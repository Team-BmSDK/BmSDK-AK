#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_Search_Formation_Standard<br/>
/// (size = 792)
/// (flags = 10485778)
/// </summary>
public partial class RAEC_Search_Formation_Standard : BmSDK.BmGame.RAEC_Search_Formation, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Search_Formation_Standard", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_Search_Formation_Standard.
    /// </summary>
    public static RAEC_Search_Formation_Standard DefaultObject => (RAEC_Search_Formation_Standard)StaticClass().DefaultObject;

    internal RAEC_Search_Formation_Standard() { }

    /// <summary>
    /// Constructs a new RAEC_Search_Formation_Standard
    /// </summary>
    public RAEC_Search_Formation_Standard(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Search_Formation_Standard(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Formation_Standard>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Formation_Standard>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Formation_Standard>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Formation_Standard>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Formation_Standard>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Formation_Standard>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Formation_Standard>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Formation_Standard>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_HasBanterAECRunning;
    /// <summary>
    /// Function: HasBanterAECRunning
    /// </summary>
    public unsafe virtual bool HasBanterAECRunning()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasBanterAECRunning, "BmGame.RAEC_Search_Formation_Standard.HasBanterAECRunning");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartFollowerBanterEvent;
    /// <summary>
    /// Function: StartFollowerBanterEvent
    /// </summary>
    public unsafe virtual void StartFollowerBanterEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFollowerBanterEvent, "BmGame.RAEC_Search_Formation_Standard.StartFollowerBanterEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasBumpAECRunning;
    /// <summary>
    /// Function: HasBumpAECRunning
    /// </summary>
    public unsafe virtual bool HasBumpAECRunning()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasBumpAECRunning, "BmGame.RAEC_Search_Formation_Standard.HasBumpAECRunning");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartFollowerBumpEvent;
    /// <summary>
    /// Function: StartFollowerBumpEvent
    /// </summary>
    public unsafe virtual void StartFollowerBumpEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFollowerBumpEvent, "BmGame.RAEC_Search_Formation_Standard.StartFollowerBumpEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveFromCongaLineByIndex;
    /// <summary>
    /// Function: RemoveFromCongaLineByIndex
    /// </summary>
    public unsafe virtual void RemoveFromCongaLineByIndex(int RemIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveFromCongaLineByIndex, "BmGame.RAEC_Search_Formation_Standard.RemoveFromCongaLineByIndex");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddToCongaLine;
    /// <summary>
    /// Function: AddToCongaLine
    /// </summary>
    public unsafe virtual void AddToCongaLine(BmSDK.BmGame.RAEC_Search_Sub_Follower NewMember, int InsertIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddToCongaLine, "BmGame.RAEC_Search_Formation_Standard.AddToCongaLine");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InsertIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFollower;
    /// <summary>
    /// Function: AddFollower
    /// </summary>
    public unsafe override void AddFollower(BmSDK.BmGame.RBMAIController FollowCon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFollower, "BmGame.RAEC_Search_Formation_Standard.AddFollower");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowCon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLeader;
    /// <summary>
    /// Function: SetLeader
    /// </summary>
    public unsafe override void SetLeader(BmSDK.BmGame.RBMAIController LeaderCon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLeader, "BmGame.RAEC_Search_Formation_Standard.SetLeader");
        byte* paramsPtr = stackalloc byte[8];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRemoveSoloChild, "BmGame.RAEC_Search_Formation_Standard.OnRemoveSoloChild");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ClassProperty: LeaderSpawnClass
    /// </summary>
    public unsafe BmSDK.Class LeaderSpawnClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// ArrayProperty: CongaLine
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_Search_Sub_Follower> CongaLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_Search_Sub_Follower>>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ObjectProperty: Rearguard
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Search_Sub_Follower Rearguard
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Search_Sub_Follower>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }
}
