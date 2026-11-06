#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieBackScreen<br/>
/// (size = 1712)
/// (flags = 134217878)
/// </summary>
public partial class RGFxMovieBackScreen : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieBackScreen", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieBackScreen.
    /// </summary>
    public static RGFxMovieBackScreen DefaultObject => (RGFxMovieBackScreen)StaticClass().DefaultObject;

    internal RGFxMovieBackScreen() { }

    /// <summary>
    /// Constructs a new RGFxMovieBackScreen
    /// </summary>
    public RGFxMovieBackScreen(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieBackScreen Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieBackScreen(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieBackScreen>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieBackScreen>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieBackScreen>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieBackScreen>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieBackScreen>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieBackScreen>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieBackScreen>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieBackScreen>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetMapPostProcessValues;
    /// <summary>
    /// Function: SetMapPostProcessValues
    /// </summary>
    public unsafe virtual void SetMapPostProcessValues(bool bDefault, float FocusDistance, float ApertureStop)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMapPostProcessValues, "BmGame.RGFxMovieBackScreen.SetMapPostProcessValues");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDefault, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FocusDistance, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ApertureStop, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Tick;
    /// <summary>
    /// Function: XI_Tick
    /// </summary>
    public unsafe override void XI_Tick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Tick, "BmGame.RGFxMovieBackScreen.XI_Tick");
        byte* paramsPtr = stackalloc byte[0];
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

    private static BmSDK.Function __fn_GetRotatorShortestDiff;
    /// <summary>
    /// Function: GetRotatorShortestDiff
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetRotatorShortestDiff(BmSDK.Rotator Diff)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRotatorShortestDiff, "BmGame.RGFxMovieBackScreen.GetRotatorShortestDiff");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Diff, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_XI_CloseScreen;
    /// <summary>
    /// Function: XI_CloseScreen
    /// </summary>
    public unsafe virtual void XI_CloseScreen(BmSDK.FString ScreenName, bool bIsShutdown)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_CloseScreen, "BmGame.RGFxMovieBackScreen.XI_CloseScreen");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreenName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsShutdown, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OpenScreen;
    /// <summary>
    /// Function: XI_OpenScreen
    /// </summary>
    public unsafe virtual void XI_OpenScreen(BmSDK.FString ScreenName, bool bIsFirstScreen)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OpenScreen, "BmGame.RGFxMovieBackScreen.XI_OpenScreen");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreenName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsFirstScreen, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SetIconState;
    /// <summary>
    /// Function: XI_SetIconState
    /// </summary>
    public unsafe virtual void XI_SetIconState(bool bVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetIconState, "BmGame.RGFxMovieBackScreen.XI_SetIconState");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnOut;
    /// <summary>
    /// Function: XI_OnOut
    /// </summary>
    public unsafe override void XI_OnOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnOut, "BmGame.RGFxMovieBackScreen.XI_OnOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnOutro;
    /// <summary>
    /// Function: XI_OnOutro
    /// </summary>
    public unsafe override void XI_OnOutro()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnOutro, "BmGame.RGFxMovieBackScreen.XI_OnOutro");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnIn;
    /// <summary>
    /// Function: XI_OnIn
    /// </summary>
    public unsafe override void XI_OnIn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnIn, "BmGame.RGFxMovieBackScreen.XI_OnIn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnIntro;
    /// <summary>
    /// Function: XI_OnIntro
    /// </summary>
    public unsafe override void XI_OnIntro()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnIntro, "BmGame.RGFxMovieBackScreen.XI_OnIntro");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreemptivelyBlockInputForMinigame;
    /// <summary>
    /// Function: PreemptivelyBlockInputForMinigame
    /// </summary>
    public unsafe virtual void PreemptivelyBlockInputForMinigame()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreemptivelyBlockInputForMinigame, "BmGame.RGFxMovieBackScreen.PreemptivelyBlockInputForMinigame");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsOverworldGameplay;
    /// <summary>
    /// Function: IsOverworldGameplay
    /// </summary>
    public unsafe virtual bool IsOverworldGameplay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOverworldGameplay, "BmGame.RGFxMovieBackScreen.IsOverworldGameplay");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ParseParams;
    /// <summary>
    /// Function: ParseParams
    /// </summary>
    public unsafe virtual void ParseParams()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ParseParams, "BmGame.RGFxMovieBackScreen.ParseParams");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsEnygmaRiddleActive;
    /// <summary>
    /// Function: IsEnygmaRiddleActive
    /// </summary>
    public unsafe virtual bool IsEnygmaRiddleActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsEnygmaRiddleActive, "BmGame.RGFxMovieBackScreen.IsEnygmaRiddleActive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_SetupTabMenu;
    /// <summary>
    /// Function: XI_SetupTabMenu
    /// </summary>
    public unsafe virtual int XI_SetupTabMenu(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetupTabMenu, "BmGame.RGFxMovieBackScreen.XI_SetupTabMenu");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_UC_SwitchToTab;
    /// <summary>
    /// Function: UC_SwitchToTab
    /// </summary>
    public unsafe virtual void UC_SwitchToTab(BmSDK.FString TabName, BmSDK.FString Params)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SwitchToTab, "BmGame.RGFxMovieBackScreen.UC_SwitchToTab");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TabName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_AddTabMenuButton;
    /// <summary>
    /// Function: UC_AddTabMenuButton
    /// </summary>
    public unsafe virtual BmSDK.FString UC_AddTabMenuButton(BmSDK.FString PackageName, BmSDK.FString PageTypeName, bool bNew = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_AddTabMenuButton, "BmGame.RGFxMovieBackScreen.UC_AddTabMenuButton");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PageTypeName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNew, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_SpeechFinishedCallback;
    /// <summary>
    /// Function: SpeechFinishedCallback
    /// </summary>
    public unsafe virtual void SpeechFinishedCallback()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpeechFinishedCallback, "BmGame.RGFxMovieBackScreen.SpeechFinishedCallback");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSubtitle;
    /// <summary>
    /// Function: SetSubtitle
    /// </summary>
    public unsafe override void SetSubtitle(BmSDK.FString TheText)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSubtitle, "BmGame.RGFxMovieBackScreen.SetSubtitle");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheText, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEvictCachesAfterAllocFail;
    /// <summary>
    /// Function: SetEvictCachesAfterAllocFail
    /// </summary>
    public unsafe virtual void SetEvictCachesAfterAllocFail(bool Set)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEvictCachesAfterAllocFail, "BmGame.RGFxMovieBackScreen.SetEvictCachesAfterAllocFail");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetXPNeededStr;
    /// <summary>
    /// Function: GetXPNeededStr
    /// </summary>
    public unsafe virtual BmSDK.FString GetXPNeededStr(int XPNeeded)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetXPNeededStr, "BmGame.RGFxMovieBackScreen.GetXPNeededStr");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPNeeded, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ResetMousePosition;
    /// <summary>
    /// Function: ResetMousePosition
    /// </summary>
    public unsafe virtual void ResetMousePosition(float x_prop, float y_prop)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetMousePosition, "BmGame.RGFxMovieBackScreen.ResetMousePosition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(x_prop, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(y_prop, paramsPtr + 4);
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

    private static BmSDK.Function __fn_StoreVariablesToPData;
    /// <summary>
    /// Function: StoreVariablesToPData
    /// </summary>
    public unsafe virtual void StoreVariablesToPData()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StoreVariablesToPData, "BmGame.RGFxMovieBackScreen.StoreVariablesToPData");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVariablesFromPData;
    /// <summary>
    /// Function: SetVariablesFromPData
    /// </summary>
    public unsafe virtual void SetVariablesFromPData()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVariablesFromPData, "BmGame.RGFxMovieBackScreen.SetVariablesFromPData");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroy;
    /// <summary>
    /// Function: Destroy
    /// </summary>
    public unsafe virtual void Destroy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroy, "BmGame.RGFxMovieBackScreen.Destroy");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovieBackScreen.Init");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StrProperty: TabMenuPath
    /// </summary>
    public unsafe BmSDK.FString TabMenuPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bEnygmaClosePending
    /// </summary>
    public unsafe bool bEnygmaClosePending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1088); }
    }

    /// <summary>
    /// BoolProperty: bParams_Present
    /// </summary>
    public unsafe bool bParams_Present
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1088); }
    }

    /// <summary>
    /// StrProperty: Params_TargetScreen
    /// </summary>
    public unsafe BmSDK.FString Params_TargetScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// StrProperty: Params_TargetScreenParams
    /// </summary>
    public unsafe BmSDK.FString Params_TargetScreenParams
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ByteProperty: RiddlerStatus
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieBackScreen.RiddleLoadingStatus RiddlerStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieBackScreen.RiddleLoadingStatus>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// StructProperty: RiddlerHandle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle RiddlerHandle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 1128);

    /// <summary>
    /// ObjectProperty: RGI
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo RGI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ObjectProperty: GRI
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI GRI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ObjectProperty: PDD
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentDebugData PDD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentDebugData>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// ObjectProperty: CMan
    /// </summary>
    public unsafe BmSDK.BmGame.RChallengeManager CMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChallengeManager>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// ObjectProperty: MapController
    /// </summary>
    public unsafe BmSDK.BmGame.RMapController MapController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMapController>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// StructProperty: WorldPPSettings
    /// </summary>
    public unsafe ref BmSDK.Engine.PostProcessVolume.FPostProcessSettings WorldPPSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.PostProcessVolume.FPostProcessSettings>(Ptr + 1184);

    /// <summary>
    /// FloatProperty: MapMode3D_Alpha
    /// </summary>
    public unsafe float MapMode3D_Alpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// Enum: RiddleLoadingStatus
    /// </summary>
    public enum RiddleLoadingStatus : byte
    {
        RLS_None = 0,
        RLS_Package = 1,
        RLS_Done = 2,
        RLS_MAX = 3,
    }

    /// <summary>
    /// Enum: UpgradeItemType
    /// </summary>
    public enum UpgradeItemType : byte
    {
        UIT_Batsuit = 0,
        UIT_Gadgets = 1,
        UIT_Combat = 2,
        UIT_Predator = 3,
        UIT_Catwoman = 4,
        UIT_MAX = 5,
    }
}
