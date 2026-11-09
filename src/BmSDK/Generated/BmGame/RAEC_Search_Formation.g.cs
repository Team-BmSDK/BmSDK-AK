#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RAEC_Search_Formation<br/>
/// (size = 760)
/// (flags = 10485779)
/// </summary>
public partial class RAEC_Search_Formation : BmSDK.BmGame.RAlertEventCoordinatorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Search_Formation", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_Search_Formation.
    /// </summary>
    public static RAEC_Search_Formation DefaultObject => (RAEC_Search_Formation)StaticClass().DefaultObject;

    internal RAEC_Search_Formation() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Search_Formation(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Formation>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Formation>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Formation>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Formation>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Formation>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Formation>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Formation>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Formation>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_RegisterSplit;
    /// <summary>
    /// Function: RegisterSplit
    /// </summary>
    public unsafe virtual void RegisterSplit(BmSDK.BmGame.RBMAIController SplitCon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterSplit, "BmGame.RAEC_Search_Formation.RegisterSplit");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SplitCon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyChildStolen;
    /// <summary>
    /// Function: NotifyChildStolen
    /// </summary>
    public unsafe override void NotifyChildStolen(BmSDK.BmGame.RAlertEventCoordinatorSolo StoleFromAEC, BmSDK.BmGame.RAlertEventCoordinatorSolo StealingAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyChildStolen, "BmGame.RAEC_Search_Formation.NotifyChildStolen");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StoleFromAEC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StealingAEC, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FollowerWantsLeaderToSlow;
    /// <summary>
    /// Function: FollowerWantsLeaderToSlow
    /// </summary>
    public unsafe virtual bool FollowerWantsLeaderToSlow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FollowerWantsLeaderToSlow, "BmGame.RAEC_Search_Formation.FollowerWantsLeaderToSlow");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBestFollowersForBranchOff;
    /// <summary>
    /// Function: GetBestFollowersForBranchOff
    /// </summary>
    public unsafe virtual void GetBestFollowersForBranchOff(out BmSDK.BmGame.RBMAIController SplitGroupLeader, out BmSDK.TArray<BmSDK.BmGame.RBMAIController> SplitFollowers)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestFollowersForBranchOff, "BmGame.RAEC_Search_Formation.GetBestFollowersForBranchOff");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SplitGroupLeader);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SplitGroupLeader, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SplitGroupLeader = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIController>(paramsPtr + 0);
        SplitFollowers = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RBMAIController>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_GroupShouldSplit;
    /// <summary>
    /// Function: GroupShouldSplit
    /// </summary>
    public unsafe virtual bool GroupShouldSplit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GroupShouldSplit, "BmGame.RAEC_Search_Formation.GroupShouldSplit");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSplitCap;
    /// <summary>
    /// Function: GetSplitCap
    /// </summary>
    public unsafe virtual int GetSplitCap()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSplitCap, "BmGame.RAEC_Search_Formation.GetSplitCap");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RefuseBuddy;
    /// <summary>
    /// Function: RefuseBuddy
    /// </summary>
    public unsafe virtual bool RefuseBuddy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefuseBuddy, "BmGame.RAEC_Search_Formation.RefuseBuddy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InitSplitThugs;
    /// <summary>
    /// Function: InitSplitThugs
    /// </summary>
    public unsafe virtual void InitSplitThugs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitSplitThugs, "BmGame.RAEC_Search_Formation.InitSplitThugs");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssessPotentialSplit;
    /// <summary>
    /// Function: AssessPotentialSplit
    /// </summary>
    public unsafe virtual void AssessPotentialSplit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssessPotentialSplit, "BmGame.RAEC_Search_Formation.AssessPotentialSplit");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFollower;
    /// <summary>
    /// Function: AddFollower
    /// </summary>
    public unsafe virtual void AddFollower(BmSDK.BmGame.RBMAIController FollowCon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFollower, "BmGame.RAEC_Search_Formation.AddFollower");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowCon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLeader;
    /// <summary>
    /// Function: SetLeader
    /// </summary>
    public unsafe virtual void SetLeader(BmSDK.BmGame.RBMAIController LeaderCon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLeader, "BmGame.RAEC_Search_Formation.SetLeader");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeaderCon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRemoveSoloChild;
    /// <summary>
    /// Function: OnRemoveSoloChild
    /// </summary>
    public unsafe override void OnRemoveSoloChild(BmSDK.BmGame.RAlertEventCoordinatorSolo RemAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRemoveSoloChild, "BmGame.RAEC_Search_Formation.OnRemoveSoloChild");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: LeaderAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Search_Sub_FormationLeader LeaderAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Search_Sub_FormationLeader>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bShutdownOnLeaderRemoval
    /// </summary>
    public unsafe bool bShutdownOnLeaderRemoval
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// ArrayProperty: SideBranches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSearchRoutingWrapper.FSideBranchStruct> SideBranches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSearchRoutingWrapper.FSideBranchStruct>>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// StructProperty: SplitOffGroupDest
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SplitOffGroupDest
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 748);
}
