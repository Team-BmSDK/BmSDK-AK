#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxGameViewportClient<br/>
/// (size = 484)
/// (flags = 134217918)
/// </summary>
public partial class RGFxGameViewportClient : BmSDK.Engine.GameViewportClient, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxGameViewportClient", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxGameViewportClient.
    /// </summary>
    public static RGFxGameViewportClient DefaultObject => (RGFxGameViewportClient)StaticClass().DefaultObject;

    internal RGFxGameViewportClient() { }

    /// <summary>
    /// Constructs a new RGFxGameViewportClient
    /// </summary>
    public RGFxGameViewportClient(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxGameViewportClient Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxGameViewportClient(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxGameViewportClient>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxGameViewportClient>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxGameViewportClient>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxGameViewportClient>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxGameViewportClient>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxGameViewportClient>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxGameViewportClient>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxGameViewportClient>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetProgressMessage;
    /// <summary>
    /// Function: SetProgressMessage
    /// </summary>
    public unsafe override void SetProgressMessage(BmSDK.Engine.PlayerController.EProgressMessageType MessageType, BmSDK.FString Message, BmSDK.FString Title = default, bool bIgnoreFutureNetworkMessages = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetProgressMessage, "BmGame.RGFxGameViewportClient.SetProgressMessage");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreFutureNetworkMessages, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClosePopups;
    /// <summary>
    /// Function: ClosePopups
    /// </summary>
    public unsafe virtual void ClosePopups()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClosePopups, "BmGame.RGFxGameViewportClient.ClosePopups");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveErrorPopup;
    /// <summary>
    /// Function: RemoveErrorPopup
    /// </summary>
    public unsafe virtual void RemoveErrorPopup(BmSDK.BmGame.RGFxMoviePopupRequester MovieRef)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveErrorPopup, "BmGame.RGFxGameViewportClient.RemoveErrorPopup");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovieRef, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenPopUpError;
    /// <summary>
    /// Function: OpenPopUpError
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGFxMoviePopupRequester OpenPopUpError(BmSDK.BmGame.RPlayerController RPC, BmSDK.BmGame.RGFxMoviePopupRequester.GPopup_Type TheType, BmSDK.BmGame.RGFxMovie RespondTo, BmSDK.FString Message, BmSDK.TArray<BmSDK.FString> Prompts, int DefaultSelected = default, bool bAllowBack = default, BmSDK.GFxUI.SwfMovie iMovie = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenPopUpError, "BmGame.RGFxGameViewportClient.OpenPopUpError");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RespondTo, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prompts, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultSelected, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowBack, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iMovie, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(paramsPtr + 68);
    }

    private static BmSDK.Function __fn_DrawTransition;
    /// <summary>
    /// Function: DrawTransition
    /// </summary>
    public unsafe override void DrawTransition(BmSDK.Engine.Canvas Canvas)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTransition, "BmGame.RGFxGameViewportClient.DrawTransition");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowSessionInfo;
    /// <summary>
    /// Function: ShowSessionInfo
    /// </summary>
    public unsafe virtual void ShowSessionInfo(BmSDK.Engine.Canvas C)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowSessionInfo, "BmGame.RGFxGameViewportClient.ShowSessionInfo");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleSessionInfoDisplay;
    /// <summary>
    /// Function: ToggleSessionInfoDisplay
    /// </summary>
    public unsafe virtual void ToggleSessionInfoDisplay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleSessionInfoDisplay, "BmGame.RGFxGameViewportClient.ToggleSessionInfoDisplay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init(out BmSDK.FString OutError)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxGameViewportClient.Init");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutError = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetSubtitleMinY;
    /// <summary>
    /// Function: GetSubtitleMinY
    /// </summary>
    public unsafe virtual float GetSubtitleMinY()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSubtitleMinY, "BmGame.RGFxGameViewportClient.GetSubtitleMinY");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayGammaReferenceBrightness;
    /// <summary>
    /// Function: GetDisplayGammaReferenceBrightness
    /// </summary>
    public unsafe virtual float GetDisplayGammaReferenceBrightness()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayGammaReferenceBrightness, "BmGame.RGFxGameViewportClient.GetDisplayGammaReferenceBrightness");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InstallOurGFxHandlers;
    /// <summary>
    /// Function: InstallOurGFxHandlers
    /// </summary>
    public unsafe virtual bool InstallOurGFxHandlers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstallOurGFxHandlers, "BmGame.RGFxGameViewportClient.InstallOurGFxHandlers");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetupGameFonts;
    /// <summary>
    /// Function: SetupGameFonts
    /// </summary>
    public unsafe virtual void SetupGameFonts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupGameFonts, "BmGame.RGFxGameViewportClient.SetupGameFonts");
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
    /// BoolProperty: bShowCalibrationImage
    /// </summary>
    public unsafe bool bShowCalibrationImage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 460) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 460); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 460); }
    }

    /// <summary>
    /// BoolProperty: bShowSessionDebug
    /// </summary>
    public unsafe bool bShowSessionDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 460) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 460); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 460); }
    }

    /// <summary>
    /// ArrayProperty: ErrorPopup
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGFxMoviePopupRequester> ErrorPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGFxMoviePopupRequester>>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// FloatProperty: SubtitleYLast
    /// </summary>
    public unsafe float SubtitleYLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }
}
