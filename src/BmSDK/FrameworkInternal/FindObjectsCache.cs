namespace BmSDK.Framework;

/// <summary>
/// Indexes every live wrapper by its managed type, for <see cref="Game.FindObjects{T}"/>.
/// </summary>
/// <remarks>
/// Each wrapper sits in one bucket, the list for its exact type, and remembers its index there
/// (<see cref="GameObject.CacheBucket"/>, <see cref="GameObject.CacheIndex"/>), so registering and
/// unregistering an object allocates nothing and removal is a swap with the bucket's last entry. The
/// game creates and destroys tens of thousands of objects while streaming the city, and the earlier
/// design (a linked-list node per type in the object's class chain, plus an array of them and a
/// dictionary entry) left that many long-lived allocations to the garbage collector, which showed up
/// as gen1 pauses of 20-40 ms (Team-BmSDK/BmSDK-AK#13). A query gathers the buckets whose type derives
/// from T once, and again whenever a new type appears.
/// </remarks>
internal static class FindObjectsCache
{
    private static readonly Dictionary<Type, List<GameObject>> s_buckets = [];
    private static readonly Dictionary<Type, List<GameObject>[]> s_queryBuckets = [];
    private static int s_bucketsVersion;
    private static int s_queryVersion = -1;

    /// <summary>
    /// Enumerates the live objects of type T. Objects created or destroyed while enumerating may be
    /// missed, as before.
    /// </summary>
    public static IEnumerable<T> FindObjects<T>()
        where T : GameObject
    {
        foreach (var bucket in BucketsFor(typeof(T)))
        {
            for (var i = 0; i < bucket.Count; i++)
            {
                yield return (T)bucket[i];
            }
        }
    }

    private static List<GameObject>[] BucketsFor(Type type)
    {
        if (s_queryVersion != s_bucketsVersion)
        {
            s_queryBuckets.Clear();
            s_queryVersion = s_bucketsVersion;
        }

        if (!s_queryBuckets.TryGetValue(type, out var buckets))
        {
            var list = new List<List<GameObject>>();
            foreach (var (bucketType, bucket) in s_buckets)
            {
                if (type.IsAssignableFrom(bucketType))
                {
                    list.Add(bucket);
                }
            }

            buckets = [.. list];
            s_queryBuckets[type] = buckets;
        }

        return buckets;
    }

    public static void Register(GameObject obj)
    {
        // Omit CDOs, invalid objects from type cache
        if (!obj.IsValid || obj.IsClassDefaultObject || obj.CacheBucket != null)
        {
            return;
        }

        var type = obj.GetType();
        if (!s_buckets.TryGetValue(type, out var bucket))
        {
            bucket = [];
            s_buckets[type] = bucket;
            s_bucketsVersion++;
        }

        obj.CacheBucket = bucket;
        obj.CacheIndex = bucket.Count;
        bucket.Add(obj);
    }

    public static void Unregister(GameObject obj)
    {
        var bucket = obj.CacheBucket;
        if (bucket == null)
        {
            return;
        }

        // Swap the last entry into the hole, so removal is O(1) and nothing is allocated.
        var index = obj.CacheIndex;
        var last = bucket[^1];
        bucket[index] = last;
        last.CacheIndex = index;
        bucket.RemoveAt(bucket.Count - 1);

        obj.CacheBucket = null;
        obj.CacheIndex = -1;
    }
}
