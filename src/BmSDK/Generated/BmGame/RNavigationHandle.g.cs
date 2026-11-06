#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RNavigationHandle<br/>
/// (size = 928)
/// (flags = 134217874)
/// </summary>
public partial class RNavigationHandle : BmSDK.Engine.NavigationHandle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RNavigationHandle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RNavigationHandle.
    /// </summary>
    public static RNavigationHandle DefaultObject => (RNavigationHandle)StaticClass().DefaultObject;

    internal RNavigationHandle() { }

    /// <summary>
    /// Constructs a new RNavigationHandle
    /// </summary>
    public RNavigationHandle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RNavigationHandle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RNavigationHandle(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavigationHandle>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavigationHandle>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavigationHandle>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavigationHandle>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavigationHandle>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavigationHandle>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavigationHandle>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavigationHandle>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CacheStartStateForDebug;
    /// <summary>
    /// Function: CacheStartStateForDebug
    /// </summary>
    public unsafe virtual void CacheStartStateForDebug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CacheStartStateForDebug, "BmGame.RNavigationHandle.CacheStartStateForDebug");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetThoughtString;
    /// <summary>
    /// Function: GetThoughtString
    /// </summary>
    public unsafe virtual BmSDK.FString GetThoughtString(bool bMaxVerbosity = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughtString, "BmGame.RNavigationHandle.GetThoughtString");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMaxVerbosity, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsEmpty;
    /// <summary>
    /// Function: IsEmpty
    /// </summary>
    public unsafe virtual bool IsEmpty()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsEmpty, "BmGame.RNavigationHandle.IsEmpty");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FollowPath;
    /// <summary>
    /// Function: FollowPath
    /// </summary>
    public unsafe virtual void FollowPath(bool bCanFallBackToMoveInDirection = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FollowPath, "BmGame.RNavigationHandle.FollowPath");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanFallBackToMoveInDirection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindPathToPoint;
    /// <summary>
    /// Function: FindPathToPoint
    /// </summary>
    public unsafe virtual void FindPathToPoint(System.Numerics.Vector3 NewDestPoint, int Priority = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPathToPoint, "BmGame.RNavigationHandle.FindPathToPoint");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDestPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindPathToActor;
    /// <summary>
    /// Function: FindPathToActor
    /// </summary>
    public unsafe virtual void FindPathToActor(BmSDK.Engine.Actor NewDestActor, int Priority = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPathToActor, "BmGame.RNavigationHandle.FindPathToActor");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDestActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateAvoidPathObjectsConstraints;
    /// <summary>
    /// Function: CreateAvoidPathObjectsConstraints
    /// </summary>
    public unsafe void CreateAvoidPathObjectsConstraints()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateAvoidPathObjectsConstraints, "BmGame.RNavigationHandle.CreateAvoidPathObjectsConstraints");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateAvoidBlockedPolysConstraints;
    /// <summary>
    /// Function: CreateAvoidBlockedPolysConstraints
    /// </summary>
    public unsafe void CreateAvoidBlockedPolysConstraints()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateAvoidBlockedPolysConstraints, "BmGame.RNavigationHandle.CreateAvoidBlockedPolysConstraints");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateAvoidPlayersConstraints;
    /// <summary>
    /// Function: CreateAvoidPlayersConstraints
    /// </summary>
    public unsafe void CreateAvoidPlayersConstraints()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateAvoidPlayersConstraints, "BmGame.RNavigationHandle.CreateAvoidPlayersConstraints");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreatePathToSafetyContraints;
    /// <summary>
    /// Function: CreatePathToSafetyContraints
    /// </summary>
    public unsafe void CreatePathToSafetyContraints()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreatePathToSafetyContraints, "BmGame.RNavigationHandle.CreatePathToSafetyContraints");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreatePathToActorConstraints;
    /// <summary>
    /// Function: CreatePathToActorConstraints
    /// </summary>
    public unsafe void CreatePathToActorConstraints(BmSDK.Engine.Actor destActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreatePathToActorConstraints, "BmGame.RNavigationHandle.CreatePathToActorConstraints");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(destActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreatePathToPointConstraints;
    /// <summary>
    /// Function: CreatePathToPointConstraints
    /// </summary>
    public unsafe void CreatePathToPointConstraints(System.Numerics.Vector3 DestPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreatePathToPointConstraints, "BmGame.RNavigationHandle.CreatePathToPointConstraints");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableForcedPathShortening;
    /// <summary>
    /// Function: DisableForcedPathShortening
    /// </summary>
    public unsafe virtual void DisableForcedPathShortening()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableForcedPathShortening, "BmGame.RNavigationHandle.DisableForcedPathShortening");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceInstantPathShortening;
    /// <summary>
    /// Function: ForceInstantPathShortening
    /// </summary>
    public unsafe virtual void ForceInstantPathShortening(int ShortenAttempts = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceInstantPathShortening, "BmGame.RNavigationHandle.ForceInstantPathShortening");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShortenAttempts, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAppendToHandle;
    /// <summary>
    /// Function: SetAppendToHandle
    /// </summary>
    public unsafe virtual void SetAppendToHandle(BmSDK.BmGame.RNavigationHandle PreviousHandle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAppendToHandle, "BmGame.RNavigationHandle.SetAppendToHandle");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousHandle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetUseCheapSupportCheck;
    /// <summary>
    /// Function: SetUseCheapSupportCheck
    /// </summary>
    public unsafe virtual void SetUseCheapSupportCheck(bool bNewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetUseCheapSupportCheck, "BmGame.RNavigationHandle.SetUseCheapSupportCheck");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCanDoPathShortening;
    /// <summary>
    /// Function: SetCanDoPathShortening
    /// </summary>
    public unsafe virtual void SetCanDoPathShortening(bool bNewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCanDoPathShortening, "BmGame.RNavigationHandle.SetCanDoPathShortening");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPathFollowingTimeSlicing;
    /// <summary>
    /// Function: SetPathFollowingTimeSlicing
    /// </summary>
    public unsafe virtual void SetPathFollowingTimeSlicing(bool bNewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPathFollowingTimeSlicing, "BmGame.RNavigationHandle.SetPathFollowingTimeSlicing");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTraversal;
    /// <summary>
    /// Function: SetTraversal
    /// </summary>
    public unsafe virtual void SetTraversal(bool bNewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTraversal, "BmGame.RNavigationHandle.SetTraversal");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetUseLadders;
    /// <summary>
    /// Function: SetUseLadders
    /// </summary>
    public unsafe virtual void SetUseLadders(bool bNewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetUseLadders, "BmGame.RNavigationHandle.SetUseLadders");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGoal_Safety;
    /// <summary>
    /// Function: SetGoal_Safety
    /// </summary>
    public unsafe virtual void SetGoal_Safety()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGoal_Safety, "BmGame.RNavigationHandle.SetGoal_Safety");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGoal_PathToActor;
    /// <summary>
    /// Function: SetGoal_PathToActor
    /// </summary>
    public unsafe virtual void SetGoal_PathToActor(BmSDK.Engine.Actor destActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGoal_PathToActor, "BmGame.RNavigationHandle.SetGoal_PathToActor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(destActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGoal_AdditionalPathToPoint;
    /// <summary>
    /// Function: SetGoal_AdditionalPathToPoint
    /// </summary>
    public unsafe virtual void SetGoal_AdditionalPathToPoint(System.Numerics.Vector3 DestPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGoal_AdditionalPathToPoint, "BmGame.RNavigationHandle.SetGoal_AdditionalPathToPoint");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGoal_PathToPoint;
    /// <summary>
    /// Function: SetGoal_PathToPoint
    /// </summary>
    public unsafe virtual void SetGoal_PathToPoint(System.Numerics.Vector3 DestPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGoal_PathToPoint, "BmGame.RNavigationHandle.SetGoal_PathToPoint");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetConstraint_AvoidPathObject;
    /// <summary>
    /// Function: SetConstraint_AvoidPathObject
    /// </summary>
    public unsafe virtual void SetConstraint_AvoidPathObject(BmSDK.Engine.Actor PathObjectToAvoid)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetConstraint_AvoidPathObject, "BmGame.RNavigationHandle.SetConstraint_AvoidPathObject");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PathObjectToAvoid, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetConstraint_AvoidPlayers;
    /// <summary>
    /// Function: SetConstraint_AvoidPlayers
    /// </summary>
    public unsafe virtual void SetConstraint_AvoidPlayers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetConstraint_AvoidPlayers, "BmGame.RNavigationHandle.SetConstraint_AvoidPlayers");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAdditionalSearch;
    /// <summary>
    /// Function: StartAdditionalSearch
    /// </summary>
    public unsafe virtual void StartAdditionalSearch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAdditionalSearch, "BmGame.RNavigationHandle.StartAdditionalSearch");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSearch;
    /// <summary>
    /// Function: StartSearch
    /// </summary>
    public unsafe virtual void StartSearch(int Priority = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSearch, "BmGame.RNavigationHandle.StartSearch");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrepareForSearch;
    /// <summary>
    /// Function: PrepareForSearch
    /// </summary>
    public unsafe virtual void PrepareForSearch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepareForSearch, "BmGame.RNavigationHandle.PrepareForSearch");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearPathFindParameters;
    /// <summary>
    /// Function: ClearPathFindParameters
    /// </summary>
    public unsafe void ClearPathFindParameters()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPathFindParameters, "BmGame.RNavigationHandle.ClearPathFindParameters");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreatePathGoalEvaluator;
    /// <summary>
    /// Function: CreatePathGoalEvaluator
    /// </summary>
    public unsafe override BmSDK.Engine.NavMeshPathGoalEvaluator CreatePathGoalEvaluator(BmSDK.Class GoalEvalClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreatePathGoalEvaluator, "BmGame.RNavigationHandle.CreatePathGoalEvaluator");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoalEvalClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.NavMeshPathGoalEvaluator>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CreatePathConstraint;
    /// <summary>
    /// Function: CreatePathConstraint
    /// </summary>
    public unsafe override BmSDK.Engine.NavMeshPathConstraint CreatePathConstraint(BmSDK.Class ConstraintClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreatePathConstraint, "BmGame.RNavigationHandle.CreatePathConstraint");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConstraintClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.NavMeshPathConstraint>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_Release;
    /// <summary>
    /// Function: Release
    /// </summary>
    public unsafe virtual void Release()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Release, "BmGame.RNavigationHandle.Release");
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

    private static BmSDK.Function __fn_Claim;
    /// <summary>
    /// Function: Claim
    /// </summary>
    public unsafe virtual void Claim(BmSDK.FName NewClaimName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Claim, "BmGame.RNavigationHandle.Claim");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewClaimName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_Deactivate;
    /// <summary>
    /// Function: Deactivate
    /// </summary>
    public unsafe virtual void Deactivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Deactivate, "BmGame.RNavigationHandle.Deactivate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleDebugCamera;
    /// <summary>
    /// Function: ToggleDebugCamera
    /// </summary>
    public unsafe virtual void ToggleDebugCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleDebugCamera, "BmGame.RNavigationHandle.ToggleDebugCamera");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe virtual void Initialise(BmSDK.Engine.Actor NewActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmGame.RNavigationHandle.Initialise");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OutputStartState;
    /// <summary>
    /// Function: OutputStartState
    /// </summary>
    public unsafe virtual void OutputStartState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OutputStartState, "BmGame.RNavigationHandle.OutputStartState");
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

    private static BmSDK.Function __fn_AddToNavHandleHistory;
    /// <summary>
    /// Function: AddToNavHandleHistory
    /// </summary>
    public unsafe virtual void AddToNavHandleHistory(BmSDK.FString Text)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddToNavHandleHistory, "BmGame.RNavigationHandle.AddToNavHandleHistory");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetObstaclesOnPath;
    /// <summary>
    /// Function: GetObstaclesOnPath
    /// </summary>
    public unsafe virtual void GetObstaclesOnPath(out BmSDK.TArray<BmSDK.Engine.Actor> Obstacles)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObstaclesOnPath, "BmGame.RNavigationHandle.GetObstaclesOnPath");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Obstacles = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_BuildChasePointPath;
    /// <summary>
    /// Function: BuildChasePointPath
    /// </summary>
    public unsafe virtual void BuildChasePointPath(out BmSDK.TArray<BmSDK.BmGame.RChasePoint> CPPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuildChasePointPath, "BmGame.RNavigationHandle.BuildChasePointPath");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CPPath = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RChasePoint>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetReachableLocation;
    /// <summary>
    /// Function: GetReachableLocation
    /// </summary>
    public unsafe static bool GetReachableLocation(System.Numerics.Vector3 NearLocation, out System.Numerics.Vector3 ReachableLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetReachableLocation, "BmGame.RNavigationHandle.GetReachableLocation");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NearLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ReachableLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReachableLocation, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ReachableLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_SetBlockedPolyList;
    /// <summary>
    /// Function: SetBlockedPolyList
    /// </summary>
    public unsafe virtual void SetBlockedPolyList(BmSDK.TArray<System.IntPtr> NewBlockedPolyList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBlockedPolyList, "BmGame.RNavigationHandle.SetBlockedPolyList");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBlockedPolyList, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetPylonAndVisibleVertsFromPos;
    /// <summary>
    /// Function: GetPylonAndVisibleVertsFromPos
    /// </summary>
    public unsafe static void GetPylonAndVisibleVertsFromPos(System.Numerics.Vector3 TestPos, out BmSDK.Engine.Pylon BasePylon, out int SourceVert, out BmSDK.TArray<int> VertIDList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPylonAndVisibleVertsFromPos, "BmGame.RNavigationHandle.GetPylonAndVisibleVertsFromPos");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BasePylon);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BasePylon, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SourceVert);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceVert, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BasePylon = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Pylon>(paramsPtr + 12);
        SourceVert = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
        VertIDList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_GetPathForNextXDist;
    /// <summary>
    /// Function: GetPathForNextXDist
    /// </summary>
    public unsafe virtual void GetPathForNextXDist(float LookAheadDist, System.Numerics.Vector3 TestExtents, out BmSDK.TArray<System.Numerics.Vector3> PathPoints, out int bHitSpecialMoveEdge)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPathForNextXDist, "BmGame.RNavigationHandle.GetPathForNextXDist");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAheadDist, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestExtents, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bHitSpecialMoveEdge);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHitSpecialMoveEdge, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PathPoints = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 16);
        bHitSpecialMoveEdge = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 32);
        return;
    }

    private static BmSDK.Function __fn_ClearBlockedPolyLists;
    /// <summary>
    /// Function: ClearBlockedPolyLists
    /// </summary>
    public unsafe virtual void ClearBlockedPolyLists()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearBlockedPolyLists, "BmGame.RNavigationHandle.ClearBlockedPolyLists");
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

    private static BmSDK.Function __fn_AppendPathCacheFromHandle;
    /// <summary>
    /// Function: AppendPathCacheFromHandle
    /// </summary>
    public unsafe virtual void AppendPathCacheFromHandle(BmSDK.BmGame.RNavigationHandle AppendedHandle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AppendPathCacheFromHandle, "BmGame.RNavigationHandle.AppendPathCacheFromHandle");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AppendedHandle, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddPylonsFromPathCacheToStoredArray;
    /// <summary>
    /// Function: AddPylonsFromPathCacheToStoredArray
    /// </summary>
    public unsafe virtual void AddPylonsFromPathCacheToStoredArray()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPylonsFromPathCacheToStoredArray, "BmGame.RNavigationHandle.AddPylonsFromPathCacheToStoredArray");
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

    private static BmSDK.Function __fn_CopyStoredPathCacheIntoPathCache;
    /// <summary>
    /// Function: CopyStoredPathCacheIntoPathCache
    /// </summary>
    public unsafe virtual void CopyStoredPathCacheIntoPathCache()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CopyStoredPathCacheIntoPathCache, "BmGame.RNavigationHandle.CopyStoredPathCacheIntoPathCache");
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

    private static BmSDK.Function __fn_AppendPathCacheToStoredPathCache;
    /// <summary>
    /// Function: AppendPathCacheToStoredPathCache
    /// </summary>
    public unsafe virtual void AppendPathCacheToStoredPathCache()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AppendPathCacheToStoredPathCache, "BmGame.RNavigationHandle.AppendPathCacheToStoredPathCache");
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

    private static BmSDK.Function __fn_CheckStoredPathCacheIsValid;
    /// <summary>
    /// Function: CheckStoredPathCacheIsValid
    /// </summary>
    public unsafe virtual bool CheckStoredPathCacheIsValid()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckStoredPathCacheIsValid, "BmGame.RNavigationHandle.CheckStoredPathCacheIsValid");
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

    private static BmSDK.Function __fn_StoredPathCache_Empty;
    /// <summary>
    /// Function: StoredPathCache_Empty
    /// </summary>
    public unsafe virtual void StoredPathCache_Empty()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StoredPathCache_Empty, "BmGame.RNavigationHandle.StoredPathCache_Empty");
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

    private static BmSDK.Function __fn_ShowPathDebug;
    /// <summary>
    /// Function: ShowPathDebug
    /// </summary>
    public unsafe virtual void ShowPathDebug(bool bShowAll, bool bShowPolys, bool bShowTraversalHistory, int ShortenHistorySize, int EdgeHistorySize, bool bPermanent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowPathDebug, "BmGame.RNavigationHandle.ShowPathDebug");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowAll, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowPolys, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowTraversalHistory, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShortenHistorySize, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EdgeHistorySize, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPermanent, paramsPtr + 20);
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

    private static BmSDK.Function __fn_GetFinalEdgeIndex;
    /// <summary>
    /// Function: GetFinalEdgeIndex
    /// </summary>
    public unsafe virtual int GetFinalEdgeIndex()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFinalEdgeIndex, "BmGame.RNavigationHandle.GetFinalEdgeIndex");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPathObjectsOnPathOfClass;
    /// <summary>
    /// Function: GetPathObjectsOnPathOfClass
    /// </summary>
    public unsafe virtual void GetPathObjectsOnPathOfClass(BmSDK.Class TestClass, out BmSDK.TArray<BmSDK.Engine.Actor> PathObjectList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPathObjectsOnPathOfClass, "BmGame.RNavigationHandle.GetPathObjectsOnPathOfClass");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestClass, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PathObjectList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_PathContainsPathObject;
    /// <summary>
    /// Function: PathContainsPathObject
    /// </summary>
    public unsafe virtual bool PathContainsPathObject(BmSDK.Engine.Actor PathObject)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathContainsPathObject, "BmGame.RNavigationHandle.PathContainsPathObject");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PathObject, paramsPtr + 0);
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

    private static BmSDK.Function __fn_FindNarrowestPointOnPath;
    /// <summary>
    /// Function: FindNarrowestPointOnPath
    /// </summary>
    public unsafe virtual void FindNarrowestPointOnPath(float LookAheadDist, float MaxWidth, out float NarrowestOnLeft, out float NarrowestOnRight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindNarrowestPointOnPath, "BmGame.RNavigationHandle.FindNarrowestPointOnPath");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAheadDist, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxWidth, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NarrowestOnLeft);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NarrowestOnLeft, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NarrowestOnRight);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NarrowestOnRight, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NarrowestOnLeft = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        NarrowestOnRight = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_FindPredatorPointOnPath;
    /// <summary>
    /// Function: FindPredatorPointOnPath
    /// </summary>
    public unsafe virtual bool FindPredatorPointOnPath(float DistToCheck, out BmSDK.BmGame.RPredatorSpecialMovePointBase PredatorPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPredatorPointOnPath, "BmGame.RNavigationHandle.FindPredatorPointOnPath");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistToCheck, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PredatorPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PredatorPoint, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PredatorPoint = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPredatorSpecialMovePointBase>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_FindCornerPointOnPath;
    /// <summary>
    /// Function: FindCornerPointOnPath
    /// </summary>
    public unsafe virtual bool FindCornerPointOnPath(float DistToCheck, out BmSDK.BmGame.RCornerWallMarker StartPoint, out BmSDK.BmGame.RCornerWallMarker EndPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindCornerPointOnPath, "BmGame.RNavigationHandle.FindCornerPointOnPath");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistToCheck, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StartPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out EndPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPoint, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        StartPoint = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCornerWallMarker>(paramsPtr + 4);
        EndPoint = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCornerWallMarker>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_FindIntersectionInfo;
    /// <summary>
    /// Function: FindIntersectionInfo
    /// </summary>
    public unsafe virtual bool FindIntersectionInfo(BmSDK.BmGame.RNavigationHandle OtherNavHandle, out System.Numerics.Vector3 IntersectionStart, out int IntersectionStartID, out System.Numerics.Vector3 IntersectionEnd, out int IntersectionEndID, out float IntersectionStartDist, out float IntersectionLength)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindIntersectionInfo, "BmGame.RNavigationHandle.FindIntersectionInfo");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherNavHandle, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntersectionStart);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntersectionStart, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntersectionStartID);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntersectionStartID, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntersectionEnd);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntersectionEnd, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntersectionEndID);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntersectionEndID, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntersectionStartDist);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntersectionStartDist, paramsPtr + 40);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntersectionLength);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntersectionLength, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        IntersectionStart = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        IntersectionStartID = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
        IntersectionEnd = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
        IntersectionEndID = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 36);
        IntersectionStartDist = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 40);
        IntersectionLength = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 44);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_IsHostOnPath;
    /// <summary>
    /// Function: IsHostOnPath
    /// </summary>
    public unsafe virtual bool IsHostOnPath()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHostOnPath, "BmGame.RNavigationHandle.IsHostOnPath");
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

    private static BmSDK.Function __fn_PathCache_Empty;
    /// <summary>
    /// Function: PathCache_Empty
    /// </summary>
    public unsafe override bool PathCache_Empty()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathCache_Empty, "BmGame.RNavigationHandle.PathCache_Empty");
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

    private static BmSDK.Function __fn_GetNextMoveLocation;
    /// <summary>
    /// Function: GetNextMoveLocation
    /// </summary>
    public unsafe override bool GetNextMoveLocation(out System.Numerics.Vector3 out_MoveDest, float ArrivalDistance)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextMoveLocation, "BmGame.RNavigationHandle.GetNextMoveLocation");
        byte* paramsPtr = stackalloc byte[20];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_MoveDest);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_MoveDest, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrivalDistance, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_MoveDest = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetGoalDestination;
    /// <summary>
    /// Function: GetGoalDestination
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGoalDestination()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGoalDestination, "BmGame.RNavigationHandle.GetGoalDestination");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPathDestination;
    /// <summary>
    /// Function: GetPathDestination
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPathDestination()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPathDestination, "BmGame.RNavigationHandle.GetPathDestination");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFinalDestination;
    /// <summary>
    /// Function: GetFinalDestination
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFinalDestination()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFinalDestination, "BmGame.RNavigationHandle.GetFinalDestination");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPathLength;
    /// <summary>
    /// Function: GetPathLength
    /// </summary>
    public unsafe virtual float GetPathLength()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPathLength, "BmGame.RNavigationHandle.GetPathLength");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanMoveToCurrDestinationFromPosition;
    /// <summary>
    /// Function: CanMoveToCurrDestinationFromPosition
    /// </summary>
    public unsafe virtual bool CanMoveToCurrDestinationFromPosition(System.Numerics.Vector3 NewPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanMoveToCurrDestinationFromPosition, "BmGame.RNavigationHandle.CanMoveToCurrDestinationFromPosition");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPos, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UseNextPathObjectEdge;
    /// <summary>
    /// Function: UseNextPathObjectEdge
    /// </summary>
    public unsafe virtual void UseNextPathObjectEdge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UseNextPathObjectEdge, "BmGame.RNavigationHandle.UseNextPathObjectEdge");
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

    private static BmSDK.Function __fn_NextEdgeIsPathObject;
    /// <summary>
    /// Function: NextEdgeIsPathObject
    /// </summary>
    public unsafe virtual bool NextEdgeIsPathObject()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NextEdgeIsPathObject, "BmGame.RNavigationHandle.NextEdgeIsPathObject");
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
    public unsafe virtual bool CanDoPathShortening()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoPathShortening, "BmGame.RNavigationHandle.CanDoPathShortening");
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

    private static BmSDK.Function __fn_AdvancePathCache;
    /// <summary>
    /// Function: AdvancePathCache
    /// </summary>
    public unsafe virtual void AdvancePathCache()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdvancePathCache, "BmGame.RNavigationHandle.AdvancePathCache");
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

    private static BmSDK.Function __fn_AtPathGoal;
    /// <summary>
    /// Function: AtPathGoal
    /// </summary>
    public unsafe virtual bool AtPathGoal()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AtPathGoal, "BmGame.RNavigationHandle.AtPathGoal");
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

    private static BmSDK.Function __fn_AtGoal;
    /// <summary>
    /// Function: AtGoal
    /// </summary>
    public unsafe virtual bool AtGoal()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AtGoal, "BmGame.RNavigationHandle.AtGoal");
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

    private static BmSDK.Function __fn_HasBeenInvalidatedByDynamicUpdate;
    /// <summary>
    /// Function: HasBeenInvalidatedByDynamicUpdate
    /// </summary>
    public unsafe virtual bool HasBeenInvalidatedByDynamicUpdate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasBeenInvalidatedByDynamicUpdate, "BmGame.RNavigationHandle.HasBeenInvalidatedByDynamicUpdate");
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

    private static BmSDK.Function __fn_PathNotFound;
    /// <summary>
    /// Function: PathNotFound
    /// </summary>
    public unsafe virtual bool PathNotFound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathNotFound, "BmGame.RNavigationHandle.PathNotFound");
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

    private static BmSDK.Function __fn_HasPath;
    /// <summary>
    /// Function: HasPath
    /// </summary>
    public unsafe virtual bool HasPath()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasPath, "BmGame.RNavigationHandle.HasPath");
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

    private static BmSDK.Function __fn_PathFound;
    /// <summary>
    /// Function: PathFound
    /// </summary>
    public unsafe virtual bool PathFound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathFound, "BmGame.RNavigationHandle.PathFound");
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

    private static BmSDK.Function __fn_IsSearching;
    /// <summary>
    /// Function: IsSearching
    /// </summary>
    public unsafe virtual bool IsSearching()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSearching, "BmGame.RNavigationHandle.IsSearching");
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

    private static BmSDK.Function __fn_IsAvailable;
    /// <summary>
    /// Function: IsAvailable
    /// </summary>
    public unsafe virtual bool IsAvailable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAvailable, "BmGame.RNavigationHandle.IsAvailable");
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

    private static BmSDK.Function __fn_ClearConstraints;
    /// <summary>
    /// Function: ClearConstraints
    /// </summary>
    public unsafe override void ClearConstraints()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearConstraints, "BmGame.RNavigationHandle.ClearConstraints");
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

    private static BmSDK.Function __fn_DoPathFinding;
    /// <summary>
    /// Function: DoPathFinding
    /// </summary>
    public unsafe virtual bool DoPathFinding(out BmSDK.Engine.Actor out_DestActor, out int out_DestItem, out int PathRequestsUsed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoPathFinding, "BmGame.RNavigationHandle.DoPathFinding");
        byte* paramsPtr = stackalloc byte[20];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_DestActor);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_DestActor, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_DestItem);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_DestItem, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PathRequestsUsed);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PathRequestsUsed, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_DestActor = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
        out_DestItem = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        PathRequestsUsed = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_FindPath;
    /// <summary>
    /// Function: FindPath
    /// </summary>
    public unsafe override bool FindPath(out BmSDK.Engine.Actor out_DestActor, out int out_DestItem, out int PathRequestsUsed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPath, "BmGame.RNavigationHandle.FindPath");
        byte* paramsPtr = stackalloc byte[20];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_DestActor);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_DestActor, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_DestItem);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_DestItem, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PathRequestsUsed);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PathRequestsUsed, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_DestActor = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
        out_DestItem = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        PathRequestsUsed = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ClearLatentDelegates;
    /// <summary>
    /// Function: ClearLatentDelegates
    /// </summary>
    public unsafe virtual void ClearLatentDelegates()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLatentDelegates, "BmGame.RNavigationHandle.ClearLatentDelegates");
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

    private static BmSDK.Function __fn_FireLatentDelegate_ReachedEdge;
    /// <summary>
    /// Function: FireLatentDelegate_ReachedEdge
    /// </summary>
    public unsafe virtual void FireLatentDelegate_ReachedEdge(int EdgeIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireLatentDelegate_ReachedEdge, "BmGame.RNavigationHandle.FireLatentDelegate_ReachedEdge");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EdgeIdx, paramsPtr + 0);
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

    private static BmSDK.Function __fn_FireLatentDelegate_ReachedGoal;
    /// <summary>
    /// Function: FireLatentDelegate_ReachedGoal
    /// </summary>
    public unsafe virtual void FireLatentDelegate_ReachedGoal()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireLatentDelegate_ReachedGoal, "BmGame.RNavigationHandle.FireLatentDelegate_ReachedGoal");
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

    private static BmSDK.Function __fn_FireLatentDelegate_PathFailure;
    /// <summary>
    /// Function: FireLatentDelegate_PathFailure
    /// </summary>
    public unsafe virtual void FireLatentDelegate_PathFailure()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireLatentDelegate_PathFailure, "BmGame.RNavigationHandle.FireLatentDelegate_PathFailure");
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

    private static BmSDK.Function __fn_FireLatentDelegate_PathSuccess;
    /// <summary>
    /// Function: FireLatentDelegate_PathSuccess
    /// </summary>
    public unsafe virtual void FireLatentDelegate_PathSuccess()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireLatentDelegate_PathSuccess, "BmGame.RNavigationHandle.FireLatentDelegate_PathSuccess");
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

    private static BmSDK.Function __fn_ReachedEdge;
    /// <summary>
    /// Function: ReachedEdge
    /// </summary>
    public unsafe virtual void ReachedEdge(BmSDK.BmGame.RNavigationHandle NavHandle, int EdgeID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReachedEdge, "BmGame.RNavigationHandle.ReachedEdge");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EdgeID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReachedGoal;
    /// <summary>
    /// Function: ReachedGoal
    /// </summary>
    public unsafe virtual void ReachedGoal(BmSDK.BmGame.RNavigationHandle NavHandle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReachedGoal, "BmGame.RNavigationHandle.ReachedGoal");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PathFailure;
    /// <summary>
    /// Function: PathFailure
    /// </summary>
    public unsafe virtual void PathFailure(BmSDK.BmGame.RNavigationHandle NavHandle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathFailure, "BmGame.RNavigationHandle.PathFailure");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PathSuccess;
    /// <summary>
    /// Function: PathSuccess
    /// </summary>
    public unsafe virtual void PathSuccess(BmSDK.BmGame.RNavigationHandle NavHandle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathSuccess, "BmGame.RNavigationHandle.PathSuccess");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FNavHandleHistoryInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FNavHandleHistoryInfo
    {
        /// <summary>
        /// FloatProperty: Time
        /// </summary>
        public unsafe float Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Text
        /// </summary>
        public unsafe BmSDK.FString Text
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FStartStateDebugInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial record struct FStartStateDebugInfo
    {
        /// <summary>
        /// StructProperty: CachedPathParams
        /// </summary>
        public unsafe BmSDK.Engine.NavigationHandle.FNavMeshPathParams CachedPathParams
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavigationHandle.FNavMeshPathParams>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: ActorRot
        /// </summary>
        public unsafe BmSDK.Rotator ActorRot
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// ObjectProperty: PathToActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor PathToActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// StructProperty: PathToPoint
        /// </summary>
        public unsafe System.Numerics.Vector3 PathToPoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bAvoidPlayers
        /// </summary>
        public unsafe bool bAvoidPlayers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }

        /// <summary>
        /// BoolProperty: bCanUseLadders
        /// </summary>
        public unsafe bool bCanUseLadders
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }

        /// <summary>
        /// BoolProperty: bUseCheapSupportCheck
        /// </summary>
        public unsafe bool bUseCheapSupportCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }

        /// <summary>
        /// BoolProperty: bCanTraverse
        /// </summary>
        public unsafe bool bCanTraverse
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }

        /// <summary>
        /// BoolProperty: bPathToSafety
        /// </summary>
        public unsafe bool bPathToSafety
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }

        /// <summary>
        /// ArrayProperty: AdditionalGoalList
        /// </summary>
        public unsafe BmSDK.TArray<System.Numerics.Vector3> AdditionalGoalList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }
    }

    /// <summary>
    /// Struct: FEdgeReachedInstance
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FEdgeReachedInstance
    {
        /// <summary>
        /// StructProperty: EdgeReachedLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 EdgeReachedLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: EdgeStart
        /// </summary>
        public unsafe System.Numerics.Vector3 EdgeStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: EdgeEnd
        /// </summary>
        public unsafe System.Numerics.Vector3 EdgeEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: NextEdgeLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 NextEdgeLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Struct: FPathShortenInstance
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FPathShortenInstance
    {
        /// <summary>
        /// StructProperty: ShortenStart
        /// </summary>
        public unsafe System.Numerics.Vector3 ShortenStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: ShortenEnd
        /// </summary>
        public unsafe System.Numerics.Vector3 ShortenEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: ShortenExtent
        /// </summary>
        public unsafe System.Numerics.Vector3 ShortenExtent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ArrayProperty: ShortenPoints
        /// </summary>
        public unsafe BmSDK.TArray<System.Numerics.Vector3> ShortenPoints
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Enum: PathStatus
    /// </summary>
    public enum PathStatus : byte
    {
        PATH_None = 0,
        PATH_Waiting = 1,
        PATH_Claimed = 2,
        PATH_Searching = 3,
        PATH_Found = 4,
        PATH_NotFound = 5,
        PATH_Shortening = 6,
        PathStatus_MAX = 7,
    }

    /// <summary>
    /// BoolProperty: bCanPathFind
    /// </summary>
    public unsafe bool bCanPathFind
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bSettingUpPathFind
    /// </summary>
    public unsafe bool bSettingUpPathFind
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreKnownPathObstacles
    /// </summary>
    public unsafe bool bIgnoreKnownPathObstacles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreGuardVolumeConstraints
    /// </summary>
    public unsafe bool bIgnoreGuardVolumeConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bBeenFollowed
    /// </summary>
    public unsafe bool bBeenFollowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bHasPath
    /// </summary>
    public unsafe bool bHasPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bAtPathGoal
    /// </summary>
    public unsafe bool bAtPathGoal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bAvoidPlayers
    /// </summary>
    public unsafe bool bAvoidPlayers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bCanUseLadders
    /// </summary>
    public unsafe bool bCanUseLadders
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bCanTraverse
    /// </summary>
    public unsafe bool bCanTraverse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bPathToSafety
    /// </summary>
    public unsafe bool bPathToSafety
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bUseCheapSupportCheck
    /// </summary>
    public unsafe bool bUseCheapSupportCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bCanDoPathShortening
    /// </summary>
    public unsafe bool bCanDoPathShortening
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bCanDoRandomTeleport
    /// </summary>
    public unsafe bool bCanDoRandomTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bTimeSliceGetNextMoveLocation
    /// </summary>
    public unsafe bool bTimeSliceGetNextMoveLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bUseLastFramesPathTarget
    /// </summary>
    public unsafe bool bUseLastFramesPathTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bStuck
    /// </summary>
    public unsafe bool bStuck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bUsedPathObject
    /// </summary>
    public unsafe bool bUsedPathObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bHasDoneFollowOnThisPath
    /// </summary>
    public unsafe bool bHasDoneFollowOnThisPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: LatentDelegate_PathSuccess
    /// </summary>
    public unsafe bool LatentDelegate_PathSuccess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: LatentDelegate_PathFailure
    /// </summary>
    public unsafe bool LatentDelegate_PathFailure
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: LatentDelegate_ReachedGoal
    /// </summary>
    public unsafe bool LatentDelegate_ReachedGoal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// ByteProperty: CurrState
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle.PathStatus CurrState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle.PathStatus>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ObjectProperty: HostActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor HostActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ObjectProperty: HostNavActor
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationActor HostNavActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationActor>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// ObjectProperty: HostPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI HostPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ObjectProperty: NavigationManager
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationManager NavigationManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationManager>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// ObjectProperty: PathToActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor PathToActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ObjectProperty: LastSafeAnchorPylon
    /// </summary>
    public unsafe BmSDK.Engine.Pylon LastSafeAnchorPylon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// ObjectProperty: HandleToBeAppended
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle HandleToBeAppended
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// ObjectProperty: HandleToAppendTo
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle HandleToAppendTo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// NameProperty: ClaimName
    /// </summary>
    public unsafe BmSDK.FName ClaimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// IntProperty: PathFindPriority
    /// </summary>
    public unsafe int PathFindPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// IntProperty: CurrPathCacheID
    /// </summary>
    public unsafe int CurrPathCacheID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// FloatProperty: CachedPathLength
    /// </summary>
    public unsafe float CachedPathLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// StructProperty: PathToPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PathToPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 536);

    /// <summary>
    /// IntProperty: ForcedShortenAttempts
    /// </summary>
    public unsafe int ForcedShortenAttempts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// StructProperty: TempMoveLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TempMoveLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 552);

    /// <summary>
    /// StructProperty: LastSafeLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastSafeLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 564);

    /// <summary>
    /// IntProperty: LastSafeAnchorID
    /// </summary>
    public unsafe int LastSafeAnchorID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// FloatProperty: PathShortenProportion
    /// </summary>
    public unsafe float PathShortenProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// StructProperty: LastMoveLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastMoveLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 584);

    /// <summary>
    /// FloatProperty: LastMoveLocationUpdateTime
    /// </summary>
    public unsafe float LastMoveLocationUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// FloatProperty: LastMoveInDirectionFallbackTime
    /// </summary>
    public unsafe float LastMoveInDirectionFallbackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// StructProperty: StuckTestLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StuckTestLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 604);

    /// <summary>
    /// FloatProperty: StuckTestTime
    /// </summary>
    public unsafe float StuckTestTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// ArrayProperty: PathShortens
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle.FPathShortenInstance> PathShortens
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle.FPathShortenInstance>>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ArrayProperty: EdgesReached
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle.FEdgeReachedInstance> EdgesReached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle.FEdgeReachedInstance>>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// ArrayProperty: PathTraversalHistory
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> PathTraversalHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalGoalList
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> AdditionalGoalList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// StructProperty: PreviousPathLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPathLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 684);

    /// <summary>
    /// ArrayProperty: AvoidPathObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> AvoidPathObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ArrayProperty: BlockedPolyList
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> BlockedPolyList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// StructProperty: StartStateDebug
    /// </summary>
    public unsafe ref BmSDK.BmGame.RNavigationHandle.FStartStateDebugInfo StartStateDebug
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RNavigationHandle.FStartStateDebugInfo>(Ptr + 728);

    /// <summary>
    /// ArrayProperty: NavHandleHistory
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle.FNavHandleHistoryInfo> NavHandleHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle.FNavHandleHistoryInfo>>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ArrayProperty: LatentDelegate_ReachedEdges
    /// </summary>
    public unsafe BmSDK.TArray<int> LatentDelegate_ReachedEdges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// DelegateProperty: __PathSuccess__Delegate
    /// </summary>
    public unsafe System.IntPtr __PathSuccess__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// DelegateProperty: __PathFailure__Delegate
    /// </summary>
    public unsafe System.IntPtr __PathFailure__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// DelegateProperty: __ReachedGoal__Delegate
    /// </summary>
    public unsafe System.IntPtr __ReachedGoal__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// DelegateProperty: __ReachedEdge__Delegate
    /// </summary>
    public unsafe System.IntPtr __ReachedEdge__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// Struct: FComputedPathPoint
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FComputedPathPoint
    {
        /// <summary>
        /// StructProperty: Loc
        /// </summary>
        public unsafe System.Numerics.Vector3 Loc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Edge
        /// </summary>
        public unsafe System.IntPtr Edge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }
}
