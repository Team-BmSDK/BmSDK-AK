#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_CityRunAwayBase<br/>
/// (size = 1008)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_CityRunAwayBase : BmSDK.BmGame.RBMBehaviour_GangMovementBaseBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_CityRunAwayBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMBehaviour_CityRunAwayBase.
    /// </summary>
    public static RBMBehaviour_CityRunAwayBase DefaultObject => (RBMBehaviour_CityRunAwayBase)StaticClass().DefaultObject;

    internal RBMBehaviour_CityRunAwayBase() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_CityRunAwayBase
    /// </summary>
    public RBMBehaviour_CityRunAwayBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_CityRunAwayBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_CityRunAwayBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_CityRunAwayBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_CityRunAwayBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_CityRunAwayBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_CityRunAwayBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_CityRunAwayBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_CityRunAwayBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_CityRunAwayBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_CityRunAwayBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DebugBatmobileCollision;
    /// <summary>
    /// Function: DebugBatmobileCollision
    /// </summary>
    public unsafe virtual void DebugBatmobileCollision(BmSDK.BmGame.RVehicleBatmobileBase Bmbl)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugBatmobileCollision, "BmGame.RBMBehaviour_CityRunAwayBase.DebugBatmobileCollision");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bmbl, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RiotSuppressorShouldKO;
    /// <summary>
    /// Function: RiotSuppressorShouldKO
    /// </summary>
    public unsafe override bool RiotSuppressorShouldKO()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RiotSuppressorShouldKO, "BmGame.RBMBehaviour_CityRunAwayBase.RiotSuppressorShouldKO");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AwareOfPlayer;
    /// <summary>
    /// Function: AwareOfPlayer
    /// </summary>
    public unsafe override bool AwareOfPlayer(BmSDK.Engine.Actor Player, BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwareOfPlayer, "BmGame.RBMBehaviour_CityRunAwayBase.AwareOfPlayer");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsFacingAvoidActor;
    /// <summary>
    /// Function: IsFacingAvoidActor
    /// </summary>
    public unsafe virtual bool IsFacingAvoidActor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFacingAvoidActor, "BmGame.RBMBehaviour_CityRunAwayBase.IsFacingAvoidActor");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DrawRunAwayPathDebug;
    /// <summary>
    /// Function: DrawRunAwayPathDebug
    /// </summary>
    public unsafe virtual void DrawRunAwayPathDebug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawRunAwayPathDebug, "BmGame.RBMBehaviour_CityRunAwayBase.DrawRunAwayPathDebug");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldStopRunning;
    /// <summary>
    /// Function: ShouldStopRunning
    /// </summary>
    public unsafe virtual bool ShouldStopRunning(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldStopRunning, "BmGame.RBMBehaviour_CityRunAwayBase.ShouldStopRunning");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TrimLinksBasedOnLocation;
    /// <summary>
    /// Function: TrimLinksBasedOnLocation
    /// </summary>
    public unsafe virtual bool TrimLinksBasedOnLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrimLinksBasedOnLocation, "BmGame.RBMBehaviour_CityRunAwayBase.TrimLinksBasedOnLocation");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInLink;
    /// <summary>
    /// Function: IsInLink
    /// </summary>
    public unsafe virtual bool IsInLink(int LinkId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInLink, "BmGame.RBMBehaviour_CityRunAwayBase.IsInLink");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OverrideGetupStances;
    /// <summary>
    /// Function: OverrideGetupStances
    /// </summary>
    public unsafe override bool OverrideGetupStances(out BmSDK.FName MovementStance, out BmSDK.FName WeaponStance)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideGetupStances, "BmGame.RBMBehaviour_CityRunAwayBase.OverrideGetupStances");
        byte* paramsPtr = stackalloc byte[20];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MovementStance);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out WeaponStance);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MovementStance = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
        WeaponStance = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_StartNextMoveToAction;
    /// <summary>
    /// Function: StartNextMoveToAction
    /// </summary>
    public unsafe virtual bool StartNextMoveToAction(bool bReachedPoint = default, bool bFindNextPoint = default, bool bDirectMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartNextMoveToAction, "BmGame.RBMBehaviour_CityRunAwayBase.StartNextMoveToAction");
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReachedPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFindNextPoint, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDirectMove, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RemoveCloseLocationsFromList;
    /// <summary>
    /// Function: RemoveCloseLocationsFromList
    /// </summary>
    public unsafe virtual void RemoveCloseLocationsFromList(out BmSDK.TArray<System.Numerics.Vector3> LocationList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveCloseLocationsFromList, "BmGame.RBMBehaviour_CityRunAwayBase.RemoveCloseLocationsFromList");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        LocationList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SnapPointToNavMesh;
    /// <summary>
    /// Function: SnapPointToNavMesh
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 SnapPointToNavMesh(System.Numerics.Vector3 SnapPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SnapPointToNavMesh, "BmGame.RBMBehaviour_CityRunAwayBase.SnapPointToNavMesh");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SnapPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CalculateGoalPos;
    /// <summary>
    /// Function: CalculateGoalPos
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 CalculateGoalPos()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateGoalPos, "BmGame.RBMBehaviour_CityRunAwayBase.CalculateGoalPos");
        byte* paramsPtr = stackalloc byte[204];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNextRunAwayPoint;
    /// <summary>
    /// Function: GetNextRunAwayPoint
    /// </summary>
    public unsafe virtual bool GetNextRunAwayPoint(bool bReachedPoint = default, bool bForceReevaluate = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextRunAwayPoint, "BmGame.RBMBehaviour_CityRunAwayBase.GetNextRunAwayPoint");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReachedPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceReevaluate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetCurrentLinkFromNetwork;
    /// <summary>
    /// Function: SetCurrentLinkFromNetwork
    /// </summary>
    public unsafe virtual bool SetCurrentLinkFromNetwork()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentLinkFromNetwork, "BmGame.RBMBehaviour_CityRunAwayBase.SetCurrentLinkFromNetwork");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRunAwayScoreForPoint;
    /// <summary>
    /// Function: GetRunAwayScoreForPoint
    /// </summary>
    public unsafe virtual float GetRunAwayScoreForPoint(int TestRoadPointIndex, out BmSDK.TArray<System.Numerics.Vector3> ThreatDirections)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRunAwayScoreForPoint, "BmGame.RBMBehaviour_CityRunAwayBase.GetRunAwayScoreForPoint");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestRoadPointIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThreatDirections = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ChooseNextRoadLink;
    /// <summary>
    /// Function: ChooseNextRoadLink
    /// </summary>
    public unsafe virtual void ChooseNextRoadLink()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChooseNextRoadLink, "BmGame.RBMBehaviour_CityRunAwayBase.ChooseNextRoadLink");
        byte* paramsPtr = stackalloc byte[216];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsVillainInPositionToPlayFleeBark;
    /// <summary>
    /// Function: IsVillainInPositionToPlayFleeBark
    /// </summary>
    public unsafe virtual bool IsVillainInPositionToPlayFleeBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVillainInPositionToPlayFleeBark, "BmGame.RBMBehaviour_CityRunAwayBase.IsVillainInPositionToPlayFleeBark");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayFleeReaction;
    /// <summary>
    /// Function: PlayFleeReaction
    /// </summary>
    public unsafe virtual void PlayFleeReaction()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFleeReaction, "BmGame.RBMBehaviour_CityRunAwayBase.PlayFleeReaction");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMoveLocation;
    /// <summary>
    /// Function: GetMoveLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetMoveLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMoveLocation, "BmGame.RBMBehaviour_CityRunAwayBase.GetMoveLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEvadeVehicleType;
    /// <summary>
    /// Function: GetEvadeVehicleType
    /// </summary>
    public unsafe override BmSDK.BmGame.RGameInfo.EEvadeVehicleType GetEvadeVehicleType(BmSDK.Engine.Actor V, float VehicleSpeed, bool bZap)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEvadeVehicleType, "BmGame.RBMBehaviour_CityRunAwayBase.GetEvadeVehicleType");
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VehicleSpeed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bZap, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.EEvadeVehicleType>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_UpdateThreatAndDestroyCheck;
    /// <summary>
    /// Function: UpdateThreatAndDestroyCheck
    /// </summary>
    public unsafe virtual bool UpdateThreatAndDestroyCheck(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateThreatAndDestroyCheck, "BmGame.RBMBehaviour_CityRunAwayBase.UpdateThreatAndDestroyCheck");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OnEndInterrupt;
    /// <summary>
    /// Function: OnEndInterrupt
    /// </summary>
    public unsafe override void OnEndInterrupt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEndInterrupt, "BmGame.RBMBehaviour_CityRunAwayBase.OnEndInterrupt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBeginInterrupt;
    /// <summary>
    /// Function: OnBeginInterrupt
    /// </summary>
    public unsafe override void OnBeginInterrupt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBeginInterrupt, "BmGame.RBMBehaviour_CityRunAwayBase.OnBeginInterrupt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceIntoCombat;
    /// <summary>
    /// Function: ForceIntoCombat
    /// </summary>
    public unsafe virtual void ForceIntoCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceIntoCombat, "BmGame.RBMBehaviour_CityRunAwayBase.ForceIntoCombat");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceNearbyThugsIntoCombat;
    /// <summary>
    /// Function: ForceNearbyThugsIntoCombat
    /// </summary>
    public unsafe virtual void ForceNearbyThugsIntoCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceNearbyThugsIntoCombat, "BmGame.RBMBehaviour_CityRunAwayBase.ForceNearbyThugsIntoCombat");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldForceIntoCombat;
    /// <summary>
    /// Function: ShouldForceIntoCombat
    /// </summary>
    public unsafe virtual bool ShouldForceIntoCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceIntoCombat, "BmGame.RBMBehaviour_CityRunAwayBase.ShouldForceIntoCombat");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetMovementSpeed;
    /// <summary>
    /// Function: SetMovementSpeed
    /// </summary>
    public unsafe virtual bool SetMovementSpeed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMovementSpeed, "BmGame.RBMBehaviour_CityRunAwayBase.SetMovementSpeed");
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TickIsDisabledStateChanged;
    /// <summary>
    /// Function: TickIsDisabledStateChanged
    /// </summary>
    public unsafe override void TickIsDisabledStateChanged(bool bTickIsDisabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickIsDisabledStateChanged, "BmGame.RBMBehaviour_CityRunAwayBase.TickIsDisabledStateChanged");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTickIsDisabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRunVariants;
    /// <summary>
    /// Function: SetRunVariants
    /// </summary>
    public unsafe virtual void SetRunVariants(BmSDK.BmGame.RBMAIAction_RiotRunBase MoveAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRunVariants, "BmGame.RBMBehaviour_CityRunAwayBase.SetRunVariants");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDeactivate;
    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeactivate, "BmGame.RBMBehaviour_CityRunAwayBase.OnDeactivate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnActivate;
    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmGame.RBMBehaviour_CityRunAwayBase.OnActivate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: SavedAction
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIAction_BaseMove SavedAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIAction_BaseMove>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: SavedThreat
    /// </summary>
    public unsafe BmSDK.Engine.Actor SavedThreat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: RoadNetwork
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadNetwork RoadNetwork
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// StructProperty: GoalPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GoalPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 796);

    /// <summary>
    /// FloatProperty: SavedThreatDistance
    /// </summary>
    public unsafe float SavedThreatDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// FloatProperty: WaitTime
    /// </summary>
    public unsafe float WaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// StructProperty: FleeReactionID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId FleeReactionID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 816);

    /// <summary>
    /// ArrayProperty: FleeReactionFront
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> FleeReactionFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ArrayProperty: FleeReactionBack
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> FleeReactionBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// FloatProperty: WaitingtoReactTime
    /// </summary>
    public unsafe float WaitingtoReactTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// FloatProperty: CheckThreatDirectionTimer
    /// </summary>
    public unsafe float CheckThreatDirectionTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// BoolProperty: bHaveRunAwayFromAvoidActors
    /// </summary>
    public unsafe bool bHaveRunAwayFromAvoidActors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: bRetryStartNextMoveToDueToFailure
    /// </summary>
    public unsafe bool bRetryStartNextMoveToDueToFailure
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: bForceFleeReaction
    /// </summary>
    public unsafe bool bForceFleeReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: bCanBackAway
    /// </summary>
    public unsafe bool bCanBackAway
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: bHasRun
    /// </summary>
    public unsafe bool bHasRun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: bHasBackedAway
    /// </summary>
    public unsafe bool bHasBackedAway
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: bDontChangePose
    /// </summary>
    public unsafe bool bDontChangePose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// FloatProperty: TimeHiddenForDestroy
    /// </summary>
    public unsafe float TimeHiddenForDestroy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// FloatProperty: MinDistanceFromThreatToDestroy
    /// </summary>
    public unsafe float MinDistanceFromThreatToDestroy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// FloatProperty: TimeBehaviourStarted
    /// </summary>
    public unsafe float TimeBehaviourStarted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ArrayProperty: RoadLinks
    /// </summary>
    public unsafe BmSDK.TArray<int> RoadLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ArrayProperty: RoadPoints
    /// </summary>
    public unsafe BmSDK.TArray<int> RoadPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// IntProperty: LookAheadLinks
    /// </summary>
    public unsafe int LookAheadLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ArrayProperty: StoredLocationList
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> StoredLocationList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// FloatProperty: MinRoadWidth
    /// </summary>
    public unsafe float MinRoadWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// ArrayProperty: GoalHistory
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> GoalHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ArrayProperty: SprintingHitReactionAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> SprintingHitReactionAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ArrayProperty: RunningHitReactionAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> RunningHitReactionAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ByteProperty: MoveSpeed
    /// </summary>
    public unsafe BmSDK.Engine.RAutomaticTransitions.EMovementSpeed MoveSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAutomaticTransitions.EMovementSpeed>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// StructProperty: HitReactionID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId HitReactionID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 984);

    /// <summary>
    /// ArrayProperty: AvoidActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> AvoidActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: PlayFleeBarkTimer
    /// </summary>
    public unsafe float PlayFleeBarkTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }
}
