#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_Casualty<br/>
/// (size = 965)
/// (flags = 10485778)
/// </summary>
public partial class RAEC_Casualty : BmSDK.BmGame.RAEC_CasualtyBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Casualty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_Casualty.
    /// </summary>
    public static RAEC_Casualty DefaultObject => (RAEC_Casualty)StaticClass().DefaultObject;

    internal RAEC_Casualty() { }

    /// <summary>
    /// Constructs a new RAEC_Casualty
    /// </summary>
    public RAEC_Casualty(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Casualty(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Casualty>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Casualty>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Casualty>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Casualty>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Casualty>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Casualty>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Casualty>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Casualty>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnBeginShutdown;
    /// <summary>
    /// Function: OnBeginShutdown
    /// </summary>
    public unsafe override void OnBeginShutdown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBeginShutdown, "BmGame.RAEC_Casualty.OnBeginShutdown");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelGameplayEvents;
    /// <summary>
    /// Function: CancelGameplayEvents
    /// </summary>
    public unsafe override void CancelGameplayEvents()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelGameplayEvents, "BmGame.RAEC_Casualty.CancelGameplayEvents");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MissingCheckinFinished;
    /// <summary>
    /// Function: MissingCheckinFinished
    /// </summary>
    public unsafe virtual void MissingCheckinFinished(bool bInterrupted)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MissingCheckinFinished, "BmGame.RAEC_Casualty.MissingCheckinFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInterrupted, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DiscoverOtherUndiscoveredManDowns;
    /// <summary>
    /// Function: DiscoverOtherUndiscoveredManDowns
    /// </summary>
    public unsafe virtual void DiscoverOtherUndiscoveredManDowns()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DiscoverOtherUndiscoveredManDowns, "BmGame.RAEC_Casualty.DiscoverOtherUndiscoveredManDowns");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanUseGrenadeGrate;
    /// <summary>
    /// Function: CanUseGrenadeGrate
    /// </summary>
    public unsafe virtual bool CanUseGrenadeGrate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseGrenadeGrate, "BmGame.RAEC_Casualty.CanUseGrenadeGrate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CancelNearbyManDowns;
    /// <summary>
    /// Function: CancelNearbyManDowns
    /// </summary>
    public unsafe virtual void CancelNearbyManDowns()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelNearbyManDowns, "BmGame.RAEC_Casualty.CancelNearbyManDowns");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetClosestPointOnLine;
    /// <summary>
    /// Function: GetClosestPointOnLine
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetClosestPointOnLine(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, System.Numerics.Vector3 TestPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestPointOnLine, "BmGame.RAEC_Casualty.GetClosestPointOnLine");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetCasInfo;
    /// <summary>
    /// Function: GetCasInfo
    /// </summary>
    public unsafe virtual void GetCasInfo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCasInfo, "BmGame.RAEC_Casualty.GetCasInfo");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnNeedsCrouchTransIn;
    /// <summary>
    /// Function: PawnNeedsCrouchTransIn
    /// </summary>
    public unsafe static bool PawnNeedsCrouchTransIn(BmSDK.BmGame.RBMPawnAI TestCentreThug, BmSDK.BmGame.RPawnVillain TestCas)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnNeedsCrouchTransIn, "BmGame.RAEC_Casualty.PawnNeedsCrouchTransIn");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestCentreThug, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestCas, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetCrouchPosition;
    /// <summary>
    /// Function: GetCrouchPosition
    /// </summary>
    public unsafe virtual bool GetCrouchPosition(System.Numerics.Vector3 queryLoc, out System.Numerics.Vector3 crouchPos, out BmSDK.Rotator crouchRot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCrouchPosition, "BmGame.RAEC_Casualty.GetCrouchPosition");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(queryLoc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out crouchPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(crouchPos, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out crouchRot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(crouchRot, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        crouchPos = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        crouchRot = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_ManDownCleanUp;
    /// <summary>
    /// Function: ManDownCleanUp
    /// </summary>
    public unsafe virtual void ManDownCleanUp(bool triggerRedHoodResponse)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManDownCleanUp, "BmGame.RAEC_Casualty.ManDownCleanUp");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(triggerRedHoodResponse, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RejectEvent;
    /// <summary>
    /// Function: RejectEvent
    /// </summary>
    public unsafe virtual void RejectEvent(bool triggerRedHoodResponse)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RejectEvent, "BmGame.RAEC_Casualty.RejectEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(triggerRedHoodResponse, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DiscoveredByCheckin;
    /// <summary>
    /// Function: DiscoveredByCheckin
    /// </summary>
    public unsafe virtual void DiscoveredByCheckin()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DiscoveredByCheckin, "BmGame.RAEC_Casualty.DiscoveredByCheckin");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostCutNotify;
    /// <summary>
    /// Function: PostCutNotify
    /// </summary>
    public unsafe override void PostCutNotify(System.Numerics.Vector3 ImpactLoc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostCutNotify, "BmGame.RAEC_Casualty.PostCutNotify");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyRopeCut;
    /// <summary>
    /// Function: NotifyRopeCut
    /// </summary>
    public unsafe override void NotifyRopeCut(BmSDK.BmGame.RBatarangProjectile Brang)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyRopeCut, "BmGame.RAEC_Casualty.NotifyRopeCut");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Brang, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryStopKicking;
    /// <summary>
    /// Function: TryStopKicking
    /// </summary>
    public unsafe virtual void TryStopKicking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryStopKicking, "BmGame.RAEC_Casualty.TryStopKicking");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ManDownEventPending;
    /// <summary>
    /// Function: ManDownEventPending
    /// </summary>
    public unsafe override bool ManDownEventPending()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManDownEventPending, "BmGame.RAEC_Casualty.ManDownEventPending");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ManDownIsActive;
    /// <summary>
    /// Function: ManDownIsActive
    /// </summary>
    public unsafe override bool ManDownIsActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManDownIsActive, "BmGame.RAEC_Casualty.ManDownIsActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartTerrifiedSetPiece;
    /// <summary>
    /// Function: StartTerrifiedSetPiece
    /// </summary>
    public unsafe virtual void StartTerrifiedSetPiece(BmSDK.BmGame.RBMAIController Spotter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartTerrifiedSetPiece, "BmGame.RAEC_Casualty.StartTerrifiedSetPiece");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spotter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartNervousSetPiece;
    /// <summary>
    /// Function: StartNervousSetPiece
    /// </summary>
    public unsafe virtual void StartNervousSetPiece()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartNervousSetPiece, "BmGame.RAEC_Casualty.StartNervousSetPiece");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindNearestMedic;
    /// <summary>
    /// Function: FindNearestMedic
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIController FindNearestMedic()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindNearestMedic, "BmGame.RAEC_Casualty.FindNearestMedic");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIController>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldStealFrom;
    /// <summary>
    /// Function: ShouldStealFrom
    /// </summary>
    public unsafe virtual bool ShouldStealFrom(BmSDK.BmGame.RBMAIController Spotter, BmSDK.BmGame.RBMAIController StealingCon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldStealFrom, "BmGame.RAEC_Casualty.ShouldStealFrom");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spotter, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StealingCon, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ExitsManDownAfterCallingItOut;
    /// <summary>
    /// Function: ExitsManDownAfterCallingItOut
    /// </summary>
    public unsafe static bool ExitsManDownAfterCallingItOut(BmSDK.BmGame.RPawnVillain TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitsManDownAfterCallingItOut, "BmGame.RAEC_Casualty.ExitsManDownAfterCallingItOut");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_StartTygerSetPiece;
    /// <summary>
    /// Function: StartTygerSetPiece
    /// </summary>
    public unsafe virtual void StartTygerSetPiece(BmSDK.BmGame.RBMAIController Spotter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartTygerSetPiece, "BmGame.RAEC_Casualty.StartTygerSetPiece");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spotter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartMedicBusyQuickDismiss;
    /// <summary>
    /// Function: StartMedicBusyQuickDismiss
    /// </summary>
    public unsafe virtual void StartMedicBusyQuickDismiss(BmSDK.BmGame.RBMAIController Spotter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartMedicBusyQuickDismiss, "BmGame.RAEC_Casualty.StartMedicBusyQuickDismiss");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spotter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartMiniManDown;
    /// <summary>
    /// Function: StartMiniManDown
    /// </summary>
    public unsafe virtual void StartMiniManDown(BmSDK.BmGame.RBMAIController Spotter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartMiniManDown, "BmGame.RAEC_Casualty.StartMiniManDown");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spotter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CasFound;
    /// <summary>
    /// Function: CasFound
    /// </summary>
    public unsafe override void CasFound(BmSDK.BmGame.RBMAIController Spotter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CasFound, "BmGame.RAEC_Casualty.CasFound");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spotter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasActiveMedicButCannotClaimOne;
    /// <summary>
    /// Function: HasActiveMedicButCannotClaimOne
    /// </summary>
    public unsafe virtual bool HasActiveMedicButCannotClaimOne()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasActiveMedicButCannotClaimOne, "BmGame.RAEC_Casualty.HasActiveMedicButCannotClaimOne");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerTunnelTakedownAAIResponse;
    /// <summary>
    /// Function: TriggerTunnelTakedownAAIResponse
    /// </summary>
    public unsafe virtual void TriggerTunnelTakedownAAIResponse()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerTunnelTakedownAAIResponse, "BmGame.RAEC_Casualty.TriggerTunnelTakedownAAIResponse");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerInvertedTakedownAAIResponse;
    /// <summary>
    /// Function: TriggerInvertedTakedownAAIResponse
    /// </summary>
    public unsafe virtual void TriggerInvertedTakedownAAIResponse(bool bExploitCounter = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerInvertedTakedownAAIResponse, "BmGame.RAEC_Casualty.TriggerInvertedTakedownAAIResponse");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bExploitCounter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerGlideKickOrDropAttackTakedownAAIResponse;
    /// <summary>
    /// Function: TriggerGlideKickOrDropAttackTakedownAAIResponse
    /// </summary>
    public unsafe virtual void TriggerGlideKickOrDropAttackTakedownAAIResponse(BmSDK.BmGame.RHidePoint attackOriginHidePoint, System.Numerics.Vector3 attackOriginPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerGlideKickOrDropAttackTakedownAAIResponse, "BmGame.RAEC_Casualty.TriggerGlideKickOrDropAttackTakedownAAIResponse");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(attackOriginHidePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(attackOriginPos, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TannoyAnnouncementsEnded_Mine;
    /// <summary>
    /// Function: TannoyAnnouncementsEnded_Mine
    /// </summary>
    public unsafe virtual void TannoyAnnouncementsEnded_Mine()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TannoyAnnouncementsEnded_Mine, "BmGame.RAEC_Casualty.TannoyAnnouncementsEnded_Mine");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TannoyAnnouncementsEnded_Ledge;
    /// <summary>
    /// Function: TannoyAnnouncementsEnded_Ledge
    /// </summary>
    public unsafe virtual void TannoyAnnouncementsEnded_Ledge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TannoyAnnouncementsEnded_Ledge, "BmGame.RAEC_Casualty.TannoyAnnouncementsEnded_Ledge");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TannoyAnnouncementsEnded_Grate;
    /// <summary>
    /// Function: TannoyAnnouncementsEnded_Grate
    /// </summary>
    public unsafe virtual void TannoyAnnouncementsEnded_Grate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TannoyAnnouncementsEnded_Grate, "BmGame.RAEC_Casualty.TannoyAnnouncementsEnded_Grate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TannoyAnnouncementsEnded_Silent;
    /// <summary>
    /// Function: TannoyAnnouncementsEnded_Silent
    /// </summary>
    public unsafe virtual void TannoyAnnouncementsEnded_Silent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TannoyAnnouncementsEnded_Silent, "BmGame.RAEC_Casualty.TannoyAnnouncementsEnded_Silent");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TannoyAnnouncementsEnded_Vantage;
    /// <summary>
    /// Function: TannoyAnnouncementsEnded_Vantage
    /// </summary>
    public unsafe virtual void TannoyAnnouncementsEnded_Vantage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TannoyAnnouncementsEnded_Vantage, "BmGame.RAEC_Casualty.TannoyAnnouncementsEnded_Vantage");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TannoyAnnouncementsEnded;
    /// <summary>
    /// Function: TannoyAnnouncementsEnded
    /// </summary>
    public unsafe virtual void TannoyAnnouncementsEnded(BmSDK.TArray<BmSDK.BmGame.RAnnounceAAITannoyRunner.FAnnouncementInfo> RespondToList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TannoyAnnouncementsEnded, "BmGame.RAEC_Casualty.TannoyAnnouncementsEnded");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RespondToList, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMainAnnouncementType;
    /// <summary>
    /// Function: GetMainAnnouncementType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnnounceAAITannoyRunner.AAIResponseType GetMainAnnouncementType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMainAnnouncementType, "BmGame.RAEC_Casualty.GetMainAnnouncementType");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnnounceAAITannoyRunner.AAIResponseType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryTriggerAAIAnnouncement;
    /// <summary>
    /// Function: TryTriggerAAIAnnouncement
    /// </summary>
    public unsafe override void TryTriggerAAIAnnouncement(bool bSkipStraightToResponse = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryTriggerAAIAnnouncement, "BmGame.RAEC_Casualty.TryTriggerAAIAnnouncement");
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipStraightToResponse, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSourceHidePointForTakedown;
    /// <summary>
    /// Function: GetSourceHidePointForTakedown
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHidePoint GetSourceHidePointForTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSourceHidePointForTakedown, "BmGame.RAEC_Casualty.GetSourceHidePointForTakedown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHidePoint>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetVantageTakedownResponseFlagVal;
    /// <summary>
    /// Function: GetVantageTakedownResponseFlagVal
    /// </summary>
    public unsafe virtual BmSDK.FName GetVantageTakedownResponseFlagVal(BmSDK.BmGame.RHidePoint attackOriginHidePoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVantageTakedownResponseFlagVal, "BmGame.RAEC_Casualty.GetVantageTakedownResponseFlagVal");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(attackOriginHidePoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetTakedownResponseFlagVal;
    /// <summary>
    /// Function: GetTakedownResponseFlagVal
    /// </summary>
    public unsafe virtual BmSDK.FName GetTakedownResponseFlagVal(BmSDK.BmGame.RGameInfo.AAITakedownType responseType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTakedownResponseFlagVal, "BmGame.RAEC_Casualty.GetTakedownResponseFlagVal");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(responseType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OtherManDownActive;
    /// <summary>
    /// Function: OtherManDownActive
    /// </summary>
    public unsafe virtual bool OtherManDownActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OtherManDownActive, "BmGame.RAEC_Casualty.OtherManDownActive");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartInvestigateNavRequests;
    /// <summary>
    /// Function: StartInvestigateNavRequests
    /// </summary>
    public unsafe virtual void StartInvestigateNavRequests()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartInvestigateNavRequests, "BmGame.RAEC_Casualty.StartInvestigateNavRequests");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoMissingThugCheckinBark;
    /// <summary>
    /// Function: DoMissingThugCheckinBark
    /// </summary>
    public unsafe virtual void DoMissingThugCheckinBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoMissingThugCheckinBark, "BmGame.RAEC_Casualty.DoMissingThugCheckinBark");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RespondToMissingCheckin;
    /// <summary>
    /// Function: RespondToMissingCheckin
    /// </summary>
    public unsafe virtual void RespondToMissingCheckin()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RespondToMissingCheckin, "BmGame.RAEC_Casualty.RespondToMissingCheckin");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VillainScreamed;
    /// <summary>
    /// Function: VillainScreamed
    /// </summary>
    public unsafe override void VillainScreamed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VillainScreamed, "BmGame.RAEC_Casualty.VillainScreamed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearInvestigateNavReqs;
    /// <summary>
    /// Function: ClearInvestigateNavReqs
    /// </summary>
    public unsafe virtual void ClearInvestigateNavReqs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearInvestigateNavReqs, "BmGame.RAEC_Casualty.ClearInvestigateNavReqs");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnTakenDown;
    /// <summary>
    /// Function: PawnTakenDown
    /// </summary>
    public unsafe override void PawnTakenDown(bool bGlideKicked, bool bDropAttacked, BmSDK.BmGame.RHidePoint takeDownOriginHidePoint, System.Numerics.Vector3 GlideKickHidePointPerchPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnTakenDown, "BmGame.RAEC_Casualty.PawnTakenDown");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGlideKicked, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDropAttacked, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takeDownOriginHidePoint, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GlideKickHidePointPerchPos, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAIThoughts;
    /// <summary>
    /// Function: GetAIThoughts
    /// </summary>
    public unsafe override void GetAIThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAIThoughts, "BmGame.RAEC_Casualty.GetAIThoughts");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRemoveSoloChild, "BmGame.RAEC_Casualty.OnRemoveSoloChild");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRemoveGroupChild;
    /// <summary>
    /// Function: OnRemoveGroupChild
    /// </summary>
    public unsafe override void OnRemoveGroupChild(BmSDK.BmGame.RAlertEventCoordinatorBase RemAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRemoveGroupChild, "BmGame.RAEC_Casualty.OnRemoveGroupChild");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RAEC_Casualty.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RAEC_Casualty.PreStreamOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RAEC_Casualty.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: NervousSetPieceType
    /// </summary>
    public enum NervousSetPieceType : byte
    {
        NST_Normal = 0,
        NST_TerrorTrans = 1,
        NST_MAX = 2,
    }

    /// <summary>
    /// ObjectProperty: ChildGroupCheckCas
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Casualty_GroupCheckCas ChildGroupCheckCas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Casualty_GroupCheckCas>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ObjectProperty: ChildSoloCas
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Casualty_Sub_Solo ChildSoloCas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Casualty_Sub_Solo>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// ObjectProperty: ChildPauseGroup
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_GroupPauseAndLook ChildPauseGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_GroupPauseAndLook>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// ObjectProperty: AAITAnnoyRunner
    /// </summary>
    public unsafe BmSDK.BmGame.RAnnounceAAITannoyRunner AAITAnnoyRunner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnnounceAAITannoyRunner>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickOriginHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint GlideKickOriginHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ObjectProperty: DropAttackOriginHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint DropAttackOriginHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ObjectProperty: AssignedSentryGunPlacementPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RSentryGunPlacementPoint AssignedSentryGunPlacementPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSentryGunPlacementPoint>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ObjectProperty: NervousSetPieceSpotter
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController NervousSetPieceSpotter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// IntProperty: NervousInvestigateCap
    /// </summary>
    public unsafe int NervousInvestigateCap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bDiscoveredByCheckin
    /// </summary>
    public unsafe bool bDiscoveredByCheckin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToPlayHeardTakedown
    /// </summary>
    public unsafe bool bWaitingToPlayHeardTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bPerimSetPieceStarted
    /// </summary>
    public unsafe bool bPerimSetPieceStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bNeedGlideKickResponse
    /// </summary>
    public unsafe bool bNeedGlideKickResponse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bNeedDropAttackResponse
    /// </summary>
    public unsafe bool bNeedDropAttackResponse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bDoneCheekyGargMine
    /// </summary>
    public unsafe bool bDoneCheekyGargMine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bCasFaceDown
    /// </summary>
    public unsafe bool bCasFaceDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bLeftOfCasBlocked
    /// </summary>
    public unsafe bool bLeftOfCasBlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bRightOfCasBlocked
    /// </summary>
    public unsafe bool bRightOfCasBlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: thugOnCasLeft
    /// </summary>
    public unsafe bool thugOnCasLeft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: triggeredAAIAnnouncement
    /// </summary>
    public unsafe bool triggeredAAIAnnouncement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: triggeredAAIResponse
    /// </summary>
    public unsafe bool triggeredAAIResponse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// ArrayProperty: InvestigateNavReq
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle> InvestigateNavReq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle>>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// IntProperty: NumAssigned
    /// </summary>
    public unsafe int NumAssigned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// FloatProperty: ReleaseTimer
    /// </summary>
    public unsafe float ReleaseTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// FloatProperty: PlayHeardTakedownSkipTimer
    /// </summary>
    public unsafe float PlayHeardTakedownSkipTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// StructProperty: takedownHidePointPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 takedownHidePointPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 884);

    /// <summary>
    /// StructProperty: crouchPosLeftOfCas
    /// </summary>
    public unsafe ref System.Numerics.Vector3 crouchPosLeftOfCas
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 896);

    /// <summary>
    /// StructProperty: crouchRotLeftOfCas
    /// </summary>
    public unsafe ref BmSDK.Rotator crouchRotLeftOfCas
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 908);

    /// <summary>
    /// StructProperty: crouchPosRightOfCas
    /// </summary>
    public unsafe ref System.Numerics.Vector3 crouchPosRightOfCas
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 920);

    /// <summary>
    /// StructProperty: crouchRotRightOfCas
    /// </summary>
    public unsafe ref BmSDK.Rotator crouchRotRightOfCas
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 932);

    /// <summary>
    /// FloatProperty: CAS_FAR_GESTURE_DIST
    /// </summary>
    public unsafe float CAS_FAR_GESTURE_DIST
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// StructProperty: cachedSpottedLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 cachedSpottedLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 948);

    /// <summary>
    /// IntProperty: casFoundCount
    /// </summary>
    public unsafe int casFoundCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ByteProperty: NSPType
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Casualty.NervousSetPieceType NSPType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Casualty.NervousSetPieceType>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }
}
