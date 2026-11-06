#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_PhotoModeOverlay<br/>
/// (size = 1128)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_PhotoModeOverlay : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_PhotoModeOverlay", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_PhotoModeOverlay.
    /// </summary>
    public static RGFxMovieUI_PhotoModeOverlay DefaultObject => (RGFxMovieUI_PhotoModeOverlay)StaticClass().DefaultObject;

    internal RGFxMovieUI_PhotoModeOverlay() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_PhotoModeOverlay
    /// </summary>
    public RGFxMovieUI_PhotoModeOverlay(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_PhotoModeOverlay Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_PhotoModeOverlay(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PhotoModeOverlay>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PhotoModeOverlay>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PhotoModeOverlay>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PhotoModeOverlay>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PhotoModeOverlay>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PhotoModeOverlay>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PhotoModeOverlay>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PhotoModeOverlay>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_XI_GetScreenSize;
    /// <summary>
    /// Function: XI_GetScreenSize
    /// </summary>
    public unsafe virtual void XI_GetScreenSize(BmSDK.FString TargetPath, BmSDK.FString WidthVariableName, BmSDK.FString HeightVariableName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetScreenSize, "BmGame.RGFxMovieUI_PhotoModeOverlay.XI_GetScreenSize");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidthVariableName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeightVariableName, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close(bool Unload = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.RGFxMovieUI_PhotoModeOverlay.Close");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Unload, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoadedPackage;
    /// <summary>
    /// Function: OnLoadedPackage
    /// </summary>
    public unsafe override void OnLoadedPackage(BmSDK.FString sCallback)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoadedPackage, "BmGame.RGFxMovieUI_PhotoModeOverlay.OnLoadedPackage");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCallback, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_LoadedFrame;
    /// <summary>
    /// Function: UC_LoadedFrame
    /// </summary>
    public unsafe virtual void UC_LoadedFrame(BmSDK.FString LoadedFrame)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_LoadedFrame, "BmGame.RGFxMovieUI_PhotoModeOverlay.UC_LoadedFrame");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedFrame, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadFrame;
    /// <summary>
    /// Function: LoadFrame
    /// </summary>
    public unsafe virtual void LoadFrame(bool bInIsHighRes = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadFrame, "BmGame.RGFxMovieUI_PhotoModeOverlay.LoadFrame");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInIsHighRes, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetLogo;
    /// <summary>
    /// Function: UC_SetLogo
    /// </summary>
    public unsafe virtual void UC_SetLogo(int Position, int Scale)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetLogo, "BmGame.RGFxMovieUI_PhotoModeOverlay.UC_SetLogo");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetFrame;
    /// <summary>
    /// Function: UC_SetFrame
    /// </summary>
    public unsafe virtual void UC_SetFrame(int intensity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetFrame, "BmGame.RGFxMovieUI_PhotoModeOverlay.UC_SetFrame");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(intensity, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetVignette;
    /// <summary>
    /// Function: UC_SetVignette
    /// </summary>
    public unsafe virtual void UC_SetVignette(int Type, int intensity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetVignette, "BmGame.RGFxMovieUI_PhotoModeOverlay.UC_SetVignette");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(intensity, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ChangedSlider;
    /// <summary>
    /// Function: XI_ChangedSlider
    /// </summary>
    public unsafe virtual void XI_ChangedSlider()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ChangedSlider, "BmGame.RGFxMovieUI_PhotoModeOverlay.XI_ChangedSlider");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ChangedTab;
    /// <summary>
    /// Function: XI_ChangedTab
    /// </summary>
    public unsafe virtual void XI_ChangedTab()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ChangedTab, "BmGame.RGFxMovieUI_PhotoModeOverlay.XI_ChangedTab");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Set;
    /// <summary>
    /// Function: XI_Set
    /// </summary>
    public unsafe virtual void XI_Set(BmSDK.FString ItemName, float Value, BmSDK.FString ListItem, bool bIshighRes = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Set, "BmGame.RGFxMovieUI_PhotoModeOverlay.XI_Set");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ListItem, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIshighRes, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Setup;
    /// <summary>
    /// Function: XI_Setup
    /// </summary>
    public unsafe virtual void XI_Setup(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Setup, "BmGame.RGFxMovieUI_PhotoModeOverlay.XI_Setup");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SetRightMouseClick;
    /// <summary>
    /// Function: XI_SetRightMouseClick
    /// </summary>
    public unsafe virtual void XI_SetRightMouseClick(bool bInClick)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetRightMouseClick, "BmGame.RGFxMovieUI_PhotoModeOverlay.XI_SetRightMouseClick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInClick, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SetLeftMouseClick;
    /// <summary>
    /// Function: XI_SetLeftMouseClick
    /// </summary>
    public unsafe virtual void XI_SetLeftMouseClick(bool bInClick)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetLeftMouseClick, "BmGame.RGFxMovieUI_PhotoModeOverlay.XI_SetLeftMouseClick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInClick, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_PhotoListItem;
    /// <summary>
    /// Function: UC_PhotoListItem
    /// </summary>
    public unsafe virtual void UC_PhotoListItem(BmSDK.FString TabName, BmSDK.FString ItemName, int Max, float Current, float Default = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_PhotoListItem, "BmGame.RGFxMovieUI_PhotoModeOverlay.UC_PhotoListItem");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TabName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Max, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Default, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_PhotoSliderItem;
    /// <summary>
    /// Function: UC_PhotoSliderItem
    /// </summary>
    public unsafe virtual void UC_PhotoSliderItem(BmSDK.FString TabName, BmSDK.FString ItemName, float Min, float Max, float Step, float Default, BmSDK.FString Unit, int Fix, bool bMid, bool bPlus, float Current)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_PhotoSliderItem, "BmGame.RGFxMovieUI_PhotoModeOverlay.UC_PhotoSliderItem");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TabName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Min, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Max, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Step, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Default, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Unit, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fix, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMid, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlus, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 76);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnOut;
    /// <summary>
    /// Function: XI_OnOut
    /// </summary>
    public unsafe override void XI_OnOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnOut, "BmGame.RGFxMovieUI_PhotoModeOverlay.XI_OnOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_In;
    /// <summary>
    /// Function: XI_In
    /// </summary>
    public unsafe virtual void XI_In(bool bInUsingGamepad)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_In, "BmGame.RGFxMovieUI_PhotoModeOverlay.XI_In");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInUsingGamepad, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ToggleVisible;
    /// <summary>
    /// Function: XI_ToggleVisible
    /// </summary>
    public unsafe virtual void XI_ToggleVisible(bool bVisible, bool bInUsingGamepad)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ToggleVisible, "BmGame.RGFxMovieUI_PhotoModeOverlay.XI_ToggleVisible");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInUsingGamepad, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnBack;
    /// <summary>
    /// Function: XI_OnBack
    /// </summary>
    public unsafe override void XI_OnBack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnBack, "BmGame.RGFxMovieUI_PhotoModeOverlay.XI_OnBack");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_UpdatePrompts;
    /// <summary>
    /// Function: XI_UpdatePrompts
    /// </summary>
    public unsafe virtual void XI_UpdatePrompts(bool bInUsingGamepad)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_UpdatePrompts, "BmGame.RGFxMovieUI_PhotoModeOverlay.XI_UpdatePrompts");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInUsingGamepad, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupScreenPrompts;
    /// <summary>
    /// Function: SetupScreenPrompts
    /// </summary>
    public unsafe override void SetupScreenPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupScreenPrompts, "BmGame.RGFxMovieUI_PhotoModeOverlay.SetupScreenPrompts");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovieUI_PhotoModeOverlay.Init");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpecialInit;
    /// <summary>
    /// Function: SpecialInit
    /// </summary>
    public unsafe override bool SpecialInit(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialInit, "BmGame.RGFxMovieUI_PhotoModeOverlay.SpecialInit");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// ObjectProperty: PhotoCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RPhotoCameraController PhotoCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPhotoCameraController>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// IntProperty: VignetteType
    /// </summary>
    public unsafe int VignetteType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// IntProperty: VignetteIntensity
    /// </summary>
    public unsafe int VignetteIntensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// IntProperty: FrameType
    /// </summary>
    public unsafe int FrameType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// IntProperty: FrameIntensity
    /// </summary>
    public unsafe int FrameIntensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// IntProperty: LogoPosition
    /// </summary>
    public unsafe int LogoPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// IntProperty: LogoScale
    /// </summary>
    public unsafe int LogoScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// StrProperty: LoadingFrame
    /// </summary>
    public unsafe BmSDK.FString LoadingFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// IntProperty: TimeOnEnter
    /// </summary>
    public unsafe int TimeOnEnter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bIsPromptsVisible
    /// </summary>
    public unsafe bool bIsPromptsVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bPrevUsingGamepad
    /// </summary>
    public unsafe bool bPrevUsingGamepad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bBackPressed
    /// </summary>
    public unsafe bool bBackPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }
}
