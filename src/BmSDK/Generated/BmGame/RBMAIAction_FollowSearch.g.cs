#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMAIAction_FollowSearch<br/>
/// (size = 952)
/// (flags = 10485778)
/// </summary>
public partial class RBMAIAction_FollowSearch : BmSDK.BmGame.RBMAIAction_BaseMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMAIAction_FollowSearch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMAIAction_FollowSearch.
    /// </summary>
    public static RBMAIAction_FollowSearch DefaultObject => (RBMAIAction_FollowSearch)StaticClass().DefaultObject;

    internal RBMAIAction_FollowSearch() { }

    /// <summary>
    /// Constructs a new RBMAIAction_FollowSearch
    /// </summary>
    public RBMAIAction_FollowSearch(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMAIAction_FollowSearch(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_FollowSearch>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_FollowSearch>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_FollowSearch>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_FollowSearch>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_FollowSearch>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_FollowSearch>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_FollowSearch>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_FollowSearch>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetWalkSlow;
    /// <summary>
    /// Function: SetWalkSlow
    /// </summary>
    public unsafe virtual void SetWalkSlow(bool bNewWalkSlow)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWalkSlow, "BmGame.RBMAIAction_FollowSearch.SetWalkSlow");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewWalkSlow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateStance;
    /// <summary>
    /// Function: UpdateStance
    /// </summary>
    public unsafe virtual void UpdateStance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateStance, "BmGame.RBMAIAction_FollowSearch.UpdateStance");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WantsLeaderToSlow;
    /// <summary>
    /// Function: WantsLeaderToSlow
    /// </summary>
    public unsafe virtual bool WantsLeaderToSlow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WantsLeaderToSlow, "BmGame.RBMAIAction_FollowSearch.WantsLeaderToSlow");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInFormation;
    /// <summary>
    /// Function: IsInFormation
    /// </summary>
    public unsafe virtual bool IsInFormation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInFormation, "BmGame.RBMAIAction_FollowSearch.IsInFormation");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ActionTick;
    /// <summary>
    /// Function: ActionTick
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMAIAction.ActionTickResult ActionTick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActionTick, "BmGame.RBMAIAction_FollowSearch.ActionTick");
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIAction.ActionTickResult>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_BuildHandle;
    /// <summary>
    /// Function: BuildHandle
    /// </summary>
    public unsafe override BmSDK.BmGame.RNavigationHandle BuildHandle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuildHandle, "BmGame.RBMAIAction_FollowSearch.BuildHandle");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RNavigationHandle>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetHasBackwardsFollower;
    /// <summary>
    /// Function: SetHasBackwardsFollower
    /// </summary>
    public unsafe virtual void SetHasBackwardsFollower(bool bNewVal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHasBackwardsFollower, "BmGame.RBMAIAction_FollowSearch.SetHasBackwardsFollower");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewVal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBackwards;
    /// <summary>
    /// Function: SetBackwards
    /// </summary>
    public unsafe virtual void SetBackwards(bool bNewVal, bool bWalkSlowlyIfForward = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBackwards, "BmGame.RBMAIAction_FollowSearch.SetBackwards");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewVal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWalkSlowlyIfForward, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupFollowPosition;
    /// <summary>
    /// Function: SetupFollowPosition
    /// </summary>
    public unsafe virtual void SetupFollowPosition(System.Numerics.Vector3 NewOffset, float newdist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupFollowPosition, "BmGame.RBMAIAction_FollowSearch.SetupFollowPosition");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOffset, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newdist, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupFollowTarget;
    /// <summary>
    /// Function: SetupFollowTarget
    /// </summary>
    public unsafe virtual void SetupFollowTarget(BmSDK.BmGame.RBMPawnAI NewFollowTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupFollowTarget, "BmGame.RBMAIAction_FollowSearch.SetupFollowTarget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFollowTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Cleanup;
    /// <summary>
    /// Function: Cleanup
    /// </summary>
    public unsafe override void Cleanup()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Cleanup, "BmGame.RBMAIAction_FollowSearch.Cleanup");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: FollowTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI FollowTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ObjectProperty: RepathHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle RepathHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// FloatProperty: FollowDist
    /// </summary>
    public unsafe float FollowDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// StructProperty: FollowOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FollowOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 920);

    /// <summary>
    /// BoolProperty: bHasBeenInFormation
    /// </summary>
    public unsafe bool bHasBeenInFormation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bBackwards
    /// </summary>
    public unsafe bool bBackwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bHasBackwardsFollower
    /// </summary>
    public unsafe bool bHasBackwardsFollower
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bUseSlowForwardStance
    /// </summary>
    public unsafe bool bUseSlowForwardStance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// StructProperty: PathDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PathDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 936);

    /// <summary>
    /// FloatProperty: NoAimTime
    /// </summary>
    public unsafe float NoAimTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }
}
