#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMCombatManager<br/>
/// (size = 2004)
/// (flags = 144703634)
/// </summary>
public partial class RBMCombatManager : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMCombatManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMCombatManager.
    /// </summary>
    public static RBMCombatManager DefaultObject => (RBMCombatManager)StaticClass().DefaultObject;

    internal RBMCombatManager() { }

    /// <summary>
    /// Constructs a new RBMCombatManager
    /// </summary>
    public RBMCombatManager(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMCombatManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_IsPlayerDamageSuspended;
    /// <summary>
    /// Function: IsPlayerDamageSuspended
    /// </summary>
    public unsafe virtual bool IsPlayerDamageSuspended()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayerDamageSuspended, "BmGame.RBMCombatManager.IsPlayerDamageSuspended");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SuspendPlayerDamage;
    /// <summary>
    /// Function: SuspendPlayerDamage
    /// </summary>
    public unsafe virtual void SuspendPlayerDamage(float Duration)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuspendPlayerDamage, "BmGame.RBMCombatManager.SuspendPlayerDamage");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlipAllOutOfCombatSmokeReactionsToBeInCombatSmokeReactions;
    /// <summary>
    /// Function: FlipAllOutOfCombatSmokeReactionsToBeInCombatSmokeReactions
    /// </summary>
    public unsafe virtual void FlipAllOutOfCombatSmokeReactionsToBeInCombatSmokeReactions()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlipAllOutOfCombatSmokeReactionsToBeInCombatSmokeReactions, "BmGame.RBMCombatManager.FlipAllOutOfCombatSmokeReactionsToBeInCombatSmokeReactions");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceHUDOn;
    /// <summary>
    /// Function: ForceHUDOn
    /// </summary>
    public unsafe virtual bool ForceHUDOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceHUDOn, "BmGame.RBMCombatManager.ForceHUDOn");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_VeryDangerousGunAttacks;
    /// <summary>
    /// Function: VeryDangerousGunAttacks
    /// </summary>
    public unsafe virtual bool VeryDangerousGunAttacks()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VeryDangerousGunAttacks, "BmGame.RBMCombatManager.VeryDangerousGunAttacks");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMostDangerousMultiStageWeapon;
    /// <summary>
    /// Function: GetMostDangerousMultiStageWeapon
    /// </summary>
    public unsafe virtual int GetMostDangerousMultiStageWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMostDangerousMultiStageWeapon, "BmGame.RBMCombatManager.GetMostDangerousMultiStageWeapon");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ThugsReact;
    /// <summary>
    /// Function: ThugsReact
    /// </summary>
    public unsafe virtual void ThugsReact(System.Numerics.Vector3 DangerSource, float AffectRadius, BmSDK.BmGame.RPawnVillain ExcludeThug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugsReact, "BmGame.RBMCombatManager.ThugsReact");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DangerSource, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AffectRadius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExcludeThug, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerSwitched;
    /// <summary>
    /// Function: PlayerSwitched
    /// </summary>
    public unsafe virtual void PlayerSwitched(BmSDK.BmGame.RPawnPlayer NewPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerSwitched, "BmGame.RBMCombatManager.PlayerSwitched");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPosWithinBatmobileTakedownRange;
    /// <summary>
    /// Function: IsPosWithinBatmobileTakedownRange
    /// </summary>
    public unsafe virtual bool IsPosWithinBatmobileTakedownRange(BmSDK.BmGame.RPawnVillain TestPawn, System.Numerics.Vector3 TestLocation, BmSDK.BmGame.RPawnPlayerCombat AttackingPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPosWithinBatmobileTakedownRange, "BmGame.RBMCombatManager.IsPosWithinBatmobileTakedownRange");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackingPlayer, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_DoesPosPassBatmobileTakedownLOSChecks;
    /// <summary>
    /// Function: DoesPosPassBatmobileTakedownLOSChecks
    /// </summary>
    public unsafe virtual bool DoesPosPassBatmobileTakedownLOSChecks(System.Numerics.Vector3 TestLocation, BmSDK.BmGame.RPawnVillain TestVillain, BmSDK.BmGame.RPawnPlayerCombat AttackingPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoesPosPassBatmobileTakedownLOSChecks, "BmGame.RBMCombatManager.DoesPosPassBatmobileTakedownLOSChecks");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestVillain, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackingPlayer, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_SetCurrBatmobileTakedownTargetHighlight;
    /// <summary>
    /// Function: SetCurrBatmobileTakedownTargetHighlight
    /// </summary>
    public unsafe virtual void SetCurrBatmobileTakedownTargetHighlight(bool bOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrBatmobileTakedownTargetHighlight, "BmGame.RBMCombatManager.SetCurrBatmobileTakedownTargetHighlight");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrBatmobileTakedownTarget;
    /// <summary>
    /// Function: SetCurrBatmobileTakedownTarget
    /// </summary>
    public unsafe virtual void SetCurrBatmobileTakedownTarget(BmSDK.BmGame.RPawnVillain NewTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrBatmobileTakedownTarget, "BmGame.RBMCombatManager.SetCurrBatmobileTakedownTarget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AreAllCombatantsPuzzleRobots;
    /// <summary>
    /// Function: AreAllCombatantsPuzzleRobots
    /// </summary>
    public unsafe virtual bool AreAllCombatantsPuzzleRobots()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreAllCombatantsPuzzleRobots, "BmGame.RBMCombatManager.AreAllCombatantsPuzzleRobots");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumUniqueWeaponsCrates;
    /// <summary>
    /// Function: GetNumUniqueWeaponsCrates
    /// </summary>
    public unsafe virtual int GetNumUniqueWeaponsCrates()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumUniqueWeaponsCrates, "BmGame.RBMCombatManager.GetNumUniqueWeaponsCrates");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumUniqueCombatantWeapons;
    /// <summary>
    /// Function: GetNumUniqueCombatantWeapons
    /// </summary>
    public unsafe virtual int GetNumUniqueCombatantWeapons(BmSDK.BmGame.RGameInfo.EHudWeaponType WeaponType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumUniqueCombatantWeapons, "BmGame.RBMCombatManager.GetNumUniqueCombatantWeapons");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNumUniqueThugCombatants;
    /// <summary>
    /// Function: GetNumUniqueThugCombatants
    /// </summary>
    public unsafe virtual int GetNumUniqueThugCombatants(bool bForXP, bool bIncludeThugs = default, bool bIncludeMilitia = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumUniqueThugCombatants, "BmGame.RBMCombatManager.GetNumUniqueThugCombatants");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForXP, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludeThugs, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludeMilitia, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetNumUniqueCombatants;
    /// <summary>
    /// Function: GetNumUniqueCombatants
    /// </summary>
    public unsafe virtual int GetNumUniqueCombatants(bool bForXP = default, BmSDK.Class TestClass = default, BmSDK.BmGame.RPawnCombat.ECombatPawnType PawnType = default, bool bIncludeThugs = default, bool bIncludeMilitia = default, bool bForceClassMatch = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumUniqueCombatants, "BmGame.RBMCombatManager.GetNumUniqueCombatants");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForXP, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestClass, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludeThugs, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludeMilitia, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceClassMatch, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ClearUniqueCombatants;
    /// <summary>
    /// Function: ClearUniqueCombatants
    /// </summary>
    public unsafe virtual void ClearUniqueCombatants()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearUniqueCombatants, "BmGame.RBMCombatManager.ClearUniqueCombatants");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddNearbyWeaponCratesForPawn;
    /// <summary>
    /// Function: AddNearbyWeaponCratesForPawn
    /// </summary>
    public unsafe virtual void AddNearbyWeaponCratesForPawn(BmSDK.BmGame.RPawnVillain Villain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddNearbyWeaponCratesForPawn, "BmGame.RBMCombatManager.AddNearbyWeaponCratesForPawn");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddUniqueCombatant;
    /// <summary>
    /// Function: AddUniqueCombatant
    /// </summary>
    public unsafe virtual void AddUniqueCombatant(BmSDK.BmGame.RPawnVillain NewCombatant)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddUniqueCombatant, "BmGame.RBMCombatManager.AddUniqueCombatant");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCombatant, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllUniqueCombatantsGiveXP;
    /// <summary>
    /// Function: AllUniqueCombatantsGiveXP
    /// </summary>
    public unsafe virtual bool AllUniqueCombatantsGiveXP()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllUniqueCombatantsGiveXP, "BmGame.RBMCombatManager.AllUniqueCombatantsGiveXP");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CacheCombatIdleList;
    /// <summary>
    /// Function: CacheCombatIdleList
    /// </summary>
    public unsafe virtual void CacheCombatIdleList(BmSDK.Engine.AnimSet TestAnimSet, out BmSDK.TArray<BmSDK.FName> outCombatIdleStances)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CacheCombatIdleList, "BmGame.RBMCombatManager.CacheCombatIdleList");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestAnimSet, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outCombatIdleStances = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_HasCachedCombatIdleList;
    /// <summary>
    /// Function: HasCachedCombatIdleList
    /// </summary>
    public unsafe virtual bool HasCachedCombatIdleList(BmSDK.Engine.AnimSet TestAnimSet, out BmSDK.TArray<BmSDK.FName> outIdleStances)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasCachedCombatIdleList, "BmGame.RBMCombatManager.HasCachedCombatIdleList");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestAnimSet, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outIdleStances = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CacheTauntList;
    /// <summary>
    /// Function: CacheTauntList
    /// </summary>
    public unsafe virtual void CacheTauntList(BmSDK.Engine.AnimSet TestAnimSet, out BmSDK.TArray<BmSDK.BmGame.RGameRI.FTauntAnimInfo> outTauntAnims)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CacheTauntList, "BmGame.RBMCombatManager.CacheTauntList");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestAnimSet, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outTauntAnims = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameRI.FTauntAnimInfo>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_HasCachedTauntList;
    /// <summary>
    /// Function: HasCachedTauntList
    /// </summary>
    public unsafe virtual bool HasCachedTauntList(BmSDK.Engine.AnimSet TestAnimSet, out BmSDK.TArray<BmSDK.BmGame.RGameRI.FTauntAnimInfo> outTauntAnims)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasCachedTauntList, "BmGame.RBMCombatManager.HasCachedTauntList");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestAnimSet, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outTauntAnims = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameRI.FTauntAnimInfo>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CacheStepList;
    /// <summary>
    /// Function: CacheStepList
    /// </summary>
    public unsafe virtual void CacheStepList(BmSDK.Engine.AnimSet TestAnimSet, out BmSDK.TArray<BmSDK.FName> outStepList, out BmSDK.TArray<BmSDK.FName> outLongStepList, BmSDK.FName outForwardStepName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CacheStepList, "BmGame.RBMCombatManager.CacheStepList");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestAnimSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outForwardStepName, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outStepList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 8);
        outLongStepList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_HasCachedStepList;
    /// <summary>
    /// Function: HasCachedStepList
    /// </summary>
    public unsafe virtual bool HasCachedStepList(BmSDK.Engine.AnimSet TestAnimSet, out BmSDK.TArray<BmSDK.FName> outStepList, out BmSDK.TArray<BmSDK.FName> outLongStepList, out BmSDK.FName outForwardStepName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasCachedStepList, "BmGame.RBMCombatManager.HasCachedStepList");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestAnimSet, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outForwardStepName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outForwardStepName, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outStepList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 8);
        outLongStepList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 24);
        outForwardStepName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_EnableBot;
    /// <summary>
    /// Function: EnableBot
    /// </summary>
    public unsafe virtual void EnableBot()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableBot, "BmGame.RBMCombatManager.EnableBot");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableBot;
    /// <summary>
    /// Function: DisableBot
    /// </summary>
    public unsafe virtual void DisableBot()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableBot, "BmGame.RBMCombatManager.DisableBot");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPawnToKeepInView;
    /// <summary>
    /// Function: GetPawnToKeepInView
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat GetPawnToKeepInView()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnToKeepInView, "BmGame.RBMCombatManager.GetPawnToKeepInView");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearPawnToKeepInView;
    /// <summary>
    /// Function: ClearPawnToKeepInView
    /// </summary>
    public unsafe virtual void ClearPawnToKeepInView()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPawnToKeepInView, "BmGame.RBMCombatManager.ClearPawnToKeepInView");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPawnToKeepInView;
    /// <summary>
    /// Function: SetPawnToKeepInView
    /// </summary>
    public unsafe virtual void SetPawnToKeepInView(BmSDK.BmGame.RPawnVillain TargetPawn, float MaxYaw = default, float PitchOffset = default, float PitchUpLimit = default, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed ViewSpeed = default, bool bLookAtLocation = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPawnToKeepInView, "BmGame.RBMCombatManager.SetPawnToKeepInView");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxYaw, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PitchOffset, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PitchUpLimit, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewSpeed, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLookAtLocation, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVenomCamera;
    /// <summary>
    /// Function: SetVenomCamera
    /// </summary>
    public unsafe virtual void SetVenomCamera(bool SetVenomCameraOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVenomCamera, "BmGame.RBMCombatManager.SetVenomCamera");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SetVenomCameraOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPlayerVIPTarget;
    /// <summary>
    /// Function: SetPlayerVIPTarget
    /// </summary>
    public unsafe virtual void SetPlayerVIPTarget(BmSDK.BmGame.RPawnVillain VIPTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerVIPTarget, "BmGame.RBMCombatManager.SetPlayerVIPTarget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VIPTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Stop2DCombatCamera;
    /// <summary>
    /// Function: Stop2DCombatCamera
    /// </summary>
    public unsafe virtual void Stop2DCombatCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Stop2DCombatCamera, "BmGame.RBMCombatManager.Stop2DCombatCamera");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Start2DCombatCamera;
    /// <summary>
    /// Function: Start2DCombatCamera
    /// </summary>
    public unsafe virtual void Start2DCombatCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Start2DCombatCamera, "BmGame.RBMCombatManager.Start2DCombatCamera");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetThugToPush;
    /// <summary>
    /// Function: GetThugToPush
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain GetThugToPush(BmSDK.BmGame.RPawnVillain Pusher)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThugToPush, "BmGame.RBMCombatManager.GetThugToPush");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pusher, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CallForThugHelper;
    /// <summary>
    /// Function: CallForThugHelper
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain CallForThugHelper(BmSDK.BmGame.RPawnVillain ThugInNeed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CallForThugHelper, "BmGame.RBMCombatManager.CallForThugHelper");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugInNeed, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanDoGrabAttack;
    /// <summary>
    /// Function: CanDoGrabAttack
    /// </summary>
    public unsafe virtual bool CanDoGrabAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoGrabAttack, "BmGame.RBMCombatManager.CanDoGrabAttack");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AllCombatantsAreFrozen;
    /// <summary>
    /// Function: AllCombatantsAreFrozen
    /// </summary>
    public unsafe virtual bool AllCombatantsAreFrozen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllCombatantsAreFrozen, "BmGame.RBMCombatManager.AllCombatantsAreFrozen");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ExitedNarrowCombatZone;
    /// <summary>
    /// Function: ExitedNarrowCombatZone
    /// </summary>
    public unsafe virtual void ExitedNarrowCombatZone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitedNarrowCombatZone, "BmGame.RBMCombatManager.ExitedNarrowCombatZone");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnteredNarrowCombatZone;
    /// <summary>
    /// Function: EnteredNarrowCombatZone
    /// </summary>
    public unsafe virtual void EnteredNarrowCombatZone(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnteredNarrowCombatZone, "BmGame.RBMCombatManager.EnteredNarrowCombatZone");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimeSinceLastNinjaDodge;
    /// <summary>
    /// Function: TimeSinceLastNinjaDodge
    /// </summary>
    public unsafe virtual float TimeSinceLastNinjaDodge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimeSinceLastNinjaDodge, "BmGame.RBMCombatManager.TimeSinceLastNinjaDodge");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NinjaDodged;
    /// <summary>
    /// Function: NinjaDodged
    /// </summary>
    public unsafe virtual void NinjaDodged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NinjaDodged, "BmGame.RBMCombatManager.NinjaDodged");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPawnHealthMultiplier;
    /// <summary>
    /// Function: GetPawnHealthMultiplier
    /// </summary>
    public unsafe virtual float GetPawnHealthMultiplier()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnHealthMultiplier, "BmGame.RBMCombatManager.GetPawnHealthMultiplier");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetPawnHealthMultiplier;
    /// <summary>
    /// Function: ResetPawnHealthMultiplier
    /// </summary>
    public unsafe virtual void ResetPawnHealthMultiplier()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPawnHealthMultiplier, "BmGame.RBMCombatManager.ResetPawnHealthMultiplier");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPawnHealthMultiplier;
    /// <summary>
    /// Function: SetPawnHealthMultiplier
    /// </summary>
    public unsafe virtual void SetPawnHealthMultiplier(float NewValue, bool bForceInNewGamePlus = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPawnHealthMultiplier, "BmGame.RBMCombatManager.SetPawnHealthMultiplier");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceInNewGamePlus, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsToughThugActive;
    /// <summary>
    /// Function: IsToughThugActive
    /// </summary>
    public unsafe virtual bool IsToughThugActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsToughThugActive, "BmGame.RBMCombatManager.IsToughThugActive");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumActiveCombatThugs;
    /// <summary>
    /// Function: GetNumActiveCombatThugs
    /// </summary>
    public unsafe virtual int GetNumActiveCombatThugs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumActiveCombatThugs, "BmGame.RBMCombatManager.GetNumActiveCombatThugs");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumJoiningCombatantsForInterrogation;
    /// <summary>
    /// Function: GetNumJoiningCombatantsForInterrogation
    /// </summary>
    public unsafe virtual int GetNumJoiningCombatantsForInterrogation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumJoiningCombatantsForInterrogation, "BmGame.RBMCombatManager.GetNumJoiningCombatantsForInterrogation");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumNonStasisJoiningCombatants;
    /// <summary>
    /// Function: GetNumNonStasisJoiningCombatants
    /// </summary>
    public unsafe virtual int GetNumNonStasisJoiningCombatants()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumNonStasisJoiningCombatants, "BmGame.RBMCombatManager.GetNumNonStasisJoiningCombatants");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumJoiningCombatants;
    /// <summary>
    /// Function: GetNumJoiningCombatants
    /// </summary>
    public unsafe virtual int GetNumJoiningCombatants()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumJoiningCombatants, "BmGame.RBMCombatManager.GetNumJoiningCombatants");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveJoiningCombatant;
    /// <summary>
    /// Function: RemoveJoiningCombatant
    /// </summary>
    public unsafe virtual void RemoveJoiningCombatant(BmSDK.BmGame.RPawnVillain OldCombatant)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveJoiningCombatant, "BmGame.RBMCombatManager.RemoveJoiningCombatant");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldCombatant, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddJoiningCombatant;
    /// <summary>
    /// Function: AddJoiningCombatant
    /// </summary>
    public unsafe virtual void AddJoiningCombatant(BmSDK.BmGame.RPawnVillain NewCombatant)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddJoiningCombatant, "BmGame.RBMCombatManager.AddJoiningCombatant");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCombatant, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ListWeaponConfigRefs;
    /// <summary>
    /// Function: ListWeaponConfigRefs
    /// </summary>
    public unsafe virtual void ListWeaponConfigRefs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListWeaponConfigRefs, "BmGame.RBMCombatManager.ListWeaponConfigRefs");
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearWeaponConfigRef;
    /// <summary>
    /// Function: ClearWeaponConfigRef
    /// </summary>
    public unsafe virtual void ClearWeaponConfigRef(BmSDK.BmGame.RBMCombatManager.EWeaponConfigType ConfigType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearWeaponConfigRef, "BmGame.RBMCombatManager.ClearWeaponConfigRef");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConfigType, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetWeaponConfig;
    /// <summary>
    /// Function: SetWeaponConfig
    /// </summary>
    public unsafe virtual void SetWeaponConfig(BmSDK.BmGame.RBMCombatManager.EWeaponConfigType ConfigType, BmSDK.BmGame.RWeaponConfig NewConfig)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWeaponConfig, "BmGame.RBMCombatManager.SetWeaponConfig");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConfigType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewConfig, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWeaponConfigAndAddRef;
    /// <summary>
    /// Function: GetWeaponConfigAndAddRef
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig GetWeaponConfigAndAddRef(BmSDK.BmGame.RBMCombatManager.EWeaponConfigType ConfigType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponConfigAndAddRef, "BmGame.RBMCombatManager.GetWeaponConfigAndAddRef");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConfigType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasWeaponConfigFor;
    /// <summary>
    /// Function: HasWeaponConfigFor
    /// </summary>
    public unsafe virtual bool HasWeaponConfigFor(BmSDK.BmGame.RBMCombatManager.EWeaponConfigType ConfigType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasWeaponConfigFor, "BmGame.RBMCombatManager.HasWeaponConfigFor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConfigType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FingersStamped;
    /// <summary>
    /// Function: FingersStamped
    /// </summary>
    public unsafe virtual void FingersStamped()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FingersStamped, "BmGame.RBMCombatManager.FingersStamped");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanStampOnFingers;
    /// <summary>
    /// Function: CanStampOnFingers
    /// </summary>
    public unsafe virtual bool CanStampOnFingers(BmSDK.BmGame.RPawnVillain Stamper)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanStampOnFingers, "BmGame.RBMCombatManager.CanStampOnFingers");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stamper, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_BrickThrown;
    /// <summary>
    /// Function: BrickThrown
    /// </summary>
    public unsafe virtual void BrickThrown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BrickThrown, "BmGame.RBMCombatManager.BrickThrown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanThrowBrick;
    /// <summary>
    /// Function: CanThrowBrick
    /// </summary>
    public unsafe virtual bool CanThrowBrick(BmSDK.BmGame.RPawnVillain Thrower, bool bGrenade = default, bool bHalveTimeCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanThrowBrick, "BmGame.RBMCombatManager.CanThrowBrick");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thrower, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGrenade, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHalveTimeCheck, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsForceFinalSimultaneousAttackDisabled;
    /// <summary>
    /// Function: IsForceFinalSimultaneousAttackDisabled
    /// </summary>
    public unsafe virtual bool IsForceFinalSimultaneousAttackDisabled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsForceFinalSimultaneousAttackDisabled, "BmGame.RBMCombatManager.IsForceFinalSimultaneousAttackDisabled");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMaxSimCounterers;
    /// <summary>
    /// Function: GetMaxSimCounterers
    /// </summary>
    public unsafe virtual int GetMaxSimCounterers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxSimCounterers, "BmGame.RBMCombatManager.GetMaxSimCounterers");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetSimultaneousAttackTimer;
    /// <summary>
    /// Function: SetSimultaneousAttackTimer
    /// </summary>
    public unsafe virtual void SetSimultaneousAttackTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSimultaneousAttackTimer, "BmGame.RBMCombatManager.SetSimultaneousAttackTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDifficultyValue;
    /// <summary>
    /// Function: GetDifficultyValue
    /// </summary>
    public unsafe virtual float GetDifficultyValue(BmSDK.BmGame.RBMCombatManager.EDifficultyType EDT, BmSDK.BmGame.RBMPawnAI TestPawn = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDifficultyValue, "BmGame.RBMCombatManager.GetDifficultyValue");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EDT, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_TriggerCombatCowerEvent;
    /// <summary>
    /// Function: TriggerCombatCowerEvent
    /// </summary>
    public unsafe virtual int TriggerCombatCowerEvent(BmSDK.BmGame.RPawnCombat EventInstigator, System.Numerics.Vector3 EventLocation, float LOSRadius = default, float NoLOSRadius = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCombatCowerEvent, "BmGame.RBMCombatManager.TriggerCombatCowerEvent");
        byte* paramsPtr = stackalloc byte[300];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LOSRadius, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoLOSRadius, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_TriggerCombatEvent;
    /// <summary>
    /// Function: TriggerCombatEvent
    /// </summary>
    public unsafe virtual void TriggerCombatEvent(BmSDK.BmGame.RPawnCombat EventInstigator, System.Numerics.Vector3 EventLocation, System.Numerics.Vector3 SightingLocation, float LOSRadius = default, float NoLOSRadius = default, bool bCanAlertInOtherPylons = default, bool bForceSightingTimeUpdate = default, bool bFearTakedownReaction = default, bool bAlertRioters = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCombatEvent, "BmGame.RBMCombatManager.TriggerCombatEvent");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SightingLocation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LOSRadius, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoLOSRadius, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanAlertInOtherPylons, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceSightingTimeUpdate, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFearTakedownReaction, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAlertRioters, paramsPtr + 52);
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

    private static BmSDK.Function __fn_KillAllEnemies;
    /// <summary>
    /// Function: KillAllEnemies
    /// </summary>
    public unsafe virtual bool KillAllEnemies(BmSDK.Engine.Controller PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillAllEnemies, "BmGame.RBMCombatManager.KillAllEnemies");
        byte* paramsPtr = stackalloc byte[300];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_InputRightStick;
    /// <summary>
    /// Function: InputRightStick
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 InputRightStick(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InputRightStick, "BmGame.RBMCombatManager.InputRightStick");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_InputLeftStick;
    /// <summary>
    /// Function: InputLeftStick
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 InputLeftStick(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InputLeftStick, "BmGame.RBMCombatManager.InputLeftStick");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_EnableCombatBarks;
    /// <summary>
    /// Function: EnableCombatBarks
    /// </summary>
    public unsafe virtual void EnableCombatBarks(bool bEnable)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableCombatBarks, "BmGame.RBMCombatManager.EnableCombatBarks");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCombatBarkOnRandomPawn;
    /// <summary>
    /// Function: PlayCombatBarkOnRandomPawn
    /// </summary>
    public unsafe virtual void PlayCombatBarkOnRandomPawn(BmSDK.FName EventName, BmSDK.BmGame.RPawnCombat AvoidPawn = default, BmSDK.BmGame.RBarkValDef.FlagTypeEnum FlagType = default, BmSDK.FName FlagValue = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCombatBarkOnRandomPawn, "BmGame.RBMCombatManager.PlayCombatBarkOnRandomPawn");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvoidPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagValue, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTirednessStateForBarks;
    /// <summary>
    /// Function: GetTirednessStateForBarks
    /// </summary>
    public unsafe virtual BmSDK.FName GetTirednessStateForBarks(BmSDK.BmGame.RPawnVillain SpeakingPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTirednessStateForBarks, "BmGame.RBMCombatManager.GetTirednessStateForBarks");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeakingPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetLastPickup;
    /// <summary>
    /// Function: SetLastPickup
    /// </summary>
    public unsafe virtual void SetLastPickup(BmSDK.BmGame.RBMWeapon Weapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLastPickup, "BmGame.RBMCombatManager.SetLastPickup");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTimeBetweenBarkMultiplier;
    /// <summary>
    /// Function: SetTimeBetweenBarkMultiplier
    /// </summary>
    public unsafe virtual void SetTimeBetweenBarkMultiplier(float NewTimeBetweenBarkMultiplier)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTimeBetweenBarkMultiplier, "BmGame.RBMCombatManager.SetTimeBetweenBarkMultiplier");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTimeBetweenBarkMultiplier, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlayBarkForPickup;
    /// <summary>
    /// Function: CanPlayBarkForPickup
    /// </summary>
    public unsafe virtual bool CanPlayBarkForPickup(BmSDK.BmGame.RBMWeapon NewWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayBarkForPickup, "BmGame.RBMCombatManager.CanPlayBarkForPickup");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FleeCombatBarkPlayed;
    /// <summary>
    /// Function: FleeCombatBarkPlayed
    /// </summary>
    public unsafe virtual void FleeCombatBarkPlayed(System.Numerics.Vector3 PawnPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FleeCombatBarkPlayed, "BmGame.RBMCombatManager.FleeCombatBarkPlayed");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_JoinCombatBarkPlayed;
    /// <summary>
    /// Function: JoinCombatBarkPlayed
    /// </summary>
    public unsafe virtual void JoinCombatBarkPlayed(System.Numerics.Vector3 PawnPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JoinCombatBarkPlayed, "BmGame.RBMCombatManager.JoinCombatBarkPlayed");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarkPlayed;
    /// <summary>
    /// Function: BarkPlayed
    /// </summary>
    public unsafe virtual void BarkPlayed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarkPlayed, "BmGame.RBMCombatManager.BarkPlayed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEnterCombatBark;
    /// <summary>
    /// Function: GetEnterCombatBark
    /// </summary>
    public unsafe virtual BmSDK.FName GetEnterCombatBark(BmSDK.BmGame.RPawnVillain Villain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEnterCombatBark, "BmGame.RBMCombatManager.GetEnterCombatBark");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ShootBatmobileBarkPlayed;
    /// <summary>
    /// Function: ShootBatmobileBarkPlayed
    /// </summary>
    public unsafe virtual void ShootBatmobileBarkPlayed(System.Numerics.Vector3 PawnPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShootBatmobileBarkPlayed, "BmGame.RBMCombatManager.ShootBatmobileBarkPlayed");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlayShootBatmobileBark;
    /// <summary>
    /// Function: CanPlayShootBatmobileBark
    /// </summary>
    public unsafe virtual bool CanPlayShootBatmobileBark(System.Numerics.Vector3 PawnPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayShootBatmobileBark, "BmGame.RBMCombatManager.CanPlayShootBatmobileBark");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CanPlayFleeCombatBark;
    /// <summary>
    /// Function: CanPlayFleeCombatBark
    /// </summary>
    public unsafe virtual bool CanPlayFleeCombatBark(System.Numerics.Vector3 PawnPos, bool bIgnoreAnySpeechCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayFleeCombatBark, "BmGame.RBMCombatManager.CanPlayFleeCombatBark");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreAnySpeechCheck, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CanPlayJoinCombatBark;
    /// <summary>
    /// Function: CanPlayJoinCombatBark
    /// </summary>
    public unsafe virtual bool CanPlayJoinCombatBark(System.Numerics.Vector3 PawnPos, BmSDK.BmGame.RPawnVillain Villain, bool bWasSpeaking = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayJoinCombatBark, "BmGame.RBMCombatManager.CanPlayJoinCombatBark");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSpeaking, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ResetCanPlaySeeCombatBark;
    /// <summary>
    /// Function: ResetCanPlaySeeCombatBark
    /// </summary>
    public unsafe virtual void ResetCanPlaySeeCombatBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetCanPlaySeeCombatBark, "BmGame.RBMCombatManager.ResetCanPlaySeeCombatBark");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayedSeeCombatBark;
    /// <summary>
    /// Function: PlayedSeeCombatBark
    /// </summary>
    public unsafe virtual void PlayedSeeCombatBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayedSeeCombatBark, "BmGame.RBMCombatManager.PlayedSeeCombatBark");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlaySeeCombatBark;
    /// <summary>
    /// Function: CanPlaySeeCombatBark
    /// </summary>
    public unsafe virtual bool CanPlaySeeCombatBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlaySeeCombatBark, "BmGame.RBMCombatManager.CanPlaySeeCombatBark");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TimeSinceLastBark;
    /// <summary>
    /// Function: TimeSinceLastBark
    /// </summary>
    public unsafe virtual float TimeSinceLastBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimeSinceLastBark, "BmGame.RBMCombatManager.TimeSinceLastBark");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBark;
    /// <summary>
    /// Function: CanBark
    /// </summary>
    public unsafe virtual bool CanBark(bool bHighPriorityBark = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBark, "BmGame.RBMCombatManager.CanBark");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHighPriorityBark, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TauntPerformed;
    /// <summary>
    /// Function: TauntPerformed
    /// </summary>
    public unsafe virtual void TauntPerformed(int TauntID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TauntPerformed, "BmGame.RBMCombatManager.TauntPerformed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TauntID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLastTauntID;
    /// <summary>
    /// Function: GetLastTauntID
    /// </summary>
    public unsafe virtual int GetLastTauntID()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLastTauntID, "BmGame.RBMCombatManager.GetLastTauntID");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanTaunt;
    /// <summary>
    /// Function: CanTaunt
    /// </summary>
    public unsafe virtual bool CanTaunt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTaunt, "BmGame.RBMCombatManager.CanTaunt");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldSuppressXP;
    /// <summary>
    /// Function: ShouldSuppressXP
    /// </summary>
    public unsafe virtual bool ShouldSuppressXP()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSuppressXP, "BmGame.RBMCombatManager.ShouldSuppressXP");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UnsuppressXP;
    /// <summary>
    /// Function: UnsuppressXP
    /// </summary>
    public unsafe virtual void UnsuppressXP(BmSDK.GameObject UnSuppressor, bool bGiveXP)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnsuppressXP, "BmGame.RBMCombatManager.UnsuppressXP");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnSuppressor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGiveXP, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuppressXP;
    /// <summary>
    /// Function: SuppressXP
    /// </summary>
    public unsafe virtual void SuppressXP(BmSDK.GameObject Suppressor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuppressXP, "BmGame.RBMCombatManager.SuppressXP");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Suppressor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldSuppressFinalBlow;
    /// <summary>
    /// Function: ShouldSuppressFinalBlow
    /// </summary>
    public unsafe virtual bool ShouldSuppressFinalBlow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSuppressFinalBlow, "BmGame.RBMCombatManager.ShouldSuppressFinalBlow");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UnsuppressFinalBlow;
    /// <summary>
    /// Function: UnsuppressFinalBlow
    /// </summary>
    public unsafe virtual void UnsuppressFinalBlow(BmSDK.GameObject UnSuppressor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnsuppressFinalBlow, "BmGame.RBMCombatManager.UnsuppressFinalBlow");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnSuppressor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuppressFinalBlow;
    /// <summary>
    /// Function: SuppressFinalBlow
    /// </summary>
    public unsafe virtual void SuppressFinalBlow(BmSDK.GameObject Suppressor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuppressFinalBlow, "BmGame.RBMCombatManager.SuppressFinalBlow");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Suppressor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBaseMoveScore;
    /// <summary>
    /// Function: GetBaseMoveScore
    /// </summary>
    public unsafe virtual int GetBaseMoveScore(BmSDK.BmGame.RGameInfo.EComboMoveType MoveType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBaseMoveScore, "BmGame.RBMCombatManager.GetBaseMoveScore");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBatmanLookAt;
    /// <summary>
    /// Function: GetBatmanLookAt
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat GetBatmanLookAt(BmSDK.BmGame.RPawnPlayerCombat BatmanPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatmanLookAt, "BmGame.RBMCombatManager.GetBatmanLookAt");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_BatmanBlocked;
    /// <summary>
    /// Function: BatmanBlocked
    /// </summary>
    public unsafe virtual void BatmanBlocked(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmanBlocked, "BmGame.RBMCombatManager.BatmanBlocked");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DelayNextAttack;
    /// <summary>
    /// Function: DelayNextAttack
    /// </summary>
    public unsafe virtual void DelayNextAttack(float DelayAmount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DelayNextAttack, "BmGame.RBMCombatManager.DelayNextAttack");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DelayAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearAttackListForTitanBeatUp;
    /// <summary>
    /// Function: ClearAttackListForTitanBeatUp
    /// </summary>
    public unsafe virtual void ClearAttackListForTitanBeatUp(float Time, BmSDK.BmGame.RPawnPlayerCombat Batman)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAttackListForTitanBeatUp, "BmGame.RBMCombatManager.ClearAttackListForTitanBeatUp");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Batman, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmanHit;
    /// <summary>
    /// Function: BatmanHit
    /// </summary>
    public unsafe virtual void BatmanHit(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RPawnCombat Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmanHit, "BmGame.RBMCombatManager.BatmanHit");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuccessfulRedirect;
    /// <summary>
    /// Function: SuccessfulRedirect
    /// </summary>
    public unsafe virtual void SuccessfulRedirect(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuccessfulRedirect, "BmGame.RBMCombatManager.SuccessfulRedirect");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuccessfulEvade;
    /// <summary>
    /// Function: SuccessfulEvade
    /// </summary>
    public unsafe virtual void SuccessfulEvade(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuccessfulEvade, "BmGame.RBMCombatManager.SuccessfulEvade");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuccessfulCounter;
    /// <summary>
    /// Function: SuccessfulCounter
    /// </summary>
    public unsafe virtual void SuccessfulCounter(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RPawnCombat HitPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuccessfulCounter, "BmGame.RBMCombatManager.SuccessfulCounter");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuccessfulStun;
    /// <summary>
    /// Function: SuccessfulStun
    /// </summary>
    public unsafe virtual void SuccessfulStun(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuccessfulStun, "BmGame.RBMCombatManager.SuccessfulStun");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ComboStrikeHit;
    /// <summary>
    /// Function: ComboStrikeHit
    /// </summary>
    public unsafe virtual void ComboStrikeHit(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ComboStrikeHit, "BmGame.RBMCombatManager.ComboStrikeHit");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HeavyStrikeHit;
    /// <summary>
    /// Function: HeavyStrikeHit
    /// </summary>
    public unsafe virtual void HeavyStrikeHit(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RPawnCombat HitPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HeavyStrikeHit, "BmGame.RBMCombatManager.HeavyStrikeHit");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickStrikeHit;
    /// <summary>
    /// Function: QuickStrikeHit
    /// </summary>
    public unsafe virtual void QuickStrikeHit(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RPawnCombat HitPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickStrikeHit, "BmGame.RBMCombatManager.QuickStrikeHit");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HeavyStrikeKO;
    /// <summary>
    /// Function: HeavyStrikeKO
    /// </summary>
    public unsafe virtual void HeavyStrikeKO(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RPawnCharacter TakedownTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HeavyStrikeKO, "BmGame.RBMCombatManager.HeavyStrikeKO");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TakedownTarget, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickStrikeKO;
    /// <summary>
    /// Function: QuickStrikeKO
    /// </summary>
    public unsafe virtual void QuickStrikeKO(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RPawnCharacter TakedownTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickStrikeKO, "BmGame.RBMCombatManager.QuickStrikeKO");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TakedownTarget, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckCameraTarget;
    /// <summary>
    /// Function: CheckCameraTarget
    /// </summary>
    public unsafe virtual void CheckCameraTarget(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.Engine.Actor CheckCameraTargetActor, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed CheckCameraLookAtSpeed, System.Numerics.Vector3 CheckCameraTargetOffset)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckCameraTarget, "BmGame.RBMCombatManager.CheckCameraTarget");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckCameraTargetActor, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckCameraLookAtSpeed, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckCameraTargetOffset, paramsPtr + 20);
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

    private static BmSDK.Function __fn_GetCombatCameraScoreForPawn;
    /// <summary>
    /// Function: GetCombatCameraScoreForPawn
    /// </summary>
    public unsafe virtual float GetCombatCameraScoreForPawn(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RPawnVillain TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatCameraScoreForPawn, "BmGame.RBMCombatManager.GetCombatCameraScoreForPawn");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetOffscreenScore;
    /// <summary>
    /// Function: GetOffscreenScore
    /// </summary>
    public unsafe virtual float GetOffscreenScore(BmSDK.BmGame.RPawnCombat TestPawn, System.Numerics.Vector3 CamVec, System.Numerics.Vector3 BatmanPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOffscreenScore, "BmGame.RBMCombatManager.GetOffscreenScore");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamVec, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanPos, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetTimeBetweenHitAndAttack;
    /// <summary>
    /// Function: GetTimeBetweenHitAndAttack
    /// </summary>
    public unsafe virtual float GetTimeBetweenHitAndAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeBetweenHitAndAttack, "BmGame.RBMCombatManager.GetTimeBetweenHitAndAttack");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetIgnoreDDA;
    /// <summary>
    /// Function: SetIgnoreDDA
    /// </summary>
    public unsafe virtual void SetIgnoreDDA(bool bNewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIgnoreDDA, "BmGame.RBMCombatManager.SetIgnoreDDA");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOverrideChapter;
    /// <summary>
    /// Function: SetOverrideChapter
    /// </summary>
    public unsafe virtual void SetOverrideChapter(float NewOverrideChapter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOverrideChapter, "BmGame.RBMCombatManager.SetOverrideChapter");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOverrideChapter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCombatChapterForEnemySpawn;
    /// <summary>
    /// Function: GetCombatChapterForEnemySpawn
    /// </summary>
    public unsafe virtual float GetCombatChapterForEnemySpawn(int ActualChapter, BmSDK.BmGame.RBMPawnAI SpawnedThug, bool bIgnoreDDA)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatChapterForEnemySpawn, "BmGame.RBMCombatManager.GetCombatChapterForEnemySpawn");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActualChapter, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnedThug, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreDDA, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetCombatChapterForEnemyMoves;
    /// <summary>
    /// Function: GetCombatChapterForEnemyMoves
    /// </summary>
    public unsafe virtual float GetCombatChapterForEnemyMoves()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatChapterForEnemyMoves, "BmGame.RBMCombatManager.GetCombatChapterForEnemyMoves");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCombatChapter;
    /// <summary>
    /// Function: GetCombatChapter
    /// </summary>
    public unsafe virtual float GetCombatChapter(int ActualChapter = default, bool bIgnoreDDA = default, BmSDK.BmGame.RPawnCombat TestPawn = default, bool bIgnorePlayerOverrideVolume = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatChapter, "BmGame.RBMCombatManager.GetCombatChapter");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActualChapter, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreDDA, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnorePlayerOverrideVolume, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_IsOtherCombatantInCombatRange;
    /// <summary>
    /// Function: IsOtherCombatantInCombatRange
    /// </summary>
    public unsafe virtual bool IsOtherCombatantInCombatRange(BmSDK.BmGame.RPawnCombat ExcludePawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOtherCombatantInCombatRange, "BmGame.RBMCombatManager.IsOtherCombatantInCombatRange");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExcludePawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_OtherPawnsAreInPawnsRangeForFinalBlow;
    /// <summary>
    /// Function: OtherPawnsAreInPawnsRangeForFinalBlow
    /// </summary>
    public unsafe virtual bool OtherPawnsAreInPawnsRangeForFinalBlow(BmSDK.BmGame.RPawnCombat TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OtherPawnsAreInPawnsRangeForFinalBlow, "BmGame.RBMCombatManager.OtherPawnsAreInPawnsRangeForFinalBlow");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ShouldDoFinalBlowCam;
    /// <summary>
    /// Function: ShouldDoFinalBlowCam
    /// </summary>
    public unsafe virtual bool ShouldDoFinalBlowCam(BmSDK.BmGame.RPawnCombat Target, bool bIgnoreDeadPawns = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldDoFinalBlowCam, "BmGame.RBMCombatManager.ShouldDoFinalBlowCam");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreDeadPawns, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetNumAttackers;
    /// <summary>
    /// Function: GetNumAttackers
    /// </summary>
    public unsafe virtual int GetNumAttackers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumAttackers, "BmGame.RBMCombatManager.GetNumAttackers");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAnyoneAttackingWithNonGun;
    /// <summary>
    /// Function: IsAnyoneAttackingWithNonGun
    /// </summary>
    public unsafe virtual bool IsAnyoneAttackingWithNonGun(BmSDK.BmGame.RPawnCombat Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAnyoneAttackingWithNonGun, "BmGame.RBMCombatManager.IsAnyoneAttackingWithNonGun");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsAnyoneAttacking;
    /// <summary>
    /// Function: IsAnyoneAttacking
    /// </summary>
    public unsafe virtual bool IsAnyoneAttacking(BmSDK.BmGame.RPawnCombat Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAnyoneAttacking, "BmGame.RBMCombatManager.IsAnyoneAttacking");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UnlockAchievement;
    /// <summary>
    /// Function: UnlockAchievement
    /// </summary>
    public unsafe virtual void UnlockAchievement(BmSDK.BmGame.RGameInfo.EAchievementID Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockAchievement, "BmGame.RBMCombatManager.UnlockAchievement");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnDied;
    /// <summary>
    /// Function: PawnDied
    /// </summary>
    public unsafe virtual void PawnDied(BmSDK.BmGame.RPawnCombat DeadPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnDied, "BmGame.RBMCombatManager.PawnDied");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeadPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTimeSinceFinishedCombat;
    /// <summary>
    /// Function: GetTimeSinceFinishedCombat
    /// </summary>
    public unsafe virtual float GetTimeSinceFinishedCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeSinceFinishedCombat, "BmGame.RBMCombatManager.GetTimeSinceFinishedCombat");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FinishedCombatMoreThan1Second;
    /// <summary>
    /// Function: FinishedCombatMoreThan1Second
    /// </summary>
    public unsafe virtual void FinishedCombatMoreThan1Second()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedCombatMoreThan1Second, "BmGame.RBMCombatManager.FinishedCombatMoreThan1Second");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishedCombat;
    /// <summary>
    /// Function: FinishedCombat
    /// </summary>
    public unsafe virtual void FinishedCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedCombat, "BmGame.RBMCombatManager.FinishedCombat");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetPerFightStats;
    /// <summary>
    /// Function: ResetPerFightStats
    /// </summary>
    public unsafe virtual void ResetPerFightStats(bool bForce = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPerFightStats, "BmGame.RBMCombatManager.ResetPerFightStats");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatSuccessTriggered;
    /// <summary>
    /// Function: CombatSuccessTriggered
    /// </summary>
    public unsafe virtual void CombatSuccessTriggered()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatSuccessTriggered, "BmGame.RBMCombatManager.CombatSuccessTriggered");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableDDATracking;
    /// <summary>
    /// Function: DisableDDATracking
    /// </summary>
    public unsafe virtual void DisableDDATracking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableDDATracking, "BmGame.RBMCombatManager.DisableDDATracking");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableDDATracking;
    /// <summary>
    /// Function: EnableDDATracking
    /// </summary>
    public unsafe virtual void EnableDDATracking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableDDATracking, "BmGame.RBMCombatManager.EnableDDATracking");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemovePawnFromList;
    /// <summary>
    /// Function: RemovePawnFromList
    /// </summary>
    public unsafe virtual void RemovePawnFromList(BmSDK.BmGame.RPawnCombat ToRemove, bool bRemovedDueToKO = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemovePawnFromList, "BmGame.RBMCombatManager.RemovePawnFromList");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToRemove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRemovedDueToKO, paramsPtr + 8);
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

    private static BmSDK.Function __fn_DebugCombatAreas;
    /// <summary>
    /// Function: DebugCombatAreas
    /// </summary>
    public unsafe virtual void DebugCombatAreas()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCombatAreas, "BmGame.RBMCombatManager.DebugCombatAreas");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMaxCombatPawns;
    /// <summary>
    /// Function: UpdateMaxCombatPawns
    /// </summary>
    public unsafe virtual void UpdateMaxCombatPawns(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMaxCombatPawns, "BmGame.RBMCombatManager.UpdateMaxCombatPawns");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMaxCombatPawns;
    /// <summary>
    /// Function: SetMaxCombatPawns
    /// </summary>
    public unsafe virtual void SetMaxCombatPawns(int NewMaxPawns)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMaxCombatPawns, "BmGame.RBMCombatManager.SetMaxCombatPawns");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMaxPawns, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindTargetPlayer;
    /// <summary>
    /// Function: FindTargetPlayer
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayerCombat FindTargetPlayer(BmSDK.BmGame.RPawnVillain Villain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindTargetPlayer, "BmGame.RBMCombatManager.FindTargetPlayer");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CombatBarkCanHappen;
    /// <summary>
    /// Function: CombatBarkCanHappen
    /// </summary>
    public unsafe virtual bool CombatBarkCanHappen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatBarkCanHappen, "BmGame.RBMCombatManager.CombatBarkCanHappen");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMostRecentSightingLocationForTarget;
    /// <summary>
    /// Function: GetMostRecentSightingLocationForTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetMostRecentSightingLocationForTarget(BmSDK.Engine.Actor TestActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMostRecentSightingLocationForTarget, "BmGame.RBMCombatManager.GetMostRecentSightingLocationForTarget");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetMostRecentSightingTimeForTarget;
    /// <summary>
    /// Function: GetMostRecentSightingTimeForTarget
    /// </summary>
    public unsafe virtual float GetMostRecentSightingTimeForTarget(BmSDK.Engine.Actor TestActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMostRecentSightingTimeForTarget, "BmGame.RBMCombatManager.GetMostRecentSightingTimeForTarget");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_BatmobileSeen;
    /// <summary>
    /// Function: BatmobileSeen
    /// </summary>
    public unsafe virtual void BatmobileSeen(System.Numerics.Vector3 NewLocation = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmobileSeen, "BmGame.RBMCombatManager.BatmobileSeen");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLastSeenLocation;
    /// <summary>
    /// Function: SetLastSeenLocation
    /// </summary>
    public unsafe virtual void SetLastSeenLocation(System.Numerics.Vector3 NewLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLastSeenLocation, "BmGame.RBMCombatManager.SetLastSeenLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerSeen;
    /// <summary>
    /// Function: PlayerSeen
    /// </summary>
    public unsafe virtual void PlayerSeen(System.Numerics.Vector3 NewLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerSeen, "BmGame.RBMCombatManager.PlayerSeen");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateCombatStepper;
    /// <summary>
    /// Function: UpdateCombatStepper
    /// </summary>
    public unsafe virtual void UpdateCombatStepper()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCombatStepper, "BmGame.RBMCombatManager.UpdateCombatStepper");
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

    private static BmSDK.Function __fn_AreAllPlayersDead;
    /// <summary>
    /// Function: AreAllPlayersDead
    /// </summary>
    public unsafe virtual bool AreAllPlayersDead()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreAllPlayersDead, "BmGame.RBMCombatManager.AreAllPlayersDead");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPDD;
    /// <summary>
    /// Function: GetPDD
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPersistentDebugData GetPDD()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPDD, "BmGame.RBMCombatManager.GetPDD");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentDebugData>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PunishingAttackPerformed;
    /// <summary>
    /// Function: PunishingAttackPerformed
    /// </summary>
    public unsafe virtual void PunishingAttackPerformed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PunishingAttackPerformed, "BmGame.RBMCombatManager.PunishingAttackPerformed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPerformPunishingAttack;
    /// <summary>
    /// Function: CanPerformPunishingAttack
    /// </summary>
    public unsafe virtual bool CanPerformPunishingAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformPunishingAttack, "BmGame.RBMCombatManager.CanPerformPunishingAttack");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateAllPickupableThrownObjectAuras;
    /// <summary>
    /// Function: UpdateAllPickupableThrownObjectAuras
    /// </summary>
    public unsafe virtual void UpdateAllPickupableThrownObjectAuras()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAllPickupableThrownObjectAuras, "BmGame.RBMCombatManager.UpdateAllPickupableThrownObjectAuras");
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

    private static BmSDK.Function __fn_LeavingCombat;
    /// <summary>
    /// Function: LeavingCombat
    /// </summary>
    public unsafe virtual void LeavingCombat(BmSDK.BmGame.RPawnCombat Leaver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LeavingCombat, "BmGame.RBMCombatManager.LeavingCombat");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Leaver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TellPlayerControllerCombatFinished;
    /// <summary>
    /// Function: TellPlayerControllerCombatFinished
    /// </summary>
    public unsafe virtual void TellPlayerControllerCombatFinished(bool bBatmanVictorious)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TellPlayerControllerCombatFinished, "BmGame.RBMCombatManager.TellPlayerControllerCombatFinished");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBatmanVictorious, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TellPlayerControllerCombatStarted;
    /// <summary>
    /// Function: TellPlayerControllerCombatStarted
    /// </summary>
    public unsafe virtual void TellPlayerControllerCombatStarted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TellPlayerControllerCombatStarted, "BmGame.RBMCombatManager.TellPlayerControllerCombatStarted");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterPawn;
    /// <summary>
    /// Function: RegisterPawn
    /// </summary>
    public unsafe virtual void RegisterPawn(BmSDK.BmGame.RPawnCombat NewPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterPawn, "BmGame.RBMCombatManager.RegisterPawn");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnregisterRetreatFromBatmobilePawn;
    /// <summary>
    /// Function: UnregisterRetreatFromBatmobilePawn
    /// </summary>
    public unsafe virtual void UnregisterRetreatFromBatmobilePawn(BmSDK.BmGame.RPawnVillain Thug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterRetreatFromBatmobilePawn, "BmGame.RBMCombatManager.UnregisterRetreatFromBatmobilePawn");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRetreatFromBatmobileActorForPawn;
    /// <summary>
    /// Function: GetRetreatFromBatmobileActorForPawn
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetRetreatFromBatmobileActorForPawn(BmSDK.BmGame.RPawnVillain Thug, out BmSDK.TArray<BmSDK.Engine.Actor> ExcludeActors, BmSDK.Engine.Actor TargetActor = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRetreatFromBatmobileActorForPawn, "BmGame.RBMCombatManager.GetRetreatFromBatmobileActorForPawn");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thug, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetActor, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ExcludeActors = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_UnRegisterRetreatFromBatmobilePoint;
    /// <summary>
    /// Function: UnRegisterRetreatFromBatmobilePoint
    /// </summary>
    public unsafe virtual void UnRegisterRetreatFromBatmobilePoint(BmSDK.BmGame.RCombatRetreatFromBatmobilePoint OldPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnRegisterRetreatFromBatmobilePoint, "BmGame.RBMCombatManager.UnRegisterRetreatFromBatmobilePoint");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterRetreatFromBatmobilePoint;
    /// <summary>
    /// Function: RegisterRetreatFromBatmobilePoint
    /// </summary>
    public unsafe virtual void RegisterRetreatFromBatmobilePoint(BmSDK.BmGame.RCombatRetreatFromBatmobilePoint NewPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterRetreatFromBatmobilePoint, "BmGame.RBMCombatManager.RegisterRetreatFromBatmobilePoint");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsNearVillainBlocker;
    /// <summary>
    /// Function: IsNearVillainBlocker
    /// </summary>
    public unsafe virtual bool IsNearVillainBlocker(System.Numerics.Vector3 TestLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNearVillainBlocker, "BmGame.RBMCombatManager.IsNearVillainBlocker");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RemoveVillainDoorBlocker;
    /// <summary>
    /// Function: RemoveVillainDoorBlocker
    /// </summary>
    public unsafe virtual void RemoveVillainDoorBlocker(BmSDK.BmGame.RBunkerDoorVillainBlocker Old)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveVillainDoorBlocker, "BmGame.RBMCombatManager.RemoveVillainDoorBlocker");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Old, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterVillainDoorBlocker;
    /// <summary>
    /// Function: RegisterVillainDoorBlocker
    /// </summary>
    public unsafe virtual void RegisterVillainDoorBlocker(BmSDK.BmGame.RBunkerDoorVillainBlocker NewDoorBlocker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterVillainDoorBlocker, "BmGame.RBMCombatManager.RegisterVillainDoorBlocker");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDoorBlocker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLastTargetStates;
    /// <summary>
    /// Function: ClearLastTargetStates
    /// </summary>
    public unsafe virtual void ClearLastTargetStates()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLastTargetStates, "BmGame.RBMCombatManager.ClearLastTargetStates");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateCombatEvent;
    /// <summary>
    /// Function: ActivateCombatEvent
    /// </summary>
    public unsafe virtual void ActivateCombatEvent(BmSDK.Class EventClass, BmSDK.Engine.Actor NewInstigator)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateCombatEvent, "BmGame.RBMCombatManager.ActivateCombatEvent");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewInstigator, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterCombatEvent;
    /// <summary>
    /// Function: RegisterCombatEvent
    /// </summary>
    public unsafe virtual void RegisterCombatEvent(BmSDK.BmGame.RCombatEvent NewEvent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterCombatEvent, "BmGame.RBMCombatManager.RegisterCombatEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewEvent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGuardPointForPawn;
    /// <summary>
    /// Function: GetGuardPointForPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RCombatArea_GuardPoint GetGuardPointForPawn(BmSDK.BmGame.RBMPawnAI Guard)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGuardPointForPawn, "BmGame.RBMCombatManager.GetGuardPointForPawn");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Guard, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatArea_GuardPoint>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RemoveGuardPoint;
    /// <summary>
    /// Function: RemoveGuardPoint
    /// </summary>
    public unsafe virtual void RemoveGuardPoint(BmSDK.BmGame.RCombatArea_GuardPoint ToRemove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveGuardPoint, "BmGame.RBMCombatManager.RemoveGuardPoint");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToRemove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddGuardPoint;
    /// <summary>
    /// Function: AddGuardPoint
    /// </summary>
    public unsafe virtual void AddGuardPoint(BmSDK.BmGame.RCombatArea_GuardPoint ToAdd)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGuardPoint, "BmGame.RBMCombatManager.AddGuardPoint");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToAdd, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmanLeftCombatArea;
    /// <summary>
    /// Function: BatmanLeftCombatArea
    /// </summary>
    public unsafe virtual void BatmanLeftCombatArea(BmSDK.BmGame.RCombatArea CombatArea)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmanLeftCombatArea, "BmGame.RBMCombatManager.BatmanLeftCombatArea");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatArea, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasCombatAreas;
    /// <summary>
    /// Function: HasCombatAreas
    /// </summary>
    public unsafe virtual bool HasCombatAreas()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasCombatAreas, "BmGame.RBMCombatManager.HasCombatAreas");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GatherCombatAreaForces;
    /// <summary>
    /// Function: GatherCombatAreaForces
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GatherCombatAreaForces(BmSDK.BmGame.RPawnCombat Pawn, float MaxForce)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GatherCombatAreaForces, "BmGame.RBMCombatManager.GatherCombatAreaForces");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxForce, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetCombatAreaForce;
    /// <summary>
    /// Function: GetCombatAreaForce
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetCombatAreaForce(BmSDK.BmGame.RCombatArea Area, BmSDK.BmGame.RPawnCombat Pawn, float MaxForce)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatAreaForce, "BmGame.RBMCombatManager.GetCombatAreaForce");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Area, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxForce, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetCombatArea;
    /// <summary>
    /// Function: GetCombatArea
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RCombatArea GetCombatArea(System.Numerics.Vector3 CheckLoc = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatArea, "BmGame.RBMCombatManager.GetCombatArea");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatArea>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RemoveCombatArea;
    /// <summary>
    /// Function: RemoveCombatArea
    /// </summary>
    public unsafe virtual void RemoveCombatArea(BmSDK.BmGame.RCombatArea ToRemove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveCombatArea, "BmGame.RBMCombatManager.RemoveCombatArea");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToRemove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCombatArea;
    /// <summary>
    /// Function: AddCombatArea
    /// </summary>
    public unsafe virtual void AddCombatArea(BmSDK.BmGame.RCombatArea ToAdd)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCombatArea, "BmGame.RBMCombatManager.AddCombatArea");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToAdd, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNumCasualtyForMedic;
    /// <summary>
    /// Function: GetNumCasualtyForMedic
    /// </summary>
    public unsafe virtual int GetNumCasualtyForMedic(BmSDK.BmGame.RPawnVillain NewMedic, BmSDK.BmGame.RPawnCombat NewTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumCasualtyForMedic, "BmGame.RBMCombatManager.GetNumCasualtyForMedic");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMedic, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ShouldPrioritiseChargedUpAttacks;
    /// <summary>
    /// Function: ShouldPrioritiseChargedUpAttacks
    /// </summary>
    public unsafe virtual bool ShouldPrioritiseChargedUpAttacks()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldPrioritiseChargedUpAttacks, "BmGame.RBMCombatManager.ShouldPrioritiseChargedUpAttacks");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanFindThugToChargeUp;
    /// <summary>
    /// Function: CanFindThugToChargeUp
    /// </summary>
    public unsafe virtual bool CanFindThugToChargeUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanFindThugToChargeUp, "BmGame.RBMCombatManager.CanFindThugToChargeUp");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetThugToChargeUp;
    /// <summary>
    /// Function: GetThugToChargeUp
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain GetThugToChargeUp(BmSDK.BmGame.RPawnVillainThugMedic Medic)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThugToChargeUp, "BmGame.RBMCombatManager.GetThugToChargeUp");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Medic, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetThugToChargeUpScore;
    /// <summary>
    /// Function: GetThugToChargeUpScore
    /// </summary>
    public unsafe virtual float GetThugToChargeUpScore(BmSDK.BmGame.RPawnVillain Medic, BmSDK.BmGame.RPawnVillain TestThug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThugToChargeUpScore, "BmGame.RBMCombatManager.GetThugToChargeUpScore");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Medic, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestThug, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetCasualtyForMedic;
    /// <summary>
    /// Function: GetCasualtyForMedic
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain GetCasualtyForMedic(BmSDK.BmGame.RPawnVillain NewMedic, BmSDK.BmGame.RPawnCombat NewTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCasualtyForMedic, "BmGame.RBMCombatManager.GetCasualtyForMedic");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMedic, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetCasualtyScore;
    /// <summary>
    /// Function: GetCasualtyScore
    /// </summary>
    public unsafe virtual float GetCasualtyScore(BmSDK.BmGame.RPawnVillain Medic, BmSDK.BmGame.RPawnVillain Casualty)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCasualtyScore, "BmGame.RBMCombatManager.GetCasualtyScore");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Medic, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Casualty, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetCombatPointForPawn;
    /// <summary>
    /// Function: GetCombatPointForPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatPoint GetCombatPointForPawn(BmSDK.BmGame.RPawnCombat NewUser, BmSDK.BmGame.RPawnCombat NewTarget, bool bTaunting)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatPointForPawn, "BmGame.RBMCombatManager.GetCombatPointForPawn");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUser, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTaunting, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatPoint>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_CanMoveToPointToUseObject;
    /// <summary>
    /// Function: CanMoveToPointToUseObject
    /// </summary>
    public unsafe virtual bool CanMoveToPointToUseObject(BmSDK.BmGame.RPawnCombat TestPawn, System.Numerics.Vector3 TestPoint, float MinPlayerDist = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanMoveToPointToUseObject, "BmGame.RBMCombatManager.CanMoveToPointToUseObject");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinPlayerDist, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_HasGunLocker;
    /// <summary>
    /// Function: HasGunLocker
    /// </summary>
    public unsafe virtual bool HasGunLocker()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasGunLocker, "BmGame.RBMCombatManager.HasGunLocker");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLocationInDualplayZone;
    /// <summary>
    /// Function: GetLocationInDualplayZone
    /// </summary>
    public unsafe virtual bool GetLocationInDualplayZone(System.Numerics.Vector3 TestPawnLocation, out System.Numerics.Vector3 ZoneLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocationInDualplayZone, "BmGame.RBMCombatManager.GetLocationInDualplayZone");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawnLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ZoneLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ZoneLocation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ZoneLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetDualplayZoneContainingLoc;
    /// <summary>
    /// Function: GetDualplayZoneContainingLoc
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RDualplayZone GetDualplayZoneContainingLoc(System.Numerics.Vector3 TestLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDualplayZoneContainingLoc, "BmGame.RBMCombatManager.GetDualplayZoneContainingLoc");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDualplayZone>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetDualplayZone;
    /// <summary>
    /// Function: GetDualplayZone
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RDualplayZone GetDualplayZone(System.Numerics.Vector3 TestLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDualplayZone, "BmGame.RBMCombatManager.GetDualplayZone");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDualplayZone>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RemoveDualplayZone;
    /// <summary>
    /// Function: RemoveDualplayZone
    /// </summary>
    public unsafe virtual void RemoveDualplayZone(BmSDK.BmGame.RDualplayZone OldZone)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveDualplayZone, "BmGame.RBMCombatManager.RemoveDualplayZone");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldZone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDualplayZone;
    /// <summary>
    /// Function: AddDualplayZone
    /// </summary>
    public unsafe virtual void AddDualplayZone(BmSDK.BmGame.RDualplayZone NewZone)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDualplayZone, "BmGame.RBMCombatManager.AddDualplayZone");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewZone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCombatAttractorForce;
    /// <summary>
    /// Function: GetCombatAttractorForce
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetCombatAttractorForce(BmSDK.BmGame.RPawnCombat Receiver, float MaxForce)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatAttractorForce, "BmGame.RBMCombatManager.GetCombatAttractorForce");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Receiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxForce, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RemoveCombatAttactor;
    /// <summary>
    /// Function: RemoveCombatAttactor
    /// </summary>
    public unsafe virtual void RemoveCombatAttactor(BmSDK.BmGame.RCombatAttractor OldAttractor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveCombatAttactor, "BmGame.RBMCombatManager.RemoveCombatAttactor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldAttractor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCombatAttractor;
    /// <summary>
    /// Function: AddCombatAttractor
    /// </summary>
    public unsafe virtual void AddCombatAttractor(BmSDK.BmGame.RCombatAttractor NewAttractor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCombatAttractor, "BmGame.RBMCombatManager.AddCombatAttractor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttractor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveThrowTarget;
    /// <summary>
    /// Function: RemoveThrowTarget
    /// </summary>
    public unsafe virtual void RemoveThrowTarget(BmSDK.BmGame.RThrowTarget RemoveTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveThrowTarget, "BmGame.RBMCombatManager.RemoveThrowTarget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemoveTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddThrowTarget;
    /// <summary>
    /// Function: AddThrowTarget
    /// </summary>
    public unsafe virtual void AddThrowTarget(BmSDK.BmGame.RThrowTarget NewTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddThrowTarget, "BmGame.RBMCombatManager.AddThrowTarget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveCombatPoint;
    /// <summary>
    /// Function: RemoveCombatPoint
    /// </summary>
    public unsafe virtual void RemoveCombatPoint(BmSDK.BmGame.RBMCombatPoint _RemoveCombatPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveCombatPoint, "BmGame.RBMCombatManager.RemoveCombatPoint");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RemoveCombatPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCombatPoint;
    /// <summary>
    /// Function: AddCombatPoint
    /// </summary>
    public unsafe virtual void AddCombatPoint(BmSDK.BmGame.RBMCombatPoint NewCombatPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCombatPoint, "BmGame.RBMCombatManager.AddCombatPoint");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCombatPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanShowCounterIcons;
    /// <summary>
    /// Function: CanShowCounterIcons
    /// </summary>
    public unsafe virtual bool CanShowCounterIcons()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanShowCounterIcons, "BmGame.RBMCombatManager.CanShowCounterIcons");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetNewGamePlus;
    /// <summary>
    /// Function: SetNewGamePlus
    /// </summary>
    public unsafe virtual void SetNewGamePlus()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNewGamePlus, "BmGame.RBMCombatManager.SetNewGamePlus");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RBMCombatManager.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AreAnyCombatantsTargettingPawn;
    /// <summary>
    /// Function: AreAnyCombatantsTargettingPawn
    /// </summary>
    public unsafe virtual bool AreAnyCombatantsTargettingPawn(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreAnyCombatantsTargettingPawn, "BmGame.RBMCombatManager.AreAnyCombatantsTargettingPawn");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UpdateRiotCombatWallah;
    /// <summary>
    /// Function: UpdateRiotCombatWallah
    /// </summary>
    public unsafe virtual void UpdateRiotCombatWallah(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRiotCombatWallah, "BmGame.RBMCombatManager.UpdateRiotCombatWallah");
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

    private static BmSDK.Function __fn_StartRiotCombatWallah;
    /// <summary>
    /// Function: StartRiotCombatWallah
    /// </summary>
    public unsafe virtual void StartRiotCombatWallah()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartRiotCombatWallah, "BmGame.RBMCombatManager.StartRiotCombatWallah");
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

    private static BmSDK.Function __fn_IsPosInBatmobileLOSForTakedown;
    /// <summary>
    /// Function: IsPosInBatmobileLOSForTakedown
    /// </summary>
    public unsafe virtual bool IsPosInBatmobileLOSForTakedown(BmSDK.BmGame.RPawnVillain TestVillain, System.Numerics.Vector3 TestLoc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPosInBatmobileLOSForTakedown, "BmGame.RBMCombatManager.IsPosInBatmobileLOSForTakedown");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestVillain, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLoc, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_FillDamageProxyCache;
    /// <summary>
    /// Function: FillDamageProxyCache
    /// </summary>
    public unsafe virtual void FillDamageProxyCache(int NumInCache)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FillDamageProxyCache, "BmGame.RBMCombatManager.FillDamageProxyCache");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumInCache, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ReleaseDamageProxy;
    /// <summary>
    /// Function: ReleaseDamageProxy
    /// </summary>
    public unsafe virtual void ReleaseDamageProxy(BmSDK.BmGame.RBMCombatDamageProxy Proxy)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseDamageProxy, "BmGame.RBMCombatManager.ReleaseDamageProxy");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proxy, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetDamageProxyForPawn;
    /// <summary>
    /// Function: GetDamageProxyForPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatDamageProxy GetDamageProxyForPawn(BmSDK.BmGame.RPawnCombat NewPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageProxyForPawn, "BmGame.RBMCombatManager.GetDamageProxyForPawn");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPawn, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatDamageProxy>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetClosestCombatThugDistance;
    /// <summary>
    /// Function: GetClosestCombatThugDistance
    /// </summary>
    public unsafe virtual float GetClosestCombatThugDistance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestCombatThugDistance, "BmGame.RBMCombatManager.GetClosestCombatThugDistance");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInAnyCombat_Audio;
    /// <summary>
    /// Function: IsInAnyCombat_Audio
    /// </summary>
    public unsafe virtual bool IsInAnyCombat_Audio()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInAnyCombat_Audio, "BmGame.RBMCombatManager.IsInAnyCombat_Audio");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInDefiniteCombat_Audio;
    /// <summary>
    /// Function: IsInDefiniteCombat_Audio
    /// </summary>
    public unsafe virtual bool IsInDefiniteCombat_Audio()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInDefiniteCombat_Audio, "BmGame.RBMCombatManager.IsInDefiniteCombat_Audio");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumSnipers;
    /// <summary>
    /// Function: GetNumSnipers
    /// </summary>
    public unsafe virtual int GetNumSnipers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumSnipers, "BmGame.RBMCombatManager.GetNumSnipers");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsRiotCombatActiveInPylon;
    /// <summary>
    /// Function: IsRiotCombatActiveInPylon
    /// </summary>
    public unsafe virtual bool IsRiotCombatActiveInPylon(BmSDK.Engine.Pylon CheckPylon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRiotCombatActiveInPylon, "BmGame.RBMCombatManager.IsRiotCombatActiveInPylon");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckPylon, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsCombatActiveInPylon;
    /// <summary>
    /// Function: IsCombatActiveInPylon
    /// </summary>
    public unsafe virtual bool IsCombatActiveInPylon(BmSDK.Engine.Pylon CheckPylon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCombatActiveInPylon, "BmGame.RBMCombatManager.IsCombatActiveInPylon");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckPylon, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetInterrogationTarget;
    /// <summary>
    /// Function: GetInterrogationTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain GetInterrogationTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInterrogationTarget, "BmGame.RBMCombatManager.GetInterrogationTarget");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanUseInterrogation;
    /// <summary>
    /// Function: CanUseInterrogation
    /// </summary>
    public unsafe virtual bool CanUseInterrogation(System.Numerics.Vector3 CheckLocation, bool bIgnoreNumCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseInterrogation, "BmGame.RBMCombatManager.CanUseInterrogation");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreNumCheck, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsOnscreen;
    /// <summary>
    /// Function: IsOnscreen
    /// </summary>
    public unsafe virtual bool IsOnscreen(System.Numerics.Vector3 CheckLocation, BmSDK.BmGame.RPawnCombat PlayerPawn, System.Numerics.Vector3 CameraPositionOffset = default, float MaxCosMulti = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOnscreen, "BmGame.RBMCombatManager.IsOnscreen");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraPositionOffset, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxCosMulti, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetAngleFromPawnToPawn;
    /// <summary>
    /// Function: GetAngleFromPawnToPawn
    /// </summary>
    public unsafe virtual float GetAngleFromPawnToPawn(BmSDK.BmGame.RPawnCombat Pawn1, BmSDK.BmGame.RPawnCombat Pawn2)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAngleFromPawnToPawn, "BmGame.RBMCombatManager.GetAngleFromPawnToPawn");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn2, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetPawnBetweenPoints;
    /// <summary>
    /// Function: GetPawnBetweenPoints
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat GetPawnBetweenPoints(System.Numerics.Vector3 SourceLocation, System.Numerics.Vector3 TargetLocation, out BmSDK.TArray<BmSDK.BmGame.RPawnCombat> IgnorePawnList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnBetweenPoints, "BmGame.RBMCombatManager.GetPawnBetweenPoints");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        IgnorePawnList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_LOSFromPawnToPawn;
    /// <summary>
    /// Function: LOSFromPawnToPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat LOSFromPawnToPawn(BmSDK.BmGame.RPawnCombat Pawn1, BmSDK.BmGame.RPawnCombat Pawn2)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LOSFromPawnToPawn, "BmGame.RBMCombatManager.LOSFromPawnToPawn");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn2, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsDeepInCombat;
    /// <summary>
    /// Function: IsDeepInCombat
    /// </summary>
    public unsafe virtual bool IsDeepInCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDeepInCombat, "BmGame.RBMCombatManager.IsDeepInCombat");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateAttackersForTarget;
    /// <summary>
    /// Function: UpdateAttackersForTarget
    /// </summary>
    public unsafe virtual void UpdateAttackersForTarget(BmSDK.BmGame.RPawnCombat TargetPawn, float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAttackersForTarget, "BmGame.RBMCombatManager.UpdateAttackersForTarget");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
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

    private static BmSDK.Function __fn_AssignAttackerTargets;
    /// <summary>
    /// Function: AssignAttackerTargets
    /// </summary>
    public unsafe virtual void AssignAttackerTargets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignAttackerTargets, "BmGame.RBMCombatManager.AssignAttackerTargets");
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

    private static BmSDK.Function __fn_UpdateAttackers;
    /// <summary>
    /// Function: UpdateAttackers
    /// </summary>
    public unsafe virtual void UpdateAttackers(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAttackers, "BmGame.RBMCombatManager.UpdateAttackers");
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

    private static BmSDK.Function __fn_CanUseCombatPoint;
    /// <summary>
    /// Function: CanUseCombatPoint
    /// </summary>
    public unsafe virtual bool CanUseCombatPoint(bool bIgnoreProportion = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseCombatPoint, "BmGame.RBMCombatManager.CanUseCombatPoint");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreProportion, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNumCombatantsForInterrogation;
    /// <summary>
    /// Function: GetNumCombatantsForInterrogation
    /// </summary>
    public unsafe virtual int GetNumCombatantsForInterrogation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumCombatantsForInterrogation, "BmGame.RBMCombatManager.GetNumCombatantsForInterrogation");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumCombatants;
    /// <summary>
    /// Function: GetNumCombatants
    /// </summary>
    public unsafe virtual int GetNumCombatants()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumCombatants, "BmGame.RBMCombatManager.GetNumCombatants");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CacheNumCombatants;
    /// <summary>
    /// Function: CacheNumCombatants
    /// </summary>
    public unsafe virtual void CacheNumCombatants(bool bRemovedDueToKO = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CacheNumCombatants, "BmGame.RBMCombatManager.CacheNumCombatants");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRemovedDueToKO, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ShouldForceCombatCamera;
    /// <summary>
    /// Function: ShouldForceCombatCamera
    /// </summary>
    public unsafe virtual bool ShouldForceCombatCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceCombatCamera, "BmGame.RBMCombatManager.ShouldForceCombatCamera");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldLockDoors;
    /// <summary>
    /// Function: ShouldLockDoors
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.ECombatLockType ShouldLockDoors()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldLockDoors, "BmGame.RBMCombatManager.ShouldLockDoors");
        byte* paramsPtr = stackalloc byte[1];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ECombatLockType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAnyVillainNearLocation;
    /// <summary>
    /// Function: IsAnyVillainNearLocation
    /// </summary>
    public unsafe virtual bool IsAnyVillainNearLocation(System.Numerics.Vector3 TestLocation, float TestRadius)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAnyVillainNearLocation, "BmGame.RBMCombatManager.IsAnyVillainNearLocation");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestRadius, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsCombatantNearLocation;
    /// <summary>
    /// Function: IsCombatantNearLocation
    /// </summary>
    public unsafe virtual bool IsCombatantNearLocation(System.Numerics.Vector3 TestLocation, float TestRadius)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCombatantNearLocation, "BmGame.RBMCombatManager.IsCombatantNearLocation");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestRadius, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsLocationInCombatArea;
    /// <summary>
    /// Function: IsLocationInCombatArea
    /// </summary>
    public unsafe virtual bool IsLocationInCombatArea(System.Numerics.Vector3 TestLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLocationInCombatArea, "BmGame.RBMCombatManager.IsLocationInCombatArea");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Struct: FCombatantInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FCombatantInfo
    {
        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Pawn
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnVillain Pawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ClassProperty: PawnClass
        /// </summary>
        public unsafe BmSDK.Class PawnClass
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ClassProperty: WeaponClass
        /// </summary>
        public unsafe BmSDK.Class WeaponClass
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bIsMilitia
        /// </summary>
        public unsafe bool bIsMilitia
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: bGiveXP
        /// </summary>
        public unsafe bool bGiveXP
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: bPawnHasBeenDead
        /// </summary>
        public unsafe bool bPawnHasBeenDead
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FCachedIdleStances
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FCachedIdleStances
    {
        /// <summary>
        /// ArrayProperty: Stances
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> Stances
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: AnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet AnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FCachedStepAnims
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FCachedStepAnims
    {
        /// <summary>
        /// ArrayProperty: List
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> List
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: LongList
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> LongList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// NameProperty: ForwardName
        /// </summary>
        public unsafe BmSDK.FName ForwardName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ObjectProperty: AnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet AnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FCachedTauntAnims
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FCachedTauntAnims
    {
        /// <summary>
        /// ObjectProperty: AnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet AnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: Anims
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameRI.FTauntAnimInfo> Anims
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameRI.FTauntAnimInfo>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FDifficultyProgressionDefine
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FDifficultyProgressionDefine
    {
        /// <summary>
        /// FloatProperty: MinChapter
        /// </summary>
        public unsafe float MinChapter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MaxChapter
        /// </summary>
        public unsafe float MaxChapter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: EasyValue
        /// </summary>
        public unsafe float EasyValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: HardValue
        /// </summary>
        public unsafe float HardValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: DebugMenuIncrement
        /// </summary>
        public unsafe float DebugMenuIncrement
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bOpenInDebugMenu
        /// </summary>
        public unsafe bool bOpenInDebugMenu
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Enum: EDifficultyType
    /// </summary>
    public enum EDifficultyType : byte
    {
        EDT_DamageUnarmed = 0,
        EDT_DamagePipe = 1,
        EDT_DamageBox = 2,
        EDT_DamageStunStickRepel = 3,
        EDT_DamageStunStickAttack = 4,
        EDT_DamageKnife = 5,
        EDT_DamageCombatGun = 6,
        EDT_DamageNinja = 7,
        EDT_DamageNinjaCombo = 8,
        EDT_EnemyHealth = 9,
        EDT_StrikeDurationScale = 10,
        EDT_BladeDurationScale = 11,
        EDT_TimeBeforeNextStrike = 12,
        EDT_BruteDurationScale = 13,
        EDT_BruteDamageUnarmed = 14,
        EDT_BruteDamageKnives = 15,
        EDT_BruteDamageShield = 16,
        EDT_BruteDamageStunFist = 17,
        EDT_BruteDamageThrowThug = 18,
        EDT_MAX = 19,
    }

    /// <summary>
    /// Struct: FCachedAnimset
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FCachedAnimset
    {
        /// <summary>
        /// ObjectProperty: AnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet AnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: PathName
        /// </summary>
        public unsafe BmSDK.FString PathName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FPairedAnimsetPackageDef
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 140)]
    public partial record struct FPairedAnimsetPackageDef
    {
        /// <summary>
        /// NameProperty: PlayerName
        /// </summary>
        public unsafe BmSDK.FName PlayerName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: PackageName
        /// </summary>
        public unsafe BmSDK.FString PackageName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: VillainAnimsetNames
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> VillainAnimsetNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ArrayProperty: PlayerAnimsetNames
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> PlayerAnimsetNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ArrayProperty: DynamicallyLoadedAnimsets
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDynamicallyLoadedAnimsetDef> DynamicallyLoadedAnimsets
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDynamicallyLoadedAnimsetDef>>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bAssumeAlreadyLoaded
        /// </summary>
        public unsafe bool bAssumeAlreadyLoaded
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bNonOWOnly
        /// </summary>
        public unsafe bool bNonOWOnly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// ArrayProperty: DualPlayTakedownAnims
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> DualPlayTakedownAnims
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// ArrayProperty: BMDualPlayTakedownAnims
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> BMDualPlayTakedownAnims
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// ArrayProperty: DualPlayStrikeAnims
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> DualPlayStrikeAnims
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 108); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }; }
        }

        /// <summary>
        /// ArrayProperty: BMDualPlayStrikeAnims
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> BMDualPlayStrikeAnims
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 124); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }; }
        }
    }

    /// <summary>
    /// Struct: FDynamicallyLoadedAnimsetDef
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 25)]
    public partial record struct FDynamicallyLoadedAnimsetDef
    {
        /// <summary>
        /// NameProperty: PropertyName
        /// </summary>
        public unsafe BmSDK.FName PropertyName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: AnimsetString
        /// </summary>
        public unsafe BmSDK.FString AnimsetString
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: ArrayOp
        /// </summary>
        public unsafe BmSDK.BmGame.RBMCombatManager.EArrayPropertyType ArrayOp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.EArrayPropertyType>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: EArrayPropertyType
    /// </summary>
    public enum EArrayPropertyType : byte
    {
        EAPT_None = 0,
        EAPT_ClearAndAdd = 1,
        EAPT_Add = 2,
        EAPT_Assign = 3,
        EAPT_MAX = 4,
    }

    /// <summary>
    /// Struct: FWeaponConfigRef
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FWeaponConfigRef
    {
        /// <summary>
        /// ObjectProperty: WeaponConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RWeaponConfig WeaponConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: RefCount
        /// </summary>
        public unsafe int RefCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: EWeaponConfigType
    /// </summary>
    public enum EWeaponConfigType : byte
    {
        WEAPONCONFIG_None = 0,
        WEAPONCONFIG_Unarmed = 1,
        WEAPONCONFIG_Knife = 2,
        WEAPONCONFIG_Pipe = 3,
        WEAPONCONFIG_Shield = 4,
        WEAPONCONFIG_StunStick = 5,
        WEAPONCONFIG_HeavyObject = 6,
        WEAPONCONFIG_Ninja = 7,
        WEAPONCONFIG_NinjaSword = 8,
        WEAPONCONFIG_Outcast = 9,
        WEAPONCONFIG_CrowdOutcast = 10,
        WEAPONCONFIG_Hobo = 11,
        WEAPONCONFIG_PredatorUnarmed = 12,
        WEAPONCONFIG_PredatorRifle = 13,
        WEAPONCONFIG_PredatorShotgun = 14,
        WEAPONCONFIG_LitePredatorRifle = 15,
        WEAPONCONFIG_UnarmedTired = 16,
        WEAPONCONFIG_UnarmedKnackered = 17,
        WEAPONCONFIG_UnarmedLumbering = 18,
        WEAPONCONFIG_CombatExpert = 19,
        WEAPONCONFIG_TonfaUnarmed = 20,
        WEAPONCONFIG_RiddlerMechSuit = 21,
        WEAPONCONFIG_JokerBoxer = 22,
        WEAPONCONFIG_MAX = 23,
    }

    /// <summary>
    /// ArrayProperty: CombatPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatPoint> CombatPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatPoint>>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ArrayProperty: CombatAreas
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCombatArea> CombatAreas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCombatArea>>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ArrayProperty: GuardPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCombatArea_GuardPoint> GuardPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCombatArea_GuardPoint>>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ArrayProperty: ThrowTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RThrowTarget> ThrowTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RThrowTarget>>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ArrayProperty: CombatAttractors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCombatAttractor> CombatAttractors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCombatAttractor>>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ArrayProperty: DualplayZones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDualplayZone> DualplayZones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDualplayZone>>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ArrayProperty: CombatEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCombatEvent> CombatEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCombatEvent>>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: CurrTakedownObject
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatPoint_EnvironmentAttackObjectBase CurrTakedownObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatPoint_EnvironmentAttackObjectBase>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: CurrBatmobileTakedownTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain CurrBatmobileTakedownTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: CombatStepper
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat CombatStepper
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_IntegratedChallengeBase ChallengeAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_IntegratedChallengeBase>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: CurrentChargingThug
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain CurrentChargingThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: SpecialCombatEventReceiver
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain SpecialCombatEventReceiver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: BarkGroupContext
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkGroupContext_Combat BarkGroupContext
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkGroupContext_Combat>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: PawnToKeepInView
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat PawnToKeepInView
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: GameRepInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI GameRepInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ObjectProperty: CombatCamera2D
    /// </summary>
    public unsafe BmSDK.BmGame.R2DCombatCamera CombatCamera2D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.R2DCombatCamera>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ObjectProperty: PlayerVIPTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain PlayerVIPTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ObjectProperty: DisableCounterIconSequenceAction
    /// </summary>
    public unsafe BmSDK.Engine.SequenceAction DisableCounterIconSequenceAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SequenceAction>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ObjectProperty: TargetPlayerOverride
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat TargetPlayerOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: AttackerOverride
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain AttackerOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileTakedownHighlight
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstance BatmobileTakedownHighlight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ObjectProperty: RiotCombatWallahStart
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RiotCombatWallahStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ObjectProperty: RiotCombatWallahStop
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RiotCombatWallahStop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ObjectProperty: RiotStartCombatAkEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RiotStartCombatAkEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: RiotCombatWallahParameter
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName RiotCombatWallahParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ObjectProperty: DestroyEnvironmentWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatPoint_EnvironmentWeapon DestroyEnvironmentWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatPoint_EnvironmentWeapon>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ObjectProperty: LastJumpAlly
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain LastJumpAlly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bSuspendBatmobileTakedownTargetSearch
    /// </summary>
    public unsafe bool bSuspendBatmobileTakedownTargetSearch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bHasPotentialBatmobileTakedownTarget
    /// </summary>
    public unsafe bool bHasPotentialBatmobileTakedownTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bKismetIgnoreDDA
    /// </summary>
    public unsafe bool bKismetIgnoreDDA
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bCanAttack
    /// </summary>
    public unsafe bool bCanAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bEnableAllAttacksByDefault
    /// </summary>
    public unsafe bool bEnableAllAttacksByDefault
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableNormalAttack
    /// </summary>
    public unsafe bool bDisableNormalAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableGrabAttack
    /// </summary>
    public unsafe bool bDisableGrabAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableChargeAttack
    /// </summary>
    public unsafe bool bDisableChargeAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableBeatdown
    /// </summary>
    public unsafe bool bDisableBeatdown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bHeavyFloorStrike
    /// </summary>
    public unsafe bool bHeavyFloorStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableAdrenaline
    /// </summary>
    public unsafe bool bDisableAdrenaline
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableNinjaCounter
    /// </summary>
    public unsafe bool bDisableNinjaCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableNinjaDespawn
    /// </summary>
    public unsafe bool bDisableNinjaDespawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableCombatLock
    /// </summary>
    public unsafe bool bDisableCombatLock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableCombatTakedownCheck
    /// </summary>
    public unsafe bool bDisableCombatTakedownCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableCombatExpertFuryAttack
    /// </summary>
    public unsafe bool bDisableCombatExpertFuryAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableMedicChargeUpThug
    /// </summary>
    public unsafe bool bDisableMedicChargeUpThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableMedicRevives
    /// </summary>
    public unsafe bool bDisableMedicRevives
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableBotDialogue
    /// </summary>
    public unsafe bool bDisableBotDialogue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableQuickGadgetPrompts
    /// </summary>
    public unsafe bool bDisableQuickGadgetPrompts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bSeperatedDualplay
    /// </summary>
    public unsafe bool bSeperatedDualplay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bForceFinalSimultaneousAttack
    /// </summary>
    public unsafe bool bForceFinalSimultaneousAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bShowKnifeThugTutorial
    /// </summary>
    public unsafe bool bShowKnifeThugTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bShowShieldThugTutorial
    /// </summary>
    public unsafe bool bShowShieldThugTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bShowArmouredThugTutorial
    /// </summary>
    public unsafe bool bShowArmouredThugTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bShowStunStickThugTutorial
    /// </summary>
    public unsafe bool bShowStunStickThugTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bShowMultiStageTutorial
    /// </summary>
    public unsafe bool bShowMultiStageTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bShowMedicBuffTutorial
    /// </summary>
    public unsafe bool bShowMedicBuffTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bShowWeaponPickupHelp
    /// </summary>
    public unsafe bool bShowWeaponPickupHelp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bExitCombatIfFarFromThugs
    /// </summary>
    public unsafe bool bExitCombatIfFarFromThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisplayDifficultyDebug
    /// </summary>
    public unsafe bool bDisplayDifficultyDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bMoreThanOneCombatantHasBeenActive
    /// </summary>
    public unsafe bool bMoreThanOneCombatantHasBeenActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bPlayerIsTargetted
    /// </summary>
    public unsafe bool bPlayerIsTargetted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bDisableCombatTakedownPoints
    /// </summary>
    public unsafe bool bDisableCombatTakedownPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: ImpactRampIn
    /// </summary>
    public unsafe bool ImpactRampIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: ImpactRampOut
    /// </summary>
    public unsafe bool ImpactRampOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bPlayedSeeCombatBark
    /// </summary>
    public unsafe bool bPlayedSeeCombatBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bKeepInViewLookAtPawnLocation
    /// </summary>
    public unsafe bool bKeepInViewLookAtPawnLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bDisableDDATracking
    /// </summary>
    public unsafe bool bDisableDDATracking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bSuspendCachingNumCombatants
    /// </summary>
    public unsafe bool bSuspendCachingNumCombatants
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bTriedToCacheNumCombatantsWhileSuspended
    /// </summary>
    public unsafe bool bTriedToCacheNumCombatantsWhileSuspended
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bPairedAnimLoadStartedThisFrame
    /// </summary>
    public unsafe bool bPairedAnimLoadStartedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bNinjaDodgedLastStrike
    /// </summary>
    public unsafe bool bNinjaDodgedLastStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bNewGamePlus
    /// </summary>
    public unsafe bool bNewGamePlus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bNoCameraAssistance
    /// </summary>
    public unsafe bool bNoCameraAssistance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bVenomCameraOn
    /// </summary>
    public unsafe bool bVenomCameraOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bStayAwayFromPlayer
    /// </summary>
    public unsafe bool bStayAwayFromPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bDisableBot
    /// </summary>
    public unsafe bool bDisableBot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bBotTargetted
    /// </summary>
    public unsafe bool bBotTargetted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bCombatRiotWallahRunning
    /// </summary>
    public unsafe bool bCombatRiotWallahRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bMultiStageThrowActive
    /// </summary>
    public unsafe bool bMultiStageThrowActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bDualplayLOS
    /// </summary>
    public unsafe bool bDualplayLOS
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bCrocFight
    /// </summary>
    public unsafe bool bCrocFight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// IntProperty: CombatStepperIndex
    /// </summary>
    public unsafe int CombatStepperIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// FloatProperty: LastTauntTime
    /// </summary>
    public unsafe float LastTauntTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// IntProperty: LastTauntID
    /// </summary>
    public unsafe int LastTauntID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// FloatProperty: LastLocationSpecificTakedownTauntTime
    /// </summary>
    public unsafe float LastLocationSpecificTakedownTauntTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ArrayProperty: SuppressFinalBlowObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> SuppressFinalBlowObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// ArrayProperty: SuppressXPObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> SuppressXPObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: TimeUntilNextMaxPawnsUpdate
    /// </summary>
    public unsafe float TimeUntilNextMaxPawnsUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// IntProperty: MaxCombatPawns
    /// </summary>
    public unsafe int MaxCombatPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// FloatProperty: OverrideChapter
    /// </summary>
    public unsafe float OverrideChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ArrayProperty: ActiveDifficultyVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDifficultyOverrideVolume> ActiveDifficultyVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDifficultyOverrideVolume>>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: LastBMSightingTime
    /// </summary>
    public unsafe float LastBMSightingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// StructProperty: LastSightingLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastSightingLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1036);

    /// <summary>
    /// FloatProperty: LastBatmobileSightingTime
    /// </summary>
    public unsafe float LastBatmobileSightingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// StructProperty: LastBatmobileSightingLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastBatmobileSightingLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1052);

    /// <summary>
    /// ArrayProperty: VillainBlockerList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBunkerDoorVillainBlocker> VillainBlockerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBunkerDoorVillainBlocker>>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// ArrayProperty: RetreatFromBatmobilePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCombatRetreatFromBatmobilePoint> RetreatFromBatmobilePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCombatRetreatFromBatmobilePoint>>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// FloatProperty: LastFuryAttackTime
    /// </summary>
    public unsafe float LastFuryAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// FloatProperty: PawnHealthMultiplier
    /// </summary>
    public unsafe float PawnHealthMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// FloatProperty: SimultaneousAttackTimer
    /// </summary>
    public unsafe float SimultaneousAttackTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// FloatProperty: ForceFinalSimultaneousAttackTime
    /// </summary>
    public unsafe float ForceFinalSimultaneousAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ArrayProperty: AllowedSimultaneousTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat.SimultaneousCounterBehaviourType> AllowedSimultaneousTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat.SimultaneousCounterBehaviourType>>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithKnives
    /// </summary>
    public unsafe int NumCombatantsWithKnives
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithShields
    /// </summary>
    public unsafe int NumCombatantsWithShields
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithArmour
    /// </summary>
    public unsafe int NumCombatantsWithArmour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithStunSticks
    /// </summary>
    public unsafe int NumCombatantsWithStunSticks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsMultiStage
    /// </summary>
    public unsafe int NumCombatantsMultiStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// IntProperty: MostDangerousMultiStageWeapon
    /// </summary>
    public unsafe int MostDangerousMultiStageWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithHeavyObjects
    /// </summary>
    public unsafe int NumCombatantsWithHeavyObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithGuns
    /// </summary>
    public unsafe int NumCombatantsWithGuns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsStartedWithGuns
    /// </summary>
    public unsafe int NumCombatantsStartedWithGuns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithWeapons
    /// </summary>
    public unsafe int NumCombatantsWithWeapons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithBats
    /// </summary>
    public unsafe int NumCombatantsWithBats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsMedics
    /// </summary>
    public unsafe int NumCombatantsMedics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsMedicBuffs
    /// </summary>
    public unsafe int NumCombatantsMedicBuffs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// IntProperty: NumRiotersInCombat
    /// </summary>
    public unsafe int NumRiotersInCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// IntProperty: NumRobotsInCombat
    /// </summary>
    public unsafe int NumRobotsInCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// IntProperty: NumMilitiaInCombat
    /// </summary>
    public unsafe int NumMilitiaInCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// FloatProperty: LastCombatRollTime
    /// </summary>
    public unsafe float LastCombatRollTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// ArrayProperty: CombatPylons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Pylon> CombatPylons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Pylon>>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// ArrayProperty: RiotCombatPylons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Pylon> RiotCombatPylons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Pylon>>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// ArrayProperty: CombatantsJoining
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> CombatantsJoining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// FloatProperty: LastExplosivePickedUpTime
    /// </summary>
    public unsafe float LastExplosivePickedUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// FloatProperty: LastThrownObjectPickedUpTime
    /// </summary>
    public unsafe float LastThrownObjectPickedUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// FloatProperty: LastGunDispenserUseTime
    /// </summary>
    public unsafe float LastGunDispenserUseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// FloatProperty: NextThugHelpThugTime
    /// </summary>
    public unsafe float NextThugHelpThugTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// FloatProperty: NextThugPushThugTime
    /// </summary>
    public unsafe float NextThugPushThugTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// FloatProperty: ImpactEmoteChanceCombat
    /// </summary>
    public unsafe float ImpactEmoteChanceCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// FloatProperty: ImpactEmoteChancePredator
    /// </summary>
    public unsafe float ImpactEmoteChancePredator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: WeaponConfigs
    /// </summary>
    public InlineArray<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef> WeaponConfigs => new(23, Ptr + 1272, 12, this);

    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1272);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1284);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1296);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1308);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1320);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1332);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1344);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1356);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1368);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1380);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_10
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1392);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_11
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1404);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_12
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1416);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_13
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1428);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_14
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1440);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_15
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1452);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_16
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1464);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_17
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1476);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_18
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1488);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_19
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1500);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_20
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1512);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_21
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1524);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_22
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1536);

    /// <summary>
    /// ArrayProperty: ThugPlayerPairedAnimsetPackageDefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FPairedAnimsetPackageDef> ThugPlayerPairedAnimsetPackageDefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FPairedAnimsetPackageDef>>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// ArrayProperty: CachedCombatAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCachedAnimset> CachedCombatAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCachedAnimset>>(Ptr + 1564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1564); }
    }

    /// <summary>
    /// ArrayProperty: DifficultyProgressionDefines_Easy
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine> DifficultyProgressionDefines_Easy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine>>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// ArrayProperty: DifficultyProgressionDefines_Normal
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine> DifficultyProgressionDefines_Normal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine>>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// ArrayProperty: DifficultyProgressionDefines_Hard
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine> DifficultyProgressionDefines_Hard
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine>>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// ArrayProperty: MoveTypeScores
    /// </summary>
    public unsafe BmSDK.TArray<int> MoveTypeScores
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1628); }
    }

    /// <summary>
    /// ArrayProperty: CachedTaunts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCachedTauntAnims> CachedTaunts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCachedTauntAnims>>(Ptr + 1644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1644); }
    }

    /// <summary>
    /// ArrayProperty: CachedSteps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCachedStepAnims> CachedSteps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCachedStepAnims>>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }

    /// <summary>
    /// ArrayProperty: CachedIdles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCachedIdleStances> CachedIdles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCachedIdleStances>>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// FloatProperty: LastGrabAttackTime
    /// </summary>
    public unsafe float LastGrabAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// IntProperty: NumCombatants
    /// </summary>
    public unsafe int NumCombatants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }
    }

    /// <summary>
    /// IntProperty: MaxCombatantsThisFight
    /// </summary>
    public unsafe int MaxCombatantsThisFight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// IntProperty: CombatKOsThisFight
    /// </summary>
    public unsafe int CombatKOsThisFight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }
    }

    /// <summary>
    /// FloatProperty: TotalCombatHealth
    /// </summary>
    public unsafe float TotalCombatHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// IntProperty: CurrActiveCombatThugs
    /// </summary>
    public unsafe int CurrActiveCombatThugs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }
    }

    /// <summary>
    /// FloatProperty: ActiveCombatTime
    /// </summary>
    public unsafe float ActiveCombatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// FloatProperty: InActiveCombatTime
    /// </summary>
    public unsafe float InActiveCombatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// FloatProperty: ClosestCombatPawnDistance
    /// </summary>
    public unsafe float ClosestCombatPawnDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1724); }
    }

    /// <summary>
    /// ArrayProperty: UniqueCombatantList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCombatantInfo> UniqueCombatantList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCombatantInfo>>(Ptr + 1728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }
    }

    /// <summary>
    /// ArrayProperty: UniqueWeaponsCrates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatPoint> UniqueWeaponsCrates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatPoint>>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }

    /// <summary>
    /// FloatProperty: ImpactMinSpeed
    /// </summary>
    public unsafe float ImpactMinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// FloatProperty: ImpactPreTime
    /// </summary>
    public unsafe float ImpactPreTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// FloatProperty: ImpactPostTime
    /// </summary>
    public unsafe float ImpactPostTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }
    }

    /// <summary>
    /// FloatProperty: ImpactRampInEnd
    /// </summary>
    public unsafe float ImpactRampInEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1772); }
    }

    /// <summary>
    /// FloatProperty: ImpactRampOutStart
    /// </summary>
    public unsafe float ImpactRampOutStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// FloatProperty: LastPunishingAttackTime
    /// </summary>
    public unsafe float LastPunishingAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// FloatProperty: LastBarkTime
    /// </summary>
    public unsafe float LastBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1784); }
    }

    /// <summary>
    /// FloatProperty: LastJoinCombatBarkTime
    /// </summary>
    public unsafe float LastJoinCombatBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1788); }
    }

    /// <summary>
    /// StructProperty: LastJoinCombatBarkPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastJoinCombatBarkPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1792);

    /// <summary>
    /// IntProperty: FleeBarksRemaining
    /// </summary>
    public unsafe int FleeBarksRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1804); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenBarkMultiplier
    /// </summary>
    public unsafe float TimeBetweenBarkMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// FloatProperty: CanAttackTime
    /// </summary>
    public unsafe float CanAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// FloatProperty: MinCombatFOV
    /// </summary>
    public unsafe float MinCombatFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// IntProperty: MinCombatFOVNum
    /// </summary>
    public unsafe int MinCombatFOVNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// FloatProperty: MaxCombatFOV
    /// </summary>
    public unsafe float MaxCombatFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }
    }

    /// <summary>
    /// IntProperty: MaxCombatFOVNum
    /// </summary>
    public unsafe int MaxCombatFOVNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// IntProperty: OverrideNumCombatants
    /// </summary>
    public unsafe int OverrideNumCombatants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// NameProperty: FinishedCombatName
    /// </summary>
    public unsafe BmSDK.FName FinishedCombatName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }

    /// <summary>
    /// FloatProperty: MaxYawOffsetDeg
    /// </summary>
    public unsafe float MaxYawOffsetDeg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// FloatProperty: PitchOffsetDeg
    /// </summary>
    public unsafe float PitchOffsetDeg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// FloatProperty: PitchUpLimitDeg
    /// </summary>
    public unsafe float PitchUpLimitDeg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// ByteProperty: KeepInViewSpeed
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CameraLookAtSpeed KeepInViewSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtSpeed>(Ptr + 1856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }
    }

    /// <summary>
    /// NameProperty: LastPickupClassName
    /// </summary>
    public unsafe BmSDK.FName LastPickupClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// FloatProperty: PickupBarkTime
    /// </summary>
    public unsafe float PickupBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// FloatProperty: MaxOnscreenCosAngleZ
    /// </summary>
    public unsafe float MaxOnscreenCosAngleZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1872); }
    }

    /// <summary>
    /// FloatProperty: MaxOnscreenCosAngleXY
    /// </summary>
    public unsafe float MaxOnscreenCosAngleXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }

    /// <summary>
    /// IntProperty: ProtectionStatus
    /// </summary>
    public unsafe int ProtectionStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// FloatProperty: LastThrowBrickTime
    /// </summary>
    public unsafe float LastThrowBrickTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// ArrayProperty: TeleportPointList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCombatTeleport> TeleportPointList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCombatTeleport>>(Ptr + 1888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }
    }

    /// <summary>
    /// IntProperty: Counter1
    /// </summary>
    public unsafe int Counter1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }
    }

    /// <summary>
    /// IntProperty: Counter2
    /// </summary>
    public unsafe int Counter2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1908); }
    }

    /// <summary>
    /// IntProperty: Counter3
    /// </summary>
    public unsafe int Counter3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// IntProperty: NumberStrikesAgainstNinjas
    /// </summary>
    public unsafe int NumberStrikesAgainstNinjas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// IntProperty: NumberNinjaDodges
    /// </summary>
    public unsafe int NumberNinjaDodges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// FloatProperty: LastNinjaDodgeTime
    /// </summary>
    public unsafe float LastNinjaDodgeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1924); }
    }

    /// <summary>
    /// IntProperty: NumberNinjaCounters
    /// </summary>
    public unsafe int NumberNinjaCounters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// FloatProperty: FinishedCombatTime
    /// </summary>
    public unsafe float FinishedCombatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// IntProperty: NumCombatantVehicles
    /// </summary>
    public unsafe int NumCombatantVehicles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// IntProperty: MaxSimCounterersOverride
    /// </summary>
    public unsafe int MaxSimCounterersOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsForInterrogation
    /// </summary>
    public unsafe int NumCombatantsForInterrogation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsJoiningForInterrogation
    /// </summary>
    public unsafe int NumCombatantsJoiningForInterrogation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// FloatProperty: LastVillainChargeAttackTime
    /// </summary>
    public unsafe float LastVillainChargeAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// ArrayProperty: DamageProxyCache
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatDamageProxy> DamageProxyCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatDamageProxy>>(Ptr + 1956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1956); }
    }

    /// <summary>
    /// ArrayProperty: ActiveDamageProxyCache
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatDamageProxy> ActiveDamageProxyCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatDamageProxy>>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }

    /// <summary>
    /// FloatProperty: LastThugChargeUpTime
    /// </summary>
    public unsafe float LastThugChargeUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// FloatProperty: LastThugChargeUpAttackTime
    /// </summary>
    public unsafe float LastThugChargeUpAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }
    }

    /// <summary>
    /// FloatProperty: LastMultiStageThrowAttackTime
    /// </summary>
    public unsafe float LastMultiStageThrowAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }

    /// <summary>
    /// FloatProperty: LastJumpOffAllyTime
    /// </summary>
    public unsafe float LastJumpOffAllyTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }
}
