#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RChallengeManager<br/>
/// (size = 428)
/// (flags = 134217874)
/// </summary>
public partial class RChallengeManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RChallengeManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RChallengeManager.
    /// </summary>
    public static RChallengeManager DefaultObject => (RChallengeManager)StaticClass().DefaultObject;

    internal RChallengeManager() { }

    /// <summary>
    /// Constructs a new RChallengeManager
    /// </summary>
    public RChallengeManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RChallengeManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RChallengeManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChallengeManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChallengeManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChallengeManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnWorldChange;
    /// <summary>
    /// Function: OnWorldChange
    /// </summary>
    public unsafe virtual void OnWorldChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWorldChange, "BmGame.RChallengeManager.OnWorldChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsScarecrowChallenge;
    /// <summary>
    /// Function: IsScarecrowChallenge
    /// </summary>
    public unsafe virtual bool IsScarecrowChallenge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsScarecrowChallenge, "BmGame.RChallengeManager.IsScarecrowChallenge");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ToTimeString;
    /// <summary>
    /// Function: ToTimeString
    /// </summary>
    public unsafe virtual BmSDK.FString ToTimeString(int Value, bool bMilliseconds)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToTimeString, "BmGame.RChallengeManager.ToTimeString");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMilliseconds, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DumpLBCache;
    /// <summary>
    /// Function: DumpLBCache
    /// </summary>
    public unsafe virtual void DumpLBCache()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpLBCache, "BmGame.RChallengeManager.DumpLBCache");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpINISettings;
    /// <summary>
    /// Function: DumpINISettings
    /// </summary>
    public unsafe virtual void DumpINISettings()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpINISettings, "BmGame.RChallengeManager.DumpINISettings");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Dump;
    /// <summary>
    /// Function: Dump
    /// </summary>
    public unsafe virtual void Dump()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Dump, "BmGame.RChallengeManager.Dump");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRetriesLeft;
    /// <summary>
    /// Function: GetRetriesLeft
    /// </summary>
    public unsafe virtual int GetRetriesLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRetriesLeft, "BmGame.RChallengeManager.GetRetriesLeft");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentURL;
    /// <summary>
    /// Function: GetCurrentURL
    /// </summary>
    public unsafe virtual BmSDK.FString GetCurrentURL()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentURL, "BmGame.RChallengeManager.GetCurrentURL");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentChallengeCharacterName;
    /// <summary>
    /// Function: GetCurrentChallengeCharacterName
    /// </summary>
    public unsafe virtual BmSDK.FString GetCurrentChallengeCharacterName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentChallengeCharacterName, "BmGame.RChallengeManager.GetCurrentChallengeCharacterName");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentChallengeCharacterId;
    /// <summary>
    /// Function: GetCurrentChallengeCharacterId
    /// </summary>
    public unsafe virtual int GetCurrentChallengeCharacterId()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentChallengeCharacterId, "BmGame.RChallengeManager.GetCurrentChallengeCharacterId");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentChallengeId;
    /// <summary>
    /// Function: GetCurrentChallengeId
    /// </summary>
    public unsafe virtual int GetCurrentChallengeId()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentChallengeId, "BmGame.RChallengeManager.GetCurrentChallengeId");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsCampaign;
    /// <summary>
    /// Function: IsCampaign
    /// </summary>
    public unsafe virtual bool IsCampaign()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCampaign, "BmGame.RChallengeManager.IsCampaign");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsLastRound;
    /// <summary>
    /// Function: IsLastRound
    /// </summary>
    public unsafe virtual bool IsLastRound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLastRound, "BmGame.RChallengeManager.IsLastRound");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentRound;
    /// <summary>
    /// Function: GetCurrentRound
    /// </summary>
    public unsafe virtual int GetCurrentRound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentRound, "BmGame.RChallengeManager.GetCurrentRound");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetNextRound;
    /// <summary>
    /// Function: SetNextRound
    /// </summary>
    public unsafe virtual void SetNextRound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNextRound, "BmGame.RChallengeManager.SetNextRound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsModifierActive;
    /// <summary>
    /// Function: IsModifierActive
    /// </summary>
    public unsafe virtual bool IsModifierActive(BmSDK.BmGame.RGameInfo.EChallengeModifiers new_modifier)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsModifierActive, "BmGame.RChallengeManager.IsModifierActive");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_modifier, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PlayerAcceptsCurrentRoundResults;
    /// <summary>
    /// Function: PlayerAcceptsCurrentRoundResults
    /// </summary>
    public unsafe virtual void PlayerAcceptsCurrentRoundResults()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerAcceptsCurrentRoundResults, "BmGame.RChallengeManager.PlayerAcceptsCurrentRoundResults");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRoundMedalsEarned;
    /// <summary>
    /// Function: SetRoundMedalsEarned
    /// </summary>
    public unsafe virtual void SetRoundMedalsEarned(int Round, byte medals_earned)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRoundMedalsEarned, "BmGame.RChallengeManager.SetRoundMedalsEarned");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Round, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(medals_earned, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetActiveRound;
    /// <summary>
    /// Function: SetActiveRound
    /// </summary>
    public unsafe virtual void SetActiveRound(int Round)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetActiveRound, "BmGame.RChallengeManager.SetActiveRound");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Round, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BuildChallengeList;
    /// <summary>
    /// Function: BuildChallengeList
    /// </summary>
    public unsafe virtual void BuildChallengeList(int ChallengeID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuildChallengeList, "BmGame.RChallengeManager.BuildChallengeList");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FilloutChallengeMatch;
    /// <summary>
    /// Function: FilloutChallengeMatch
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RChallengeManager.FChallengeMatch FilloutChallengeMatch(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FilloutChallengeMatch, "BmGame.RChallengeManager.FilloutChallengeMatch");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RChallengeManager.FChallengeMatch>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ExitChallengeMode;
    /// <summary>
    /// Function: ExitChallengeMode
    /// </summary>
    public unsafe virtual void ExitChallengeMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitChallengeMode, "BmGame.RChallengeManager.ExitChallengeMode");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterChallengeMode;
    /// <summary>
    /// Function: EnterChallengeMode
    /// </summary>
    public unsafe virtual void EnterChallengeMode(BmSDK.BmGame.RChallengeModeStartPointBase hStartPoint, bool bInGameStart)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterChallengeMode, "BmGame.RChallengeManager.EnterChallengeMode");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hStartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInGameStart, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDefaults;
    /// <summary>
    /// Function: SetDefaults
    /// </summary>
    public unsafe virtual void SetDefaults()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDefaults, "BmGame.RChallengeManager.SetDefaults");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetScoreOrTimeText;
    /// <summary>
    /// Function: GetScoreOrTimeText
    /// </summary>
    public unsafe virtual BmSDK.FString GetScoreOrTimeText(int nId, int nScore, bool bEmptyIfZero = default, bool bMilliseconds = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreOrTimeText, "BmGame.RChallengeManager.GetScoreOrTimeText");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nScore, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEmptyIfZero, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMilliseconds, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetRankMode;
    /// <summary>
    /// Function: GetRankMode
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.EChallengeRankMode GetRankMode(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRankMode, "BmGame.RChallengeManager.GetRankMode");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.EChallengeRankMode>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetRivalPointLimit;
    /// <summary>
    /// Function: GetRivalPointLimit
    /// </summary>
    public unsafe virtual int GetRivalPointLimit(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRivalPointLimit, "BmGame.RChallengeManager.GetRivalPointLimit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsTimeBasedMap;
    /// <summary>
    /// Function: IsTimeBasedMap
    /// </summary>
    public unsafe virtual bool IsTimeBasedMap(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTimeBasedMap, "BmGame.RChallengeManager.IsTimeBasedMap");
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsUniqueGoalMap;
    /// <summary>
    /// Function: IsUniqueGoalMap
    /// </summary>
    public unsafe virtual bool IsUniqueGoalMap(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsUniqueGoalMap, "BmGame.RChallengeManager.IsUniqueGoalMap");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsStillStreaming;
    /// <summary>
    /// Function: IsStillStreaming
    /// </summary>
    public unsafe virtual bool IsStillStreaming(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStillStreaming, "BmGame.RChallengeManager.IsStillStreaming");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShouldIgnoreGameState;
    /// <summary>
    /// Function: ShouldIgnoreGameState
    /// </summary>
    public unsafe virtual bool ShouldIgnoreGameState(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldIgnoreGameState, "BmGame.RChallengeManager.ShouldIgnoreGameState");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsBattleModeMap;
    /// <summary>
    /// Function: IsBattleModeMap
    /// </summary>
    public unsafe virtual bool IsBattleModeMap(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBattleModeMap, "BmGame.RChallengeManager.IsBattleModeMap");
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsDrivingMap;
    /// <summary>
    /// Function: IsDrivingMap
    /// </summary>
    public unsafe virtual bool IsDrivingMap(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDrivingMap, "BmGame.RChallengeManager.IsDrivingMap");
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsTrainingMap;
    /// <summary>
    /// Function: IsTrainingMap
    /// </summary>
    public unsafe virtual bool IsTrainingMap(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTrainingMap, "BmGame.RChallengeManager.IsTrainingMap");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetStartRef;
    /// <summary>
    /// Function: GetStartRef
    /// </summary>
    public unsafe virtual BmSDK.FString GetStartRef(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStartRef, "BmGame.RChallengeManager.GetStartRef");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPlayableBatmobile;
    /// <summary>
    /// Function: GetPlayableBatmobile
    /// </summary>
    public unsafe virtual BmSDK.FString GetPlayableBatmobile(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayableBatmobile, "BmGame.RChallengeManager.GetPlayableBatmobile");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPlayableCharacter;
    /// <summary>
    /// Function: GetPlayableCharacter
    /// </summary>
    public unsafe virtual BmSDK.FString GetPlayableCharacter(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayableCharacter, "BmGame.RChallengeManager.GetPlayableCharacter");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNavigationLocationByID;
    /// <summary>
    /// Function: GetNavigationLocationByID
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetNavigationLocationByID(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNavigationLocationByID, "BmGame.RChallengeManager.GetNavigationLocationByID");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ValidateSorting;
    /// <summary>
    /// Function: ValidateSorting
    /// </summary>
    public unsafe virtual void ValidateSorting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ValidateSorting, "BmGame.RChallengeManager.ValidateSorting");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__ChallengeDataSort;
    /// <summary>
    /// Function: _ChallengeDataSort
    /// </summary>
    public unsafe virtual int _ChallengeDataSort(BmSDK.BmGame.RGameInfo.FChallengeDesc A, BmSDK.BmGame.RGameInfo.FChallengeDesc B)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__ChallengeDataSort, "BmGame.RChallengeManager._ChallengeDataSort");
        byte* paramsPtr = stackalloc byte[252];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 116);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 232);
    }

    private static BmSDK.Function __fn_UpdateWaypointArrowMarker;
    /// <summary>
    /// Function: UpdateWaypointArrowMarker
    /// </summary>
    public unsafe virtual void UpdateWaypointArrowMarker(System.Numerics.Vector3 vLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateWaypointArrowMarker, "BmGame.RChallengeManager.UpdateWaypointArrowMarker");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitializeWaypointArrowMarker;
    /// <summary>
    /// Function: InitializeWaypointArrowMarker
    /// </summary>
    public unsafe virtual void InitializeWaypointArrowMarker(BmSDK.Engine.ParticleSystem iParticles)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitializeWaypointArrowMarker, "BmGame.RChallengeManager.InitializeWaypointArrowMarker");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iParticles, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AwardChallengeUpgradePoint;
    /// <summary>
    /// Function: AwardChallengeUpgradePoint
    /// </summary>
    public unsafe virtual void AwardChallengeUpgradePoint(int nChallengeId, int nPointsToAward = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardChallengeUpgradePoint, "BmGame.RChallengeManager.AwardChallengeUpgradePoint");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nChallengeId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPointsToAward, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLastChallengeUnlockedFresh;
    /// <summary>
    /// Function: GetLastChallengeUnlockedFresh
    /// </summary>
    public unsafe virtual BmSDK.FString GetLastChallengeUnlockedFresh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLastChallengeUnlockedFresh, "BmGame.RChallengeManager.GetLastChallengeUnlockedFresh");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetChallengeCategoryStringWheel;
    /// <summary>
    /// Function: GetChallengeCategoryStringWheel
    /// </summary>
    public unsafe virtual BmSDK.FString GetChallengeCategoryStringWheel(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChallengeCategoryStringWheel, "BmGame.RChallengeManager.GetChallengeCategoryStringWheel");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TriggerChallengeUnlockRequirement;
    /// <summary>
    /// Function: TriggerChallengeUnlockRequirement
    /// </summary>
    public unsafe virtual bool TriggerChallengeUnlockRequirement(int nChallengeId, int nLock = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerChallengeUnlockRequirement, "BmGame.RChallengeManager.TriggerChallengeUnlockRequirement");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nChallengeId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nLock, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetDifficulty;
    /// <summary>
    /// Function: GetDifficulty
    /// </summary>
    public unsafe virtual int GetDifficulty(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDifficulty, "BmGame.RChallengeManager.GetDifficulty");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetLeaderboardId;
    /// <summary>
    /// Function: GetLeaderboardId
    /// </summary>
    public unsafe virtual int GetLeaderboardId(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLeaderboardId, "BmGame.RChallengeManager.GetLeaderboardId");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_EnablePrerequisite;
    /// <summary>
    /// Function: EnablePrerequisite
    /// </summary>
    public unsafe virtual void EnablePrerequisite(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnablePrerequisite, "BmGame.RChallengeManager.EnablePrerequisite");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsChallengeFrontendOnly;
    /// <summary>
    /// Function: IsChallengeFrontendOnly
    /// </summary>
    public unsafe virtual bool IsChallengeFrontendOnly(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsChallengeFrontendOnly, "BmGame.RChallengeManager.IsChallengeFrontendOnly");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsPrerequisiteMet;
    /// <summary>
    /// Function: IsPrerequisiteMet
    /// </summary>
    public unsafe virtual bool IsPrerequisiteMet(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPrerequisiteMet, "BmGame.RChallengeManager.IsPrerequisiteMet");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShouldShowCompass;
    /// <summary>
    /// Function: ShouldShowCompass
    /// </summary>
    public unsafe virtual bool ShouldShowCompass()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldShowCompass, "BmGame.RChallengeManager.ShouldShowCompass");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFrontendGroupByID;
    /// <summary>
    /// Function: GetFrontendGroupByID
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.EChallengeFrontendGroup GetFrontendGroupByID(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFrontendGroupByID, "BmGame.RChallengeManager.GetFrontendGroupByID");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.EChallengeFrontendGroup>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDescriptionByID;
    /// <summary>
    /// Function: GetDescriptionByID
    /// </summary>
    public unsafe virtual BmSDK.FString GetDescriptionByID(int Id, bool bDebrief = default, bool bCompleted = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDescriptionByID, "BmGame.RChallengeManager.GetDescriptionByID");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebrief, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCompleted, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetTitleByIDLocalised;
    /// <summary>
    /// Function: GetTitleByIDLocalised
    /// </summary>
    public unsafe virtual BmSDK.FString GetTitleByIDLocalised(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTitleByIDLocalised, "BmGame.RChallengeManager.GetTitleByIDLocalised");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTitleByID;
    /// <summary>
    /// Function: GetTitleByID
    /// </summary>
    public unsafe virtual BmSDK.FString GetTitleByID(int Id, bool bMixedCase = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTitleByID, "BmGame.RChallengeManager.GetTitleByID");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMixedCase, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetChallengeMapIndex;
    /// <summary>
    /// Function: GetChallengeMapIndex
    /// </summary>
    public unsafe virtual int GetChallengeMapIndex(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChallengeMapIndex, "BmGame.RChallengeManager.GetChallengeMapIndex");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetRGI;
    /// <summary>
    /// Function: GetRGI
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo GetRGI()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRGI, "BmGame.RChallengeManager.GetRGI");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetNextToPoll;
    /// <summary>
    /// Function: SetNextToPoll
    /// </summary>
    public unsafe virtual void SetNextToPoll(BmSDK.BmGame.RPlayerController RPC, int LeaderboardId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNextToPoll, "BmGame.RChallengeManager.SetNextToPoll");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeaderboardId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsChallengeDLC;
    /// <summary>
    /// Function: IsChallengeDLC
    /// </summary>
    public unsafe virtual bool IsChallengeDLC(int nChallengeId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsChallengeDLC, "BmGame.RChallengeManager.IsChallengeDLC");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nChallengeId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsLeaderboardFetchInProgress;
    /// <summary>
    /// Function: IsLeaderboardFetchInProgress
    /// </summary>
    public unsafe virtual bool IsLeaderboardFetchInProgress()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLeaderboardFetchInProgress, "BmGame.RChallengeManager.IsLeaderboardFetchInProgress");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetChallengeCountByFrontendGroup;
    /// <summary>
    /// Function: GetChallengeCountByFrontendGroup
    /// </summary>
    public unsafe virtual int GetChallengeCountByFrontendGroup(BmSDK.BmGame.RGameInfo.EChallengeFrontendGroup eMin, BmSDK.BmGame.RGameInfo.EChallengeFrontendGroup eMax, bool bInclusive)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChallengeCountByFrontendGroup, "BmGame.RChallengeManager.GetChallengeCountByFrontendGroup");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eMin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eMax, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInclusive, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetFriendBeatYouMsg;
    /// <summary>
    /// Function: GetFriendBeatYouMsg
    /// </summary>
    public unsafe virtual bool GetFriendBeatYouMsg(out BmSDK.BmGame.RChallengeManager.FBeatenMsg msg)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFriendBeatYouMsg, "BmGame.RChallengeManager.GetFriendBeatYouMsg");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        msg = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RChallengeManager.FBeatenMsg>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetCachedLeaderboardData;
    /// <summary>
    /// Function: GetCachedLeaderboardData
    /// </summary>
    public unsafe virtual bool GetCachedLeaderboardData(int nChallengeId, int nFriendIndex, out BmSDK.FString sName, out int nScore, out int nMedals)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCachedLeaderboardData, "BmGame.RChallengeManager.GetCachedLeaderboardData");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nChallengeId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nFriendIndex, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out nScore);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nScore, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out nMedals);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nMedals, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        sName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
        nScore = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
        nMedals = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetCachedLeaderboardErrorCode;
    /// <summary>
    /// Function: GetCachedLeaderboardErrorCode
    /// </summary>
    public unsafe virtual int GetCachedLeaderboardErrorCode(int nChallengeId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCachedLeaderboardErrorCode, "BmGame.RChallengeManager.GetCachedLeaderboardErrorCode");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nChallengeId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCachedLeaderboardCycle;
    /// <summary>
    /// Function: GetCachedLeaderboardCycle
    /// </summary>
    public unsafe virtual int GetCachedLeaderboardCycle(int nChallengeId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCachedLeaderboardCycle, "BmGame.RChallengeManager.GetCachedLeaderboardCycle");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nChallengeId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetLastCachedLeaderboardIndex;
    /// <summary>
    /// Function: GetLastCachedLeaderboardIndex
    /// </summary>
    public unsafe virtual int GetLastCachedLeaderboardIndex(int nChallengeId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLastCachedLeaderboardIndex, "BmGame.RChallengeManager.GetLastCachedLeaderboardIndex");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nChallengeId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetMyCachedLeaderboardIndex;
    /// <summary>
    /// Function: GetMyCachedLeaderboardIndex
    /// </summary>
    public unsafe virtual int GetMyCachedLeaderboardIndex(int nChallengeId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMyCachedLeaderboardIndex, "BmGame.RChallengeManager.GetMyCachedLeaderboardIndex");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nChallengeId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckQueuedLeaderboardBeatenByMessages;
    /// <summary>
    /// Function: CheckQueuedLeaderboardBeatenByMessages
    /// </summary>
    public unsafe virtual void CheckQueuedLeaderboardBeatenByMessages()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckQueuedLeaderboardBeatenByMessages, "BmGame.RChallengeManager.CheckQueuedLeaderboardBeatenByMessages");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueLeaderboardBeatenByMessage;
    /// <summary>
    /// Function: QueueLeaderboardBeatenByMessage
    /// </summary>
    public unsafe virtual void QueueLeaderboardBeatenByMessage(int ChallengeID, int LeaderboardId, BmSDK.FString NickName, int Score, int Medals)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueLeaderboardBeatenByMessage, "BmGame.RChallengeManager.QueueLeaderboardBeatenByMessage");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeaderboardId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NickName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Medals, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadLBCache;
    /// <summary>
    /// Function: LoadLBCache
    /// </summary>
    public unsafe virtual void LoadLBCache()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadLBCache, "BmGame.RChallengeManager.LoadLBCache");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_SaveLBCache;
    /// <summary>
    /// Function: SaveLBCache
    /// </summary>
    public unsafe virtual void SaveLBCache()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveLBCache, "BmGame.RChallengeManager.SaveLBCache");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_MarkChallengeLeaderboardAsPlayed;
    /// <summary>
    /// Function: MarkChallengeLeaderboardAsPlayed
    /// </summary>
    public unsafe virtual void MarkChallengeLeaderboardAsPlayed(int ChallengeID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MarkChallengeLeaderboardAsPlayed, "BmGame.RChallengeManager.MarkChallengeLeaderboardAsPlayed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckLeaderboards;
    /// <summary>
    /// Function: CheckLeaderboards
    /// </summary>
    public unsafe virtual void CheckLeaderboards(BmSDK.BmGame.RPlayerController RPC, float Time)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckLeaderboards, "BmGame.RChallengeManager.CheckLeaderboards");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFriendsPollEnabled;
    /// <summary>
    /// Function: SetFriendsPollEnabled
    /// </summary>
    public unsafe virtual void SetFriendsPollEnabled(bool bEnabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFriendsPollEnabled, "BmGame.RChallengeManager.SetFriendsPollEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnStatsReadComplete;
    /// <summary>
    /// Function: OnStatsReadComplete
    /// </summary>
    public unsafe virtual void OnStatsReadComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnStatsReadComplete, "BmGame.RChallengeManager.OnStatsReadComplete");
        byte* paramsPtr = stackalloc byte[152];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadLeaderboard;
    /// <summary>
    /// Function: ReadLeaderboard
    /// </summary>
    public unsafe virtual void ReadLeaderboard(int ControllerId, int LeaderboardId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadLeaderboard, "BmGame.RChallengeManager.ReadLeaderboard");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeaderboardId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearChallengeSymbols;
    /// <summary>
    /// Function: ClearChallengeSymbols
    /// </summary>
    public unsafe virtual void ClearChallengeSymbols()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearChallengeSymbols, "BmGame.RChallengeManager.ClearChallengeSymbols");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChallengeSymbolsShouldHideHud;
    /// <summary>
    /// Function: ChallengeSymbolsShouldHideHud
    /// </summary>
    public unsafe virtual bool ChallengeSymbolsShouldHideHud()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChallengeSymbolsShouldHideHud, "BmGame.RChallengeManager.ChallengeSymbolsShouldHideHud");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Struct: FBeatenMsg
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FBeatenMsg
    {
        /// <summary>
        /// IntProperty: ChallengeID
        /// </summary>
        public unsafe int ChallengeID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: LeaderboardId
        /// </summary>
        public unsafe int LeaderboardId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Score
        /// </summary>
        public unsafe int Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: Medals
        /// </summary>
        public unsafe int Medals
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StrProperty: NickName
        /// </summary>
        public unsafe BmSDK.FString NickName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bSent
        /// </summary>
        public unsafe bool bSent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Struct: FLeaderboardCached
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 76)]
    public partial record struct FLeaderboardCached
    {
        /// <summary>
        /// ArrayProperty: Ranks
        /// </summary>
        public unsafe BmSDK.TArray<int> Ranks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: NickNames
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> NickNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ArrayProperty: Medals
        /// </summary>
        public unsafe BmSDK.TArray<int> Medals
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ArrayProperty: Scores
        /// </summary>
        public unsafe BmSDK.TArray<int> Scores
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// IntProperty: MyIndex
        /// </summary>
        public unsafe int MyIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// IntProperty: Cycle
        /// </summary>
        public unsafe int Cycle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// IntProperty: ErrorCode
        /// </summary>
        public unsafe int ErrorCode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }
    }

    /// <summary>
    /// Struct: FChallengeMatch
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FChallengeMatch
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
        /// IntProperty: PackId
        /// </summary>
        public unsafe int PackId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: LeaderboardId
        /// </summary>
        public unsafe int LeaderboardId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bPredator
        /// </summary>
        public unsafe bool bPredator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: ChallengeStartPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RChallengeModeStartPointBase ChallengeStartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChallengeModeStartPointBase>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeController
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_IntegratedChallengeBase ChallengeController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_IntegratedChallengeBase>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: MainMovieUI
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieUI_ChallengeSymbol MainMovieUI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieUI_ChallengeSymbol>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: MiniMovieUI
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieUI_ChallengeSymbolMini MiniMovieUI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieUI_ChallengeSymbolMini>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: NextWaypoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor NextWaypoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ObjectProperty: NextWaypointArrowEmitter
    /// </summary>
    public unsafe BmSDK.Engine.REmitter NextWaypointArrowEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: StatsReadObject
    /// </summary>
    public unsafe BmSDK.BmGame.ROnlineStatsRead StatsReadObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.ROnlineStatsRead>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// StructProperty: ChallengeBestSourceLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ChallengeBestSourceLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 140);

    /// <summary>
    /// StructProperty: ChallengeBestSourceDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ChallengeBestSourceDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 152);

    /// <summary>
    /// IntProperty: ChallengeBestId
    /// </summary>
    public unsafe int ChallengeBestId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// IntProperty: AwardedPointsDuringChallenge
    /// </summary>
    public unsafe int AwardedPointsDuringChallenge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: AwardedPointsDuringTutorial
    /// </summary>
    public unsafe bool AwardedPointsDuringTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: StartedInGame
    /// </summary>
    public unsafe bool StartedInGame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: NewBestRank
    /// </summary>
    public unsafe bool NewBestRank
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bPoll_Enabled
    /// </summary>
    public unsafe bool bPoll_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bPoll_DelayBeforeNextProximtyAdd
    /// </summary>
    public unsafe bool bPoll_DelayBeforeNextProximtyAdd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bPoll_Fetching
    /// </summary>
    public unsafe bool bPoll_Fetching
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: PlayerHasVisitedMainMenuSinceLastRestart
    /// </summary>
    public unsafe bool PlayerHasVisitedMainMenuSinceLastRestart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: ResetPlayerWaypointOnNextLoad
    /// </summary>
    public unsafe bool ResetPlayerWaypointOnNextLoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bExtremeModeToggle
    /// </summary>
    public unsafe bool bExtremeModeToggle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// IntProperty: ChallengeMapIndexCachedId
    /// </summary>
    public unsafe int ChallengeMapIndexCachedId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// IntProperty: ChallengeMapIndexCached
    /// </summary>
    public unsafe int ChallengeMapIndexCached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// IntProperty: ChallengeMapListCachedLength
    /// </summary>
    public unsafe int ChallengeMapListCachedLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// IntProperty: LastPlayedFrontendChallenge
    /// </summary>
    public unsafe int LastPlayedFrontendChallenge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ArrayProperty: CampaignModifiersUsed
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EChallengeModifiers> CampaignModifiersUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EChallengeModifiers>>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// ArrayProperty: ModifiersCurrentlyActive
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EChallengeModifiers> ModifiersCurrentlyActive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EChallengeModifiers>>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// ArrayProperty: CampaignMedalsEarned
    /// </summary>
    public unsafe BmSDK.TArray<byte> CampaignMedalsEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// ArrayProperty: Rounds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FChallengeMatch> Rounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FChallengeMatch>>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// IntProperty: ActiveEpisodeId
    /// </summary>
    public unsafe int ActiveEpisodeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// IntProperty: CampaignId
    /// </summary>
    public unsafe int CampaignId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// IntProperty: CurrentChallengeId
    /// </summary>
    public unsafe int CurrentChallengeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// IntProperty: CurrentLeaderboardId
    /// </summary>
    public unsafe int CurrentLeaderboardId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// StrProperty: SelectedMapURL
    /// </summary>
    public unsafe BmSDK.FString SelectedMapURL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// IntProperty: CurrentRound
    /// </summary>
    public unsafe int CurrentRound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// IntProperty: CurrentRetrysLeft
    /// </summary>
    public unsafe int CurrentRetrysLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// IntProperty: MWCachedRating
    /// </summary>
    public unsafe int MWCachedRating
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// FloatProperty: Poll_Delay
    /// </summary>
    public unsafe float Poll_Delay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// FloatProperty: TimeLast
    /// </summary>
    public unsafe float TimeLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// StrProperty: OurNickName
    /// </summary>
    public unsafe BmSDK.FString OurNickName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// IntProperty: Poll_ChallengeLeaderboardIdToCheck
    /// </summary>
    public unsafe int Poll_ChallengeLeaderboardIdToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// IntProperty: Poll_ChallengeId
    /// </summary>
    public unsafe int Poll_ChallengeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// IntProperty: Poll_NextIndexToCheck
    /// </summary>
    public unsafe int Poll_NextIndexToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// ArrayProperty: LeaderboardCache
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FLeaderboardCached> LeaderboardCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FLeaderboardCached>>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// ArrayProperty: BeatenQueue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FBeatenMsg> BeatenQueue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FBeatenMsg>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// FloatProperty: TimeStampChallengeUnlockFresh
    /// </summary>
    public unsafe float TimeStampChallengeUnlockFresh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// StrProperty: LastChallengeUnlocked
    /// </summary>
    public unsafe BmSDK.FString LastChallengeUnlocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// IntProperty: MostRecentDamagerGangAffiliation
    /// </summary>
    public unsafe int MostRecentDamagerGangAffiliation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// StrProperty: MostRecentDeathMovieString
    /// </summary>
    public unsafe BmSDK.FString MostRecentDeathMovieString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// IntProperty: CurrentChallengeCharacterId
    /// </summary>
    public unsafe int CurrentChallengeCharacterId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ArrayProperty: LeaderboardCacheBoardIdsPlayed
    /// </summary>
    public unsafe BmSDK.TArray<byte> LeaderboardCacheBoardIdsPlayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// Struct: FCountsByCharacter
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FCountsByCharacter
    {
        /// <summary>
        /// IntProperty: Ranked
        /// </summary>
        public unsafe int Ranked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: RankedTotal
        /// </summary>
        public unsafe int RankedTotal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: RankedDLC
        /// </summary>
        public unsafe int RankedDLC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: RankedDLCTotal
        /// </summary>
        public unsafe int RankedDLCTotal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: Custom
        /// </summary>
        public unsafe int Custom
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: CustomTotal
        /// </summary>
        public unsafe int CustomTotal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: CustomDLC
        /// </summary>
        public unsafe int CustomDLC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: CustomDLCTotal
        /// </summary>
        public unsafe int CustomDLCTotal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: Campaign
        /// </summary>
        public unsafe int Campaign
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: CampaignTotal
        /// </summary>
        public unsafe int CampaignTotal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: CampaignDLC
        /// </summary>
        public unsafe int CampaignDLC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: CampaignDLCTotal
        /// </summary>
        public unsafe int CampaignDLCTotal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }

    /// <summary>
    /// Enum: ChallengeScreenModes
    /// </summary>
    public enum ChallengeScreenModes : byte
    {
        CSM_Briefing = 0,
        CSM_Backscreen = 1,
        CSM_Debrief = 2,
        CSM_MAX = 3,
    }
}
