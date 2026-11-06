using BmSDK.Framework;

namespace BmSDK;

public partial class Function
{
    [Flags]
    public enum EFunctionFlags
    {
        FUNC_Defined = 0x2,
        FUNC_Iterator = 0x4,
        FUNC_Net = 0x40,
        FUNC_NetReliable = 0x80,
        FUNC_Simulated = 0x100,
        FUNC_Native = 0x400,
        FUNC_Event = 0x800,
        FUNC_Operator = 0x1000,
        FUNC_Static = 0x2000,
        FUNC_NetServer = 0x00200000,
        FUNC_NetClient = 0x01000000,
    }

    public bool IsStatic => FunctionFlags.HasFlag(EFunctionFlags.FUNC_Static);

    /// <summary>Which of BmSDK's lifecycle hooks this function drives, if any.</summary>
    internal enum Lifecycle : byte
    {
        None,
        Init,
        EnterMenu,
        EnterGame,
        Tick,
    }

    // Filled in once per UFunction by the ProcessInternal detour, so the hot path never builds a path
    // string or looks redirects up by name. A wrapper dies with its object, so nothing here goes stale.
    internal string? CachedPath;
    internal Lifecycle LifecycleKind;
    internal int RedirectGeneration = -1;
    internal bool MayRedirect;

    // Cached parameter layout for redirects (see FFrame.ParamsToManaged and RedirectCall.RunOriginal).
    internal int[]? ParamOffsets;
    internal int ParamsBytes = -1;
    internal bool ReturnResolved;
    internal int ReturnOffset;
    internal int ReturnSize;

    internal int[] GetParamOffsets() =>
        ParamOffsets ??= EnumerateParams().Select(p => (int)p.Offset).ToArray();

    internal int GetParamsBytes() =>
        ParamsBytes >= 0 ? ParamsBytes : ParamsBytes = EnumerateParams().Sum(p => p.ElementSize);

    internal void ResolveReturn()
    {
        if (ReturnResolved)
        {
            return;
        }

        var ret = GetReturnParam();
        ReturnOffset = ret?.Offset ?? 0;
        ReturnSize = ret?.ElementSize ?? 0;
        ReturnResolved = true;
    }

    /// <summary>
    /// Property: FunctionFlags
    /// </summary>
    public unsafe EFunctionFlags FunctionFlags
    {
        get => MarshalUtil.ToManaged<EFunctionFlags>(Ptr + 164);
        set => MarshalUtil.ToUnmanaged(value, (Ptr + 164).ToPointer());
    }

    /// <summary>
    /// Property: iNative
    /// </summary>
    public unsafe ushort iNative
    {
        get => MarshalUtil.ToManaged<ushort>(Ptr + 168);
        set => MarshalUtil.ToUnmanaged(value, (Ptr + 168).ToPointer());
    }

    public IEnumerable<Property> EnumerateParams()
    {
        return EnumerateFields()
            .OfType<Property>()
            .Where(prop =>
                prop.PropertyFlags.HasFlag(Property.EPropertyFlags.CPF_Parm)
                && !prop.PropertyFlags.HasFlag(Property.EPropertyFlags.CPF_ReturnParm)
            );
    }

    public Property? GetReturnParam() =>
        EnumerateFields()
            .OfType<Property>()
            .FirstOrDefault(prop =>
                prop.PropertyFlags.HasFlag(Property.EPropertyFlags.CPF_ReturnParm)
            );
}
