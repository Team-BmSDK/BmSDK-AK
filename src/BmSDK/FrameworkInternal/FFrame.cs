using BmSDK.Framework;

namespace BmSDK;

[StructLayout(LayoutKind.Explicit)]
internal unsafe record struct FFrame
{
    [FieldOffset(0xC)]
    public IntPtr Node;

    [FieldOffset(0x14)]
    public IntPtr Object;

    [FieldOffset(0x1C)]
    public IntPtr Code;

    [FieldOffset(0x24)]
    public IntPtr Locals;

    [FieldOffset(0x2C)]
    public IntPtr PreviousFrame;

    [FieldOffset(0x34)]
    public IntPtr OutParms;

    public readonly Function GetFunction()
    {
        var nodePtr = Node;
        return MarshalUtil.ToManaged<Function>(&nodePtr);
    }

    /// <summary>
    /// Marshals this frame's parameters to managed values of the given types, in declaration order.
    /// </summary>
    public readonly object?[] ParamsToManaged(Type[] managedTypes)
    {
        var localsPtr = Locals;
        var offsets = GetFunction().GetParamOffsets();

        var values = new object?[offsets.Length];
        for (var i = 0; i < offsets.Length; i++)
        {
            values[i] = MarshalUtil.ToManaged(localsPtr + offsets[i], managedTypes[i]);
        }

        return values;
    }
}
