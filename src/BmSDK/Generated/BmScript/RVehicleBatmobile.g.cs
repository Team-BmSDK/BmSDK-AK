#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RVehicleBatmobile<br/>
/// (size = 8640)
/// (flags = 10486326)
/// </summary>
public partial class RVehicleBatmobile : BmSDK.BmGame.RVehicleBatmobileBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RVehicleBatmobile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RVehicleBatmobile.
    /// </summary>
    public static RVehicleBatmobile DefaultObject => (RVehicleBatmobile)StaticClass().DefaultObject;

    internal RVehicleBatmobile() { }

    /// <summary>
    /// Constructs a new RVehicleBatmobile
    /// </summary>
    public RVehicleBatmobile(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBatmobile(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_IsBatmobileTouchingAGlideOutOfBoundsVolume;
    /// <summary>
    /// Function: IsBatmobileTouchingAGlideOutOfBoundsVolume
    /// </summary>
    public unsafe override bool IsBatmobileTouchingAGlideOutOfBoundsVolume()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatmobileTouchingAGlideOutOfBoundsVolume, "BmScript.RVehicleBatmobile.IsBatmobileTouchingAGlideOutOfBoundsVolume");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckForUpgrades;
    /// <summary>
    /// Function: CheckForUpgrades
    /// </summary>
    public unsafe override void CheckForUpgrades(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForUpgrades, "BmScript.RVehicleBatmobile.CheckForUpgrades");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetOverrideCamera;
    /// <summary>
    /// Function: GetOverrideCamera
    /// </summary>
    public unsafe override BmSDK.FName GetOverrideCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverrideCamera, "BmScript.RVehicleBatmobile.GetOverrideCamera");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GrappleSwingIn;
    /// <summary>
    /// Function: GrappleSwingIn
    /// </summary>
    public unsafe override void GrappleSwingIn(BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrappleSwingIn, "BmScript.RVehicleBatmobile.GrappleSwingIn");
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnThugStunEffect;
    /// <summary>
    /// Function: SpawnThugStunEffect
    /// </summary>
    public unsafe override void SpawnThugStunEffect(BmSDK.BmGame.RBMPawnAI Thug, System.Numerics.Vector3 ThugDiveDirection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnThugStunEffect, "BmScript.RVehicleBatmobile.SpawnThugStunEffect");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thug, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugDiveDirection, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopWaterImpactEffect;
    /// <summary>
    /// Function: StopWaterImpactEffect
    /// </summary>
    public unsafe override void StopWaterImpactEffect()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopWaterImpactEffect, "BmScript.RVehicleBatmobile.StopWaterImpactEffect");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnWaterImpactEffect;
    /// <summary>
    /// Function: SpawnWaterImpactEffect
    /// </summary>
    public unsafe override void SpawnWaterImpactEffect(System.Numerics.Vector3 HitLocation, BmSDK.Engine.Camera PlayerCamera)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnWaterImpactEffect, "BmScript.RVehicleBatmobile.SpawnWaterImpactEffect");
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerCamera, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnAbseilImpactRear;
    /// <summary>
    /// Function: SpawnAbseilImpactRear
    /// </summary>
    public unsafe override void SpawnAbseilImpactRear()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnAbseilImpactRear, "BmScript.RVehicleBatmobile.SpawnAbseilImpactRear");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnAbseilImpactFront;
    /// <summary>
    /// Function: SpawnAbseilImpactFront
    /// </summary>
    public unsafe override void SpawnAbseilImpactFront()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnAbseilImpactFront, "BmScript.RVehicleBatmobile.SpawnAbseilImpactFront");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UsedWhenStolen;
    /// <summary>
    /// Function: UsedWhenStolen
    /// </summary>
    public unsafe override void UsedWhenStolen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UsedWhenStolen, "BmScript.RVehicleBatmobile.UsedWhenStolen");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIsStolen;
    /// <summary>
    /// Function: SetIsStolen
    /// </summary>
    public unsafe override void SetIsStolen(bool Stolen, BmSDK.Engine.SequenceAction Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIsStolen, "BmScript.RVehicleBatmobile.SetIsStolen");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stolen, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDisabledByEMP;
    /// <summary>
    /// Function: SetDisabledByEMP
    /// </summary>
    public unsafe override void SetDisabledByEMP(bool Disabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDisabledByEMP, "BmScript.RVehicleBatmobile.SetDisabledByEMP");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Disabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateBatmanPickupRoute;
    /// <summary>
    /// Function: UpdateBatmanPickupRoute
    /// </summary>
    public unsafe virtual void UpdateBatmanPickupRoute()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateBatmanPickupRoute, "BmScript.RVehicleBatmobile.UpdateBatmanPickupRoute");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EjectToSpot;
    /// <summary>
    /// Function: EjectToSpot
    /// </summary>
    public unsafe override void EjectToSpot(System.Numerics.Vector3 EjectTarget, BmSDK.BmGame.RPawnPlayer Batman, BmSDK.BmGame.RSpecialMoveConfig OverrideMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EjectToSpot, "BmScript.RVehicleBatmobile.EjectToSpot");
        byte* paramsPtr = stackalloc byte[160];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EjectTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Batman, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMove, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PickUpPlayer;
    /// <summary>
    /// Function: PickUpPlayer
    /// </summary>
    public unsafe override void PickUpPlayer(BmSDK.BmGame.RPawnPlayer PlayerToPickUp, bool HighSpeedPickup = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickUpPlayer, "BmScript.RVehicleBatmobile.PickUpPlayer");
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerToPickUp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HighSpeedPickup, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestReachedWithoutPlayer;
    /// <summary>
    /// Function: DestReachedWithoutPlayer
    /// </summary>
    public unsafe virtual void DestReachedWithoutPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestReachedWithoutPlayer, "BmScript.RVehicleBatmobile.DestReachedWithoutPlayer");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestReachedBrakeToStop;
    /// <summary>
    /// Function: DestReachedBrakeToStop
    /// </summary>
    public unsafe override void DestReachedBrakeToStop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestReachedBrakeToStop, "BmScript.RVehicleBatmobile.DestReachedBrakeToStop");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SkidToStopJumpIn;
    /// <summary>
    /// Function: SkidToStopJumpIn
    /// </summary>
    public unsafe override void SkidToStopJumpIn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SkidToStopJumpIn, "BmScript.RVehicleBatmobile.SkidToStopJumpIn");
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestReachedSkidToStop;
    /// <summary>
    /// Function: DestReachedSkidToStop
    /// </summary>
    public unsafe override void DestReachedSkidToStop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestReachedSkidToStop, "BmScript.RVehicleBatmobile.DestReachedSkidToStop");
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanEnterVehicle;
    /// <summary>
    /// Function: CanEnterVehicle
    /// </summary>
    public unsafe override bool CanEnterVehicle(BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanEnterVehicle, "BmScript.RVehicleBatmobile.CanEnterVehicle");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PancakeOther;
    /// <summary>
    /// Function: PancakeOther
    /// </summary>
    public unsafe override void PancakeOther(BmSDK.Engine.Pawn Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PancakeOther, "BmScript.RVehicleBatmobile.PancakeOther");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindExitLocation;
    /// <summary>
    /// Function: FindExitLocation
    /// </summary>
    public unsafe virtual bool FindExitLocation(out BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindExitLocation, "BmScript.RVehicleBatmobile.FindExitLocation");
        byte* paramsPtr = stackalloc byte[148];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 132);
    }

    private static BmSDK.Function __fn_DriverLeave;
    /// <summary>
    /// Function: DriverLeave
    /// </summary>
    public unsafe override bool DriverLeave(bool bForceLeave, bool bReallyForceLeave = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DriverLeave, "BmScript.RVehicleBatmobile.DriverLeave");
        byte* paramsPtr = stackalloc byte[228];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceLeave, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReallyForceLeave, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AlertBatmanLeftCar;
    /// <summary>
    /// Function: AlertBatmanLeftCar
    /// </summary>
    public unsafe virtual void AlertBatmanLeftCar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertBatmanLeftCar, "BmScript.RVehicleBatmobile.AlertBatmanLeftCar");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RescueMe;
    /// <summary>
    /// Function: RescueMe
    /// </summary>
    public unsafe override bool RescueMe(bool FindOffScreenLocation = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RescueMe, "BmScript.RVehicleBatmobile.RescueMe");
        byte* paramsPtr = stackalloc byte[268];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FindOffScreenLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ChooseAlternateSpawnPoint;
    /// <summary>
    /// Function: ChooseAlternateSpawnPoint
    /// </summary>
    public unsafe virtual int ChooseAlternateSpawnPoint(out System.Numerics.Vector3 pos, out BmSDK.Rotator Rot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChooseAlternateSpawnPoint, "BmScript.RVehicleBatmobile.ChooseAlternateSpawnPoint");
        byte* paramsPtr = stackalloc byte[236];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        pos = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_TriggerWrongWayEvent;
    /// <summary>
    /// Function: TriggerWrongWayEvent
    /// </summary>
    public unsafe override void TriggerWrongWayEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerWrongWayEvent, "BmScript.RVehicleBatmobile.TriggerWrongWayEvent");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.RVehicleBatmobile.Tick");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoXrayUpdate;
    /// <summary>
    /// Function: DoXrayUpdate
    /// </summary>
    public unsafe override void DoXrayUpdate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoXrayUpdate, "BmScript.RVehicleBatmobile.DoXrayUpdate");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestTightAreas;
    /// <summary>
    /// Function: TestTightAreas
    /// </summary>
    public unsafe virtual void TestTightAreas()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestTightAreas, "BmScript.RVehicleBatmobile.TestTightAreas");
        byte* paramsPtr = stackalloc byte[188];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSleepRBPhysics;
    /// <summary>
    /// Function: OnSleepRBPhysics
    /// </summary>
    public unsafe override void OnSleepRBPhysics()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSleepRBPhysics, "BmScript.RVehicleBatmobile.OnSleepRBPhysics");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnWakeRBPhysics;
    /// <summary>
    /// Function: OnWakeRBPhysics
    /// </summary>
    public unsafe override void OnWakeRBPhysics()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWakeRBPhysics, "BmScript.RVehicleBatmobile.OnWakeRBPhysics");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DriverLeft;
    /// <summary>
    /// Function: DriverLeft
    /// </summary>
    public unsafe override void DriverLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DriverLeft, "BmScript.RVehicleBatmobile.DriverLeft");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DriverEnter;
    /// <summary>
    /// Function: DriverEnter
    /// </summary>
    public unsafe override bool DriverEnter(BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DriverEnter, "BmScript.RVehicleBatmobile.DriverEnter");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SpawnRightExhaustBurst;
    /// <summary>
    /// Function: SpawnRightExhaustBurst
    /// </summary>
    public unsafe override void SpawnRightExhaustBurst()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnRightExhaustBurst, "BmScript.RVehicleBatmobile.SpawnRightExhaustBurst");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnLeftExhaustBurst;
    /// <summary>
    /// Function: SpawnLeftExhaustBurst
    /// </summary>
    public unsafe override void SpawnLeftExhaustBurst()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnLeftExhaustBurst, "BmScript.RVehicleBatmobile.SpawnLeftExhaustBurst");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnSideExhaustBurst;
    /// <summary>
    /// Function: SpawnSideExhaustBurst
    /// </summary>
    public unsafe virtual void SpawnSideExhaustBurst()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSideExhaustBurst, "BmScript.RVehicleBatmobile.SpawnSideExhaustBurst");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnExhaustBurst;
    /// <summary>
    /// Function: SpawnExhaustBurst
    /// </summary>
    public unsafe override void SpawnExhaustBurst(bool bFront, bool bDoSideExhaustBurst)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnExhaustBurst, "BmScript.RVehicleBatmobile.SpawnExhaustBurst");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFront, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoSideExhaustBurst, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SlipstreamOff;
    /// <summary>
    /// Function: SlipstreamOff
    /// </summary>
    public unsafe virtual void SlipstreamOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SlipstreamOff, "BmScript.RVehicleBatmobile.SlipstreamOff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SlipstreamOn;
    /// <summary>
    /// Function: SlipstreamOn
    /// </summary>
    public unsafe virtual void SlipstreamOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SlipstreamOn, "BmScript.RVehicleBatmobile.SlipstreamOn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AfterburnerWarmupOff;
    /// <summary>
    /// Function: AfterburnerWarmupOff
    /// </summary>
    public unsafe override void AfterburnerWarmupOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AfterburnerWarmupOff, "BmScript.RVehicleBatmobile.AfterburnerWarmupOff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AfterburnerWarmupOn;
    /// <summary>
    /// Function: AfterburnerWarmupOn
    /// </summary>
    public unsafe override void AfterburnerWarmupOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AfterburnerWarmupOn, "BmScript.RVehicleBatmobile.AfterburnerWarmupOn");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAfterBurnerRumble;
    /// <summary>
    /// Function: SetAfterBurnerRumble
    /// </summary>
    public unsafe virtual void SetAfterBurnerRumble(bool bPlay, float fRumbleStrength)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAfterBurnerRumble, "BmScript.RVehicleBatmobile.SetAfterBurnerRumble");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlay, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fRumbleStrength, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AfterburnerOff;
    /// <summary>
    /// Function: AfterburnerOff
    /// </summary>
    public unsafe override void AfterburnerOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AfterburnerOff, "BmScript.RVehicleBatmobile.AfterburnerOff");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AfterburnerOn;
    /// <summary>
    /// Function: AfterburnerOn
    /// </summary>
    public unsafe override void AfterburnerOn(bool bFront = default, bool bDoSideExhaustBurst = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AfterburnerOn, "BmScript.RVehicleBatmobile.AfterburnerOn");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFront, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoSideExhaustBurst, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AfterburnerOnForDuration;
    /// <summary>
    /// Function: AfterburnerOnForDuration
    /// </summary>
    public unsafe override void AfterburnerOnForDuration(float Duration, bool bFront = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AfterburnerOnForDuration, "BmScript.RVehicleBatmobile.AfterburnerOnForDuration");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFront, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HeadlightsOff;
    /// <summary>
    /// Function: HeadlightsOff
    /// </summary>
    public unsafe override void HeadlightsOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HeadlightsOff, "BmScript.RVehicleBatmobile.HeadlightsOff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateBoostWarmup;
    /// <summary>
    /// Function: ActivateBoostWarmup
    /// </summary>
    public unsafe override void ActivateBoostWarmup(bool Activate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateBoostWarmup, "BmScript.RVehicleBatmobile.ActivateBoostWarmup");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Activate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerBoost;
    /// <summary>
    /// Function: TriggerBoost
    /// </summary>
    public unsafe override void TriggerBoost()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerBoost, "BmScript.RVehicleBatmobile.TriggerBoost");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToFallIn;
    /// <summary>
    /// Function: TryToFallIn
    /// </summary>
    public unsafe override void TryToFallIn(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToFallIn, "BmScript.RVehicleBatmobile.TryToFallIn");
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToGlideIn;
    /// <summary>
    /// Function: TryToGlideIn
    /// </summary>
    public unsafe override void TryToGlideIn(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToGlideIn, "BmScript.RVehicleBatmobile.TryToGlideIn");
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToDrive;
    /// <summary>
    /// Function: TryToDrive
    /// </summary>
    public unsafe override bool TryToDrive(BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToDrive, "BmScript.RVehicleBatmobile.TryToDrive");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetInBatmobileInstant;
    /// <summary>
    /// Function: GetInBatmobileInstant
    /// </summary>
    public unsafe override void GetInBatmobileInstant(BmSDK.BmGame.RPawnPlayer PlayerGettingIn, bool bEndOfMatinee = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInBatmobileInstant, "BmScript.RVehicleBatmobile.GetInBatmobileInstant");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerGettingIn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEndOfMatinee, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInBatmobile;
    /// <summary>
    /// Function: GetInBatmobile
    /// </summary>
    public unsafe override void GetInBatmobile(BmSDK.Engine.Pawn PlayerGettingIn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInBatmobile, "BmScript.RVehicleBatmobile.GetInBatmobile");
        byte* paramsPtr = stackalloc byte[148];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerGettingIn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckSpaceToGetOutOfBatmobileFromKismet;
    /// <summary>
    /// Function: CheckSpaceToGetOutOfBatmobileFromKismet
    /// </summary>
    public unsafe override BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileGetOutSpace CheckSpaceToGetOutOfBatmobileFromKismet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckSpaceToGetOutOfBatmobileFromKismet, "BmScript.RVehicleBatmobile.CheckSpaceToGetOutOfBatmobileFromKismet");
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileGetOutSpace>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.RVehicleBatmobile.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: GetInMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8352); }
    }

    /// <summary>
    /// ObjectProperty: GlideInMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideInMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8360); }
    }

    /// <summary>
    /// ObjectProperty: GlideBoostInMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideBoostInMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8368); }
    }

    /// <summary>
    /// ObjectProperty: FallInMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FallInMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8376); }
    }

    /// <summary>
    /// ObjectProperty: GetOutMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetOutMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8384); }
    }

    /// <summary>
    /// ObjectProperty: GetOutToStandFastMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetOutToStandFastMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8392); }
    }

    /// <summary>
    /// ObjectProperty: GetOutOnTopMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetOutOnTopMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8400); }
    }

    /// <summary>
    /// ObjectProperty: GetOutOnTopOnSteepInclineMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetOutOnTopOnSteepInclineMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8408); }
    }

    /// <summary>
    /// ObjectProperty: EjectUpMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EjectUpMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8416); }
    }

    /// <summary>
    /// ObjectProperty: EjectForwardMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EjectForwardMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8424); }
    }

    /// <summary>
    /// ObjectProperty: GetInRemoteMoveFront
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInRemoteMoveFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8432); }
    }

    /// <summary>
    /// ObjectProperty: GetInRemoteMoveBack
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInRemoteMoveBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8440); }
    }

    /// <summary>
    /// ObjectProperty: JumpInBatmobileSkidStopMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig JumpInBatmobileSkidStopMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8448); }
    }

    /// <summary>
    /// ObjectProperty: GetInWithoutAnimMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInWithoutAnimMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8456); }
    }

    /// <summary>
    /// ObjectProperty: EjectWhenBatmobileVerticalMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EjectWhenBatmobileVerticalMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8464); }
    }

    /// <summary>
    /// ObjectProperty: EjectUpWhenBatmobileVerticalMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EjectUpWhenBatmobileVerticalMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8472); }
    }

    /// <summary>
    /// ObjectProperty: GetInWhenBatmbileVerticalMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInWhenBatmbileVerticalMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8480); }
    }

    /// <summary>
    /// ObjectProperty: SwingInBatmobileAbseilingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SwingInBatmobileAbseilingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8488); }
    }

    /// <summary>
    /// ObjectProperty: EjectToSpotMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EjectToSpotMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8496); }
    }

    /// <summary>
    /// ObjectProperty: GetInOnSideMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInOnSideMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8504); }
    }

    /// <summary>
    /// ObjectProperty: GetOutOnSideMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetOutOnSideMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8512); }
    }

    /// <summary>
    /// ObjectProperty: HighSpeedPickupMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HighSpeedPickupMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8520); }
    }

    /// <summary>
    /// ObjectProperty: AfterburnerFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform AfterburnerFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 8528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8528); }
    }

    /// <summary>
    /// ObjectProperty: TaserSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TaserSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8536); }
    }

    /// <summary>
    /// ObjectProperty: StolenAction
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_SetBatmobileState StolenAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_SetBatmobileState>(Ptr + 8544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8544); }
    }

    /// <summary>
    /// ComponentProperty: DisabledByEmpFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent DisabledByEmpFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8552); }
    }

    /// <summary>
    /// IntProperty: GetOutOnTopOnSteepInclinePitch
    /// </summary>
    public unsafe int GetOutOnTopOnSteepInclinePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8560); }
    }

    /// <summary>
    /// BoolProperty: GlidingIn
    /// </summary>
    public unsafe bool GlidingIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8564); }
    }

    /// <summary>
    /// BoolProperty: bAfterburnerIsOn
    /// </summary>
    public unsafe bool bAfterburnerIsOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8564); }
    }

    /// <summary>
    /// BoolProperty: bBattleModeAfterBurnerIsOn
    /// </summary>
    public unsafe bool bBattleModeAfterBurnerIsOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8564); }
    }

    /// <summary>
    /// BoolProperty: bAfterburnerIsWarming
    /// </summary>
    public unsafe bool bAfterburnerIsWarming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8564); }
    }

    /// <summary>
    /// BoolProperty: XrayMaterialsAssigned
    /// </summary>
    public unsafe bool XrayMaterialsAssigned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8564); }
    }

    /// <summary>
    /// ArrayProperty: LeaveCarListeners
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RCarListenerInterface> LeaveCarListeners
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RCarListenerInterface>>(Ptr + 8568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8568); }
    }

    /// <summary>
    /// FloatProperty: fAfterburnerStartTime
    /// </summary>
    public unsafe float fAfterburnerStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8584); }
    }

    /// <summary>
    /// FloatProperty: fAfterBurnerRumbleStartStrength
    /// </summary>
    public unsafe float fAfterBurnerRumbleStartStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8588); }
    }

    /// <summary>
    /// FloatProperty: fAfterBurnerRumbleStrengthTimeMultiplier
    /// </summary>
    public unsafe float fAfterBurnerRumbleStrengthTimeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8592); }
    }

    /// <summary>
    /// FloatProperty: fAfterburnerCutoffStartTime
    /// </summary>
    public unsafe float fAfterburnerCutoffStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8596); }
    }

    /// <summary>
    /// FloatProperty: fAfterBurnerRumbleCutoffStartStrength
    /// </summary>
    public unsafe float fAfterBurnerRumbleCutoffStartStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8600); }
    }

    /// <summary>
    /// FloatProperty: fAfterBurnerRumbleCutoffTimeMultiplier
    /// </summary>
    public unsafe float fAfterBurnerRumbleCutoffTimeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8604); }
    }

    /// <summary>
    /// ArrayProperty: UpgradedGeneratorBonus
    /// </summary>
    public unsafe BmSDK.TArray<float> UpgradedGeneratorBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 8608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8608); }
    }

    /// <summary>
    /// ArrayProperty: UpgradedGeneratorShielding
    /// </summary>
    public unsafe BmSDK.TArray<float> UpgradedGeneratorShielding
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 8624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8624); }
    }
}
