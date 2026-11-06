#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RJokerTannoy<br/>
/// (size = 752)
/// (flags = 144703634)
/// </summary>
public partial class RJokerTannoy : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RJokerTannoy", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RJokerTannoy.
    /// </summary>
    public static RJokerTannoy DefaultObject => (RJokerTannoy)StaticClass().DefaultObject;

    internal RJokerTannoy() { }

    /// <summary>
    /// Constructs a new RJokerTannoy
    /// </summary>
    public RJokerTannoy(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RJokerTannoy(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJokerTannoy>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerTannoy>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJokerTannoy>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerTannoy>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerTannoy>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerTannoy>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJokerTannoy>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerTannoy>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PlaySpecialHackyVoiceSynthDisableLine;
    /// <summary>
    /// Function: PlaySpecialHackyVoiceSynthDisableLine
    /// </summary>
    public unsafe virtual bool PlaySpecialHackyVoiceSynthDisableLine()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySpecialHackyVoiceSynthDisableLine, "BmGame.RJokerTannoy.PlaySpecialHackyVoiceSynthDisableLine");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TrySpecialHackyVoiceSynthDisableLine;
    /// <summary>
    /// Function: TrySpecialHackyVoiceSynthDisableLine
    /// </summary>
    public unsafe virtual bool TrySpecialHackyVoiceSynthDisableLine()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrySpecialHackyVoiceSynthDisableLine, "BmGame.RJokerTannoy.TrySpecialHackyVoiceSynthDisableLine");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSpeakerGender;
    /// <summary>
    /// Function: GetSpeakerGender
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkDialogue.AkDialogueVoiceGender GetSpeakerGender()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpeakerGender, "BmGame.RJokerTannoy.GetSpeakerGender");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogue.AkDialogueVoiceGender>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsTannoyCharSpeaking;
    /// <summary>
    /// Function: IsTannoyCharSpeaking
    /// </summary>
    public unsafe virtual bool IsTannoyCharSpeaking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTannoyCharSpeaking, "BmGame.RJokerTannoy.IsTannoyCharSpeaking");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasScriptedSpeechToPlay;
    /// <summary>
    /// Function: HasScriptedSpeechToPlay
    /// </summary>
    public unsafe virtual bool HasScriptedSpeechToPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasScriptedSpeechToPlay, "BmGame.RJokerTannoy.HasScriptedSpeechToPlay");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpecialLastManAnnouncement;
    /// <summary>
    /// Function: SpecialLastManAnnouncement
    /// </summary>
    public unsafe virtual void SpecialLastManAnnouncement()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialLastManAnnouncement, "BmGame.RJokerTannoy.SpecialLastManAnnouncement");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnToggle;
    /// <summary>
    /// Function: OnToggle
    /// </summary>
    public unsafe virtual void OnToggle(BmSDK.Engine.SeqAct_Toggle Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggle, "BmGame.RJokerTannoy.OnToggle");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryVoiceSynthDisabledKismetEvent;
    /// <summary>
    /// Function: TryVoiceSynthDisabledKismetEvent
    /// </summary>
    public unsafe virtual bool TryVoiceSynthDisabledKismetEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryVoiceSynthDisabledKismetEvent, "BmGame.RJokerTannoy.TryVoiceSynthDisabledKismetEvent");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayTakedownResponse;
    /// <summary>
    /// Function: PlayTakedownResponse
    /// </summary>
    public unsafe virtual bool PlayTakedownResponse(BmSDK.Engine.Actor Subject, BmSDK.FName flag, BmSDK.BmGame.RAlertEventCoordinatorBase owningEvent, BmSDK.TArray<BmSDK.Engine.Actor> extraSpeakers = default, BmSDK.FName nInvestigateTargetFlag = default, bool bForceCanPlay = default, System.IntPtr NewBarkFinished = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayTakedownResponse, "BmGame.RJokerTannoy.PlayTakedownResponse");
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(flag, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(owningEvent, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(extraSpeakers, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nInvestigateTargetFlag, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceCanPlay, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBarkFinished, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 68);
    }

    private static BmSDK.Function __fn_CanPlayAnnouncement;
    /// <summary>
    /// Function: CanPlayAnnouncement
    /// </summary>
    public unsafe virtual bool CanPlayAnnouncement()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayAnnouncement, "BmGame.RJokerTannoy.CanPlayAnnouncement");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HandleBarkPlayed;
    /// <summary>
    /// Function: HandleBarkPlayed
    /// </summary>
    public unsafe virtual void HandleBarkPlayed(BmSDK.BmGame.RBarkFlagBase FlagsOfLinePlayed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleBarkPlayed, "BmGame.RJokerTannoy.HandleBarkPlayed");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagsOfLinePlayed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLine;
    /// <summary>
    /// Function: GetLine
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBarkConvo GetLine(out float PlayedScore)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLine, "BmGame.RJokerTannoy.GetLine");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PlayedScore = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkConvo>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsAbleToPlayChatter;
    /// <summary>
    /// Function: IsAbleToPlayChatter
    /// </summary>
    public unsafe virtual bool IsAbleToPlayChatter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAbleToPlayChatter, "BmGame.RJokerTannoy.IsAbleToPlayChatter");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAbleToPlayLines;
    /// <summary>
    /// Function: IsAbleToPlayLines
    /// </summary>
    public unsafe virtual bool IsAbleToPlayLines()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAbleToPlayLines, "BmGame.RJokerTannoy.IsAbleToPlayLines");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsTannoyActive;
    /// <summary>
    /// Function: IsTannoyActive
    /// </summary>
    public unsafe virtual bool IsTannoyActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTannoyActive, "BmGame.RJokerTannoy.IsTannoyActive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RJokerTannoy.Destroyed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RJokerTannoy.PreStreamOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitWithRoomState;
    /// <summary>
    /// Function: InitWithRoomState
    /// </summary>
    public unsafe virtual void InitWithRoomState(BmSDK.BmGame.RBMRoomAIState NewRoomState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitWithRoomState, "BmGame.RJokerTannoy.InitWithRoomState");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRoomState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RJokerTannoy.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bFireEventsWithoutAudio
    /// </summary>
    public unsafe bool bFireEventsWithoutAudio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bTannoyActive
    /// </summary>
    public unsafe bool bTannoyActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bGameplayAnnouncementsOnly
    /// </summary>
    public unsafe bool bGameplayAnnouncementsOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bFirstNervousLineIsScripted
    /// </summary>
    public unsafe bool bFirstNervousLineIsScripted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bScriptedFirstNervousLineDone
    /// </summary>
    public unsafe bool bScriptedFirstNervousLineDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bTalkDuringCocky
    /// </summary>
    public unsafe bool bTalkDuringCocky
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// FloatProperty: MinTimeBetweenLines
    /// </summary>
    public unsafe float MinTimeBetweenLines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// IntProperty: HeadCountCommentIndex
    /// </summary>
    public unsafe int HeadCountCommentIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ComponentProperty: RoomState
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState RoomState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// ObjectProperty: TannoyCharDef
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkCharacterDef TannoyCharDef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkCharacterDef>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ObjectProperty: CharacterVoice
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueVoice CharacterVoice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueVoice>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ObjectProperty: BCDInstance
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkCharacterDefInstance BCDInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkCharacterDefInstance>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: BossInRoomPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnSpeech BossInRoomPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnSpeech>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: SpecialPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnSpeech SpecialPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnSpeech>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: DSDef
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkCharacterDef DSDef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkCharacterDef>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ObjectProperty: VoiceSynth
    /// </summary>
    public unsafe BmSDK.BmGame.TannoyVoiceSynthActor VoiceSynth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.TannoyVoiceSynthActor>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ComponentProperty: PawnSpeechDialogueComponent
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueComponent PawnSpeechDialogueComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueComponent>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }
}
