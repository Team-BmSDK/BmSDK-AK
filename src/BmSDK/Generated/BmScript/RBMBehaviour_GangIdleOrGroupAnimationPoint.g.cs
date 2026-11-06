#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_GangIdleOrGroupAnimationPoint<br/>
/// (size = 948)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_GangIdleOrGroupAnimationPoint : BmSDK.BmScript.RBMBehaviour_GangMovementBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMBehaviour_GangIdleOrGroupAnimationPoint.
    /// </summary>
    public static RBMBehaviour_GangIdleOrGroupAnimationPoint DefaultObject => (RBMBehaviour_GangIdleOrGroupAnimationPoint)StaticClass().DefaultObject;

    internal RBMBehaviour_GangIdleOrGroupAnimationPoint() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_GangIdleOrGroupAnimationPoint
    /// </summary>
    public RBMBehaviour_GangIdleOrGroupAnimationPoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_GangIdleOrGroupAnimationPoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_GangIdleOrGroupAnimationPoint(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangIdleOrGroupAnimationPoint>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangIdleOrGroupAnimationPoint>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangIdleOrGroupAnimationPoint>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangIdleOrGroupAnimationPoint>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangIdleOrGroupAnimationPoint>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangIdleOrGroupAnimationPoint>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangIdleOrGroupAnimationPoint>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangIdleOrGroupAnimationPoint>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpectatorCheer;
    /// <summary>
    /// Function: SpectatorCheer
    /// </summary>
    public unsafe virtual void SpectatorCheer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpectatorCheer, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint.SpectatorCheer");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DettachFromCar;
    /// <summary>
    /// Function: DettachFromCar
    /// </summary>
    public unsafe override void DettachFromCar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DettachFromCar, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint.DettachFromCar");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachToCarSeat1;
    /// <summary>
    /// Function: AttachToCarSeat1
    /// </summary>
    public unsafe override void AttachToCarSeat1()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachToCarSeat1, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint.AttachToCarSeat1");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerOutputEvent;
    /// <summary>
    /// Function: TriggerOutputEvent
    /// </summary>
    public unsafe override void TriggerOutputEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerOutputEvent, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint.TriggerOutputEvent");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSpeakInChatter;
    /// <summary>
    /// Function: CanSpeakInChatter
    /// </summary>
    public unsafe override void CanSpeakInChatter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSpeakInChatter, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint.CanSpeakInChatter");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsChattering;
    /// <summary>
    /// Function: IsChattering
    /// </summary>
    public unsafe virtual bool IsChattering()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsChattering, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint.IsChattering");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnimationRefRot;
    /// <summary>
    /// Function: GetAnimationRefRot
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetAnimationRefRot()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimationRefRot, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint.GetAnimationRefRot");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnimationRefPos;
    /// <summary>
    /// Function: GetAnimationRefPos
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAnimationRefPos()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimationRefPos, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint.GetAnimationRefPos");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartAnimationInAnyDirection;
    /// <summary>
    /// Function: StartAnimationInAnyDirection
    /// </summary>
    public unsafe virtual bool StartAnimationInAnyDirection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAnimationInAnyDirection, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint.StartAnimationInAnyDirection");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCustomAnyDirectionAnimSettings;
    /// <summary>
    /// Function: SetCustomAnyDirectionAnimSettings
    /// </summary>
    public unsafe virtual void SetCustomAnyDirectionAnimSettings(BmSDK.FName PrevState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCustomAnyDirectionAnimSettings, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint.SetCustomAnyDirectionAnimSettings");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrevState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAnimationForPaired;
    /// <summary>
    /// Function: GetAnimationForPaired
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAnimConfig GetAnimationForPaired(BmSDK.FName AnimationName, int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimationForPaired, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint.GetAnimationForPaired");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimationName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetAnimation;
    /// <summary>
    /// Function: GetAnimation
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAnimConfig GetAnimation(BmSDK.FName AnimationName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimation, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint.GetAnimation");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimationName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetRandomAnimationFromArrayForPaired;
    /// <summary>
    /// Function: GetRandomAnimationFromArrayForPaired
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAnimConfig GetRandomAnimationFromArrayForPaired(BmSDK.TArray<BmSDK.FName> AnimationArray, int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRandomAnimationFromArrayForPaired, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint.GetRandomAnimationFromArrayForPaired");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimationArray, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetRandomAnimationFromArray;
    /// <summary>
    /// Function: GetRandomAnimationFromArray
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAnimConfig GetRandomAnimationFromArray(BmSDK.TArray<BmSDK.FName> AnimationArray)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRandomAnimationFromArray, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint.GetRandomAnimationFromArray");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimationArray, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_OnActivate;
    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint.OnActivate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// IntProperty: EventIndex
    /// </summary>
    public unsafe int EventIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// IntProperty: NumEventsLeft
    /// </summary>
    public unsafe int NumEventsLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// FloatProperty: WaitingTimeOut
    /// </summary>
    public unsafe float WaitingTimeOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// FloatProperty: DefaultWaitingTimeOut
    /// </summary>
    public unsafe float DefaultWaitingTimeOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bStartedPaired
    /// </summary>
    public unsafe bool bStartedPaired
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: CustomWaitTime
    /// </summary>
    public unsafe float CustomWaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }
}
