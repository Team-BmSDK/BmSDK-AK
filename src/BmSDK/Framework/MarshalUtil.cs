using System.Reflection;

namespace BmSDK.Framework;

/// <summary>
/// Provides utility methods for converting data between unmanaged and managed
/// representations.
/// </summary>
public static unsafe class MarshalUtil
{
    [StructLayout(LayoutKind.Sequential)]
    private struct FScriptInterface
    {
        public IntPtr ObjectPointer;
        public IntPtr InterfacePointer;
    }

    private static readonly Dictionary<IntPtr, GameObject> s_managedObjects = [];

    /// <summary>
    /// Marshals unmanaged data to managed, then returns it.
    /// </summary>
    public static TManaged ToManaged<TManaged>(void* data)
    {
        // Try to copy memory directly (for struct, primitive types)
        if (typeof(TManaged).IsValueType)
        {
            return MemUtil.Blit<TManaged>(data);
        }
        else if (
            typeof(TManaged).IsGenericType
            && typeof(TManaged).GetGenericTypeDefinition() == typeof(TArray<>)
        )
        {
            // Create new TArray wrapper every time - duplicates will still refer to the same native object.
            var instance = Guard.NotNull(
                Activator.CreateInstance(
                    typeof(TManaged),
                    BindingFlags.Instance | BindingFlags.NonPublic,
                    null,
                    [(IntPtr)data],
                    null
                ),
                $"Couldn't create an instance of array 0x{new IntPtr(data):X}"
            );

            return (TManaged)instance;
        }
        else if (
            typeof(TManaged).IsAssignableTo(typeof(GameObject))
            || typeof(TManaged).IsAssignableTo(typeof(Interface))
        )
        {
            var objPtr = MemUtil.Blit<IntPtr>(data);

            // Handle null object pointers.
            if (objPtr == IntPtr.Zero)
            {
                return (TManaged)(object)null!;
            }

            // Get or create a managed wrapper for the UObject
            return (TManaged)(object)Guard.NotNull(GetOrCreateWrapper(objPtr));
        }

        throw new NotImplementedException(
            $"Marshaling not (fully) implemented for type {typeof(TManaged).Name}"
        );
    }

    public static TManaged ToManaged<TManaged>(IntPtr data) =>
        ToManaged<TManaged>(data.ToPointer());

    /// <summary>
    /// Boxing adapters over the generic marshallers, one instantiation per type, so marshalling by
    /// <see cref="Type"/> (redirect arguments and results) costs a dictionary lookup and a delegate call
    /// rather than reflection on every call.
    /// </summary>
    private static class Boxed<T>
    {
        public static object? To(IntPtr data) => ToManaged<T>(data);

        public static void From(object? value, IntPtr data) => ToUnmanaged((T)value!, data);
    }

    private static readonly Dictionary<Type, Func<IntPtr, object?>> s_toManagedByType = [];
    private static readonly Dictionary<Type, Action<object?, IntPtr>> s_toUnmanagedByType = [];

    /// <summary>Marshals unmanaged data to a managed value of a type only known at run time.</summary>
    public static object? ToManaged(IntPtr data, Type managedType)
    {
        if (!s_toManagedByType.TryGetValue(managedType, out var marshal))
        {
            marshal = typeof(Boxed<>)
                .MakeGenericType(managedType)
                .GetMethod(nameof(Boxed<int>.To), BindingFlags.Public | BindingFlags.Static)!
                .CreateDelegate<Func<IntPtr, object?>>();
            s_toManagedByType[managedType] = marshal;
        }

        return marshal(data);
    }

    /// <summary>
    /// Marshals a managed object to native, then copies it into an existing buffer.
    /// </summary>
    public static void ToUnmanaged<TManaged>(TManaged value, void* data)
    {
        // Try to copy memory directly (for struct, primitive types)
        if (typeof(TManaged).IsValueType)
        {
            MemUtil.Blit(value, data);
            return;
        }
        else if (
            typeof(TManaged).IsGenericType
            && typeof(TManaged).GetGenericTypeDefinition() == typeof(TArray<>)
        )
        {
            var dataSize = sizeof(TArray<TManaged>.NativeData);

            if (value is null || data == null)
            {
                // Clear native struct memory
                NativeMemory.Clear(data, (nuint)dataSize);
                return;
            }

            // Copy native struct memory
            var sourcePtr = ((IArray)value).Ptr;
            Buffer.MemoryCopy(sourcePtr.ToPointer(), data, dataSize, dataSize);
            return;
        }
        else if (typeof(TManaged).IsAssignableTo(typeof(GameObject)))
        {
            // Handle null object references.
            if (value is null)
            {
                ToUnmanaged(IntPtr.Zero, data);
                return;
            }

            // We already have a pointer to this object's native instance, so just assign it.
            ToUnmanaged(((GameObject)(object)value!).Ptr, data);
            return;
        }

        throw new NotImplementedException(
            $"Marshaling not (fully) implemented for type {typeof(TManaged).Name}"
        );
    }

    public static void ToUnmanaged<TManaged>(TManaged value, IntPtr data) =>
        ToUnmanaged(value, data.ToPointer());

    /// <summary>Marshals a managed value of a type only known at run time into an existing buffer.</summary>
    public static void ToUnmanaged(object? value, IntPtr data, Type managedType)
    {
        if (!s_toUnmanagedByType.TryGetValue(managedType, out var marshal))
        {
            marshal = typeof(Boxed<>)
                .MakeGenericType(managedType)
                .GetMethod(nameof(Boxed<int>.From), BindingFlags.Public | BindingFlags.Static)!
                .CreateDelegate<Action<object?, IntPtr>>();
            s_toUnmanagedByType[managedType] = marshal;
        }

        marshal(value, data);
    }

    /// <summary>
    /// Gets the managed wrapper instance corresponding to the given unmanaged pointer.
    /// </summary>
    /// <remarks>
    /// This function is useful when working with native redirects. It allows one to
    /// easily convert this-pointers to the actual instances in BmSDK.
    /// </remarks>
    /// <param name="objPtr">Pointer to unmanaged object</param>
    /// <returns>Managed wrapper of unmanaged pointer</returns>
    internal static GameObject GetOrCreateWrapper(IntPtr objPtr)
    {
        // Get cached object wrapepr
        if (s_managedObjects.TryGetValue(objPtr, out var existingObj))
        {
            return existingObj;
        }

        // Calculate memory address of the object's class
        var classPtr = *(IntPtr*)(objPtr + GameDefine.MemberOffsets.Object__Class).ToPointer();
        var classIndexPtr = classPtr + GameDefine.MemberOffsets.Object__ObjectInternalInteger;
        var classFlagsPtr = classPtr + GameDefine.MemberOffsets.Class__ClassFlags;

        // Not clear yet why this happens, but maybe we don't need to worry about it.
        var classIndex = *(int*)classIndexPtr.ToPointer();
        if (classIndex < 1)
        {
            return CreateManagedWrapper(objPtr, s_classWrapperType ??= MakeWrapperType(typeof(Class)));
        }

        // Get the managed type (and its constructor) through the class object, worked out once per
        // class: every object the game creates comes through here, and building the class path
        // string each time was a large share of the garbage behind the streaming stutter (#13).
        if (!s_wrapperTypes.TryGetValue(classPtr, out var wrapperType))
        {
            var classFlags = *(Class.EClassFlags*)classFlagsPtr.ToPointer();
            var managedType = !classFlags.HasFlag(Class.EClassFlags.CLASS_Interface)
                ? GetManagedTypeForClassPtr(classPtr)
                : typeof(GameObject); // Wrap CDOs of interfaces as GameObject
            wrapperType = MakeWrapperType(managedType);
            s_wrapperTypes[classPtr] = wrapperType;
        }

        // Wrap this object in a managed instance
        return CreateManagedWrapper(objPtr, wrapperType);
    }

    private sealed record WrapperType(Type ManagedType, Func<GameObject> Factory);

    /// <summary>Wrapper type and constructor per UClass; an entry is dropped when its class is destroyed.</summary>
    private static readonly Dictionary<IntPtr, WrapperType> s_wrapperTypes = [];
    private static WrapperType? s_classWrapperType;

    private static WrapperType MakeWrapperType(Type managedType)
    {
        var ctor = managedType.GetConstructor(
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
            Type.EmptyTypes
        );
        Guard.NotNull(ctor, $"Managed type {managedType.Name} has no parameterless constructor");

        var factory = System.Linq.Expressions.Expression
            .Lambda<Func<GameObject>>(System.Linq.Expressions.Expression.New(ctor))
            .Compile();
        return new WrapperType(managedType, factory);
    }

    /// <summary>
    /// Gets the managed type for the given unmanaged class. Classes that didn't exist at generation
    /// time fall back to the closest known type in their super chain.
    /// </summary>
    internal static Type GetManagedTypeForClassPtr(IntPtr classPtr)
    {
        var classPath = GetClassPath(classPtr);

        if (StaticInit.TryGetManagedTypeForClassPath(classPath, out var managedType))
        {
            return managedType;
        }

        // Class didn't exist at generation time, so walk up the super chain until we find one that did.
        for (
            var superPtr = GetSuperStruct(classPtr);
            superPtr != IntPtr.Zero;
            superPtr = GetSuperStruct(superPtr)
        )
        {
            if (StaticInit.TryGetManagedTypeForClassPath(GetClassPath(superPtr), out var superType))
            {
                Debug.LogWarning(
                    $"Couldn't find managed type for class '{classPath}', falling back to {superType.FullName}"
                );
                return superType;
            }
        }

        Debug.LogWarning($"Couldn't find managed type for class '{classPath}'");
        return typeof(GameObject);
    }

    private static IntPtr GetSuperStruct(IntPtr structPtr) =>
        *(IntPtr*)(structPtr + GameDefine.MemberOffsets.Struct__SuperStruct).ToPointer();

    private static GameObject CreateManagedWrapper(IntPtr objPtr, WrapperType wrapperType)
    {
        // Create a new managed object
        var newObj = s_managedObjects[objPtr] = wrapperType.Factory();
        newObj.Ptr = objPtr;
        FindObjectsCache.Register(newObj);
        return newObj;
    }

    private static string GetClassPath(IntPtr classPtr)
    {
        // Fetch class name.
        var className = *(FName*)(classPtr + GameDefine.MemberOffsets.Object__Name).ToPointer();

        // Fetch outer name.
        var classOuterPtr = *(IntPtr*)(classPtr + GameDefine.MemberOffsets.Object__Outer).ToPointer();
        var classOuterName = *(FName*)
            (classOuterPtr + GameDefine.MemberOffsets.Object__Name).ToPointer();

        return $"{classOuterName}.{className}";
    }

    /// <summary>
    /// Returns a ref to unmanaged data at the specified address.
    /// </summary>
    internal static ref T AsRef<T>(IntPtr data)
        where T : unmanaged => ref *(T*)data.ToPointer();

    internal static int GetSizeUnmanaged<TManaged>()
    {
        // Try to use managed size directly (for struct, primitive types)
        if (typeof(TManaged).IsValueType)
        {
            return Marshal.SizeOf<TManaged>();
        }
        // Return UE3 internal interface wrapper size
        else if (typeof(TManaged).IsInterface)
        {
            return sizeof(FScriptInterface);
        }
        // Return size of UObject pointer
        else if (typeof(TManaged).IsAssignableTo(typeof(GameObject)))
        {
            return sizeof(IntPtr);
        }

        throw new NotImplementedException(
            $"Marshaling not (fully) implemented for type {typeof(TManaged).Name}"
        );
    }

    internal static void DestroyManagedWrapper(IntPtr objPtr)
    {
        if (s_managedObjects.TryGetValue(objPtr, out var obj))
        {
            FindObjectsCache.Unregister(obj);

            // Detach all script components
            if (obj.HasScriptComponents)
            {
                obj.DetachAllScriptComponents();
            }

            // A class is going away: its address may be reused by another class later.
            if (obj is Class)
            {
                s_wrapperTypes.Remove(objPtr);
            }

            // Mark managed wrapper as invalid
            obj.Ptr = IntPtr.Zero;

            // Remove managed wrapper from storage
            s_managedObjects.Remove(objPtr);
        }
    }
}
