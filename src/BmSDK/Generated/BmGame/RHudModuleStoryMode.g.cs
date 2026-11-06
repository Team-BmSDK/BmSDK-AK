#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleStoryMode<br/>
/// (size = 700)
/// (flags = 18)
/// </summary>
public partial class RHudModuleStoryMode : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleStoryMode", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHudModuleStoryMode.
    /// </summary>
    public static RHudModuleStoryMode DefaultObject => (RHudModuleStoryMode)StaticClass().DefaultObject;

    internal RHudModuleStoryMode() { }

    /// <summary>
    /// Constructs a new RHudModuleStoryMode
    /// </summary>
    public RHudModuleStoryMode(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleStoryMode Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleStoryMode(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleStoryMode>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleStoryMode>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleStoryMode>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleStoryMode>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleStoryMode>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleStoryMode>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleStoryMode>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleStoryMode>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ShowRiddle;
    /// <summary>
    /// Function: ShowRiddle
    /// </summary>
    public unsafe virtual void ShowRiddle(bool bShow, BmSDK.FString RiddleText)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowRiddle, "BmGame.RHudModuleStoryMode.ShowRiddle");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RiddleText, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowCredits;
    /// <summary>
    /// Function: ShowCredits
    /// </summary>
    public unsafe virtual void ShowCredits(float Delay, BmSDK.TArray<BmSDK.FString> CreditList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCredits, "BmGame.RHudModuleStoryMode.ShowCredits");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delay, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CreditList, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowCreditsAS;
    /// <summary>
    /// Function: ShowCreditsAS
    /// </summary>
    public unsafe virtual void ShowCreditsAS(float Delay)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCreditsAS, "BmGame.RHudModuleStoryMode.ShowCreditsAS");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetZoomMode;
    /// <summary>
    /// Function: SetZoomMode
    /// </summary>
    public unsafe virtual void SetZoomMode(bool bEnabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetZoomMode, "BmGame.RHudModuleStoryMode.SetZoomMode");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInfoText;
    /// <summary>
    /// Function: SetInfoText
    /// </summary>
    public unsafe virtual void SetInfoText(BmSDK.FString PadText, BmSDK.FString AltPcText, int Justification = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInfoText, "BmGame.RHudModuleStoryMode.SetInfoText");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PadText, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltPcText, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Justification, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClockTimerExpired;
    /// <summary>
    /// Function: ClockTimerExpired
    /// </summary>
    public unsafe virtual void ClockTimerExpired()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClockTimerExpired, "BmGame.RHudModuleStoryMode.ClockTimerExpired");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OffsetClockTimer;
    /// <summary>
    /// Function: OffsetClockTimer
    /// </summary>
    public unsafe virtual void OffsetClockTimer(int nHundredthsOfSeconds, bool bBonus)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OffsetClockTimer, "BmGame.RHudModuleStoryMode.OffsetClockTimer");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nHundredthsOfSeconds, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBonus, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PauseClockTimer;
    /// <summary>
    /// Function: PauseClockTimer
    /// </summary>
    public unsafe virtual void PauseClockTimer(bool bPause)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PauseClockTimer, "BmGame.RHudModuleStoryMode.PauseClockTimer");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPause, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetClockTimer;
    /// <summary>
    /// Function: SetClockTimer
    /// </summary>
    public unsafe virtual void SetClockTimer(int nHundredthsOfSeconds, bool bVisible, bool bWarning)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClockTimer, "BmGame.RHudModuleStoryMode.SetClockTimer");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nHundredthsOfSeconds, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWarning, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearPromptsPrivate;
    /// <summary>
    /// Function: ClearPromptsPrivate
    /// </summary>
    public unsafe virtual void ClearPromptsPrivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPromptsPrivate, "BmGame.RHudModuleStoryMode.ClearPromptsPrivate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendBatchPromptsPrivate;
    /// <summary>
    /// Function: SendBatchPromptsPrivate
    /// </summary>
    public unsafe virtual void SendBatchPromptsPrivate(BmSDK.FString BatchPromptsString)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendBatchPromptsPrivate, "BmGame.RHudModuleStoryMode.SendBatchPromptsPrivate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatchPromptsString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlushBatchPrompts;
    /// <summary>
    /// Function: FlushBatchPrompts
    /// </summary>
    public unsafe virtual void FlushBatchPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushBatchPrompts, "BmGame.RHudModuleStoryMode.FlushBatchPrompts");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPromptPrivate;
    /// <summary>
    /// Function: SetPromptPrivate
    /// </summary>
    public unsafe virtual void SetPromptPrivate(int Id, bool bMain, BmSDK.FString PadText, BmSDK.FString PCText, BmSDK.FString Label, float Alpha)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPromptPrivate, "BmGame.RHudModuleStoryMode.SetPromptPrivate");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMain, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PadText, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PCText, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMainPrompt;
    /// <summary>
    /// Function: SetMainPrompt
    /// </summary>
    public unsafe virtual void SetMainPrompt(int Id, BmSDK.FString Label, float Alpha = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMainPrompt, "BmGame.RHudModuleStoryMode.SetMainPrompt");
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
    public unsafe virtual void SetPrompt(int Id, BmSDK.FString Label, float Alpha = default, bool bAsMain = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrompt, "BmGame.RHudModuleStoryMode.SetPrompt");
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAsMain, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReLayoutPrompts;
    /// <summary>
    /// Function: ReLayoutPrompts
    /// </summary>
    public unsafe virtual void ReLayoutPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReLayoutPrompts, "BmGame.RHudModuleStoryMode.ReLayoutPrompts");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPrompts, "BmGame.RHudModuleStoryMode.ClearPrompts");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOneShotWarningMessage;
    /// <summary>
    /// Function: SetOneShotWarningMessage
    /// </summary>
    public unsafe virtual void SetOneShotWarningMessage(BmSDK.FString NewWarningMessage, bool HighPriority)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOneShotWarningMessage, "BmGame.RHudModuleStoryMode.SetOneShotWarningMessage");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWarningMessage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HighPriority, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCommandBeaconCharge;
    /// <summary>
    /// Function: SetCommandBeaconCharge
    /// </summary>
    public unsafe virtual void SetCommandBeaconCharge(float Percentage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCommandBeaconCharge, "BmGame.RHudModuleStoryMode.SetCommandBeaconCharge");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Percentage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWarningBar;
    /// <summary>
    /// Function: SetWarningBar
    /// </summary>
    public unsafe virtual void SetWarningBar(float BarValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWarningBar, "BmGame.RHudModuleStoryMode.SetWarningBar");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWarningMessage;
    /// <summary>
    /// Function: SetWarningMessage
    /// </summary>
    public unsafe virtual void SetWarningMessage(BmSDK.FString NewWarningMessage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWarningMessage, "BmGame.RHudModuleStoryMode.SetWarningMessage");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWarningMessage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGenericHudMessage;
    /// <summary>
    /// Function: SetGenericHudMessage
    /// </summary>
    public unsafe virtual void SetGenericHudMessage(BmSDK.FString the_message, bool centre_message)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGenericHudMessage, "BmGame.RHudModuleStoryMode.SetGenericHudMessage");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_message, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(centre_message, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_ThreatLevelOutroComplete;
    /// <summary>
    /// Function: DXI_ThreatLevelOutroComplete
    /// </summary>
    public unsafe virtual void DXI_ThreatLevelOutroComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_ThreatLevelOutroComplete, "BmGame.RHudModuleStoryMode.DXI_ThreatLevelOutroComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetThreatLevel;
    /// <summary>
    /// Function: SetThreatLevel
    /// </summary>
    public unsafe virtual void SetThreatLevel(BmSDK.FString sCityName, BmSDK.FString sThreats, bool bBatmobileAvailable, bool bTutorialMode, int _ThreatLevelNumIcons)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetThreatLevel, "BmGame.RHudModuleStoryMode.SetThreatLevel");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCityName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sThreats, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBatmobileAvailable, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTutorialMode, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ThreatLevelNumIcons, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetThreatLevelPrivate;
    /// <summary>
    /// Function: SetThreatLevelPrivate
    /// </summary>
    public unsafe virtual void SetThreatLevelPrivate(BmSDK.FString sCityName, BmSDK.FString sThreats, bool bBatmobileAvailable, bool bFullIntroAnimation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetThreatLevelPrivate, "BmGame.RHudModuleStoryMode.SetThreatLevelPrivate");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCityName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sThreats, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBatmobileAvailable, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFullIntroAnimation, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThreatLevelSuppressesSurveillance;
    /// <summary>
    /// Function: ThreatLevelSuppressesSurveillance
    /// </summary>
    public unsafe virtual void ThreatLevelSuppressesSurveillance(bool do_suppress)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThreatLevelSuppressesSurveillance, "BmGame.RHudModuleStoryMode.ThreatLevelSuppressesSurveillance");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(do_suppress, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlushThreatLevel;
    /// <summary>
    /// Function: FlushThreatLevel
    /// </summary>
    public unsafe virtual void FlushThreatLevel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushThreatLevel, "BmGame.RHudModuleStoryMode.FlushThreatLevel");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideThreatLevel;
    /// <summary>
    /// Function: HideThreatLevel
    /// </summary>
    public unsafe virtual void HideThreatLevel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideThreatLevel, "BmGame.RHudModuleStoryMode.HideThreatLevel");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_Story_OpenWheelOnCached;
    /// <summary>
    /// Function: DXI_Story_OpenWheelOnCached
    /// </summary>
    public unsafe virtual void DXI_Story_OpenWheelOnCached()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_Story_OpenWheelOnCached, "BmGame.RHudModuleStoryMode.DXI_Story_OpenWheelOnCached");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_Story_OpenWheelOn;
    /// <summary>
    /// Function: DXI_Story_OpenWheelOn
    /// </summary>
    public unsafe virtual void DXI_Story_OpenWheelOn(BmSDK.FString sType, BmSDK.FString sMission)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_Story_OpenWheelOn, "BmGame.RHudModuleStoryMode.DXI_Story_OpenWheelOn");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sMission, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_Story_ShowDiscovery;
    /// <summary>
    /// Function: DXI_Story_ShowDiscovery
    /// </summary>
    public unsafe virtual void DXI_Story_ShowDiscovery(BmSDK.FString IconName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_Story_ShowDiscovery, "BmGame.RHudModuleStoryMode.DXI_Story_ShowDiscovery");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueDiscoveryPrivate;
    /// <summary>
    /// Function: QueueDiscoveryPrivate
    /// </summary>
    public unsafe virtual void QueueDiscoveryPrivate(BmSDK.FString discovery_string)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueDiscoveryPrivate, "BmGame.RHudModuleStoryMode.QueueDiscoveryPrivate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(discovery_string, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueDiscoveryChallengeRevealed;
    /// <summary>
    /// Function: QueueDiscoveryChallengeRevealed
    /// </summary>
    public unsafe virtual void QueueDiscoveryChallengeRevealed(int NumReveals, float SecondsDuration = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueDiscoveryChallengeRevealed, "BmGame.RHudModuleStoryMode.QueueDiscoveryChallengeRevealed");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumReveals, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondsDuration, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueDiscoveryChallenge;
    /// <summary>
    /// Function: QueueDiscoveryChallenge
    /// </summary>
    public unsafe virtual void QueueDiscoveryChallenge(BmSDK.FString ItemName, int nId = default, float SecondsDuration = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueDiscoveryChallenge, "BmGame.RHudModuleStoryMode.QueueDiscoveryChallenge");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondsDuration, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueDiscoverySideStory;
    /// <summary>
    /// Function: QueueDiscoverySideStory
    /// </summary>
    public unsafe virtual void QueueDiscoverySideStory(BmSDK.FString SideStoryName, BmSDK.FString ItemName, float SecondsDuration = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueDiscoverySideStory, "BmGame.RHudModuleStoryMode.QueueDiscoverySideStory");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStoryName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondsDuration, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIntelVisiblePrivate;
    /// <summary>
    /// Function: SetIntelVisiblePrivate
    /// </summary>
    public unsafe virtual void SetIntelVisiblePrivate(bool Visible, bool show_quietly)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIntelVisiblePrivate, "BmGame.RHudModuleStoryMode.SetIntelVisiblePrivate");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Visible, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show_quietly, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateIntelVisible;
    /// <summary>
    /// Function: UpdateIntelVisible
    /// </summary>
    public unsafe virtual void UpdateIntelVisible(bool quietly)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateIntelVisible, "BmGame.RHudModuleStoryMode.UpdateIntelVisible");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(quietly, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIntelSystemVisuallySuppressed;
    /// <summary>
    /// Function: SetIntelSystemVisuallySuppressed
    /// </summary>
    public unsafe virtual void SetIntelSystemVisuallySuppressed(bool suppressed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIntelSystemVisuallySuppressed, "BmGame.RHudModuleStoryMode.SetIntelSystemVisuallySuppressed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(suppressed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateIntelRequestStatus;
    /// <summary>
    /// Function: UpdateIntelRequestStatus
    /// </summary>
    public unsafe virtual void UpdateIntelRequestStatus()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateIntelRequestStatus, "BmGame.RHudModuleStoryMode.UpdateIntelRequestStatus");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffIntel;
    /// <summary>
    /// Function: TurnOffIntel
    /// </summary>
    public unsafe virtual void TurnOffIntel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffIntel, "BmGame.RHudModuleStoryMode.TurnOffIntel");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetIntelRequestCountdown;
    /// <summary>
    /// Function: ResetIntelRequestCountdown
    /// </summary>
    public unsafe virtual void ResetIntelRequestCountdown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetIntelRequestCountdown, "BmGame.RHudModuleStoryMode.ResetIntelRequestCountdown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIntelSystemSuppressed;
    /// <summary>
    /// Function: SetIntelSystemSuppressed
    /// </summary>
    public unsafe virtual void SetIntelSystemSuppressed(bool suppressed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIntelSystemSuppressed, "BmGame.RHudModuleStoryMode.SetIntelSystemSuppressed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(suppressed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetApcIntelVisible;
    /// <summary>
    /// Function: SetApcIntelVisible
    /// </summary>
    public unsafe virtual void SetApcIntelVisible(bool Visible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetApcIntelVisible, "BmGame.RHudModuleStoryMode.SetApcIntelVisible");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Visible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPenguinIntelVisible;
    /// <summary>
    /// Function: SetPenguinIntelVisible
    /// </summary>
    public unsafe virtual void SetPenguinIntelVisible(bool Visible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPenguinIntelVisible, "BmGame.RHudModuleStoryMode.SetPenguinIntelVisible");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Visible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIntelVisible;
    /// <summary>
    /// Function: SetIntelVisible
    /// </summary>
    public unsafe virtual void SetIntelVisible(bool Visible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIntelVisible, "BmGame.RHudModuleStoryMode.SetIntelVisible");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Visible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetExclusivePromptsMode;
    /// <summary>
    /// Function: SetExclusivePromptsMode
    /// </summary>
    public unsafe virtual void SetExclusivePromptsMode(bool exclusive_prompts)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetExclusivePromptsMode, "BmGame.RHudModuleStoryMode.SetExclusivePromptsMode");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(exclusive_prompts, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLapCount;
    /// <summary>
    /// Function: SetLapCount
    /// </summary>
    public unsafe virtual void SetLapCount(int lap, int maxLap)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLapCount, "BmGame.RHudModuleStoryMode.SetLapCount");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(lap, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(maxLap, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleLapCount;
    /// <summary>
    /// Function: ToggleLapCount
    /// </summary>
    public unsafe virtual void ToggleLapCount(bool _lapCountOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleLapCount, "BmGame.RHudModuleStoryMode.ToggleLapCount");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_lapCountOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetonateExplosiveGel;
    /// <summary>
    /// Function: DetonateExplosiveGel
    /// </summary>
    public unsafe virtual void DetonateExplosiveGel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetonateExplosiveGel, "BmGame.RHudModuleStoryMode.DetonateExplosiveGel");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowExplosiveGelCount;
    /// <summary>
    /// Function: ShowExplosiveGelCount
    /// </summary>
    public unsafe virtual void ShowExplosiveGelCount(int NumVictims, bool WillKnockdown)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowExplosiveGelCount, "BmGame.RHudModuleStoryMode.ShowExplosiveGelCount");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumVictims, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WillKnockdown, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.RHudModuleStoryMode.Close");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitialiseFlash;
    /// <summary>
    /// Function: InitialiseFlash
    /// </summary>
    public unsafe override void InitialiseFlash()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseFlash, "BmGame.RHudModuleStoryMode.InitialiseFlash");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RHudModuleStoryMode.Init");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// StrProperty: CachedFunction_ClearPrompts
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_ClearPrompts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_BatchAddPrompts
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_BatchAddPrompts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetClockTimer
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetClockTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_PauseClockTimer
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_PauseClockTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_OffsetClockTimer
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_OffsetClockTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_ClockTimerExpired
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_ClockTimerExpired
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetInfoText
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetInfoText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetZoomMode
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetZoomMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_ShowRiddle
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_ShowRiddle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetWarningMessage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetWarningMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetWarningBar
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetWarningBar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetCommandBeaconCharge
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetCommandBeaconCharge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetLapCount
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetLapCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_ToggleLapCount
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_ToggleLapCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetIntelVisible
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetIntelVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_QueueDiscovery
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_QueueDiscovery
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetThreatLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetThreatLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_HideThreatLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_HideThreatLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// StrProperty: Cached_ShowExplosiveGelCount
    /// </summary>
    public unsafe BmSDK.FString Cached_ShowExplosiveGelCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetGenericHudMessage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetGenericHudMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// IntProperty: ExplosiveGelCount
    /// </summary>
    public unsafe int ExplosiveGelCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// StrProperty: CurrentWarningMessage
    /// </summary>
    public unsafe BmSDK.FString CurrentWarningMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// FloatProperty: CurrentBarValue
    /// </summary>
    public unsafe float CurrentBarValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// FloatProperty: CurrentPercentage
    /// </summary>
    public unsafe float CurrentPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// IntProperty: CurrentLap
    /// </summary>
    public unsafe int CurrentLap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: lapCountOn
    /// </summary>
    public unsafe bool lapCountOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: ThreatLevelDirty
    /// </summary>
    public unsafe bool ThreatLevelDirty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: RequestHideThreatLevel
    /// </summary>
    public unsafe bool RequestHideThreatLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: CachedThreat_bBatmobileAvailable
    /// </summary>
    public unsafe bool CachedThreat_bBatmobileAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: CachedThreat_bTutorialMode
    /// </summary>
    public unsafe bool CachedThreat_bTutorialMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: ThreatLevelVisible
    /// </summary>
    public unsafe bool ThreatLevelVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: SurveillanceSuppressedByThreatLevel
    /// </summary>
    public unsafe bool SurveillanceSuppressedByThreatLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: IntelSystemSuppressed
    /// </summary>
    public unsafe bool IntelSystemSuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: IntelSystemVisuallySuppressed
    /// </summary>
    public unsafe bool IntelSystemVisuallySuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: StandardIntelAvailable
    /// </summary>
    public unsafe bool StandardIntelAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: PenguinIntelAvailable
    /// </summary>
    public unsafe bool PenguinIntelAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: ApcIntelAvailable
    /// </summary>
    public unsafe bool ApcIntelAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: HudIntelVisible
    /// </summary>
    public unsafe bool HudIntelVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: IntelRequested
    /// </summary>
    public unsafe bool IntelRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: bThreatLevelActuallyOnscreen
    /// </summary>
    public unsafe bool bThreatLevelActuallyOnscreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: bExclusivePromptsMode
    /// </summary>
    public unsafe bool bExclusivePromptsMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: bIsZoomed
    /// </summary>
    public unsafe bool bIsZoomed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: PromptsMightBeDirty
    /// </summary>
    public unsafe bool PromptsMightBeDirty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// StrProperty: CachedThreat_sCityName
    /// </summary>
    public unsafe BmSDK.FString CachedThreat_sCityName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// StrProperty: CachedThreat_sThreats
    /// </summary>
    public unsafe BmSDK.FString CachedThreat_sThreats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// IntProperty: ThreatLevelNumIcons
    /// </summary>
    public unsafe int ThreatLevelNumIcons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: IntelRequestCountdown
    /// </summary>
    public unsafe float IntelRequestCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// StrProperty: CurrentBatchPromptsString
    /// </summary>
    public unsafe BmSDK.FString CurrentBatchPromptsString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// StrProperty: PendingBatchPromptsString
    /// </summary>
    public unsafe BmSDK.FString PendingBatchPromptsString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// StrProperty: GenericHudMessage
    /// </summary>
    public unsafe BmSDK.FString GenericHudMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// StrProperty: LastThingToSetPrompts
    /// </summary>
    public unsafe BmSDK.FString LastThingToSetPrompts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }
}
