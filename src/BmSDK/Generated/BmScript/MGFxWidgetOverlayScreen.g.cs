#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MGFxWidgetOverlayScreen<br/>
/// (size = 196)
/// (flags = 18)
/// </summary>
public partial class MGFxWidgetOverlayScreen : BmSDK.GFxUI.GFxObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MGFxWidgetOverlayScreen", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MGFxWidgetOverlayScreen.
    /// </summary>
    public static MGFxWidgetOverlayScreen DefaultObject => (MGFxWidgetOverlayScreen)StaticClass().DefaultObject;

    internal MGFxWidgetOverlayScreen() { }

    /// <summary>
    /// Constructs a new MGFxWidgetOverlayScreen
    /// </summary>
    public MGFxWidgetOverlayScreen(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxWidgetOverlayScreen Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxWidgetOverlayScreen(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreen>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreen>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreen>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreen>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreen>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreen>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreen>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreen>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ScrollToPosition;
    /// <summary>
    /// Function: ScrollToPosition
    /// </summary>
    public unsafe virtual void ScrollToPosition(float ScrollBlockY)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScrollToPosition, "BmScript.MGFxWidgetOverlayScreen.ScrollToPosition");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScrollBlockY, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMinYForScrolling;
    /// <summary>
    /// Function: GetMinYForScrolling
    /// </summary>
    public unsafe virtual float GetMinYForScrolling()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMinYForScrolling, "BmScript.MGFxWidgetOverlayScreen.GetMinYForScrolling");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMaxYForScrolling;
    /// <summary>
    /// Function: GetMaxYForScrolling
    /// </summary>
    public unsafe virtual float GetMaxYForScrolling()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxYForScrolling, "BmScript.MGFxWidgetOverlayScreen.GetMaxYForScrolling");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlaySoundEffect;
    /// <summary>
    /// Function: PlaySoundEffect
    /// </summary>
    public unsafe virtual void PlaySoundEffect(BmSDK.BmScript.MGFxMovieUI_WBIDMain.WBPlay_UI_SFX sfx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySoundEffect, "BmScript.MGFxWidgetOverlayScreen.PlaySoundEffect");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sfx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThreadSafeInvalidate;
    /// <summary>
    /// Function: ThreadSafeInvalidate
    /// </summary>
    public unsafe virtual void ThreadSafeInvalidate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThreadSafeInvalidate, "BmScript.MGFxWidgetOverlayScreen.ThreadSafeInvalidate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnImageLoadComplete;
    /// <summary>
    /// Function: OnImageLoadComplete
    /// </summary>
    public unsafe virtual void OnImageLoadComplete(BmSDK.GFxUI.GFxObject pRef)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnImageLoadComplete, "BmScript.MGFxWidgetOverlayScreen.OnImageLoadComplete");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pRef, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnKeyUp;
    /// <summary>
    /// Function: OnKeyUp
    /// </summary>
    public unsafe virtual void OnKeyUp(int Key)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnKeyUp, "BmScript.MGFxWidgetOverlayScreen.OnKeyUp");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KeyInput;
    /// <summary>
    /// Function: KeyInput
    /// </summary>
    public unsafe virtual void KeyInput(int Key)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KeyInput, "BmScript.MGFxWidgetOverlayScreen.KeyInput");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMouseWheel;
    /// <summary>
    /// Function: OnMouseWheel
    /// </summary>
    public unsafe virtual void OnMouseWheel(int btnIdx, bool directionUp)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMouseWheel, "BmScript.MGFxWidgetOverlayScreen.OnMouseWheel");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(btnIdx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(directionUp, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMouseRollOut;
    /// <summary>
    /// Function: OnMouseRollOut
    /// </summary>
    public unsafe virtual void OnMouseRollOut(int btnIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMouseRollOut, "BmScript.MGFxWidgetOverlayScreen.OnMouseRollOut");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(btnIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMouseRollOver;
    /// <summary>
    /// Function: OnMouseRollOver
    /// </summary>
    public unsafe virtual void OnMouseRollOver(int btnIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMouseRollOver, "BmScript.MGFxWidgetOverlayScreen.OnMouseRollOver");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(btnIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMouseDown;
    /// <summary>
    /// Function: OnMouseDown
    /// </summary>
    public unsafe virtual void OnMouseDown(int btnIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMouseDown, "BmScript.MGFxWidgetOverlayScreen.OnMouseDown");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(btnIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPressTab;
    /// <summary>
    /// Function: OnPressTab
    /// </summary>
    public unsafe virtual void OnPressTab()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPressTab, "BmScript.MGFxWidgetOverlayScreen.OnPressTab");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NavRight;
    /// <summary>
    /// Function: NavRight
    /// </summary>
    public unsafe virtual void NavRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavRight, "BmScript.MGFxWidgetOverlayScreen.NavRight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NavLeft;
    /// <summary>
    /// Function: NavLeft
    /// </summary>
    public unsafe virtual void NavLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavLeft, "BmScript.MGFxWidgetOverlayScreen.NavLeft");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NavDown;
    /// <summary>
    /// Function: NavDown
    /// </summary>
    public unsafe virtual void NavDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavDown, "BmScript.MGFxWidgetOverlayScreen.NavDown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NavUp;
    /// <summary>
    /// Function: NavUp
    /// </summary>
    public unsafe virtual void NavUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavUp, "BmScript.MGFxWidgetOverlayScreen.NavUp");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPressRB;
    /// <summary>
    /// Function: OnPressRB
    /// </summary>
    public unsafe virtual void OnPressRB()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPressRB, "BmScript.MGFxWidgetOverlayScreen.OnPressRB");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPressLB;
    /// <summary>
    /// Function: OnPressLB
    /// </summary>
    public unsafe virtual void OnPressLB()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPressLB, "BmScript.MGFxWidgetOverlayScreen.OnPressLB");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPC;
    /// <summary>
    /// Function: IsPC
    /// </summary>
    public unsafe virtual bool IsPC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPC, "BmScript.MGFxWidgetOverlayScreen.IsPC");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetPromptIndex;
    /// <summary>
    /// Function: SetPromptIndex
    /// </summary>
    public unsafe virtual void SetPromptIndex(int promptAIdx, int promptBIdx, int promptExtIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPromptIndex, "BmScript.MGFxWidgetOverlayScreen.SetPromptIndex");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(promptAIdx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(promptBIdx, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(promptExtIdx, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPressB;
    /// <summary>
    /// Function: OnPressB
    /// </summary>
    public unsafe virtual void OnPressB()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPressB, "BmScript.MGFxWidgetOverlayScreen.OnPressB");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPressA;
    /// <summary>
    /// Function: OnPressA
    /// </summary>
    public unsafe virtual void OnPressA()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPressA, "BmScript.MGFxWidgetOverlayScreen.OnPressA");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Terminate;
    /// <summary>
    /// Function: Terminate
    /// </summary>
    public unsafe virtual void Terminate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Terminate, "BmScript.MGFxWidgetOverlayScreen.Terminate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendData;
    /// <summary>
    /// Function: SendData
    /// </summary>
    public unsafe virtual void SendData()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendData, "BmScript.MGFxWidgetOverlayScreen.SendData");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyInput;
    /// <summary>
    /// Function: DestroyInput
    /// </summary>
    public unsafe virtual void DestroyInput()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyInput, "BmScript.MGFxWidgetOverlayScreen.DestroyInput");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupInput;
    /// <summary>
    /// Function: SetupInput
    /// </summary>
    public unsafe virtual void SetupInput()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupInput, "BmScript.MGFxWidgetOverlayScreen.SetupInput");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_onOverlayAnimationComplete;
    /// <summary>
    /// Function: onOverlayAnimationComplete
    /// </summary>
    public unsafe virtual void onOverlayAnimationComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_onOverlayAnimationComplete, "BmScript.MGFxWidgetOverlayScreen.onOverlayAnimationComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_onTransistionCompleteCallback;
    /// <summary>
    /// Function: onTransistionCompleteCallback
    /// </summary>
    public unsafe virtual void onTransistionCompleteCallback(bool bIsActive)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_onTransistionCompleteCallback, "BmScript.MGFxWidgetOverlayScreen.onTransistionCompleteCallback");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsActive, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.MGFxWidgetOverlayScreen.Init");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: DataMessage
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDDataMessage DataMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDDataMessage>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: ManagerRef
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDOverlayManager ManagerRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDOverlayManager>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ObjectProperty: _parent
    /// </summary>
    public unsafe BmSDK.BmScript.MGFxWidgetOverlayMain _parent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MGFxWidgetOverlayMain>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ObjectProperty: OverlayBasic
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject OverlayBasic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bSetupInput
    /// </summary>
    public unsafe bool bSetupInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bNeedsThreadSafeInvalidate
    /// </summary>
    public unsafe bool bNeedsThreadSafeInvalidate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bNeedsKeyUp
    /// </summary>
    public unsafe bool bNeedsKeyUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// IntProperty: PromptAIndex
    /// </summary>
    public unsafe int PromptAIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// IntProperty: PromptBIndex
    /// </summary>
    public unsafe int PromptBIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// IntProperty: PromptExtraIndex
    /// </summary>
    public unsafe int PromptExtraIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }
}
