#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveInstance_EjectIntoFirefly<br/>
/// (size = 984)
/// (flags = 10485778)
/// </summary>
public partial class RSpecialMoveInstance_EjectIntoFirefly : BmSDK.BmGame.RSpecialMoveInstance, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveInstance_EjectIntoFirefly", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMoveInstance_EjectIntoFirefly.
    /// </summary>
    public static RSpecialMoveInstance_EjectIntoFirefly DefaultObject => (RSpecialMoveInstance_EjectIntoFirefly)StaticClass().DefaultObject;

    internal RSpecialMoveInstance_EjectIntoFirefly() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_EjectIntoFirefly
    /// </summary>
    public RSpecialMoveInstance_EjectIntoFirefly(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_EjectIntoFirefly(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_EjectIntoFirefly>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_EjectIntoFirefly>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_EjectIntoFirefly>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_EjectIntoFirefly>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_EjectIntoFirefly>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_EjectIntoFirefly>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_EjectIntoFirefly>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_EjectIntoFirefly>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CancelSpecialMove;
    /// <summary>
    /// Function: CancelSpecialMove
    /// </summary>
    public unsafe override void CancelSpecialMove(BmSDK.BmGame.RSpecialMoveConfig NextSpecialMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelSpecialMove, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.CancelSpecialMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextSpecialMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishSpecialMove;
    /// <summary>
    /// Function: FinishSpecialMove
    /// </summary>
    public unsafe override void FinishSpecialMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishSpecialMove, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.FinishSpecialMove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireFireflyEvent;
    /// <summary>
    /// Function: FireFireflyEvent
    /// </summary>
    public unsafe virtual void FireFireflyEvent(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireFireflyEvent, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.FireFireflyEvent");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AutomaticTutorialTextAllowed;
    /// <summary>
    /// Function: AutomaticTutorialTextAllowed
    /// </summary>
    public unsafe override bool AutomaticTutorialTextAllowed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutomaticTutorialTextAllowed, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.AutomaticTutorialTextAllowed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override void GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleAction;
    /// <summary>
    /// Function: HandleAction
    /// </summary>
    public unsafe override void HandleAction(BmSDK.FName actionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleAction, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.HandleAction");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyNoMorePunches;
    /// <summary>
    /// Function: NotifyNoMorePunches
    /// </summary>
    public unsafe virtual void NotifyNoMorePunches()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyNoMorePunches, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.NotifyNoMorePunches");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPunchConnected;
    /// <summary>
    /// Function: NotifyPunchConnected
    /// </summary>
    public unsafe virtual void NotifyPunchConnected()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPunchConnected, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.NotifyPunchConnected");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFFClearanceInDirection;
    /// <summary>
    /// Function: GetFFClearanceInDirection
    /// </summary>
    public unsafe virtual float GetFFClearanceInDirection(System.Numerics.Vector3 Dir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFFClearanceInDirection, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.GetFFClearanceInDirection");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_TriggerEscapeFinalAnim;
    /// <summary>
    /// Function: TriggerEscapeFinalAnim
    /// </summary>
    public unsafe virtual void TriggerEscapeFinalAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerEscapeFinalAnim, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.TriggerEscapeFinalAnim");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerEscapeDialogue;
    /// <summary>
    /// Function: TriggerEscapeDialogue
    /// </summary>
    public unsafe virtual void TriggerEscapeDialogue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerEscapeDialogue, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.TriggerEscapeDialogue");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateCineCamLookat;
    /// <summary>
    /// Function: UpdateCineCamLookat
    /// </summary>
    public unsafe virtual void UpdateCineCamLookat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCineCamLookat, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.UpdateCineCamLookat");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerPunch;
    /// <summary>
    /// Function: TriggerPunch
    /// </summary>
    public unsafe virtual void TriggerPunch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPunch, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.TriggerPunch");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForWorldCollision;
    /// <summary>
    /// Function: CheckForWorldCollision
    /// </summary>
    public unsafe virtual bool CheckForWorldCollision(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, System.Numerics.Vector3 CollisionCheckExtent, out System.Numerics.Vector3 HitLoc, out System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForWorldCollision, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.CheckForWorldCollision");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionCheckExtent, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 48);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_PlayAdditivePunchAnim;
    /// <summary>
    /// Function: PlayAdditivePunchAnim
    /// </summary>
    public unsafe virtual void PlayAdditivePunchAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAdditivePunchAnim, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.PlayAdditivePunchAnim");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerSlavedAnim;
    /// <summary>
    /// Function: TriggerSlavedAnim
    /// </summary>
    public unsafe virtual void TriggerSlavedAnim(BmSDK.FName AnimName, bool useIdleFromConfig, float TransitionDurationScale, BmSDK.BmGame.RAnimUtil_PosePlayer.EAnimTransitionType transType, BmSDK.FName CustomIdleName, bool bQueued = default, bool bNoCameraAnim = default, bool bBlendFromPreviousCineCam = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSlavedAnim, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.TriggerSlavedAnim");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(useIdleFromConfig, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(transType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdleName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bQueued, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoCameraAnim, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBlendFromPreviousCineCam, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LandingAnimStarted;
    /// <summary>
    /// Function: LandingAnimStarted
    /// </summary>
    public unsafe virtual void LandingAnimStarted(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId QueuedAnimID, float TimeLeftOver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LandingAnimStarted, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.LandingAnimStarted");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueuedAnimID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLandingArea;
    /// <summary>
    /// Function: ClearLandingArea
    /// </summary>
    public unsafe virtual void ClearLandingArea(System.Numerics.Vector3 landingLoc, float Radius)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLandingArea, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.ClearLandingArea");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(landingLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SnapToRoad;
    /// <summary>
    /// Function: SnapToRoad
    /// </summary>
    public unsafe virtual float SnapToRoad(System.Numerics.Vector3 InLoc, out System.Numerics.Vector3 outLoc, out System.Numerics.Vector3 outRefRot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SnapToRoad, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.SnapToRoad");
        byte* paramsPtr = stackalloc byte[180];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLoc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outLoc, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outRefRot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outRefRot, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        outRefRot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_ChooseLandingAnim;
    /// <summary>
    /// Function: ChooseLandingAnim
    /// </summary>
    public unsafe virtual void ChooseLandingAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChooseLandingAnim, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.ChooseLandingAnim");
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateFFMaterials;
    /// <summary>
    /// Function: UpdateFFMaterials
    /// </summary>
    public unsafe virtual void UpdateFFMaterials()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFFMaterials, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.UpdateFFMaterials");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerSpecialMove;
    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe override void TriggerSpecialMove(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSpecialMove, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.TriggerSpecialMove");
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StoppedSkidding;
    /// <summary>
    /// Function: StoppedSkidding
    /// </summary>
    public unsafe virtual void StoppedSkidding()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StoppedSkidding, "BmGame.RSpecialMoveInstance_EjectIntoFirefly.StoppedSkidding");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: MyConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig_EjectIntoFirefly MyConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig_EjectIntoFirefly>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: FF
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnBossFireflyBase FF
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossFireflyBase>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// FloatProperty: IdleTime
    /// </summary>
    public unsafe float IdleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bExiting
    /// </summary>
    public unsafe bool bExiting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bPunchQueued
    /// </summary>
    public unsafe bool bPunchQueued
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredEscapeDialogue
    /// </summary>
    public unsafe bool bTriggeredEscapeDialogue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bDrawLandingDbg
    /// </summary>
    public unsafe bool bDrawLandingDbg
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bNoMorePunches
    /// </summary>
    public unsafe bool bNoMorePunches
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bLanded
    /// </summary>
    public unsafe bool bLanded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// IntProperty: NumPunchesSoFar
    /// </summary>
    public unsafe int NumPunchesSoFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// StructProperty: ReferenceLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ReferenceLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 904);

    /// <summary>
    /// StructProperty: ReferenceRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator ReferenceRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 916);

    /// <summary>
    /// NameProperty: landingAnimName
    /// </summary>
    public unsafe BmSDK.FName landingAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// StructProperty: beatdownRefLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 beatdownRefLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 936);

    /// <summary>
    /// StructProperty: beatdownRefRot
    /// </summary>
    public unsafe ref BmSDK.Rotator beatdownRefRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 948);

    /// <summary>
    /// FloatProperty: FOV_base
    /// </summary>
    public unsafe float FOV_base
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// FloatProperty: FOV_extra
    /// </summary>
    public unsafe float FOV_extra
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// StructProperty: bmToFF2d
    /// </summary>
    public unsafe ref System.Numerics.Vector3 bmToFF2d
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 968);

    /// <summary>
    /// FloatProperty: timeSpentNotSpeakingAfterDialogue
    /// </summary>
    public unsafe float timeSpentNotSpeakingAfterDialogue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }
}
