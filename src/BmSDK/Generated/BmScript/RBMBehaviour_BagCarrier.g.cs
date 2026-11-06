#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_BagCarrier<br/>
/// (size = 880)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_BagCarrier : BmSDK.BmGame.RBMBehaviour_BagCarrierBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_BagCarrier", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMBehaviour_BagCarrier.
    /// </summary>
    public static RBMBehaviour_BagCarrier DefaultObject => (RBMBehaviour_BagCarrier)StaticClass().DefaultObject;

    internal RBMBehaviour_BagCarrier() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_BagCarrier
    /// </summary>
    public RBMBehaviour_BagCarrier(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_BagCarrier Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_BagCarrier(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_BagCarrier>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_BagCarrier>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_BagCarrier>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_BagCarrier>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_BagCarrier>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_BagCarrier>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_BagCarrier>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_BagCarrier>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmScript.RBMBehaviour_BagCarrier.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckFuturePathOrientation;
    /// <summary>
    /// Function: CheckFuturePathOrientation
    /// </summary>
    public unsafe virtual bool CheckFuturePathOrientation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckFuturePathOrientation, "BmScript.RBMBehaviour_BagCarrier.CheckFuturePathOrientation");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BagCarrier_GetNavHandle_PathToPoint;
    /// <summary>
    /// Function: BagCarrier_GetNavHandle_PathToPoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RNavigationHandle BagCarrier_GetNavHandle_PathToPoint(System.Numerics.Vector3 DestPos, bool bAllowTraversal = default, BmSDK.FName ClaimName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BagCarrier_GetNavHandle_PathToPoint, "BmScript.RBMBehaviour_BagCarrier.BagCarrier_GetNavHandle_PathToPoint");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowTraversal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClaimName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RNavigationHandle>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetNextWaypointIndex;
    /// <summary>
    /// Function: GetNextWaypointIndex
    /// </summary>
    public unsafe virtual int GetNextWaypointIndex(bool bTowardsPickUpPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextWaypointIndex, "BmScript.RBMBehaviour_BagCarrier.GetNextWaypointIndex");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTowardsPickUpPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetWaypointScore;
    /// <summary>
    /// Function: GetWaypointScore
    /// </summary>
    public unsafe virtual float GetWaypointScore(System.Numerics.Vector3 currentLoc, System.Numerics.Vector3 Destination, System.Numerics.Vector3 waypointLoc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWaypointScore, "BmScript.RBMBehaviour_BagCarrier.GetWaypointScore");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(currentLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Destination, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(waypointLoc, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetBestWaypointIndex;
    /// <summary>
    /// Function: GetBestWaypointIndex
    /// </summary>
    public unsafe virtual int GetBestWaypointIndex(bool bTowardsPickUpPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestWaypointIndex, "BmScript.RBMBehaviour_BagCarrier.GetBestWaypointIndex");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTowardsPickUpPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FindClosestShootingPawnToPlayer;
    /// <summary>
    /// Function: FindClosestShootingPawnToPlayer
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawn FindClosestShootingPawnToPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindClosestShootingPawnToPlayer, "BmScript.RBMBehaviour_BagCarrier.FindClosestShootingPawnToPlayer");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawn>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AreAnyPawnsCheatChasing;
    /// <summary>
    /// Function: AreAnyPawnsCheatChasing
    /// </summary>
    public unsafe virtual bool AreAnyPawnsCheatChasing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreAnyPawnsCheatChasing, "BmScript.RBMBehaviour_BagCarrier.AreAnyPawnsCheatChasing");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldCheatChase;
    /// <summary>
    /// Function: ShouldCheatChase
    /// </summary>
    public unsafe virtual bool ShouldCheatChase()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldCheatChase, "BmScript.RBMBehaviour_BagCarrier.ShouldCheatChase");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FindClosestPawnWaitingForCurrentDropOffPoint;
    /// <summary>
    /// Function: FindClosestPawnWaitingForCurrentDropOffPoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawn FindClosestPawnWaitingForCurrentDropOffPoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindClosestPawnWaitingForCurrentDropOffPoint, "BmScript.RBMBehaviour_BagCarrier.FindClosestPawnWaitingForCurrentDropOffPoint");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawn>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HandlePathFail;
    /// <summary>
    /// Function: HandlePathFail
    /// </summary>
    public unsafe override void HandlePathFail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandlePathFail, "BmScript.RBMBehaviour_BagCarrier.HandlePathFail");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckAssignBetterDropOffPoint;
    /// <summary>
    /// Function: CheckAssignBetterDropOffPoint
    /// </summary>
    public unsafe virtual bool CheckAssignBetterDropOffPoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAssignBetterDropOffPoint, "BmScript.RBMBehaviour_BagCarrier.CheckAssignBetterDropOffPoint");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OkToCarryOnBagCarrying;
    /// <summary>
    /// Function: OkToCarryOnBagCarrying
    /// </summary>
    public unsafe virtual bool OkToCarryOnBagCarrying()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OkToCarryOnBagCarrying, "BmScript.RBMBehaviour_BagCarrier.OkToCarryOnBagCarrying");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RunToExitPoint;
    /// <summary>
    /// Function: RunToExitPoint
    /// </summary>
    public unsafe virtual void RunToExitPoint(BmSDK.Engine.Actor inExitPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RunToExitPoint, "BmScript.RBMBehaviour_BagCarrier.RunToExitPoint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inExitPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryTriggerExitBark;
    /// <summary>
    /// Function: TryTriggerExitBark
    /// </summary>
    public unsafe virtual void TryTriggerExitBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryTriggerExitBark, "BmScript.RBMBehaviour_BagCarrier.TryTriggerExitBark");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SnapPointToNavMesh;
    /// <summary>
    /// Function: SnapPointToNavMesh
    /// </summary>
    public unsafe virtual bool SnapPointToNavMesh(out System.Numerics.Vector3 TestPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SnapPointToNavMesh, "BmScript.RBMBehaviour_BagCarrier.SnapPointToNavMesh");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TestPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TestPoint = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_HasLineOfSightToThrowGrenadeOnGrate;
    /// <summary>
    /// Function: HasLineOfSightToThrowGrenadeOnGrate
    /// </summary>
    public unsafe virtual bool HasLineOfSightToThrowGrenadeOnGrate(BmSDK.BmGame.RTunnelGrateBase Grate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasLineOfSightToThrowGrenadeOnGrate, "BmScript.RBMBehaviour_BagCarrier.HasLineOfSightToThrowGrenadeOnGrate");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Grate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GotLOSToPlayer;
    /// <summary>
    /// Function: GotLOSToPlayer
    /// </summary>
    public unsafe virtual bool GotLOSToPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotLOSToPlayer, "BmScript.RBMBehaviour_BagCarrier.GotLOSToPlayer");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldStopAndShootPlayer;
    /// <summary>
    /// Function: ShouldStopAndShootPlayer
    /// </summary>
    public unsafe override bool ShouldStopAndShootPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldStopAndShootPlayer, "BmScript.RBMBehaviour_BagCarrier.ShouldStopAndShootPlayer");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerGrateResponse;
    /// <summary>
    /// Function: TriggerGrateResponse
    /// </summary>
    public unsafe override void TriggerGrateResponse(BmSDK.BmGame.RTunnelGrateBase Grate, bool canDestroy = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerGrateResponse, "BmScript.RBMBehaviour_BagCarrier.TriggerGrateResponse");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Grate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(canDestroy, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float UpdateTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.RBMBehaviour_BagCarrier.Tick");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateBagVFX;
    /// <summary>
    /// Function: UpdateBagVFX
    /// </summary>
    public unsafe virtual void UpdateBagVFX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateBagVFX, "BmScript.RBMBehaviour_BagCarrier.UpdateBagVFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyGunEmpty;
    /// <summary>
    /// Function: NotifyGunEmpty
    /// </summary>
    public unsafe override void NotifyGunEmpty()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyGunEmpty, "BmScript.RBMBehaviour_BagCarrier.NotifyGunEmpty");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyFailed;
    /// <summary>
    /// Function: NotifyFailed
    /// </summary>
    public unsafe override void NotifyFailed(BmSDK.BmGame.RBMAIAction FinishedAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFailed, "BmScript.RBMBehaviour_BagCarrier.NotifyFailed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyFinished;
    /// <summary>
    /// Function: NotifyFinished
    /// </summary>
    public unsafe override void NotifyFinished(BmSDK.BmGame.RBMAIAction FinishedAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFinished, "BmScript.RBMBehaviour_BagCarrier.NotifyFinished");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDestination;
    /// <summary>
    /// Function: GetDestination
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDestination(bool bFinalDestQueryOnly = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDestination, "BmScript.RBMBehaviour_BagCarrier.GetDestination");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinalDestQueryOnly, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UnlockCurrentDropoffPoint;
    /// <summary>
    /// Function: UnlockCurrentDropoffPoint
    /// </summary>
    public unsafe override void UnlockCurrentDropoffPoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockCurrentDropoffPoint, "BmScript.RBMBehaviour_BagCarrier.UnlockCurrentDropoffPoint");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockPickupPoints;
    /// <summary>
    /// Function: UnlockPickupPoints
    /// </summary>
    public unsafe override void UnlockPickupPoints()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockPickupPoints, "BmScript.RBMBehaviour_BagCarrier.UnlockPickupPoints");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LockCurrentPickupPoint;
    /// <summary>
    /// Function: LockCurrentPickupPoint
    /// </summary>
    public unsafe virtual void LockCurrentPickupPoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LockCurrentPickupPoint, "BmScript.RBMBehaviour_BagCarrier.LockCurrentPickupPoint");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBestEnabledDropOffPoint;
    /// <summary>
    /// Function: GetBestEnabledDropOffPoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RLootDestinationBase GetBestEnabledDropOffPoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestEnabledDropOffPoint, "BmScript.RBMBehaviour_BagCarrier.GetBestEnabledDropOffPoint");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RLootDestinationBase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AssignPickUpPoint;
    /// <summary>
    /// Function: AssignPickUpPoint
    /// </summary>
    public unsafe virtual void AssignPickUpPoint(BmSDK.BmGame.RLootSourceBase chosenPickUpPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignPickUpPoint, "BmScript.RBMBehaviour_BagCarrier.AssignPickUpPoint");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(chosenPickUpPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChoosePickUpPoint;
    /// <summary>
    /// Function: ChoosePickUpPoint
    /// </summary>
    public unsafe virtual void ChoosePickUpPoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChoosePickUpPoint, "BmScript.RBMBehaviour_BagCarrier.ChoosePickUpPoint");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NeedsRandomPickupPoint;
    /// <summary>
    /// Function: NeedsRandomPickupPoint
    /// </summary>
    public unsafe virtual bool NeedsRandomPickupPoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NeedsRandomPickupPoint, "BmScript.RBMBehaviour_BagCarrier.NeedsRandomPickupPoint");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetOverridingDropOffPoint;
    /// <summary>
    /// Function: SetOverridingDropOffPoint
    /// </summary>
    public unsafe override void SetOverridingDropOffPoint(BmSDK.BmGame.RLootDestinationBase dropoffPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOverridingDropOffPoint, "BmScript.RBMBehaviour_BagCarrier.SetOverridingDropOffPoint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dropoffPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOverridingPickupPoint;
    /// <summary>
    /// Function: SetOverridingPickupPoint
    /// </summary>
    public unsafe override void SetOverridingPickupPoint(BmSDK.BmGame.RLootSourceBase PickupPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOverridingPickupPoint, "BmScript.RBMBehaviour_BagCarrier.SetOverridingPickupPoint");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PickupPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPickUpPointTargetLocation;
    /// <summary>
    /// Function: GetPickUpPointTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPickUpPointTargetLocation(BmSDK.BmGame.RLootSourceBase PickupPoint, out BmSDK.BmGame.RCarriableObjectBagBase existingBag)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPickUpPointTargetLocation, "BmScript.RBMBehaviour_BagCarrier.GetPickUpPointTargetLocation");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PickupPoint, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out existingBag);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(existingBag, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        existingBag = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCarriableObjectBagBase>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsLocationProhibitedByTakedownVolume;
    /// <summary>
    /// Function: IsLocationProhibitedByTakedownVolume
    /// </summary>
    public unsafe virtual bool IsLocationProhibitedByTakedownVolume(System.Numerics.Vector3 Location)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLocationProhibitedByTakedownVolume, "BmScript.RBMBehaviour_BagCarrier.IsLocationProhibitedByTakedownVolume");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Location, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetLeastBusyLootSourceGroups;
    /// <summary>
    /// Function: GetLeastBusyLootSourceGroups
    /// </summary>
    public unsafe virtual BmSDK.TArray<int> GetLeastBusyLootSourceGroups()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLeastBusyLootSourceGroups, "BmScript.RBMBehaviour_BagCarrier.GetLeastBusyLootSourceGroups");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetActorForPredVolTest;
    /// <summary>
    /// Function: GetActorForPredVolTest
    /// </summary>
    public unsafe override BmSDK.Engine.Actor GetActorForPredVolTest()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActorForPredVolTest, "BmScript.RBMBehaviour_BagCarrier.GetActorForPredVolTest");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetJoiningLocations;
    /// <summary>
    /// Function: GetJoiningLocations
    /// </summary>
    public unsafe override bool GetJoiningLocations(out BmSDK.TArray<System.Numerics.Vector3> outLocations, out BmSDK.TArray<BmSDK.GameObject> outObjects)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJoiningLocations, "BmScript.RBMBehaviour_BagCarrier.GetJoiningLocations");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outLocations = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 0);
        outObjects = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.GameObject>>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_PriorityBehaviourWaiting;
    /// <summary>
    /// Function: PriorityBehaviourWaiting
    /// </summary>
    public unsafe override void PriorityBehaviourWaiting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PriorityBehaviourWaiting, "BmScript.RBMBehaviour_BagCarrier.PriorityBehaviourWaiting");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LootBagDroppedOff;
    /// <summary>
    /// Function: LootBagDroppedOff
    /// </summary>
    public unsafe virtual void LootBagDroppedOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LootBagDroppedOff, "BmScript.RBMBehaviour_BagCarrier.LootBagDroppedOff");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DettachBagInternal;
    /// <summary>
    /// Function: DettachBagInternal
    /// </summary>
    public unsafe virtual void DettachBagInternal(bool bEnablePhys, bool bNoPoseChange = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DettachBagInternal, "BmScript.RBMBehaviour_BagCarrier.DettachBagInternal");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnablePhys, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoPoseChange, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DettachBagNoPhysics;
    /// <summary>
    /// Function: DettachBagNoPhysics
    /// </summary>
    public unsafe virtual void DettachBagNoPhysics()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DettachBagNoPhysics, "BmScript.RBMBehaviour_BagCarrier.DettachBagNoPhysics");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DettachBagNoPoseChange;
    /// <summary>
    /// Function: DettachBagNoPoseChange
    /// </summary>
    public unsafe virtual void DettachBagNoPoseChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DettachBagNoPoseChange, "BmScript.RBMBehaviour_BagCarrier.DettachBagNoPoseChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DettachBag;
    /// <summary>
    /// Function: DettachBag
    /// </summary>
    public unsafe virtual void DettachBag()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DettachBag, "BmScript.RBMBehaviour_BagCarrier.DettachBag");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisruptedExplosion;
    /// <summary>
    /// Function: DisruptedExplosion
    /// </summary>
    public unsafe virtual void DisruptedExplosion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisruptedExplosion, "BmScript.RBMBehaviour_BagCarrier.DisruptedExplosion");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachBag;
    /// <summary>
    /// Function: AttachBag
    /// </summary>
    public unsafe virtual void AttachBag()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachBag, "BmScript.RBMBehaviour_BagCarrier.AttachBag");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoPoseChange;
    /// <summary>
    /// Function: DoPoseChange
    /// </summary>
    public unsafe virtual void DoPoseChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoPoseChange, "BmScript.RBMBehaviour_BagCarrier.DoPoseChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyBagNoPoseChange;
    /// <summary>
    /// Function: DestroyBagNoPoseChange
    /// </summary>
    public unsafe virtual void DestroyBagNoPoseChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyBagNoPoseChange, "BmScript.RBMBehaviour_BagCarrier.DestroyBagNoPoseChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyBag;
    /// <summary>
    /// Function: DestroyBag
    /// </summary>
    public unsafe virtual void DestroyBag()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyBag, "BmScript.RBMBehaviour_BagCarrier.DestroyBag");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnBag;
    /// <summary>
    /// Function: SpawnBag
    /// </summary>
    public unsafe virtual void SpawnBag()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnBag, "BmScript.RBMBehaviour_BagCarrier.SpawnBag");
        byte* paramsPtr = stackalloc byte[37];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBombReactAnim;
    /// <summary>
    /// Function: GetBombReactAnim
    /// </summary>
    public unsafe override bool GetBombReactAnim(bool bFront, out BmSDK.FName AnimName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBombReactAnim, "BmScript.RBMBehaviour_BagCarrier.GetBombReactAnim");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFront, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AnimName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AnimName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_OnEndInterrupt;
    /// <summary>
    /// Function: OnEndInterrupt
    /// </summary>
    public unsafe override void OnEndInterrupt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEndInterrupt, "BmScript.RBMBehaviour_BagCarrier.OnEndInterrupt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBeginInterrupt;
    /// <summary>
    /// Function: OnBeginInterrupt
    /// </summary>
    public unsafe override void OnBeginInterrupt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBeginInterrupt, "BmScript.RBMBehaviour_BagCarrier.OnBeginInterrupt");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnExitBehaviourCalled;
    /// <summary>
    /// Function: OnExitBehaviourCalled
    /// </summary>
    public unsafe override void OnExitBehaviourCalled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnExitBehaviourCalled, "BmScript.RBMBehaviour_BagCarrier.OnExitBehaviourCalled");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnExitConditionTriggered;
    /// <summary>
    /// Function: OnExitConditionTriggered
    /// </summary>
    public unsafe override void OnExitConditionTriggered()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnExitConditionTriggered, "BmScript.RBMBehaviour_BagCarrier.OnExitConditionTriggered");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDeactivate;
    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeactivate, "BmScript.RBMBehaviour_BagCarrier.OnDeactivate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishActivation;
    /// <summary>
    /// Function: FinishActivation
    /// </summary>
    public unsafe virtual void FinishActivation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishActivation, "BmScript.RBMBehaviour_BagCarrier.FinishActivation");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInitialState;
    /// <summary>
    /// Function: SetInitialState
    /// </summary>
    public unsafe override void SetInitialState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInitialState, "BmScript.RBMBehaviour_BagCarrier.SetInitialState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnActivate;
    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmScript.RBMBehaviour_BagCarrier.OnActivate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLootPoints;
    /// <summary>
    /// Function: GetLootPoints
    /// </summary>
    public unsafe virtual void GetLootPoints()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLootPoints, "BmScript.RBMBehaviour_BagCarrier.GetLootPoints");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandlesGlance;
    /// <summary>
    /// Function: HandlesGlance
    /// </summary>
    public unsafe override bool HandlesGlance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandlesGlance, "BmScript.RBMBehaviour_BagCarrier.HandlesGlance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Cleanup;
    /// <summary>
    /// Function: Cleanup
    /// </summary>
    public unsafe virtual void Cleanup()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Cleanup, "BmScript.RBMBehaviour_BagCarrier.Cleanup");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetTimeTillOverlay;
    /// <summary>
    /// Function: ResetTimeTillOverlay
    /// </summary>
    public unsafe virtual void ResetTimeTillOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetTimeTillOverlay, "BmScript.RBMBehaviour_BagCarrier.ResetTimeTillOverlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBagCarrierWeaponStance;
    /// <summary>
    /// Function: GetBagCarrierWeaponStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetBagCarrierWeaponStance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBagCarrierWeaponStance, "BmScript.RBMBehaviour_BagCarrier.GetBagCarrierWeaponStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBagCarrierMovementStance;
    /// <summary>
    /// Function: GetBagCarrierMovementStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetBagCarrierMovementStance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBagCarrierMovementStance, "BmScript.RBMBehaviour_BagCarrier.GetBagCarrierMovementStance");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBagCarrierMovementStance_WithBag;
    /// <summary>
    /// Function: GetBagCarrierMovementStance_WithBag
    /// </summary>
    public unsafe virtual BmSDK.FName GetBagCarrierMovementStance_WithBag()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBagCarrierMovementStance_WithBag, "BmScript.RBMBehaviour_BagCarrier.GetBagCarrierMovementStance_WithBag");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBagCarrierMovementStance_NoBag;
    /// <summary>
    /// Function: GetBagCarrierMovementStance_NoBag
    /// </summary>
    public unsafe virtual BmSDK.FName GetBagCarrierMovementStance_NoBag()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBagCarrierMovementStance_NoBag, "BmScript.RBMBehaviour_BagCarrier.GetBagCarrierMovementStance_NoBag");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPickupOffFloorAnimName;
    /// <summary>
    /// Function: GetPickupOffFloorAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetPickupOffFloorAnimName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPickupOffFloorAnimName, "BmScript.RBMBehaviour_BagCarrier.GetPickupOffFloorAnimName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDropOffAnimName;
    /// <summary>
    /// Function: GetDropOffAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetDropOffAnimName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDropOffAnimName, "BmScript.RBMBehaviour_BagCarrier.GetDropOffAnimName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ChooseDropoffDirection;
    /// <summary>
    /// Function: ChooseDropoffDirection
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RBMBehaviour_BagCarrier.eLootPointInteractDirection ChooseDropoffDirection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChooseDropoffDirection, "BmScript.RBMBehaviour_BagCarrier.ChooseDropoffDirection");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.RBMBehaviour_BagCarrier.eLootPointInteractDirection>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasDirectionalDropoffAnims;
    /// <summary>
    /// Function: HasDirectionalDropoffAnims
    /// </summary>
    public unsafe virtual bool HasDirectionalDropoffAnims()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasDirectionalDropoffAnims, "BmScript.RBMBehaviour_BagCarrier.HasDirectionalDropoffAnims");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBagAnimSet;
    /// <summary>
    /// Function: GetBagAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetBagAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBagAnimSet, "BmScript.RBMBehaviour_BagCarrier.GetBagAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDoorWaitIdleAnimName;
    /// <summary>
    /// Function: GetDoorWaitIdleAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetDoorWaitIdleAnimName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDoorWaitIdleAnimName, "BmScript.RBMBehaviour_BagCarrier.GetDoorWaitIdleAnimName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDoorWaitInAnimName;
    /// <summary>
    /// Function: GetDoorWaitInAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetDoorWaitInAnimName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDoorWaitInAnimName, "BmScript.RBMBehaviour_BagCarrier.GetDoorWaitInAnimName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDoorWaitAnimSet;
    /// <summary>
    /// Function: GetDoorWaitAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetDoorWaitAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDoorWaitAnimSet, "BmScript.RBMBehaviour_BagCarrier.GetDoorWaitAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetExitAnimName;
    /// <summary>
    /// Function: GetExitAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetExitAnimName(bool bDeterministic = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetExitAnimName, "BmScript.RBMBehaviour_BagCarrier.GetExitAnimName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDeterministic, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetEntryAnimName;
    /// <summary>
    /// Function: GetEntryAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetEntryAnimName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEntryAnimName, "BmScript.RBMBehaviour_BagCarrier.GetEntryAnimName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEntryExitAnimSet;
    /// <summary>
    /// Function: GetEntryExitAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetEntryExitAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEntryExitAnimSet, "BmScript.RBMBehaviour_BagCarrier.GetEntryExitAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLootingOutAnimName;
    /// <summary>
    /// Function: GetLootingOutAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetLootingOutAnimName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLootingOutAnimName, "BmScript.RBMBehaviour_BagCarrier.GetLootingOutAnimName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLootingIdleAnimName;
    /// <summary>
    /// Function: GetLootingIdleAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetLootingIdleAnimName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLootingIdleAnimName, "BmScript.RBMBehaviour_BagCarrier.GetLootingIdleAnimName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLootingInAnimName;
    /// <summary>
    /// Function: GetLootingInAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetLootingInAnimName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLootingInAnimName, "BmScript.RBMBehaviour_BagCarrier.GetLootingInAnimName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLootingAnimSet;
    /// <summary>
    /// Function: GetLootingAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetLootingAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLootingAnimSet, "BmScript.RBMBehaviour_BagCarrier.GetLootingAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayLootPointDropoffAnim;
    /// <summary>
    /// Function: PlayLootPointDropoffAnim
    /// </summary>
    public unsafe virtual void PlayLootPointDropoffAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayLootPointDropoffAnim, "BmScript.RBMBehaviour_BagCarrier.PlayLootPointDropoffAnim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayLootPointPickupAnim;
    /// <summary>
    /// Function: PlayLootPointPickupAnim
    /// </summary>
    public unsafe virtual void PlayLootPointPickupAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayLootPointPickupAnim, "BmScript.RBMBehaviour_BagCarrier.PlayLootPointPickupAnim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropoffPointStateChange;
    /// <summary>
    /// Function: DropoffPointStateChange
    /// </summary>
    public unsafe virtual void DropoffPointStateChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropoffPointStateChange, "BmScript.RBMBehaviour_BagCarrier.DropoffPointStateChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MainStateChange;
    /// <summary>
    /// Function: MainStateChange
    /// </summary>
    public unsafe virtual void MainStateChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MainStateChange, "BmScript.RBMBehaviour_BagCarrier.MainStateChange");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitialStateChange;
    /// <summary>
    /// Function: InitialStateChange
    /// </summary>
    public unsafe virtual void InitialStateChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialStateChange, "BmScript.RBMBehaviour_BagCarrier.InitialStateChange");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPickupPointAnimInfo;
    /// <summary>
    /// Function: GetPickupPointAnimInfo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RLootPointBase.FLootingAnimInfo GetPickupPointAnimInfo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPickupPointAnimInfo, "BmScript.RBMBehaviour_BagCarrier.GetPickupPointAnimInfo");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RLootPointBase.FLootingAnimInfo>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsLongWayFromDropoff;
    /// <summary>
    /// Function: IsLongWayFromDropoff
    /// </summary>
    public unsafe override bool IsLongWayFromDropoff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLongWayFromDropoff, "BmScript.RBMBehaviour_BagCarrier.IsLongWayFromDropoff");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDistFromDropoff;
    /// <summary>
    /// Function: GetDistFromDropoff
    /// </summary>
    public unsafe override float GetDistFromDropoff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDistFromDropoff, "BmScript.RBMBehaviour_BagCarrier.GetDistFromDropoff");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShutdownTimerHUD;
    /// <summary>
    /// Function: ShutdownTimerHUD
    /// </summary>
    public unsafe virtual void ShutdownTimerHUD()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShutdownTimerHUD, "BmScript.RBMBehaviour_BagCarrier.ShutdownTimerHUD");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryUpdateTimerHUD;
    /// <summary>
    /// Function: TryUpdateTimerHUD
    /// </summary>
    public unsafe virtual void TryUpdateTimerHUD(int IntRemainingTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryUpdateTimerHUD, "BmScript.RBMBehaviour_BagCarrier.TryUpdateTimerHUD");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntRemainingTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitTimerHUD;
    /// <summary>
    /// Function: InitTimerHUD
    /// </summary>
    public unsafe virtual void InitTimerHUD()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitTimerHUD, "BmScript.RBMBehaviour_BagCarrier.InitTimerHUD");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: eLootPointInteractDirection
    /// </summary>
    public enum eLootPointInteractDirection : byte
    {
        eLPIDNotSet = 0,
        eLPIDStraight = 1,
        eLPIDLeft = 2,
        eLPIDRight = 3,
        eLootPointInteractDirection_MAX = 4,
    }

    /// <summary>
    /// ArrayProperty: allPickUpPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLootSourceBase> allPickUpPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLootSourceBase>>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ArrayProperty: allDropOffPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLootDestinationBase> allDropOffPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLootDestinationBase>>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: ExitPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor ExitPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: currPickupPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RLootSourceBase currPickupPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLootSourceBase>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: currDropOffPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RLootDestinationBase currDropOffPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLootDestinationBase>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: ShootAction
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIAction_StandAndShoot ShootAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIAction_StandAndShoot>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: GrateTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase GrateTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: introAnimRefPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor introAnimRefPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: OverridingPickUpPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RLootSourceBase OverridingPickUpPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLootSourceBase>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: OverridingDropOffPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RLootDestinationBase OverridingDropOffPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLootDestinationBase>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bDebug
    /// </summary>
    public unsafe bool bDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bChasePlayer
    /// </summary>
    public unsafe bool bChasePlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bFinishedPickingUp
    /// </summary>
    public unsafe bool bFinishedPickingUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bHasLootingIdleAnim
    /// </summary>
    public unsafe bool bHasLootingIdleAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bHasLootingOutAnim
    /// </summary>
    public unsafe bool bHasLootingOutAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bGotLootPoints
    /// </summary>
    public unsafe bool bGotLootPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bStartedShooting
    /// </summary>
    public unsafe bool bStartedShooting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bRandomPickupPointSelection
    /// </summary>
    public unsafe bool bRandomPickupPointSelection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bForceFirstPickupPointToBeNonRandom
    /// </summary>
    public unsafe bool bForceFirstPickupPointToBeNonRandom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bChosenPickupPointSinceActivation
    /// </summary>
    public unsafe bool bChosenPickupPointSinceActivation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bPlayIntroAnim
    /// </summary>
    public unsafe bool bPlayIntroAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bEnterFromRight
    /// </summary>
    public unsafe bool bEnterFromRight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bPlayedIntroAnim
    /// </summary>
    public unsafe bool bPlayedIntroAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredIntroAnimFinishedOutput
    /// </summary>
    public unsafe bool bTriggeredIntroAnimFinishedOutput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: inPlaceForGrateGrenadeThrow
    /// </summary>
    public unsafe bool inPlaceForGrateGrenadeThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bagVFXActive
    /// </summary>
    public unsafe bool bagVFXActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bUseAlternateDropoffAnim
    /// </summary>
    public unsafe bool bUseAlternateDropoffAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: cachedDestinationIsWaypoint
    /// </summary>
    public unsafe bool cachedDestinationIsWaypoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bNeverUseWaypoints
    /// </summary>
    public unsafe bool bNeverUseWaypoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bTempDontUseWaypoints
    /// </summary>
    public unsafe bool bTempDontUseWaypoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bDbgDrawWaypoints
    /// </summary>
    public unsafe bool bDbgDrawWaypoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bSpawnedBag
    /// </summary>
    public unsafe bool bSpawnedBag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bLastAmbientDialogueWasAboutCash
    /// </summary>
    public unsafe bool bLastAmbientDialogueWasAboutCash
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bHasEverBeenInterrupted
    /// </summary>
    public unsafe bool bHasEverBeenInterrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bDonePostInterruptRoomwideAlert
    /// </summary>
    public unsafe bool bDonePostInterruptRoomwideAlert
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bRequestedLadderFreePath
    /// </summary>
    public unsafe bool bRequestedLadderFreePath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// StructProperty: transID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId transID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 792);

    /// <summary>
    /// FloatProperty: timeSinceRepathCheck
    /// </summary>
    public unsafe float timeSinceRepathCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: TimeTillOverlay
    /// </summary>
    public unsafe float TimeTillOverlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// FloatProperty: timeBetweenOverlaysMin
    /// </summary>
    public unsafe float timeBetweenOverlaysMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// FloatProperty: timeBetweenOverlaysMax
    /// </summary>
    public unsafe float timeBetweenOverlaysMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// FloatProperty: TimeSpentPickingUp
    /// </summary>
    public unsafe float TimeSpentPickingUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: pickupDuration
    /// </summary>
    public unsafe float pickupDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// FloatProperty: aimAtGrateStartTime
    /// </summary>
    public unsafe float aimAtGrateStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// FloatProperty: aimAtGrateDuration
    /// </summary>
    public unsafe float aimAtGrateDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// StructProperty: cachedDropoffDestination
    /// </summary>
    public unsafe ref System.Numerics.Vector3 cachedDropoffDestination
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 828);

    /// <summary>
    /// IntProperty: nextWaypointIndex
    /// </summary>
    public unsafe int nextWaypointIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// FloatProperty: LastHUDTimerDrawTime
    /// </summary>
    public unsafe float LastHUDTimerDrawTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// StructProperty: pickupFromFloorAnimStartLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 pickupFromFloorAnimStartLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 848);

    /// <summary>
    /// FloatProperty: PostCheatChaseStartTime
    /// </summary>
    public unsafe float PostCheatChaseStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ByteProperty: interactDirection
    /// </summary>
    public unsafe BmSDK.BmScript.RBMBehaviour_BagCarrier.eLootPointInteractDirection interactDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RBMBehaviour_BagCarrier.eLootPointInteractDirection>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// ByteProperty: FuturePathElevation
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIAction_BaseMove.ePathElevation FuturePathElevation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIAction_BaseMove.ePathElevation>(Ptr + 865); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 865); }
    }

    /// <summary>
    /// StructProperty: FuturePathAimPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FuturePathAimPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 868);
}
