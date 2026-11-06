#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieRadialGadgetSelect<br/>
/// (size = 1488)
/// (flags = 134217878)
/// </summary>
public partial class RGFxMovieRadialGadgetSelect : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieRadialGadgetSelect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieRadialGadgetSelect.
    /// </summary>
    public static RGFxMovieRadialGadgetSelect DefaultObject => (RGFxMovieRadialGadgetSelect)StaticClass().DefaultObject;

    internal RGFxMovieRadialGadgetSelect() { }

    /// <summary>
    /// Constructs a new RGFxMovieRadialGadgetSelect
    /// </summary>
    public RGFxMovieRadialGadgetSelect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieRadialGadgetSelect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieRadialGadgetSelect(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieRadialGadgetSelect>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieRadialGadgetSelect>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieRadialGadgetSelect>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieRadialGadgetSelect>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieRadialGadgetSelect>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieRadialGadgetSelect>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieRadialGadgetSelect>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieRadialGadgetSelect>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_XI_GetScreenSize;
    /// <summary>
    /// Function: XI_GetScreenSize
    /// </summary>
    public unsafe virtual void XI_GetScreenSize(BmSDK.FString TargetPath, BmSDK.FString WidthVariableName, BmSDK.FString HeightVariableName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetScreenSize, "BmGame.RGFxMovieRadialGadgetSelect.XI_GetScreenSize");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidthVariableName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeightVariableName, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleVoiceRec;
    /// <summary>
    /// Function: HandleVoiceRec
    /// </summary>
    public unsafe override bool HandleVoiceRec(BmSDK.FString VoiceRecCommand)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleVoiceRec, "BmGame.RGFxMovieRadialGadgetSelect.HandleVoiceRec");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VoiceRecCommand, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ShowTapModePrompts;
    /// <summary>
    /// Function: ShowTapModePrompts
    /// </summary>
    public unsafe virtual void ShowTapModePrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowTapModePrompts, "BmGame.RGFxMovieRadialGadgetSelect.ShowTapModePrompts");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePrompts;
    /// <summary>
    /// Function: UpdatePrompts
    /// </summary>
    public unsafe virtual void UpdatePrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePrompts, "BmGame.RGFxMovieRadialGadgetSelect.UpdatePrompts");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRequiredGadgetPrompt;
    /// <summary>
    /// Function: SetRequiredGadgetPrompt
    /// </summary>
    public unsafe virtual void SetRequiredGadgetPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRequiredGadgetPrompt, "BmGame.RGFxMovieRadialGadgetSelect.SetRequiredGadgetPrompt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMoving;
    /// <summary>
    /// Function: SetMoving
    /// </summary>
    public unsafe virtual void SetMoving(bool Moving)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMoving, "BmGame.RGFxMovieRadialGadgetSelect.SetMoving");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Moving, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHighlightAudio;
    /// <summary>
    /// Function: PlayHighlightAudio
    /// </summary>
    public unsafe virtual void PlayHighlightAudio()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHighlightAudio, "BmGame.RGFxMovieRadialGadgetSelect.PlayHighlightAudio");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGadgetSelect;
    /// <summary>
    /// Function: UpdateGadgetSelect
    /// </summary>
    public unsafe virtual void UpdateGadgetSelect()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGadgetSelect, "BmGame.RGFxMovieRadialGadgetSelect.UpdateGadgetSelect");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CycleGadgets;
    /// <summary>
    /// Function: CycleGadgets
    /// </summary>
    public unsafe virtual void CycleGadgets(int Direction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CycleGadgets, "BmGame.RGFxMovieRadialGadgetSelect.CycleGadgets");
        byte* paramsPtr = stackalloc byte[36];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrevGadget, "BmGame.RGFxMovieRadialGadgetSelect.PrevGadget");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NextGadget, "BmGame.RGFxMovieRadialGadgetSelect.NextGadget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ManualSelectGadget;
    /// <summary>
    /// Function: ManualSelectGadget
    /// </summary>
    public unsafe virtual void ManualSelectGadget(int gadgetIndex, bool selectedByScroll = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManualSelectGadget, "BmGame.RGFxMovieRadialGadgetSelect.ManualSelectGadget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(gadgetIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(selectedByScroll, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckIndexAndShowQuickfireGadget;
    /// <summary>
    /// Function: CheckIndexAndShowQuickfireGadget
    /// </summary>
    public unsafe virtual void CheckIndexAndShowQuickfireGadget(int gadgetIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckIndexAndShowQuickfireGadget, "BmGame.RGFxMovieRadialGadgetSelect.CheckIndexAndShowQuickfireGadget");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(gadgetIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SyncInventoryGadget;
    /// <summary>
    /// Function: SyncInventoryGadget
    /// </summary>
    public unsafe virtual void SyncInventoryGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SyncInventoryGadget, "BmGame.RGFxMovieRadialGadgetSelect.SyncInventoryGadget");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostCloseGadgetAction;
    /// <summary>
    /// Function: PostCloseGadgetAction
    /// </summary>
    public unsafe virtual void PostCloseGadgetAction()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostCloseGadgetAction, "BmGame.RGFxMovieRadialGadgetSelect.PostCloseGadgetAction");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateControlStick;
    /// <summary>
    /// Function: UpdateControlStick
    /// </summary>
    public unsafe virtual void UpdateControlStick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateControlStick, "BmGame.RGFxMovieRadialGadgetSelect.UpdateControlStick");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateControlStickXy;
    /// <summary>
    /// Function: UpdateControlStickXy
    /// </summary>
    public unsafe virtual void UpdateControlStickXy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateControlStickXy, "BmGame.RGFxMovieRadialGadgetSelect.UpdateControlStickXy");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowRequiredGadgetIndex;
    /// <summary>
    /// Function: ShowRequiredGadgetIndex
    /// </summary>
    public unsafe virtual void ShowRequiredGadgetIndex(int _RequiredGadget_OutOfSixteen)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowRequiredGadgetIndex, "BmGame.RGFxMovieRadialGadgetSelect.ShowRequiredGadgetIndex");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RequiredGadget_OutOfSixteen, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowFailedGadget;
    /// <summary>
    /// Function: ShowFailedGadget
    /// </summary>
    public unsafe virtual void ShowFailedGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowFailedGadget, "BmGame.RGFxMovieRadialGadgetSelect.ShowFailedGadget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideCurrentGadget;
    /// <summary>
    /// Function: HideCurrentGadget
    /// </summary>
    public unsafe virtual void HideCurrentGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideCurrentGadget, "BmGame.RGFxMovieRadialGadgetSelect.HideCurrentGadget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowCurrentGadget;
    /// <summary>
    /// Function: ShowCurrentGadget
    /// </summary>
    public unsafe virtual void ShowCurrentGadget(int gadget_index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCurrentGadget, "BmGame.RGFxMovieRadialGadgetSelect.ShowCurrentGadget");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(gadget_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SelectWheelGadgetPrivate;
    /// <summary>
    /// Function: SelectWheelGadgetPrivate
    /// </summary>
    public unsafe virtual void SelectWheelGadgetPrivate(int gadget_index, bool Snap)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectWheelGadgetPrivate, "BmGame.RGFxMovieRadialGadgetSelect.SelectWheelGadgetPrivate");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(gadget_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Snap, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SelectWheelGadget;
    /// <summary>
    /// Function: SelectWheelGadget
    /// </summary>
    public unsafe virtual void SelectWheelGadget(int gadget_index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectWheelGadget, "BmGame.RGFxMovieRadialGadgetSelect.SelectWheelGadget");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(gadget_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseWheel;
    /// <summary>
    /// Function: CloseWheel
    /// </summary>
    public unsafe virtual void CloseWheel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseWheel, "BmGame.RGFxMovieRadialGadgetSelect.CloseWheel");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_UpdateSelectedGadgetIndex;
    /// <summary>
    /// Function: DXI_UpdateSelectedGadgetIndex
    /// </summary>
    public unsafe virtual void DXI_UpdateSelectedGadgetIndex(BmSDK.FString InIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_UpdateSelectedGadgetIndex, "BmGame.RGFxMovieRadialGadgetSelect.DXI_UpdateSelectedGadgetIndex");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenWheelPrivate_RhdUpg;
    /// <summary>
    /// Function: OpenWheelPrivate_RhdUpg
    /// </summary>
    public unsafe virtual void OpenWheelPrivate_RhdUpg(int selected_gadget, bool RhdUpgraded)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenWheelPrivate_RhdUpg, "BmGame.RGFxMovieRadialGadgetSelect.OpenWheelPrivate_RhdUpg");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(selected_gadget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RhdUpgraded, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenWheelPrivate;
    /// <summary>
    /// Function: OpenWheelPrivate
    /// </summary>
    public unsafe virtual void OpenWheelPrivate(int selected_gadget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenWheelPrivate, "BmGame.RGFxMovieRadialGadgetSelect.OpenWheelPrivate");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(selected_gadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenWheel;
    /// <summary>
    /// Function: OpenWheel
    /// </summary>
    public unsafe virtual void OpenWheel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenWheel, "BmGame.RGFxMovieRadialGadgetSelect.OpenWheel");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceFocus;
    /// <summary>
    /// Function: ForceFocus
    /// </summary>
    public unsafe virtual void ForceFocus(bool GiveFocus)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceFocus, "BmGame.RGFxMovieRadialGadgetSelect.ForceFocus");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GiveFocus, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGadgetParams;
    /// <summary>
    /// Function: UpdateGadgetParams
    /// </summary>
    public unsafe virtual void UpdateGadgetParams(int gadget_index, int recharge_percent, int ammo_single_value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGadgetParams, "BmGame.RGFxMovieRadialGadgetSelect.UpdateGadgetParams");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(gadget_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(recharge_percent, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ammo_single_value, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendGadgetsToFlashPrivate;
    /// <summary>
    /// Function: SendGadgetsToFlashPrivate
    /// </summary>
    public unsafe virtual void SendGadgetsToFlashPrivate(BmSDK.FString character_acronym, int max_slots, BmSDK.FString comma_separated_gadget_list)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendGadgetsToFlashPrivate, "BmGame.RGFxMovieRadialGadgetSelect.SendGadgetsToFlashPrivate");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(character_acronym, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(max_slots, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(comma_separated_gadget_list, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendGadgetsToFlash;
    /// <summary>
    /// Function: SendGadgetsToFlash
    /// </summary>
    public unsafe virtual void SendGadgetsToFlash()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendGadgetsToFlash, "BmGame.RGFxMovieRadialGadgetSelect.SendGadgetsToFlash");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWheelArrowAngle;
    /// <summary>
    /// Function: SetWheelArrowAngle
    /// </summary>
    public unsafe virtual void SetWheelArrowAngle(float new_angle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWheelArrowAngle, "BmGame.RGFxMovieRadialGadgetSelect.SetWheelArrowAngle");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_angle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnClose;
    /// <summary>
    /// Function: OnClose
    /// </summary>
    public unsafe override void OnClose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClose, "BmGame.RGFxMovieRadialGadgetSelect.OnClose");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPromptPrivate;
    /// <summary>
    /// Function: SetPromptPrivate
    /// </summary>
    public unsafe virtual void SetPromptPrivate(int Id, bool bMain, BmSDK.FString PadText, BmSDK.FString PCText, BmSDK.FString Label, float Alpha)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPromptPrivate, "BmGame.RGFxMovieRadialGadgetSelect.SetPromptPrivate");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMain, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PadText, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PCText, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPrompt;
    /// <summary>
    /// Function: SetPrompt
    /// </summary>
    public unsafe virtual void SetPrompt(int Id, BmSDK.FString Label, float Alpha = default, bool bAsMain = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrompt, "BmGame.RGFxMovieRadialGadgetSelect.SetPrompt");
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAsMain, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReLayoutPrompts;
    /// <summary>
    /// Function: ReLayoutPrompts
    /// </summary>
    public unsafe virtual void ReLayoutPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReLayoutPrompts, "BmGame.RGFxMovieRadialGadgetSelect.ReLayoutPrompts");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearPrompts;
    /// <summary>
    /// Function: ClearPrompts
    /// </summary>
    public unsafe virtual void ClearPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPrompts, "BmGame.RGFxMovieRadialGadgetSelect.ClearPrompts");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAspectRatioChanged;
    /// <summary>
    /// Function: OnAspectRatioChanged
    /// </summary>
    public unsafe override void OnAspectRatioChanged(float aspect_ratio)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAspectRatioChanged, "BmGame.RGFxMovieRadialGadgetSelect.OnAspectRatioChanged");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aspect_ratio, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHudVisibility;
    /// <summary>
    /// Function: UpdateHudVisibility
    /// </summary>
    public unsafe override void UpdateHudVisibility(bool bVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHudVisibility, "BmGame.RGFxMovieRadialGadgetSelect.UpdateHudVisibility");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLeftCornerGadgetVisible;
    /// <summary>
    /// Function: SetLeftCornerGadgetVisible
    /// </summary>
    public unsafe virtual void SetLeftCornerGadgetVisible(bool _bLeftCornerGadgetVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLeftCornerGadgetVisible, "BmGame.RGFxMovieRadialGadgetSelect.SetLeftCornerGadgetVisible");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_bLeftCornerGadgetVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWheelOpen;
    /// <summary>
    /// Function: SetWheelOpen
    /// </summary>
    public unsafe virtual void SetWheelOpen(bool _bWheelOpen)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWheelOpen, "BmGame.RGFxMovieRadialGadgetSelect.SetWheelOpen");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_bWheelOpen, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterAsManualAdvanceMovie;
    /// <summary>
    /// Function: RegisterAsManualAdvanceMovie
    /// </summary>
    public unsafe virtual void RegisterAsManualAdvanceMovie(bool do_register)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterAsManualAdvanceMovie, "BmGame.RGFxMovieRadialGadgetSelect.RegisterAsManualAdvanceMovie");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(do_register, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessDeferredInterfaceCalls;
    /// <summary>
    /// Function: ProcessDeferredInterfaceCalls
    /// </summary>
    public unsafe virtual void ProcessDeferredInterfaceCalls()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessDeferredInterfaceCalls, "BmGame.RGFxMovieRadialGadgetSelect.ProcessDeferredInterfaceCalls");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IndividualDeferredInterfaceCall;
    /// <summary>
    /// Function: IndividualDeferredInterfaceCall
    /// </summary>
    public unsafe virtual void IndividualDeferredInterfaceCall(BmSDK.TArray<BmSDK.FString> param_array)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IndividualDeferredInterfaceCall, "BmGame.RGFxMovieRadialGadgetSelect.IndividualDeferredInterfaceCall");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(param_array, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessDeferredInterfaceCallsNative;
    /// <summary>
    /// Function: ProcessDeferredInterfaceCallsNative
    /// </summary>
    public unsafe virtual void ProcessDeferredInterfaceCallsNative(BmSDK.FString DeferredExternalInterfaceCalls)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessDeferredInterfaceCallsNative, "BmGame.RGFxMovieRadialGadgetSelect.ProcessDeferredInterfaceCallsNative");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeferredExternalInterfaceCalls, paramsPtr + 0);
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

    private static BmSDK.Function __fn_CheckGadgetWheel;
    /// <summary>
    /// Function: CheckGadgetWheel
    /// </summary>
    public unsafe virtual int CheckGadgetWheel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckGadgetWheel, "BmGame.RGFxMovieRadialGadgetSelect.CheckGadgetWheel");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_PushDeferredCallsToGame;
    /// <summary>
    /// Function: XI_PushDeferredCallsToGame
    /// </summary>
    public unsafe virtual void XI_PushDeferredCallsToGame(BmSDK.FString deferred_calls)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_PushDeferredCallsToGame, "BmGame.RGFxMovieRadialGadgetSelect.XI_PushDeferredCallsToGame");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(deferred_calls, paramsPtr + 0);
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

    private static BmSDK.Function __fn_CheckAndClearDeferredCalls;
    /// <summary>
    /// Function: CheckAndClearDeferredCalls
    /// </summary>
    public unsafe virtual BmSDK.FString CheckAndClearDeferredCalls()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAndClearDeferredCalls, "BmGame.RGFxMovieRadialGadgetSelect.CheckAndClearDeferredCalls");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ManualAdvanceTick;
    /// <summary>
    /// Function: ManualAdvanceTick
    /// </summary>
    public unsafe override void ManualAdvanceTick(float DeltaT)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManualAdvanceTick, "BmGame.RGFxMovieRadialGadgetSelect.ManualAdvanceTick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaT, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovieRadialGadgetSelect.Init");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bWheelOpen
    /// </summary>
    public unsafe bool bWheelOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bLeftCornerGadgetVisible
    /// </summary>
    public unsafe bool bLeftCornerGadgetVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bRegisteredAsManualAdvanceMovie
    /// </summary>
    public unsafe bool bRegisteredAsManualAdvanceMovie
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bIsMoving
    /// </summary>
    public unsafe bool bIsMoving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: GadgetChangeWhileOpen
    /// </summary>
    public unsafe bool GadgetChangeWhileOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: PostCloseGadgetActionQueued
    /// </summary>
    public unsafe bool PostCloseGadgetActionQueued
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: DeregisterCountdown
    /// </summary>
    public unsafe float DeregisterCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// StructProperty: WorldPPSettings
    /// </summary>
    public unsafe ref BmSDK.Engine.PostProcessVolume.FPostProcessSettings WorldPPSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.PostProcessVolume.FPostProcessSettings>(Ptr + 704);

    /// <summary>
    /// IntProperty: SelectedGadgetIndex
    /// </summary>
    public unsafe int SelectedGadgetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// IntProperty: SelectedGadgetIndex_Inventory
    /// </summary>
    public unsafe int SelectedGadgetIndex_Inventory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// IntProperty: LeftCornerGadgetIndex
    /// </summary>
    public unsafe int LeftCornerGadgetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// IntProperty: RequiredGadget_OutOfSixteen
    /// </summary>
    public unsafe int RequiredGadget_OutOfSixteen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// IntProperty: NumWheelSlots
    /// </summary>
    public unsafe int NumWheelSlots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// FloatProperty: RadiansPerGadget
    /// </summary>
    public unsafe float RadiansPerGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// FloatProperty: LastAngleSent
    /// </summary>
    public unsafe float LastAngleSent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: CurrentlyLoadedGadgets
    /// </summary>
    public InlineArray<BmSDK.FName> CurrentlyLoadedGadgets => new(12, Ptr + 1256, 8, this);

    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// FloatProperty: ControlStickX
    /// </summary>
    public unsafe float ControlStickX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// FloatProperty: ControlStickY
    /// </summary>
    public unsafe float ControlStickY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// FloatProperty: StickMagLastFrame
    /// </summary>
    public unsafe float StickMagLastFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// ObjectProperty: CloseWheelEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CloseWheelEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// ObjectProperty: CloseWheelEquipEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CloseWheelEquipEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// ObjectProperty: WheelHighlightEmptyEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WheelHighlightEmptyEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// ObjectProperty: WheelHighlightGadgetEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WheelHighlightGadgetEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// ObjectProperty: PlayWheelMoveEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent PlayWheelMoveEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// ObjectProperty: StopWheelMoveEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StopWheelMoveEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// ObjectProperty: WheelOpenEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WheelOpenEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// FloatProperty: TimeInMenu
    /// </summary>
    public unsafe float TimeInMenu
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// StrProperty: DeferredExternalInterfaceCallsString
    /// </summary>
    public unsafe BmSDK.FString DeferredExternalInterfaceCallsString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: CycleGadgetsIndexOrder
    /// </summary>
    public InlineArray<int> CycleGadgetsIndexOrder => new(12, Ptr + 1440, 4, this);

    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }
}
