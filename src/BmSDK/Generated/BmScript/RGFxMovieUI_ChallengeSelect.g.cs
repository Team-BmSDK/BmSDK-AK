#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_ChallengeSelect<br/>
/// (size = 1136)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_ChallengeSelect : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_ChallengeSelect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_ChallengeSelect.
    /// </summary>
    public static RGFxMovieUI_ChallengeSelect DefaultObject => (RGFxMovieUI_ChallengeSelect)StaticClass().DefaultObject;

    internal RGFxMovieUI_ChallengeSelect() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_ChallengeSelect
    /// </summary>
    public RGFxMovieUI_ChallengeSelect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_ChallengeSelect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_ChallengeSelect(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ChallengeSelect>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ChallengeSelect>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ChallengeSelect>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ChallengeSelect>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ChallengeSelect>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ChallengeSelect>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ChallengeSelect>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ChallengeSelect>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SendLeaderBoardToFlash;
    /// <summary>
    /// Function: SendLeaderBoardToFlash
    /// </summary>
    public unsafe override void SendLeaderBoardToFlash(int nId, int nTotal, BmSDK.TArray<int> aFriendIndex, BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> aNetIDs, BmSDK.TArray<int> aRanks, BmSDK.TArray<BmSDK.FString> aNames, BmSDK.TArray<int> aStars, BmSDK.TArray<float> aScores, BmSDK.TArray<int> aRivalPoints, BmSDK.TArray<float> aStory, BmSDK.TArray<float> aMW, BmSDK.TArray<float> aAR)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendLeaderBoardToFlash, "BmScript.RGFxMovieUI_ChallengeSelect.SendLeaderBoardToFlash");
        byte* paramsPtr = stackalloc byte[260];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nTotal, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aFriendIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aNetIDs, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aRanks, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aNames, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aStars, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aScores, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aRivalPoints, paramsPtr + 104);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aStory, paramsPtr + 120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aMW, paramsPtr + 136);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aAR, paramsPtr + 152);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_UpdatePrompts;
    /// <summary>
    /// Function: XI_UpdatePrompts
    /// </summary>
    public unsafe virtual void XI_UpdatePrompts(int nId, bool bLeaderboard, bool bEmpty = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_UpdatePrompts, "BmScript.RGFxMovieUI_ChallengeSelect.XI_UpdatePrompts");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLeaderboard, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEmpty, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsDefaultCharacter;
    /// <summary>
    /// Function: IsDefaultCharacter
    /// </summary>
    public unsafe virtual bool IsDefaultCharacter(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDefaultCharacter, "BmScript.RGFxMovieUI_ChallengeSelect.IsDefaultCharacter");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_XI_ShowGamerCard;
    /// <summary>
    /// Function: XI_ShowGamerCard
    /// </summary>
    public unsafe virtual void XI_ShowGamerCard(int nFriendIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ShowGamerCard, "BmScript.RGFxMovieUI_ChallengeSelect.XI_ShowGamerCard");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nFriendIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_FetchLeaderboardData;
    /// <summary>
    /// Function: XI_FetchLeaderboardData
    /// </summary>
    public unsafe virtual bool XI_FetchLeaderboardData(int RequestedMode, int ChallengeID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_FetchLeaderboardData, "BmScript.RGFxMovieUI_ChallengeSelect.XI_FetchLeaderboardData");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestedMode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_XI_ChallengeHasLeaderboard;
    /// <summary>
    /// Function: XI_ChallengeHasLeaderboard
    /// </summary>
    public unsafe virtual bool XI_ChallengeHasLeaderboard(int ChallengeID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ChallengeHasLeaderboard, "BmScript.RGFxMovieUI_ChallengeSelect.XI_ChallengeHasLeaderboard");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TimerPollingLeaderboards;
    /// <summary>
    /// Function: TimerPollingLeaderboards
    /// </summary>
    public unsafe virtual void TimerPollingLeaderboards()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimerPollingLeaderboards, "BmScript.RGFxMovieUI_ChallengeSelect.TimerPollingLeaderboards");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPollingBoards;
    /// <summary>
    /// Function: IsPollingBoards
    /// </summary>
    public unsafe virtual bool IsPollingBoards()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPollingBoards, "BmScript.RGFxMovieUI_ChallengeSelect.IsPollingBoards");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UC_ShowLeaderboard;
    /// <summary>
    /// Function: UC_ShowLeaderboard
    /// </summary>
    public unsafe virtual void UC_ShowLeaderboard()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_ShowLeaderboard, "BmScript.RGFxMovieUI_ChallengeSelect.UC_ShowLeaderboard");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetLeaderboardError;
    /// <summary>
    /// Function: UC_SetLeaderboardError
    /// </summary>
    public unsafe virtual void UC_SetLeaderboardError(BmSDK.FString sError)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetLeaderboardError, "BmScript.RGFxMovieUI_ChallengeSelect.UC_SetLeaderboardError");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sError, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetLeaderboardLine;
    /// <summary>
    /// Function: UC_SetLeaderboardLine
    /// </summary>
    public unsafe virtual void UC_SetLeaderboardLine(int nIndex, int nRank, BmSDK.FString sName, int nStars, BmSDK.FString sScore, int nRivalPoints, bool bIsSelf, bool bIsRival)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetLeaderboardLine, "BmScript.RGFxMovieUI_ChallengeSelect.UC_SetLeaderboardLine");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nRank, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nStars, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sScore, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nRivalPoints, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSelf, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsRival, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyFriendBeatYou;
    /// <summary>
    /// Function: NotifyFriendBeatYou
    /// </summary>
    public unsafe override void NotifyFriendBeatYou()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFriendBeatYou, "BmScript.RGFxMovieUI_ChallengeSelect.NotifyFriendBeatYou");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_ShowBeatenByMessage;
    /// <summary>
    /// Function: UC_ShowBeatenByMessage
    /// </summary>
    public unsafe virtual void UC_ShowBeatenByMessage(BmSDK.FString sMessage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_ShowBeatenByMessage, "BmScript.RGFxMovieUI_ChallengeSelect.UC_ShowBeatenByMessage");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sMessage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFadeCompleted_Callback;
    /// <summary>
    /// Function: OnFadeCompleted_Callback
    /// </summary>
    public unsafe override void OnFadeCompleted_Callback()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFadeCompleted_Callback, "BmScript.RGFxMovieUI_ChallengeSelect.OnFadeCompleted_Callback");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_FilterCharacter;
    /// <summary>
    /// Function: XI_FilterCharacter
    /// </summary>
    public unsafe virtual bool XI_FilterCharacter(BmSDK.FString Stab, int nId, BmSDK.FString sCharacter, bool bDefault)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_FilterCharacter, "BmScript.RGFxMovieUI_ChallengeSelect.XI_FilterCharacter");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stab, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCharacter, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDefault, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_XI_GetActorListPackage;
    /// <summary>
    /// Function: XI_GetActorListPackage
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetActorListPackage(BmSDK.FString sCharacter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetActorListPackage, "BmScript.RGFxMovieUI_ChallengeSelect.XI_GetActorListPackage");
        byte* paramsPtr = stackalloc byte[196];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCharacter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_XI_GetExtraStars;
    /// <summary>
    /// Function: XI_GetExtraStars
    /// </summary>
    public unsafe virtual int XI_GetExtraStars(int iChallenge)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetExtraStars, "BmScript.RGFxMovieUI_ChallengeSelect.XI_GetExtraStars");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iChallenge, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_XI_GetChallengeStars;
    /// <summary>
    /// Function: XI_GetChallengeStars
    /// </summary>
    public unsafe virtual int XI_GetChallengeStars(int nId, BmSDK.FString sCharacter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetChallengeStars, "BmScript.RGFxMovieUI_ChallengeSelect.XI_GetChallengeStars");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCharacter, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_XI_RefreshChallengeScores;
    /// <summary>
    /// Function: XI_RefreshChallengeScores
    /// </summary>
    public unsafe virtual void XI_RefreshChallengeScores(int nId, BmSDK.FString sCharacter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_RefreshChallengeScores, "BmScript.RGFxMovieUI_ChallengeSelect.XI_RefreshChallengeScores");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCharacter, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_LaunchChallenge;
    /// <summary>
    /// Function: XI_LaunchChallenge
    /// </summary>
    public unsafe virtual void XI_LaunchChallenge(int nId, BmSDK.FString sCharacter, bool bDefault)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_LaunchChallenge, "BmScript.RGFxMovieUI_ChallengeSelect.XI_LaunchChallenge");
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCharacter, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDefault, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ChallengeSelectEnumerate;
    /// <summary>
    /// Function: XI_ChallengeSelectEnumerate
    /// </summary>
    public unsafe virtual void XI_ChallengeSelectEnumerate(BmSDK.FString sTargetPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ChallengeSelectEnumerate, "BmScript.RGFxMovieUI_ChallengeSelect.XI_ChallengeSelectEnumerate");
        byte* paramsPtr = stackalloc byte[188];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sTargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_FetchExtremeModeToggle;
    /// <summary>
    /// Function: XI_FetchExtremeModeToggle
    /// </summary>
    public unsafe virtual void XI_FetchExtremeModeToggle(int nId, bool bOnSelected = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_FetchExtremeModeToggle, "BmScript.RGFxMovieUI_ChallengeSelect.XI_FetchExtremeModeToggle");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnSelected, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ToggleExtremeMode;
    /// <summary>
    /// Function: XI_ToggleExtremeMode
    /// </summary>
    public unsafe virtual void XI_ToggleExtremeMode(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ToggleExtremeMode, "BmScript.RGFxMovieUI_ChallengeSelect.XI_ToggleExtremeMode");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetExtremeInfo;
    /// <summary>
    /// Function: UC_SetExtremeInfo
    /// </summary>
    public unsafe virtual void UC_SetExtremeInfo(bool bShow)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetExtremeInfo, "BmScript.RGFxMovieUI_ChallengeSelect.UC_SetExtremeInfo");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetChallengeScores;
    /// <summary>
    /// Function: UC_SetChallengeScores
    /// </summary>
    public unsafe virtual void UC_SetChallengeScores(int nId, int nMedals, BmSDK.FString sScore, int nRivalPoints)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetChallengeScores, "BmScript.RGFxMovieUI_ChallengeSelect.UC_SetChallengeScores");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nMedals, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sScore, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nRivalPoints, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_AddChallenge;
    /// <summary>
    /// Function: UC_AddChallenge
    /// </summary>
    public unsafe virtual void UC_AddChallenge(BmSDK.FString Stab, int nId, BmSDK.FString sStatus, BmSDK.FString sMode, int nMedals, BmSDK.FString sScore, int nRivalPoints, BmSDK.FString sActiveCharacter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_AddChallenge, "BmScript.RGFxMovieUI_ChallengeSelect.UC_AddChallenge");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stab, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sStatus, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sMode, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nMedals, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sScore, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nRivalPoints, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sActiveCharacter, paramsPtr + 76);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_AddAvailableCharacter;
    /// <summary>
    /// Function: UC_AddAvailableCharacter
    /// </summary>
    public unsafe virtual void UC_AddAvailableCharacter(BmSDK.FString sName, int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_AddAvailableCharacter, "BmScript.RGFxMovieUI_ChallengeSelect.UC_AddAvailableCharacter");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetDefaultChallenge;
    /// <summary>
    /// Function: UC_SetDefaultChallenge
    /// </summary>
    public unsafe virtual void UC_SetDefaultChallenge(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetDefaultChallenge, "BmScript.RGFxMovieUI_ChallengeSelect.UC_SetDefaultChallenge");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnOut;
    /// <summary>
    /// Function: XI_OnOut
    /// </summary>
    public unsafe override void XI_OnOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnOut, "BmScript.RGFxMovieUI_ChallengeSelect.XI_OnOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe override void CloseScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmScript.RGFxMovieUI_ChallengeSelect.CloseScreen");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.RGFxMovieUI_ChallengeSelect.Init");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StrProperty: m_sMoviePath
    /// </summary>
    public unsafe BmSDK.FString m_sMoviePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// StrProperty: m_sOverridePlayers
    /// </summary>
    public unsafe BmSDK.FString m_sOverridePlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// StrProperty: m_sOverrideBatmobiles
    /// </summary>
    public unsafe BmSDK.FString m_sOverrideBatmobiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ByteProperty: m_eLeaderboardFetchType
    /// </summary>
    public unsafe BmSDK.Engine.UIDataStore_OnlineStats.EStatsFetchType m_eLeaderboardFetchType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIDataStore_OnlineStats.EStatsFetchType>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// IntProperty: m_nLeaderboardChallengeId
    /// </summary>
    public unsafe int m_nLeaderboardChallengeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// IntProperty: m_nLeaderboardId
    /// </summary>
    public unsafe int m_nLeaderboardId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bBeatenByActive
    /// </summary>
    public unsafe bool bBeatenByActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bRePollingLeaderboard
    /// </summary>
    public unsafe bool bRePollingLeaderboard
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bSaveOptions
    /// </summary>
    public unsafe bool bSaveOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bAllowCharacterFilter
    /// </summary>
    public unsafe bool bAllowCharacterFilter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bExtremeModeToggle
    /// </summary>
    public unsafe bool bExtremeModeToggle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bLastFetchEmpty
    /// </summary>
    public unsafe bool bLastFetchEmpty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// Enum: CSLBMode
    /// </summary>
    public enum CSLBMode : byte
    {
        CSLBMode_Friends = 0,
        CSLBMode_Ranked = 1,
        CSLBMode_Top100 = 2,
        CSLBMode_MAX = 3,
    }
}
