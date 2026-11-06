#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGadgetSelect<br/>
/// (size = 120)
/// (flags = 134217874)
/// </summary>
public partial class RGadgetSelect : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGadgetSelect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGadgetSelect.
    /// </summary>
    public static RGadgetSelect DefaultObject => (RGadgetSelect)StaticClass().DefaultObject;

    internal RGadgetSelect() { }

    /// <summary>
    /// Constructs a new RGadgetSelect
    /// </summary>
    public RGadgetSelect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGadgetSelect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGadgetSelect(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGadgetSelect>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGadgetSelect>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGadgetSelect>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGadgetSelect>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGadgetSelect>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGadgetSelect>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGadgetSelect>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGadgetSelect>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DisplayedGadgetChanged;
    /// <summary>
    /// Function: DisplayedGadgetChanged
    /// </summary>
    public unsafe virtual void DisplayedGadgetChanged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayedGadgetChanged, "BmGame.RGadgetSelect.DisplayedGadgetChanged");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe virtual void DrawHUD(BmSDK.Engine.HUD H)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmGame.RGadgetSelect.DrawHUD");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickMainThread;
    /// <summary>
    /// Function: TickMainThread
    /// </summary>
    public unsafe virtual void TickMainThread(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickMainThread, "BmGame.RGadgetSelect.TickMainThread");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowFailedGadget;
    /// <summary>
    /// Function: ShowFailedGadget
    /// </summary>
    public unsafe virtual void ShowFailedGadget(BmSDK.BmGame.RInventoryGadget TheGadget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowFailedGadget, "BmGame.RGadgetSelect.ShowFailedGadget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendGadgetsToFlash;
    /// <summary>
    /// Function: SendGadgetsToFlash
    /// </summary>
    public unsafe virtual void SendGadgetsToFlash()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendGadgetsToFlash, "BmGame.RGadgetSelect.SendGadgetsToFlash");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GoOffscreen;
    /// <summary>
    /// Function: GoOffscreen
    /// </summary>
    public unsafe virtual void GoOffscreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoOffscreen, "BmGame.RGadgetSelect.GoOffscreen");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideGadgetSelect;
    /// <summary>
    /// Function: HideGadgetSelect
    /// </summary>
    public unsafe virtual void HideGadgetSelect()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideGadgetSelect, "BmGame.RGadgetSelect.HideGadgetSelect");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetUpdated;
    /// <summary>
    /// Function: GadgetUpdated
    /// </summary>
    public unsafe virtual void GadgetUpdated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetUpdated, "BmGame.RGadgetSelect.GadgetUpdated");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGadgetSelect.Init");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoubleGadget;
    /// <summary>
    /// Function: DoubleGadget
    /// </summary>
    public unsafe virtual void DoubleGadget(byte Row, byte column)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoubleGadget, "BmGame.RGadgetSelect.DoubleGadget");
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Row, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(column, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetSelected;
    /// <summary>
    /// Function: GadgetSelected
    /// </summary>
    public unsafe virtual void GadgetSelected(byte Row, byte column)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetSelected, "BmGame.RGadgetSelect.GadgetSelected");
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Row, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(column, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CycleGadgets;
    /// <summary>
    /// Function: CycleGadgets
    /// </summary>
    public unsafe virtual void CycleGadgets(int Direction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CycleGadgets, "BmGame.RGadgetSelect.CycleGadgets");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrevGadget;
    /// <summary>
    /// Function: PrevGadget
    /// </summary>
    public unsafe virtual void PrevGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrevGadget, "BmGame.RGadgetSelect.PrevGadget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NextGadget;
    /// <summary>
    /// Function: NextGadget
    /// </summary>
    public unsafe virtual void NextGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NextGadget, "BmGame.RGadgetSelect.NextGadget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SelectGadget;
    /// <summary>
    /// Function: SelectGadget
    /// </summary>
    public unsafe virtual void SelectGadget(int Gadget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectGadget, "BmGame.RGadgetSelect.SelectGadget");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateSelectedGadget;
    /// <summary>
    /// Function: UpdateSelectedGadget
    /// </summary>
    public unsafe virtual void UpdateSelectedGadget(float DeltaTime, bool bCanCycleGadgets)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSelectedGadget, "BmGame.RGadgetSelect.UpdateSelectedGadget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanCycleGadgets, paramsPtr + 4);
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

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe virtual void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RGadgetSelect.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHUDHidden;
    /// <summary>
    /// Function: SetHUDHidden
    /// </summary>
    public unsafe virtual void SetHUDHidden(bool bHide, bool bImmediate = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHUDHidden, "BmGame.RGadgetSelect.SetHUDHidden");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHide, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bImmediate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AutoSelectGadgetAndOpenHud;
    /// <summary>
    /// Function: AutoSelectGadgetAndOpenHud
    /// </summary>
    public unsafe virtual void AutoSelectGadgetAndOpenHud(BmSDK.Class GadgetClass, bool ShowChangeOnHud = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutoSelectGadgetAndOpenHud, "BmGame.RGadgetSelect.AutoSelectGadgetAndOpenHud");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowChangeOnHud, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetGadgetSelected;
    /// <summary>
    /// Function: GadgetGadgetSelected
    /// </summary>
    public unsafe virtual void GadgetGadgetSelected()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetGadgetSelected, "BmGame.RGadgetSelect.GadgetGadgetSelected");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnChanged;
    /// <summary>
    /// Function: PawnChanged
    /// </summary>
    public unsafe virtual void PawnChanged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnChanged, "BmGame.RGadgetSelect.PawnChanged");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPC;
    /// <summary>
    /// Function: GetPC
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPlayerController GetPC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPC, "BmGame.RGadgetSelect.GetPC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPlayerController>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: OwnerPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController OwnerPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: DiagonalInDelay
    /// </summary>
    public unsafe float DiagonalInDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: DiagonalOutDelay
    /// </summary>
    public unsafe float DiagonalOutDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ByteProperty: SelectedColumn
    /// </summary>
    public unsafe byte SelectedColumn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ByteProperty: SelectedRow
    /// </summary>
    public unsafe byte SelectedRow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 101); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 101); }
    }

    /// <summary>
    /// ByteProperty: LastColumn
    /// </summary>
    public unsafe byte LastColumn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 102); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 102); }
    }

    /// <summary>
    /// ByteProperty: LastRow
    /// </summary>
    public unsafe byte LastRow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 103); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 103); }
    }

    /// <summary>
    /// ByteProperty: DoubleTapColumn
    /// </summary>
    public unsafe byte DoubleTapColumn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ByteProperty: DoubleTapRow
    /// </summary>
    public unsafe byte DoubleTapRow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 105); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 105); }
    }

    /// <summary>
    /// FloatProperty: LastSelectionTime
    /// </summary>
    public unsafe float LastSelectionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: DoubleTapTimer
    /// </summary>
    public unsafe float DoubleTapTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: WaitingToRecentre
    /// </summary>
    public unsafe bool WaitingToRecentre
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }
}
