#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieResonatorMinigame<br/>
/// (size = 840)
/// (flags = 134217878)
/// </summary>
public partial class RGFxMovieResonatorMinigame : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieResonatorMinigame", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieResonatorMinigame.
    /// </summary>
    public static RGFxMovieResonatorMinigame DefaultObject => (RGFxMovieResonatorMinigame)StaticClass().DefaultObject;

    internal RGFxMovieResonatorMinigame() { }

    /// <summary>
    /// Constructs a new RGFxMovieResonatorMinigame
    /// </summary>
    public RGFxMovieResonatorMinigame(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieResonatorMinigame Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieResonatorMinigame(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieResonatorMinigame>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieResonatorMinigame>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieResonatorMinigame>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieResonatorMinigame>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieResonatorMinigame>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieResonatorMinigame>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieResonatorMinigame>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieResonatorMinigame>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_RadioScannerAudioCallback;
    /// <summary>
    /// Function: RadioScannerAudioCallback
    /// </summary>
    public unsafe virtual void RadioScannerAudioCallback(int CallbackFlags, BmSDK.Engine.AkWwise.FAkSoundHandle SoundHandle, int MarkerID, float Duration)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RadioScannerAudioCallback, "BmGame.RGFxMovieResonatorMinigame.RadioScannerAudioCallback");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CallbackFlags, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundHandle, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MarkerID, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RadioScannerAudioMarker;
    /// <summary>
    /// Function: RadioScannerAudioMarker
    /// </summary>
    public unsafe virtual void RadioScannerAudioMarker(BmSDK.Engine.AkWwise.FAkSoundHandle SoundHandle, int MarkerID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RadioScannerAudioMarker, "BmGame.RGFxMovieResonatorMinigame.RadioScannerAudioMarker");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundHandle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MarkerID, paramsPtr + 16);
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

    private static BmSDK.Function __fn_FE_CloseResonator;
    /// <summary>
    /// Function: FE_CloseResonator
    /// </summary>
    public unsafe virtual void FE_CloseResonator()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FE_CloseResonator, "BmGame.RGFxMovieResonatorMinigame.FE_CloseResonator");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FE_StartResonator;
    /// <summary>
    /// Function: FE_StartResonator
    /// </summary>
    public unsafe virtual void FE_StartResonator()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FE_StartResonator, "BmGame.RGFxMovieResonatorMinigame.FE_StartResonator");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FE_NotifyPasswordFound;
    /// <summary>
    /// Function: FE_NotifyPasswordFound
    /// </summary>
    public unsafe virtual void FE_NotifyPasswordFound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FE_NotifyPasswordFound, "BmGame.RGFxMovieResonatorMinigame.FE_NotifyPasswordFound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FE_PlayResonatorAudioEvent;
    /// <summary>
    /// Function: FE_PlayResonatorAudioEvent
    /// </summary>
    public unsafe virtual void FE_PlayResonatorAudioEvent(int event_index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FE_PlayResonatorAudioEvent, "BmGame.RGFxMovieResonatorMinigame.FE_PlayResonatorAudioEvent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(event_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FE_SetRumbleFromFlash;
    /// <summary>
    /// Function: FE_SetRumbleFromFlash
    /// </summary>
    public unsafe virtual void FE_SetRumbleFromFlash(float left_rumble, float right_rumble)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FE_SetRumbleFromFlash, "BmGame.RGFxMovieResonatorMinigame.FE_SetRumbleFromFlash");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(left_rumble, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(right_rumble, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FE_RedoPasswordPrompts;
    /// <summary>
    /// Function: FE_RedoPasswordPrompts
    /// </summary>
    public unsafe virtual void FE_RedoPasswordPrompts(bool _CanCyclePasswords)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FE_RedoPasswordPrompts, "BmGame.RGFxMovieResonatorMinigame.FE_RedoPasswordPrompts");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_CanCyclePasswords, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FE_RedoDisruptedPrompts;
    /// <summary>
    /// Function: FE_RedoDisruptedPrompts
    /// </summary>
    public unsafe virtual void FE_RedoDisruptedPrompts(bool _CanExit)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FE_RedoDisruptedPrompts, "BmGame.RGFxMovieResonatorMinigame.FE_RedoDisruptedPrompts");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_CanExit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FE_RedoRadioPrompts;
    /// <summary>
    /// Function: FE_RedoRadioPrompts
    /// </summary>
    public unsafe virtual void FE_RedoRadioPrompts(bool _RadioCanScan, bool _RadioCanMove, bool _RadioCanFlick)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FE_RedoRadioPrompts, "BmGame.RGFxMovieResonatorMinigame.FE_RedoRadioPrompts");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RadioCanScan, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RadioCanMove, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RadioCanFlick, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FE_StopRadio;
    /// <summary>
    /// Function: FE_StopRadio
    /// </summary>
    public unsafe virtual void FE_StopRadio()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FE_StopRadio, "BmGame.RGFxMovieResonatorMinigame.FE_StopRadio");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FE_SetCurrentRadioDecrypted;
    /// <summary>
    /// Function: FE_SetCurrentRadioDecrypted
    /// </summary>
    public unsafe virtual void FE_SetCurrentRadioDecrypted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FE_SetCurrentRadioDecrypted, "BmGame.RGFxMovieResonatorMinigame.FE_SetCurrentRadioDecrypted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FE_SetCurrentRadioWarbleXY;
    /// <summary>
    /// Function: FE_SetCurrentRadioWarbleXY
    /// </summary>
    public unsafe virtual void FE_SetCurrentRadioWarbleXY(float value_x, float value_y)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FE_SetCurrentRadioWarbleXY, "BmGame.RGFxMovieResonatorMinigame.FE_SetCurrentRadioWarbleXY");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(value_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(value_y, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FE_SetCurrentRadioAudioLevel;
    /// <summary>
    /// Function: FE_SetCurrentRadioAudioLevel
    /// </summary>
    public unsafe virtual void FE_SetCurrentRadioAudioLevel(float zero_to_one)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FE_SetCurrentRadioAudioLevel, "BmGame.RGFxMovieResonatorMinigame.FE_SetCurrentRadioAudioLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(zero_to_one, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FE_SetCurrentRadioStation;
    /// <summary>
    /// Function: FE_SetCurrentRadioStation
    /// </summary>
    public unsafe virtual void FE_SetCurrentRadioStation(BmSDK.FString RadioStationName, int CurrentSequence, bool encrypted)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FE_SetCurrentRadioStation, "BmGame.RGFxMovieResonatorMinigame.FE_SetCurrentRadioStation");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RadioStationName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentSequence, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(encrypted, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRadioAudioStates;
    /// <summary>
    /// Function: SetRadioAudioStates
    /// </summary>
    public unsafe virtual void SetRadioAudioStates(BmSDK.Engine.AkStateName base_state, BmSDK.Engine.AkStateName sequence_state)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRadioAudioStates, "BmGame.RGFxMovieResonatorMinigame.SetRadioAudioStates");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(base_state, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sequence_state, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FE_SetRadioStationFound;
    /// <summary>
    /// Function: FE_SetRadioStationFound
    /// </summary>
    public unsafe virtual void FE_SetRadioStationFound(BmSDK.FString RadioStationNameInternal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FE_SetRadioStationFound, "BmGame.RGFxMovieResonatorMinigame.FE_SetRadioStationFound");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RadioStationNameInternal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FE_TriggerOneShotRadioEvent;
    /// <summary>
    /// Function: FE_TriggerOneShotRadioEvent
    /// </summary>
    public unsafe virtual void FE_TriggerOneShotRadioEvent(BmSDK.FString RadioStationName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FE_TriggerOneShotRadioEvent, "BmGame.RGFxMovieResonatorMinigame.FE_TriggerOneShotRadioEvent");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RadioStationName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FE_PasswordCrackerCrashedEvent;
    /// <summary>
    /// Function: FE_PasswordCrackerCrashedEvent
    /// </summary>
    public unsafe virtual void FE_PasswordCrackerCrashedEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FE_PasswordCrackerCrashedEvent, "BmGame.RGFxMovieResonatorMinigame.FE_PasswordCrackerCrashedEvent");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FE_TellFlashAboutControllerState;
    /// <summary>
    /// Function: FE_TellFlashAboutControllerState
    /// </summary>
    public unsafe virtual void FE_TellFlashAboutControllerState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FE_TellFlashAboutControllerState, "BmGame.RGFxMovieResonatorMinigame.FE_TellFlashAboutControllerState");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayResonatorAudioEvent;
    /// <summary>
    /// Function: PlayResonatorAudioEvent
    /// </summary>
    public unsafe virtual void PlayResonatorAudioEvent(int event_index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayResonatorAudioEvent, "BmGame.RGFxMovieResonatorMinigame.PlayResonatorAudioEvent");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(event_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillPasswordAudio;
    /// <summary>
    /// Function: KillPasswordAudio
    /// </summary>
    public unsafe virtual void KillPasswordAudio()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillPasswordAudio, "BmGame.RGFxMovieResonatorMinigame.KillPasswordAudio");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartPasswordAudio;
    /// <summary>
    /// Function: StartPasswordAudio
    /// </summary>
    public unsafe virtual void StartPasswordAudio()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartPasswordAudio, "BmGame.RGFxMovieResonatorMinigame.StartPasswordAudio");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayMinigamePrompts;
    /// <summary>
    /// Function: DisplayMinigamePrompts
    /// </summary>
    public unsafe virtual void DisplayMinigamePrompts(BmSDK.BmGame.RHUDPrompt HelpPrompt)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayMinigamePrompts, "BmGame.RGFxMovieResonatorMinigame.DisplayMinigamePrompts");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRumbleFromFlash;
    /// <summary>
    /// Function: SetRumbleFromFlash
    /// </summary>
    public unsafe virtual void SetRumbleFromFlash(float left_rumble, float right_rumble)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRumbleFromFlash, "BmGame.RGFxMovieResonatorMinigame.SetRumbleFromFlash");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(left_rumble, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(right_rumble, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RedoRadioPrompts;
    /// <summary>
    /// Function: RedoRadioPrompts
    /// </summary>
    public unsafe virtual void RedoRadioPrompts(bool _RadioCanScan, bool _RadioCanMove, bool _RadioCanFlick)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RedoRadioPrompts, "BmGame.RGFxMovieResonatorMinigame.RedoRadioPrompts");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RadioCanScan, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RadioCanMove, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RadioCanFlick, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MakeUnresponsive;
    /// <summary>
    /// Function: MakeUnresponsive
    /// </summary>
    public unsafe virtual void MakeUnresponsive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeUnresponsive, "BmGame.RGFxMovieResonatorMinigame.MakeUnresponsive");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestQuit;
    /// <summary>
    /// Function: RequestQuit
    /// </summary>
    public unsafe virtual void RequestQuit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestQuit, "BmGame.RGFxMovieResonatorMinigame.RequestQuit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BroadcastIsJammed;
    /// <summary>
    /// Function: BroadcastIsJammed
    /// </summary>
    public unsafe virtual void BroadcastIsJammed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BroadcastIsJammed, "BmGame.RGFxMovieResonatorMinigame.BroadcastIsJammed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableEncryptedChipIntro;
    /// <summary>
    /// Function: EnableEncryptedChipIntro
    /// </summary>
    public unsafe virtual void EnableEncryptedChipIntro()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableEncryptedChipIntro, "BmGame.RGFxMovieResonatorMinigame.EnableEncryptedChipIntro");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddStation;
    /// <summary>
    /// Function: AddStation
    /// </summary>
    public unsafe virtual void AddStation(BmSDK.FString StationName, float FrequencyX, float FrequencyY, int TransmissionRadius, byte CurrentSequence, bool HasBeenFound, bool HasHadHint, bool IsEncrypted, bool Mandatory, bool EasterEgg, BmSDK.FString StationTransmitterType, BmSDK.FString StationEncryptionType, BmSDK.FString StationEncryptionStrength, bool HasOneShotEvent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddStation, "BmGame.RGFxMovieResonatorMinigame.AddStation");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StationName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FrequencyX, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FrequencyY, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransmissionRadius, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentSequence, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HasBeenFound, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HasHadHint, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsEncrypted, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mandatory, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EasterEgg, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StationTransmitterType, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StationEncryptionType, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StationEncryptionStrength, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HasOneShotEvent, paramsPtr + 100);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAudioInterceptDetails;
    /// <summary>
    /// Function: SetAudioInterceptDetails
    /// </summary>
    public unsafe virtual void SetAudioInterceptDetails(BmSDK.FString StationName, BmSDK.FString SpeakerName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAudioInterceptDetails, "BmGame.RGFxMovieResonatorMinigame.SetAudioInterceptDetails");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StationName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeakerName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RedoDisruptedPrompts;
    /// <summary>
    /// Function: RedoDisruptedPrompts
    /// </summary>
    public unsafe virtual void RedoDisruptedPrompts(bool _CanExit)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RedoDisruptedPrompts, "BmGame.RGFxMovieResonatorMinigame.RedoDisruptedPrompts");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_CanExit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetControlBoxParams;
    /// <summary>
    /// Function: SetControlBoxParams
    /// </summary>
    public unsafe virtual void SetControlBoxParams(int _SecurityLevel, BmSDK.FString _HackingNetworkString, BmSDK.FString _HackingTargetString, int _PasswordDifficultyLevel)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetControlBoxParams, "BmGame.RGFxMovieResonatorMinigame.SetControlBoxParams");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_SecurityLevel, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_HackingNetworkString, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_HackingTargetString, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_PasswordDifficultyLevel, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDistortionEffectActive;
    /// <summary>
    /// Function: SetDistortionEffectActive
    /// </summary>
    public unsafe virtual void SetDistortionEffectActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDistortionEffectActive, "BmGame.RGFxMovieResonatorMinigame.SetDistortionEffectActive");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetImminentJamming;
    /// <summary>
    /// Function: SetImminentJamming
    /// </summary>
    public unsafe virtual void SetImminentJamming()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetImminentJamming, "BmGame.RGFxMovieResonatorMinigame.SetImminentJamming");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHighSecurity;
    /// <summary>
    /// Function: SetHighSecurity
    /// </summary>
    public unsafe virtual void SetHighSecurity()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHighSecurity, "BmGame.RGFxMovieResonatorMinigame.SetHighSecurity");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RedoPasswordPrompts;
    /// <summary>
    /// Function: RedoPasswordPrompts
    /// </summary>
    public unsafe virtual void RedoPasswordPrompts(bool _CanCyclePasswords)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RedoPasswordPrompts, "BmGame.RGFxMovieResonatorMinigame.RedoPasswordPrompts");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_CanCyclePasswords, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartResonatorMinigame;
    /// <summary>
    /// Function: StartResonatorMinigame
    /// </summary>
    public unsafe virtual void StartResonatorMinigame()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartResonatorMinigame, "BmGame.RGFxMovieResonatorMinigame.StartResonatorMinigame");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetResonatorPassword;
    /// <summary>
    /// Function: SetResonatorPassword
    /// </summary>
    public unsafe virtual void SetResonatorPassword(int password_index, BmSDK.FString the_password)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetResonatorPassword, "BmGame.RGFxMovieResonatorMinigame.SetResonatorPassword");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(password_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_password, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInstructionText;
    /// <summary>
    /// Function: SetInstructionText
    /// </summary>
    public unsafe virtual void SetInstructionText(BmSDK.FString new_instructions)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInstructionText, "BmGame.RGFxMovieResonatorMinigame.SetInstructionText");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_instructions, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableDebugAction;
    /// <summary>
    /// Function: EnableDebugAction
    /// </summary>
    public unsafe virtual void EnableDebugAction()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableDebugAction, "BmGame.RGFxMovieResonatorMinigame.EnableDebugAction");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestThenClearFlag;
    /// <summary>
    /// Function: TestThenClearFlag
    /// </summary>
    public unsafe virtual bool TestThenClearFlag(BmSDK.FString FlagName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestThenClearFlag, "BmGame.RGFxMovieResonatorMinigame.TestThenClearFlag");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_OnCloseMinigame;
    /// <summary>
    /// Function: OnCloseMinigame
    /// </summary>
    public unsafe virtual void OnCloseMinigame()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCloseMinigame, "BmGame.RGFxMovieResonatorMinigame.OnCloseMinigame");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe virtual void CloseScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmGame.RGFxMovieResonatorMinigame.CloseScreen");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Hide;
    /// <summary>
    /// Function: Hide
    /// </summary>
    public unsafe virtual void Hide()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Hide, "BmGame.RGFxMovieResonatorMinigame.Hide");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_show;
    /// <summary>
    /// Function: show
    /// </summary>
    public unsafe virtual void show()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_show, "BmGame.RGFxMovieResonatorMinigame.show");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideItem;
    /// <summary>
    /// Function: HideItem
    /// </summary>
    public unsafe virtual void HideItem(BmSDK.FString ItemName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideItem, "BmGame.RGFxMovieResonatorMinigame.HideItem");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowItem;
    /// <summary>
    /// Function: ShowItem
    /// </summary>
    public unsafe virtual void ShowItem(BmSDK.FString ItemName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowItem, "BmGame.RGFxMovieResonatorMinigame.ShowItem");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KismetControlsInOut;
    /// <summary>
    /// Function: KismetControlsInOut
    /// </summary>
    public unsafe virtual void KismetControlsInOut(bool bTrue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KismetControlsInOut, "BmGame.RGFxMovieResonatorMinigame.KismetControlsInOut");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTrue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadMiniGame;
    /// <summary>
    /// Function: LoadMiniGame
    /// </summary>
    public unsafe virtual void LoadMiniGame(BmSDK.FString minigame_path)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadMiniGame, "BmGame.RGFxMovieResonatorMinigame.LoadMiniGame");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(minigame_path, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendCachedMousePosition;
    /// <summary>
    /// Function: SendCachedMousePosition
    /// </summary>
    public unsafe virtual void SendCachedMousePosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendCachedMousePosition, "BmGame.RGFxMovieResonatorMinigame.SendCachedMousePosition");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCachedMousePosition;
    /// <summary>
    /// Function: SetCachedMousePosition
    /// </summary>
    public unsafe virtual void SetCachedMousePosition(float _fCachedMouseX, float _fCachedMouseY)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCachedMousePosition, "BmGame.RGFxMovieResonatorMinigame.SetCachedMousePosition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_fCachedMouseX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_fCachedMouseY, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MinigameTick;
    /// <summary>
    /// Function: MinigameTick
    /// </summary>
    public unsafe virtual void MinigameTick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MinigameTick, "BmGame.RGFxMovieResonatorMinigame.MinigameTick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHudVisibility;
    /// <summary>
    /// Function: UpdateHudVisibility
    /// </summary>
    public unsafe override void UpdateHudVisibility(bool bVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHudVisibility, "BmGame.RGFxMovieResonatorMinigame.UpdateHudVisibility");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendRandomCharacterString;
    /// <summary>
    /// Function: SendRandomCharacterString
    /// </summary>
    public unsafe virtual void SendRandomCharacterString()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendRandomCharacterString, "BmGame.RGFxMovieResonatorMinigame.SendRandomCharacterString");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovieResonatorMinigame.Init");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: ControllerStatusFields
    /// </summary>
    public enum ControllerStatusFields : byte
    {
        CSF_UsingController = 0,
        CSF_LeftX_OR_KeyboardX = 1,
        CSF_LeftY_OR_KeyboardY = 2,
        CSF_RightX_OR_MouseX = 3,
        CSF_RightY_OR_MouseY = 4,
        CSF_Left_Bumper = 5,
        CSF_Right_Bumper = 6,
        CSF_Left_Trigger = 7,
        CSF_Right_Trigger = 8,
        CSF_ButtonA = 9,
        CSF_ButtonB = 10,
        CSF_MAX = 11,
    }

    /// <summary>
    /// Enum: ResonatorAudioEvent
    /// </summary>
    public enum ResonatorAudioEvent : byte
    {
        RAE_StickStable = 0,
        RAE_BothSticksStable = 1,
        RAE_BothSticksCorrect = 2,
        RAE_ConfirmDisrupt = 3,
        RAE_LeftStickStartMove = 4,
        RAE_LeftStickStopMove = 5,
        RAE_RightStickStartMove = 6,
        RAE_RightStickStopMove = 7,
        RAE_StartSequencer = 8,
        RAE_StopSequencer = 9,
        RAE_MAX = 10,
    }

    /// <summary>
    /// BoolProperty: RadioCanScan
    /// </summary>
    public unsafe bool RadioCanScan
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: RadioCanMove
    /// </summary>
    public unsafe bool RadioCanMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: RadioCanFlick
    /// </summary>
    public unsafe bool RadioCanFlick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: CanExit
    /// </summary>
    public unsafe bool CanExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: CanCyclePasswords
    /// </summary>
    public unsafe bool CanCyclePasswords
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bIsHighSecurity
    /// </summary>
    public unsafe bool bIsHighSecurity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bJammingImminent
    /// </summary>
    public unsafe bool bJammingImminent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bAlreadyJammed
    /// </summary>
    public unsafe bool bAlreadyJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bIsInPasswordMode
    /// </summary>
    public unsafe bool bIsInPasswordMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: RumbleEnabled
    /// </summary>
    public unsafe bool RumbleEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bAnyMandatoryStations
    /// </summary>
    public unsafe bool bAnyMandatoryStations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// StrProperty: GadgetHelpText
    /// </summary>
    public unsafe BmSDK.FString GadgetHelpText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ByteProperty: GadgetHelpIcon
    /// </summary>
    public unsafe BmSDK.BmGame.RHUDPrompt.EControlIcon GadgetHelpIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.EControlIcon>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// StrProperty: ResonatorInstructions
    /// </summary>
    public unsafe BmSDK.FString ResonatorInstructions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// StrProperty: ResonatorMoviePath
    /// </summary>
    public unsafe BmSDK.FString ResonatorMoviePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ArrayProperty: PasswordArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PasswordArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// FloatProperty: FlashRumbleValueLeft
    /// </summary>
    public unsafe float FlashRumbleValueLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// FloatProperty: FlashRumbleValueRight
    /// </summary>
    public unsafe float FlashRumbleValueRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// IntProperty: SecurityLevel
    /// </summary>
    public unsafe int SecurityLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// StrProperty: HackingNetworkString
    /// </summary>
    public unsafe BmSDK.FString HackingNetworkString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// StrProperty: HackingTargetString
    /// </summary>
    public unsafe BmSDK.FString HackingTargetString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: fCachedMouseX
    /// </summary>
    public unsafe float fCachedMouseX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: fCachedMouseY
    /// </summary>
    public unsafe float fCachedMouseY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// IntProperty: PasswordDifficultyLevel
    /// </summary>
    public unsafe int PasswordDifficultyLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ArrayProperty: ControllerStatusArray
    /// </summary>
    public unsafe BmSDK.TArray<float> ControllerStatusArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }
}
