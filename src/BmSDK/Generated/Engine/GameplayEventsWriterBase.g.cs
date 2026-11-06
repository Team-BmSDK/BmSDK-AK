#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GameplayEventsWriterBase<br/>
/// (size = 444)
/// (flags = 134217874)
/// </summary>
public partial class GameplayEventsWriterBase : BmSDK.Engine.GameplayEvents, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GameplayEventsWriterBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GameplayEventsWriterBase.
    /// </summary>
    public static GameplayEventsWriterBase DefaultObject => (GameplayEventsWriterBase)StaticClass().DefaultObject;

    internal GameplayEventsWriterBase() { }

    /// <summary>
    /// Constructs a new GameplayEventsWriterBase
    /// </summary>
    public GameplayEventsWriterBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GameplayEventsWriterBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GameplayEventsWriterBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameplayEventsWriterBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameplayEventsWriterBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameplayEventsWriterBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameplayEventsWriterBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameplayEventsWriterBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameplayEventsWriterBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameplayEventsWriterBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameplayEventsWriterBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_RecordCoverLinkFireLinks;
    /// <summary>
    /// Function: RecordCoverLinkFireLinks
    /// </summary>
    public unsafe virtual int RecordCoverLinkFireLinks(BmSDK.Engine.CoverLink Link, BmSDK.Engine.Controller Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecordCoverLinkFireLinks, "Engine.GameplayEventsWriterBase.RecordCoverLinkFireLinks");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_RecordAIPathFail;
    /// <summary>
    /// Function: RecordAIPathFail
    /// </summary>
    public unsafe virtual void RecordAIPathFail(BmSDK.Engine.Controller AI, BmSDK.FString Reason, System.Numerics.Vector3 Dest)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecordAIPathFail, "Engine.GameplayEventsWriterBase.RecordAIPathFail");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dest, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogSystemPollEvents;
    /// <summary>
    /// Function: LogSystemPollEvents
    /// </summary>
    public unsafe virtual void LogSystemPollEvents()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogSystemPollEvents, "Engine.GameplayEventsWriterBase.LogSystemPollEvents");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogProjectileIntEvent;
    /// <summary>
    /// Function: LogProjectileIntEvent
    /// </summary>
    public unsafe virtual void LogProjectileIntEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.Class Proj, int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogProjectileIntEvent, "Engine.GameplayEventsWriterBase.LogProjectileIntEvent");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proj, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogDamageEvent;
    /// <summary>
    /// Function: LogDamageEvent
    /// </summary>
    public unsafe virtual void LogDamageEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.Class dmgType, BmSDK.Engine.Controller Target, int Amount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogDamageEvent, "Engine.GameplayEventsWriterBase.LogDamageEvent");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogWeaponIntEvent;
    /// <summary>
    /// Function: LogWeaponIntEvent
    /// </summary>
    public unsafe virtual void LogWeaponIntEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.Class WeaponClass, int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogWeaponIntEvent, "Engine.GameplayEventsWriterBase.LogWeaponIntEvent");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponClass, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogPlayerPlayerEvent;
    /// <summary>
    /// Function: LogPlayerPlayerEvent
    /// </summary>
    public unsafe virtual void LogPlayerPlayerEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.Engine.Controller Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogPlayerPlayerEvent, "Engine.GameplayEventsWriterBase.LogPlayerPlayerEvent");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogPlayerKillDeath;
    /// <summary>
    /// Function: LogPlayerKillDeath
    /// </summary>
    public unsafe virtual void LogPlayerKillDeath(int EventID, int KillType, BmSDK.Engine.Controller Killer, BmSDK.Class dmgType, BmSDK.Engine.Controller Dead)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogPlayerKillDeath, "Engine.GameplayEventsWriterBase.LogPlayerKillDeath");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KillType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dead, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogAllPlayerPositionsEvent;
    /// <summary>
    /// Function: LogAllPlayerPositionsEvent
    /// </summary>
    public unsafe virtual void LogAllPlayerPositionsEvent(int EventID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogAllPlayerPositionsEvent, "Engine.GameplayEventsWriterBase.LogAllPlayerPositionsEvent");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogPlayerLoginChange;
    /// <summary>
    /// Function: LogPlayerLoginChange
    /// </summary>
    public unsafe virtual void LogPlayerLoginChange(int EventID, BmSDK.Engine.Controller Player, BmSDK.FString PlayerName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bSplitScreen)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogPlayerLoginChange, "Engine.GameplayEventsWriterBase.LogPlayerLoginChange");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSplitScreen, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogPlayerSpawnEvent;
    /// <summary>
    /// Function: LogPlayerSpawnEvent
    /// </summary>
    public unsafe virtual void LogPlayerSpawnEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.Class PawnClass, int TeamID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogPlayerSpawnEvent, "Engine.GameplayEventsWriterBase.LogPlayerSpawnEvent");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnClass, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamID, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogPlayerStringEvent;
    /// <summary>
    /// Function: LogPlayerStringEvent
    /// </summary>
    public unsafe virtual void LogPlayerStringEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.FString EventString)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogPlayerStringEvent, "Engine.GameplayEventsWriterBase.LogPlayerStringEvent");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventString, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogPlayerFloatEvent;
    /// <summary>
    /// Function: LogPlayerFloatEvent
    /// </summary>
    public unsafe virtual void LogPlayerFloatEvent(int EventID, BmSDK.Engine.Controller Player, float Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogPlayerFloatEvent, "Engine.GameplayEventsWriterBase.LogPlayerFloatEvent");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogPlayerIntEvent;
    /// <summary>
    /// Function: LogPlayerIntEvent
    /// </summary>
    public unsafe virtual void LogPlayerIntEvent(int EventID, BmSDK.Engine.Controller Player, int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogPlayerIntEvent, "Engine.GameplayEventsWriterBase.LogPlayerIntEvent");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogTeamStringEvent;
    /// <summary>
    /// Function: LogTeamStringEvent
    /// </summary>
    public unsafe virtual void LogTeamStringEvent(int EventID, BmSDK.Engine.TeamInfo Team, BmSDK.FString Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogTeamStringEvent, "Engine.GameplayEventsWriterBase.LogTeamStringEvent");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogTeamFloatEvent;
    /// <summary>
    /// Function: LogTeamFloatEvent
    /// </summary>
    public unsafe virtual void LogTeamFloatEvent(int EventID, BmSDK.Engine.TeamInfo Team, float Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogTeamFloatEvent, "Engine.GameplayEventsWriterBase.LogTeamFloatEvent");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogTeamIntEvent;
    /// <summary>
    /// Function: LogTeamIntEvent
    /// </summary>
    public unsafe virtual void LogTeamIntEvent(int EventID, BmSDK.Engine.TeamInfo Team, int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogTeamIntEvent, "Engine.GameplayEventsWriterBase.LogTeamIntEvent");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogGamePositionEvent;
    /// <summary>
    /// Function: LogGamePositionEvent
    /// </summary>
    public unsafe virtual void LogGamePositionEvent(int EventID, out System.Numerics.Vector3 Position, float Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogGamePositionEvent, "Engine.GameplayEventsWriterBase.LogGamePositionEvent");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Position);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Position = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_LogGameFloatEvent;
    /// <summary>
    /// Function: LogGameFloatEvent
    /// </summary>
    public unsafe virtual void LogGameFloatEvent(int EventID, float Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogGameFloatEvent, "Engine.GameplayEventsWriterBase.LogGameFloatEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogGameStringEvent;
    /// <summary>
    /// Function: LogGameStringEvent
    /// </summary>
    public unsafe virtual void LogGameStringEvent(int EventID, BmSDK.FString Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogGameStringEvent, "Engine.GameplayEventsWriterBase.LogGameStringEvent");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogGameIntEvent;
    /// <summary>
    /// Function: LogGameIntEvent
    /// </summary>
    public unsafe virtual void LogGameIntEvent(int EventID, int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogGameIntEvent, "Engine.GameplayEventsWriterBase.LogGameIntEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndLogging;
    /// <summary>
    /// Function: EndLogging
    /// </summary>
    public unsafe virtual void EndLogging()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndLogging, "Engine.GameplayEventsWriterBase.EndLogging");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetLogging;
    /// <summary>
    /// Function: ResetLogging
    /// </summary>
    public unsafe virtual void ResetLogging(float HeartbeatDelta = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetLogging, "Engine.GameplayEventsWriterBase.ResetLogging");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeartbeatDelta, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartLogging;
    /// <summary>
    /// Function: StartLogging
    /// </summary>
    public unsafe virtual void StartLogging(float HeartbeatDelta = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartLogging, "Engine.GameplayEventsWriterBase.StartLogging");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeartbeatDelta, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPlaylistId;
    /// <summary>
    /// Function: GetPlaylistId
    /// </summary>
    public unsafe virtual int GetPlaylistId()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlaylistId, "Engine.GameplayEventsWriterBase.GetPlaylistId");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGameTypeId;
    /// <summary>
    /// Function: GetGameTypeId
    /// </summary>
    public unsafe virtual int GetGameTypeId()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGameTypeId, "Engine.GameplayEventsWriterBase.GetGameTypeId");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Poll;
    /// <summary>
    /// Function: Poll
    /// </summary>
    public unsafe virtual void Poll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Poll, "Engine.GameplayEventsWriterBase.Poll");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopPolling;
    /// <summary>
    /// Function: StopPolling
    /// </summary>
    public unsafe virtual void StopPolling()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopPolling, "Engine.GameplayEventsWriterBase.StopPolling");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartPolling;
    /// <summary>
    /// Function: StartPolling
    /// </summary>
    public unsafe virtual void StartPolling(float HearbeatDelta)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartPolling, "Engine.GameplayEventsWriterBase.StartPolling");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HearbeatDelta, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsSessionInProgress;
    /// <summary>
    /// Function: IsSessionInProgress
    /// </summary>
    public unsafe virtual bool IsSessionInProgress()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSessionInProgress, "Engine.GameplayEventsWriterBase.IsSessionInProgress");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: Game
    /// </summary>
    public unsafe BmSDK.Engine.GameInfo Game
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameInfo>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }
}
