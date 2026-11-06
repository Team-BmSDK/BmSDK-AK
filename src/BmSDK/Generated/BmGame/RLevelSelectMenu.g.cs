#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RLevelSelectMenu<br/>
/// (size = 1212)
/// (flags = 144704150)
/// </summary>
public partial class RLevelSelectMenu : BmSDK.BmGame.RDynamicMenu, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RLevelSelectMenu", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RLevelSelectMenu.
    /// </summary>
    public static RLevelSelectMenu DefaultObject => (RLevelSelectMenu)StaticClass().DefaultObject;

    internal RLevelSelectMenu() { }

    /// <summary>
    /// Constructs a new RLevelSelectMenu
    /// </summary>
    public RLevelSelectMenu(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RLevelSelectMenu(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLevelSelectMenu>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelSelectMenu>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLevelSelectMenu>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelSelectMenu>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelSelectMenu>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelSelectMenu>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLevelSelectMenu>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelSelectMenu>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DumpMenusSubForQA;
    /// <summary>
    /// Function: DumpMenusSubForQA
    /// </summary>
    public unsafe virtual void DumpMenusSubForQA(BmSDK.TArray<BmSDK.BmGame.RLevelSelectMenu.FLevelDef> LevelDefs, BmSDK.FString ChapterName, int KeyboardShortcut)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpMenusSubForQA, "BmGame.RLevelSelectMenu.DumpMenusSubForQA");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelDefs, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChapterName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyboardShortcut, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpMenusForQA;
    /// <summary>
    /// Function: DumpMenusForQA
    /// </summary>
    public unsafe virtual void DumpMenusForQA(bool VS, out BmSDK.TArray<BmSDK.BmGame.RSaveGameManager.FRSaveGameSummaryInfo> StartPoints)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpMenusForQA, "BmGame.RLevelSelectMenu.DumpMenusForQA");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VS, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StartPoints = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RSaveGameManager.FRSaveGameSummaryInfo>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_DoMenuItems;
    /// <summary>
    /// Function: DoMenuItems
    /// </summary>
    public unsafe override void DoMenuItems()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoMenuItems, "BmGame.RLevelSelectMenu.DoMenuItems");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinalItems;
    /// <summary>
    /// Function: FinalItems
    /// </summary>
    public unsafe virtual void FinalItems()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinalItems, "BmGame.RLevelSelectMenu.FinalItems");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoCharacterSelect;
    /// <summary>
    /// Function: DoCharacterSelect
    /// </summary>
    public unsafe virtual void DoCharacterSelect()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoCharacterSelect, "BmGame.RLevelSelectMenu.DoCharacterSelect");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFromStartItem;
    /// <summary>
    /// Function: PlayFromStartItem
    /// </summary>
    public unsafe virtual void PlayFromStartItem()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFromStartItem, "BmGame.RLevelSelectMenu.PlayFromStartItem");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoStartPointsMenu;
    /// <summary>
    /// Function: DoStartPointsMenu
    /// </summary>
    public unsafe virtual void DoStartPointsMenu(BmSDK.FString SaveType, out BmSDK.TArray<BmSDK.BmGame.RSaveGameManager.FRSaveGameSummaryInfo> StartPoints, BmSDK.FString Title = default, int ShortcutNumber = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoStartPointsMenu, "BmGame.RLevelSelectMenu.DoStartPointsMenu");
        byte* paramsPtr = stackalloc byte[156];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShortcutNumber, paramsPtr + 48);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        StartPoints = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RSaveGameManager.FRSaveGameSummaryInfo>>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_DoStartPointsMenuTitle;
    /// <summary>
    /// Function: DoStartPointsMenuTitle
    /// </summary>
    public unsafe virtual void DoStartPointsMenuTitle(BmSDK.FString Title, int ShortcutNumber)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoStartPointsMenuTitle, "BmGame.RLevelSelectMenu.DoStartPointsMenuTitle");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShortcutNumber, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoSaveGameMenu;
    /// <summary>
    /// Function: DoSaveGameMenu
    /// </summary>
    public unsafe virtual void DoSaveGameMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoSaveGameMenu, "BmGame.RLevelSelectMenu.DoSaveGameMenu");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoLevelsMenu;
    /// <summary>
    /// Function: DoLevelsMenu
    /// </summary>
    public unsafe virtual void DoLevelsMenu(BmSDK.TArray<BmSDK.BmGame.RLevelSelectMenu.FLevelDef> LevelDefs, BmSDK.FString ChapterName, int KeyboardShortcut, BmSDK.FString AddLevels = default, BmSDK.FString AddParams = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoLevelsMenu, "BmGame.RLevelSelectMenu.DoLevelsMenu");
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelDefs, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChapterName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyboardShortcut, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AddLevels, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AddParams, paramsPtr + 52);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_LoadLevel;
    /// <summary>
    /// Function: LoadLevel
    /// </summary>
    public unsafe virtual void LoadLevel(BmSDK.FString Level)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadLevel, "BmGame.RLevelSelectMenu.LoadLevel");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Level, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadLevelDef;
    /// <summary>
    /// Function: LoadLevelDef
    /// </summary>
    public unsafe virtual void LoadLevelDef(BmSDK.BmGame.RLevelSelectMenu.FLevelDef L, BmSDK.FString ExtraParams = default, BmSDK.FString AddLevels = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadLevelDef, "BmGame.RLevelSelectMenu.LoadLevelDef");
        byte* paramsPtr = stackalloc byte[156];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(L, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraParams, paramsPtr + 108);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AddLevels, paramsPtr + 124);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_LoadSaveGame;
    /// <summary>
    /// Function: LoadSaveGame
    /// </summary>
    public unsafe virtual void LoadSaveGame(BmSDK.FString SaveName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadSaveGame, "BmGame.RLevelSelectMenu.LoadSaveGame");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoMenu;
    /// <summary>
    /// Function: DoMenu
    /// </summary>
    public unsafe override bool DoMenu(BmSDK.Engine.Canvas C, float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoMenu, "BmGame.RLevelSelectMenu.DoMenu");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CheckRequiredChunksAreReady;
    /// <summary>
    /// Function: CheckRequiredChunksAreReady
    /// </summary>
    public unsafe virtual bool CheckRequiredChunksAreReady(int RequiredChunk)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckRequiredChunksAreReady, "BmGame.RLevelSelectMenu.CheckRequiredChunksAreReady");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequiredChunk, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OnEnumerateUserFilesComplete;
    /// <summary>
    /// Function: OnEnumerateUserFilesComplete
    /// </summary>
    public unsafe virtual void OnEnumerateUserFilesComplete(bool bWasSuccessful, BmSDK.FString UserId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEnumerateUserFilesComplete, "BmGame.RLevelSelectMenu.OnEnumerateUserFilesComplete");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartRealSavesQuery;
    /// <summary>
    /// Function: StartRealSavesQuery
    /// </summary>
    public unsafe virtual void StartRealSavesQuery()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartRealSavesQuery, "BmGame.RLevelSelectMenu.StartRealSavesQuery");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableMenu;
    /// <summary>
    /// Function: EnableMenu
    /// </summary>
    public unsafe virtual void EnableMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableMenu, "BmGame.RLevelSelectMenu.EnableMenu");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AutoStartLevel;
    /// <summary>
    /// Function: AutoStartLevel
    /// </summary>
    public unsafe virtual void AutoStartLevel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutoStartLevel, "BmGame.RLevelSelectMenu.AutoStartLevel");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RLevelSelectMenu.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StoreCurrentSelection;
    /// <summary>
    /// Function: StoreCurrentSelection
    /// </summary>
    public unsafe virtual void StoreCurrentSelection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StoreCurrentSelection, "BmGame.RLevelSelectMenu.StoreCurrentSelection");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMenuOpened;
    /// <summary>
    /// Function: OnMenuOpened
    /// </summary>
    public unsafe override void OnMenuOpened()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMenuOpened, "BmGame.RLevelSelectMenu.OnMenuOpened");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableHydraToBypassOnlineSubsystem;
    /// <summary>
    /// Function: EnableHydraToBypassOnlineSubsystem
    /// </summary>
    public unsafe virtual void EnableHydraToBypassOnlineSubsystem()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableHydraToBypassOnlineSubsystem, "BmGame.RLevelSelectMenu.EnableHydraToBypassOnlineSubsystem");
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

    private static BmSDK.Function __fn_TakeOptionsCopy;
    /// <summary>
    /// Function: TakeOptionsCopy
    /// </summary>
    public unsafe virtual void TakeOptionsCopy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeOptionsCopy, "BmGame.RLevelSelectMenu.TakeOptionsCopy");
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

    private static BmSDK.Function __fn_InvalidateMemorySave;
    /// <summary>
    /// Function: InvalidateMemorySave
    /// </summary>
    public unsafe virtual void InvalidateMemorySave()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InvalidateMemorySave, "BmGame.RLevelSelectMenu.InvalidateMemorySave");
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

    private static BmSDK.Function __fn_KillAllSounds;
    /// <summary>
    /// Function: KillAllSounds
    /// </summary>
    public unsafe virtual void KillAllSounds()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillAllSounds, "BmGame.RLevelSelectMenu.KillAllSounds");
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

    private static BmSDK.Function __fn_DoMoviesMenu;
    /// <summary>
    /// Function: DoMoviesMenu
    /// </summary>
    public unsafe virtual void DoMoviesMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoMoviesMenu, "BmGame.RLevelSelectMenu.DoMoviesMenu");
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

    private static BmSDK.Function __fn_DoAllLevelsMenu;
    /// <summary>
    /// Function: DoAllLevelsMenu
    /// </summary>
    public unsafe virtual void DoAllLevelsMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoAllLevelsMenu, "BmGame.RLevelSelectMenu.DoAllLevelsMenu");
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

    private static BmSDK.Function __fn_FlushOpenHandles;
    /// <summary>
    /// Function: FlushOpenHandles
    /// </summary>
    public unsafe virtual void FlushOpenHandles()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushOpenHandles, "BmGame.RLevelSelectMenu.FlushOpenHandles");
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

    /// <summary>
    /// ArrayProperty: Menus
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLevelSelectMenu.FMenusDef> Menus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLevelSelectMenu.FMenusDef>>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ArrayProperty: NonMilestoneMenus
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLevelSelectMenu.FMenusDef> NonMilestoneMenus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLevelSelectMenu.FMenusDef>>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// ArrayProperty: DLCMenus
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLevelSelectMenu.FMenusDef> DLCMenus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLevelSelectMenu.FMenusDef>>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// ArrayProperty: QAMenus
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLevelSelectMenu.FMenusDef> QAMenus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLevelSelectMenu.FMenusDef>>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ArrayProperty: Cutscenes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLevelSelectMenu.FMenusDef> Cutscenes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLevelSelectMenu.FMenusDef>>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// ObjectProperty: Backdrop
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D Backdrop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// ArrayProperty: SaveGames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSaveGameManager.FRSaveGameSummaryInfo> SaveGames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSaveGameManager.FRSaveGameSummaryInfo>>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// ArrayProperty: StartPointsNG
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSaveGameManager.FRSaveGameSummaryInfo> StartPointsNG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSaveGameManager.FRSaveGameSummaryInfo>>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// ArrayProperty: StartPointsNGP
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSaveGameManager.FRSaveGameSummaryInfo> StartPointsNGP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSaveGameManager.FRSaveGameSummaryInfo>>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: StartPointsDLC
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSaveGameManager.FRSaveGameSummaryInfo> StartPointsDLC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSaveGameManager.FRSaveGameSummaryInfo>>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ArrayProperty: AllLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> AllLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bNewGamePlusMode
    /// </summary>
    public unsafe bool bNewGamePlusMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bMilestoneMapsOnly
    /// </summary>
    public unsafe bool bMilestoneMapsOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bScannedForMovies
    /// </summary>
    public unsafe bool bScannedForMovies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bOpenedChunkUI
    /// </summary>
    public unsafe bool bOpenedChunkUI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bIsLoading
    /// </summary>
    public unsafe bool bIsLoading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// IntProperty: Chapter
    /// </summary>
    public unsafe int Chapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// IntProperty: ChosenCharacter
    /// </summary>
    public unsafe int ChosenCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// IntProperty: ChosenBatmobile
    /// </summary>
    public unsafe int ChosenBatmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// ArrayProperty: ChapterNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ChapterNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ArrayProperty: CharacterNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> CharacterNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// ArrayProperty: BatmobileNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> BatmobileNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ArrayProperty: MovieNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> MovieNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// IntProperty: UnpausedCounter
    /// </summary>
    public unsafe int UnpausedCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// Struct: FMenusDef
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FMenusDef
    {
        /// <summary>
        /// StrProperty: Title
        /// </summary>
        public unsafe BmSDK.FString Title
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: Levels
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RLevelSelectMenu.FLevelDef> Levels
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLevelSelectMenu.FLevelDef>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FLevelDef
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 108)]
    public partial record struct FLevelDef
    {
        /// <summary>
        /// StrProperty: Desc
        /// </summary>
        public unsafe BmSDK.FString Desc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: LevelNames
        /// </summary>
        public unsafe BmSDK.FString LevelNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: Flags
        /// </summary>
        public unsafe BmSDK.FString Flags
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StrProperty: Chapters
        /// </summary>
        public unsafe BmSDK.FString Chapters
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StrProperty: LoadSaveGame
        /// </summary>
        public unsafe BmSDK.FString LoadSaveGame
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// StrProperty: ConsoleEvent
        /// </summary>
        public unsafe BmSDK.FString ConsoleEvent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// NameProperty: StartPoint
        /// </summary>
        public unsafe BmSDK.FName StartPoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// BoolProperty: DisableEntry
        /// </summary>
        public unsafe bool DisableEntry
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }; }
        }

        /// <summary>
        /// BoolProperty: DisableEntryInMilestone
        /// </summary>
        public unsafe bool DisableEntryInMilestone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }; }
        }
    }
}
