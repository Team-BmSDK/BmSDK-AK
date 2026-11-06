#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPawnVillainGunPredBase<br/>
/// (size = 6792)
/// (flags = 10485815)
/// </summary>
public partial class RPawnVillainGunPredBase : BmSDK.BmGame.RPawnVillainGunBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnVillainGunPredBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillainGunPredBase.
    /// </summary>
    public static RPawnVillainGunPredBase DefaultObject => (RPawnVillainGunPredBase)StaticClass().DefaultObject;

    internal RPawnVillainGunPredBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainGunPredBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetCameraAnimset;
    /// <summary>
    /// Function: GetCameraAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetCameraAnimset(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraAnimset, "BmGame.RPawnVillainGunPredBase.GetCameraAnimset");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetVillainEnvTakedownAnimset;
    /// <summary>
    /// Function: GetVillainEnvTakedownAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetVillainEnvTakedownAnimset(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVillainEnvTakedownAnimset, "BmGame.RPawnVillainGunPredBase.GetVillainEnvTakedownAnimset");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPlayerEnvTakedownAnimset;
    /// <summary>
    /// Function: GetPlayerEnvTakedownAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetPlayerEnvTakedownAnimset(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerEnvTakedownAnimset, "BmGame.RPawnVillainGunPredBase.GetPlayerEnvTakedownAnimset");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmGame.RPawnVillainGunPredBase.Died");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RPawnVillainGunPredBase.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThrowRemoteAway;
    /// <summary>
    /// Function: ThrowRemoteAway
    /// </summary>
    public unsafe virtual void ThrowRemoteAway()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowRemoteAway, "BmGame.RPawnVillainGunPredBase.ThrowRemoteAway");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasRemoteBeenThrownAway;
    /// <summary>
    /// Function: HasRemoteBeenThrownAway
    /// </summary>
    public unsafe virtual bool HasRemoteBeenThrownAway()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasRemoteBeenThrownAway, "BmGame.RPawnVillainGunPredBase.HasRemoteBeenThrownAway");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsMiniDroneDisabledByREC;
    /// <summary>
    /// Function: IsMiniDroneDisabledByREC
    /// </summary>
    public unsafe virtual bool IsMiniDroneDisabledByREC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMiniDroneDisabledByREC, "BmGame.RPawnVillainGunPredBase.IsMiniDroneDisabledByREC");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UnequipMiniDroneController;
    /// <summary>
    /// Function: UnequipMiniDroneController
    /// </summary>
    public unsafe virtual void UnequipMiniDroneController()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnequipMiniDroneController, "BmGame.RPawnVillainGunPredBase.UnequipMiniDroneController");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EquipMiniDroneController;
    /// <summary>
    /// Function: EquipMiniDroneController
    /// </summary>
    public unsafe virtual void EquipMiniDroneController()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EquipMiniDroneController, "BmGame.RPawnVillainGunPredBase.EquipMiniDroneController");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeDisarmedByDirectMagBlast;
    /// <summary>
    /// Function: CanBeDisarmedByDirectMagBlast
    /// </summary>
    public unsafe override bool CanBeDisarmedByDirectMagBlast()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeDisarmedByDirectMagBlast, "BmGame.RPawnVillainGunPredBase.CanBeDisarmedByDirectMagBlast");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateCorePanicWeaponConfig;
    /// <summary>
    /// Function: CreateCorePanicWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateCorePanicWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2, BmSDK.Engine.AnimSet AnimSet3, BmSDK.Engine.AnimSet TurnAnimSet2)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateCorePanicWeaponConfig, "BmGame.RPawnVillainGunPredBase.CreateCorePanicWeaponConfig");
        byte* paramsPtr = stackalloc byte[11600];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet3, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnAnimSet2, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_CreateHitReactionWeaponConfigForGun;
    /// <summary>
    /// Function: CreateHitReactionWeaponConfigForGun
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateHitReactionWeaponConfigForGun(BmSDK.GameObject NewOwner, BmSDK.FName CombatMovementStance, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2 = default, BmSDK.Engine.AnimSet AnimSet3 = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateHitReactionWeaponConfigForGun, "BmGame.RPawnVillainGunPredBase.CreateHitReactionWeaponConfigForGun");
        byte* paramsPtr = stackalloc byte[660];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatMovementStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet3, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_AddGrenadeProps;
    /// <summary>
    /// Function: AddGrenadeProps
    /// </summary>
    public unsafe virtual void AddGrenadeProps()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGrenadeProps, "BmGame.RPawnVillainGunPredBase.AddGrenadeProps");
        byte* paramsPtr = stackalloc byte[312];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponSwitchCallback;
    /// <summary>
    /// Function: WeaponSwitchCallback
    /// </summary>
    public unsafe override void WeaponSwitchCallback(BmSDK.Engine.Inventory NewWeapon, BmSDK.Engine.Inventory PreviousWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponSwitchCallback, "BmGame.RPawnVillainGunPredBase.WeaponSwitchCallback");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousWeapon, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInXrayMode;
    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe override void SetInXrayMode(bool show, bool bForceOff)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInXrayMode, "BmGame.RPawnVillainGunPredBase.SetInXrayMode");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsAwareOfPlayer;
    /// <summary>
    /// Function: IsAwareOfPlayer
    /// </summary>
    public unsafe override bool IsAwareOfPlayer(BmSDK.BmGame.RPawnPlayer PlayerPawn, BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAwareOfPlayer, "BmGame.RPawnVillainGunPredBase.IsAwareOfPlayer");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_PlayerSpotted;
    /// <summary>
    /// Function: PlayerSpotted
    /// </summary>
    public unsafe override void PlayerSpotted(BmSDK.BmGame.RPawnPlayer SpottedPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerSpotted, "BmGame.RPawnVillainGunPredBase.PlayerSpotted");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpottedPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasDiscoveredJammedWeapon;
    /// <summary>
    /// Function: HasDiscoveredJammedWeapon
    /// </summary>
    public unsafe override bool HasDiscoveredJammedWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasDiscoveredJammedWeapon, "BmGame.RPawnVillainGunPredBase.HasDiscoveredJammedWeapon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DisruptedDMDExplode;
    /// <summary>
    /// Function: DisruptedDMDExplode
    /// </summary>
    public unsafe virtual void DisruptedDMDExplode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisruptedDMDExplode, "BmGame.RPawnVillainGunPredBase.DisruptedDMDExplode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GogglesBlinded;
    /// <summary>
    /// Function: GogglesBlinded
    /// </summary>
    public unsafe virtual bool GogglesBlinded()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GogglesBlinded, "BmGame.RPawnVillainGunPredBase.GogglesBlinded");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetVantageMineHidden;
    /// <summary>
    /// Function: SetVantageMineHidden
    /// </summary>
    public unsafe override void SetVantageMineHidden(bool bNewVal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVantageMineHidden, "BmGame.RPawnVillainGunPredBase.SetVantageMineHidden");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewVal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGrenadeHidden;
    /// <summary>
    /// Function: SetGrenadeHidden
    /// </summary>
    public unsafe override void SetGrenadeHidden(BmSDK.BmGame.RPawnVillainGunBase.LeftRight GrenadeHand, bool bNewVal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGrenadeHidden, "BmGame.RPawnVillainGunPredBase.SetGrenadeHidden");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrenadeHand, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewVal, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CurrentGrenadeFuseTime;
    /// <summary>
    /// Function: CurrentGrenadeFuseTime
    /// </summary>
    public unsafe override float CurrentGrenadeFuseTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CurrentGrenadeFuseTime, "BmGame.RPawnVillainGunPredBase.CurrentGrenadeFuseTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DoGrenadeLaunch;
    /// <summary>
    /// Function: DoGrenadeLaunch
    /// </summary>
    public unsafe override bool DoGrenadeLaunch(System.Numerics.Vector3 ThrowVel, System.Numerics.Vector3 TargetLoc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoGrenadeLaunch, "BmGame.RPawnVillainGunPredBase.DoGrenadeLaunch");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowVel, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLoc, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_TryThrowGrenade;
    /// <summary>
    /// Function: TryThrowGrenade
    /// </summary>
    public unsafe override bool TryThrowGrenade(System.Numerics.Vector3 TargetLoc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryThrowGrenade, "BmGame.RPawnVillainGunPredBase.TryThrowGrenade");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetGrenadeSpawnOffset;
    /// <summary>
    /// Function: GetGrenadeSpawnOffset
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetGrenadeSpawnOffset(BmSDK.Rotator PawnLaunchRot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGrenadeSpawnOffset, "BmGame.RPawnVillainGunPredBase.GetGrenadeSpawnOffset");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnLaunchRot, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PlaySound_Splash;
    /// <summary>
    /// Function: PlaySound_Splash
    /// </summary>
    public unsafe override void PlaySound_Splash()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound_Splash, "BmGame.RPawnVillainGunPredBase.PlaySound_Splash");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateMiniCombatWeaponConfig;
    /// <summary>
    /// Function: CreateMiniCombatWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateMiniCombatWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateMiniCombatWeaponConfig, "BmGame.RPawnVillainGunPredBase.CreateMiniCombatWeaponConfig");
        byte* paramsPtr = stackalloc byte[2384];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CreateWeaponConfigUnarmed;
    /// <summary>
    /// Function: CreateWeaponConfigUnarmed
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateWeaponConfigUnarmed(BmSDK.GameObject NewOwner)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeaponConfigUnarmed, "BmGame.RPawnVillainGunPredBase.CreateWeaponConfigUnarmed");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AttachProps;
    /// <summary>
    /// Function: AttachProps
    /// </summary>
    public unsafe override void AttachProps()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachProps, "BmGame.RPawnVillainGunPredBase.AttachProps");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmGame.RPawnVillainGunPredBase.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetIncendiaryGrenadeClass;
    /// <summary>
    /// Function: GetIncendiaryGrenadeClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetIncendiaryGrenadeClass()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIncendiaryGrenadeClass, "BmGame.RPawnVillainGunPredBase.GetIncendiaryGrenadeClass");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMineInVentTFRConfig;
    /// <summary>
    /// Function: GetMineInVentTFRConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RTransitionFromRunConfig GetMineInVentTFRConfig()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMineInVentTFRConfig, "BmGame.RPawnVillainGunPredBase.GetMineInVentTFRConfig");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RTransitionFromRunConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisruptorReactionAnimset;
    /// <summary>
    /// Function: GetDisruptorReactionAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetDisruptorReactionAnimset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisruptorReactionAnimset, "BmGame.RPawnVillainGunPredBase.GetDisruptorReactionAnimset");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDroneControllerAnimset;
    /// <summary>
    /// Function: GetDroneControllerAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetDroneControllerAnimset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDroneControllerAnimset, "BmGame.RPawnVillainGunPredBase.GetDroneControllerAnimset");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetVoiceSynthAnimSet;
    /// <summary>
    /// Function: GetVoiceSynthAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetVoiceSynthAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVoiceSynthAnimSet, "BmGame.RPawnVillainGunPredBase.GetVoiceSynthAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTerrorGuardAnimSet;
    /// <summary>
    /// Function: GetTerrorGuardAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetTerrorGuardAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTerrorGuardAnimSet, "BmGame.RPawnVillainGunPredBase.GetTerrorGuardAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDetectiveModeDetectorAnimSet;
    /// <summary>
    /// Function: GetDetectiveModeDetectorAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetDetectiveModeDetectorAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDetectiveModeDetectorAnimSet, "BmGame.RPawnVillainGunPredBase.GetDetectiveModeDetectorAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetVaultExplosivesAnimSet;
    /// <summary>
    /// Function: GetVaultExplosivesAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetVaultExplosivesAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVaultExplosivesAnimSet, "BmGame.RPawnVillainGunPredBase.GetVaultExplosivesAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCorePredAnimSet;
    /// <summary>
    /// Function: GetCorePredAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetCorePredAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCorePredAnimSet, "BmGame.RPawnVillainGunPredBase.GetCorePredAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMedicAnimSet;
    /// <summary>
    /// Function: GetMedicAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetMedicAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMedicAnimSet, "BmGame.RPawnVillainGunPredBase.GetMedicAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetManDownAnimSet;
    /// <summary>
    /// Function: GetManDownAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetManDownAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetManDownAnimSet, "BmGame.RPawnVillainGunPredBase.GetManDownAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGrateLookAnimSet;
    /// <summary>
    /// Function: GetGrateLookAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetGrateLookAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGrateLookAnimSet, "BmGame.RPawnVillainGunPredBase.GetGrateLookAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLedgeLookAnimSet;
    /// <summary>
    /// Function: GetLedgeLookAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetLedgeLookAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLedgeLookAnimSet, "BmGame.RPawnVillainGunPredBase.GetLedgeLookAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBuddyBumpAnimset;
    /// <summary>
    /// Function: GetBuddyBumpAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetBuddyBumpAnimset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBuddyBumpAnimset, "BmGame.RPawnVillainGunPredBase.GetBuddyBumpAnimset");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBuddyJoinAnimset;
    /// <summary>
    /// Function: GetBuddyJoinAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetBuddyJoinAnimset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBuddyJoinAnimset, "BmGame.RPawnVillainGunPredBase.GetBuddyJoinAnimset");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSideRoomSearchAnimSet;
    /// <summary>
    /// Function: GetSideRoomSearchAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetSideRoomSearchAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSideRoomSearchAnimSet, "BmGame.RPawnVillainGunPredBase.GetSideRoomSearchAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPairedCornerAnimSet;
    /// <summary>
    /// Function: GetPairedCornerAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetPairedCornerAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPairedCornerAnimSet, "BmGame.RPawnVillainGunPredBase.GetPairedCornerAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSoloCornerAnimSet;
    /// <summary>
    /// Function: GetSoloCornerAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetSoloCornerAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSoloCornerAnimSet, "BmGame.RPawnVillainGunPredBase.GetSoloCornerAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnOverrideTakedown;
    /// <summary>
    /// Function: SpawnOverrideTakedown
    /// </summary>
    public unsafe override bool SpawnOverrideTakedown(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnOverrideTakedown, "BmGame.RPawnVillainGunPredBase.SpawnOverrideTakedown");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DetonateDoor;
    /// <summary>
    /// Function: DetonateDoor
    /// </summary>
    public unsafe virtual void DetonateDoor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetonateDoor, "BmGame.RPawnVillainGunPredBase.DetonateDoor");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideExplosive;
    /// <summary>
    /// Function: HideExplosive
    /// </summary>
    public unsafe virtual void HideExplosive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideExplosive, "BmGame.RPawnVillainGunPredBase.HideExplosive");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// IntProperty: GrenadeLeftIndex
    /// </summary>
    public unsafe int GrenadeLeftIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6752); }
    }

    /// <summary>
    /// IntProperty: GrenadeRightIndex
    /// </summary>
    public unsafe int GrenadeRightIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6756); }
    }

    /// <summary>
    /// IntProperty: VantageMineIndex
    /// </summary>
    public unsafe int VantageMineIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6760); }
    }

    /// <summary>
    /// BoolProperty: bCanEnterLevelScriptingWhileCocky
    /// </summary>
    public unsafe bool bCanEnterLevelScriptingWhileCocky
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6764); }
    }

    /// <summary>
    /// BoolProperty: bDMDDetecting
    /// </summary>
    public unsafe bool bDMDDetecting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6764); }
    }

    /// <summary>
    /// BoolProperty: lastDMDSignalSucceeded
    /// </summary>
    public unsafe bool lastDMDSignalSucceeded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6764); }
    }

    /// <summary>
    /// BoolProperty: bDMDExploded
    /// </summary>
    public unsafe bool bDMDExploded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6764); }
    }

    /// <summary>
    /// BoolProperty: bHasDroneRemoteEquipped
    /// </summary>
    public unsafe bool bHasDroneRemoteEquipped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6764); }
    }

    /// <summary>
    /// BoolProperty: bHasNoticedDisruptedDroneRemote
    /// </summary>
    public unsafe bool bHasNoticedDisruptedDroneRemote
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6764); }
    }

    /// <summary>
    /// BoolProperty: bSpawnedArmband
    /// </summary>
    public unsafe bool bSpawnedArmband
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6764); }
    }

    /// <summary>
    /// FloatProperty: GoggleBlindTime
    /// </summary>
    public unsafe float GoggleBlindTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6768); }
    }

    /// <summary>
    /// FloatProperty: lastDMDSignalLineTime
    /// </summary>
    public unsafe float lastDMDSignalLineTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6772); }
    }

    /// <summary>
    /// FloatProperty: lastDMDDeactivateTime
    /// </summary>
    public unsafe float lastDMDDeactivateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6776); }
    }

    /// <summary>
    /// FloatProperty: lastDMDSignalLostTime
    /// </summary>
    public unsafe float lastDMDSignalLostTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6780); }
    }

    /// <summary>
    /// ObjectProperty: BankDoorPanel
    /// </summary>
    public unsafe BmSDK.BmGame.RBankDoorControlPanelBase BankDoorPanel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBankDoorControlPanelBase>(Ptr + 6784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6784); }
    }
}
