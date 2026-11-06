#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RAEC_CasualtyBase<br/>
/// (size = 784)
/// (flags = 10485779)
/// </summary>
public partial class RAEC_CasualtyBase : BmSDK.BmGame.RAlertEventCoordinatorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_CasualtyBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_CasualtyBase.
    /// </summary>
    public static RAEC_CasualtyBase DefaultObject => (RAEC_CasualtyBase)StaticClass().DefaultObject;

    internal RAEC_CasualtyBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_CasualtyBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_CasualtyBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_CasualtyBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_CasualtyBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_CasualtyBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_CasualtyBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_CasualtyBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_CasualtyBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_CasualtyBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CancelGameplayEvents;
    /// <summary>
    /// Function: CancelGameplayEvents
    /// </summary>
    public unsafe virtual void CancelGameplayEvents()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelGameplayEvents, "BmGame.RAEC_CasualtyBase.CancelGameplayEvents");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindGargWeAreCurrentlyTiedTo;
    /// <summary>
    /// Function: FindGargWeAreCurrentlyTiedTo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHidePoint FindGargWeAreCurrentlyTiedTo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindGargWeAreCurrentlyTiedTo, "BmGame.RAEC_CasualtyBase.FindGargWeAreCurrentlyTiedTo");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHidePoint>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FindCasGarg;
    /// <summary>
    /// Function: FindCasGarg
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHidePoint FindCasGarg()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindCasGarg, "BmGame.RAEC_CasualtyBase.FindCasGarg");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHidePoint>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryTriggerAAIAnnouncement;
    /// <summary>
    /// Function: TryTriggerAAIAnnouncement
    /// </summary>
    public unsafe virtual void TryTriggerAAIAnnouncement(bool bSkipStraightToResponse = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryTriggerAAIAnnouncement, "BmGame.RAEC_CasualtyBase.TryTriggerAAIAnnouncement");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipStraightToResponse, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScreamNoReaction;
    /// <summary>
    /// Function: ScreamNoReaction
    /// </summary>
    public unsafe virtual void ScreamNoReaction()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScreamNoReaction, "BmGame.RAEC_CasualtyBase.ScreamNoReaction");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SonicBatarangTakedown;
    /// <summary>
    /// Function: SonicBatarangTakedown
    /// </summary>
    public unsafe virtual void SonicBatarangTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SonicBatarangTakedown, "BmGame.RAEC_CasualtyBase.SonicBatarangTakedown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostCutNotify;
    /// <summary>
    /// Function: PostCutNotify
    /// </summary>
    public unsafe virtual void PostCutNotify(System.Numerics.Vector3 ImpactLoc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostCutNotify, "BmGame.RAEC_CasualtyBase.PostCutNotify");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnTakenDown;
    /// <summary>
    /// Function: PawnTakenDown
    /// </summary>
    public unsafe virtual void PawnTakenDown(bool bGlideKicked, bool bDropAttacked, BmSDK.BmGame.RHidePoint inGlideKickOriginHidePoint, System.Numerics.Vector3 GlideKickHidePointPerchPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnTakenDown, "BmGame.RAEC_CasualtyBase.PawnTakenDown");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGlideKicked, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDropAttacked, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inGlideKickOriginHidePoint, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GlideKickHidePointPerchPos, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyRopeCut;
    /// <summary>
    /// Function: NotifyRopeCut
    /// </summary>
    public unsafe virtual void NotifyRopeCut(BmSDK.BmGame.RBatarangProjectile Brang)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyRopeCut, "BmGame.RAEC_CasualtyBase.NotifyRopeCut");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Brang, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VillainScreamed;
    /// <summary>
    /// Function: VillainScreamed
    /// </summary>
    public unsafe virtual void VillainScreamed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VillainScreamed, "BmGame.RAEC_CasualtyBase.VillainScreamed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ManDownEventPending;
    /// <summary>
    /// Function: ManDownEventPending
    /// </summary>
    public unsafe virtual bool ManDownEventPending()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManDownEventPending, "BmGame.RAEC_CasualtyBase.ManDownEventPending");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ManDownIsActive;
    /// <summary>
    /// Function: ManDownIsActive
    /// </summary>
    public unsafe virtual bool ManDownIsActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManDownIsActive, "BmGame.RAEC_CasualtyBase.ManDownIsActive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CasFound;
    /// <summary>
    /// Function: CasFound
    /// </summary>
    public unsafe virtual void CasFound(BmSDK.BmGame.RBMAIController Spotter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CasFound, "BmGame.RAEC_CasualtyBase.CasFound");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spotter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBarkPriority;
    /// <summary>
    /// Function: GetBarkPriority
    /// </summary>
    public unsafe override int GetBarkPriority()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBarkPriority, "BmGame.RAEC_CasualtyBase.GetBarkPriority");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_WantsToGlanceAt;
    /// <summary>
    /// Function: WantsToGlanceAt
    /// </summary>
    public unsafe override bool WantsToGlanceAt(BmSDK.Engine.Actor TestTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WantsToGlanceAt, "BmGame.RAEC_CasualtyBase.WantsToGlanceAt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FinishTopLevelAEC;
    /// <summary>
    /// Function: FinishTopLevelAEC
    /// </summary>
    public unsafe override void FinishTopLevelAEC(BmSDK.BmGame.RBMAIController StolenCon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishTopLevelAEC, "BmGame.RAEC_CasualtyBase.FinishTopLevelAEC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StolenCon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTakedownType;
    /// <summary>
    /// Function: GetTakedownType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.AAITakedownType GetTakedownType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTakedownType, "BmGame.RAEC_CasualtyBase.GetTakedownType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.AAITakedownType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetTakedownType;
    /// <summary>
    /// Function: SetTakedownType
    /// </summary>
    public unsafe virtual void SetTakedownType(BmSDK.BmGame.RGameInfo.AAITakedownType inTakedownType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTakedownType, "BmGame.RAEC_CasualtyBase.SetTakedownType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTakedownType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Casualty
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain Casualty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: GrateCasTakenDownFrom
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase GrateCasTakenDownFrom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ObjectProperty: cachedCasGarg
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint cachedCasGarg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ObjectProperty: TunnelCasTakenDownFrom
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelFunnel TunnelCasTakenDownFrom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelFunnel>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// ObjectProperty: InvTakedownGarg
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint InvTakedownGarg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// ObjectProperty: ColdDiscoverCas
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController ColdDiscoverCas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bPlayedManDown
    /// </summary>
    public unsafe bool bPlayedManDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bDiscoverForewarned
    /// </summary>
    public unsafe bool bDiscoverForewarned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bPlayerAlreadySeenAtTimeOfTakedown
    /// </summary>
    public unsafe bool bPlayerAlreadySeenAtTimeOfTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bKnockoutWasWitnessed
    /// </summary>
    public unsafe bool bKnockoutWasWitnessed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// ByteProperty: takedownType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.AAITakedownType takedownType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.AAITakedownType>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// FloatProperty: DiscoveryTime
    /// </summary>
    public unsafe float DiscoveryTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// FloatProperty: MiniManDownRegisterTime
    /// </summary>
    public unsafe float MiniManDownRegisterTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }
}
