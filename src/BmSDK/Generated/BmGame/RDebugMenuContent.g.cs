#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDebugMenuContent<br/>
/// (size = 1192)
/// (flags = 10485782)
/// </summary>
public partial class RDebugMenuContent : BmSDK.BmGame.RDebugMenu, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDebugMenuContent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RDebugMenuContent.
    /// </summary>
    public static RDebugMenuContent DefaultObject => (RDebugMenuContent)StaticClass().DefaultObject;

    internal RDebugMenuContent() { }

    /// <summary>
    /// Constructs a new RDebugMenuContent
    /// </summary>
    public RDebugMenuContent(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDebugMenuContent(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DoBackscreenMenu;
    /// <summary>
    /// Function: DoBackscreenMenu
    /// </summary>
    public unsafe virtual void DoBackscreenMenu(BmSDK.BmGame.RPlayerController RPC, out BmSDK.BmGame.RPersistentDebugData.FBackscreenDebugData Debug_BackscreenDebugData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoBackscreenMenu, "BmGame.RDebugMenuContent.DoBackscreenMenu");
        byte* paramsPtr = stackalloc byte[96];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Debug_BackscreenDebugData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentDebugData.FBackscreenDebugData>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_MostWantedReCalc;
    /// <summary>
    /// Function: MostWantedReCalc
    /// </summary>
    public unsafe virtual void MostWantedReCalc(BmSDK.BmGame.RPlayerController RPC, out BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData> Debug_MostWantedData, BmSDK.BmGame.RPersistentDebugData.MostWantedDebugMenuE Entry, int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MostWantedReCalc, "BmGame.RDebugMenuContent.MostWantedReCalc");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Debug_MostWantedData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_BespokeProperties;
    /// <summary>
    /// Function: BespokeProperties
    /// </summary>
    public unsafe virtual void BespokeProperties(BmSDK.BmGame.RPlayerController RPC, out BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData> Debug_MostWantedData, BmSDK.BmGame.RPersistentDebugData.MostWantedDebugMenuE Entry, int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BespokeProperties, "BmGame.RDebugMenuContent.BespokeProperties");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Debug_MostWantedData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_MenuMostWanted;
    /// <summary>
    /// Function: MenuMostWanted
    /// </summary>
    public unsafe virtual void MenuMostWanted(BmSDK.BmGame.RPlayerController RPC, out BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData> Debug_MostWantedData, BmSDK.BmGame.RPersistentDebugData.MostWantedDebugMenuE Entry)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MenuMostWanted, "BmGame.RDebugMenuContent.MenuMostWanted");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Debug_MostWantedData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_MenuMostWantedUnlockItem;
    /// <summary>
    /// Function: MenuMostWantedUnlockItem
    /// </summary>
    public unsafe virtual void MenuMostWantedUnlockItem(BmSDK.BmGame.RPlayerController RPC, out BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData> Debug_MostWantedData, BmSDK.BmGame.RPersistentDebugData.MostWantedDebugMenuE Entry)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MenuMostWantedUnlockItem, "BmGame.RDebugMenuContent.MenuMostWantedUnlockItem");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Debug_MostWantedData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_MenuMostWantedCollapseAll;
    /// <summary>
    /// Function: MenuMostWantedCollapseAll
    /// </summary>
    public unsafe virtual void MenuMostWantedCollapseAll(out BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData> Debug_MostWantedData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MenuMostWantedCollapseAll, "BmGame.RDebugMenuContent.MenuMostWantedCollapseAll");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Debug_MostWantedData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_DoMostWantedMenu;
    /// <summary>
    /// Function: DoMostWantedMenu
    /// </summary>
    public unsafe virtual void DoMostWantedMenu(BmSDK.BmGame.RPlayerController RPC, out BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData> Debug_MostWantedData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoMostWantedMenu, "BmGame.RDebugMenuContent.DoMostWantedMenu");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Debug_MostWantedData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_ModifyBaseProperties;
    /// <summary>
    /// Function: ModifyBaseProperties
    /// </summary>
    public unsafe virtual bool ModifyBaseProperties(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyBaseProperties, "BmGame.RDebugMenuContent.ModifyBaseProperties");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FindOrAddMission;
    /// <summary>
    /// Function: FindOrAddMission
    /// </summary>
    public unsafe virtual int FindOrAddMission(BmSDK.BmGame.RPlayerController RPC, BmSDK.FString MissionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindOrAddMission, "BmGame.RDebugMenuContent.FindOrAddMission");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MissionName, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_RItemFlag;
    /// <summary>
    /// Function: RItemFlag
    /// </summary>
    public unsafe virtual bool RItemFlag(BmSDK.FString DisplayString, BmSDK.FString FlagName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RItemFlag, "BmGame.RDebugMenuContent.RItemFlag");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisplayString, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GivePlayerWeapon;
    /// <summary>
    /// Function: GivePlayerWeapon
    /// </summary>
    public unsafe virtual void GivePlayerWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GivePlayerWeapon, "BmGame.RDebugMenuContent.GivePlayerWeapon");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetTakedownObjects;
    /// <summary>
    /// Function: ResetTakedownObjects
    /// </summary>
    public unsafe virtual void ResetTakedownObjects()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetTakedownObjects, "BmGame.RDebugMenuContent.ResetTakedownObjects");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateDebrisMaxHeightComponent;
    /// <summary>
    /// Function: UpdateDebrisMaxHeightComponent
    /// </summary>
    public unsafe virtual void UpdateDebrisMaxHeightComponent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateDebrisMaxHeightComponent, "BmGame.RDebugMenuContent.UpdateDebrisMaxHeightComponent");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DettachDebrisMaxHeightStaticMeshComponentFromPlayer;
    /// <summary>
    /// Function: DettachDebrisMaxHeightStaticMeshComponentFromPlayer
    /// </summary>
    public unsafe virtual void DettachDebrisMaxHeightStaticMeshComponentFromPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DettachDebrisMaxHeightStaticMeshComponentFromPlayer, "BmGame.RDebugMenuContent.DettachDebrisMaxHeightStaticMeshComponentFromPlayer");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachDebrisMaxHeightStaticMeshComponentToPlayer;
    /// <summary>
    /// Function: AttachDebrisMaxHeightStaticMeshComponentToPlayer
    /// </summary>
    public unsafe virtual void AttachDebrisMaxHeightStaticMeshComponentToPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachDebrisMaxHeightStaticMeshComponentToPlayer, "BmGame.RDebugMenuContent.AttachDebrisMaxHeightStaticMeshComponentToPlayer");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMenuClosed;
    /// <summary>
    /// Function: OnMenuClosed
    /// </summary>
    public unsafe override void OnMenuClosed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMenuClosed, "BmGame.RDebugMenuContent.OnMenuClosed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMenuOpened;
    /// <summary>
    /// Function: OnMenuOpened
    /// </summary>
    public unsafe override void OnMenuOpened()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMenuOpened, "BmGame.RDebugMenuContent.OnMenuOpened");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowVersionInfo;
    /// <summary>
    /// Function: ShowVersionInfo
    /// </summary>
    public unsafe override void ShowVersionInfo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowVersionInfo, "BmGame.RDebugMenuContent.ShowVersionInfo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowSoloEventInfo;
    /// <summary>
    /// Function: ShowSoloEventInfo
    /// </summary>
    public unsafe virtual void ShowSoloEventInfo(BmSDK.BmGame.RAlertEventCoordinatorSolo AEC, int IndentDepth = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowSoloEventInfo, "BmGame.RDebugMenuContent.ShowSoloEventInfo");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AEC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IndentDepth, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowEventInfo;
    /// <summary>
    /// Function: ShowEventInfo
    /// </summary>
    public unsafe virtual void ShowEventInfo(BmSDK.BmGame.RAlertEventCoordinatorBase AEC, int IndentDepth = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowEventInfo, "BmGame.RDebugMenuContent.ShowEventInfo");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AEC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IndentDepth, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoDifficultyProgressionMenu;
    /// <summary>
    /// Function: DoDifficultyProgressionMenu
    /// </summary>
    public unsafe virtual void DoDifficultyProgressionMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoDifficultyProgressionMenu, "BmGame.RDebugMenuContent.DoDifficultyProgressionMenu");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoVehiclesMenu;
    /// <summary>
    /// Function: DoVehiclesMenu
    /// </summary>
    public unsafe virtual void DoVehiclesMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoVehiclesMenu, "BmGame.RDebugMenuContent.DoVehiclesMenu");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoVehiclePhysicsMenu;
    /// <summary>
    /// Function: DoVehiclePhysicsMenu
    /// </summary>
    public unsafe virtual void DoVehiclePhysicsMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoVehiclePhysicsMenu, "BmGame.RDebugMenuContent.DoVehiclePhysicsMenu");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoVehicleDifficultyMenu;
    /// <summary>
    /// Function: DoVehicleDifficultyMenu
    /// </summary>
    public unsafe virtual void DoVehicleDifficultyMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoVehicleDifficultyMenu, "BmGame.RDebugMenuContent.DoVehicleDifficultyMenu");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoBatmobileHandlingSwitch;
    /// <summary>
    /// Function: DoBatmobileHandlingSwitch
    /// </summary>
    public unsafe virtual void DoBatmobileHandlingSwitch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoBatmobileHandlingSwitch, "BmGame.RDebugMenuContent.DoBatmobileHandlingSwitch");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoGadgetsMenu;
    /// <summary>
    /// Function: DoGadgetsMenu
    /// </summary>
    public unsafe virtual void DoGadgetsMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoGadgetsMenu, "BmGame.RDebugMenuContent.DoGadgetsMenu");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoBatgirlDebugMenu;
    /// <summary>
    /// Function: DoBatgirlDebugMenu
    /// </summary>
    public unsafe virtual void DoBatgirlDebugMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoBatgirlDebugMenu, "BmGame.RDebugMenuContent.DoBatgirlDebugMenu");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoHarleyDebugMenu;
    /// <summary>
    /// Function: DoHarleyDebugMenu
    /// </summary>
    public unsafe virtual void DoHarleyDebugMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoHarleyDebugMenu, "BmGame.RDebugMenuContent.DoHarleyDebugMenu");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoBossMenu;
    /// <summary>
    /// Function: DoBossMenu
    /// </summary>
    public unsafe virtual void DoBossMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoBossMenu, "BmGame.RDebugMenuContent.DoBossMenu");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ItemGadget;
    /// <summary>
    /// Function: ItemGadget
    /// </summary>
    public unsafe virtual bool ItemGadget(BmSDK.FString GadgetName, BmSDK.BmGame.RInventoryGadget Gadget, BmSDK.Class GadgetClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemGadget, "BmGame.RDebugMenuContent.ItemGadget");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gadget, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetClass, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_AddApexClothMenu;
    /// <summary>
    /// Function: AddApexClothMenu
    /// </summary>
    public unsafe virtual void AddApexClothMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddApexClothMenu, "BmGame.RDebugMenuContent.AddApexClothMenu");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDestructiblesMenu;
    /// <summary>
    /// Function: AddDestructiblesMenu
    /// </summary>
    public unsafe virtual void AddDestructiblesMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDestructiblesMenu, "BmGame.RDebugMenuContent.AddDestructiblesMenu");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoMenuItems;
    /// <summary>
    /// Function: DoMenuItems
    /// </summary>
    public unsafe override void DoMenuItems()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoMenuItems, "BmGame.RDebugMenuContent.DoMenuItems");
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoTableOfContentMenu;
    /// <summary>
    /// Function: DoTableOfContentMenu
    /// </summary>
    public unsafe virtual void DoTableOfContentMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoTableOfContentMenu, "BmGame.RDebugMenuContent.DoTableOfContentMenu");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLevelVisible;
    /// <summary>
    /// Function: SetLevelVisible
    /// </summary>
    public unsafe virtual void SetLevelVisible(BmSDK.FString LevelName, BmSDK.FString LevelType, bool bVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLevelVisible, "BmGame.RDebugMenuContent.SetLevelVisible");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoCapeMenuItems;
    /// <summary>
    /// Function: DoCapeMenuItems
    /// </summary>
    public unsafe virtual void DoCapeMenuItems(BmSDK.Engine.Actor BatmanActor, bool bCapeEnableOnly = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoCapeMenuItems, "BmGame.RDebugMenuContent.DoCapeMenuItems");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCapeEnableOnly, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoCapeDebugStateChangeMenu;
    /// <summary>
    /// Function: DoCapeDebugStateChangeMenu
    /// </summary>
    public unsafe virtual void DoCapeDebugStateChangeMenu(BmSDK.BmGame.RCapeComponent CapeComponent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoCapeDebugStateChangeMenu, "BmGame.RDebugMenuContent.DoCapeDebugStateChangeMenu");
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CapeComponent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCapeComponentFromActor;
    /// <summary>
    /// Function: GetCapeComponentFromActor
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RCapeComponent GetCapeComponentFromActor(BmSDK.Engine.Actor BatmanActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCapeComponentFromActor, "BmGame.RDebugMenuContent.GetCapeComponentFromActor");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeComponent>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DoAiThoughtsMenu;
    /// <summary>
    /// Function: DoAiThoughtsMenu
    /// </summary>
    public unsafe virtual void DoAiThoughtsMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoAiThoughtsMenu, "BmGame.RDebugMenuContent.DoAiThoughtsMenu");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoBatmanStrikeListMenu;
    /// <summary>
    /// Function: DoBatmanStrikeListMenu
    /// </summary>
    public unsafe virtual void DoBatmanStrikeListMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoBatmanStrikeListMenu, "BmGame.RDebugMenuContent.DoBatmanStrikeListMenu");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoVehicleEnemyMenu;
    /// <summary>
    /// Function: DoVehicleEnemyMenu
    /// </summary>
    public unsafe virtual bool DoVehicleEnemyMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoVehicleEnemyMenu, "BmGame.RDebugMenuContent.DoVehicleEnemyMenu");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DoTakedownTestMenu;
    /// <summary>
    /// Function: DoTakedownTestMenu
    /// </summary>
    public unsafe virtual void DoTakedownTestMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoTakedownTestMenu, "BmGame.RDebugMenuContent.DoTakedownTestMenu");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoRandomPopulationMenu;
    /// <summary>
    /// Function: DoRandomPopulationMenu
    /// </summary>
    public unsafe virtual void DoRandomPopulationMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoRandomPopulationMenu, "BmGame.RDebugMenuContent.DoRandomPopulationMenu");
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoPSCMenu;
    /// <summary>
    /// Function: DoPSCMenu
    /// </summary>
    public unsafe virtual void DoPSCMenu(bool NoTitle = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoPSCMenu, "BmGame.RDebugMenuContent.DoPSCMenu");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoTitle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoPerCharacterTypeAudioItems;
    /// <summary>
    /// Function: DoPerCharacterTypeAudioItems
    /// </summary>
    public unsafe virtual void DoPerCharacterTypeAudioItems(out BmSDK.BmGame.RPersistentDebugData.FPerCharacterTypeAnimDebug Options, BmSDK.FString CharacterName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoPerCharacterTypeAudioItems, "BmGame.RDebugMenuContent.DoPerCharacterTypeAudioItems");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterName, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Options = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentDebugData.FPerCharacterTypeAnimDebug>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_DoCinematicAnimItems;
    /// <summary>
    /// Function: DoCinematicAnimItems
    /// </summary>
    public unsafe virtual void DoCinematicAnimItems(out BmSDK.BmGame.RPersistentDebugData.FCinematicAnimDebug Options)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoCinematicAnimItems, "BmGame.RDebugMenuContent.DoCinematicAnimItems");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Options = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentDebugData.FCinematicAnimDebug>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_DoVehicleAnimItems;
    /// <summary>
    /// Function: DoVehicleAnimItems
    /// </summary>
    public unsafe virtual void DoVehicleAnimItems(out BmSDK.BmGame.RPersistentDebugData.FVehicleAnimDebug Options, BmSDK.FString MenuName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoVehicleAnimItems, "BmGame.RDebugMenuContent.DoVehicleAnimItems");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MenuName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Options = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentDebugData.FVehicleAnimDebug>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_DoPerCharacterTypeAnimItems;
    /// <summary>
    /// Function: DoPerCharacterTypeAnimItems
    /// </summary>
    public unsafe virtual void DoPerCharacterTypeAnimItems(out BmSDK.BmGame.RPersistentDebugData.FPerCharacterTypeAnimDebug Options, BmSDK.FString CharacterName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoPerCharacterTypeAnimItems, "BmGame.RDebugMenuContent.DoPerCharacterTypeAnimItems");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterName, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Options = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentDebugData.FPerCharacterTypeAnimDebug>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RDebugMenuContent.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: EPopulationType
    /// </summary>
    public enum EPopulationType : byte
    {
        POPTYPE_All = 0,
        POPTYPE_Vehicles = 1,
        POPTYPE_Formations = 2,
        POPTYPE_Riots = 3,
        POPTYPE_MAX = 4,
    }

    /// <summary>
    /// ObjectProperty: GameInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo GameInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ComponentProperty: DebrisMaxHeightStaticMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent DebrisMaxHeightStaticMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// ComponentProperty: AudioComponent
    /// </summary>
    public unsafe BmSDK.Engine.AudioComponent AudioComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AudioComponent>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: ConsoleEventsOpen
    /// </summary>
    public unsafe bool ConsoleEventsOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bStatUnit
    /// </summary>
    public unsafe bool bStatUnit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bEnableSharedCapeOptions
    /// </summary>
    public unsafe bool bEnableSharedCapeOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: RopeOptions
    /// </summary>
    public unsafe bool RopeOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: PhysicsOptions
    /// </summary>
    public unsafe bool PhysicsOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: DepthBiasOptions
    /// </summary>
    public unsafe bool DepthBiasOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: OceanBuoyancyOptions
    /// </summary>
    public unsafe bool OceanBuoyancyOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bDebrisMaxHeightStaticMeshComponentAttached
    /// </summary>
    public unsafe bool bDebrisMaxHeightStaticMeshComponentAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bShowCurrentDistrictScenarios
    /// </summary>
    public unsafe bool bShowCurrentDistrictScenarios
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// ArrayProperty: ConsoleEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ConsoleEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: ConsoleEventDescs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ConsoleEventDescs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// IntProperty: ConsoleEventIndex
    /// </summary>
    public unsafe int ConsoleEventIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ArrayProperty: LevelStreamingTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LevelStreamingTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// IntProperty: AngleAudioComponent
    /// </summary>
    public unsafe int AngleAudioComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// IntProperty: LevelStreamingOptions
    /// </summary>
    public unsafe int LevelStreamingOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// IntProperty: CurrDebugCapeStateChangeSetting
    /// </summary>
    public unsafe int CurrDebugCapeStateChangeSetting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// IntProperty: VehEncounterType
    /// </summary>
    public unsafe int VehEncounterType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// IntProperty: PrevDrawDestructiblesMode
    /// </summary>
    public unsafe int PrevDrawDestructiblesMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// ArrayProperty: CachedPopulationActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceObject> CachedPopulationActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceObject>>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ArrayProperty: PopulationTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PopulationTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// IntProperty: PopTypeIdx
    /// </summary>
    public unsafe int PopTypeIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// FloatProperty: PopulationWarmUpTime
    /// </summary>
    public unsafe float PopulationWarmUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }
}
