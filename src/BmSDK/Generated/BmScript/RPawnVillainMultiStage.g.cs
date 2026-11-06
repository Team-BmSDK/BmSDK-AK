#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// ABSTRACT Class: RPawnVillainMultiStage<br/>
/// (size = 7000)
/// (flags = 10485815)
/// </summary>
public partial class RPawnVillainMultiStage : BmSDK.BmGame.RPawnVillainMultiStageBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnVillainMultiStage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillainMultiStage.
    /// </summary>
    public static RPawnVillainMultiStage DefaultObject => (RPawnVillainMultiStage)StaticClass().DefaultObject;

    internal RPawnVillainMultiStage() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainMultiStage(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStage>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStage>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStage>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStage>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStage>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStage>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStage>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStage>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetMultiWeaponXrays;
    /// <summary>
    /// Function: SetMultiWeaponXrays
    /// </summary>
    public unsafe override void SetMultiWeaponXrays()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMultiWeaponXrays, "BmScript.RPawnVillainMultiStage.SetMultiWeaponXrays");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetUpXrayMaterials;
    /// <summary>
    /// Function: SetUpXrayMaterials
    /// </summary>
    public unsafe override void SetUpXrayMaterials(bool bPutInForeground)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetUpXrayMaterials, "BmScript.RPawnVillainMultiStage.SetUpXrayMaterials");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPutInForeground, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySound_ImpactAI;
    /// <summary>
    /// Function: PlaySound_ImpactAI
    /// </summary>
    public unsafe override void PlaySound_ImpactAI(BmSDK.Engine.Actor playOn, bool bIsStrike, bool bFinishingBlow, bool bIsHeadImpact, bool bIsPunch, bool bIsStrong, bool bIsBlocked, bool bCanEmote = default, bool bIsQuick = default, bool bPlayerAttacked = default, bool bForceEmote = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound_ImpactAI, "BmScript.RPawnVillainMultiStage.PlaySound_ImpactAI");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(playOn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrike, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinishingBlow, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsHeadImpact, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPunch, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrong, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBlocked, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanEmote, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsQuick, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayerAttacked, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceEmote, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmScript.RPawnVillainMultiStage.Died");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_IsCharging;
    /// <summary>
    /// Function: IsCharging
    /// </summary>
    public unsafe override bool IsCharging()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCharging, "BmScript.RPawnVillainMultiStage.IsCharging");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFallingTakedownAttackerAnimset;
    /// <summary>
    /// Function: GetFallingTakedownAttackerAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetFallingTakedownAttackerAnimset(BmSDK.BmGame.RPawnPlayer Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFallingTakedownAttackerAnimset, "BmScript.RPawnVillainMultiStage.GetFallingTakedownAttackerAnimset");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetFallingTakedownAnimset;
    /// <summary>
    /// Function: GetFallingTakedownAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetFallingTakedownAnimset(BmSDK.BmGame.RPawnPlayer Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFallingTakedownAnimset, "BmScript.RPawnVillainMultiStage.GetFallingTakedownAnimset");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CreateRagdollWeaponConfig;
    /// <summary>
    /// Function: CreateRagdollWeaponConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateRagdollWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2, BmSDK.Engine.AnimSet AnimSet3 = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateRagdollWeaponConfig, "BmScript.RPawnVillainMultiStage.CreateRagdollWeaponConfig");
        byte* paramsPtr = stackalloc byte[476];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet3, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_CreateMultiStageWeaponConfig;
    /// <summary>
    /// Function: CreateMultiStageWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateMultiStageWeaponConfig(BmSDK.GameObject NewOwner)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateMultiStageWeaponConfig, "BmScript.RPawnVillainMultiStage.CreateMultiStageWeaponConfig");
        byte* paramsPtr = stackalloc byte[8152];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CreateWeaponConfigUnarmed;
    /// <summary>
    /// Function: CreateWeaponConfigUnarmed
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateWeaponConfigUnarmed(BmSDK.GameObject NewOwner)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeaponConfigUnarmed, "BmScript.RPawnVillainMultiStage.CreateWeaponConfigUnarmed");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetCombatAimingConfig;
    /// <summary>
    /// Function: GetCombatAimingConfig
    /// </summary>
    public unsafe virtual BmSDK.Engine.RAimingConfig GetCombatAimingConfig()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatAimingConfig, "BmScript.RPawnVillainMultiStage.GetCombatAimingConfig");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAimingConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InitialisePlayerSpecificAnimsets;
    /// <summary>
    /// Function: InitialisePlayerSpecificAnimsets
    /// </summary>
    public unsafe override void InitialisePlayerSpecificAnimsets(BmSDK.BmGame.RPawnPlayerCombat NewPlayer, int PlayerIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialisePlayerSpecificAnimsets, "BmScript.RPawnVillainMultiStage.InitialisePlayerSpecificAnimsets");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnOverrideDualTakedown;
    /// <summary>
    /// Function: SpawnOverrideDualTakedown
    /// </summary>
    public unsafe override bool SpawnOverrideDualTakedown(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnOverrideDualTakedown, "BmScript.RPawnVillainMultiStage.SpawnOverrideDualTakedown");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetBatClawHitReactionClass;
    /// <summary>
    /// Function: GetBatClawHitReactionClass
    /// </summary>
    public unsafe override BmSDK.Class GetBatClawHitReactionClass()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatClawHitReactionClass, "BmScript.RPawnVillainMultiStage.GetBatClawHitReactionClass");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRECHitReactionClass;
    /// <summary>
    /// Function: GetRECHitReactionClass
    /// </summary>
    public unsafe override BmSDK.Class GetRECHitReactionClass()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRECHitReactionClass, "BmScript.RPawnVillainMultiStage.GetRECHitReactionClass");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RagdollOnREC;
    /// <summary>
    /// Function: RagdollOnREC
    /// </summary>
    public unsafe override bool RagdollOnREC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RagdollOnREC, "BmScript.RPawnVillainMultiStage.RagdollOnREC");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBlockDuringHitReaction;
    /// <summary>
    /// Function: CanBlockDuringHitReaction
    /// </summary>
    public unsafe override bool CanBlockDuringHitReaction(BmSDK.BmGame.RPawnCombat.FDamageInfo HitReactionDmgInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBlockDuringHitReaction, "BmScript.RPawnVillainMultiStage.CanBlockDuringHitReaction");
        byte* paramsPtr = stackalloc byte[252];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitReactionDmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 248);
    }

    private static BmSDK.Function __fn_GetBlockInAnimName;
    /// <summary>
    /// Function: GetBlockInAnimName
    /// </summary>
    public unsafe override BmSDK.FName GetBlockInAnimName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBlockInAnimName, "BmScript.RPawnVillainMultiStage.GetBlockInAnimName");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBlockIdleAnimName;
    /// <summary>
    /// Function: GetBlockIdleAnimName
    /// </summary>
    public unsafe override BmSDK.FName GetBlockIdleAnimName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBlockIdleAnimName, "BmScript.RPawnVillainMultiStage.GetBlockIdleAnimName");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAerialAttackAnimName;
    /// <summary>
    /// Function: GetAerialAttackAnimName
    /// </summary>
    public unsafe override BmSDK.FName GetAerialAttackAnimName(bool bFinisher, BmSDK.BmGame.RPawnPlayerCombat Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAerialAttackAnimName, "BmScript.RPawnVillainMultiStage.GetAerialAttackAnimName");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinisher, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetAerialEvadeInToTargetAnimName;
    /// <summary>
    /// Function: GetAerialEvadeInToTargetAnimName
    /// </summary>
    public unsafe override BmSDK.FName GetAerialEvadeInToTargetAnimName(BmSDK.BmGame.RPawnPlayerCombat Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAerialEvadeInToTargetAnimName, "BmScript.RPawnVillainMultiStage.GetAerialEvadeInToTargetAnimName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetAerialJumpOnTargetAnimName;
    /// <summary>
    /// Function: GetAerialJumpOnTargetAnimName
    /// </summary>
    public unsafe override BmSDK.FName GetAerialJumpOnTargetAnimName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAerialJumpOnTargetAnimName, "BmScript.RPawnVillainMultiStage.GetAerialJumpOnTargetAnimName");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStateHitReactionAnimset;
    /// <summary>
    /// Function: GetStateHitReactionAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetStateHitReactionAnimset(BmSDK.BmGame.RPawnVillainMultiStageBase.EThugState NewThugState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStateHitReactionAnimset, "BmScript.RPawnVillainMultiStage.GetStateHitReactionAnimset");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewThugState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetRECHitReactionAnimName;
    /// <summary>
    /// Function: GetRECHitReactionAnimName
    /// </summary>
    public unsafe override BmSDK.FName GetRECHitReactionAnimName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRECHitReactionAnimName, "BmScript.RPawnVillainMultiStage.GetRECHitReactionAnimName");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBeatdownHitReactionName;
    /// <summary>
    /// Function: GetBeatdownHitReactionName
    /// </summary>
    public unsafe override BmSDK.FName GetBeatdownHitReactionName(BmSDK.FName DefaultName, BmSDK.Class StrikeDmgType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBeatdownHitReactionName, "BmScript.RPawnVillainMultiStage.GetBeatdownHitReactionName");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SetBatarangable;
    /// <summary>
    /// Function: SetBatarangable
    /// </summary>
    public unsafe virtual void SetBatarangable(bool bSetOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBatarangable, "BmScript.RPawnVillainMultiStage.SetBatarangable");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetOverrideTakedownInfo;
    /// <summary>
    /// Function: GetOverrideTakedownInfo
    /// </summary>
    public unsafe override bool GetOverrideTakedownInfo(BmSDK.BmGame.RPawnPlayerCombat Attacker, out BmSDK.BmGame.RPawnPlayerCombat.ETakedownType takedownType, out System.Numerics.Vector3 TakedownLocation, out BmSDK.Rotator TakedownRotation, out int DamageAmount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverrideTakedownInfo, "BmScript.RPawnVillainMultiStage.GetOverrideTakedownInfo");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        takedownType = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.ETakedownType>(paramsPtr + 8);
        TakedownLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        TakedownRotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 24);
        DamageAmount = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_WillTakedownKill;
    /// <summary>
    /// Function: WillTakedownKill
    /// </summary>
    public unsafe virtual bool WillTakedownKill(BmSDK.BmGame.RPawnPlayerCombat Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WillTakedownKill, "BmScript.RPawnVillainMultiStage.WillTakedownKill");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ShouldComboTakedownKill;
    /// <summary>
    /// Function: ShouldComboTakedownKill
    /// </summary>
    public unsafe override bool ShouldComboTakedownKill(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldComboTakedownKill, "BmScript.RPawnVillainMultiStage.ShouldComboTakedownKill");
        byte* paramsPtr = stackalloc byte[252];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 248);
    }

    private static BmSDK.Function __fn_GetDeadThugPickupPoint;
    /// <summary>
    /// Function: GetDeadThugPickupPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDeadThugPickupPoint(BmSDK.BmGame.RPawnVillain DeadThug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDeadThugPickupPoint, "BmScript.RPawnVillainMultiStage.GetDeadThugPickupPoint");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeadThug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindThugToThrow;
    /// <summary>
    /// Function: FindThugToThrow
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat FindThugToThrow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindThugToThrow, "BmScript.RPawnVillainMultiStage.FindThugToThrow");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanAerialRedirect;
    /// <summary>
    /// Function: CanAerialRedirect
    /// </summary>
    public unsafe override bool CanAerialRedirect()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanAerialRedirect, "BmScript.RPawnVillainMultiStage.CanAerialRedirect");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBlockAnimset;
    /// <summary>
    /// Function: GetBlockAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetBlockAnimset(BmSDK.BmGame.RPawnVillainMultiStageBase.EThugState BlockState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBlockAnimset, "BmScript.RPawnVillainMultiStage.GetBlockAnimset");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlockState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetUnarmedHitReactionAnimset;
    /// <summary>
    /// Function: GetUnarmedHitReactionAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetUnarmedHitReactionAnimset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnarmedHitReactionAnimset, "BmScript.RPawnVillainMultiStage.GetUnarmedHitReactionAnimset");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetForwardStepName;
    /// <summary>
    /// Function: GetForwardStepName
    /// </summary>
    public unsafe override BmSDK.FName GetForwardStepName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetForwardStepName, "BmScript.RPawnVillainMultiStage.GetForwardStepName");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCombatMovementAnimset;
    /// <summary>
    /// Function: GetCombatMovementAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetCombatMovementAnimset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatMovementAnimset, "BmScript.RPawnVillainMultiStage.GetCombatMovementAnimset");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStepList;
    /// <summary>
    /// Function: GetStepList
    /// </summary>
    public unsafe override BmSDK.TArray<BmSDK.FName> GetStepList(bool bLongStep = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStepList, "BmScript.RPawnVillainMultiStage.GetStepList");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLongStep, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsMilitia;
    /// <summary>
    /// Function: IsMilitia
    /// </summary>
    public unsafe virtual bool IsMilitia()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMilitia, "BmScript.RPawnVillainMultiStage.IsMilitia");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmScript.RPawnVillainMultiStage.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RepelAttack;
    /// <summary>
    /// Function: RepelAttack
    /// </summary>
    public unsafe override void RepelAttack(BmSDK.BmGame.RPawnCombat Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RepelAttack, "BmScript.RPawnVillainMultiStage.RepelAttack");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMultiAttackAnimSets;
    /// <summary>
    /// Function: GetMultiAttackAnimSets
    /// </summary>
    public unsafe override void GetMultiAttackAnimSets(BmSDK.BmGame.RPawnCombat PlayerPawn, out BmSDK.Engine.AnimSet VillainAnimSet, out BmSDK.Engine.AnimSet PlayerAnimset)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMultiAttackAnimSets, "BmScript.RPawnVillainMultiStage.GetMultiAttackAnimSets");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        VillainAnimSet = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 8);
        PlayerAnimset = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_GetMultiAttackAnimNames;
    /// <summary>
    /// Function: GetMultiAttackAnimNames
    /// </summary>
    public unsafe override void GetMultiAttackAnimNames(out BmSDK.FName IntroName, out BmSDK.FName AttackName, out BmSDK.FName FailName, out BmSDK.FName CounterName, BmSDK.BmGame.RPawnPlayerCombat Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMultiAttackAnimNames, "BmScript.RPawnVillainMultiStage.GetMultiAttackAnimNames");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IntroName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
        AttackName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
        FailName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 16);
        CounterName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_EFistHitTarget;
    /// <summary>
    /// Function: EFistHitTarget
    /// </summary>
    public unsafe override void EFistHitTarget(BmSDK.FName DamageBone)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EFistHitTarget, "BmScript.RPawnVillainMultiStage.EFistHitTarget");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageBone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHitReaction;
    /// <summary>
    /// Function: PlayHitReaction
    /// </summary>
    public unsafe override void PlayHitReaction(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHitReaction, "BmScript.RPawnVillainMultiStage.PlayHitReaction");
        byte* paramsPtr = stackalloc byte[248];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanRepelDuringHitReaction;
    /// <summary>
    /// Function: CanRepelDuringHitReaction
    /// </summary>
    public unsafe override bool CanRepelDuringHitReaction(BmSDK.BmGame.RPawnCombat.FDamageInfo NewDmgInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanRepelDuringHitReaction, "BmScript.RPawnVillainMultiStage.CanRepelDuringHitReaction");
        byte* paramsPtr = stackalloc byte[252];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 248);
    }

    private static BmSDK.Function __fn_CanRepelAttack;
    /// <summary>
    /// Function: CanRepelAttack
    /// </summary>
    public unsafe override bool CanRepelAttack(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanRepelAttack, "BmScript.RPawnVillainMultiStage.CanRepelAttack");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CanRepel;
    /// <summary>
    /// Function: CanRepel
    /// </summary>
    public unsafe override bool CanRepel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanRepel, "BmScript.RPawnVillainMultiStage.CanRepel");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStunnedWeaponStance;
    /// <summary>
    /// Function: GetStunnedWeaponStance
    /// </summary>
    public unsafe override BmSDK.FName GetStunnedWeaponStance(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStunnedWeaponStance, "BmScript.RPawnVillainMultiStage.GetStunnedWeaponStance");
        byte* paramsPtr = stackalloc byte[264];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 248);
    }

    private static BmSDK.Function __fn_TargettedBy;
    /// <summary>
    /// Function: TargettedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.TargetStrikeResponse TargettedBy(BmSDK.BmGame.RPawnCombat NewAttacker, BmSDK.Class dmgType, bool bFar = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargettedBy, "BmScript.RPawnVillainMultiStage.TargettedBy");
        byte* paramsPtr = stackalloc byte[22];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFar, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.TargetStrikeResponse>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetPossibleMoves;
    /// <summary>
    /// Function: GetPossibleMoves
    /// </summary>
    public unsafe override void GetPossibleMoves(out BmSDK.TArray<BmSDK.Class> PossibleMoves, BmSDK.BmGame.RPawnVillainMultiStageBase.EThugState CurrThugState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPossibleMoves, "BmScript.RPawnVillainMultiStage.GetPossibleMoves");
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrThugState, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PossibleMoves = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetHudWeaponType;
    /// <summary>
    /// Function: GetHudWeaponType
    /// </summary>
    public unsafe override BmSDK.BmGame.RGameInfo.EHudWeaponType GetHudWeaponType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHudWeaponType, "BmScript.RPawnVillainMultiStage.GetHudWeaponType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EHudWeaponType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetThrowThugAttackClass;
    /// <summary>
    /// Function: GetThrowThugAttackClass
    /// </summary>
    public unsafe override BmSDK.Class GetThrowThugAttackClass()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThrowThugAttackClass, "BmScript.RPawnVillainMultiStage.GetThrowThugAttackClass");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetArmour;
    /// <summary>
    /// Function: SetArmour
    /// </summary>
    public unsafe override void SetArmour(bool bOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetArmour, "BmScript.RPawnVillainMultiStage.SetArmour");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetSpeed;
    /// <summary>
    /// Function: ResetSpeed
    /// </summary>
    public unsafe virtual void ResetSpeed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetSpeed, "BmScript.RPawnVillainMultiStage.ResetSpeed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetInvincibility;
    /// <summary>
    /// Function: ResetInvincibility
    /// </summary>
    public unsafe virtual void ResetInvincibility()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetInvincibility, "BmScript.RPawnVillainMultiStage.ResetInvincibility");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDodgeClass;
    /// <summary>
    /// Function: GetDodgeClass
    /// </summary>
    public unsafe override BmSDK.Class GetDodgeClass()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDodgeClass, "BmScript.RPawnVillainMultiStage.GetDodgeClass");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanTakeSlideAttack;
    /// <summary>
    /// Function: CanTakeSlideAttack
    /// </summary>
    public unsafe override bool CanTakeSlideAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTakeSlideAttack, "BmScript.RPawnVillainMultiStage.CanTakeSlideAttack");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFreezeBlastPriority;
    /// <summary>
    /// Function: GetFreezeBlastPriority
    /// </summary>
    public unsafe override float GetFreezeBlastPriority()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFreezeBlastPriority, "BmScript.RPawnVillainMultiStage.GetFreezeBlastPriority");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatClawPriority;
    /// <summary>
    /// Function: GetBatClawPriority
    /// </summary>
    public unsafe override float GetBatClawPriority()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatClawPriority, "BmScript.RPawnVillainMultiStage.GetBatClawPriority");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTargetPriority;
    /// <summary>
    /// Function: GetTargetPriority
    /// </summary>
    public unsafe override float GetTargetPriority(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetPriority, "BmScript.RPawnVillainMultiStage.GetTargetPriority");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CanBlockAttack;
    /// <summary>
    /// Function: CanBlockAttack
    /// </summary>
    public unsafe override bool CanBlockAttack(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBlockAttack, "BmScript.RPawnVillainMultiStage.CanBlockAttack");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ModifyDamageAmount;
    /// <summary>
    /// Function: ModifyDamageAmount
    /// </summary>
    public unsafe override void ModifyDamageAmount(BmSDK.Class dmgType, out float DmgAmount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyDamageAmount, "BmScript.RPawnVillainMultiStage.ModifyDamageAmount");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DmgAmount = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_WeaponChanged;
    /// <summary>
    /// Function: WeaponChanged
    /// </summary>
    public unsafe override void WeaponChanged(BmSDK.BmGame.RBMWeapon NewWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponChanged, "BmScript.RPawnVillainMultiStage.WeaponChanged");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.RPawnVillainMultiStage.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCombatMirrored;
    /// <summary>
    /// Function: SetCombatMirrored
    /// </summary>
    public unsafe virtual void SetCombatMirrored()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCombatMirrored, "BmScript.RPawnVillainMultiStage.SetCombatMirrored");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TempDisableEFist;
    /// <summary>
    /// Function: TempDisableEFist
    /// </summary>
    public unsafe override void TempDisableEFist()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TempDisableEFist, "BmScript.RPawnVillainMultiStage.TempDisableEFist");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopBladeTrailR;
    /// <summary>
    /// Function: StopBladeTrailR
    /// </summary>
    public unsafe override void StopBladeTrailR()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopBladeTrailR, "BmScript.RPawnVillainMultiStage.StopBladeTrailR");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopBladeTrailL;
    /// <summary>
    /// Function: StopBladeTrailL
    /// </summary>
    public unsafe override void StopBladeTrailL()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopBladeTrailL, "BmScript.RPawnVillainMultiStage.StopBladeTrailL");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartBladeTrailR;
    /// <summary>
    /// Function: StartBladeTrailR
    /// </summary>
    public unsafe virtual void StartBladeTrailR()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartBladeTrailR, "BmScript.RPawnVillainMultiStage.StartBladeTrailR");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartBladeTrailL;
    /// <summary>
    /// Function: StartBladeTrailL
    /// </summary>
    public unsafe virtual void StartBladeTrailL()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartBladeTrailL, "BmScript.RPawnVillainMultiStage.StartBladeTrailL");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopEFistFx;
    /// <summary>
    /// Function: StopEFistFx
    /// </summary>
    public unsafe virtual void StopEFistFx()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopEFistFx, "BmScript.RPawnVillainMultiStage.StopEFistFx");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartEFistFx;
    /// <summary>
    /// Function: StartEFistFx
    /// </summary>
    public unsafe virtual void StartEFistFx()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartEFistFx, "BmScript.RPawnVillainMultiStage.StartEFistFx");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: ArmourMic
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant ArmourMic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6800); }
    }

    /// <summary>
    /// ObjectProperty: ShieldAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ShieldAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 6808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6808); }
    }

    /// <summary>
    /// ObjectProperty: ArmourAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ArmourAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 6816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6816); }
    }

    /// <summary>
    /// ObjectProperty: BladeAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BladeAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 6824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6824); }
    }

    /// <summary>
    /// ObjectProperty: BlockSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BlockSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6832); }
    }

    /// <summary>
    /// ComponentProperty: BladeTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BladeTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6840); }
    }

    /// <summary>
    /// ComponentProperty: BatarangOverride
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent BatarangOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 6848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6848); }
    }

    /// <summary>
    /// FloatProperty: ArmourParam
    /// </summary>
    public unsafe float ArmourParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6856); }
    }

    /// <summary>
    /// FloatProperty: TargetArmourParam
    /// </summary>
    public unsafe float TargetArmourParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6860); }
    }

    /// <summary>
    /// ArrayProperty: ShieldStepList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ShieldStepList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 6864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6864); }
    }

    /// <summary>
    /// NameProperty: ShieldForwardStepName
    /// </summary>
    public unsafe BmSDK.FName ShieldForwardStepName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6880); }
    }

    /// <summary>
    /// ArrayProperty: ArmourStepList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ArmourStepList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 6888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6888); }
    }

    /// <summary>
    /// NameProperty: ArmourForwardStepName
    /// </summary>
    public unsafe BmSDK.FName ArmourForwardStepName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6904); }
    }

    /// <summary>
    /// ArrayProperty: BladeStepList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BladeStepList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 6912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6912); }
    }

    /// <summary>
    /// NameProperty: BladeForwardStepName
    /// </summary>
    public unsafe BmSDK.FName BladeForwardStepName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6928); }
    }

    /// <summary>
    /// NameProperty: ThrowInAnimName
    /// </summary>
    public unsafe BmSDK.FName ThrowInAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6936); }
    }

    /// <summary>
    /// IntProperty: TakedownDamageAmount
    /// </summary>
    public unsafe int TakedownDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6944); }
    }

    /// <summary>
    /// BoolProperty: bCanBeBataranged
    /// </summary>
    public unsafe bool bCanBeBataranged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6948) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6948); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6948); }
    }

    /// <summary>
    /// BoolProperty: bSetHealthMaterial
    /// </summary>
    public unsafe bool bSetHealthMaterial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6948) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6948); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6948); }
    }

    /// <summary>
    /// ArrayProperty: ShieldMaterialIds
    /// </summary>
    public unsafe BmSDK.TArray<int> ShieldMaterialIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 6952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6952); }
    }

    /// <summary>
    /// ArrayProperty: HandMaterialIds
    /// </summary>
    public unsafe BmSDK.TArray<int> HandMaterialIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 6968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6968); }
    }

    /// <summary>
    /// ArrayProperty: BladeMaterialIds
    /// </summary>
    public unsafe BmSDK.TArray<int> BladeMaterialIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 6984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6984); }
    }
}
