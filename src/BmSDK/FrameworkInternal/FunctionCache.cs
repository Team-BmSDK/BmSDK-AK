namespace BmSDK.Framework;

/// <summary>
/// Caches the UFunction looked up by each generated function wrapper.
/// </summary>
/// <remarks>
/// Every generated call used to run <c>StaticFindObject</c> on its function's path string.
/// Each wrapper now keeps the result in its own static field. A wrapper is invalidated
/// (<see cref="GameObject.Ptr"/> set to zero) when its object is destroyed, so a stale
/// entry is looked up again rather than used.
/// </remarks>
internal static class FunctionCache
{
    public static Function Get(ref Function? slot, string path)
    {
        var func = slot;
        if (func is not null && func.Ptr != IntPtr.Zero)
        {
            return func;
        }

        return slot = GameObject.StaticFindObjectChecked<Function>(
            Function.StaticClass(),
            null,
            path,
            true
        );
    }
}
