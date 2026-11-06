#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_AbandonedVehicleAnimationPoint<br/>
/// (size = 1128)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_AbandonedVehicleAnimationPoint : BmSDK.BmScript.RBMBehaviour_GangMovementBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMBehaviour_AbandonedVehicleAnimationPoint.
    /// </summary>
    public static RBMBehaviour_AbandonedVehicleAnimationPoint DefaultObject => (RBMBehaviour_AbandonedVehicleAnimationPoint)StaticClass().DefaultObject;

    internal RBMBehaviour_AbandonedVehicleAnimationPoint() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_AbandonedVehicleAnimationPoint
    /// </summary>
    public RBMBehaviour_AbandonedVehicleAnimationPoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_AbandonedVehicleAnimationPoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_AbandonedVehicleAnimationPoint(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_AbandonedVehicleAnimationPoint>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_AbandonedVehicleAnimationPoint>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_AbandonedVehicleAnimationPoint>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_AbandonedVehicleAnimationPoint>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_AbandonedVehicleAnimationPoint>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_AbandonedVehicleAnimationPoint>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_AbandonedVehicleAnimationPoint>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_AbandonedVehicleAnimationPoint>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MovingCarOver;
    /// <summary>
    /// Function: MovingCarOver
    /// </summary>
    public unsafe virtual void MovingCarOver()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MovingCarOver, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.MovingCarOver");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WarnMovingCar;
    /// <summary>
    /// Function: WarnMovingCar
    /// </summary>
    public unsafe virtual void WarnMovingCar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WarnMovingCar, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.WarnMovingCar");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSiren;
    /// <summary>
    /// Function: StartSiren
    /// </summary>
    public unsafe virtual void StartSiren()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSiren, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.StartSiren");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CrackObjectRightHand;
    /// <summary>
    /// Function: CrackObjectRightHand
    /// </summary>
    public unsafe virtual void CrackObjectRightHand()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CrackObjectRightHand, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.CrackObjectRightHand");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CrackObject;
    /// <summary>
    /// Function: CrackObject
    /// </summary>
    public unsafe override void CrackObject()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CrackObject, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.CrackObject");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExplodeMolotov;
    /// <summary>
    /// Function: ExplodeMolotov
    /// </summary>
    public unsafe override void ExplodeMolotov()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExplodeMolotov, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.ExplodeMolotov");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SmashDriversPassengerWindow;
    /// <summary>
    /// Function: SmashDriversPassengerWindow
    /// </summary>
    public unsafe virtual void SmashDriversPassengerWindow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SmashDriversPassengerWindow, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.SmashDriversPassengerWindow");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SmashDriversWindow;
    /// <summary>
    /// Function: SmashDriversWindow
    /// </summary>
    public unsafe virtual void SmashDriversWindow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SmashDriversWindow, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.SmashDriversWindow");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CrackWindscreen;
    /// <summary>
    /// Function: CrackWindscreen
    /// </summary>
    public unsafe virtual void CrackWindscreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CrackWindscreen, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.CrackWindscreen");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CarOnRoof;
    /// <summary>
    /// Function: CarOnRoof
    /// </summary>
    public unsafe virtual void CarOnRoof()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CarOnRoof, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.CarOnRoof");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CarOnSide;
    /// <summary>
    /// Function: CarOnSide
    /// </summary>
    public unsafe virtual void CarOnSide()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CarOnSide, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.CarOnSide");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CarToLoopAnim;
    /// <summary>
    /// Function: CarToLoopAnim
    /// </summary>
    public unsafe virtual void CarToLoopAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CarToLoopAnim, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.CarToLoopAnim");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CarToAnim;
    /// <summary>
    /// Function: CarToAnim
    /// </summary>
    public unsafe virtual void CarToAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CarToAnim, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.CarToAnim");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CarToPhysics;
    /// <summary>
    /// Function: CarToPhysics
    /// </summary>
    public unsafe virtual void CarToPhysics()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CarToPhysics, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.CarToPhysics");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Cheer;
    /// <summary>
    /// Function: Cheer
    /// </summary>
    public unsafe virtual void Cheer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Cheer, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.Cheer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpectatorCheer;
    /// <summary>
    /// Function: SpectatorCheer
    /// </summary>
    public unsafe virtual void SpectatorCheer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpectatorCheer, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.SpectatorCheer");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DettachFromCar, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.DettachFromCar");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachToCarSeat1, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.AttachToCarSeat1");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerOutputEvent, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.TriggerOutputEvent");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlayWaitingAnimation;
    /// <summary>
    /// Function: CanPlayWaitingAnimation
    /// </summary>
    public unsafe virtual bool CanPlayWaitingAnimation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayWaitingAnimation, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.CanPlayWaitingAnimation");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FastExitBuddies;
    /// <summary>
    /// Function: FastExitBuddies
    /// </summary>
    public unsafe virtual void FastExitBuddies()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FastExitBuddies, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.FastExitBuddies");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RiotExitBehaviour;
    /// <summary>
    /// Function: RiotExitBehaviour
    /// </summary>
    public unsafe override void RiotExitBehaviour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RiotExitBehaviour, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.RiotExitBehaviour");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RiotHandleSpookedBy;
    /// <summary>
    /// Function: RiotHandleSpookedBy
    /// </summary>
    public unsafe override bool RiotHandleSpookedBy(BmSDK.Engine.Actor Threat, bool bAlertNeighbours = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RiotHandleSpookedBy, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.RiotHandleSpookedBy");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Threat, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAlertNeighbours, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetEvadeVehicleType;
    /// <summary>
    /// Function: GetEvadeVehicleType
    /// </summary>
    public unsafe override BmSDK.BmGame.RGameInfo.EEvadeVehicleType GetEvadeVehicleType(BmSDK.Engine.Actor V, float CarSpeed, bool bZap)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEvadeVehicleType, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.GetEvadeVehicleType");
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CarSpeed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bZap, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EEvadeVehicleType>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_OnDeactivate;
    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeactivate, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.OnDeactivate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnActivate;
    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint.OnActivate");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bInTransOut
    /// </summary>
    public unsafe bool bInTransOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 924); }
    }

    /// <summary>
    /// BoolProperty: bStartedPaired
    /// </summary>
    public unsafe bool bStartedPaired
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 924); }
    }

    /// <summary>
    /// IntProperty: EventIndex
    /// </summary>
    public unsafe int EventIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// IntProperty: NumEventsLeft
    /// </summary>
    public unsafe int NumEventsLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ObjectProperty: Car
    /// </summary>
    public unsafe BmSDK.BmGame.RAbandonedVehicle Car
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAbandonedVehicle>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// ObjectProperty: DestinationCarActor
    /// </summary>
    public unsafe BmSDK.BmScript.RGangInteractPointAbandonedVehicle DestinationCarActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGangInteractPointAbandonedVehicle>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// IntProperty: CurrentBuddies
    /// </summary>
    public unsafe int CurrentBuddies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: IdleTime
    /// </summary>
    public unsafe float IdleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// StructProperty: WaitingTransId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId WaitingTransId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 960);

    /// <summary>
    /// StructProperty: CarAnimDetail
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGangInteractPointAbandonedVehicleBase.FCarAnimationDetails CarAnimDetail
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGangInteractPointAbandonedVehicleBase.FCarAnimationDetails>(Ptr + 964);

    /// <summary>
    /// StructProperty: CarMultiStageInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGangInteractPointAbandonedVehicleBase.FMultiStageAnim CarMultiStageInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGangInteractPointAbandonedVehicleBase.FMultiStageAnim>(Ptr + 1024);
}
