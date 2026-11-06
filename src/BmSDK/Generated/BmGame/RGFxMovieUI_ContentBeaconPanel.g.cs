#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_ContentBeaconPanel<br/>
/// (size = 1140)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_ContentBeaconPanel : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_ContentBeaconPanel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_ContentBeaconPanel.
    /// </summary>
    public static RGFxMovieUI_ContentBeaconPanel DefaultObject => (RGFxMovieUI_ContentBeaconPanel)StaticClass().DefaultObject;

    internal RGFxMovieUI_ContentBeaconPanel() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_ContentBeaconPanel
    /// </summary>
    public RGFxMovieUI_ContentBeaconPanel(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_ContentBeaconPanel Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_ContentBeaconPanel(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ContentBeaconPanel>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ContentBeaconPanel>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ContentBeaconPanel>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ContentBeaconPanel>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ContentBeaconPanel>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ContentBeaconPanel>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ContentBeaconPanel>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ContentBeaconPanel>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ContentBeaconContentLoaded;
    /// <summary>
    /// Function: ContentBeaconContentLoaded
    /// </summary>
    public unsafe virtual void ContentBeaconContentLoaded(bool bWasSuccessful, BmSDK.FString sCustomId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ContentBeaconContentLoaded, "BmGame.RGFxMovieUI_ContentBeaconPanel.ContentBeaconContentLoaded");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFadeCompleted_Callback;
    /// <summary>
    /// Function: OnFadeCompleted_Callback
    /// </summary>
    public unsafe override void OnFadeCompleted_Callback()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFadeCompleted_Callback, "BmGame.RGFxMovieUI_ContentBeaconPanel.OnFadeCompleted_Callback");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopupRequester_Callback;
    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe override void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester iPopup, int nButtonId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmGame.RGFxMovieUI_ContentBeaconPanel.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iPopup, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nButtonId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_HandleModeChange;
    /// <summary>
    /// Function: XI_HandleModeChange
    /// </summary>
    public unsafe virtual void XI_HandleModeChange(BmSDK.FString sMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_HandleModeChange, "BmGame.RGFxMovieUI_ContentBeaconPanel.XI_HandleModeChange");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_HandleAction;
    /// <summary>
    /// Function: XI_HandleAction
    /// </summary>
    public unsafe virtual void XI_HandleAction(BmSDK.FString sAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_HandleAction, "BmGame.RGFxMovieUI_ContentBeaconPanel.XI_HandleAction");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ReadyForSetup;
    /// <summary>
    /// Function: XI_ReadyForSetup
    /// </summary>
    public unsafe virtual void XI_ReadyForSetup()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ReadyForSetup, "BmGame.RGFxMovieUI_ContentBeaconPanel.XI_ReadyForSetup");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_ClearKeyDowns;
    /// <summary>
    /// Function: UC_ClearKeyDowns
    /// </summary>
    public unsafe virtual void UC_ClearKeyDowns()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_ClearKeyDowns, "BmGame.RGFxMovieUI_ContentBeaconPanel.UC_ClearKeyDowns");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetImageFromPackage;
    /// <summary>
    /// Function: UC_SetImageFromPackage
    /// </summary>
    public unsafe virtual void UC_SetImageFromPackage(BmSDK.FString sPackage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetImageFromPackage, "BmGame.RGFxMovieUI_ContentBeaconPanel.UC_SetImageFromPackage");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPackage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetImageError;
    /// <summary>
    /// Function: UC_SetImageError
    /// </summary>
    public unsafe virtual void UC_SetImageError()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetImageError, "BmGame.RGFxMovieUI_ContentBeaconPanel.UC_SetImageError");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetImage;
    /// <summary>
    /// Function: UC_SetImage
    /// </summary>
    public unsafe virtual void UC_SetImage(BmSDK.GFxUI.GFxObject iImage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetImage, "BmGame.RGFxMovieUI_ContentBeaconPanel.UC_SetImage");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iImage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetAction;
    /// <summary>
    /// Function: UC_SetAction
    /// </summary>
    public unsafe virtual void UC_SetAction(BmSDK.FString sAction, BmSDK.FString sText)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetAction, "BmGame.RGFxMovieUI_ContentBeaconPanel.UC_SetAction");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sAction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sText, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetText;
    /// <summary>
    /// Function: UC_SetText
    /// </summary>
    public unsafe virtual void UC_SetText(BmSDK.FString sComponent, BmSDK.FString sText)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetText, "BmGame.RGFxMovieUI_ContentBeaconPanel.UC_SetText");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sText, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetMode;
    /// <summary>
    /// Function: UC_SetMode
    /// </summary>
    public unsafe virtual void UC_SetMode(BmSDK.FString sMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetMode, "BmGame.RGFxMovieUI_ContentBeaconPanel.UC_SetMode");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceFocus;
    /// <summary>
    /// Function: ForceFocus
    /// </summary>
    public unsafe virtual void ForceFocus(bool bFocus)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceFocus, "BmGame.RGFxMovieUI_ContentBeaconPanel.ForceFocus");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFocus, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAspectRatioChanged;
    /// <summary>
    /// Function: OnAspectRatioChanged
    /// </summary>
    public unsafe override void OnAspectRatioChanged(float fAspect)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAspectRatioChanged, "BmGame.RGFxMovieUI_ContentBeaconPanel.OnAspectRatioChanged");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fAspect, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Setup;
    /// <summary>
    /// Function: Setup
    /// </summary>
    public unsafe virtual void Setup(BmSDK.BmGame.RGameInfo.EContentBeaconDisplayMode eDisplayMode, int nBeaconIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Setup, "BmGame.RGFxMovieUI_ContentBeaconPanel.Setup");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eDisplayMode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nBeaconIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialize;
    /// <summary>
    /// Function: Initialize
    /// </summary>
    public unsafe virtual void Initialize(BmSDK.Engine.LocalPlayer iPlayer, BmSDK.BmGame.RGameInfo.EContentBeaconDisplayMode eDisplayMode, int nBeaconIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialize, "BmGame.RGFxMovieUI_ContentBeaconPanel.Initialize");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eDisplayMode, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nBeaconIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ByteProperty: m_eCachedDisplayMode
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EContentBeaconDisplayMode m_eCachedDisplayMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EContentBeaconDisplayMode>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// IntProperty: m_nCachedBeaconIndex
    /// </summary>
    public unsafe int m_nCachedBeaconIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// StrProperty: m_sCachedAction
    /// </summary>
    public unsafe BmSDK.FString m_sCachedAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// IntProperty: m_nCachedEpisodeIndex
    /// </summary>
    public unsafe int m_nCachedEpisodeIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ObjectProperty: m_iConfirmLaunchPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester m_iConfirmLaunchPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ObjectProperty: m_iContentNotFoundPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester m_iContentNotFoundPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ObjectProperty: m_iWantOnlinePopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester m_iWantOnlinePopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// DelegateProperty: __ContentBeaconContentLoaded__Delegate
    /// </summary>
    public unsafe System.IntPtr __ContentBeaconContentLoaded__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }
}
