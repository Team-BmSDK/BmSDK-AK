#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAIBrain<br/>
/// (size = 132)
/// (flags = 134217874)
/// </summary>
public partial class RAIBrain : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAIBrain", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAIBrain.
    /// </summary>
    public static RAIBrain DefaultObject => (RAIBrain)StaticClass().DefaultObject;

    internal RAIBrain() { }

    /// <summary>
    /// Constructs a new RAIBrain
    /// </summary>
    public RAIBrain(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAIBrain Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAIBrain(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAIBrain>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAIBrain>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAIBrain>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAIBrain>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAIBrain>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAIBrain>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAIBrain>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAIBrain>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_FireSpawnerBehaviourRoot;
    /// <summary>
    /// Function: FireSpawnerBehaviourRoot
    /// </summary>
    public unsafe virtual void FireSpawnerBehaviourRoot(int BrainIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireSpawnerBehaviourRoot, "BmGame.RAIBrain.FireSpawnerBehaviourRoot");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BrainIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTopLevelAEC;
    /// <summary>
    /// Function: SetTopLevelAEC
    /// </summary>
    public unsafe virtual void SetTopLevelAEC(BmSDK.BmGame.RAlertEventCoordinatorBase NewTopLevelAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTopLevelAEC, "BmGame.RAIBrain.SetTopLevelAEC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTopLevelAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearAssignment;
    /// <summary>
    /// Function: ClearAssignment
    /// </summary>
    public unsafe virtual void ClearAssignment()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAssignment, "BmGame.RAIBrain.ClearAssignment");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleNonAECState;
    /// <summary>
    /// Function: HandleNonAECState
    /// </summary>
    public unsafe virtual void HandleNonAECState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleNonAECState, "BmGame.RAIBrain.HandleNonAECState");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyBrainState;
    /// <summary>
    /// Function: ApplyBrainState
    /// </summary>
    public unsafe virtual void ApplyBrainState(BmSDK.FName NewBrainState, BmSDK.BmGame.RAlertEventCoordinatorBase PendingTLAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyBrainState, "BmGame.RAIBrain.ApplyBrainState");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBrainState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PendingTLAEC, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EvaluateState;
    /// <summary>
    /// Function: EvaluateState
    /// </summary>
    public unsafe virtual void EvaluateState(out BmSDK.FName NewName, out BmSDK.BmGame.RAlertEventCoordinatorBase NewAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EvaluateState, "BmGame.RAIBrain.EvaluateState");
        byte* paramsPtr = stackalloc byte[16];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewAEC);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAEC, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NewName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
        NewAEC = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAlertEventCoordinatorBase>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_DoAssignment;
    /// <summary>
    /// Function: DoAssignment
    /// </summary>
    public unsafe virtual void DoAssignment()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoAssignment, "BmGame.RAIBrain.DoAssignment");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: BrainScriptImportance
    /// </summary>
    public enum BrainScriptImportance : byte
    {
        BSI_Default = 0,
        BSI_Searching = 1,
        BSI_HavingAGun = 2,
        BSI_BeingInSmoke = 3,
        BSI_MAX = 4,
    }

    /// <summary>
    /// ObjectProperty: HostController
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController HostController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: CurrentTopLevelAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAlertEventCoordinatorBase CurrentTopLevelAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlertEventCoordinatorBase>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// NameProperty: BrainState
    /// </summary>
    public unsafe BmSDK.FName BrainState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: KismetOutput
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> KismetOutput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ByteProperty: ScriptImportance
    /// </summary>
    public unsafe BmSDK.BmGame.RAIBrain.BrainScriptImportance ScriptImportance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAIBrain.BrainScriptImportance>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// BoolProperty: bAutoRevertOnBSIInterrupt
    /// </summary>
    public unsafe bool bAutoRevertOnBSIInterrupt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bCleaningUp
    /// </summary>
    public unsafe bool bCleaningUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }
}
