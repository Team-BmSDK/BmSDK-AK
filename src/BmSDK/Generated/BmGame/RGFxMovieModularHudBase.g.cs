#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieModularHudBase<br/>
/// (size = 752)
/// (flags = 134217878)
/// </summary>
public partial class RGFxMovieModularHudBase : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieModularHudBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieModularHudBase.
    /// </summary>
    public static RGFxMovieModularHudBase DefaultObject => (RGFxMovieModularHudBase)StaticClass().DefaultObject;

    internal RGFxMovieModularHudBase() { }

    /// <summary>
    /// Constructs a new RGFxMovieModularHudBase
    /// </summary>
    public RGFxMovieModularHudBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieModularHudBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieModularHudBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieModularHudBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieModularHudBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieModularHudBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieModularHudBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieModularHudBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieModularHudBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieModularHudBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieModularHudBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetColorTransform;
    /// <summary>
    /// Function: SetColorTransform
    /// </summary>
    public unsafe virtual void SetColorTransform(float RedOffset, float GreenOffset, float BlueOffset, float RedScalar, float GreenScalar, float BlueScalar)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetColorTransform, "BmGame.RGFxMovieModularHudBase.SetColorTransform");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RedOffset, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GreenOffset, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlueOffset, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RedScalar, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GreenScalar, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlueScalar, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShakeAndFlashHudPrivate;
    /// <summary>
    /// Function: ShakeAndFlashHudPrivate
    /// </summary>
    public unsafe virtual void ShakeAndFlashHudPrivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShakeAndFlashHudPrivate, "BmGame.RGFxMovieModularHudBase.ShakeAndFlashHudPrivate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShakeHudPrivate;
    /// <summary>
    /// Function: ShakeHudPrivate
    /// </summary>
    public unsafe virtual void ShakeHudPrivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShakeHudPrivate, "BmGame.RGFxMovieModularHudBase.ShakeHudPrivate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlushShakeEntireHud;
    /// <summary>
    /// Function: FlushShakeEntireHud
    /// </summary>
    public unsafe virtual void FlushShakeEntireHud()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushShakeEntireHud, "BmGame.RGFxMovieModularHudBase.FlushShakeEntireHud");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShakeEntireHud;
    /// <summary>
    /// Function: ShakeEntireHud
    /// </summary>
    public unsafe virtual void ShakeEntireHud(bool FlashAndShake = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShakeEntireHud, "BmGame.RGFxMovieModularHudBase.ShakeEntireHud");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlashAndShake, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ManualAdvanceTick;
    /// <summary>
    /// Function: ManualAdvanceTick
    /// </summary>
    public unsafe override void ManualAdvanceTick(float DeltaT)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManualAdvanceTick, "BmGame.RGFxMovieModularHudBase.ManualAdvanceTick");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaT, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_PushDeferredCallsToGame;
    /// <summary>
    /// Function: XI_PushDeferredCallsToGame
    /// </summary>
    public unsafe virtual void XI_PushDeferredCallsToGame(BmSDK.FString deferred_calls)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_PushDeferredCallsToGame, "BmGame.RGFxMovieModularHudBase.XI_PushDeferredCallsToGame");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(deferred_calls, paramsPtr + 0);
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

    private static BmSDK.Function __fn_CheckAndClearDeferredCalls;
    /// <summary>
    /// Function: CheckAndClearDeferredCalls
    /// </summary>
    public unsafe virtual BmSDK.FString CheckAndClearDeferredCalls()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAndClearDeferredCalls, "BmGame.RGFxMovieModularHudBase.CheckAndClearDeferredCalls");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsModuleReady;
    /// <summary>
    /// Function: IsModuleReady
    /// </summary>
    public unsafe virtual int IsModuleReady(BmSDK.FString _ExtensionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsModuleReady, "BmGame.RGFxMovieModularHudBase.IsModuleReady");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CleanUpForCutscene;
    /// <summary>
    /// Function: CleanUpForCutscene
    /// </summary>
    public unsafe virtual void CleanUpForCutscene()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanUpForCutscene, "BmGame.RGFxMovieModularHudBase.CleanUpForCutscene");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSwfMovieFullName;
    /// <summary>
    /// Function: GetSwfMovieFullName
    /// </summary>
    public unsafe virtual BmSDK.FString GetSwfMovieFullName(BmSDK.GFxUI.SwfMovie TestMovie)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSwfMovieFullName, "BmGame.RGFxMovieModularHudBase.GetSwfMovieFullName");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestMovie, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AutoAdjustExtension;
    /// <summary>
    /// Function: AutoAdjustExtension
    /// </summary>
    public unsafe virtual void AutoAdjustExtension(BmSDK.FString _ExtensionName, int _WidescreenAdjust)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutoAdjustExtension, "BmGame.RGFxMovieModularHudBase.AutoAdjustExtension");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_WidescreenAdjust, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeleteHudExtension;
    /// <summary>
    /// Function: DeleteHudExtension
    /// </summary>
    public unsafe virtual void DeleteHudExtension(BmSDK.FString _ExtensionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeleteHudExtension, "BmGame.RGFxMovieModularHudBase.DeleteHudExtension");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateHudExtension;
    /// <summary>
    /// Function: CreateHudExtension
    /// </summary>
    public unsafe virtual void CreateHudExtension(BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath, int ModulePriority, bool CanBeTinted)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateHudExtension, "BmGame.RGFxMovieModularHudBase.CreateHudExtension");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ModulePriority, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanBeTinted, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateHudExtensionFromSwfMovie;
    /// <summary>
    /// Function: CreateHudExtensionFromSwfMovie
    /// </summary>
    public unsafe virtual void CreateHudExtensionFromSwfMovie(BmSDK.FString _ExtensionName, BmSDK.GFxUI.SwfMovie _ExtensionPath, int ModulePriority, bool CanBeTinted)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateHudExtensionFromSwfMovie, "BmGame.RGFxMovieModularHudBase.CreateHudExtensionFromSwfMovie");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ModulePriority, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanBeTinted, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterModuleClass;
    /// <summary>
    /// Function: RegisterModuleClass
    /// </summary>
    public unsafe virtual void RegisterModuleClass(BmSDK.BmGame.RHudModule the_module)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterModuleClass, "BmGame.RGFxMovieModularHudBase.RegisterModuleClass");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_module, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendVisibilityToFlash;
    /// <summary>
    /// Function: SendVisibilityToFlash
    /// </summary>
    public unsafe virtual void SendVisibilityToFlash(bool bVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendVisibilityToFlash, "BmGame.RGFxMovieModularHudBase.SendVisibilityToFlash");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVisibilityAuto;
    /// <summary>
    /// Function: SetVisibilityAuto
    /// </summary>
    public unsafe virtual void SetVisibilityAuto()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVisibilityAuto, "BmGame.RGFxMovieModularHudBase.SetVisibilityAuto");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHudVisibility;
    /// <summary>
    /// Function: UpdateHudVisibility
    /// </summary>
    public unsafe override void UpdateHudVisibility(bool bVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHudVisibility, "BmGame.RGFxMovieModularHudBase.UpdateHudVisibility");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ManuallySetHudVisibility;
    /// <summary>
    /// Function: ManuallySetHudVisibility
    /// </summary>
    public unsafe virtual void ManuallySetHudVisibility(bool bVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManuallySetHudVisibility, "BmGame.RGFxMovieModularHudBase.ManuallySetHudVisibility");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSelectiveVisibilityModule;
    /// <summary>
    /// Function: SetSelectiveVisibilityModule
    /// </summary>
    public unsafe virtual void SetSelectiveVisibilityModule(BmSDK.FString module_name)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSelectiveVisibilityModule, "BmGame.RGFxMovieModularHudBase.SetSelectiveVisibilityModule");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(module_name, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsModuleVisible;
    /// <summary>
    /// Function: IsModuleVisible
    /// </summary>
    public unsafe virtual bool IsModuleVisible(BmSDK.FString module_name)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsModuleVisible, "BmGame.RGFxMovieModularHudBase.IsModuleVisible");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(module_name, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SetSelectiveVisibilityModuleByReference;
    /// <summary>
    /// Function: SetSelectiveVisibilityModuleByReference
    /// </summary>
    public unsafe virtual void SetSelectiveVisibilityModuleByReference(BmSDK.BmGame.RHudModule the_module)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSelectiveVisibilityModuleByReference, "BmGame.RGFxMovieModularHudBase.SetSelectiveVisibilityModuleByReference");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_module, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestSetSelectiveVisibilityModule;
    /// <summary>
    /// Function: TestSetSelectiveVisibilityModule
    /// </summary>
    public unsafe virtual void TestSetSelectiveVisibilityModule()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestSetSelectiveVisibilityModule, "BmGame.RGFxMovieModularHudBase.TestSetSelectiveVisibilityModule");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterAsManualAdvanceMovie;
    /// <summary>
    /// Function: RegisterAsManualAdvanceMovie
    /// </summary>
    public unsafe virtual void RegisterAsManualAdvanceMovie(bool do_register)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterAsManualAdvanceMovie, "BmGame.RGFxMovieModularHudBase.RegisterAsManualAdvanceMovie");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(do_register, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAspectRatioChanged;
    /// <summary>
    /// Function: OnAspectRatioChanged
    /// </summary>
    public unsafe override void OnAspectRatioChanged(float aspect_ratio)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAspectRatioChanged, "BmGame.RGFxMovieModularHudBase.OnAspectRatioChanged");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aspect_ratio, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnClose;
    /// <summary>
    /// Function: OnClose
    /// </summary>
    public unsafe override void OnClose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClose, "BmGame.RGFxMovieModularHudBase.OnClose");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovieModularHudBase.Init");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bHudVisibilityGame
    /// </summary>
    public unsafe bool bHudVisibilityGame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bHudVisibilityManual
    /// </summary>
    public unsafe bool bHudVisibilityManual
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bFlagCheckHudVisibility
    /// </summary>
    public unsafe bool bFlagCheckHudVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bRegisteredAsManualAdvanceMovie
    /// </summary>
    public unsafe bool bRegisteredAsManualAdvanceMovie
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// ArrayProperty: ModulesWaitingToInitialise
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHudModule> ModulesWaitingToInitialise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHudModule>>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// StrProperty: SelectiveVisibilityModule
    /// </summary>
    public unsafe BmSDK.FString SelectiveVisibilityModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// StrProperty: DeferredExternalInterfaceCallsString
    /// </summary>
    public unsafe BmSDK.FString DeferredExternalInterfaceCallsString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// IntProperty: HudShakeQueued
    /// </summary>
    public unsafe int HudShakeQueued
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }
}
