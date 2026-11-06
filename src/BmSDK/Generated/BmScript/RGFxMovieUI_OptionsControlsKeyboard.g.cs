#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_OptionsControlsKeyboard<br/>
/// (size = 1204)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_OptionsControlsKeyboard : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_OptionsControlsKeyboard.
    /// </summary>
    public static RGFxMovieUI_OptionsControlsKeyboard DefaultObject => (RGFxMovieUI_OptionsControlsKeyboard)StaticClass().DefaultObject;

    internal RGFxMovieUI_OptionsControlsKeyboard() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_OptionsControlsKeyboard
    /// </summary>
    public RGFxMovieUI_OptionsControlsKeyboard(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_OptionsControlsKeyboard Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_OptionsControlsKeyboard(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsControlsKeyboard>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsControlsKeyboard>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsControlsKeyboard>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsControlsKeyboard>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsControlsKeyboard>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsControlsKeyboard>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsControlsKeyboard>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsControlsKeyboard>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_XI_GetIsLeftCtrlPressed;
    /// <summary>
    /// Function: XI_GetIsLeftCtrlPressed
    /// </summary>
    public unsafe virtual void XI_GetIsLeftCtrlPressed(BmSDK.FString sPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetIsLeftCtrlPressed, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_GetIsLeftCtrlPressed");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetIsLeftShiftPressed;
    /// <summary>
    /// Function: XI_GetIsLeftShiftPressed
    /// </summary>
    public unsafe virtual void XI_GetIsLeftShiftPressed(BmSDK.FString sPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetIsLeftShiftPressed, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_GetIsLeftShiftPressed");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe override void CloseScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.CloseScreen");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentPage;
    /// <summary>
    /// Function: SetCurrentPage
    /// </summary>
    public unsafe virtual void SetCurrentPage(int nPage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentPage, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.SetCurrentPage");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AppendPage;
    /// <summary>
    /// Function: AppendPage
    /// </summary>
    public unsafe virtual void AppendPage(BmSDK.FString InName, BmSDK.FString InDevice, BmSDK.FString InScheme)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AppendPage, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.AppendPage");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDevice, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InScheme, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_RequestPages;
    /// <summary>
    /// Function: XI_RequestPages
    /// </summary>
    public unsafe virtual void XI_RequestPages(BmSDK.FString sPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_RequestPages, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_RequestPages");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SetBindByAbility;
    /// <summary>
    /// Function: XI_SetBindByAbility
    /// </summary>
    public unsafe virtual void XI_SetBindByAbility(int InAbilityId, BmSDK.FString InKeyUnlocalized, bool bIsPrimary, int InTypeId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetBindByAbility, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_SetBindByAbility");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAbilityId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKeyUnlocalized, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPrimary, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_RequestControlData;
    /// <summary>
    /// Function: XI_RequestControlData
    /// </summary>
    public unsafe virtual void XI_RequestControlData(BmSDK.FString BatmanAbilityNamesPath, BmSDK.FString BatmanKey1Path, BmSDK.FString BatmanKey2Path, BmSDK.FString PursuitAbilityNamesPath, BmSDK.FString PursuitKeys1Path, BmSDK.FString PursuitKeys2Path, BmSDK.FString BattleAbilityNamesPath, BmSDK.FString BattleKeys1Path, BmSDK.FString BattleKeys2Path)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_RequestControlData, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_RequestControlData");
        byte* paramsPtr = stackalloc byte[308];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanAbilityNamesPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanKey1Path, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanKey2Path, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PursuitAbilityNamesPath, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PursuitKeys1Path, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PursuitKeys2Path, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BattleAbilityNamesPath, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BattleKeys1Path, paramsPtr + 112);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BattleKeys2Path, paramsPtr + 128);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ThrowKeyBindPopup;
    /// <summary>
    /// Function: XI_ThrowKeyBindPopup
    /// </summary>
    public unsafe virtual void XI_ThrowKeyBindPopup(BmSDK.FString InPath, int InTypeId, int InIndex, bool InbIsPrimaryKeyBind)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ThrowKeyBindPopup, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_ThrowKeyBindPopup");
        byte* paramsPtr = stackalloc byte[45];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbIsPrimaryKeyBind, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDefaultKey;
    /// <summary>
    /// Function: GetDefaultKey
    /// </summary>
    public unsafe virtual BmSDK.FString GetDefaultKey(int InTypeId, int InIndex, BmSDK.BmScript.RGFxMovieUI_OptionsControlsKeyboard.KeyMap InKeyMap, bool GetUnlocalized = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultKey, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.GetDefaultKey");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKeyMap, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetUnlocalized, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetCurrentKey;
    /// <summary>
    /// Function: GetCurrentKey
    /// </summary>
    public unsafe virtual BmSDK.FString GetCurrentKey(int InTypeId, int InIndex, BmSDK.BmScript.RGFxMovieUI_OptionsControlsKeyboard.KeyMap InKeyMap)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentKey, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.GetCurrentKey");
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKeyMap, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetKey;
    /// <summary>
    /// Function: GetKey
    /// </summary>
    public unsafe virtual BmSDK.FString GetKey(BmSDK.BmScript.RGFxMovieUI_OptionsControlsKeyboard.KeyBindSourceId InSource, int InTypeId, int InIndex, BmSDK.BmScript.RGFxMovieUI_OptionsControlsKeyboard.KeyMap InKeyMap, bool GetUnlocalizedDefault = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetKey, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.GetKey");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSource, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKeyMap, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetUnlocalizedDefault, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_XI_ThrowAreYouSurePopup;
    /// <summary>
    /// Function: XI_ThrowAreYouSurePopup
    /// </summary>
    public unsafe virtual void XI_ThrowAreYouSurePopup(BmSDK.FString InPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ThrowAreYouSurePopup, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_ThrowAreYouSurePopup");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ButtonPCThrowAreYouSurePopup;
    /// <summary>
    /// Function: XI_ButtonPCThrowAreYouSurePopup
    /// </summary>
    public unsafe virtual void XI_ButtonPCThrowAreYouSurePopup(BmSDK.FString InPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ButtonPCThrowAreYouSurePopup, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_ButtonPCThrowAreYouSurePopup");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetKeyButtonBind;
    /// <summary>
    /// Function: SetKeyButtonBind
    /// </summary>
    public unsafe virtual void SetKeyButtonBind(BmSDK.FString InKey)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetKeyButtonBind, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.SetKeyButtonBind");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopupRequester_Callback;
    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe override void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KeyBindPopUpResetToDefaultPressed;
    /// <summary>
    /// Function: KeyBindPopUpResetToDefaultPressed
    /// </summary>
    public unsafe virtual void KeyBindPopUpResetToDefaultPressed(BmSDK.FString InDefaultKey)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KeyBindPopUpResetToDefaultPressed, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.KeyBindPopUpResetToDefaultPressed");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDefaultKey, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnBack;
    /// <summary>
    /// Function: XI_OnBack
    /// </summary>
    public unsafe override void XI_OnBack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnBack, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_OnBack");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnYPressed;
    /// <summary>
    /// Function: XI_OnYPressed
    /// </summary>
    public unsafe virtual void XI_OnYPressed(BmSDK.FString Path)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnYPressed, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_OnYPressed");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Path, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetAllKeybindsToDefault;
    /// <summary>
    /// Function: ResetAllKeybindsToDefault
    /// </summary>
    public unsafe virtual void ResetAllKeybindsToDefault()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetAllKeybindsToDefault, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.ResetAllKeybindsToDefault");
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.Init");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: KeyMap
    /// </summary>
    public enum KeyMap : byte
    {
        KeyMap_Primary = 0,
        KeyMap_Secondary = 1,
        KeyMap_MAX = 2,
    }

    /// <summary>
    /// Enum: KeyBindSourceId
    /// </summary>
    public enum KeyBindSourceId : byte
    {
        KeyBindSourceId_Default = 0,
        KeyBindSourceId_Current = 1,
        KeyBindSourceId_MAX = 2,
    }

    /// <summary>
    /// Enum: KeyboardBindTypeId
    /// </summary>
    public enum KeyboardBindTypeId : byte
    {
        KeyboardBindTypeId_Batman = 0,
        KeyboardBindTypeId_Pursuit = 1,
        KeyboardBindTypeId_Battle = 2,
        KeyboardBindTypeId_MAX = 3,
    }

    /// <summary>
    /// StrProperty: CachedFunction_AddPage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_AddPage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetCurrentPage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetCurrentPage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// StrProperty: FunctionPath
    /// </summary>
    public unsafe BmSDK.FString FunctionPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ObjectProperty: ApplyKeybindingsPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ApplyKeybindingsPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ObjectProperty: KeyButtonRemoveDuplicateKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester KeyButtonRemoveDuplicateKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ObjectProperty: ButtonPCRemoveDuplicateKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ButtonPCRemoveDuplicateKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ObjectProperty: SetKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester SetKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ObjectProperty: ResetAllToDefaultPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ResetAllToDefaultPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// IntProperty: NoOption
    /// </summary>
    public unsafe int NoOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// IntProperty: CancelOption
    /// </summary>
    public unsafe int CancelOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// StrProperty: DefaultKeyBind
    /// </summary>
    public unsafe BmSDK.FString DefaultKeyBind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// BoolProperty: bHasModifier
    /// </summary>
    public unsafe bool bHasModifier
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1184); }
    }

    /// <summary>
    /// StrProperty: SelectedKeyBind
    /// </summary>
    public unsafe BmSDK.FString SelectedKeyBind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }
}
