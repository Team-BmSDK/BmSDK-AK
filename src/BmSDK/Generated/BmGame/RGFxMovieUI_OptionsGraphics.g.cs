#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_OptionsGraphics<br/>
/// (size = 1168)
/// (flags = 134217878)
/// </summary>
public partial class RGFxMovieUI_OptionsGraphics : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_OptionsGraphics", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_OptionsGraphics.
    /// </summary>
    public static RGFxMovieUI_OptionsGraphics DefaultObject => (RGFxMovieUI_OptionsGraphics)StaticClass().DefaultObject;

    internal RGFxMovieUI_OptionsGraphics() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_OptionsGraphics
    /// </summary>
    public RGFxMovieUI_OptionsGraphics(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_OptionsGraphics Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_OptionsGraphics(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsGraphics>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsGraphics>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsGraphics>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsGraphics>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsGraphics>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsGraphics>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsGraphics>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsGraphics>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe override void CloseScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmGame.RGFxMovieUI_OptionsGraphics.CloseScreen");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetResolution;
    /// <summary>
    /// Function: ResetResolution
    /// </summary>
    public unsafe virtual void ResetResolution()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetResolution, "BmGame.RGFxMovieUI_OptionsGraphics.ResetResolution");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnX;
    /// <summary>
    /// Function: XI_OnX
    /// </summary>
    public unsafe override void XI_OnX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnX, "BmGame.RGFxMovieUI_OptionsGraphics.XI_OnX");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Tick;
    /// <summary>
    /// Function: XI_Tick
    /// </summary>
    public unsafe override void XI_Tick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Tick, "BmGame.RGFxMovieUI_OptionsGraphics.XI_Tick");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckRestartChange;
    /// <summary>
    /// Function: CheckRestartChange
    /// </summary>
    public unsafe virtual void CheckRestartChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckRestartChange, "BmGame.RGFxMovieUI_OptionsGraphics.CheckRestartChange");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckResolution;
    /// <summary>
    /// Function: CheckResolution
    /// </summary>
    public unsafe virtual void CheckResolution()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckResolution, "BmGame.RGFxMovieUI_OptionsGraphics.CheckResolution");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoExit;
    /// <summary>
    /// Function: DoExit
    /// </summary>
    public unsafe override void DoExit(bool ApplyChanges)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoExit, "BmGame.RGFxMovieUI_OptionsGraphics.DoExit");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ApplyChanges, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnApply;
    /// <summary>
    /// Function: OnApply
    /// </summary>
    public unsafe virtual void OnApply()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnApply, "BmGame.RGFxMovieUI_OptionsGraphics.OnApply");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnBack;
    /// <summary>
    /// Function: XI_OnBack
    /// </summary>
    public unsafe override void XI_OnBack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnBack, "BmGame.RGFxMovieUI_OptionsGraphics.XI_OnBack");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopupRequester_Callback;
    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe override void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmGame.RGFxMovieUI_OptionsGraphics.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Set;
    /// <summary>
    /// Function: XI_Set
    /// </summary>
    public unsafe virtual void XI_Set(int Id, BmSDK.FString Type, int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Set, "BmGame.RGFxMovieUI_OptionsGraphics.XI_Set");
        byte* paramsPtr = stackalloc byte[24];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Get, "BmGame.RGFxMovieUI_OptionsGraphics.XI_Get");
        byte* paramsPtr = stackalloc byte[24];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetDefault, "BmGame.RGFxMovieUI_OptionsGraphics.XI_GetDefault");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ConvertOptionIndexToAdaptiveVsync;
    /// <summary>
    /// Function: ConvertOptionIndexToAdaptiveVsync
    /// </summary>
    public unsafe virtual int ConvertOptionIndexToAdaptiveVsync(int OptionIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConvertOptionIndexToAdaptiveVsync, "BmGame.RGFxMovieUI_OptionsGraphics.ConvertOptionIndexToAdaptiveVsync");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OptionIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ConvertOptionIndexToVsync;
    /// <summary>
    /// Function: ConvertOptionIndexToVsync
    /// </summary>
    public unsafe virtual int ConvertOptionIndexToVsync(int OptionIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConvertOptionIndexToVsync, "BmGame.RGFxMovieUI_OptionsGraphics.ConvertOptionIndexToVsync");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OptionIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ConvertToVsyncOptionIndex;
    /// <summary>
    /// Function: ConvertToVsyncOptionIndex
    /// </summary>
    public unsafe virtual int ConvertToVsyncOptionIndex(int Vsync, int AdaptiveVsync)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConvertToVsyncOptionIndex, "BmGame.RGFxMovieUI_OptionsGraphics.ConvertToVsyncOptionIndex");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vsync, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AdaptiveVsync, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_BuildVsyncList;
    /// <summary>
    /// Function: BuildVsyncList
    /// </summary>
    public unsafe virtual BmSDK.FString BuildVsyncList()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuildVsyncList, "BmGame.RGFxMovieUI_OptionsGraphics.BuildVsyncList");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFPSIndex;
    /// <summary>
    /// Function: GetFPSIndex
    /// </summary>
    public unsafe virtual int GetFPSIndex(int FPS)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFPSIndex, "BmGame.RGFxMovieUI_OptionsGraphics.GetFPSIndex");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FPS, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SortByFPS;
    /// <summary>
    /// Function: SortByFPS
    /// </summary>
    public unsafe virtual int SortByFPS(int A, int B)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortByFPS, "BmGame.RGFxMovieUI_OptionsGraphics.SortByFPS");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_BuildFPSList;
    /// <summary>
    /// Function: BuildFPSList
    /// </summary>
    public unsafe virtual BmSDK.FString BuildFPSList()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuildFPSList, "BmGame.RGFxMovieUI_OptionsGraphics.BuildFPSList");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_SetupMenu;
    /// <summary>
    /// Function: XI_SetupMenu
    /// </summary>
    public unsafe override void XI_SetupMenu(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetupMenu, "BmGame.RGFxMovieUI_OptionsGraphics.XI_SetupMenu");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableResolutionMenuItem;
    /// <summary>
    /// Function: EnableResolutionMenuItem
    /// </summary>
    public unsafe virtual void EnableResolutionMenuItem()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableResolutionMenuItem, "BmGame.RGFxMovieUI_OptionsGraphics.EnableResolutionMenuItem");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableResolutionMenuItem;
    /// <summary>
    /// Function: DisableResolutionMenuItem
    /// </summary>
    public unsafe virtual void DisableResolutionMenuItem()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableResolutionMenuItem, "BmGame.RGFxMovieUI_OptionsGraphics.DisableResolutionMenuItem");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableResolutionMenuItem_ASHelper;
    /// <summary>
    /// Function: EnableResolutionMenuItem_ASHelper
    /// </summary>
    public unsafe virtual void EnableResolutionMenuItem_ASHelper(int AllMenuIndex, int MenuItemsIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableResolutionMenuItem_ASHelper, "BmGame.RGFxMovieUI_OptionsGraphics.EnableResolutionMenuItem_ASHelper");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllMenuIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MenuItemsIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableResolutionMenuItem_ASHelper;
    /// <summary>
    /// Function: DisableResolutionMenuItem_ASHelper
    /// </summary>
    public unsafe virtual void DisableResolutionMenuItem_ASHelper(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableResolutionMenuItem_ASHelper, "BmGame.RGFxMovieUI_OptionsGraphics.DisableResolutionMenuItem_ASHelper");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAlphaOfMenuItem_ASHelper;
    /// <summary>
    /// Function: SetAlphaOfMenuItem_ASHelper
    /// </summary>
    public unsafe virtual void SetAlphaOfMenuItem_ASHelper(int indexIntoAllItems, float newAlpha)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAlphaOfMenuItem_ASHelper, "BmGame.RGFxMovieUI_OptionsGraphics.SetAlphaOfMenuItem_ASHelper");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(indexIntoAllItems, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newAlpha, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CopyOptions;
    /// <summary>
    /// Function: CopyOptions
    /// </summary>
    public unsafe virtual void CopyOptions()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CopyOptions, "BmGame.RGFxMovieUI_OptionsGraphics.CopyOptions");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddResolutionLabel;
    /// <summary>
    /// Function: AddResolutionLabel
    /// </summary>
    public unsafe virtual void AddResolutionLabel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddResolutionLabel, "BmGame.RGFxMovieUI_OptionsGraphics.AddResolutionLabel");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovieUI_OptionsGraphics.Init");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetResolutionLabelNames;
    /// <summary>
    /// Function: GetResolutionLabelNames
    /// </summary>
    public unsafe virtual bool GetResolutionLabelNames()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetResolutionLabelNames, "BmGame.RGFxMovieUI_OptionsGraphics.GetResolutionLabelNames");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ApplySelectedOptions;
    /// <summary>
    /// Function: ApplySelectedOptions
    /// </summary>
    public unsafe virtual void ApplySelectedOptions()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplySelectedOptions, "BmGame.RGFxMovieUI_OptionsGraphics.ApplySelectedOptions");
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

    /// <summary>
    /// IntProperty: DisplayModeCopy
    /// </summary>
    public unsafe int DisplayModeCopy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// IntProperty: ResolutionXCopy
    /// </summary>
    public unsafe int ResolutionXCopy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// IntProperty: ResolutionYCopy
    /// </summary>
    public unsafe int ResolutionYCopy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// FloatProperty: TimeInSec
    /// </summary>
    public unsafe float TimeInSec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// BoolProperty: bQuestionPrompted
    /// </summary>
    public unsafe bool bQuestionPrompted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1088); }
    }

    /// <summary>
    /// BoolProperty: bWindowedFullscreenMode
    /// </summary>
    public unsafe bool bWindowedFullscreenMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1088); }
    }

    /// <summary>
    /// BoolProperty: bInitialized
    /// </summary>
    public unsafe bool bInitialized
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1088); }
    }

    /// <summary>
    /// ObjectProperty: ConfirmationPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ConfirmationPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ObjectProperty: RestartPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester RestartPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ObjectProperty: ApplyChangesPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ApplyChangesPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ArrayProperty: SupportedResolutions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> SupportedResolutions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// IntProperty: DisplayMode_WindowedFullscreen
    /// </summary>
    public unsafe int DisplayMode_WindowedFullscreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// ArrayProperty: FPSArray
    /// </summary>
    public unsafe BmSDK.TArray<int> FPSArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// DelegateProperty: __SortByFPS__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByFPS__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }
}
