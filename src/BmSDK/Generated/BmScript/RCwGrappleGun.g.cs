#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCwGrappleGun<br/>
/// (size = 7472)
/// (flags = 10485810)
/// </summary>
public partial class RCwGrappleGun : BmSDK.BmGame.RCwGrappleGunBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCwGrappleGun", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCwGrappleGun.
    /// </summary>
    public static RCwGrappleGun DefaultObject => (RCwGrappleGun)StaticClass().DefaultObject;

    internal RCwGrappleGun() { }

    /// <summary>
    /// Constructs a new RCwGrappleGun
    /// </summary>
    public RCwGrappleGun(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCwGrappleGun(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CanAimGrapple;
    /// <summary>
    /// Function: CanAimGrapple
    /// </summary>
    public unsafe override bool CanAimGrapple()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanAimGrapple, "BmScript.RCwGrappleGun.CanAimGrapple");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RecalculatePath;
    /// <summary>
    /// Function: RecalculatePath
    /// </summary>
    public unsafe virtual void RecalculatePath()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecalculatePath, "BmScript.RCwGrappleGun.RecalculatePath");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsWallClimbMove;
    /// <summary>
    /// Function: IsWallClimbMove
    /// </summary>
    public unsafe override bool IsWallClimbMove(BmSDK.BmGame.RSpecialMoveConfig Config)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWallClimbMove, "BmScript.RCwGrappleGun.IsWallClimbMove");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindGrapplePointMultipleCones;
    /// <summary>
    /// Function: FindGrapplePointMultipleCones
    /// </summary>
    public unsafe override void FindGrapplePointMultipleCones(out BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition> Cones, float MinAngle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindGrapplePointMultipleCones, "BmScript.RCwGrappleGun.FindGrapplePointMultipleCones");
        byte* paramsPtr = stackalloc byte[164];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinAngle, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Cones = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddCone;
    /// <summary>
    /// Function: AddCone
    /// </summary>
    public unsafe virtual void AddCone(out BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition> Cones, float MinAngle, System.Numerics.Vector3 CameraLocation, BmSDK.Rotator CameraRotation, System.Numerics.Vector3 PlayerLocation, bool bZoomed, float OverrideMaxDistance = default, BmSDK.FString Desc = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCone, "BmScript.RCwGrappleGun.AddCone");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinAngle, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLocation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraRotation, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bZoomed, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaxDistance, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Desc, paramsPtr + 64);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        Cones = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ModifyCone;
    /// <summary>
    /// Function: ModifyCone
    /// </summary>
    public unsafe virtual void ModifyCone(out BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition> Cones, float MinAngle, System.Numerics.Vector3 CameraLocation, BmSDK.Rotator CameraRotation, System.Numerics.Vector3 PlayerLocation, bool bZoomed, float OverrideMaxDistance = default, BmSDK.FString Desc = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyCone, "BmScript.RCwGrappleGun.ModifyCone");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinAngle, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLocation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraRotation, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bZoomed, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaxDistance, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Desc, paramsPtr + 64);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        Cones = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ResetAutoSwing;
    /// <summary>
    /// Function: ResetAutoSwing
    /// </summary>
    public unsafe virtual void ResetAutoSwing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetAutoSwing, "BmScript.RCwGrappleGun.ResetAutoSwing");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAutoSwing;
    /// <summary>
    /// Function: StartAutoSwing
    /// </summary>
    public unsafe virtual void StartAutoSwing(bool bTriggeredFromEdge = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAutoSwing, "BmScript.RCwGrappleGun.StartAutoSwing");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTriggeredFromEdge, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSwingFromEdge;
    /// <summary>
    /// Function: CanSwingFromEdge
    /// </summary>
    public unsafe virtual bool CanSwingFromEdge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSwingFromEdge, "BmScript.RCwGrappleGun.CanSwingFromEdge");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ScriptTick;
    /// <summary>
    /// Function: ScriptTick
    /// </summary>
    public unsafe override void ScriptTick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScriptTick, "BmScript.RCwGrappleGun.ScriptTick");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawClimbRoute;
    /// <summary>
    /// Function: DrawClimbRoute
    /// </summary>
    public unsafe override void DrawClimbRoute(bool bPersistent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawClimbRoute, "BmScript.RCwGrappleGun.DrawClimbRoute");
        byte* paramsPtr = stackalloc byte[348];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForSwingEdge;
    /// <summary>
    /// Function: CheckForSwingEdge
    /// </summary>
    public unsafe virtual void CheckForSwingEdge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForSwingEdge, "BmScript.RCwGrappleGun.CheckForSwingEdge");
        byte* paramsPtr = stackalloc byte[204];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawDebugInfo;
    /// <summary>
    /// Function: DrawDebugInfo
    /// </summary>
    public unsafe virtual void DrawDebugInfo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugInfo, "BmScript.RCwGrappleGun.DrawDebugInfo");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearDebugInfo;
    /// <summary>
    /// Function: ClearDebugInfo
    /// </summary>
    public unsafe virtual void ClearDebugInfo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearDebugInfo, "BmScript.RCwGrappleGun.ClearDebugInfo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpTargetInfo;
    /// <summary>
    /// Function: DumpTargetInfo
    /// </summary>
    public unsafe virtual void DumpTargetInfo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpTargetInfo, "BmScript.RCwGrappleGun.DumpTargetInfo");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetIdealSwingParameters;
    /// <summary>
    /// Function: GetIdealSwingParameters
    /// </summary>
    public unsafe override void GetIdealSwingParameters(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 EndLocation, System.Numerics.Vector3 WallLocation, out float IdealSwingTime, out float IdealSwingLength)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIdealSwingParameters, "BmScript.RCwGrappleGun.GetIdealSwingParameters");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IdealSwingTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdealSwingTime, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IdealSwingLength);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdealSwingLength, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IdealSwingTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 36);
        IdealSwingLength = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 40);
        return;
    }

    private static BmSDK.Function __fn_GetAerialWhipConfig;
    /// <summary>
    /// Function: GetAerialWhipConfig
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RSpecialMoveConfig_CwAerialWhipPounce GetAerialWhipConfig(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 EndLocation, System.Numerics.Vector3 WallLocation, BmSDK.BmGame.RPawnPlayerCatwomanBase.ESwingDirection SwingDirection = default, bool bGetSafeMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAerialWhipConfig, "BmScript.RCwGrappleGun.GetAerialWhipConfig");
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwingDirection, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGetSafeMove, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.RSpecialMoveConfig_CwAerialWhipPounce>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_TriggerAerialWhipPounce;
    /// <summary>
    /// Function: TriggerAerialWhipPounce
    /// </summary>
    public unsafe virtual bool TriggerAerialWhipPounce()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerAerialWhipPounce, "BmScript.RCwGrappleGun.TriggerAerialWhipPounce");
        byte* paramsPtr = stackalloc byte[236];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerAerialAutoWhipPounce;
    /// <summary>
    /// Function: TriggerAerialAutoWhipPounce
    /// </summary>
    public unsafe virtual bool TriggerAerialAutoWhipPounce()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerAerialAutoWhipPounce, "BmScript.RCwGrappleGun.TriggerAerialAutoWhipPounce");
        byte* paramsPtr = stackalloc byte[96];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartWallClimbCamera;
    /// <summary>
    /// Function: StartWallClimbCamera
    /// </summary>
    public unsafe override void StartWallClimbCamera(System.Numerics.Vector3 CurrentLandLocation, int FirstClimbPointIndex = default, bool bEstimatedLandPoint = default, bool bFromSwing = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartWallClimbCamera, "BmScript.RCwGrappleGun.StartWallClimbCamera");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentLandLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstClimbPointIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEstimatedLandPoint, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFromSwing, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerClawClimb;
    /// <summary>
    /// Function: TriggerClawClimb
    /// </summary>
    public unsafe virtual void TriggerClawClimb(bool bForceClawClimb)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerClawClimb, "BmScript.RCwGrappleGun.TriggerClawClimb");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceClawClimb, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerPounce;
    /// <summary>
    /// Function: TriggerPounce
    /// </summary>
    public unsafe virtual void TriggerPounce()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPounce, "BmScript.RCwGrappleGun.TriggerPounce");
        byte* paramsPtr = stackalloc byte[228];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryAerialSwingMove;
    /// <summary>
    /// Function: TryAerialSwingMove
    /// </summary>
    public unsafe virtual bool TryAerialSwingMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryAerialSwingMove, "BmScript.RCwGrappleGun.TryAerialSwingMove");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Grapple;
    /// <summary>
    /// Function: Grapple
    /// </summary>
    public unsafe override bool Grapple(BmSDK.BmGame.RSpecialMoveConfig OverrideGrappleMove = default, bool bForceSucced = default, bool bTryQueuedGrapple = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Grapple, "BmScript.RCwGrappleGun.Grapple");
        byte* paramsPtr = stackalloc byte[1412];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideGrappleMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceSucced, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTryQueuedGrapple, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// IntProperty: FrameCount
    /// </summary>
    public unsafe int FrameCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7440); }
    }

    /// <summary>
    /// StructProperty: DirectPounceDetectShift
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DirectPounceDetectShift
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7444);

    /// <summary>
    /// BoolProperty: bDebugDirectPounceFeatureDetection
    /// </summary>
    public unsafe bool bDebugDirectPounceFeatureDetection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7456) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7456); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7456); }
    }

    /// <summary>
    /// BoolProperty: IsAutomaticClimbWall
    /// </summary>
    public unsafe bool IsAutomaticClimbWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7456) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7456); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7456); }
    }

    /// <summary>
    /// FloatProperty: ShortJumpOffPitchDown
    /// </summary>
    public unsafe float ShortJumpOffPitchDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7460); }
    }

    /// <summary>
    /// FloatProperty: ShortJumpOffRelativePitchDown
    /// </summary>
    public unsafe float ShortJumpOffRelativePitchDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7464); }
    }

    /// <summary>
    /// IntProperty: MaximumClimb
    /// </summary>
    public unsafe int MaximumClimb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7468); }
    }
}
