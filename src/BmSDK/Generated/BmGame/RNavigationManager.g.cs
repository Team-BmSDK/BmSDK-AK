#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RNavigationManager<br/>
/// (size = 504)
/// (flags = 134217874)
/// </summary>
public partial class RNavigationManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RNavigationManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RNavigationManager.
    /// </summary>
    public static RNavigationManager DefaultObject => (RNavigationManager)StaticClass().DefaultObject;

    internal RNavigationManager() { }

    /// <summary>
    /// Constructs a new RNavigationManager
    /// </summary>
    public RNavigationManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RNavigationManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RNavigationManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavigationManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavigationManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavigationManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavigationManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavigationManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavigationManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavigationManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavigationManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_NavManWTF;
    /// <summary>
    /// Function: NavManWTF
    /// </summary>
    public unsafe virtual void NavManWTF()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavManWTF, "BmGame.RNavigationManager.NavManWTF");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe virtual void DrawHUD(BmSDK.Engine.Canvas Canvas)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmGame.RNavigationManager.DrawHUD");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSearchDestination;
    /// <summary>
    /// Function: GetSearchDestination
    /// </summary>
    public unsafe virtual bool GetSearchDestination(System.Numerics.Vector3 StartPos, BmSDK.Engine.Volume RestrictToVol, out System.Numerics.Vector3 SearchPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSearchDestination, "BmGame.RNavigationManager.GetSearchDestination");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RestrictToVol, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SearchPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchPos, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SearchPos = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetNavMeshLocationFromRailingPoints;
    /// <summary>
    /// Function: GetNavMeshLocationFromRailingPoints
    /// </summary>
    public unsafe virtual bool GetNavMeshLocationFromRailingPoints(System.Numerics.Vector3 CurrLocation, System.Numerics.Vector3 PointA, System.Numerics.Vector3 PointB, out System.Numerics.Vector3 NavMeshLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNavMeshLocationFromRailingPoints, "BmGame.RNavigationManager.GetNavMeshLocationFromRailingPoints");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointA, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointB, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NavMeshLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavMeshLocation, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NavMeshLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_NavHandleTrace;
    /// <summary>
    /// Function: NavHandleTrace
    /// </summary>
    public unsafe virtual bool NavHandleTrace(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, System.Numerics.Vector3 Extent, out System.Numerics.Vector3 HitLoc, out System.Numerics.Vector3 HitNorm)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavHandleTrace, "BmGame.RNavigationManager.NavHandleTrace");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNorm);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNorm, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
        HitNorm = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 48);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_NavHandlePointReachable;
    /// <summary>
    /// Function: NavHandlePointReachable
    /// </summary>
    public unsafe virtual bool NavHandlePointReachable(System.Numerics.Vector3 EndLoc, System.Numerics.Vector3 StartLoc, System.Numerics.Vector3 Extent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavHandlePointReachable, "BmGame.RNavigationManager.NavHandlePointReachable");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLoc, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_UpdatePendingGroupAssignmentPickerList;
    /// <summary>
    /// Function: UpdatePendingGroupAssignmentPickerList
    /// </summary>
    public unsafe virtual void UpdatePendingGroupAssignmentPickerList()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePendingGroupAssignmentPickerList, "BmGame.RNavigationManager.UpdatePendingGroupAssignmentPickerList");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPendingGroupAssignmentPicker;
    /// <summary>
    /// Function: AddPendingGroupAssignmentPicker
    /// </summary>
    public unsafe virtual void AddPendingGroupAssignmentPicker(BmSDK.BmGame.RGroupAssignmentPicker NewGMAP)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPendingGroupAssignmentPicker, "BmGame.RNavigationManager.AddPendingGroupAssignmentPicker");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGMAP, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessTraceCheckVertsQueries;
    /// <summary>
    /// Function: ProcessTraceCheckVertsQueries
    /// </summary>
    public unsafe virtual void ProcessTraceCheckVertsQueries()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessTraceCheckVertsQueries, "BmGame.RNavigationManager.ProcessTraceCheckVertsQueries");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveProcessTraceCheckVertsQuery;
    /// <summary>
    /// Function: RemoveProcessTraceCheckVertsQuery
    /// </summary>
    public unsafe virtual void RemoveProcessTraceCheckVertsQuery(BmSDK.BmGame.RBMAIAction_PauseCheckVerts OldQuery)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveProcessTraceCheckVertsQuery, "BmGame.RNavigationManager.RemoveProcessTraceCheckVertsQuery");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldQuery, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddProcessTraceCheckVertsQuery;
    /// <summary>
    /// Function: AddProcessTraceCheckVertsQuery
    /// </summary>
    public unsafe virtual void AddProcessTraceCheckVertsQuery(BmSDK.BmGame.RBMAIAction_PauseCheckVerts NewQuery)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddProcessTraceCheckVertsQuery, "BmGame.RNavigationManager.AddProcessTraceCheckVertsQuery");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewQuery, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveAttackEdgeSearch;
    /// <summary>
    /// Function: RemoveAttackEdgeSearch
    /// </summary>
    public unsafe virtual void RemoveAttackEdgeSearch(BmSDK.BmGame.RAttackEdgeSearch OldSearch)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAttackEdgeSearch, "BmGame.RNavigationManager.RemoveAttackEdgeSearch");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldSearch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddAttackEdgeSearch;
    /// <summary>
    /// Function: AddAttackEdgeSearch
    /// </summary>
    public unsafe virtual void AddAttackEdgeSearch(BmSDK.BmGame.RAttackEdgeSearch NewSearch)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddAttackEdgeSearch, "BmGame.RNavigationManager.AddAttackEdgeSearch");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSearch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAttackEdgeSearch;
    /// <summary>
    /// Function: StartAttackEdgeSearch
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAttackEdgeSearch StartAttackEdgeSearch(System.Numerics.Vector3 TargetLocation, float AttackRadius, BmSDK.FName ClaimName, BmSDK.TArray<BmSDK.Engine.Pylon> NewPylonList = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAttackEdgeSearch, "BmGame.RNavigationManager.StartAttackEdgeSearch");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackRadius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClaimName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPylonList, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAttackEdgeSearch>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_RemoveChaseLocationSearch;
    /// <summary>
    /// Function: RemoveChaseLocationSearch
    /// </summary>
    public unsafe virtual void RemoveChaseLocationSearch(BmSDK.BmGame.RChaseLocationSearch OldSearch)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveChaseLocationSearch, "BmGame.RNavigationManager.RemoveChaseLocationSearch");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldSearch, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddChaseLocationSearch;
    /// <summary>
    /// Function: AddChaseLocationSearch
    /// </summary>
    public unsafe virtual void AddChaseLocationSearch(BmSDK.BmGame.RChaseLocationSearch NewSearch)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddChaseLocationSearch, "BmGame.RNavigationManager.AddChaseLocationSearch");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSearch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveAttackPointSearch;
    /// <summary>
    /// Function: RemoveAttackPointSearch
    /// </summary>
    public unsafe virtual void RemoveAttackPointSearch(BmSDK.BmGame.RAttackPointSearch OldSearch)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAttackPointSearch, "BmGame.RNavigationManager.RemoveAttackPointSearch");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldSearch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddAttackPointSearch;
    /// <summary>
    /// Function: AddAttackPointSearch
    /// </summary>
    public unsafe virtual void AddAttackPointSearch(BmSDK.BmGame.RAttackPointSearch NewSearch)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddAttackPointSearch, "BmGame.RNavigationManager.AddAttackPointSearch");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSearch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAttackPointSearch;
    /// <summary>
    /// Function: StartAttackPointSearch
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAttackPointSearch StartAttackPointSearch(System.Numerics.Vector3 TargetLocation, float AttackRadius, BmSDK.FName ClaimName, BmSDK.BmGame.RAttackPointSearch.StanceVisType StanceToCheck = default, BmSDK.TArray<BmSDK.Engine.Pylon> NewPylonList = default, float NewSubDivideSizeTarget = default, bool bAutoAdjustToFloor = default, bool bAdjustHeightForHumanTargetSize = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAttackPointSearch, "BmGame.RNavigationManager.StartAttackPointSearch");
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackRadius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClaimName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StanceToCheck, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPylonList, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSubDivideSizeTarget, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAutoAdjustToFloor, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAdjustHeightForHumanTargetSize, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAttackPointSearch>(paramsPtr + 56);
    }

    private static BmSDK.Function __fn_GetPathFindActorHandle;
    /// <summary>
    /// Function: GetPathFindActorHandle
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RNavigationHandle GetPathFindActorHandle(System.Numerics.Vector3 StartLocation, BmSDK.FName ClaimName, BmSDK.Engine.Pawn ParamProxy = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPathFindActorHandle, "BmGame.RNavigationManager.GetPathFindActorHandle");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClaimName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamProxy, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RNavigationHandle>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_RemoveSearchRequest;
    /// <summary>
    /// Function: RemoveSearchRequest
    /// </summary>
    public unsafe virtual void RemoveSearchRequest(BmSDK.BmGame.RNavigationHandle OldNavHandle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveSearchRequest, "BmGame.RNavigationManager.RemoveSearchRequest");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldNavHandle, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddSearchRequest;
    /// <summary>
    /// Function: AddSearchRequest
    /// </summary>
    public unsafe virtual void AddSearchRequest(BmSDK.BmGame.RNavigationHandle NewNavHandle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSearchRequest, "BmGame.RNavigationManager.AddSearchRequest");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewNavHandle, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RemoveNavHandle;
    /// <summary>
    /// Function: RemoveNavHandle
    /// </summary>
    public unsafe virtual void RemoveNavHandle(BmSDK.BmGame.RNavigationHandle OldNavHandle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveNavHandle, "BmGame.RNavigationManager.RemoveNavHandle");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldNavHandle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddNavHandle;
    /// <summary>
    /// Function: AddNavHandle
    /// </summary>
    public unsafe virtual void AddNavHandle(BmSDK.BmGame.RNavigationHandle NewNavHandle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddNavHandle, "BmGame.RNavigationManager.AddNavHandle");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewNavHandle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe virtual void Initialise()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmGame.RNavigationManager.Initialise");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInNavMesh;
    /// <summary>
    /// Function: IsInNavMesh
    /// </summary>
    public unsafe virtual bool IsInNavMesh(System.Numerics.Vector3 TestPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInNavMesh, "BmGame.RNavigationManager.IsInNavMesh");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_NavMeshExists;
    /// <summary>
    /// Function: NavMeshExists
    /// </summary>
    public unsafe virtual bool NavMeshExists()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavMeshExists, "BmGame.RNavigationManager.NavMeshExists");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_CanDoPathShortening;
    /// <summary>
    /// Function: CanDoPathShortening
    /// </summary>
    public unsafe virtual bool CanDoPathShortening(BmSDK.BmGame.RNavigationHandle NavHandle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoPathShortening, "BmGame.RNavigationManager.CanDoPathShortening");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DisplayPylonList;
    /// <summary>
    /// Function: DisplayPylonList
    /// </summary>
    public unsafe virtual void DisplayPylonList()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayPylonList, "BmGame.RNavigationManager.DisplayPylonList");
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

    private static BmSDK.Function __fn_Tick_PostUpdate;
    /// <summary>
    /// Function: Tick_PostUpdate
    /// </summary>
    public unsafe virtual void Tick_PostUpdate(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick_PostUpdate, "BmGame.RNavigationManager.Tick_PostUpdate");
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

    private static BmSDK.Function __fn_Tick_DuringAsync;
    /// <summary>
    /// Function: Tick_DuringAsync
    /// </summary>
    public unsafe virtual void Tick_DuringAsync(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick_DuringAsync, "BmGame.RNavigationManager.Tick_DuringAsync");
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

    private static BmSDK.Function __fn_Tick_PreAsync;
    /// <summary>
    /// Function: Tick_PreAsync
    /// </summary>
    public unsafe virtual void Tick_PreAsync(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick_PreAsync, "BmGame.RNavigationManager.Tick_PreAsync");
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

    private static BmSDK.Function __fn_TickQueuedkDOPRebuilds;
    /// <summary>
    /// Function: TickQueuedkDOPRebuilds
    /// </summary>
    public unsafe virtual void TickQueuedkDOPRebuilds(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickQueuedkDOPRebuilds, "BmGame.RNavigationManager.TickQueuedkDOPRebuilds");
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

    private static BmSDK.Function __fn_QueuePylonForObstacleMeshkDOPRebuild;
    /// <summary>
    /// Function: QueuePylonForObstacleMeshkDOPRebuild
    /// </summary>
    public unsafe virtual void QueuePylonForObstacleMeshkDOPRebuild(BmSDK.Engine.Pylon RebuildPylon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueuePylonForObstacleMeshkDOPRebuild, "BmGame.RNavigationManager.QueuePylonForObstacleMeshkDOPRebuild");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RebuildPylon, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SyncOnNavMeshObstacleJob;
    /// <summary>
    /// Function: SyncOnNavMeshObstacleJob
    /// </summary>
    public unsafe virtual void SyncOnNavMeshObstacleJob()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SyncOnNavMeshObstacleJob, "BmGame.RNavigationManager.SyncOnNavMeshObstacleJob");
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

    private static BmSDK.Function __fn_AnyNavMeshJobInProgress;
    /// <summary>
    /// Function: AnyNavMeshJobInProgress
    /// </summary>
    public unsafe virtual bool AnyNavMeshJobInProgress()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnyNavMeshJobInProgress, "BmGame.RNavigationManager.AnyNavMeshJobInProgress");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_ShowHandleDebug;
    /// <summary>
    /// Function: ShowHandleDebug
    /// </summary>
    public unsafe virtual void ShowHandleDebug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowHandleDebug, "BmGame.RNavigationManager.ShowHandleDebug");
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

    private static BmSDK.Function __fn_ReturnNavMeshPathConstraintToPool;
    /// <summary>
    /// Function: ReturnNavMeshPathConstraintToPool
    /// </summary>
    public unsafe virtual void ReturnNavMeshPathConstraintToPool(BmSDK.Engine.NavMeshPathConstraint PathConstraint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReturnNavMeshPathConstraintToPool, "BmGame.RNavigationManager.ReturnNavMeshPathConstraintToPool");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PathConstraint, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ReturnNavMeshPathGoalToPool;
    /// <summary>
    /// Function: ReturnNavMeshPathGoalToPool
    /// </summary>
    public unsafe virtual void ReturnNavMeshPathGoalToPool(BmSDK.Engine.NavMeshPathGoalEvaluator PathGoal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReturnNavMeshPathGoalToPool, "BmGame.RNavigationManager.ReturnNavMeshPathGoalToPool");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PathGoal, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetNavMeshPathConstraintFromPool;
    /// <summary>
    /// Function: GetNavMeshPathConstraintFromPool
    /// </summary>
    public unsafe virtual BmSDK.Engine.NavMeshPathConstraint GetNavMeshPathConstraintFromPool(BmSDK.Class ConstraintClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNavMeshPathConstraintFromPool, "BmGame.RNavigationManager.GetNavMeshPathConstraintFromPool");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConstraintClass, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.NavMeshPathConstraint>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetNavMeshPathGoalFromPool;
    /// <summary>
    /// Function: GetNavMeshPathGoalFromPool
    /// </summary>
    public unsafe virtual BmSDK.Engine.NavMeshPathGoalEvaluator GetNavMeshPathGoalFromPool(BmSDK.Class GoalClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNavMeshPathGoalFromPool, "BmGame.RNavigationManager.GetNavMeshPathGoalFromPool");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoalClass, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.NavMeshPathGoalEvaluator>(paramsPtr + 8);
    }

    /// <summary>
    /// Struct: FRebuildObstacleMeshkDOPInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FRebuildObstacleMeshkDOPInfo
    {
        /// <summary>
        /// ObjectProperty: RebuildPylon
        /// </summary>
        public unsafe BmSDK.Engine.Pylon RebuildPylon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: RequestTime
        /// </summary>
        public unsafe float RequestTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// ArrayProperty: AllNavHandles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle> AllNavHandles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: PendingSearchRequests
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle> PendingSearchRequests
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: NavigationActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationActor> NavigationActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationActor>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: AttackPointSearches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAttackPointSearch> AttackPointSearches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAttackPointSearch>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: PendingAttackPointSearches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAttackPointSearch> PendingAttackPointSearches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAttackPointSearch>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ArrayProperty: AttackEdgeSearches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAttackEdgeSearch> AttackEdgeSearches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAttackEdgeSearch>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: PendingAttackEdgeSearches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAttackEdgeSearch> PendingAttackEdgeSearches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAttackEdgeSearch>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ArrayProperty: PendingChaseLocationSearches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RChaseLocationSearch> PendingChaseLocationSearches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChaseLocationSearch>>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ArrayProperty: TraceCheckVertsQueries
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIAction_PauseCheckVerts> TraceCheckVertsQueries
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIAction_PauseCheckVerts>>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ArrayProperty: UninformedSearchSuppressionVol
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RUninformedSearchSuppressionVolume> UninformedSearchSuppressionVol
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RUninformedSearchSuppressionVolume>>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ArrayProperty: PendingGroupAssignmentPickerList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGroupAssignmentPicker> PendingGroupAssignmentPickerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGroupAssignmentPicker>>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// IntProperty: CurrShortener
    /// </summary>
    public unsafe int CurrShortener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ArrayProperty: ShortenHandleIndices
    /// </summary>
    public unsafe BmSDK.TArray<int> ShortenHandleIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// IntProperty: MaxShortensPerFrame
    /// </summary>
    public unsafe int MaxShortensPerFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// IntProperty: OverridePathSearchesPerFrame
    /// </summary>
    public unsafe int OverridePathSearchesPerFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ObjectProperty: GRI
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI GRI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// ArrayProperty: FireChaseInvalidatedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RChaseLocationSearch> FireChaseInvalidatedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChaseLocationSearch>>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// MapProperty: NavMeshPathGoalPool
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ NavMeshPathGoalPool
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// MapProperty: NavMeshPathConstraintPool
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ NavMeshPathConstraintPool
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ArrayProperty: UsedGoalList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.NavMeshPathGoalEvaluator> UsedGoalList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.NavMeshPathGoalEvaluator>>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ArrayProperty: UsedConstraintList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.NavMeshPathConstraint> UsedConstraintList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.NavMeshPathConstraint>>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ArrayProperty: RebuildkDOPRequests
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationManager.FRebuildObstacleMeshkDOPInfo> RebuildkDOPRequests
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationManager.FRebuildObstacleMeshkDOPInfo>>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }
}
