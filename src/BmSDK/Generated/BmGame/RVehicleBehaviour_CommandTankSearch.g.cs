#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBehaviour_CommandTankSearch<br/>
/// (size = 1156)
/// (flags = 12306)
/// </summary>
public partial class RVehicleBehaviour_CommandTankSearch : BmSDK.BmGame.RVehicleBehaviour_HeavyTankSearch, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBehaviour_CommandTankSearch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RVehicleBehaviour_CommandTankSearch.
    /// </summary>
    public static RVehicleBehaviour_CommandTankSearch DefaultObject => (RVehicleBehaviour_CommandTankSearch)StaticClass().DefaultObject;

    internal RVehicleBehaviour_CommandTankSearch() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_CommandTankSearch
    /// </summary>
    public RVehicleBehaviour_CommandTankSearch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_CommandTankSearch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_CommandTankSearch(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBehaviour_CommandTankSearch>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBehaviour_CommandTankSearch>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBehaviour_CommandTankSearch>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBehaviour_CommandTankSearch>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBehaviour_CommandTankSearch>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBehaviour_CommandTankSearch>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBehaviour_CommandTankSearch>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBehaviour_CommandTankSearch>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_IsInOvercharge;
    /// <summary>
    /// Function: IsInOvercharge
    /// </summary>
    public unsafe virtual bool IsInOvercharge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInOvercharge, "BmGame.RVehicleBehaviour_CommandTankSearch.IsInOvercharge");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AmIInATunnel;
    /// <summary>
    /// Function: AmIInATunnel
    /// </summary>
    public unsafe virtual bool AmIInATunnel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AmIInATunnel, "BmGame.RVehicleBehaviour_CommandTankSearch.AmIInATunnel");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TurnOnTunnelRestrictions;
    /// <summary>
    /// Function: TurnOnTunnelRestrictions
    /// </summary>
    public unsafe virtual void TurnOnTunnelRestrictions()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnTunnelRestrictions, "BmGame.RVehicleBehaviour_CommandTankSearch.TurnOnTunnelRestrictions");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeakPointDestroyed;
    /// <summary>
    /// Function: WeakPointDestroyed
    /// </summary>
    public unsafe virtual void WeakPointDestroyed(int WP)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeakPointDestroyed, "BmGame.RVehicleBehaviour_CommandTankSearch.WeakPointDestroyed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WP, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPostEngagePhase;
    /// <summary>
    /// Function: GetPostEngagePhase
    /// </summary>
    public unsafe override BmSDK.BmGame.RVehicleBehaviour_HeavyTankSearch.ETankSearchPhase GetPostEngagePhase()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPostEngagePhase, "BmGame.RVehicleBehaviour_CommandTankSearch.GetPostEngagePhase");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RVehicleBehaviour_HeavyTankSearch.ETankSearchPhase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HeatLevelUpdated;
    /// <summary>
    /// Function: HeatLevelUpdated
    /// </summary>
    public unsafe virtual void HeatLevelUpdated(float HeatLevel)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HeatLevelUpdated, "BmGame.RVehicleBehaviour_CommandTankSearch.HeatLevelUpdated");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeatLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PoweredUp;
    /// <summary>
    /// Function: PoweredUp
    /// </summary>
    public unsafe virtual void PoweredUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PoweredUp, "BmGame.RVehicleBehaviour_CommandTankSearch.PoweredUp");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PoweredDown;
    /// <summary>
    /// Function: PoweredDown
    /// </summary>
    public unsafe virtual void PoweredDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PoweredDown, "BmGame.RVehicleBehaviour_CommandTankSearch.PoweredDown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitHealthBar;
    /// <summary>
    /// Function: InitHealthBar
    /// </summary>
    public unsafe virtual void InitHealthBar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitHealthBar, "BmGame.RVehicleBehaviour_CommandTankSearch.InitHealthBar");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Activated;
    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Activated, "BmGame.RVehicleBehaviour_CommandTankSearch.Activated");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmGame.RVehicleBehaviour_CommandTankSearch.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GotoPhase;
    /// <summary>
    /// Function: GotoPhase
    /// </summary>
    public unsafe override void GotoPhase(BmSDK.BmGame.RVehicleBehaviour_HeavyTankSearch.ETankSearchPhase NewPhase)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoPhase, "BmGame.RVehicleBehaviour_CommandTankSearch.GotoPhase");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPhase, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanLoseTargetWhenEngaging;
    /// <summary>
    /// Function: CanLoseTargetWhenEngaging
    /// </summary>
    public unsafe override bool CanLoseTargetWhenEngaging()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanLoseTargetWhenEngaging, "BmGame.RVehicleBehaviour_CommandTankSearch.CanLoseTargetWhenEngaging");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEngageTargetThrottleScale;
    /// <summary>
    /// Function: GetEngageTargetThrottleScale
    /// </summary>
    public unsafe override float GetEngageTargetThrottleScale()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEngageTargetThrottleScale, "BmGame.RVehicleBehaviour_CommandTankSearch.GetEngageTargetThrottleScale");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSearchThrottleScale;
    /// <summary>
    /// Function: GetSearchThrottleScale
    /// </summary>
    public unsafe override float GetSearchThrottleScale()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSearchThrottleScale, "BmGame.RVehicleBehaviour_CommandTankSearch.GetSearchThrottleScale");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInitialSearchLink;
    /// <summary>
    /// Function: GetInitialSearchLink
    /// </summary>
    public unsafe override int GetInitialSearchLink(BmSDK.BmGame.RRoadNetwork Roads, int StartLink, System.Numerics.Vector3 Direction, out float LinkT, out System.Numerics.Vector3 EndLoc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInitialSearchLink, "BmGame.RVehicleBehaviour_CommandTankSearch.GetInitialSearchLink");
        byte* paramsPtr = stackalloc byte[52];
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

    private static BmSDK.Function __fn_CalculateSearchTarget;
    /// <summary>
    /// Function: CalculateSearchTarget
    /// </summary>
    public unsafe virtual void CalculateSearchTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateSearchTarget, "BmGame.RVehicleBehaviour_CommandTankSearch.CalculateSearchTarget");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PickNewSearchTarget;
    /// <summary>
    /// Function: PickNewSearchTarget
    /// </summary>
    public unsafe virtual void PickNewSearchTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickNewSearchTarget, "BmGame.RVehicleBehaviour_CommandTankSearch.PickNewSearchTarget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSearchRadius;
    /// <summary>
    /// Function: GetSearchRadius
    /// </summary>
    public unsafe override float GetSearchRadius()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSearchRadius, "BmGame.RVehicleBehaviour_CommandTankSearch.GetSearchRadius");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSearchCentre;
    /// <summary>
    /// Function: GetSearchCentre
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetSearchCentre()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSearchCentre, "BmGame.RVehicleBehaviour_CommandTankSearch.GetSearchCentre");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RVehicleBehaviour_CommandTankSearch.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickEngageTarget;
    /// <summary>
    /// Function: TickEngageTarget
    /// </summary>
    public unsafe override void TickEngageTarget(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickEngageTarget, "BmGame.RVehicleBehaviour_CommandTankSearch.TickEngageTarget");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnHostVehicleDied;
    /// <summary>
    /// Function: OnHostVehicleDied
    /// </summary>
    public unsafe override void OnHostVehicleDied(BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnHostVehicleDied, "BmGame.RVehicleBehaviour_CommandTankSearch.OnHostVehicleDied");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyTakeDamage;
    /// <summary>
    /// Function: NotifyTakeDamage
    /// </summary>
    public unsafe override void NotifyTakeDamage(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyTakeDamage, "BmGame.RVehicleBehaviour_CommandTankSearch.NotifyTakeDamage");
        byte* paramsPtr = stackalloc byte[108];
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

    private static BmSDK.Function __fn_InitOneShotTimer;
    /// <summary>
    /// Function: InitOneShotTimer
    /// </summary>
    public unsafe virtual void InitOneShotTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitOneShotTimer, "BmGame.RVehicleBehaviour_CommandTankSearch.InitOneShotTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitBehaviour;
    /// <summary>
    /// Function: ExitBehaviour
    /// </summary>
    public unsafe override void ExitBehaviour(BmSDK.BmGame.RVehicleBehaviour NextBehaviour)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitBehaviour, "BmGame.RVehicleBehaviour_CommandTankSearch.ExitBehaviour");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextBehaviour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterBehaviour;
    /// <summary>
    /// Function: EnterBehaviour
    /// </summary>
    public unsafe override void EnterBehaviour(BmSDK.BmGame.RVehicleBehaviour PreviousBehaviour)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterBehaviour, "BmGame.RVehicleBehaviour_CommandTankSearch.EnterBehaviour");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousBehaviour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAttack;
    /// <summary>
    /// Function: StartAttack
    /// </summary>
    public unsafe override bool StartAttack(BmSDK.Engine.Actor Target, float WarningTime, System.Numerics.Vector3 AttackLoc = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAttack, "BmGame.RVehicleBehaviour_CommandTankSearch.StartAttack");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WarningTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackLoc, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetScanColour;
    /// <summary>
    /// Function: GetScanColour
    /// </summary>
    public unsafe override void GetScanColour(out int R, out int G, out int B)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScanColour, "BmGame.RVehicleBehaviour_CommandTankSearch.GetScanColour");
        byte* paramsPtr = stackalloc byte[12];
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

    private static BmSDK.Function __fn_SuperHighPriority;
    /// <summary>
    /// Function: SuperHighPriority
    /// </summary>
    public unsafe override bool SuperHighPriority()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuperHighPriority, "BmGame.RVehicleBehaviour_CommandTankSearch.SuperHighPriority");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// BoolProperty: bCloudburstVulnerable
    /// </summary>
    public unsafe bool bCloudburstVulnerable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bFindNewSearchTarget
    /// </summary>
    public unsafe bool bFindNewSearchTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: FinalStage
    /// </summary>
    public unsafe bool FinalStage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bStartOverchargeChase
    /// </summary>
    public unsafe bool bStartOverchargeChase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bAddedTunnelVolumesToRestrictions
    /// </summary>
    public unsafe bool bAddedTunnelVolumesToRestrictions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// ArrayProperty: SearchPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> SearchPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// StructProperty: SearchLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SearchLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1028);

    /// <summary>
    /// FloatProperty: OneShotLineDelayMin
    /// </summary>
    public unsafe float OneShotLineDelayMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: OneShotLineDelayMax
    /// </summary>
    public unsafe float OneShotLineDelayMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: OneShotTickDown
    /// </summary>
    public unsafe float OneShotTickDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// ArrayProperty: StageScan360Period
    /// </summary>
    public unsafe BmSDK.TArray<float> StageScan360Period
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ArrayProperty: ChaseTimes
    /// </summary>
    public unsafe BmSDK.TArray<float> ChaseTimes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// ArrayProperty: WeakPointOutputLinks
    /// </summary>
    public unsafe BmSDK.TArray<int> WeakPointOutputLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// StructProperty: ThrottleVsDistCurve
    /// </summary>
    public unsafe ref BmSDK.GameObject.FInterpCurveFloat ThrottleVsDistCurve
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 1100);

    /// <summary>
    /// FloatProperty: ChaseStartTime
    /// </summary>
    public unsafe float ChaseStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ObjectProperty: BossModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleBoss BossModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleBoss>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// FloatProperty: RunningAwayDuration
    /// </summary>
    public unsafe float RunningAwayDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// FloatProperty: AlertTimer
    /// </summary>
    public unsafe float AlertTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ArrayProperty: TunnelVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Volume> TunnelVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Volume>>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }
}
