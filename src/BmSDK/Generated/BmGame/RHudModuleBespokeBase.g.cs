#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleBespokeBase<br/>
/// (size = 248)
/// (flags = 18)
/// </summary>
public partial class RHudModuleBespokeBase : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleBespokeBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHudModuleBespokeBase.
    /// </summary>
    public static RHudModuleBespokeBase DefaultObject => (RHudModuleBespokeBase)StaticClass().DefaultObject;

    internal RHudModuleBespokeBase() { }

    /// <summary>
    /// Constructs a new RHudModuleBespokeBase
    /// </summary>
    public RHudModuleBespokeBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleBespokeBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleBespokeBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleBespokeBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleBespokeBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleBespokeBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleBespokeBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleBespokeBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleBespokeBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleBespokeBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleBespokeBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_EliminateTunnel;
    /// <summary>
    /// Function: EliminateTunnel
    /// </summary>
    public unsafe virtual void EliminateTunnel(int TunnelIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EliminateTunnel, "BmGame.RHudModuleBespokeBase.EliminateTunnel");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TunnelIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetConnectivityProportion;
    /// <summary>
    /// Function: SetConnectivityProportion
    /// </summary>
    public unsafe virtual void SetConnectivityProportion(float Proportion, bool CanTrigger)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetConnectivityProportion, "BmGame.RHudModuleBespokeBase.SetConnectivityProportion");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanTrigger, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ManualUpdate;
    /// <summary>
    /// Function: ManualUpdate
    /// </summary>
    public unsafe virtual void ManualUpdate(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManualUpdate, "BmGame.RHudModuleBespokeBase.ManualUpdate");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGunshipStabilityWarning;
    /// <summary>
    /// Function: SetGunshipStabilityWarning
    /// </summary>
    public unsafe virtual void SetGunshipStabilityWarning(bool show_warning)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGunshipStabilityWarning, "BmGame.RHudModuleBespokeBase.SetGunshipStabilityWarning");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show_warning, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestShutdown;
    /// <summary>
    /// Function: RequestShutdown
    /// </summary>
    public unsafe virtual void RequestShutdown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestShutdown, "BmGame.RHudModuleBespokeBase.RequestShutdown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCloudburstOvercharge;
    /// <summary>
    /// Function: SetCloudburstOvercharge
    /// </summary>
    public unsafe virtual void SetCloudburstOvercharge(float _CloudburstOvercharge)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCloudburstOvercharge, "BmGame.RHudModuleBespokeBase.SetCloudburstOvercharge");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_CloudburstOvercharge, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_CloudburstOutroComplete;
    /// <summary>
    /// Function: DXI_CloudburstOutroComplete
    /// </summary>
    public unsafe virtual void DXI_CloudburstOutroComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_CloudburstOutroComplete, "BmGame.RHudModuleBespokeBase.DXI_CloudburstOutroComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_CloudburstHighlightShown;
    /// <summary>
    /// Function: DXI_CloudburstHighlightShown
    /// </summary>
    public unsafe virtual void DXI_CloudburstHighlightShown(int IndexClockwiseFromFront)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_CloudburstHighlightShown, "BmGame.RHudModuleBespokeBase.DXI_CloudburstHighlightShown");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IndexClockwiseFromFront, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_CloudburstInitialScanComplete;
    /// <summary>
    /// Function: DXI_CloudburstInitialScanComplete
    /// </summary>
    public unsafe virtual void DXI_CloudburstInitialScanComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_CloudburstInitialScanComplete, "BmGame.RHudModuleBespokeBase.DXI_CloudburstInitialScanComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoOutro;
    /// <summary>
    /// Function: DoOutro
    /// </summary>
    public unsafe virtual void DoOutro()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoOutro, "BmGame.RHudModuleBespokeBase.DoOutro");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_BespokeHudOffscreen;
    /// <summary>
    /// Function: XI_BespokeHudOffscreen
    /// </summary>
    public unsafe virtual void XI_BespokeHudOffscreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_BespokeHudOffscreen, "BmGame.RHudModuleBespokeBase.XI_BespokeHudOffscreen");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ApcLocationNoLongerRequired;
    /// <summary>
    /// Function: XI_ApcLocationNoLongerRequired
    /// </summary>
    public unsafe virtual void XI_ApcLocationNoLongerRequired()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ApcLocationNoLongerRequired, "BmGame.RHudModuleBespokeBase.XI_ApcLocationNoLongerRequired");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ShutdownFilmBombCounter;
    /// <summary>
    /// Function: XI_ShutdownFilmBombCounter
    /// </summary>
    public unsafe virtual void XI_ShutdownFilmBombCounter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ShutdownFilmBombCounter, "BmGame.RHudModuleBespokeBase.XI_ShutdownFilmBombCounter");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBombsRemaining;
    /// <summary>
    /// Function: SetBombsRemaining
    /// </summary>
    public unsafe virtual void SetBombsRemaining(int BombsRemaining)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBombsRemaining, "BmGame.RHudModuleBespokeBase.SetBombsRemaining");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BombsRemaining, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRobberyValues;
    /// <summary>
    /// Function: SetRobberyValues
    /// </summary>
    public unsafe virtual void SetRobberyValues(int MoneyInVault, int MoneyOnFloor, int MoneyBeingCarried, int MoneyStolen)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRobberyValues, "BmGame.RHudModuleBespokeBase.SetRobberyValues");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoneyInVault, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoneyOnFloor, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoneyBeingCarried, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoneyStolen, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTakedownsRemaining;
    /// <summary>
    /// Function: SetTakedownsRemaining
    /// </summary>
    public unsafe virtual void SetTakedownsRemaining(int _TakedownsRemaining)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTakedownsRemaining, "BmGame.RHudModuleBespokeBase.SetTakedownsRemaining");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_TakedownsRemaining, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckAndResetAllPurposeVariable;
    /// <summary>
    /// Function: CheckAndResetAllPurposeVariable
    /// </summary>
    public unsafe virtual int CheckAndResetAllPurposeVariable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAndResetAllPurposeVariable, "BmGame.RHudModuleBespokeBase.CheckAndResetAllPurposeVariable");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.RHudModuleBespokeBase.Close");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RHudModuleBespokeBase.Init");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// BoolProperty: RequiresManualUpdate
    /// </summary>
    public unsafe bool RequiresManualUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: SuppressLocalRadar
    /// </summary>
    public unsafe bool SuppressLocalRadar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: SuppressThreatLevel
    /// </summary>
    public unsafe bool SuppressThreatLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: SuppressSurveillance
    /// </summary>
    public unsafe bool SuppressSurveillance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: SuppressFocusDetail
    /// </summary>
    public unsafe bool SuppressFocusDetail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// IntProperty: AllPurposeVariable
    /// </summary>
    public unsafe int AllPurposeVariable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }
}
