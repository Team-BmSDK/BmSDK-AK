#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GameInfo<br/>
/// (size = 1532)
/// (flags = 144703670)
/// </summary>
public partial class GameInfo : BmSDK.Engine.Info, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GameInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GameInfo.
    /// </summary>
    public static GameInfo DefaultObject => (GameInfo)StaticClass().DefaultObject;

    internal GameInfo() { }

    /// <summary>
    /// Constructs a new GameInfo
    /// </summary>
    public GameInfo(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GameInfo(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameInfo>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameInfo>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameInfo>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameInfo>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameInfo>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameInfo>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameInfo>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameInfo>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PylonLoaded;
    /// <summary>
    /// Function: PylonLoaded
    /// </summary>
    public unsafe virtual void PylonLoaded(BmSDK.Engine.Pylon NewPylon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PylonLoaded, "Engine.GameInfo.PylonLoaded");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPylon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearOnlineDelegates;
    /// <summary>
    /// Function: ClearOnlineDelegates
    /// </summary>
    public unsafe virtual void ClearOnlineDelegates()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearOnlineDelegates, "Engine.GameInfo.ClearOnlineDelegates");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitCrowdPopulationManager;
    /// <summary>
    /// Function: InitCrowdPopulationManager
    /// </summary>
    public unsafe virtual void InitCrowdPopulationManager()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitCrowdPopulationManager, "Engine.GameInfo.InitCrowdPopulationManager");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnEngineHasLoaded;
    /// <summary>
    /// Function: OnEngineHasLoaded
    /// </summary>
    public unsafe virtual void OnEngineHasLoaded()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEngineHasLoaded, "Engine.GameInfo.OnEngineHasLoaded");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDestroyOnlineGameComplete;
    /// <summary>
    /// Function: OnDestroyOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnDestroyOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDestroyOnlineGameComplete, "Engine.GameInfo.OnDestroyOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StandbyCheatDetected;
    /// <summary>
    /// Function: StandbyCheatDetected
    /// </summary>
    public unsafe virtual void StandbyCheatDetected(BmSDK.Engine.GameInfo.EStandbyType StandbyType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StandbyCheatDetected, "Engine.GameInfo.StandbyCheatDetected");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StandbyType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableStandbyCheatDetection;
    /// <summary>
    /// Function: EnableStandbyCheatDetection
    /// </summary>
    public unsafe virtual void EnableStandbyCheatDetection(bool bIsEnabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableStandbyCheatDetection, "Engine.GameInfo.EnableStandbyCheatDetection");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsEnabled, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetGameTimePlayedString;
    /// <summary>
    /// Function: GetGameTimePlayedString
    /// </summary>
    public unsafe virtual BmSDK.FString GetGameTimePlayedString()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGameTimePlayedString, "Engine.GameInfo.GetGameTimePlayedString");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGameTimePlayed;
    /// <summary>
    /// Function: GetGameTimePlayed
    /// </summary>
    public unsafe virtual float GetGameTimePlayed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGameTimePlayed, "Engine.GameInfo.GetGameTimePlayed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TellClientsToTravelToSession;
    /// <summary>
    /// Function: TellClientsToTravelToSession
    /// </summary>
    public unsafe virtual void TellClientsToTravelToSession(BmSDK.FName SessionName, BmSDK.Class SearchClass, byte PlatformSpecificInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TellClientsToTravelToSession, "Engine.GameInfo.TellClientsToTravelToSession");
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchClass, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformSpecificInfo, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TellClientsPartyHostIsLeaving;
    /// <summary>
    /// Function: TellClientsPartyHostIsLeaving
    /// </summary>
    public unsafe virtual void TellClientsPartyHostIsLeaving(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PartyHostPlayerId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TellClientsPartyHostIsLeaving, "Engine.GameInfo.TellClientsPartyHostIsLeaving");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartyHostPlayerId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnServerCreateComplete;
    /// <summary>
    /// Function: OnServerCreateComplete
    /// </summary>
    public unsafe virtual void OnServerCreateComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnServerCreateComplete, "Engine.GameInfo.OnServerCreateComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterServer;
    /// <summary>
    /// Function: RegisterServer
    /// </summary>
    public unsafe virtual void RegisterServer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterServer, "Engine.GameInfo.RegisterServer");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoginChange;
    /// <summary>
    /// Function: OnLoginChange
    /// </summary>
    public unsafe virtual void OnLoginChange(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoginChange, "Engine.GameInfo.OnLoginChange");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoginFailed;
    /// <summary>
    /// Function: OnLoginFailed
    /// </summary>
    public unsafe virtual void OnLoginFailed(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineServerConnectionStatus ErrorCode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoginFailed, "Engine.GameInfo.OnLoginFailed");
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ErrorCode, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearAutoLoginDelegates;
    /// <summary>
    /// Function: ClearAutoLoginDelegates
    /// </summary>
    public unsafe virtual void ClearAutoLoginDelegates()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAutoLoginDelegates, "Engine.GameInfo.ClearAutoLoginDelegates");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessServerLogin;
    /// <summary>
    /// Function: ProcessServerLogin
    /// </summary>
    public unsafe virtual bool ProcessServerLogin()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessServerLogin, "Engine.GameInfo.ProcessServerLogin");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MatineeCancelled;
    /// <summary>
    /// Function: MatineeCancelled
    /// </summary>
    public unsafe virtual void MatineeCancelled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatineeCancelled, "Engine.GameInfo.MatineeCancelled");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RecalculateSkillRating;
    /// <summary>
    /// Function: RecalculateSkillRating
    /// </summary>
    public unsafe virtual void RecalculateSkillRating()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecalculateSkillRating, "Engine.GameInfo.RecalculateSkillRating");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGameplayMuteList;
    /// <summary>
    /// Function: UpdateGameplayMuteList
    /// </summary>
    public unsafe virtual void UpdateGameplayMuteList(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGameplayMuteList, "Engine.GameInfo.UpdateGameplayMuteList");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyArbitratedMatchEnd;
    /// <summary>
    /// Function: NotifyArbitratedMatchEnd
    /// </summary>
    public unsafe virtual void NotifyArbitratedMatchEnd()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyArbitratedMatchEnd, "Engine.GameInfo.NotifyArbitratedMatchEnd");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MatchIsInProgress;
    /// <summary>
    /// Function: MatchIsInProgress
    /// </summary>
    public unsafe virtual bool MatchIsInProgress()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatchIsInProgress, "Engine.GameInfo.MatchIsInProgress");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ArbitrationRegistrationComplete;
    /// <summary>
    /// Function: ArbitrationRegistrationComplete
    /// </summary>
    public unsafe virtual void ArbitrationRegistrationComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ArbitrationRegistrationComplete, "Engine.GameInfo.ArbitrationRegistrationComplete");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterServerForArbitration;
    /// <summary>
    /// Function: RegisterServerForArbitration
    /// </summary>
    public unsafe virtual void RegisterServerForArbitration()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterServerForArbitration, "Engine.GameInfo.RegisterServerForArbitration");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartArbitratedMatch;
    /// <summary>
    /// Function: StartArbitratedMatch
    /// </summary>
    public unsafe virtual void StartArbitratedMatch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartArbitratedMatch, "Engine.GameInfo.StartArbitratedMatch");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartArbitrationRegistration;
    /// <summary>
    /// Function: StartArbitrationRegistration
    /// </summary>
    public unsafe virtual void StartArbitrationRegistration()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartArbitrationRegistration, "Engine.GameInfo.StartArbitrationRegistration");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessClientRegistrationCompletion;
    /// <summary>
    /// Function: ProcessClientRegistrationCompletion
    /// </summary>
    public unsafe virtual void ProcessClientRegistrationCompletion(BmSDK.Engine.PlayerController PC, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessClientRegistrationCompletion, "Engine.GameInfo.ProcessClientRegistrationCompletion");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGameSettingsCounts;
    /// <summary>
    /// Function: UpdateGameSettingsCounts
    /// </summary>
    public unsafe virtual void UpdateGameSettingsCounts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGameSettingsCounts, "Engine.GameInfo.UpdateGameSettingsCounts");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSeamlessTravelViewTarget;
    /// <summary>
    /// Function: SetSeamlessTravelViewTarget
    /// </summary>
    public unsafe virtual void SetSeamlessTravelViewTarget(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSeamlessTravelViewTarget, "Engine.GameInfo.SetSeamlessTravelViewTarget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleSeamlessTravelPlayer;
    /// <summary>
    /// Function: HandleSeamlessTravelPlayer
    /// </summary>
    public unsafe virtual void HandleSeamlessTravelPlayer(out BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleSeamlessTravelPlayer, "Engine.GameInfo.HandleSeamlessTravelPlayer");
        byte* paramsPtr = stackalloc byte[52];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out C);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        C = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Controller>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGameSettings;
    /// <summary>
    /// Function: UpdateGameSettings
    /// </summary>
    public unsafe virtual void UpdateGameSettings()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGameSettings, "Engine.GameInfo.UpdateGameSettings");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostSeamlessTravel;
    /// <summary>
    /// Function: PostSeamlessTravel
    /// </summary>
    public unsafe virtual void PostSeamlessTravel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostSeamlessTravel, "Engine.GameInfo.PostSeamlessTravel");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwapPlayerControllers;
    /// <summary>
    /// Function: SwapPlayerControllers
    /// </summary>
    public unsafe virtual void SwapPlayerControllers(BmSDK.Engine.PlayerController OldPC, BmSDK.Engine.PlayerController NewPC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwapPlayerControllers, "Engine.GameInfo.SwapPlayerControllers");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPC, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetSeamlessTravelActorList;
    /// <summary>
    /// Function: GetSeamlessTravelActorList
    /// </summary>
    public unsafe virtual void GetSeamlessTravelActorList(bool bToEntry, out BmSDK.TArray<BmSDK.Engine.Actor> ActorList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSeamlessTravelActorList, "Engine.GameInfo.GetSeamlessTravelActorList");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bToEntry, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ActorList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_OverridePRI;
    /// <summary>
    /// Function: OverridePRI
    /// </summary>
    public unsafe virtual void OverridePRI(BmSDK.Engine.PlayerController PC, BmSDK.Engine.PlayerReplicationInfo OldPRI)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverridePRI, "Engine.GameInfo.OverridePRI");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldPRI, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindInactivePRI;
    /// <summary>
    /// Function: FindInactivePRI
    /// </summary>
    public unsafe virtual bool FindInactivePRI(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindInactivePRI, "Engine.GameInfo.FindInactivePRI");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AddInactivePRI;
    /// <summary>
    /// Function: AddInactivePRI
    /// </summary>
    public unsafe virtual void AddInactivePRI(BmSDK.Engine.PlayerReplicationInfo PRI, BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddInactivePRI, "Engine.GameInfo.AddInactivePRI");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PRI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostCommitMapChange;
    /// <summary>
    /// Function: PostCommitMapChange
    /// </summary>
    public unsafe virtual void PostCommitMapChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostCommitMapChange, "Engine.GameInfo.PostCommitMapChange");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreCommitMapChange;
    /// <summary>
    /// Function: PreCommitMapChange
    /// </summary>
    public unsafe virtual void PreCommitMapChange(BmSDK.FString PreviousMapName, BmSDK.FString NextMapName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreCommitMapChange, "Engine.GameInfo.PreCommitMapChange");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousMapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextMapName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowPausing;
    /// <summary>
    /// Function: AllowPausing
    /// </summary>
    public unsafe virtual bool AllowPausing(BmSDK.Engine.PlayerController PC = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowPausing, "Engine.GameInfo.AllowPausing");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AllowCheats;
    /// <summary>
    /// Function: AllowCheats
    /// </summary>
    public unsafe virtual bool AllowCheats(BmSDK.Engine.PlayerController P)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowCheats, "Engine.GameInfo.AllowCheats");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AllowMutator;
    /// <summary>
    /// Function: AllowMutator
    /// </summary>
    public unsafe static bool AllowMutator(BmSDK.FString MutatorClassName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowMutator, "Engine.GameInfo.AllowMutator");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MutatorClassName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_PlayerCanRestart;
    /// <summary>
    /// Function: PlayerCanRestart
    /// </summary>
    public unsafe virtual bool PlayerCanRestart(BmSDK.Engine.PlayerController aPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerCanRestart, "Engine.GameInfo.PlayerCanRestart");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PlayerCanRestartGame;
    /// <summary>
    /// Function: PlayerCanRestartGame
    /// </summary>
    public unsafe virtual bool PlayerCanRestartGame(BmSDK.Engine.PlayerController aPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerCanRestartGame, "Engine.GameInfo.PlayerCanRestartGame");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DriverLeftVehicle;
    /// <summary>
    /// Function: DriverLeftVehicle
    /// </summary>
    public unsafe virtual void DriverLeftVehicle(BmSDK.Engine.Vehicle V, BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DriverLeftVehicle, "Engine.GameInfo.DriverLeftVehicle");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanLeaveVehicle;
    /// <summary>
    /// Function: CanLeaveVehicle
    /// </summary>
    public unsafe virtual bool CanLeaveVehicle(BmSDK.Engine.Vehicle V, BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanLeaveVehicle, "Engine.GameInfo.CanLeaveVehicle");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_DriverEnteredVehicle;
    /// <summary>
    /// Function: DriverEnteredVehicle
    /// </summary>
    public unsafe virtual void DriverEnteredVehicle(BmSDK.Engine.Vehicle V, BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DriverEnteredVehicle, "Engine.GameInfo.DriverEnteredVehicle");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ModifyScoreKill;
    /// <summary>
    /// Function: ModifyScoreKill
    /// </summary>
    public unsafe virtual void ModifyScoreKill(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyScoreKill, "Engine.GameInfo.ModifyScoreKill");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScoreKill;
    /// <summary>
    /// Function: ScoreKill
    /// </summary>
    public unsafe virtual void ScoreKill(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScoreKill, "Engine.GameInfo.ScoreKill");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckScore;
    /// <summary>
    /// Function: CheckScore
    /// </summary>
    public unsafe virtual bool CheckScore(BmSDK.Engine.PlayerReplicationInfo Scorer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckScore, "Engine.GameInfo.CheckScore");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scorer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ScoreObjective;
    /// <summary>
    /// Function: ScoreObjective
    /// </summary>
    public unsafe virtual void ScoreObjective(BmSDK.Engine.PlayerReplicationInfo Scorer, int Score)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScoreObjective, "Engine.GameInfo.ScoreObjective");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scorer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddObjectiveScore;
    /// <summary>
    /// Function: AddObjectiveScore
    /// </summary>
    public unsafe virtual void AddObjectiveScore(BmSDK.Engine.PlayerReplicationInfo Scorer, int Score)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddObjectiveScore, "Engine.GameInfo.AddObjectiveScore");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scorer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RatePlayerStart;
    /// <summary>
    /// Function: RatePlayerStart
    /// </summary>
    public unsafe virtual float RatePlayerStart(BmSDK.Engine.PlayerStart P, byte Team, BmSDK.Engine.Controller Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RatePlayerStart, "Engine.GameInfo.RatePlayerStart");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ChoosePlayerStart;
    /// <summary>
    /// Function: ChoosePlayerStart
    /// </summary>
    public unsafe virtual BmSDK.Engine.PlayerStart ChoosePlayerStart(BmSDK.Engine.Controller Player, byte InTeam = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChoosePlayerStart, "Engine.GameInfo.ChoosePlayerStart");
        byte* paramsPtr = stackalloc byte[45];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTeam, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerStart>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_FindPlayerStart;
    /// <summary>
    /// Function: FindPlayerStart
    /// </summary>
    public unsafe virtual BmSDK.Engine.NavigationPoint FindPlayerStart(BmSDK.Engine.Controller Player, byte InTeam = default, BmSDK.FString IncomingName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPlayerStart, "Engine.GameInfo.FindPlayerStart");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTeam, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncomingName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavigationPoint>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ShouldSpawnAtStartSpot;
    /// <summary>
    /// Function: ShouldSpawnAtStartSpot
    /// </summary>
    public unsafe virtual bool ShouldSpawnAtStartSpot(BmSDK.Engine.Controller Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSpawnAtStartSpot, "Engine.GameInfo.ShouldSpawnAtStartSpot");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_EndLogging;
    /// <summary>
    /// Function: EndLogging
    /// </summary>
    public unsafe virtual void EndLogging(BmSDK.FString Reason)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndLogging, "Engine.GameInfo.EndLogging");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GameEventsPoll;
    /// <summary>
    /// Function: GameEventsPoll
    /// </summary>
    public unsafe virtual void GameEventsPoll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GameEventsPoll, "Engine.GameInfo.GameEventsPoll");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndOnlineGame;
    /// <summary>
    /// Function: EndOnlineGame
    /// </summary>
    public unsafe virtual void EndOnlineGame()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndOnlineGame, "Engine.GameInfo.EndOnlineGame");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PerformEndGameHandling;
    /// <summary>
    /// Function: PerformEndGameHandling
    /// </summary>
    public unsafe virtual void PerformEndGameHandling()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PerformEndGameHandling, "Engine.GameInfo.PerformEndGameHandling");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndGame;
    /// <summary>
    /// Function: EndGame
    /// </summary>
    public unsafe virtual void EndGame(BmSDK.Engine.PlayerReplicationInfo Winner, BmSDK.FString Reason)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndGame, "Engine.GameInfo.EndGame");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WriteOnlinePlayerScores;
    /// <summary>
    /// Function: WriteOnlinePlayerScores
    /// </summary>
    public unsafe virtual void WriteOnlinePlayerScores()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteOnlinePlayerScores, "Engine.GameInfo.WriteOnlinePlayerScores");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WriteOnlineStats;
    /// <summary>
    /// Function: WriteOnlineStats
    /// </summary>
    public unsafe virtual void WriteOnlineStats()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteOnlineStats, "Engine.GameInfo.WriteOnlineStats");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckEndGame;
    /// <summary>
    /// Function: CheckEndGame
    /// </summary>
    public unsafe virtual bool CheckEndGame(BmSDK.Engine.PlayerReplicationInfo Winner, BmSDK.FString Reason)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckEndGame, "Engine.GameInfo.CheckEndGame");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CheckModifiedEndGame;
    /// <summary>
    /// Function: CheckModifiedEndGame
    /// </summary>
    public unsafe virtual bool CheckModifiedEndGame(BmSDK.Engine.PlayerReplicationInfo Winner, BmSDK.FString Reason)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckModifiedEndGame, "Engine.GameInfo.CheckModifiedEndGame");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_RestartGame;
    /// <summary>
    /// Function: RestartGame
    /// </summary>
    public unsafe virtual void RestartGame()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestartGame, "Engine.GameInfo.RestartGame");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTravelType;
    /// <summary>
    /// Function: GetTravelType
    /// </summary>
    public unsafe virtual bool GetTravelType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTravelType, "Engine.GameInfo.GetTravelType");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNextMap;
    /// <summary>
    /// Function: GetNextMap
    /// </summary>
    public unsafe virtual BmSDK.FString GetNextMap()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextMap, "Engine.GameInfo.GetNextMap");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SendPlayer;
    /// <summary>
    /// Function: SendPlayer
    /// </summary>
    public unsafe virtual void SendPlayer(BmSDK.Engine.PlayerController aPlayer, BmSDK.FString URL)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendPlayer, "Engine.GameInfo.SendPlayer");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(URL, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PickTeam;
    /// <summary>
    /// Function: PickTeam
    /// </summary>
    public unsafe virtual byte PickTeam(byte Current, BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickTeam, "Engine.GameInfo.PickTeam");
        byte* paramsPtr = stackalloc byte[13];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ChangeTeam;
    /// <summary>
    /// Function: ChangeTeam
    /// </summary>
    public unsafe virtual bool ChangeTeam(BmSDK.Engine.Controller Other, int N, bool bNewTeam)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeTeam, "Engine.GameInfo.ChangeTeam");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(N, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewTeam, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ChangeName;
    /// <summary>
    /// Function: ChangeName
    /// </summary>
    public unsafe virtual void ChangeName(BmSDK.Engine.Controller Other, BmSDK.FString S, bool bNameChange)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeName, "Engine.GameInfo.ChangeName");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(S, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNameChange, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DiscardInventory;
    /// <summary>
    /// Function: DiscardInventory
    /// </summary>
    public unsafe virtual void DiscardInventory(BmSDK.Engine.Pawn Other, BmSDK.Engine.Controller Killer = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DiscardInventory, "Engine.GameInfo.DiscardInventory");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PickupQuery;
    /// <summary>
    /// Function: PickupQuery
    /// </summary>
    public unsafe virtual bool PickupQuery(BmSDK.Engine.Pawn Other, BmSDK.Class ItemClass, BmSDK.Engine.Actor Pickup)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickupQuery, "Engine.GameInfo.PickupQuery");
        byte* paramsPtr = stackalloc byte[29];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemClass, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pickup, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ShouldRespawn;
    /// <summary>
    /// Function: ShouldRespawn
    /// </summary>
    public unsafe virtual bool ShouldRespawn(BmSDK.Engine.PickupFactory Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldRespawn, "Engine.GameInfo.ShouldRespawn");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CheckRelevance;
    /// <summary>
    /// Function: CheckRelevance
    /// </summary>
    public unsafe virtual bool CheckRelevance(BmSDK.Engine.Actor Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckRelevance, "Engine.GameInfo.CheckRelevance");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ReduceDamage;
    /// <summary>
    /// Function: ReduceDamage
    /// </summary>
    public unsafe virtual void ReduceDamage(out int Damage, BmSDK.Engine.Pawn injured, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor DamageCauser)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReduceDamage, "Engine.GameInfo.ReduceDamage");
        byte* paramsPtr = stackalloc byte[64];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Damage);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(injured, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Momentum);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Damage = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        Momentum = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 32);
        return;
    }

    private static BmSDK.Function __fn_CanSpectate;
    /// <summary>
    /// Function: CanSpectate
    /// </summary>
    public unsafe virtual bool CanSpectate(BmSDK.Engine.PlayerController Viewer, BmSDK.Engine.PlayerReplicationInfo ViewTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSpectate, "Engine.GameInfo.CanSpectate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Viewer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewTarget, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_KickBan;
    /// <summary>
    /// Function: KickBan
    /// </summary>
    public unsafe virtual void KickBan(BmSDK.FString S)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KickBan, "Engine.GameInfo.KickBan");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(S, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Kick;
    /// <summary>
    /// Function: Kick
    /// </summary>
    public unsafe virtual void Kick(BmSDK.FString S)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Kick, "Engine.GameInfo.Kick");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(S, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreventDeath;
    /// <summary>
    /// Function: PreventDeath
    /// </summary>
    public unsafe virtual bool PreventDeath(BmSDK.Engine.Pawn KilledPawn, BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreventDeath, "Engine.GameInfo.PreventDeath");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_Killed;
    /// <summary>
    /// Function: Killed
    /// </summary>
    public unsafe virtual void Killed(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller KilledPlayer, BmSDK.Engine.Pawn KilledPawn, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Killed, "Engine.GameInfo.Killed");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyKilled;
    /// <summary>
    /// Function: NotifyKilled
    /// </summary>
    public unsafe virtual void NotifyKilled(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller Killed, BmSDK.Engine.Pawn KilledPawn, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyKilled, "Engine.GameInfo.NotifyKilled");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPlayerDefaults;
    /// <summary>
    /// Function: SetPlayerDefaults
    /// </summary>
    public unsafe virtual void SetPlayerDefaults(BmSDK.Engine.Pawn PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerDefaults, "Engine.GameInfo.SetPlayerDefaults");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Mutate;
    /// <summary>
    /// Function: Mutate
    /// </summary>
    public unsafe virtual void Mutate(BmSDK.FString MutateString, BmSDK.Engine.PlayerController Sender)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Mutate, "Engine.GameInfo.Mutate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MutateString, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Sender, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDefaultInventory;
    /// <summary>
    /// Function: AddDefaultInventory
    /// </summary>
    public unsafe virtual void AddDefaultInventory(BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDefaultInventory, "Engine.GameInfo.AddDefaultInventory");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AcceptInventory;
    /// <summary>
    /// Function: AcceptInventory
    /// </summary>
    public unsafe virtual void AcceptInventory(BmSDK.Engine.Pawn PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AcceptInventory, "Engine.GameInfo.AcceptInventory");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnregisterPlayer;
    /// <summary>
    /// Function: UnregisterPlayer
    /// </summary>
    public unsafe virtual void UnregisterPlayer(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterPlayer, "Engine.GameInfo.UnregisterPlayer");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Logout;
    /// <summary>
    /// Function: Logout
    /// </summary>
    public unsafe virtual void Logout(BmSDK.Engine.Controller Exiting)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Logout, "Engine.GameInfo.Logout");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Exiting, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreExit;
    /// <summary>
    /// Function: PreExit
    /// </summary>
    public unsafe virtual void PreExit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreExit, "Engine.GameInfo.PreExit");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalculatedNetSpeed;
    /// <summary>
    /// Function: CalculatedNetSpeed
    /// </summary>
    public unsafe virtual int CalculatedNetSpeed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculatedNetSpeed, "Engine.GameInfo.CalculatedNetSpeed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateNetSpeeds;
    /// <summary>
    /// Function: UpdateNetSpeeds
    /// </summary>
    public unsafe virtual void UpdateNetSpeeds()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateNetSpeeds, "Engine.GameInfo.UpdateNetSpeeds");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostLogin;
    /// <summary>
    /// Function: PostLogin
    /// </summary>
    public unsafe virtual void PostLogin(BmSDK.Engine.PlayerController NewPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostLogin, "Engine.GameInfo.PostLogin");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GenericPlayerInitialization;
    /// <summary>
    /// Function: GenericPlayerInitialization
    /// </summary>
    public unsafe virtual void GenericPlayerInitialization(BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GenericPlayerInitialization, "Engine.GameInfo.GenericPlayerInitialization");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReplicateStreamingStatus;
    /// <summary>
    /// Function: ReplicateStreamingStatus
    /// </summary>
    public unsafe virtual void ReplicateStreamingStatus(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicateStreamingStatus, "Engine.GameInfo.ReplicateStreamingStatus");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDefaultPlayerClass;
    /// <summary>
    /// Function: GetDefaultPlayerClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetDefaultPlayerClass(BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultPlayerClass, "Engine.GameInfo.GetDefaultPlayerClass");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SpawnDefaultPawnFor;
    /// <summary>
    /// Function: SpawnDefaultPawnFor
    /// </summary>
    public unsafe virtual BmSDK.Engine.Pawn SpawnDefaultPawnFor(BmSDK.Engine.Controller NewPlayer, BmSDK.Engine.NavigationPoint StartSpot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDefaultPawnFor, "Engine.GameInfo.SpawnDefaultPawnFor");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartSpot, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_RestartPlayer;
    /// <summary>
    /// Function: RestartPlayer
    /// </summary>
    public unsafe virtual void RestartPlayer(BmSDK.Engine.Controller NewPlayer, bool bForPlayerSwitch = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestartPlayer, "Engine.GameInfo.RestartPlayer");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForPlayerSwitch, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartBots;
    /// <summary>
    /// Function: StartBots
    /// </summary>
    public unsafe virtual void StartBots()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartBots, "Engine.GameInfo.StartBots");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartHumans;
    /// <summary>
    /// Function: StartHumans
    /// </summary>
    public unsafe virtual void StartHumans()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartHumans, "Engine.GameInfo.StartHumans");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnStartOnlineGameComplete;
    /// <summary>
    /// Function: OnStartOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnStartOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnStartOnlineGameComplete, "Engine.GameInfo.OnStartOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartOnlineGame;
    /// <summary>
    /// Function: StartOnlineGame
    /// </summary>
    public unsafe virtual void StartOnlineGame()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartOnlineGame, "Engine.GameInfo.StartOnlineGame");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartMatch;
    /// <summary>
    /// Function: StartMatch
    /// </summary>
    public unsafe virtual void StartMatch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartMatch, "Engine.GameInfo.StartMatch");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Login;
    /// <summary>
    /// Function: Login
    /// </summary>
    public unsafe virtual BmSDK.Engine.PlayerController Login(BmSDK.FString Portal, BmSDK.FString Options, BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId, out BmSDK.FString ErrorMessage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Login, "Engine.GameInfo.Login");
        byte* paramsPtr = stackalloc byte[164];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Portal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ErrorMessage = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(paramsPtr + 56);
    }

    private static BmSDK.Function __fn_SpawnPlayerController;
    /// <summary>
    /// Function: SpawnPlayerController
    /// </summary>
    public unsafe virtual BmSDK.Engine.PlayerController SpawnPlayerController(System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnPlayerController, "Engine.GameInfo.SpawnPlayerController");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetNextPlayerID;
    /// <summary>
    /// Function: GetNextPlayerID
    /// </summary>
    public unsafe virtual int GetNextPlayerID()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextPlayerID, "Engine.GameInfo.GetNextPlayerID");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AtCapacity;
    /// <summary>
    /// Function: AtCapacity
    /// </summary>
    public unsafe virtual bool AtCapacity(bool bSpectator)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AtCapacity, "Engine.GameInfo.AtCapacity");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpectator, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RejectLogin;
    /// <summary>
    /// Function: RejectLogin
    /// </summary>
    public unsafe static void RejectLogin(BmSDK.Engine.Player InPlayer, BmSDK.FString Error)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RejectLogin, "Engine.GameInfo.RejectLogin");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Error, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_ResumeLogin;
    /// <summary>
    /// Function: ResumeLogin
    /// </summary>
    public unsafe static void ResumeLogin(BmSDK.Engine.Player InPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResumeLogin, "Engine.GameInfo.ResumeLogin");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPlayer, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_PauseLogin;
    /// <summary>
    /// Function: PauseLogin
    /// </summary>
    public unsafe static BmSDK.Engine.Player PauseLogin()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PauseLogin, "Engine.GameInfo.PauseLogin");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Player>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PreLogin;
    /// <summary>
    /// Function: PreLogin
    /// </summary>
    public unsafe virtual void PreLogin(BmSDK.FString Options, BmSDK.FString Address, BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId, bool bSupportsAuth, out BmSDK.FString ErrorMessage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreLogin, "Engine.GameInfo.PreLogin");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Address, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSupportsAuth, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ErrorMessage = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 44);
        return;
    }

    private static BmSDK.Function __fn_RequiresPassword;
    /// <summary>
    /// Function: RequiresPassword
    /// </summary>
    public unsafe virtual bool RequiresPassword()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequiresPassword, "Engine.GameInfo.RequiresPassword");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ProcessClientTravel;
    /// <summary>
    /// Function: ProcessClientTravel
    /// </summary>
    public unsafe virtual BmSDK.Engine.PlayerController ProcessClientTravel(out BmSDK.FString URL, BmSDK.GameObject.FGuid NextMapGuid, bool bSeamless, bool bAbsolute)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessClientTravel, "Engine.GameInfo.ProcessClientTravel");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextMapGuid, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSeamless, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAbsolute, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        URL = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_ProcessServerTravel;
    /// <summary>
    /// Function: ProcessServerTravel
    /// </summary>
    public unsafe virtual void ProcessServerTravel(BmSDK.FString URL, bool bAbsolute = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessServerTravel, "Engine.GameInfo.ProcessServerTravel");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(URL, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAbsolute, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveMutator;
    /// <summary>
    /// Function: RemoveMutator
    /// </summary>
    public unsafe virtual void RemoveMutator(BmSDK.Engine.Mutator MutatorToRemove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveMutator, "Engine.GameInfo.RemoveMutator");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MutatorToRemove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddMutator;
    /// <summary>
    /// Function: AddMutator
    /// </summary>
    public unsafe virtual void AddMutator(BmSDK.FString mutname, bool bUserAdded = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddMutator, "Engine.GameInfo.AddMutator");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mutname, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUserAdded, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPendingConnectionLost;
    /// <summary>
    /// Function: NotifyPendingConnectionLost
    /// </summary>
    public unsafe virtual void NotifyPendingConnectionLost()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPendingConnectionLost, "Engine.GameInfo.NotifyPendingConnectionLost");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitGame;
    /// <summary>
    /// Function: InitGame
    /// </summary>
    public unsafe virtual void InitGame(BmSDK.FString Options, out BmSDK.FString ErrorMessage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitGame, "Engine.GameInfo.InitGame");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ErrorMessage = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_SetGameType;
    /// <summary>
    /// Function: SetGameType
    /// </summary>
    public unsafe static BmSDK.Class SetGameType(BmSDK.FString MapName, BmSDK.FString Options, BmSDK.FString Portal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGameType, "Engine.GameInfo.SetGameType");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Portal, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_GetDefaultGameClassPath;
    /// <summary>
    /// Function: GetDefaultGameClassPath
    /// </summary>
    public unsafe static BmSDK.FString GetDefaultGameClassPath(BmSDK.FString MapName, BmSDK.FString Options, BmSDK.FString Portal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultGameClassPath, "Engine.GameInfo.GetDefaultGameClassPath");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Portal, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_GetIntOption;
    /// <summary>
    /// Function: GetIntOption
    /// </summary>
    public unsafe static int GetIntOption(BmSDK.FString Options, BmSDK.FString ParseString, int CurrentValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIntOption, "Engine.GameInfo.GetIntOption");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParseString, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentValue, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_HasOption;
    /// <summary>
    /// Function: HasOption
    /// </summary>
    public unsafe static bool HasOption(BmSDK.FString Options, BmSDK.FString InKey)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasOption, "Engine.GameInfo.HasOption");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_ParseOption;
    /// <summary>
    /// Function: ParseOption
    /// </summary>
    public unsafe static BmSDK.FString ParseOption(BmSDK.FString Options, BmSDK.FString InKey)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ParseOption, "Engine.GameInfo.ParseOption");
        byte* paramsPtr = stackalloc byte[96];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetKeyValue;
    /// <summary>
    /// Function: GetKeyValue
    /// </summary>
    public unsafe static void GetKeyValue(BmSDK.FString Pair, out BmSDK.FString Key, out BmSDK.FString Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetKeyValue, "Engine.GameInfo.GetKeyValue");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pair, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Key = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
        Value = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 32);
        return;
    }

    private static BmSDK.Function __fn_GrabOption;
    /// <summary>
    /// Function: GrabOption
    /// </summary>
    public unsafe static bool GrabOption(out BmSDK.FString Options, out BmSDK.FString Result)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrabOption, "Engine.GameInfo.GrabOption");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Options = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
        Result = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_SetGameSpeed;
    /// <summary>
    /// Function: SetGameSpeed
    /// </summary>
    public unsafe virtual void SetGameSpeed(float T)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGameSpeed, "Engine.GameInfo.SetGameSpeed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugPause;
    /// <summary>
    /// Function: DebugPause
    /// </summary>
    public unsafe virtual void DebugPause()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugPause, "Engine.GameInfo.DebugPause");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceClearUnpauseDelegates;
    /// <summary>
    /// Function: ForceClearUnpauseDelegates
    /// </summary>
    public unsafe virtual void ForceClearUnpauseDelegates(BmSDK.Engine.Actor PauseActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceClearUnpauseDelegates, "Engine.GameInfo.ForceClearUnpauseDelegates");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PauseActor, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearPause;
    /// <summary>
    /// Function: ClearPause
    /// </summary>
    public unsafe virtual void ClearPause()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPause, "Engine.GameInfo.ClearPause");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPause;
    /// <summary>
    /// Function: SetPause
    /// </summary>
    public unsafe virtual bool SetPause(BmSDK.Engine.PlayerController PC, System.IntPtr CanUnpauseDelegate = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPause, "Engine.GameInfo.SetPause");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanUnpauseDelegate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CanUnpause;
    /// <summary>
    /// Function: CanUnpause
    /// </summary>
    public unsafe virtual bool CanUnpause()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUnpause, "Engine.GameInfo.CanUnpause");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumPlayers;
    /// <summary>
    /// Function: GetNumPlayers
    /// </summary>
    public unsafe virtual int GetNumPlayers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumPlayers, "Engine.GameInfo.GetNumPlayers");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNetworkNumber;
    /// <summary>
    /// Function: GetNetworkNumber
    /// </summary>
    public unsafe virtual BmSDK.FString GetNetworkNumber()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNetworkNumber, "Engine.GameInfo.GetNetworkNumber");
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

    private static BmSDK.Function __fn_InitGameReplicationInfo;
    /// <summary>
    /// Function: InitGameReplicationInfo
    /// </summary>
    public unsafe virtual void InitGameReplicationInfo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitGameReplicationInfo, "Engine.GameInfo.InitGameReplicationInfo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceKickPlayer;
    /// <summary>
    /// Function: ForceKickPlayer
    /// </summary>
    public unsafe virtual void ForceKickPlayer(BmSDK.Engine.PlayerController PC, BmSDK.FString KickReason)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceKickPlayer, "Engine.GameInfo.ForceKickPlayer");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KickReason, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KickIdler;
    /// <summary>
    /// Function: KickIdler
    /// </summary>
    public unsafe virtual void KickIdler(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KickIdler, "Engine.GameInfo.KickIdler");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GameEnding;
    /// <summary>
    /// Function: GameEnding
    /// </summary>
    public unsafe virtual void GameEnding()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GameEnding, "Engine.GameInfo.GameEnding");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyNavigationChanged;
    /// <summary>
    /// Function: NotifyNavigationChanged
    /// </summary>
    public unsafe virtual void NotifyNavigationChanged(BmSDK.Engine.NavigationPoint N)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyNavigationChanged, "Engine.GameInfo.NotifyNavigationChanged");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(N, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoNavFearCostFallOff;
    /// <summary>
    /// Function: DoNavFearCostFallOff
    /// </summary>
    public unsafe virtual void DoNavFearCostFallOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoNavFearCostFallOff, "Engine.GameInfo.DoNavFearCostFallOff");
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

    private static BmSDK.Function __fn_ShouldStartInCinematicMode;
    /// <summary>
    /// Function: ShouldStartInCinematicMode
    /// </summary>
    public unsafe virtual bool ShouldStartInCinematicMode(out int OutHidePlayer, out int OutHideHud, out int OutDisableMovement, out int OutDisableTurning, out int OutDisableInput)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldStartInCinematicMode, "Engine.GameInfo.ShouldStartInCinematicMode");
        byte* paramsPtr = stackalloc byte[24];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutHidePlayer);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutHidePlayer, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutHideHud);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutHideHud, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutDisableMovement);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutDisableMovement, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutDisableTurning);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutDisableTurning, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutDisableInput);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutDisableInput, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutHidePlayer = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        OutHideHud = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        OutDisableMovement = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        OutDisableTurning = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
        OutDisableInput = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ResetLevel;
    /// <summary>
    /// Function: ResetLevel
    /// </summary>
    public unsafe virtual void ResetLevel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetLevel, "Engine.GameInfo.ResetLevel");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldReset;
    /// <summary>
    /// Function: ShouldReset
    /// </summary>
    public unsafe virtual bool ShouldReset(BmSDK.Engine.Actor ActorToReset)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldReset, "Engine.GameInfo.ShouldReset");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorToReset, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_Reset;
    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe override void Reset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reset, "Engine.GameInfo.Reset");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayDebug;
    /// <summary>
    /// Function: DisplayDebug
    /// </summary>
    public unsafe override void DisplayDebug(BmSDK.Engine.HUD HUD, out float out_YL, out float out_YPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayDebug, "Engine.GameInfo.DisplayDebug");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HUD, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_YL);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_YL, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_YPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_YPos, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_YL = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
        out_YPos = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "Engine.GameInfo.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreBeginPlay;
    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe override void PreBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreBeginPlay, "Engine.GameInfo.PreBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMapCommonPackageName;
    /// <summary>
    /// Function: GetMapCommonPackageName
    /// </summary>
    public unsafe virtual bool GetMapCommonPackageName(out BmSDK.FString InFilename, out BmSDK.FString OutCommonPackageName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMapCommonPackageName, "Engine.GameInfo.GetMapCommonPackageName");
        byte* paramsPtr = stackalloc byte[36];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        InFilename = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
        OutCommonPackageName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetSupportedGameTypes;
    /// <summary>
    /// Function: GetSupportedGameTypes
    /// </summary>
    public unsafe virtual bool GetSupportedGameTypes(out BmSDK.FString InFilename, out BmSDK.Engine.GameInfo.FGameTypePrefix OutGameType, bool bCheckExt = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSupportedGameTypes, "Engine.GameInfo.GetSupportedGameTypes");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckExt, paramsPtr + 84);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        InFilename = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
        OutGameType = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameInfo.FGameTypePrefix>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 88);
    }

    /// <summary>
    /// Struct: FGameTypePrefix
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial record struct FGameTypePrefix
    {
        /// <summary>
        /// StrProperty: Prefix
        /// </summary>
        public unsafe BmSDK.FString Prefix
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bUsesCommonPackage
        /// </summary>
        public unsafe bool bUsesCommonPackage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: GameType
        /// </summary>
        public unsafe BmSDK.FString GameType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ArrayProperty: AdditionalGameTypes
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> AdditionalGameTypes
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ArrayProperty: ForcedObjects
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> ForcedObjects
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }
    }

    /// <summary>
    /// Struct: FGameClassShortName
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FGameClassShortName
    {
        /// <summary>
        /// StrProperty: ShortName
        /// </summary>
        public unsafe BmSDK.FString ShortName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: GameClassName
        /// </summary>
        public unsafe BmSDK.FString GameClassName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Enum: EStandbyType
    /// </summary>
    public enum EStandbyType : byte
    {
        STDBY_Rx = 0,
        STDBY_Tx = 1,
        STDBY_BadPing = 2,
        STDBY_MAX = 3,
    }

    /// <summary>
    /// StructProperty: Map3DRenderingData
    /// </summary>
    public unsafe ref BmSDK.Engine.GameInfo.FRMap3DRenderingData Map3DRenderingData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.GameInfo.FRMap3DRenderingData>(Ptr + 672);

    /// <summary>
    /// StructProperty: PCColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor PCColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 768);

    /// <summary>
    /// StructProperty: PCLineColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor PCLineColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 784);

    /// <summary>
    /// StructProperty: PCAmbientCol
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor PCAmbientCol
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 800);

    /// <summary>
    /// StructProperty: PCRadialFadeColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor PCRadialFadeColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 816);

    /// <summary>
    /// StructProperty: PCSonarPlayerColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor PCSonarPlayerColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 832);

    /// <summary>
    /// StructProperty: PCSonarWaypointColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor PCSonarWaypointColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 848);

    /// <summary>
    /// StructProperty: PCHL_Building
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor PCHL_Building
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 864);

    /// <summary>
    /// StructProperty: PCHL_FireCrew
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor PCHL_FireCrew
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 880);

    /// <summary>
    /// StructProperty: PCHL_ManBat
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor PCHL_ManBat
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 896);

    /// <summary>
    /// StructProperty: PCHL_Azrael
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor PCHL_Azrael
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 912);

    /// <summary>
    /// StructProperty: PCHL_PygVictim
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor PCHL_PygVictim
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 928);

    /// <summary>
    /// StructProperty: PCHL_RiddlerBombThug
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor PCHL_RiddlerBombThug
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 944);

    /// <summary>
    /// StructProperty: PCHL_RiddlerCameo
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor PCHL_RiddlerCameo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 960);

    /// <summary>
    /// FloatProperty: PCTopDownGlow
    /// </summary>
    public unsafe float PCTopDownGlow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// FloatProperty: PCEdgeGlow
    /// </summary>
    public unsafe float PCEdgeGlow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// FloatProperty: PCAOPower
    /// </summary>
    public unsafe float PCAOPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// FloatProperty: PCAOIntensity1
    /// </summary>
    public unsafe float PCAOIntensity1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: PCAOIntensity2
    /// </summary>
    public unsafe float PCAOIntensity2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// BoolProperty: bLevelFadeOutOWLighting
    /// </summary>
    public unsafe bool bLevelFadeOutOWLighting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bLevelFadeOutOWLightingPrev
    /// </summary>
    public unsafe bool bLevelFadeOutOWLightingPrev
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bRestartLevel
    /// </summary>
    public unsafe bool bRestartLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bPauseable
    /// </summary>
    public unsafe bool bPauseable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bTeamGame
    /// </summary>
    public unsafe bool bTeamGame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bGameEnded
    /// </summary>
    public unsafe bool bGameEnded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bOverTime
    /// </summary>
    public unsafe bool bOverTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bDelayedStart
    /// </summary>
    public unsafe bool bDelayedStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToStartMatch
    /// </summary>
    public unsafe bool bWaitingToStartMatch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bChangeLevels
    /// </summary>
    public unsafe bool bChangeLevels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bAlreadyChanged
    /// </summary>
    public unsafe bool bAlreadyChanged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bAdminCanPause
    /// </summary>
    public unsafe bool bAdminCanPause
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bGameRestarted
    /// </summary>
    public unsafe bool bGameRestarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bLevelChange
    /// </summary>
    public unsafe bool bLevelChange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bKickLiveIdlers
    /// </summary>
    public unsafe bool bKickLiveIdlers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bUsingArbitration
    /// </summary>
    public unsafe bool bUsingArbitration
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bHasArbitratedHandshakeBegun
    /// </summary>
    public unsafe bool bHasArbitratedHandshakeBegun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bNeedsEndGameHandshake
    /// </summary>
    public unsafe bool bNeedsEndGameHandshake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bIsEndGameHandshakeComplete
    /// </summary>
    public unsafe bool bIsEndGameHandshakeComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bHasEndGameHandshakeBegun
    /// </summary>
    public unsafe bool bHasEndGameHandshakeBegun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bFixedPlayerStart
    /// </summary>
    public unsafe bool bFixedPlayerStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bDoFearCostFallOff
    /// </summary>
    public unsafe bool bDoFearCostFallOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bUseSeamlessTravel
    /// </summary>
    public unsafe bool bUseSeamlessTravel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bHasNetworkError
    /// </summary>
    public unsafe bool bHasNetworkError
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bRequiresPushToTalk
    /// </summary>
    public unsafe bool bRequiresPushToTalk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bIsStandbyCheckingEnabled
    /// </summary>
    public unsafe bool bIsStandbyCheckingEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bIsStandbyCheckingOn
    /// </summary>
    public unsafe bool bIsStandbyCheckingOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bHasStandbyCheatTriggered
    /// </summary>
    public unsafe bool bHasStandbyCheatTriggered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// FloatProperty: OWLightFadeAmount
    /// </summary>
    public unsafe float OWLightFadeAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// StrProperty: CauseEventCommand
    /// </summary>
    public unsafe BmSDK.FString CauseEventCommand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// StrProperty: BugLocString
    /// </summary>
    public unsafe BmSDK.FString BugLocString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// StrProperty: BugRotString
    /// </summary>
    public unsafe BmSDK.FString BugRotString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// ArrayProperty: PendingArbitrationPCs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.PlayerController> PendingArbitrationPCs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PlayerController>>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ArrayProperty: ArbitrationPCs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.PlayerController> ArbitrationPCs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PlayerController>>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// FloatProperty: ArbitrationHandshakeTimeout
    /// </summary>
    public unsafe float ArbitrationHandshakeTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// FloatProperty: GameDifficulty
    /// </summary>
    public unsafe float GameDifficulty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// IntProperty: GoreLevel
    /// </summary>
    public unsafe int GoreLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// FloatProperty: GameSpeed
    /// </summary>
    public unsafe float GameSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ClassProperty: DefaultPawnClass
    /// </summary>
    public unsafe BmSDK.Class DefaultPawnClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ClassProperty: HUDType
    /// </summary>
    public unsafe BmSDK.Class HUDType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ClassProperty: SecondaryHUDType
    /// </summary>
    public unsafe BmSDK.Class SecondaryHUDType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// IntProperty: MaxSpectators
    /// </summary>
    public unsafe int MaxSpectators
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// IntProperty: MaxSpectatorsAllowed
    /// </summary>
    public unsafe int MaxSpectatorsAllowed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// IntProperty: NumSpectators
    /// </summary>
    public unsafe int NumSpectators
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// IntProperty: MaxPlayers
    /// </summary>
    public unsafe int MaxPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// IntProperty: MaxPlayersAllowed
    /// </summary>
    public unsafe int MaxPlayersAllowed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// IntProperty: NumPlayers
    /// </summary>
    public unsafe int NumPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// IntProperty: NumBots
    /// </summary>
    public unsafe int NumBots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// IntProperty: NumTravellingPlayers
    /// </summary>
    public unsafe int NumTravellingPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// IntProperty: CurrentID
    /// </summary>
    public unsafe int CurrentID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// StrProperty: DefaultPlayerName
    /// </summary>
    public unsafe BmSDK.FString DefaultPlayerName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// StrProperty: GameName
    /// </summary>
    public unsafe BmSDK.FString GameName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// FloatProperty: FearCostFallOff
    /// </summary>
    public unsafe float FearCostFallOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// IntProperty: GoalScore
    /// </summary>
    public unsafe int GoalScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// IntProperty: MaxLives
    /// </summary>
    public unsafe int MaxLives
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// IntProperty: TimeLimit
    /// </summary>
    public unsafe int TimeLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// ClassProperty: DeathMessageClass
    /// </summary>
    public unsafe BmSDK.Class DeathMessageClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// ClassProperty: GameMessageClass
    /// </summary>
    public unsafe BmSDK.Class GameMessageClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// ObjectProperty: BaseMutator
    /// </summary>
    public unsafe BmSDK.Engine.Mutator BaseMutator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Mutator>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// ObjectProperty: AccessControl
    /// </summary>
    public unsafe BmSDK.Engine.AccessControl AccessControl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AccessControl>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// ObjectProperty: GameReplicationInfo
    /// </summary>
    public unsafe BmSDK.Engine.GameReplicationInfo GameReplicationInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameReplicationInfo>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// ObjectProperty: OnlineSub
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem OnlineSub
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// ObjectProperty: StreamingPauseIcon
    /// </summary>
    public unsafe BmSDK.Engine.Material StreamingPauseIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// ClassProperty: OnlineGameSettingsClass
    /// </summary>
    public unsafe BmSDK.Class OnlineGameSettingsClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// ClassProperty: OnlineStatsWriteClass
    /// </summary>
    public unsafe BmSDK.Class OnlineStatsWriteClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// ClassProperty: GameReplicationInfoClass
    /// </summary>
    public unsafe BmSDK.Class GameReplicationInfoClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// ClassProperty: PlayerReplicationInfoClass
    /// </summary>
    public unsafe BmSDK.Class PlayerReplicationInfoClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// ClassProperty: PlayerControllerClass
    /// </summary>
    public unsafe BmSDK.Class PlayerControllerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// ClassProperty: AccessControlClass
    /// </summary>
    public unsafe BmSDK.Class AccessControlClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// FloatProperty: MaxIdleTime
    /// </summary>
    public unsafe float MaxIdleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// FloatProperty: MaxTimeMargin
    /// </summary>
    public unsafe float MaxTimeMargin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// FloatProperty: TimeMarginSlack
    /// </summary>
    public unsafe float TimeMarginSlack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// FloatProperty: MinTimeMargin
    /// </summary>
    public unsafe float MinTimeMargin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// ArrayProperty: InactivePRIArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.PlayerReplicationInfo> InactivePRIArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PlayerReplicationInfo>>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// ArrayProperty: Pausers
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> Pausers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// InterfaceProperty: GameInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameInterface GameInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameInterface>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// IntProperty: LeaderboardId
    /// </summary>
    public unsafe int LeaderboardId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// IntProperty: ArbitratedLeaderboardId
    /// </summary>
    public unsafe int ArbitratedLeaderboardId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// StrProperty: ServerOptions
    /// </summary>
    public unsafe BmSDK.FString ServerOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// IntProperty: AdjustedNetSpeed
    /// </summary>
    public unsafe int AdjustedNetSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// FloatProperty: LastNetSpeedUpdateTime
    /// </summary>
    public unsafe float LastNetSpeedUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// IntProperty: TotalNetBandwidth
    /// </summary>
    public unsafe int TotalNetBandwidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// IntProperty: MinDynamicBandwidth
    /// </summary>
    public unsafe int MinDynamicBandwidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// IntProperty: MaxDynamicBandwidth
    /// </summary>
    public unsafe int MaxDynamicBandwidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// FloatProperty: StandbyRxCheatTime
    /// </summary>
    public unsafe float StandbyRxCheatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// FloatProperty: StandbyTxCheatTime
    /// </summary>
    public unsafe float StandbyTxCheatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// IntProperty: BadPingThreshold
    /// </summary>
    public unsafe int BadPingThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// FloatProperty: PercentMissingForRxStandby
    /// </summary>
    public unsafe float PercentMissingForRxStandby
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// FloatProperty: PercentMissingForTxStandby
    /// </summary>
    public unsafe float PercentMissingForTxStandby
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// FloatProperty: PercentForBadPing
    /// </summary>
    public unsafe float PercentForBadPing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// FloatProperty: JoinInProgressStandbyWaitTime
    /// </summary>
    public unsafe float JoinInProgressStandbyWaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// ArrayProperty: GameInfoClassAliases
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameInfo.FGameClassShortName> GameInfoClassAliases
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameInfo.FGameClassShortName>>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// StrProperty: DefaultGameType
    /// </summary>
    public unsafe BmSDK.FString DefaultGameType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// ArrayProperty: DefaultMapPrefixes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameInfo.FGameTypePrefix> DefaultMapPrefixes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameInfo.FGameTypePrefix>>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// ArrayProperty: CustomMapPrefixes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameInfo.FGameTypePrefix> CustomMapPrefixes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameInfo.FGameTypePrefix>>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// IntProperty: AnimTreePoolSize
    /// </summary>
    public unsafe int AnimTreePoolSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// DelegateProperty: __CanUnpause__Delegate
    /// </summary>
    public unsafe System.IntPtr __CanUnpause__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// Struct: FRMap3DRenderingData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 92)]
    public partial record struct FRMap3DRenderingData
    {
        /// <summary>
        /// StructProperty: PlayerPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 PlayerPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: WaypointPosition
        /// </summary>
        public unsafe System.Numerics.Vector4 WaypointPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector4>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: MapXNavigable
        /// </summary>
        public unsafe float MapXNavigable
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: MapYNavigable
        /// </summary>
        public unsafe float MapYNavigable
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: MapZNavigable
        /// </summary>
        public unsafe float MapZNavigable
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: MapAceNavigable
        /// </summary>
        public unsafe float MapAceNavigable
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: MapXThreatLevel
        /// </summary>
        public unsafe float MapXThreatLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: MapYThreatLevel
        /// </summary>
        public unsafe float MapYThreatLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: MapZThreatLevel
        /// </summary>
        public unsafe float MapZThreatLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// ArrayProperty: ColorAndFadePct
        /// </summary>
        public unsafe BmSDK.TArray<System.Numerics.Vector4> ColorAndFadePct
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector4>>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// ArrayProperty: WorldToHighlight
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.GameObject.FMatrix> WorldToHighlight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FMatrix>>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }
    }
}
