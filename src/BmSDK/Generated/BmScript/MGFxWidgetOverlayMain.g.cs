#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MGFxWidgetOverlayMain<br/>
/// (size = 164)
/// (flags = 18)
/// </summary>
public partial class MGFxWidgetOverlayMain : BmSDK.GFxUI.GFxObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MGFxWidgetOverlayMain", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MGFxWidgetOverlayMain.
    /// </summary>
    public static MGFxWidgetOverlayMain DefaultObject => (MGFxWidgetOverlayMain)StaticClass().DefaultObject;

    internal MGFxWidgetOverlayMain() { }

    /// <summary>
    /// Constructs a new MGFxWidgetOverlayMain
    /// </summary>
    public MGFxWidgetOverlayMain(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxWidgetOverlayMain Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxWidgetOverlayMain(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayMain>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayMain>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayMain>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayMain>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayMain>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayMain>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayMain>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayMain>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_HandleMouseWheel;
    /// <summary>
    /// Function: HandleMouseWheel
    /// </summary>
    public unsafe virtual void HandleMouseWheel(int btnIdx, bool directionUp)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleMouseWheel, "BmScript.MGFxWidgetOverlayMain.HandleMouseWheel");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleMouseRollOut, "BmScript.MGFxWidgetOverlayMain.HandleMouseRollOut");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleMouseRollOver, "BmScript.MGFxWidgetOverlayMain.HandleMouseRollOver");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleMouseInput, "BmScript.MGFxWidgetOverlayMain.HandleMouseInput");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnImageLoadComplete, "BmScript.MGFxWidgetOverlayMain.OnImageLoadComplete");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KeyUpInput, "BmScript.MGFxWidgetOverlayMain.KeyUpInput");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleInput, "BmScript.MGFxWidgetOverlayMain.HandleInput");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsRepeat, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Terminate;
    /// <summary>
    /// Function: Terminate
    /// </summary>
    public unsafe virtual void Terminate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Terminate, "BmScript.MGFxWidgetOverlayMain.Terminate");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_onTransistionCompleteCallback, "BmScript.MGFxWidgetOverlayMain.onTransistionCompleteCallback");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsActive, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnloadOverlay;
    /// <summary>
    /// Function: UnloadOverlay
    /// </summary>
    public unsafe virtual void UnloadOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnloadOverlay, "BmScript.MGFxWidgetOverlayMain.UnloadOverlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadOverlay;
    /// <summary>
    /// Function: LoadOverlay
    /// </summary>
    public unsafe virtual void LoadOverlay(BmSDK.FString Overlay)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadOverlay, "BmScript.MGFxWidgetOverlayMain.LoadOverlay");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Overlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadNew;
    /// <summary>
    /// Function: LoadNew
    /// </summary>
    public unsafe virtual void LoadNew(BmSDK.BmGame.MWBIDOverlayManager.E_WBID_Screen_Type screen)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadNew, "BmScript.MGFxWidgetOverlayMain.LoadNew");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(screen, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WidgetInitialized;
    /// <summary>
    /// Function: WidgetInitialized
    /// </summary>
    public unsafe override bool WidgetInitialized(BmSDK.FName WidgetName, BmSDK.FName WidgetPath, BmSDK.GFxUI.GFxObject Widget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetInitialized, "BmScript.MGFxWidgetOverlayMain.WidgetInitialized");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetPath, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Widget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// ObjectProperty: _parent
    /// </summary>
    public unsafe BmSDK.BmScript.MGFxMovieUI_WBIDMain _parent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MGFxMovieUI_WBIDMain>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: Screen_Current
    /// </summary>
    public unsafe BmSDK.BmScript.MGFxWidgetOverlayScreen Screen_Current
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MGFxWidgetOverlayScreen>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
}
