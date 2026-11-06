#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveInstance_RelativeAnimMove<br/>
/// (size = 988)
/// (flags = 144703634)
/// </summary>
public partial class RSpecialMoveInstance_RelativeAnimMove : BmSDK.BmGame.RSpecialMoveInstance, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveInstance_RelativeAnimMove", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMoveInstance_RelativeAnimMove.
    /// </summary>
    public static RSpecialMoveInstance_RelativeAnimMove DefaultObject => (RSpecialMoveInstance_RelativeAnimMove)StaticClass().DefaultObject;

    internal RSpecialMoveInstance_RelativeAnimMove() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_RelativeAnimMove
    /// </summary>
    public RSpecialMoveInstance_RelativeAnimMove(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_RelativeAnimMove(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RelativeAnimMove>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RelativeAnimMove>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RelativeAnimMove>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RelativeAnimMove>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RelativeAnimMove>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RelativeAnimMove>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RelativeAnimMove>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RelativeAnimMove>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetCameraAlignRotation;
    /// <summary>
    /// Function: GetCameraAlignRotation
    /// </summary>
    public unsafe override BmSDK.Rotator GetCameraAlignRotation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraAlignRotation, "BmGame.RSpecialMoveInstance_RelativeAnimMove.GetCameraAlignRotation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTransitionId;
    /// <summary>
    /// Function: GetTransitionId
    /// </summary>
    public unsafe override BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId GetTransitionId()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionId, "BmGame.RSpecialMoveInstance_RelativeAnimMove.GetTransitionId");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AllowCollisionWithLocator;
    /// <summary>
    /// Function: AllowCollisionWithLocator
    /// </summary>
    public unsafe virtual void AllowCollisionWithLocator()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowCollisionWithLocator, "BmGame.RSpecialMoveInstance_RelativeAnimMove.AllowCollisionWithLocator");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanAddExtraVelocity;
    /// <summary>
    /// Function: CanAddExtraVelocity
    /// </summary>
    public unsafe virtual void CanAddExtraVelocity()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanAddExtraVelocity, "BmGame.RSpecialMoveInstance_RelativeAnimMove.CanAddExtraVelocity");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCameraState;
    /// <summary>
    /// Function: SetCameraState
    /// </summary>
    public unsafe override void SetCameraState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCameraState, "BmGame.RSpecialMoveInstance_RelativeAnimMove.SetCameraState");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCameraAnim;
    /// <summary>
    /// Function: GetCameraAnim
    /// </summary>
    public unsafe override BmSDK.FName GetCameraAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraAnim, "BmGame.RSpecialMoveInstance_RelativeAnimMove.GetCameraAnim");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FinalAnimStarted;
    /// <summary>
    /// Function: FinalAnimStarted
    /// </summary>
    public unsafe virtual void FinalAnimStarted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinalAnimStarted, "BmGame.RSpecialMoveInstance_RelativeAnimMove.FinalAnimStarted");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayedQueuedTransition;
    /// <summary>
    /// Function: PlayedQueuedTransition
    /// </summary>
    public unsafe virtual void PlayedQueuedTransition(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id, float TimeLeftOver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayedQueuedTransition, "BmGame.RSpecialMoveInstance_RelativeAnimMove.PlayedQueuedTransition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FallingCamera;
    /// <summary>
    /// Function: FallingCamera
    /// </summary>
    public unsafe virtual void FallingCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FallingCamera, "BmGame.RSpecialMoveInstance_RelativeAnimMove.FallingCamera");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFloorGrateAnim;
    /// <summary>
    /// Function: PlayFloorGrateAnim
    /// </summary>
    public unsafe virtual void PlayFloorGrateAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFloorGrateAnim, "BmGame.RSpecialMoveInstance_RelativeAnimMove.PlayFloorGrateAnim");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FootStepNotify;
    /// <summary>
    /// Function: FootStepNotify
    /// </summary>
    public unsafe override void FootStepNotify()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FootStepNotify, "BmGame.RSpecialMoveInstance_RelativeAnimMove.FootStepNotify");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PredictEndLocation;
    /// <summary>
    /// Function: PredictEndLocation
    /// </summary>
    public unsafe override bool PredictEndLocation(out System.Numerics.Vector3 EndLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PredictEndLocation, "BmGame.RSpecialMoveInstance_RelativeAnimMove.PredictEndLocation");
        byte* paramsPtr = stackalloc byte[32];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out EndLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        EndLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CanOverride;
    /// <summary>
    /// Function: CanOverride
    /// </summary>
    public unsafe virtual bool CanOverride()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanOverride, "BmGame.RSpecialMoveInstance_RelativeAnimMove.CanOverride");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DisallowOverride;
    /// <summary>
    /// Function: DisallowOverride
    /// </summary>
    public unsafe virtual void DisallowOverride()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisallowOverride, "BmGame.RSpecialMoveInstance_RelativeAnimMove.DisallowOverride");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowOverride;
    /// <summary>
    /// Function: AllowOverride
    /// </summary>
    public unsafe virtual void AllowOverride()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowOverride, "BmGame.RSpecialMoveInstance_RelativeAnimMove.AllowOverride");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleAction;
    /// <summary>
    /// Function: HandleAction
    /// </summary>
    public unsafe override void HandleAction(BmSDK.FName actionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleAction, "BmGame.RSpecialMoveInstance_RelativeAnimMove.HandleAction");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PerformOverrideMove;
    /// <summary>
    /// Function: PerformOverrideMove
    /// </summary>
    public unsafe virtual bool PerformOverrideMove(bool FastForward)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PerformOverrideMove, "BmGame.RSpecialMoveInstance_RelativeAnimMove.PerformOverrideMove");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FastForward, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckForAOverride;
    /// <summary>
    /// Function: CheckForAOverride
    /// </summary>
    public unsafe override bool CheckForAOverride(bool ForceOverride = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForAOverride, "BmGame.RSpecialMoveInstance_RelativeAnimMove.CheckForAOverride");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceOverride, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_LandFinished;
    /// <summary>
    /// Function: LandFinished
    /// </summary>
    public unsafe virtual void LandFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LandFinished, "BmGame.RSpecialMoveInstance_RelativeAnimMove.LandFinished");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TunnelCamera;
    /// <summary>
    /// Function: TunnelCamera
    /// </summary>
    public unsafe virtual void TunnelCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TunnelCamera, "BmGame.RSpecialMoveInstance_RelativeAnimMove.TunnelCamera");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopAimAt;
    /// <summary>
    /// Function: StopAimAt
    /// </summary>
    public unsafe virtual void StopAimAt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAimAt, "BmGame.RSpecialMoveInstance_RelativeAnimMove.StopAimAt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAimAt;
    /// <summary>
    /// Function: StartAimAt
    /// </summary>
    public unsafe virtual void StartAimAt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAimAt, "BmGame.RSpecialMoveInstance_RelativeAnimMove.StartAimAt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PickRandomAnim;
    /// <summary>
    /// Function: PickRandomAnim
    /// </summary>
    public unsafe virtual void PickRandomAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickRandomAnim, "BmGame.RSpecialMoveInstance_RelativeAnimMove.PickRandomAnim");
        byte* paramsPtr = stackalloc byte[0];
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

    private static BmSDK.Function __fn_StopRelativeTransition;
    /// <summary>
    /// Function: StopRelativeTransition
    /// </summary>
    public unsafe override void StopRelativeTransition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopRelativeTransition, "BmGame.RSpecialMoveInstance_RelativeAnimMove.StopRelativeTransition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FallTimeOut;
    /// <summary>
    /// Function: FallTimeOut
    /// </summary>
    public unsafe virtual void FallTimeOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FallTimeOut, "BmGame.RSpecialMoveInstance_RelativeAnimMove.FallTimeOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverrideButtonIsBeingHeld;
    /// <summary>
    /// Function: OverrideButtonIsBeingHeld
    /// </summary>
    public unsafe virtual bool OverrideButtonIsBeingHeld()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideButtonIsBeingHeld, "BmGame.RSpecialMoveInstance_RelativeAnimMove.OverrideButtonIsBeingHeld");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateSpecialMove;
    /// <summary>
    /// Function: UpdateSpecialMove
    /// </summary>
    public unsafe override bool UpdateSpecialMove(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSpecialMove, "BmGame.RSpecialMoveInstance_RelativeAnimMove.UpdateSpecialMove");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CancelSpecialMove;
    /// <summary>
    /// Function: CancelSpecialMove
    /// </summary>
    public unsafe override void CancelSpecialMove(BmSDK.BmGame.RSpecialMoveConfig NextSpecialMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelSpecialMove, "BmGame.RSpecialMoveInstance_RelativeAnimMove.CancelSpecialMove");
        byte* paramsPtr = stackalloc byte[16];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishSpecialMove, "BmGame.RSpecialMoveInstance_RelativeAnimMove.FinishSpecialMove");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEndControllerState;
    /// <summary>
    /// Function: GetEndControllerState
    /// </summary>
    public unsafe override BmSDK.FName GetEndControllerState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEndControllerState, "BmGame.RSpecialMoveInstance_RelativeAnimMove.GetEndControllerState");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartAnimation;
    /// <summary>
    /// Function: StartAnimation
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId StartAnimation(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator MoveLocation, BmSDK.FName AnimName, BmSDK.FName idleAnimName = default, bool bMirror = default, BmSDK.FName EndMovementStance = default, float DurationScale = default, BmSDK.Engine.AnimSet OverrideTransitionAnimSet = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice MirrorIdle = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAnimation, "BmGame.RSpecialMoveInstance_RelativeAnimMove.StartAnimation");
        byte* paramsPtr = stackalloc byte[216];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(idleAnimName, paramsPtr + 140);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirror, paramsPtr + 148);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndMovementStance, paramsPtr + 152);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DurationScale, paramsPtr + 160);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideTransitionAnimSet, paramsPtr + 164);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirrorIdle, paramsPtr + 172);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 176);
    }

    private static BmSDK.Function __fn_AllowWallEvade;
    /// <summary>
    /// Function: AllowWallEvade
    /// </summary>
    public unsafe virtual void AllowWallEvade()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowWallEvade, "BmGame.RSpecialMoveInstance_RelativeAnimMove.AllowWallEvade");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEndMovementStance;
    /// <summary>
    /// Function: GetEndMovementStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetEndMovementStance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEndMovementStance, "BmGame.RSpecialMoveInstance_RelativeAnimMove.GetEndMovementStance");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCustomIdle;
    /// <summary>
    /// Function: GetCustomIdle
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAnimConfig GetCustomIdle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomIdle, "BmGame.RSpecialMoveInstance_RelativeAnimMove.GetCustomIdle");
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DoSlavedJokerHallucination;
    /// <summary>
    /// Function: DoSlavedJokerHallucination
    /// </summary>
    public unsafe override void DoSlavedJokerHallucination(bool bIgnoreCollisionCheck, BmSDK.BmGame.RPawnJokerHallucination.TypesOfHallucination HallucinationType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoSlavedJokerHallucination, "BmGame.RSpecialMoveInstance_RelativeAnimMove.DoSlavedJokerHallucination");
        byte* paramsPtr = stackalloc byte[49];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreCollisionCheck, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HallucinationType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerSpecialMove;
    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe override void TriggerSpecialMove(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSpecialMove, "BmGame.RSpecialMoveInstance_RelativeAnimMove.TriggerSpecialMove");
        byte* paramsPtr = stackalloc byte[176];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// IntProperty: ChosenAnim
    /// </summary>
    public unsafe int ChosenAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// BoolProperty: bMirrored
    /// </summary>
    public unsafe bool bMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bUseAimAt
    /// </summary>
    public unsafe bool bUseAimAt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bAllowOverride
    /// </summary>
    public unsafe bool bAllowOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bTryingToOverride
    /// </summary>
    public unsafe bool bTryingToOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: StoppedFollowingBase
    /// </summary>
    public unsafe bool StoppedFollowingBase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bCanAddExtraVelocity
    /// </summary>
    public unsafe bool bCanAddExtraVelocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredTunnelCamera
    /// </summary>
    public unsafe bool bTriggeredTunnelCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bDelayCallingSetCameraState
    /// </summary>
    public unsafe bool bDelayCallingSetCameraState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// StructProperty: AnimEndLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AnimEndLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 884);

    /// <summary>
    /// StructProperty: ReferencePointOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ReferencePointOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 896);

    /// <summary>
    /// StructProperty: ReferenceRotationOffset
    /// </summary>
    public unsafe ref BmSDK.Rotator ReferenceRotationOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 908);

    /// <summary>
    /// StructProperty: Transition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Transition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 920);

    /// <summary>
    /// NameProperty: FinalMovementStance
    /// </summary>
    public unsafe BmSDK.FName FinalMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// FloatProperty: FallingTime
    /// </summary>
    public unsafe float FallingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// FloatProperty: LastATime
    /// </summary>
    public unsafe float LastATime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: OverrideGlideSpeed
    /// </summary>
    public unsafe float OverrideGlideSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// StructProperty: ReferenceRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator ReferenceRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 944);

    /// <summary>
    /// StructProperty: ReferenceLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ReferenceLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 956);

    /// <summary>
    /// StructProperty: PreQueuedAnim
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PreQueuedAnim
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 968);

    /// <summary>
    /// DelegateProperty: __PlayedQueuedTransition__Delegate
    /// </summary>
    public unsafe System.IntPtr __PlayedQueuedTransition__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }
}
