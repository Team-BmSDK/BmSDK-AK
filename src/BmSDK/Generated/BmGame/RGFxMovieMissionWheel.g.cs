#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieMissionWheel<br/>
/// (size = 1760)
/// (flags = 134217878)
/// </summary>
public partial class RGFxMovieMissionWheel : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieMissionWheel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieMissionWheel.
    /// </summary>
    public static RGFxMovieMissionWheel DefaultObject => (RGFxMovieMissionWheel)StaticClass().DefaultObject;

    internal RGFxMovieMissionWheel() { }

    /// <summary>
    /// Constructs a new RGFxMovieMissionWheel
    /// </summary>
    public RGFxMovieMissionWheel(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieMissionWheel Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieMissionWheel(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieMissionWheel>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieMissionWheel>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieMissionWheel>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieMissionWheel>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieMissionWheel>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieMissionWheel>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieMissionWheel>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieMissionWheel>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_XI_bUsingDPad;
    /// <summary>
    /// Function: XI_bUsingDPad
    /// </summary>
    public unsafe virtual void XI_bUsingDPad(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_bUsingDPad, "BmGame.RGFxMovieMissionWheel.XI_bUsingDPad");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_ReFetchChallengeBoard;
    /// <summary>
    /// Function: UC_ReFetchChallengeBoard
    /// </summary>
    public unsafe virtual void UC_ReFetchChallengeBoard()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_ReFetchChallengeBoard, "BmGame.RGFxMovieMissionWheel.UC_ReFetchChallengeBoard");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_OpenMainChallengeBoard;
    /// <summary>
    /// Function: UC_OpenMainChallengeBoard
    /// </summary>
    public unsafe virtual void UC_OpenMainChallengeBoard()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_OpenMainChallengeBoard, "BmGame.RGFxMovieMissionWheel.UC_OpenMainChallengeBoard");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FetchChallengeBoard;
    /// <summary>
    /// Function: FetchChallengeBoard
    /// </summary>
    public unsafe virtual bool FetchChallengeBoard()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FetchChallengeBoard, "BmGame.RGFxMovieMissionWheel.FetchChallengeBoard");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_FetchBoard;
    /// <summary>
    /// Function: XI_FetchBoard
    /// </summary>
    public unsafe virtual void XI_FetchBoard(int _ChallengeId, int RequestedMode, BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_FetchBoard, "BmGame.RGFxMovieMissionWheel.XI_FetchBoard");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ChallengeId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestedMode, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_TriggerLeaderboard;
    /// <summary>
    /// Function: UC_TriggerLeaderboard
    /// </summary>
    public unsafe virtual void UC_TriggerLeaderboard(int FriendCount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_TriggerLeaderboard, "BmGame.RGFxMovieMissionWheel.UC_TriggerLeaderboard");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendCount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendLeaderBoardToFlash;
    /// <summary>
    /// Function: SendLeaderBoardToFlash
    /// </summary>
    public unsafe override void SendLeaderBoardToFlash(int Id, int total, BmSDK.TArray<int> FriendIndex, BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> NetIDs, BmSDK.TArray<int> Ranks, BmSDK.TArray<BmSDK.FString> NickNames, BmSDK.TArray<int> Stars, BmSDK.TArray<float> Scores, BmSDK.TArray<int> RivalPoints, BmSDK.TArray<float> Story, BmSDK.TArray<float> MW, BmSDK.TArray<float> AR)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendLeaderBoardToFlash, "BmGame.RGFxMovieMissionWheel.SendLeaderBoardToFlash");
        byte* paramsPtr = stackalloc byte[332];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(total, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetIDs, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Ranks, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NickNames, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stars, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scores, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RivalPoints, paramsPtr + 104);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Story, paramsPtr + 120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MW, paramsPtr + 136);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AR, paramsPtr + 152);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetLeaderboardLine;
    /// <summary>
    /// Function: UC_SetLeaderboardLine
    /// </summary>
    public unsafe virtual void UC_SetLeaderboardLine(int Index, int Rank, BmSDK.FString NickName, int Medals, BmSDK.FString Score)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetLeaderboardLine, "BmGame.RGFxMovieMissionWheel.UC_SetLeaderboardLine");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rank, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NickName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Medals, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetGoal;
    /// <summary>
    /// Function: UC_SetGoal
    /// </summary>
    public unsafe virtual void UC_SetGoal(int GoalId, BmSDK.FString GoalStr)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetGoal, "BmGame.RGFxMovieMissionWheel.UC_SetGoal");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoalId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoalStr, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SetupContents;
    /// <summary>
    /// Function: XI_SetupContents
    /// </summary>
    public unsafe virtual void XI_SetupContents()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetupContents, "BmGame.RGFxMovieMissionWheel.XI_SetupContents");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ClosedMainBoard;
    /// <summary>
    /// Function: XI_ClosedMainBoard
    /// </summary>
    public unsafe virtual void XI_ClosedMainBoard()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ClosedMainBoard, "BmGame.RGFxMovieMissionWheel.XI_ClosedMainBoard");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LeaderboardTick;
    /// <summary>
    /// Function: LeaderboardTick
    /// </summary>
    public unsafe virtual void LeaderboardTick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LeaderboardTick, "BmGame.RGFxMovieMissionWheel.LeaderboardTick");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ShowMWGamercard;
    /// <summary>
    /// Function: XI_ShowMWGamercard
    /// </summary>
    public unsafe virtual void XI_ShowMWGamercard(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ShowMWGamercard, "BmGame.RGFxMovieMissionWheel.XI_ShowMWGamercard");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_WillASetRival;
    /// <summary>
    /// Function: XI_WillASetRival
    /// </summary>
    public unsafe virtual void XI_WillASetRival(int Status)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_WillASetRival, "BmGame.RGFxMovieMissionWheel.XI_WillASetRival");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Status, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPollingBoards;
    /// <summary>
    /// Function: IsPollingBoards
    /// </summary>
    public unsafe virtual bool IsPollingBoards()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPollingBoards, "BmGame.RGFxMovieMissionWheel.IsPollingBoards");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_PS4CanAccessLB;
    /// <summary>
    /// Function: XI_PS4CanAccessLB
    /// </summary>
    public unsafe virtual bool XI_PS4CanAccessLB()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_PS4CanAccessLB, "BmGame.RGFxMovieMissionWheel.XI_PS4CanAccessLB");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UC_ReFetchBoard;
    /// <summary>
    /// Function: UC_ReFetchBoard
    /// </summary>
    public unsafe virtual void UC_ReFetchBoard()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_ReFetchBoard, "BmGame.RGFxMovieMissionWheel.UC_ReFetchBoard");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_OpenMWMainBoard;
    /// <summary>
    /// Function: UC_OpenMWMainBoard
    /// </summary>
    public unsafe virtual void UC_OpenMWMainBoard()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_OpenMWMainBoard, "BmGame.RGFxMovieMissionWheel.UC_OpenMWMainBoard");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_GotMWLeaderboardData;
    /// <summary>
    /// Function: UC_GotMWLeaderboardData
    /// </summary>
    public unsafe virtual void UC_GotMWLeaderboardData(int Count)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_GotMWLeaderboardData, "BmGame.RGFxMovieMissionWheel.UC_GotMWLeaderboardData");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SetRivalIndex;
    /// <summary>
    /// Function: XI_SetRivalIndex
    /// </summary>
    public unsafe virtual void XI_SetRivalIndex(int Index, bool bChallengeData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetRivalIndex, "BmGame.RGFxMovieMissionWheel.XI_SetRivalIndex");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bChallengeData, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetRivalIndex;
    /// <summary>
    /// Function: XI_GetRivalIndex
    /// </summary>
    public unsafe virtual int XI_GetRivalIndex(bool bChallengeData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetRivalIndex, "BmGame.RGFxMovieMissionWheel.XI_GetRivalIndex");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bChallengeData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_XI_GetSelfIndex;
    /// <summary>
    /// Function: XI_GetSelfIndex
    /// </summary>
    public unsafe virtual int XI_GetSelfIndex(bool bChallengeData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetSelfIndex, "BmGame.RGFxMovieMissionWheel.XI_GetSelfIndex");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bChallengeData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OnMWLeaderboardRead;
    /// <summary>
    /// Function: OnMWLeaderboardRead
    /// </summary>
    public unsafe override void OnMWLeaderboardRead(bool bWasSuccessful, BmSDK.BmGame.ROnlineStatsReadMostWanted MWStats)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMWLeaderboardRead, "BmGame.RGFxMovieMissionWheel.OnMWLeaderboardRead");
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MWStats, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_FetchMWBoard;
    /// <summary>
    /// Function: XI_FetchMWBoard
    /// </summary>
    public unsafe virtual void XI_FetchMWBoard(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_FetchMWBoard, "BmGame.RGFxMovieMissionWheel.XI_FetchMWBoard");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SetMWBoardRef;
    /// <summary>
    /// Function: XI_SetMWBoardRef
    /// </summary>
    public unsafe virtual void XI_SetMWBoardRef(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetMWBoardRef, "BmGame.RGFxMovieMissionWheel.XI_SetMWBoardRef");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetMostWantedStatForRival;
    /// <summary>
    /// Function: XI_GetMostWantedStatForRival
    /// </summary>
    public unsafe virtual int XI_GetMostWantedStatForRival()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetMostWantedStatForRival, "BmGame.RGFxMovieMissionWheel.XI_GetMostWantedStatForRival");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_GetBatmobileUnavailable;
    /// <summary>
    /// Function: XI_GetBatmobileUnavailable
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetBatmobileUnavailable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetBatmobileUnavailable, "BmGame.RGFxMovieMissionWheel.XI_GetBatmobileUnavailable");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_ClearTutorial;
    /// <summary>
    /// Function: XI_ClearTutorial
    /// </summary>
    public unsafe virtual void XI_ClearTutorial(BmSDK.FString sWheelType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ClearTutorial, "BmGame.RGFxMovieMissionWheel.XI_ClearTutorial");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sWheelType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ClearNewFlag;
    /// <summary>
    /// Function: XI_ClearNewFlag
    /// </summary>
    public unsafe virtual void XI_ClearNewFlag(BmSDK.FString sMissionName, bool bOnlyClearOneShot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ClearNewFlag, "BmGame.RGFxMovieMissionWheel.XI_ClearNewFlag");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sMissionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyClearOneShot, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ClearCompleteAnim;
    /// <summary>
    /// Function: XI_ClearCompleteAnim
    /// </summary>
    public unsafe virtual void XI_ClearCompleteAnim(BmSDK.FString sMissionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ClearCompleteAnim, "BmGame.RGFxMovieMissionWheel.XI_ClearCompleteAnim");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sMissionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_PlayMissionSound;
    /// <summary>
    /// Function: XI_PlayMissionSound
    /// </summary>
    public unsafe virtual void XI_PlayMissionSound(BmSDK.FString sDialogueCase)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_PlayMissionSound, "BmGame.RGFxMovieMissionWheel.XI_PlayMissionSound");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sDialogueCase, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_PlayMissionSoundForMissionInWheel;
    /// <summary>
    /// Function: XI_PlayMissionSoundForMissionInWheel
    /// </summary>
    public unsafe virtual void XI_PlayMissionSoundForMissionInWheel(BmSDK.FString sMission, BmSDK.FString sSpecialCase)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_PlayMissionSoundForMissionInWheel, "BmGame.RGFxMovieMissionWheel.XI_PlayMissionSoundForMissionInWheel");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sMission, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sSpecialCase, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_CancelMissionSoundForMissionOutsideOfWheel;
    /// <summary>
    /// Function: XI_CancelMissionSoundForMissionOutsideOfWheel
    /// </summary>
    public unsafe virtual void XI_CancelMissionSoundForMissionOutsideOfWheel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_CancelMissionSoundForMissionOutsideOfWheel, "BmGame.RGFxMovieMissionWheel.XI_CancelMissionSoundForMissionOutsideOfWheel");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_PlayMissionSoundForMissionOutsideOfWheel;
    /// <summary>
    /// Function: XI_PlayMissionSoundForMissionOutsideOfWheel
    /// </summary>
    public unsafe virtual void XI_PlayMissionSoundForMissionOutsideOfWheel(BmSDK.FString sMission, BmSDK.FString sSpecialCase)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_PlayMissionSoundForMissionOutsideOfWheel, "BmGame.RGFxMovieMissionWheel.XI_PlayMissionSoundForMissionOutsideOfWheel");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sMission, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sSpecialCase, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_TutorialPopUp;
    /// <summary>
    /// Function: XI_TutorialPopUp
    /// </summary>
    public unsafe virtual void XI_TutorialPopUp(BmSDK.FString sWheelType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_TutorialPopUp, "BmGame.RGFxMovieMissionWheel.XI_TutorialPopUp");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sWheelType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_RequestClose;
    /// <summary>
    /// Function: XI_RequestClose
    /// </summary>
    public unsafe virtual void XI_RequestClose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_RequestClose, "BmGame.RGFxMovieMissionWheel.XI_RequestClose");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetStickAngMag;
    /// <summary>
    /// Function: XI_GetStickAngMag
    /// </summary>
    public unsafe virtual void XI_GetStickAngMag(BmSDK.FString TargetBasePath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetStickAngMag, "BmGame.RGFxMovieMissionWheel.XI_GetStickAngMag");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Tick;
    /// <summary>
    /// Function: XI_Tick
    /// </summary>
    public unsafe override void XI_Tick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Tick, "BmGame.RGFxMovieMissionWheel.XI_Tick");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ToggleMission;
    /// <summary>
    /// Function: XI_ToggleMission
    /// </summary>
    public unsafe virtual void XI_ToggleMission(BmSDK.FString sMission, int iExtraParameter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ToggleMission, "BmGame.RGFxMovieMissionWheel.XI_ToggleMission");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sMission, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iExtraParameter, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_LastHighlight;
    /// <summary>
    /// Function: XI_LastHighlight
    /// </summary>
    public unsafe virtual void XI_LastHighlight(BmSDK.FString sType, BmSDK.FString sMission)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_LastHighlight, "BmGame.RGFxMovieMissionWheel.XI_LastHighlight");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sMission, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SetMWWheelDefaultType;
    /// <summary>
    /// Function: XI_SetMWWheelDefaultType
    /// </summary>
    public unsafe virtual void XI_SetMWWheelDefaultType(BmSDK.FString sType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetMWWheelDefaultType, "BmGame.RGFxMovieMissionWheel.XI_SetMWWheelDefaultType");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_AlternateCarRace;
    /// <summary>
    /// Function: XI_AlternateCarRace
    /// </summary>
    public unsafe virtual bool XI_AlternateCarRace(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_AlternateCarRace, "BmGame.RGFxMovieMissionWheel.XI_AlternateCarRace");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_XI_IsChallengeAwarded;
    /// <summary>
    /// Function: XI_IsChallengeAwarded
    /// </summary>
    public unsafe virtual bool XI_IsChallengeAwarded(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_IsChallengeAwarded, "BmGame.RGFxMovieMissionWheel.XI_IsChallengeAwarded");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_XI_IsUniqueGoalMap;
    /// <summary>
    /// Function: XI_IsUniqueGoalMap
    /// </summary>
    public unsafe virtual bool XI_IsUniqueGoalMap(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_IsUniqueGoalMap, "BmGame.RGFxMovieMissionWheel.XI_IsUniqueGoalMap");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_XI_GetExtraChallengeMedals;
    /// <summary>
    /// Function: XI_GetExtraChallengeMedals
    /// </summary>
    public unsafe virtual int XI_GetExtraChallengeMedals(int iChallengeCategory)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetExtraChallengeMedals, "BmGame.RGFxMovieMissionWheel.XI_GetExtraChallengeMedals");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iChallengeCategory, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FireFlyActive;
    /// <summary>
    /// Function: FireFlyActive
    /// </summary>
    public unsafe virtual bool FireFlyActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireFlyActive, "BmGame.RGFxMovieMissionWheel.FireFlyActive");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_WheelSetSubtitles;
    /// <summary>
    /// Function: WheelSetSubtitles
    /// </summary>
    public unsafe virtual void WheelSetSubtitles(BmSDK.FString sSubtitle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WheelSetSubtitles, "BmGame.RGFxMovieMissionWheel.WheelSetSubtitles");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sSubtitle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetWheel;
    /// <summary>
    /// Function: UC_SetWheel
    /// </summary>
    public unsafe virtual void UC_SetWheel(BmSDK.FString sType, BmSDK.FString sBackTarget, BmSDK.FString sMissionToHighlight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetWheel, "BmGame.RGFxMovieMissionWheel.UC_SetWheel");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sBackTarget, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sMissionToHighlight, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_AddItem;
    /// <summary>
    /// Function: UC_AddItem
    /// </summary>
    public unsafe void UC_AddItem(BmSDK.FString sName, int iId, BmSDK.FString sAction, BmSDK.FString sBackground, bool bNewlyCompleted, float fAngle, bool bUnlocked, bool bLayoutOnly, int SuspendedState, bool bWaypointActive, bool bIntel, int bNew, bool bDirty, bool bDLC, BmSDK.FString sSubscript, BmSDK.FString sSidePanel, float fPercentage, BmSDK.FString sMarkers, int iSynopsisId, int iProgressId, BmSDK.FString sHeaders, BmSDK.FString sParams, int iMedals, int iPoints, BmSDK.FString sScore, BmSDK.FString sLeaderBoard)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_AddItem, "BmGame.RGFxMovieMissionWheel.UC_AddItem");
        byte* paramsPtr = stackalloc byte[240];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iId, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sAction, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sBackground, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewlyCompleted, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fAngle, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUnlocked, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLayoutOnly, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SuspendedState, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWaypointActive, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIntel, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNew, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDirty, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDLC, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sSubscript, paramsPtr + 92);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sSidePanel, paramsPtr + 108);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fPercentage, paramsPtr + 124);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sMarkers, paramsPtr + 128);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iSynopsisId, paramsPtr + 144);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iProgressId, paramsPtr + 148);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sHeaders, paramsPtr + 152);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sParams, paramsPtr + 168);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iMedals, paramsPtr + 184);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iPoints, paramsPtr + 188);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sScore, paramsPtr + 192);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sLeaderBoard, paramsPtr + 208);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCurrentMission;
    /// <summary>
    /// Function: GetCurrentMission
    /// </summary>
    public unsafe virtual BmSDK.FString GetCurrentMission()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentMission, "BmGame.RGFxMovieMissionWheel.GetCurrentMission");
        byte* paramsPtr = stackalloc byte[85];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SortById;
    /// <summary>
    /// Function: SortById
    /// </summary>
    public unsafe virtual int SortById(BmSDK.BmGame.RGameInfo.FMostWantedSetup A, BmSDK.BmGame.RGameInfo.FMostWantedSetup B)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortById, "BmGame.RGFxMovieMissionWheel.SortById");
        byte* paramsPtr = stackalloc byte[212];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 192);
    }

    private static BmSDK.Function __fn_AddItems;
    /// <summary>
    /// Function: AddItems
    /// </summary>
    public unsafe virtual void AddItems(BmSDK.TArray<BmSDK.BmGame.RGFxMovieMissionWheel.FMission_Data> aItems)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddItems, "BmGame.RGFxMovieMissionWheel.AddItems");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aItems, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddInSummaryAndSetAngles;
    /// <summary>
    /// Function: AddInSummaryAndSetAngles
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RGFxMovieMissionWheel.FMission_Data> AddInSummaryAndSetAngles(BmSDK.TArray<BmSDK.BmGame.RGFxMovieMissionWheel.FMission_Data> aItems, BmSDK.BmGame.RGFxMovieMissionWheel.FMission_Data structItem)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddInSummaryAndSetAngles, "BmGame.RGFxMovieMissionWheel.AddInSummaryAndSetAngles");
        byte* paramsPtr = stackalloc byte[484];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aItems, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(structItem, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RGFxMovieMissionWheel.FMission_Data>>(paramsPtr + 228);
    }

    private static BmSDK.Function __fn_GetChallengeDistance;
    /// <summary>
    /// Function: GetChallengeDistance
    /// </summary>
    public unsafe virtual int GetChallengeDistance(int iId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChallengeDistance, "BmGame.RGFxMovieMissionWheel.GetChallengeDistance");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UC_SetAltCarTextOn;
    /// <summary>
    /// Function: UC_SetAltCarTextOn
    /// </summary>
    public unsafe virtual void UC_SetAltCarTextOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetAltCarTextOn, "BmGame.RGFxMovieMissionWheel.UC_SetAltCarTextOn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetChallengeData_Sub;
    /// <summary>
    /// Function: GetChallengeData_Sub
    /// </summary>
    public unsafe virtual void GetChallengeData_Sub(BmSDK.FString sType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChallengeData_Sub, "BmGame.RGFxMovieMissionWheel.GetChallengeData_Sub");
        byte* paramsPtr = stackalloc byte[836];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInRightCategory;
    /// <summary>
    /// Function: IsInRightCategory
    /// </summary>
    public unsafe virtual bool IsInRightCategory(BmSDK.FString CategoryName, int ChallengeListIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInRightCategory, "BmGame.RGFxMovieMissionWheel.IsInRightCategory");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CategoryName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeListIndex, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetChallengeDisabled;
    /// <summary>
    /// Function: GetChallengeDisabled
    /// </summary>
    public unsafe virtual bool GetChallengeDisabled(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChallengeDisabled, "BmGame.RGFxMovieMissionWheel.GetChallengeDisabled");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetChallengeData_Categories;
    /// <summary>
    /// Function: GetChallengeData_Categories
    /// </summary>
    public unsafe virtual void GetChallengeData_Categories()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChallengeData_Categories, "BmGame.RGFxMovieMissionWheel.GetChallengeData_Categories");
        byte* paramsPtr = stackalloc byte[828];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMostWantedData_DLC;
    /// <summary>
    /// Function: GetMostWantedData_DLC
    /// </summary>
    public unsafe virtual void GetMostWantedData_DLC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMostWantedData_DLC, "BmGame.RGFxMovieMissionWheel.GetMostWantedData_DLC");
        byte* paramsPtr = stackalloc byte[832];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMostWantedData;
    /// <summary>
    /// Function: GetMostWantedData
    /// </summary>
    public unsafe virtual void GetMostWantedData()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMostWantedData, "BmGame.RGFxMovieMissionWheel.GetMostWantedData");
        byte* paramsPtr = stackalloc byte[964];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_AnyDLCMissionsPresent;
    /// <summary>
    /// Function: XI_AnyDLCMissionsPresent
    /// </summary>
    public unsafe virtual bool XI_AnyDLCMissionsPresent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_AnyDLCMissionsPresent, "BmGame.RGFxMovieMissionWheel.XI_AnyDLCMissionsPresent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_SetupWheelData;
    /// <summary>
    /// Function: XI_SetupWheelData
    /// </summary>
    public unsafe virtual void XI_SetupWheelData(BmSDK.FString sWheelType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetupWheelData, "BmGame.RGFxMovieMissionWheel.XI_SetupWheelData");
        byte* paramsPtr = stackalloc byte[81];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sWheelType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitFlash;
    /// <summary>
    /// Function: InitFlash
    /// </summary>
    public unsafe virtual void InitFlash(BmSDK.FString sType, BmSDK.TArray<BmSDK.FString> aWheelsAvailable, int iKnightfall, int iMidKnightfall, bool bMW_Tutorial, bool bAR_Tutorial, bool bMW_DLC_Tutorial, bool bAR_DLC_Tutorial)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitFlash, "BmGame.RGFxMovieMissionWheel.InitFlash");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aWheelsAvailable, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iKnightfall, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iMidKnightfall, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMW_Tutorial, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAR_Tutorial, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMW_DLC_Tutorial, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAR_DLC_Tutorial, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovieMissionWheel.Init");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: WCLBMode
    /// </summary>
    public enum WCLBMode : byte
    {
        WCLBMode_Friends = 0,
        WCLBMode_Ranked = 1,
        WCLBMode_Top100 = 2,
        WCLBMode_MAX = 3,
    }

    /// <summary>
    /// BoolProperty: bMWReadPending
    /// </summary>
    public unsafe bool bMWReadPending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bMWFetchSuccess
    /// </summary>
    public unsafe bool bMWFetchSuccess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bMWMainBoard
    /// </summary>
    public unsafe bool bMWMainBoard
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bIsPC
    /// </summary>
    public unsafe bool bIsPC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bIsDurango
    /// </summary>
    public unsafe bool bIsDurango
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bIsOrbis
    /// </summary>
    public unsafe bool bIsOrbis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bOrbisBeginSignIn
    /// </summary>
    public unsafe bool bOrbisBeginSignIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bChallengeReadPending
    /// </summary>
    public unsafe bool bChallengeReadPending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bChallengeFetching
    /// </summary>
    public unsafe bool bChallengeFetching
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bChallengeFetchSuccess
    /// </summary>
    public unsafe bool bChallengeFetchSuccess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bChallengeMainBoard
    /// </summary>
    public unsafe bool bChallengeMainBoard
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: MostWantedTutorialActive
    /// </summary>
    public unsafe bool MostWantedTutorialActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: ChallengeTutorialActive
    /// </summary>
    public unsafe bool ChallengeTutorialActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bRequestedLBData
    /// </summary>
    public unsafe bool bRequestedLBData
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bRequestedMWData
    /// </summary>
    public unsafe bool bRequestedMWData
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// IntProperty: ASetRivalState
    /// </summary>
    public unsafe int ASetRivalState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// StrProperty: MWTargetPath
    /// </summary>
    public unsafe BmSDK.FString MWTargetPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: MyMWStats
    /// </summary>
    public unsafe BmSDK.TArray<int> MyMWStats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ArrayProperty: MWStatNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> MWStatNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// IntProperty: ChallengeID
    /// </summary>
    public unsafe int ChallengeID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ByteProperty: Mode
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieMissionWheel.WCLBMode Mode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieMissionWheel.WCLBMode>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// ByteProperty: Request
    /// </summary>
    public unsafe BmSDK.Engine.UIDataStore_OnlineStats.EStatsFetchType Request
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIDataStore_OnlineStats.EStatsFetchType>(Ptr + 1133); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1133); }
    }

    /// <summary>
    /// IntProperty: LB_Offset
    /// </summary>
    public unsafe int LB_Offset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// StrProperty: ChallengeTargetPath
    /// </summary>
    public unsafe BmSDK.FString ChallengeTargetPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// ObjectProperty: RGI
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo RGI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// ObjectProperty: GRI
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI GRI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// ObjectProperty: CMan
    /// </summary>
    public unsafe BmSDK.BmGame.RChallengeManager CMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChallengeManager>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// ObjectProperty: FlagMan
    /// </summary>
    public unsafe BmSDK.BmGame.RFlagManager FlagMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFlagManager>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// ObjectProperty: SSMan
    /// </summary>
    public unsafe BmSDK.BmGame.RSideStoryManager SSMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSideStoryManager>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// StrProperty: ChallengesListPath
    /// </summary>
    public unsafe BmSDK.FString ChallengesListPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// IntProperty: ModeIndex
    /// </summary>
    public unsafe int ModeIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// FloatProperty: fMyFadeTimeSec
    /// </summary>
    public unsafe float fMyFadeTimeSec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// StructProperty: WorldPPSettings
    /// </summary>
    public unsafe ref BmSDK.Engine.PostProcessVolume.FPostProcessSettings WorldPPSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.PostProcessVolume.FPostProcessSettings>(Ptr + 1220);

    /// <summary>
    /// DelegateProperty: __SortById__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortById__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }

    /// <summary>
    /// Struct: FMission_Data
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 212)]
    public partial record struct FMission_Data
    {
        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: Action
        /// </summary>
        public unsafe BmSDK.FString Action
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// StrProperty: Background
        /// </summary>
        public unsafe BmSDK.FString Background
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: NewlyCompleted
        /// </summary>
        public unsafe bool NewlyCompleted
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: Angle
        /// </summary>
        public unsafe float Angle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: Unlocked
        /// </summary>
        public unsafe bool Unlocked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: LayoutOnly
        /// </summary>
        public unsafe bool LayoutOnly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }; }
        }

        /// <summary>
        /// IntProperty: SuspendedState
        /// </summary>
        public unsafe int SuspendedState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: Waypointed
        /// </summary>
        public unsafe bool Waypointed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }; }
        }

        /// <summary>
        /// BoolProperty: Intel
        /// </summary>
        public unsafe bool Intel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }; }
        }

        /// <summary>
        /// IntProperty: New
        /// </summary>
        public unsafe int New
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: Dirty
        /// </summary>
        public unsafe bool Dirty
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: DLC
        /// </summary>
        public unsafe bool DLC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// StrProperty: Subscript
        /// </summary>
        public unsafe BmSDK.FString Subscript
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// StrProperty: SidePanel
        /// </summary>
        public unsafe BmSDK.FString SidePanel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// FloatProperty: Percentage
        /// </summary>
        public unsafe float Percentage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }

        /// <summary>
        /// StrProperty: Markers
        /// </summary>
        public unsafe BmSDK.FString Markers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 116); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }; }
        }

        /// <summary>
        /// IntProperty: SynopsisId
        /// </summary>
        public unsafe int SynopsisId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }; }
        }

        /// <summary>
        /// IntProperty: ProgressId
        /// </summary>
        public unsafe int ProgressId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }; }
        }

        /// <summary>
        /// StrProperty: Headers
        /// </summary>
        public unsafe BmSDK.FString Headers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 140); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }; }
        }

        /// <summary>
        /// StrProperty: Params
        /// </summary>
        public unsafe BmSDK.FString Params
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 156); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }; }
        }

        /// <summary>
        /// IntProperty: Medals
        /// </summary>
        public unsafe int Medals
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }; }
        }

        /// <summary>
        /// IntProperty: Points
        /// </summary>
        public unsafe int Points
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }; }
        }

        /// <summary>
        /// StrProperty: Score
        /// </summary>
        public unsafe BmSDK.FString Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 180); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }; }
        }

        /// <summary>
        /// StrProperty: Leaderboard
        /// </summary>
        public unsafe BmSDK.FString Leaderboard
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 196); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }; }
        }
    }
}
