#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPawnVillainJokerBoxerBase<br/>
/// (size = 6772)
/// (flags = 10485815)
/// </summary>
public partial class RPawnVillainJokerBoxerBase : BmSDK.BmGame.RPawnVillainThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnVillainJokerBoxerBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillainJokerBoxerBase.
    /// </summary>
    public static RPawnVillainJokerBoxerBase DefaultObject => (RPawnVillainJokerBoxerBase)StaticClass().DefaultObject;

    internal RPawnVillainJokerBoxerBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainJokerBoxerBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainJokerBoxerBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainJokerBoxerBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainJokerBoxerBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainJokerBoxerBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainJokerBoxerBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainJokerBoxerBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainJokerBoxerBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainJokerBoxerBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_EmoteExertWindUp;
    /// <summary>
    /// Function: EmoteExertWindUp
    /// </summary>
    public unsafe virtual void EmoteExertWindUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EmoteExertWindUp, "BmGame.RPawnVillainJokerBoxerBase.EmoteExertWindUp");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EmoteLaugh;
    /// <summary>
    /// Function: EmoteLaugh
    /// </summary>
    public unsafe virtual void EmoteLaugh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EmoteLaugh, "BmGame.RPawnVillainJokerBoxerBase.EmoteLaugh");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EmoteVictoryLaugh;
    /// <summary>
    /// Function: EmoteVictoryLaugh
    /// </summary>
    public unsafe virtual void EmoteVictoryLaugh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EmoteVictoryLaugh, "BmGame.RPawnVillainJokerBoxerBase.EmoteVictoryLaugh");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EmoteKO;
    /// <summary>
    /// Function: EmoteKO
    /// </summary>
    public unsafe virtual void EmoteKO()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EmoteKO, "BmGame.RPawnVillainJokerBoxerBase.EmoteKO");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EmoteExertLight;
    /// <summary>
    /// Function: EmoteExertLight
    /// </summary>
    public unsafe virtual void EmoteExertLight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EmoteExertLight, "BmGame.RPawnVillainJokerBoxerBase.EmoteExertLight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EmoteExertStrong;
    /// <summary>
    /// Function: EmoteExertStrong
    /// </summary>
    public unsafe virtual void EmoteExertStrong()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EmoteExertStrong, "BmGame.RPawnVillainJokerBoxerBase.EmoteExertStrong");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayPlayerSpecificTaunt;
    /// <summary>
    /// Function: PlayPlayerSpecificTaunt
    /// </summary>
    public unsafe virtual void PlayPlayerSpecificTaunt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayPlayerSpecificTaunt, "BmGame.RPawnVillainJokerBoxerBase.PlayPlayerSpecificTaunt");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHitByDualPlayBark;
    /// <summary>
    /// Function: PlayHitByDualPlayBark
    /// </summary>
    public unsafe virtual void PlayHitByDualPlayBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHitByDualPlayBark, "BmGame.RPawnVillainJokerBoxerBase.PlayHitByDualPlayBark");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHitPlayerInClashBark;
    /// <summary>
    /// Function: PlayHitPlayerInClashBark
    /// </summary>
    public unsafe virtual void PlayHitPlayerInClashBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHitPlayerInClashBark, "BmGame.RPawnVillainJokerBoxerBase.PlayHitPlayerInClashBark");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCombatBarkTaunt;
    /// <summary>
    /// Function: PlayCombatBarkTaunt
    /// </summary>
    public unsafe override void PlayCombatBarkTaunt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCombatBarkTaunt, "BmGame.RPawnVillainJokerBoxerBase.PlayCombatBarkTaunt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHitByRobinBark;
    /// <summary>
    /// Function: PlayHitByRobinBark
    /// </summary>
    public unsafe virtual void PlayHitByRobinBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHitByRobinBark, "BmGame.RPawnVillainJokerBoxerBase.PlayHitByRobinBark");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHitByBatmanBark;
    /// <summary>
    /// Function: PlayHitByBatmanBark
    /// </summary>
    public unsafe virtual void PlayHitByBatmanBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHitByBatmanBark, "BmGame.RPawnVillainJokerBoxerBase.PlayHitByBatmanBark");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCombatBark;
    /// <summary>
    /// Function: PlayCombatBark
    /// </summary>
    public unsafe override void PlayCombatBark(BmSDK.FName EventName, bool bUseWeapon, BmSDK.BmGame.RBMWeapon OverrideWeapon = default, BmSDK.FName OverrideWeaponFlag = default, BmSDK.BmGame.RBarkValDef.FlagTypeEnum FlagType = default, BmSDK.FName FlagValue = default, BmSDK.BmGame.RPawnPlayer OverridePlayer = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCombatBark, "BmGame.RPawnVillainJokerBoxerBase.PlayCombatBark");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseWeapon, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideWeapon, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideWeaponFlag, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagType, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagValue, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridePlayer, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RecoverHitPoint;
    /// <summary>
    /// Function: RecoverHitPoint
    /// </summary>
    public unsafe virtual void RecoverHitPoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecoverHitPoint, "BmGame.RPawnVillainJokerBoxerBase.RecoverHitPoint");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitHealthBar;
    /// <summary>
    /// Function: InitHealthBar
    /// </summary>
    public unsafe virtual void InitHealthBar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitHealthBar, "BmGame.RPawnVillainJokerBoxerBase.InitHealthBar");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearAnimsets;
    /// <summary>
    /// Function: ClearAnimsets
    /// </summary>
    public unsafe override void ClearAnimsets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAnimsets, "BmGame.RPawnVillainJokerBoxerBase.ClearAnimsets");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitAnimsets;
    /// <summary>
    /// Function: InitAnimsets
    /// </summary>
    public unsafe override void InitAnimsets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitAnimsets, "BmGame.RPawnVillainJokerBoxerBase.InitAnimsets");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireClashEvent;
    /// <summary>
    /// Function: FireClashEvent
    /// </summary>
    public unsafe virtual void FireClashEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireClashEvent, "BmGame.RPawnVillainJokerBoxerBase.FireClashEvent");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncVisibleDamageLevel;
    /// <summary>
    /// Function: IncVisibleDamageLevel
    /// </summary>
    public unsafe virtual void IncVisibleDamageLevel(int OverrideLevel = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncVisibleDamageLevel, "BmGame.RPawnVillainJokerBoxerBase.IncVisibleDamageLevel");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DecHitPoint;
    /// <summary>
    /// Function: DecHitPoint
    /// </summary>
    public unsafe virtual void DecHitPoint(bool bDualplayMove = default, bool bCounterHit = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DecHitPoint, "BmGame.RPawnVillainJokerBoxerBase.DecHitPoint");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDualplayMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCounterHit, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPlayerCombatAnimSet;
    /// <summary>
    /// Function: GetPlayerCombatAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetPlayerCombatAnimSet(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerCombatAnimSet, "BmGame.RPawnVillainJokerBoxerBase.GetPlayerCombatAnimSet");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPairedCombatAnimSet;
    /// <summary>
    /// Function: GetPairedCombatAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetPairedCombatAnimSet(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPairedCombatAnimSet, "BmGame.RPawnVillainJokerBoxerBase.GetPairedCombatAnimSet");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPossibleMoves;
    /// <summary>
    /// Function: GetPossibleMoves
    /// </summary>
    public unsafe virtual void GetPossibleMoves(out BmSDK.TArray<BmSDK.Class> PossibleMoves)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPossibleMoves, "BmGame.RPawnVillainJokerBoxerBase.GetPossibleMoves");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PossibleMoves = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnDualAttackMove;
    /// <summary>
    /// Function: SpawnDualAttackMove
    /// </summary>
    public unsafe virtual bool SpawnDualAttackMove(BmSDK.BmGame.RPawnPlayerCombat Grabber, BmSDK.FName InitialGrabAnim, System.Numerics.Vector3 MoveLoc, float MoveYaw, BmSDK.Engine.AnimSet JBAnimSet = default, BmSDK.Engine.AnimSet GrabberAnimSet = default, BmSDK.Engine.AnimSet AttackerAnimSet = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDualAttackMove, "BmGame.RPawnVillainJokerBoxerBase.SpawnDualAttackMove");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Grabber, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialGrabAnim, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLoc, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JBAnimSet, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrabberAnimSet, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackerAnimSet, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 56);
    }

    /// <summary>
    /// BoolProperty: bIsAttacking
    /// </summary>
    public unsafe bool bIsAttacking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6696); }
    }

    /// <summary>
    /// ArrayProperty: JBCombatAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> JBCombatAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6700); }
    }

    /// <summary>
    /// ArrayProperty: PlayerCombatAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> PlayerCombatAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6716); }
    }

    /// <summary>
    /// ObjectProperty: BossModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleBoss BossModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleBoss>(Ptr + 6732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6732); }
    }

    /// <summary>
    /// ObjectProperty: TheMovieInstance
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie TheMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 6740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6740); }
    }

    /// <summary>
    /// ClassProperty: ReviveMoveClass
    /// </summary>
    public unsafe BmSDK.Class ReviveMoveClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6748); }
    }

    /// <summary>
    /// FloatProperty: HitPoints
    /// </summary>
    public unsafe float HitPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6756); }
    }

    /// <summary>
    /// FloatProperty: MinHitPoints
    /// </summary>
    public unsafe float MinHitPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6760); }
    }

    /// <summary>
    /// FloatProperty: DualTakedownHitPoints
    /// </summary>
    public unsafe float DualTakedownHitPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6764); }
    }

    /// <summary>
    /// FloatProperty: LastReviveTime
    /// </summary>
    public unsafe float LastReviveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6768); }
    }
}
