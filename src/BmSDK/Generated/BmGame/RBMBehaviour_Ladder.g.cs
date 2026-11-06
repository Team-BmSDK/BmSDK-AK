#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_Ladder<br/>
/// (size = 644)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_Ladder : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_Ladder", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMBehaviour_Ladder.
    /// </summary>
    public static RBMBehaviour_Ladder DefaultObject => (RBMBehaviour_Ladder)StaticClass().DefaultObject;

    internal RBMBehaviour_Ladder() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_Ladder
    /// </summary>
    public RBMBehaviour_Ladder(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_Ladder Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_Ladder(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_Ladder>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_Ladder>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_Ladder>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_Ladder>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_Ladder>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_Ladder>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_Ladder>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_Ladder>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CanThugBeFrozen;
    /// <summary>
    /// Function: CanThugBeFrozen
    /// </summary>
    public unsafe override bool CanThugBeFrozen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanThugBeFrozen, "BmGame.RBMBehaviour_Ladder.CanThugBeFrozen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayJumpDownLadderAnim;
    /// <summary>
    /// Function: PlayJumpDownLadderAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayJumpDownLadderAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayJumpDownLadderAnim, "BmGame.RBMBehaviour_Ladder.PlayJumpDownLadderAnim");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PawnWantsToJump;
    /// <summary>
    /// Function: PawnWantsToJump
    /// </summary>
    public unsafe virtual bool PawnWantsToJump()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnWantsToJump, "BmGame.RBMBehaviour_Ladder.PawnWantsToJump");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayFullClimbLadderAnim;
    /// <summary>
    /// Function: PlayFullClimbLadderAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayFullClimbLadderAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFullClimbLadderAnim, "BmGame.RBMBehaviour_Ladder.PlayFullClimbLadderAnim");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayedQueuedClimbAnim;
    /// <summary>
    /// Function: PlayedQueuedClimbAnim
    /// </summary>
    public unsafe virtual void PlayedQueuedClimbAnim(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId QueuedTransition, float TimeLeftOver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayedQueuedClimbAnim, "BmGame.RBMBehaviour_Ladder.PlayedQueuedClimbAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueuedTransition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayClimbLadderAnim;
    /// <summary>
    /// Function: PlayClimbLadderAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayClimbLadderAnim(BmSDK.FName LadderTransName, bool bQueue = default, bool bCompensateForLadderHeight = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayClimbLadderAnim, "BmGame.RBMBehaviour_Ladder.PlayClimbLadderAnim");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LadderTransName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bQueue, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCompensateForLadderHeight, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetClimbLadderAnimName_Out;
    /// <summary>
    /// Function: GetClimbLadderAnimName_Out
    /// </summary>
    public unsafe virtual BmSDK.FName GetClimbLadderAnimName_Out()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClimbLadderAnimName_Out, "BmGame.RBMBehaviour_Ladder.GetClimbLadderAnimName_Out");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetClimbLadderAnimName_Middle;
    /// <summary>
    /// Function: GetClimbLadderAnimName_Middle
    /// </summary>
    public unsafe virtual BmSDK.FName GetClimbLadderAnimName_Middle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClimbLadderAnimName_Middle, "BmGame.RBMBehaviour_Ladder.GetClimbLadderAnimName_Middle");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetClimbLadderAnimName_In;
    /// <summary>
    /// Function: GetClimbLadderAnimName_In
    /// </summary>
    public unsafe virtual BmSDK.FName GetClimbLadderAnimName_In()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClimbLadderAnimName_In, "BmGame.RBMBehaviour_Ladder.GetClimbLadderAnimName_In");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AllowNextClimber;
    /// <summary>
    /// Function: AllowNextClimber
    /// </summary>
    public unsafe virtual void AllowNextClimber()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowNextClimber, "BmGame.RBMBehaviour_Ladder.AllowNextClimber");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableRagdollOnHit;
    /// <summary>
    /// Function: EnableRagdollOnHit
    /// </summary>
    public unsafe virtual void EnableRagdollOnHit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableRagdollOnHit, "BmGame.RBMBehaviour_Ladder.EnableRagdollOnHit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableRagdollOnHit;
    /// <summary>
    /// Function: DisableRagdollOnHit
    /// </summary>
    public unsafe virtual void DisableRagdollOnHit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableRagdollOnHit, "BmGame.RBMBehaviour_Ladder.DisableRagdollOnHit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyChase;
    /// <summary>
    /// Function: NotifyChase
    /// </summary>
    public unsafe virtual void NotifyChase(System.Numerics.Vector3 LadderForward)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyChase, "BmGame.RBMBehaviour_Ladder.NotifyChase");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LadderForward, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckPawnsBelow;
    /// <summary>
    /// Function: CheckPawnsBelow
    /// </summary>
    public unsafe virtual void CheckPawnsBelow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckPawnsBelow, "BmGame.RBMBehaviour_Ladder.CheckPawnsBelow");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KnockBackPawn;
    /// <summary>
    /// Function: KnockBackPawn
    /// </summary>
    public unsafe virtual void KnockBackPawn(BmSDK.BmGame.RPawnCombat TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KnockBackPawn, "BmGame.RBMBehaviour_Ladder.KnockBackPawn");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WillLandOnPawn;
    /// <summary>
    /// Function: WillLandOnPawn
    /// </summary>
    public unsafe virtual bool WillLandOnPawn(BmSDK.BmGame.RPawn TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WillLandOnPawn, "BmGame.RBMBehaviour_Ladder.WillLandOnPawn");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_OnDeactivate;
    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeactivate, "BmGame.RBMBehaviour_Ladder.OnDeactivate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnActivate;
    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmGame.RBMBehaviour_Ladder.OnActivate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartTraversal;
    /// <summary>
    /// Function: StartTraversal
    /// </summary>
    public unsafe virtual void StartTraversal(BmSDK.BmGame.RLadder NewLadder, bool bClimbing)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartTraversal, "BmGame.RBMBehaviour_Ladder.StartTraversal");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLadder, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bClimbing, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Ladder
    /// </summary>
    public unsafe BmSDK.BmGame.RLadder Ladder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLadder>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: LadderAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet LadderAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bClimbingLadder
    /// </summary>
    public unsafe bool bClimbingLadder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 604); }
    }

    /// <summary>
    /// BoolProperty: bInitialReceiveSoftPawnCollision
    /// </summary>
    public unsafe bool bInitialReceiveSoftPawnCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 604); }
    }

    /// <summary>
    /// BoolProperty: bPlayedOutAnim
    /// </summary>
    public unsafe bool bPlayedOutAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 604); }
    }

    /// <summary>
    /// StructProperty: LadderAnimID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId LadderAnimID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 608);

    /// <summary>
    /// StructProperty: LadderAnimID2
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId LadderAnimID2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 612);

    /// <summary>
    /// StructProperty: LadderAnimID3
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId LadderAnimID3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 616);

    /// <summary>
    /// StructProperty: LadderTop
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LadderTop
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 620);

    /// <summary>
    /// StructProperty: StartLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StartLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 632);
}
