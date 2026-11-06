#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_BatarangReaction_Watching<br/>
/// (size = 844)
/// (flags = 10485778)
/// </summary>
public partial class RAEC_BatarangReaction_Watching : BmSDK.BmGame.RAlertEventCoordinatorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_BatarangReaction_Watching", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_BatarangReaction_Watching.
    /// </summary>
    public static RAEC_BatarangReaction_Watching DefaultObject => (RAEC_BatarangReaction_Watching)StaticClass().DefaultObject;

    internal RAEC_BatarangReaction_Watching() { }

    /// <summary>
    /// Constructs a new RAEC_BatarangReaction_Watching
    /// </summary>
    public RAEC_BatarangReaction_Watching(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_BatarangReaction_Watching(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_BatarangReaction_Watching>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_BatarangReaction_Watching>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_BatarangReaction_Watching>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_BatarangReaction_Watching>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_BatarangReaction_Watching>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_BatarangReaction_Watching>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_BatarangReaction_Watching>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_BatarangReaction_Watching>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnBeginShutdown;
    /// <summary>
    /// Function: OnBeginShutdown
    /// </summary>
    public unsafe override void OnBeginShutdown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBeginShutdown, "BmGame.RAEC_BatarangReaction_Watching.OnBeginShutdown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearTestRequests;
    /// <summary>
    /// Function: ClearTestRequests
    /// </summary>
    public unsafe virtual void ClearTestRequests()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearTestRequests, "BmGame.RAEC_BatarangReaction_Watching.ClearTestRequests");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayRepeatHitLine;
    /// <summary>
    /// Function: PlayRepeatHitLine
    /// </summary>
    public unsafe virtual void PlayRepeatHitLine(BmSDK.BmGame.RPawnVillain TalkPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayRepeatHitLine, "BmGame.RAEC_BatarangReaction_Watching.PlayRepeatHitLine");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TalkPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNumNotStunnedThugsInEvent;
    /// <summary>
    /// Function: GetNumNotStunnedThugsInEvent
    /// </summary>
    public unsafe virtual int GetNumNotStunnedThugsInEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumNotStunnedThugsInEvent, "BmGame.RAEC_BatarangReaction_Watching.GetNumNotStunnedThugsInEvent");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetThugToBeTalkedTo;
    /// <summary>
    /// Function: GetThugToBeTalkedTo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain GetThugToBeTalkedTo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThugToBeTalkedTo, "BmGame.RAEC_BatarangReaction_Watching.GetThugToBeTalkedTo");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNearestValidThugToLastImpact;
    /// <summary>
    /// Function: GetNearestValidThugToLastImpact
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIController GetNearestValidThugToLastImpact()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNearestValidThugToLastImpact, "BmGame.RAEC_BatarangReaction_Watching.GetNearestValidThugToLastImpact");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIController>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRandomThugToSpeakIfNobodyIsRECed;
    /// <summary>
    /// Function: GetRandomThugToSpeakIfNobodyIsRECed
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIController GetRandomThugToSpeakIfNobodyIsRECed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRandomThugToSpeakIfNobodyIsRECed, "BmGame.RAEC_BatarangReaction_Watching.GetRandomThugToSpeakIfNobodyIsRECed");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIController>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRandomThugToSpeak;
    /// <summary>
    /// Function: GetRandomThugToSpeak
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIController GetRandomThugToSpeak()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRandomThugToSpeak, "BmGame.RAEC_BatarangReaction_Watching.GetRandomThugToSpeak");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIController>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ProcessThugSearch;
    /// <summary>
    /// Function: ProcessThugSearch
    /// </summary>
    public unsafe virtual bool ProcessThugSearch(BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper> TargetThugSearch, bool bUncappedDist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessThugSearch, "BmGame.RAEC_BatarangReaction_Watching.ProcessThugSearch");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetThugSearch, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUncappedDist, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_PawnCanSeeLastPoint;
    /// <summary>
    /// Function: PawnCanSeeLastPoint
    /// </summary>
    public unsafe virtual bool PawnCanSeeLastPoint(BmSDK.BmGame.RBMPawnAI TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnCanSeeLastPoint, "BmGame.RAEC_BatarangReaction_Watching.PawnCanSeeLastPoint");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_InitThugSearch;
    /// <summary>
    /// Function: InitThugSearch
    /// </summary>
    public unsafe virtual void InitThugSearch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitThugSearch, "BmGame.RAEC_BatarangReaction_Watching.InitThugSearch");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartResponderSearch;
    /// <summary>
    /// Function: StartResponderSearch
    /// </summary>
    public unsafe virtual void StartResponderSearch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartResponderSearch, "BmGame.RAEC_BatarangReaction_Watching.StartResponderSearch");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResponderSearchActive;
    /// <summary>
    /// Function: ResponderSearchActive
    /// </summary>
    public unsafe virtual bool ResponderSearchActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResponderSearchActive, "BmGame.RAEC_BatarangReaction_Watching.ResponderSearchActive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DoJumpReaction;
    /// <summary>
    /// Function: DoJumpReaction
    /// </summary>
    public unsafe virtual void DoJumpReaction(System.Numerics.Vector3 HitLoc, System.Numerics.Vector3 ThrownFromPos, bool bThrownFromGarg, float JumpRange, int NewBRangID = default, bool bDueToBodyDrop = default, BmSDK.BmGame.RBMAIController BodyDodger = default, bool bTerrorShootStartle = default, bool bAwardRECScareMedal = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoJumpReaction, "BmGame.RAEC_BatarangReaction_Watching.DoJumpReaction");
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThrownFromGarg, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpRange, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBRangID, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDueToBodyDrop, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BodyDodger, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTerrorShootStartle, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAwardRECScareMedal, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasThugsReacting;
    /// <summary>
    /// Function: HasThugsReacting
    /// </summary>
    public unsafe virtual bool HasThugsReacting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasThugsReacting, "BmGame.RAEC_BatarangReaction_Watching.HasThugsReacting");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ExitIntoAttack;
    /// <summary>
    /// Function: ExitIntoAttack
    /// </summary>
    public unsafe virtual void ExitIntoAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitIntoAttack, "BmGame.RAEC_BatarangReaction_Watching.ExitIntoAttack");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WatcherStarted;
    /// <summary>
    /// Function: WatcherStarted
    /// </summary>
    public unsafe virtual void WatcherStarted(BmSDK.BmGame.RAEC_Brang_Sub_WatchBatarang StartingWatcher)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WatcherStarted, "BmGame.RAEC_BatarangReaction_Watching.WatcherStarted");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartingWatcher, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugGotBatarangedOutOfFrozen;
    /// <summary>
    /// Function: ThugGotBatarangedOutOfFrozen
    /// </summary>
    public unsafe virtual void ThugGotBatarangedOutOfFrozen(BmSDK.BmGame.RBMAIController NewCon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugGotBatarangedOutOfFrozen, "BmGame.RAEC_BatarangReaction_Watching.ThugGotBatarangedOutOfFrozen");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugGotUpFromBatarang;
    /// <summary>
    /// Function: ThugGotUpFromBatarang
    /// </summary>
    public unsafe virtual void ThugGotUpFromBatarang(BmSDK.BmGame.RPawnVillain TestThug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugGotUpFromBatarang, "BmGame.RAEC_BatarangReaction_Watching.ThugGotUpFromBatarang");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestThug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ManDownBodyDodge;
    /// <summary>
    /// Function: ManDownBodyDodge
    /// </summary>
    public unsafe virtual void ManDownBodyDodge(BmSDK.BmGame.RBMAIController Dodger, System.Numerics.Vector3 HitLoc, System.Numerics.Vector3 ThrownFromPos, bool bThrownFromGarg, int LaunchID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManDownBodyDodge, "BmGame.RAEC_BatarangReaction_Watching.ManDownBodyDodge");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dodger, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThrownFromGarg, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchID, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugHit;
    /// <summary>
    /// Function: ThugHit
    /// </summary>
    public unsafe virtual void ThugHit(BmSDK.BmGame.RPawnVillain NewVictim, System.Numerics.Vector3 HitLoc, System.Numerics.Vector3 ThrownFromPos, bool bThrownFromGarg, BmSDK.BmGame.RBMAIController.BRAECReactionType Type, int NewLaunchID, bool bAwardRECScareMedal = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugHit, "BmGame.RAEC_BatarangReaction_Watching.ThugHit");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVictim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThrownFromGarg, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLaunchID, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAwardRECScareMedal, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MakeRicochetNoise;
    /// <summary>
    /// Function: MakeRicochetNoise
    /// </summary>
    public unsafe virtual void MakeRicochetNoise(System.Numerics.Vector3 HitLoc, System.Numerics.Vector3 ThrownFromPos, bool bThrownFromGarg, float JumpRange, int LaunchID, bool bTerrorShootStartle = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeRicochetNoise, "BmGame.RAEC_BatarangReaction_Watching.MakeRicochetNoise");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThrownFromGarg, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpRange, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchID, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTerrorShootStartle, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForThrowReaction;
    /// <summary>
    /// Function: CheckForThrowReaction
    /// </summary>
    public unsafe virtual void CheckForThrowReaction(System.Numerics.Vector3 ThrownFromPos, BmSDK.BmGame.RBMAIController.BRAECReactionType Type, int LaunchID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForThrowReaction, "BmGame.RAEC_BatarangReaction_Watching.CheckForThrowReaction");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchID, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetParamsFromReactionType;
    /// <summary>
    /// Function: GetParamsFromReactionType
    /// </summary>
    public unsafe virtual bool GetParamsFromReactionType(BmSDK.BmGame.RBMAIController.BRAECReactionType TestType, out float JumpRange)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetParamsFromReactionType, "BmGame.RAEC_BatarangReaction_Watching.GetParamsFromReactionType");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestType, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out JumpRange);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpRange, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        JumpRange = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ThugSawThrow;
    /// <summary>
    /// Function: ThugSawThrow
    /// </summary>
    public unsafe virtual bool ThugSawThrow(System.Numerics.Vector3 ThrownFromPos, int NewLaunchID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugSawThrow, "BmGame.RAEC_BatarangReaction_Watching.ThugSawThrow");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLaunchID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetAIThoughts;
    /// <summary>
    /// Function: GetAIThoughts
    /// </summary>
    public unsafe override void GetAIThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAIThoughts, "BmGame.RAEC_BatarangReaction_Watching.GetAIThoughts");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_OnRemoveSoloChild;
    /// <summary>
    /// Function: OnRemoveSoloChild
    /// </summary>
    public unsafe override void OnRemoveSoloChild(BmSDK.BmGame.RAlertEventCoordinatorSolo RemAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRemoveSoloChild, "BmGame.RAEC_BatarangReaction_Watching.OnRemoveSoloChild");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RAEC_BatarangReaction_Watching.Tick");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBarkPriority;
    /// <summary>
    /// Function: GetBarkPriority
    /// </summary>
    public unsafe override int GetBarkPriority()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBarkPriority, "BmGame.RAEC_BatarangReaction_Watching.GetBarkPriority");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RAEC_BatarangReaction_Watching.PreStreamOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: LastImpactPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastImpactPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 720);

    /// <summary>
    /// StructProperty: LastLaunchPointActual
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastLaunchPointActual
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 732);

    /// <summary>
    /// StructProperty: LastLaunchPointAiming
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastLaunchPointAiming
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 744);

    /// <summary>
    /// IntProperty: CurrentBRangID
    /// </summary>
    public unsafe int CurrentBRangID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// FloatProperty: DisperseTimer
    /// </summary>
    public unsafe float DisperseTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: PostGetupTimer
    /// </summary>
    public unsafe float PostGetupTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bPlayedImpactReactionBark
    /// </summary>
    public unsafe bool bPlayedImpactReactionBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bUrgentlyNeedMoreWatchers
    /// </summary>
    public unsafe bool bUrgentlyNeedMoreWatchers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bGroupFormed
    /// </summary>
    public unsafe bool bGroupFormed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bPlayedChatter
    /// </summary>
    public unsafe bool bPlayedChatter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// ObjectProperty: Victim
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain Victim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: LastThugHit
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain LastThugHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: LastWitnessThug
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain LastWitnessThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: APS
    /// </summary>
    public unsafe BmSDK.BmGame.RAttackPointSearch APS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAttackPointSearch>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: ReleaseTimer
    /// </summary>
    public unsafe float ReleaseTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ArrayProperty: ThugSearch
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper> ThugSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper>>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ArrayProperty: ReserveThugSearch
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper> ReserveThugSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper>>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// IntProperty: ImpactCount
    /// </summary>
    public unsafe int ImpactCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }
}
