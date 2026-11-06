#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_SaveSlotSelect<br/>
/// (size = 1272)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_SaveSlotSelect : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_SaveSlotSelect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_SaveSlotSelect.
    /// </summary>
    public static RGFxMovieUI_SaveSlotSelect DefaultObject => (RGFxMovieUI_SaveSlotSelect)StaticClass().DefaultObject;

    internal RGFxMovieUI_SaveSlotSelect() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_SaveSlotSelect
    /// </summary>
    public RGFxMovieUI_SaveSlotSelect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_SaveSlotSelect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_SaveSlotSelect(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_SaveSlotSelect>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_SaveSlotSelect>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_SaveSlotSelect>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_SaveSlotSelect>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_SaveSlotSelect>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_SaveSlotSelect>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_SaveSlotSelect>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_SaveSlotSelect>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ChangeCalibState;
    /// <summary>
    /// Function: ChangeCalibState
    /// </summary>
    public unsafe virtual void ChangeCalibState(bool bOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeCalibState, "BmScript.RGFxMovieUI_SaveSlotSelect.ChangeCalibState");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnLostFocus;
    /// <summary>
    /// Function: XI_OnLostFocus
    /// </summary>
    public unsafe override void XI_OnLostFocus(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnLostFocus, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_OnLostFocus");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnFocusDifficultyMenu;
    /// <summary>
    /// Function: XI_OnFocusDifficultyMenu
    /// </summary>
    public unsafe virtual void XI_OnFocusDifficultyMenu(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnFocusDifficultyMenu, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_OnFocusDifficultyMenu");
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnBack;
    /// <summary>
    /// Function: XI_OnBack
    /// </summary>
    public unsafe override void XI_OnBack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnBack, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_OnBack");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnClickedDifficultyMenu;
    /// <summary>
    /// Function: XI_OnClickedDifficultyMenu
    /// </summary>
    public unsafe virtual void XI_OnClickedDifficultyMenu(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnClickedDifficultyMenu, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_OnClickedDifficultyMenu");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Set;
    /// <summary>
    /// Function: XI_Set
    /// </summary>
    public unsafe virtual void XI_Set(int Id, BmSDK.FString Type, int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Set, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_Set");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Get;
    /// <summary>
    /// Function: XI_Get
    /// </summary>
    public unsafe virtual int XI_Get(int Id, BmSDK.FString Type)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Get, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_Get");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_XI_GetDefault;
    /// <summary>
    /// Function: XI_GetDefault
    /// </summary>
    public unsafe virtual int XI_GetDefault(int Id, BmSDK.FString Type)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetDefault, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_GetDefault");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_AreAllOnDefaults;
    /// <summary>
    /// Function: AreAllOnDefaults
    /// </summary>
    public unsafe virtual bool AreAllOnDefaults()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreAllOnDefaults, "BmScript.RGFxMovieUI_SaveSlotSelect.AreAllOnDefaults");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_SetupDifficultyMenu;
    /// <summary>
    /// Function: XI_SetupDifficultyMenu
    /// </summary>
    public unsafe virtual void XI_SetupDifficultyMenu(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetupDifficultyMenu, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_SetupDifficultyMenu");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnDifficultyClosed;
    /// <summary>
    /// Function: XI_OnDifficultyClosed
    /// </summary>
    public unsafe virtual void XI_OnDifficultyClosed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnDifficultyClosed, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_OnDifficultyClosed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnDifficultyOpened;
    /// <summary>
    /// Function: XI_OnDifficultyOpened
    /// </summary>
    public unsafe virtual void XI_OnDifficultyOpened()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnDifficultyOpened, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_OnDifficultyOpened");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_CloseDifficulty;
    /// <summary>
    /// Function: UC_CloseDifficulty
    /// </summary>
    public unsafe virtual void UC_CloseDifficulty()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_CloseDifficulty, "BmScript.RGFxMovieUI_SaveSlotSelect.UC_CloseDifficulty");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_OpenDifficulty;
    /// <summary>
    /// Function: UC_OpenDifficulty
    /// </summary>
    public unsafe virtual void UC_OpenDifficulty()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_OpenDifficulty, "BmScript.RGFxMovieUI_SaveSlotSelect.UC_OpenDifficulty");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenDifficultyMenu;
    /// <summary>
    /// Function: OpenDifficultyMenu
    /// </summary>
    public unsafe virtual void OpenDifficultyMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenDifficultyMenu, "BmScript.RGFxMovieUI_SaveSlotSelect.OpenDifficultyMenu");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitShowBackups;
    /// <summary>
    /// Function: ExitShowBackups
    /// </summary>
    public unsafe virtual void ExitShowBackups()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitShowBackups, "BmScript.RGFxMovieUI_SaveSlotSelect.ExitShowBackups");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CycleBackups;
    /// <summary>
    /// Function: CycleBackups
    /// </summary>
    public unsafe virtual void CycleBackups()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CycleBackups, "BmScript.RGFxMovieUI_SaveSlotSelect.CycleBackups");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefreshTooltip;
    /// <summary>
    /// Function: RefreshTooltip
    /// </summary>
    public unsafe virtual void RefreshTooltip()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshTooltip, "BmScript.RGFxMovieUI_SaveSlotSelect.RefreshTooltip");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnKey;
    /// <summary>
    /// Function: XI_OnKey
    /// </summary>
    public unsafe override void XI_OnKey(int KeyCode, bool bDown)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnKey, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_OnKey");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyCode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDown, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnFocus;
    /// <summary>
    /// Function: XI_OnFocus
    /// </summary>
    public unsafe override void XI_OnFocus(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnFocus, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_OnFocus");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Tick;
    /// <summary>
    /// Function: XI_Tick
    /// </summary>
    public unsafe override void XI_Tick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Tick, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_Tick");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePrompts, "BmScript.RGFxMovieUI_SaveSlotSelect.UpdatePrompts");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopupRequester_Callback;
    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe override void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmScript.RGFxMovieUI_SaveSlotSelect.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverwriteSave;
    /// <summary>
    /// Function: OverwriteSave
    /// </summary>
    public unsafe virtual void OverwriteSave()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverwriteSave, "BmScript.RGFxMovieUI_SaveSlotSelect.OverwriteSave");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDeleteUserFileComplete;
    /// <summary>
    /// Function: OnDeleteUserFileComplete
    /// </summary>
    public unsafe virtual void OnDeleteUserFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeleteUserFileComplete, "BmScript.RGFxMovieUI_SaveSlotSelect.OnDeleteUserFileComplete");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeleteSave;
    /// <summary>
    /// Function: DeleteSave
    /// </summary>
    public unsafe virtual void DeleteSave()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeleteSave, "BmScript.RGFxMovieUI_SaveSlotSelect.DeleteSave");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_DeleteSaveGame;
    /// <summary>
    /// Function: XI_DeleteSaveGame
    /// </summary>
    public unsafe virtual void XI_DeleteSaveGame(BmSDK.FString Ref, int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_DeleteSaveGame, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_DeleteSaveGame");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Ref, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetData;
    /// <summary>
    /// Function: SetData
    /// </summary>
    public unsafe virtual void SetData(BmSDK.FString Ref, BmSDK.FString Location, BmSDK.FString TimePlayed, BmSDK.FString Difficulty, BmSDK.FString Percentage, int PlayerIcon, bool bNewGame, bool bCorrupt, bool bFuture, int BackupNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetData, "BmScript.RGFxMovieUI_SaveSlotSelect.SetData");
        byte* paramsPtr = stackalloc byte[100];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Ref, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Location, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimePlayed, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Difficulty, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Percentage, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIcon, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewGame, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCorrupt, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFuture, paramsPtr + 92);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BackupNum, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetSaveGameInfo;
    /// <summary>
    /// Function: XI_GetSaveGameInfo
    /// </summary>
    public unsafe virtual void XI_GetSaveGameInfo(BmSDK.FString Ref, int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetSaveGameInfo, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_GetSaveGameInfo");
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Ref, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SaveLoadedContinueOn;
    /// <summary>
    /// Function: SaveLoadedContinueOn
    /// </summary>
    public unsafe virtual void SaveLoadedContinueOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveLoadedContinueOn, "BmScript.RGFxMovieUI_SaveSlotSelect.SaveLoadedContinueOn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnClicked;
    /// <summary>
    /// Function: XI_OnClicked
    /// </summary>
    public unsafe override void XI_OnClicked(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnClicked, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_OnClicked");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SaveToNewSlot;
    /// <summary>
    /// Function: SaveToNewSlot
    /// </summary>
    public unsafe virtual void SaveToNewSlot()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveToNewSlot, "BmScript.RGFxMovieUI_SaveSlotSelect.SaveToNewSlot");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSaveFileComplete;
    /// <summary>
    /// Function: OnSaveFileComplete
    /// </summary>
    public unsafe virtual void OnSaveFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSaveFileComplete, "BmScript.RGFxMovieUI_SaveSlotSelect.OnSaveFileComplete");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadSaveGame;
    /// <summary>
    /// Function: LoadSaveGame
    /// </summary>
    public unsafe virtual void LoadSaveGame()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadSaveGame, "BmScript.RGFxMovieUI_SaveSlotSelect.LoadSaveGame");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoadFileComplete;
    /// <summary>
    /// Function: OnLoadFileComplete
    /// </summary>
    public unsafe virtual void OnLoadFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoadFileComplete, "BmScript.RGFxMovieUI_SaveSlotSelect.OnLoadFileComplete");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CorruptSaveUI;
    /// <summary>
    /// Function: CorruptSaveUI
    /// </summary>
    public unsafe virtual void CorruptSaveUI(int ErrorCode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CorruptSaveUI, "BmScript.RGFxMovieUI_SaveSlotSelect.CorruptSaveUI");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ErrorCode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBackup;
    /// <summary>
    /// Function: IsBackup
    /// </summary>
    public unsafe virtual bool IsBackup(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBackup, "BmScript.RGFxMovieUI_SaveSlotSelect.IsBackup");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsFuture;
    /// <summary>
    /// Function: IsFuture
    /// </summary>
    public unsafe virtual bool IsFuture(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFuture, "BmScript.RGFxMovieUI_SaveSlotSelect.IsFuture");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsCorrupt;
    /// <summary>
    /// Function: IsCorrupt
    /// </summary>
    public unsafe virtual bool IsCorrupt(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCorrupt, "BmScript.RGFxMovieUI_SaveSlotSelect.IsCorrupt");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsEmpty;
    /// <summary>
    /// Function: IsEmpty
    /// </summary>
    public unsafe virtual bool IsEmpty(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsEmpty, "BmScript.RGFxMovieUI_SaveSlotSelect.IsEmpty");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_XI_OnOut;
    /// <summary>
    /// Function: XI_OnOut
    /// </summary>
    public unsafe override void XI_OnOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnOut, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_OnOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SetupMenu;
    /// <summary>
    /// Function: XI_SetupMenu
    /// </summary>
    public unsafe override void XI_SetupMenu(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetupMenu, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_SetupMenu");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_IsEnumerating;
    /// <summary>
    /// Function: XI_IsEnumerating
    /// </summary>
    public unsafe virtual bool XI_IsEnumerating()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_IsEnumerating, "BmScript.RGFxMovieUI_SaveSlotSelect.XI_IsEnumerating");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CorrectSaveFileInfoArray;
    /// <summary>
    /// Function: CorrectSaveFileInfoArray
    /// </summary>
    public unsafe virtual void CorrectSaveFileInfoArray()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CorrectSaveFileInfoArray, "BmScript.RGFxMovieUI_SaveSlotSelect.CorrectSaveFileInfoArray");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SortByFuture;
    /// <summary>
    /// Function: SortByFuture
    /// </summary>
    public unsafe virtual int SortByFuture(BmSDK.BmScript.RGFxMovieUI_SaveSlotSelect.FSaveGameFileInfo A, BmSDK.BmScript.RGFxMovieUI_SaveSlotSelect.FSaveGameFileInfo B)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortByFuture, "BmScript.RGFxMovieUI_SaveSlotSelect.SortByFuture");
        byte* paramsPtr = stackalloc byte[188];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 92);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 184);
    }

    private static BmSDK.Function __fn_SortByTimeStamp;
    /// <summary>
    /// Function: SortByTimeStamp
    /// </summary>
    public unsafe virtual int SortByTimeStamp(BmSDK.BmScript.RGFxMovieUI_SaveSlotSelect.FSaveGameFileInfo A, BmSDK.BmScript.RGFxMovieUI_SaveSlotSelect.FSaveGameFileInfo B)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortByTimeStamp, "BmScript.RGFxMovieUI_SaveSlotSelect.SortByTimeStamp");
        byte* paramsPtr = stackalloc byte[188];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 92);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 184);
    }

    private static BmSDK.Function __fn_LoadNextSave;
    /// <summary>
    /// Function: LoadNextSave
    /// </summary>
    public unsafe virtual void LoadNextSave()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadNextSave, "BmScript.RGFxMovieUI_SaveSlotSelect.LoadNextSave");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadUserFileComplete;
    /// <summary>
    /// Function: OnReadUserFileComplete
    /// </summary>
    public unsafe virtual void OnReadUserFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadUserFileComplete, "BmScript.RGFxMovieUI_SaveSlotSelect.OnReadUserFileComplete");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpInfo;
    /// <summary>
    /// Function: DumpInfo
    /// </summary>
    public unsafe virtual void DumpInfo(BmSDK.FString TitleLabel = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpInfo, "BmScript.RGFxMovieUI_SaveSlotSelect.DumpInfo");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleLabel, paramsPtr + 0);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_OnEnumerateUserFilesComplete;
    /// <summary>
    /// Function: OnEnumerateUserFilesComplete
    /// </summary>
    public unsafe virtual void OnEnumerateUserFilesComplete(bool bWasSuccessful, BmSDK.FString UserId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEnumerateUserFilesComplete, "BmScript.RGFxMovieUI_SaveSlotSelect.OnEnumerateUserFilesComplete");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginEnumerate;
    /// <summary>
    /// Function: BeginEnumerate
    /// </summary>
    public unsafe virtual void BeginEnumerate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginEnumerate, "BmScript.RGFxMovieUI_SaveSlotSelect.BeginEnumerate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SortByFilename;
    /// <summary>
    /// Function: SortByFilename
    /// </summary>
    public unsafe virtual int SortByFilename(BmSDK.BmScript.RGFxMovieUI_SaveSlotSelect.FSaveGameFileInfo A, BmSDK.BmScript.RGFxMovieUI_SaveSlotSelect.FSaveGameFileInfo B)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortByFilename, "BmScript.RGFxMovieUI_SaveSlotSelect.SortByFilename");
        byte* paramsPtr = stackalloc byte[188];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 92);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 184);
    }

    private static BmSDK.Function __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe override void CloseScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmScript.RGFxMovieUI_SaveSlotSelect.CloseScreen");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.RGFxMovieUI_SaveSlotSelect.Init");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: SaveSlotInfos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RGFxMovieUI_SaveSlotSelect.FSaveSlotInfo> SaveSlotInfos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RGFxMovieUI_SaveSlotSelect.FSaveSlotInfo>>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: OnlineSub
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem OnlineSub
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ObjectProperty: ActivePopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ActivePopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ArrayProperty: SaveFileInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RGFxMovieUI_SaveSlotSelect.FSaveGameFileInfo> SaveFileInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RGFxMovieUI_SaveSlotSelect.FSaveGameFileInfo>>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// BoolProperty: bLoadNext
    /// </summary>
    public unsafe bool bLoadNext
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bEnumerating
    /// </summary>
    public unsafe bool bEnumerating
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bOverwrite
    /// </summary>
    public unsafe bool bOverwrite
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bShownFutureOnce
    /// </summary>
    public unsafe bool bShownFutureOnce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bDelAll
    /// </summary>
    public unsafe bool bDelAll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bDifficultyMenuActive
    /// </summary>
    public unsafe bool bDifficultyMenuActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bShowBackups
    /// </summary>
    public unsafe bool bShowBackups
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bSilent
    /// </summary>
    public unsafe bool bSilent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// IntProperty: LoadCountIndex
    /// </summary>
    public unsafe int LoadCountIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// IntProperty: MaxSlot
    /// </summary>
    public unsafe int MaxSlot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ByteProperty: PopupType
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_SaveSlotSelect.SavePopupType PopupType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_SaveSlotSelect.SavePopupType>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// IntProperty: DelId
    /// </summary>
    public unsafe int DelId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// IntProperty: SaveId
    /// </summary>
    public unsafe int SaveId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// IntProperty: FocusId
    /// </summary>
    public unsafe int FocusId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// StrProperty: DelRef
    /// </summary>
    public unsafe BmSDK.FString DelRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// StrProperty: PlatformStr
    /// </summary>
    public unsafe BmSDK.FString PlatformStr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// StrProperty: SaveSlotMenu
    /// </summary>
    public unsafe BmSDK.FString SaveSlotMenu
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// IntProperty: LoadingSlot
    /// </summary>
    public unsafe int LoadingSlot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// IntProperty: LoadingSlotxId
    /// </summary>
    public unsafe int LoadingSlotxId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// IntProperty: Counter_LB
    /// </summary>
    public unsafe int Counter_LB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// StrProperty: FullyLocalisedDialogue
    /// </summary>
    public unsafe BmSDK.FString FullyLocalisedDialogue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// DelegateProperty: __SortByFilename__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByFilename__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// DelegateProperty: __SortByTimeStamp__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByTimeStamp__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// DelegateProperty: __SortByFuture__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByFuture__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// Struct: FSaveSlotInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FSaveSlotInfo
    {
        /// <summary>
        /// ArrayProperty: GameInfos
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmScript.RGFxMovieUI_SaveSlotSelect.FSaveGameFileInfo> GameInfos
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RGFxMovieUI_SaveSlotSelect.FSaveGameFileInfo>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: SlotID
        /// </summary>
        public unsafe int SlotID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: Current
        /// </summary>
        public unsafe int Current
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: Latest
        /// </summary>
        public unsafe int Latest
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bContainsACorruptEntry
        /// </summary>
        public unsafe bool bContainsACorruptEntry
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bContainsAFutureEntry
        /// </summary>
        public unsafe bool bContainsAFutureEntry
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Struct: FSaveGameFileInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 92)]
    public partial record struct FSaveGameFileInfo
    {
        /// <summary>
        /// StrProperty: Filename
        /// </summary>
        public unsafe BmSDK.FString Filename
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: DLName
        /// </summary>
        public unsafe BmSDK.FString DLName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: FileSize
        /// </summary>
        public unsafe int FileSize
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: SlotID
        /// </summary>
        public unsafe int SlotID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: xId
        /// </summary>
        public unsafe int xId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: TimeStamp
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId TimeStamp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// StrProperty: Difficulty
        /// </summary>
        public unsafe BmSDK.FString Difficulty
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// IntProperty: Percentage
        /// </summary>
        public unsafe int Percentage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// IntProperty: LocationID
        /// </summary>
        public unsafe int LocationID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// IntProperty: Day
        /// </summary>
        public unsafe int Day
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// IntProperty: Month
        /// </summary>
        public unsafe int Month
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// IntProperty: Year
        /// </summary>
        public unsafe int Year
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// BoolProperty: bIsFuture
        /// </summary>
        public unsafe bool bIsFuture
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }; }
        }
    }

    /// <summary>
    /// Enum: SavePopupType
    /// </summary>
    public enum SavePopupType : byte
    {
        SavePopupType_FreeSpace = 0,
        SavePopupType_Delete = 1,
        SavePopupType_Corrupt2 = 2,
        SavePopupType_CorruptRestore = 3,
        SavePopupType_CorruptDel = 4,
        SavePopupType_SaveRetry = 5,
        SavePopupType_BackupSelected = 6,
        SavePopupType_MAX = 7,
    }
}
