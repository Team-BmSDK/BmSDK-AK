#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNodePlayCustomAnim<br/>
/// (size = 328)
/// (flags = 144703634)
/// </summary>
public partial class AnimNodePlayCustomAnim : BmSDK.Engine.AnimNodeBlend, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNodePlayCustomAnim", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as AnimNodePlayCustomAnim.
    /// </summary>
    public static AnimNodePlayCustomAnim DefaultObject => (AnimNodePlayCustomAnim)StaticClass().DefaultObject;

    internal AnimNodePlayCustomAnim() { }

    /// <summary>
    /// Constructs a new AnimNodePlayCustomAnim
    /// </summary>
    public AnimNodePlayCustomAnim(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNodePlayCustomAnim Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNodePlayCustomAnim(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AnimNodePlayCustomAnim>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AnimNodePlayCustomAnim>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AnimNodePlayCustomAnim>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AnimNodePlayCustomAnim>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AnimNodePlayCustomAnim>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AnimNodePlayCustomAnim>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AnimNodePlayCustomAnim>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AnimNodePlayCustomAnim>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetRootBoneAxisOption;
    /// <summary>
    /// Function: SetRootBoneAxisOption
    /// </summary>
    public unsafe virtual void SetRootBoneAxisOption(BmSDK.Engine.AnimNodeSequence.ERootBoneAxis AxisX = default, BmSDK.Engine.AnimNodeSequence.ERootBoneAxis AxisY = default, BmSDK.Engine.AnimNodeSequence.ERootBoneAxis AxisZ = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRootBoneAxisOption, "Engine.AnimNodePlayCustomAnim.SetRootBoneAxisOption");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisY, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisZ, paramsPtr + 2);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCustomAnimNodeSeq;
    /// <summary>
    /// Function: GetCustomAnimNodeSeq
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimNodeSequence GetCustomAnimNodeSeq()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomAnimNodeSeq, "Engine.AnimNodePlayCustomAnim.GetCustomAnimNodeSeq");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimNodeSequence>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetActorAnimEndNotification;
    /// <summary>
    /// Function: SetActorAnimEndNotification
    /// </summary>
    public unsafe virtual void SetActorAnimEndNotification(bool bNewStatus)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetActorAnimEndNotification, "Engine.AnimNodePlayCustomAnim.SetActorAnimEndNotification");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewStatus, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCustomAnim;
    /// <summary>
    /// Function: SetCustomAnim
    /// </summary>
    public unsafe virtual void SetCustomAnim(BmSDK.FName AnimName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCustomAnim, "Engine.AnimNodePlayCustomAnim.SetCustomAnim");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopCustomAnim;
    /// <summary>
    /// Function: StopCustomAnim
    /// </summary>
    public unsafe virtual void StopCustomAnim(float BlendOutTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopCustomAnim, "Engine.AnimNodePlayCustomAnim.StopCustomAnim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendOutTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_PlayCustomAnimByDuration;
    /// <summary>
    /// Function: PlayCustomAnimByDuration
    /// </summary>
    public unsafe virtual void PlayCustomAnimByDuration(BmSDK.FName AnimName, float Duration, float BlendInTime = default, float BlendOutTime = default, bool bLooping = default, bool bOverride = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCustomAnimByDuration, "Engine.AnimNodePlayCustomAnim.PlayCustomAnimByDuration");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendInTime, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendOutTime, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLooping, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverride, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_PlayCustomAnim;
    /// <summary>
    /// Function: PlayCustomAnim
    /// </summary>
    public unsafe virtual float PlayCustomAnim(BmSDK.FName AnimName, float Rate, float BlendInTime = default, float BlendOutTime = default, bool bLooping = default, bool bOverride = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCustomAnim, "Engine.AnimNodePlayCustomAnim.PlayCustomAnim");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rate, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendInTime, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendOutTime, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLooping, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverride, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 28);
    }

    /// <summary>
    /// BoolProperty: bIsPlayingCustomAnim
    /// </summary>
    public unsafe bool bIsPlayingCustomAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
    }

    /// <summary>
    /// FloatProperty: CustomPendingBlendOutTime
    /// </summary>
    public unsafe float CustomPendingBlendOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }
}
