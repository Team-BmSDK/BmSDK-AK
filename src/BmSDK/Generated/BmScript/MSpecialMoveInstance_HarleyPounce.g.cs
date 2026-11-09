#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MSpecialMoveInstance_HarleyPounce<br/>
/// (size = 956)
/// (flags = 10485778)
/// </summary>
public partial class MSpecialMoveInstance_HarleyPounce : BmSDK.BmGame.RSpecialMoveInstance, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MSpecialMoveInstance_HarleyPounce", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MSpecialMoveInstance_HarleyPounce.
    /// </summary>
    public static MSpecialMoveInstance_HarleyPounce DefaultObject => (MSpecialMoveInstance_HarleyPounce)StaticClass().DefaultObject;

    internal MSpecialMoveInstance_HarleyPounce() { }

    /// <summary>
    /// Constructs a new MSpecialMoveInstance_HarleyPounce
    /// </summary>
    public MSpecialMoveInstance_HarleyPounce(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MSpecialMoveInstance_HarleyPounce(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_HarleyPounce>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_HarleyPounce>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_HarleyPounce>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_HarleyPounce>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_HarleyPounce>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_HarleyPounce>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_HarleyPounce>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_HarleyPounce>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_FinishSpecialMove;
    /// <summary>
    /// Function: FinishSpecialMove
    /// </summary>
    public unsafe override void FinishSpecialMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishSpecialMove, "BmScript.MSpecialMoveInstance_HarleyPounce.FinishSpecialMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckGrapplePressed;
    /// <summary>
    /// Function: CheckGrapplePressed
    /// </summary>
    public unsafe virtual void CheckGrapplePressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckGrapplePressed, "BmScript.MSpecialMoveInstance_HarleyPounce.CheckGrapplePressed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartDisableCameraCollision;
    /// <summary>
    /// Function: StartDisableCameraCollision
    /// </summary>
    public unsafe virtual void StartDisableCameraCollision()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartDisableCameraCollision, "BmScript.MSpecialMoveInstance_HarleyPounce.StartDisableCameraCollision");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEndCameraState;
    /// <summary>
    /// Function: SetEndCameraState
    /// </summary>
    public unsafe virtual void SetEndCameraState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEndCameraState, "BmScript.MSpecialMoveInstance_HarleyPounce.SetEndCameraState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WallClimbStartCam;
    /// <summary>
    /// Function: WallClimbStartCam
    /// </summary>
    public unsafe virtual void WallClimbStartCam()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WallClimbStartCam, "BmScript.MSpecialMoveInstance_HarleyPounce.WallClimbStartCam");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEndControllerState;
    /// <summary>
    /// Function: GetEndControllerState
    /// </summary>
    public unsafe override BmSDK.FName GetEndControllerState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEndControllerState, "BmScript.MSpecialMoveInstance_HarleyPounce.GetEndControllerState");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayAnimLandOverRailing;
    /// <summary>
    /// Function: PlayAnimLandOverRailing
    /// </summary>
    public unsafe virtual void PlayAnimLandOverRailing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAnimLandOverRailing, "BmScript.MSpecialMoveInstance_HarleyPounce.PlayAnimLandOverRailing");
        byte* paramsPtr = stackalloc byte[26];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayAnimLandOnRailing;
    /// <summary>
    /// Function: PlayAnimLandOnRailing
    /// </summary>
    public unsafe virtual void PlayAnimLandOnRailing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAnimLandOnRailing, "BmScript.MSpecialMoveInstance_HarleyPounce.PlayAnimLandOnRailing");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayAnimSlipThroughGrate;
    /// <summary>
    /// Function: PlayAnimSlipThroughGrate
    /// </summary>
    public unsafe virtual void PlayAnimSlipThroughGrate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAnimSlipThroughGrate, "BmScript.MSpecialMoveInstance_HarleyPounce.PlayAnimSlipThroughGrate");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlipOverRailing;
    /// <summary>
    /// Function: FlipOverRailing
    /// </summary>
    public unsafe virtual bool FlipOverRailing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlipOverRailing, "BmScript.MSpecialMoveInstance_HarleyPounce.FlipOverRailing");
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CalculateIsAngleJump;
    /// <summary>
    /// Function: CalculateIsAngleJump
    /// </summary>
    public unsafe virtual void CalculateIsAngleJump()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateIsAngleJump, "BmScript.MSpecialMoveInstance_HarleyPounce.CalculateIsAngleJump");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayAnimAir;
    /// <summary>
    /// Function: PlayAnimAir
    /// </summary>
    public unsafe virtual void PlayAnimAir()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAnimAir, "BmScript.MSpecialMoveInstance_HarleyPounce.PlayAnimAir");
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayAnimJump;
    /// <summary>
    /// Function: PlayAnimJump
    /// </summary>
    public unsafe virtual void PlayAnimJump()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAnimJump, "BmScript.MSpecialMoveInstance_HarleyPounce.PlayAnimJump");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayAnimCartWheel;
    /// <summary>
    /// Function: PlayAnimCartWheel
    /// </summary>
    public unsafe virtual void PlayAnimCartWheel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAnimCartWheel, "BmScript.MSpecialMoveInstance_HarleyPounce.PlayAnimCartWheel");
        byte* paramsPtr = stackalloc byte[172];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayBreakWindowAnim;
    /// <summary>
    /// Function: PlayBreakWindowAnim
    /// </summary>
    public unsafe virtual void PlayBreakWindowAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBreakWindowAnim, "BmScript.MSpecialMoveInstance_HarleyPounce.PlayBreakWindowAnim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForBreakableWindow;
    /// <summary>
    /// Function: CheckForBreakableWindow
    /// </summary>
    public unsafe virtual bool CheckForBreakableWindow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForBreakableWindow, "BmScript.MSpecialMoveInstance_HarleyPounce.CheckForBreakableWindow");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsCartWheelValid;
    /// <summary>
    /// Function: IsCartWheelValid
    /// </summary>
    public unsafe virtual bool IsCartWheelValid(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, BmSDK.BmGame.MHarleyGrappleGunBase GrappleGun, out BmSDK.FName AnimName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCartWheelValid, "BmScript.MSpecialMoveInstance_HarleyPounce.IsCartWheelValid");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrappleGun, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AnimName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AnimName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_TraceProperCartWheelPath;
    /// <summary>
    /// Function: TraceProperCartWheelPath
    /// </summary>
    public unsafe virtual bool TraceProperCartWheelPath(System.Numerics.Vector3 TraceStart, System.Numerics.Vector3 TraceEnd, float TraceForwardDist, System.Numerics.Vector3 TraceExtent, out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceProperCartWheelPath, "BmScript.MSpecialMoveInstance_HarleyPounce.TraceProperCartWheelPath");
        byte* paramsPtr = stackalloc byte[188];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceStart, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceEnd, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceForwardDist, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceExtent, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 40);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 40);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 52);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 64);
    }

    private static BmSDK.Function __fn_GetCartWheelAnimBasedOnDistance;
    /// <summary>
    /// Function: GetCartWheelAnimBasedOnDistance
    /// </summary>
    public unsafe virtual bool GetCartWheelAnimBasedOnDistance(float DistanceSq, BmSDK.BmGame.MHarleyGrappleGunBase GrappleGun, out BmSDK.FName AnimName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCartWheelAnimBasedOnDistance, "BmScript.MSpecialMoveInstance_HarleyPounce.GetCartWheelAnimBasedOnDistance");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistanceSq, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrappleGun, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AnimName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AnimName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_TriggerSpecialMove;
    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe override void TriggerSpecialMove(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSpecialMove, "BmScript.MSpecialMoveInstance_HarleyPounce.TriggerSpecialMove");
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NextSwing;
    /// <summary>
    /// Function: NextSwing
    /// </summary>
    public unsafe virtual void NextSwing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NextSwing, "BmScript.MSpecialMoveInstance_HarleyPounce.NextSwing");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTargetHidePoint;
    /// <summary>
    /// Function: GetTargetHidePoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHidePoint GetTargetHidePoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetHidePoint, "BmScript.MSpecialMoveInstance_HarleyPounce.GetTargetHidePoint");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUpdateGrapple, "BmScript.MSpecialMoveInstance_HarleyPounce.CanUpdateGrapple");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNextHidePoint;
    /// <summary>
    /// Function: GetNextHidePoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHidePoint GetNextHidePoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextHidePoint, "BmScript.MSpecialMoveInstance_HarleyPounce.GetNextHidePoint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHidePoint>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetNextHidePoint;
    /// <summary>
    /// Function: SetNextHidePoint
    /// </summary>
    public unsafe virtual void SetNextHidePoint(BmSDK.BmGame.RHidePoint NextPoint, System.Numerics.Vector3 NextPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNextHidePoint, "BmScript.MSpecialMoveInstance_HarleyPounce.SetNextHidePoint");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextPos, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: MyConfig
    /// </summary>
    public unsafe BmSDK.BmScript.MSpecialMoveConfig_HarleyPounce MyConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MSpecialMoveConfig_HarleyPounce>(Ptr + 876); }
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
    /// ObjectProperty: TargetHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePointLedgePerch TargetHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePointLedgePerch>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: IsShortHorizontalPounce
    /// </summary>
    public unsafe bool IsShortHorizontalPounce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: IsLongHorizontalPounce
    /// </summary>
    public unsafe bool IsLongHorizontalPounce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: IsMidHorizontalPounce
    /// </summary>
    public unsafe bool IsMidHorizontalPounce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bPounceFromRailingStealth
    /// </summary>
    public unsafe bool bPounceFromRailingStealth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bPouncethroughGrate
    /// </summary>
    public unsafe bool bPouncethroughGrate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bGrapplePressed
    /// </summary>
    public unsafe bool bGrapplePressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: JumpAngle
    /// </summary>
    public unsafe bool JumpAngle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bCanSwingAgain
    /// </summary>
    public unsafe bool bCanSwingAgain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// StructProperty: TransitionId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId TransitionId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 904);

    /// <summary>
    /// NameProperty: FinalMovementStance
    /// </summary>
    public unsafe BmSDK.FName FinalMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// StructProperty: refLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 refLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 916);

    /// <summary>
    /// StructProperty: RefRot
    /// </summary>
    public unsafe ref BmSDK.Rotator RefRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 928);

    /// <summary>
    /// FloatProperty: JumpDotRight
    /// </summary>
    public unsafe float JumpDotRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// StructProperty: NextHidePointSwingPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 NextHidePointSwingPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 944);
}
