#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCheatManager<br/>
/// (size = 212)
/// (flags = 54)
/// </summary>
public partial class RCheatManager : BmSDK.Engine.CheatManager, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCheatManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCheatManager.
    /// </summary>
    public static RCheatManager DefaultObject => (RCheatManager)StaticClass().DefaultObject;

    internal RCheatManager() { }

    /// <summary>
    /// Constructs a new RCheatManager
    /// </summary>
    public RCheatManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCheatManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCheatManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCheatManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCheatManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCheatManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCheatManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCheatManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCheatManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCheatManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCheatManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DisplayAllFades;
    /// <summary>
    /// Function: DisplayAllFades
    /// </summary>
    public unsafe virtual void DisplayAllFades()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayAllFades, "BmGame.RCheatManager.DisplayAllFades");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DMThroughWalls_Suppress;
    /// <summary>
    /// Function: DMThroughWalls_Suppress
    /// </summary>
    public unsafe virtual void DMThroughWalls_Suppress()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DMThroughWalls_Suppress, "BmGame.RCheatManager.DMThroughWalls_Suppress");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DMThroughWalls_Allow;
    /// <summary>
    /// Function: DMThroughWalls_Allow
    /// </summary>
    public unsafe virtual void DMThroughWalls_Allow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DMThroughWalls_Allow, "BmGame.RCheatManager.DMThroughWalls_Allow");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EvaluateBrains;
    /// <summary>
    /// Function: EvaluateBrains
    /// </summary>
    public unsafe virtual void EvaluateBrains()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EvaluateBrains, "BmGame.RCheatManager.EvaluateBrains");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitCheatManager;
    /// <summary>
    /// Function: InitCheatManager
    /// </summary>
    public unsafe override void InitCheatManager()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitCheatManager, "BmGame.RCheatManager.InitCheatManager");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverrideWalkCamera;
    /// <summary>
    /// Function: OverrideWalkCamera
    /// </summary>
    public unsafe virtual void OverrideWalkCamera(BmSDK.FName CameraName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideWalkCamera, "BmGame.RCheatManager.OverrideWalkCamera");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceBatmanOutOfCar;
    /// <summary>
    /// Function: ForceBatmanOutOfCar
    /// </summary>
    public unsafe virtual void ForceBatmanOutOfCar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceBatmanOutOfCar, "BmGame.RCheatManager.ForceBatmanOutOfCar");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnsuppressXPTake;
    /// <summary>
    /// Function: UnsuppressXPTake
    /// </summary>
    public unsafe virtual void UnsuppressXPTake()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnsuppressXPTake, "BmGame.RCheatManager.UnsuppressXPTake");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnsuppressXPGive;
    /// <summary>
    /// Function: UnsuppressXPGive
    /// </summary>
    public unsafe virtual void UnsuppressXPGive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnsuppressXPGive, "BmGame.RCheatManager.UnsuppressXPGive");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuppressXP;
    /// <summary>
    /// Function: SuppressXP
    /// </summary>
    public unsafe virtual void SuppressXP()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuppressXP, "BmGame.RCheatManager.SuppressXP");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueDeleter;
    /// <summary>
    /// Function: QueueDeleter
    /// </summary>
    public unsafe virtual void QueueDeleter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueDeleter, "BmGame.RCheatManager.QueueDeleter");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueLoader;
    /// <summary>
    /// Function: QueueLoader
    /// </summary>
    public unsafe virtual void QueueLoader()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueLoader, "BmGame.RCheatManager.QueueLoader");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueSaver;
    /// <summary>
    /// Function: QueueSaver
    /// </summary>
    public unsafe virtual void QueueSaver()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueSaver, "BmGame.RCheatManager.QueueSaver");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CacheFolderScanner;
    /// <summary>
    /// Function: CacheFolderScanner
    /// </summary>
    public unsafe virtual void CacheFolderScanner()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CacheFolderScanner, "BmGame.RCheatManager.CacheFolderScanner");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CacheFileScanner;
    /// <summary>
    /// Function: CacheFileScanner
    /// </summary>
    public unsafe virtual void CacheFileScanner()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CacheFileScanner, "BmGame.RCheatManager.CacheFileScanner");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CacheDeleter;
    /// <summary>
    /// Function: CacheDeleter
    /// </summary>
    public unsafe virtual void CacheDeleter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CacheDeleter, "BmGame.RCheatManager.CacheDeleter");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCacheLoadComplete;
    /// <summary>
    /// Function: OnCacheLoadComplete
    /// </summary>
    public unsafe virtual void OnCacheLoadComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesTransferred, float timeTaken)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCacheLoadComplete, "BmGame.RCheatManager.OnCacheLoadComplete");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesTransferred, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeTaken, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CacheLoader;
    /// <summary>
    /// Function: CacheLoader
    /// </summary>
    public unsafe virtual void CacheLoader()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CacheLoader, "BmGame.RCheatManager.CacheLoader");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCacheSaveComplete;
    /// <summary>
    /// Function: OnCacheSaveComplete
    /// </summary>
    public unsafe virtual void OnCacheSaveComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesTransferred, float timeTaken)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCacheSaveComplete, "BmGame.RCheatManager.OnCacheSaveComplete");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesTransferred, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeTaken, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CacheSaver;
    /// <summary>
    /// Function: CacheSaver
    /// </summary>
    public unsafe virtual void CacheSaver()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CacheSaver, "BmGame.RCheatManager.CacheSaver");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearCombatTutorials;
    /// <summary>
    /// Function: ClearCombatTutorials
    /// </summary>
    public unsafe virtual void ClearCombatTutorials()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCombatTutorials, "BmGame.RCheatManager.ClearCombatTutorials");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Playtester;
    /// <summary>
    /// Function: Playtester
    /// </summary>
    public unsafe virtual void Playtester(BmSDK.FString PlaytesterName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Playtester, "BmGame.RCheatManager.Playtester");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlaytesterName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCustomContentAccessModeOverride;
    /// <summary>
    /// Function: SetCustomContentAccessModeOverride
    /// </summary>
    public unsafe virtual void SetCustomContentAccessModeOverride(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCustomContentAccessModeOverride, "BmGame.RCheatManager.SetCustomContentAccessModeOverride");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmobileSetTireLatStiffYMod;
    /// <summary>
    /// Function: BatmobileSetTireLatStiffYMod
    /// </summary>
    public unsafe virtual void BatmobileSetTireLatStiffYMod(float NewLatSlipMod)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmobileSetTireLatStiffYMod, "BmGame.RCheatManager.BatmobileSetTireLatStiffYMod");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLatSlipMod, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmobileSetTireFrictionMod;
    /// <summary>
    /// Function: BatmobileSetTireFrictionMod
    /// </summary>
    public unsafe virtual void BatmobileSetTireFrictionMod(float NewFrictionMod)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmobileSetTireFrictionMod, "BmGame.RCheatManager.BatmobileSetTireFrictionMod");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFrictionMod, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmobileInfinitePower;
    /// <summary>
    /// Function: BatmobileInfinitePower
    /// </summary>
    public unsafe virtual void BatmobileInfinitePower()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmobileInfinitePower, "BmGame.RCheatManager.BatmobileInfinitePower");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCommanderTankBossStage;
    /// <summary>
    /// Function: SetCommanderTankBossStage
    /// </summary>
    public unsafe virtual void SetCommanderTankBossStage(int Stage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCommanderTankBossStage, "BmGame.RCheatManager.SetCommanderTankBossStage");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPawnImmuneToDebugKIll;
    /// <summary>
    /// Function: IsPawnImmuneToDebugKIll
    /// </summary>
    public unsafe virtual bool IsPawnImmuneToDebugKIll(BmSDK.BmGame.RPawn TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPawnImmuneToDebugKIll, "BmGame.RCheatManager.IsPawnImmuneToDebugKIll");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_MatineeDebugOverlay;
    /// <summary>
    /// Function: MatineeDebugOverlay
    /// </summary>
    public unsafe virtual void MatineeDebugOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatineeDebugOverlay, "BmGame.RCheatManager.MatineeDebugOverlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleGrapplePointDebug;
    /// <summary>
    /// Function: ToggleGrapplePointDebug
    /// </summary>
    public unsafe virtual void ToggleGrapplePointDebug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleGrapplePointDebug, "BmGame.RCheatManager.ToggleGrapplePointDebug");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmobileCockpitClose;
    /// <summary>
    /// Function: BatmobileCockpitClose
    /// </summary>
    public unsafe virtual void BatmobileCockpitClose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmobileCockpitClose, "BmGame.RCheatManager.BatmobileCockpitClose");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmobileCockpitOpen;
    /// <summary>
    /// Function: BatmobileCockpitOpen
    /// </summary>
    public unsafe virtual void BatmobileCockpitOpen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmobileCockpitOpen, "BmGame.RCheatManager.BatmobileCockpitOpen");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerPhysImpact;
    /// <summary>
    /// Function: TriggerPhysImpact
    /// </summary>
    public unsafe virtual void TriggerPhysImpact()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPhysImpact, "BmGame.RCheatManager.TriggerPhysImpact");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TogglePhysImpact;
    /// <summary>
    /// Function: TogglePhysImpact
    /// </summary>
    public unsafe virtual void TogglePhysImpact()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TogglePhysImpact, "BmGame.RCheatManager.TogglePhysImpact");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatGhost;
    /// <summary>
    /// Function: CombatGhost
    /// </summary>
    public unsafe virtual void CombatGhost()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatGhost, "BmGame.RCheatManager.CombatGhost");
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NavMeshObstaclesOff;
    /// <summary>
    /// Function: NavMeshObstaclesOff
    /// </summary>
    public unsafe virtual void NavMeshObstaclesOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavMeshObstaclesOff, "BmGame.RCheatManager.NavMeshObstaclesOff");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NavMeshObstaclesOn;
    /// <summary>
    /// Function: NavMeshObstaclesOn
    /// </summary>
    public unsafe virtual void NavMeshObstaclesOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavMeshObstaclesOn, "BmGame.RCheatManager.NavMeshObstaclesOn");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnDebugRunAwayThug;
    /// <summary>
    /// Function: SpawnDebugRunAwayThug
    /// </summary>
    public unsafe virtual void SpawnDebugRunAwayThug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDebugRunAwayThug, "BmGame.RCheatManager.SpawnDebugRunAwayThug");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleStreamingMiniMap;
    /// <summary>
    /// Function: ToggleStreamingMiniMap
    /// </summary>
    public unsafe virtual void ToggleStreamingMiniMap()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleStreamingMiniMap, "BmGame.RCheatManager.ToggleStreamingMiniMap");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleFramerateCheat;
    /// <summary>
    /// Function: ToggleFramerateCheat
    /// </summary>
    public unsafe virtual void ToggleFramerateCheat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleFramerateCheat, "BmGame.RCheatManager.ToggleFramerateCheat");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableAlternativeWalk;
    /// <summary>
    /// Function: DisableAlternativeWalk
    /// </summary>
    public unsafe virtual void DisableAlternativeWalk()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableAlternativeWalk, "BmGame.RCheatManager.DisableAlternativeWalk");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableAlternativeWalk;
    /// <summary>
    /// Function: EnableAlternativeWalk
    /// </summary>
    public unsafe virtual void EnableAlternativeWalk(bool AllowCameraTurn = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableAlternativeWalk, "BmGame.RCheatManager.EnableAlternativeWalk");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowCameraTurn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawRedHoodSniperDebug;
    /// <summary>
    /// Function: DrawRedHoodSniperDebug
    /// </summary>
    public unsafe virtual void DrawRedHoodSniperDebug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawRedHoodSniperDebug, "BmGame.RCheatManager.DrawRedHoodSniperDebug");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveSkillPoints;
    /// <summary>
    /// Function: GiveSkillPoints
    /// </summary>
    public unsafe virtual void GiveSkillPoints(int Points)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveSkillPoints, "BmGame.RCheatManager.GiveSkillPoints");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Points, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoubleGhostToggleB;
    /// <summary>
    /// Function: DoubleGhostToggleB
    /// </summary>
    public unsafe virtual void DoubleGhostToggleB()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoubleGhostToggleB, "BmGame.RCheatManager.DoubleGhostToggleB");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoubleGhostToggleA;
    /// <summary>
    /// Function: DoubleGhostToggleA
    /// </summary>
    public unsafe virtual void DoubleGhostToggleA()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoubleGhostToggleA, "BmGame.RCheatManager.DoubleGhostToggleA");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StickToggleGhost;
    /// <summary>
    /// Function: StickToggleGhost
    /// </summary>
    public unsafe virtual void StickToggleGhost()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StickToggleGhost, "BmGame.RCheatManager.StickToggleGhost");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RealWorldBatman;
    /// <summary>
    /// Function: RealWorldBatman
    /// </summary>
    public unsafe virtual void RealWorldBatman()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RealWorldBatman, "BmGame.RCheatManager.RealWorldBatman");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SentryGunSpawnAll;
    /// <summary>
    /// Function: SentryGunSpawnAll
    /// </summary>
    public unsafe virtual void SentryGunSpawnAll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SentryGunSpawnAll, "BmGame.RCheatManager.SentryGunSpawnAll");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SentryGunTriggerPlacement;
    /// <summary>
    /// Function: SentryGunTriggerPlacement
    /// </summary>
    public unsafe virtual void SentryGunTriggerPlacement()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SentryGunTriggerPlacement, "BmGame.RCheatManager.SentryGunTriggerPlacement");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExplodeCar;
    /// <summary>
    /// Function: ExplodeCar
    /// </summary>
    public unsafe virtual void ExplodeCar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExplodeCar, "BmGame.RCheatManager.ExplodeCar");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawRoadLink;
    /// <summary>
    /// Function: DrawRoadLink
    /// </summary>
    public unsafe virtual void DrawRoadLink(int LinkIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawRoadLink, "BmGame.RCheatManager.DrawRoadLink");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowSatNav;
    /// <summary>
    /// Function: ShowSatNav
    /// </summary>
    public unsafe virtual void ShowSatNav()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowSatNav, "BmGame.RCheatManager.ShowSatNav");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TankFormationReverse;
    /// <summary>
    /// Function: TankFormationReverse
    /// </summary>
    public unsafe virtual void TankFormationReverse()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TankFormationReverse, "BmGame.RCheatManager.TankFormationReverse");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillVehicles;
    /// <summary>
    /// Function: KillVehicles
    /// </summary>
    public unsafe virtual void KillVehicles()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillVehicles, "BmGame.RCheatManager.KillVehicles");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VehicleRunAway;
    /// <summary>
    /// Function: VehicleRunAway
    /// </summary>
    public unsafe virtual void VehicleRunAway()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VehicleRunAway, "BmGame.RCheatManager.VehicleRunAway");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitPassengersCalm;
    /// <summary>
    /// Function: ExitPassengersCalm
    /// </summary>
    public unsafe virtual void ExitPassengersCalm()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitPassengersCalm, "BmGame.RCheatManager.ExitPassengersCalm");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitPassengers;
    /// <summary>
    /// Function: ExitPassengers
    /// </summary>
    public unsafe virtual void ExitPassengers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitPassengers, "BmGame.RCheatManager.ExitPassengers");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnPassengers;
    /// <summary>
    /// Function: SpawnPassengers
    /// </summary>
    public unsafe virtual void SpawnPassengers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnPassengers, "BmGame.RCheatManager.SpawnPassengers");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnVehicleScenario;
    /// <summary>
    /// Function: SpawnVehicleScenario
    /// </summary>
    public unsafe virtual void SpawnVehicleScenario()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnVehicleScenario, "BmGame.RCheatManager.SpawnVehicleScenario");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnChaseCar;
    /// <summary>
    /// Function: SpawnChaseCar
    /// </summary>
    public unsafe virtual void SpawnChaseCar(BmSDK.GameObject Archetype = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnChaseCar, "BmGame.RCheatManager.SpawnChaseCar");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Archetype, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmobileAway;
    /// <summary>
    /// Function: BatmobileAway
    /// </summary>
    public unsafe virtual void BatmobileAway()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmobileAway, "BmGame.RCheatManager.BatmobileAway");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindBatmobile;
    /// <summary>
    /// Function: FindBatmobile
    /// </summary>
    public unsafe virtual void FindBatmobile()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindBatmobile, "BmGame.RCheatManager.FindBatmobile");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayTestDroneBark;
    /// <summary>
    /// Function: PlayTestDroneBark
    /// </summary>
    public unsafe virtual void PlayTestDroneBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayTestDroneBark, "BmGame.RCheatManager.PlayTestDroneBark");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SlamBatmobile;
    /// <summary>
    /// Function: SlamBatmobile
    /// </summary>
    public unsafe virtual void SlamBatmobile()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SlamBatmobile, "BmGame.RCheatManager.SlamBatmobile");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlipBatmobile;
    /// <summary>
    /// Function: FlipBatmobile
    /// </summary>
    public unsafe virtual void FlipBatmobile()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlipBatmobile, "BmGame.RCheatManager.FlipBatmobile");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlipCommanderTank;
    /// <summary>
    /// Function: FlipCommanderTank
    /// </summary>
    public unsafe virtual void FlipCommanderTank()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlipCommanderTank, "BmGame.RCheatManager.FlipCommanderTank");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlipGordon;
    /// <summary>
    /// Function: FlipGordon
    /// </summary>
    public unsafe virtual void FlipGordon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlipGordon, "BmGame.RCheatManager.FlipGordon");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlipThugCars;
    /// <summary>
    /// Function: FlipThugCars
    /// </summary>
    public unsafe virtual void FlipThugCars()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlipThugCars, "BmGame.RCheatManager.FlipThugCars");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillHeavyTanks;
    /// <summary>
    /// Function: KillHeavyTanks
    /// </summary>
    public unsafe virtual void KillHeavyTanks()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillHeavyTanks, "BmGame.RCheatManager.KillHeavyTanks");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillHeavyTank;
    /// <summary>
    /// Function: KillHeavyTank
    /// </summary>
    public unsafe virtual void KillHeavyTank()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillHeavyTank, "BmGame.RCheatManager.KillHeavyTank");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillAPC;
    /// <summary>
    /// Function: KillAPC
    /// </summary>
    public unsafe virtual void KillAPC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillAPC, "BmGame.RCheatManager.KillAPC");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RescueBatmobile;
    /// <summary>
    /// Function: RescueBatmobile
    /// </summary>
    public unsafe virtual void RescueBatmobile()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RescueBatmobile, "BmGame.RCheatManager.RescueBatmobile");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnPlayerCar;
    /// <summary>
    /// Function: SpawnPlayerCar
    /// </summary>
    public unsafe virtual void SpawnPlayerCar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnPlayerCar, "BmGame.RCheatManager.SpawnPlayerCar");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestBlockBankDoors;
    /// <summary>
    /// Function: TestBlockBankDoors
    /// </summary>
    public unsafe virtual void TestBlockBankDoors()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestBlockBankDoors, "BmGame.RCheatManager.TestBlockBankDoors");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPredWallTakedownDone;
    /// <summary>
    /// Function: SetPredWallTakedownDone
    /// </summary>
    public unsafe virtual void SetPredWallTakedownDone(bool bNewVal = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPredWallTakedownDone, "BmGame.RCheatManager.SetPredWallTakedownDone");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewVal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPredLedgeTakedownDone;
    /// <summary>
    /// Function: SetPredLedgeTakedownDone
    /// </summary>
    public unsafe virtual void SetPredLedgeTakedownDone(bool bNewVal = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPredLedgeTakedownDone, "BmGame.RCheatManager.SetPredLedgeTakedownDone");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewVal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPredSilentTakedownDone;
    /// <summary>
    /// Function: SetPredSilentTakedownDone
    /// </summary>
    public unsafe virtual void SetPredSilentTakedownDone(bool bNewVal = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPredSilentTakedownDone, "BmGame.RCheatManager.SetPredSilentTakedownDone");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewVal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPredGrateTakedownDone;
    /// <summary>
    /// Function: SetPredGrateTakedownDone
    /// </summary>
    public unsafe virtual void SetPredGrateTakedownDone(bool bNewVal = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPredGrateTakedownDone, "BmGame.RCheatManager.SetPredGrateTakedownDone");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewVal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestMap3DDebug;
    /// <summary>
    /// Function: TestMap3DDebug
    /// </summary>
    public unsafe virtual void TestMap3DDebug(bool bShowDebug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestMap3DDebug, "BmGame.RCheatManager.TestMap3DDebug");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowDebug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestMap3D;
    /// <summary>
    /// Function: TestMap3D
    /// </summary>
    public unsafe virtual void TestMap3D(bool bShowDebug = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestMap3D, "BmGame.RCheatManager.TestMap3D");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowDebug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestStatsStory;
    /// <summary>
    /// Function: TestStatsStory
    /// </summary>
    public unsafe virtual void TestStatsStory(int Percentage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestStatsStory, "BmGame.RCheatManager.TestStatsStory");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Percentage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GFxSafeFrame;
    /// <summary>
    /// Function: GFxSafeFrame
    /// </summary>
    public unsafe virtual void GFxSafeFrame(bool bShow)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GFxSafeFrame, "BmGame.RCheatManager.GFxSafeFrame");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpamBatarangs;
    /// <summary>
    /// Function: SpamBatarangs
    /// </summary>
    public unsafe virtual void SpamBatarangs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpamBatarangs, "BmGame.RCheatManager.SpamBatarangs");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MassJam;
    /// <summary>
    /// Function: MassJam
    /// </summary>
    public unsafe virtual void MassJam()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MassJam, "BmGame.RCheatManager.MassJam");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestBatmanInc;
    /// <summary>
    /// Function: TestBatmanInc
    /// </summary>
    public unsafe virtual void TestBatmanInc()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestBatmanInc, "BmGame.RCheatManager.TestBatmanInc");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RiddlerPickupDebug;
    /// <summary>
    /// Function: RiddlerPickupDebug
    /// </summary>
    public unsafe virtual void RiddlerPickupDebug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RiddlerPickupDebug, "BmGame.RCheatManager.RiddlerPickupDebug");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpStorySynopsis;
    /// <summary>
    /// Function: DumpStorySynopsis
    /// </summary>
    public unsafe virtual void DumpStorySynopsis()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpStorySynopsis, "BmGame.RCheatManager.DumpStorySynopsis");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpObjectives;
    /// <summary>
    /// Function: DumpObjectives
    /// </summary>
    public unsafe virtual void DumpObjectives()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpObjectives, "BmGame.RCheatManager.DumpObjectives");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpPDat;
    /// <summary>
    /// Function: DumpPDat
    /// </summary>
    public unsafe virtual void DumpPDat(BmSDK.FString Mode = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpPDat, "BmGame.RCheatManager.DumpPDat");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 0);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_PoolAllPawns;
    /// <summary>
    /// Function: PoolAllPawns
    /// </summary>
    public unsafe virtual void PoolAllPawns()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PoolAllPawns, "BmGame.RCheatManager.PoolAllPawns");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RiddlerRevealItemsOnlyValid;
    /// <summary>
    /// Function: RiddlerRevealItemsOnlyValid
    /// </summary>
    public unsafe virtual void RiddlerRevealItemsOnlyValid()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RiddlerRevealItemsOnlyValid, "BmGame.RCheatManager.RiddlerRevealItemsOnlyValid");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RiddlerRevealItems;
    /// <summary>
    /// Function: RiddlerRevealItems
    /// </summary>
    public unsafe virtual void RiddlerRevealItems(BmSDK.FString MapName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RiddlerRevealItems, "BmGame.RCheatManager.RiddlerRevealItems");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_TriggerHeatConcealEffect;
    /// <summary>
    /// Function: TriggerHeatConcealEffect
    /// </summary>
    public unsafe virtual void TriggerHeatConcealEffect()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerHeatConcealEffect, "BmGame.RCheatManager.TriggerHeatConcealEffect");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddScreenShake;
    /// <summary>
    /// Function: AddScreenShake
    /// </summary>
    public unsafe virtual void AddScreenShake(float Strength = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddScreenShake, "BmGame.RCheatManager.AddScreenShake");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BmRagDoll;
    /// <summary>
    /// Function: BmRagDoll
    /// </summary>
    public unsafe virtual void BmRagDoll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BmRagDoll, "BmGame.RCheatManager.BmRagDoll");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetControlType;
    /// <summary>
    /// Function: SetControlType
    /// </summary>
    public unsafe virtual void SetControlType(int Type)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetControlType, "BmGame.RCheatManager.SetControlType");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugLoadGame;
    /// <summary>
    /// Function: DebugLoadGame
    /// </summary>
    public unsafe virtual void DebugLoadGame()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugLoadGame, "BmGame.RCheatManager.DebugLoadGame");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CycleAIPhysWalking;
    /// <summary>
    /// Function: CycleAIPhysWalking
    /// </summary>
    public unsafe virtual void CycleAIPhysWalking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CycleAIPhysWalking, "BmGame.RCheatManager.CycleAIPhysWalking");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpPawns;
    /// <summary>
    /// Function: DumpPawns
    /// </summary>
    public unsafe virtual void DumpPawns()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpPawns, "BmGame.RCheatManager.DumpPawns");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowVPointAttackCache;
    /// <summary>
    /// Function: ShowVPointAttackCache
    /// </summary>
    public unsafe virtual void ShowVPointAttackCache()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowVPointAttackCache, "BmGame.RCheatManager.ShowVPointAttackCache");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowProgress;
    /// <summary>
    /// Function: ShowProgress
    /// </summary>
    public unsafe virtual void ShowProgress()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowProgress, "BmGame.RCheatManager.ShowProgress");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SplitScreenMovieCapture;
    /// <summary>
    /// Function: SplitScreenMovieCapture
    /// </summary>
    public unsafe virtual void SplitScreenMovieCapture()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SplitScreenMovieCapture, "BmGame.RCheatManager.SplitScreenMovieCapture");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCamera2Pad;
    /// <summary>
    /// Function: DebugCamera2Pad
    /// </summary>
    public unsafe virtual void DebugCamera2Pad()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCamera2Pad, "BmGame.RCheatManager.DebugCamera2Pad");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillMe;
    /// <summary>
    /// Function: KillMe
    /// </summary>
    public unsafe virtual void KillMe()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillMe, "BmGame.RCheatManager.KillMe");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestLevelHidden;
    /// <summary>
    /// Function: TestLevelHidden
    /// </summary>
    public unsafe virtual void TestLevelHidden(BmSDK.FName LevelName, bool Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestLevelHidden, "BmGame.RCheatManager.TestLevelHidden");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChallengeSetMedals;
    /// <summary>
    /// Function: ChallengeSetMedals
    /// </summary>
    public unsafe virtual void ChallengeSetMedals(int nId, int nMedals, int nCharacterId = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChallengeSetMedals, "BmGame.RCheatManager.ChallengeSetMedals");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nMedals, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nCharacterId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChallengeSetScore;
    /// <summary>
    /// Function: ChallengeSetScore
    /// </summary>
    public unsafe virtual void ChallengeSetScore(int nId, int nScore, int nCharacterId = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChallengeSetScore, "BmGame.RCheatManager.ChallengeSetScore");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nScore, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nCharacterId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChallengeAdjustTime;
    /// <summary>
    /// Function: ChallengeAdjustTime
    /// </summary>
    public unsafe virtual void ChallengeAdjustTime(float fSeconds)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChallengeAdjustTime, "BmGame.RCheatManager.ChallengeAdjustTime");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fSeconds, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChallengeAdjustScore;
    /// <summary>
    /// Function: ChallengeAdjustScore
    /// </summary>
    public unsafe virtual void ChallengeAdjustScore(int nScore)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChallengeAdjustScore, "BmGame.RCheatManager.ChallengeAdjustScore");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nScore, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EraseAllLeaderBoards;
    /// <summary>
    /// Function: EraseAllLeaderBoards
    /// </summary>
    public unsafe virtual void EraseAllLeaderBoards()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EraseAllLeaderBoards, "BmGame.RCheatManager.EraseAllLeaderBoards");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EraseLeaderBoard;
    /// <summary>
    /// Function: EraseLeaderBoard
    /// </summary>
    public unsafe virtual void EraseLeaderBoard(int BoardID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EraseLeaderBoard, "BmGame.RCheatManager.EraseLeaderBoard");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoardID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EraseMeFromLeaderBoard;
    /// <summary>
    /// Function: EraseMeFromLeaderBoard
    /// </summary>
    public unsafe virtual void EraseMeFromLeaderBoard(int BoardID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EraseMeFromLeaderBoard, "BmGame.RCheatManager.EraseMeFromLeaderBoard");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoardID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHard;
    /// <summary>
    /// Function: SetHard
    /// </summary>
    public unsafe virtual void SetHard()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHard, "BmGame.RCheatManager.SetHard");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNormal;
    /// <summary>
    /// Function: SetNormal
    /// </summary>
    public unsafe virtual void SetNormal()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNormal, "BmGame.RCheatManager.SetNormal");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEasy;
    /// <summary>
    /// Function: SetEasy
    /// </summary>
    public unsafe virtual void SetEasy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEasy, "BmGame.RCheatManager.SetEasy");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHardDifficulty;
    /// <summary>
    /// Function: SetHardDifficulty
    /// </summary>
    public unsafe virtual void SetHardDifficulty()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHardDifficulty, "BmGame.RCheatManager.SetHardDifficulty");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNormalDifficulty;
    /// <summary>
    /// Function: SetNormalDifficulty
    /// </summary>
    public unsafe virtual void SetNormalDifficulty()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNormalDifficulty, "BmGame.RCheatManager.SetNormalDifficulty");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEasyDifficulty;
    /// <summary>
    /// Function: SetEasyDifficulty
    /// </summary>
    public unsafe virtual void SetEasyDifficulty()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEasyDifficulty, "BmGame.RCheatManager.SetEasyDifficulty");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestTargetCursor;
    /// <summary>
    /// Function: TestTargetCursor
    /// </summary>
    public unsafe virtual void TestTargetCursor(BmSDK.FString cursorstr, BmSDK.FString Str)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestTargetCursor, "BmGame.RCheatManager.TestTargetCursor");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cursorstr, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Str, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestScoreSetHP;
    /// <summary>
    /// Function: TestScoreSetHP
    /// </summary>
    public unsafe virtual void TestScoreSetHP(int InCurrent, int InMaximum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestScoreSetHP, "BmGame.RCheatManager.TestScoreSetHP");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InCurrent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InMaximum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestScoreSetXP;
    /// <summary>
    /// Function: TestScoreSetXP
    /// </summary>
    public unsafe virtual void TestScoreSetXP(int InCurrent, int InMaximum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestScoreSetXP, "BmGame.RCheatManager.TestScoreSetXP");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InCurrent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InMaximum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestScoreSetPoints;
    /// <summary>
    /// Function: TestScoreSetPoints
    /// </summary>
    public unsafe virtual void TestScoreSetPoints(int InCurrent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestScoreSetPoints, "BmGame.RCheatManager.TestScoreSetPoints");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InCurrent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestScoreShow;
    /// <summary>
    /// Function: TestScoreShow
    /// </summary>
    public unsafe virtual void TestScoreShow(BmSDK.FString show)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestScoreShow, "BmGame.RCheatManager.TestScoreShow");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestCombo;
    /// <summary>
    /// Function: TestCombo
    /// </summary>
    public unsafe virtual void TestCombo(int InValue, int PowerUpValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestCombo, "BmGame.RCheatManager.TestCombo");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PowerUpValue, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestTakedown;
    /// <summary>
    /// Function: TestTakedown
    /// </summary>
    public unsafe virtual void TestTakedown(int InValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestTakedown, "BmGame.RCheatManager.TestTakedown");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestZoomMode;
    /// <summary>
    /// Function: TestZoomMode
    /// </summary>
    public unsafe virtual void TestZoomMode(BmSDK.FString InString)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestZoomMode, "BmGame.RCheatManager.TestZoomMode");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveRiddlerMap;
    /// <summary>
    /// Function: GiveRiddlerMap
    /// </summary>
    public unsafe virtual void GiveRiddlerMap()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveRiddlerMap, "BmGame.RCheatManager.GiveRiddlerMap");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockCatwomanEpisodes;
    /// <summary>
    /// Function: UnlockCatwomanEpisodes
    /// </summary>
    public unsafe virtual void UnlockCatwomanEpisodes(bool bJustCharacter = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockCatwomanEpisodes, "BmGame.RCheatManager.UnlockCatwomanEpisodes");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bJustCharacter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockTape;
    /// <summary>
    /// Function: UnlockTape
    /// </summary>
    public unsafe virtual void UnlockTape(BmSDK.BmGame.RGameInfo.ETapeCharacter Id, bool bSilent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockTape, "BmGame.RCheatManager.UnlockTape");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSilent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockTapes;
    /// <summary>
    /// Function: UnlockTapes
    /// </summary>
    public unsafe virtual void UnlockTapes(bool bSilent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockTapes, "BmGame.RCheatManager.UnlockTapes");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSilent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockBio;
    /// <summary>
    /// Function: UnlockBio
    /// </summary>
    public unsafe virtual void UnlockBio(BmSDK.BmGame.RGameInfo.EBioCharacter Id, bool bSilent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockBio, "BmGame.RCheatManager.UnlockBio");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSilent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockBios;
    /// <summary>
    /// Function: UnlockBios
    /// </summary>
    public unsafe virtual void UnlockBios(bool bSilent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockBios, "BmGame.RCheatManager.UnlockBios");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSilent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AwardDebugIntel;
    /// <summary>
    /// Function: AwardDebugIntel
    /// </summary>
    public unsafe virtual void AwardDebugIntel(int intel_enum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardDebugIntel, "BmGame.RCheatManager.AwardDebugIntel");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(intel_enum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AwardIntelPoint;
    /// <summary>
    /// Function: AwardIntelPoint
    /// </summary>
    public unsafe virtual void AwardIntelPoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardIntelPoint, "BmGame.RCheatManager.AwardIntelPoint");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DiscoverAllCurrentSideStories;
    /// <summary>
    /// Function: DiscoverAllCurrentSideStories
    /// </summary>
    public unsafe virtual void DiscoverAllCurrentSideStories()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DiscoverAllCurrentSideStories, "BmGame.RCheatManager.DiscoverAllCurrentSideStories");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockConceptGallery;
    /// <summary>
    /// Function: UnlockConceptGallery
    /// </summary>
    public unsafe virtual void UnlockConceptGallery(BmSDK.BmGame.RPersistentData.EConceptArt Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockConceptGallery, "BmGame.RCheatManager.UnlockConceptGallery");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockConceptGalleries;
    /// <summary>
    /// Function: UnlockConceptGalleries
    /// </summary>
    public unsafe virtual void UnlockConceptGalleries()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockConceptGalleries, "BmGame.RCheatManager.UnlockConceptGalleries");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockShowcaseVehicle;
    /// <summary>
    /// Function: UnlockShowcaseVehicle
    /// </summary>
    public unsafe virtual void UnlockShowcaseVehicle(BmSDK.BmGame.RPersistentData.EShowcaseVehicle Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockShowcaseVehicle, "BmGame.RCheatManager.UnlockShowcaseVehicle");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockShowcaseCharacter;
    /// <summary>
    /// Function: UnlockShowcaseCharacter
    /// </summary>
    public unsafe virtual void UnlockShowcaseCharacter(BmSDK.BmGame.RPersistentData.EShowcaseCharacter Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockShowcaseCharacter, "BmGame.RCheatManager.UnlockShowcaseCharacter");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockShowcaseItems;
    /// <summary>
    /// Function: UnlockShowcaseItems
    /// </summary>
    public unsafe virtual void UnlockShowcaseItems()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockShowcaseItems, "BmGame.RCheatManager.UnlockShowcaseItems");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockCityStory;
    /// <summary>
    /// Function: UnlockCityStory
    /// </summary>
    public unsafe virtual void UnlockCityStory(int StoryId = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockCityStory, "BmGame.RCheatManager.UnlockCityStory");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StoryId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableChallengeTimer;
    /// <summary>
    /// Function: EnableChallengeTimer
    /// </summary>
    public unsafe virtual void EnableChallengeTimer(bool bEnabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableChallengeTimer, "BmGame.RCheatManager.EnableChallengeTimer");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockChallengeMode;
    /// <summary>
    /// Function: UnlockChallengeMode
    /// </summary>
    public unsafe virtual void UnlockChallengeMode(bool bIgnorePrerequisites = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockChallengeMode, "BmGame.RCheatManager.UnlockChallengeMode");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnorePrerequisites, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RevealAndUnlockChallengeID;
    /// <summary>
    /// Function: RevealAndUnlockChallengeID
    /// </summary>
    public unsafe virtual void RevealAndUnlockChallengeID(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RevealAndUnlockChallengeID, "BmGame.RCheatManager.RevealAndUnlockChallengeID");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockChallengeID;
    /// <summary>
    /// Function: UnlockChallengeID
    /// </summary>
    public unsafe virtual void UnlockChallengeID(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockChallengeID, "BmGame.RCheatManager.UnlockChallengeID");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RevealChallengeID;
    /// <summary>
    /// Function: RevealChallengeID
    /// </summary>
    public unsafe virtual void RevealChallengeID(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RevealChallengeID, "BmGame.RCheatManager.RevealChallengeID");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UCM;
    /// <summary>
    /// Function: UCM
    /// </summary>
    public unsafe virtual void UCM()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UCM, "BmGame.RCheatManager.UCM");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestAchievement;
    /// <summary>
    /// Function: TestAchievement
    /// </summary>
    public unsafe virtual void TestAchievement(int IDNumber)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestAchievement, "BmGame.RCheatManager.TestAchievement");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IDNumber, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockAllAchievements;
    /// <summary>
    /// Function: UnlockAllAchievements
    /// </summary>
    public unsafe virtual void UnlockAllAchievements()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockAllAchievements, "BmGame.RCheatManager.UnlockAllAchievements");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockRiddlerPuzzles;
    /// <summary>
    /// Function: UnlockRiddlerPuzzles
    /// </summary>
    public unsafe virtual void UnlockRiddlerPuzzles(int eState = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockRiddlerPuzzles, "BmGame.RCheatManager.UnlockRiddlerPuzzles");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockRiddlerScreen;
    /// <summary>
    /// Function: UnlockRiddlerScreen
    /// </summary>
    public unsafe virtual void UnlockRiddlerScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockRiddlerScreen, "BmGame.RCheatManager.UnlockRiddlerScreen");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockWayneTech;
    /// <summary>
    /// Function: UnlockWayneTech
    /// </summary>
    public unsafe virtual void UnlockWayneTech()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockWayneTech, "BmGame.RCheatManager.UnlockWayneTech");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockAll;
    /// <summary>
    /// Function: UnlockAll
    /// </summary>
    public unsafe virtual void UnlockAll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockAll, "BmGame.RCheatManager.UnlockAll");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UA;
    /// <summary>
    /// Function: UA
    /// </summary>
    public unsafe virtual void UA()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UA, "BmGame.RCheatManager.UA");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockNewGamePlus;
    /// <summary>
    /// Function: UnlockNewGamePlus
    /// </summary>
    public unsafe virtual void UnlockNewGamePlus()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockNewGamePlus, "BmGame.RCheatManager.UnlockNewGamePlus");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestSetGlobalFlag;
    /// <summary>
    /// Function: TestSetGlobalFlag
    /// </summary>
    public unsafe virtual void TestSetGlobalFlag(BmSDK.FString FlagName, bool bSet = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestSetGlobalFlag, "BmGame.RCheatManager.TestSetGlobalFlag");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSet, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestNoSaving;
    /// <summary>
    /// Function: TestNoSaving
    /// </summary>
    public unsafe virtual void TestNoSaving()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestNoSaving, "BmGame.RCheatManager.TestNoSaving");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetRoom;
    /// <summary>
    /// Function: ResetRoom
    /// </summary>
    public unsafe virtual void ResetRoom()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetRoom, "BmGame.RCheatManager.ResetRoom");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpPawnLevelVol;
    /// <summary>
    /// Function: DumpPawnLevelVol
    /// </summary>
    public unsafe virtual void DumpPawnLevelVol()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpPawnLevelVol, "BmGame.RCheatManager.DumpPawnLevelVol");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpRoomState;
    /// <summary>
    /// Function: DumpRoomState
    /// </summary>
    public unsafe virtual void DumpRoomState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpRoomState, "BmGame.RCheatManager.DumpRoomState");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpBarkCoord;
    /// <summary>
    /// Function: DumpBarkCoord
    /// </summary>
    public unsafe virtual void DumpBarkCoord()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpBarkCoord, "BmGame.RCheatManager.DumpBarkCoord");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpAllNav;
    /// <summary>
    /// Function: DumpAllNav
    /// </summary>
    public unsafe virtual void DumpAllNav()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpAllNav, "BmGame.RCheatManager.DumpAllNav");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MakeNervous;
    /// <summary>
    /// Function: MakeNervous
    /// </summary>
    public unsafe virtual void MakeNervous()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeNervous, "BmGame.RCheatManager.MakeNervous");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MakeTerrified;
    /// <summary>
    /// Function: MakeTerrified
    /// </summary>
    public unsafe virtual void MakeTerrified()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeTerrified, "BmGame.RCheatManager.MakeTerrified");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarkDewedge;
    /// <summary>
    /// Function: BarkDewedge
    /// </summary>
    public unsafe virtual void BarkDewedge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarkDewedge, "BmGame.RCheatManager.BarkDewedge");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarkWTF;
    /// <summary>
    /// Function: BarkWTF
    /// </summary>
    public unsafe virtual void BarkWTF()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarkWTF, "BmGame.RCheatManager.BarkWTF");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableBattleModeToggleOption;
    /// <summary>
    /// Function: EnableBattleModeToggleOption
    /// </summary>
    public unsafe virtual void EnableBattleModeToggleOption()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableBattleModeToggleOption, "BmGame.RCheatManager.EnableBattleModeToggleOption");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugInteractableItems;
    /// <summary>
    /// Function: DebugInteractableItems
    /// </summary>
    public unsafe virtual void DebugInteractableItems()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugInteractableItems, "BmGame.RCheatManager.DebugInteractableItems");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugPlayerObstructions;
    /// <summary>
    /// Function: DebugPlayerObstructions
    /// </summary>
    public unsafe virtual void DebugPlayerObstructions()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugPlayerObstructions, "BmGame.RCheatManager.DebugPlayerObstructions");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LockGlideButton;
    /// <summary>
    /// Function: LockGlideButton
    /// </summary>
    public unsafe virtual void LockGlideButton()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LockGlideButton, "BmGame.RCheatManager.LockGlideButton");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InstantCasualty;
    /// <summary>
    /// Function: InstantCasualty
    /// </summary>
    public unsafe virtual void InstantCasualty()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstantCasualty, "BmGame.RCheatManager.InstantCasualty");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugUpgradeEquipment;
    /// <summary>
    /// Function: DebugUpgradeEquipment
    /// </summary>
    public unsafe virtual void DebugUpgradeEquipment()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugUpgradeEquipment, "BmGame.RCheatManager.DebugUpgradeEquipment");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InfiniteGadgets;
    /// <summary>
    /// Function: InfiniteGadgets
    /// </summary>
    public unsafe virtual void InfiniteGadgets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InfiniteGadgets, "BmGame.RCheatManager.InfiniteGadgets");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugRemoveArmour;
    /// <summary>
    /// Function: DebugRemoveArmour
    /// </summary>
    public unsafe virtual void DebugRemoveArmour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugRemoveArmour, "BmGame.RCheatManager.DebugRemoveArmour");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveArmour;
    /// <summary>
    /// Function: DebugGiveArmour
    /// </summary>
    public unsafe virtual void DebugGiveArmour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveArmour, "BmGame.RCheatManager.DebugGiveArmour");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGlobalFlagGet;
    /// <summary>
    /// Function: DebugGlobalFlagGet
    /// </summary>
    public unsafe virtual void DebugGlobalFlagGet(BmSDK.FString sFlag)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGlobalFlagGet, "BmGame.RCheatManager.DebugGlobalFlagGet");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sFlag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGlobalFlagSet;
    /// <summary>
    /// Function: DebugGlobalFlagSet
    /// </summary>
    public unsafe virtual void DebugGlobalFlagSet(BmSDK.FString sFlag, bool bFlag)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGlobalFlagSet, "BmGame.RCheatManager.DebugGlobalFlagSet");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sFlag, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFlag, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugSharedFlagGet;
    /// <summary>
    /// Function: DebugSharedFlagGet
    /// </summary>
    public unsafe virtual void DebugSharedFlagGet(BmSDK.FString sFlag)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugSharedFlagGet, "BmGame.RCheatManager.DebugSharedFlagGet");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sFlag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugSharedFlagSet;
    /// <summary>
    /// Function: DebugSharedFlagSet
    /// </summary>
    public unsafe virtual void DebugSharedFlagSet(BmSDK.FString sFlag, bool bFlag)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugSharedFlagSet, "BmGame.RCheatManager.DebugSharedFlagSet");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sFlag, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFlag, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugRemoteEvent;
    /// <summary>
    /// Function: DebugRemoteEvent
    /// </summary>
    public unsafe virtual void DebugRemoteEvent(BmSDK.FString sEvent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugRemoteEvent, "BmGame.RCheatManager.DebugRemoteEvent");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sEvent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpgradeEquipmentMenu;
    /// <summary>
    /// Function: UpgradeEquipmentMenu
    /// </summary>
    public unsafe virtual void UpgradeEquipmentMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpgradeEquipmentMenu, "BmGame.RCheatManager.UpgradeEquipmentMenu");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveFreezeBlast;
    /// <summary>
    /// Function: DebugGiveFreezeBlast
    /// </summary>
    public unsafe virtual void DebugGiveFreezeBlast()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveFreezeBlast, "BmGame.RCheatManager.DebugGiveFreezeBlast");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockAllUpgrades;
    /// <summary>
    /// Function: UnlockAllUpgrades
    /// </summary>
    public unsafe virtual void UnlockAllUpgrades(bool UnLock = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockAllUpgrades, "BmGame.RCheatManager.UnlockAllUpgrades");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnLock, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveAllGadgets;
    /// <summary>
    /// Function: DebugGiveAllGadgets
    /// </summary>
    public unsafe virtual void DebugGiveAllGadgets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveAllGadgets, "BmGame.RCheatManager.DebugGiveAllGadgets");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponConfigWTF;
    /// <summary>
    /// Function: WeaponConfigWTF
    /// </summary>
    public unsafe virtual void WeaponConfigWTF()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponConfigWTF, "BmGame.RCheatManager.WeaponConfigWTF");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PPWTF;
    /// <summary>
    /// Function: PPWTF
    /// </summary>
    public unsafe virtual void PPWTF()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PPWTF, "BmGame.RCheatManager.PPWTF");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlinkWBID;
    /// <summary>
    /// Function: UnlinkWBID
    /// </summary>
    public unsafe virtual void UnlinkWBID()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlinkWBID, "BmGame.RCheatManager.UnlinkWBID");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerWTF;
    /// <summary>
    /// Function: PlayerWTF
    /// </summary>
    public unsafe virtual void PlayerWTF()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerWTF, "BmGame.RCheatManager.PlayerWTF");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpecialActionXP;
    /// <summary>
    /// Function: SpecialActionXP
    /// </summary>
    public unsafe virtual void SpecialActionXP()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialActionXP, "BmGame.RCheatManager.SpecialActionXP");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddXP;
    /// <summary>
    /// Function: AddXP
    /// </summary>
    public unsafe virtual void AddXP(int Xp = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddXP, "BmGame.RCheatManager.AddXP");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Xp, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugForce3rdPersonCamera;
    /// <summary>
    /// Function: DebugForce3rdPersonCamera
    /// </summary>
    public unsafe virtual void DebugForce3rdPersonCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugForce3rdPersonCamera, "BmGame.RCheatManager.DebugForce3rdPersonCamera");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCamera;
    /// <summary>
    /// Function: DebugCamera
    /// </summary>
    public unsafe virtual void DebugCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCamera, "BmGame.RCheatManager.DebugCamera");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleMagicGunStartle;
    /// <summary>
    /// Function: ToggleMagicGunStartle
    /// </summary>
    public unsafe virtual void ToggleMagicGunStartle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleMagicGunStartle, "BmGame.RCheatManager.ToggleMagicGunStartle");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleMagicSmasher;
    /// <summary>
    /// Function: ToggleMagicSmasher
    /// </summary>
    public unsafe virtual void ToggleMagicSmasher()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleMagicSmasher, "BmGame.RCheatManager.ToggleMagicSmasher");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleNavMeshInspector;
    /// <summary>
    /// Function: ToggleNavMeshInspector
    /// </summary>
    public unsafe virtual void ToggleNavMeshInspector()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleNavMeshInspector, "BmGame.RCheatManager.ToggleNavMeshInspector");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleAIPaths;
    /// <summary>
    /// Function: ToggleAIPaths
    /// </summary>
    public unsafe virtual void ToggleAIPaths()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleAIPaths, "BmGame.RCheatManager.ToggleAIPaths");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TogglePaths;
    /// <summary>
    /// Function: TogglePaths
    /// </summary>
    public unsafe virtual void TogglePaths()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TogglePaths, "BmGame.RCheatManager.TogglePaths");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DPropShape;
    /// <summary>
    /// Function: DPropShape
    /// </summary>
    public unsafe virtual void DPropShape()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DPropShape, "BmGame.RCheatManager.DPropShape");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TogglePhysicsGrabber;
    /// <summary>
    /// Function: TogglePhysicsGrabber
    /// </summary>
    public unsafe virtual void TogglePhysicsGrabber()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TogglePhysicsGrabber, "BmGame.RCheatManager.TogglePhysicsGrabber");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleBot;
    /// <summary>
    /// Function: ToggleBot
    /// </summary>
    public unsafe virtual void ToggleBot()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleBot, "BmGame.RCheatManager.ToggleBot");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffEnemiesCanAttack;
    /// <summary>
    /// Function: TurnOffEnemiesCanAttack
    /// </summary>
    public unsafe virtual void TurnOffEnemiesCanAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffEnemiesCanAttack, "BmGame.RCheatManager.TurnOffEnemiesCanAttack");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleEnemiesCanAttack;
    /// <summary>
    /// Function: ToggleEnemiesCanAttack
    /// </summary>
    public unsafe virtual void ToggleEnemiesCanAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleEnemiesCanAttack, "BmGame.RCheatManager.ToggleEnemiesCanAttack");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AdvanceCurrentThoughtHistoryItem;
    /// <summary>
    /// Function: AdvanceCurrentThoughtHistoryItem
    /// </summary>
    public unsafe virtual void AdvanceCurrentThoughtHistoryItem()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdvanceCurrentThoughtHistoryItem, "BmGame.RCheatManager.AdvanceCurrentThoughtHistoryItem");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayThoughtsOnAll;
    /// <summary>
    /// Function: DisplayThoughtsOnAll
    /// </summary>
    public unsafe virtual void DisplayThoughtsOnAll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayThoughtsOnAll, "BmGame.RCheatManager.DisplayThoughtsOnAll");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StepPawnDisplayingThoughts;
    /// <summary>
    /// Function: StepPawnDisplayingThoughts
    /// </summary>
    public unsafe virtual void StepPawnDisplayingThoughts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StepPawnDisplayingThoughts, "BmGame.RCheatManager.StepPawnDisplayingThoughts");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayLookAtPawnThoughts;
    /// <summary>
    /// Function: DisplayLookAtPawnThoughts
    /// </summary>
    public unsafe virtual void DisplayLookAtPawnThoughts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayLookAtPawnThoughts, "BmGame.RCheatManager.DisplayLookAtPawnThoughts");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleErrorThoughts;
    /// <summary>
    /// Function: ToggleErrorThoughts
    /// </summary>
    public unsafe virtual void ToggleErrorThoughts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleErrorThoughts, "BmGame.RCheatManager.ToggleErrorThoughts");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpCurrentPawnThoughtsToLog;
    /// <summary>
    /// Function: DumpCurrentPawnThoughtsToLog
    /// </summary>
    public unsafe virtual void DumpCurrentPawnThoughtsToLog()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpCurrentPawnThoughtsToLog, "BmGame.RCheatManager.DumpCurrentPawnThoughtsToLog");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleThoughts;
    /// <summary>
    /// Function: ToggleThoughts
    /// </summary>
    public unsafe virtual void ToggleThoughts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleThoughts, "BmGame.RCheatManager.ToggleThoughts");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleOnScreenKismetAndWarnings;
    /// <summary>
    /// Function: ToggleOnScreenKismetAndWarnings
    /// </summary>
    public unsafe virtual void ToggleOnScreenKismetAndWarnings()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleOnScreenKismetAndWarnings, "BmGame.RCheatManager.ToggleOnScreenKismetAndWarnings");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugViewDist;
    /// <summary>
    /// Function: DebugViewDist
    /// </summary>
    public unsafe virtual void DebugViewDist(float newdist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugViewDist, "BmGame.RCheatManager.DebugViewDist");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newdist, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugFocusViewDist;
    /// <summary>
    /// Function: DebugFocusViewDist
    /// </summary>
    public unsafe virtual void DebugFocusViewDist(float newdist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugFocusViewDist, "BmGame.RCheatManager.DebugFocusViewDist");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newdist, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugExtendedViewDist;
    /// <summary>
    /// Function: DebugExtendedViewDist
    /// </summary>
    public unsafe virtual void DebugExtendedViewDist(float newdist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugExtendedViewDist, "BmGame.RCheatManager.DebugExtendedViewDist");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newdist, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugVertFov;
    /// <summary>
    /// Function: DebugVertFov
    /// </summary>
    public unsafe virtual void DebugVertFov(int NewFOV)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugVertFov, "BmGame.RCheatManager.DebugVertFov");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugFov;
    /// <summary>
    /// Function: DebugFov
    /// </summary>
    public unsafe virtual void DebugFov(int NewFOV)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugFov, "BmGame.RCheatManager.DebugFov");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopDebugCameraMovement;
    /// <summary>
    /// Function: StopDebugCameraMovement
    /// </summary>
    public unsafe virtual void StopDebugCameraMovement()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopDebugCameraMovement, "BmGame.RCheatManager.StopDebugCameraMovement");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCameraZoomOut;
    /// <summary>
    /// Function: DebugCameraZoomOut
    /// </summary>
    public unsafe virtual void DebugCameraZoomOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCameraZoomOut, "BmGame.RCheatManager.DebugCameraZoomOut");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCameraZoomIn;
    /// <summary>
    /// Function: DebugCameraZoomIn
    /// </summary>
    public unsafe virtual void DebugCameraZoomIn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCameraZoomIn, "BmGame.RCheatManager.DebugCameraZoomIn");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCameraBack;
    /// <summary>
    /// Function: DebugCameraBack
    /// </summary>
    public unsafe virtual void DebugCameraBack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCameraBack, "BmGame.RCheatManager.DebugCameraBack");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCameraForward;
    /// <summary>
    /// Function: DebugCameraForward
    /// </summary>
    public unsafe virtual void DebugCameraForward()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCameraForward, "BmGame.RCheatManager.DebugCameraForward");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCameraRight;
    /// <summary>
    /// Function: DebugCameraRight
    /// </summary>
    public unsafe virtual void DebugCameraRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCameraRight, "BmGame.RCheatManager.DebugCameraRight");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCameraLeft;
    /// <summary>
    /// Function: DebugCameraLeft
    /// </summary>
    public unsafe virtual void DebugCameraLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCameraLeft, "BmGame.RCheatManager.DebugCameraLeft");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCameraUp;
    /// <summary>
    /// Function: DebugCameraUp
    /// </summary>
    public unsafe virtual void DebugCameraUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCameraUp, "BmGame.RCheatManager.DebugCameraUp");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCameraDown;
    /// <summary>
    /// Function: DebugCameraDown
    /// </summary>
    public unsafe virtual void DebugCameraDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCameraDown, "BmGame.RCheatManager.DebugCameraDown");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_APC;
    /// <summary>
    /// Function: APC
    /// </summary>
    public unsafe virtual void APC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_APC, "BmGame.RCheatManager.APC");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceSpawnAPC;
    /// <summary>
    /// Function: ForceSpawnAPC
    /// </summary>
    public unsafe virtual void ForceSpawnAPC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceSpawnAPC, "BmGame.RCheatManager.ForceSpawnAPC");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnBatmobileMob;
    /// <summary>
    /// Function: SpawnBatmobileMob
    /// </summary>
    public unsafe virtual void SpawnBatmobileMob()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnBatmobileMob, "BmGame.RCheatManager.SpawnBatmobileMob");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugRespawnAllThrowable;
    /// <summary>
    /// Function: DebugRespawnAllThrowable
    /// </summary>
    public unsafe virtual void DebugRespawnAllThrowable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugRespawnAllThrowable, "BmGame.RCheatManager.DebugRespawnAllThrowable");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugDestroyAllWeapons;
    /// <summary>
    /// Function: DebugDestroyAllWeapons
    /// </summary>
    public unsafe virtual void DebugDestroyAllWeapons()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugDestroyAllWeapons, "BmGame.RCheatManager.DebugDestroyAllWeapons");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugKillAllButOneEnemyInRoom;
    /// <summary>
    /// Function: DebugKillAllButOneEnemyInRoom
    /// </summary>
    public unsafe virtual void DebugKillAllButOneEnemyInRoom()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugKillAllButOneEnemyInRoom, "BmGame.RCheatManager.DebugKillAllButOneEnemyInRoom");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugKillAllEnemies;
    /// <summary>
    /// Function: DebugKillAllEnemies
    /// </summary>
    public unsafe virtual void DebugKillAllEnemies()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugKillAllEnemies, "BmGame.RCheatManager.DebugKillAllEnemies");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetSpotted;
    /// <summary>
    /// Function: ResetSpotted
    /// </summary>
    public unsafe virtual void ResetSpotted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetSpotted, "BmGame.RCheatManager.ResetSpotted");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpecialMoveCheat;
    /// <summary>
    /// Function: SpecialMoveCheat
    /// </summary>
    public unsafe virtual void SpecialMoveCheat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialMoveCheat, "BmGame.RCheatManager.SpecialMoveCheat");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RestoreHealth;
    /// <summary>
    /// Function: RestoreHealth
    /// </summary>
    public unsafe virtual void RestoreHealth()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreHealth, "BmGame.RCheatManager.RestoreHealth");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NearDeath;
    /// <summary>
    /// Function: NearDeath
    /// </summary>
    public unsafe virtual void NearDeath()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NearDeath, "BmGame.RCheatManager.NearDeath");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Invisible;
    /// <summary>
    /// Function: Invisible
    /// </summary>
    public unsafe virtual void Invisible()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Invisible, "BmGame.RCheatManager.Invisible");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpgradeMag;
    /// <summary>
    /// Function: UpgradeMag
    /// </summary>
    public unsafe virtual void UpgradeMag()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpgradeMag, "BmGame.RCheatManager.UpgradeMag");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PauseAndPan;
    /// <summary>
    /// Function: PauseAndPan
    /// </summary>
    public unsafe virtual void PauseAndPan()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PauseAndPan, "BmGame.RCheatManager.PauseAndPan");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWaypoint;
    /// <summary>
    /// Function: SetWaypoint
    /// </summary>
    public unsafe virtual void SetWaypoint(float atX, float atY, float atZ)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWaypoint, "BmGame.RCheatManager.SetWaypoint");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZ, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CopyWaypoint;
    /// <summary>
    /// Function: CopyWaypoint
    /// </summary>
    public unsafe virtual void CopyWaypoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CopyWaypoint, "BmGame.RCheatManager.CopyWaypoint");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReportBug;
    /// <summary>
    /// Function: ReportBug
    /// </summary>
    public unsafe virtual void ReportBug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReportBug, "BmGame.RCheatManager.ReportBug");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetReproSteps;
    /// <summary>
    /// Function: GetReproSteps
    /// </summary>
    public unsafe virtual BmSDK.FString GetReproSteps()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetReproSteps, "BmGame.RCheatManager.GetReproSteps");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetVersionStr;
    /// <summary>
    /// Function: GetVersionStr
    /// </summary>
    public unsafe virtual BmSDK.FString GetVersionStr()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVersionStr, "BmGame.RCheatManager.GetVersionStr");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPlatformStr;
    /// <summary>
    /// Function: GetPlatformStr
    /// </summary>
    public unsafe virtual BmSDK.FString GetPlatformStr()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlatformStr, "BmGame.RCheatManager.GetPlatformStr");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLastSaveGameName;
    /// <summary>
    /// Function: GetLastSaveGameName
    /// </summary>
    public unsafe virtual BmSDK.FString GetLastSaveGameName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLastSaveGameName, "BmGame.RCheatManager.GetLastSaveGameName");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AutoSaveGame;
    /// <summary>
    /// Function: AutoSaveGame
    /// </summary>
    public unsafe virtual void AutoSaveGame()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutoSaveGame, "BmGame.RCheatManager.AutoSaveGame");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyDebugSetLevel;
    /// <summary>
    /// Function: ApplyDebugSetLevel
    /// </summary>
    public unsafe virtual bool ApplyDebugSetLevel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyDebugSetLevel, "BmGame.RCheatManager.ApplyDebugSetLevel");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TeleportTo;
    /// <summary>
    /// Function: TeleportTo
    /// </summary>
    public unsafe virtual void TeleportTo(float X, float Y, float Z, int Yaw, BmSDK.FString LevelName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TeleportTo, "BmGame.RCheatManager.TeleportTo");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Yaw, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelName, paramsPtr + 16);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_Teleport;
    /// <summary>
    /// Function: Teleport
    /// </summary>
    public unsafe override void Teleport()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Teleport, "BmGame.RCheatManager.Teleport");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPlayerLocation;
    /// <summary>
    /// Function: SetPlayerLocation
    /// </summary>
    public unsafe virtual void SetPlayerLocation(BmSDK.Engine.Pawn P, System.Numerics.Vector3 pos, int Yaw)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerLocation, "BmGame.RCheatManager.SetPlayerLocation");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Yaw, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CycleAnimNames;
    /// <summary>
    /// Function: CycleAnimNames
    /// </summary>
    public unsafe virtual void CycleAnimNames()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CycleAnimNames, "BmGame.RCheatManager.CycleAnimNames");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefreshPaths;
    /// <summary>
    /// Function: RefreshPaths
    /// </summary>
    public unsafe virtual void RefreshPaths()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshPaths, "BmGame.RCheatManager.RefreshPaths");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsDefaultCharacterSkinTest;
    /// <summary>
    /// Function: IsDefaultCharacterSkinTest
    /// </summary>
    public unsafe virtual void IsDefaultCharacterSkinTest(BmSDK.FString sCharacter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDefaultCharacterSkinTest, "BmGame.RCheatManager.IsDefaultCharacterSkinTest");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCharacter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WarningMessageTest;
    /// <summary>
    /// Function: WarningMessageTest
    /// </summary>
    public unsafe virtual void WarningMessageTest(BmSDK.FString sText = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WarningMessageTest, "BmGame.RCheatManager.WarningMessageTest");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sText, paramsPtr + 0);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_EnableDebugCamera;
    /// <summary>
    /// Function: EnableDebugCamera
    /// </summary>
    public unsafe override void EnableDebugCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableDebugCamera, "BmGame.RCheatManager.EnableDebugCamera");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleLowSpeed;
    /// <summary>
    /// Function: ToggleLowSpeed
    /// </summary>
    public unsafe virtual void ToggleLowSpeed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleLowSpeed, "BmGame.RCheatManager.ToggleLowSpeed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleSuperHighSpeed;
    /// <summary>
    /// Function: ToggleSuperHighSpeed
    /// </summary>
    public unsafe virtual void ToggleSuperHighSpeed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleSuperHighSpeed, "BmGame.RCheatManager.ToggleSuperHighSpeed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleHighSpeed;
    /// <summary>
    /// Function: ToggleHighSpeed
    /// </summary>
    public unsafe virtual void ToggleHighSpeed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleHighSpeed, "BmGame.RCheatManager.ToggleHighSpeed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Slomo;
    /// <summary>
    /// Function: Slomo
    /// </summary>
    public unsafe override void Slomo(float T)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Slomo, "BmGame.RCheatManager.Slomo");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleGhost;
    /// <summary>
    /// Function: ToggleGhost
    /// </summary>
    public unsafe virtual void ToggleGhost()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleGhost, "BmGame.RCheatManager.ToggleGhost");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReloadLevel;
    /// <summary>
    /// Function: ReloadLevel
    /// </summary>
    public unsafe virtual void ReloadLevel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReloadLevel, "BmGame.RCheatManager.ReloadLevel");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleScreenshotCamera;
    /// <summary>
    /// Function: ToggleScreenshotCamera
    /// </summary>
    public unsafe virtual void ToggleScreenshotCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleScreenshotCamera, "BmGame.RCheatManager.ToggleScreenshotCamera");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleLookInvert;
    /// <summary>
    /// Function: ToggleLookInvert
    /// </summary>
    public unsafe virtual void ToggleLookInvert()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleLookInvert, "BmGame.RCheatManager.ToggleLookInvert");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoName;
    /// <summary>
    /// Function: GotoName
    /// </summary>
    public unsafe virtual void GotoName(BmSDK.FString InName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoName, "BmGame.RCheatManager.GotoName");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ListNames;
    /// <summary>
    /// Function: ListNames
    /// </summary>
    public unsafe virtual void ListNames(BmSDK.FString InName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListNames, "BmGame.RCheatManager.ListNames");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ListDynamicActors;
    /// <summary>
    /// Function: ListDynamicActors
    /// </summary>
    public unsafe override void ListDynamicActors()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListDynamicActors, "BmGame.RCheatManager.ListDynamicActors");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FBatmobileHandlingTweak
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FBatmobileHandlingTweak
    {
        /// <summary>
        /// FloatProperty: TireFrictionMod
        /// </summary>
        public unsafe float TireFrictionMod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: LatStiffYMod
        /// </summary>
        public unsafe float LatStiffYMod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: StandardSteeringSpeedCurve
        /// </summary>
        public unsafe BmSDK.GameObject.FInterpCurveFloat StandardSteeringSpeedCurve
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// BoolProperty: bIgnoreDamage
    /// </summary>
    public unsafe bool bIgnoreDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: bCapeForwards
    /// </summary>
    public unsafe bool bCapeForwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: bCapeGliding
    /// </summary>
    public unsafe bool bCapeGliding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: bUnlockedAllUpgrades
    /// </summary>
    public unsafe bool bUnlockedAllUpgrades
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// ArrayProperty: SpawnedPassengers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Pawn> SpawnedPassengers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Pawn>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: ImmuneToDebugKill
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Pawn> ImmuneToDebugKill
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Pawn>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// NameProperty: DebugSetLevel
    /// </summary>
    public unsafe BmSDK.FName DebugSetLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: DebugSetPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DebugSetPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 180);

    /// <summary>
    /// IntProperty: DebugSetYaw
    /// </summary>
    public unsafe int DebugSetYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// ArrayProperty: BatmobileSettings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCheatManager.FBatmobileHandlingTweak> BatmobileSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCheatManager.FBatmobileHandlingTweak>>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }
}
