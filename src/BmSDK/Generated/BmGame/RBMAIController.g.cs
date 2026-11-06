#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMAIController<br/>
/// (size = 1508)
/// (flags = 144703634)
/// </summary>
public partial class RBMAIController : BmSDK.Engine.AIController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMAIController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMAIController.
    /// </summary>
    public static RBMAIController DefaultObject => (RBMAIController)StaticClass().DefaultObject;

    internal RBMAIController() { }

    /// <summary>
    /// Constructs a new RBMAIController
    /// </summary>
    public RBMAIController(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMAIController(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIController>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_RemoveForceTickIfCloseObject;
    /// <summary>
    /// Function: RemoveForceTickIfCloseObject
    /// </summary>
    public unsafe virtual void RemoveForceTickIfCloseObject(BmSDK.GameObject OldObject)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveForceTickIfCloseObject, "BmGame.RBMAIController.RemoveForceTickIfCloseObject");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddForceTickIfCloseObject;
    /// <summary>
    /// Function: AddForceTickIfCloseObject
    /// </summary>
    public unsafe virtual void AddForceTickIfCloseObject(BmSDK.GameObject NewObject, bool bSetInAIManager = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddForceTickIfCloseObject, "BmGame.RBMAIController.AddForceTickIfCloseObject");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewObject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetInAIManager, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldForceTickIfClose;
    /// <summary>
    /// Function: ShouldForceTickIfClose
    /// </summary>
    public unsafe virtual bool ShouldForceTickIfClose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceTickIfClose, "BmGame.RBMAIController.ShouldForceTickIfClose");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveForceTickObject;
    /// <summary>
    /// Function: RemoveForceTickObject
    /// </summary>
    public unsafe virtual void RemoveForceTickObject(BmSDK.GameObject OldObject)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveForceTickObject, "BmGame.RBMAIController.RemoveForceTickObject");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddForceTickObject;
    /// <summary>
    /// Function: AddForceTickObject
    /// </summary>
    public unsafe virtual void AddForceTickObject(BmSDK.GameObject NewObject, bool bSetInAIManager = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddForceTickObject, "BmGame.RBMAIController.AddForceTickObject");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewObject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetInAIManager, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldForceTick;
    /// <summary>
    /// Function: ShouldForceTick
    /// </summary>
    public unsafe virtual bool ShouldForceTick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceTick, "BmGame.RBMAIController.ShouldForceTick");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetUniqueIdentifier;
    /// <summary>
    /// Function: GetUniqueIdentifier
    /// </summary>
    public unsafe virtual BmSDK.FString GetUniqueIdentifier()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUniqueIdentifier, "BmGame.RBMAIController.GetUniqueIdentifier");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPairUp;
    /// <summary>
    /// Function: CanPairUp
    /// </summary>
    public unsafe virtual bool CanPairUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPairUp, "BmGame.RBMAIController.CanPairUp");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IdleConfigIsBlockingLowPriorityPred;
    /// <summary>
    /// Function: IdleConfigIsBlockingLowPriorityPred
    /// </summary>
    public unsafe virtual bool IdleConfigIsBlockingLowPriorityPred()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IdleConfigIsBlockingLowPriorityPred, "BmGame.RBMAIController.IdleConfigIsBlockingLowPriorityPred");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TakedownCancelled;
    /// <summary>
    /// Function: TakedownCancelled
    /// </summary>
    public unsafe virtual void TakedownCancelled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakedownCancelled, "BmGame.RBMAIController.TakedownCancelled");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPlacingMine;
    /// <summary>
    /// Function: IsPlacingMine
    /// </summary>
    public unsafe virtual bool IsPlacingMine()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlacingMine, "BmGame.RBMAIController.IsPlacingMine");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NotifyGunJamDiscovered;
    /// <summary>
    /// Function: NotifyGunJamDiscovered
    /// </summary>
    public unsafe virtual void NotifyGunJamDiscovered()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyGunJamDiscovered, "BmGame.RBMAIController.NotifyGunJamDiscovered");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsLockedUp;
    /// <summary>
    /// Function: IsLockedUp
    /// </summary>
    public unsafe virtual bool IsLockedUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLockedUp, "BmGame.RBMAIController.IsLockedUp");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPredThugInSmoke;
    /// <summary>
    /// Function: IsPredThugInSmoke
    /// </summary>
    public unsafe virtual bool IsPredThugInSmoke()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPredThugInSmoke, "BmGame.RBMAIController.IsPredThugInSmoke");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NotifyPathEdgeReached;
    /// <summary>
    /// Function: NotifyPathEdgeReached
    /// </summary>
    public unsafe virtual void NotifyPathEdgeReached(BmSDK.BmGame.RBMAIAction NotifyAction, BmSDK.BmGame.RNavigationHandle NotifyHandle, int EdgeID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPathEdgeReached, "BmGame.RBMAIController.NotifyPathEdgeReached");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyAction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyHandle, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EdgeID, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPathFound;
    /// <summary>
    /// Function: NotifyPathFound
    /// </summary>
    public unsafe virtual void NotifyPathFound(BmSDK.BmGame.RBMAIAction NotifyAction, BmSDK.BmGame.RNavigationHandle NotifyHandle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPathFound, "BmGame.RBMAIController.NotifyPathFound");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyAction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyHandle, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyEvent;
    /// <summary>
    /// Function: NotifyEvent
    /// </summary>
    public unsafe virtual void NotifyEvent(BmSDK.BmGame.RBMAIAction NotifyAction, BmSDK.FString EventType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyEvent, "BmGame.RBMAIController.NotifyEvent");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyAction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyFailed;
    /// <summary>
    /// Function: NotifyFailed
    /// </summary>
    public unsafe virtual void NotifyFailed(BmSDK.BmGame.RBMAIAction FinishedAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFailed, "BmGame.RBMAIController.NotifyFailed");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyStopped;
    /// <summary>
    /// Function: NotifyStopped
    /// </summary>
    public unsafe virtual void NotifyStopped(BmSDK.BmGame.RBMAIAction FinishedAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyStopped, "BmGame.RBMAIController.NotifyStopped");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyFinished;
    /// <summary>
    /// Function: NotifyFinished
    /// </summary>
    public unsafe virtual void NotifyFinished(BmSDK.BmGame.RBMAIAction FinishedAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFinished, "BmGame.RBMAIController.NotifyFinished");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SeenAnotherThug;
    /// <summary>
    /// Function: SeenAnotherThug
    /// </summary>
    public unsafe virtual void SeenAnotherThug(BmSDK.BmGame.RPawnVillain SeenPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SeenAnotherThug, "BmGame.RBMAIController.SeenAnotherThug");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SeenPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishGlance;
    /// <summary>
    /// Function: FinishGlance
    /// </summary>
    public unsafe virtual void FinishGlance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishGlance, "BmGame.RBMAIController.FinishGlance");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GlanceCurrentlyHandled;
    /// <summary>
    /// Function: GlanceCurrentlyHandled
    /// </summary>
    public unsafe virtual bool GlanceCurrentlyHandled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GlanceCurrentlyHandled, "BmGame.RBMAIController.GlanceCurrentlyHandled");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ApplyGlance;
    /// <summary>
    /// Function: ApplyGlance
    /// </summary>
    public unsafe virtual bool ApplyGlance(BmSDK.BmGame.AlertInstance GlanceTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyGlance, "BmGame.RBMAIController.ApplyGlance");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GlanceTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UpdateGlanceTarget;
    /// <summary>
    /// Function: UpdateGlanceTarget
    /// </summary>
    public unsafe virtual void UpdateGlanceTarget(BmSDK.BmGame.AlertInstance NewBestGlanceable)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGlanceTarget, "BmGame.RBMAIController.UpdateGlanceTarget");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBestGlanceable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnBumpedByPlayer;
    /// <summary>
    /// Function: PawnBumpedByPlayer
    /// </summary>
    public unsafe virtual void PawnBumpedByPlayer(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnBumpedByPlayer, "BmGame.RBMAIController.PawnBumpedByPlayer");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndPredator;
    /// <summary>
    /// Function: EndPredator
    /// </summary>
    public unsafe virtual void EndPredator()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndPredator, "BmGame.RBMAIController.EndPredator");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsClaimedBy;
    /// <summary>
    /// Function: IsClaimedBy
    /// </summary>
    public unsafe virtual bool IsClaimedBy(BmSDK.BmGame.RAlertEventCoordinatorBase TestCoord)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsClaimedBy, "BmGame.RBMAIController.IsClaimedBy");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestCoord, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SuccessfullyClaimedBy;
    /// <summary>
    /// Function: SuccessfullyClaimedBy
    /// </summary>
    public unsafe virtual bool SuccessfullyClaimedBy(BmSDK.BmGame.RAlertEventCoordinatorSolo NewCoord)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuccessfullyClaimedBy, "BmGame.RBMAIController.SuccessfullyClaimedBy");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCoord, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_HasCorrectTopLevelAECFor;
    /// <summary>
    /// Function: HasCorrectTopLevelAECFor
    /// </summary>
    public unsafe virtual bool HasCorrectTopLevelAECFor(BmSDK.BmGame.RAlertEventCoordinatorBase TestAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasCorrectTopLevelAECFor, "BmGame.RBMAIController.HasCorrectTopLevelAECFor");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsLitePredThug;
    /// <summary>
    /// Function: IsLitePredThug
    /// </summary>
    public unsafe virtual bool IsLitePredThug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLitePredThug, "BmGame.RBMAIController.IsLitePredThug");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NotifyGunEmpty;
    /// <summary>
    /// Function: NotifyGunEmpty
    /// </summary>
    public unsafe virtual void NotifyGunEmpty()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyGunEmpty, "BmGame.RBMAIController.NotifyGunEmpty");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetUpNotify;
    /// <summary>
    /// Function: GetUpNotify
    /// </summary>
    public unsafe virtual void GetUpNotify()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUpNotify, "BmGame.RBMAIController.GetUpNotify");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBeingTakenDown;
    /// <summary>
    /// Function: IsBeingTakenDown
    /// </summary>
    public unsafe virtual void IsBeingTakenDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBeingTakenDown, "BmGame.RBMAIController.IsBeingTakenDown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHangAttackScream;
    /// <summary>
    /// Function: PlayHangAttackScream
    /// </summary>
    public unsafe virtual void PlayHangAttackScream()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHangAttackScream, "BmGame.RBMAIController.PlayHangAttackScream");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBatmanGrab;
    /// <summary>
    /// Function: CanBatmanGrab
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIController.BatmanGrabType CanBatmanGrab()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBatmanGrab, "BmGame.RBMAIController.CanBatmanGrab");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController.BatmanGrabType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAlertState;
    /// <summary>
    /// Function: GetAlertState
    /// </summary>
    public unsafe virtual void GetAlertState(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAlertState, "BmGame.RBMAIController.GetAlertState");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_InformOfDroneExploding;
    /// <summary>
    /// Function: InformOfDroneExploding
    /// </summary>
    public unsafe virtual void InformOfDroneExploding()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InformOfDroneExploding, "BmGame.RBMAIController.InformOfDroneExploding");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BroadcastBatmanSpottedToSnipers;
    /// <summary>
    /// Function: BroadcastBatmanSpottedToSnipers
    /// </summary>
    public unsafe virtual void BroadcastBatmanSpottedToSnipers(BmSDK.Engine.Actor PlayerActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BroadcastBatmanSpottedToSnipers, "BmGame.RBMAIController.BroadcastBatmanSpottedToSnipers");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerActor, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_PredThugDisarmed;
    /// <summary>
    /// Function: PredThugDisarmed
    /// </summary>
    public unsafe virtual void PredThugDisarmed(bool bPostponeReaction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PredThugDisarmed, "BmGame.RBMAIController.PredThugDisarmed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPostponeReaction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupNoisyTakedownWithNoReaction;
    /// <summary>
    /// Function: SetupNoisyTakedownWithNoReaction
    /// </summary>
    public unsafe virtual void SetupNoisyTakedownWithNoReaction()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupNoisyTakedownWithNoReaction, "BmGame.RBMAIController.SetupNoisyTakedownWithNoReaction");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoNoisyTakedown;
    /// <summary>
    /// Function: DoNoisyTakedown
    /// </summary>
    public unsafe virtual void DoNoisyTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoNoisyTakedown, "BmGame.RBMAIController.DoNoisyTakedown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddAlert;
    /// <summary>
    /// Function: AddAlert
    /// </summary>
    public unsafe virtual void AddAlert(BmSDK.Engine.Actor NewActor, System.Numerics.Vector3 NewLocation, bool bAddIfNew = default, float BackDateTime = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddAlert, "BmGame.RBMAIController.AddAlert");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddIfNew, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BackDateTime, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveAlertActor;
    /// <summary>
    /// Function: RemoveAlertActor
    /// </summary>
    public unsafe virtual void RemoveAlertActor(BmSDK.Engine.Actor ExAlertActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAlertActor, "BmGame.RBMAIController.RemoveAlertActor");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExAlertActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddNewAlertActor;
    /// <summary>
    /// Function: AddNewAlertActor
    /// </summary>
    public unsafe virtual void AddNewAlertActor(BmSDK.Engine.Actor NewAlertActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddNewAlertActor, "BmGame.RBMAIController.AddNewAlertActor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAlertActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireDualPlayPawnSeenEvents;
    /// <summary>
    /// Function: FireDualPlayPawnSeenEvents
    /// </summary>
    public unsafe virtual void FireDualPlayPawnSeenEvents()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireDualPlayPawnSeenEvents, "BmGame.RBMAIController.FireDualPlayPawnSeenEvents");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireSeenEvents;
    /// <summary>
    /// Function: FireSeenEvents
    /// </summary>
    public unsafe virtual void FireSeenEvents()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireSeenEvents, "BmGame.RBMAIController.FireSeenEvents");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldIgnoreSilentPredator;
    /// <summary>
    /// Function: ShouldIgnoreSilentPredator
    /// </summary>
    public unsafe virtual bool ShouldIgnoreSilentPredator()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldIgnoreSilentPredator, "BmGame.RBMAIController.ShouldIgnoreSilentPredator");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RoomFearChanged;
    /// <summary>
    /// Function: RoomFearChanged
    /// </summary>
    public unsafe virtual void RoomFearChanged(BmSDK.BmGame.RBMRoomAIState.VillainFearLevel NewLevel)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RoomFearChanged, "BmGame.RBMAIController.RoomFearChanged");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAnimationFearLevel;
    /// <summary>
    /// Function: GetAnimationFearLevel
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMRoomAIState.VillainFearLevel GetAnimationFearLevel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimationFearLevel, "BmGame.RBMAIController.GetAnimationFearLevel");
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState.VillainFearLevel>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDialogueFearLevel;
    /// <summary>
    /// Function: GetDialogueFearLevel
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMRoomAIState.VillainFearLevel GetDialogueFearLevel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDialogueFearLevel, "BmGame.RBMAIController.GetDialogueFearLevel");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState.VillainFearLevel>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DrawViewCone;
    /// <summary>
    /// Function: DrawViewCone
    /// </summary>
    public unsafe virtual void DrawViewCone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawViewCone, "BmGame.RBMAIController.DrawViewCone");
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAIThoughts;
    /// <summary>
    /// Function: GetAIThoughts
    /// </summary>
    public unsafe virtual void GetAIThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAIThoughts, "BmGame.RBMAIController.GetAIThoughts");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddThought;
    /// <summary>
    /// Function: AddThought
    /// </summary>
    public unsafe virtual void AddThought(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList, BmSDK.FString ThoughtText, int R = default, int G = default, int B = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddThought, "BmGame.RBMAIController.AddThought");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThoughtText, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveFromAIManager;
    /// <summary>
    /// Function: RemoveFromAIManager
    /// </summary>
    public unsafe override void RemoveFromAIManager()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveFromAIManager, "BmGame.RBMAIController.RemoveFromAIManager");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessCarCollisionWarning;
    /// <summary>
    /// Function: ProcessCarCollisionWarning
    /// </summary>
    public unsafe virtual void ProcessCarCollisionWarning(BmSDK.Engine.Actor V, float Speed, BmSDK.BmGame.RGameInfo.EEvadeVehicleType EvadeType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessCarCollisionWarning, "BmGame.RBMAIController.ProcessCarCollisionWarning");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvadeType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanCheckFalling;
    /// <summary>
    /// Function: CanCheckFalling
    /// </summary>
    public unsafe virtual bool CanCheckFalling()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCheckFalling, "BmGame.RBMAIController.CanCheckFalling");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DodgeLineLaunchKick;
    /// <summary>
    /// Function: DodgeLineLaunchKick
    /// </summary>
    public unsafe virtual bool DodgeLineLaunchKick(BmSDK.BmGame.RPawnPlayer Attacker, System.Numerics.Vector3 KickDirection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DodgeLineLaunchKick, "BmGame.RBMAIController.DodgeLineLaunchKick");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KickDirection, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_DodgeDropAttack;
    /// <summary>
    /// Function: DodgeDropAttack
    /// </summary>
    public unsafe virtual bool DodgeDropAttack(BmSDK.BmGame.RPawnPlayer Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DodgeDropAttack, "BmGame.RBMAIController.DodgeDropAttack");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CheckDodgeProjectile;
    /// <summary>
    /// Function: CheckDodgeProjectile
    /// </summary>
    public unsafe virtual bool CheckDodgeProjectile(BmSDK.BmGame.RPawn Thrower, BmSDK.FName TargetBone, System.Numerics.Vector3 ProjPos, int BatarangID, bool bForceDodge = default, bool bSteerableProj = default, bool bDodgeAwayFromPosition = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckDodgeProjectile, "BmGame.RBMAIController.CheckDodgeProjectile");
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thrower, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBone, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjPos, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangID, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDodge, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSteerableProj, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDodgeAwayFromPosition, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_GetDodgeClass;
    /// <summary>
    /// Function: GetDodgeClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetDodgeClass()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDodgeClass, "BmGame.RBMAIController.GetDodgeClass");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDodgeProjectile;
    /// <summary>
    /// Function: CanDodgeProjectile
    /// </summary>
    public unsafe virtual bool CanDodgeProjectile(System.Numerics.Vector3 ThrownFromPos, int CheckBatarangID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDodgeProjectile, "BmGame.RBMAIController.CanDodgeProjectile");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckBatarangID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_BlockAttack;
    /// <summary>
    /// Function: BlockAttack
    /// </summary>
    public unsafe virtual void BlockAttack(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlockAttack, "BmGame.RBMAIController.BlockAttack");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrepareToBlockAttack;
    /// <summary>
    /// Function: PrepareToBlockAttack
    /// </summary>
    public unsafe virtual void PrepareToBlockAttack(BmSDK.BmGame.RPawnCombat Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepareToBlockAttack, "BmGame.RBMAIController.PrepareToBlockAttack");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RepelAttack;
    /// <summary>
    /// Function: RepelAttack
    /// </summary>
    public unsafe virtual void RepelAttack(BmSDK.BmGame.RPawnCombat Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RepelAttack, "BmGame.RBMAIController.RepelAttack");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RepelledAttacker;
    /// <summary>
    /// Function: RepelledAttacker
    /// </summary>
    public unsafe virtual void RepelledAttacker(BmSDK.BmGame.RPawnCombat Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RepelledAttacker, "BmGame.RBMAIController.RepelledAttacker");
        byte* paramsPtr = stackalloc byte[256];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleStickyGelHit;
    /// <summary>
    /// Function: HandleStickyGelHit
    /// </summary>
    public unsafe virtual bool HandleStickyGelHit(BmSDK.BmGame.RPawnPlayer Player, System.Numerics.Vector3 HitNormal, BmSDK.BmGame.RExplosiveGelBomb Proj = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleStickyGelHit, "BmGame.RBMAIController.HandleStickyGelHit");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proj, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_HandleFreezeVentHit;
    /// <summary>
    /// Function: HandleFreezeVentHit
    /// </summary>
    public unsafe virtual bool HandleFreezeVentHit(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleFreezeVentHit, "BmGame.RBMAIController.HandleFreezeVentHit");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_HandleFreezeClusterGrenadeHit;
    /// <summary>
    /// Function: HandleFreezeClusterGrenadeHit
    /// </summary>
    public unsafe virtual bool HandleFreezeClusterGrenadeHit(BmSDK.BmGame.RPawnPlayer Player, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleFreezeClusterGrenadeHit, "BmGame.RBMAIController.HandleFreezeClusterGrenadeHit");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_HandleFreezeBlastHit;
    /// <summary>
    /// Function: HandleFreezeBlastHit
    /// </summary>
    public unsafe virtual bool HandleFreezeBlastHit(BmSDK.BmGame.RPawnPlayer Player, System.Numerics.Vector3 HitNormal, BmSDK.BmGame.RFreezeSprayProjectile Proj = default, bool bInstantFreeze = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleFreezeBlastHit, "BmGame.RBMAIController.HandleFreezeBlastHit");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proj, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstantFreeze, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_TakeElectricityDamage;
    /// <summary>
    /// Function: TakeElectricityDamage
    /// </summary>
    public unsafe virtual void TakeElectricityDamage(System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor HitActor = default, bool bKill = default, BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeElectricityDamage, "BmGame.RBMAIController.TakeElectricityDamage");
        byte* paramsPtr = stackalloc byte[300];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitActor, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKill, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GoRagdoll;
    /// <summary>
    /// Function: GoRagdoll
    /// </summary>
    public unsafe virtual void GoRagdoll(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, BmSDK.BmGame.RGameInfo.RagdollStunType NewStunType = default, bool bKill = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoRagdoll, "BmGame.RBMAIController.GoRagdoll");
        byte* paramsPtr = stackalloc byte[292];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStunType, paramsPtr + 248);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKill, paramsPtr + 252);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsStunned;
    /// <summary>
    /// Function: IsStunned
    /// </summary>
    public unsafe virtual bool IsStunned()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStunned, "BmGame.RBMAIController.IsStunned");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetStunnedRagdoll;
    /// <summary>
    /// Function: SetStunnedRagdoll
    /// </summary>
    public unsafe virtual void SetStunnedRagdoll(bool bNewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStunnedRagdoll, "BmGame.RBMAIController.SetStunnedRagdoll");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Redirected;
    /// <summary>
    /// Function: Redirected
    /// </summary>
    public unsafe virtual void Redirected()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Redirected, "BmGame.RBMAIController.Redirected");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeHitInCombat;
    /// <summary>
    /// Function: CanBeHitInCombat
    /// </summary>
    public unsafe virtual bool CanBeHitInCombat(BmSDK.BmGame.RDamageType DamageType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeHitInCombat, "BmGame.RBMAIController.CanBeHitInCombat");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CombatMoveInitialised;
    /// <summary>
    /// Function: CombatMoveInitialised
    /// </summary>
    public unsafe virtual void CombatMoveInitialised(BmSDK.BmGame.RCombatMove NewMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatMoveInitialised, "BmGame.RBMAIController.CombatMoveInitialised");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCM;
    /// <summary>
    /// Function: GetCM
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatManager GetCM()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCM, "BmGame.RBMAIController.GetCM");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DemoteBehaviour;
    /// <summary>
    /// Function: DemoteBehaviour
    /// </summary>
    public unsafe virtual void DemoteBehaviour(BmSDK.BmGame.RBMBehaviour BehaviourToDemote)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DemoteBehaviour, "BmGame.RBMAIController.DemoteBehaviour");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourToDemote, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PromoteBehaviour;
    /// <summary>
    /// Function: PromoteBehaviour
    /// </summary>
    public unsafe virtual void PromoteBehaviour(BmSDK.BmGame.RBMBehaviour BehaviourToPromote)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PromoteBehaviour, "BmGame.RBMAIController.PromoteBehaviour");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourToPromote, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InstantExitBehaviour;
    /// <summary>
    /// Function: InstantExitBehaviour
    /// </summary>
    public unsafe virtual void InstantExitBehaviour(BmSDK.BmGame.RBMBehaviour BehaviourToExit, bool bCallEndInterrupt = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstantExitBehaviour, "BmGame.RBMAIController.InstantExitBehaviour");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourToExit, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCallEndInterrupt, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickBehaviour;
    /// <summary>
    /// Function: TickBehaviour
    /// </summary>
    public unsafe virtual void TickBehaviour(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickBehaviour, "BmGame.RBMAIController.TickBehaviour");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_GetTimeUntilFreeToAct;
    /// <summary>
    /// Function: GetTimeUntilFreeToAct
    /// </summary>
    public unsafe virtual float GetTimeUntilFreeToAct()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeUntilFreeToAct, "BmGame.RBMAIController.GetTimeUntilFreeToAct");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsWalkingTowards;
    /// <summary>
    /// Function: IsWalkingTowards
    /// </summary>
    public unsafe virtual bool IsWalkingTowards(System.Numerics.Vector3 TestPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWalkingTowards, "BmGame.RBMAIController.IsWalkingTowards");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PointIsValidLookatPos;
    /// <summary>
    /// Function: PointIsValidLookatPos
    /// </summary>
    public unsafe virtual bool PointIsValidLookatPos(System.Numerics.Vector3 TestPos, bool bDoTrace = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PointIsValidLookatPos, "BmGame.RBMAIController.PointIsValidLookatPos");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoTrace, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetDirectionOfFocus;
    /// <summary>
    /// Function: GetDirectionOfFocus
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDirectionOfFocus()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDirectionOfFocus, "BmGame.RBMAIController.GetDirectionOfFocus");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnDefaultBehaviour;
    /// <summary>
    /// Function: SpawnDefaultBehaviour
    /// </summary>
    public unsafe virtual void SpawnDefaultBehaviour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDefaultBehaviour, "BmGame.RBMAIController.SpawnDefaultBehaviour");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEntryAnim;
    /// <summary>
    /// Function: GetEntryAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetEntryAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEntryAnim, "BmGame.RBMAIController.GetEntryAnim");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEntryAnimSet;
    /// <summary>
    /// Function: GetEntryAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetEntryAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEntryAnimSet, "BmGame.RBMAIController.GetEntryAnimSet");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsValidBarkSpeaker;
    /// <summary>
    /// Function: IsValidBarkSpeaker
    /// </summary>
    public unsafe virtual bool IsValidBarkSpeaker()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidBarkSpeaker, "BmGame.RBMAIController.IsValidBarkSpeaker");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ProcessWeaponChange;
    /// <summary>
    /// Function: ProcessWeaponChange
    /// </summary>
    public unsafe virtual void ProcessWeaponChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessWeaponChange, "BmGame.RBMAIController.ProcessWeaponChange");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponChanged;
    /// <summary>
    /// Function: WeaponChanged
    /// </summary>
    public unsafe virtual void WeaponChanged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponChanged, "BmGame.RBMAIController.WeaponChanged");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldCombatantForceCombatCamera;
    /// <summary>
    /// Function: ShouldCombatantForceCombatCamera
    /// </summary>
    public unsafe virtual bool ShouldCombatantForceCombatCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldCombatantForceCombatCamera, "BmGame.RBMAIController.ShouldCombatantForceCombatCamera");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldCombatantLockDoors;
    /// <summary>
    /// Function: ShouldCombatantLockDoors
    /// </summary>
    public unsafe virtual bool ShouldCombatantLockDoors()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldCombatantLockDoors, "BmGame.RBMAIController.ShouldCombatantLockDoors");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearCombatBehaviour;
    /// <summary>
    /// Function: ClearCombatBehaviour
    /// </summary>
    public unsafe virtual void ClearCombatBehaviour(BmSDK.BmGame.RBMBehaviour_Combat CombatBehaviourToClear)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCombatBehaviour, "BmGame.RBMAIController.ClearCombatBehaviour");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatBehaviourToClear, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCombatBehaviour;
    /// <summary>
    /// Function: SetCombatBehaviour
    /// </summary>
    public unsafe virtual void SetCombatBehaviour(BmSDK.BmGame.RBMBehaviour_Combat NewCombatBehaviour)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCombatBehaviour, "BmGame.RBMAIController.SetCombatBehaviour");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCombatBehaviour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnCombatBehaviour;
    /// <summary>
    /// Function: SpawnCombatBehaviour
    /// </summary>
    public unsafe virtual void SpawnCombatBehaviour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnCombatBehaviour, "BmGame.RBMAIController.SpawnCombatBehaviour");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitCombat;
    /// <summary>
    /// Function: ExitCombat
    /// </summary>
    public unsafe virtual void ExitCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitCombat, "BmGame.RBMAIController.ExitCombat");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterCombat;
    /// <summary>
    /// Function: EnterCombat
    /// </summary>
    public unsafe virtual void EnterCombat(bool bCanReactFirst = default, bool bForceIntoCombat = default, bool bFearTakedownReaction = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterCombat, "BmGame.RBMAIController.EnterCombat");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanReactFirst, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceIntoCombat, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFearTakedownReaction, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayReactionWhileInCombat;
    /// <summary>
    /// Function: PlayReactionWhileInCombat
    /// </summary>
    public unsafe virtual void PlayReactionWhileInCombat(System.Numerics.Vector3 EventLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayReactionWhileInCombat, "BmGame.RBMAIController.PlayReactionWhileInCombat");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RioterShouldAvoidCombat;
    /// <summary>
    /// Function: RioterShouldAvoidCombat
    /// </summary>
    public unsafe virtual bool RioterShouldAvoidCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RioterShouldAvoidCombat, "BmGame.RBMAIController.RioterShouldAvoidCombat");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EnterCombatWithDefaults;
    /// <summary>
    /// Function: EnterCombatWithDefaults
    /// </summary>
    public unsafe virtual void EnterCombatWithDefaults()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterCombatWithDefaults, "BmGame.RBMAIController.EnterCombatWithDefaults");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DelayedEnterCombat;
    /// <summary>
    /// Function: DelayedEnterCombat
    /// </summary>
    public unsafe virtual void DelayedEnterCombat(float Delay)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DelayedEnterCombat, "BmGame.RBMAIController.DelayedEnterCombat");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayEnterCombatCue;
    /// <summary>
    /// Function: PlayEnterCombatCue
    /// </summary>
    public unsafe virtual void PlayEnterCombatCue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayEnterCombatCue, "BmGame.RBMAIController.PlayEnterCombatCue");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleNoise;
    /// <summary>
    /// Function: HandleNoise
    /// </summary>
    public unsafe virtual void HandleNoise(BmSDK.BmGame.RPawnPlayer PlayerInstigator)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleNoise, "BmGame.RBMAIController.HandleNoise");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerInstigator, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBehaviourCustomEyeLocation;
    /// <summary>
    /// Function: GetBehaviourCustomEyeLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetBehaviourCustomEyeLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBehaviourCustomEyeLocation, "BmGame.RBMAIController.GetBehaviourCustomEyeLocation");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AdjustAnimatedAimDir;
    /// <summary>
    /// Function: AdjustAnimatedAimDir
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 AdjustAnimatedAimDir(System.Numerics.Vector3 AnimatedDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustAnimatedAimDir, "BmGame.RBMAIController.AdjustAnimatedAimDir");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimatedDir, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_DoPlayerLookAt;
    /// <summary>
    /// Function: DoPlayerLookAt
    /// </summary>
    public unsafe virtual void DoPlayerLookAt(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoPlayerLookAt, "BmGame.RBMAIController.DoPlayerLookAt");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanLookAtPlayer;
    /// <summary>
    /// Function: CanLookAtPlayer
    /// </summary>
    public unsafe virtual bool CanLookAtPlayer(BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanLookAtPlayer, "BmGame.RBMAIController.CanLookAtPlayer");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UpdateNotVisibleAlert;
    /// <summary>
    /// Function: UpdateNotVisibleAlert
    /// </summary>
    public unsafe virtual void UpdateNotVisibleAlert(float DeltaTime, BmSDK.BmGame.AlertInstance A)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateNotVisibleAlert, "BmGame.RBMAIController.UpdateNotVisibleAlert");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_GetAlertText;
    /// <summary>
    /// Function: GetAlertText
    /// </summary>
    public unsafe virtual BmSDK.FString GetAlertText(BmSDK.BmGame.AlertInstance Al)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAlertText, "BmGame.RBMAIController.GetAlertText");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Al, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetLOSText;
    /// <summary>
    /// Function: GetLOSText
    /// </summary>
    public unsafe virtual bool GetLOSText(BmSDK.Engine.Actor TestActor, out BmSDK.FString LOSString, out byte R, out byte G, out byte B)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLOSText, "BmGame.RBMAIController.GetLOSText");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        LOSString = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 8);
        R = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 24);
        G = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 25);
        B = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 26);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_TriggerPawnActivatedEvent;
    /// <summary>
    /// Function: TriggerPawnActivatedEvent
    /// </summary>
    public unsafe virtual void TriggerPawnActivatedEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPawnActivatedEvent, "BmGame.RBMAIController.TriggerPawnActivatedEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerPawnEvent;
    /// <summary>
    /// Function: TriggerPawnEvent
    /// </summary>
    public unsafe virtual bool TriggerPawnEvent(BmSDK.Class EventClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPawnEvent, "BmGame.RBMAIController.TriggerPawnEvent");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_OutputBehaviourStack;
    /// <summary>
    /// Function: OutputBehaviourStack
    /// </summary>
    public unsafe virtual void OutputBehaviourStack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OutputBehaviourStack, "BmGame.RBMAIController.OutputBehaviourStack");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BehaviourStateChanged;
    /// <summary>
    /// Function: BehaviourStateChanged
    /// </summary>
    public unsafe virtual void BehaviourStateChanged(BmSDK.FName NewState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BehaviourStateChanged, "BmGame.RBMAIController.BehaviourStateChanged");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitConditionActivated;
    /// <summary>
    /// Function: ExitConditionActivated
    /// </summary>
    public unsafe virtual void ExitConditionActivated(BmSDK.FString ExitConditionString)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitConditionActivated, "BmGame.RBMAIController.ExitConditionActivated");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExitConditionString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddToBehaviourHistory;
    /// <summary>
    /// Function: AddToBehaviourHistory
    /// </summary>
    public unsafe virtual void AddToBehaviourHistory(BmSDK.FString BehaviourInfoString)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddToBehaviourHistory, "BmGame.RBMAIController.AddToBehaviourHistory");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourInfoString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBehaviourOfClass;
    /// <summary>
    /// Function: GetBehaviourOfClass
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMBehaviour GetBehaviourOfClass(BmSDK.Class TestClass, bool bExact = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBehaviourOfClass, "BmGame.RBMAIController.GetBehaviourOfClass");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bExact, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_HasBehaviourOfClass;
    /// <summary>
    /// Function: HasBehaviourOfClass
    /// </summary>
    public unsafe virtual bool HasBehaviourOfClass(BmSDK.Class TestClass, bool bExact = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasBehaviourOfClass, "BmGame.RBMAIController.HasBehaviourOfClass");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bExact, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsBehaviourActive;
    /// <summary>
    /// Function: IsBehaviourActive
    /// </summary>
    public unsafe virtual bool IsBehaviourActive(int Index = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBehaviourActive, "BmGame.RBMAIController.IsBehaviourActive");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RemoveBehaviourFromList;
    /// <summary>
    /// Function: RemoveBehaviourFromList
    /// </summary>
    public unsafe virtual void RemoveBehaviourFromList(BmSDK.BmGame.RBMBehaviour BehaviourToRemove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveBehaviourFromList, "BmGame.RBMAIController.RemoveBehaviourFromList");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourToRemove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFirstNonInterruptBehaviour;
    /// <summary>
    /// Function: GetFirstNonInterruptBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMBehaviour GetFirstNonInterruptBehaviour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFirstNonInterruptBehaviour, "BmGame.RBMAIController.GetFirstNonInterruptBehaviour");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLastBehaviour;
    /// <summary>
    /// Function: GetLastBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMBehaviour GetLastBehaviour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLastBehaviour, "BmGame.RBMAIController.GetLastBehaviour");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryClearSpecialMoves;
    /// <summary>
    /// Function: TryClearSpecialMoves
    /// </summary>
    public unsafe virtual void TryClearSpecialMoves()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryClearSpecialMoves, "BmGame.RBMAIController.TryClearSpecialMoves");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearSpawnedBehaviours;
    /// <summary>
    /// Function: ClearSpawnedBehaviours
    /// </summary>
    public unsafe virtual void ClearSpawnedBehaviours()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearSpawnedBehaviours, "BmGame.RBMAIController.ClearSpawnedBehaviours");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearBehavioursOfClass;
    /// <summary>
    /// Function: ClearBehavioursOfClass
    /// </summary>
    public unsafe virtual void ClearBehavioursOfClass(BmSDK.Class TestClass, bool bExact = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearBehavioursOfClass, "BmGame.RBMAIController.ClearBehavioursOfClass");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bExact, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearInterruptBehaviours;
    /// <summary>
    /// Function: ClearInterruptBehaviours
    /// </summary>
    public unsafe virtual void ClearInterruptBehaviours(bool bCallEndInterrupt = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearInterruptBehaviours, "BmGame.RBMAIController.ClearInterruptBehaviours");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCallEndInterrupt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearNonInterruptBehaviours;
    /// <summary>
    /// Function: ClearNonInterruptBehaviours
    /// </summary>
    public unsafe virtual void ClearNonInterruptBehaviours()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearNonInterruptBehaviours, "BmGame.RBMAIController.ClearNonInterruptBehaviours");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearBehaviourList;
    /// <summary>
    /// Function: ClearBehaviourList
    /// </summary>
    public unsafe virtual void ClearBehaviourList()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearBehaviourList, "BmGame.RBMAIController.ClearBehaviourList");
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_RemoveExitCondition;
    /// <summary>
    /// Function: RemoveExitCondition
    /// </summary>
    public unsafe virtual void RemoveExitCondition(BmSDK.BmGame.RBMExitCondition ToRemove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveExitCondition, "BmGame.RBMAIController.RemoveExitCondition");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToRemove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddExitCondition;
    /// <summary>
    /// Function: AddExitCondition
    /// </summary>
    public unsafe virtual void AddExitCondition(BmSDK.BmGame.RBMExitCondition NewExitCondition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddExitCondition, "BmGame.RBMAIController.AddExitCondition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewExitCondition, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnBehaviour;
    /// <summary>
    /// Function: SpawnBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMBehaviour SpawnBehaviour(BmSDK.Class BehaviourClass, BmSDK.BmGame.RBMBehaviour ParentBehaviour = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnBehaviour, "BmGame.RBMAIController.SpawnBehaviour");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParentBehaviour, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_NativeSpawnBehaviour;
    /// <summary>
    /// Function: NativeSpawnBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMBehaviour NativeSpawnBehaviour(BmSDK.Class BehaviourClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NativeSpawnBehaviour, "BmGame.RBMAIController.NativeSpawnBehaviour");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ActivateSpawnedBehaviour;
    /// <summary>
    /// Function: ActivateSpawnedBehaviour
    /// </summary>
    public unsafe virtual void ActivateSpawnedBehaviour(BmSDK.BmGame.RBMBehaviour SpawnedBehaviour)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateSpawnedBehaviour, "BmGame.RBMAIController.ActivateSpawnedBehaviour");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnedBehaviour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateSpawnedBehaviour;
    /// <summary>
    /// Function: CreateSpawnedBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMBehaviour CreateSpawnedBehaviour(BmSDK.Class BehaviourClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateSpawnedBehaviour, "BmGame.RBMAIController.CreateSpawnedBehaviour");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RegisterSpawnedBehaviour;
    /// <summary>
    /// Function: RegisterSpawnedBehaviour
    /// </summary>
    public unsafe virtual void RegisterSpawnedBehaviour(BmSDK.BmGame.RBMBehaviour NewBehaviour)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterSpawnedBehaviour, "BmGame.RBMAIController.RegisterSpawnedBehaviour");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBehaviour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PriorityIsGreaterThan;
    /// <summary>
    /// Function: PriorityIsGreaterThan
    /// </summary>
    public unsafe virtual bool PriorityIsGreaterThan(BmSDK.BmGame.RBMBehaviour BehA, BmSDK.BmGame.RBMBehaviour BehB)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PriorityIsGreaterThan, "BmGame.RBMAIController.PriorityIsGreaterThan");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehA, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehB, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_RegisterNewBehaviour;
    /// <summary>
    /// Function: RegisterNewBehaviour
    /// </summary>
    public unsafe virtual void RegisterNewBehaviour(BmSDK.BmGame.RBMBehaviour NewBehaviour, bool bInsertAtEnd = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterNewBehaviour, "BmGame.RBMAIController.RegisterNewBehaviour");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBehaviour, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInsertAtEnd, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleNewBehaviour;
    /// <summary>
    /// Function: HandleNewBehaviour
    /// </summary>
    public unsafe virtual void HandleNewBehaviour(BmSDK.BmGame.RBMBehaviour NewBehaviour)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleNewBehaviour, "BmGame.RBMAIController.HandleNewBehaviour");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBehaviour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CleanUpBeforeRemove;
    /// <summary>
    /// Function: CleanUpBeforeRemove
    /// </summary>
    public unsafe virtual void CleanUpBeforeRemove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanUpBeforeRemove, "BmGame.RBMAIController.CleanUpBeforeRemove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearFakeDeadBehaviours;
    /// <summary>
    /// Function: ClearFakeDeadBehaviours
    /// </summary>
    public unsafe virtual void ClearFakeDeadBehaviours()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFakeDeadBehaviours, "BmGame.RBMAIController.ClearFakeDeadBehaviours");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RBMAIController.Destroyed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnDied;
    /// <summary>
    /// Function: PawnDied
    /// </summary>
    public unsafe override void PawnDied(BmSDK.Engine.Pawn inPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnDied, "BmGame.RBMAIController.PawnDied");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnPossess;
    /// <summary>
    /// Function: UnPossess
    /// </summary>
    public unsafe override void UnPossess()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnPossess, "BmGame.RBMAIController.UnPossess");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RoomStateChanged;
    /// <summary>
    /// Function: RoomStateChanged
    /// </summary>
    public unsafe virtual void RoomStateChanged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RoomStateChanged, "BmGame.RBMAIController.RoomStateChanged");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe virtual void PostInitCharacter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmGame.RBMAIController.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReRegisterController;
    /// <summary>
    /// Function: ReRegisterController
    /// </summary>
    public unsafe virtual void ReRegisterController()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReRegisterController, "BmGame.RBMAIController.ReRegisterController");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Possess;
    /// <summary>
    /// Function: Possess
    /// </summary>
    public unsafe override void Possess(BmSDK.Engine.Pawn inPawn, bool bVehicleTransition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Possess, "BmGame.RBMAIController.Possess");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVehicleTransition, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickMe;
    /// <summary>
    /// Function: TickMe
    /// </summary>
    public unsafe virtual void TickMe()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickMe, "BmGame.RBMAIController.TickMe");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInBehaviourControlled;
    /// <summary>
    /// Function: IsInBehaviourControlled
    /// </summary>
    public unsafe virtual bool IsInBehaviourControlled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInBehaviourControlled, "BmGame.RBMAIController.IsInBehaviourControlled");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RBMAIController.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBatarangable;
    /// <summary>
    /// Function: IsBatarangable
    /// </summary>
    public unsafe virtual bool IsBatarangable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatarangable, "BmGame.RBMAIController.IsBatarangable");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDroneControlStanceName;
    /// <summary>
    /// Function: GetDroneControlStanceName
    /// </summary>
    public unsafe virtual BmSDK.FName GetDroneControlStanceName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDroneControlStanceName, "BmGame.RBMAIController.GetDroneControlStanceName");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetTickIsDisabled;
    /// <summary>
    /// Function: SetTickIsDisabled
    /// </summary>
    public unsafe override void SetTickIsDisabled(bool bInDisabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTickIsDisabled, "BmGame.RBMAIController.SetTickIsDisabled");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInDisabled, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_FindRailingForPoint;
    /// <summary>
    /// Function: FindRailingForPoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMPathNode_FenceJump FindRailingForPoint(System.Numerics.Vector3 LockPoint, out System.Numerics.Vector3 LockPosition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindRailingForPoint, "BmGame.RBMAIController.FindRailingForPoint");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LockPoint, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LockPosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPathNode_FenceJump>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CalcVisibilityFor;
    /// <summary>
    /// Function: CalcVisibilityFor
    /// </summary>
    public unsafe virtual BmSDK.BmGame.AlertInstance.VisibilityCategory CalcVisibilityFor(BmSDK.Engine.Actor A, System.Numerics.Vector3 Checkpoint = default, float CanSeePercent = default, System.Numerics.Vector3 LookDir = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalcVisibilityFor, "BmGame.RBMAIController.CalcVisibilityFor");
        byte* paramsPtr = stackalloc byte[37];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Checkpoint, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanSeePercent, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookDir, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.AlertInstance.VisibilityCategory>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_FindAlertFor;
    /// <summary>
    /// Function: FindAlertFor
    /// </summary>
    public unsafe virtual BmSDK.BmGame.AlertInstance FindAlertFor(BmSDK.Engine.Actor A)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAlertFor, "BmGame.RBMAIController.FindAlertFor");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.AlertInstance>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindAlertForPlayer;
    /// <summary>
    /// Function: FindAlertForPlayer
    /// </summary>
    public unsafe virtual BmSDK.BmGame.AlertInstance FindAlertForPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAlertForPlayer, "BmGame.RBMAIController.FindAlertForPlayer");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.AlertInstance>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PawnIsChunkyTick;
    /// <summary>
    /// Function: PawnIsChunkyTick
    /// </summary>
    public unsafe virtual bool PawnIsChunkyTick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnIsChunkyTick, "BmGame.RBMAIController.PawnIsChunkyTick");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PawnInStasis;
    /// <summary>
    /// Function: PawnInStasis
    /// </summary>
    public unsafe virtual bool PawnInStasis()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnInStasis, "BmGame.RBMAIController.PawnInStasis");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShutDownBehaviour;
    /// <summary>
    /// Function: ShutDownBehaviour
    /// </summary>
    public unsafe virtual void ShutDownBehaviour(BmSDK.BmGame.RBMBehaviour BehaviourToExit, bool bCallEndInterrupt = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShutDownBehaviour, "BmGame.RBMAIController.ShutDownBehaviour");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourToExit, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCallEndInterrupt, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_TickBehaviourState;
    /// <summary>
    /// Function: TickBehaviourState
    /// </summary>
    public unsafe virtual void TickBehaviourState(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickBehaviourState, "BmGame.RBMAIController.TickBehaviourState");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_GetAIManager;
    /// <summary>
    /// Function: GetAIManager
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIManager GetAIManager()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAIManager, "BmGame.RBMAIController.GetAIManager");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIManager>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DoFaceFXForFear;
    /// <summary>
    /// Function: DoFaceFXForFear
    /// </summary>
    public unsafe virtual void DoFaceFXForFear()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoFaceFXForFear, "BmGame.RBMAIController.DoFaceFXForFear");
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_GetSilentPredatorGlanceStanceName;
    /// <summary>
    /// Function: GetSilentPredatorGlanceStanceName
    /// </summary>
    public unsafe virtual BmSDK.FName GetSilentPredatorGlanceStanceName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSilentPredatorGlanceStanceName, "BmGame.RBMAIController.GetSilentPredatorGlanceStanceName");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSilentPredatorStanceName;
    /// <summary>
    /// Function: GetSilentPredatorStanceName
    /// </summary>
    public unsafe virtual BmSDK.FName GetSilentPredatorStanceName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSilentPredatorStanceName, "BmGame.RBMAIController.GetSilentPredatorStanceName");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ProcessSpottedNotifies;
    /// <summary>
    /// Function: ProcessSpottedNotifies
    /// </summary>
    public unsafe virtual void ProcessSpottedNotifies()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessSpottedNotifies, "BmGame.RBMAIController.ProcessSpottedNotifies");
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_ProcessSpottableAlerts;
    /// <summary>
    /// Function: ProcessSpottableAlerts
    /// </summary>
    public unsafe virtual void ProcessSpottableAlerts(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessSpottableAlerts, "BmGame.RBMAIController.ProcessSpottableAlerts");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_GetVisionCheckEyeLoc;
    /// <summary>
    /// Function: GetVisionCheckEyeLoc
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetVisionCheckEyeLoc()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVisionCheckEyeLoc, "BmGame.RBMAIController.GetVisionCheckEyeLoc");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetViewDir;
    /// <summary>
    /// Function: GetViewDir
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetViewDir(bool bFixUpAnimAimDir = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetViewDir, "BmGame.RBMAIController.GetViewDir");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFixUpAnimAimDir, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsPointInFOVWithLookDir;
    /// <summary>
    /// Function: IsPointInFOVWithLookDir
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIController.FOVcategory IsPointInFOVWithLookDir(System.Numerics.Vector3 TestPos, System.Numerics.Vector3 LookDir, bool bUseActualAimDirForCloseCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPointInFOVWithLookDir, "BmGame.RBMAIController.IsPointInFOVWithLookDir");
        byte* paramsPtr = stackalloc byte[29];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseActualAimDirForCloseCheck, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController.FOVcategory>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_IsPointInFOV;
    /// <summary>
    /// Function: IsPointInFOV
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIController.FOVcategory IsPointInFOV(System.Numerics.Vector3 TestPos, bool bFixUpAnimAimDir = default, bool bUseActualAimDirForCloseCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPointInFOV, "BmGame.RBMAIController.IsPointInFOV");
        byte* paramsPtr = stackalloc byte[21];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFixUpAnimAimDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseActualAimDirForCloseCheck, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController.FOVcategory>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_IsInFOV;
    /// <summary>
    /// Function: IsInFOV
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIController.FOVcategory IsInFOV(BmSDK.Engine.Actor TestActor, bool bFixUpAnimAimDir = default, bool bUseActualAimDirForCloseCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInFOV, "BmGame.RBMAIController.IsInFOV");
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFixUpAnimAimDir, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseActualAimDirForCloseCheck, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController.FOVcategory>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsRunningBehaviour;
    /// <summary>
    /// Function: IsRunningBehaviour
    /// </summary>
    public unsafe virtual bool IsRunningBehaviour(BmSDK.BmGame.RBMBehaviour TestBehaviour)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRunningBehaviour, "BmGame.RBMAIController.IsRunningBehaviour");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestBehaviour, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetBehaviour;
    /// <summary>
    /// Function: GetBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMBehaviour GetBehaviour(int Index = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBehaviour, "BmGame.RBMAIController.GetBehaviour");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(paramsPtr + 4);
    }

    /// <summary>
    /// Enum: CasualtyScreamReason
    /// </summary>
    public enum CasualtyScreamReason : byte
    {
        CSR_Generic = 0,
        CSR_Fell = 1,
        CSR_WallExplode = 2,
        CSR_ThroughWall = 3,
        CSR_FromGrate = 4,
        CSR_Shocked = 5,
        CSR_MAX = 6,
    }

    /// <summary>
    /// Enum: BRAECReactionType
    /// </summary>
    public enum BRAECReactionType : byte
    {
        BRAEC_Batarang = 0,
        BRAEC_SteerableBatarang = 1,
        BRAEC_BreakingGlass = 2,
        BRAEC_Generator = 3,
        BRAEC_DualHandguns = 4,
        BRAEC_MAX = 5,
    }

    /// <summary>
    /// Enum: FOVcategory
    /// </summary>
    public enum FOVcategory : byte
    {
        FOV_None = 0,
        FOV_Peripheral = 1,
        FOV_Central = 2,
        FOV_MAX = 3,
    }

    /// <summary>
    /// Enum: BatmanGrabType
    /// </summary>
    public enum BatmanGrabType : byte
    {
        BGT_NoGrab = 0,
        BGT_Grab = 1,
        BGT_FailedGrab = 2,
        BGT_MAX = 3,
    }

    /// <summary>
    /// Enum: PoseMirroredBehaviour
    /// </summary>
    public enum PoseMirroredBehaviour : byte
    {
        PMB_DontCare = 0,
        PMB_NotMirrored = 1,
        PMB_Mirrored = 2,
        PMB_MAX = 3,
    }

    /// <summary>
    /// ObjectProperty: PawnAI
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI PawnAI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ObjectProperty: PawnVillain
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain PawnVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ObjectProperty: CombatBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour_Combat CombatBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_Combat>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// ObjectProperty: StoredIdleConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour StoredIdleConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// ObjectProperty: InterruptingBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour InterruptingBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ObjectProperty: RiotBrain
    /// </summary>
    public unsafe BmSDK.BmGame.RRiotBrain RiotBrain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRiotBrain>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// ObjectProperty: RiotVolume
    /// </summary>
    public unsafe BmSDK.BmGame.ROverworldPopulationVolume RiotVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.ROverworldPopulationVolume>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// ObjectProperty: SpecialWatchVPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint SpecialWatchVPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// ObjectProperty: PredQueue
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour_ActionQueue PredQueue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_ActionQueue>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// ObjectProperty: CurrentEvent
    /// </summary>
    public unsafe BmSDK.BmGame.RAlertEventCoordinatorSolo CurrentEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlertEventCoordinatorSolo>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// ObjectProperty: AIManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIManager AIManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIManager>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// ObjectProperty: Brain
    /// </summary>
    public unsafe BmSDK.BmGame.RAIBrain Brain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAIBrain>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// ObjectProperty: objectSuppressingReceiveSoftPawnCollision
    /// </summary>
    public unsafe BmSDK.GameObject objectSuppressingReceiveSoftPawnCollision
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// ClassProperty: DefaultFleeBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class DefaultFleeBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// ClassProperty: DefaultBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class DefaultBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// ArrayProperty: BehaviourList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMBehaviour> BehaviourList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMBehaviour>>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// ArrayProperty: ExitConditionList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMExitCondition> ExitConditionList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMExitCondition>>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// BoolProperty: bDeactivatingBehaviour
    /// </summary>
    public unsafe bool bDeactivatingBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bRegistered
    /// </summary>
    public unsafe bool bRegistered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bHasHadBehaviour
    /// </summary>
    public unsafe bool bHasHadBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bInCombat
    /// </summary>
    public unsafe bool bInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bWeaponChanged
    /// </summary>
    public unsafe bool bWeaponChanged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bHadCombatBehaviour
    /// </summary>
    public unsafe bool bHadCombatBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bEverBeenInCombat
    /// </summary>
    public unsafe bool bEverBeenInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bUseCombatAreas
    /// </summary>
    public unsafe bool bUseCombatAreas
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bStoreIdleConfig
    /// </summary>
    public unsafe bool bStoreIdleConfig
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bCachedSeenSeqEvents
    /// </summary>
    public unsafe bool bCachedSeenSeqEvents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bCachedDualPlayPawnSeenSeqEvents
    /// </summary>
    public unsafe bool bCachedDualPlayPawnSeenSeqEvents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bPlayedEnterCombatSound
    /// </summary>
    public unsafe bool bPlayedEnterCombatSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bBehaviourControlledTick
    /// </summary>
    public unsafe bool bBehaviourControlledTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bCachedIsStunned
    /// </summary>
    public unsafe bool bCachedIsStunned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bInShouldAvoidCombat
    /// </summary>
    public unsafe bool bInShouldAvoidCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bVisionIsBlocked
    /// </summary>
    public unsafe bool bVisionIsBlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bStunnedRagdoll
    /// </summary>
    public unsafe bool bStunnedRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bLookedAtPlayer
    /// </summary>
    public unsafe bool bLookedAtPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bUseHeadBoneAsViewDir
    /// </summary>
    public unsafe bool bUseHeadBoneAsViewDir
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bForceShortenPathCheck
    /// </summary>
    public unsafe bool bForceShortenPathCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bHasSeenBMDuringAlert
    /// </summary>
    public unsafe bool bHasSeenBMDuringAlert
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bBehaviourCustomEyeLocation
    /// </summary>
    public unsafe bool bBehaviourCustomEyeLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bBumpedLastPawnMoveTick
    /// </summary>
    public unsafe bool bBumpedLastPawnMoveTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bHaveCachedAnimatedAimDir
    /// </summary>
    public unsafe bool bHaveCachedAnimatedAimDir
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bBehaviourIsRunningAEC
    /// </summary>
    public unsafe bool bBehaviourIsRunningAEC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bIsInsideApplyGlance
    /// </summary>
    public unsafe bool bIsInsideApplyGlance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// IntProperty: TriggerActivationEventFrames
    /// </summary>
    public unsafe int TriggerActivationEventFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// ArrayProperty: SeenSeqEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceObject> SeenSeqEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceObject>>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceActivatedSeenEvents
    /// </summary>
    public unsafe float TimeSinceActivatedSeenEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// ArrayProperty: DualPlayPawnSeenSeqEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceObject> DualPlayPawnSeenSeqEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceObject>>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceActivatedDualPlayPawnSeenEvents
    /// </summary>
    public unsafe float TimeSinceActivatedDualPlayPawnSeenEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// FloatProperty: SuspectLimit
    /// </summary>
    public unsafe float SuspectLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// FloatProperty: SpottedLimit
    /// </summary>
    public unsafe float SpottedLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// FloatProperty: MinCanSeePercent
    /// </summary>
    public unsafe float MinCanSeePercent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// FloatProperty: SimpleFOVCheckRange
    /// </summary>
    public unsafe float SimpleFOVCheckRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// FloatProperty: Attack360AwarenessRange
    /// </summary>
    public unsafe float Attack360AwarenessRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// ArrayProperty: CurrentAlert
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.AlertInstance> CurrentAlert
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.AlertInstance>>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// ArrayProperty: NeighbourList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIController> NeighbourList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIController>>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// FloatProperty: LookAtPlayerTime
    /// </summary>
    public unsafe float LookAtPlayerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// FloatProperty: LookAtPlayerDistance
    /// </summary>
    public unsafe float LookAtPlayerDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// FloatProperty: LastSearchInvestigateMoveTime
    /// </summary>
    public unsafe float LastSearchInvestigateMoveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// NameProperty: HeadBone
    /// </summary>
    public unsafe BmSDK.FName HeadBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// NameProperty: NervousIdleVariantName
    /// </summary>
    public unsafe BmSDK.FName NervousIdleVariantName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// NameProperty: NoStateName
    /// </summary>
    public unsafe BmSDK.FName NoStateName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// FloatProperty: BumpedTimer
    /// </summary>
    public unsafe float BumpedTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// StructProperty: CachedAnimatedAimDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CachedAnimatedAimDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1436);

    /// <summary>
    /// FloatProperty: LastCheckUnconsciousThugTime
    /// </summary>
    public unsafe float LastCheckUnconsciousThugTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// StrProperty: sUniqueAIIdentifier
    /// </summary>
    public unsafe BmSDK.FString sUniqueAIIdentifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// ArrayProperty: ForceTickObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> ForceTickObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// ArrayProperty: ForceTickIfCloseObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> ForceTickIfCloseObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// NameProperty: PawnName
    /// </summary>
    public unsafe BmSDK.FName PawnName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }
}
