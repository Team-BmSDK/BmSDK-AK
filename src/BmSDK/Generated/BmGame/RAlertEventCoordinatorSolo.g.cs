#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RAlertEventCoordinatorSolo<br/>
/// (size = 696)
/// (flags = 144703635)
/// </summary>
public partial class RAlertEventCoordinatorSolo : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAlertEventCoordinatorSolo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAlertEventCoordinatorSolo.
    /// </summary>
    public static RAlertEventCoordinatorSolo DefaultObject => (RAlertEventCoordinatorSolo)StaticClass().DefaultObject;

    internal RAlertEventCoordinatorSolo() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAlertEventCoordinatorSolo(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAlertEventCoordinatorSolo>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAlertEventCoordinatorSolo>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAlertEventCoordinatorSolo>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAlertEventCoordinatorSolo>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAlertEventCoordinatorSolo>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAlertEventCoordinatorSolo>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAlertEventCoordinatorSolo>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAlertEventCoordinatorSolo>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnBeginShutdown;
    /// <summary>
    /// Function: OnBeginShutdown
    /// </summary>
    public unsafe virtual void OnBeginShutdown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBeginShutdown, "BmGame.RAlertEventCoordinatorSolo.OnBeginShutdown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawVis;
    /// <summary>
    /// Function: DrawVis
    /// </summary>
    public unsafe virtual void DrawVis()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawVis, "BmGame.RAlertEventCoordinatorSolo.DrawVis");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAIThoughts;
    /// <summary>
    /// Function: GetAIThoughts
    /// </summary>
    public unsafe virtual void GetAIThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAIThoughts, "BmGame.RAlertEventCoordinatorSolo.GetAIThoughts");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_BeginShutdown;
    /// <summary>
    /// Function: BeginShutdown
    /// </summary>
    public unsafe virtual void BeginShutdown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginShutdown, "BmGame.RAlertEventCoordinatorSolo.BeginShutdown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugHitByStrike;
    /// <summary>
    /// Function: ThugHitByStrike
    /// </summary>
    public unsafe virtual void ThugHitByStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugHitByStrike, "BmGame.RAlertEventCoordinatorSolo.ThugHitByStrike");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanDodgeProjectile;
    /// <summary>
    /// Function: CanDodgeProjectile
    /// </summary>
    public unsafe virtual bool CanDodgeProjectile(System.Numerics.Vector3 ThrownFromPos, int CheckBatarangID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDodgeProjectile, "BmGame.RAlertEventCoordinatorSolo.CanDodgeProjectile");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckBatarangID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_WantsToGlanceAt;
    /// <summary>
    /// Function: WantsToGlanceAt
    /// </summary>
    public unsafe virtual bool WantsToGlanceAt(BmSDK.Engine.Actor TestTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WantsToGlanceAt, "BmGame.RAlertEventCoordinatorSolo.WantsToGlanceAt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_NotifyGunEmpty;
    /// <summary>
    /// Function: NotifyGunEmpty
    /// </summary>
    public unsafe virtual void NotifyGunEmpty()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyGunEmpty, "BmGame.RAlertEventCoordinatorSolo.NotifyGunEmpty");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPathEdgeReached;
    /// <summary>
    /// Function: NotifyPathEdgeReached
    /// </summary>
    public unsafe virtual void NotifyPathEdgeReached(BmSDK.BmGame.RBMAIAction NotifyAction, BmSDK.BmGame.RNavigationHandle NotifyHandle, int EdgeID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPathEdgeReached, "BmGame.RAlertEventCoordinatorSolo.NotifyPathEdgeReached");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPathFound, "BmGame.RAlertEventCoordinatorSolo.NotifyPathFound");
        byte* paramsPtr = stackalloc byte[16];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyEvent, "BmGame.RAlertEventCoordinatorSolo.NotifyEvent");
        byte* paramsPtr = stackalloc byte[24];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFailed, "BmGame.RAlertEventCoordinatorSolo.NotifyFailed");
        byte* paramsPtr = stackalloc byte[8];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyStopped, "BmGame.RAlertEventCoordinatorSolo.NotifyStopped");
        byte* paramsPtr = stackalloc byte[8];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFinished, "BmGame.RAlertEventCoordinatorSolo.NotifyFinished");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnVillainStolen;
    /// <summary>
    /// Function: OnVillainStolen
    /// </summary>
    public unsafe virtual void OnVillainStolen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnVillainStolen, "BmGame.RAlertEventCoordinatorSolo.OnVillainStolen");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VillainStolen;
    /// <summary>
    /// Function: VillainStolen
    /// </summary>
    public unsafe virtual void VillainStolen(BmSDK.BmGame.RBMAIController Stolen, BmSDK.BmGame.RAlertEventCoordinatorSolo StealingAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VillainStolen, "BmGame.RAlertEventCoordinatorSolo.VillainStolen");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stolen, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StealingAEC, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignToEvent;
    /// <summary>
    /// Function: AssignToEvent
    /// </summary>
    public unsafe virtual void AssignToEvent(BmSDK.BmGame.RBMAIController Con)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignToEvent, "BmGame.RAlertEventCoordinatorSolo.AssignToEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Con, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnStartChild;
    /// <summary>
    /// Function: OnStartChild
    /// </summary>
    public unsafe virtual void OnStartChild()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnStartChild, "BmGame.RAlertEventCoordinatorSolo.OnStartChild");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartChild;
    /// <summary>
    /// Function: StartChild
    /// </summary>
    public unsafe virtual bool StartChild(BmSDK.BmGame.RBMAIController NewCon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartChild, "BmGame.RAlertEventCoordinatorSolo.StartChild");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetParent;
    /// <summary>
    /// Function: SetParent
    /// </summary>
    public unsafe virtual void SetParent(BmSDK.BmGame.RAlertEventCoordinatorBase NewParent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetParent, "BmGame.RAlertEventCoordinatorSolo.SetParent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewParent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProjectPointOntoPlane;
    /// <summary>
    /// Function: ProjectPointOntoPlane
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 ProjectPointOntoPlane(out System.Numerics.Vector3 rPlaneNormal, out System.Numerics.Vector3 rPointOnPlane, out System.Numerics.Vector3 rPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProjectPointOntoPlane, "BmGame.RAlertEventCoordinatorSolo.ProjectPointOntoPlane");
        byte* paramsPtr = stackalloc byte[48];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out rPlaneNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rPlaneNormal, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out rPointOnPlane);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rPointOnPlane, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out rPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rPoint, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        rPlaneNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        rPointOnPlane = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        rPoint = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetParentOfClass;
    /// <summary>
    /// Function: GetParentOfClass
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAlertEventCoordinatorBase GetParentOfClass(BmSDK.Class TestClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetParentOfClass, "BmGame.RAlertEventCoordinatorSolo.GetParentOfClass");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestClass, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAlertEventCoordinatorBase>(paramsPtr + 8);
    }

    /// <summary>
    /// ObjectProperty: HostCon
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController HostCon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: Parent
    /// </summary>
    public unsafe BmSDK.BmGame.RAlertEventCoordinatorBase Parent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlertEventCoordinatorBase>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ComponentProperty: RoomState
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState RoomState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// BoolProperty: bExpandDebug
    /// </summary>
    public unsafe bool bExpandDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bExtraAware
    /// </summary>
    public unsafe bool bExtraAware
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bAllowApproximateVisionChecks
    /// </summary>
    public unsafe bool bAllowApproximateVisionChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bCanSeePlayerOverEdge
    /// </summary>
    public unsafe bool bCanSeePlayerOverEdge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bCanSeePlayerThroughPartialObstruction
    /// </summary>
    public unsafe bool bCanSeePlayerThroughPartialObstruction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bFiresPlayerSeenKismet
    /// </summary>
    public unsafe bool bFiresPlayerSeenKismet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bVisionCheckSmokeFailFudge
    /// </summary>
    public unsafe bool bVisionCheckSmokeFailFudge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bCanStasis
    /// </summary>
    public unsafe bool bCanStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bBeginShutdownCalled
    /// </summary>
    public unsafe bool bBeginShutdownCalled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }
}
