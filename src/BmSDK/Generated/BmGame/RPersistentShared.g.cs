#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPersistentShared<br/>
/// (size = 1032)
/// (flags = 134217878)
/// </summary>
public partial class RPersistentShared : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPersistentShared", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPersistentShared.
    /// </summary>
    public static RPersistentShared DefaultObject => (RPersistentShared)StaticClass().DefaultObject;

    internal RPersistentShared() { }

    /// <summary>
    /// Constructs a new RPersistentShared
    /// </summary>
    public RPersistentShared(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPersistentShared Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPersistentShared(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPersistentShared>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentShared>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPersistentShared>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentShared>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentShared>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentShared>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPersistentShared>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentShared>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UpgradesPurchasedAdjust;
    /// <summary>
    /// Function: UpgradesPurchasedAdjust
    /// </summary>
    public unsafe virtual void UpgradesPurchasedAdjust(int nUpgrades)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpgradesPurchasedAdjust, "BmGame.RPersistentShared.UpgradesPurchasedAdjust");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nUpgrades, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpgradePointsSpent;
    /// <summary>
    /// Function: UpgradePointsSpent
    /// </summary>
    public unsafe virtual void UpgradePointsSpent(int nPoints)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpgradePointsSpent, "BmGame.RPersistentShared.UpgradePointsSpent");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPoints, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpgradePointsEarned;
    /// <summary>
    /// Function: UpgradePointsEarned
    /// </summary>
    public unsafe virtual void UpgradePointsEarned(int nPoints)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpgradePointsEarned, "BmGame.RPersistentShared.UpgradePointsEarned");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPoints, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEpisodeProgress;
    /// <summary>
    /// Function: GetEpisodeProgress
    /// </summary>
    public unsafe virtual void GetEpisodeProgress(int Uid, out int OutProgress, out int OutNew)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEpisodeProgress, "BmGame.RPersistentShared.GetEpisodeProgress");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Uid, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutProgress = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        OutNew = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_SetEpisodeProgress;
    /// <summary>
    /// Function: SetEpisodeProgress
    /// </summary>
    public unsafe virtual void SetEpisodeProgress(int Uid, int Percent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEpisodeProgress, "BmGame.RPersistentShared.SetEpisodeProgress");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Uid, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Percent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearStoryNew;
    /// <summary>
    /// Function: ClearStoryNew
    /// </summary>
    public unsafe virtual void ClearStoryNew(int Uid)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearStoryNew, "BmGame.RPersistentShared.ClearStoryNew");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Uid, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsEpisodeNew;
    /// <summary>
    /// Function: IsEpisodeNew
    /// </summary>
    public unsafe virtual bool IsEpisodeNew(int Uid)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsEpisodeNew, "BmGame.RPersistentShared.IsEpisodeNew");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Uid, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IncSkillPointCategoryCount;
    /// <summary>
    /// Function: IncSkillPointCategoryCount
    /// </summary>
    public unsafe virtual void IncSkillPointCategoryCount(BmSDK.BmGame.RPersistentShared.SkillPointCategories Category, int IncAmount = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncSkillPointCategoryCount, "BmGame.RPersistentShared.IncSkillPointCategoryCount");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Category, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddSkillPointDetail;
    /// <summary>
    /// Function: AddSkillPointDetail
    /// </summary>
    public unsafe virtual void AddSkillPointDetail(BmSDK.FString DetailString)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSkillPointDetail, "BmGame.RPersistentShared.AddSkillPointDetail");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DetailString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearSkillPointDetails;
    /// <summary>
    /// Function: ClearSkillPointDetails
    /// </summary>
    public unsafe virtual void ClearSkillPointDetails()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearSkillPointDetails, "BmGame.RPersistentShared.ClearSkillPointDetails");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SkillPointEncounterFinished;
    /// <summary>
    /// Function: SkillPointEncounterFinished
    /// </summary>
    public unsafe virtual void SkillPointEncounterFinished(int SkillPointsEarned, BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SkillPointEncounterFinished, "BmGame.RPersistentShared.SkillPointEncounterFinished");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkillPointsEarned, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRiddlerProgressionProportion;
    /// <summary>
    /// Function: GetRiddlerProgressionProportion
    /// </summary>
    public unsafe virtual float GetRiddlerProgressionProportion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRiddlerProgressionProportion, "BmGame.RPersistentShared.GetRiddlerProgressionProportion");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRiddlerProgressionAbsolute;
    /// <summary>
    /// Function: GetRiddlerProgressionAbsolute
    /// </summary>
    public unsafe virtual int GetRiddlerProgressionAbsolute()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRiddlerProgressionAbsolute, "BmGame.RPersistentShared.GetRiddlerProgressionAbsolute");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AllCamerasBroken;
    /// <summary>
    /// Function: AllCamerasBroken
    /// </summary>
    public unsafe virtual bool AllCamerasBroken()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllCamerasBroken, "BmGame.RPersistentShared.AllCamerasBroken");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IncreasePenguinBrokenCount;
    /// <summary>
    /// Function: IncreasePenguinBrokenCount
    /// </summary>
    public unsafe virtual int IncreasePenguinBrokenCount(BmSDK.BmGame.RGameInfo.ERiddlerLocationName Zone)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreasePenguinBrokenCount, "BmGame.RPersistentShared.IncreasePenguinBrokenCount");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IncreaseJokerBalloonPoppedCount;
    /// <summary>
    /// Function: IncreaseJokerBalloonPoppedCount
    /// </summary>
    public unsafe virtual int IncreaseJokerBalloonPoppedCount(BmSDK.BmGame.RGameInfo.ERiddlerLocationName Zone)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseJokerBalloonPoppedCount, "BmGame.RPersistentShared.IncreaseJokerBalloonPoppedCount");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IncreaseJokerTeethCount;
    /// <summary>
    /// Function: IncreaseJokerTeethCount
    /// </summary>
    public unsafe virtual int IncreaseJokerTeethCount(BmSDK.BmGame.RGameInfo.ERiddlerLocationName Zone)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseJokerTeethCount, "BmGame.RPersistentShared.IncreaseJokerTeethCount");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IncreaseRiddleCount;
    /// <summary>
    /// Function: IncreaseRiddleCount
    /// </summary>
    public unsafe virtual int IncreaseRiddleCount(BmSDK.BmGame.RGameInfo.ERiddlerLocationName Zone)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseRiddleCount, "BmGame.RPersistentShared.IncreaseRiddleCount");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CWTotalPossiblePickupsAndChallenges;
    /// <summary>
    /// Function: CWTotalPossiblePickupsAndChallenges
    /// </summary>
    public unsafe virtual int CWTotalPossiblePickupsAndChallenges()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CWTotalPossiblePickupsAndChallenges, "BmGame.RPersistentShared.CWTotalPossiblePickupsAndChallenges");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CWPickupsAndChallengesCompleteCount;
    /// <summary>
    /// Function: CWPickupsAndChallengesCompleteCount
    /// </summary>
    public unsafe virtual int CWPickupsAndChallengesCompleteCount()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CWPickupsAndChallengesCompleteCount, "BmGame.RPersistentShared.CWPickupsAndChallengesCompleteCount");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CWPickupsAndChallengesComplete;
    /// <summary>
    /// Function: CWPickupsAndChallengesComplete
    /// </summary>
    public unsafe virtual bool CWPickupsAndChallengesComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CWPickupsAndChallengesComplete, "BmGame.RPersistentShared.CWPickupsAndChallengesComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCWPickupsTotalCollected;
    /// <summary>
    /// Function: GetCWPickupsTotalCollected
    /// </summary>
    public unsafe virtual int GetCWPickupsTotalCollected()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCWPickupsTotalCollected, "BmGame.RPersistentShared.GetCWPickupsTotalCollected");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IncreaseCWPickupCount;
    /// <summary>
    /// Function: IncreaseCWPickupCount
    /// </summary>
    public unsafe virtual int IncreaseCWPickupCount(BmSDK.BmGame.RGameInfo.ERiddlerLocationName Zone)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseCWPickupCount, "BmGame.RPersistentShared.IncreaseCWPickupCount");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IncreasePickupCount;
    /// <summary>
    /// Function: IncreasePickupCount
    /// </summary>
    public unsafe virtual int IncreasePickupCount(BmSDK.BmGame.RGameInfo.ERiddlerLocationName Zone)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreasePickupCount, "BmGame.RPersistentShared.IncreasePickupCount");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IncreaseBrokenDemonSealCount;
    /// <summary>
    /// Function: IncreaseBrokenDemonSealCount
    /// </summary>
    public unsafe virtual int IncreaseBrokenDemonSealCount()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseBrokenDemonSealCount, "BmGame.RPersistentShared.IncreaseBrokenDemonSealCount");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IncreaseBrokenHarleyHeadCount;
    /// <summary>
    /// Function: IncreaseBrokenHarleyHeadCount
    /// </summary>
    public unsafe virtual int IncreaseBrokenHarleyHeadCount()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseBrokenHarleyHeadCount, "BmGame.RPersistentShared.IncreaseBrokenHarleyHeadCount");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateBatChallenge;
    /// <summary>
    /// Function: UpdateBatChallenge
    /// </summary>
    public unsafe virtual void UpdateBatChallenge(BmSDK.BmGame.RPersistentData.EBatmanChallenge Entry, float InValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateBatChallenge, "BmGame.RPersistentShared.UpdateBatChallenge");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InValue, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBatChallengeAsBeaten;
    /// <summary>
    /// Function: IsBatChallengeAsBeaten
    /// </summary>
    public unsafe virtual bool IsBatChallengeAsBeaten(BmSDK.BmGame.RPersistentData.EBatmanChallenge Entry)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatChallengeAsBeaten, "BmGame.RPersistentShared.IsBatChallengeAsBeaten");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetBatChallengeAsBeaten;
    /// <summary>
    /// Function: SetBatChallengeAsBeaten
    /// </summary>
    public unsafe virtual void SetBatChallengeAsBeaten(BmSDK.BmGame.RPersistentData.EBatmanChallenge Entry)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBatChallengeAsBeaten, "BmGame.RPersistentShared.SetBatChallengeAsBeaten");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBatChallengeValueNeeded;
    /// <summary>
    /// Function: GetBatChallengeValueNeeded
    /// </summary>
    public unsafe virtual float GetBatChallengeValueNeeded(BmSDK.BmGame.RPersistentData.EBatmanChallenge Entry)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatChallengeValueNeeded, "BmGame.RPersistentShared.GetBatChallengeValueNeeded");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBatChallengeValueBest;
    /// <summary>
    /// Function: GetBatChallengeValueBest
    /// </summary>
    public unsafe virtual float GetBatChallengeValueBest(BmSDK.BmGame.RPersistentData.EBatmanChallenge Entry)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatChallengeValueBest, "BmGame.RPersistentShared.GetBatChallengeValueBest");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBatChallengeValueCurrent;
    /// <summary>
    /// Function: GetBatChallengeValueCurrent
    /// </summary>
    public unsafe virtual float GetBatChallengeValueCurrent(BmSDK.BmGame.RPersistentData.EBatmanChallenge Entry)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatChallengeValueCurrent, "BmGame.RPersistentShared.GetBatChallengeValueCurrent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetRiddlerLocationDataValue;
    /// <summary>
    /// Function: GetRiddlerLocationDataValue
    /// </summary>
    public unsafe virtual int GetRiddlerLocationDataValue(int LocIndex, int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRiddlerLocationDataValue, "BmGame.RPersistentShared.GetRiddlerLocationDataValue");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetRiddlerLocationData;
    /// <summary>
    /// Function: SetRiddlerLocationData
    /// </summary>
    public unsafe virtual void SetRiddlerLocationData(int LocIndex, int Index, int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRiddlerLocationData, "BmGame.RPersistentShared.SetRiddlerLocationData");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRiddlerLocationData;
    /// <summary>
    /// Function: GetRiddlerLocationData
    /// </summary>
    public unsafe virtual BmSDK.TArray<int> GetRiddlerLocationData(int LocIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRiddlerLocationData, "BmGame.RPersistentShared.GetRiddlerLocationData");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsRiddlerAreaUnlocked;
    /// <summary>
    /// Function: IsRiddlerAreaUnlocked
    /// </summary>
    public unsafe virtual bool IsRiddlerAreaUnlocked(int LocIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRiddlerAreaUnlocked, "BmGame.RPersistentShared.IsRiddlerAreaUnlocked");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UnlockRiddlerArea;
    /// <summary>
    /// Function: UnlockRiddlerArea
    /// </summary>
    public unsafe virtual void UnlockRiddlerArea(int LocIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockRiddlerArea, "BmGame.RPersistentShared.UnlockRiddlerArea");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRiddlerAreaNew;
    /// <summary>
    /// Function: ClearRiddlerAreaNew
    /// </summary>
    public unsafe virtual void ClearRiddlerAreaNew(int LocIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRiddlerAreaNew, "BmGame.RPersistentShared.ClearRiddlerAreaNew");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRiddlerTotalCount;
    /// <summary>
    /// Function: GetRiddlerTotalCount
    /// </summary>
    public unsafe virtual int GetRiddlerTotalCount()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRiddlerTotalCount, "BmGame.RPersistentShared.GetRiddlerTotalCount");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRiddlerAreaTotalCount;
    /// <summary>
    /// Function: GetRiddlerAreaTotalCount
    /// </summary>
    public unsafe virtual int GetRiddlerAreaTotalCount(int LocIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRiddlerAreaTotalCount, "BmGame.RPersistentShared.GetRiddlerAreaTotalCount");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Set_PercentEntry;
    /// <summary>
    /// Function: Set_PercentEntry
    /// </summary>
    public unsafe virtual void Set_PercentEntry(bool bPlus, BmSDK.BmGame.RPersistentShared.EPercentData Item, float Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Set_PercentEntry, "BmGame.RPersistentShared.Set_PercentEntry");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlus, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Item, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Get_PercentEntry;
    /// <summary>
    /// Function: Get_PercentEntry
    /// </summary>
    public unsafe virtual float Get_PercentEntry(bool bPlus, BmSDK.BmGame.RPersistentShared.EPercentData Item)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Get_PercentEntry, "BmGame.RPersistentShared.Get_PercentEntry");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlus, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Item, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CountCityStoryNew;
    /// <summary>
    /// Function: CountCityStoryNew
    /// </summary>
    public unsafe virtual int CountCityStoryNew(int StartAt, int Count)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CountCityStoryNew, "BmGame.RPersistentShared.CountCityStoryNew");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartAt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CountBiosNew;
    /// <summary>
    /// Function: CountBiosNew
    /// </summary>
    public unsafe virtual int CountBiosNew()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CountBiosNew, "BmGame.RPersistentShared.CountBiosNew");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CountOfBiosUnlocked;
    /// <summary>
    /// Function: CountOfBiosUnlocked
    /// </summary>
    public unsafe virtual int CountOfBiosUnlocked()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CountOfBiosUnlocked, "BmGame.RPersistentShared.CountOfBiosUnlocked");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBioUnlocked;
    /// <summary>
    /// Function: IsBioUnlocked
    /// </summary>
    public unsafe virtual bool IsBioUnlocked(BmSDK.BmGame.RGameInfo.EBioCharacter inBio)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBioUnlocked, "BmGame.RPersistentShared.IsBioUnlocked");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inBio, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Dump;
    /// <summary>
    /// Function: Dump
    /// </summary>
    public unsafe virtual void Dump()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Dump, "BmGame.RPersistentShared.Dump");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpStats;
    /// <summary>
    /// Function: DumpStats
    /// </summary>
    public unsafe virtual void DumpStats()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpStats, "BmGame.RPersistentShared.DumpStats");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PadStr;
    /// <summary>
    /// Function: PadStr
    /// </summary>
    public unsafe virtual BmSDK.FString PadStr(BmSDK.FString InStr, int DesiredLen)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PadStr, "BmGame.RPersistentShared.PadStr");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InStr, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredLen, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_FloatArrayToString;
    /// <summary>
    /// Function: FloatArrayToString
    /// </summary>
    public unsafe virtual BmSDK.FString FloatArrayToString(BmSDK.TArray<float> Values)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FloatArrayToString, "BmGame.RPersistentShared.FloatArrayToString");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Values, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IntArrayToString;
    /// <summary>
    /// Function: IntArrayToString
    /// </summary>
    public unsafe virtual BmSDK.FString IntArrayToString(BmSDK.TArray<int> Values)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IntArrayToString, "BmGame.RPersistentShared.IntArrayToString");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Values, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ByteArrayToString;
    /// <summary>
    /// Function: ByteArrayToString
    /// </summary>
    public unsafe virtual BmSDK.FString ByteArrayToString(BmSDK.TArray<byte> Values)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ByteArrayToString, "BmGame.RPersistentShared.ByteArrayToString");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Values, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_AwardUpgradePointsForNewlyCompletedChallenges;
    /// <summary>
    /// Function: AwardUpgradePointsForNewlyCompletedChallenges
    /// </summary>
    public unsafe virtual void AwardUpgradePointsForNewlyCompletedChallenges()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardUpgradePointsForNewlyCompletedChallenges, "BmGame.RPersistentShared.AwardUpgradePointsForNewlyCompletedChallenges");
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

    private static BmSDK.Function __fn_IsSharedFlagSet;
    /// <summary>
    /// Function: IsSharedFlagSet
    /// </summary>
    public unsafe virtual bool IsSharedFlagSet(BmSDK.FString FlagName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSharedFlagSet, "BmGame.RPersistentShared.IsSharedFlagSet");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SetSharedFlag;
    /// <summary>
    /// Function: SetSharedFlag
    /// </summary>
    public unsafe virtual void SetSharedFlag(BmSDK.FString FlagName, bool bTrue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSharedFlag, "BmGame.RPersistentShared.SetSharedFlag");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTrue, paramsPtr + 16);
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

    /// <summary>
    /// Enum: SkillPointCategories
    /// </summary>
    public enum SkillPointCategories : byte
    {
        SPC_None = 0,
        SPC_Combat_NumberOfCombatants = 1,
        SPC_Combat_HighestCombo = 2,
        SPC_Combat_Variation = 3,
        SPC_Combat_BonusNoHit = 4,
        SPC_Combat_BonusOneCombo = 5,
        SPC_Combat_NumberOfEncounters = 6,
        SPC_Predator_NumberOfCombatants = 7,
        SPC_Predator_IntimidationTakedowns = 8,
        SPC_Predator_Variation = 9,
        SPC_Predator_NumberOfEncounters = 10,
        SPC_VehCombat_NumberOfEnemies = 11,
        SPC_VehCombat_HighestCombo = 12,
        SPC_VehCombat_Perfect = 13,
        SPC_VehPredator_NumberOfEnemies = 14,
        SPC_VehPredator_HighestCombo = 15,
        SPC_VehPredator_Perfect = 16,
        SPC_MAX = 17,
    }

    /// <summary>
    /// Struct: FRiddlerGridPuzzle
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FRiddlerGridPuzzle
    {
        /// <summary>
        /// ByteProperty: Version
        /// </summary>
        public unsafe byte Version
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: Id
        /// </summary>
        public unsafe byte Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// ByteProperty: Flags
        /// </summary>
        public unsafe byte Flags
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2); }; }
        }

        /// <summary>
        /// ByteProperty: Category
        /// </summary>
        public unsafe byte Category
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3); }; }
        }

        /// <summary>
        /// ArrayProperty: Pieces
        /// </summary>
        public unsafe BmSDK.TArray<byte> Pieces
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FRiddlerGridCategory
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FRiddlerGridCategory
    {
        /// <summary>
        /// ByteProperty: Version
        /// </summary>
        public unsafe byte Version
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: Id
        /// </summary>
        public unsafe byte Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// ByteProperty: Flags
        /// </summary>
        public unsafe byte Flags
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2); }; }
        }

        /// <summary>
        /// ArrayProperty: Collections
        /// </summary>
        public unsafe BmSDK.TArray<byte> Collections
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// IntProperty: Version
    /// </summary>
    public unsafe int Version
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StrProperty: Description
    /// </summary>
    public unsafe BmSDK.FString Description
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ArrayProperty: SharedFlags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> SharedFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: Upgrades
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> Upgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// IntProperty: NumUpgrades
    /// </summary>
    public unsafe int NumUpgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ArrayProperty: SharedGlobalFlags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> SharedGlobalFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: CatwomanEpisodes_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> CatwomanEpisodes_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: CatwomanEpisodes_Unlocked
    /// </summary>
    public unsafe BmSDK.TArray<byte> CatwomanEpisodes_Unlocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ArrayProperty: CharacterBios_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> CharacterBios_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ArrayProperty: CharacterBios_SubId
    /// </summary>
    public unsafe BmSDK.TArray<byte> CharacterBios_SubId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ArrayProperty: CharacterBios_Unlocked
    /// </summary>
    public unsafe BmSDK.TArray<byte> CharacterBios_Unlocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ArrayProperty: CharacterViewer_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> CharacterViewer_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ArrayProperty: CharacterViewer_Unlocked
    /// </summary>
    public unsafe BmSDK.TArray<byte> CharacterViewer_Unlocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ArrayProperty: GalleryUnlocks_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> GalleryUnlocks_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ArrayProperty: GalleryUnlocks
    /// </summary>
    public unsafe BmSDK.TArray<byte> GalleryUnlocks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ArrayProperty: Upgrades_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> Upgrades_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// ArrayProperty: DLCStory_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> DLCStory_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// ArrayProperty: DLCStory_Status
    /// </summary>
    public unsafe BmSDK.TArray<byte> DLCStory_Status
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// ArrayProperty: DLC_MW_Completed
    /// </summary>
    public unsafe BmSDK.TArray<byte> DLC_MW_Completed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// ArrayProperty: CityStories
    /// </summary>
    public unsafe BmSDK.TArray<int> CityStories
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// ArrayProperty: LinkedCityStories
    /// </summary>
    public unsafe BmSDK.TArray<int> LinkedCityStories
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// ArrayProperty: GameplayStats
    /// </summary>
    public unsafe BmSDK.TArray<float> GameplayStats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// ArrayProperty: PercentStats_Game
    /// </summary>
    public unsafe BmSDK.TArray<float> PercentStats_Game
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// ArrayProperty: PercentStats_GamePlus
    /// </summary>
    public unsafe BmSDK.TArray<float> PercentStats_GamePlus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// ArrayProperty: StoryOverAllPercent
    /// </summary>
    public unsafe BmSDK.TArray<float> StoryOverAllPercent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// FloatProperty: Player_RangeBonus
    /// </summary>
    public unsafe float Player_RangeBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// ByteProperty: bCompleteSuitUnlocked
    /// </summary>
    public unsafe byte bCompleteSuitUnlocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_Categories
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentShared.FRiddlerGridCategory> RiddlerData_Categories
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentShared.FRiddlerGridCategory>>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_Puzzles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentShared.FRiddlerGridPuzzle> RiddlerData_Puzzles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentShared.FRiddlerGridPuzzle>>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_AreaTotals
    /// </summary>
    public unsafe BmSDK.TArray<byte> RiddlerData_AreaTotals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_Rows
    /// </summary>
    public unsafe BmSDK.TArray<byte> RiddlerData_Rows
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_AreasNew
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_AreasNew
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_AreasLocked
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_AreasLocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_CityX
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_CityX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_CityY
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_CityY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_CityZ
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_CityZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_Film
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_Film
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_Stagg
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_Stagg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_HideOut
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_HideOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// ArrayProperty: PickupTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> PickupTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// ArrayProperty: CWPickupTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> CWPickupTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ArrayProperty: JokerTeethPickupTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> JokerTeethPickupTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ArrayProperty: CharacterTapesCollected
    /// </summary>
    public unsafe BmSDK.TArray<int> CharacterTapesCollected
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ArrayProperty: CharacterTapesMax
    /// </summary>
    public unsafe BmSDK.TArray<int> CharacterTapesMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ArrayProperty: TapesCollected
    /// </summary>
    public unsafe BmSDK.TArray<int> TapesCollected
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ArrayProperty: JokerBalloonTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> JokerBalloonTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ArrayProperty: BrokenPenguinTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> BrokenPenguinTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ArrayProperty: BrokenCameraTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> BrokenCameraTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ArrayProperty: RiddleTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddleTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// IntProperty: BrokenHarleyHeadTally
    /// </summary>
    public unsafe int BrokenHarleyHeadTally
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// IntProperty: BrokenDemonSealTally
    /// </summary>
    public unsafe int BrokenDemonSealTally
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// IntProperty: BrokenGrundyHeadTally
    /// </summary>
    public unsafe int BrokenGrundyHeadTally
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// IntProperty: PickupCount
    /// </summary>
    public unsafe int PickupCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// IntProperty: PickupRevealsLeft
    /// </summary>
    public unsafe int PickupRevealsLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// IntProperty: NumSecretsTotal
    /// </summary>
    public unsafe int NumSecretsTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// IntProperty: InterrogatesLeft
    /// </summary>
    public unsafe int InterrogatesLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// IntProperty: NumCamerasBroken
    /// </summary>
    public unsafe int NumCamerasBroken
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// IntProperty: InterrogatesPerformed
    /// </summary>
    public unsafe int InterrogatesPerformed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// IntProperty: InterrogatesWithTutorialPerformed
    /// </summary>
    public unsafe int InterrogatesWithTutorialPerformed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ArrayProperty: BatChallengeCurrent
    /// </summary>
    public unsafe BmSDK.TArray<float> BatChallengeCurrent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ArrayProperty: BatChallengeBest
    /// </summary>
    public unsafe BmSDK.TArray<float> BatChallengeBest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ArrayProperty: BatChallengeNeeded
    /// </summary>
    public unsafe BmSDK.TArray<float> BatChallengeNeeded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ArrayProperty: BatChallengeBeaten
    /// </summary>
    public unsafe BmSDK.TArray<int> BatChallengeBeaten
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// FloatProperty: XpForPrevUpgrade
    /// </summary>
    public unsafe float XpForPrevUpgrade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// FloatProperty: XpForNextUpgrade
    /// </summary>
    public unsafe float XpForNextUpgrade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// FloatProperty: Xp
    /// </summary>
    public unsafe float Xp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// FloatProperty: XpLevel
    /// </summary>
    public unsafe float XpLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: XpOverUpgradeThreshold
    /// </summary>
    public unsafe float XpOverUpgradeThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// IntProperty: SkillPoints
    /// </summary>
    public unsafe int SkillPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ArrayProperty: SkillPointCategoryCounts
    /// </summary>
    public unsafe BmSDK.TArray<int> SkillPointCategoryCounts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ArrayProperty: SkillPointDetails
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> SkillPointDetails
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// IntProperty: _UpgradesBought
    /// </summary>
    public unsafe int _UpgradesBought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// IntProperty: _CW_UpgradesBought
    /// </summary>
    public unsafe int _CW_UpgradesBought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// IntProperty: playerLevel
    /// </summary>
    public unsafe int playerLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// IntProperty: _UnlockablesToSpend
    /// </summary>
    public unsafe int _UnlockablesToSpend
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// IntProperty: ShowLevelUpFlag
    /// </summary>
    public unsafe int ShowLevelUpFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// IntProperty: RiddlerGridEnabled
    /// </summary>
    public unsafe int RiddlerGridEnabled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// IntProperty: UpgradePointsAvailable
    /// </summary>
    public unsafe int UpgradePointsAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// IntProperty: UpgradePointsUsed
    /// </summary>
    public unsafe int UpgradePointsUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// IntProperty: UpgradesPurchased
    /// </summary>
    public unsafe int UpgradesPurchased
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ArrayProperty: WaynetechPointsForChallengeId
    /// </summary>
    public unsafe BmSDK.TArray<int> WaynetechPointsForChallengeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// Enum: EPercentData
    /// </summary>
    public enum EPercentData : byte
    {
        EPercentData_Grand = 0,
        EPercentData_Story = 1,
        EPercentData_Azrael = 2,
        EPercentData_Bane = 3,
        EPercentData_DeadShot = 4,
        EPercentData_Hush = 5,
        EPercentData_Mad_Hatter = 6,
        EPercentData_Nora = 7,
        EPercentData_Riddler = 8,
        EPercentData_Zsasz = 9,
        EPercentData_Bullies = 10,
        EPercentData_ARTraining = 11,
        EPercentData_IceBergCops = 12,
        EPercentData_FreezeCluster = 13,
        EPercentData_SideTotal = 14,
        EPercentData_Riddles = 15,
        EPercentData_Upgrades = 16,
        EPercentData_Bios = 17,
        EPercentData_Trophies = 18,
        EPercentData_Arts = 19,
        EPercentData_Collect_Total = 20,
        EPercentData_CW_Trophies = 21,
        EPercentData_CW_Upgrades = 22,
        EPercentData_CW_Loot = 23,
        EPercentData_CW_Total = 24,
        EPercentData_Riddler_Medals = 25,
        EPercentData_Riddler_MedalsOf = 26,
        EPercentData_Riddler_Camp_Medals = 27,
        EPercentData_Riddler_Camp_MedalsOf = 28,
        EPercentData_Riddler_Total = 29,
        EPercentData_RiddlerDLC_Batman_Medals = 30,
        EPercentData_RiddlerDLC_Batman_MedalsOf = 31,
        EPercentData_RiddlerDLC_Batman_Camp_Medals = 32,
        EPercentData_RiddlerDLC_Batman_Camp_MedalsOf = 33,
        EPercentData_RiddlerDLC_Catwoman_Medals = 34,
        EPercentData_RiddlerDLC_Catwoman_MedalsOf = 35,
        EPercentData_RiddlerDLC_Catwoman_Camp_Medals = 36,
        EPercentData_RiddlerDLC_Catwoman_Camp_MedalsOf = 37,
        EPercentData_RiddlerDLC_Robin_Medals = 38,
        EPercentData_RiddlerDLC_Robin_MedalsOf = 39,
        EPercentData_RiddlerDLC_Robin_Camp_Medals = 40,
        EPercentData_RiddlerDLC_Robin_Camp_MedalsOf = 41,
        EPercentData_RiddlerDLC_NightWing_Medals = 42,
        EPercentData_RiddlerDLC_NightWing_MedalsOf = 43,
        EPercentData_RiddlerDLC_NightWing_Camp_Medals = 44,
        EPercentData_RiddlerDLC_NightWing_Camp_MedalsOf = 45,
        EPercentData_RiddlerDLC_Total = 46,
        EPercentData_Episode1_Trophies = 47,
        EPercentData_Episode1_TrophiesOf = 48,
        EPercentData_Episode1_Story = 49,
        EPercentData_Episode1_Total = 50,
        EPercentData_MAX = 51,
    }

    /// <summary>
    /// Enum: EGameplayStats
    /// </summary>
    public enum EGameplayStats : byte
    {
        EGameplayStats_DistanceFlown = 0,
        EGameplayStats_MAX = 1,
    }

    /// <summary>
    /// Enum: PSharedVersion
    /// </summary>
    public enum PSharedVersion : byte
    {
        PSharedVer_Initial = 0,
        PSharedVer_AddedNEWs = 1,
        PSharedVer_Upgrades = 2,
        PSharedVer_MovedStuff1 = 3,
        PSharedVer_GameplayStats = 4,
        PSharedVer_DLCStory = 5,
        PSharedVer_PercentData = 6,
        PSharedVer_BestSurvivalTime = 7,
        PSharedVer_CityStories = 8,
        PSharedVer_BioSubId = 9,
        PSharedVer_ConceptArt = 10,
        PSharedVer_BestSurvivalTimeRemoved = 11,
        PSharedVer_PlayerRangeBonus = 12,
        PSharedVer_NewGamePlusCombine = 13,
        PSharedVer_NewGamePlusCombine2 = 14,
        PSharedVer_UpgradesMoved = 15,
        PSharedVer_Description = 16,
        PSharedVer_RememberBatmanLevel = 17,
        PSharedVer_RiddlerGridEnabled = 18,
        PSharedVer_SkillPoints = 19,
        PSharedVer_RiddlerGridBm3 = 20,
        PSharedVer_RiddlerGridFlexBm3 = 21,
        PSharedVer_StoryOverAllPercent = 22,
        PSharedVer_WBPlayRewards = 23,
        PSharedVer_WBPlayRewardsMoved = 24,
        PSharedVer_UpgradePointsSave = 25,
        PSharedVer_UpgradePointsSave2 = 26,
        PSharedVer_MovedUpgradePointsToPS = 27,
        PSharedVer_MW_DLC_Completed = 28,
        PSharedVer_MAX = 29,
    }
}
