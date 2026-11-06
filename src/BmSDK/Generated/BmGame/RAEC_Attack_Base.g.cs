#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RAEC_Attack_Base<br/>
/// (size = 748)
/// (flags = 10485779)
/// </summary>
public partial class RAEC_Attack_Base : BmSDK.BmGame.RAlertEventCoordinatorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Attack_Base", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_Attack_Base.
    /// </summary>
    public static RAEC_Attack_Base DefaultObject => (RAEC_Attack_Base)StaticClass().DefaultObject;

    internal RAEC_Attack_Base() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Attack_Base(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Base>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Base>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Base>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Base>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Base>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Base>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Base>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Base>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_FindOverLookFences;
    /// <summary>
    /// Function: FindOverLookFences
    /// </summary>
    public unsafe virtual void FindOverLookFences(System.Numerics.Vector3 EstimatedPlayerPos, out BmSDK.TArray<BmSDK.BmGame.RBMPathNode_FenceJumpProxy> OverLookFence, out BmSDK.TArray<System.Numerics.Vector3> OverLookFencePos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindOverLookFences, "BmGame.RAEC_Attack_Base.FindOverLookFences");
        byte* paramsPtr = stackalloc byte[124];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EstimatedPlayerPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OverLookFence = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPathNode_FenceJumpProxy>>(paramsPtr + 12);
        OverLookFencePos = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 28);
        return;
    }

    private static BmSDK.Function __fn_PlayerDead;
    /// <summary>
    /// Function: PlayerDead
    /// </summary>
    public unsafe virtual void PlayerDead()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerDead, "BmGame.RAEC_Attack_Base.PlayerDead");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmanSpecialEscape;
    /// <summary>
    /// Function: BatmanSpecialEscape
    /// </summary>
    public unsafe virtual void BatmanSpecialEscape(BmSDK.BmGame.RAEC_Attack_Base.SpecialEscapeType EscapeType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmanSpecialEscape, "BmGame.RAEC_Attack_Base.BatmanSpecialEscape");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EscapeType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerHasSpecialEscaped;
    /// <summary>
    /// Function: PlayerHasSpecialEscaped
    /// </summary>
    public unsafe virtual bool PlayerHasSpecialEscaped()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerHasSpecialEscaped, "BmGame.RAEC_Attack_Base.PlayerHasSpecialEscaped");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ThugEscapedTakedown;
    /// <summary>
    /// Function: ThugEscapedTakedown
    /// </summary>
    public unsafe virtual void ThugEscapedTakedown(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugEscapedTakedown, "BmGame.RAEC_Attack_Base.ThugEscapedTakedown");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleNoisyGadget;
    /// <summary>
    /// Function: HandleNoisyGadget
    /// </summary>
    public unsafe virtual void HandleNoisyGadget(System.Numerics.Vector3 ThrownFromPos, float ReactRange)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleNoisyGadget, "BmGame.RAEC_Attack_Base.HandleNoisyGadget");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReactRange, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleGadgetImpactNoise;
    /// <summary>
    /// Function: HandleGadgetImpactNoise
    /// </summary>
    public unsafe virtual bool HandleGadgetImpactNoise(System.Numerics.Vector3 HitLoc, System.Numerics.Vector3 ThrownFromPos, float ReactRange)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleGadgetImpactNoise, "BmGame.RAEC_Attack_Base.HandleGadgetImpactNoise");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReactRange, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ClearPlayerSeenInGuardVolumes;
    /// <summary>
    /// Function: ClearPlayerSeenInGuardVolumes
    /// </summary>
    public unsafe virtual void ClearPlayerSeenInGuardVolumes()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPlayerSeenInGuardVolumes, "BmGame.RAEC_Attack_Base.ClearPlayerSeenInGuardVolumes");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrepChase;
    /// <summary>
    /// Function: PrepChase
    /// </summary>
    public unsafe virtual void PrepChase()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepChase, "BmGame.RAEC_Attack_Base.PrepChase");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitSurpriseWindow;
    /// <summary>
    /// Function: InitSurpriseWindow
    /// </summary>
    public unsafe virtual void InitSurpriseWindow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitSurpriseWindow, "BmGame.RAEC_Attack_Base.InitSurpriseWindow");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitFreeFire;
    /// <summary>
    /// Function: InitFreeFire
    /// </summary>
    public unsafe virtual void InitFreeFire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitFreeFire, "BmGame.RAEC_Attack_Base.InitFreeFire");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpottedSloMoStarted;
    /// <summary>
    /// Function: SpottedSloMoStarted
    /// </summary>
    public unsafe virtual void SpottedSloMoStarted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpottedSloMoStarted, "BmGame.RAEC_Attack_Base.SpottedSloMoStarted");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasActiveSurprisedThugs;
    /// <summary>
    /// Function: HasActiveSurprisedThugs
    /// </summary>
    public unsafe virtual bool HasActiveSurprisedThugs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasActiveSurprisedThugs, "BmGame.RAEC_Attack_Base.HasActiveSurprisedThugs");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ThugIsInterruptingFearTakedown;
    /// <summary>
    /// Function: ThugIsInterruptingFearTakedown
    /// </summary>
    public unsafe virtual void ThugIsInterruptingFearTakedown(BmSDK.BmGame.RBMAIController NewMember, float PoseChangeDeadline)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugIsInterruptingFearTakedown, "BmGame.RAEC_Attack_Base.ThugIsInterruptingFearTakedown");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoseChangeDeadline, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddAttacker;
    /// <summary>
    /// Function: AddAttacker
    /// </summary>
    public unsafe virtual void AddAttacker(BmSDK.BmGame.RBMAIController NewMember, bool bPlaySpottedLine = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddAttacker, "BmGame.RAEC_Attack_Base.AddAttacker");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlaySpottedLine, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AlertAndAddAttacker;
    /// <summary>
    /// Function: AlertAndAddAttacker
    /// </summary>
    public unsafe virtual void AlertAndAddAttacker(BmSDK.BmGame.RBMAIController NewMember, bool bPlaySpottedLine = default, BmSDK.BmGame.RAEC_Attack_Base.PredAttackEscalationType EscType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertAndAddAttacker, "BmGame.RAEC_Attack_Base.AlertAndAddAttacker");
        byte* paramsPtr = stackalloc byte[13];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlaySpottedLine, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EscType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugSawPlayer;
    /// <summary>
    /// Function: ThugSawPlayer
    /// </summary>
    public unsafe virtual void ThugSawPlayer(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugSawPlayer, "BmGame.RAEC_Attack_Base.ThugSawPlayer");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceNearbyAttackLook;
    /// <summary>
    /// Function: ForceNearbyAttackLook
    /// </summary>
    public unsafe virtual void ForceNearbyAttackLook()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceNearbyAttackLook, "BmGame.RAEC_Attack_Base.ForceNearbyAttackLook");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InternalStartAttack;
    /// <summary>
    /// Function: InternalStartAttack
    /// </summary>
    public unsafe virtual void InternalStartAttack(bool bForceRestart = default, BmSDK.BmGame.RAEC_Attack_Base.AttackStartTrigger StartCause = default, BmSDK.BmGame.RPawnVillain TriggeringVillain = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InternalStartAttack, "BmGame.RAEC_Attack_Base.InternalStartAttack");
        byte* paramsPtr = stackalloc byte[16];
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
    public unsafe virtual void SpecialCaseThugStartedAttack(BmSDK.BmGame.RBMAIController SpotterCon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialCaseThugStartedAttack, "BmGame.RAEC_Attack_Base.SpecialCaseThugStartedAttack");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpotterCon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceStartAttackFromStoredState;
    /// <summary>
    /// Function: ForceStartAttackFromStoredState
    /// </summary>
    public unsafe virtual void ForceStartAttackFromStoredState(BmSDK.BmGame.RPawnPlayer.FAIAwarenessState StoredState, BmSDK.BmGame.RAEC_Attack_Base.PredAttackEscalationType EscType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceStartAttackFromStoredState, "BmGame.RAEC_Attack_Base.ForceStartAttackFromStoredState");
        byte* paramsPtr = stackalloc byte[129];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StoredState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EscType, paramsPtr + 128);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceStartAttack;
    /// <summary>
    /// Function: ForceStartAttack
    /// </summary>
    public unsafe virtual void ForceStartAttack(bool bForceRestart = default, BmSDK.BmGame.RAEC_Attack_Base.AttackStartTrigger StartCause = default, BmSDK.BmGame.RAEC_Attack_Base.PredAttackEscalationType EscType = default, BmSDK.BmGame.RPawnVillain TriggeringVillain = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceStartAttack, "BmGame.RAEC_Attack_Base.ForceStartAttack");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceRestart, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartCause, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EscType, paramsPtr + 5);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TriggeringVillain, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IndirectAlertTriggered;
    /// <summary>
    /// Function: IndirectAlertTriggered
    /// </summary>
    public unsafe virtual void IndirectAlertTriggered(System.Numerics.Vector3 alertLoc, BmSDK.BmGame.RAEC_Attack_Base.AttackStartTrigger StartCause = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IndirectAlertTriggered, "BmGame.RAEC_Attack_Base.IndirectAlertTriggered");
        byte* paramsPtr = stackalloc byte[13];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(alertLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartCause, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AreAttackersActive;
    /// <summary>
    /// Function: AreAttackersActive
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameRI.EPredAttackState AreAttackersActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreAttackersActive, "BmGame.RAEC_Attack_Base.AreAttackersActive");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EPredAttackState>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetAttackAECWantsThug;
    /// <summary>
    /// Function: SetAttackAECWantsThug
    /// </summary>
    public unsafe virtual void SetAttackAECWantsThug(BmSDK.BmGame.RBMAIController BrainCon, bool bNewVal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAttackAECWantsThug, "BmGame.RAEC_Attack_Base.SetAttackAECWantsThug");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BrainCon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewVal, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetConvergeActive;
    /// <summary>
    /// Function: GetConvergeActive
    /// </summary>
    public unsafe virtual bool GetConvergeActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetConvergeActive, "BmGame.RAEC_Attack_Base.GetConvergeActive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetConvergeActive;
    /// <summary>
    /// Function: SetConvergeActive
    /// </summary>
    public unsafe virtual void SetConvergeActive(bool bNewActive)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetConvergeActive, "BmGame.RAEC_Attack_Base.SetConvergeActive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewActive, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAIThoughts;
    /// <summary>
    /// Function: GetAIThoughts
    /// </summary>
    public unsafe override void GetAIThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAIThoughts, "BmGame.RAEC_Attack_Base.GetAIThoughts");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_TargetPlayerUpdated;
    /// <summary>
    /// Function: TargetPlayerUpdated
    /// </summary>
    public unsafe virtual void TargetPlayerUpdated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargetPlayerUpdated, "BmGame.RAEC_Attack_Base.TargetPlayerUpdated");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitForPlayer;
    /// <summary>
    /// Function: InitForPlayer
    /// </summary>
    public unsafe virtual void InitForPlayer(BmSDK.BmGame.RPawnPlayer NewTargetPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitForPlayer, "BmGame.RAEC_Attack_Base.InitForPlayer");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTargetPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBarkPriority;
    /// <summary>
    /// Function: GetBarkPriority
    /// </summary>
    public unsafe override int GetBarkPriority()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBarkPriority, "BmGame.RAEC_Attack_Base.GetBarkPriority");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_WantsToGlanceAt;
    /// <summary>
    /// Function: WantsToGlanceAt
    /// </summary>
    public unsafe override bool WantsToGlanceAt(BmSDK.Engine.Actor TestTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WantsToGlanceAt, "BmGame.RAEC_Attack_Base.WantsToGlanceAt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RAEC_Attack_Base.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishTopLevelAEC;
    /// <summary>
    /// Function: FinishTopLevelAEC
    /// </summary>
    public unsafe override void FinishTopLevelAEC(BmSDK.BmGame.RBMAIController StolenCon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishTopLevelAEC, "BmGame.RAEC_Attack_Base.FinishTopLevelAEC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StolenCon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateChildren;
    /// <summary>
    /// Function: CreateChildren
    /// </summary>
    public unsafe virtual void CreateChildren()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateChildren, "BmGame.RAEC_Attack_Base.CreateChildren");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: SpecialEscapeType
    /// </summary>
    public enum SpecialEscapeType : byte
    {
        SPECIALESCAPE_Vantage = 0,
        SPECIALESCAPE_SniperBoss = 1,
        SPECIALESCAPE_Other = 2,
        SPECIALESCAPE_MAX = 3,
    }

    /// <summary>
    /// Enum: AttackProgressState
    /// </summary>
    public enum AttackProgressState : byte
    {
        ATTPROG_None = 0,
        ATTPROG_SurpriseWindow = 1,
        ATTPROG_FreeFire = 2,
        ATTPROG_MAX = 3,
    }

    /// <summary>
    /// Enum: PredAttackEscalationType
    /// </summary>
    public enum PredAttackEscalationType : byte
    {
        PREDATTESC_Surprised = 0,
        PREDATTESC_FreeFire = 1,
        PREDATTESC_MAX = 2,
    }

    /// <summary>
    /// Enum: AttackStartTrigger
    /// </summary>
    public enum AttackStartTrigger : byte
    {
        AST_UnclearNoise = 0,
        AST_NoisyTakedown = 1,
        AST_Drone = 2,
        AST_SpottedInGrate = 3,
        AST_DMD = 4,
        AST_RedHoodSpottedPlayer = 5,
        AST_MAX = 6,
    }

    /// <summary>
    /// ObjectProperty: TargetPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer TargetPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bConvergeActive
    /// </summary>
    public unsafe bool bConvergeActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: bDoingFearTakedown
    /// </summary>
    public unsafe bool bDoingFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// FloatProperty: VantageEscapeTime
    /// </summary>
    public unsafe float VantageEscapeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ByteProperty: AttProg
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_Base.AttackProgressState AttProg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_Base.AttackProgressState>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: SurpriseWindowStartTime
    /// </summary>
    public unsafe float SurpriseWindowStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// FloatProperty: FreeFireStartTime
    /// </summary>
    public unsafe float FreeFireStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }
}
