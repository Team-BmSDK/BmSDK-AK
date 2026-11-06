#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RChallengeModeStartPoint<br/>
/// (size = 1556)
/// (flags = 10486290)
/// </summary>
public partial class RChallengeModeStartPoint : BmSDK.BmGame.RChallengeModeStartPointBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RChallengeModeStartPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RChallengeModeStartPoint.
    /// </summary>
    public static RChallengeModeStartPoint DefaultObject => (RChallengeModeStartPoint)StaticClass().DefaultObject;

    internal RChallengeModeStartPoint() { }

    /// <summary>
    /// Constructs a new RChallengeModeStartPoint
    /// </summary>
    public RChallengeModeStartPoint(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RChallengeModeStartPoint(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPoint>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPoint>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPoint>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPoint>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPoint>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPoint>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPoint>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPoint>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_Music_RemoveCustom;
    /// <summary>
    /// Function: Music_RemoveCustom
    /// </summary>
    public unsafe virtual void Music_RemoveCustom()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Music_RemoveCustom, "BmScript.RChallengeModeStartPoint.Music_RemoveCustom");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Music_ChallengeFail;
    /// <summary>
    /// Function: Music_ChallengeFail
    /// </summary>
    public unsafe virtual void Music_ChallengeFail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Music_ChallengeFail, "BmScript.RChallengeModeStartPoint.Music_ChallengeFail");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Music_ChallengeSuccess;
    /// <summary>
    /// Function: Music_ChallengeSuccess
    /// </summary>
    public unsafe virtual void Music_ChallengeSuccess()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Music_ChallengeSuccess, "BmScript.RChallengeModeStartPoint.Music_ChallengeSuccess");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Music_ResetForChallenge;
    /// <summary>
    /// Function: Music_ResetForChallenge
    /// </summary>
    public unsafe virtual void Music_ResetForChallenge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Music_ResetForChallenge, "BmScript.RChallengeModeStartPoint.Music_ResetForChallenge");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowLongRangeInteraction;
    /// <summary>
    /// Function: AllowLongRangeInteraction
    /// </summary>
    public unsafe virtual bool AllowLongRangeInteraction(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowLongRangeInteraction, "BmScript.RChallengeModeStartPoint.AllowLongRangeInteraction");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.RChallengeModeStartPoint.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateChallengeInRGameInfo;
    /// <summary>
    /// Function: UpdateChallengeInRGameInfo
    /// </summary>
    public unsafe virtual void UpdateChallengeInRGameInfo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateChallengeInRGameInfo, "BmScript.RChallengeModeStartPoint.UpdateChallengeInRGameInfo");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnToggle;
    /// <summary>
    /// Function: OnToggle
    /// </summary>
    public unsafe override void OnToggle(BmSDK.Engine.SeqAct_Toggle Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggle, "BmScript.RChallengeModeStartPoint.OnToggle");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBackscreen;
    /// <summary>
    /// Function: OnBackscreen
    /// </summary>
    public unsafe virtual void OnBackscreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBackscreen, "BmScript.RChallengeModeStartPoint.OnBackscreen");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnChallengeCompletion;
    /// <summary>
    /// Function: OnChallengeCompletion
    /// </summary>
    public unsafe virtual void OnChallengeCompletion(bool bFailed, BmSDK.FString sCustomMessage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnChallengeCompletion, "BmScript.RChallengeModeStartPoint.OnChallengeCompletion");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFailed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomMessage, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimerChallengeCompletionDelay;
    /// <summary>
    /// Function: TimerChallengeCompletionDelay
    /// </summary>
    public unsafe virtual void TimerChallengeCompletionDelay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimerChallengeCompletionDelay, "BmScript.RChallengeModeStartPoint.TimerChallengeCompletionDelay");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimerEndingChallenge;
    /// <summary>
    /// Function: TimerEndingChallenge
    /// </summary>
    public unsafe virtual void TimerEndingChallenge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimerEndingChallenge, "BmScript.RChallengeModeStartPoint.TimerEndingChallenge");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeBackIn;
    /// <summary>
    /// Function: FadeBackIn
    /// </summary>
    public unsafe override void FadeBackIn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeBackIn, "BmScript.RChallengeModeStartPoint.FadeBackIn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AbortChallenge;
    /// <summary>
    /// Function: AbortChallenge
    /// </summary>
    public unsafe override void AbortChallenge(int nTriggerEvent, bool bPlayAbortedDialog)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AbortChallenge, "BmScript.RChallengeModeStartPoint.AbortChallenge");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nTriggerEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayAbortedDialog, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopSpeechCallback;
    /// <summary>
    /// Function: StopSpeechCallback
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkDialogue.AkDialogueCallbackResult StopSpeechCallback(int speechId, bool interrupted)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSpeechCallback, "BmScript.RChallengeModeStartPoint.StopSpeechCallback");
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(interrupted, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogue.AkDialogueCallbackResult>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FlushLoading;
    /// <summary>
    /// Function: FlushLoading
    /// </summary>
    public unsafe virtual void FlushLoading()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushLoading, "BmScript.RChallengeModeStartPoint.FlushLoading");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AfterFinishedDialogue;
    /// <summary>
    /// Function: AfterFinishedDialogue
    /// </summary>
    public unsafe virtual void AfterFinishedDialogue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AfterFinishedDialogue, "BmScript.RChallengeModeStartPoint.AfterFinishedDialogue");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimerAfterAbortFadeOut;
    /// <summary>
    /// Function: TimerAfterAbortFadeOut
    /// </summary>
    public unsafe virtual void TimerAfterAbortFadeOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimerAfterAbortFadeOut, "BmScript.RChallengeModeStartPoint.TimerAfterAbortFadeOut");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimerAfterAbortFadeOutAfterSwitchToGameMaps;
    /// <summary>
    /// Function: TimerAfterAbortFadeOutAfterSwitchToGameMaps
    /// </summary>
    public unsafe virtual void TimerAfterAbortFadeOutAfterSwitchToGameMaps()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimerAfterAbortFadeOutAfterSwitchToGameMaps, "BmScript.RChallengeModeStartPoint.TimerAfterAbortFadeOutAfterSwitchToGameMaps");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RestartChallenge;
    /// <summary>
    /// Function: RestartChallenge
    /// </summary>
    public unsafe override void RestartChallenge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestartChallenge, "BmScript.RChallengeModeStartPoint.RestartChallenge");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimerAfterRestartFadeOut;
    /// <summary>
    /// Function: TimerAfterRestartFadeOut
    /// </summary>
    public unsafe virtual void TimerAfterRestartFadeOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimerAfterRestartFadeOut, "BmScript.RChallengeModeStartPoint.TimerAfterRestartFadeOut");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimerAfterRestartFadeOutAfterRespawn;
    /// <summary>
    /// Function: TimerAfterRestartFadeOutAfterRespawn
    /// </summary>
    public unsafe virtual void TimerAfterRestartFadeOutAfterRespawn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimerAfterRestartFadeOutAfterRespawn, "BmScript.RChallengeModeStartPoint.TimerAfterRestartFadeOutAfterRespawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RespawnPlayer;
    /// <summary>
    /// Function: RespawnPlayer
    /// </summary>
    public unsafe virtual void RespawnPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RespawnPlayer, "BmScript.RChallengeModeStartPoint.RespawnPlayer");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitiateScreenMode;
    /// <summary>
    /// Function: InitiateScreenMode
    /// </summary>
    public unsafe override void InitiateScreenMode(BmSDK.BmGame.RChallengeManager.ChallengeScreenModes eMode, bool bAccepted, bool bInGameStart)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitiateScreenMode, "BmScript.RChallengeModeStartPoint.InitiateScreenMode");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eMode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAccepted, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInGameStart, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimerAfterStartFadeOut;
    /// <summary>
    /// Function: TimerAfterStartFadeOut
    /// </summary>
    public unsafe virtual void TimerAfterStartFadeOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimerAfterStartFadeOut, "BmScript.RChallengeModeStartPoint.TimerAfterStartFadeOut");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MovePlayerHere;
    /// <summary>
    /// Function: MovePlayerHere
    /// </summary>
    public unsafe override void MovePlayerHere()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MovePlayerHere, "BmScript.RChallengeModeStartPoint.MovePlayerHere");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerEvent;
    /// <summary>
    /// Function: TriggerEvent
    /// </summary>
    public unsafe override void TriggerEvent(int OutputIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerEvent, "BmScript.RChallengeModeStartPoint.TriggerEvent");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutputIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearChallengeMiniScreen;
    /// <summary>
    /// Function: ClearChallengeMiniScreen
    /// </summary>
    public unsafe override void ClearChallengeMiniScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearChallengeMiniScreen, "BmScript.RChallengeModeStartPoint.ClearChallengeMiniScreen");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetChallengeMiniScreen;
    /// <summary>
    /// Function: SetChallengeMiniScreen
    /// </summary>
    public unsafe override void SetChallengeMiniScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetChallengeMiniScreen, "BmScript.RChallengeModeStartPoint.SetChallengeMiniScreen");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerChallengeAwardPointNotification;
    /// <summary>
    /// Function: TriggerChallengeAwardPointNotification
    /// </summary>
    public unsafe virtual void TriggerChallengeAwardPointNotification()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerChallengeAwardPointNotification, "BmScript.RChallengeModeStartPoint.TriggerChallengeAwardPointNotification");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearChallengeScreen;
    /// <summary>
    /// Function: ClearChallengeScreen
    /// </summary>
    public unsafe override void ClearChallengeScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearChallengeScreen, "BmScript.RChallengeModeStartPoint.ClearChallengeScreen");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetChallengeScreen;
    /// <summary>
    /// Function: SetChallengeScreen
    /// </summary>
    public unsafe override void SetChallengeScreen(BmSDK.BmGame.RChallengeManager.ChallengeScreenModes selected_mode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetChallengeScreen, "BmScript.RChallengeModeStartPoint.SetChallengeScreen");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(selected_mode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverridePreviousLines;
    /// <summary>
    /// Function: OverridePreviousLines
    /// </summary>
    public unsafe virtual bool OverridePreviousLines()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverridePreviousLines, "BmScript.RChallengeModeStartPoint.OverridePreviousLines");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInteractButton;
    /// <summary>
    /// Function: GetInteractButton
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RInteractInterface.EInteractableItemFaceButton GetInteractButton(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInteractButton, "BmScript.RChallengeModeStartPoint.GetInteractButton");
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInteractInterface.EInteractableItemFaceButton>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetUpperPrompt;
    /// <summary>
    /// Function: GetUpperPrompt
    /// </summary>
    public unsafe virtual BmSDK.FString GetUpperPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUpperPrompt, "BmScript.RChallengeModeStartPoint.GetUpperPrompt");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OverridesRun;
    /// <summary>
    /// Function: OverridesRun
    /// </summary>
    public unsafe virtual float OverridesRun(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverridesRun, "BmScript.RChallengeModeStartPoint.OverridesRun");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanReachItem;
    /// <summary>
    /// Function: CanReachItem
    /// </summary>
    public unsafe virtual bool CanReachItem(BmSDK.Engine.Pawn CheckingPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReachItem, "BmScript.RChallengeModeStartPoint.CanReachItem");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckingPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetLocationOffset;
    /// <summary>
    /// Function: GetLocationOffset
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetLocationOffset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocationOffset, "BmScript.RChallengeModeStartPoint.GetLocationOffset");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanUseInCinematicMode;
    /// <summary>
    /// Function: CanUseInCinematicMode
    /// </summary>
    public unsafe virtual bool CanUseInCinematicMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseInCinematicMode, "BmScript.RChallengeModeStartPoint.CanUseInCinematicMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MustBeCrouched;
    /// <summary>
    /// Function: MustBeCrouched
    /// </summary>
    public unsafe virtual bool MustBeCrouched(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MustBeCrouched, "BmScript.RChallengeModeStartPoint.MustBeCrouched");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsButtonPrompt;
    /// <summary>
    /// Function: IsButtonPrompt
    /// </summary>
    public unsafe virtual bool IsButtonPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsButtonPrompt, "BmScript.RChallengeModeStartPoint.IsButtonPrompt");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPriority;
    /// <summary>
    /// Function: GetPriority
    /// </summary>
    public unsafe virtual float GetPriority()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPriority, "BmScript.RChallengeModeStartPoint.GetPriority");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFOVDegrees;
    /// <summary>
    /// Function: GetFOVDegrees
    /// </summary>
    public unsafe virtual float GetFOVDegrees(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFOVDegrees, "BmScript.RChallengeModeStartPoint.GetFOVDegrees");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetHeightRange;
    /// <summary>
    /// Function: GetHeightRange
    /// </summary>
    public unsafe virtual float GetHeightRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeightRange, "BmScript.RChallengeModeStartPoint.GetHeightRange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRange;
    /// <summary>
    /// Function: GetRange
    /// </summary>
    public unsafe virtual float GetRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRange, "BmScript.RChallengeModeStartPoint.GetRange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Interact;
    /// <summary>
    /// Function: Interact
    /// </summary>
    public unsafe virtual void Interact(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Interact, "BmScript.RChallengeModeStartPoint.Interact");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsActive;
    /// <summary>
    /// Function: IsActive
    /// </summary>
    public unsafe virtual bool IsActive(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsActive, "BmScript.RChallengeModeStartPoint.IsActive");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPrompt;
    /// <summary>
    /// Function: GetPrompt
    /// </summary>
    public unsafe virtual BmSDK.FString GetPrompt(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrompt, "BmScript.RChallengeModeStartPoint.GetPrompt");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CompleteRestartOrAbort;
    /// <summary>
    /// Function: CompleteRestartOrAbort
    /// </summary>
    public unsafe virtual void CompleteRestartOrAbort()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CompleteRestartOrAbort, "BmScript.RChallengeModeStartPoint.CompleteRestartOrAbort");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bCompletionFailed
    /// </summary>
    public unsafe bool bCompletionFailed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1512); }
    }

    /// <summary>
    /// BoolProperty: bAbortChallenge
    /// </summary>
    public unsafe bool bAbortChallenge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1512); }
    }

    /// <summary>
    /// BoolProperty: bRestartChallenge
    /// </summary>
    public unsafe bool bRestartChallenge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1512); }
    }

    /// <summary>
    /// BoolProperty: DoFadeOnSuccess
    /// </summary>
    public unsafe bool DoFadeOnSuccess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1512); }
    }

    /// <summary>
    /// BoolProperty: DoFadeOnFail
    /// </summary>
    public unsafe bool DoFadeOnFail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1512); }
    }

    /// <summary>
    /// BoolProperty: DoFadeOnAbort
    /// </summary>
    public unsafe bool DoFadeOnAbort
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1512); }
    }

    /// <summary>
    /// BoolProperty: DoFadeOnRestart
    /// </summary>
    public unsafe bool DoFadeOnRestart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1512); }
    }

    /// <summary>
    /// StrProperty: sCompletionDebriefMessage
    /// </summary>
    public unsafe BmSDK.FString sCompletionDebriefMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// IntProperty: AfterFadeEventToTrigger
    /// </summary>
    public unsafe int AfterFadeEventToTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// FloatProperty: TimeSpentInWaitState
    /// </summary>
    public unsafe float TimeSpentInWaitState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// DelegateProperty: __CompleteRestartOrAbort__Delegate
    /// </summary>
    public unsafe System.IntPtr __CompleteRestartOrAbort__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }
}
