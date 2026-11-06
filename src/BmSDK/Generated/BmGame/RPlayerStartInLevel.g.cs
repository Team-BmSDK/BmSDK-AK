#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPlayerStartInLevel<br/>
/// (size = 1092)
/// (flags = 144704146)
/// </summary>
public partial class RPlayerStartInLevel : BmSDK.Engine.PlayerStart, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPlayerStartInLevel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPlayerStartInLevel.
    /// </summary>
    public static RPlayerStartInLevel DefaultObject => (RPlayerStartInLevel)StaticClass().DefaultObject;

    internal RPlayerStartInLevel() { }

    /// <summary>
    /// Constructs a new RPlayerStartInLevel
    /// </summary>
    public RPlayerStartInLevel(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPlayerStartInLevel(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerStartInLevel>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerStartInLevel>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerStartInLevel>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerStartInLevel>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerStartInLevel>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerStartInLevel>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerStartInLevel>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerStartInLevel>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RPlayerStartInLevel.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableCheckpoints;
    /// <summary>
    /// Function: EnableCheckpoints
    /// </summary>
    public unsafe virtual void EnableCheckpoints()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableCheckpoints, "BmGame.RPlayerStartInLevel.EnableCheckpoints");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateCheckpoint;
    /// <summary>
    /// Function: ActivateCheckpoint
    /// </summary>
    public unsafe virtual void ActivateCheckpoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateCheckpoint, "BmGame.RPlayerStartInLevel.ActivateCheckpoint");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnModifyDoor;
    /// <summary>
    /// Function: OnModifyDoor
    /// </summary>
    public unsafe virtual void OnModifyDoor(BmSDK.BmGame.RSeqAct_ModifyDoor Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnModifyDoor, "BmGame.RPlayerStartInLevel.OnModifyDoor");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleKismetAction;
    /// <summary>
    /// Function: HandleKismetAction
    /// </summary>
    public unsafe virtual void HandleKismetAction(int Index, BmSDK.BmGame.RSeqAct_ModifyDoor Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleKismetAction, "BmGame.RPlayerStartInLevel.HandleKismetAction");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartLevelFromHere;
    /// <summary>
    /// Function: StartLevelFromHere
    /// </summary>
    public unsafe virtual void StartLevelFromHere(bool LevelStart = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartLevelFromHere, "BmGame.RPlayerStartInLevel.StartLevelFromHere");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelStart, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SaveGameHere;
    /// <summary>
    /// Function: SaveGameHere
    /// </summary>
    public unsafe virtual void SaveGameHere(BmSDK.FString Filename = default, BmSDK.BmGame.RGameRI.FDebugSaveDescription DebugSaveGameDescription = default, bool bMemoryOnly = default, bool bAllowSaveDuringChase = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveGameHere, "BmGame.RPlayerStartInLevel.SaveGameHere");
        byte* paramsPtr = stackalloc byte[180];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DebugSaveGameDescription, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMemoryOnly, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowSaveDuringChase, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetOuterMost;
    /// <summary>
    /// Function: GetOuterMost
    /// </summary>
    public unsafe virtual BmSDK.GameObject GetOuterMost(BmSDK.GameObject A)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOuterMost, "BmGame.RPlayerStartInLevel.GetOuterMost");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ExitTransition;
    /// <summary>
    /// Function: ExitTransition
    /// </summary>
    public unsafe virtual void ExitTransition(bool LevelStart = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitTransition, "BmGame.RPlayerStartInLevel.ExitTransition");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelStart, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckPlayerStartFromHere;
    /// <summary>
    /// Function: CheckPlayerStartFromHere
    /// </summary>
    public unsafe virtual void CheckPlayerStartFromHere()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckPlayerStartFromHere, "BmGame.RPlayerStartInLevel.CheckPlayerStartFromHere");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckPlayerStart;
    /// <summary>
    /// Function: CheckPlayerStart
    /// </summary>
    public unsafe virtual void CheckPlayerStart(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckPlayerStart, "BmGame.RPlayerStartInLevel.CheckPlayerStart");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnBatmobileForThisStartPoint;
    /// <summary>
    /// Function: SpawnBatmobileForThisStartPoint
    /// </summary>
    public unsafe virtual void SpawnBatmobileForThisStartPoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnBatmobileForThisStartPoint, "BmGame.RPlayerStartInLevel.SpawnBatmobileForThisStartPoint");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MovePlayerHere;
    /// <summary>
    /// Function: MovePlayerHere
    /// </summary>
    public unsafe virtual void MovePlayerHere()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MovePlayerHere, "BmGame.RPlayerStartInLevel.MovePlayerHere");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TeleportPlayerToHere;
    /// <summary>
    /// Function: TeleportPlayerToHere
    /// </summary>
    public unsafe virtual void TeleportPlayerToHere()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TeleportPlayerToHere, "BmGame.RPlayerStartInLevel.TeleportPlayerToHere");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishPreloadingLevelsForEntering;
    /// <summary>
    /// Function: FinishPreloadingLevelsForEntering
    /// </summary>
    public unsafe virtual void FinishPreloadingLevelsForEntering()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishPreloadingLevelsForEntering, "BmGame.RPlayerStartInLevel.FinishPreloadingLevelsForEntering");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreloadLevelsForEntering;
    /// <summary>
    /// Function: PreloadLevelsForEntering
    /// </summary>
    public unsafe virtual void PreloadLevelsForEntering()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreloadLevelsForEntering, "BmGame.RPlayerStartInLevel.PreloadLevelsForEntering");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FacingSameDirection;
    /// <summary>
    /// Function: FacingSameDirection
    /// </summary>
    public unsafe virtual bool FacingSameDirection(BmSDK.Rotator PlayerRot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FacingSameDirection, "BmGame.RPlayerStartInLevel.FacingSameDirection");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerRot, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_StopLoadingSymbol;
    /// <summary>
    /// Function: StopLoadingSymbol
    /// </summary>
    public unsafe virtual void StopLoadingSymbol()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopLoadingSymbol, "BmGame.RPlayerStartInLevel.StopLoadingSymbol");
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_FlushTexturesStreaming;
    /// <summary>
    /// Function: FlushTexturesStreaming
    /// </summary>
    public unsafe virtual void FlushTexturesStreaming()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushTexturesStreaming, "BmGame.RPlayerStartInLevel.FlushTexturesStreaming");
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_GetMyLevelVolume;
    /// <summary>
    /// Function: GetMyLevelVolume
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RLevelVolume GetMyLevelVolume()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMyLevelVolume, "BmGame.RPlayerStartInLevel.GetMyLevelVolume");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RLevelVolume>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGRI;
    /// <summary>
    /// Function: GetGRI
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameRI GetGRI()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGRI, "BmGame.RPlayerStartInLevel.GetGRI");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameRI>(paramsPtr + 0);
    }

    /// <summary>
    /// NameProperty: Level
    /// </summary>
    public unsafe BmSDK.FName Level
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalStreamingLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> AdditionalStreamingLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalStreamingLODLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> AdditionalStreamingLODLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalStreamingLevelRequiredInstallChunks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EInstallChunk> AdditionalStreamingLevelRequiredInstallChunks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EInstallChunk>>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalStreamingLODLevelRequiredInstallChunks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EInstallChunk> AdditionalStreamingLODLevelRequiredInstallChunks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EInstallChunk>>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bSaveWhenTeleportedTo
    /// </summary>
    public unsafe bool bSaveWhenTeleportedTo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bOnlySaveOnce
    /// </summary>
    public unsafe bool bOnlySaveOnce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bReshowCurrentObjectiveOnLoad
    /// </summary>
    public unsafe bool bReshowCurrentObjectiveOnLoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bStartCrouched
    /// </summary>
    public unsafe bool bStartCrouched
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bUsableForAutoSaving
    /// </summary>
    public unsafe bool bUsableForAutoSaving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bFlushTextureStreaming
    /// </summary>
    public unsafe bool bFlushTextureStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bWasInsideBox
    /// </summary>
    public unsafe bool bWasInsideBox
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bStreamingInLevel
    /// </summary>
    public unsafe bool bStreamingInLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bEnableCheckpointSystem
    /// </summary>
    public unsafe bool bEnableCheckpointSystem
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bForceDisableCheckpointSystem
    /// </summary>
    public unsafe bool bForceDisableCheckpointSystem
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bAllowTickIsDisabled
    /// </summary>
    public unsafe bool bAllowTickIsDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bStartInBatmobile
    /// </summary>
    public unsafe bool bStartInBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bStartInBatmobileFakeRemoteDrive
    /// </summary>
    public unsafe bool bStartInBatmobileFakeRemoteDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bForceStartOutOfBatmobile
    /// </summary>
    public unsafe bool bForceStartOutOfBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bChallengeStartPoint
    /// </summary>
    public unsafe bool bChallengeStartPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: CheckpointWidth
    /// </summary>
    public unsafe float CheckpointWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: CheckpointLength
    /// </summary>
    public unsafe float CheckpointLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// StructProperty: CheckpointSaveGameDescription
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGameRI.FDebugSaveDescription CheckpointSaveGameDescription
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameRI.FDebugSaveDescription>(Ptr + 1044);

    /// <summary>
    /// FloatProperty: LastCheckpointTime
    /// </summary>
    public unsafe float LastCheckpointTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileStartLocation
    /// </summary>
    public unsafe BmSDK.Engine.Actor BatmobileStartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }
}
