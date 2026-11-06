#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_Attack<br/>
/// (size = 848)
/// (flags = 10485778)
/// </summary>
public partial class RAEC_Attack : BmSDK.BmGame.RAEC_Attack_Base, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Attack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_Attack.
    /// </summary>
    public static RAEC_Attack DefaultObject => (RAEC_Attack)StaticClass().DefaultObject;

    internal RAEC_Attack() { }

    /// <summary>
    /// Constructs a new RAEC_Attack
    /// </summary>
    public RAEC_Attack(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Attack(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PlayExclaim;
    /// <summary>
    /// Function: PlayExclaim
    /// </summary>
    public unsafe virtual void PlayExclaim(System.Numerics.Vector3 EventCentre)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayExclaim, "BmGame.RAEC_Attack.PlayExclaim");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventCentre, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerDead;
    /// <summary>
    /// Function: PlayerDead
    /// </summary>
    public unsafe override void PlayerDead()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerDead, "BmGame.RAEC_Attack.PlayerDead");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceAllAttackersOutOfAttack;
    /// <summary>
    /// Function: ForceAllAttackersOutOfAttack
    /// </summary>
    public unsafe virtual void ForceAllAttackersOutOfAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceAllAttackersOutOfAttack, "BmGame.RAEC_Attack.ForceAllAttackersOutOfAttack");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmanSpecialEscape;
    /// <summary>
    /// Function: BatmanSpecialEscape
    /// </summary>
    public unsafe override void BatmanSpecialEscape(BmSDK.BmGame.RAEC_Attack_Base.SpecialEscapeType EscapeType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmanSpecialEscape, "BmGame.RAEC_Attack.BatmanSpecialEscape");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EscapeType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpecialEscapeBark;
    /// <summary>
    /// Function: SpecialEscapeBark
    /// </summary>
    public unsafe virtual void SpecialEscapeBark(BmSDK.BmGame.RAEC_Attack_Base.SpecialEscapeType EscapeType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialEscapeBark, "BmGame.RAEC_Attack.SpecialEscapeBark");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EscapeType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnregisterSniperAEC;
    /// <summary>
    /// Function: UnregisterSniperAEC
    /// </summary>
    public unsafe virtual void UnregisterSniperAEC(BmSDK.BmGame.RAEC_Search_Sub_Sniper ExSniperAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterSniperAEC, "BmGame.RAEC_Attack.UnregisterSniperAEC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExSniperAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterSniperAEC;
    /// <summary>
    /// Function: RegisterSniperAEC
    /// </summary>
    public unsafe virtual void RegisterSniperAEC(BmSDK.BmGame.RAEC_Search_Sub_Sniper NewSniperAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterSniperAEC, "BmGame.RAEC_Attack.RegisterSniperAEC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSniperAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasActiveGuardPerim;
    /// <summary>
    /// Function: HasActiveGuardPerim
    /// </summary>
    public unsafe virtual bool HasActiveGuardPerim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasActiveGuardPerim, "BmGame.RAEC_Attack.HasActiveGuardPerim");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasThugTryingToFire;
    /// <summary>
    /// Function: HasThugTryingToFire
    /// </summary>
    public unsafe virtual bool HasThugTryingToFire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasThugTryingToFire, "BmGame.RAEC_Attack.HasThugTryingToFire");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ThugsAttacking;
    /// <summary>
    /// Function: ThugsAttacking
    /// </summary>
    public unsafe virtual bool ThugsAttacking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugsAttacking, "BmGame.RAEC_Attack.ThugsAttacking");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AreAttackersActive;
    /// <summary>
    /// Function: AreAttackersActive
    /// </summary>
    public unsafe override BmSDK.BmGame.RGameRI.EPredAttackState AreAttackersActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreAttackersActive, "BmGame.RAEC_Attack.AreAttackersActive");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameRI.EPredAttackState>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AttackEventFinished;
    /// <summary>
    /// Function: AttackEventFinished
    /// </summary>
    public unsafe virtual void AttackEventFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttackEventFinished, "BmGame.RAEC_Attack.AttackEventFinished");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelChase;
    /// <summary>
    /// Function: CancelChase
    /// </summary>
    public unsafe virtual void CancelChase()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelChase, "BmGame.RAEC_Attack.CancelChase");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanUseGrenadeGrate;
    /// <summary>
    /// Function: CanUseGrenadeGrate
    /// </summary>
    public unsafe virtual bool CanUseGrenadeGrate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseGrenadeGrate, "BmGame.RAEC_Attack.CanUseGrenadeGrate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PrepChase;
    /// <summary>
    /// Function: PrepChase
    /// </summary>
    public unsafe override void PrepChase()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepChase, "BmGame.RAEC_Attack.PrepChase");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerSeenSinceFreeFireStart;
    /// <summary>
    /// Function: PlayerSeenSinceFreeFireStart
    /// </summary>
    public unsafe virtual bool PlayerSeenSinceFreeFireStart()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerSeenSinceFreeFireStart, "BmGame.RAEC_Attack.PlayerSeenSinceFreeFireStart");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HandlePossibleGrateGrenade;
    /// <summary>
    /// Function: HandlePossibleGrateGrenade
    /// </summary>
    public unsafe virtual void HandlePossibleGrateGrenade()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandlePossibleGrateGrenade, "BmGame.RAEC_Attack.HandlePossibleGrateGrenade");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitFreeFire;
    /// <summary>
    /// Function: InitFreeFire
    /// </summary>
    public unsafe override void InitFreeFire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitFreeFire, "BmGame.RAEC_Attack.InitFreeFire");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryInstantEscalate;
    /// <summary>
    /// Function: TryInstantEscalate
    /// </summary>
    public unsafe virtual void TryInstantEscalate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryInstantEscalate, "BmGame.RAEC_Attack.TryInstantEscalate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNearestThugToPosition;
    /// <summary>
    /// Function: GetNearestThugToPosition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMPawnAI GetNearestThugToPosition(System.Numerics.Vector3 TestPos, bool bIgnoreMinigunners = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNearestThugToPosition, "BmGame.RAEC_Attack.GetNearestThugToPosition");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreMinigunners, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMPawnAI>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetNearestGrateToPosition;
    /// <summary>
    /// Function: GetNearestGrateToPosition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RTunnelGrateBase GetNearestGrateToPosition(System.Numerics.Vector3 TestPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNearestGrateToPosition, "BmGame.RAEC_Attack.GetNearestGrateToPosition");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RTunnelGrateBase>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SpecialBarkAvailable;
    /// <summary>
    /// Function: SpecialBarkAvailable
    /// </summary>
    public unsafe virtual void SpecialBarkAvailable(BmSDK.FName SpecialBarkEventValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialBarkAvailable, "BmGame.RAEC_Attack.SpecialBarkAvailable");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialBarkEventValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddGuardPerimWatcherWithPosition;
    /// <summary>
    /// Function: AddGuardPerimWatcherWithPosition
    /// </summary>
    public unsafe virtual void AddGuardPerimWatcherWithPosition(BmSDK.BmGame.RBMAIController NewWatcher, System.Numerics.Vector3 StandPos, System.Numerics.Vector3 AimPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGuardPerimWatcherWithPosition, "BmGame.RAEC_Attack.AddGuardPerimWatcherWithPosition");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWatcher, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StandPos, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimPos, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddGuardPerimWatcherWithPathPos;
    /// <summary>
    /// Function: AddGuardPerimWatcherWithPathPos
    /// </summary>
    public unsafe virtual void AddGuardPerimWatcherWithPathPos(BmSDK.BmGame.RBMAIController NewWatcher, System.Numerics.Vector3 pathPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGuardPerimWatcherWithPathPos, "BmGame.RAEC_Attack.AddGuardPerimWatcherWithPathPos");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWatcher, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pathPos, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleNoisyGadget;
    /// <summary>
    /// Function: HandleNoisyGadget
    /// </summary>
    public unsafe override void HandleNoisyGadget(System.Numerics.Vector3 ThrownFromPos, float ReactRange)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleNoisyGadget, "BmGame.RAEC_Attack.HandleNoisyGadget");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReactRange, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleGadgetImpactNoise;
    /// <summary>
    /// Function: HandleGadgetImpactNoise
    /// </summary>
    public unsafe override bool HandleGadgetImpactNoise(System.Numerics.Vector3 HitLoc, System.Numerics.Vector3 ThrownFromPos, float ReactRange)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleGadgetImpactNoise, "BmGame.RAEC_Attack.HandleGadgetImpactNoise");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReactRange, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ThugEscapedTakedown;
    /// <summary>
    /// Function: ThugEscapedTakedown
    /// </summary>
    public unsafe override void ThugEscapedTakedown(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugEscapedTakedown, "BmGame.RAEC_Attack.ThugEscapedTakedown");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugIsInterruptingFearTakedown;
    /// <summary>
    /// Function: ThugIsInterruptingFearTakedown
    /// </summary>
    public unsafe override void ThugIsInterruptingFearTakedown(BmSDK.BmGame.RBMAIController NewMember, float PoseChangeDeadline)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugIsInterruptingFearTakedown, "BmGame.RAEC_Attack.ThugIsInterruptingFearTakedown");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoseChangeDeadline, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PropagateWhitelistToNearbyThugs;
    /// <summary>
    /// Function: PropagateWhitelistToNearbyThugs
    /// </summary>
    public unsafe virtual void PropagateWhitelistToNearbyThugs(BmSDK.BmGame.RPawnVillain AlertedVillain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PropagateWhitelistToNearbyThugs, "BmGame.RAEC_Attack.PropagateWhitelistToNearbyThugs");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlertedVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitDistStartle;
    /// <summary>
    /// Function: InitDistStartle
    /// </summary>
    public unsafe virtual void InitDistStartle(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitDistStartle, "BmGame.RAEC_Attack.InitDistStartle");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddAttacker;
    /// <summary>
    /// Function: AddAttacker
    /// </summary>
    public unsafe override void AddAttacker(BmSDK.BmGame.RBMAIController NewMember, bool bPlaySpottedLine = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddAttacker, "BmGame.RAEC_Attack.AddAttacker");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlaySpottedLine, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugSawPlayer;
    /// <summary>
    /// Function: ThugSawPlayer
    /// </summary>
    public unsafe override void ThugSawPlayer(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugSawPlayer, "BmGame.RAEC_Attack.ThugSawPlayer");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasActiveSurprisedThugs;
    /// <summary>
    /// Function: HasActiveSurprisedThugs
    /// </summary>
    public unsafe override bool HasActiveSurprisedThugs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasActiveSurprisedThugs, "BmGame.RAEC_Attack.HasActiveSurprisedThugs");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateHarleyMayhemModeChild;
    /// <summary>
    /// Function: CreateHarleyMayhemModeChild
    /// </summary>
    public unsafe virtual void CreateHarleyMayhemModeChild()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateHarleyMayhemModeChild, "BmGame.RAEC_Attack.CreateHarleyMayhemModeChild");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceNearbyAttackLook;
    /// <summary>
    /// Function: ForceNearbyAttackLook
    /// </summary>
    public unsafe override void ForceNearbyAttackLook()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceNearbyAttackLook, "BmGame.RAEC_Attack.ForceNearbyAttackLook");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySpottedBark;
    /// <summary>
    /// Function: PlaySpottedBark
    /// </summary>
    public unsafe virtual void PlaySpottedBark(BmSDK.BmGame.RPawnVillain SpotterThug, bool bInitialAttackStarted, bool bInitialChasing, bool bInitialChasingFromSighting)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySpottedBark, "BmGame.RAEC_Attack.PlaySpottedBark");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpotterThug, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInitialAttackStarted, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInitialChasing, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInitialChasingFromSighting, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayRespondToNoiseBarks;
    /// <summary>
    /// Function: PlayRespondToNoiseBarks
    /// </summary>
    public unsafe virtual void PlayRespondToNoiseBarks(BmSDK.BmGame.RAEC_Attack_Base.AttackStartTrigger StartCause)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayRespondToNoiseBarks, "BmGame.RAEC_Attack.PlayRespondToNoiseBarks");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartCause, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInterruptingFearTakedown;
    /// <summary>
    /// Function: IsInterruptingFearTakedown
    /// </summary>
    public unsafe virtual bool IsInterruptingFearTakedown(BmSDK.BmGame.RBMAIController TestCon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInterruptingFearTakedown, "BmGame.RAEC_Attack.IsInterruptingFearTakedown");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestCon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FearTakedownStartle;
    /// <summary>
    /// Function: FearTakedownStartle
    /// </summary>
    public unsafe virtual void FearTakedownStartle(BmSDK.BmGame.RPawnVillain Screamer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FearTakedownStartle, "BmGame.RAEC_Attack.FearTakedownStartle");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Screamer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InternalStartAttack;
    /// <summary>
    /// Function: InternalStartAttack
    /// </summary>
    public unsafe override void InternalStartAttack(bool bForceRestart = default, BmSDK.BmGame.RAEC_Attack_Base.AttackStartTrigger StartCause = default, BmSDK.BmGame.RPawnVillain TriggeringVillain = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InternalStartAttack, "BmGame.RAEC_Attack.InternalStartAttack");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceRestart, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartCause, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TriggeringVillain, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpecialCaseThugStartedAttack;
    /// <summary>
    /// Function: SpecialCaseThugStartedAttack
    /// </summary>
    public unsafe override void SpecialCaseThugStartedAttack(BmSDK.BmGame.RBMAIController SpotterCon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialCaseThugStartedAttack, "BmGame.RAEC_Attack.SpecialCaseThugStartedAttack");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpotterCon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRemoveGroupChild;
    /// <summary>
    /// Function: OnRemoveGroupChild
    /// </summary>
    public unsafe override void OnRemoveGroupChild(BmSDK.BmGame.RAlertEventCoordinatorBase RemAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRemoveGroupChild, "BmGame.RAEC_Attack.OnRemoveGroupChild");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TargetPlayerUpdated;
    /// <summary>
    /// Function: TargetPlayerUpdated
    /// </summary>
    public unsafe override void TargetPlayerUpdated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargetPlayerUpdated, "BmGame.RAEC_Attack.TargetPlayerUpdated");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateChildren;
    /// <summary>
    /// Function: CreateChildren
    /// </summary>
    public unsafe override void CreateChildren()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateChildren, "BmGame.RAEC_Attack.CreateChildren");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RAEC_Attack.Tick");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: PrimaryAttackChild
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_Converge PrimaryAttackChild
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_Converge>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: ChaseChild
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_Chase ChaseChild
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_Chase>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: GargChild
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_CheckGarg GargChild
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_CheckGarg>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: DistStartleChild
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_Startle DistStartleChild
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_Startle>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: FearStartleChild
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_Startle FearStartleChild
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_Startle>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: MayhemModeChild
    /// </summary>
    public unsafe BmSDK.BmGame.MAEC_MayhemMode MayhemModeChild
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MAEC_MayhemMode>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bSpottedThisConverge
    /// </summary>
    public unsafe bool bSpottedThisConverge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: bQueueSpottedBark
    /// </summary>
    public unsafe bool bQueueSpottedBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: bDoGrateGrenadeEvenIfNoAttackersFound
    /// </summary>
    public unsafe bool bDoGrateGrenadeEvenIfNoAttackersFound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredByTakedown
    /// </summary>
    public unsafe bool bTriggeredByTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// ArrayProperty: ActiveSnipers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_Search_Sub_Sniper> ActiveSnipers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_Search_Sub_Sniper>>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// FloatProperty: LastAttackChatterBarkTime
    /// </summary>
    public unsafe float LastAttackChatterBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// FloatProperty: AttackChatterLockTime
    /// </summary>
    public unsafe float AttackChatterLockTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// StructProperty: PrevChaseStartLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PrevChaseStartLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 824);

    /// <summary>
    /// FloatProperty: LostBMIncendiary_Interval
    /// </summary>
    public unsafe float LostBMIncendiary_Interval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// FloatProperty: LostBMIndendiary_LastTriggerTime
    /// </summary>
    public unsafe float LostBMIndendiary_LastTriggerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// FloatProperty: LastAttackFinishedTime
    /// </summary>
    public unsafe float LastAttackFinishedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }
}
