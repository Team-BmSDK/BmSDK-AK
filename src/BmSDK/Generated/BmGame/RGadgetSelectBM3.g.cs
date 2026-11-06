#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGadgetSelectBM3<br/>
/// (size = 157)
/// (flags = 18)
/// </summary>
public partial class RGadgetSelectBM3 : BmSDK.BmGame.RGadgetSelect, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGadgetSelectBM3", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGadgetSelectBM3.
    /// </summary>
    public static RGadgetSelectBM3 DefaultObject => (RGadgetSelectBM3)StaticClass().DefaultObject;

    internal RGadgetSelectBM3() { }

    /// <summary>
    /// Constructs a new RGadgetSelectBM3
    /// </summary>
    public RGadgetSelectBM3(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGadgetSelectBM3 Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGadgetSelectBM3(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGadgetSelectBM3>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGadgetSelectBM3>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGadgetSelectBM3>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGadgetSelectBM3>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGadgetSelectBM3>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGadgetSelectBM3>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGadgetSelectBM3>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGadgetSelectBM3>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PawnChanged;
    /// <summary>
    /// Function: PawnChanged
    /// </summary>
    public unsafe override void PawnChanged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnChanged, "BmGame.RGadgetSelectBM3.PawnChanged");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideGadgetSelect;
    /// <summary>
    /// Function: HideGadgetSelect
    /// </summary>
    public unsafe override void HideGadgetSelect()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideGadgetSelect, "BmGame.RGadgetSelectBM3.HideGadgetSelect");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickMainThread;
    /// <summary>
    /// Function: TickMainThread
    /// </summary>
    public unsafe override void TickMainThread(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickMainThread, "BmGame.RGadgetSelectBM3.TickMainThread");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RGadgetSelectBM3.Tick");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoCloseWheel;
    /// <summary>
    /// Function: DoCloseWheel
    /// </summary>
    public unsafe virtual void DoCloseWheel(bool force_closed = default, bool force_shutdown = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoCloseWheel, "BmGame.RGadgetSelectBM3.DoCloseWheel");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(force_closed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(force_shutdown, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVisualState;
    /// <summary>
    /// Function: SetVisualState
    /// </summary>
    public unsafe virtual void SetVisualState(BmSDK.BmGame.RGadgetSelectBM3.EGadgetWheelState new_state)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVisualState, "BmGame.RGadgetSelectBM3.SetVisualState");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_state, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldSetOffscreen;
    /// <summary>
    /// Function: ShouldSetOffscreen
    /// </summary>
    public unsafe virtual void ShouldSetOffscreen(bool _bShouldMoveOffscreen)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSetOffscreen, "BmGame.RGadgetSelectBM3.ShouldSetOffscreen");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_bShouldMoveOffscreen, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGadgetIndexPC;
    /// <summary>
    /// Function: GetGadgetIndexPC
    /// </summary>
    public unsafe virtual int GetGadgetIndexPC(BmSDK.FName GadgetName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetIndexPC, "BmGame.RGadgetSelectBM3.GetGadgetIndexPC");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetGadgetIndex;
    /// <summary>
    /// Function: GetGadgetIndex
    /// </summary>
    public unsafe virtual int GetGadgetIndex(BmSDK.FName GadgetName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetIndex, "BmGame.RGadgetSelectBM3.GetGadgetIndex");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ShowRequiredGadget;
    /// <summary>
    /// Function: ShowRequiredGadget
    /// </summary>
    public unsafe virtual void ShowRequiredGadget(BmSDK.FName RequiredGadget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowRequiredGadget, "BmGame.RGadgetSelectBM3.ShowRequiredGadget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequiredGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowFailedGadget;
    /// <summary>
    /// Function: ShowFailedGadget
    /// </summary>
    public unsafe override void ShowFailedGadget(BmSDK.BmGame.RInventoryGadget TheGadget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowFailedGadget, "BmGame.RGadgetSelectBM3.ShowFailedGadget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowQuickfireGadget;
    /// <summary>
    /// Function: ShowQuickfireGadget
    /// </summary>
    public unsafe virtual void ShowQuickfireGadget(BmSDK.BmGame.RInventoryGadget TheGadget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowQuickfireGadget, "BmGame.RGadgetSelectBM3.ShowQuickfireGadget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGadgetList;
    /// <summary>
    /// Function: UpdateGadgetList
    /// </summary>
    public unsafe virtual void UpdateGadgetList()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGadgetList, "BmGame.RGadgetSelectBM3.UpdateGadgetList");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AutoSelectGadgetAndOpenHud;
    /// <summary>
    /// Function: AutoSelectGadgetAndOpenHud
    /// </summary>
    public unsafe override void AutoSelectGadgetAndOpenHud(BmSDK.Class GadgetClass, bool ShowChangeOnHud = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutoSelectGadgetAndOpenHud, "BmGame.RGadgetSelectBM3.AutoSelectGadgetAndOpenHud");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowChangeOnHud, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayedGadgetChanged;
    /// <summary>
    /// Function: DisplayedGadgetChanged
    /// </summary>
    public unsafe override void DisplayedGadgetChanged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayedGadgetChanged, "BmGame.RGadgetSelectBM3.DisplayedGadgetChanged");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGadgetByName;
    /// <summary>
    /// Function: GetGadgetByName
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RInventoryGadget GetGadgetByName(int gadget_index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetByName, "BmGame.RGadgetSelectBM3.GetGadgetByName");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(gadget_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GoOffscreen;
    /// <summary>
    /// Function: GoOffscreen
    /// </summary>
    public unsafe override void GoOffscreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoOffscreen, "BmGame.RGadgetSelectBM3.GoOffscreen");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AutoSelectCurrentGadget;
    /// <summary>
    /// Function: AutoSelectCurrentGadget
    /// </summary>
    public unsafe virtual void AutoSelectCurrentGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutoSelectCurrentGadget, "BmGame.RGadgetSelectBM3.AutoSelectCurrentGadget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AutocorrectCharacterGadgets;
    /// <summary>
    /// Function: AutocorrectCharacterGadgets
    /// </summary>
    public unsafe virtual void AutocorrectCharacterGadgets(BmSDK.BmGame.RAddContentPlayerCharacter the_character)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutocorrectCharacterGadgets, "BmGame.RGadgetSelectBM3.AutocorrectCharacterGadgets");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_character, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Synchronise;
    /// <summary>
    /// Function: Synchronise
    /// </summary>
    public unsafe virtual void Synchronise()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Synchronise, "BmGame.RGadgetSelectBM3.Synchronise");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGadgetSelectBM3.Init");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: EGadgetWheelState
    /// </summary>
    public enum EGadgetWheelState : byte
    {
        GWS_Offscreen = 0,
        GWS_Collapsed = 1,
        GWS_WheelVisible = 2,
        GWS_MAX = 3,
    }

    /// <summary>
    /// BoolProperty: bIsSynced
    /// </summary>
    public unsafe bool bIsSynced
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: bShouldMoveOffscreen
    /// </summary>
    public unsafe bool bShouldMoveOffscreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: bCornerGadgetVisible
    /// </summary>
    public unsafe bool bCornerGadgetVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: InTapMode
    /// </summary>
    public unsafe bool InTapMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: EarlySelection
    /// </summary>
    public unsafe bool EarlySelection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: IgnoreRightTrigger
    /// </summary>
    public unsafe bool IgnoreRightTrigger
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: IgnoreRunButton
    /// </summary>
    public unsafe bool IgnoreRunButton
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: IgnoreCancelButton
    /// </summary>
    public unsafe bool IgnoreCancelButton
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: VoiceCommandClose
    /// </summary>
    public unsafe bool VoiceCommandClose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: bDisabledByChallengeEnded
    /// </summary>
    public unsafe bool bDisabledByChallengeEnded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// IntProperty: RequiredGadgetIndex
    /// </summary>
    public unsafe int RequiredGadgetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: fShowReadiedGadgetCountUp
    /// </summary>
    public unsafe float fShowReadiedGadgetCountUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// FloatProperty: fGoOffscreenCountdown
    /// </summary>
    public unsafe float fGoOffscreenCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// FloatProperty: fGoOffscreenPeriod
    /// </summary>
    public unsafe float fGoOffscreenPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceDeployed
    /// </summary>
    public unsafe float TimeSinceDeployed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: EarlySelectionDelay
    /// </summary>
    public unsafe float EarlySelectionDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ObjectProperty: InvMan
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryManager InvMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryManager>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ByteProperty: CurrentGadgetWheelState
    /// </summary>
    public unsafe BmSDK.BmGame.RGadgetSelectBM3.EGadgetWheelState CurrentGadgetWheelState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGadgetSelectBM3.EGadgetWheelState>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
}
