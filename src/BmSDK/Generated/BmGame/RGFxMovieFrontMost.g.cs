#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieFrontMost<br/>
/// (size = 788)
/// (flags = 134217878)
/// </summary>
public partial class RGFxMovieFrontMost : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieFrontMost", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieFrontMost.
    /// </summary>
    public static RGFxMovieFrontMost DefaultObject => (RGFxMovieFrontMost)StaticClass().DefaultObject;

    internal RGFxMovieFrontMost() { }

    /// <summary>
    /// Constructs a new RGFxMovieFrontMost
    /// </summary>
    public RGFxMovieFrontMost(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieFrontMost Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieFrontMost(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieFrontMost>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieFrontMost>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieFrontMost>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieFrontMost>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieFrontMost>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieFrontMost>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieFrontMost>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieFrontMost>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_XI_GetKeyboardSkipPrompt;
    /// <summary>
    /// Function: XI_GetKeyboardSkipPrompt
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetKeyboardSkipPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetKeyboardSkipPrompt, "BmGame.RGFxMovieFrontMost.XI_GetKeyboardSkipPrompt");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_PromptClicked;
    /// <summary>
    /// Function: XI_PromptClicked
    /// </summary>
    public unsafe virtual void XI_PromptClicked(int PromptId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_PromptClicked, "BmGame.RGFxMovieFrontMost.XI_PromptClicked");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PromptId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMainPrompt;
    /// <summary>
    /// Function: SetMainPrompt
    /// </summary>
    public unsafe virtual void SetMainPrompt(int Id, BmSDK.FString Label, float Alpha = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMainPrompt, "BmGame.RGFxMovieFrontMost.SetMainPrompt");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPrompt;
    /// <summary>
    /// Function: SetPrompt
    /// </summary>
    public unsafe virtual void SetPrompt(int Id, BmSDK.FString Label, float Alpha = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrompt, "BmGame.RGFxMovieFrontMost.SetPrompt");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__SetPrompt;
    /// <summary>
    /// Function: _SetPrompt
    /// </summary>
    public unsafe virtual void _SetPrompt(int Id, bool bMain, BmSDK.FString PadText, BmSDK.FString PCText, BmSDK.FString Label, float Alpha)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__SetPrompt, "BmGame.RGFxMovieFrontMost._SetPrompt");
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMain, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PadText, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PCText, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReLayoutPrompts;
    /// <summary>
    /// Function: ReLayoutPrompts
    /// </summary>
    public unsafe virtual void ReLayoutPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReLayoutPrompts, "BmGame.RGFxMovieFrontMost.ReLayoutPrompts");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearPrompts;
    /// <summary>
    /// Function: ClearPrompts
    /// </summary>
    public unsafe virtual void ClearPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPrompts, "BmGame.RGFxMovieFrontMost.ClearPrompts");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SavingIconAtOneSecondMark;
    /// <summary>
    /// Function: XI_SavingIconAtOneSecondMark
    /// </summary>
    public unsafe virtual void XI_SavingIconAtOneSecondMark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SavingIconAtOneSecondMark, "BmGame.RGFxMovieFrontMost.XI_SavingIconAtOneSecondMark");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_TriggerSavingError;
    /// <summary>
    /// Function: XI_TriggerSavingError
    /// </summary>
    public unsafe virtual void XI_TriggerSavingError()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_TriggerSavingError, "BmGame.RGFxMovieFrontMost.XI_TriggerSavingError");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_IsSaving;
    /// <summary>
    /// Function: XI_IsSaving
    /// </summary>
    public unsafe virtual int XI_IsSaving()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_IsSaving, "BmGame.RGFxMovieFrontMost.XI_IsSaving");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_ShowSavingIconFlashFrontend;
    /// <summary>
    /// Function: ShowSavingIconFlashFrontend
    /// </summary>
    public unsafe virtual void ShowSavingIconFlashFrontend()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowSavingIconFlashFrontend, "BmGame.RGFxMovieFrontMost.ShowSavingIconFlashFrontend");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowSavingIconFlashInGame;
    /// <summary>
    /// Function: ShowSavingIconFlashInGame
    /// </summary>
    public unsafe virtual void ShowSavingIconFlashInGame()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowSavingIconFlashInGame, "BmGame.RGFxMovieFrontMost.ShowSavingIconFlashInGame");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSavingIconInGameAlpha;
    /// <summary>
    /// Function: SetSavingIconInGameAlpha
    /// </summary>
    public unsafe virtual void SetSavingIconInGameAlpha(float fAlpha)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSavingIconInGameAlpha, "BmGame.RGFxMovieFrontMost.SetSavingIconInGameAlpha");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fAlpha, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowSavingIcon;
    /// <summary>
    /// Function: ShowSavingIcon
    /// </summary>
    public unsafe virtual void ShowSavingIcon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowSavingIcon, "BmGame.RGFxMovieFrontMost.ShowSavingIcon");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowLoadingPrompt;
    /// <summary>
    /// Function: ShowLoadingPrompt
    /// </summary>
    public unsafe virtual void ShowLoadingPrompt(bool bShow, bool bForceOff = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowLoadingPrompt, "BmGame.RGFxMovieFrontMost.ShowLoadingPrompt");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowSkipPrompt;
    /// <summary>
    /// Function: ShowSkipPrompt
    /// </summary>
    public unsafe virtual void ShowSkipPrompt(bool bShow, bool bForceOff = default, bool bAButtonToSkip = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowSkipPrompt, "BmGame.RGFxMovieFrontMost.ShowSkipPrompt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAButtonToSkip, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SideScreenFadeIn;
    /// <summary>
    /// Function: SideScreenFadeIn
    /// </summary>
    public unsafe virtual void SideScreenFadeIn(float OverSeconds)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SideScreenFadeIn, "BmGame.RGFxMovieFrontMost.SideScreenFadeIn");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverSeconds, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SideScreenFadeOut;
    /// <summary>
    /// Function: SideScreenFadeOut
    /// </summary>
    public unsafe virtual void SideScreenFadeOut(float OverSeconds)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SideScreenFadeOut, "BmGame.RGFxMovieFrontMost.SideScreenFadeOut");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverSeconds, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSimpleFade;
    /// <summary>
    /// Function: SetSimpleFade
    /// </summary>
    public unsafe virtual void SetSimpleFade(float Opacity, int RGB = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSimpleFade, "BmGame.RGFxMovieFrontMost.SetSimpleFade");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Opacity, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RGB, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeInRGB;
    /// <summary>
    /// Function: FadeInRGB
    /// </summary>
    public unsafe virtual void FadeInRGB(float OverSecs, int RGB = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeInRGB, "BmGame.RGFxMovieFrontMost.FadeInRGB");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverSecs, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RGB, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeOutRGB;
    /// <summary>
    /// Function: FadeOutRGB
    /// </summary>
    public unsafe virtual void FadeOutRGB(float OverSecs, int RGB = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeOutRGB, "BmGame.RGFxMovieFrontMost.FadeOutRGB");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverSecs, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RGB, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeAnimatedDone_CB;
    /// <summary>
    /// Function: FadeAnimatedDone_CB
    /// </summary>
    public unsafe virtual void FadeAnimatedDone_CB(bool bBlackscreen)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeAnimatedDone_CB, "BmGame.RGFxMovieFrontMost.FadeAnimatedDone_CB");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBlackscreen, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeCallbackMe;
    /// <summary>
    /// Function: FadeCallbackMe
    /// </summary>
    public unsafe virtual void FadeCallbackMe(BmSDK.BmGame.RGFxMovie CallMeBack)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeCallbackMe, "BmGame.RGFxMovieFrontMost.FadeCallbackMe");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CallMeBack, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerFadeIn;
    /// <summary>
    /// Function: TriggerFadeIn
    /// </summary>
    public unsafe virtual void TriggerFadeIn(BmSDK.BmGame.RGFxMovieFrontMost.AnimatedFadeType FadeType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerFadeIn, "BmGame.RGFxMovieFrontMost.TriggerFadeIn");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FadeType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerFadeOut;
    /// <summary>
    /// Function: TriggerFadeOut
    /// </summary>
    public unsafe virtual void TriggerFadeOut(BmSDK.BmGame.RGFxMovieFrontMost.AnimatedFadeType FadeType, bool bInstantly, bool fadesAudio = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerFadeOut, "BmGame.RGFxMovieFrontMost.TriggerFadeOut");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FadeType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstantly, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fadesAudio, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSubtitles;
    /// <summary>
    /// Function: SetSubtitles
    /// </summary>
    public unsafe virtual void SetSubtitles(BmSDK.FString TheText, BmSDK.BmGame.RGFxMovieFrontMost.SubtitleJustify Justification)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSubtitles, "BmGame.RGFxMovieFrontMost.SetSubtitles");
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheText, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Justification, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSubtitles_set;
    /// <summary>
    /// Function: SetSubtitles_set
    /// </summary>
    public unsafe virtual void SetSubtitles_set(BmSDK.FString ThePadText, BmSDK.FString ThePCText, int Justification)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSubtitles_set, "BmGame.RGFxMovieFrontMost.SetSubtitles_set");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePadText, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePCText, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Justification, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOverFadeText;
    /// <summary>
    /// Function: SetOverFadeText
    /// </summary>
    public unsafe virtual void SetOverFadeText(BmSDK.FString TextToSet, float DurationMilliseconds)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOverFadeText, "BmGame.RGFxMovieFrontMost.SetOverFadeText");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextToSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DurationMilliseconds, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOverFadeText_set;
    /// <summary>
    /// Function: SetOverFadeText_set
    /// </summary>
    public unsafe virtual void SetOverFadeText_set(BmSDK.FString PadStr, BmSDK.FString KeyStr, float DurationMilliseconds)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOverFadeText_set, "BmGame.RGFxMovieFrontMost.SetOverFadeText_set");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PadStr, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyStr, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DurationMilliseconds, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetToolTip;
    /// <summary>
    /// Function: SetToolTip
    /// </summary>
    public unsafe virtual void SetToolTip(BmSDK.FString TheText = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetToolTip, "BmGame.RGFxMovieFrontMost.SetToolTip");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheText, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsFadeInProgress;
    /// <summary>
    /// Function: IsFadeInProgress
    /// </summary>
    public unsafe virtual bool IsFadeInProgress()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFadeInProgress, "BmGame.RGFxMovieFrontMost.IsFadeInProgress");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FadeInMC;
    /// <summary>
    /// Function: FadeInMC
    /// </summary>
    public unsafe virtual void FadeInMC(BmSDK.FString FadeName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeInMC, "BmGame.RGFxMovieFrontMost.FadeInMC");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FadeName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeOutMC;
    /// <summary>
    /// Function: FadeOutMC
    /// </summary>
    public unsafe virtual void FadeOutMC(BmSDK.FString FadeName, bool bInstantly)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeOutMC, "BmGame.RGFxMovieFrontMost.FadeOutMC");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FadeName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstantly, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowSafeFrame;
    /// <summary>
    /// Function: ShowSafeFrame
    /// </summary>
    public unsafe virtual void ShowSafeFrame(bool bShow)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowSafeFrame, "BmGame.RGFxMovieFrontMost.ShowSafeFrame");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAspectRatioChanged;
    /// <summary>
    /// Function: OnAspectRatioChanged
    /// </summary>
    public unsafe override void OnAspectRatioChanged(float aspect_ratio)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAspectRatioChanged, "BmGame.RGFxMovieFrontMost.OnAspectRatioChanged");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aspect_ratio, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_ShowVRamBar;
    /// <summary>
    /// Function: UC_ShowVRamBar
    /// </summary>
    public unsafe virtual void UC_ShowVRamBar(bool ShowVRamBar)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_ShowVRamBar, "BmGame.RGFxMovieFrontMost.UC_ShowVRamBar");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowVRamBar, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetVRamTooltip;
    /// <summary>
    /// Function: UC_SetVRamTooltip
    /// </summary>
    public unsafe virtual void UC_SetVRamTooltip(BmSDK.FString VRamTooltip)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetVRamTooltip, "BmGame.RGFxMovieFrontMost.UC_SetVRamTooltip");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VRamTooltip, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetVRamColor;
    /// <summary>
    /// Function: UC_SetVRamColor
    /// </summary>
    public unsafe virtual void UC_SetVRamColor(int VRamColor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetVRamColor, "BmGame.RGFxMovieFrontMost.UC_SetVRamColor");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VRamColor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetVRamUsed;
    /// <summary>
    /// Function: UC_SetVRamUsed
    /// </summary>
    public unsafe virtual void UC_SetVRamUsed(BmSDK.FString UsageValues, float Percentage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetVRamUsed, "BmGame.RGFxMovieFrontMost.UC_SetVRamUsed");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UsageValues, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Percentage, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateVRamBar;
    /// <summary>
    /// Function: UpdateVRamBar
    /// </summary>
    public unsafe virtual void UpdateVRamBar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateVRamBar, "BmGame.RGFxMovieFrontMost.UpdateVRamBar");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetupVRamBar;
    /// <summary>
    /// Function: UC_SetupVRamBar
    /// </summary>
    public unsafe virtual void UC_SetupVRamBar(BmSDK.FString Title, BmSDK.FString GraphicsCard, float AspectRatio)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetupVRamBar, "BmGame.RGFxMovieFrontMost.UC_SetupVRamBar");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GraphicsCard, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AspectRatio, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SetupVRamBar;
    /// <summary>
    /// Function: XI_SetupVRamBar
    /// </summary>
    public unsafe virtual void XI_SetupVRamBar(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetupVRamBar, "BmGame.RGFxMovieFrontMost.XI_SetupVRamBar");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovieFrontMost.Init");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAspectRatio;
    /// <summary>
    /// Function: GetAspectRatio
    /// </summary>
    public unsafe virtual float GetAspectRatio()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAspectRatio, "BmGame.RGFxMovieFrontMost.GetAspectRatio");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_GetVideoCardName;
    /// <summary>
    /// Function: GetVideoCardName
    /// </summary>
    public unsafe virtual BmSDK.FString GetVideoCardName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVideoCardName, "BmGame.RGFxMovieFrontMost.GetVideoCardName");
        byte* paramsPtr = stackalloc byte[16];
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

    private static BmSDK.Function __fn_GetTotalAvailableVRam;
    /// <summary>
    /// Function: GetTotalAvailableVRam
    /// </summary>
    public unsafe virtual float GetTotalAvailableVRam()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTotalAvailableVRam, "BmGame.RGFxMovieFrontMost.GetTotalAvailableVRam");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_GetCurrentVRamUsage;
    /// <summary>
    /// Function: GetCurrentVRamUsage
    /// </summary>
    public unsafe virtual float GetCurrentVRamUsage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentVRamUsage, "BmGame.RGFxMovieFrontMost.GetCurrentVRamUsage");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_ShouldFade;
    /// <summary>
    /// Function: ShouldFade
    /// </summary>
    public unsafe virtual bool ShouldFade()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldFade, "BmGame.RGFxMovieFrontMost.ShouldFade");
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

    /// <summary>
    /// Struct: FPromptRecord
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public partial record struct FPromptRecord
    {
        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bMain
        /// </summary>
        public unsafe bool bMain
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: PadText
        /// </summary>
        public unsafe BmSDK.FString PadText
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StrProperty: PCText
        /// </summary>
        public unsafe BmSDK.FString PCText
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StrProperty: Label
        /// </summary>
        public unsafe BmSDK.FString Label
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: Alpha
        /// </summary>
        public unsafe float Alpha
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Enum: SubtitleJustify
    /// </summary>
    public enum SubtitleJustify : byte
    {
        SUBS_LeftAlign = 0,
        SUBS_Centered = 1,
        SUBS_RightAlign = 2,
        SUBS_Justify = 3,
        SUBS_MAX = 4,
    }

    /// <summary>
    /// ArrayProperty: FadeNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> FadeNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ArrayProperty: CurrentPrompts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGFxMovieFrontMost.FPromptRecord> CurrentPrompts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGFxMovieFrontMost.FPromptRecord>>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: OnFadedMovieToCallback
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovie OnFadedMovieToCallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovie>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ByteProperty: JustifyLast
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieFrontMost.SubtitleJustify JustifyLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieFrontMost.SubtitleJustify>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// StrProperty: SubtitlesLast
    /// </summary>
    public unsafe BmSDK.FString SubtitlesLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// BoolProperty: bSaveIconActive
    /// </summary>
    public unsafe bool bSaveIconActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 756); }
    }

    /// <summary>
    /// BoolProperty: bFadeInProgress
    /// </summary>
    public unsafe bool bFadeInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 756); }
    }

    /// <summary>
    /// FloatProperty: FADE_OUT_TIME
    /// </summary>
    public unsafe float FADE_OUT_TIME
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: FADE_IN_TIME
    /// </summary>
    public unsafe float FADE_IN_TIME
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// StrProperty: VRamBarPath
    /// </summary>
    public unsafe BmSDK.FString VRamBarPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// FloatProperty: TotalAvailableVRam
    /// </summary>
    public unsafe float TotalAvailableVRam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// Enum: AnimatedFadeType
    /// </summary>
    public enum AnimatedFadeType : byte
    {
        AF_Fade_Bats = 0,
        AF_Fade_Riddler = 1,
        AF_Fade_MAX = 2,
    }
}
