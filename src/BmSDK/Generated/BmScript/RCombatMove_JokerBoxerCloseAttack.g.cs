#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCombatMove_JokerBoxerCloseAttack<br/>
/// (size = 1044)
/// (flags = 10485778)
/// </summary>
public partial class RCombatMove_JokerBoxerCloseAttack : BmSDK.BmGame.RCombatMove_VillainAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCombatMove_JokerBoxerCloseAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCombatMove_JokerBoxerCloseAttack.
    /// </summary>
    public static RCombatMove_JokerBoxerCloseAttack DefaultObject => (RCombatMove_JokerBoxerCloseAttack)StaticClass().DefaultObject;

    internal RCombatMove_JokerBoxerCloseAttack() { }

    /// <summary>
    /// Constructs a new RCombatMove_JokerBoxerCloseAttack
    /// </summary>
    public RCombatMove_JokerBoxerCloseAttack(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_JokerBoxerCloseAttack(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_JokerBoxerCloseAttack>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_JokerBoxerCloseAttack>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_JokerBoxerCloseAttack>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_JokerBoxerCloseAttack>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_JokerBoxerCloseAttack>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_JokerBoxerCloseAttack>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_JokerBoxerCloseAttack>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_JokerBoxerCloseAttack>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ExitMove;
    /// <summary>
    /// Function: ExitMove
    /// </summary>
    public unsafe override void ExitMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMove, "BmScript.RCombatMove_JokerBoxerCloseAttack.ExitMove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveOverridenForPawn;
    /// <summary>
    /// Function: MoveOverridenForPawn
    /// </summary>
    public unsafe override void MoveOverridenForPawn(BmSDK.BmGame.RPawnCombat OverridenPawn, BmSDK.BmGame.RCombatMove NewMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveOverridenForPawn, "BmScript.RCombatMove_JokerBoxerCloseAttack.MoveOverridenForPawn");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridenPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHitPlayerBark;
    /// <summary>
    /// Function: PlayHitPlayerBark
    /// </summary>
    public unsafe virtual void PlayHitPlayerBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHitPlayerBark, "BmScript.RCombatMove_JokerBoxerCloseAttack.PlayHitPlayerBark");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerIsPullingAway;
    /// <summary>
    /// Function: PlayerIsPullingAway
    /// </summary>
    public unsafe virtual bool PlayerIsPullingAway()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerIsPullingAway, "BmScript.RCombatMove_JokerBoxerCloseAttack.PlayerIsPullingAway");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayerIsCounteringProperly;
    /// <summary>
    /// Function: PlayerIsCounteringProperly
    /// </summary>
    public unsafe virtual bool PlayerIsCounteringProperly()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerIsCounteringProperly, "BmScript.RCombatMove_JokerBoxerCloseAttack.PlayerIsCounteringProperly");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BreakoutHeadlock;
    /// <summary>
    /// Function: BreakoutHeadlock
    /// </summary>
    public unsafe virtual void BreakoutHeadlock()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BreakoutHeadlock, "BmScript.RCombatMove_JokerBoxerCloseAttack.BreakoutHeadlock");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartCustomCounter;
    /// <summary>
    /// Function: StartCustomCounter
    /// </summary>
    public unsafe override bool StartCustomCounter(BmSDK.BmGame.RPawnPlayerCombat Counterer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartCustomCounter, "BmScript.RCombatMove_JokerBoxerCloseAttack.StartCustomCounter");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Counterer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PlayCounterAnim;
    /// <summary>
    /// Function: PlayCounterAnim
    /// </summary>
    public unsafe virtual void PlayCounterAnim(bool bPlayIdle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCounterAnim, "BmScript.RCombatMove_JokerBoxerCloseAttack.PlayCounterAnim");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayIdle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayStrikeAnim;
    /// <summary>
    /// Function: PlayStrikeAnim
    /// </summary>
    public unsafe virtual void PlayStrikeAnim(BmSDK.FName AnimName, bool bRotationOnly = default, float StartTime = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayStrikeAnim, "BmScript.RCombatMove_JokerBoxerCloseAttack.PlayStrikeAnim");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRotationOnly, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowAnotherAttacker;
    /// <summary>
    /// Function: AllowAnotherAttacker
    /// </summary>
    public unsafe override bool AllowAnotherAttacker()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowAnotherAttacker, "BmScript.RCombatMove_JokerBoxerCloseAttack.AllowAnotherAttacker");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAttacking;
    /// <summary>
    /// Function: IsAttacking
    /// </summary>
    public unsafe override bool IsAttacking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAttacking, "BmScript.RCombatMove_JokerBoxerCloseAttack.IsAttacking");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TargetMovingAway;
    /// <summary>
    /// Function: TargetMovingAway
    /// </summary>
    public unsafe virtual bool TargetMovingAway()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargetMovingAway, "BmScript.RCombatMove_JokerBoxerCloseAttack.TargetMovingAway");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DamagePawn;
    /// <summary>
    /// Function: DamagePawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.DamageResult DamagePawn(BmSDK.BmGame.RPawnCombat DamageReceiver, bool bHeavy, bool bLeftHit, bool bHitAlt = default, bool bSendPlayerBack = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagePawn, "BmScript.RCombatMove_JokerBoxerCloseAttack.DamagePawn");
        byte* paramsPtr = stackalloc byte[288];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHeavy, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLeftHit, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHitAlt, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSendPlayerBack, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CanPerformNextComboMove;
    /// <summary>
    /// Function: CanPerformNextComboMove
    /// </summary>
    public unsafe override bool CanPerformNextComboMove(bool bSpecialMove = default, bool bStrike = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformNextComboMove, "BmScript.RCombatMove_JokerBoxerCloseAttack.CanPerformNextComboMove");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStrike, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PlayAbortAnim;
    /// <summary>
    /// Function: PlayAbortAnim
    /// </summary>
    public unsafe override void PlayAbortAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAbortAnim, "BmScript.RCombatMove_JokerBoxerCloseAttack.PlayAbortAnim");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldStartNextStrike;
    /// <summary>
    /// Function: ShouldStartNextStrike
    /// </summary>
    public unsafe virtual bool ShouldStartNextStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldStartNextStrike, "BmScript.RCombatMove_JokerBoxerCloseAttack.ShouldStartNextStrike");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopTargetting;
    /// <summary>
    /// Function: StopTargetting
    /// </summary>
    public unsafe override void StopTargetting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopTargetting, "BmScript.RCombatMove_JokerBoxerCloseAttack.StopTargetting");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamageCollisionDeactivated;
    /// <summary>
    /// Function: DamageCollisionDeactivated
    /// </summary>
    public unsafe virtual void DamageCollisionDeactivated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageCollisionDeactivated, "BmScript.RCombatMove_JokerBoxerCloseAttack.DamageCollisionDeactivated");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDamageBone;
    /// <summary>
    /// Function: GetDamageBone
    /// </summary>
    public unsafe virtual BmSDK.FName GetDamageBone(bool bLeft)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageBone, "BmScript.RCombatMove_JokerBoxerCloseAttack.GetDamageBone");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLeft, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OnPlayHaymaker;
    /// <summary>
    /// Function: OnPlayHaymaker
    /// </summary>
    public unsafe virtual void OnPlayHaymaker(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId NewId, float TimeLeftOver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPlayHaymaker, "BmScript.RCombatMove_JokerBoxerCloseAttack.OnPlayHaymaker");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPlayHeadlockLoop;
    /// <summary>
    /// Function: OnPlayHeadlockLoop
    /// </summary>
    public unsafe virtual void OnPlayHeadlockLoop(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId NewId, float TimeLeftOver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPlayHeadlockLoop, "BmScript.RCombatMove_JokerBoxerCloseAttack.OnPlayHeadlockLoop");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAttackState;
    /// <summary>
    /// Function: StartAttackState
    /// </summary>
    public unsafe virtual void StartAttackState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAttackState, "BmScript.RCombatMove_JokerBoxerCloseAttack.StartAttackState");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStrikeAnim;
    /// <summary>
    /// Function: GetStrikeAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetStrikeAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeAnim, "BmScript.RCombatMove_JokerBoxerCloseAttack.GetStrikeAnim");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeLocation;
    /// <summary>
    /// Function: GetStrikeLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetStrikeLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeLocation, "BmScript.RCombatMove_JokerBoxerCloseAttack.GetStrikeLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DamageNearbyThug;
    /// <summary>
    /// Function: DamageNearbyThug
    /// </summary>
    public unsafe virtual void DamageNearbyThug(System.Numerics.Vector3 DamageSource)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageNearbyThug, "BmScript.RCombatMove_JokerBoxerCloseAttack.DamageNearbyThug");
        byte* paramsPtr = stackalloc byte[292];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageSource, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmScript.RCombatMove_JokerBoxerCloseAttack.Initialise");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Queue5End;
    /// <summary>
    /// Function: Queue5End
    /// </summary>
    public unsafe virtual void Queue5End()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Queue5End, "BmScript.RCombatMove_JokerBoxerCloseAttack.Queue5End");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Queue4End;
    /// <summary>
    /// Function: Queue4End
    /// </summary>
    public unsafe virtual void Queue4End()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Queue4End, "BmScript.RCombatMove_JokerBoxerCloseAttack.Queue4End");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Queue3End;
    /// <summary>
    /// Function: Queue3End
    /// </summary>
    public unsafe virtual void Queue3End()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Queue3End, "BmScript.RCombatMove_JokerBoxerCloseAttack.Queue3End");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Queue2End;
    /// <summary>
    /// Function: Queue2End
    /// </summary>
    public unsafe virtual void Queue2End()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Queue2End, "BmScript.RCombatMove_JokerBoxerCloseAttack.Queue2End");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Queue2Mid;
    /// <summary>
    /// Function: Queue2Mid
    /// </summary>
    public unsafe virtual void Queue2Mid()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Queue2Mid, "BmScript.RCombatMove_JokerBoxerCloseAttack.Queue2Mid");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Branch34;
    /// <summary>
    /// Function: Branch34
    /// </summary>
    public unsafe virtual void Branch34()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Branch34, "BmScript.RCombatMove_JokerBoxerCloseAttack.Branch34");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Branch35;
    /// <summary>
    /// Function: Branch35
    /// </summary>
    public unsafe virtual void Branch35()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Branch35, "BmScript.RCombatMove_JokerBoxerCloseAttack.Branch35");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Branch345;
    /// <summary>
    /// Function: Branch345
    /// </summary>
    public unsafe virtual void Branch345()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Branch345, "BmScript.RCombatMove_JokerBoxerCloseAttack.Branch345");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueHaymaker;
    /// <summary>
    /// Function: QueueHaymaker
    /// </summary>
    public unsafe virtual void QueueHaymaker()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueHaymaker, "BmScript.RCombatMove_JokerBoxerCloseAttack.QueueHaymaker");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HeadlockStrike;
    /// <summary>
    /// Function: HeadlockStrike
    /// </summary>
    public unsafe virtual void HeadlockStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HeadlockStrike, "BmScript.RCombatMove_JokerBoxerCloseAttack.HeadlockStrike");
        byte* paramsPtr = stackalloc byte[248];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueHeadlock;
    /// <summary>
    /// Function: QueueHeadlock
    /// </summary>
    public unsafe virtual void QueueHeadlock()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueHeadlock, "BmScript.RCombatMove_JokerBoxerCloseAttack.QueueHeadlock");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HeadlockContact;
    /// <summary>
    /// Function: HeadlockContact
    /// </summary>
    public unsafe virtual void HeadlockContact()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HeadlockContact, "BmScript.RCombatMove_JokerBoxerCloseAttack.HeadlockContact");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NormalSpeed;
    /// <summary>
    /// Function: NormalSpeed
    /// </summary>
    public unsafe virtual void NormalSpeed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NormalSpeed, "BmScript.RCombatMove_JokerBoxerCloseAttack.NormalSpeed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopTrail;
    /// <summary>
    /// Function: StopTrail
    /// </summary>
    public unsafe virtual void StopTrail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopTrail, "BmScript.RCombatMove_JokerBoxerCloseAttack.StopTrail");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartTrailRight;
    /// <summary>
    /// Function: StartTrailRight
    /// </summary>
    public unsafe virtual void StartTrailRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartTrailRight, "BmScript.RCombatMove_JokerBoxerCloseAttack.StartTrailRight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartTrailLeft;
    /// <summary>
    /// Function: StartTrailLeft
    /// </summary>
    public unsafe virtual void StartTrailLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartTrailLeft, "BmScript.RCombatMove_JokerBoxerCloseAttack.StartTrailLeft");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LastCombatAnimHitRight;
    /// <summary>
    /// Function: LastCombatAnimHitRight
    /// </summary>
    public unsafe virtual void LastCombatAnimHitRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LastCombatAnimHitRight, "BmScript.RCombatMove_JokerBoxerCloseAttack.LastCombatAnimHitRight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LastCombatAnimHitLeft;
    /// <summary>
    /// Function: LastCombatAnimHitLeft
    /// </summary>
    public unsafe virtual void LastCombatAnimHitLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LastCombatAnimHitLeft, "BmScript.RCombatMove_JokerBoxerCloseAttack.LastCombatAnimHitLeft");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowNextStrike;
    /// <summary>
    /// Function: AllowNextStrike
    /// </summary>
    public unsafe virtual void AllowNextStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowNextStrike, "BmScript.RCombatMove_JokerBoxerCloseAttack.AllowNextStrike");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldHitPlayer;
    /// <summary>
    /// Function: ShouldHitPlayer
    /// </summary>
    public unsafe virtual bool ShouldHitPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldHitPlayer, "BmScript.RCombatMove_JokerBoxerCloseAttack.ShouldHitPlayer");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_VeryCloseToTarget;
    /// <summary>
    /// Function: VeryCloseToTarget
    /// </summary>
    public unsafe virtual bool VeryCloseToTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VeryCloseToTarget, "BmScript.RCombatMove_JokerBoxerCloseAttack.VeryCloseToTarget");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AllowedToHit;
    /// <summary>
    /// Function: AllowedToHit
    /// </summary>
    public unsafe virtual bool AllowedToHit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowedToHit, "BmScript.RCombatMove_JokerBoxerCloseAttack.AllowedToHit");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CombatAnimHitRightLight;
    /// <summary>
    /// Function: CombatAnimHitRightLight
    /// </summary>
    public unsafe virtual void CombatAnimHitRightLight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatAnimHitRightLight, "BmScript.RCombatMove_JokerBoxerCloseAttack.CombatAnimHitRightLight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatAnimHitLeftLightAlt;
    /// <summary>
    /// Function: CombatAnimHitLeftLightAlt
    /// </summary>
    public unsafe virtual void CombatAnimHitLeftLightAlt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatAnimHitLeftLightAlt, "BmScript.RCombatMove_JokerBoxerCloseAttack.CombatAnimHitLeftLightAlt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatAnimHitLeftLight;
    /// <summary>
    /// Function: CombatAnimHitLeftLight
    /// </summary>
    public unsafe virtual void CombatAnimHitLeftLight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatAnimHitLeftLight, "BmScript.RCombatMove_JokerBoxerCloseAttack.CombatAnimHitLeftLight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatAnimHitRightHeavy;
    /// <summary>
    /// Function: CombatAnimHitRightHeavy
    /// </summary>
    public unsafe virtual void CombatAnimHitRightHeavy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatAnimHitRightHeavy, "BmScript.RCombatMove_JokerBoxerCloseAttack.CombatAnimHitRightHeavy");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatAnimHitRight;
    /// <summary>
    /// Function: CombatAnimHitRight
    /// </summary>
    public unsafe virtual void CombatAnimHitRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatAnimHitRight, "BmScript.RCombatMove_JokerBoxerCloseAttack.CombatAnimHitRight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatAnimHitLeft;
    /// <summary>
    /// Function: CombatAnimHitLeft
    /// </summary>
    public unsafe virtual void CombatAnimHitLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatAnimHitLeft, "BmScript.RCombatMove_JokerBoxerCloseAttack.CombatAnimHitLeft");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: MoveTimeout
    /// </summary>
    public unsafe float MoveTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ArrayProperty: HitTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat> HitTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bQueueStrike
    /// </summary>
    public unsafe bool bQueueStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 824); }
    }

    /// <summary>
    /// BoolProperty: bDisableCounter
    /// </summary>
    public unsafe bool bDisableCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 824); }
    }

    /// <summary>
    /// BoolProperty: bForceStraightIntoAttack
    /// </summary>
    public unsafe bool bForceStraightIntoAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 824); }
    }

    /// <summary>
    /// BoolProperty: bTrackTarget
    /// </summary>
    public unsafe bool bTrackTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 824); }
    }

    /// <summary>
    /// BoolProperty: bLastStrike
    /// </summary>
    public unsafe bool bLastStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 824); }
    }

    /// <summary>
    /// BoolProperty: bForceHitTarget
    /// </summary>
    public unsafe bool bForceHitTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 824); }
    }

    /// <summary>
    /// BoolProperty: bAllowNextStrike
    /// </summary>
    public unsafe bool bAllowNextStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 824); }
    }

    /// <summary>
    /// BoolProperty: bHeadlock
    /// </summary>
    public unsafe bool bHeadlock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 824); }
    }

    /// <summary>
    /// BoolProperty: bCountered
    /// </summary>
    public unsafe bool bCountered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 824); }
    }

    /// <summary>
    /// BoolProperty: bPulledAwayAlready
    /// </summary>
    public unsafe bool bPulledAwayAlready
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 824); }
    }

    /// <summary>
    /// BoolProperty: bCounterHeld
    /// </summary>
    public unsafe bool bCounterHeld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 824); }
    }

    /// <summary>
    /// BoolProperty: bDisplaySwitch
    /// </summary>
    public unsafe bool bDisplaySwitch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 824); }
    }

    /// <summary>
    /// BoolProperty: bHitPlayer
    /// </summary>
    public unsafe bool bHitPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 824); }
    }

    /// <summary>
    /// NameProperty: OverrideStrikeAnimName
    /// </summary>
    public unsafe BmSDK.FName OverrideStrikeAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: OverrideStrikeAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet OverrideStrikeAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: TargetAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet TargetAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ObjectProperty: JBoxerAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet JBoxerAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ComponentProperty: StrikeTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent StrikeTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// FloatProperty: OverrideStrikeDurationScale
    /// </summary>
    public unsafe float OverrideStrikeDurationScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// StructProperty: InitStrikeDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 InitStrikeDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 872);

    /// <summary>
    /// StructProperty: FirstTransitionLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FirstTransitionLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 884);

    /// <summary>
    /// StructProperty: LastTransitionLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastTransitionLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 896);

    /// <summary>
    /// FloatProperty: LastTransitionRotation
    /// </summary>
    public unsafe float LastTransitionRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// IntProperty: ForceHitFrames
    /// </summary>
    public unsafe int ForceHitFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// FloatProperty: ForceHitDist
    /// </summary>
    public unsafe float ForceHitDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// StructProperty: TargetAnimID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId TargetAnimID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 920);

    /// <summary>
    /// StructProperty: VillainAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId VillainAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 924);

    /// <summary>
    /// NameProperty: PlayerImpactBone
    /// </summary>
    public unsafe BmSDK.FName PlayerImpactBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// NameProperty: StrikeAnimName
    /// </summary>
    public unsafe BmSDK.FName StrikeAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// NameProperty: VillainStrikeBone
    /// </summary>
    public unsafe BmSDK.FName VillainStrikeBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// NameProperty: CounterAnimName
    /// </summary>
    public unsafe BmSDK.FName CounterAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// NameProperty: idleAnimName
    /// </summary>
    public unsafe BmSDK.FName idleAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ByteProperty: StrikeCounterLimb
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CounterLimb StrikeCounterLimb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CounterLimb>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// FloatProperty: SlideHitReactionAmount
    /// </summary>
    public unsafe float SlideHitReactionAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// FloatProperty: TransitionDurationScale
    /// </summary>
    public unsafe float TransitionDurationScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// StructProperty: AnimPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AnimPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 980);

    /// <summary>
    /// FloatProperty: AnimYaw
    /// </summary>
    public unsafe float AnimYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// FloatProperty: DamageAmount
    /// </summary>
    public unsafe float DamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// FloatProperty: AttackRange
    /// </summary>
    public unsafe float AttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// IntProperty: NumHitsLanded
    /// </summary>
    public unsafe int NumHitsLanded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// IntProperty: NumHitsMissed
    /// </summary>
    public unsafe int NumHitsMissed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ArrayProperty: AnimDuration
    /// </summary>
    public unsafe BmSDK.TArray<float> AnimDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// IntProperty: Variation
    /// </summary>
    public unsafe int Variation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: HitRange
    /// </summary>
    public unsafe float HitRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: AttackDelay
    /// </summary>
    public unsafe float AttackDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: StrikeRadius
    /// </summary>
    public unsafe float StrikeRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }
}
