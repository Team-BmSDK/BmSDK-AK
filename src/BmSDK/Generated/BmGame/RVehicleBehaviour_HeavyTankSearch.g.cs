#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBehaviour_HeavyTankSearch<br/>
/// (size = 1008)
/// (flags = 134230162)
/// </summary>
public partial class RVehicleBehaviour_HeavyTankSearch : BmSDK.BmGame.RVehicleBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBehaviour_HeavyTankSearch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RVehicleBehaviour_HeavyTankSearch.
    /// </summary>
    public static RVehicleBehaviour_HeavyTankSearch DefaultObject => (RVehicleBehaviour_HeavyTankSearch)StaticClass().DefaultObject;

    internal RVehicleBehaviour_HeavyTankSearch() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_HeavyTankSearch
    /// </summary>
    public RVehicleBehaviour_HeavyTankSearch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_HeavyTankSearch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_HeavyTankSearch(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBehaviour_HeavyTankSearch>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBehaviour_HeavyTankSearch>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBehaviour_HeavyTankSearch>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBehaviour_HeavyTankSearch>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBehaviour_HeavyTankSearch>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBehaviour_HeavyTankSearch>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBehaviour_HeavyTankSearch>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBehaviour_HeavyTankSearch>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_AmIOnTheWrongIsland;
    /// <summary>
    /// Function: AmIOnTheWrongIsland
    /// </summary>
    public unsafe virtual bool AmIOnTheWrongIsland()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AmIOnTheWrongIsland, "BmGame.RVehicleBehaviour_HeavyTankSearch.AmIOnTheWrongIsland");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HeavyTankBehExittedInappropriately;
    /// <summary>
    /// Function: HeavyTankBehExittedInappropriately
    /// </summary>
    public unsafe virtual void HeavyTankBehExittedInappropriately(int R, int G, int B)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HeavyTankBehExittedInappropriately, "BmGame.RVehicleBehaviour_HeavyTankSearch.HeavyTankBehExittedInappropriately");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginDroneHack;
    /// <summary>
    /// Function: BeginDroneHack
    /// </summary>
    public unsafe override void BeginDroneHack(BmSDK.BmGame.RVehicle Hacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginDroneHack, "BmGame.RVehicleBehaviour_HeavyTankSearch.BeginDroneHack");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Hacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTargetActor;
    /// <summary>
    /// Function: GetTargetActor
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetTargetActor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetActor, "BmGame.RVehicleBehaviour_HeavyTankSearch.GetTargetActor");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SuperHighPriority;
    /// <summary>
    /// Function: SuperHighPriority
    /// </summary>
    public unsafe virtual bool SuperHighPriority()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuperHighPriority, "BmGame.RVehicleBehaviour_HeavyTankSearch.SuperHighPriority");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSearchCentre;
    /// <summary>
    /// Function: GetSearchCentre
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetSearchCentre()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSearchCentre, "BmGame.RVehicleBehaviour_HeavyTankSearch.GetSearchCentre");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AlertNearbyTanks;
    /// <summary>
    /// Function: AlertNearbyTanks
    /// </summary>
    public unsafe virtual void AlertNearbyTanks(System.Numerics.Vector3 TargetLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertNearbyTanks, "BmGame.RVehicleBehaviour_HeavyTankSearch.AlertNearbyTanks");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendTanksToLocation;
    /// <summary>
    /// Function: SendTanksToLocation
    /// </summary>
    public unsafe static void SendTanksToLocation(BmSDK.TArray<System.Numerics.Vector3> PositionsToSearch, BmSDK.BmGame.RRoadNetwork Roads, BmSDK.TArray<BmSDK.BmGame.RVehicleBehaviour_HeavyTankSearch> TankList, bool Kismet)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendTanksToLocation, "BmGame.RVehicleBehaviour_HeavyTankSearch.SendTanksToLocation");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PositionsToSearch, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Roads, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TankList, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Kismet, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_AlertNTanksInRadiusToBmPresence;
    /// <summary>
    /// Function: AlertNTanksInRadiusToBmPresence
    /// </summary>
    public unsafe static int AlertNTanksInRadiusToBmPresence(BmSDK.TArray<System.Numerics.Vector3> Locations, float MaxRadius, int MaxEnemies, BmSDK.BmGame.RVehicleNPC TankToIgnore, int MaxTotalAttackers, bool NoiseReaction, bool CommanderOnly, bool Kismet, out byte CommanderAlerted)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertNTanksInRadiusToBmPresence, "BmGame.RVehicleBehaviour_HeavyTankSearch.AlertNTanksInRadiusToBmPresence");
        byte* paramsPtr = stackalloc byte[188];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Locations, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxRadius, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxEnemies, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TankToIgnore, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxTotalAttackers, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoiseReaction, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CommanderOnly, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Kismet, paramsPtr + 44);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CommanderAlerted);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CommanderAlerted, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CommanderAlerted = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 48);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_SearchLocation;
    /// <summary>
    /// Function: SearchLocation
    /// </summary>
    public unsafe virtual bool SearchLocation(System.Numerics.Vector3 SpottedLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SearchLocation, "BmGame.RVehicleBehaviour_HeavyTankSearch.SearchLocation");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpottedLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PlayerSpottedByDrones;
    /// <summary>
    /// Function: PlayerSpottedByDrones
    /// </summary>
    public unsafe virtual void PlayerSpottedByDrones(System.Numerics.Vector3 SpottedLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerSpottedByDrones, "BmGame.RVehicleBehaviour_HeavyTankSearch.PlayerSpottedByDrones");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpottedLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInitialSearchLink;
    /// <summary>
    /// Function: GetInitialSearchLink
    /// </summary>
    public unsafe virtual int GetInitialSearchLink(BmSDK.BmGame.RRoadNetwork Roads, int StartLink, System.Numerics.Vector3 Direction, out float LinkT, out System.Numerics.Vector3 EndLoc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInitialSearchLink, "BmGame.RVehicleBehaviour_HeavyTankSearch.GetInitialSearchLink");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Roads, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLink, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out LinkT);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkT, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out EndLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLoc, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        LinkT = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        EndLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_BeginRunAway;
    /// <summary>
    /// Function: BeginRunAway
    /// </summary>
    public unsafe virtual void BeginRunAway(System.Numerics.Vector3 Direction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginRunAway, "BmGame.RVehicleBehaviour_HeavyTankSearch.BeginRunAway");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceAttack;
    /// <summary>
    /// Function: ForceAttack
    /// </summary>
    public unsafe virtual void ForceAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceAttack, "BmGame.RVehicleBehaviour_HeavyTankSearch.ForceAttack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoLastKnownPosition;
    /// <summary>
    /// Function: GotoLastKnownPosition
    /// </summary>
    public unsafe virtual void GotoLastKnownPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoLastKnownPosition, "BmGame.RVehicleBehaviour_HeavyTankSearch.GotoLastKnownPosition");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartChase;
    /// <summary>
    /// Function: StartChase
    /// </summary>
    public unsafe virtual void StartChase()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartChase, "BmGame.RVehicleBehaviour_HeavyTankSearch.StartChase");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoEvilScanLines;
    /// <summary>
    /// Function: DoEvilScanLines
    /// </summary>
    public unsafe virtual void DoEvilScanLines(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoEvilScanLines, "BmGame.RVehicleBehaviour_HeavyTankSearch.DoEvilScanLines");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScanRadius;
    /// <summary>
    /// Function: ScanRadius
    /// </summary>
    public unsafe virtual void ScanRadius(float Radius)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScanRadius, "BmGame.RVehicleBehaviour_HeavyTankSearch.ScanRadius");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScanDirection;
    /// <summary>
    /// Function: ScanDirection
    /// </summary>
    public unsafe virtual void ScanDirection(System.Numerics.Vector3 ScanDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScanDirection, "BmGame.RVehicleBehaviour_HeavyTankSearch.ScanDirection");
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScanDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetScanColour;
    /// <summary>
    /// Function: GetScanColour
    /// </summary>
    public unsafe virtual void GetScanColour(out int R, out int G, out int B)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScanColour, "BmGame.RVehicleBehaviour_HeavyTankSearch.GetScanColour");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out R);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out G);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out B);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        R = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        G = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        B = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_DoScanLines;
    /// <summary>
    /// Function: DoScanLines
    /// </summary>
    public unsafe virtual void DoScanLines(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoScanLines, "BmGame.RVehicleBehaviour_HeavyTankSearch.DoScanLines");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick360Scan;
    /// <summary>
    /// Function: Tick360Scan
    /// </summary>
    public unsafe virtual void Tick360Scan(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick360Scan, "BmGame.RVehicleBehaviour_HeavyTankSearch.Tick360Scan");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPostEngagePhase;
    /// <summary>
    /// Function: GetPostEngagePhase
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RVehicleBehaviour_HeavyTankSearch.ETankSearchPhase GetPostEngagePhase()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPostEngagePhase, "BmGame.RVehicleBehaviour_HeavyTankSearch.GetPostEngagePhase");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RVehicleBehaviour_HeavyTankSearch.ETankSearchPhase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEngageTargetThrottleScale;
    /// <summary>
    /// Function: GetEngageTargetThrottleScale
    /// </summary>
    public unsafe virtual float GetEngageTargetThrottleScale()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEngageTargetThrottleScale, "BmGame.RVehicleBehaviour_HeavyTankSearch.GetEngageTargetThrottleScale");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanLoseTargetWhenEngaging;
    /// <summary>
    /// Function: CanLoseTargetWhenEngaging
    /// </summary>
    public unsafe virtual bool CanLoseTargetWhenEngaging()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanLoseTargetWhenEngaging, "BmGame.RVehicleBehaviour_HeavyTankSearch.CanLoseTargetWhenEngaging");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TickEngageTarget;
    /// <summary>
    /// Function: TickEngageTarget
    /// </summary>
    public unsafe virtual void TickEngageTarget(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickEngageTarget, "BmGame.RVehicleBehaviour_HeavyTankSearch.TickEngageTarget");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSearchThrottleScale;
    /// <summary>
    /// Function: GetSearchThrottleScale
    /// </summary>
    public unsafe virtual float GetSearchThrottleScale()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSearchThrottleScale, "BmGame.RVehicleBehaviour_HeavyTankSearch.GetSearchThrottleScale");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TickSearchLastKnownPos;
    /// <summary>
    /// Function: TickSearchLastKnownPos
    /// </summary>
    public unsafe virtual void TickSearchLastKnownPos(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickSearchLastKnownPos, "BmGame.RVehicleBehaviour_HeavyTankSearch.TickSearchLastKnownPos");
        byte* paramsPtr = stackalloc byte[37];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandlesTurretAndShooting;
    /// <summary>
    /// Function: HandlesTurretAndShooting
    /// </summary>
    public unsafe override bool HandlesTurretAndShooting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandlesTurretAndShooting, "BmGame.RVehicleBehaviour_HeavyTankSearch.HandlesTurretAndShooting");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TickRandomSearch;
    /// <summary>
    /// Function: TickRandomSearch
    /// </summary>
    public unsafe virtual void TickRandomSearch(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickRandomSearch, "BmGame.RVehicleBehaviour_HeavyTankSearch.TickRandomSearch");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChooseRandomNextSearchPoint;
    /// <summary>
    /// Function: ChooseRandomNextSearchPoint
    /// </summary>
    public unsafe virtual bool ChooseRandomNextSearchPoint(int StartPoint, int ExcludeLink, bool NoDeadEnds, out int LinkEndPoint, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restriction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChooseRandomNextSearchPoint, "BmGame.RVehicleBehaviour_HeavyTankSearch.ChooseRandomNextSearchPoint");
        byte* paramsPtr = stackalloc byte[204];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExcludeLink, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoDeadEnds, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out LinkEndPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkEndPoint, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LinkEndPoint = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
        Restriction = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 184);
    }

    private static BmSDK.Function __fn_NotifyTakeDamage;
    /// <summary>
    /// Function: NotifyTakeDamage
    /// </summary>
    public unsafe override void NotifyTakeDamage(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyTakeDamage, "BmGame.RVehicleBehaviour_HeavyTankSearch.NotifyTakeDamage");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 84);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyBumpedBatmobile;
    /// <summary>
    /// Function: NotifyBumpedBatmobile
    /// </summary>
    public unsafe override void NotifyBumpedBatmobile(BmSDK.BmGame.RVehicleBatmobileBase Batmobile, System.Numerics.Vector3 ContactPos, float Speed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyBumpedBatmobile, "BmGame.RVehicleBehaviour_HeavyTankSearch.NotifyBumpedBatmobile");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Batmobile, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactPos, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AlertToBatmobile;
    /// <summary>
    /// Function: AlertToBatmobile
    /// </summary>
    public unsafe virtual bool AlertToBatmobile(bool DueToDeath = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertToBatmobile, "BmGame.RVehicleBehaviour_HeavyTankSearch.AlertToBatmobile");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DueToDeath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Set360ScanTime;
    /// <summary>
    /// Function: Set360ScanTime
    /// </summary>
    public unsafe virtual void Set360ScanTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Set360ScanTime, "BmGame.RVehicleBehaviour_HeavyTankSearch.Set360ScanTime");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSearchRadius;
    /// <summary>
    /// Function: GetSearchRadius
    /// </summary>
    public unsafe virtual float GetSearchRadius()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSearchRadius, "BmGame.RVehicleBehaviour_HeavyTankSearch.GetSearchRadius");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Start360Scans;
    /// <summary>
    /// Function: Start360Scans
    /// </summary>
    public unsafe virtual void Start360Scans()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Start360Scans, "BmGame.RVehicleBehaviour_HeavyTankSearch.Start360Scans");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RVehicleBehaviour_HeavyTankSearch.Tick");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateCanDriveBackwards;
    /// <summary>
    /// Function: UpdateCanDriveBackwards
    /// </summary>
    public unsafe virtual void UpdateCanDriveBackwards()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCanDriveBackwards, "BmGame.RVehicleBehaviour_HeavyTankSearch.UpdateCanDriveBackwards");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoPhase;
    /// <summary>
    /// Function: GotoPhase
    /// </summary>
    public unsafe virtual void GotoPhase(BmSDK.BmGame.RVehicleBehaviour_HeavyTankSearch.ETankSearchPhase NewPhase)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoPhase, "BmGame.RVehicleBehaviour_HeavyTankSearch.GotoPhase");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPhase, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnHostVehicleDied;
    /// <summary>
    /// Function: OnHostVehicleDied
    /// </summary>
    public unsafe override void OnHostVehicleDied(BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnHostVehicleDied, "BmGame.RVehicleBehaviour_HeavyTankSearch.OnHostVehicleDied");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsActivelySearching;
    /// <summary>
    /// Function: IsActivelySearching
    /// </summary>
    public unsafe virtual bool IsActivelySearching()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsActivelySearching, "BmGame.RVehicleBehaviour_HeavyTankSearch.IsActivelySearching");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsDirectlyAttackingPlayer;
    /// <summary>
    /// Function: IsDirectlyAttackingPlayer
    /// </summary>
    public unsafe override bool IsDirectlyAttackingPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDirectlyAttackingPlayer, "BmGame.RVehicleBehaviour_HeavyTankSearch.IsDirectlyAttackingPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ExitBehaviour;
    /// <summary>
    /// Function: ExitBehaviour
    /// </summary>
    public unsafe override void ExitBehaviour(BmSDK.BmGame.RVehicleBehaviour NextBehaviour)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitBehaviour, "BmGame.RVehicleBehaviour_HeavyTankSearch.ExitBehaviour");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextBehaviour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScanLaserActive;
    /// <summary>
    /// Function: SetScanLaserActive
    /// </summary>
    public unsafe virtual void SetScanLaserActive(bool OnOrOff)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScanLaserActive, "BmGame.RVehicleBehaviour_HeavyTankSearch.SetScanLaserActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnOrOff, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterBehaviour;
    /// <summary>
    /// Function: EnterBehaviour
    /// </summary>
    public unsafe override void EnterBehaviour(BmSDK.BmGame.RVehicleBehaviour PreviousBehaviour)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterBehaviour, "BmGame.RVehicleBehaviour_HeavyTankSearch.EnterBehaviour");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousBehaviour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpecificallyLookingForPlayer;
    /// <summary>
    /// Function: SpecificallyLookingForPlayer
    /// </summary>
    public unsafe override bool SpecificallyLookingForPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecificallyLookingForPlayer, "BmGame.RVehicleBehaviour_HeavyTankSearch.SpecificallyLookingForPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AwareOfPlayer;
    /// <summary>
    /// Function: AwareOfPlayer
    /// </summary>
    public unsafe override bool AwareOfPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwareOfPlayer, "BmGame.RVehicleBehaviour_HeavyTankSearch.AwareOfPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// ByteProperty: CurrentPhase
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour_HeavyTankSearch.ETankSearchPhase CurrentPhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour_HeavyTankSearch.ETankSearchPhase>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ByteProperty: OldPhase
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour_HeavyTankSearch.ETankSearchPhase OldPhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour_HeavyTankSearch.ETankSearchPhase>(Ptr + 609); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 609); }
    }

    /// <summary>
    /// BoolProperty: SearchLastKnownPositionByKismet
    /// </summary>
    public unsafe bool SearchLastKnownPositionByKismet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// BoolProperty: b360ScansActive
    /// </summary>
    public unsafe bool b360ScansActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// BoolProperty: bConstant360Scan
    /// </summary>
    public unsafe bool bConstant360Scan
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// BoolProperty: bDrawScanLines
    /// </summary>
    public unsafe bool bDrawScanLines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// BoolProperty: InstantAttack
    /// </summary>
    public unsafe bool InstantAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// BoolProperty: StayStill
    /// </summary>
    public unsafe bool StayStill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// BoolProperty: CanSeePlayer
    /// </summary>
    public unsafe bool CanSeePlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// BoolProperty: DisableDeathBarks
    /// </summary>
    public unsafe bool DisableDeathBarks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// FloatProperty: ScanAngle
    /// </summary>
    public unsafe float ScanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// FloatProperty: ScanPeriod
    /// </summary>
    public unsafe float ScanPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// FloatProperty: CurrentScanAng
    /// </summary>
    public unsafe float CurrentScanAng
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// FloatProperty: ScanAng360
    /// </summary>
    public unsafe float ScanAng360
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: LostPlayerTime
    /// </summary>
    public unsafe float LostPlayerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: LostPlayerTimer
    /// </summary>
    public unsafe float LostPlayerTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// FloatProperty: SeenPlayerTime
    /// </summary>
    public unsafe float SeenPlayerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// FloatProperty: SeenPlayerTimeToStopMoving
    /// </summary>
    public unsafe float SeenPlayerTimeToStopMoving
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// IntProperty: ChaseEndLink
    /// </summary>
    public unsafe int ChaseEndLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// FloatProperty: ChaseRePlanDelay
    /// </summary>
    public unsafe float ChaseRePlanDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// IntProperty: StartWanderPoint
    /// </summary>
    public unsafe int StartWanderPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// IntProperty: EndWanderPoint
    /// </summary>
    public unsafe int EndWanderPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveThrottleScale
    /// </summary>
    public unsafe float SelfDriveThrottleScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// StructProperty: LastKnownPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastKnownPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 668);

    /// <summary>
    /// StructProperty: SearchDirectionToAvoid
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SearchDirectionToAvoid
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 680);

    /// <summary>
    /// StructProperty: InitialLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 InitialLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 692);

    /// <summary>
    /// FloatProperty: FullThrottleRange
    /// </summary>
    public unsafe float FullThrottleRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// FloatProperty: ChaseMinRange
    /// </summary>
    public unsafe float ChaseMinRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: MinStopAndTurnTime
    /// </summary>
    public unsafe float MinStopAndTurnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// FloatProperty: MaxStopAndTurnTime
    /// </summary>
    public unsafe float MaxStopAndTurnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// FloatProperty: StopAndScanTime
    /// </summary>
    public unsafe float StopAndScanTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// FloatProperty: ScanWarningTime
    /// </summary>
    public unsafe float ScanWarningTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// FloatProperty: ScanRoundPeriod
    /// </summary>
    public unsafe float ScanRoundPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// FloatProperty: PlayerRangeRestricition
    /// </summary>
    public unsafe float PlayerRangeRestricition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// FloatProperty: NoiseAlertRange
    /// </summary>
    public unsafe float NoiseAlertRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: DamageAlertRange
    /// </summary>
    public unsafe float DamageAlertRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// FloatProperty: Scan360Timer
    /// </summary>
    public unsafe float Scan360Timer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: AlertOtherEnemiesTime
    /// </summary>
    public unsafe float AlertOtherEnemiesTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// StructProperty: CurrentScanDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentScanDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 752);

    /// <summary>
    /// FloatProperty: TimeSinceReport
    /// </summary>
    public unsafe float TimeSinceReport
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// FloatProperty: ReportInterval
    /// </summary>
    public unsafe float ReportInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// FloatProperty: FutureLandCheckTime
    /// </summary>
    public unsafe float FutureLandCheckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// FloatProperty: MaxVelocityDiff
    /// </summary>
    public unsafe float MaxVelocityDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// FloatProperty: MaxPositionDiff
    /// </summary>
    public unsafe float MaxPositionDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// FloatProperty: PatrolSpeedScale
    /// </summary>
    public unsafe float PatrolSpeedScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ObjectProperty: CachedTargetActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor CachedTargetActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: CombatMan
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleCombatManager CombatMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleCombatManager>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: HostTank
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank HostTank
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// StructProperty: ChaseRestrictions
    /// </summary>
    public unsafe ref BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction ChaseRestrictions
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(Ptr + 812);

    /// <summary>
    /// FloatProperty: ChasePlanPeriod
    /// </summary>
    public unsafe float ChasePlanPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// StructProperty: LastSeenPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastSeenPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 984);

    /// <summary>
    /// StructProperty: LastSafePoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastSafePoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 996);

    /// <summary>
    /// Enum: ETankSearchPhase
    /// </summary>
    public enum ETankSearchPhase : byte
    {
        ETSP_RandomSearch = 0,
        ETSP_360Scan = 1,
        ETSP_SearchLastKnownPosition = 2,
        ETSP_EngagingTarget = 3,
        ETSP_NULLPhase = 4,
        ETSP_MAX = 5,
    }
}
