#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMAIManager<br/>
/// (size = 1460)
/// (flags = 144703634)
/// </summary>
public partial class RBMAIManager : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMAIManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMAIManager.
    /// </summary>
    public static RBMAIManager DefaultObject => (RBMAIManager)StaticClass().DefaultObject;

    internal RBMAIManager() { }

    /// <summary>
    /// Constructs a new RBMAIManager
    /// </summary>
    public RBMAIManager(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMAIManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnDifficultyChanged;
    /// <summary>
    /// Function: OnDifficultyChanged
    /// </summary>
    public unsafe virtual void OnDifficultyChanged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDifficultyChanged, "BmGame.RBMAIManager.OnDifficultyChanged");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPlayerUnZoom;
    /// <summary>
    /// Function: OnPlayerUnZoom
    /// </summary>
    public unsafe virtual void OnPlayerUnZoom()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPlayerUnZoom, "BmGame.RBMAIManager.OnPlayerUnZoom");
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

    private static BmSDK.Function __fn_OnPlayerZoom;
    /// <summary>
    /// Function: OnPlayerZoom
    /// </summary>
    public unsafe virtual void OnPlayerZoom()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPlayerZoom, "BmGame.RBMAIManager.OnPlayerZoom");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldDisableDivingForPawn;
    /// <summary>
    /// Function: ShouldDisableDivingForPawn
    /// </summary>
    public unsafe virtual bool ShouldDisableDivingForPawn(BmSDK.BmGame.RBMPawnAI TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldDisableDivingForPawn, "BmGame.RBMAIManager.ShouldDisableDivingForPawn");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UpdateShouldLoadPredVolBarks_Gang;
    /// <summary>
    /// Function: UpdateShouldLoadPredVolBarks_Gang
    /// </summary>
    public unsafe virtual void UpdateShouldLoadPredVolBarks_Gang(bool bNewVal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateShouldLoadPredVolBarks_Gang, "BmGame.RBMAIManager.UpdateShouldLoadPredVolBarks_Gang");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewVal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateShouldLoadPredVolBarks_Militia;
    /// <summary>
    /// Function: UpdateShouldLoadPredVolBarks_Militia
    /// </summary>
    public unsafe virtual void UpdateShouldLoadPredVolBarks_Militia(bool bNewVal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateShouldLoadPredVolBarks_Militia, "BmGame.RBMAIManager.UpdateShouldLoadPredVolBarks_Militia");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewVal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateBarks_RemovePlayer;
    /// <summary>
    /// Function: UpdateBarks_RemovePlayer
    /// </summary>
    public unsafe virtual void UpdateBarks_RemovePlayer(BmSDK.BmGame.RPawnPlayerCombat ExPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateBarks_RemovePlayer, "BmGame.RBMAIManager.UpdateBarks_RemovePlayer");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateBarks_AddPlayer;
    /// <summary>
    /// Function: UpdateBarks_AddPlayer
    /// </summary>
    public unsafe virtual void UpdateBarks_AddPlayer(BmSDK.BmGame.RPawnPlayerCombat NewPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateBarks_AddPlayer, "BmGame.RBMAIManager.UpdateBarks_AddPlayer");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FilterValList;
    /// <summary>
    /// Function: FilterValList
    /// </summary>
    public unsafe virtual void FilterValList(BmSDK.TArray<BmSDK.BmGame.RBarkPillarLookup.FFlagValAndFileName> InList, BmSDK.BmGame.RBarkValDef.FlagTypeEnum TestType, out BmSDK.TArray<BmSDK.FString> OutList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FilterValList, "BmGame.RBMAIManager.FilterValList");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestType, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_GenerateCurrentSuffixList;
    /// <summary>
    /// Function: GenerateCurrentSuffixList
    /// </summary>
    public unsafe virtual void GenerateCurrentSuffixList(out BmSDK.TArray<BmSDK.FString> SuffixList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GenerateCurrentSuffixList, "BmGame.RBMAIManager.GenerateCurrentSuffixList");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SuffixList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_RefreshBarkData;
    /// <summary>
    /// Function: RefreshBarkData
    /// </summary>
    public unsafe virtual void RefreshBarkData()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshBarkData, "BmGame.RBMAIManager.RefreshBarkData");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnregisterBarkCharDef;
    /// <summary>
    /// Function: UnregisterBarkCharDef
    /// </summary>
    public unsafe virtual void UnregisterBarkCharDef(BmSDK.BmGame.RBarkCharacterDefInstance OldDef)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterBarkCharDef, "BmGame.RBMAIManager.UnregisterBarkCharDef");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldDef, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ValidateChaptersOnBarks;
    /// <summary>
    /// Function: ValidateChaptersOnBarks
    /// </summary>
    public unsafe virtual void ValidateChaptersOnBarks(BmSDK.BmGame.RBarkSet TestSet)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ValidateChaptersOnBarks, "BmGame.RBMAIManager.ValidateChaptersOnBarks");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestSet, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ApplyPlayerNameHackForMultiStageEnemyType;
    /// <summary>
    /// Function: ApplyPlayerNameHackForMultiStageEnemyType
    /// </summary>
    public unsafe virtual void ApplyPlayerNameHackForMultiStageEnemyType(BmSDK.BmGame.RBarkSet LoadedSetToHack)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyPlayerNameHackForMultiStageEnemyType, "BmGame.RBMAIManager.ApplyPlayerNameHackForMultiStageEnemyType");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSetToHack, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AsyncLoadDone;
    /// <summary>
    /// Function: AsyncLoadDone
    /// </summary>
    public unsafe override void AsyncLoadDone(BmSDK.FString ObjectFinished)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AsyncLoadDone, "BmGame.RBMAIManager.AsyncLoadDone");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectFinished, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartBarkLoadingRequests;
    /// <summary>
    /// Function: StartBarkLoadingRequests
    /// </summary>
    public unsafe virtual void StartBarkLoadingRequests(BmSDK.BmGame.RBarkCharacterDefInstance NewDef)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartBarkLoadingRequests, "BmGame.RBMAIManager.StartBarkLoadingRequests");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDef, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterBarkCharDef;
    /// <summary>
    /// Function: RegisterBarkCharDef
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBarkCharacterDefInstance RegisterBarkCharDef(BmSDK.BmGame.RBarkCharacterDef NewDef)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterBarkCharDef, "BmGame.RBMAIManager.RegisterBarkCharDef");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDef, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkCharacterDefInstance>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TrackPawnAIList;
    /// <summary>
    /// Function: TrackPawnAIList
    /// </summary>
    public unsafe virtual void TrackPawnAIList()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrackPawnAIList, "BmGame.RBMAIManager.TrackPawnAIList");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateRebuildSpecialEdgeActorList;
    /// <summary>
    /// Function: UpdateRebuildSpecialEdgeActorList
    /// </summary>
    public unsafe virtual void UpdateRebuildSpecialEdgeActorList()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRebuildSpecialEdgeActorList, "BmGame.RBMAIManager.UpdateRebuildSpecialEdgeActorList");
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

    private static BmSDK.Function __fn_RegisterRebuildSpecialEdgeActor;
    /// <summary>
    /// Function: RegisterRebuildSpecialEdgeActor
    /// </summary>
    public unsafe virtual void RegisterRebuildSpecialEdgeActor(BmSDK.Engine.Actor NewActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterRebuildSpecialEdgeActor, "BmGame.RBMAIManager.RegisterRebuildSpecialEdgeActor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TeleportStasisPawn;
    /// <summary>
    /// Function: TeleportStasisPawn
    /// </summary>
    public unsafe virtual void TeleportStasisPawn(BmSDK.BmGame.RBMPawnAI PawnAI)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TeleportStasisPawn, "BmGame.RBMAIManager.TeleportStasisPawn");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnAI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemovePawnToTeleportInStasis;
    /// <summary>
    /// Function: RemovePawnToTeleportInStasis
    /// </summary>
    public unsafe virtual void RemovePawnToTeleportInStasis(BmSDK.BmGame.RBMPawnAI PawnAI)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemovePawnToTeleportInStasis, "BmGame.RBMAIManager.RemovePawnToTeleportInStasis");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnAI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPawnToTeleportInStasis;
    /// <summary>
    /// Function: AddPawnToTeleportInStasis
    /// </summary>
    public unsafe virtual void AddPawnToTeleportInStasis(BmSDK.BmGame.RBMPawnAI PawnAI, float TimeUntilTeleport)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPawnToTeleportInStasis, "BmGame.RBMAIManager.AddPawnToTeleportInStasis");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnAI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeUntilTeleport, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyAllPawnsThatWouldDestroyInStasis;
    /// <summary>
    /// Function: DestroyAllPawnsThatWouldDestroyInStasis
    /// </summary>
    public unsafe virtual void DestroyAllPawnsThatWouldDestroyInStasis()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyAllPawnsThatWouldDestroyInStasis, "BmGame.RBMAIManager.DestroyAllPawnsThatWouldDestroyInStasis");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemovePawnToDestroyInStasis;
    /// <summary>
    /// Function: RemovePawnToDestroyInStasis
    /// </summary>
    public unsafe virtual void RemovePawnToDestroyInStasis(BmSDK.BmGame.RBMPawnAI PawnAI)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemovePawnToDestroyInStasis, "BmGame.RBMAIManager.RemovePawnToDestroyInStasis");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnAI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPawnToDestroyInStasis;
    /// <summary>
    /// Function: AddPawnToDestroyInStasis
    /// </summary>
    public unsafe virtual void AddPawnToDestroyInStasis(BmSDK.BmGame.RBMPawnAI PawnAI, float TimeUntilDestroy)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPawnToDestroyInStasis, "BmGame.RBMAIManager.AddPawnToDestroyInStasis");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnAI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeUntilDestroy, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateJokerInCombat;
    /// <summary>
    /// Function: UpdateJokerInCombat
    /// </summary>
    public unsafe virtual void UpdateJokerInCombat(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateJokerInCombat, "BmGame.RBMAIManager.UpdateJokerInCombat");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartleThugsAtLocation;
    /// <summary>
    /// Function: StartleThugsAtLocation
    /// </summary>
    public unsafe virtual void StartleThugsAtLocation(System.Numerics.Vector3 StartleLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartleThugsAtLocation, "BmGame.RBMAIManager.StartleThugsAtLocation");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartleLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanRocketLauncherFire;
    /// <summary>
    /// Function: CanRocketLauncherFire
    /// </summary>
    public unsafe virtual bool CanRocketLauncherFire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanRocketLauncherFire, "BmGame.RBMAIManager.CanRocketLauncherFire");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAntiDodgeFactor;
    /// <summary>
    /// Function: GetAntiDodgeFactor
    /// </summary>
    public unsafe virtual float GetAntiDodgeFactor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAntiDodgeFactor, "BmGame.RBMAIManager.GetAntiDodgeFactor");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInstantHitIfNotRunningRange;
    /// <summary>
    /// Function: GetInstantHitIfNotRunningRange
    /// </summary>
    public unsafe virtual float GetInstantHitIfNotRunningRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInstantHitIfNotRunningRange, "BmGame.RBMAIManager.GetInstantHitIfNotRunningRange");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAlwaysHitRange;
    /// <summary>
    /// Function: GetAlwaysHitRange
    /// </summary>
    public unsafe virtual float GetAlwaysHitRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAlwaysHitRange, "BmGame.RBMAIManager.GetAlwaysHitRange");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInaccuracyRange;
    /// <summary>
    /// Function: GetInaccuracyRange
    /// </summary>
    public unsafe virtual float GetInaccuracyRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInaccuracyRange, "BmGame.RBMAIManager.GetInaccuracyRange");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHitRatio;
    /// <summary>
    /// Function: GetHitRatio
    /// </summary>
    public unsafe virtual float GetHitRatio(float TestDist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitRatio, "BmGame.RBMAIManager.GetHitRatio");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestDist, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDamageMultiplier;
    /// <summary>
    /// Function: GetDamageMultiplier
    /// </summary>
    public unsafe virtual float GetDamageMultiplier()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageMultiplier, "BmGame.RBMAIManager.GetDamageMultiplier");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGrenadeDamage;
    /// <summary>
    /// Function: GetGrenadeDamage
    /// </summary>
    public unsafe virtual float GetGrenadeDamage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGrenadeDamage, "BmGame.RBMAIManager.GetGrenadeDamage");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSniperDamage;
    /// <summary>
    /// Function: GetSniperDamage
    /// </summary>
    public unsafe virtual float GetSniperDamage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSniperDamage, "BmGame.RBMAIManager.GetSniperDamage");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetShotgunDamage;
    /// <summary>
    /// Function: GetShotgunDamage
    /// </summary>
    public unsafe virtual float GetShotgunDamage(BmSDK.Engine.Actor User, BmSDK.Engine.Actor Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetShotgunDamage, "BmGame.RBMAIManager.GetShotgunDamage");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(User, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetRifleDamage;
    /// <summary>
    /// Function: GetRifleDamage
    /// </summary>
    public unsafe virtual float GetRifleDamage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRifleDamage, "BmGame.RBMAIManager.GetRifleDamage");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDDAValue;
    /// <summary>
    /// Function: GetDDAValue
    /// </summary>
    public unsafe virtual float GetDDAValue(float NormalValue, float EasyValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDDAValue, "BmGame.RBMAIManager.GetDDAValue");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NormalValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EasyValue, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DumpBehaviourHistory;
    /// <summary>
    /// Function: DumpBehaviourHistory
    /// </summary>
    public unsafe virtual void DumpBehaviourHistory()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpBehaviourHistory, "BmGame.RBMAIManager.DumpBehaviourHistory");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RespawnAllThrowable;
    /// <summary>
    /// Function: RespawnAllThrowable
    /// </summary>
    public unsafe virtual void RespawnAllThrowable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RespawnAllThrowable, "BmGame.RBMAIManager.RespawnAllThrowable");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyAllWeapons;
    /// <summary>
    /// Function: DestroyAllWeapons
    /// </summary>
    public unsafe virtual void DestroyAllWeapons()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyAllWeapons, "BmGame.RBMAIManager.DestroyAllWeapons");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillAllButOneEnemyInRoom;
    /// <summary>
    /// Function: KillAllButOneEnemyInRoom
    /// </summary>
    public unsafe virtual void KillAllButOneEnemyInRoom(BmSDK.Engine.Controller PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillAllButOneEnemyInRoom, "BmGame.RBMAIManager.KillAllButOneEnemyInRoom");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillAllEnemies;
    /// <summary>
    /// Function: KillAllEnemies
    /// </summary>
    public unsafe virtual void KillAllEnemies(BmSDK.Engine.Controller PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillAllEnemies, "BmGame.RBMAIManager.KillAllEnemies");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BroadcastBatmanSpottedToSnipers;
    /// <summary>
    /// Function: BroadcastBatmanSpottedToSnipers
    /// </summary>
    public unsafe virtual void BroadcastBatmanSpottedToSnipers(BmSDK.Engine.Actor PlayerActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BroadcastBatmanSpottedToSnipers, "BmGame.RBMAIManager.BroadcastBatmanSpottedToSnipers");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerActor, paramsPtr + 0);
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

    private static BmSDK.Function __fn_QueueBroadcastBatmanSpottedToSnipers;
    /// <summary>
    /// Function: QueueBroadcastBatmanSpottedToSnipers
    /// </summary>
    public unsafe virtual void QueueBroadcastBatmanSpottedToSnipers(BmSDK.Engine.Actor PlayerActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueBroadcastBatmanSpottedToSnipers, "BmGame.RBMAIManager.QueueBroadcastBatmanSpottedToSnipers");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerActor, paramsPtr + 0);
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

    private static BmSDK.Function __fn_TriggerSniperEvent;
    /// <summary>
    /// Function: TriggerSniperEvent
    /// </summary>
    public unsafe virtual void TriggerSniperEvent(System.Numerics.Vector3 NoiseLocation, float NoiseRadius)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSniperEvent, "BmGame.RBMAIManager.TriggerSniperEvent");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoiseLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoiseRadius, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreatePlayerNoise;
    /// <summary>
    /// Function: CreatePlayerNoise
    /// </summary>
    public unsafe virtual void CreatePlayerNoise(BmSDK.BmGame.RPawnPlayer NoiseMaker, float NoiseRadius)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreatePlayerNoise, "BmGame.RBMAIManager.CreatePlayerNoise");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoiseMaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoiseRadius, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrioritiseControllerForWorldAvoidance;
    /// <summary>
    /// Function: PrioritiseControllerForWorldAvoidance
    /// </summary>
    public unsafe virtual bool PrioritiseControllerForWorldAvoidance(BmSDK.BmGame.RBMAIController PriorityController)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrioritiseControllerForWorldAvoidance, "BmGame.RBMAIManager.PrioritiseControllerForWorldAvoidance");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PriorityController, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanDoWorldAvoidanceCheck;
    /// <summary>
    /// Function: CanDoWorldAvoidanceCheck
    /// </summary>
    public unsafe virtual bool CanDoWorldAvoidanceCheck(BmSDK.BmGame.RBMAIController TestController)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoWorldAvoidanceCheck, "BmGame.RBMAIManager.CanDoWorldAvoidanceCheck");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestController, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ScanModeDeactivated;
    /// <summary>
    /// Function: ScanModeDeactivated
    /// </summary>
    public unsafe virtual void ScanModeDeactivated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScanModeDeactivated, "BmGame.RBMAIManager.ScanModeDeactivated");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScanModeActivated;
    /// <summary>
    /// Function: ScanModeActivated
    /// </summary>
    public unsafe virtual void ScanModeActivated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScanModeActivated, "BmGame.RBMAIManager.ScanModeActivated");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceTick;
    /// <summary>
    /// Function: ForceTick
    /// </summary>
    public unsafe virtual void ForceTick(BmSDK.BmGame.RBMAIController ForceController)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceTick, "BmGame.RBMAIManager.ForceTick");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceController, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetChatterDefForGangType;
    /// <summary>
    /// Function: GetChatterDefForGangType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBarkCharacterDef GetChatterDefForGangType(BmSDK.BmGame.RCharacterDefine.GangTypeDefineEnum TestGang)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChatterDefForGangType, "BmGame.RBMAIManager.GetChatterDefForGangType");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestGang, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkCharacterDef>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PlayedBark;
    /// <summary>
    /// Function: PlayedBark
    /// </summary>
    public unsafe virtual void PlayedBark(BmSDK.BmGame.RBMAIController BarkController)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayedBark, "BmGame.RBMAIManager.PlayedBark");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkController, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlayBark;
    /// <summary>
    /// Function: CanPlayBark
    /// </summary>
    public unsafe virtual bool CanPlayBark(BmSDK.BmGame.RBMAIController BarkController)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayBark, "BmGame.RBMAIManager.CanPlayBark");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkController, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPSC;
    /// <summary>
    /// Function: GetPSC
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMPawnSpawnerController GetPSC(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPSC, "BmGame.RBMAIManager.GetPSC");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnSpawnerController>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNumPSC;
    /// <summary>
    /// Function: GetNumPSC
    /// </summary>
    public unsafe virtual int GetNumPSC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumPSC, "BmGame.RBMAIManager.GetNumPSC");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemovePSC;
    /// <summary>
    /// Function: RemovePSC
    /// </summary>
    public unsafe virtual void RemovePSC(BmSDK.BmGame.RBMPawnSpawnerController _RemovePSC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemovePSC, "BmGame.RBMAIManager.RemovePSC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RemovePSC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPSC;
    /// <summary>
    /// Function: AddPSC
    /// </summary>
    public unsafe virtual void AddPSC(BmSDK.BmGame.RBMPawnSpawnerController NewPSC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPSC, "BmGame.RBMAIManager.AddPSC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPSC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDamage;
    /// <summary>
    /// Function: AddDamage
    /// </summary>
    public unsafe virtual void AddDamage(BmSDK.BmGame.RBMAIController Attacked, float DamageCaused)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDamage, "BmGame.RBMAIManager.AddDamage");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacked, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCaused, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmanSeenEvent;
    /// <summary>
    /// Function: BatmanSeenEvent
    /// </summary>
    public unsafe virtual void BatmanSeenEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmanSeenEvent, "BmGame.RBMAIManager.BatmanSeenEvent");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmanSeenEventUpdateVal;
    /// <summary>
    /// Function: BatmanSeenEventUpdateVal
    /// </summary>
    public unsafe virtual void BatmanSeenEventUpdateVal(bool Seen)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmanSeenEventUpdateVal, "BmGame.RBMAIManager.BatmanSeenEventUpdateVal");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Seen, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetClosestPawnDist;
    /// <summary>
    /// Function: GetClosestPawnDist
    /// </summary>
    public unsafe virtual float GetClosestPawnDist(System.Numerics.Vector3 TestLoc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestPawnDist, "BmGame.RBMAIManager.GetClosestPawnDist");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PawnsCloseTogether;
    /// <summary>
    /// Function: PawnsCloseTogether
    /// </summary>
    public unsafe virtual bool PawnsCloseTogether(BmSDK.BmGame.RPawn Pawn1, BmSDK.BmGame.RPawn Pawn2)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnsCloseTogether, "BmGame.RBMAIManager.PawnsCloseTogether");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn2, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_UnregisterPredatorSpecialMovePoint;
    /// <summary>
    /// Function: UnregisterPredatorSpecialMovePoint
    /// </summary>
    public unsafe virtual void UnregisterPredatorSpecialMovePoint(BmSDK.BmGame.RPredatorSpecialMovePointBase MovePoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterPredatorSpecialMovePoint, "BmGame.RBMAIManager.UnregisterPredatorSpecialMovePoint");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovePoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterPredatorSpecialMovePoint;
    /// <summary>
    /// Function: RegisterPredatorSpecialMovePoint
    /// </summary>
    public unsafe virtual void RegisterPredatorSpecialMovePoint(BmSDK.BmGame.RPredatorSpecialMovePointBase MovePoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterPredatorSpecialMovePoint, "BmGame.RBMAIManager.RegisterPredatorSpecialMovePoint");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovePoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnregisterPredGunLocker;
    /// <summary>
    /// Function: UnregisterPredGunLocker
    /// </summary>
    public unsafe virtual void UnregisterPredGunLocker(BmSDK.BmGame.RPredatorGunLockerBase OldGunLocker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterPredGunLocker, "BmGame.RBMAIManager.UnregisterPredGunLocker");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldGunLocker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterPredGunLocker;
    /// <summary>
    /// Function: RegisterPredGunLocker
    /// </summary>
    public unsafe virtual void RegisterPredGunLocker(BmSDK.BmGame.RPredatorGunLockerBase NewGunLocker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterPredGunLocker, "BmGame.RBMAIManager.RegisterPredGunLocker");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGunLocker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetStateForNewRoom;
    /// <summary>
    /// Function: SetStateForNewRoom
    /// </summary>
    public unsafe virtual void SetStateForNewRoom(BmSDK.BmGame.RLevelVolume CurrentVol)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStateForNewRoom, "BmGame.RBMAIManager.SetStateForNewRoom");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentVol, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveController;
    /// <summary>
    /// Function: RemoveController
    /// </summary>
    public unsafe virtual void RemoveController(BmSDK.BmGame.RBMAIController ToRemove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveController, "BmGame.RBMAIManager.RemoveController");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToRemove, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ShouldForceTickForController;
    /// <summary>
    /// Function: ShouldForceTickForController
    /// </summary>
    public unsafe virtual bool ShouldForceTickForController(BmSDK.BmGame.RBMAIController C, int Idx = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceTickForController, "BmGame.RBMAIManager.ShouldForceTickForController");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Idx, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetForceTickIfCloseController;
    /// <summary>
    /// Function: SetForceTickIfCloseController
    /// </summary>
    public unsafe virtual void SetForceTickIfCloseController(BmSDK.BmGame.RBMAIController ControllerToForce, bool bNewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetForceTickIfCloseController, "BmGame.RBMAIManager.SetForceTickIfCloseController");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerToForce, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetForceTickController;
    /// <summary>
    /// Function: SetForceTickController
    /// </summary>
    public unsafe virtual void SetForceTickController(BmSDK.BmGame.RBMAIController ControllerToForce, bool bNewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetForceTickController, "BmGame.RBMAIManager.SetForceTickController");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerToForce, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterController;
    /// <summary>
    /// Function: RegisterController
    /// </summary>
    public unsafe virtual void RegisterController(BmSDK.BmGame.RBMAIController NewAIController, bool bForceTick)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterController, "BmGame.RBMAIManager.RegisterController");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAIController, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceTick, paramsPtr + 8);
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

    private static BmSDK.Function __fn_TellBehavioursOfGadgetNoise;
    /// <summary>
    /// Function: TellBehavioursOfGadgetNoise
    /// </summary>
    public unsafe virtual void TellBehavioursOfGadgetNoise(System.Numerics.Vector3 SafeNoiseLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TellBehavioursOfGadgetNoise, "BmGame.RBMAIManager.TellBehavioursOfGadgetNoise");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SafeNoiseLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearWaveRespawnTimers;
    /// <summary>
    /// Function: ClearWaveRespawnTimers
    /// </summary>
    public unsafe virtual void ClearWaveRespawnTimers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearWaveRespawnTimers, "BmGame.RBMAIManager.ClearWaveRespawnTimers");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RBMAIManager.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveObstacle;
    /// <summary>
    /// Function: RemoveObstacle
    /// </summary>
    public unsafe virtual void RemoveObstacle(BmSDK.BmGame.RNavMeshObstacle_Queue Prop)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveObstacle, "BmGame.RBMAIManager.RemoveObstacle");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prop, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddObstacle;
    /// <summary>
    /// Function: AddObstacle
    /// </summary>
    public unsafe virtual void AddObstacle(BmSDK.BmGame.RNavMeshObstacle_Queue Prop)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddObstacle, "BmGame.RBMAIManager.AddObstacle");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prop, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RemoveBlockade;
    /// <summary>
    /// Function: RemoveBlockade
    /// </summary>
    public unsafe virtual void RemoveBlockade(BmSDK.BmGame.RCheckpointBlockadeBase Prop)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveBlockade, "BmGame.RBMAIManager.RemoveBlockade");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prop, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddBlockade;
    /// <summary>
    /// Function: AddBlockade
    /// </summary>
    public unsafe virtual void AddBlockade(BmSDK.BmGame.RCheckpointBlockadeBase Prop)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddBlockade, "BmGame.RBMAIManager.AddBlockade");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prop, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RemoveDestructibleProp;
    /// <summary>
    /// Function: RemoveDestructibleProp
    /// </summary>
    public unsafe virtual void RemoveDestructibleProp(BmSDK.BmGame.RDestructibleProp Prop)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveDestructibleProp, "BmGame.RBMAIManager.RemoveDestructibleProp");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prop, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddDestructibleProp;
    /// <summary>
    /// Function: AddDestructibleProp
    /// </summary>
    public unsafe virtual void AddDestructibleProp(BmSDK.BmGame.RDestructibleProp Prop)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDestructibleProp, "BmGame.RBMAIManager.AddDestructibleProp");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prop, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PylonLoaded;
    /// <summary>
    /// Function: PylonLoaded
    /// </summary>
    public unsafe virtual void PylonLoaded(BmSDK.Engine.Pylon NewPylon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PylonLoaded, "BmGame.RBMAIManager.PylonLoaded");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPylon, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UmbraVisibilityCheck;
    /// <summary>
    /// Function: UmbraVisibilityCheck
    /// </summary>
    public unsafe virtual bool UmbraVisibilityCheck(System.Numerics.Vector3 TestLocation, float BoundsXY, float BoundsZ)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UmbraVisibilityCheck, "BmGame.RBMAIManager.UmbraVisibilityCheck");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoundsXY, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoundsZ, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_HasActiveChasePoint;
    /// <summary>
    /// Function: HasActiveChasePoint
    /// </summary>
    public unsafe virtual bool HasActiveChasePoint(BmSDK.BmGame.RChasePoint ToTest)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasActiveChasePoint, "BmGame.RBMAIManager.HasActiveChasePoint");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToTest, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RemoveActiveChasePoint;
    /// <summary>
    /// Function: RemoveActiveChasePoint
    /// </summary>
    public unsafe virtual void RemoveActiveChasePoint(BmSDK.BmGame.RChasePoint ToRemove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveActiveChasePoint, "BmGame.RBMAIManager.RemoveActiveChasePoint");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToRemove, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddActiveChasePoint;
    /// <summary>
    /// Function: AddActiveChasePoint
    /// </summary>
    public unsafe virtual void AddActiveChasePoint(BmSDK.BmGame.RChasePoint ToAdd)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddActiveChasePoint, "BmGame.RBMAIManager.AddActiveChasePoint");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToAdd, paramsPtr + 0);
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

    private static BmSDK.Function __fn_NavMeshObstacleUnregistered;
    /// <summary>
    /// Function: NavMeshObstacleUnregistered
    /// </summary>
    public unsafe virtual void NavMeshObstacleUnregistered(BmSDK.Engine.Actor A)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavMeshObstacleUnregistered, "BmGame.RBMAIManager.NavMeshObstacleUnregistered");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
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

    private static BmSDK.Function __fn_NavMeshObstacleRegistered;
    /// <summary>
    /// Function: NavMeshObstacleRegistered
    /// </summary>
    public unsafe virtual void NavMeshObstacleRegistered(BmSDK.Engine.Actor A)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavMeshObstacleRegistered, "BmGame.RBMAIManager.NavMeshObstacleRegistered");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
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

    private static BmSDK.Function __fn_CanSpawnPawnObject;
    /// <summary>
    /// Function: CanSpawnPawnObject
    /// </summary>
    public unsafe virtual bool CanSpawnPawnObject()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSpawnPawnObject, "BmGame.RBMAIManager.CanSpawnPawnObject");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PawnObjectSpawned;
    /// <summary>
    /// Function: PawnObjectSpawned
    /// </summary>
    public unsafe virtual void PawnObjectSpawned()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnObjectSpawned, "BmGame.RBMAIManager.PawnObjectSpawned");
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

    private static BmSDK.Function __fn_CanUnpoolPawn;
    /// <summary>
    /// Function: CanUnpoolPawn
    /// </summary>
    public unsafe virtual bool CanUnpoolPawn(bool bSpawningPassenger = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUnpoolPawn, "BmGame.RBMAIManager.CanUnpoolPawn");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpawningPassenger, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanSpawnPawn;
    /// <summary>
    /// Function: CanSpawnPawn
    /// </summary>
    public unsafe virtual bool CanSpawnPawn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSpawnPawn, "BmGame.RBMAIManager.CanSpawnPawn");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PawnUnpooled;
    /// <summary>
    /// Function: PawnUnpooled
    /// </summary>
    public unsafe virtual void PawnUnpooled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnUnpooled, "BmGame.RBMAIManager.PawnUnpooled");
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

    private static BmSDK.Function __fn_PawnSpawned;
    /// <summary>
    /// Function: PawnSpawned
    /// </summary>
    public unsafe virtual void PawnSpawned()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnSpawned, "BmGame.RBMAIManager.PawnSpawned");
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

    private static BmSDK.Function __fn_UpdateStasisTeleportPawns;
    /// <summary>
    /// Function: UpdateStasisTeleportPawns
    /// </summary>
    public unsafe virtual bool UpdateStasisTeleportPawns(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateStasisTeleportPawns, "BmGame.RBMAIManager.UpdateStasisTeleportPawns");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateStasisDestroyPawns;
    /// <summary>
    /// Function: UpdateStasisDestroyPawns
    /// </summary>
    public unsafe virtual bool UpdateStasisDestroyPawns(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateStasisDestroyPawns, "BmGame.RBMAIManager.UpdateStasisDestroyPawns");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdatePawnToCameraDistances;
    /// <summary>
    /// Function: UpdatePawnToCameraDistances
    /// </summary>
    public unsafe virtual void UpdatePawnToCameraDistances(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePawnToCameraDistances, "BmGame.RBMAIManager.UpdatePawnToCameraDistances");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdatePredatorGunLockers;
    /// <summary>
    /// Function: UpdatePredatorGunLockers
    /// </summary>
    public unsafe virtual void UpdatePredatorGunLockers(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePredatorGunLockers, "BmGame.RBMAIManager.UpdatePredatorGunLockers");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateNavMeshObstacleQueue;
    /// <summary>
    /// Function: UpdateNavMeshObstacleQueue
    /// </summary>
    public unsafe virtual void UpdateNavMeshObstacleQueue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateNavMeshObstacleQueue, "BmGame.RBMAIManager.UpdateNavMeshObstacleQueue");
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

    private static BmSDK.Function __fn_ObstacleIsInQueue;
    /// <summary>
    /// Function: ObstacleIsInQueue
    /// </summary>
    public unsafe virtual bool ObstacleIsInQueue(BmSDK.Engine.Interface_NavMeshPathObstacle ObstacleToRemove, out int bAddObstacle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObstacleIsInQueue, "BmGame.RBMAIManager.ObstacleIsInQueue");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObstacleToRemove, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bAddObstacle);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddObstacle, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        bAddObstacle = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_RemoveNavMeshPathObstacleFromQueue;
    /// <summary>
    /// Function: RemoveNavMeshPathObstacleFromQueue
    /// </summary>
    public unsafe virtual void RemoveNavMeshPathObstacleFromQueue(BmSDK.Engine.Interface_NavMeshPathObstacle ObstacleToRemove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveNavMeshPathObstacleFromQueue, "BmGame.RBMAIManager.RemoveNavMeshPathObstacleFromQueue");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObstacleToRemove, paramsPtr + 0);
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

    private static BmSDK.Function __fn_QueueNavMeshPathObstacleToRemove;
    /// <summary>
    /// Function: QueueNavMeshPathObstacleToRemove
    /// </summary>
    public unsafe virtual void QueueNavMeshPathObstacleToRemove(BmSDK.Engine.Interface_NavMeshPathObstacle ObstacleToQueue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueNavMeshPathObstacleToRemove, "BmGame.RBMAIManager.QueueNavMeshPathObstacleToRemove");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObstacleToQueue, paramsPtr + 0);
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

    private static BmSDK.Function __fn_QueueNavMeshPathObstacleToAdd;
    /// <summary>
    /// Function: QueueNavMeshPathObstacleToAdd
    /// </summary>
    public unsafe virtual void QueueNavMeshPathObstacleToAdd(BmSDK.Engine.Interface_NavMeshPathObstacle ObstacleToQueue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueNavMeshPathObstacleToAdd, "BmGame.RBMAIManager.QueueNavMeshPathObstacleToAdd");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObstacleToQueue, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetClosestPointOnVolume;
    /// <summary>
    /// Function: GetClosestPointOnVolume
    /// </summary>
    public unsafe virtual bool GetClosestPointOnVolume(BmSDK.Engine.Volume TestVolume, System.Numerics.Vector3 TestPoint, out System.Numerics.Vector3 out_ClosestPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestPointOnVolume, "BmGame.RBMAIManager.GetClosestPointOnVolume");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestVolume, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_ClosestPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_ClosestPoint, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_ClosestPoint = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_UnRegisterBatmanCloseCheckBehaviour;
    /// <summary>
    /// Function: UnRegisterBatmanCloseCheckBehaviour
    /// </summary>
    public unsafe virtual void UnRegisterBatmanCloseCheckBehaviour(BmSDK.BmGame.RBM2Behaviour_IdleConfig BehaviourToRemove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnRegisterBatmanCloseCheckBehaviour, "BmGame.RBMAIManager.UnRegisterBatmanCloseCheckBehaviour");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourToRemove, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RegisterBatmanCloseCheckBehaviour;
    /// <summary>
    /// Function: RegisterBatmanCloseCheckBehaviour
    /// </summary>
    public unsafe virtual void RegisterBatmanCloseCheckBehaviour(BmSDK.BmGame.RBM2Behaviour_IdleConfig BehaviourToAdd)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterBatmanCloseCheckBehaviour, "BmGame.RBMAIManager.RegisterBatmanCloseCheckBehaviour");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourToAdd, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateBatmanCloseCheckBehaviours;
    /// <summary>
    /// Function: UpdateBatmanCloseCheckBehaviours
    /// </summary>
    public unsafe virtual void UpdateBatmanCloseCheckBehaviours(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateBatmanCloseCheckBehaviours, "BmGame.RBMAIManager.UpdateBatmanCloseCheckBehaviours");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_CanDoIdleConfigLOSCheck;
    /// <summary>
    /// Function: CanDoIdleConfigLOSCheck
    /// </summary>
    public unsafe virtual bool CanDoIdleConfigLOSCheck(BmSDK.BmGame.RBMAIController TestController)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoIdleConfigLOSCheck, "BmGame.RBMAIManager.CanDoIdleConfigLOSCheck");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestController, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetFiringCount;
    /// <summary>
    /// Function: GetFiringCount
    /// </summary>
    public unsafe virtual int GetFiringCount()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFiringCount, "BmGame.RBMAIManager.GetFiringCount");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldLockDoors;
    /// <summary>
    /// Function: ShouldLockDoors
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.ECombatLockType ShouldLockDoors()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldLockDoors, "BmGame.RBMAIManager.ShouldLockDoors");
        byte* paramsPtr = stackalloc byte[1];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ECombatLockType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateTimeSlicers;
    /// <summary>
    /// Function: UpdateTimeSlicers
    /// </summary>
    public unsafe virtual void UpdateTimeSlicers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTimeSlicers, "BmGame.RBMAIManager.UpdateTimeSlicers");
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

    private static BmSDK.Function __fn_UpdateAIState;
    /// <summary>
    /// Function: UpdateAIState
    /// </summary>
    public unsafe virtual void UpdateAIState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAIState, "BmGame.RBMAIManager.UpdateAIState");
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

    private static BmSDK.Function __fn_UpdateBehaviours;
    /// <summary>
    /// Function: UpdateBehaviours
    /// </summary>
    public unsafe virtual void UpdateBehaviours()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateBehaviours, "BmGame.RBMAIManager.UpdateBehaviours");
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

    private static BmSDK.Function __fn_UpdateBehaviourDeltas;
    /// <summary>
    /// Function: UpdateBehaviourDeltas
    /// </summary>
    public unsafe virtual void UpdateBehaviourDeltas(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateBehaviourDeltas, "BmGame.RBMAIManager.UpdateBehaviourDeltas");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearNoneControllers;
    /// <summary>
    /// Function: ClearNoneControllers
    /// </summary>
    public unsafe virtual void ClearNoneControllers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearNoneControllers, "BmGame.RBMAIManager.ClearNoneControllers");
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

    private static BmSDK.Function __fn_CanDoNavMeshCollisionFloorCheck;
    /// <summary>
    /// Function: CanDoNavMeshCollisionFloorCheck
    /// </summary>
    public unsafe virtual bool CanDoNavMeshCollisionFloorCheck(BmSDK.BmGame.RPawn TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoNavMeshCollisionFloorCheck, "BmGame.RBMAIManager.CanDoNavMeshCollisionFloorCheck");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanUpdateCombatCollision;
    /// <summary>
    /// Function: CanUpdateCombatCollision
    /// </summary>
    public unsafe virtual bool CanUpdateCombatCollision(BmSDK.BmGame.RPawn TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUpdateCombatCollision, "BmGame.RBMAIManager.CanUpdateCombatCollision");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PawnSpawnerActivated;
    /// <summary>
    /// Function: PawnSpawnerActivated
    /// </summary>
    public unsafe virtual void PawnSpawnerActivated(BmSDK.GameObject Spawner, float SpawnDelay)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnSpawnerActivated, "BmGame.RBMAIManager.PawnSpawnerActivated");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spawner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnDelay, paramsPtr + 8);
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

    private static BmSDK.Function __fn_CanPawnSpawnerActivate;
    /// <summary>
    /// Function: CanPawnSpawnerActivate
    /// </summary>
    public unsafe virtual bool CanPawnSpawnerActivate(BmSDK.GameObject Spawner)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPawnSpawnerActivate, "BmGame.RBMAIManager.CanPawnSpawnerActivate");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spawner, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Struct: FStasisPawnTeleportInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FStasisPawnTeleportInfo
    {
        /// <summary>
        /// ObjectProperty: PawnAI
        /// </summary>
        public unsafe BmSDK.BmGame.RBMPawnAI PawnAI
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: TimeUntilTeleport
        /// </summary>
        public unsafe float TimeUntilTeleport
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FStasisPawnDestroyInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FStasisPawnDestroyInfo
    {
        /// <summary>
        /// ObjectProperty: PawnAI
        /// </summary>
        public unsafe BmSDK.BmGame.RBMPawnAI PawnAI
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MaxTimeUntilDestroy
        /// </summary>
        public unsafe float MaxTimeUntilDestroy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: TimeUntilDestroy
        /// </summary>
        public unsafe float TimeUntilDestroy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bBeenSeen
        /// </summary>
        public unsafe bool bBeenSeen
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FStoredNavMeshObstacle
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FStoredNavMeshObstacle
    {
        /// <summary>
        /// ObjectProperty: ObstacleActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor ObstacleActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: ObstacleName
        /// </summary>
        public unsafe BmSDK.FString ObstacleName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: ENavMeshObstacleQueueType
    /// </summary>
    public enum ENavMeshObstacleQueueType : byte
    {
        NAVOBSTACLEQUEUE_None = 0,
        NAVOBSTACLEQUEUE_OnePerFrame = 1,
        NAVOBSTACLEQUEUE_BatchAddAndRemove = 2,
        NAVOBSTACLEQUEUE_IgnoreObstacles = 3,
        NAVOBSTACLEQUEUE_MAX = 4,
    }

    /// <summary>
    /// Struct: FNavMeshObstacleOperation
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FNavMeshObstacleOperation
    {
        /// <summary>
        /// BoolProperty: bAddObstacle
        /// </summary>
        public unsafe bool bAddObstacle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// InterfaceProperty: PathObstacle
        /// </summary>
        public unsafe BmSDK.Engine.Interface_NavMeshPathObstacle PathObstacle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Interface_NavMeshPathObstacle>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// NameProperty: ObstacleName
        /// </summary>
        public unsafe BmSDK.FName ObstacleName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FPawnSpawnerTimeout
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FPawnSpawnerTimeout
    {
        /// <summary>
        /// StrProperty: PawnSpawnerName
        /// </summary>
        public unsafe BmSDK.FString PawnSpawnerName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: CanRespawnTime
        /// </summary>
        public unsafe float CanRespawnTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FPredatorDifficultyLevelDefine
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FPredatorDifficultyLevelDefine
    {
        /// <summary>
        /// FloatProperty: AlwaysHitRange
        /// </summary>
        public unsafe float AlwaysHitRange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: InstantHitIfNotRunningRange
        /// </summary>
        public unsafe float InstantHitIfNotRunningRange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: TimeToAcquire
        /// </summary>
        public unsafe float TimeToAcquire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: RifleDamagePerShot
        /// </summary>
        public unsafe float RifleDamagePerShot
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: ShotgunDamagePerShot
        /// </summary>
        public unsafe float ShotgunDamagePerShot
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: SniperDamagePerShot
        /// </summary>
        public unsafe float SniperDamagePerShot
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: InaccuracyRange
        /// </summary>
        public unsafe float InaccuracyRange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: MaxInaccuracyRange
        /// </summary>
        public unsafe float MaxInaccuracyRange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: HitRatio
        /// </summary>
        public unsafe float HitRatio
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: GrenadeDamage
        /// </summary>
        public unsafe float GrenadeDamage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Struct: FControllerInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FControllerInfo
    {
        /// <summary>
        /// ObjectProperty: Controller
        /// </summary>
        public unsafe BmSDK.BmGame.RBMAIController Controller
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: ControllerName
        /// </summary>
        public unsafe BmSDK.FName ControllerName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// NameProperty: PawnName
        /// </summary>
        public unsafe BmSDK.FName PawnName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// NameProperty: PawnSpawner
        /// </summary>
        public unsafe BmSDK.FName PawnSpawner
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: AccumulatedDelta
        /// </summary>
        public unsafe float AccumulatedDelta
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bForceTick
        /// </summary>
        public unsafe bool bForceTick
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: bForceTickIfClose
        /// </summary>
        public unsafe bool bForceTickIfClose
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: Game
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo Game
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: BroadcastPlayerToSnipersActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor BroadcastPlayerToSnipersActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: JokerHallucinationCombatController
    /// </summary>
    public unsafe BmSDK.BmGame.RJokerHallucinationCombatController JokerHallucinationCombatController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJokerHallucinationCombatController>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: MilitiaChatter
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkCharacterDef MilitiaChatter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkCharacterDef>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: GangChatter
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkCharacterDef GangChatter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkCharacterDef>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: BarkPillarData
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkPillarLookup BarkPillarData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkPillarLookup>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: PillarState
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkFlagBase PillarState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkFlagBase>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ArrayProperty: GlobalControllerInfoList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FControllerInfo> GlobalControllerInfoList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FControllerInfo>>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ArrayProperty: ActiveAIPawnList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> ActiveAIPawnList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// IntProperty: MaxPathNodesSeenPerCheck
    /// </summary>
    public unsafe int MaxPathNodesSeenPerCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// FloatProperty: MinTimeBetweenSuccessfulChecks
    /// </summary>
    public unsafe float MinTimeBetweenSuccessfulChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceBark
    /// </summary>
    public unsafe float TimeSinceBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// IntProperty: CurrentControllerIndex
    /// </summary>
    public unsafe int CurrentControllerIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// IntProperty: AIUpdatesPerFrame
    /// </summary>
    public unsafe int AIUpdatesPerFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// BoolProperty: bCombatEnabled
    /// </summary>
    public unsafe bool bCombatEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bPauseOnNextSighting
    /// </summary>
    public unsafe bool bPauseOnNextSighting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bSetPieceTeleport
    /// </summary>
    public unsafe bool bSetPieceTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bAIFallIntoWater
    /// </summary>
    public unsafe bool bAIFallIntoWater
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bDisableAIFallingCheck
    /// </summary>
    public unsafe bool bDisableAIFallingCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bCanBatclawThroughNavMesh
    /// </summary>
    public unsafe bool bCanBatclawThroughNavMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bScanMode
    /// </summary>
    public unsafe bool bScanMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bPredatorPartial
    /// </summary>
    public unsafe bool bPredatorPartial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bPredatorActive
    /// </summary>
    public unsafe bool bPredatorActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bPredAllDownOrLockedUp
    /// </summary>
    public unsafe bool bPredAllDownOrLockedUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bSuppressFinaleCam
    /// </summary>
    public unsafe bool bSuppressFinaleCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bPawnSpawnedThisFrame
    /// </summary>
    public unsafe bool bPawnSpawnedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bUpdateNavigationObstacles
    /// </summary>
    public unsafe bool bUpdateNavigationObstacles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bForceUpdateNavigationObstacles
    /// </summary>
    public unsafe bool bForceUpdateNavigationObstacles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bPillarStateDirty
    /// </summary>
    public unsafe bool bPillarStateDirty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bShouldLoadPredVolBarks_Militia
    /// </summary>
    public unsafe bool bShouldLoadPredVolBarks_Militia
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bShouldLoadPredVolBarks_Gang
    /// </summary>
    public unsafe bool bShouldLoadPredVolBarks_Gang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bNavMeshJobInProgress
    /// </summary>
    public unsafe bool bNavMeshJobInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bPylonLoaded
    /// </summary>
    public unsafe bool bPylonLoaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bQueuedUnZoomPawns
    /// </summary>
    public unsafe bool bQueuedUnZoomPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// IntProperty: ManDownPerimeterCap
    /// </summary>
    public unsafe int ManDownPerimeterCap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// FloatProperty: SmashNoiseRadius_Close
    /// </summary>
    public unsafe float SmashNoiseRadius_Close
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ArrayProperty: PawnSpawnerControllers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnSpawnerController> PawnSpawnerControllers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnSpawnerController>>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// IntProperty: CurrPathNodeSeenUpdater
    /// </summary>
    public unsafe int CurrPathNodeSeenUpdater
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// IntProperty: StoredSeenVal
    /// </summary>
    public unsafe int StoredSeenVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// IntProperty: LastSetSeenVal
    /// </summary>
    public unsafe int LastSetSeenVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: LastRocketTime
    /// </summary>
    public unsafe float LastRocketTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ArrayProperty: ThugsPreventingRocketFire
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ThugsPreventingRocketFire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// FloatProperty: PHFOV
    /// </summary>
    public unsafe float PHFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// FloatProperty: PVFOV
    /// </summary>
    public unsafe float PVFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// FloatProperty: FocusViewDist
    /// </summary>
    public unsafe float FocusViewDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// FloatProperty: PeriViewDist
    /// </summary>
    public unsafe float PeriViewDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// FloatProperty: ExtViewDist
    /// </summary>
    public unsafe float ExtViewDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// FloatProperty: LastSearchSpecialTime
    /// </summary>
    public unsafe float LastSearchSpecialTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// IntProperty: CurrWorldAvoidanceUpdate
    /// </summary>
    public unsafe int CurrWorldAvoidanceUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// IntProperty: WorldAvoidanceUpdateGroups
    /// </summary>
    public unsafe int WorldAvoidanceUpdateGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// IntProperty: NextAvoidanceUpdate
    /// </summary>
    public unsafe int NextAvoidanceUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// IntProperty: PriorityAvoidanceCounter
    /// </summary>
    public unsafe int PriorityAvoidanceCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// IntProperty: CurrCombatCollisionUpdate
    /// </summary>
    public unsafe int CurrCombatCollisionUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// IntProperty: CombatCollisionUpdateGroups
    /// </summary>
    public unsafe int CombatCollisionUpdateGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// IntProperty: CurrNavMeshCollisionFloorCheckUpdate
    /// </summary>
    public unsafe int CurrNavMeshCollisionFloorCheckUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// IntProperty: NavMeshCollisionFloorCheckUpdateGroups
    /// </summary>
    public unsafe int NavMeshCollisionFloorCheckUpdateGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// IntProperty: CurrIdleConfigLOSCheckUpdate
    /// </summary>
    public unsafe int CurrIdleConfigLOSCheckUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// IntProperty: IdleConfigLOSCheckUpdateGroups
    /// </summary>
    public unsafe int IdleConfigLOSCheckUpdateGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// StrProperty: PredPartialFlagName
    /// </summary>
    public unsafe BmSDK.FString PredPartialFlagName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// StrProperty: PredActiveFlagName
    /// </summary>
    public unsafe BmSDK.FString PredActiveFlagName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// StrProperty: PredAllDownOrLockedUpFlagName
    /// </summary>
    public unsafe BmSDK.FString PredAllDownOrLockedUpFlagName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// IntProperty: FiringCount
    /// </summary>
    public unsafe int FiringCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// FloatProperty: PathLookPitchScale_Up
    /// </summary>
    public unsafe float PathLookPitchScale_Up
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: PathLookPitchScale_Down
    /// </summary>
    public unsafe float PathLookPitchScale_Down
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ArrayProperty: PredatorGunLockers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPredatorGunLockerBase> PredatorGunLockers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPredatorGunLockerBase>>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ArrayProperty: PredatorSpecialMovePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPredatorSpecialMovePointBase> PredatorSpecialMovePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPredatorSpecialMovePointBase>>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// ArrayProperty: PredDifficulty
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FPredatorDifficultyLevelDefine> PredDifficulty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FPredatorDifficultyLevelDefine>>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// ArrayProperty: PredFiringCountDamageMultiplier
    /// </summary>
    public unsafe BmSDK.TArray<float> PredFiringCountDamageMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ArrayProperty: ActiveSnipers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> ActiveSnipers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// ArrayProperty: PawnSpawnerTimeoutInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FPawnSpawnerTimeout> PawnSpawnerTimeoutInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FPawnSpawnerTimeout>>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// ArrayProperty: BatmanCloseCheckBehaviours
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBM2Behaviour_IdleConfig> BatmanCloseCheckBehaviours
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBM2Behaviour_IdleConfig>>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// ArrayProperty: PendingNavMeshObstacleOperations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FNavMeshObstacleOperation> PendingNavMeshObstacleOperations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FNavMeshObstacleOperation>>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ArrayProperty: takedownCountVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RTakedownCountVolume> takedownCountVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RTakedownCountVolume>>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ArrayProperty: lootSources
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLootSourceBase> lootSources
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLootSourceBase>>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ArrayProperty: lootDestinations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLootDestinationBase> lootDestinations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLootDestinationBase>>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ArrayProperty: deadThugCounters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_DeadThugOnscreenCounter> deadThugCounters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_DeadThugOnscreenCounter>>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ArrayProperty: destructibleWallsWaitingToRegisterWithNavMesh
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDestructibleProp_FractureWall> destructibleWallsWaitingToRegisterWithNavMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDestructibleProp_FractureWall>>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ArrayProperty: DialogueLocationVolumeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDialogueLocationVolume> DialogueLocationVolumeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDialogueLocationVolume>>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// IntProperty: FramesUntilNextPawnSpawn
    /// </summary>
    public unsafe int FramesUntilNextPawnSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// ArrayProperty: ScriptedSpawners
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> ScriptedSpawners
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// IntProperty: SpawnsThisFrame
    /// </summary>
    public unsafe int SpawnsThisFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// IntProperty: CurrShockedIdleID
    /// </summary>
    public unsafe int CurrShockedIdleID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// IntProperty: CurrRainMaterialUpdate
    /// </summary>
    public unsafe int CurrRainMaterialUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// ByteProperty: NavMeshObstacleQueueType
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIManager.ENavMeshObstacleQueueType NavMeshObstacleQueueType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIManager.ENavMeshObstacleQueueType>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// ArrayProperty: RegisteredNavMeshObstacleActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FStoredNavMeshObstacle> RegisteredNavMeshObstacleActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FStoredNavMeshObstacle>>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// IntProperty: iNextSpawnedThugUniqueIdentifier
    /// </summary>
    public unsafe int iNextSpawnedThugUniqueIdentifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// ArrayProperty: StasisDestroyPawns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FStasisPawnDestroyInfo> StasisDestroyPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FStasisPawnDestroyInfo>>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// ArrayProperty: StasisTeleportPawns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FStasisPawnTeleportInfo> StasisTeleportPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FStasisPawnTeleportInfo>>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// ArrayProperty: RebuildSpecialEdgeActorList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> RebuildSpecialEdgeActorList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// ArrayProperty: PreviousFramePawnNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PreviousFramePawnNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// ArrayProperty: BarkData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkCharacterDefInstance> BarkData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkCharacterDefInstance>>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// ArrayProperty: ActiveChasePoints
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ActiveChasePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// ArrayProperty: CornerPointsToRegister
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCornerPointBase> CornerPointsToRegister
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCornerPointBase>>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// ArrayProperty: LLDAIToRegister
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLedgeLookDangerAreaInfo> LLDAIToRegister
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLedgeLookDangerAreaInfo>>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// ArrayProperty: DisableDivingVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDisableAIDivingAwayFromVehiclesVolume> DisableDivingVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDisableAIDivingAwayFromVehiclesVolume>>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// ArrayProperty: PropsToUpdate
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDestructibleProp> PropsToUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDestructibleProp>>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// ArrayProperty: BlockadesToUpdate
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCheckpointBlockadeBase> BlockadesToUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCheckpointBlockadeBase>>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// ArrayProperty: ObstaclesToUpdate
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavMeshObstacle_Queue> ObstaclesToUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavMeshObstacle_Queue>>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// StructProperty: CachedBmblNavLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CachedBmblNavLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1432);

    /// <summary>
    /// ArrayProperty: CachedBmblNavShape
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> CachedBmblNavShape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }
}
