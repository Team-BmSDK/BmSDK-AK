#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MGFxWidgetOverlayScreenGeneric<br/>
/// (size = 220)
/// (flags = 18)
/// </summary>
public partial class MGFxWidgetOverlayScreenGeneric : BmSDK.BmScript.MGFxWidgetOverlayScreen, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MGFxWidgetOverlayScreenGeneric", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MGFxWidgetOverlayScreenGeneric.
    /// </summary>
    public static MGFxWidgetOverlayScreenGeneric DefaultObject => (MGFxWidgetOverlayScreenGeneric)StaticClass().DefaultObject;

    internal MGFxWidgetOverlayScreenGeneric() { }

    /// <summary>
    /// Constructs a new MGFxWidgetOverlayScreenGeneric
    /// </summary>
    public MGFxWidgetOverlayScreenGeneric(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxWidgetOverlayScreenGeneric Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxWidgetOverlayScreenGeneric(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreenGeneric>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreenGeneric>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreenGeneric>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreenGeneric>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreenGeneric>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreenGeneric>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreenGeneric>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreenGeneric>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_onTransistionCompleteCallback;
    /// <summary>
    /// Function: onTransistionCompleteCallback
    /// </summary>
    public unsafe override void onTransistionCompleteCallback(bool bIsActive)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_onTransistionCompleteCallback, "BmScript.MGFxWidgetOverlayScreenGeneric.onTransistionCompleteCallback");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsActive, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Terminate;
    /// <summary>
    /// Function: Terminate
    /// </summary>
    public unsafe override void Terminate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Terminate, "BmScript.MGFxWidgetOverlayScreenGeneric.Terminate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FreeTexture;
    /// <summary>
    /// Function: FreeTexture
    /// </summary>
    public unsafe virtual void FreeTexture()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FreeTexture, "BmScript.MGFxWidgetOverlayScreenGeneric.FreeTexture");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayImage;
    /// <summary>
    /// Function: DisplayImage
    /// </summary>
    public unsafe virtual void DisplayImage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayImage, "BmScript.MGFxWidgetOverlayScreenGeneric.DisplayImage");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadImage;
    /// <summary>
    /// Function: LoadImage
    /// </summary>
    public unsafe virtual void LoadImage(BmSDK.TArray<byte> sourceImage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadImage, "BmScript.MGFxWidgetOverlayScreenGeneric.LoadImage");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sourceImage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AppendFontColourTagsToString;
    /// <summary>
    /// Function: AppendFontColourTagsToString
    /// </summary>
    public unsafe virtual BmSDK.FString AppendFontColourTagsToString(BmSDK.FString Text, BmSDK.BmGame.MWBIDOverlayManager.NetworkDebugColourCode Code)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AppendFontColourTagsToString, "BmScript.MGFxWidgetOverlayScreenGeneric.AppendFontColourTagsToString");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Code, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_UpdateNetworkStatus;
    /// <summary>
    /// Function: UpdateNetworkStatus
    /// </summary>
    public unsafe virtual void UpdateNetworkStatus()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateNetworkStatus, "BmScript.MGFxWidgetOverlayScreenGeneric.UpdateNetworkStatus");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPressB;
    /// <summary>
    /// Function: OnPressB
    /// </summary>
    public unsafe override void OnPressB()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPressB, "BmScript.MGFxWidgetOverlayScreenGeneric.OnPressB");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPressA;
    /// <summary>
    /// Function: OnPressA
    /// </summary>
    public unsafe override void OnPressA()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPressA, "BmScript.MGFxWidgetOverlayScreenGeneric.OnPressA");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Invalidate;
    /// <summary>
    /// Function: Invalidate
    /// </summary>
    public unsafe virtual void Invalidate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Invalidate, "BmScript.MGFxWidgetOverlayScreenGeneric.Invalidate");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WidgetInitialized;
    /// <summary>
    /// Function: WidgetInitialized
    /// </summary>
    public unsafe override bool WidgetInitialized(BmSDK.FName WidgetName, BmSDK.FName WidgetPath, BmSDK.GFxUI.GFxObject Widget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetInitialized, "BmScript.MGFxWidgetOverlayScreenGeneric.WidgetInitialized");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetPath, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Widget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.MGFxWidgetOverlayScreenGeneric.Init");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: TextContainer
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject TextContainer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ObjectProperty: CookieImage
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject CookieImage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// IntProperty: SelectedButton
    /// </summary>
    public unsafe int SelectedButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// BoolProperty: bIsPleaseWait
    /// </summary>
    public unsafe bool bIsPleaseWait
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 216); }
    }

    /// <summary>
    /// BoolProperty: bIsNetworkDebug
    /// </summary>
    public unsafe bool bIsNetworkDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 216); }
    }
}
