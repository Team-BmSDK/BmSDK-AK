#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveInstance_SwingToVantagePoint<br/>
/// (size = 1064)
/// (flags = 144703634)
/// </summary>
public partial class RSpecialMoveInstance_SwingToVantagePoint : BmSDK.BmGame.RSpecialMoveInstance, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveInstance_SwingToVantagePoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMoveInstance_SwingToVantagePoint.
    /// </summary>
    public static RSpecialMoveInstance_SwingToVantagePoint DefaultObject => (RSpecialMoveInstance_SwingToVantagePoint)StaticClass().DefaultObject;

    internal RSpecialMoveInstance_SwingToVantagePoint() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_SwingToVantagePoint
    /// </summary>
    public RSpecialMoveInstance_SwingToVantagePoint(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_SwingToVantagePoint(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_SwingToVantagePoint>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_SwingToVantagePoint>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_SwingToVantagePoint>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_SwingToVantagePoint>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_SwingToVantagePoint>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_SwingToVantagePoint>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_SwingToVantagePoint>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_SwingToVantagePoint>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CanCancelSwing;
    /// <summary>
    /// Function: CanCancelSwing
    /// </summary>
    public unsafe virtual bool CanCancelSwing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCancelSwing, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.CanCancelSwing");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NextSwing;
    /// <summary>
    /// Function: NextSwing
    /// </summary>
    public unsafe virtual void NextSwing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NextSwing, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.NextSwing");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNextHidePoint;
    /// <summary>
    /// Function: GetNextHidePoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHidePoint GetNextHidePoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextHidePoint, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.GetNextHidePoint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHidePoint>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTargetHidePoint;
    /// <summary>
    /// Function: GetTargetHidePoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHidePoint GetTargetHidePoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetHidePoint, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.GetTargetHidePoint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHidePoint>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanUpdateGrapple;
    /// <summary>
    /// Function: CanUpdateGrapple
    /// </summary>
    public unsafe virtual bool CanUpdateGrapple()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUpdateGrapple, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.CanUpdateGrapple");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetNextHidePoint;
    /// <summary>
    /// Function: SetNextHidePoint
    /// </summary>
    public unsafe virtual void SetNextHidePoint(BmSDK.BmGame.RHidePoint NextPoint, System.Numerics.Vector3 NextPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNextHidePoint, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.SetNextHidePoint");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextPos, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldCorrectForClientError;
    /// <summary>
    /// Function: ShouldCorrectForClientError
    /// </summary>
    public unsafe override bool ShouldCorrectForClientError()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldCorrectForClientError, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.ShouldCorrectForClientError");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerSwingCamera;
    /// <summary>
    /// Function: TriggerSwingCamera
    /// </summary>
    public unsafe virtual void TriggerSwingCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSwingCamera, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.TriggerSwingCamera");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseSwingRope;
    /// <summary>
    /// Function: ReleaseSwingRope
    /// </summary>
    public unsafe virtual void ReleaseSwingRope()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseSwingRope, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.ReleaseSwingRope");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwingFireGrapple;
    /// <summary>
    /// Function: SwingFireGrapple
    /// </summary>
    public unsafe virtual void SwingFireGrapple()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwingFireGrapple, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.SwingFireGrapple");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishSpecialMove;
    /// <summary>
    /// Function: FinishSpecialMove
    /// </summary>
    public unsafe override void FinishSpecialMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishSpecialMove, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.FinishSpecialMove");
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelSpecialMove;
    /// <summary>
    /// Function: CancelSpecialMove
    /// </summary>
    public unsafe override void CancelSpecialMove(BmSDK.BmGame.RSpecialMoveConfig NextSpecialMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelSpecialMove, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.CancelSpecialMove");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextSpecialMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyLandingCapeState;
    /// <summary>
    /// Function: ApplyLandingCapeState
    /// </summary>
    public unsafe virtual void ApplyLandingCapeState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyLandingCapeState, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.ApplyLandingCapeState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLandDirection;
    /// <summary>
    /// Function: GetLandDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetLandDirection(BmSDK.FName AnimName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLandDirection, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.GetLandDirection");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DrawTrajectory;
    /// <summary>
    /// Function: DrawTrajectory
    /// </summary>
    public unsafe virtual void DrawTrajectory()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTrajectory, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.DrawTrajectory");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSwingEndLocation;
    /// <summary>
    /// Function: GetSwingEndLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetSwingEndLocation(System.Numerics.Vector3 Direction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSwingEndLocation, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.GetSwingEndLocation");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetGrappleSwingState;
    /// <summary>
    /// Function: SetGrappleSwingState
    /// </summary>
    public unsafe virtual void SetGrappleSwingState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGrappleSwingState, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.SetGrappleSwingState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerSpecialMove;
    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe override void TriggerSpecialMove(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSpecialMove, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.TriggerSpecialMove");
        byte* paramsPtr = stackalloc byte[476];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateTrajectory;
    /// <summary>
    /// Function: UpdateTrajectory
    /// </summary>
    public unsafe virtual float UpdateTrajectory(float DeltaTime, out System.Numerics.Vector3 Position, out BmSDK.Rotator PlayerRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTrajectory, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.UpdateTrajectory");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Position);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PlayerRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerRotation, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Position = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        PlayerRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_SetupTrajectory;
    /// <summary>
    /// Function: SetupTrajectory
    /// </summary>
    public unsafe virtual void SetupTrajectory(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 EndLocation, float DefaultDistance, float DefaultRadius, float AnimationDuration, float DurationPower, bool SwingFromPointAboveTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupTrajectory, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.SetupTrajectory");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultDistance, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultRadius, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimationDuration, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DurationPower, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwingFromPointAboveTarget, paramsPtr + 40);
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

    private static BmSDK.Function __fn_CalculateFireToPoint;
    /// <summary>
    /// Function: CalculateFireToPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 CalculateFireToPoint(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 EndLocation, float DefaultDistance, float DefaultRadius)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateFireToPoint, "BmGame.RSpecialMoveInstance_SwingToVantagePoint.CalculateFireToPoint");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultDistance, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultRadius, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 32);
    }

    /// <summary>
    /// ObjectProperty: TargetHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint TargetHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: NextHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint NextHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// StructProperty: NextHidePointSwingPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 NextHidePointSwingPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 892);

    /// <summary>
    /// FloatProperty: TrajectoryDuration
    /// </summary>
    public unsafe float TrajectoryDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// FloatProperty: TrajectoryRadius
    /// </summary>
    public unsafe float TrajectoryRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// StructProperty: TrajectoryOrigin
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TrajectoryOrigin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 912);

    /// <summary>
    /// StructProperty: TrajectoryDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TrajectoryDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 924);

    /// <summary>
    /// StructProperty: TrajectoryUp
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TrajectoryUp
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 936);

    /// <summary>
    /// StructProperty: FireGrappleTo
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FireGrappleTo
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 948);

    /// <summary>
    /// FloatProperty: TrajectoryStart
    /// </summary>
    public unsafe float TrajectoryStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// FloatProperty: TrajectoryEnd
    /// </summary>
    public unsafe float TrajectoryEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// StructProperty: SwingEndLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SwingEndLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 968);

    /// <summary>
    /// FloatProperty: CurrentTrajectoryPosition
    /// </summary>
    public unsafe float CurrentTrajectoryPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: bMirrored
    /// </summary>
    public unsafe bool bMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 984) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 984); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 984); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredCamera
    /// </summary>
    public unsafe bool bTriggeredCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 984) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 984); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 984); }
    }

    /// <summary>
    /// BoolProperty: bCanSwingAgain
    /// </summary>
    public unsafe bool bCanSwingAgain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 984) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 984); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 984); }
    }

    /// <summary>
    /// BoolProperty: bFromGrateChute
    /// </summary>
    public unsafe bool bFromGrateChute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 984) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 984); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 984); }
    }

    /// <summary>
    /// StructProperty: LandTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId LandTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 988);

    /// <summary>
    /// StructProperty: StoredVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StoredVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 992);

    /// <summary>
    /// StructProperty: OutVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 OutVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1004);

    /// <summary>
    /// FloatProperty: TimeScale
    /// </summary>
    public unsafe float TimeScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// StructProperty: GrappleFireLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrappleFireLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1020);

    /// <summary>
    /// IntProperty: JumpLandAnimYawOffset
    /// </summary>
    public unsafe int JumpLandAnimYawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// ByteProperty: AimingConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc AimingConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// NameProperty: nLandingAnimationName
    /// </summary>
    public unsafe BmSDK.FName nLandingAnimationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// StructProperty: AudioSwingOneShot
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle AudioSwingOneShot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 1048);
}
