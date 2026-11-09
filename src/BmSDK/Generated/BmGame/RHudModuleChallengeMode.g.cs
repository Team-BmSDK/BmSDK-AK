#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleChallengeMode<br/>
/// (size = 284)
/// (flags = 18)
/// </summary>
public partial class RHudModuleChallengeMode : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleChallengeMode", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHudModuleChallengeMode.
    /// </summary>
    public static RHudModuleChallengeMode DefaultObject => (RHudModuleChallengeMode)StaticClass().DefaultObject;

    internal RHudModuleChallengeMode() { }

    /// <summary>
    /// Constructs a new RHudModuleChallengeMode
    /// </summary>
    public RHudModuleChallengeMode(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleChallengeMode Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleChallengeMode(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleChallengeMode>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleChallengeMode>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleChallengeMode>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleChallengeMode>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleChallengeMode>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleChallengeMode>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleChallengeMode>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleChallengeMode>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetFriendDataFromChallengeId;
    /// <summary>
    /// Function: SetFriendDataFromChallengeId
    /// </summary>
    public unsafe virtual void SetFriendDataFromChallengeId(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFriendDataFromChallengeId, "BmGame.RHudModuleChallengeMode.SetFriendDataFromChallengeId");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTankCountsByZone;
    /// <summary>
    /// Function: SetTankCountsByZone
    /// </summary>
    public unsafe virtual void SetTankCountsByZone(int ZoneRed, int ZoneYellow, int ZoneGreen, int ZoneMax, bool bHide)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTankCountsByZone, "BmGame.RHudModuleChallengeMode.SetTankCountsByZone");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ZoneRed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ZoneYellow, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ZoneGreen, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ZoneMax, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHide, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEnemyCount;
    /// <summary>
    /// Function: SetEnemyCount
    /// </summary>
    public unsafe virtual void SetEnemyCount(bool EnemyCountVisible, int EnemyCountValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEnemyCount, "BmGame.RHudModuleChallengeMode.SetEnemyCount");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnemyCountVisible, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnemyCountValue, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_RemoveMessage;
    /// <summary>
    /// Function: UC_RemoveMessage
    /// </summary>
    public unsafe virtual void UC_RemoveMessage(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_RemoveMessage, "BmGame.RHudModuleChallengeMode.UC_RemoveMessage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_AddMessage;
    /// <summary>
    /// Function: UC_AddMessage
    /// </summary>
    public unsafe virtual int UC_AddMessage(BmSDK.FString sField, BmSDK.FString sText, float fDuration, bool bQueue, bool bExclusive)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_AddMessage, "BmGame.RHudModuleChallengeMode.UC_AddMessage");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sField, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sText, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDuration, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bQueue, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bExclusive, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_UC_SetFriendData;
    /// <summary>
    /// Function: UC_SetFriendData
    /// </summary>
    public unsafe virtual void UC_SetFriendData(BmSDK.FString sName, BmSDK.FString sScore, int nStars, bool bShow)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetFriendData, "BmGame.RHudModuleChallengeMode.UC_SetFriendData");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sScore, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nStars, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_TimerExpired;
    /// <summary>
    /// Function: UC_TimerExpired
    /// </summary>
    public unsafe virtual void UC_TimerExpired()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_TimerExpired, "BmGame.RHudModuleChallengeMode.UC_TimerExpired");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_TimerOffset;
    /// <summary>
    /// Function: UC_TimerOffset
    /// </summary>
    public unsafe virtual void UC_TimerOffset(int nHundredths, bool bBonus)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_TimerOffset, "BmGame.RHudModuleChallengeMode.UC_TimerOffset");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nHundredths, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBonus, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_PauseChallengeTimer;
    /// <summary>
    /// Function: UC_PauseChallengeTimer
    /// </summary>
    public unsafe virtual void UC_PauseChallengeTimer(bool bPause)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_PauseChallengeTimer, "BmGame.RHudModuleChallengeMode.UC_PauseChallengeTimer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPause, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetChallengeTimerWithAdditionalText;
    /// <summary>
    /// Function: UC_SetChallengeTimerWithAdditionalText
    /// </summary>
    public unsafe virtual void UC_SetChallengeTimerWithAdditionalText(int nHundredths, bool bVisible, bool bWarning, BmSDK.FString AdditionalText)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetChallengeTimerWithAdditionalText, "BmGame.RHudModuleChallengeMode.UC_SetChallengeTimerWithAdditionalText");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nHundredths, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWarning, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AdditionalText, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetChallengeTimer;
    /// <summary>
    /// Function: UC_SetChallengeTimer
    /// </summary>
    public unsafe virtual void UC_SetChallengeTimer(int nHundredths, bool bVisible, bool bWarning)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetChallengeTimer, "BmGame.RHudModuleChallengeMode.UC_SetChallengeTimer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nHundredths, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWarning, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ChallengeResultsClose;
    /// <summary>
    /// Function: XI_ChallengeResultsClose
    /// </summary>
    public unsafe virtual void XI_ChallengeResultsClose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ChallengeResultsClose, "BmGame.RHudModuleChallengeMode.XI_ChallengeResultsClose");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ChallengeResults;
    /// <summary>
    /// Function: XI_ChallengeResults
    /// </summary>
    public unsafe virtual void XI_ChallengeResults()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ChallengeResults, "BmGame.RHudModuleChallengeMode.XI_ChallengeResults");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_CountdownComplete;
    /// <summary>
    /// Function: XI_CountdownComplete
    /// </summary>
    public unsafe virtual void XI_CountdownComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_CountdownComplete, "BmGame.RHudModuleChallengeMode.XI_CountdownComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_IsCountdownComplete;
    /// <summary>
    /// Function: UC_IsCountdownComplete
    /// </summary>
    public unsafe virtual bool UC_IsCountdownComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_IsCountdownComplete, "BmGame.RHudModuleChallengeMode.UC_IsCountdownComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UC_StartCountdown;
    /// <summary>
    /// Function: UC_StartCountdown
    /// </summary>
    public unsafe virtual void UC_StartCountdown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_StartCountdown, "BmGame.RHudModuleChallengeMode.UC_StartCountdown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetChallengeStars;
    /// <summary>
    /// Function: UC_SetChallengeStars
    /// </summary>
    public unsafe virtual void UC_SetChallengeStars(int nStars, bool bShow)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetChallengeStars, "BmGame.RHudModuleChallengeMode.UC_SetChallengeStars");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nStars, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetRivalPoints;
    /// <summary>
    /// Function: UC_SetRivalPoints
    /// </summary>
    public unsafe virtual void UC_SetRivalPoints(int nPoints, bool bShow)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetRivalPoints, "BmGame.RHudModuleChallengeMode.UC_SetRivalPoints");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPoints, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetObjectiveFailed;
    /// <summary>
    /// Function: UC_SetObjectiveFailed
    /// </summary>
    public unsafe virtual void UC_SetObjectiveFailed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetObjectiveFailed, "BmGame.RHudModuleChallengeMode.UC_SetObjectiveFailed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetDetailsOffset;
    /// <summary>
    /// Function: UC_SetDetailsOffset
    /// </summary>
    public unsafe virtual void UC_SetDetailsOffset(float fOffset)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetDetailsOffset, "BmGame.RHudModuleChallengeMode.UC_SetDetailsOffset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fOffset, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetObjective;
    /// <summary>
    /// Function: UC_SetObjective
    /// </summary>
    public unsafe virtual void UC_SetObjective(BmSDK.FString sObjective, int nStars, bool bWarning)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetObjective, "BmGame.RHudModuleChallengeMode.UC_SetObjective");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sObjective, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nStars, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWarning, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetChallengeScore;
    /// <summary>
    /// Function: UC_SetChallengeScore
    /// </summary>
    public unsafe virtual void UC_SetChallengeScore(BmSDK.FString NewScore, bool bShow)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetChallengeScore, "BmGame.RHudModuleChallengeMode.UC_SetChallengeScore");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewScore, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_ShowBackground;
    /// <summary>
    /// Function: UC_ShowBackground
    /// </summary>
    public unsafe virtual void UC_ShowBackground(bool bShow)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_ShowBackground, "BmGame.RHudModuleChallengeMode.UC_ShowBackground");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetMode;
    /// <summary>
    /// Function: UC_SetMode
    /// </summary>
    public unsafe virtual void UC_SetMode(BmSDK.FString sMode, bool bStoryStyle, float fDetailsOffset)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetMode, "BmGame.RHudModuleChallengeMode.UC_SetMode");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sMode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStoryStyle, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDetailsOffset, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_ChallengeEnd;
    /// <summary>
    /// Function: UC_ChallengeEnd
    /// </summary>
    public unsafe virtual void UC_ChallengeEnd(bool bFailed, BmSDK.FString sScore, int nStars, int nRivalPoints, bool bAllowResults)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_ChallengeEnd, "BmGame.RHudModuleChallengeMode.UC_ChallengeEnd");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFailed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sScore, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nStars, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nRivalPoints, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowResults, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.RHudModuleChallengeMode.Close");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RHudModuleChallengeMode.Init");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// ObjectProperty: CMan
    /// </summary>
    public unsafe BmSDK.BmGame.RChallengeManager CMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChallengeManager>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bCountdownComplete
    /// </summary>
    public unsafe bool bCountdownComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 248); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetEnemyCount
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetEnemyCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetTanksByZone
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetTanksByZone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }
}
