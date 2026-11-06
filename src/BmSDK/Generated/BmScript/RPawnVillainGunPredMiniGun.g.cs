#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnVillainGunPredMiniGun<br/>
/// (size = 6832)
/// (flags = 10485814)
/// </summary>
public partial class RPawnVillainGunPredMiniGun : BmSDK.BmGame.RPawnVillainGunPredMiniGunBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnVillainGunPredMiniGun", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillainGunPredMiniGun.
    /// </summary>
    public static RPawnVillainGunPredMiniGun DefaultObject => (RPawnVillainGunPredMiniGun)StaticClass().DefaultObject;

    internal RPawnVillainGunPredMiniGun() { }

    /// <summary>
    /// Constructs a new RPawnVillainGunPredMiniGun
    /// </summary>
    public RPawnVillainGunPredMiniGun(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainGunPredMiniGun(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredMiniGun>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredMiniGun>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredMiniGun>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredMiniGun>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredMiniGun>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredMiniGun>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredMiniGun>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredMiniGun>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PlayAttemptedTakedownDialogueLine;
    /// <summary>
    /// Function: PlayAttemptedTakedownDialogueLine
    /// </summary>
    public unsafe override void PlayAttemptedTakedownDialogueLine(BmSDK.BmGame.RPawnPlayer Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAttemptedTakedownDialogueLine, "BmScript.RPawnVillainGunPredMiniGun.PlayAttemptedTakedownDialogueLine");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBlockBreakerStunTime;
    /// <summary>
    /// Function: GetBlockBreakerStunTime
    /// </summary>
    public unsafe override float GetBlockBreakerStunTime(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBlockBreakerStunTime, "BmScript.RPawnVillainGunPredMiniGun.GetBlockBreakerStunTime");
        byte* paramsPtr = stackalloc byte[268];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 248);
    }

    private static BmSDK.Function __fn_CantSpeakReason;
    /// <summary>
    /// Function: CantSpeakReason
    /// </summary>
    public unsafe override BmSDK.FString CantSpeakReason(BmSDK.Engine.AkDialogueSpeech Speech, BmSDK.Engine.AkDialogue.FAkSpeechOptions dlgOpts = default, bool dlgContinuation = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CantSpeakReason, "BmScript.RPawnVillainGunPredMiniGun.CantSpeakReason");
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speech, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgOpts, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgContinuation, paramsPtr + 124);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 128);
    }

    private static BmSDK.Function __fn_CanSpeak;
    /// <summary>
    /// Function: CanSpeak
    /// </summary>
    public unsafe override bool CanSpeak(BmSDK.Engine.AkDialogueSpeech Speech, BmSDK.Engine.AkDialogue.FAkSpeechOptions dlgOpts = default, bool dlgContinuation = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSpeak, "BmScript.RPawnVillainGunPredMiniGun.CanSpeak");
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speech, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgOpts, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgContinuation, paramsPtr + 124);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 128);
    }

    private static BmSDK.Function __fn_GetFallingTakedownAttackerAnimset;
    /// <summary>
    /// Function: GetFallingTakedownAttackerAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetFallingTakedownAttackerAnimset(BmSDK.BmGame.RPawnPlayer Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFallingTakedownAttackerAnimset, "BmScript.RPawnVillainGunPredMiniGun.GetFallingTakedownAttackerAnimset");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetFallingTakedownAnimset;
    /// <summary>
    /// Function: GetFallingTakedownAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetFallingTakedownAnimset(BmSDK.BmGame.RPawnPlayer Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFallingTakedownAnimset, "BmScript.RPawnVillainGunPredMiniGun.GetFallingTakedownAnimset");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_HitByBatarang;
    /// <summary>
    /// Function: HitByBatarang
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult HitByBatarang(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByBatarang, "BmScript.RPawnVillainGunPredMiniGun.HitByBatarang");
        byte* paramsPtr = stackalloc byte[110];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 84);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 92);
    }

    private static BmSDK.Function __fn_PlayHitReaction;
    /// <summary>
    /// Function: PlayHitReaction
    /// </summary>
    public unsafe override void PlayHitReaction(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHitReaction, "BmScript.RPawnVillainGunPredMiniGun.PlayHitReaction");
        byte* paramsPtr = stackalloc byte[280];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VulnerableToDualTeamTakedown;
    /// <summary>
    /// Function: VulnerableToDualTeamTakedown
    /// </summary>
    public unsafe override bool VulnerableToDualTeamTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VulnerableToDualTeamTakedown, "BmScript.RPawnVillainGunPredMiniGun.VulnerableToDualTeamTakedown");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnSpecialAttack;
    /// <summary>
    /// Function: SpawnSpecialAttack
    /// </summary>
    public unsafe override bool SpawnSpecialAttack(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSpecialAttack, "BmScript.RPawnVillainGunPredMiniGun.SpawnSpecialAttack");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_DoGrenadeVentThrow;
    /// <summary>
    /// Function: DoGrenadeVentThrow
    /// </summary>
    public unsafe override bool DoGrenadeVentThrow(System.Numerics.Vector3 ThrowVel, BmSDK.Rotator SpawnRot, System.Numerics.Vector3 TargetLoc, out BmSDK.BmGame.RProjectile_GrenadeBase NadeProj)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoGrenadeVentThrow, "BmScript.RPawnVillainGunPredMiniGun.DoGrenadeVentThrow");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowVel, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLoc, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NadeProj);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NadeProj, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NadeProj = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RProjectile_GrenadeBase>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_SpawnVantageMine;
    /// <summary>
    /// Function: SpawnVantageMine
    /// </summary>
    public unsafe override BmSDK.BmGame.RVantageMineBase SpawnVantageMine()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnVantageMine, "BmScript.RPawnVillainGunPredMiniGun.SpawnVantageMine");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RVantageMineBase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetHealth;
    /// <summary>
    /// Function: SetHealth
    /// </summary>
    public unsafe override void SetHealth()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealth, "BmScript.RPawnVillainGunPredMiniGun.SetHealth");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNonFatalTakedownDamage;
    /// <summary>
    /// Function: GetNonFatalTakedownDamage
    /// </summary>
    public unsafe override float GetNonFatalTakedownDamage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNonFatalTakedownDamage, "BmScript.RPawnVillainGunPredMiniGun.GetNonFatalTakedownDamage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetVoiceSynthAnimSet;
    /// <summary>
    /// Function: GetVoiceSynthAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetVoiceSynthAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVoiceSynthAnimSet, "BmScript.RPawnVillainGunPredMiniGun.GetVoiceSynthAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetVaultExplosivesAnimSet;
    /// <summary>
    /// Function: GetVaultExplosivesAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetVaultExplosivesAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVaultExplosivesAnimSet, "BmScript.RPawnVillainGunPredMiniGun.GetVaultExplosivesAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCorePredAnimSet;
    /// <summary>
    /// Function: GetCorePredAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetCorePredAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCorePredAnimSet, "BmScript.RPawnVillainGunPredMiniGun.GetCorePredAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetManDownAnimSet;
    /// <summary>
    /// Function: GetManDownAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetManDownAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetManDownAnimSet, "BmScript.RPawnVillainGunPredMiniGun.GetManDownAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGrateLookAnimSet;
    /// <summary>
    /// Function: GetGrateLookAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetGrateLookAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGrateLookAnimSet, "BmScript.RPawnVillainGunPredMiniGun.GetGrateLookAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLedgeLookAnimSet;
    /// <summary>
    /// Function: GetLedgeLookAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetLedgeLookAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLedgeLookAnimSet, "BmScript.RPawnVillainGunPredMiniGun.GetLedgeLookAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBuddyBumpAnimset;
    /// <summary>
    /// Function: GetBuddyBumpAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetBuddyBumpAnimset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBuddyBumpAnimset, "BmScript.RPawnVillainGunPredMiniGun.GetBuddyBumpAnimset");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBuddyJoinAnimset;
    /// <summary>
    /// Function: GetBuddyJoinAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetBuddyJoinAnimset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBuddyJoinAnimset, "BmScript.RPawnVillainGunPredMiniGun.GetBuddyJoinAnimset");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSideRoomSearchAnimSet;
    /// <summary>
    /// Function: GetSideRoomSearchAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetSideRoomSearchAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSideRoomSearchAnimSet, "BmScript.RPawnVillainGunPredMiniGun.GetSideRoomSearchAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPairedCornerAnimSet;
    /// <summary>
    /// Function: GetPairedCornerAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetPairedCornerAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPairedCornerAnimSet, "BmScript.RPawnVillainGunPredMiniGun.GetPairedCornerAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSoloCornerAnimSet;
    /// <summary>
    /// Function: GetSoloCornerAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetSoloCornerAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSoloCornerAnimSet, "BmScript.RPawnVillainGunPredMiniGun.GetSoloCornerAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateLadderWeaponConfig;
    /// <summary>
    /// Function: CreateLadderWeaponConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateLadderWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2 = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateLadderWeaponConfig, "BmScript.RPawnVillainGunPredMiniGun.CreateLadderWeaponConfig");
        byte* paramsPtr = stackalloc byte[3424];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CreateWeapon;
    /// <summary>
    /// Function: CreateWeapon
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMWeapon CreateWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeapon, "BmScript.RPawnVillainGunPredMiniGun.CreateWeapon");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMWeapon>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InitialisePlayerSpecificAnimsets;
    /// <summary>
    /// Function: InitialisePlayerSpecificAnimsets
    /// </summary>
    public unsafe override void InitialisePlayerSpecificAnimsets(BmSDK.BmGame.RPawnPlayerCombat NewPlayer, int PlayerIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialisePlayerSpecificAnimsets, "BmScript.RPawnVillainGunPredMiniGun.InitialisePlayerSpecificAnimsets");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanEverDoBagCarrier;
    /// <summary>
    /// Function: CanEverDoBagCarrier
    /// </summary>
    public unsafe override bool CanEverDoBagCarrier()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanEverDoBagCarrier, "BmScript.RPawnVillainGunPredMiniGun.CanEverDoBagCarrier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMedicAnimSet;
    /// <summary>
    /// Function: GetMedicAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetMedicAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMedicAnimSet, "BmScript.RPawnVillainGunPredMiniGun.GetMedicAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TickGunFire;
    /// <summary>
    /// Function: TickGunFire
    /// </summary>
    public unsafe override void TickGunFire(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickGunFire, "BmScript.RPawnVillainGunPredMiniGun.TickGunFire");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPawnProps;
    /// <summary>
    /// Function: AddPawnProps
    /// </summary>
    public unsafe override void AddPawnProps()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPawnProps, "BmScript.RPawnVillainGunPredMiniGun.AddPawnProps");
        byte* paramsPtr = stackalloc byte[200];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
