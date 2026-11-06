#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCombatMove_DualPlayJokerBoxerAttack<br/>
/// (size = 1264)
/// (flags = 10485778)
/// </summary>
public partial class RCombatMove_DualPlayJokerBoxerAttack : BmSDK.BmGame.RCombatMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCombatMove_DualPlayJokerBoxerAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCombatMove_DualPlayJokerBoxerAttack.
    /// </summary>
    public static RCombatMove_DualPlayJokerBoxerAttack DefaultObject => (RCombatMove_DualPlayJokerBoxerAttack)StaticClass().DefaultObject;

    internal RCombatMove_DualPlayJokerBoxerAttack() { }

    /// <summary>
    /// Constructs a new RCombatMove_DualPlayJokerBoxerAttack
    /// </summary>
    public RCombatMove_DualPlayJokerBoxerAttack(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_DualPlayJokerBoxerAttack(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_DualPlayJokerBoxerAttack>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_DualPlayJokerBoxerAttack>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_DualPlayJokerBoxerAttack>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_DualPlayJokerBoxerAttack>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_DualPlayJokerBoxerAttack>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_DualPlayJokerBoxerAttack>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_DualPlayJokerBoxerAttack>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_DualPlayJokerBoxerAttack>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ExitMove;
    /// <summary>
    /// Function: ExitMove
    /// </summary>
    public unsafe override void ExitMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMove, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.ExitMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitMoveForPawn;
    /// <summary>
    /// Function: ExitMoveForPawn
    /// </summary>
    public unsafe override void ExitMoveForPawn(BmSDK.BmGame.RPawnCombat PawnToExit)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMoveForPawn, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.ExitMoveForPawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnToExit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveOverridenForPawn;
    /// <summary>
    /// Function: MoveOverridenForPawn
    /// </summary>
    public unsafe override void MoveOverridenForPawn(BmSDK.BmGame.RPawnCombat OverridenPawn, BmSDK.BmGame.RCombatMove NewMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveOverridenForPawn, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.MoveOverridenForPawn");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridenPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueAttackAnim;
    /// <summary>
    /// Function: QueueAttackAnim
    /// </summary>
    public unsafe virtual void QueueAttackAnim(int StageToQueue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueAttackAnim, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.QueueAttackAnim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StageToQueue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffHighlight;
    /// <summary>
    /// Function: TurnOffHighlight
    /// </summary>
    public unsafe virtual void TurnOffHighlight(bool bSuccess)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffHighlight, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.TurnOffHighlight");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccess, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnHighlight;
    /// <summary>
    /// Function: TurnOnHighlight
    /// </summary>
    public unsafe virtual void TurnOnHighlight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnHighlight, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.TurnOnHighlight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoJBAttackState;
    /// <summary>
    /// Function: GotoJBAttackState
    /// </summary>
    public unsafe virtual void GotoJBAttackState(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId QueuedAnimID, float TimeLeftOver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoJBAttackState, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.GotoJBAttackState");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueuedAnimID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoPlayersGetInState;
    /// <summary>
    /// Function: GotoPlayersGetInState
    /// </summary>
    public unsafe virtual void GotoPlayersGetInState(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId QueuedAnimID, float TimeLeftOver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoPlayersGetInState, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.GotoPlayersGetInState");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueuedAnimID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPreStrikeAnim;
    /// <summary>
    /// Function: GetPreStrikeAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetPreStrikeAnim(System.Numerics.Vector3 PreStrikeHeading)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPreStrikeAnim, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.GetPreStrikeAnim");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreStrikeHeading, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PlayClashStrike;
    /// <summary>
    /// Function: PlayClashStrike
    /// </summary>
    public unsafe virtual void PlayClashStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayClashStrike, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.PlayClashStrike");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCounter;
    /// <summary>
    /// Function: PlayCounter
    /// </summary>
    public unsafe virtual void PlayCounter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCounter, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.PlayCounter");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRemainingThugsOneHitKill;
    /// <summary>
    /// Function: SetRemainingThugsOneHitKill
    /// </summary>
    public unsafe virtual void SetRemainingThugsOneHitKill()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRemainingThugsOneHitKill, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.SetRemainingThugsOneHitKill");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCounterAttempted;
    /// <summary>
    /// Function: TriggerCounterAttempted
    /// </summary>
    public unsafe override void TriggerCounterAttempted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCounterAttempted, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.TriggerCounterAttempted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetForceToGiveToPawn;
    /// <summary>
    /// Function: GetForceToGiveToPawn
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetForceToGiveToPawn(BmSDK.BmGame.RPawnCombat Receiver, float MaxForce, float MinRange = default, float MaxRange = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetForceToGiveToPawn, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.GetForceToGiveToPawn");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Receiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxForce, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinRange, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxRange, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_OverrideForceToGiveToPawn;
    /// <summary>
    /// Function: OverrideForceToGiveToPawn
    /// </summary>
    public unsafe override bool OverrideForceToGiveToPawn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideForceToGiveToPawn, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.OverrideForceToGiveToPawn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeTargettedByPlayer;
    /// <summary>
    /// Function: CanBeTargettedByPlayer
    /// </summary>
    public unsafe override bool CanBeTargettedByPlayer(BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.Class DamageType, BmSDK.BmGame.RPawnPlayerCombat NewPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeTargettedByPlayer, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.CanBeTargettedByPlayer");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CanReceiveAttackFromPawn;
    /// <summary>
    /// Function: CanReceiveAttackFromPawn
    /// </summary>
    public unsafe override bool CanReceiveAttackFromPawn(BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReceiveAttackFromPawn, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.CanReceiveAttackFromPawn");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CanBotPerformNextComboMove;
    /// <summary>
    /// Function: CanBotPerformNextComboMove
    /// </summary>
    public unsafe override bool CanBotPerformNextComboMove(bool bSpecialMove = default, bool bStrike = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBotPerformNextComboMove, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.CanBotPerformNextComboMove");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStrike, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanPerformNextComboMove;
    /// <summary>
    /// Function: CanPerformNextComboMove
    /// </summary>
    public unsafe override bool CanPerformNextComboMove(bool bSpecialMove = default, bool bStrike = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformNextComboMove, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.CanPerformNextComboMove");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStrike, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DamagedBy;
    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat DamageReceiver, BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedBy, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.DamagedBy");
        byte* paramsPtr = stackalloc byte[300];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 256);
    }

    private static BmSDK.Function __fn_OverrideHitReaction;
    /// <summary>
    /// Function: OverrideHitReaction
    /// </summary>
    public unsafe override bool OverrideHitReaction(BmSDK.BmGame.RPawnCombat HitPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideHitReaction, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.OverrideHitReaction");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DamagePlayer;
    /// <summary>
    /// Function: DamagePlayer
    /// </summary>
    public unsafe virtual void DamagePlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagePlayer, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.DamagePlayer");
        byte* paramsPtr = stackalloc byte[264];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayPlayerHitRight;
    /// <summary>
    /// Function: PlayPlayerHitRight
    /// </summary>
    public unsafe virtual void PlayPlayerHitRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayPlayerHitRight, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.PlayPlayerHitRight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayPlayerHitLeft;
    /// <summary>
    /// Function: PlayPlayerHitLeft
    /// </summary>
    public unsafe virtual void PlayPlayerHitLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayPlayerHitLeft, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.PlayPlayerHitLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeTracked;
    /// <summary>
    /// Function: CanBeTracked
    /// </summary>
    public unsafe override bool CanBeTracked()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeTracked, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.CanBeTracked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetAnimSets;
    /// <summary>
    /// Function: SetAnimSets
    /// </summary>
    public unsafe virtual void SetAnimSets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAnimSets, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.SetAnimSets");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetImpactPS;
    /// <summary>
    /// Function: GetImpactPS
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetImpactPS()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetImpactPS, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.GetImpactPS");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearThugs;
    /// <summary>
    /// Function: ClearThugs
    /// </summary>
    public unsafe virtual void ClearThugs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearThugs, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.ClearThugs");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanNewAttackBeStarted;
    /// <summary>
    /// Function: CanNewAttackBeStarted
    /// </summary>
    public unsafe override bool CanNewAttackBeStarted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanNewAttackBeStarted, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.CanNewAttackBeStarted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAttacking;
    /// <summary>
    /// Function: IsAttacking
    /// </summary>
    public unsafe override bool IsAttacking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAttacking, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.IsAttacking");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInitiatorToTargetDistInAnim;
    /// <summary>
    /// Function: GetInitiatorToTargetDistInAnim
    /// </summary>
    public unsafe virtual float GetInitiatorToTargetDistInAnim(BmSDK.FName TestAnimName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInitiatorToTargetDistInAnim, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.GetInitiatorToTargetDistInAnim");
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestAnimName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetBestAnimYaw;
    /// <summary>
    /// Function: GetBestAnimYaw
    /// </summary>
    public unsafe virtual bool GetBestAnimYaw(BmSDK.FName TestAnimName, BmSDK.BmGame.RPawnPlayerCombat InitiatorPawn, BmSDK.BmGame.RPawnPlayerCombat BuddyPawn, BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.Engine.AnimSet IAnimSet, BmSDK.Engine.AnimSet BAnimset, BmSDK.Engine.AnimSet TAnimSet, BmSDK.Engine.AnimSet CamAnimset, System.Numerics.Vector3 refLoc, BmSDK.Rotator RefRot, out int OutYaw)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestAnimYaw, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.GetBestAnimYaw");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestAnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitiatorPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BuddyPawn, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IAnimSet, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BAnimset, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TAnimSet, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamAnimset, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(refLoc, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RefRot, paramsPtr + 76);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutYaw);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutYaw, paramsPtr + 88);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutYaw = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 88);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 92);
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.Initialise");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCombatThoughts;
    /// <summary>
    /// Function: GetCombatThoughts
    /// </summary>
    public unsafe override void GetCombatThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatThoughts, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.GetCombatThoughts");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ShowStaffIfBuddyIsRobin;
    /// <summary>
    /// Function: ShowStaffIfBuddyIsRobin
    /// </summary>
    public unsafe virtual void ShowStaffIfBuddyIsRobin()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowStaffIfBuddyIsRobin, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.ShowStaffIfBuddyIsRobin");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BoxerStrikeable;
    /// <summary>
    /// Function: BoxerStrikeable
    /// </summary>
    public unsafe virtual void BoxerStrikeable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BoxerStrikeable, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.BoxerStrikeable");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SlowmoSfxOff;
    /// <summary>
    /// Function: SlowmoSfxOff
    /// </summary>
    public unsafe virtual void SlowmoSfxOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SlowmoSfxOff, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.SlowmoSfxOff");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SlomoSfxOn;
    /// <summary>
    /// Function: SlomoSfxOn
    /// </summary>
    public unsafe virtual void SlomoSfxOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SlomoSfxOn, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.SlomoSfxOn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpeedUp;
    /// <summary>
    /// Function: SpeedUp
    /// </summary>
    public unsafe virtual void SpeedUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpeedUp, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.SpeedUp");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SlowDown;
    /// <summary>
    /// Function: SlowDown
    /// </summary>
    public unsafe virtual void SlowDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SlowDown, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.SlowDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMoveYaw;
    /// <summary>
    /// Function: UpdateMoveYaw
    /// </summary>
    public unsafe virtual void UpdateMoveYaw()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMoveYaw, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.UpdateMoveYaw");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugsReactCheer;
    /// <summary>
    /// Function: ThugsReactCheer
    /// </summary>
    public unsafe virtual void ThugsReactCheer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugsReactCheer, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.ThugsReactCheer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugsReactPain;
    /// <summary>
    /// Function: ThugsReactPain
    /// </summary>
    public unsafe virtual void ThugsReactPain()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugsReactPain, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.ThugsReactPain");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BuddyHitKillJB;
    /// <summary>
    /// Function: BuddyHitKillJB
    /// </summary>
    public unsafe virtual void BuddyHitKillJB()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuddyHitKillJB, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.BuddyHitKillJB");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinalHit;
    /// <summary>
    /// Function: FinalHit
    /// </summary>
    public unsafe virtual void FinalHit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinalHit, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.FinalHit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnSlaveAll;
    /// <summary>
    /// Function: UnSlaveAll
    /// </summary>
    public unsafe virtual void UnSlaveAll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnSlaveAll, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.UnSlaveAll");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerBeatdownHitJB;
    /// <summary>
    /// Function: PlayerBeatdownHitJB
    /// </summary>
    public unsafe virtual void PlayerBeatdownHitJB()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerBeatdownHitJB, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.PlayerBeatdownHitJB");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BuddyHitJBRightElbow;
    /// <summary>
    /// Function: BuddyHitJBRightElbow
    /// </summary>
    public unsafe virtual void BuddyHitJBRightElbow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuddyHitJBRightElbow, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.BuddyHitJBRightElbow");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BuddyHitJBLeftElbow;
    /// <summary>
    /// Function: BuddyHitJBLeftElbow
    /// </summary>
    public unsafe virtual void BuddyHitJBLeftElbow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuddyHitJBLeftElbow, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.BuddyHitJBLeftElbow");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BuddyHitJBRightFoot;
    /// <summary>
    /// Function: BuddyHitJBRightFoot
    /// </summary>
    public unsafe virtual void BuddyHitJBRightFoot()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuddyHitJBRightFoot, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.BuddyHitJBRightFoot");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BuddyHitJBLeftFoot;
    /// <summary>
    /// Function: BuddyHitJBLeftFoot
    /// </summary>
    public unsafe virtual void BuddyHitJBLeftFoot()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuddyHitJBLeftFoot, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.BuddyHitJBLeftFoot");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BuddyHitJBHead;
    /// <summary>
    /// Function: BuddyHitJBHead
    /// </summary>
    public unsafe virtual void BuddyHitJBHead()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuddyHitJBHead, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.BuddyHitJBHead");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BuddyHitJBRightKnee;
    /// <summary>
    /// Function: BuddyHitJBRightKnee
    /// </summary>
    public unsafe virtual void BuddyHitJBRightKnee()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuddyHitJBRightKnee, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.BuddyHitJBRightKnee");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BuddyHitJBLeftKnee;
    /// <summary>
    /// Function: BuddyHitJBLeftKnee
    /// </summary>
    public unsafe virtual void BuddyHitJBLeftKnee()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuddyHitJBLeftKnee, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.BuddyHitJBLeftKnee");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BuddyBeatdownHitJBRight;
    /// <summary>
    /// Function: BuddyBeatdownHitJBRight
    /// </summary>
    public unsafe virtual void BuddyBeatdownHitJBRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuddyBeatdownHitJBRight, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.BuddyBeatdownHitJBRight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BuddyBeatdownHitJBLeft;
    /// <summary>
    /// Function: BuddyBeatdownHitJBLeft
    /// </summary>
    public unsafe virtual void BuddyBeatdownHitJBLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuddyBeatdownHitJBLeft, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.BuddyBeatdownHitJBLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BuddyHitJBRight;
    /// <summary>
    /// Function: BuddyHitJBRight
    /// </summary>
    public unsafe virtual void BuddyHitJBRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuddyHitJBRight, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.BuddyHitJBRight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BuddyCounterHitJBLeft;
    /// <summary>
    /// Function: BuddyCounterHitJBLeft
    /// </summary>
    public unsafe virtual void BuddyCounterHitJBLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuddyCounterHitJBLeft, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.BuddyCounterHitJBLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BuddyHitJBLeft;
    /// <summary>
    /// Function: BuddyHitJBLeft
    /// </summary>
    public unsafe virtual void BuddyHitJBLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuddyHitJBLeft, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.BuddyHitJBLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitiatorHitJBRightElbow;
    /// <summary>
    /// Function: InitiatorHitJBRightElbow
    /// </summary>
    public unsafe virtual void InitiatorHitJBRightElbow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitiatorHitJBRightElbow, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.InitiatorHitJBRightElbow");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitiatorHitJBLeftElbow;
    /// <summary>
    /// Function: InitiatorHitJBLeftElbow
    /// </summary>
    public unsafe virtual void InitiatorHitJBLeftElbow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitiatorHitJBLeftElbow, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.InitiatorHitJBLeftElbow");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitiatorHitJBRightFoot;
    /// <summary>
    /// Function: InitiatorHitJBRightFoot
    /// </summary>
    public unsafe virtual void InitiatorHitJBRightFoot()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitiatorHitJBRightFoot, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.InitiatorHitJBRightFoot");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitiatorHitJBLeftFoot;
    /// <summary>
    /// Function: InitiatorHitJBLeftFoot
    /// </summary>
    public unsafe virtual void InitiatorHitJBLeftFoot()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitiatorHitJBLeftFoot, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.InitiatorHitJBLeftFoot");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitiatorHitJBHead;
    /// <summary>
    /// Function: InitiatorHitJBHead
    /// </summary>
    public unsafe virtual void InitiatorHitJBHead()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitiatorHitJBHead, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.InitiatorHitJBHead");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitiatorHitJBRightKnee;
    /// <summary>
    /// Function: InitiatorHitJBRightKnee
    /// </summary>
    public unsafe virtual void InitiatorHitJBRightKnee()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitiatorHitJBRightKnee, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.InitiatorHitJBRightKnee");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitiatorHitJBLeftKnee;
    /// <summary>
    /// Function: InitiatorHitJBLeftKnee
    /// </summary>
    public unsafe virtual void InitiatorHitJBLeftKnee()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitiatorHitJBLeftKnee, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.InitiatorHitJBLeftKnee");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitiatorBeatdownHitJBRight;
    /// <summary>
    /// Function: InitiatorBeatdownHitJBRight
    /// </summary>
    public unsafe virtual void InitiatorBeatdownHitJBRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitiatorBeatdownHitJBRight, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.InitiatorBeatdownHitJBRight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitiatorBeatdownHitJBLeft;
    /// <summary>
    /// Function: InitiatorBeatdownHitJBLeft
    /// </summary>
    public unsafe virtual void InitiatorBeatdownHitJBLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitiatorBeatdownHitJBLeft, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.InitiatorBeatdownHitJBLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerStrikeTargetHandR;
    /// <summary>
    /// Function: PlayerStrikeTargetHandR
    /// </summary>
    public unsafe virtual void PlayerStrikeTargetHandR()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerStrikeTargetHandR, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.PlayerStrikeTargetHandR");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitiatorHitJBRight;
    /// <summary>
    /// Function: InitiatorHitJBRight
    /// </summary>
    public unsafe virtual void InitiatorHitJBRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitiatorHitJBRight, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.InitiatorHitJBRight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitiatorCounterHitJBLeft;
    /// <summary>
    /// Function: InitiatorCounterHitJBLeft
    /// </summary>
    public unsafe virtual void InitiatorCounterHitJBLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitiatorCounterHitJBLeft, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.InitiatorCounterHitJBLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitiatorHitJBLeft;
    /// <summary>
    /// Function: InitiatorHitJBLeft
    /// </summary>
    public unsafe virtual void InitiatorHitJBLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitiatorHitJBLeft, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.InitiatorHitJBLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerHitJB;
    /// <summary>
    /// Function: PlayerHitJB
    /// </summary>
    public unsafe virtual void PlayerHitJB(bool bCounterHit = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerHitJB, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.PlayerHitJB");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCounterHit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayRumbleFx;
    /// <summary>
    /// Function: PlayRumbleFx
    /// </summary>
    public unsafe virtual void PlayRumbleFx()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayRumbleFx, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.PlayRumbleFx");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamageProxyOff;
    /// <summary>
    /// Function: DamageProxyOff
    /// </summary>
    public unsafe virtual void DamageProxyOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageProxyOff, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.DamageProxyOff");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamageProxyOnRight;
    /// <summary>
    /// Function: DamageProxyOnRight
    /// </summary>
    public unsafe virtual void DamageProxyOnRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageProxyOnRight, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.DamageProxyOnRight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamageProxyOnLeft;
    /// <summary>
    /// Function: DamageProxyOnLeft
    /// </summary>
    public unsafe virtual void DamageProxyOnLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageProxyOnLeft, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.DamageProxyOnLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanStrike;
    /// <summary>
    /// Function: CanStrike
    /// </summary>
    public unsafe virtual void CanStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanStrike, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.CanStrike");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowMovementExit;
    /// <summary>
    /// Function: AllowMovementExit
    /// </summary>
    public unsafe virtual void AllowMovementExit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowMovementExit, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.AllowMovementExit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowNextStrike;
    /// <summary>
    /// Function: AllowNextStrike
    /// </summary>
    public unsafe virtual void AllowNextStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowNextStrike, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.AllowNextStrike");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanCounterStop;
    /// <summary>
    /// Function: CanCounterStop
    /// </summary>
    public unsafe virtual void CanCounterStop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCounterStop, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.CanCounterStop");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanCounterStart;
    /// <summary>
    /// Function: CanCounterStart
    /// </summary>
    public unsafe virtual void CanCounterStart()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCounterStart, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.CanCounterStart");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FocusJokerBoxer;
    /// <summary>
    /// Function: FocusJokerBoxer
    /// </summary>
    public unsafe virtual void FocusJokerBoxer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FocusJokerBoxer, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.FocusJokerBoxer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FocusBuddy;
    /// <summary>
    /// Function: FocusBuddy
    /// </summary>
    public unsafe virtual void FocusBuddy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FocusBuddy, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.FocusBuddy");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FocusInitiator;
    /// <summary>
    /// Function: FocusInitiator
    /// </summary>
    public unsafe virtual void FocusInitiator()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FocusInitiator, "BmScript.RCombatMove_DualPlayJokerBoxerAttack.FocusInitiator");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Initiator
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat Initiator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ObjectProperty: Buddy
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat Buddy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ObjectProperty: JBoxer
    /// </summary>
    public unsafe BmSDK.BmScript.RPawnVillainJokerBoxer JBoxer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnVillainJokerBoxer>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// ObjectProperty: InitiatorAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet InitiatorAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// ObjectProperty: BuddyAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BuddyAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ObjectProperty: JBInitiatorAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet JBInitiatorAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ObjectProperty: JBBuddyAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet JBBuddyAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ObjectProperty: BeatdownAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BeatdownAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// StructProperty: PlayerAnimID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayerAnimID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 840);

    /// <summary>
    /// StructProperty: InitiatorAttackAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId InitiatorAttackAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 844);

    /// <summary>
    /// StructProperty: BuddyAttackAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId BuddyAttackAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 848);

    /// <summary>
    /// StructProperty: JBoxerAttackAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId JBoxerAttackAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 852);

    /// <summary>
    /// StructProperty: InitiatorCounterAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId InitiatorCounterAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 856);

    /// <summary>
    /// StructProperty: BuddyCounterAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId BuddyCounterAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 860);

    /// <summary>
    /// StructProperty: JBoxerCounterAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId JBoxerCounterAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 864);

    /// <summary>
    /// StructProperty: JBoxerPreStrikeAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId JBoxerPreStrikeAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 868);

    /// <summary>
    /// StructProperty: JBoxerGetInAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId JBoxerGetInAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 872);

    /// <summary>
    /// StructProperty: MoveLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MoveLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 876);

    /// <summary>
    /// StructProperty: LeapInAnimPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LeapInAnimPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 888);

    /// <summary>
    /// StructProperty: MoveRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator MoveRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 900);

    /// <summary>
    /// StructProperty: InitiatorStartPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 InitiatorStartPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 912);

    /// <summary>
    /// StructProperty: JBoxerStartPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 JBoxerStartPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 924);

    /// <summary>
    /// ArrayProperty: AttackList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> AttackList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// ArrayProperty: CounterList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CounterList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ArrayProperty: IdleList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> IdleList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// IntProperty: ClashStage
    /// </summary>
    public unsafe int ClashStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// IntProperty: BeatdownStage
    /// </summary>
    public unsafe int BeatdownStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// IntProperty: InitiatorBeatdownNum
    /// </summary>
    public unsafe int InitiatorBeatdownNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// IntProperty: BuddyBeatdownNum
    /// </summary>
    public unsafe int BuddyBeatdownNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// NameProperty: BeatdownName
    /// </summary>
    public unsafe BmSDK.FName BeatdownName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// StructProperty: ImpactScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 1008);

    /// <summary>
    /// BoolProperty: bIsFinalCounter
    /// </summary>
    public unsafe bool bIsFinalCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1164); }
    }

    /// <summary>
    /// BoolProperty: bIsBuddyTurn
    /// </summary>
    public unsafe bool bIsBuddyTurn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1164); }
    }

    /// <summary>
    /// BoolProperty: bAllowNextStrike
    /// </summary>
    public unsafe bool bAllowNextStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1164); }
    }

    /// <summary>
    /// BoolProperty: bAllowMovementExit
    /// </summary>
    public unsafe bool bAllowMovementExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1164); }
    }

    /// <summary>
    /// BoolProperty: bCanCounter
    /// </summary>
    public unsafe bool bCanCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1164); }
    }

    /// <summary>
    /// BoolProperty: bCanStrike
    /// </summary>
    public unsafe bool bCanStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1164); }
    }

    /// <summary>
    /// BoolProperty: bSlowDownApplied
    /// </summary>
    public unsafe bool bSlowDownApplied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1164); }
    }

    /// <summary>
    /// BoolProperty: bPlayerHit
    /// </summary>
    public unsafe bool bPlayerHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1164); }
    }

    /// <summary>
    /// BoolProperty: bJBoxerStrikeable
    /// </summary>
    public unsafe bool bJBoxerStrikeable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1164); }
    }

    /// <summary>
    /// NameProperty: InitialGrabAnim
    /// </summary>
    public unsafe BmSDK.FName InitialGrabAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// FloatProperty: GrabbedTime
    /// </summary>
    public unsafe float GrabbedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// FloatProperty: AttackRange
    /// </summary>
    public unsafe float AttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// StructProperty: InitAttackerLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 InitAttackerLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1184);

    /// <summary>
    /// IntProperty: StrikeNum
    /// </summary>
    public unsafe int StrikeNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// ArrayProperty: HitTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat> HitTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// FloatProperty: MaxGrabTime
    /// </summary>
    public unsafe float MaxGrabTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// IntProperty: HitVariation
    /// </summary>
    public unsafe int HitVariation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// NameProperty: GetInAnimName
    /// </summary>
    public unsafe BmSDK.FName GetInAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// NameProperty: GetInIdleAnimName
    /// </summary>
    public unsafe BmSDK.FName GetInIdleAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// NameProperty: PreStrikeAnim
    /// </summary>
    public unsafe BmSDK.FName PreStrikeAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// FloatProperty: MinIntoAnimDist
    /// </summary>
    public unsafe float MinIntoAnimDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// FloatProperty: MaxIntoAnimDist
    /// </summary>
    public unsafe float MaxIntoAnimDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// FloatProperty: MinDurationScale
    /// </summary>
    public unsafe float MinDurationScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// FloatProperty: MaxDurationScale
    /// </summary>
    public unsafe float MaxDurationScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }
}
