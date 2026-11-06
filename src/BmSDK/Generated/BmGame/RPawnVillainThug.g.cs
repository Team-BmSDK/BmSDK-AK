#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnVillainThug<br/>
/// (size = 6696)
/// (flags = 144703670)
/// </summary>
public partial class RPawnVillainThug : BmSDK.BmGame.RPawnVillainCombat, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnVillainThug", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillainThug.
    /// </summary>
    public static RPawnVillainThug DefaultObject => (RPawnVillainThug)StaticClass().DefaultObject;

    internal RPawnVillainThug() { }

    /// <summary>
    /// Constructs a new RPawnVillainThug
    /// </summary>
    public RPawnVillainThug(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainThug(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetReactAnimSet;
    /// <summary>
    /// Function: GetReactAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetReactAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetReactAnimSet, "BmGame.RPawnVillainThug.GetReactAnimSet");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetReactAnimName;
    /// <summary>
    /// Function: GetReactAnimName
    /// </summary>
    public unsafe override BmSDK.FName GetReactAnimName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetReactAnimName, "BmGame.RPawnVillainThug.GetReactAnimName");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InitialisePlayerSpecificAnimsets;
    /// <summary>
    /// Function: InitialisePlayerSpecificAnimsets
    /// </summary>
    public unsafe override void InitialisePlayerSpecificAnimsets(BmSDK.BmGame.RPawnPlayerCombat NewPlayer, int PlayerIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialisePlayerSpecificAnimsets, "BmGame.RPawnVillainThug.InitialisePlayerSpecificAnimsets");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VoiceControlTo;
    /// <summary>
    /// Function: VoiceControlTo
    /// </summary>
    public unsafe virtual bool VoiceControlTo(System.Numerics.Vector3 NewLocation, BmSDK.Engine.Actor NewActor, BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ThugList, bool bNewUseDestinationTargetMarkerVFX, System.Numerics.Vector3 vNewDestinationTargetMarkerLocation, BmSDK.Engine.ParticleSystem DestinationTargetMarkerTemplate, BmSDK.Engine.ParticleSystem BeamTemplate, BmSDK.Engine.ParticleSystem SelectedEnemyTemplate, System.Numerics.Vector3 vNewImpactedWallNormal, BmSDK.BmGame.RVoiceSynthesiser NewVoiceSynthesiser)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VoiceControlTo, "BmGame.RPawnVillainThug.VoiceControlTo");
        byte* paramsPtr = stackalloc byte[100];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewActor, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugList, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewUseDestinationTargetMarkerVFX, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vNewDestinationTargetMarkerLocation, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestinationTargetMarkerTemplate, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BeamTemplate, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SelectedEnemyTemplate, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vNewImpactedWallNormal, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVoiceSynthesiser, paramsPtr + 88);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 96);
    }

    private static BmSDK.Function __fn_CanBeVoiceControlled;
    /// <summary>
    /// Function: CanBeVoiceControlled
    /// </summary>
    public unsafe virtual bool CanBeVoiceControlled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeVoiceControlled, "BmGame.RPawnVillainThug.CanBeVoiceControlled");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ModifyDamageAmount;
    /// <summary>
    /// Function: ModifyDamageAmount
    /// </summary>
    public unsafe override void ModifyDamageAmount(BmSDK.Class dmgType, out float DmgAmount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyDamageAmount, "BmGame.RPawnVillainThug.ModifyDamageAmount");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DmgAmount);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DmgAmount = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_SetOverrideAnimset;
    /// <summary>
    /// Function: SetOverrideAnimset
    /// </summary>
    public unsafe override void SetOverrideAnimset(BmSDK.BmGame.RBMCombatManager.EWeaponConfigType NewConfigType, BmSDK.Engine.AnimSet NewOverrideAnimset, bool bOverrideHitReactionAnimset)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOverrideAnimset, "BmGame.RPawnVillainThug.SetOverrideAnimset");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewConfigType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOverrideAnimset, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideHitReactionAnimset, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GroupAttackHit;
    /// <summary>
    /// Function: GroupAttackHit
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult GroupAttackHit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GroupAttackHit, "BmGame.RPawnVillainThug.GroupAttackHit");
        byte* paramsPtr = stackalloc byte[261];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSmokeBombReactionClass;
    /// <summary>
    /// Function: GetSmokeBombReactionClass
    /// </summary>
    public unsafe override BmSDK.Class GetSmokeBombReactionClass()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSmokeBombReactionClass, "BmGame.RPawnVillainThug.GetSmokeBombReactionClass");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateWeaponConfigUnarmed;
    /// <summary>
    /// Function: CreateWeaponConfigUnarmed
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateWeaponConfigUnarmed(BmSDK.GameObject NewOwner)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeaponConfigUnarmed, "BmGame.RPawnVillainThug.CreateWeaponConfigUnarmed");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanPlayBark;
    /// <summary>
    /// Function: CanPlayBark
    /// </summary>
    public unsafe override bool CanPlayBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayBark, "BmGame.RPawnVillainThug.CanPlayBark");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NewWeaponAttached;
    /// <summary>
    /// Function: NewWeaponAttached
    /// </summary>
    public unsafe override void NewWeaponAttached(BmSDK.BmGame.RBMWeapon NewWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NewWeaponAttached, "BmGame.RPawnVillainThug.NewWeaponAttached");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCombatMirrored;
    /// <summary>
    /// Function: SetCombatMirrored
    /// </summary>
    public unsafe virtual void SetCombatMirrored()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCombatMirrored, "BmGame.RPawnVillainThug.SetCombatMirrored");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWeaponPickupTransitionName;
    /// <summary>
    /// Function: GetWeaponPickupTransitionName
    /// </summary>
    public unsafe override BmSDK.FName GetWeaponPickupTransitionName(BmSDK.BmGame.RBMWeapon WeaponToPickup, bool bSlidePickup)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponPickupTransitionName, "BmGame.RPawnVillainThug.GetWeaponPickupTransitionName");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponToPickup, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSlidePickup, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SleepInPool;
    /// <summary>
    /// Function: SleepInPool
    /// </summary>
    public unsafe override bool SleepInPool(bool bForce = default, bool bStreamedOut = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SleepInPool, "BmGame.RPawnVillainThug.SleepInPool");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStreamedOut, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsKnackered;
    /// <summary>
    /// Function: IsKnackered
    /// </summary>
    public unsafe override bool IsKnackered()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsKnackered, "BmGame.RPawnVillainThug.IsKnackered");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTirednessState;
    /// <summary>
    /// Function: GetTirednessState
    /// </summary>
    public unsafe override BmSDK.FName GetTirednessState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTirednessState, "BmGame.RPawnVillainThug.GetTirednessState");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DamagedBy;
    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedBy, "BmGame.RPawnVillainThug.DamagedBy");
        byte* paramsPtr = stackalloc byte[250];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 248);
    }

    private static BmSDK.Function __fn_RemoveMultiplayerAura;
    /// <summary>
    /// Function: RemoveMultiplayerAura
    /// </summary>
    public unsafe override void RemoveMultiplayerAura()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveMultiplayerAura, "BmGame.RPawnVillainThug.RemoveMultiplayerAura");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateMultiplayerAura;
    /// <summary>
    /// Function: ActivateMultiplayerAura
    /// </summary>
    public unsafe override void ActivateMultiplayerAura(BmSDK.Engine.MaterialInterface AuraMat, BmSDK.Engine.Scene.ESceneDepthPriorityGroup DPG = default, BmSDK.Engine.MaterialInterface XrayAuraMat = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateMultiplayerAura, "BmGame.RPawnVillainThug.ActivateMultiplayerAura");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuraMat, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DPG, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XrayAuraMat, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetForceBatarangTarget;
    /// <summary>
    /// Function: SetForceBatarangTarget
    /// </summary>
    public unsafe virtual void SetForceBatarangTarget(bool bSetOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetForceBatarangTarget, "BmGame.RPawnVillainThug.SetForceBatarangTarget");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmGame.RPawnVillainThug.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bCanBeKnackered
    /// </summary>
    public unsafe bool bCanBeKnackered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6672) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6672); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6672); }
    }

    /// <summary>
    /// BoolProperty: bForceBatarangTarget
    /// </summary>
    public unsafe bool bForceBatarangTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6672) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6672); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6672); }
    }

    /// <summary>
    /// FloatProperty: DualStrikeRangeTolerance
    /// </summary>
    public unsafe float DualStrikeRangeTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6676); }
    }

    /// <summary>
    /// ComponentProperty: BatarangOverride
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent BatarangOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 6680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6680); }
    }

    /// <summary>
    /// ObjectProperty: SpecialAttackAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet SpecialAttackAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 6688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6688); }
    }
}
