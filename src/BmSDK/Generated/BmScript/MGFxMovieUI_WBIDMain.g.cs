#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MGFxMovieUI_WBIDMain<br/>
/// (size = 1120)
/// (flags = 22)
/// </summary>
public partial class MGFxMovieUI_WBIDMain : BmSDK.BmGame.MGFxMovieUI_WBIDMainBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MGFxMovieUI_WBIDMain", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MGFxMovieUI_WBIDMain.
    /// </summary>
    public static MGFxMovieUI_WBIDMain DefaultObject => (MGFxMovieUI_WBIDMain)StaticClass().DefaultObject;

    internal MGFxMovieUI_WBIDMain() { }

    /// <summary>
    /// Constructs a new MGFxMovieUI_WBIDMain
    /// </summary>
    public MGFxMovieUI_WBIDMain(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxMovieUI_WBIDMain Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxMovieUI_WBIDMain(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxMovieUI_WBIDMain>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieUI_WBIDMain>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxMovieUI_WBIDMain>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieUI_WBIDMain>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieUI_WBIDMain>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieUI_WBIDMain>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxMovieUI_WBIDMain>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieUI_WBIDMain>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PlaySoundEffect;
    /// <summary>
    /// Function: PlaySoundEffect
    /// </summary>
    public unsafe virtual void PlaySoundEffect(BmSDK.BmScript.MGFxMovieUI_WBIDMain.WBPlay_UI_SFX sfx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySoundEffect, "BmScript.MGFxMovieUI_WBIDMain.PlaySoundEffect");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sfx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRewardsScreenError;
    /// <summary>
    /// Function: SetRewardsScreenError
    /// </summary>
    public unsafe override void SetRewardsScreenError()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRewardsScreenError, "BmScript.MGFxMovieUI_WBIDMain.SetRewardsScreenError");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_PasteFromClipboard;
    /// <summary>
    /// Function: XI_PasteFromClipboard
    /// </summary>
    public unsafe virtual void XI_PasteFromClipboard(BmSDK.FString TargetPath, BmSDK.FString VariableName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_PasteFromClipboard, "BmScript.MGFxMovieUI_WBIDMain.XI_PasteFromClipboard");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetMinYForScrolling;
    /// <summary>
    /// Function: XI_GetMinYForScrolling
    /// </summary>
    public unsafe virtual void XI_GetMinYForScrolling(BmSDK.FString TargetPath, BmSDK.FString VariableName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetMinYForScrolling, "BmScript.MGFxMovieUI_WBIDMain.XI_GetMinYForScrolling");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetMaxYForScrolling;
    /// <summary>
    /// Function: XI_GetMaxYForScrolling
    /// </summary>
    public unsafe virtual void XI_GetMaxYForScrolling(BmSDK.FString TargetPath, BmSDK.FString VariableName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetMaxYForScrolling, "BmScript.MGFxMovieUI_WBIDMain.XI_GetMaxYForScrolling");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ScrollToPosition;
    /// <summary>
    /// Function: XI_ScrollToPosition
    /// </summary>
    public unsafe virtual void XI_ScrollToPosition(float ScrollBlockY)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ScrollToPosition, "BmScript.MGFxMovieUI_WBIDMain.XI_ScrollToPosition");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScrollBlockY, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetViewportHeight;
    /// <summary>
    /// Function: XI_GetViewportHeight
    /// </summary>
    public unsafe override void XI_GetViewportHeight(BmSDK.FString TargetPath, BmSDK.FString VariableName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetViewportHeight, "BmScript.MGFxMovieUI_WBIDMain.XI_GetViewportHeight");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetMouseY;
    /// <summary>
    /// Function: XI_GetMouseY
    /// </summary>
    public unsafe virtual void XI_GetMouseY(BmSDK.FString TargetPath, BmSDK.FString VariableName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetMouseY, "BmScript.MGFxMovieUI_WBIDMain.XI_GetMouseY");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateWBIDWidgets;
    /// <summary>
    /// Function: UpdateWBIDWidgets
    /// </summary>
    public unsafe override void UpdateWBIDWidgets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateWBIDWidgets, "BmScript.MGFxMovieUI_WBIDMain.UpdateWBIDWidgets");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessVoiceCommand;
    /// <summary>
    /// Function: ProcessVoiceCommand
    /// </summary>
    public unsafe override bool ProcessVoiceCommand(BmSDK.FString VoiceRecCommand)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessVoiceCommand, "BmScript.MGFxMovieUI_WBIDMain.ProcessVoiceCommand");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VoiceRecCommand, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_OnScreenLoaded;
    /// <summary>
    /// Function: OnScreenLoaded
    /// </summary>
    public unsafe virtual void OnScreenLoaded(BmSDK.GFxUI.GFxObject screenRef)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnScreenLoaded, "BmScript.MGFxMovieUI_WBIDMain.OnScreenLoaded");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(screenRef, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnClose;
    /// <summary>
    /// Function: OnClose
    /// </summary>
    public unsafe override void OnClose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClose, "BmScript.MGFxMovieUI_WBIDMain.OnClose");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_onOverlayAnimationComplete;
    /// <summary>
    /// Function: XI_onOverlayAnimationComplete
    /// </summary>
    public unsafe virtual void XI_onOverlayAnimationComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_onOverlayAnimationComplete, "BmScript.MGFxMovieUI_WBIDMain.XI_onOverlayAnimationComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_onTransistionCompleteCallback;
    /// <summary>
    /// Function: onTransistionCompleteCallback
    /// </summary>
    public unsafe virtual void onTransistionCompleteCallback(bool bIsActive)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_onTransistionCompleteCallback, "BmScript.MGFxMovieUI_WBIDMain.onTransistionCompleteCallback");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsActive, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandlePromptInput;
    /// <summary>
    /// Function: HandlePromptInput
    /// </summary>
    public unsafe virtual void HandlePromptInput(int btnIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandlePromptInput, "BmScript.MGFxMovieUI_WBIDMain.HandlePromptInput");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(btnIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleMouseWheel;
    /// <summary>
    /// Function: HandleMouseWheel
    /// </summary>
    public unsafe virtual void HandleMouseWheel(int btnIdx, bool directionUp)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleMouseWheel, "BmScript.MGFxMovieUI_WBIDMain.HandleMouseWheel");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(btnIdx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(directionUp, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleMouseRollOut;
    /// <summary>
    /// Function: HandleMouseRollOut
    /// </summary>
    public unsafe virtual void HandleMouseRollOut(int btnIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleMouseRollOut, "BmScript.MGFxMovieUI_WBIDMain.HandleMouseRollOut");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(btnIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleMouseRollOver;
    /// <summary>
    /// Function: HandleMouseRollOver
    /// </summary>
    public unsafe virtual void HandleMouseRollOver(int btnIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleMouseRollOver, "BmScript.MGFxMovieUI_WBIDMain.HandleMouseRollOver");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(btnIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleMouseInput;
    /// <summary>
    /// Function: HandleMouseInput
    /// </summary>
    public unsafe virtual void HandleMouseInput(int btnIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleMouseInput, "BmScript.MGFxMovieUI_WBIDMain.HandleMouseInput");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(btnIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnImageLoadComplete;
    /// <summary>
    /// Function: OnImageLoadComplete
    /// </summary>
    public unsafe virtual void OnImageLoadComplete(BmSDK.GFxUI.GFxObject pRef)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnImageLoadComplete, "BmScript.MGFxMovieUI_WBIDMain.OnImageLoadComplete");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pRef, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KeyUpInput;
    /// <summary>
    /// Function: KeyUpInput
    /// </summary>
    public unsafe virtual void KeyUpInput(int Key)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KeyUpInput, "BmScript.MGFxMovieUI_WBIDMain.KeyUpInput");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleInput;
    /// <summary>
    /// Function: HandleInput
    /// </summary>
    public unsafe virtual void HandleInput(int Key, bool bIsRepeat)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleInput, "BmScript.MGFxMovieUI_WBIDMain.HandleInput");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsRepeat, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TransitionOut;
    /// <summary>
    /// Function: TransitionOut
    /// </summary>
    public unsafe virtual void TransitionOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TransitionOut, "BmScript.MGFxMovieUI_WBIDMain.TransitionOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TransitionIn;
    /// <summary>
    /// Function: TransitionIn
    /// </summary>
    public unsafe virtual void TransitionIn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TransitionIn, "BmScript.MGFxMovieUI_WBIDMain.TransitionIn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Terminate;
    /// <summary>
    /// Function: Terminate
    /// </summary>
    public unsafe override void Terminate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Terminate, "BmScript.MGFxMovieUI_WBIDMain.Terminate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadNext;
    /// <summary>
    /// Function: LoadNext
    /// </summary>
    public unsafe virtual void LoadNext(BmSDK.BmGame.MWBIDOverlayManager.E_WBID_Screen_Type nextOverlay)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadNext, "BmScript.MGFxMovieUI_WBIDMain.LoadNext");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nextOverlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Update;
    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe virtual void Update()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Update, "BmScript.MGFxMovieUI_WBIDMain.Update");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.MGFxMovieUI_WBIDMain.Init");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WidgetInitialized;
    /// <summary>
    /// Function: WidgetInitialized
    /// </summary>
    public unsafe override bool WidgetInitialized(BmSDK.FName WidgetName, BmSDK.FName WidgetPath, BmSDK.GFxUI.GFxObject Widget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetInitialized, "BmScript.MGFxMovieUI_WBIDMain.WidgetInitialized");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetPath, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Widget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Enum: WBPlay_UI_SFX
    /// </summary>
    public enum WBPlay_UI_SFX : byte
    {
        WBPlay_UI_SFX_Cycle = 0,
        WBPlay_UI_SFX_Cancel = 1,
        WBPlay_UI_SFX_Back = 2,
        WBPlay_UI_SFX_OnClicked = 3,
        WBPlay_UI_SFX_OnFocus = 4,
        WBPlay_UI_SFX_OnLostFocus = 5,
        WBPlay_UI_SFX_Reset_Default = 6,
        WBPlay_UI_SFX_Slider_Max = 7,
        WBPlay_UI_SFX_Slider_Min = 8,
        WBPlay_UI_SFX_Slider_Move = 9,
        WBPlay_UI_SFX_Switch_Screen = 10,
        WBPlay_UI_SFX_Toggle = 11,
        WBPlay_UI_SFX_MAX = 12,
    }

    /// <summary>
    /// ObjectProperty: OverlayMaster
    /// </summary>
    public unsafe BmSDK.BmScript.MGFxWidgetOverlayMain OverlayMaster
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MGFxWidgetOverlayMain>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: ScreenMovie
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject ScreenMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: ManagerRef
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDOverlayManager ManagerRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDOverlayManager>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ObjectProperty: DataMessage
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDDataMessage DataMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDDataMessage>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ObjectProperty: MainMenu
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_MainMenu MainMenu
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_MainMenu>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ObjectProperty: RewardsMenu
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards RewardsMenu
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }
}
