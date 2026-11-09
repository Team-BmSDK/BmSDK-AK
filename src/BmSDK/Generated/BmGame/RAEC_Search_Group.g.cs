#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_Search_Group<br/>
/// (size = 816)
/// (flags = 10485778)
/// </summary>
public partial class RAEC_Search_Group : BmSDK.BmGame.RAlertEventCoordinatorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Search_Group", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_Search_Group.
    /// </summary>
    public static RAEC_Search_Group DefaultObject => (RAEC_Search_Group)StaticClass().DefaultObject;

    internal RAEC_Search_Group() { }

    /// <summary>
    /// Constructs a new RAEC_Search_Group
    /// </summary>
    public RAEC_Search_Group(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Search_Group(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Group>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Group>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Group>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Group>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Group>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Group>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Group>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search_Group>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnBeginShutdown;
    /// <summary>
    /// Function: OnBeginShutdown
    /// </summary>
    public unsafe override void OnBeginShutdown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBeginShutdown, "BmGame.RAEC_Search_Group.OnBeginShutdown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveFailed;
    /// <summary>
    /// Function: MoveFailed
    /// </summary>
    public unsafe virtual void MoveFailed(System.Numerics.Vector3 StartPos, System.Numerics.Vector3 StartDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveFailed, "BmGame.RAEC_Search_Group.MoveFailed");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartDir, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartProcessingNextLeg;
    /// <summary>
    /// Function: StartProcessingNextLeg
    /// </summary>
    public unsafe virtual void StartProcessingNextLeg(System.Numerics.Vector3 StartPos, System.Numerics.Vector3 StartDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartProcessingNextLeg, "BmGame.RAEC_Search_Group.StartProcessingNextLeg");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartDir, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSearchForNextLeg;
    /// <summary>
    /// Function: StartSearchForNextLeg
    /// </summary>
    public unsafe virtual void StartSearchForNextLeg()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSearchForNextLeg, "BmGame.RAEC_Search_Group.StartSearchForNextLeg");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasMinigunnerInFormation;
    /// <summary>
    /// Function: HasMinigunnerInFormation
    /// </summary>
    public unsafe virtual bool HasMinigunnerInFormation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasMinigunnerInFormation, "BmGame.RAEC_Search_Group.HasMinigunnerInFormation");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldCheckSideRooms;
    /// <summary>
    /// Function: ShouldCheckSideRooms
    /// </summary>
    public unsafe virtual bool ShouldCheckSideRooms()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldCheckSideRooms, "BmGame.RAEC_Search_Group.ShouldCheckSideRooms");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldTryCorners;
    /// <summary>
    /// Function: ShouldTryCorners
    /// </summary>
    public unsafe virtual bool ShouldTryCorners()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldTryCorners, "BmGame.RAEC_Search_Group.ShouldTryCorners");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasSpecialDestination;
    /// <summary>
    /// Function: HasSpecialDestination
    /// </summary>
    public unsafe virtual bool HasSpecialDestination()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasSpecialDestination, "BmGame.RAEC_Search_Group.HasSpecialDestination");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldForceDirect;
    /// <summary>
    /// Function: ShouldForceDirect
    /// </summary>
    public unsafe virtual bool ShouldForceDirect()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceDirect, "BmGame.RAEC_Search_Group.ShouldForceDirect");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldAvoidBacktracking;
    /// <summary>
    /// Function: ShouldAvoidBacktracking
    /// </summary>
    public unsafe virtual bool ShouldAvoidBacktracking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldAvoidBacktracking, "BmGame.RAEC_Search_Group.ShouldAvoidBacktracking");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AddJoiningBuddy;
    /// <summary>
    /// Function: AddJoiningBuddy
    /// </summary>
    public unsafe virtual bool AddJoiningBuddy(BmSDK.BmGame.RBMAIController FollowCon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddJoiningBuddy, "BmGame.RAEC_Search_Group.AddJoiningBuddy");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowCon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ReassignBuddyJoin;
    /// <summary>
    /// Function: ReassignBuddyJoin
    /// </summary>
    public unsafe virtual void ReassignBuddyJoin()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReassignBuddyJoin, "BmGame.RAEC_Search_Group.ReassignBuddyJoin");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReassignStandard;
    /// <summary>
    /// Function: ReassignStandard
    /// </summary>
    public unsafe virtual void ReassignStandard()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReassignStandard, "BmGame.RAEC_Search_Group.ReassignStandard");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReassignToSideRoom;
    /// <summary>
    /// Function: ReassignToSideRoom
    /// </summary>
    public unsafe virtual void ReassignToSideRoom(System.Numerics.Vector3 LeaderLoc, System.Numerics.Vector3 SearchLoc, BmSDK.BmGame.RSideRoomVolume SideVol)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReassignToSideRoom, "BmGame.RAEC_Search_Group.ReassignToSideRoom");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeaderLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchLoc, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideVol, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReassignToWallShoot;
    /// <summary>
    /// Function: ReassignToWallShoot
    /// </summary>
    public unsafe virtual void ReassignToWallShoot(BmSDK.BmGame.RDestructibleProp_FractureWall WeakWall, System.Numerics.Vector3 WallLoc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReassignToWallShoot, "BmGame.RAEC_Search_Group.ReassignToWallShoot");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeakWall, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLoc, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReassignToLedgeLook;
    /// <summary>
    /// Function: ReassignToLedgeLook
    /// </summary>
    public unsafe virtual void ReassignToLedgeLook(BmSDK.BmGame.RLedgeLookDangerAreaInfo LedgeDangerInfo, System.Numerics.Vector3 LedgeLookStart, System.Numerics.Vector3 LedgeLookEnd)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReassignToLedgeLook, "BmGame.RAEC_Search_Group.ReassignToLedgeLook");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LedgeDangerInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LedgeLookStart, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LedgeLookEnd, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReassignToGrate;
    /// <summary>
    /// Function: ReassignToGrate
    /// </summary>
    public unsafe virtual void ReassignToGrate(BmSDK.BmGame.RTunnelGrateBase FirstGrate, BmSDK.BmGame.RTunnelGrateBase LastGrate, System.Numerics.Vector3 StandAtEndPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReassignToGrate, "BmGame.RAEC_Search_Group.ReassignToGrate");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstGrate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LastGrate, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StandAtEndPoint, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReassignToPredatorPoint;
    /// <summary>
    /// Function: ReassignToPredatorPoint
    /// </summary>
    public unsafe virtual void ReassignToPredatorPoint(BmSDK.BmGame.RPredatorSpecialMovePointBase PredatorPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReassignToPredatorPoint, "BmGame.RAEC_Search_Group.ReassignToPredatorPoint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PredatorPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReassignToCorner;
    /// <summary>
    /// Function: ReassignToCorner
    /// </summary>
    public unsafe virtual void ReassignToCorner(BmSDK.BmGame.RCornerWallMarker StartCorner, BmSDK.BmGame.RCornerWallMarker EndCorner)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReassignToCorner, "BmGame.RAEC_Search_Group.ReassignToCorner");
        byte* paramsPtr = stackalloc byte[41];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartCorner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndCorner, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReassignToSplitGroup;
    /// <summary>
    /// Function: ReassignToSplitGroup
    /// </summary>
    public unsafe virtual void ReassignToSplitGroup(BmSDK.BmGame.RSearchRoutingWrapper.FSideBranchStruct SplitPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReassignToSplitGroup, "BmGame.RAEC_Search_Group.ReassignToSplitGroup");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SplitPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignFromSpecial;
    /// <summary>
    /// Function: AssignFromSpecial
    /// </summary>
    public unsafe virtual void AssignFromSpecial(BmSDK.BmGame.RBMAIController NewLeader = default, bool useAlternateRotation = default, BmSDK.Rotator alternateRotation = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignFromSpecial, "BmGame.RAEC_Search_Group.AssignFromSpecial");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLeader, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(useAlternateRotation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(alternateRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LeaderChangeIsAllowed;
    /// <summary>
    /// Function: LeaderChangeIsAllowed
    /// </summary>
    public unsafe virtual bool LeaderChangeIsAllowed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LeaderChangeIsAllowed, "BmGame.RAEC_Search_Group.LeaderChangeIsAllowed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TransferMembersBetween;
    /// <summary>
    /// Function: TransferMembersBetween
    /// </summary>
    public unsafe virtual void TransferMembersBetween(BmSDK.BmGame.RAEC_Search_Formation OldFormation, BmSDK.BmGame.RAEC_Search_Formation NewFormation, BmSDK.BmGame.RBMAIController NewLeader = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TransferMembersBetween, "BmGame.RAEC_Search_Group.TransferMembersBetween");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldFormation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFormation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLeader, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefuseBuddy;
    /// <summary>
    /// Function: RefuseBuddy
    /// </summary>
    public unsafe virtual bool RefuseBuddy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefuseBuddy, "BmGame.RAEC_Search_Group.RefuseBuddy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AbsorbFollowers;
    /// <summary>
    /// Function: AbsorbFollowers
    /// </summary>
    public unsafe virtual void AbsorbFollowers(BmSDK.BmGame.RAEC_Search_Group AbsorbedGroup)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AbsorbFollowers, "BmGame.RAEC_Search_Group.AbsorbFollowers");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbsorbedGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLeaderFromChase;
    /// <summary>
    /// Function: SetLeaderFromChase
    /// </summary>
    public unsafe virtual void SetLeaderFromChase(BmSDK.BmGame.RBMAIController NewLeader, System.Numerics.Vector3 NewUDestFromChase)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLeaderFromChase, "BmGame.RAEC_Search_Group.SetLeaderFromChase");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLeader, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUDestFromChase, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLeader;
    /// <summary>
    /// Function: SetLeader
    /// </summary>
    public unsafe virtual void SetLeader(BmSDK.BmGame.RBMAIController NewLeader)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLeader, "BmGame.RAEC_Search_Group.SetLeader");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLeader, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawVis;
    /// <summary>
    /// Function: DrawVis
    /// </summary>
    public unsafe override void DrawVis()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawVis, "BmGame.RAEC_Search_Group.DrawVis");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRemoveGroupChild;
    /// <summary>
    /// Function: OnRemoveGroupChild
    /// </summary>
    public unsafe override void OnRemoveGroupChild(BmSDK.BmGame.RAlertEventCoordinatorBase RemAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRemoveGroupChild, "BmGame.RAEC_Search_Group.OnRemoveGroupChild");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RAEC_Search_Group.PreStreamOut");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RAEC_Search_Group.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: SearchRouting
    /// </summary>
    public unsafe BmSDK.BmGame.RSearchRoutingWrapper SearchRouting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSearchRoutingWrapper>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: FormationAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Search_Formation FormationAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Search_Formation>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ObjectProperty: PreviousParent
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Search_Group PreviousParent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Search_Group>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ClassProperty: SpawnClass
    /// </summary>
    public unsafe BmSDK.Class SpawnClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// StructProperty: LastArrivePos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastArrivePos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 752);

    /// <summary>
    /// StructProperty: LastArriveDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastArriveDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 764);

    /// <summary>
    /// StructProperty: UltimateDestination
    /// </summary>
    public unsafe ref System.Numerics.Vector3 UltimateDestination
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 776);

    /// <summary>
    /// StructProperty: NextMovePoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 NextMovePoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 788);

    /// <summary>
    /// BoolProperty: bPickNewUDestOnArrival
    /// </summary>
    public unsafe bool bPickNewUDestOnArrival
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// StructProperty: LastGroupSplitLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastGroupSplitLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 804);
}
