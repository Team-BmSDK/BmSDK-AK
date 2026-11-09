#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI<br/>
/// (size = 1072)
/// (flags = 134217878)
/// </summary>
public partial class RGFxMovieUI : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI.
    /// </summary>
    public static RGFxMovieUI DefaultObject => (RGFxMovieUI)StaticClass().DefaultObject;

    internal RGFxMovieUI() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI
    /// </summary>
    public RGFxMovieUI(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetEnabledStatusIME;
    /// <summary>
    /// Function: SetEnabledStatusIME
    /// </summary>
    public unsafe virtual void SetEnabledStatusIME(bool bEnable)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEnabledStatusIME, "BmGame.RGFxMovieUI.SetEnabledStatusIME");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnable, paramsPtr + 0);
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

    private static BmSDK.Function __fn_XI_IsThumbButtonPressed;
    /// <summary>
    /// Function: XI_IsThumbButtonPressed
    /// </summary>
    public unsafe virtual void XI_IsThumbButtonPressed(BmSDK.FString TargetPath, BmSDK.FString TargetVar)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_IsThumbButtonPressed, "BmGame.RGFxMovieUI.XI_IsThumbButtonPressed");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetVar, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetRebindableKeysDown;
    /// <summary>
    /// Function: XI_GetRebindableKeysDown
    /// </summary>
    public unsafe virtual void XI_GetRebindableKeysDown(BmSDK.FString TargetPath, BmSDK.FString TargetVar)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetRebindableKeysDown, "BmGame.RGFxMovieUI.XI_GetRebindableKeysDown");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetVar, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsAnyAltPressed;
    /// <summary>
    /// Function: IsAnyAltPressed
    /// </summary>
    public unsafe virtual bool IsAnyAltPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAnyAltPressed, "BmGame.RGFxMovieUI.IsAnyAltPressed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsKeyBindingPressed;
    /// <summary>
    /// Function: IsKeyBindingPressed
    /// </summary>
    public unsafe virtual int IsKeyBindingPressed(BmSDK.BmGame.RPersistentOptions.EControlsOptionsKeyboard KeyBinding)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsKeyBindingPressed, "BmGame.RGFxMovieUI.IsKeyBindingPressed");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyBinding, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckLevelPackageIsPresent;
    /// <summary>
    /// Function: CheckLevelPackageIsPresent
    /// </summary>
    public unsafe virtual bool CheckLevelPackageIsPresent(out BmSDK.FString LevelName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckLevelPackageIsPresent, "BmGame.RGFxMovieUI.CheckLevelPackageIsPresent");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LevelName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SendHydraReportPhotoModeUsed;
    /// <summary>
    /// Function: SendHydraReportPhotoModeUsed
    /// </summary>
    public unsafe virtual void SendHydraReportPhotoModeUsed(int TimeSpentInPhotoMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraReportPhotoModeUsed, "BmGame.RGFxMovieUI.SendHydraReportPhotoModeUsed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeSpentInPhotoMode, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SendHydraWBPlayRewardClaimedEvent;
    /// <summary>
    /// Function: SendHydraWBPlayRewardClaimedEvent
    /// </summary>
    public unsafe virtual void SendHydraWBPlayRewardClaimedEvent(BmSDK.FString RewardFlag)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraWBPlayRewardClaimedEvent, "BmGame.RGFxMovieUI.SendHydraWBPlayRewardClaimedEvent");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RewardFlag, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SendHydraReportGraphicsOptions;
    /// <summary>
    /// Function: SendHydraReportGraphicsOptions
    /// </summary>
    public unsafe virtual void SendHydraReportGraphicsOptions()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraReportGraphicsOptions, "BmGame.RGFxMovieUI.SendHydraReportGraphicsOptions");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_GetKeyCode;
    /// <summary>
    /// Function: GetKeyCode
    /// </summary>
    public unsafe virtual int GetKeyCode(BmSDK.FString Key)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetKeyCode, "BmGame.RGFxMovieUI.GetKeyCode");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_XI_GetKeyBinding;
    /// <summary>
    /// Function: XI_GetKeyBinding
    /// </summary>
    public unsafe virtual void XI_GetKeyBinding(BmSDK.FString TargetPath, BmSDK.FString Ability, BmSDK.FString PrimaryKey, BmSDK.FString SecondaryKey)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetKeyBinding, "BmGame.RGFxMovieUI.XI_GetKeyBinding");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Ability, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrimaryKey, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondaryKey, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMouseVisible;
    /// <summary>
    /// Function: SetMouseVisible
    /// </summary>
    public unsafe virtual void SetMouseVisible(bool bVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMouseVisible, "BmGame.RGFxMovieUI.SetMouseVisible");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetMouseLock;
    /// <summary>
    /// Function: SetMouseLock
    /// </summary>
    public unsafe virtual void SetMouseLock(bool bLock)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMouseLock, "BmGame.RGFxMovieUI.SetMouseLock");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLock, paramsPtr + 0);
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

    private static BmSDK.Function __fn_XI_GetViewportHeight;
    /// <summary>
    /// Function: XI_GetViewportHeight
    /// </summary>
    public unsafe virtual void XI_GetViewportHeight(BmSDK.FString TargetPath, BmSDK.FString VariableName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetViewportHeight, "BmGame.RGFxMovieUI.XI_GetViewportHeight");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetViewportWidth;
    /// <summary>
    /// Function: XI_GetViewportWidth
    /// </summary>
    public unsafe virtual void XI_GetViewportWidth(BmSDK.FString TargetPath, BmSDK.FString VariableName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetViewportWidth, "BmGame.RGFxMovieUI.XI_GetViewportWidth");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetMouse_Y;
    /// <summary>
    /// Function: XI_GetMouse_Y
    /// </summary>
    public unsafe virtual void XI_GetMouse_Y(BmSDK.FString TargetPath, BmSDK.FString VariableName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetMouse_Y, "BmGame.RGFxMovieUI.XI_GetMouse_Y");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetMouseX;
    /// <summary>
    /// Function: XI_GetMouseX
    /// </summary>
    public unsafe virtual void XI_GetMouseX(BmSDK.FString TargetPath, BmSDK.FString VariableName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetMouseX, "BmGame.RGFxMovieUI.XI_GetMouseX");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HaveWarnerIdCheckForConnection;
    /// <summary>
    /// Function: HaveWarnerIdCheckForConnection
    /// </summary>
    public unsafe virtual void HaveWarnerIdCheckForConnection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HaveWarnerIdCheckForConnection, "BmGame.RGFxMovieUI.HaveWarnerIdCheckForConnection");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_ProcessVoiceCommand;
    /// <summary>
    /// Function: ProcessVoiceCommand
    /// </summary>
    public unsafe override bool ProcessVoiceCommand(BmSDK.FString VoiceRecCommand)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessVoiceCommand, "BmGame.RGFxMovieUI.ProcessVoiceCommand");
        byte* paramsPtr = stackalloc byte[37];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VoiceRecCommand, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_UC_TriggerVoiceCommand;
    /// <summary>
    /// Function: UC_TriggerVoiceCommand
    /// </summary>
    public unsafe virtual void UC_TriggerVoiceCommand(BmSDK.FString VoiceRecCommand)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_TriggerVoiceCommand, "BmGame.RGFxMovieUI.UC_TriggerVoiceCommand");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VoiceRecCommand, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleGAS;
    /// <summary>
    /// Function: HandleGAS
    /// </summary>
    public unsafe virtual bool HandleGAS(BmSDK.FString Cmd)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleGAS, "BmGame.RGFxMovieUI.HandleGAS");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cmd, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsStoryActive;
    /// <summary>
    /// Function: IsStoryActive
    /// </summary>
    public unsafe virtual bool IsStoryActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStoryActive, "BmGame.RGFxMovieUI.IsStoryActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateTextField;
    /// <summary>
    /// Function: UpdateTextField
    /// </summary>
    public unsafe virtual void UpdateTextField(BmSDK.FString FuncName, int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTextField, "BmGame.RGFxMovieUI.UpdateTextField");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FuncName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_RegisterTextField;
    /// <summary>
    /// Function: XI_RegisterTextField
    /// </summary>
    public unsafe virtual void XI_RegisterTextField(BmSDK.FString FuncName, int Value, BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_RegisterTextField, "BmGame.RGFxMovieUI.XI_RegisterTextField");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FuncName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SetIsUsingDefaults;
    /// <summary>
    /// Function: XI_SetIsUsingDefaults
    /// </summary>
    public unsafe virtual void XI_SetIsUsingDefaults(bool bIsDefaults)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetIsUsingDefaults, "BmGame.RGFxMovieUI.XI_SetIsUsingDefaults");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsDefaults, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_UpdateInitialValues;
    /// <summary>
    /// Function: UC_UpdateInitialValues
    /// </summary>
    public unsafe virtual void UC_UpdateInitialValues()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_UpdateInitialValues, "BmGame.RGFxMovieUI.UC_UpdateInitialValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_RestoreInitialValues;
    /// <summary>
    /// Function: UC_RestoreInitialValues
    /// </summary>
    public unsafe virtual void UC_RestoreInitialValues()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_RestoreInitialValues, "BmGame.RGFxMovieUI.UC_RestoreInitialValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetButtonExponent;
    /// <summary>
    /// Function: UC_SetButtonExponent
    /// </summary>
    public unsafe virtual void UC_SetButtonExponent(BmSDK.FString sButtonLabel, BmSDK.FString sExponentText, BmSDK.FString sExponentIcon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetButtonExponent, "BmGame.RGFxMovieUI.UC_SetButtonExponent");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sButtonLabel, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sExponentText, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sExponentIcon, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetDebugMenuAvailable;
    /// <summary>
    /// Function: UC_SetDebugMenuAvailable
    /// </summary>
    public unsafe virtual void UC_SetDebugMenuAvailable(bool bAvailable)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetDebugMenuAvailable, "BmGame.RGFxMovieUI.UC_SetDebugMenuAvailable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAvailable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetKeyEcho;
    /// <summary>
    /// Function: UC_SetKeyEcho
    /// </summary>
    public unsafe virtual void UC_SetKeyEcho(bool bEnabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetKeyEcho, "BmGame.RGFxMovieUI.UC_SetKeyEcho");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetMenuLocked;
    /// <summary>
    /// Function: UC_SetMenuLocked
    /// </summary>
    public unsafe virtual void UC_SetMenuLocked(bool bState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetMenuLocked, "BmGame.RGFxMovieUI.UC_SetMenuLocked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_RefreshFocus;
    /// <summary>
    /// Function: UC_RefreshFocus
    /// </summary>
    public unsafe virtual void UC_RefreshFocus()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_RefreshFocus, "BmGame.RGFxMovieUI.UC_RefreshFocus");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetLastUID;
    /// <summary>
    /// Function: UC_SetLastUID
    /// </summary>
    public unsafe virtual void UC_SetLastUID(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetLastUID, "BmGame.RGFxMovieUI.UC_SetLastUID");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_AddLogo;
    /// <summary>
    /// Function: UC_AddLogo
    /// </summary>
    public unsafe virtual void UC_AddLogo(int Id, BmSDK.FString Label, BmSDK.FString DisplayText, bool bDisabled = default, BmSDK.FString LocBase = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_AddLogo, "BmGame.RGFxMovieUI.UC_AddLogo");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisplayText, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDisabled, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocBase, paramsPtr + 40);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_UC_AddListItem;
    /// <summary>
    /// Function: UC_AddListItem
    /// </summary>
    public unsafe virtual void UC_AddListItem(int Id, BmSDK.FString Label, BmSDK.FString Params, bool bDisabled = default, BmSDK.FString LocBase = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_AddListItem, "BmGame.RGFxMovieUI.UC_AddListItem");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDisabled, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocBase, paramsPtr + 40);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_UC_AddSlider;
    /// <summary>
    /// Function: UC_AddSlider
    /// </summary>
    public unsafe virtual void UC_AddSlider(int Id, BmSDK.FString Label, int Step, bool bMakesSound = default, bool bDisabled = default, BmSDK.FString LocBase = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_AddSlider, "BmGame.RGFxMovieUI.UC_AddSlider");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Step, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMakesSound, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDisabled, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocBase, paramsPtr + 32);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_UC_AddButtonSaveGame;
    /// <summary>
    /// Function: UC_AddButtonSaveGame
    /// </summary>
    public unsafe virtual void UC_AddButtonSaveGame(int Id, BmSDK.FString Label, bool bAllowRollOver = default, bool bDisabled = default, BmSDK.FString LocBase = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_AddButtonSaveGame, "BmGame.RGFxMovieUI.UC_AddButtonSaveGame");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowRollOver, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDisabled, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocBase, paramsPtr + 28);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_UC_AddButtonCentered;
    /// <summary>
    /// Function: UC_AddButtonCentered
    /// </summary>
    public unsafe virtual void UC_AddButtonCentered(int Id, BmSDK.FString Label, bool bAllowRollOver = default, bool bShowNew = default, bool bDisabled = default, BmSDK.FString LocBase = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_AddButtonCentered, "BmGame.RGFxMovieUI.UC_AddButtonCentered");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowRollOver, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowNew, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDisabled, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocBase, paramsPtr + 32);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_UC_AddButton;
    /// <summary>
    /// Function: UC_AddButton
    /// </summary>
    public unsafe virtual void UC_AddButton(int Id, BmSDK.FString Label, bool bAllowRollOver = default, bool bShowNew = default, bool bDisabled = default, BmSDK.FString LocBase = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_AddButton, "BmGame.RGFxMovieUI.UC_AddButton");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowRollOver, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowNew, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDisabled, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocBase, paramsPtr + 32);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_UC_AddIndent;
    /// <summary>
    /// Function: UC_AddIndent
    /// </summary>
    public unsafe virtual void UC_AddIndent(int Indent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_AddIndent, "BmGame.RGFxMovieUI.UC_AddIndent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Indent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetOffset;
    /// <summary>
    /// Function: UC_SetOffset
    /// </summary>
    public unsafe virtual void UC_SetOffset(int Offset)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetOffset, "BmGame.RGFxMovieUI.UC_SetOffset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Offset, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SetupMenu;
    /// <summary>
    /// Function: XI_SetupMenu
    /// </summary>
    public unsafe virtual void XI_SetupMenu(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetupMenu, "BmGame.RGFxMovieUI.XI_SetupMenu");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_DetectNetworkDebugCheat;
    /// <summary>
    /// Function: XI_DetectNetworkDebugCheat
    /// </summary>
    public unsafe virtual void XI_DetectNetworkDebugCheat(int charCode, bool bIsRepeat)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_DetectNetworkDebugCheat, "BmGame.RGFxMovieUI.XI_DetectNetworkDebugCheat");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(charCode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsRepeat, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetTitle;
    /// <summary>
    /// Function: XI_GetTitle
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetTitle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetTitle, "BmGame.RGFxMovieUI.XI_GetTitle");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_OnOptionsToDefault;
    /// <summary>
    /// Function: XI_OnOptionsToDefault
    /// </summary>
    public unsafe virtual void XI_OnOptionsToDefault()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnOptionsToDefault, "BmGame.RGFxMovieUI.XI_OnOptionsToDefault");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OpenDebugLevelSelect;
    /// <summary>
    /// Function: XI_OpenDebugLevelSelect
    /// </summary>
    public unsafe virtual void XI_OpenDebugLevelSelect()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OpenDebugLevelSelect, "BmGame.RGFxMovieUI.XI_OpenDebugLevelSelect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnKey;
    /// <summary>
    /// Function: XI_OnKey
    /// </summary>
    public unsafe virtual void XI_OnKey(int KeyCode, bool bDown)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnKey, "BmGame.RGFxMovieUI.XI_OnKey");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyCode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDown, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnLostFocus;
    /// <summary>
    /// Function: XI_OnLostFocus
    /// </summary>
    public unsafe virtual void XI_OnLostFocus(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnLostFocus, "BmGame.RGFxMovieUI.XI_OnLostFocus");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnFocus;
    /// <summary>
    /// Function: XI_OnFocus
    /// </summary>
    public unsafe virtual void XI_OnFocus(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnFocus, "BmGame.RGFxMovieUI.XI_OnFocus");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnBack;
    /// <summary>
    /// Function: XI_OnBack
    /// </summary>
    public unsafe virtual void XI_OnBack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnBack, "BmGame.RGFxMovieUI.XI_OnBack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnStart;
    /// <summary>
    /// Function: XI_OnStart
    /// </summary>
    public unsafe virtual void XI_OnStart()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnStart, "BmGame.RGFxMovieUI.XI_OnStart");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnY;
    /// <summary>
    /// Function: XI_OnY
    /// </summary>
    public unsafe virtual void XI_OnY()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnY, "BmGame.RGFxMovieUI.XI_OnY");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnX;
    /// <summary>
    /// Function: XI_OnX
    /// </summary>
    public unsafe virtual void XI_OnX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnX, "BmGame.RGFxMovieUI.XI_OnX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnClicked;
    /// <summary>
    /// Function: XI_OnClicked
    /// </summary>
    public unsafe virtual void XI_OnClicked(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnClicked, "BmGame.RGFxMovieUI.XI_OnClicked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Tick;
    /// <summary>
    /// Function: XI_Tick
    /// </summary>
    public unsafe virtual void XI_Tick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Tick, "BmGame.RGFxMovieUI.XI_Tick");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnOut;
    /// <summary>
    /// Function: XI_OnOut
    /// </summary>
    public unsafe virtual void XI_OnOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnOut, "BmGame.RGFxMovieUI.XI_OnOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnOutro;
    /// <summary>
    /// Function: XI_OnOutro
    /// </summary>
    public unsafe virtual void XI_OnOutro()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnOutro, "BmGame.RGFxMovieUI.XI_OnOutro");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnIn;
    /// <summary>
    /// Function: XI_OnIn
    /// </summary>
    public unsafe virtual void XI_OnIn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnIn, "BmGame.RGFxMovieUI.XI_OnIn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnIntro;
    /// <summary>
    /// Function: XI_OnIntro
    /// </summary>
    public unsafe virtual void XI_OnIntro()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnIntro, "BmGame.RGFxMovieUI.XI_OnIntro");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateNewBlankGame;
    /// <summary>
    /// Function: CreateNewBlankGame
    /// </summary>
    public unsafe virtual void CreateNewBlankGame()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateNewBlankGame, "BmGame.RGFxMovieUI.CreateNewBlankGame");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Game_Replay1stCatwoman;
    /// <summary>
    /// Function: Game_Replay1stCatwoman
    /// </summary>
    public unsafe virtual void Game_Replay1stCatwoman(BmSDK.FString CharacterName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Game_Replay1stCatwoman, "BmGame.RGFxMovieUI.Game_Replay1stCatwoman");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterName, paramsPtr + 0);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_CheckCatwomanOffer;
    /// <summary>
    /// Function: CheckCatwomanOffer
    /// </summary>
    public unsafe virtual bool CheckCatwomanOffer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckCatwomanOffer, "BmGame.RGFxMovieUI.CheckCatwomanOffer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRetriesLeft;
    /// <summary>
    /// Function: GetRetriesLeft
    /// </summary>
    public unsafe virtual int GetRetriesLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRetriesLeft, "BmGame.RGFxMovieUI.GetRetriesLeft");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsCampaign;
    /// <summary>
    /// Function: IsCampaign
    /// </summary>
    public unsafe virtual bool IsCampaign()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCampaign, "BmGame.RGFxMovieUI.IsCampaign");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetDeviceName;
    /// <summary>
    /// Function: SetDeviceName
    /// </summary>
    public unsafe virtual void SetDeviceName(BmSDK.FString DeviceName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDeviceName, "BmGame.RGFxMovieUI.SetDeviceName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetGlobalFlag;
    /// <summary>
    /// Function: XI_GetGlobalFlag
    /// </summary>
    public unsafe virtual bool XI_GetGlobalFlag(BmSDK.FString sFlag)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetGlobalFlag, "BmGame.RGFxMovieUI.XI_GetGlobalFlag");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sFlag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_XI_SetRivalName;
    /// <summary>
    /// Function: XI_SetRivalName
    /// </summary>
    public unsafe virtual void XI_SetRivalName(BmSDK.FString RivalName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetRivalName, "BmGame.RGFxMovieUI.XI_SetRivalName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RivalName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetRivalName;
    /// <summary>
    /// Function: XI_GetRivalName
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetRivalName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetRivalName, "BmGame.RGFxMovieUI.XI_GetRivalName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_CustomPrompts;
    /// <summary>
    /// Function: XI_CustomPrompts
    /// </summary>
    public unsafe virtual void XI_CustomPrompts(BmSDK.FString sA, BmSDK.FString sB, BmSDK.FString sX, BmSDK.FString sY, bool bWithTab = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_CustomPrompts, "BmGame.RGFxMovieUI.XI_CustomPrompts");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sA, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sB, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sX, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sY, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWithTab, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPrompts;
    /// <summary>
    /// Function: SetPrompts
    /// </summary>
    public unsafe virtual void SetPrompts(BmSDK.BmGame.RGFxMovieUI.UIPromptType PromptType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrompts, "BmGame.RGFxMovieUI.SetPrompts");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PromptType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ClearPrompts;
    /// <summary>
    /// Function: XI_ClearPrompts
    /// </summary>
    public unsafe override void XI_ClearPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ClearPrompts, "BmGame.RGFxMovieUI.XI_ClearPrompts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MapPromptFind;
    /// <summary>
    /// Function: MapPromptFind
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHUDPrompt.EControlIcon MapPromptFind(BmSDK.FString VoiceCmd)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MapPromptFind, "BmGame.RGFxMovieUI.MapPromptFind");
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VoiceCmd, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_MapPromptEntry;
    /// <summary>
    /// Function: MapPromptEntry
    /// </summary>
    public unsafe virtual void MapPromptEntry(BmSDK.BmGame.RHUDPrompt.EControlIcon Icon, BmSDK.FString LocDirectRef, BmSDK.FString VoiceCmd = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MapPromptEntry, "BmGame.RGFxMovieUI.MapPromptEntry");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Icon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocDirectRef, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VoiceCmd, paramsPtr + 20);
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

    private static BmSDK.Function __fn_ResetVoicePromptMap;
    /// <summary>
    /// Function: ResetVoicePromptMap
    /// </summary>
    public unsafe virtual void ResetVoicePromptMap()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetVoicePromptMap, "BmGame.RGFxMovieUI.ResetVoicePromptMap");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_AddVoiceCmd;
    /// <summary>
    /// Function: AddVoiceCmd
    /// </summary>
    public unsafe virtual void AddVoiceCmd(BmSDK.FString Cmd)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddVoiceCmd, "BmGame.RGFxMovieUI.AddVoiceCmd");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cmd, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupScreenPrompts;
    /// <summary>
    /// Function: SetupScreenPrompts
    /// </summary>
    public unsafe virtual void SetupScreenPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupScreenPrompts, "BmGame.RGFxMovieUI.SetupScreenPrompts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnEvent;
    /// <summary>
    /// Function: OnEvent
    /// </summary>
    public unsafe virtual void OnEvent(BmSDK.BmGame.RGFxMovieUI.UIEVENT_ActionType ActionType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEvent, "BmGame.RGFxMovieUI.OnEvent");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActionType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoginLost;
    /// <summary>
    /// Function: OnLoginLost
    /// </summary>
    public unsafe virtual void OnLoginLost()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoginLost, "BmGame.RGFxMovieUI.OnLoginLost");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAltF4;
    /// <summary>
    /// Function: OnAltF4
    /// </summary>
    public unsafe virtual void OnAltF4()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAltF4, "BmGame.RGFxMovieUI.OnAltF4");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBackCustom;
    /// <summary>
    /// Function: OnBackCustom
    /// </summary>
    public unsafe virtual void OnBackCustom()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBackCustom, "BmGame.RGFxMovieUI.OnBackCustom");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnStreamingInstall_Callback;
    /// <summary>
    /// Function: OnStreamingInstall_Callback
    /// </summary>
    public unsafe virtual void OnStreamingInstall_Callback(bool bWasCancelled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnStreamingInstall_Callback, "BmGame.RGFxMovieUI.OnStreamingInstall_Callback");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasCancelled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopupRequester_Callback;
    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe override void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmGame.RGFxMovieUI.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BackOut;
    /// <summary>
    /// Function: BackOut
    /// </summary>
    public unsafe virtual void BackOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BackOut, "BmGame.RGFxMovieUI.BackOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoExit;
    /// <summary>
    /// Function: DoExit
    /// </summary>
    public unsafe virtual void DoExit(bool ApplyChanges)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoExit, "BmGame.RGFxMovieUI.DoExit");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ApplyChanges, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close(bool Unload = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.RGFxMovieUI.Close");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Unload, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TransitionBackToCurrent;
    /// <summary>
    /// Function: TransitionBackToCurrent
    /// </summary>
    public unsafe virtual void TransitionBackToCurrent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TransitionBackToCurrent, "BmGame.RGFxMovieUI.TransitionBackToCurrent");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TransitionForwardsKeepingCurrent;
    /// <summary>
    /// Function: TransitionForwardsKeepingCurrent
    /// </summary>
    public unsafe virtual void TransitionForwardsKeepingCurrent(BmSDK.FString EventName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TransitionForwardsKeepingCurrent, "BmGame.RGFxMovieUI.TransitionForwardsKeepingCurrent");
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TransitionForwards;
    /// <summary>
    /// Function: TransitionForwards
    /// </summary>
    public unsafe virtual void TransitionForwards(BmSDK.FString EventName, bool bClose)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TransitionForwards, "BmGame.RGFxMovieUI.TransitionForwards");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bClose, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TransitionBack;
    /// <summary>
    /// Function: TransitionBack
    /// </summary>
    public unsafe virtual void TransitionBack(BmSDK.FString EventName, bool bSilent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TransitionBack, "BmGame.RGFxMovieUI.TransitionBack");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSilent, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTheClassName;
    /// <summary>
    /// Function: GetTheClassName
    /// </summary>
    public unsafe override BmSDK.FString GetTheClassName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTheClassName, "BmGame.RGFxMovieUI.GetTheClassName");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe virtual void CloseScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmGame.RGFxMovieUI.CloseScreen");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInOutro;
    /// <summary>
    /// Function: IsInOutro
    /// </summary>
    public unsafe virtual bool IsInOutro()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInOutro, "BmGame.RGFxMovieUI.IsInOutro");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInIntro;
    /// <summary>
    /// Function: IsInIntro
    /// </summary>
    public unsafe virtual bool IsInIntro()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInIntro, "BmGame.RGFxMovieUI.IsInIntro");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInputBlocked;
    /// <summary>
    /// Function: IsInputBlocked
    /// </summary>
    public unsafe virtual bool IsInputBlocked()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInputBlocked, "BmGame.RGFxMovieUI.IsInputBlocked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetMouseCursorEnabled;
    /// <summary>
    /// Function: SetMouseCursorEnabled
    /// </summary>
    public unsafe virtual void SetMouseCursorEnabled(bool is_enabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMouseCursorEnabled, "BmGame.RGFxMovieUI.SetMouseCursorEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetUsingGamepad;
    /// <summary>
    /// Function: XI_GetUsingGamepad
    /// </summary>
    public unsafe override bool XI_GetUsingGamepad()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetUsingGamepad, "BmGame.RGFxMovieUI.XI_GetUsingGamepad");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_BlockInput;
    /// <summary>
    /// Function: XI_BlockInput
    /// </summary>
    public unsafe virtual void XI_BlockInput(bool bBlocked)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_BlockInput, "BmGame.RGFxMovieUI.XI_BlockInput");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBlocked, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlockInput;
    /// <summary>
    /// Function: BlockInput
    /// </summary>
    public unsafe virtual void BlockInput(bool bBlocked)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlockInput, "BmGame.RGFxMovieUI.BlockInput");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBlocked, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovieUI.Init");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpecialInit;
    /// <summary>
    /// Function: SpecialInit
    /// </summary>
    public unsafe virtual bool SpecialInit(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialInit, "BmGame.RGFxMovieUI.SpecialInit");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SaveCurrentMenu;
    /// <summary>
    /// Function: SaveCurrentMenu
    /// </summary>
    public unsafe virtual void SaveCurrentMenu(BmSDK.FString MenuName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveCurrentMenu, "BmGame.RGFxMovieUI.SaveCurrentMenu");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MenuName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGridButtonContext;
    /// <summary>
    /// Function: GetGridButtonContext
    /// </summary>
    public unsafe virtual BmSDK.FString GetGridButtonContext(int ButtonId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGridButtonContext, "BmGame.RGFxMovieUI.GetGridButtonContext");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsCatwomanAvailable;
    /// <summary>
    /// Function: IsCatwomanAvailable
    /// </summary>
    public unsafe virtual bool IsCatwomanAvailable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCatwomanAvailable, "BmGame.RGFxMovieUI.IsCatwomanAvailable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsNewGamePlusStarted;
    /// <summary>
    /// Function: IsNewGamePlusStarted
    /// </summary>
    public unsafe virtual bool IsNewGamePlusStarted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNewGamePlusStarted, "BmGame.RGFxMovieUI.IsNewGamePlusStarted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsNewGamePlusUnlocked;
    /// <summary>
    /// Function: IsNewGamePlusUnlocked
    /// </summary>
    public unsafe virtual bool IsNewGamePlusUnlocked()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNewGamePlusUnlocked, "BmGame.RGFxMovieUI.IsNewGamePlusUnlocked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CountCharacters;
    /// <summary>
    /// Function: CountCharacters
    /// </summary>
    public unsafe virtual int CountCharacters(BmSDK.FString CharacterWanted)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CountCharacters, "BmGame.RGFxMovieUI.CountCharacters");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterWanted, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_XI_RequestGridMenuData;
    /// <summary>
    /// Function: XI_RequestGridMenuData
    /// </summary>
    public unsafe virtual int XI_RequestGridMenuData(BmSDK.FString TargetBasePath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_RequestGridMenuData, "BmGame.RGFxMovieUI.XI_RequestGridMenuData");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_EndRow;
    /// <summary>
    /// Function: EndRow
    /// </summary>
    public unsafe virtual void EndRow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndRow, "BmGame.RGFxMovieUI.EndRow");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddGridItem;
    /// <summary>
    /// Function: AddGridItem
    /// </summary>
    public unsafe virtual void AddGridItem(int InId, BmSDK.FString inItemName, BmSDK.FString inPackageName, BmSDK.FString inDisplayNameRef, bool inPlatformSpecific, bool inLocked, bool inNew = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGridItem, "BmGame.RGFxMovieUI.AddGridItem");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inItemName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inPackageName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inDisplayNameRef, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inPlatformSpecific, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inLocked, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inNew, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StoreButtonId;
    /// <summary>
    /// Function: StoreButtonId
    /// </summary>
    public unsafe virtual void StoreButtonId(int ButtonId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StoreButtonId, "BmGame.RGFxMovieUI.StoreButtonId");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTheButtonName;
    /// <summary>
    /// Function: GetTheButtonName
    /// </summary>
    public unsafe virtual BmSDK.FString GetTheButtonName(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTheButtonName, "BmGame.RGFxMovieUI.GetTheButtonName");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AreIniFilesModified;
    /// <summary>
    /// Function: AreIniFilesModified
    /// </summary>
    public unsafe virtual bool AreIniFilesModified()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreIniFilesModified, "BmGame.RGFxMovieUI.AreIniFilesModified");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_IsBelowMinMemory;
    /// <summary>
    /// Function: IsBelowMinMemory
    /// </summary>
    public unsafe virtual bool IsBelowMinMemory(int TotalPhysMem)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBelowMinMemory, "BmGame.RGFxMovieUI.IsBelowMinMemory");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalPhysMem, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetGPUName;
    /// <summary>
    /// Function: GetGPUName
    /// </summary>
    public unsafe virtual BmSDK.FString GetGPUName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGPUName, "BmGame.RGFxMovieUI.GetGPUName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMinVideoDriverVersion;
    /// <summary>
    /// Function: GetMinVideoDriverVersion
    /// </summary>
    public unsafe virtual BmSDK.FString GetMinVideoDriverVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMinVideoDriverVersion, "BmGame.RGFxMovieUI.GetMinVideoDriverVersion");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetVideoDriverVersion;
    /// <summary>
    /// Function: GetVideoDriverVersion
    /// </summary>
    public unsafe virtual BmSDK.FString GetVideoDriverVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVideoDriverVersion, "BmGame.RGFxMovieUI.GetVideoDriverVersion");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMinMemoryWarning;
    /// <summary>
    /// Function: GetMinMemoryWarning
    /// </summary>
    public unsafe virtual BmSDK.FString GetMinMemoryWarning(int TotalPhysMem)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMinMemoryWarning, "BmGame.RGFxMovieUI.GetMinMemoryWarning");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalPhysMem, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetSystemTotalMemGBs;
    /// <summary>
    /// Function: GetSystemTotalMemGBs
    /// </summary>
    public unsafe virtual float GetSystemTotalMemGBs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSystemTotalMemGBs, "BmGame.RGFxMovieUI.GetSystemTotalMemGBs");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AreGiftCallsActive;
    /// <summary>
    /// Function: AreGiftCallsActive
    /// </summary>
    public unsafe virtual bool AreGiftCallsActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreGiftCallsActive, "BmGame.RGFxMovieUI.AreGiftCallsActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_StartHydraFetchGiftCalls;
    /// <summary>
    /// Function: StartHydraFetchGiftCalls
    /// </summary>
    public unsafe virtual void StartHydraFetchGiftCalls()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartHydraFetchGiftCalls, "BmGame.RGFxMovieUI.StartHydraFetchGiftCalls");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_SendHydraInsufficientRAMPopupEvent;
    /// <summary>
    /// Function: SendHydraInsufficientRAMPopupEvent
    /// </summary>
    public unsafe virtual void SendHydraInsufficientRAMPopupEvent(int SystemTotalMemGBs)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraInsufficientRAMPopupEvent, "BmGame.RGFxMovieUI.SendHydraInsufficientRAMPopupEvent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SystemTotalMemGBs, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SendHydraOutdatedDriverPopupEvent;
    /// <summary>
    /// Function: SendHydraOutdatedDriverPopupEvent
    /// </summary>
    public unsafe virtual void SendHydraOutdatedDriverPopupEvent(BmSDK.FString DriverVersion)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraOutdatedDriverPopupEvent, "BmGame.RGFxMovieUI.SendHydraOutdatedDriverPopupEvent");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DriverVersion, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SendHydraGWPageExposeEvent;
    /// <summary>
    /// Function: SendHydraGWPageExposeEvent
    /// </summary>
    public unsafe virtual void SendHydraGWPageExposeEvent(BmSDK.FString EventType, BmSDK.FString DLCId, BmSDK.FString EventID, int LoadTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraGWPageExposeEvent, "BmGame.RGFxMovieUI.SendHydraGWPageExposeEvent");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DLCId, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadTime, paramsPtr + 48);
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

    private static BmSDK.Function __fn_SendHydraRedeemCodePressedEvent;
    /// <summary>
    /// Function: SendHydraRedeemCodePressedEvent
    /// </summary>
    public unsafe virtual void SendHydraRedeemCodePressedEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraRedeemCodePressedEvent, "BmGame.RGFxMovieUI.SendHydraRedeemCodePressedEvent");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_SendHydraDLCDetailViewEvent;
    /// <summary>
    /// Function: SendHydraDLCDetailViewEvent
    /// </summary>
    public unsafe virtual void SendHydraDLCDetailViewEvent(BmSDK.FString DLCId, BmSDK.FString DLCName, int LoadTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraDLCDetailViewEvent, "BmGame.RGFxMovieUI.SendHydraDLCDetailViewEvent");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DLCId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DLCName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadTime, paramsPtr + 32);
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

    private static BmSDK.Function __fn_SendHydraMOTDClickEvent;
    /// <summary>
    /// Function: SendHydraMOTDClickEvent
    /// </summary>
    public unsafe virtual void SendHydraMOTDClickEvent(BmSDK.FString MOTDId, BmSDK.FString MOTDType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraMOTDClickEvent, "BmGame.RGFxMovieUI.SendHydraMOTDClickEvent");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MOTDId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MOTDType, paramsPtr + 16);
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

    private static BmSDK.Function __fn_ReportHydraGWSessionEnd;
    /// <summary>
    /// Function: ReportHydraGWSessionEnd
    /// </summary>
    public unsafe virtual void ReportHydraGWSessionEnd()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReportHydraGWSessionEnd, "BmGame.RGFxMovieUI.ReportHydraGWSessionEnd");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_ReportHydraGWSessionBegin;
    /// <summary>
    /// Function: ReportHydraGWSessionBegin
    /// </summary>
    public unsafe virtual void ReportHydraGWSessionBegin()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReportHydraGWSessionBegin, "BmGame.RGFxMovieUI.ReportHydraGWSessionBegin");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_GetAppSeconds;
    /// <summary>
    /// Function: GetAppSeconds
    /// </summary>
    public unsafe virtual int GetAppSeconds()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAppSeconds, "BmGame.RGFxMovieUI.GetAppSeconds");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentUTCTime;
    /// <summary>
    /// Function: GetCurrentUTCTime
    /// </summary>
    public unsafe virtual void GetCurrentUTCTime(out int Year, out int Month, out int Day, out int Hour, out int Min, out int Sec, out int MSec)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentUTCTime, "BmGame.RGFxMovieUI.GetCurrentUTCTime");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Year);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Year, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Month);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Month, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Day);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Day, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Hour);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Hour, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Min);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Min, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Sec);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Sec, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MSec);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MSec, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Year = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        Month = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        Day = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        Hour = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
        Min = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        Sec = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
        MSec = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_SetMotionBlur;
    /// <summary>
    /// Function: SetMotionBlur
    /// </summary>
    public unsafe virtual void SetMotionBlur(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMotionBlur, "BmGame.RGFxMovieUI.SetMotionBlur");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetMotionBlur;
    /// <summary>
    /// Function: GetMotionBlur
    /// </summary>
    public unsafe virtual int GetMotionBlur()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMotionBlur, "BmGame.RGFxMovieUI.GetMotionBlur");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDefaultMotionBlur;
    /// <summary>
    /// Function: GetDefaultMotionBlur
    /// </summary>
    public unsafe virtual int GetDefaultMotionBlur()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultMotionBlur, "BmGame.RGFxMovieUI.GetDefaultMotionBlur");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetTextureFiltering;
    /// <summary>
    /// Function: SetTextureFiltering
    /// </summary>
    public unsafe virtual void SetTextureFiltering(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTextureFiltering, "BmGame.RGFxMovieUI.SetTextureFiltering");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetTextureFiltering;
    /// <summary>
    /// Function: GetTextureFiltering
    /// </summary>
    public unsafe virtual int GetTextureFiltering()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTextureFiltering, "BmGame.RGFxMovieUI.GetTextureFiltering");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDefaultTextureFiltering;
    /// <summary>
    /// Function: GetDefaultTextureFiltering
    /// </summary>
    public unsafe virtual int GetDefaultTextureFiltering()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultTextureFiltering, "BmGame.RGFxMovieUI.GetDefaultTextureFiltering");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetFilmGrain;
    /// <summary>
    /// Function: SetFilmGrain
    /// </summary>
    public unsafe virtual void SetFilmGrain(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFilmGrain, "BmGame.RGFxMovieUI.SetFilmGrain");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetFilmGrain;
    /// <summary>
    /// Function: GetFilmGrain
    /// </summary>
    public unsafe virtual int GetFilmGrain()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFilmGrain, "BmGame.RGFxMovieUI.GetFilmGrain");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDefaultFilmGrain;
    /// <summary>
    /// Function: GetDefaultFilmGrain
    /// </summary>
    public unsafe virtual int GetDefaultFilmGrain()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultFilmGrain, "BmGame.RGFxMovieUI.GetDefaultFilmGrain");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetChromaticAberration;
    /// <summary>
    /// Function: SetChromaticAberration
    /// </summary>
    public unsafe virtual void SetChromaticAberration(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetChromaticAberration, "BmGame.RGFxMovieUI.SetChromaticAberration");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetChromaticAberration;
    /// <summary>
    /// Function: GetChromaticAberration
    /// </summary>
    public unsafe virtual int GetChromaticAberration()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChromaticAberration, "BmGame.RGFxMovieUI.GetChromaticAberration");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDefaultChromaticAberration;
    /// <summary>
    /// Function: GetDefaultChromaticAberration
    /// </summary>
    public unsafe virtual int GetDefaultChromaticAberration()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultChromaticAberration, "BmGame.RGFxMovieUI.GetDefaultChromaticAberration");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetMaxFPS;
    /// <summary>
    /// Function: SetMaxFPS
    /// </summary>
    public unsafe virtual void SetMaxFPS(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMaxFPS, "BmGame.RGFxMovieUI.SetMaxFPS");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetMaxFPS;
    /// <summary>
    /// Function: GetMaxFPS
    /// </summary>
    public unsafe virtual int GetMaxFPS()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxFPS, "BmGame.RGFxMovieUI.GetMaxFPS");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDefaultMaxFPS;
    /// <summary>
    /// Function: GetDefaultMaxFPS
    /// </summary>
    public unsafe virtual int GetDefaultMaxFPS()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultMaxFPS, "BmGame.RGFxMovieUI.GetDefaultMaxFPS");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetAdaptiveVsync;
    /// <summary>
    /// Function: SetAdaptiveVsync
    /// </summary>
    public unsafe virtual void SetAdaptiveVsync(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAdaptiveVsync, "BmGame.RGFxMovieUI.SetAdaptiveVsync");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetAdaptiveVsync;
    /// <summary>
    /// Function: GetAdaptiveVsync
    /// </summary>
    public unsafe virtual int GetAdaptiveVsync()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAdaptiveVsync, "BmGame.RGFxMovieUI.GetAdaptiveVsync");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDefaultAdaptiveVsync;
    /// <summary>
    /// Function: GetDefaultAdaptiveVsync
    /// </summary>
    public unsafe virtual int GetDefaultAdaptiveVsync()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultAdaptiveVsync, "BmGame.RGFxMovieUI.GetDefaultAdaptiveVsync");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetVsync;
    /// <summary>
    /// Function: SetVsync
    /// </summary>
    public unsafe virtual void SetVsync(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVsync, "BmGame.RGFxMovieUI.SetVsync");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetVsync;
    /// <summary>
    /// Function: GetVsync
    /// </summary>
    public unsafe virtual int GetVsync()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVsync, "BmGame.RGFxMovieUI.GetVsync");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDefaultVsync;
    /// <summary>
    /// Function: GetDefaultVsync
    /// </summary>
    public unsafe virtual int GetDefaultVsync()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultVsync, "BmGame.RGFxMovieUI.GetDefaultVsync");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetVolumetricLighting;
    /// <summary>
    /// Function: SetVolumetricLighting
    /// </summary>
    public unsafe virtual void SetVolumetricLighting(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVolumetricLighting, "BmGame.RGFxMovieUI.SetVolumetricLighting");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetVolumetricLighting;
    /// <summary>
    /// Function: GetVolumetricLighting
    /// </summary>
    public unsafe virtual int GetVolumetricLighting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVolumetricLighting, "BmGame.RGFxMovieUI.GetVolumetricLighting");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDefaultVolumetricLighting;
    /// <summary>
    /// Function: GetDefaultVolumetricLighting
    /// </summary>
    public unsafe virtual int GetDefaultVolumetricLighting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultVolumetricLighting, "BmGame.RGFxMovieUI.GetDefaultVolumetricLighting");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetRainFX;
    /// <summary>
    /// Function: SetRainFX
    /// </summary>
    public unsafe virtual void SetRainFX(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRainFX, "BmGame.RGFxMovieUI.SetRainFX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetRainFX;
    /// <summary>
    /// Function: GetRainFX
    /// </summary>
    public unsafe virtual int GetRainFX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRainFX, "BmGame.RGFxMovieUI.GetRainFX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDefaultRainFX;
    /// <summary>
    /// Function: GetDefaultRainFX
    /// </summary>
    public unsafe virtual int GetDefaultRainFX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultRainFX, "BmGame.RGFxMovieUI.GetDefaultRainFX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetInteractiveDebris;
    /// <summary>
    /// Function: SetInteractiveDebris
    /// </summary>
    public unsafe virtual void SetInteractiveDebris(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInteractiveDebris, "BmGame.RGFxMovieUI.SetInteractiveDebris");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetInteractiveDebris;
    /// <summary>
    /// Function: GetInteractiveDebris
    /// </summary>
    public unsafe virtual int GetInteractiveDebris()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInteractiveDebris, "BmGame.RGFxMovieUI.GetInteractiveDebris");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDefaultInteractiveDebris;
    /// <summary>
    /// Function: GetDefaultInteractiveDebris
    /// </summary>
    public unsafe virtual int GetDefaultInteractiveDebris()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultInteractiveDebris, "BmGame.RGFxMovieUI.GetDefaultInteractiveDebris");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetInteractiveSmoke;
    /// <summary>
    /// Function: SetInteractiveSmoke
    /// </summary>
    public unsafe virtual void SetInteractiveSmoke(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInteractiveSmoke, "BmGame.RGFxMovieUI.SetInteractiveSmoke");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetInteractiveSmoke;
    /// <summary>
    /// Function: GetInteractiveSmoke
    /// </summary>
    public unsafe virtual int GetInteractiveSmoke()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInteractiveSmoke, "BmGame.RGFxMovieUI.GetInteractiveSmoke");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDefaultInteractiveSmoke;
    /// <summary>
    /// Function: GetDefaultInteractiveSmoke
    /// </summary>
    public unsafe virtual int GetDefaultInteractiveSmoke()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultInteractiveSmoke, "BmGame.RGFxMovieUI.GetDefaultInteractiveSmoke");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetLevelOfDetail;
    /// <summary>
    /// Function: SetLevelOfDetail
    /// </summary>
    public unsafe virtual void SetLevelOfDetail(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLevelOfDetail, "BmGame.RGFxMovieUI.SetLevelOfDetail");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetLevelOfDetail;
    /// <summary>
    /// Function: GetLevelOfDetail
    /// </summary>
    public unsafe virtual int GetLevelOfDetail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLevelOfDetail, "BmGame.RGFxMovieUI.GetLevelOfDetail");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDefaultLevelOfDetail;
    /// <summary>
    /// Function: GetDefaultLevelOfDetail
    /// </summary>
    public unsafe virtual int GetDefaultLevelOfDetail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultLevelOfDetail, "BmGame.RGFxMovieUI.GetDefaultLevelOfDetail");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetShadowQuality;
    /// <summary>
    /// Function: SetShadowQuality
    /// </summary>
    public unsafe virtual void SetShadowQuality(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetShadowQuality, "BmGame.RGFxMovieUI.SetShadowQuality");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetShadowQuality;
    /// <summary>
    /// Function: GetShadowQuality
    /// </summary>
    public unsafe virtual int GetShadowQuality()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetShadowQuality, "BmGame.RGFxMovieUI.GetShadowQuality");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDefaultShadowQuality;
    /// <summary>
    /// Function: GetDefaultShadowQuality
    /// </summary>
    public unsafe virtual int GetDefaultShadowQuality()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultShadowQuality, "BmGame.RGFxMovieUI.GetDefaultShadowQuality");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetTextureResolution;
    /// <summary>
    /// Function: SetTextureResolution
    /// </summary>
    public unsafe virtual void SetTextureResolution(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTextureResolution, "BmGame.RGFxMovieUI.SetTextureResolution");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetTextureResolution;
    /// <summary>
    /// Function: GetTextureResolution
    /// </summary>
    public unsafe virtual int GetTextureResolution()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTextureResolution, "BmGame.RGFxMovieUI.GetTextureResolution");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDefaultTextureResolution;
    /// <summary>
    /// Function: GetDefaultTextureResolution
    /// </summary>
    public unsafe virtual int GetDefaultTextureResolution()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultTextureResolution, "BmGame.RGFxMovieUI.GetDefaultTextureResolution");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetAntialiasing;
    /// <summary>
    /// Function: SetAntialiasing
    /// </summary>
    public unsafe virtual void SetAntialiasing(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAntialiasing, "BmGame.RGFxMovieUI.SetAntialiasing");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetAntialiasing;
    /// <summary>
    /// Function: GetAntialiasing
    /// </summary>
    public unsafe virtual int GetAntialiasing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAntialiasing, "BmGame.RGFxMovieUI.GetAntialiasing");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDefaultAntialiasing;
    /// <summary>
    /// Function: GetDefaultAntialiasing
    /// </summary>
    public unsafe virtual int GetDefaultAntialiasing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultAntialiasing, "BmGame.RGFxMovieUI.GetDefaultAntialiasing");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCurrentResolutionY;
    /// <summary>
    /// Function: SetCurrentResolutionY
    /// </summary>
    public unsafe virtual void SetCurrentResolutionY(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentResolutionY, "BmGame.RGFxMovieUI.SetCurrentResolutionY");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetCurrentResolutionX;
    /// <summary>
    /// Function: SetCurrentResolutionX
    /// </summary>
    public unsafe virtual void SetCurrentResolutionX(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentResolutionX, "BmGame.RGFxMovieUI.SetCurrentResolutionX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetResolution;
    /// <summary>
    /// Function: SetResolution
    /// </summary>
    public unsafe virtual void SetResolution(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetResolution, "BmGame.RGFxMovieUI.SetResolution");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetCurrentResolutionY;
    /// <summary>
    /// Function: GetCurrentResolutionY
    /// </summary>
    public unsafe virtual int GetCurrentResolutionY()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentResolutionY, "BmGame.RGFxMovieUI.GetCurrentResolutionY");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentResolutionX;
    /// <summary>
    /// Function: GetCurrentResolutionX
    /// </summary>
    public unsafe virtual int GetCurrentResolutionX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentResolutionX, "BmGame.RGFxMovieUI.GetCurrentResolutionX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetResolution;
    /// <summary>
    /// Function: GetResolution
    /// </summary>
    public unsafe virtual int GetResolution()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetResolution, "BmGame.RGFxMovieUI.GetResolution");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDefaultResolution;
    /// <summary>
    /// Function: GetDefaultResolution
    /// </summary>
    public unsafe virtual int GetDefaultResolution()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultResolution, "BmGame.RGFxMovieUI.GetDefaultResolution");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetDisplayMode;
    /// <summary>
    /// Function: SetDisplayMode
    /// </summary>
    public unsafe virtual void SetDisplayMode(int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDisplayMode, "BmGame.RGFxMovieUI.SetDisplayMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetDisplayMode;
    /// <summary>
    /// Function: GetDisplayMode
    /// </summary>
    public unsafe virtual int GetDisplayMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayMode, "BmGame.RGFxMovieUI.GetDisplayMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDefaultDisplayMode;
    /// <summary>
    /// Function: GetDefaultDisplayMode
    /// </summary>
    public unsafe virtual int GetDefaultDisplayMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultDisplayMode, "BmGame.RGFxMovieUI.GetDefaultDisplayMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetRestartOptionsChanged;
    /// <summary>
    /// Function: SetRestartOptionsChanged
    /// </summary>
    public unsafe virtual void SetRestartOptionsChanged(bool OptionsChanged)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRestartOptionsChanged, "BmGame.RGFxMovieUI.SetRestartOptionsChanged");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OptionsChanged, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetRestartOptionsChanged;
    /// <summary>
    /// Function: GetRestartOptionsChanged
    /// </summary>
    public unsafe virtual bool GetRestartOptionsChanged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRestartOptionsChanged, "BmGame.RGFxMovieUI.GetRestartOptionsChanged");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_RevertGraphicsOptionsToCopy;
    /// <summary>
    /// Function: RevertGraphicsOptionsToCopy
    /// </summary>
    public unsafe virtual void RevertGraphicsOptionsToCopy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RevertGraphicsOptionsToCopy, "BmGame.RGFxMovieUI.RevertGraphicsOptionsToCopy");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_HaveGraphicsOptionsChangedFromCopy;
    /// <summary>
    /// Function: HaveGraphicsOptionsChangedFromCopy
    /// </summary>
    public unsafe virtual bool HaveGraphicsOptionsChangedFromCopy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HaveGraphicsOptionsChangedFromCopy, "BmGame.RGFxMovieUI.HaveGraphicsOptionsChangedFromCopy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_MakeCopyOfGraphicsOptions;
    /// <summary>
    /// Function: MakeCopyOfGraphicsOptions
    /// </summary>
    public unsafe virtual void MakeCopyOfGraphicsOptions()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeCopyOfGraphicsOptions, "BmGame.RGFxMovieUI.MakeCopyOfGraphicsOptions");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_ClearMenuState;
    /// <summary>
    /// Function: ClearMenuState
    /// </summary>
    public unsafe virtual void ClearMenuState(BmSDK.FString StorageName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearMenuState, "BmGame.RGFxMovieUI.ClearMenuState");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StorageName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RestoreMenuState;
    /// <summary>
    /// Function: RestoreMenuState
    /// </summary>
    public unsafe virtual void RestoreMenuState(BmSDK.FString StorageName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreMenuState, "BmGame.RGFxMovieUI.RestoreMenuState");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StorageName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SaveMenuState;
    /// <summary>
    /// Function: SaveMenuState
    /// </summary>
    public unsafe virtual void SaveMenuState(BmSDK.FString StorageName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveMenuState, "BmGame.RGFxMovieUI.SaveMenuState");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StorageName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearAllMenuStates;
    /// <summary>
    /// Function: ClearAllMenuStates
    /// </summary>
    public unsafe virtual void ClearAllMenuStates()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAllMenuStates, "BmGame.RGFxMovieUI.ClearAllMenuStates");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_CancelLoadControllerImagePackageSF;
    /// <summary>
    /// Function: CancelLoadControllerImagePackageSF
    /// </summary>
    public unsafe virtual void CancelLoadControllerImagePackageSF()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelLoadControllerImagePackageSF, "BmGame.RGFxMovieUI.CancelLoadControllerImagePackageSF");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_LoadControllerImagePackageSF;
    /// <summary>
    /// Function: LoadControllerImagePackageSF
    /// </summary>
    public unsafe virtual void LoadControllerImagePackageSF()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadControllerImagePackageSF, "BmGame.RGFxMovieUI.LoadControllerImagePackageSF");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_ControllerImageLoaded_CB;
    /// <summary>
    /// Function: ControllerImageLoaded_CB
    /// </summary>
    public unsafe virtual void ControllerImageLoaded_CB()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ControllerImageLoaded_CB, "BmGame.RGFxMovieUI.ControllerImageLoaded_CB");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SimpleLoadPackage;
    /// <summary>
    /// Function: SimpleLoadPackage
    /// </summary>
    public unsafe virtual void SimpleLoadPackage(BmSDK.FString SwfRef)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SimpleLoadPackage, "BmGame.RGFxMovieUI.SimpleLoadPackage");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwfRef, paramsPtr + 0);
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
    /// Struct: FMenuState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FMenuState
    {
        /// <summary>
        /// IntProperty: ActiveColumn
        /// </summary>
        public unsafe int ActiveColumn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: ActiveColumnIndexs
        /// </summary>
        public unsafe BmSDK.TArray<int> ActiveColumnIndexs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: UIEVENT_ActionType
    /// </summary>
    public enum UIEVENT_ActionType : byte
    {
        UIEVENT_AT_Forward = 0,
        UIEVENT_AT_Back = 1,
        UIEVENT_AT_MAX = 2,
    }

    /// <summary>
    /// Enum: UIPromptType
    /// </summary>
    public enum UIPromptType : byte
    {
        UIPT_None = 0,
        UIPT_MenuA = 1,
        UIPT_MenuB = 2,
        UIPT_MenuAB = 3,
        UIPT_MenuABTab = 4,
        UIPT_MenuABY = 5,
        UIPT_MainABY = 6,
        UIPT_MainAY = 7,
        UIPT_MenuB_UD = 8,
        UIPT_AccountPicker = 9,
        UIPT_OptionMenuABY = 10,
        UIPT_OptionABY = 11,
        UIPT_OptionBY = 12,
        UIPT_OptionBYRBLB = 13,
        UIPT_OptionAB = 14,
        UIPT_SlotsABDel = 15,
        UIPT_MenuABBackup = 16,
        UIPT_MenuABBackup1 = 17,
        UIPT_MenuABBackup2 = 18,
        UIPT_MenuABBackup3 = 19,
        UIPT_SlotsABDelBackup = 20,
        UIPT_SlotsABDelBackup1 = 21,
        UIPT_SlotsABDelBackup2 = 22,
        UIPT_SlotsABDelBackup3 = 23,
        UIPT_OptionKeyboardABY = 24,
        UIPT_OptionKeyboardABX = 25,
        UIPT_OptionGamePadABXY = 26,
        UIPT_OptionABYApply = 27,
        UIPT_WBID_Overlays = 28,
        UIPT_StorySynopsis = 29,
        UIPT_ChallengeEmpty = 30,
        UIPT_ChallengeEmptyExtremeOff = 31,
        UIPT_ChallengeEmptyExtremeOn = 32,
        UIPT_ChallengeLocked = 33,
        UIPT_ChallengeLockedEmpty = 34,
        UIPT_ChallengeSelect = 35,
        UIPT_ChallengeSelectExtremeOff = 36,
        UIPT_ChallengeSelectExtremeOn = 37,
        UIPT_MenuABTabExtremeOff = 38,
        UIPT_MenuABTabExtremeOn = 39,
        UIPT_LobbyMapLocal = 40,
        UIPT_LobbyMap = 41,
        UIPT_MapInterrogate = 42,
        UIPT_LobbyCharacterLocal = 43,
        UIPT_LobbyCharacter = 44,
        UIPT_LobbyLeaderboard = 45,
        UIPT_MapSelectRanked = 46,
        UIPT_MapSelectCustom = 47,
        UIPT_MapSelectCampaign = 48,
        UIPT_MapCampaignInfo = 49,
        UIPT_MapLeaderboard = 50,
        UIPT_MapLeaderboard_NoY = 51,
        UIPT_IGStore_ABY = 52,
        UIPT_IGStore_ABXY = 53,
        UIPT_Custom = 54,
        UIPT_PhotoMode = 55,
        UIPT_PhotoMenu = 56,
        UIPT_PhotoMenuKBM = 57,
        UIPT_MAX = 58,
    }

    /// <summary>
    /// Enum: MenuItemEnum
    /// </summary>
    public enum MenuItemEnum : byte
    {
        MIE_None = 0,
        MIE_Resume = 1,
        MIE_Restart = 2,
        MIE_OptionsGame = 3,
        MIE_OptionsAudio = 4,
        MIE_OptionsControls = 5,
        MIE_OptionsControlsGamepad = 6,
        MIE_OptionsControlsKeyboard = 7,
        MIE_OptionsCheats = 8,
        MIE_OptionsGraphics = 9,
        MIE_InGameStore = 10,
        MIE_EventCalendar = 11,
        MIE_DurangoHelp = 12,
        MIE_DurangoVideos = 13,
        MIE_EndChallenge = 14,
        MIE_Exit = 15,
        MIE_InvertLook = 16,
        MIE_InvertRotation = 17,
        MIE_InvertGlide = 18,
        MIE_InvertBatarangGlide = 19,
        MIE_CameraAssist = 20,
        MIE_PredatorAwareness = 21,
        MIE_Hints = 22,
        MIE_CombatEasyMode = 23,
        MIE_Vibration = 24,
        MIE_SouthPaw = 25,
        MIE_SixAxis = 26,
        MIE_BattleModeToggle = 27,
        MIE_Brightness = 28,
        MIE_StorageDevice = 29,
        MIE_Subtitles = 30,
        MIE_EnglishVoiceCast = 31,
        MIE_PadSpeaker = 32,
        MIE_SpeechRec = 33,
        MIE_VolumeSFX = 34,
        MIE_VolumeBGM = 35,
        MIE_VolumeDLG = 36,
        MIE_AudioDynRange = 37,
        MIE_DisplayMode = 38,
        MIE_Resolution = 39,
        MIE_Vsync = 40,
        MIE_Antialiasing = 41,
        MIE_GeometryDetail = 42,
        MIE_DynamicShadows = 43,
        MIE_MotionBlur = 44,
        MIE_DepthOfField = 45,
        MIE_Distortion = 46,
        MIE_LensFlare = 47,
        MIE_LightShafts = 48,
        MIE_Reflections = 49,
        MIE_InteractiveSmoke = 50,
        MIE_InteractiveDebris = 51,
        MIE_RainFX = 52,
        MIE_VolumetricLighting = 53,
        MIE_GameWorksLogo = 54,
        MIE_TextureResolution = 55,
        MIE_ShadowQuality = 56,
        MIE_LevelOfDetail = 57,
        MIE_MAXFPS = 58,
        MIE_ChromaticAberration = 59,
        MIE_FilmGrain = 60,
        MIE_TextureFiltering = 61,
        MIE_Difficulty = 62,
        MIE_StartGame = 63,
        MIE_Options3D = 64,
        MIE_OptionsBenchmark = 65,
        MIE_Mode3D = 66,
        MIE_EyeInversion = 67,
        MIE_Intensity = 68,
        MIE_NewGame = 69,
        MIE_Continue = 70,
        MIE_NewGamePlus = 71,
        MIE_ContinuePlus = 72,
        MIE_Challenge = 73,
        MIE_ConceptGallery = 74,
        MIE_Synopsis = 75,
        MIE_ArkhamEpisodes = 76,
        MIE_BatCave = 77,
        MIE_StoryDLC1New = 78,
        MIE_StoryDLC1Continue = 79,
        MIE_StoryDLCMenu = 80,
        MIE_WBID = 81,
        MIE_LIVE = 82,
        MIE_ExitGame = 83,
        MIE_OptionsMenu = 84,
        MIE_ExtrasMenu = 85,
        MIE_Credits = 86,
        MIE_Stats = 87,
        MIE_VSlice = 88,
        MIE_VSliceContinue = 89,
        MIE_SystemStore = 90,
        MIE_FreeRoam = 91,
        MIE_SkinSelect = 92,
        MIE_DeadRetry = 93,
        MIE_DeadQuit = 94,
        MIE_PhotoMode = 95,
        MIE_MouseSensitivity = 96,
        MIE_MouseSmoothing = 97,
        MIE_MAX = 98,
    }

    /// <summary>
    /// StrProperty: GFXFact
    /// </summary>
    public unsafe BmSDK.FString GFXFact
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// StructProperty: MenuIndex
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FMenuState MenuIndex
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FMenuState>(Ptr + 712);

    /// <summary>
    /// StrProperty: MenuPath
    /// </summary>
    public unsafe BmSDK.FString MenuPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// StrProperty: EventNameOnOut
    /// </summary>
    public unsafe BmSDK.FString EventNameOnOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bIsOptionsDefaults
    /// </summary>
    public unsafe bool bIsOptionsDefaults
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bIdByIndexNotName
    /// </summary>
    public unsafe bool bIdByIndexNotName
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bInputBlocked
    /// </summary>
    public unsafe bool bInputBlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bNoMenuSave
    /// </summary>
    public unsafe bool bNoMenuSave
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bInTransition
    /// </summary>
    public unsafe bool bInTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bClosing
    /// </summary>
    public unsafe bool bClosing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bShouldDoApplyCheck
    /// </summary>
    public unsafe bool bShouldDoApplyCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bDoingApply
    /// </summary>
    public unsafe bool bDoingApply
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bShouldCancelChanges
    /// </summary>
    public unsafe bool bShouldCancelChanges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bSkipped1stFocusSFX
    /// </summary>
    public unsafe bool bSkipped1stFocusSFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bShowApplyPrompt
    /// </summary>
    public unsafe bool bShowApplyPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// ByteProperty: LastSetPrompt
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieUI.UIPromptType LastSetPrompt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieUI.UIPromptType>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ArrayProperty: TextFieldFuncs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> TextFieldFuncs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ArrayProperty: TextFieldFuncPaths
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> TextFieldFuncPaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// StrProperty: IconSetPackage
    /// </summary>
    public unsafe BmSDK.FString IconSetPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// StrProperty: NameBaseRef
    /// </summary>
    public unsafe BmSDK.FString NameBaseRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// IntProperty: SavedButtonId
    /// </summary>
    public unsafe int SavedButtonId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// IntProperty: rowCounter
    /// </summary>
    public unsafe int rowCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// IntProperty: rowsUsed
    /// </summary>
    public unsafe int rowsUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// IntProperty: ButtonsX
    /// </summary>
    public unsafe int ButtonsX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// IntProperty: ButtonsY
    /// </summary>
    public unsafe int ButtonsY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ArrayProperty: ButtonIds
    /// </summary>
    public unsafe BmSDK.TArray<int> ButtonIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ArrayProperty: ButtonStates
    /// </summary>
    public unsafe BmSDK.TArray<int> ButtonStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ArrayProperty: ButtonIconNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ButtonIconNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// ArrayProperty: ButtonIconPkgNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ButtonIconPkgNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ArrayProperty: ButtonStringRefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ButtonStringRefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// StrProperty: MovieName
    /// </summary>
    public unsafe BmSDK.FString MovieName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// StrProperty: OnBackCmd
    /// </summary>
    public unsafe BmSDK.FString OnBackCmd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ObjectProperty: ApplyChangesOnExitPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ApplyChangesOnExitPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ObjectProperty: ControllerImageRef
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie ControllerImageRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// MapProperty: VoicePromptMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ VoicePromptMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// ArrayProperty: SwfRefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.SwfMovie> SwfRefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.SwfMovie>>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }
}
