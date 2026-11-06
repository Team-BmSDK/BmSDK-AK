#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RVehicleNPC<br/>
/// (size = 7620)
/// (flags = 144704183)
/// </summary>
public partial class RVehicleNPC : BmSDK.BmGame.RVehicle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleNPC", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RVehicleNPC.
    /// </summary>
    public static RVehicleNPC DefaultObject => (RVehicleNPC)StaticClass().DefaultObject;

    internal RVehicleNPC() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleNPC(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleNPC>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPC>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleNPC>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPC>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPC>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPC>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleNPC>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPC>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_FreezeAttackDestroyTarget;
    /// <summary>
    /// Function: FreezeAttackDestroyTarget
    /// </summary>
    public unsafe virtual void FreezeAttackDestroyTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FreezeAttackDestroyTarget, "BmGame.RVehicleNPC.FreezeAttackDestroyTarget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StoreTurretLockedAngle;
    /// <summary>
    /// Function: StoreTurretLockedAngle
    /// </summary>
    public unsafe virtual void StoreTurretLockedAngle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StoreTurretLockedAngle, "BmGame.RVehicleNPC.StoreTurretLockedAngle");
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

    private static BmSDK.Function __fn_DelayedDestroyForEndChallenge;
    /// <summary>
    /// Function: DelayedDestroyForEndChallenge
    /// </summary>
    public unsafe override void DelayedDestroyForEndChallenge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DelayedDestroyForEndChallenge, "BmGame.RVehicleNPC.DelayedDestroyForEndChallenge");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHealthBarVisibility;
    /// <summary>
    /// Function: UpdateHealthBarVisibility
    /// </summary>
    public unsafe virtual void UpdateHealthBarVisibility()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHealthBarVisibility, "BmGame.RVehicleNPC.UpdateHealthBarVisibility");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMissileTargetLocation;
    /// <summary>
    /// Function: GetMissileTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetMissileTargetLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMissileTargetLocation, "BmGame.RVehicleNPC.GetMissileTargetLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetWeaponLockOnLocation;
    /// <summary>
    /// Function: GetWeaponLockOnLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetWeaponLockOnLocation(out int InSight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponLockOnLocation, "BmGame.RVehicleNPC.GetWeaponLockOnLocation");
        byte* paramsPtr = stackalloc byte[16];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InSight);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSight, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        InSight = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FellOutOfWorld;
    /// <summary>
    /// Function: FellOutOfWorld
    /// </summary>
    public unsafe override void FellOutOfWorld(BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FellOutOfWorld, "BmGame.RVehicleNPC.FellOutOfWorld");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OutsideWorldBounds;
    /// <summary>
    /// Function: OutsideWorldBounds
    /// </summary>
    public unsafe override void OutsideWorldBounds()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OutsideWorldBounds, "BmGame.RVehicleNPC.OutsideWorldBounds");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyBumpedByBatmobile;
    /// <summary>
    /// Function: NotifyBumpedByBatmobile
    /// </summary>
    public unsafe virtual void NotifyBumpedByBatmobile(BmSDK.BmGame.RVehicleBatmobileBase Batmobile, System.Numerics.Vector3 ContactPos, float Speed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyBumpedByBatmobile, "BmGame.RVehicleNPC.NotifyBumpedByBatmobile");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Batmobile, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactPos, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerSpotted;
    /// <summary>
    /// Function: PlayerSpotted
    /// </summary>
    public unsafe virtual void PlayerSpotted(BmSDK.Engine.Actor Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerSpotted, "BmGame.RVehicleNPC.PlayerSpotted");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
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

    private static BmSDK.Function __fn_DeactivateCounterIcon;
    /// <summary>
    /// Function: DeactivateCounterIcon
    /// </summary>
    public unsafe virtual void DeactivateCounterIcon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivateCounterIcon, "BmGame.RVehicleNPC.DeactivateCounterIcon");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateCounterIcon;
    /// <summary>
    /// Function: ActivateCounterIcon
    /// </summary>
    public unsafe virtual void ActivateCounterIcon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateCounterIcon, "BmGame.RVehicleNPC.ActivateCounterIcon");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponHit;
    /// <summary>
    /// Function: WeaponHit
    /// </summary>
    public unsafe virtual void WeaponHit(BmSDK.BmGame.RProjectile Proj, BmSDK.Engine.Actor HitActor, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponHit, "BmGame.RVehicleNPC.WeaponHit");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proj, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitActor, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FollowVehicleStopped;
    /// <summary>
    /// Function: FollowVehicleStopped
    /// </summary>
    public unsafe virtual void FollowVehicleStopped()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FollowVehicleStopped, "BmGame.RVehicleNPC.FollowVehicleStopped");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartTakeoffWheelspin;
    /// <summary>
    /// Function: StartTakeoffWheelspin
    /// </summary>
    public unsafe virtual void StartTakeoffWheelspin(float Duration)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartTakeoffWheelspin, "BmGame.RVehicleNPC.StartTakeoffWheelspin");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DroneHackerExplosion;
    /// <summary>
    /// Function: DroneHackerExplosion
    /// </summary>
    public unsafe virtual void DroneHackerExplosion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DroneHackerExplosion, "BmGame.RVehicleNPC.DroneHackerExplosion");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DroneHackedSuicide;
    /// <summary>
    /// Function: DroneHackedSuicide
    /// </summary>
    public unsafe virtual void DroneHackedSuicide()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DroneHackedSuicide, "BmGame.RVehicleNPC.DroneHackedSuicide");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DroneBombSuicide;
    /// <summary>
    /// Function: DroneBombSuicide
    /// </summary>
    public unsafe virtual void DroneBombSuicide()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DroneBombSuicide, "BmGame.RVehicleNPC.DroneBombSuicide");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SurprisedByDamage;
    /// <summary>
    /// Function: SurprisedByDamage
    /// </summary>
    public unsafe virtual void SurprisedByDamage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SurprisedByDamage, "BmGame.RVehicleNPC.SurprisedByDamage");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAwareOfPlayer;
    /// <summary>
    /// Function: SetAwareOfPlayer
    /// </summary>
    public unsafe virtual void SetAwareOfPlayer(bool bAware)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAwareOfPlayer, "BmGame.RVehicleNPC.SetAwareOfPlayer");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAware, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ForceInCombatTimer;
    /// <summary>
    /// Function: ForceInCombatTimer
    /// </summary>
    public unsafe virtual void ForceInCombatTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceInCombatTimer, "BmGame.RVehicleNPC.ForceInCombatTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayDeathBarks;
    /// <summary>
    /// Function: PlayDeathBarks
    /// </summary>
    public unsafe virtual void PlayDeathBarks()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDeathBarks, "BmGame.RVehicleNPC.PlayDeathBarks");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceInCombat;
    /// <summary>
    /// Function: ForceInCombat
    /// </summary>
    public unsafe virtual void ForceInCombat(float ForceTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceInCombat, "BmGame.RVehicleNPC.ForceInCombat");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllPassengersSpawned;
    /// <summary>
    /// Function: AllPassengersSpawned
    /// </summary>
    public unsafe virtual void AllPassengersSpawned()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllPassengersSpawned, "BmGame.RVehicleNPC.AllPassengersSpawned");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawIndependentWeaponWarningHUD;
    /// <summary>
    /// Function: DrawIndependentWeaponWarningHUD
    /// </summary>
    public unsafe virtual void DrawIndependentWeaponWarningHUD()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawIndependentWeaponWarningHUD, "BmGame.RVehicleNPC.DrawIndependentWeaponWarningHUD");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireChargedCannonAttack;
    /// <summary>
    /// Function: FireChargedCannonAttack
    /// </summary>
    public unsafe virtual void FireChargedCannonAttack(BmSDK.BmGame.RVehicleNPC.FWalkerWeaponContainer WalkerWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireChargedCannonAttack, "BmGame.RVehicleNPC.FireChargedCannonAttack");
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WalkerWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireMortarAttack;
    /// <summary>
    /// Function: FireMortarAttack
    /// </summary>
    public unsafe virtual void FireMortarAttack(BmSDK.BmGame.RVehicleNPC.FWalkerWeaponContainer WalkerWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireMortarAttack, "BmGame.RVehicleNPC.FireMortarAttack");
        byte* paramsPtr = stackalloc byte[124];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WalkerWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireCannonAttack;
    /// <summary>
    /// Function: FireCannonAttack
    /// </summary>
    public unsafe virtual void FireCannonAttack(BmSDK.BmGame.RVehicleNPC.FWalkerWeaponContainer WalkerWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireCannonAttack, "BmGame.RVehicleNPC.FireCannonAttack");
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WalkerWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProjectileInFlight;
    /// <summary>
    /// Function: ProjectileInFlight
    /// </summary>
    public unsafe virtual void ProjectileInFlight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProjectileInFlight, "BmGame.RVehicleNPC.ProjectileInFlight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireRocketAttack;
    /// <summary>
    /// Function: FireRocketAttack
    /// </summary>
    public unsafe virtual void FireRocketAttack(BmSDK.BmGame.RVehicleNPC.FWalkerWeaponContainer WalkerWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireRocketAttack, "BmGame.RVehicleNPC.FireRocketAttack");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WalkerWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireMissileAttack;
    /// <summary>
    /// Function: FireMissileAttack
    /// </summary>
    public unsafe virtual void FireMissileAttack(BmSDK.BmGame.RVehicleNPC.FWalkerWeaponContainer WalkerWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireMissileAttack, "BmGame.RVehicleNPC.FireMissileAttack");
        byte* paramsPtr = stackalloc byte[124];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WalkerWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBarrageDelay;
    /// <summary>
    /// Function: GetBarrageDelay
    /// </summary>
    public unsafe virtual float GetBarrageDelay(BmSDK.BmGame.RVehicleNPC.EWalkerWeaponTypes Type)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBarrageDelay, "BmGame.RVehicleNPC.GetBarrageDelay");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBarrageSize;
    /// <summary>
    /// Function: GetBarrageSize
    /// </summary>
    public unsafe virtual int GetBarrageSize(BmSDK.BmGame.RVehicleNPC.EWalkerWeaponTypes Type)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBarrageSize, "BmGame.RVehicleNPC.GetBarrageSize");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateIndependentWeapons;
    /// <summary>
    /// Function: UpdateIndependentWeapons
    /// </summary>
    public unsafe virtual void UpdateIndependentWeapons(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateIndependentWeapons, "BmGame.RVehicleNPC.UpdateIndependentWeapons");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndDroneHack;
    /// <summary>
    /// Function: EndDroneHack
    /// </summary>
    public unsafe virtual void EndDroneHack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndDroneHack, "BmGame.RVehicleNPC.EndDroneHack");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginDroneHack;
    /// <summary>
    /// Function: BeginDroneHack
    /// </summary>
    public unsafe virtual void BeginDroneHack(BmSDK.BmGame.RVehicle Hacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginDroneHack, "BmGame.RVehicleNPC.BeginDroneHack");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Hacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnVehiclePassengers;
    /// <summary>
    /// Function: SpawnVehiclePassengers
    /// </summary>
    public unsafe virtual void SpawnVehiclePassengers(out BmSDK.TArray<BmSDK.Engine.Pawn> SpawnedPassengers, BmSDK.Engine.Pawn BatmanPawn = default, BmSDK.BmGame.RVehicleNPCWeapon PassengerWeaponArchetype = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnVehiclePassengers, "BmGame.RVehicleNPC.SpawnVehiclePassengers");
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanPawn, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PassengerWeaponArchetype, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SpawnedPassengers = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Pawn>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetAsFriendlyVehicle;
    /// <summary>
    /// Function: SetAsFriendlyVehicle
    /// </summary>
    public unsafe virtual void SetAsFriendlyVehicle(bool Friendly)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAsFriendlyVehicle, "BmGame.RVehicleNPC.SetAsFriendlyVehicle");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Friendly, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OverrideVehicleTakedownPrompt;
    /// <summary>
    /// Function: OverrideVehicleTakedownPrompt
    /// </summary>
    public unsafe virtual void OverrideVehicleTakedownPrompt(out BmSDK.FString TakedownPrompt)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideVehicleTakedownPrompt, "BmGame.RVehicleNPC.OverrideVehicleTakedownPrompt");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TakedownPrompt = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ExplodeMe;
    /// <summary>
    /// Function: ExplodeMe
    /// </summary>
    public unsafe virtual void ExplodeMe()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExplodeMe, "BmGame.RVehicleNPC.ExplodeMe");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmobileHackTimeout;
    /// <summary>
    /// Function: BatmobileHackTimeout
    /// </summary>
    public unsafe virtual void BatmobileHackTimeout()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmobileHackTimeout, "BmGame.RVehicleNPC.BatmobileHackTimeout");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchAllegiance;
    /// <summary>
    /// Function: SwitchAllegiance
    /// </summary>
    public unsafe virtual bool SwitchAllegiance(float HackDuration)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchAllegiance, "BmGame.RVehicleNPC.SwitchAllegiance");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackDuration, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TakeDamageVehicleAsBomb;
    /// <summary>
    /// Function: TakeDamageVehicleAsBomb
    /// </summary>
    public unsafe virtual bool TakeDamageVehicleAsBomb(int DamageAmount, BmSDK.Engine.Controller EventInstigator)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamageVehicleAsBomb, "BmGame.RVehicleNPC.TakeDamageVehicleAsBomb");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetVehicleAsBomb;
    /// <summary>
    /// Function: SetVehicleAsBomb
    /// </summary>
    public unsafe virtual void SetVehicleAsBomb(float Expiry, int BombHealth, bool IsBombEMP)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVehicleAsBomb, "BmGame.RVehicleNPC.SetVehicleAsBomb");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Expiry, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BombHealth, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsBombEMP, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndOracleHack;
    /// <summary>
    /// Function: EndOracleHack
    /// </summary>
    public unsafe virtual void EndOracleHack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndOracleHack, "BmGame.RVehicleNPC.EndOracleHack");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginOracleHack;
    /// <summary>
    /// Function: BeginOracleHack
    /// </summary>
    public unsafe virtual void BeginOracleHack(float HackDuration, BmSDK.FString HackType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginOracleHack, "BmGame.RVehicleNPC.BeginOracleHack");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackDuration, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetachFromWinch;
    /// <summary>
    /// Function: DetachFromWinch
    /// </summary>
    public unsafe virtual void DetachFromWinch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachFromWinch, "BmGame.RVehicleNPC.DetachFromWinch");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WinchAttached;
    /// <summary>
    /// Function: WinchAttached
    /// </summary>
    public unsafe virtual void WinchAttached(BmSDK.BmGame.RBatmobileWinch Winch, System.Numerics.Vector3 pos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WinchAttached, "BmGame.RVehicleNPC.WinchAttached");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winch, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverrideVehicleTakedown;
    /// <summary>
    /// Function: OverrideVehicleTakedown
    /// </summary>
    public unsafe virtual bool OverrideVehicleTakedown(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideVehicleTakedown, "BmGame.RVehicleNPC.OverrideVehicleTakedown");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_MakeWheelsFallOff;
    /// <summary>
    /// Function: MakeWheelsFallOff
    /// </summary>
    public unsafe virtual void MakeWheelsFallOff(bool FrontWheels, bool RearWheels)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeWheelsFallOff, "BmGame.RVehicleNPC.MakeWheelsFallOff");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FrontWheels, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RearWheels, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitVehiclePassengerIdleInfoFromPreset;
    /// <summary>
    /// Function: InitVehiclePassengerIdleInfoFromPreset
    /// </summary>
    public unsafe virtual void InitVehiclePassengerIdleInfoFromPreset(out BmSDK.BmGame.RVehicleNPC.FVehiclePassengerIdleInfo InfoOut, int SeatIndex, BmSDK.BmGame.RVehicleNPC.VehiclePassengerIdleType IdleType, BmSDK.BmGame.RVehicleNPC.FVehiclePassengerIdleInfo InfoCustom)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitVehiclePassengerIdleInfoFromPreset, "BmGame.RVehicleNPC.InitVehiclePassengerIdleInfoFromPreset");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SeatIndex, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdleType, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfoCustom, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        InfoOut = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RVehicleNPC.FVehiclePassengerIdleInfo>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetImpactAudioEvent;
    /// <summary>
    /// Function: GetImpactAudioEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetImpactAudioEvent(BmSDK.Engine.AkWwise.EAkWorldMaterial Mat)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetImpactAudioEvent, "BmGame.RVehicleNPC.GetImpactAudioEvent");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnMGBulletFX;
    /// <summary>
    /// Function: SpawnMGBulletFX
    /// </summary>
    public unsafe virtual void SpawnMGBulletFX(System.Numerics.Vector3 StartLoc, BmSDK.Engine.Actor.FImpactInfo Impact)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnMGBulletFX, "BmGame.RVehicleNPC.SpawnMGBulletFX");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Impact, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalcMGImpact;
    /// <summary>
    /// Function: CalcMGImpact
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor.FImpactInfo CalcMGImpact(System.Numerics.Vector3 StartTrace, System.Numerics.Vector3 EndTrace, bool bForceMiss)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalcMGImpact, "BmGame.RVehicleNPC.CalcMGImpact");
        byte* paramsPtr = stackalloc byte[292];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTrace, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndTrace, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceMiss, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FImpactInfo>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetRandDeviance;
    /// <summary>
    /// Function: GetRandDeviance
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRandDeviance(BmSDK.Rotator Heading)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRandDeviance, "BmGame.RVehicleNPC.GetRandDeviance");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Heading, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ShouldForceMissedShot;
    /// <summary>
    /// Function: ShouldForceMissedShot
    /// </summary>
    public unsafe virtual bool ShouldForceMissedShot(BmSDK.BmGame.RPawnPlayer TargetPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceMissedShot, "BmGame.RVehicleNPC.ShouldForceMissedShot");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetMachineGunActive;
    /// <summary>
    /// Function: SetMachineGunActive
    /// </summary>
    public unsafe virtual void SetMachineGunActive(bool is_active)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMachineGunActive, "BmGame.RVehicleNPC.SetMachineGunActive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireMachineGunAtLocation;
    /// <summary>
    /// Function: FireMachineGunAtLocation
    /// </summary>
    public unsafe virtual void FireMachineGunAtLocation(System.Numerics.Vector3 ShootAtLocation, bool bForceMiss)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireMachineGunAtLocation, "BmGame.RVehicleNPC.FireMachineGunAtLocation");
        byte* paramsPtr = stackalloc byte[408];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShootAtLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceMiss, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireMachineGunNow;
    /// <summary>
    /// Function: FireMachineGunNow
    /// </summary>
    public unsafe virtual void FireMachineGunNow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireMachineGunNow, "BmGame.RVehicleNPC.FireMachineGunNow");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MachineGunOff;
    /// <summary>
    /// Function: MachineGunOff
    /// </summary>
    public unsafe virtual void MachineGunOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MachineGunOff, "BmGame.RVehicleNPC.MachineGunOff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginMachineGunAttack;
    /// <summary>
    /// Function: BeginMachineGunAttack
    /// </summary>
    public unsafe virtual void BeginMachineGunAttack(BmSDK.Engine.Actor Target, float Duration = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginMachineGunAttack, "BmGame.RVehicleNPC.BeginMachineGunAttack");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsAwareOfBatmobile;
    /// <summary>
    /// Function: IsAwareOfBatmobile
    /// </summary>
    public unsafe virtual bool IsAwareOfBatmobile()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAwareOfBatmobile, "BmGame.RVehicleNPC.IsAwareOfBatmobile");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetAwareOfBatmobile;
    /// <summary>
    /// Function: SetAwareOfBatmobile
    /// </summary>
    public unsafe virtual void SetAwareOfBatmobile(float AwareDuration, BmSDK.BmGame.RVehicleBatmobileBase Batmobile)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAwareOfBatmobile, "BmGame.RVehicleNPC.SetAwareOfBatmobile");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AwareDuration, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Batmobile, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayBarkDriver;
    /// <summary>
    /// Function: PlayBarkDriver
    /// </summary>
    public unsafe virtual bool PlayBarkDriver(BmSDK.FName EventID, int Priority = default, BmSDK.Engine.Pawn OtherConvoPawn = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBarkDriver, "BmGame.RVehicleNPC.PlayBarkDriver");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherConvoPawn, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_PlayBarkPassenger;
    /// <summary>
    /// Function: PlayBarkPassenger
    /// </summary>
    public unsafe virtual bool PlayBarkPassenger(BmSDK.Engine.Pawn PassengerPawn, BmSDK.Engine.Pawn OtherConvoPawn, BmSDK.FName EventID, int Priority = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBarkPassenger, "BmGame.RVehicleNPC.PlayBarkPassenger");
        byte* paramsPtr = stackalloc byte[96];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PassengerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherConvoPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_IsPlayerInActivePredVolume;
    /// <summary>
    /// Function: IsPlayerInActivePredVolume
    /// </summary>
    public unsafe virtual bool IsPlayerInActivePredVolume()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayerInActivePredVolume, "BmGame.RVehicleNPC.IsPlayerInActivePredVolume");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayDelayedDriverBark;
    /// <summary>
    /// Function: PlayDelayedDriverBark
    /// </summary>
    public unsafe void PlayDelayedDriverBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDelayedDriverBark, "BmGame.RVehicleNPC.PlayDelayedDriverBark");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayBarkDriverDelayed;
    /// <summary>
    /// Function: PlayBarkDriverDelayed
    /// </summary>
    public unsafe virtual void PlayBarkDriverDelayed(BmSDK.FName EventID, float Delay, int Priority = default, BmSDK.Engine.Pawn OtherConvoPawn = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBarkDriverDelayed, "BmGame.RVehicleNPC.PlayBarkDriverDelayed");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delay, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherConvoPawn, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyWeaponFire;
    /// <summary>
    /// Function: NotifyWeaponFire
    /// </summary>
    public unsafe virtual void NotifyWeaponFire(BmSDK.BmGame.RVehicleWeapon FiringWeapon, System.Numerics.Vector3 WeaponOrigin, System.Numerics.Vector3 FireDirection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyWeaponFire, "BmGame.RVehicleNPC.NotifyWeaponFire");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FiringWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponOrigin, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireDirection, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIndoorVision;
    /// <summary>
    /// Function: SetIndoorVision
    /// </summary>
    public unsafe virtual void SetIndoorVision(bool NewIndoorVision)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIndoorVision, "BmGame.RVehicleNPC.SetIndoorVision");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewIndoorVision, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnTeleport;
    /// <summary>
    /// Function: OnTeleport
    /// </summary>
    public unsafe override void OnTeleport(BmSDK.Engine.SeqAct_Teleport Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnTeleport, "BmGame.RVehicleNPC.OnTeleport");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetActorThoughts;
    /// <summary>
    /// Function: GetActorThoughts
    /// </summary>
    public unsafe override void GetActorThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList, out System.Numerics.Vector3 ThoughtLocationOverride, BmSDK.FString IndentString = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActorThoughts, "BmGame.RVehicleNPC.GetActorThoughts");
        byte* paramsPtr = stackalloc byte[84];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThoughtLocationOverride);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThoughtLocationOverride, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IndentString, paramsPtr + 28);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        ThoughtLocationOverride = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_PancakeOther;
    /// <summary>
    /// Function: PancakeOther
    /// </summary>
    public unsafe override void PancakeOther(BmSDK.Engine.Pawn Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PancakeOther, "BmGame.RVehicleNPC.PancakeOther");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePawnFading;
    /// <summary>
    /// Function: UpdatePawnFading
    /// </summary>
    public unsafe virtual void UpdatePawnFading(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePawnFading, "BmGame.RVehicleNPC.UpdatePawnFading");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeAndDestroyPawn;
    /// <summary>
    /// Function: FadeAndDestroyPawn
    /// </summary>
    public unsafe virtual void FadeAndDestroyPawn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeAndDestroyPawn, "BmGame.RVehicleNPC.FadeAndDestroyPawn");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartFadeIn;
    /// <summary>
    /// Function: StartFadeIn
    /// </summary>
    public unsafe virtual void StartFadeIn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFadeIn, "BmGame.RVehicleNPC.StartFadeIn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RVehicleNPC.PreStreamOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RVehicleNPC.Destroyed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyPassengers;
    /// <summary>
    /// Function: DestroyPassengers
    /// </summary>
    public unsafe virtual void DestroyPassengers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyPassengers, "BmGame.RVehicleNPC.DestroyPassengers");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BreakOffDoor;
    /// <summary>
    /// Function: BreakOffDoor
    /// </summary>
    public unsafe virtual void BreakOffDoor(BmSDK.FName DoorName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BreakOffDoor, "BmGame.RVehicleNPC.BreakOffDoor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DoorName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BreakOffDoorForSlot;
    /// <summary>
    /// Function: BreakOffDoorForSlot
    /// </summary>
    public unsafe virtual void BreakOffDoorForSlot(int Slot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BreakOffDoorForSlot, "BmGame.RVehicleNPC.BreakOffDoorForSlot");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Slot, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSlotForPassenger;
    /// <summary>
    /// Function: GetSlotForPassenger
    /// </summary>
    public unsafe virtual int GetSlotForPassenger(BmSDK.BmGame.RBMPawnAI Passenger)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSlotForPassenger, "BmGame.RVehicleNPC.GetSlotForPassenger");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Passenger, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PassengerHasEnteredInternal;
    /// <summary>
    /// Function: PassengerHasEnteredInternal
    /// </summary>
    public unsafe virtual void PassengerHasEnteredInternal(BmSDK.BmGame.RBMPawnAI NewPassenger, int SlotID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PassengerHasEnteredInternal, "BmGame.RVehicleNPC.PassengerHasEnteredInternal");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPassenger, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PassengerHasEntered;
    /// <summary>
    /// Function: PassengerHasEntered
    /// </summary>
    public unsafe virtual bool PassengerHasEntered(BmSDK.BmGame.RBMPawnAI NewPassenger)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PassengerHasEntered, "BmGame.RVehicleNPC.PassengerHasEntered");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPassenger, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UnassignEnteringPassenger;
    /// <summary>
    /// Function: UnassignEnteringPassenger
    /// </summary>
    public unsafe virtual void UnassignEnteringPassenger(BmSDK.BmGame.RBMPawnAI PassengerToRemove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnassignEnteringPassenger, "BmGame.RVehicleNPC.UnassignEnteringPassenger");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PassengerToRemove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEnterAnimInfo;
    /// <summary>
    /// Function: GetEnterAnimInfo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.FEnterVehicleAnimInfo GetEnterAnimInfo(int Slot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEnterAnimInfo, "BmGame.RVehicleNPC.GetEnterAnimInfo");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Slot, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.FEnterVehicleAnimInfo>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TryAssignToSlot;
    /// <summary>
    /// Function: TryAssignToSlot
    /// </summary>
    public unsafe virtual bool TryAssignToSlot(BmSDK.BmGame.RBMPawnAI NewPassenger, int PassengerSlot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryAssignToSlot, "BmGame.RVehicleNPC.TryAssignToSlot");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPassenger, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PassengerSlot, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_AssignToPassengerSlot;
    /// <summary>
    /// Function: AssignToPassengerSlot
    /// </summary>
    public unsafe virtual bool AssignToPassengerSlot(BmSDK.BmGame.RBMPawnAI NewPassenger, out int PassengerSlot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignToPassengerSlot, "BmGame.RVehicleNPC.AssignToPassengerSlot");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPassenger, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PassengerSlot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PassengerSlot, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PassengerSlot = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PlayDoorAnim;
    /// <summary>
    /// Function: PlayDoorAnim
    /// </summary>
    public unsafe virtual bool PlayDoorAnim(int PassengerSlot, BmSDK.FName AnimName, BmSDK.Engine.AnimSet ExtraAnimSet = default, float ThugRateScale = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDoorAnim, "BmGame.RVehicleNPC.PlayDoorAnim");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PassengerSlot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraAnimSet, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugRateScale, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_IsDoorIntact;
    /// <summary>
    /// Function: IsDoorIntact
    /// </summary>
    public unsafe virtual bool IsDoorIntact(int PassengerSlot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDoorIntact, "BmGame.RVehicleNPC.IsDoorIntact");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PassengerSlot, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetComboTimer;
    /// <summary>
    /// Function: GetComboTimer
    /// </summary>
    public unsafe virtual float GetComboTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboTimer, "BmGame.RVehicleNPC.GetComboTimer");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ReverseFormation;
    /// <summary>
    /// Function: ReverseFormation
    /// </summary>
    public unsafe virtual void ReverseFormation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReverseFormation, "BmGame.RVehicleNPC.ReverseFormation");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveJoiner;
    /// <summary>
    /// Function: RemoveJoiner
    /// </summary>
    public unsafe virtual void RemoveJoiner(BmSDK.BmGame.RVehicleNPC Joiner)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveJoiner, "BmGame.RVehicleNPC.RemoveJoiner");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Joiner, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddJoiner;
    /// <summary>
    /// Function: AddJoiner
    /// </summary>
    public unsafe virtual void AddJoiner(BmSDK.BmGame.RVehicleNPC Joiner)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddJoiner, "BmGame.RVehicleNPC.AddJoiner");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Joiner, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RemoveFollower;
    /// <summary>
    /// Function: RemoveFollower
    /// </summary>
    public unsafe virtual void RemoveFollower(BmSDK.BmGame.RVehicleNPC follower)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveFollower, "BmGame.RVehicleNPC.RemoveFollower");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(follower, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddFollower;
    /// <summary>
    /// Function: AddFollower
    /// </summary>
    public unsafe virtual void AddFollower(BmSDK.BmGame.RVehicleNPC follower)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFollower, "BmGame.RVehicleNPC.AddFollower");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(follower, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateFollowers;
    /// <summary>
    /// Function: UpdateFollowers
    /// </summary>
    public unsafe virtual void UpdateFollowers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFollowers, "BmGame.RVehicleNPC.UpdateFollowers");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowOnHud;
    /// <summary>
    /// Function: ShowOnHud
    /// </summary>
    public unsafe virtual void ShowOnHud(bool show)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowOnHud, "BmGame.RVehicleNPC.ShowOnHud");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInCombat;
    /// <summary>
    /// Function: SetInCombat
    /// </summary>
    public unsafe virtual void SetInCombat(bool bInCombat)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInCombat, "BmGame.RVehicleNPC.SetInCombat");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInCombat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HeavyWeaponImpact;
    /// <summary>
    /// Function: HeavyWeaponImpact
    /// </summary>
    public unsafe virtual void HeavyWeaponImpact(System.Numerics.Vector3 InvestigateLoc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HeavyWeaponImpact, "BmGame.RVehicleNPC.HeavyWeaponImpact");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InvestigateLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAttackTimeBonus;
    /// <summary>
    /// Function: GetAttackTimeBonus
    /// </summary>
    public unsafe virtual float GetAttackTimeBonus(int WeaponID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAttackTimeBonus, "BmGame.RVehicleNPC.GetAttackTimeBonus");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNumSimultaneousAttackSlots;
    /// <summary>
    /// Function: GetNumSimultaneousAttackSlots
    /// </summary>
    public unsafe virtual int GetNumSimultaneousAttackSlots(int WeaponIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumSimultaneousAttackSlots, "BmGame.RVehicleNPC.GetNumSimultaneousAttackSlots");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsAttacking;
    /// <summary>
    /// Function: IsAttacking
    /// </summary>
    public unsafe virtual bool IsAttacking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAttacking, "BmGame.RVehicleNPC.IsAttacking");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayRiotHorn;
    /// <summary>
    /// Function: PlayRiotHorn
    /// </summary>
    public unsafe virtual void PlayRiotHorn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayRiotHorn, "BmGame.RVehicleNPC.PlayRiotHorn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RandomizeRiotHorn;
    /// <summary>
    /// Function: RandomizeRiotHorn
    /// </summary>
    public unsafe virtual void RandomizeRiotHorn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RandomizeRiotHorn, "BmGame.RVehicleNPC.RandomizeRiotHorn");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefreshInActiveRiotZone;
    /// <summary>
    /// Function: RefreshInActiveRiotZone
    /// </summary>
    public unsafe virtual void RefreshInActiveRiotZone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshInActiveRiotZone, "BmGame.RVehicleNPC.RefreshInActiveRiotZone");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InActiveRiotZone;
    /// <summary>
    /// Function: InActiveRiotZone
    /// </summary>
    public unsafe virtual bool InActiveRiotZone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InActiveRiotZone, "BmGame.RVehicleNPC.InActiveRiotZone");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_IsNearSpawnedWanderers;
    /// <summary>
    /// Function: IsNearSpawnedWanderers
    /// </summary>
    public unsafe virtual bool IsNearSpawnedWanderers(float Range)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNearSpawnedWanderers, "BmGame.RVehicleNPC.IsNearSpawnedWanderers");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Range, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GotoGuardBehaviour;
    /// <summary>
    /// Function: GotoGuardBehaviour
    /// </summary>
    public unsafe virtual void GotoGuardBehaviour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoGuardBehaviour, "BmGame.RVehicleNPC.GotoGuardBehaviour");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoCombatBehaviour;
    /// <summary>
    /// Function: GotoCombatBehaviour
    /// </summary>
    public unsafe virtual void GotoCombatBehaviour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoCombatBehaviour, "BmGame.RVehicleNPC.GotoCombatBehaviour");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InCombatBehaviour;
    /// <summary>
    /// Function: InCombatBehaviour
    /// </summary>
    public unsafe virtual bool InCombatBehaviour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InCombatBehaviour, "BmGame.RVehicleNPC.InCombatBehaviour");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DeathExplosionRumble;
    /// <summary>
    /// Function: DeathExplosionRumble
    /// </summary>
    public unsafe virtual void DeathExplosionRumble()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeathExplosionRumble, "BmGame.RVehicleNPC.DeathExplosionRumble");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToEnterAttackBehaviour;
    /// <summary>
    /// Function: TryToEnterAttackBehaviour
    /// </summary>
    public unsafe virtual void TryToEnterAttackBehaviour(BmSDK.Engine.Actor Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToEnterAttackBehaviour, "BmGame.RVehicleNPC.TryToEnterAttackBehaviour");
        byte* paramsPtr = stackalloc byte[220];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInAttackBehaviour;
    /// <summary>
    /// Function: IsInAttackBehaviour
    /// </summary>
    public unsafe virtual bool IsInAttackBehaviour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInAttackBehaviour, "BmGame.RVehicleNPC.IsInAttackBehaviour");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanAttackTarget;
    /// <summary>
    /// Function: CanAttackTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RVehicleNPC.ECanAttackTargetResult CanAttackTarget(BmSDK.Engine.Actor Target, int WeaponID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanAttackTarget, "BmGame.RVehicleNPC.CanAttackTarget");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RVehicleNPC.ECanAttackTargetResult>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_InCombat;
    /// <summary>
    /// Function: InCombat
    /// </summary>
    public unsafe virtual bool InCombat(BmSDK.Engine.Actor Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InCombat, "BmGame.RVehicleNPC.InCombat");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsUprightForAttack;
    /// <summary>
    /// Function: IsUprightForAttack
    /// </summary>
    public unsafe virtual bool IsUprightForAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsUprightForAttack, "BmGame.RVehicleNPC.IsUprightForAttack");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTargetActor;
    /// <summary>
    /// Function: GetTargetActor
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetTargetActor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetActor, "BmGame.RVehicleNPC.GetTargetActor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CancelAttack;
    /// <summary>
    /// Function: CancelAttack
    /// </summary>
    public unsafe virtual void CancelAttack(bool DueToBeingRammed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelAttack, "BmGame.RVehicleNPC.CancelAttack");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DueToBeingRammed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAttack;
    /// <summary>
    /// Function: StartAttack
    /// </summary>
    public unsafe virtual bool StartAttack(BmSDK.Engine.Actor Target, float WarningTime, System.Numerics.Vector3 AttackLoc = default, int WeaponIndex = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAttack, "BmGame.RVehicleNPC.StartAttack");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WarningTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackLoc, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponIndex, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_StopAttack;
    /// <summary>
    /// Function: StopAttack
    /// </summary>
    public unsafe virtual void StopAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAttack, "BmGame.RVehicleNPC.StopAttack");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateInterrogationAura;
    /// <summary>
    /// Function: UpdateInterrogationAura
    /// </summary>
    public unsafe virtual void UpdateInterrogationAura(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateInterrogationAura, "BmGame.RVehicleNPC.UpdateInterrogationAura");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeactivateInterrogateAura;
    /// <summary>
    /// Function: DeactivateInterrogateAura
    /// </summary>
    public unsafe virtual void DeactivateInterrogateAura()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivateInterrogateAura, "BmGame.RVehicleNPC.DeactivateInterrogateAura");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateInterrogateAura;
    /// <summary>
    /// Function: ActivateInterrogateAura
    /// </summary>
    public unsafe virtual void ActivateInterrogateAura()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateInterrogateAura, "BmGame.RVehicleNPC.ActivateInterrogateAura");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateTransparentSkeletalMesh;
    /// <summary>
    /// Function: CreateTransparentSkeletalMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkeletalMeshComponent CreateTransparentSkeletalMesh(BmSDK.Engine.SkeletalMesh SkeletalMesh, BmSDK.Engine.SkeletalMeshComponent ParentAnimComponent, BmSDK.Engine.MaterialInterface OverrideMaterial = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateTransparentSkeletalMesh, "BmGame.RVehicleNPC.CreateTransparentSkeletalMesh");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkeletalMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParentAnimComponent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaterial, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.SkeletalMeshComponent>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ResolveParentAnimComponent;
    /// <summary>
    /// Function: ResolveParentAnimComponent
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkeletalMeshComponent ResolveParentAnimComponent(BmSDK.Engine.SkeletalMeshComponent S)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResolveParentAnimComponent, "BmGame.RVehicleNPC.ResolveParentAnimComponent");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(S, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.SkeletalMeshComponent>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AddPawnToPassengerSlot;
    /// <summary>
    /// Function: AddPawnToPassengerSlot
    /// </summary>
    public unsafe virtual void AddPawnToPassengerSlot(int SlotID, BmSDK.BmGame.RBMPawnAI NewPassenger, bool CleanPoseChange = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPawnToPassengerSlot, "BmGame.RVehicleNPC.AddPawnToPassengerSlot");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPassenger, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CleanPoseChange, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSpawningKismet;
    /// <summary>
    /// Function: SetSpawningKismet
    /// </summary>
    public unsafe virtual void SetSpawningKismet(BmSDK.BmGame.RSeqAct_SpawnVehicle VehicleSpawner)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSpawningKismet, "BmGame.RVehicleNPC.SetSpawningKismet");
        byte* paramsPtr = stackalloc byte[224];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VehicleSpawner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitPassenger;
    /// <summary>
    /// Function: ExitPassenger
    /// </summary>
    public unsafe virtual void ExitPassenger(int PassengerIdx, BmSDK.FName OverrideExitAnim = default, BmSDK.Engine.AnimSet OverrideExitAnimset = default, bool BypassNavMeshCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitPassenger, "BmGame.RVehicleNPC.ExitPassenger");
        byte* paramsPtr = stackalloc byte[156];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PassengerIdx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideExitAnim, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideExitAnimset, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BypassNavMeshCheck, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldEnterCombatOnExit;
    /// <summary>
    /// Function: ShouldEnterCombatOnExit
    /// </summary>
    public unsafe virtual bool ShouldEnterCombatOnExit(int PassengerIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldEnterCombatOnExit, "BmGame.RVehicleNPC.ShouldEnterCombatOnExit");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PassengerIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetVehicleOrientation;
    /// <summary>
    /// Function: GetVehicleOrientation
    /// </summary>
    public unsafe override BmSDK.BmGame.RGameInfo.EVehicleOrientation GetVehicleOrientation(bool bForceSelection = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVehicleOrientation, "BmGame.RVehicleNPC.GetVehicleOrientation");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceSelection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.EVehicleOrientation>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PassengerExitRequested;
    /// <summary>
    /// Function: PassengerExitRequested
    /// </summary>
    public unsafe virtual void PassengerExitRequested(bool bDazed, bool bRunAway = default, bool bForcePlayDoorAnim = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PassengerExitRequested, "BmGame.RVehicleNPC.PassengerExitRequested");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDazed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRunAway, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForcePlayDoorAnim, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MakePassengerExitWithAnim;
    /// <summary>
    /// Function: MakePassengerExitWithAnim
    /// </summary>
    public unsafe virtual bool MakePassengerExitWithAnim(int PassengerID, BmSDK.FName ExitAnim, BmSDK.Engine.AnimSet ExitAnimset, bool BypassNavMeshCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakePassengerExitWithAnim, "BmGame.RVehicleNPC.MakePassengerExitWithAnim");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PassengerID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExitAnim, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExitAnimset, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BypassNavMeshCheck, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_MakePassengerUnconscious;
    /// <summary>
    /// Function: MakePassengerUnconscious
    /// </summary>
    public unsafe virtual void MakePassengerUnconscious(int PassengerIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakePassengerUnconscious, "BmGame.RVehicleNPC.MakePassengerUnconscious");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PassengerIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MakePassengersExit;
    /// <summary>
    /// Function: MakePassengersExit
    /// </summary>
    public unsafe virtual void MakePassengersExit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakePassengersExit, "BmGame.RVehicleNPC.MakePassengersExit");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePassengers;
    /// <summary>
    /// Function: UpdatePassengers
    /// </summary>
    public unsafe virtual void UpdatePassengers(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePassengers, "BmGame.RVehicleNPC.UpdatePassengers");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PlayPassengerIdleAnim;
    /// <summary>
    /// Function: PlayPassengerIdleAnim
    /// </summary>
    public unsafe virtual void PlayPassengerIdleAnim(int PassengerIndex, BmSDK.Engine.AnimSet AnimSet, BmSDK.FName AnimName, BmSDK.Engine.AnimSet AnimSetFinalPose, BmSDK.FName FinalPoseName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayPassengerIdleAnim, "BmGame.RVehicleNPC.PlayPassengerIdleAnim");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PassengerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSetFinalPose, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinalPoseName, paramsPtr + 28);
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

    private static BmSDK.Function __fn_SetPassengerPose;
    /// <summary>
    /// Function: SetPassengerPose
    /// </summary>
    public unsafe virtual void SetPassengerPose(int PassengerIndex, BmSDK.Engine.AnimSet AnimSet, BmSDK.FName AnimName, bool Clean = default, bool bMirrored = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPassengerPose, "BmGame.RVehicleNPC.SetPassengerPose");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PassengerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Clean, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 24);
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

    private static BmSDK.Function __fn_PlayPassengerVehicleDeadAnims;
    /// <summary>
    /// Function: PlayPassengerVehicleDeadAnims
    /// </summary>
    public unsafe virtual void PlayPassengerVehicleDeadAnims()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayPassengerVehicleDeadAnims, "BmGame.RVehicleNPC.PlayPassengerVehicleDeadAnims");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisablePassengerIdles;
    /// <summary>
    /// Function: DisablePassengerIdles
    /// </summary>
    public unsafe virtual void DisablePassengerIdles()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisablePassengerIdles, "BmGame.RVehicleNPC.DisablePassengerIdles");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnablePassengerIdles;
    /// <summary>
    /// Function: EnablePassengerIdles
    /// </summary>
    public unsafe virtual void EnablePassengerIdles()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnablePassengerIdles, "BmGame.RVehicleNPC.EnablePassengerIdles");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckLOSToPoint;
    /// <summary>
    /// Function: CheckLOSToPoint
    /// </summary>
    public unsafe virtual bool CheckLOSToPoint(System.Numerics.Vector3 ShootLocation, System.Numerics.Vector3 TargetLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckLOSToPoint, "BmGame.RVehicleNPC.CheckLOSToPoint");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShootLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CheckLOSToShoot;
    /// <summary>
    /// Function: CheckLOSToShoot
    /// </summary>
    public unsafe virtual bool CheckLOSToShoot(System.Numerics.Vector3 ShootLocation, BmSDK.Engine.Actor ShootTarget, bool IsAwareOfPlayer = default, System.Numerics.Vector3 OverrideTargetLocation = default, bool bIgnoreOtherVehicles = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckLOSToShoot, "BmGame.RVehicleNPC.CheckLOSToShoot");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShootLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShootTarget, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsAwareOfPlayer, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideTargetLocation, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreOtherVehicles, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetShootTarget;
    /// <summary>
    /// Function: GetShootTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetShootTarget(BmSDK.Engine.Actor Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetShootTarget, "BmGame.RVehicleNPC.GetShootTarget");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ShootAtTargetNow;
    /// <summary>
    /// Function: ShootAtTargetNow
    /// </summary>
    public unsafe virtual void ShootAtTargetNow(int Passenger, BmSDK.Engine.Actor Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShootAtTargetNow, "BmGame.RVehicleNPC.ShootAtTargetNow");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Passenger, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateShoot;
    /// <summary>
    /// Function: UpdateShoot
    /// </summary>
    public unsafe virtual bool UpdateShoot(float DeltaTime, BmSDK.Engine.Actor Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateShoot, "BmGame.RVehicleNPC.UpdateShoot");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_HasLineOfSightFromMuzzleToTarget;
    /// <summary>
    /// Function: HasLineOfSightFromMuzzleToTarget
    /// </summary>
    public unsafe virtual bool HasLineOfSightFromMuzzleToTarget(BmSDK.Engine.Actor Target, float ConeAngleDeg = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasLineOfSightFromMuzzleToTarget, "BmGame.RVehicleNPC.HasLineOfSightFromMuzzleToTarget");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConeAngleDeg, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetTurretRotator;
    /// <summary>
    /// Function: GetTurretRotator
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetTurretRotator()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTurretRotator, "BmGame.RVehicleNPC.GetTurretRotator");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateTurretRotToNeutral;
    /// <summary>
    /// Function: UpdateTurretRotToNeutral
    /// </summary>
    public unsafe virtual bool UpdateTurretRotToNeutral(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTurretRotToNeutral, "BmGame.RVehicleNPC.UpdateTurretRotToNeutral");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateTurretRot;
    /// <summary>
    /// Function: UpdateTurretRot
    /// </summary>
    public unsafe virtual bool UpdateTurretRot(float DeltaTime, System.Numerics.Vector3 TargetLocation, BmSDK.Rotator RotationOffset = default, bool UseMachineGun = default, float GoodAimToleranceYaw = default, float GoodAimTolerancePitch = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTurretRot, "BmGame.RVehicleNPC.UpdateTurretRot");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RotationOffset, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UseMachineGun, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoodAimToleranceYaw, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoodAimTolerancePitch, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_SwitchToAssignedBehaviour;
    /// <summary>
    /// Function: SwitchToAssignedBehaviour
    /// </summary>
    public unsafe virtual void SwitchToAssignedBehaviour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchToAssignedBehaviour, "BmGame.RVehicleNPC.SwitchToAssignedBehaviour");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForAllPassengersDead;
    /// <summary>
    /// Function: CheckForAllPassengersDead
    /// </summary>
    public unsafe virtual void CheckForAllPassengersDead()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForAllPassengersDead, "BmGame.RVehicleNPC.CheckForAllPassengersDead");
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

    private static BmSDK.Function __fn_RecentlyHadPassengers;
    /// <summary>
    /// Function: RecentlyHadPassengers
    /// </summary>
    public unsafe virtual void RecentlyHadPassengers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecentlyHadPassengers, "BmGame.RVehicleNPC.RecentlyHadPassengers");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsDamageProhibitedByPassengers;
    /// <summary>
    /// Function: IsDamageProhibitedByPassengers
    /// </summary>
    public unsafe virtual bool IsDamageProhibitedByPassengers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDamageProhibitedByPassengers, "BmGame.RVehicleNPC.IsDamageProhibitedByPassengers");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateVehicleStuckSuicide;
    /// <summary>
    /// Function: UpdateVehicleStuckSuicide
    /// </summary>
    public unsafe virtual void UpdateVehicleStuckSuicide(float DeltaTime, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateVehicleStuckSuicide, "BmGame.RVehicleNPC.UpdateVehicleStuckSuicide");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
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

    private static BmSDK.Function __fn_UpdateCrushed;
    /// <summary>
    /// Function: UpdateCrushed
    /// </summary>
    public unsafe virtual void UpdateCrushed(float DeltaTime, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCrushed, "BmGame.RVehicleNPC.UpdateCrushed");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
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

    private static BmSDK.Function __fn_DrawDebugTrail;
    /// <summary>
    /// Function: DrawDebugTrail
    /// </summary>
    public unsafe virtual void DrawDebugTrail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugTrail, "BmGame.RVehicleNPC.DrawDebugTrail");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RescueMe;
    /// <summary>
    /// Function: RescueMe
    /// </summary>
    public unsafe virtual void RescueMe()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RescueMe, "BmGame.RVehicleNPC.RescueMe");
        byte* paramsPtr = stackalloc byte[212];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RVehicleNPC.Tick");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyMe;
    /// <summary>
    /// Function: DestroyMe
    /// </summary>
    public unsafe virtual void DestroyMe()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyMe, "BmGame.RVehicleNPC.DestroyMe");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetachInteractionsForDead;
    /// <summary>
    /// Function: DetachInteractionsForDead
    /// </summary>
    public unsafe virtual void DetachInteractionsForDead()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachInteractionsForDead, "BmGame.RVehicleNPC.DetachInteractionsForDead");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideTankAndDisableCollisionOnDeath;
    /// <summary>
    /// Function: HideTankAndDisableCollisionOnDeath
    /// </summary>
    public unsafe virtual void HideTankAndDisableCollisionOnDeath()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideTankAndDisableCollisionOnDeath, "BmGame.RVehicleNPC.HideTankAndDisableCollisionOnDeath");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlipDeadVehicle;
    /// <summary>
    /// Function: FlipDeadVehicle
    /// </summary>
    public unsafe virtual void FlipDeadVehicle(System.Numerics.Vector3 FlipAxis, float TorqueScale = default, float Duration = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlipDeadVehicle, "BmGame.RVehicleNPC.FlipDeadVehicle");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlipAxis, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TorqueScale, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmGame.RVehicleNPC.Died");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_PreventThugsExitingIntoNoNavMesh;
    /// <summary>
    /// Function: PreventThugsExitingIntoNoNavMesh
    /// </summary>
    public unsafe virtual bool PreventThugsExitingIntoNoNavMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreventThugsExitingIntoNoNavMesh, "BmGame.RVehicleNPC.PreventThugsExitingIntoNoNavMesh");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BlowUpVehicle;
    /// <summary>
    /// Function: BlowUpVehicle
    /// </summary>
    public unsafe virtual void BlowUpVehicle(System.Numerics.Vector3 HitLocation = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlowUpVehicle, "BmGame.RVehicleNPC.BlowUpVehicle");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DieGraphically;
    /// <summary>
    /// Function: DieGraphically
    /// </summary>
    public unsafe virtual void DieGraphically(BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DieGraphically, "BmGame.RVehicleNPC.DieGraphically");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnDeadVehicle;
    /// <summary>
    /// Function: SpawnDeadVehicle
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RDeadVehicle SpawnDeadVehicle(BmSDK.BmGame.RDeadVehicle Archetype, BmSDK.Rotator RotatioOffset = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDeadVehicle, "BmGame.RVehicleNPC.SpawnDeadVehicle");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Archetype, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RotatioOffset, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RDeadVehicle>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetRammingDamageSpeedThreshold;
    /// <summary>
    /// Function: GetRammingDamageSpeedThreshold
    /// </summary>
    public unsafe virtual float GetRammingDamageSpeedThreshold()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRammingDamageSpeedThreshold, "BmGame.RVehicleNPC.GetRammingDamageSpeedThreshold");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AllowRammingDamage;
    /// <summary>
    /// Function: AllowRammingDamage
    /// </summary>
    public unsafe virtual void AllowRammingDamage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowRammingDamage, "BmGame.RVehicleNPC.AllowRammingDamage");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeDamage;
    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamage, "BmGame.RVehicleNPC.TakeDamage");
        byte* paramsPtr = stackalloc byte[124];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 84);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyVisualDamage;
    /// <summary>
    /// Function: ApplyVisualDamage
    /// </summary>
    public unsafe override void ApplyVisualDamage(System.Numerics.Vector3 WorldPos, float Radius, float Amount, System.Numerics.Vector3 ChannelMask, bool bDeformAllowed, bool bSmashGlass, float PartBreakOffImpulse)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyVisualDamage, "BmGame.RVehicleNPC.ApplyVisualDamage");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChannelMask, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDeformAllowed, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSmashGlass, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartBreakOffImpulse, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyVisualDamageFromDamageType;
    /// <summary>
    /// Function: ApplyVisualDamageFromDamageType
    /// </summary>
    public unsafe virtual void ApplyVisualDamageFromDamageType(BmSDK.Class dmgType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyVisualDamageFromDamageType, "BmGame.RVehicleNPC.ApplyVisualDamageFromDamageType");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsVulnerableToDamageType;
    /// <summary>
    /// Function: IsVulnerableToDamageType
    /// </summary>
    public unsafe virtual bool IsVulnerableToDamageType(BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVulnerableToDamageType, "BmGame.RVehicleNPC.IsVulnerableToDamageType");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TakeDamageFromWeapon;
    /// <summary>
    /// Function: TakeDamageFromWeapon
    /// </summary>
    public unsafe override BmSDK.Engine.Actor.EWeaponDamageResult TakeDamageFromWeapon(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default, bool bHeadShot = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamageFromWeapon, "BmGame.RVehicleNPC.TakeDamageFromWeapon");
        byte* paramsPtr = stackalloc byte[124];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHeadShot, paramsPtr + 104);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.EWeaponDamageResult>(paramsPtr + 108);
    }

    private static BmSDK.Function __fn_TakeRadiusDamageFromWeapon;
    /// <summary>
    /// Function: TakeRadiusDamageFromWeapon
    /// </summary>
    public unsafe override BmSDK.Engine.Actor.EWeaponDamageResult TakeRadiusDamageFromWeapon(BmSDK.Engine.Controller InstigatedBy, float BaseDamage, float DamageRadius, BmSDK.Class DamageType, float Momentum, System.Numerics.Vector3 HurtOrigin, bool bFullDamage, BmSDK.Engine.Actor DamageCauser, float DamageFalloffExponent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeRadiusDamageFromWeapon, "BmGame.RVehicleNPC.TakeRadiusDamageFromWeapon");
        byte* paramsPtr = stackalloc byte[57];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseDamage, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageRadius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HurtOrigin, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFullDamage, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageFalloffExponent, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.EWeaponDamageResult>(paramsPtr + 56);
    }

    private static BmSDK.Function __fn_SetMusicBlindedTime;
    /// <summary>
    /// Function: SetMusicBlindedTime
    /// </summary>
    public unsafe virtual void SetMusicBlindedTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMusicBlindedTime, "BmGame.RVehicleNPC.SetMusicBlindedTime");
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

    private static BmSDK.Function __fn_UpdateBlindedStatus;
    /// <summary>
    /// Function: UpdateBlindedStatus
    /// </summary>
    public unsafe virtual void UpdateBlindedStatus(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateBlindedStatus, "BmGame.RVehicleNPC.UpdateBlindedStatus");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetBlindedTimeRemaining;
    /// <summary>
    /// Function: GetBlindedTimeRemaining
    /// </summary>
    public unsafe virtual float GetBlindedTimeRemaining()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBlindedTimeRemaining, "BmGame.RVehicleNPC.GetBlindedTimeRemaining");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBlinded;
    /// <summary>
    /// Function: IsBlinded
    /// </summary>
    public unsafe virtual bool IsBlinded()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBlinded, "BmGame.RVehicleNPC.IsBlinded");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_UnBlind;
    /// <summary>
    /// Function: UnBlind
    /// </summary>
    public unsafe virtual void UnBlind()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnBlind, "BmGame.RVehicleNPC.UnBlind");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Blind;
    /// <summary>
    /// Function: Blind
    /// </summary>
    public unsafe virtual void Blind(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Blind, "BmGame.RVehicleNPC.Blind");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Trigger;
    /// <summary>
    /// Function: Trigger
    /// </summary>
    public unsafe virtual bool Trigger(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Trigger, "BmGame.RVehicleNPC.Trigger");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetDisplayTargetLocation;
    /// <summary>
    /// Function: GetDisplayTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDisplayTargetLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayTargetLocation, "BmGame.RVehicleNPC.GetDisplayTargetLocation");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RequiresBlindDroneUpgrade;
    /// <summary>
    /// Function: RequiresBlindDroneUpgrade
    /// </summary>
    public unsafe virtual bool RequiresBlindDroneUpgrade()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequiresBlindDroneUpgrade, "BmGame.RVehicleNPC.RequiresBlindDroneUpgrade");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanTrigger;
    /// <summary>
    /// Function: CanTrigger
    /// </summary>
    public unsafe virtual bool CanTrigger(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTrigger, "BmGame.RVehicleNPC.CanTrigger");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanBeTargettedByRHD;
    /// <summary>
    /// Function: CanBeTargettedByRHD
    /// </summary>
    public unsafe virtual bool CanBeTargettedByRHD(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeTargettedByRHD, "BmGame.RVehicleNPC.CanBeTargettedByRHD");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetDisplayLockOnState;
    /// <summary>
    /// Function: GetDisplayLockOnState
    /// </summary>
    public unsafe virtual BmSDK.FString GetDisplayLockOnState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayLockOnState, "BmGame.RVehicleNPC.GetDisplayLockOnState");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayTitle;
    /// <summary>
    /// Function: GetDisplayTitle
    /// </summary>
    public unsafe virtual BmSDK.FString GetDisplayTitle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayTitle, "BmGame.RVehicleNPC.GetDisplayTitle");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayDescription;
    /// <summary>
    /// Function: GetDisplayDescription
    /// </summary>
    public unsafe virtual BmSDK.FString GetDisplayDescription()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayDescription, "BmGame.RVehicleNPC.GetDisplayDescription");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayIconName;
    /// <summary>
    /// Function: GetDisplayIconName
    /// </summary>
    public unsafe virtual BmSDK.FString GetDisplayIconName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayIconName, "BmGame.RVehicleNPC.GetDisplayIconName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NeedDisplayRefresh;
    /// <summary>
    /// Function: NeedDisplayRefresh
    /// </summary>
    public unsafe virtual bool NeedDisplayRefresh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NeedDisplayRefresh, "BmGame.RVehicleNPC.NeedDisplayRefresh");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInteractionPrompt;
    /// <summary>
    /// Function: GetInteractionPrompt
    /// </summary>
    public unsafe virtual BmSDK.FString GetInteractionPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInteractionPrompt, "BmGame.RVehicleNPC.GetInteractionPrompt");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldInteractionPromptBeDisplayedInCentreOfScreen;
    /// <summary>
    /// Function: ShouldInteractionPromptBeDisplayedInCentreOfScreen
    /// </summary>
    public unsafe virtual bool ShouldInteractionPromptBeDisplayedInCentreOfScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldInteractionPromptBeDisplayedInCentreOfScreen, "BmGame.RVehicleNPC.ShouldInteractionPromptBeDisplayedInCentreOfScreen");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInteractionPromptSecondary;
    /// <summary>
    /// Function: GetInteractionPromptSecondary
    /// </summary>
    public unsafe virtual BmSDK.FString GetInteractionPromptSecondary()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInteractionPromptSecondary, "BmGame.RVehicleNPC.GetInteractionPromptSecondary");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInteractionType;
    /// <summary>
    /// Function: GetInteractionType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RRemoteControlLowSecurityInterface.EOmnitronInteractionType GetInteractionType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInteractionType, "BmGame.RVehicleNPC.GetInteractionType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RRemoteControlLowSecurityInterface.EOmnitronInteractionType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerSecondary;
    /// <summary>
    /// Function: TriggerSecondary
    /// </summary>
    public unsafe virtual bool TriggerSecondary(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSecondary, "BmGame.RVehicleNPC.TriggerSecondary");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanTargetTroughWalls;
    /// <summary>
    /// Function: CanTargetTroughWalls
    /// </summary>
    public unsafe virtual bool CanTargetTroughWalls()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTargetTroughWalls, "BmGame.RVehicleNPC.CanTargetTroughWalls");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMiniGameHelpPrompt;
    /// <summary>
    /// Function: GetMiniGameHelpPrompt
    /// </summary>
    public unsafe virtual void GetMiniGameHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMiniGameHelpPrompt, "BmGame.RVehicleNPC.GetMiniGameHelpPrompt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerLeft;
    /// <summary>
    /// Function: TriggerLeft
    /// </summary>
    public unsafe virtual void TriggerLeft(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerLeft, "BmGame.RVehicleNPC.TriggerLeft");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerRight;
    /// <summary>
    /// Function: TriggerRight
    /// </summary>
    public unsafe virtual void TriggerRight(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerRight, "BmGame.RVehicleNPC.TriggerRight");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateVisibilityThroughWallsInXrayMode;
    /// <summary>
    /// Function: UpdateVisibilityThroughWallsInXrayMode
    /// </summary>
    public unsafe virtual void UpdateVisibilityThroughWallsInXrayMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateVisibilityThroughWallsInXrayMode, "BmGame.RVehicleNPC.UpdateVisibilityThroughWallsInXrayMode");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetXRayMaterial;
    /// <summary>
    /// Function: SetXRayMaterial
    /// </summary>
    public unsafe virtual void SetXRayMaterial()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetXRayMaterial, "BmGame.RVehicleNPC.SetXRayMaterial");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRemoveMaterialsFromDisruptorMeshList;
    /// <summary>
    /// Function: GetRemoveMaterialsFromDisruptorMeshList
    /// </summary>
    public unsafe virtual void GetRemoveMaterialsFromDisruptorMeshList(out BmSDK.TArray<int> OutRemoveMaterialsList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRemoveMaterialsFromDisruptorMeshList, "BmGame.RVehicleNPC.GetRemoveMaterialsFromDisruptorMeshList");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutRemoveMaterialsList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_IsDisrupted;
    /// <summary>
    /// Function: IsDisrupted
    /// </summary>
    public unsafe virtual bool IsDisrupted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDisrupted, "BmGame.RVehicleNPC.IsDisrupted");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DeactivateDroneDisruptorEffect;
    /// <summary>
    /// Function: DeactivateDroneDisruptorEffect
    /// </summary>
    public unsafe virtual void DeactivateDroneDisruptorEffect()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivateDroneDisruptorEffect, "BmGame.RVehicleNPC.DeactivateDroneDisruptorEffect");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeDamageFromDroneDisruptor;
    /// <summary>
    /// Function: TakeDamageFromDroneDisruptor
    /// </summary>
    public unsafe virtual void TakeDamageFromDroneDisruptor(BmSDK.Engine.Controller DamageInstigator)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamageFromDroneDisruptor, "BmGame.RVehicleNPC.TakeDamageFromDroneDisruptor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageInstigator, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsSusceptibleToDroneDisruptor;
    /// <summary>
    /// Function: IsSusceptibleToDroneDisruptor
    /// </summary>
    public unsafe virtual bool IsSusceptibleToDroneDisruptor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSusceptibleToDroneDisruptor, "BmGame.RVehicleNPC.IsSusceptibleToDroneDisruptor");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnToggleSusceptibleToDroneDisruptor;
    /// <summary>
    /// Function: OnToggleSusceptibleToDroneDisruptor
    /// </summary>
    public unsafe virtual void OnToggleSusceptibleToDroneDisruptor(BmSDK.BmGame.RSeqAct_ToggleSusceptibleToDroneDisruptor Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggleSusceptibleToDroneDisruptor, "BmGame.RVehicleNPC.OnToggleSusceptibleToDroneDisruptor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateDamageFromEMP;
    /// <summary>
    /// Function: UpdateDamageFromEMP
    /// </summary>
    public unsafe virtual void UpdateDamageFromEMP(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateDamageFromEMP, "BmGame.RVehicleNPC.UpdateDamageFromEMP");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_TakeDamageFromEMP;
    /// <summary>
    /// Function: TakeDamageFromEMP
    /// </summary>
    public unsafe virtual void TakeDamageFromEMP(BmSDK.Engine.Controller DamageInstigator, float DamageDuration)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamageFromEMP, "BmGame.RVehicleNPC.TakeDamageFromEMP");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageInstigator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageDuration, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FrontCrushedByBatmobile;
    /// <summary>
    /// Function: FrontCrushedByBatmobile
    /// </summary>
    public unsafe virtual void FrontCrushedByBatmobile(System.Numerics.Vector3 pos, System.Numerics.Vector3 Vel, BmSDK.Engine.Controller EventInstigator, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FrontCrushedByBatmobile, "BmGame.RVehicleNPC.FrontCrushedByBatmobile");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vel, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSelfDriveSpline;
    /// <summary>
    /// Function: StartSelfDriveSpline
    /// </summary>
    public unsafe override void StartSelfDriveSpline(BmSDK.BmGame.RRoadSplinePoint StartPoint, BmSDK.BmGame.RSeqAct_VehicleDriveSpline Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSelfDriveSpline, "BmGame.RVehicleNPC.StartSelfDriveSpline");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSelfDrive;
    /// <summary>
    /// Function: StartSelfDrive
    /// </summary>
    public unsafe override void StartSelfDrive(BmSDK.BmGame.RRoadNetwork Roads, BmSDK.BmGame.RVehicleBehaviour TellArrived = default, bool WasTeleported = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSelfDrive, "BmGame.RVehicleNPC.StartSelfDrive");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Roads, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TellArrived, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WasTeleported, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoBehaviour;
    /// <summary>
    /// Function: GotoBehaviour
    /// </summary>
    public unsafe virtual void GotoBehaviour(BmSDK.BmGame.RVehicleBehaviour NewBehaviour, bool EvenIfDead = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoBehaviour, "BmGame.RVehicleNPC.GotoBehaviour");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBehaviour, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvenIfDead, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoBehaviourClassWithRestrictions;
    /// <summary>
    /// Function: GotoBehaviourClassWithRestrictions
    /// </summary>
    public unsafe virtual void GotoBehaviourClassWithRestrictions(BmSDK.Class NewBehaviourClass, BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restrictions, bool UseIndoorVision)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoBehaviourClassWithRestrictions, "BmGame.RVehicleNPC.GotoBehaviourClassWithRestrictions");
        byte* paramsPtr = stackalloc byte[188];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBehaviourClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Restrictions, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UseIndoorVision, paramsPtr + 176);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoBehaviourClassWithTemplate;
    /// <summary>
    /// Function: GotoBehaviourClassWithTemplate
    /// </summary>
    public unsafe virtual void GotoBehaviourClassWithTemplate(BmSDK.Class NewBehaviourClass, BmSDK.BmGame.RVehicleBehaviour Template, bool EvenIfDead = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoBehaviourClassWithTemplate, "BmGame.RVehicleNPC.GotoBehaviourClassWithTemplate");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBehaviourClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Template, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvenIfDead, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoBehaviourClass;
    /// <summary>
    /// Function: GotoBehaviourClass
    /// </summary>
    public unsafe virtual void GotoBehaviourClass(BmSDK.Class NewBehaviourClass, bool EvenIfDead = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoBehaviourClass, "BmGame.RVehicleNPC.GotoBehaviourClass");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBehaviourClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvenIfDead, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDefaultBehaviourClass;
    /// <summary>
    /// Function: GetDefaultBehaviourClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetDefaultBehaviourClass()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultBehaviourClass, "BmGame.RVehicleNPC.GetDefaultBehaviourClass");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AccumulateCrushed;
    /// <summary>
    /// Function: AccumulateCrushed
    /// </summary>
    public unsafe virtual void AccumulateCrushed(System.Numerics.Vector3 Force, bool IsWheel)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AccumulateCrushed, "BmGame.RVehicleNPC.AccumulateCrushed");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Force, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsWheel, paramsPtr + 12);
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

    private static BmSDK.Function __fn_RigidBodyCollision;
    /// <summary>
    /// Function: RigidBodyCollision
    /// </summary>
    public unsafe override void RigidBodyCollision(BmSDK.Engine.PrimitiveComponent HitComponent, BmSDK.Engine.PrimitiveComponent OtherComponent, out BmSDK.Engine.Actor.FCollisionImpactData RigidCollisionData, int ContactIndex, float Speed, int Index0, int Index1)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RigidBodyCollision, "BmGame.RVehicleNPC.RigidBodyCollision");
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComponent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactIndex, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index0, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index1, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RigidCollisionData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FCollisionImpactData>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_SetPassengersAllowedToChatter;
    /// <summary>
    /// Function: SetPassengersAllowedToChatter
    /// </summary>
    public unsafe virtual void SetPassengersAllowedToChatter(bool Allowed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPassengersAllowedToChatter, "BmGame.RVehicleNPC.SetPassengersAllowedToChatter");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Allowed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNumPassengers;
    /// <summary>
    /// Function: GetNumPassengers
    /// </summary>
    public unsafe virtual int GetNumPassengers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumPassengers, "BmGame.RVehicleNPC.GetNumPassengers");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DeRegisterHelicopterPointOfInterest;
    /// <summary>
    /// Function: DeRegisterHelicopterPointOfInterest
    /// </summary>
    public unsafe virtual void DeRegisterHelicopterPointOfInterest()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeRegisterHelicopterPointOfInterest, "BmGame.RVehicleNPC.DeRegisterHelicopterPointOfInterest");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterHelicopterPointOfInterest;
    /// <summary>
    /// Function: RegisterHelicopterPointOfInterest
    /// </summary>
    public unsafe virtual void RegisterHelicopterPointOfInterest()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterHelicopterPointOfInterest, "BmGame.RVehicleNPC.RegisterHelicopterPointOfInterest");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RVehicleNPC.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSelfDriveSpeedFactor;
    /// <summary>
    /// Function: GetSelfDriveSpeedFactor
    /// </summary>
    public unsafe virtual float GetSelfDriveSpeedFactor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSelfDriveSpeedFactor, "BmGame.RVehicleNPC.GetSelfDriveSpeedFactor");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BehaviourAllowsNavMeshObstacle;
    /// <summary>
    /// Function: BehaviourAllowsNavMeshObstacle
    /// </summary>
    public unsafe override bool BehaviourAllowsNavMeshObstacle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BehaviourAllowsNavMeshObstacle, "BmGame.RVehicleNPC.BehaviourAllowsNavMeshObstacle");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpecificallyLookingForPlayer;
    /// <summary>
    /// Function: SpecificallyLookingForPlayer
    /// </summary>
    public unsafe virtual bool SpecificallyLookingForPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecificallyLookingForPlayer, "BmGame.RVehicleNPC.SpecificallyLookingForPlayer");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_AwareOfPlayer;
    /// <summary>
    /// Function: AwareOfPlayer
    /// </summary>
    public unsafe virtual bool AwareOfPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwareOfPlayer, "BmGame.RVehicleNPC.AwareOfPlayer");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_RadialExplosion;
    /// <summary>
    /// Function: RadialExplosion
    /// </summary>
    public unsafe virtual void RadialExplosion(System.Numerics.Vector3 Origin, float Radius, float Strength, byte Falloff, bool bVelChange)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RadialExplosion, "BmGame.RVehicleNPC.RadialExplosion");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Origin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Falloff, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVelChange, paramsPtr + 24);
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

    private static BmSDK.Function __fn_SpawnPawn;
    /// <summary>
    /// Function: SpawnPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawn SpawnPawn(BmSDK.Class NewPawnClass, BmSDK.BmGame.RCharacterDefine CharacterDefine, BmSDK.Class CharacterType, BmSDK.Class NewWeaponClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnPawn, "BmGame.RVehicleNPC.SpawnPawn");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPawnClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterDefine, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeaponClass, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawn>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_ComputeNumLinksToRemoveForRunAway;
    /// <summary>
    /// Function: ComputeNumLinksToRemoveForRunAway
    /// </summary>
    public unsafe virtual int ComputeNumLinksToRemoveForRunAway(out int NumSpansToRemove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ComputeNumLinksToRemoveForRunAway, "BmGame.RVehicleNPC.ComputeNumLinksToRemoveForRunAway");
        byte* paramsPtr = stackalloc byte[8];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NumSpansToRemove);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumSpansToRemove, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NumSpansToRemove = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateSelfDriveStuckTime;
    /// <summary>
    /// Function: UpdateSelfDriveStuckTime
    /// </summary>
    public unsafe virtual void UpdateSelfDriveStuckTime(bool Reversing, float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSelfDriveStuckTime, "BmGame.RVehicleNPC.UpdateSelfDriveStuckTime");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reversing, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 4);
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

    private static BmSDK.Function __fn_MAT_BeginAnimControl;
    /// <summary>
    /// Function: MAT_BeginAnimControl
    /// </summary>
    public unsafe override void MAT_BeginAnimControl(BmSDK.Engine.InterpGroup InInterpGroup)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MAT_BeginAnimControl, "BmGame.RVehicleNPC.MAT_BeginAnimControl");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetRigidBodyCollisionEnabled;
    /// <summary>
    /// Function: SetRigidBodyCollisionEnabled
    /// </summary>
    public unsafe virtual void SetRigidBodyCollisionEnabled(bool Enabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRigidBodyCollisionEnabled, "BmGame.RVehicleNPC.SetRigidBodyCollisionEnabled");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Enabled, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateLights;
    /// <summary>
    /// Function: UpdateLights
    /// </summary>
    public unsafe override void UpdateLights(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateLights, "BmGame.RVehicleNPC.UpdateLights");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsValidTakedownTarget;
    /// <summary>
    /// Function: IsValidTakedownTarget
    /// </summary>
    public unsafe virtual bool IsValidTakedownTarget(bool StandingOnVehicle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidTakedownTarget, "BmGame.RVehicleNPC.IsValidTakedownTarget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StandingOnVehicle, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ForceRockAssertWithMessage;
    /// <summary>
    /// Function: ForceRockAssertWithMessage
    /// </summary>
    public unsafe virtual void ForceRockAssertWithMessage(BmSDK.FString Message)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceRockAssertWithMessage, "BmGame.RVehicleNPC.ForceRockAssertWithMessage");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PreventFallingOutOfWorld;
    /// <summary>
    /// Function: PreventFallingOutOfWorld
    /// </summary>
    public unsafe virtual void PreventFallingOutOfWorld(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreventFallingOutOfWorld, "BmGame.RVehicleNPC.PreventFallingOutOfWorld");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    /// <summary>
    /// Enum: EVehicleGroupType
    /// </summary>
    public enum EVehicleGroupType : byte
    {
        EVGT_City = 0,
        EVGT_Checkpoint = 1,
        EVGT_RedHoodTunnel = 2,
        EVGT_OracleTankBattle = 3,
        EVGT_CommandBeacon = 4,
        EVGT_All = 5,
        EVGT_MAX = 6,
    }

    /// <summary>
    /// Struct: FWalkerWeaponContainer
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 92)]
    public partial record struct FWalkerWeaponContainer
    {
        /// <summary>
        /// ByteProperty: Type
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleNPC.EWalkerWeaponTypes Type
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.EWalkerWeaponTypes>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: ProjectileArchetype
        /// </summary>
        public unsafe BmSDK.BmGame.RProjectile ProjectileArchetype
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: FireSound
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent FireSound
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// NameProperty: FiringSocketName
        /// </summary>
        public unsafe BmSDK.FName FiringSocketName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: WeaponCountdown
        /// </summary>
        public unsafe float WeaponCountdown
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: AttackLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 AttackLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ObjectProperty: AttackTarget
        /// </summary>
        public unsafe BmSDK.Engine.Actor AttackTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: bPreparingToFiring
        /// </summary>
        public unsafe bool bPreparingToFiring
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: bLeftArmWeapon
        /// </summary>
        public unsafe bool bLeftArmWeapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: bRightArmWeapon
        /// </summary>
        public unsafe bool bRightArmWeapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }; }
        }

        /// <summary>
        /// IntProperty: NumAttacksToGo
        /// </summary>
        public unsafe int NumAttacksToGo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// IntProperty: Health
        /// </summary>
        public unsafe int Health
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// ObjectProperty: ExplodeParticle
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem ExplodeParticle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// ObjectProperty: ExplodeSound
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent ExplodeSound
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bCanTargetBatman
        /// </summary>
        public unsafe bool bCanTargetBatman
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 80); }; }
        }

        /// <summary>
        /// BoolProperty: bCantDoSimultaneousAttack
        /// </summary>
        public unsafe bool bCantDoSimultaneousAttack
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 80); }; }
        }

        /// <summary>
        /// FloatProperty: WarningTimeMultiplier
        /// </summary>
        public unsafe float WarningTimeMultiplier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// FloatProperty: MinRoadClearanceToAttack
        /// </summary>
        public unsafe float MinRoadClearanceToAttack
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }
    }

    /// <summary>
    /// Enum: EWalkerWeaponTypes
    /// </summary>
    public enum EWalkerWeaponTypes : byte
    {
        EWWT_Rockets = 0,
        EWWT_Missiles = 1,
        EWWT_Cannon = 2,
        EWWT_CommanderTankChargeCannon = 3,
        EWWT_MortarAttack = 4,
        EWWT_MAX = 5,
    }

    /// <summary>
    /// Enum: EVehicleSpawnType
    /// </summary>
    public enum EVehicleSpawnType : byte
    {
        EVST_Unknown = 0,
        EVST_RiotZone = 1,
        EVST_PopulationManager = 2,
        EVST_ScriptedSpawn = 3,
        EVST_ScriptedToPopulationManager = 4,
        EVST_PopulationManagerSideStory = 5,
        EVST_MAX = 6,
    }

    /// <summary>
    /// Struct: FVehicleVisionSet
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FVehicleVisionSet
    {
        /// <summary>
        /// StructProperty: BatmobileVisionCone
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleNPC.FVehicleVisionCone BatmobileVisionCone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.FVehicleVisionCone>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: BatmanVisionCone
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleNPC.FVehicleVisionCone BatmanVisionCone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.FVehicleVisionCone>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FVehicleVisionCone
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FVehicleVisionCone
    {
        /// <summary>
        /// FloatProperty: AlwaysSeeRange
        /// </summary>
        public unsafe float AlwaysSeeRange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: VisionRange
        /// </summary>
        public unsafe float VisionRange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: ConeHorizontalHalfAngle
        /// </summary>
        public unsafe float ConeHorizontalHalfAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: ConeVerticalHalfAngle
        /// </summary>
        public unsafe float ConeVerticalHalfAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: MaxZVisionRange
        /// </summary>
        public unsafe float MaxZVisionRange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: ViewConePitchOffset
        /// </summary>
        public unsafe float ViewConePitchOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FVehiclePassenger
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 212)]
    public partial record struct FVehiclePassenger
    {
        /// <summary>
        /// NameProperty: PawnIdleAnimName
        /// </summary>
        public unsafe BmSDK.FName PawnIdleAnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: VehicleDeadAnimName
        /// </summary>
        public unsafe BmSDK.FName VehicleDeadAnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// NameProperty: SocketName
        /// </summary>
        public unsafe BmSDK.FName SocketName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// NameProperty: AnimSocketName
        /// </summary>
        public unsafe BmSDK.FName AnimSocketName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// NameProperty: DoorAnimNodeName
        /// </summary>
        public unsafe BmSDK.FName DoorAnimNodeName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// NameProperty: DoorBoneName
        /// </summary>
        public unsafe BmSDK.FName DoorBoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: NeverExit
        /// </summary>
        public unsafe bool NeverExit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }; }
        }

        /// <summary>
        /// ObjectProperty: Pawn
        /// </summary>
        public unsafe BmSDK.BmGame.RBMPawnAI Pawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// ObjectProperty: Weapon
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleNPCWeapon Weapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPCWeapon>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// ObjectProperty: BehaviourControlled
        /// </summary>
        public unsafe BmSDK.BmGame.RBMBehaviour_ControlledByVehicle BehaviourControlled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_ControlledByVehicle>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// StructProperty: SeatLoc
        /// </summary>
        public unsafe System.Numerics.Vector3 SeatLoc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// StructProperty: SeatRot
        /// </summary>
        public unsafe BmSDK.Rotator SeatRot
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// FloatProperty: Steering
        /// </summary>
        public unsafe float Steering
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }

        /// <summary>
        /// StructProperty: Idles
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleNPC.FVehiclePassengerIdleInfo Idles
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.FVehiclePassengerIdleInfo>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }

        /// <summary>
        /// ClassProperty: WeaponToGivePassenger
        /// </summary>
        public unsafe BmSDK.Class WeaponToGivePassenger
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }; }
        }

        /// <summary>
        /// ObjectProperty: DoorAnimNode
        /// </summary>
        public unsafe BmSDK.Engine.AnimNodeSequence DoorAnimNode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }; }
        }

        /// <summary>
        /// StructProperty: EnterAnimInfo
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.FEnterVehicleAnimInfo EnterAnimInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FEnterVehicleAnimInfo>(Ptr + 152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }; }
        }

        /// <summary>
        /// ArrayProperty: ExitVehicleInfos
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FExitVehicleSlotInfo> ExitVehicleInfos
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FExitVehicleSlotInfo>>(Ptr + 196); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }; }
        }
    }

    /// <summary>
    /// Struct: FVehiclePassengerIdleInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FVehiclePassengerIdleInfo
    {
        /// <summary>
        /// ArrayProperty: AnimNames
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> AnimNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MinInterval
        /// </summary>
        public unsafe float MinInterval
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: MaxInterval
        /// </summary>
        public unsafe float MaxInterval
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: CurInterval
        /// </summary>
        public unsafe float CurInterval
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: CurTransition
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId CurTransition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Enum: VehiclePassengerIdleType
    /// </summary>
    public enum VehiclePassengerIdleType : byte
    {
        VPIT_None = 0,
        VPIT_Custom = 1,
        VPIT_PartyUnarmed = 2,
        VPIT_PartyGun = 3,
        VPIT_MAX = 4,
    }

    /// <summary>
    /// Enum: ECanAttackTargetResult
    /// </summary>
    public enum ECanAttackTargetResult : byte
    {
        CATR_NoSee = 0,
        CATR_CanSeeButNotAttack = 1,
        CATR_CanAttack = 2,
        CATR_MAX = 3,
    }

    /// <summary>
    /// Enum: EVehicleCombatEncounterType
    /// </summary>
    public enum EVehicleCombatEncounterType : byte
    {
        EVCE_NoEncounter = 0,
        EVCE_ChaseEncounter = 1,
        EVCE_CombatEncounter = 2,
        EVCE_StoryChaseEncounter = 3,
        EVCE_PredatorEncounter = 4,
        EVCE_MAX = 5,
    }

    /// <summary>
    /// ObjectProperty: TurretYawController
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSingleBone TurretYawController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSingleBone>(Ptr + 4560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4560); }
    }

    /// <summary>
    /// ObjectProperty: TurretPitchController
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSingleBone TurretPitchController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSingleBone>(Ptr + 4568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4568); }
    }

    /// <summary>
    /// ObjectProperty: VehicleSoundInfo
    /// </summary>
    public unsafe BmSDK.Engine.AkVehicleSoundInfo VehicleSoundInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkVehicleSoundInfo>(Ptr + 4576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4576); }
    }

    /// <summary>
    /// ObjectProperty: Batman
    /// </summary>
    public unsafe BmSDK.Engine.Pawn Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 4584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4584); }
    }

    /// <summary>
    /// ObjectProperty: LeaderVehicle
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC LeaderVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 4592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4592); }
    }

    /// <summary>
    /// ObjectProperty: FollowVehicle
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC FollowVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 4600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4600); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeImpactParticleEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChallengeImpactParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4608); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeDespawnParticleEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChallengeDespawnParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4616); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeDespawnAkEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChallengeDespawnAkEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4624); }
    }

    /// <summary>
    /// ObjectProperty: LeaveFormationBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour_RunAway LeaveFormationBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour_RunAway>(Ptr + 4632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4632); }
    }

    /// <summary>
    /// ObjectProperty: VehicleAsBombPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem VehicleAsBombPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4640); }
    }

    /// <summary>
    /// ObjectProperty: VehicleAsEmpPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem VehicleAsEmpPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4648); }
    }

    /// <summary>
    /// ObjectProperty: VehicleAsBombExplosionPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem VehicleAsBombExplosionPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4656); }
    }

    /// <summary>
    /// ObjectProperty: VehicleAsEmpExplosionPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem VehicleAsEmpExplosionPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4664); }
    }

    /// <summary>
    /// ObjectProperty: OracleHackingPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem OracleHackingPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4672); }
    }

    /// <summary>
    /// ObjectProperty: OracleHackedPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem OracleHackedPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4680); }
    }

    /// <summary>
    /// ObjectProperty: DroneHackedEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DroneHackedEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4688); }
    }

    /// <summary>
    /// ObjectProperty: OriginalXrayMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant OriginalXrayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4696); }
    }

    /// <summary>
    /// ObjectProperty: BlindedXrayMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BlindedXrayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4704); }
    }

    /// <summary>
    /// ObjectProperty: DisruptedXrayMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant DisruptedXrayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4712); }
    }

    /// <summary>
    /// ObjectProperty: AudioTurretSpeed
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName AudioTurretSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 4720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4720); }
    }

    /// <summary>
    /// ObjectProperty: ShootProjectileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile ShootProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4728); }
    }

    /// <summary>
    /// ObjectProperty: ShootSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ShootSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4736); }
    }

    /// <summary>
    /// ObjectProperty: AttackTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor AttackTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4744); }
    }

    /// <summary>
    /// ObjectProperty: KilledBy
    /// </summary>
    public unsafe BmSDK.Engine.Actor KilledBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4752); }
    }

    /// <summary>
    /// ObjectProperty: VehicleBlockingMyLOS
    /// </summary>
    public unsafe BmSDK.Engine.Actor VehicleBlockingMyLOS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4760); }
    }

    /// <summary>
    /// ObjectProperty: MortarProjectileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RMortarProjectile MortarProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMortarProjectile>(Ptr + 4768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4768); }
    }

    /// <summary>
    /// ObjectProperty: MachineGunFireFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem MachineGunFireFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4776); }
    }

    /// <summary>
    /// ObjectProperty: MachineGunTracerFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem MachineGunTracerFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4784); }
    }

    /// <summary>
    /// ObjectProperty: MachineGunEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent MachineGunEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4792); }
    }

    /// <summary>
    /// ObjectProperty: BlindRTPC
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName BlindRTPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 4800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4800); }
    }

    /// <summary>
    /// ObjectProperty: DeadVehicleArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RDeadVehicle DeadVehicleArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeadVehicle>(Ptr + 4808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4808); }
    }

    /// <summary>
    /// ObjectProperty: DeathParticleFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DeathParticleFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4816); }
    }

    /// <summary>
    /// ObjectProperty: DeadXrayMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant DeadXrayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4824); }
    }

    /// <summary>
    /// ObjectProperty: SmashedVehicleArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RDeadVehicle SmashedVehicleArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeadVehicle>(Ptr + 4832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4832); }
    }

    /// <summary>
    /// ObjectProperty: SmashedParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SmashedParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4840); }
    }

    /// <summary>
    /// ObjectProperty: CrushedParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem CrushedParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4848); }
    }

    /// <summary>
    /// ObjectProperty: DeathExplosionSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DeathExplosionSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4856); }
    }

    /// <summary>
    /// ObjectProperty: DeathExplosionSlowmoSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DeathExplosionSlowmoSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4864); }
    }

    /// <summary>
    /// ObjectProperty: FatalDamageSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FatalDamageSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4872); }
    }

    /// <summary>
    /// ObjectProperty: FatalDamageSlowmoSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FatalDamageSlowmoSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4880); }
    }

    /// <summary>
    /// ObjectProperty: SmashedSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SmashedSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4888); }
    }

    /// <summary>
    /// ObjectProperty: CrushedSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CrushedSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4896); }
    }

    /// <summary>
    /// ObjectProperty: RiotHornSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RiotHornSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4904); }
    }

    /// <summary>
    /// ObjectProperty: CombatManagerTargetOverride
    /// </summary>
    public unsafe BmSDK.Engine.Actor CombatManagerTargetOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4912); }
    }

    /// <summary>
    /// ObjectProperty: InterrogateAuraMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant InterrogateAuraMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4920); }
    }

    /// <summary>
    /// ObjectProperty: SpawningKismet
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_SpawnVehicle SpawningKismet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_SpawnVehicle>(Ptr + 4928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4928); }
    }

    /// <summary>
    /// ObjectProperty: WaveController
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_VehicleEnemySpawner WaveController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner>(Ptr + 4936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4936); }
    }

    /// <summary>
    /// ObjectProperty: WeaponDamageFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WeaponDamageFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4944); }
    }

    /// <summary>
    /// ObjectProperty: CurrentBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour CurrentBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour>(Ptr + 4952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4952); }
    }

    /// <summary>
    /// ObjectProperty: PassengerExitBarkDef
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkCharacterDef PassengerExitBarkDef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkCharacterDef>(Ptr + 4960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4960); }
    }

    /// <summary>
    /// ObjectProperty: PassengerExitBarkPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnSpeech PassengerExitBarkPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnSpeech>(Ptr + 4968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4968); }
    }

    /// <summary>
    /// ObjectProperty: PassengerAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PassengerAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4976); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: PassengersEntering
    /// </summary>
    public InlineArray<BmSDK.BmGame.RBMPawnAI> PassengersEntering => new(4, Ptr + 4984, 8, this);

    /// <summary>
    /// ObjectProperty: PassengersEntering
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI PassengersEntering_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 4984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4984); }
    }
    /// <summary>
    /// ObjectProperty: PassengersEntering
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI PassengersEntering_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 4992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4992); }
    }
    /// <summary>
    /// ObjectProperty: PassengersEntering
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI PassengersEntering_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 5000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5000); }
    }
    /// <summary>
    /// ObjectProperty: PassengersEntering
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI PassengersEntering_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 5008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5008); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: PassengerDefaultWeaponArchetypes
    /// </summary>
    public InlineArray<BmSDK.BmGame.RVehicleNPCWeapon> PassengerDefaultWeaponArchetypes => new(4, Ptr + 5016, 8, this);

    /// <summary>
    /// ObjectProperty: PassengerDefaultWeaponArchetypes
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPCWeapon PassengerDefaultWeaponArchetypes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPCWeapon>(Ptr + 5016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5016); }
    }
    /// <summary>
    /// ObjectProperty: PassengerDefaultWeaponArchetypes
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPCWeapon PassengerDefaultWeaponArchetypes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPCWeapon>(Ptr + 5024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5024); }
    }
    /// <summary>
    /// ObjectProperty: PassengerDefaultWeaponArchetypes
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPCWeapon PassengerDefaultWeaponArchetypes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPCWeapon>(Ptr + 5032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5032); }
    }
    /// <summary>
    /// ObjectProperty: PassengerDefaultWeaponArchetypes
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPCWeapon PassengerDefaultWeaponArchetypes_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPCWeapon>(Ptr + 5040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5040); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: LastPassengerInSlot
    /// </summary>
    public InlineArray<BmSDK.BmGame.RBMPawnAI> LastPassengerInSlot => new(4, Ptr + 5048, 8, this);

    /// <summary>
    /// ObjectProperty: LastPassengerInSlot
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI LastPassengerInSlot_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 5048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5048); }
    }
    /// <summary>
    /// ObjectProperty: LastPassengerInSlot
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI LastPassengerInSlot_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 5056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5056); }
    }
    /// <summary>
    /// ObjectProperty: LastPassengerInSlot
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI LastPassengerInSlot_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 5064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5064); }
    }
    /// <summary>
    /// ObjectProperty: LastPassengerInSlot
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI LastPassengerInSlot_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 5072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5072); }
    }

    /// <summary>
    /// ObjectProperty: ScannableAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_SetScannableDrone ScannableAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_SetScannableDrone>(Ptr + 5080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5080); }
    }

    /// <summary>
    /// ObjectProperty: DefaultCombatBehaviourInstance
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour DefaultCombatBehaviourInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour>(Ptr + 5088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5088); }
    }

    /// <summary>
    /// ObjectProperty: CombatGuardBehaviourInstance
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour CombatGuardBehaviourInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour>(Ptr + 5096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5096); }
    }

    /// <summary>
    /// ObjectProperty: DelayerDriverBarkOtherConvoPawn
    /// </summary>
    public unsafe BmSDK.Engine.Pawn DelayerDriverBarkOtherConvoPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 5104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5104); }
    }

    /// <summary>
    /// ObjectProperty: SideStoryFailedThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech SideStoryFailedThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 5112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5112); }
    }

    /// <summary>
    /// ObjectProperty: SideStoryAlreadyActiveThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech SideStoryAlreadyActiveThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 5120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5120); }
    }

    /// <summary>
    /// ObjectProperty: SideStoryCantStopTrackingThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech SideStoryCantStopTrackingThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 5128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5128); }
    }

    /// <summary>
    /// ObjectProperty: AttentionDrawnToPlayerThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech AttentionDrawnToPlayerThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 5136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5136); }
    }

    /// <summary>
    /// ObjectProperty: MuzzleFlash
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem MuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5144); }
    }

    /// <summary>
    /// ObjectProperty: HeadShotExplosion
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HeadShotExplosion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5152); }
    }

    /// <summary>
    /// ObjectProperty: SpawningRiotVolume
    /// </summary>
    public unsafe BmSDK.BmGame.ROverworldPopulationVolume SpawningRiotVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.ROverworldPopulationVolume>(Ptr + 5160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5160); }
    }

    /// <summary>
    /// ObjectProperty: VehicleCustomisation
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleCustomisation VehicleCustomisation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleCustomisation>(Ptr + 5168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5168); }
    }

    /// <summary>
    /// ObjectProperty: AttachedToWinch
    /// </summary>
    public unsafe BmSDK.BmGame.RBatmobileWinch AttachedToWinch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatmobileWinch>(Ptr + 5176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5176); }
    }

    /// <summary>
    /// ObjectProperty: PullThugDriverFromCar_FromAbove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PullThugDriverFromCar_FromAbove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5184); }
    }

    /// <summary>
    /// ObjectProperty: PullThugDriverFromCar_FromInFront
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PullThugDriverFromCar_FromInFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5192); }
    }

    /// <summary>
    /// ComponentProperty: CounterIcon
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent CounterIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5200); }
    }

    /// <summary>
    /// ClassProperty: CombatGuardBehaviour
    /// </summary>
    public unsafe BmSDK.Class CombatGuardBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5208); }
    }

    /// <summary>
    /// ClassProperty: CombatFlushOutBehaviour
    /// </summary>
    public unsafe BmSDK.Class CombatFlushOutBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5216); }
    }

    /// <summary>
    /// ClassProperty: DefaultCombatBehaviour
    /// </summary>
    public unsafe BmSDK.Class DefaultCombatBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5224); }
    }

    /// <summary>
    /// ClassProperty: HackerSuicideBehaviour
    /// </summary>
    public unsafe BmSDK.Class HackerSuicideBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5232); }
    }

    /// <summary>
    /// ComponentProperty: explosionImpulse
    /// </summary>
    public unsafe BmSDK.Engine.RB_RadialImpulseComponent explosionImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_RadialImpulseComponent>(Ptr + 5240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5240); }
    }

    /// <summary>
    /// ComponentProperty: InterrogateAuraMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent InterrogateAuraMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 5248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5248); }
    }

    /// <summary>
    /// ComponentProperty: ThreatComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleThreatComponent ThreatComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleThreatComponent>(Ptr + 5256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5256); }
    }

    /// <summary>
    /// ClassProperty: FatalDamageBehaviour
    /// </summary>
    public unsafe BmSDK.Class FatalDamageBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5264); }
    }

    /// <summary>
    /// ComponentProperty: FatalDamageParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FatalDamageParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5272); }
    }

    /// <summary>
    /// ComponentProperty: MachineGunMuzzleComponent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MachineGunMuzzleComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5280); }
    }

    /// <summary>
    /// ClassProperty: ShootProjectileClass
    /// </summary>
    public unsafe BmSDK.Class ShootProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5288); }
    }

    /// <summary>
    /// ComponentProperty: DisruptedVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent DisruptedVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5296); }
    }

    /// <summary>
    /// ComponentProperty: ParticlesOracleHack
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ParticlesOracleHack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5304); }
    }

    /// <summary>
    /// ComponentProperty: ParticlesEMP
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ParticlesEMP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5312); }
    }

    /// <summary>
    /// ClassProperty: DefaultBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class DefaultBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5320); }
    }

    /// <summary>
    /// BoolProperty: bDontPitchCannon
    /// </summary>
    public unsafe bool bDontPitchCannon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: IsFriendly
    /// </summary>
    public unsafe bool IsFriendly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bOnlyDestroyOffScreen
    /// </summary>
    public unsafe bool bOnlyDestroyOffScreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCanDestroyWithPassengers
    /// </summary>
    public unsafe bool bCanDestroyWithPassengers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCanDestroyWhenAlive
    /// </summary>
    public unsafe bool bCanDestroyWhenAlive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: IsPenguinVan
    /// </summary>
    public unsafe bool IsPenguinVan
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: IsMadHatterCar
    /// </summary>
    public unsafe bool IsMadHatterCar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: IsMostWantedApc
    /// </summary>
    public unsafe bool IsMostWantedApc
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bBatmobileCantShoot
    /// </summary>
    public unsafe bool bBatmobileCantShoot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bFireflyRemovesAndAddsToPopulation
    /// </summary>
    public unsafe bool bFireflyRemovesAndAddsToPopulation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: FollowIsJoining
    /// </summary>
    public unsafe bool FollowIsJoining
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: FollowIsLeaving
    /// </summary>
    public unsafe bool FollowIsLeaving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bHadFollowers
    /// </summary>
    public unsafe bool bHadFollowers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bChallengeModePawn
    /// </summary>
    public unsafe bool bChallengeModePawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bFadeIn
    /// </summary>
    public unsafe bool bFadeIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bFadeOut
    /// </summary>
    public unsafe bool bFadeOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bShouldTickFade
    /// </summary>
    public unsafe bool bShouldTickFade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: DisableDeathBarks
    /// </summary>
    public unsafe bool DisableDeathBarks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bPlayingDoorAnim
    /// </summary>
    public unsafe bool bPlayingDoorAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bTurretDestroyed
    /// </summary>
    public unsafe bool bTurretDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: DontDestroyNearbyPropsOnSpawn
    /// </summary>
    public unsafe bool DontDestroyNearbyPropsOnSpawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bSusceptibleToEMP
    /// </summary>
    public unsafe bool bSusceptibleToEMP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCompletelyDisabledByEMP
    /// </summary>
    public unsafe bool bCompletelyDisabledByEMP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: PoweredDown
    /// </summary>
    public unsafe bool PoweredDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: VehicleAsBombEMP
    /// </summary>
    public unsafe bool VehicleAsBombEMP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: BeingHackedByOracle
    /// </summary>
    public unsafe bool BeingHackedByOracle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bSusceptibleToDroneDisruptor
    /// </summary>
    public unsafe bool bSusceptibleToDroneDisruptor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bDisrupted
    /// </summary>
    public unsafe bool bDisrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToExplodeBecauseTriedToFireWhenDisrupted
    /// </summary>
    public unsafe bool bWaitingToExplodeBecauseTriedToFireWhenDisrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: EscortIgnoreBatmobile
    /// </summary>
    public unsafe bool EscortIgnoreBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: AudioTurretSpeedABS
    /// </summary>
    public unsafe bool AudioTurretSpeedABS
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: TurretLocked
    /// </summary>
    public unsafe bool TurretLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: ShootEnabled
    /// </summary>
    public unsafe bool ShootEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bTurretLooksForward
    /// </summary>
    public unsafe bool bTurretLooksForward
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bTurretLooksForwardWhenDead
    /// </summary>
    public unsafe bool bTurretLooksForwardWhenDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: ProjectileCausesRocketBy
    /// </summary>
    public unsafe bool ProjectileCausesRocketBy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: Projectile2CausesRocketBy
    /// </summary>
    public unsafe bool Projectile2CausesRocketBy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bNeedsLOSToShoot
    /// </summary>
    public unsafe bool bNeedsLOSToShoot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: SatNavApproachFromBehind
    /// </summary>
    public unsafe bool SatNavApproachFromBehind
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: ShootWithMortar
    /// </summary>
    public unsafe bool ShootWithMortar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: ShootWithMortarHighAngle
    /// </summary>
    public unsafe bool ShootWithMortarHighAngle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: PotentialMissileThreat
    /// </summary>
    public unsafe bool PotentialMissileThreat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: MachineGunEffectsActive
    /// </summary>
    public unsafe bool MachineGunEffectsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: HasMachineGun
    /// </summary>
    public unsafe bool HasMachineGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: MachineGunAlwaysHits
    /// </summary>
    public unsafe bool MachineGunAlwaysHits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bDelayExpodeVFX
    /// </summary>
    public unsafe bool bDelayExpodeVFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: DeathExplodeNotCustom
    /// </summary>
    public unsafe bool DeathExplodeNotCustom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: FellInWater
    /// </summary>
    public unsafe bool FellInWater
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: ReSpotIfFellInWater
    /// </summary>
    public unsafe bool ReSpotIfFellInWater
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: CanBeCrushed
    /// </summary>
    public unsafe bool CanBeCrushed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: CrushedThisFrame
    /// </summary>
    public unsafe bool CrushedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bFatallyDamaged
    /// </summary>
    public unsafe bool bFatallyDamaged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: HideBonesOnSmashed
    /// </summary>
    public unsafe bool HideBonesOnSmashed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: ForceShowOnHUD
    /// </summary>
    public unsafe bool ForceShowOnHUD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: ControlledByCombatManager
    /// </summary>
    public unsafe bool ControlledByCombatManager
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bRequiresDriver
    /// </summary>
    public unsafe bool bRequiresDriver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bDamageCancelsAttacks
    /// </summary>
    public unsafe bool bDamageCancelsAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bRammingCancelsAttacks
    /// </summary>
    public unsafe bool bRammingCancelsAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bRammingDamageCooldown
    /// </summary>
    public unsafe bool bRammingDamageCooldown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bInActiveRiotZone
    /// </summary>
    public unsafe bool bInActiveRiotZone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bNearSpawnedWanderers
    /// </summary>
    public unsafe bool bNearSpawnedWanderers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bInterrogationAuraActive
    /// </summary>
    public unsafe bool bInterrogationAuraActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bHeavyArmour
    /// </summary>
    public unsafe bool bHeavyArmour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bArmourPreventsVisualDamage
    /// </summary>
    public unsafe bool bArmourPreventsVisualDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: TakesVisualDamageFromCollisions
    /// </summary>
    public unsafe bool TakesVisualDamageFromCollisions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bOnlyVulnerableToBarge
    /// </summary>
    public unsafe bool bOnlyVulnerableToBarge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bInvincibleWhenOccupied
    /// </summary>
    public unsafe bool bInvincibleWhenOccupied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bInvincibleWhenEscorted
    /// </summary>
    public unsafe bool bInvincibleWhenEscorted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: HasEverBeenAwareOfBatmobile
    /// </summary>
    public unsafe bool HasEverBeenAwareOfBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bIsInvincible
    /// </summary>
    public unsafe bool bIsInvincible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bHasTakenAnyDamage
    /// </summary>
    public unsafe bool bHasTakenAnyDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bGrabbedByIvyVine
    /// </summary>
    public unsafe bool bGrabbedByIvyVine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bOnlyVulnerableToGoodSideSwipe
    /// </summary>
    public unsafe bool bOnlyVulnerableToGoodSideSwipe
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bPassengerExitRequested
    /// </summary>
    public unsafe bool bPassengerExitRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bPassengersExitNormally
    /// </summary>
    public unsafe bool bPassengersExitNormally
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bPassengersExitRunAway
    /// </summary>
    public unsafe bool bPassengersExitRunAway
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bPassengersExitForcePlayDoorAnim
    /// </summary>
    public unsafe bool bPassengersExitForcePlayDoorAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: CountsForRamTakedownAchievement
    /// </summary>
    public unsafe bool CountsForRamTakedownAchievement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: AlwaysDoKillCamera
    /// </summary>
    public unsafe bool AlwaysDoKillCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: DroneHacked
    /// </summary>
    public unsafe bool DroneHacked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: OccupantsAllowedToChatter
    /// </summary>
    public unsafe bool OccupantsAllowedToChatter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bPassengersExitWhenDestroyed
    /// </summary>
    public unsafe bool bPassengersExitWhenDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysPlayDoorAnimOnExit
    /// </summary>
    public unsafe bool bAlwaysPlayDoorAnimOnExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bSetPassengersHostileOnExit
    /// </summary>
    public unsafe bool bSetPassengersHostileOnExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bPassengersUnconsciousWhenDestroyed
    /// </summary>
    public unsafe bool bPassengersUnconsciousWhenDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bHadPassengers
    /// </summary>
    public unsafe bool bHadPassengers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: CombatUseIndoorVision
    /// </summary>
    public unsafe bool CombatUseIndoorVision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bUseTurretYawForSpotting
    /// </summary>
    public unsafe bool bUseTurretYawForSpotting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: DoExplosionScreenShake
    /// </summary>
    public unsafe bool DoExplosionScreenShake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: PassengerBarksDisabled
    /// </summary>
    public unsafe bool PassengerBarksDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: PlayingDelayedBark
    /// </summary>
    public unsafe bool PlayingDelayedBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bDoExplosionEvenIfNoDeadVehicle
    /// </summary>
    public unsafe bool bDoExplosionEvenIfNoDeadVehicle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bIsRiotGetawayVehicle
    /// </summary>
    public unsafe bool bIsRiotGetawayVehicle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawTrail
    /// </summary>
    public unsafe bool bDebugDrawTrail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: GoingToCombatBehaviour
    /// </summary>
    public unsafe bool GoingToCombatBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: IsInCombat
    /// </summary>
    public unsafe bool IsInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bContainsRiddlerInformant
    /// </summary>
    public unsafe bool bContainsRiddlerInformant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bNoGlideTakedown
    /// </summary>
    public unsafe bool bNoGlideTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: DoingStaggeredScenarioSpawn
    /// </summary>
    public unsafe bool DoingStaggeredScenarioSpawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: IgnoreBatmobileWeaponSounds
    /// </summary>
    public unsafe bool IgnoreBatmobileWeaponSounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// FloatProperty: BehaviourActivateRange
    /// </summary>
    public unsafe float BehaviourActivateRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5344); }
    }

    /// <summary>
    /// FloatProperty: BehaviourDeactivateRange
    /// </summary>
    public unsafe float BehaviourDeactivateRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5348); }
    }

    /// <summary>
    /// FloatProperty: SteeringLookAheadScale
    /// </summary>
    public unsafe float SteeringLookAheadScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5352); }
    }

    /// <summary>
    /// FloatProperty: TyreFrictionScale
    /// </summary>
    public unsafe float TyreFrictionScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5356); }
    }

    /// <summary>
    /// FloatProperty: DestroyMinPlayerRange
    /// </summary>
    public unsafe float DestroyMinPlayerRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5360); }
    }

    /// <summary>
    /// NameProperty: PawnReferenceName
    /// </summary>
    public unsafe BmSDK.FName PawnReferenceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5364); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveJumpRightingTorque
    /// </summary>
    public unsafe float SelfDriveJumpRightingTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5372); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveJumpForwardForce
    /// </summary>
    public unsafe float SelfDriveJumpForwardForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5376); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveJumpDownForce
    /// </summary>
    public unsafe float SelfDriveJumpDownForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5380); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveStuckRightingTorque
    /// </summary>
    public unsafe float SelfDriveStuckRightingTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5384); }
    }

    /// <summary>
    /// FloatProperty: KillPostPassengersExitDelay
    /// </summary>
    public unsafe float KillPostPassengersExitDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5388); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveReverseThrottle
    /// </summary>
    public unsafe float SelfDriveReverseThrottle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5392); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveBackUpThrottle
    /// </summary>
    public unsafe float SelfDriveBackUpThrottle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5396); }
    }

    /// <summary>
    /// IntProperty: MinNumSimultaneousAttacks
    /// </summary>
    public unsafe int MinNumSimultaneousAttacks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5400); }
    }

    /// <summary>
    /// ArrayProperty: Joiners
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleNPC> Joiners
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC>>(Ptr + 5404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5404); }
    }

    /// <summary>
    /// ArrayProperty: Followers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleNPC> Followers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC>>(Ptr + 5420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5420); }
    }

    /// <summary>
    /// FloatProperty: FollowBehaviourCurrentOffsetBehind
    /// </summary>
    public unsafe float FollowBehaviourCurrentOffsetBehind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5436); }
    }

    /// <summary>
    /// FloatProperty: FollowBehaviourCurrentOffset
    /// </summary>
    public unsafe float FollowBehaviourCurrentOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5440); }
    }

    /// <summary>
    /// FloatProperty: MinRunAwayHistory
    /// </summary>
    public unsafe float MinRunAwayHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5444); }
    }

    /// <summary>
    /// FloatProperty: FadeTimer
    /// </summary>
    public unsafe float FadeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5448); }
    }

    /// <summary>
    /// FloatProperty: AlwaysStasisRange
    /// </summary>
    public unsafe float AlwaysStasisRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5452); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveStuckTime
    /// </summary>
    public unsafe float SelfDriveStuckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5456); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveReverseTime
    /// </summary>
    public unsafe float SelfDriveReverseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5460); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveRecentlyStuck
    /// </summary>
    public unsafe float SelfDriveRecentlyStuck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5464); }
    }

    /// <summary>
    /// ByteProperty: SelfDriveStuckMode
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.ESelfDriveMode SelfDriveStuckMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.ESelfDriveMode>(Ptr + 5468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5468); }
    }

    /// <summary>
    /// ByteProperty: HelicopterPointOfInterestType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes HelicopterPointOfInterestType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes>(Ptr + 5469); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5469); }
    }

    /// <summary>
    /// ByteProperty: CombatEncounterType
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC.EVehicleCombatEncounterType CombatEncounterType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.EVehicleCombatEncounterType>(Ptr + 5470); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5470); }
    }

    /// <summary>
    /// ByteProperty: ImmuneToRamDamageLevel
    /// </summary>
    public unsafe byte ImmuneToRamDamageLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5471); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5471); }
    }

    /// <summary>
    /// ByteProperty: SpawnType
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC.EVehicleSpawnType SpawnType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.EVehicleSpawnType>(Ptr + 5472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5472); }
    }

    /// <summary>
    /// ByteProperty: VehicleGroupType
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC.EVehicleGroupType VehicleGroupType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.EVehicleGroupType>(Ptr + 5473); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5473); }
    }

    /// <summary>
    /// ByteProperty: FallingRescues
    /// </summary>
    public unsafe byte FallingRescues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5474); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5474); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveTrappedTime
    /// </summary>
    public unsafe float SelfDriveTrappedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5476); }
    }

    /// <summary>
    /// StructProperty: SelfDriveTrappedRefPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SelfDriveTrappedRefPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5480);

    /// <summary>
    /// StructProperty: SelfDriveTargetLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SelfDriveTargetLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5492);

    /// <summary>
    /// FloatProperty: TrappedEventDelay
    /// </summary>
    public unsafe float TrappedEventDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5504); }
    }

    /// <summary>
    /// FloatProperty: VehicleStuckTime
    /// </summary>
    public unsafe float VehicleStuckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5508); }
    }

    /// <summary>
    /// FloatProperty: TempBoostTime
    /// </summary>
    public unsafe float TempBoostTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5512); }
    }

    /// <summary>
    /// FloatProperty: DamageTimeEMP
    /// </summary>
    public unsafe float DamageTimeEMP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5516); }
    }

    /// <summary>
    /// IntProperty: VehicleAsBombHealth
    /// </summary>
    public unsafe int VehicleAsBombHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5520); }
    }

    /// <summary>
    /// FloatProperty: VehicleAsBombBlinkTime
    /// </summary>
    public unsafe float VehicleAsBombBlinkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5524); }
    }

    /// <summary>
    /// FloatProperty: VehicleAsBombDamageRadius
    /// </summary>
    public unsafe float VehicleAsBombDamageRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5528); }
    }

    /// <summary>
    /// FloatProperty: VehicleAsBombDamageAmount
    /// </summary>
    public unsafe float VehicleAsBombDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5532); }
    }

    /// <summary>
    /// FloatProperty: VehicleAsEmpDamageRadius
    /// </summary>
    public unsafe float VehicleAsEmpDamageRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5536); }
    }

    /// <summary>
    /// FloatProperty: VehicleAsEmpDamageAmount
    /// </summary>
    public unsafe float VehicleAsEmpDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5540); }
    }

    /// <summary>
    /// FloatProperty: OracleHackDuration
    /// </summary>
    public unsafe float OracleHackDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5544); }
    }

    /// <summary>
    /// FloatProperty: OracleHackTime
    /// </summary>
    public unsafe float OracleHackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5548); }
    }

    /// <summary>
    /// StrProperty: OracleHackType
    /// </summary>
    public unsafe BmSDK.FString OracleHackType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5552); }
    }

    /// <summary>
    /// FloatProperty: fBlindedRemainingTime
    /// </summary>
    public unsafe float fBlindedRemainingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5568); }
    }

    /// <summary>
    /// NameProperty: nRHDTargetSocket
    /// </summary>
    public unsafe BmSDK.FName nRHDTargetSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5572); }
    }

    /// <summary>
    /// StrProperty: sRHDScreenTitle
    /// </summary>
    public unsafe BmSDK.FString sRHDScreenTitle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5580); }
    }

    /// <summary>
    /// ArrayProperty: RemoveMaterialsFromDisruptorMeshList
    /// </summary>
    public unsafe BmSDK.TArray<int> RemoveMaterialsFromDisruptorMeshList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 5596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5596); }
    }

    /// <summary>
    /// StrProperty: sDisruptorHUDDescription
    /// </summary>
    public unsafe BmSDK.FString sDisruptorHUDDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5612); }
    }

    /// <summary>
    /// StrProperty: sDisruptorTrackerHUDDescription
    /// </summary>
    public unsafe BmSDK.FString sDisruptorTrackerHUDDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5628); }
    }

    /// <summary>
    /// NameProperty: DisruptorTargetBone
    /// </summary>
    public unsafe BmSDK.FName DisruptorTargetBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5644); }
    }

    /// <summary>
    /// FloatProperty: TurretRotSpeed
    /// </summary>
    public unsafe float TurretRotSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5652); }
    }

    /// <summary>
    /// FloatProperty: TurretMinPitch
    /// </summary>
    public unsafe float TurretMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5656); }
    }

    /// <summary>
    /// FloatProperty: TurretMaxPitch
    /// </summary>
    public unsafe float TurretMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5660); }
    }

    /// <summary>
    /// FloatProperty: TurretMinYaw
    /// </summary>
    public unsafe float TurretMinYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5664); }
    }

    /// <summary>
    /// FloatProperty: TurretMaxYaw
    /// </summary>
    public unsafe float TurretMaxYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5668); }
    }

    /// <summary>
    /// StructProperty: TurretReferencePoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TurretReferencePoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5672);

    /// <summary>
    /// StructProperty: MachineGunReferencePoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MachineGunReferencePoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5684);

    /// <summary>
    /// FloatProperty: TurretYaw
    /// </summary>
    public unsafe float TurretYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5696); }
    }

    /// <summary>
    /// FloatProperty: TurretPitch
    /// </summary>
    public unsafe float TurretPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5700); }
    }

    /// <summary>
    /// FloatProperty: TurretWantYaw
    /// </summary>
    public unsafe float TurretWantYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5704); }
    }

    /// <summary>
    /// FloatProperty: TurretWantPitch
    /// </summary>
    public unsafe float TurretWantPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5708); }
    }

    /// <summary>
    /// StructProperty: TurretLockedRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator TurretLockedRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 5712);

    /// <summary>
    /// FloatProperty: ShootInitialDelay
    /// </summary>
    public unsafe float ShootInitialDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5724); }
    }

    /// <summary>
    /// FloatProperty: ShootInitialDelayRand
    /// </summary>
    public unsafe float ShootInitialDelayRand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5728); }
    }

    /// <summary>
    /// FloatProperty: ShootNextDelay
    /// </summary>
    public unsafe float ShootNextDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5732); }
    }

    /// <summary>
    /// FloatProperty: ShootCurDelay
    /// </summary>
    public unsafe float ShootCurDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5736); }
    }

    /// <summary>
    /// FloatProperty: ProjectileFireImpulse
    /// </summary>
    public unsafe float ProjectileFireImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5740); }
    }

    /// <summary>
    /// NameProperty: ProjectileLaunchSocket
    /// </summary>
    public unsafe BmSDK.FName ProjectileLaunchSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5744); }
    }

    /// <summary>
    /// StructProperty: ProjectileLaunchOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ProjectileLaunchOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5752);

    /// <summary>
    /// NameProperty: Projectile2LaunchSocket
    /// </summary>
    public unsafe BmSDK.FName Projectile2LaunchSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5764); }
    }

    /// <summary>
    /// FloatProperty: OptimalAttackRange
    /// </summary>
    public unsafe float OptimalAttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5772); }
    }

    /// <summary>
    /// FloatProperty: MinRoadClearanceToAttack
    /// </summary>
    public unsafe float MinRoadClearanceToAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5776); }
    }

    /// <summary>
    /// FloatProperty: AttackSpacingMultiplier
    /// </summary>
    public unsafe float AttackSpacingMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5780); }
    }

    /// <summary>
    /// FloatProperty: AttackWarningModifier
    /// </summary>
    public unsafe float AttackWarningModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5784); }
    }

    /// <summary>
    /// StructProperty: AttackLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AttackLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5788);

    /// <summary>
    /// NameProperty: DroneCombatEvTag
    /// </summary>
    public unsafe BmSDK.FName DroneCombatEvTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5800); }
    }

    /// <summary>
    /// FloatProperty: RunOverDamage
    /// </summary>
    public unsafe float RunOverDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5808); }
    }

    /// <summary>
    /// FloatProperty: MachineGunBurstDuration
    /// </summary>
    public unsafe float MachineGunBurstDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5812); }
    }

    /// <summary>
    /// FloatProperty: MachineGunDamageInterval
    /// </summary>
    public unsafe float MachineGunDamageInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5816); }
    }

    /// <summary>
    /// NameProperty: MachineGunMuzzleSocket
    /// </summary>
    public unsafe BmSDK.FName MachineGunMuzzleSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5820); }
    }

    /// <summary>
    /// FloatProperty: MachineGunShotDeviance
    /// </summary>
    public unsafe float MachineGunShotDeviance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5828); }
    }

    /// <summary>
    /// FloatProperty: MachineGunDamage
    /// </summary>
    public unsafe float MachineGunDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5832); }
    }

    /// <summary>
    /// FloatProperty: DeathImpulse
    /// </summary>
    public unsafe float DeathImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5836); }
    }

    /// <summary>
    /// FloatProperty: DeathImpulseRadius
    /// </summary>
    public unsafe float DeathImpulseRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5840); }
    }

    /// <summary>
    /// FloatProperty: DeathExplodeDelay
    /// </summary>
    public unsafe float DeathExplodeDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5844); }
    }

    /// <summary>
    /// FloatProperty: DeathDisappearTime
    /// </summary>
    public unsafe float DeathDisappearTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5848); }
    }

    /// <summary>
    /// FloatProperty: DeathExplodeKOThugRadius
    /// </summary>
    public unsafe float DeathExplodeKOThugRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5852); }
    }

    /// <summary>
    /// FloatProperty: DeathExplodeKOThugMomentum
    /// </summary>
    public unsafe float DeathExplodeKOThugMomentum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5856); }
    }

    /// <summary>
    /// NameProperty: DeadVehicleSpawnInLevel
    /// </summary>
    public unsafe BmSDK.FName DeadVehicleSpawnInLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5860); }
    }

    /// <summary>
    /// StructProperty: FlipDeadTorque
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FlipDeadTorque
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5868);

    /// <summary>
    /// FloatProperty: FlipDeadDuration
    /// </summary>
    public unsafe float FlipDeadDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5880); }
    }

    /// <summary>
    /// NameProperty: AttachDeathParticleToBone
    /// </summary>
    public unsafe BmSDK.FName AttachDeathParticleToBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5884); }
    }

    /// <summary>
    /// FloatProperty: DeathParticleSystemVelocityFactor
    /// </summary>
    public unsafe float DeathParticleSystemVelocityFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5892); }
    }

    /// <summary>
    /// FloatProperty: DeathParticleSystemVelocityFalloff
    /// </summary>
    public unsafe float DeathParticleSystemVelocityFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5896); }
    }

    /// <summary>
    /// StructProperty: DeathParticleSystemVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DeathParticleSystemVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5900);

    /// <summary>
    /// FloatProperty: DeathParticleSystemVelocityTime
    /// </summary>
    public unsafe float DeathParticleSystemVelocityTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5912); }
    }

    /// <summary>
    /// FloatProperty: CrushThreshold
    /// </summary>
    public unsafe float CrushThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5916); }
    }

    /// <summary>
    /// FloatProperty: CrushThresholdZ
    /// </summary>
    public unsafe float CrushThresholdZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5920); }
    }

    /// <summary>
    /// StructProperty: CrushPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CrushPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5924);

    /// <summary>
    /// StructProperty: CrushNeg
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CrushNeg
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5936);

    /// <summary>
    /// FloatProperty: FatalDamageImpulseMin
    /// </summary>
    public unsafe float FatalDamageImpulseMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5948); }
    }

    /// <summary>
    /// FloatProperty: FatalDamageImpulseMax
    /// </summary>
    public unsafe float FatalDamageImpulseMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5952); }
    }

    /// <summary>
    /// FloatProperty: DeathJumpImpulse
    /// </summary>
    public unsafe float DeathJumpImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5956); }
    }

    /// <summary>
    /// ArrayProperty: DeathExplosionSoundArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkEvent> DeathExplosionSoundArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkEvent>>(Ptr + 5960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5960); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveReverseDuration
    /// </summary>
    public unsafe float SelfDriveReverseDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5976); }
    }

    /// <summary>
    /// StructProperty: DirWhenAttackStarted
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DirWhenAttackStarted
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5980);

    /// <summary>
    /// StructProperty: LOSCheckOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LOSCheckOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5992);

    /// <summary>
    /// FloatProperty: InterrogationAuraAlpha
    /// </summary>
    public unsafe float InterrogationAuraAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6004); }
    }

    /// <summary>
    /// FloatProperty: WeaponDamageFXScale
    /// </summary>
    public unsafe float WeaponDamageFXScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6008); }
    }

    /// <summary>
    /// FloatProperty: VisualDamageCollisionSpeedScale
    /// </summary>
    public unsafe float VisualDamageCollisionSpeedScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6012); }
    }

    /// <summary>
    /// FloatProperty: NudgedByBatmobileTimer
    /// </summary>
    public unsafe float NudgedByBatmobileTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6016); }
    }

    /// <summary>
    /// FloatProperty: AwareOfBatmobileTimer
    /// </summary>
    public unsafe float AwareOfBatmobileTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6020); }
    }

    /// <summary>
    /// IntProperty: NumTimesRammedByBatmobile
    /// </summary>
    public unsafe int NumTimesRammedByBatmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6024); }
    }

    /// <summary>
    /// FloatProperty: LowVelocityTimer
    /// </summary>
    public unsafe float LowVelocityTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6028); }
    }

    /// <summary>
    /// FloatProperty: ChaseIdealDist
    /// </summary>
    public unsafe float ChaseIdealDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6032); }
    }

    /// <summary>
    /// FloatProperty: DroneHackerTime
    /// </summary>
    public unsafe float DroneHackerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6036); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: Passengers
    /// </summary>
    public InlineArray<BmSDK.BmGame.RVehicleNPC.FVehiclePassenger> Passengers => new(4, Ptr + 6040, 212, this);

    /// <summary>
    /// StructProperty: Passengers
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleNPC.FVehiclePassenger Passengers_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleNPC.FVehiclePassenger>(Ptr + 6040);
    /// <summary>
    /// StructProperty: Passengers
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleNPC.FVehiclePassenger Passengers_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleNPC.FVehiclePassenger>(Ptr + 6252);
    /// <summary>
    /// StructProperty: Passengers
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleNPC.FVehiclePassenger Passengers_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleNPC.FVehiclePassenger>(Ptr + 6464);
    /// <summary>
    /// StructProperty: Passengers
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleNPC.FVehiclePassenger Passengers_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleNPC.FVehiclePassenger>(Ptr + 6676);

    /// <summary>
    /// ArrayProperty: UnconsciousPassengers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> UnconsciousPassengers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 6888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6888); }
    }

    /// <summary>
    /// StructProperty: CombatMovementRestrictions
    /// </summary>
    public unsafe ref BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction CombatMovementRestrictions
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(Ptr + 6904);

    /// <summary>
    /// StructProperty: IndoorVisionCones
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleNPC.FVehicleVisionSet IndoorVisionCones
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleNPC.FVehicleVisionSet>(Ptr + 7072);

    /// <summary>
    /// StructProperty: OutdoorVisionCones
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleNPC.FVehicleVisionSet OutdoorVisionCones
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleNPC.FVehicleVisionSet>(Ptr + 7120);

    /// <summary>
    /// FloatProperty: LOSShootCheckZOffset
    /// </summary>
    public unsafe float LOSShootCheckZOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7168); }
    }

    /// <summary>
    /// StructProperty: VisionCones
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleNPC.FVehicleVisionSet VisionCones
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleNPC.FVehicleVisionSet>(Ptr + 7172);

    /// <summary>
    /// StructProperty: ExplosionScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ExplosionScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 7220);

    /// <summary>
    /// FloatProperty: TimeSinceLastDriverBark
    /// </summary>
    public unsafe float TimeSinceLastDriverBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7376); }
    }

    /// <summary>
    /// FloatProperty: TimeUntilNextDriverIdleBark
    /// </summary>
    public unsafe float TimeUntilNextDriverIdleBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7380); }
    }

    /// <summary>
    /// IntProperty: PriorityLastDriverBark
    /// </summary>
    public unsafe int PriorityLastDriverBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7384); }
    }

    /// <summary>
    /// NameProperty: LastDriverBarkId
    /// </summary>
    public unsafe BmSDK.FName LastDriverBarkId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7388); }
    }

    /// <summary>
    /// NameProperty: DelayedDriverBarkId
    /// </summary>
    public unsafe BmSDK.FName DelayedDriverBarkId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7396); }
    }

    /// <summary>
    /// IntProperty: DelayedDriverBarkPriority
    /// </summary>
    public unsafe int DelayedDriverBarkPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7404); }
    }

    /// <summary>
    /// FloatProperty: MinDelayBetweenIdleBarks
    /// </summary>
    public unsafe float MinDelayBetweenIdleBarks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7408); }
    }

    /// <summary>
    /// FloatProperty: MaxDelayBetweenIdleBarks
    /// </summary>
    public unsafe float MaxDelayBetweenIdleBarks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7412); }
    }

    /// <summary>
    /// FloatProperty: IdleBarkMaxBatmobileDist
    /// </summary>
    public unsafe float IdleBarkMaxBatmobileDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7416); }
    }

    /// <summary>
    /// FloatProperty: BatmobileNearBarkBatmobileDist
    /// </summary>
    public unsafe float BatmobileNearBarkBatmobileDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7420); }
    }

    /// <summary>
    /// FloatProperty: BatmobileNearBarkEscortDist
    /// </summary>
    public unsafe float BatmobileNearBarkEscortDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7424); }
    }

    /// <summary>
    /// StructProperty: DefaultWaveSpawnerProperties
    /// </summary>
    public unsafe ref BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.FSpawnedVehicleEnemyDesc DefaultWaveSpawnerProperties
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.FSpawnedVehicleEnemyDesc>(Ptr + 7428);

    /// <summary>
    /// IntProperty: MassResetTimer
    /// </summary>
    public unsafe int MassResetTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7516); }
    }

    /// <summary>
    /// StructProperty: TrailLastPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TrailLastPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7520);

    /// <summary>
    /// StructProperty: FireRotationOffset
    /// </summary>
    public unsafe ref BmSDK.Rotator FireRotationOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 7532);

    /// <summary>
    /// FloatProperty: MissileLockOnDuration
    /// </summary>
    public unsafe float MissileLockOnDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7544); }
    }

    /// <summary>
    /// FloatProperty: BehaviourDeltaTimeAcc
    /// </summary>
    public unsafe float BehaviourDeltaTimeAcc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7548); }
    }

    /// <summary>
    /// ArrayProperty: IndependentWeapons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.FWalkerWeaponContainer> IndependentWeapons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.FWalkerWeaponContainer>>(Ptr + 7552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7552); }
    }

    /// <summary>
    /// StructProperty: BatmanTakedownLocationOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatmanTakedownLocationOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7568);

    /// <summary>
    /// FloatProperty: AwareOfPlayerTime
    /// </summary>
    public unsafe float AwareOfPlayerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7580); }
    }

    /// <summary>
    /// FloatProperty: AwareOfPlayerMax
    /// </summary>
    public unsafe float AwareOfPlayerMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7584); }
    }

    /// <summary>
    /// IntProperty: LastLevelVolume
    /// </summary>
    public unsafe int LastLevelVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7588); }
    }

    /// <summary>
    /// StructProperty: LastSafeLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastSafeLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7592);

    /// <summary>
    /// StructProperty: LastSafeRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator LastSafeRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 7604);

    /// <summary>
    /// FloatProperty: FallingTime
    /// </summary>
    public unsafe float FallingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7616); }
    }
}
