#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRobinBotController<br/>
/// (size = 1476)
/// (flags = 144703634)
/// </summary>
public partial class RRobinBotController : BmSDK.BmGame.RBotController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRobinBotController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RRobinBotController.
    /// </summary>
    public static RRobinBotController DefaultObject => (RRobinBotController)StaticClass().DefaultObject;

    internal RRobinBotController() { }

    /// <summary>
    /// Constructs a new RRobinBotController
    /// </summary>
    public RRobinBotController(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRobinBotController(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRobinBotController>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRobinBotController>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRobinBotController>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRobinBotController>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRobinBotController>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRobinBotController>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRobinBotController>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRobinBotController>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetAssistTarget;
    /// <summary>
    /// Function: GetAssistTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain GetAssistTarget(bool bAllowMinigunners = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAssistTarget, "BmGame.RRobinBotController.GetAssistTarget");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowMinigunners, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBestHidePointForRobin;
    /// <summary>
    /// Function: GetBestHidePointForRobin
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHidePoint GetBestHidePointForRobin(bool IsInjured, bool bCheckCollision = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestHidePointForRobin, "BmGame.RRobinBotController.GetBestHidePointForRobin");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsInjured, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckCollision, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHidePoint>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe virtual void GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.RRobinBotController.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchControlForTakedown;
    /// <summary>
    /// Function: SwitchControlForTakedown
    /// </summary>
    public unsafe virtual void SwitchControlForTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchControlForTakedown, "BmGame.RRobinBotController.SwitchControlForTakedown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnSimultaneousPredatorTakedown;
    /// <summary>
    /// Function: SpawnSimultaneousPredatorTakedown
    /// </summary>
    public unsafe virtual void SpawnSimultaneousPredatorTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSimultaneousPredatorTakedown, "BmGame.RRobinBotController.SpawnSimultaneousPredatorTakedown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSimultaneousTakedownTarget;
    /// <summary>
    /// Function: SetSimultaneousTakedownTarget
    /// </summary>
    public unsafe virtual void SetSimultaneousTakedownTarget(BmSDK.BmGame.RPawnVillain NewTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSimultaneousTakedownTarget, "BmGame.RRobinBotController.SetSimultaneousTakedownTarget");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RobinTakedownFinished;
    /// <summary>
    /// Function: RobinTakedownFinished
    /// </summary>
    public unsafe virtual void RobinTakedownFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RobinTakedownFinished, "BmGame.RRobinBotController.RobinTakedownFinished");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RobinPredatorCooldown;
    /// <summary>
    /// Function: RobinPredatorCooldown
    /// </summary>
    public unsafe virtual void RobinPredatorCooldown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RobinPredatorCooldown, "BmGame.RRobinBotController.RobinPredatorCooldown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInVantage;
    /// <summary>
    /// Function: IsInVantage
    /// </summary>
    public unsafe virtual bool IsInVantage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInVantage, "BmGame.RRobinBotController.IsInVantage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NotifyShotBy;
    /// <summary>
    /// Function: NotifyShotBy
    /// </summary>
    public unsafe virtual void NotifyShotBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyShotBy, "BmGame.RRobinBotController.NotifyShotBy");
        byte* paramsPtr = stackalloc byte[264];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DualPlayTakedown;
    /// <summary>
    /// Function: DualPlayTakedown
    /// </summary>
    public unsafe virtual bool DualPlayTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DualPlayTakedown, "BmGame.RRobinBotController.DualPlayTakedown");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DualPlayDistract;
    /// <summary>
    /// Function: DualPlayDistract
    /// </summary>
    public unsafe virtual void DualPlayDistract()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DualPlayDistract, "BmGame.RRobinBotController.DualPlayDistract");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostFallingPhysicsCallback;
    /// <summary>
    /// Function: PostFallingPhysicsCallback
    /// </summary>
    public unsafe virtual void PostFallingPhysicsCallback()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostFallingPhysicsCallback, "BmGame.RRobinBotController.PostFallingPhysicsCallback");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChooseMoveToPlayerLocation;
    /// <summary>
    /// Function: ChooseMoveToPlayerLocation
    /// </summary>
    public unsafe virtual bool ChooseMoveToPlayerLocation(out System.Numerics.Vector3 IdealLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChooseMoveToPlayerLocation, "BmGame.RRobinBotController.ChooseMoveToPlayerLocation");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IdealLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdealLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IdealLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PointValid;
    /// <summary>
    /// Function: PointValid
    /// </summary>
    public unsafe virtual bool PointValid(System.Numerics.Vector3 Loc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PointValid, "BmGame.RRobinBotController.PointValid");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_StartNavMeshSearch;
    /// <summary>
    /// Function: StartNavMeshSearch
    /// </summary>
    public unsafe virtual void StartNavMeshSearch(System.Numerics.Vector3 Destination)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartNavMeshSearch, "BmGame.RRobinBotController.StartNavMeshSearch");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Destination, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_JumpOffLedge;
    /// <summary>
    /// Function: JumpOffLedge
    /// </summary>
    public unsafe virtual void JumpOffLedge(float StepHeight, System.Numerics.Vector3 JumpDirection, System.Numerics.Vector3 JumpLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JumpOffLedge, "BmGame.RRobinBotController.JumpOffLedge");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StepHeight, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpDirection, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FollowPath;
    /// <summary>
    /// Function: FollowPath
    /// </summary>
    public unsafe virtual void FollowPath()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FollowPath, "BmGame.RRobinBotController.FollowPath");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveToGoal;
    /// <summary>
    /// Function: MoveToGoal
    /// </summary>
    public unsafe virtual void MoveToGoal(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveToGoal, "BmGame.RRobinBotController.MoveToGoal");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RRobinBotController.PreStreamOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RRobinBotController.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldPathToKismetPoint;
    /// <summary>
    /// Function: ShouldPathToKismetPoint
    /// </summary>
    public unsafe virtual bool ShouldPathToKismetPoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldPathToKismetPoint, "BmGame.RRobinBotController.ShouldPathToKismetPoint");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldPathToPlayer;
    /// <summary>
    /// Function: ShouldPathToPlayer
    /// </summary>
    public unsafe virtual bool ShouldPathToPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldPathToPlayer, "BmGame.RRobinBotController.ShouldPathToPlayer");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanUseDoors;
    /// <summary>
    /// Function: CanUseDoors
    /// </summary>
    public unsafe virtual bool CanUseDoors()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseDoors, "BmGame.RRobinBotController.CanUseDoors");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TrySpawnEvade;
    /// <summary>
    /// Function: TrySpawnEvade
    /// </summary>
    public unsafe virtual bool TrySpawnEvade(System.Numerics.Vector3 EvadeDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrySpawnEvade, "BmGame.RRobinBotController.TrySpawnEvade");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvadeDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_EnterKismetStand;
    /// <summary>
    /// Function: EnterKismetStand
    /// </summary>
    public unsafe virtual void EnterKismetStand()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterKismetStand, "BmGame.RRobinBotController.EnterKismetStand");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveFromKismetStand;
    /// <summary>
    /// Function: RemoveFromKismetStand
    /// </summary>
    public unsafe virtual bool RemoveFromKismetStand()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveFromKismetStand, "BmGame.RRobinBotController.RemoveFromKismetStand");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayerIsCrouching;
    /// <summary>
    /// Function: PlayerIsCrouching
    /// </summary>
    public unsafe virtual bool PlayerIsCrouching()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerIsCrouching, "BmGame.RRobinBotController.PlayerIsCrouching");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckForCrouching;
    /// <summary>
    /// Function: CheckForCrouching
    /// </summary>
    public unsafe virtual void CheckForCrouching(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForCrouching, "BmGame.RRobinBotController.CheckForCrouching");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopAllLookAtPlayer;
    /// <summary>
    /// Function: StopAllLookAtPlayer
    /// </summary>
    public unsafe virtual void StopAllLookAtPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAllLookAtPlayer, "BmGame.RRobinBotController.StopAllLookAtPlayer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLookForward;
    /// <summary>
    /// Function: ClearLookForward
    /// </summary>
    public unsafe virtual void ClearLookForward()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLookForward, "BmGame.RRobinBotController.ClearLookForward");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLookBack;
    /// <summary>
    /// Function: ClearLookBack
    /// </summary>
    public unsafe virtual void ClearLookBack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLookBack, "BmGame.RRobinBotController.ClearLookBack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateLookAtPlayer;
    /// <summary>
    /// Function: UpdateLookAtPlayer
    /// </summary>
    public unsafe virtual void UpdateLookAtPlayer(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateLookAtPlayer, "BmGame.RRobinBotController.UpdateLookAtPlayer");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetTimeLookAtPlayer;
    /// <summary>
    /// Function: ResetTimeLookAtPlayer
    /// </summary>
    public unsafe virtual void ResetTimeLookAtPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetTimeLookAtPlayer, "BmGame.RRobinBotController.ResetTimeLookAtPlayer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMovement;
    /// <summary>
    /// Function: UpdateMovement
    /// </summary>
    public unsafe virtual void UpdateMovement(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMovement, "BmGame.RRobinBotController.UpdateMovement");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerInWay;
    /// <summary>
    /// Function: PlayerInWay
    /// </summary>
    public unsafe virtual bool PlayerInWay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerInWay, "BmGame.RRobinBotController.PlayerInWay");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnFinishedCombatMove;
    /// <summary>
    /// Function: SpawnFinishedCombatMove
    /// </summary>
    public unsafe virtual void SpawnFinishedCombatMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFinishedCombatMove, "BmGame.RRobinBotController.SpawnFinishedCombatMove");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCarrying;
    /// <summary>
    /// Function: SetCarrying
    /// </summary>
    public unsafe virtual void SetCarrying(bool bCarry, BmSDK.BmGame.RSeqAct_BeginCarryJokerThugBase CarrySeq = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCarrying, "BmGame.RRobinBotController.SetCarrying");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCarry, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CarrySeq, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceCarryJokerTransitionOver;
    /// <summary>
    /// Function: ForceCarryJokerTransitionOver
    /// </summary>
    public unsafe virtual void ForceCarryJokerTransitionOver()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceCarryJokerTransitionOver, "BmGame.RRobinBotController.ForceCarryJokerTransitionOver");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RRobinBotController.Tick");
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoPreCombatMove;
    /// <summary>
    /// Function: DoPreCombatMove
    /// </summary>
    public unsafe virtual void DoPreCombatMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoPreCombatMove, "BmGame.RRobinBotController.DoPreCombatMove");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnDualStrike;
    /// <summary>
    /// Function: SpawnDualStrike
    /// </summary>
    public unsafe virtual bool SpawnDualStrike(BmSDK.BmGame.RPawnVillain VillainTarget, BmSDK.BmGame.RPawnPlayerCombat.FDualStrikeInfo DStrikeInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDualStrike, "BmGame.RRobinBotController.SpawnDualStrike");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DStrikeInfo, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_IsDualStrikeInfoRelevant;
    /// <summary>
    /// Function: IsDualStrikeInfoRelevant
    /// </summary>
    public unsafe virtual bool IsDualStrikeInfoRelevant(BmSDK.BmGame.RPawnPlayerCombat.FDualStrikeInfo TestInfo, BmSDK.BmGame.RPawnPlayerCombat InitiatorPawn, BmSDK.BmGame.RPawnPlayerCombat BuddyPawn, BmSDK.BmGame.RPawnVillain TargetPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDualStrikeInfoRelevant, "BmGame.RRobinBotController.IsDualStrikeInfoRelevant");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitiatorPawn, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BuddyPawn, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_IsVillainDualStrikeable;
    /// <summary>
    /// Function: IsVillainDualStrikeable
    /// </summary>
    public unsafe virtual bool IsVillainDualStrikeable(BmSDK.BmGame.RPawnVillain TestVillain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVillainDualStrikeable, "BmGame.RRobinBotController.IsVillainDualStrikeable");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TrySpawnMove;
    /// <summary>
    /// Function: TrySpawnMove
    /// </summary>
    public unsafe virtual bool TrySpawnMove(BmSDK.BmGame.RRobinBotController.BotCombatMoveType MoveType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrySpawnMove, "BmGame.RRobinBotController.TrySpawnMove");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ChooseCombatMove;
    /// <summary>
    /// Function: ChooseCombatMove
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RRobinBotController.BotCombatMoveType ChooseCombatMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChooseCombatMove, "BmGame.RRobinBotController.ChooseCombatMove");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RRobinBotController.BotCombatMoveType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryCombatMove;
    /// <summary>
    /// Function: TryCombatMove
    /// </summary>
    public unsafe virtual void TryCombatMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryCombatMove, "BmGame.RRobinBotController.TryCombatMove");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatFaceAimAt;
    /// <summary>
    /// Function: CombatFaceAimAt
    /// </summary>
    public unsafe virtual void CombatFaceAimAt(BmSDK.BmGame.RPawnCombat PawnOfInterest)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatFaceAimAt, "BmGame.RRobinBotController.CombatFaceAimAt");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnOfInterest, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAllowNextStrike;
    /// <summary>
    /// Function: OnAllowNextStrike
    /// </summary>
    public unsafe virtual void OnAllowNextStrike(BmSDK.BmGame.RCombatMove CurrentMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAllowNextStrike, "BmGame.RRobinBotController.OnAllowNextStrike");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsFloorStrikeAllowed;
    /// <summary>
    /// Function: IsFloorStrikeAllowed
    /// </summary>
    public unsafe virtual bool IsFloorStrikeAllowed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFloorStrikeAllowed, "BmGame.RRobinBotController.IsFloorStrikeAllowed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsDualStrikeAllowed;
    /// <summary>
    /// Function: IsDualStrikeAllowed
    /// </summary>
    public unsafe virtual bool IsDualStrikeAllowed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDualStrikeAllowed, "BmGame.RRobinBotController.IsDualStrikeAllowed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsRedirectAllowed;
    /// <summary>
    /// Function: IsRedirectAllowed
    /// </summary>
    public unsafe virtual bool IsRedirectAllowed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRedirectAllowed, "BmGame.RRobinBotController.IsRedirectAllowed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAutoSwapAllowed;
    /// <summary>
    /// Function: IsAutoSwapAllowed
    /// </summary>
    public unsafe virtual bool IsAutoSwapAllowed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAutoSwapAllowed, "BmGame.RRobinBotController.IsAutoSwapAllowed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPlayerPawn;
    /// <summary>
    /// Function: GetPlayerPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayer GetPlayerPawn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerPawn, "BmGame.RRobinBotController.GetPlayerPawn");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearNavigation;
    /// <summary>
    /// Function: ClearNavigation
    /// </summary>
    public unsafe virtual void ClearNavigation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearNavigation, "BmGame.RRobinBotController.ClearNavigation");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnPossess;
    /// <summary>
    /// Function: UnPossess
    /// </summary>
    public unsafe override void UnPossess()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnPossess, "BmGame.RRobinBotController.UnPossess");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpendDualPlayPredAttack;
    /// <summary>
    /// Function: SpendDualPlayPredAttack
    /// </summary>
    public unsafe virtual void SpendDualPlayPredAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpendDualPlayPredAttack, "BmGame.RRobinBotController.SpendDualPlayPredAttack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitDualPlayPred;
    /// <summary>
    /// Function: InitDualPlayPred
    /// </summary>
    public unsafe virtual void InitDualPlayPred()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitDualPlayPred, "BmGame.RRobinBotController.InitDualPlayPred");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Possess;
    /// <summary>
    /// Function: Possess
    /// </summary>
    public unsafe override void Possess(BmSDK.Engine.Pawn inPawn, bool bVehicleTransition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Possess, "BmGame.RRobinBotController.Possess");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVehicleTransition, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RRobinBotController.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBestMoveToPoint;
    /// <summary>
    /// Function: GetBestMoveToPoint
    /// </summary>
    public unsafe virtual void GetBestMoveToPoint(out System.Numerics.Vector3 TestLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestMoveToPoint, "BmGame.RRobinBotController.GetBestMoveToPoint");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TestLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        TestLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlayCombatTaunt;
    /// <summary>
    /// Function: CanPlayCombatTaunt
    /// </summary>
    public unsafe virtual bool CanPlayCombatTaunt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayCombatTaunt, "BmGame.RRobinBotController.CanPlayCombatTaunt");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: BotCombatMoveType
    /// </summary>
    public enum BotCombatMoveType : byte
    {
        BCMT_None = 0,
        BCMT_Strike = 1,
        BCMT_Beatdown = 2,
        BCMT_Redirect = 3,
        BCMT_StrikeFloor = 4,
        BCMT_Num = 5,
        BCMT_MAX = 6,
    }

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavigationHandle
    /// </summary>
    public unsafe System.IntPtr VfTable_IInterface_NavigationHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ObjectProperty: GRI
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI GRI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer PlayerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ObjectProperty: BotPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer BotPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// ObjectProperty: CarryAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_BeginCarryJokerThugBase CarryAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_BeginCarryJokerThugBase>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// ObjectProperty: NavHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle NavHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ObjectProperty: BotExclusionVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RBotExclusionVolume BotExclusionVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBotExclusionVolume>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// ObjectProperty: KismetMoveAct
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_MovePlayer KismetMoveAct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_MovePlayer>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// ObjectProperty: KismetStandAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet KismetStandAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// ObjectProperty: HidePoints
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass HidePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// ObjectProperty: CurrentHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint CurrentHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// ObjectProperty: SimultaneousTakedownTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain SimultaneousTakedownTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// ObjectProperty: AssistTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain AssistTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// ObjectProperty: ForcedCinematicMode
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController ForcedCinematicMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// ClassProperty: PawnClass
    /// </summary>
    public unsafe BmSDK.Class PawnClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// BoolProperty: bDualTakedownQueued
    /// </summary>
    public unsafe bool bDualTakedownQueued
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bDisallowBeamsForPred
    /// </summary>
    public unsafe bool bDisallowBeamsForPred
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bWasInCombat
    /// </summary>
    public unsafe bool bWasInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bIsCarryingSomeone
    /// </summary>
    public unsafe bool bIsCarryingSomeone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bMoveInitialised
    /// </summary>
    public unsafe bool bMoveInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bWasMoving
    /// </summary>
    public unsafe bool bWasMoving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bCrouched
    /// </summary>
    public unsafe bool bCrouched
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bInGrate
    /// </summary>
    public unsafe bool bInGrate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bInMovementStand
    /// </summary>
    public unsafe bool bInMovementStand
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bInKismetMove
    /// </summary>
    public unsafe bool bInKismetMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bForceRun
    /// </summary>
    public unsafe bool bForceRun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bKismetWaitAtGoal
    /// </summary>
    public unsafe bool bKismetWaitAtGoal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bUseKismetStand
    /// </summary>
    public unsafe bool bUseKismetStand
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bInKismetStand
    /// </summary>
    public unsafe bool bInKismetStand
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bLookingBehind
    /// </summary>
    public unsafe bool bLookingBehind
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bLookingAtPlayer
    /// </summary>
    public unsafe bool bLookingAtPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bHasLookedBack
    /// </summary>
    public unsafe bool bHasLookedBack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bHasLookedForward
    /// </summary>
    public unsafe bool bHasLookedForward
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: MarkAndExecute
    /// </summary>
    public unsafe bool MarkAndExecute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bDisableAfterCombatMoves
    /// </summary>
    public unsafe bool bDisableAfterCombatMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bNeedsToJumpDown
    /// </summary>
    public unsafe bool bNeedsToJumpDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bForceGargoyleMove
    /// </summary>
    public unsafe bool bForceGargoyleMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// BoolProperty: bWaitingForPlayerToMove
    /// </summary>
    public unsafe bool bWaitingForPlayerToMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1256); }
    }

    /// <summary>
    /// FloatProperty: timeIdle
    /// </summary>
    public unsafe float timeIdle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// FloatProperty: TryMoveTime
    /// </summary>
    public unsafe float TryMoveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// FloatProperty: LastAutoSwapTime
    /// </summary>
    public unsafe float LastAutoSwapTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// FloatProperty: LastRedirectTime
    /// </summary>
    public unsafe float LastRedirectTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// FloatProperty: LastDualStrikeTime
    /// </summary>
    public unsafe float LastDualStrikeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// FloatProperty: LastFloorStrikeTime
    /// </summary>
    public unsafe float LastFloorStrikeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// ByteProperty: NextMove
    /// </summary>
    public unsafe BmSDK.BmGame.RRobinBotController.BotCombatMoveType NextMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRobinBotController.BotCombatMoveType>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// FloatProperty: TimeTillMovementCheck
    /// </summary>
    public unsafe float TimeTillMovementCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// StructProperty: LastMovePoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastMovePoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1292);

    /// <summary>
    /// FloatProperty: CloseToGoalDist
    /// </summary>
    public unsafe float CloseToGoalDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// FloatProperty: CloseToOldDist
    /// </summary>
    public unsafe float CloseToOldDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// FloatProperty: RunBase
    /// </summary>
    public unsafe float RunBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// FloatProperty: VeryCloseToGoalDist
    /// </summary>
    public unsafe float VeryCloseToGoalDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// FloatProperty: StandBehindDist
    /// </summary>
    public unsafe float StandBehindDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// FloatProperty: ActualMoveSpeed
    /// </summary>
    public unsafe float ActualMoveSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// FloatProperty: WalkBehindDist
    /// </summary>
    public unsafe float WalkBehindDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// FloatProperty: RunBehindDist
    /// </summary>
    public unsafe float RunBehindDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// FloatProperty: TimePlayerCrouched
    /// </summary>
    public unsafe float TimePlayerCrouched
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// FloatProperty: TimePlayerStanding
    /// </summary>
    public unsafe float TimePlayerStanding
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// FloatProperty: TimeNeededForCrouchChange
    /// </summary>
    public unsafe float TimeNeededForCrouchChange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// IntProperty: KismetFails
    /// </summary>
    public unsafe int KismetFails
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// StructProperty: KismetGoal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 KismetGoal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1352);

    /// <summary>
    /// StructProperty: KismetGoalDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 KismetGoalDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1364);

    /// <summary>
    /// NameProperty: KismetStandName
    /// </summary>
    public unsafe BmSDK.FName KismetStandName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// NameProperty: KismetStandInName
    /// </summary>
    public unsafe BmSDK.FName KismetStandInName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// NameProperty: KismetStandOutName
    /// </summary>
    public unsafe BmSDK.FName KismetStandOutName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// FloatProperty: TimePlayerBehind
    /// </summary>
    public unsafe float TimePlayerBehind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// FloatProperty: TimeUntilLookBehind
    /// </summary>
    public unsafe float TimeUntilLookBehind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// FloatProperty: MinDistToLookBack
    /// </summary>
    public unsafe float MinDistToLookBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// FloatProperty: TimeLookingAtPlayer
    /// </summary>
    public unsafe float TimeLookingAtPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// FloatProperty: MaxTimeToWatchPlayer
    /// </summary>
    public unsafe float MaxTimeToWatchPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// FloatProperty: MaxLookAtDist
    /// </summary>
    public unsafe float MaxLookAtDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// FloatProperty: IdealPredVantagePointDistance
    /// </summary>
    public unsafe float IdealPredVantagePointDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// StructProperty: SavedJumpPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SavedJumpPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1428);

    /// <summary>
    /// StructProperty: SavedJumpDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SavedJumpDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1440);

    /// <summary>
    /// StructProperty: LastPawnLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastPawnLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1452);

    /// <summary>
    /// FloatProperty: PossessTime
    /// </summary>
    public unsafe float PossessTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// FloatProperty: PlayerInWayTimer
    /// </summary>
    public unsafe float PlayerInWayTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// IntProperty: NumOrderedTakedownsRemaining
    /// </summary>
    public unsafe int NumOrderedTakedownsRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }
}
