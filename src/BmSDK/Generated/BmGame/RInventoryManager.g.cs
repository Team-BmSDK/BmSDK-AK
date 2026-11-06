#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RInventoryManager<br/>
/// (size = 912)
/// (flags = 144703634)
/// </summary>
public partial class RInventoryManager : BmSDK.Engine.InventoryManager, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RInventoryManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RInventoryManager.
    /// </summary>
    public static RInventoryManager DefaultObject => (RInventoryManager)StaticClass().DefaultObject;

    internal RInventoryManager() { }

    /// <summary>
    /// Constructs a new RInventoryManager
    /// </summary>
    public RInventoryManager(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInventoryManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnLevelChange;
    /// <summary>
    /// Function: OnLevelChange
    /// </summary>
    public unsafe virtual void OnLevelChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLevelChange, "BmGame.RInventoryManager.OnLevelChange");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRoomChange;
    /// <summary>
    /// Function: OnRoomChange
    /// </summary>
    public unsafe virtual void OnRoomChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRoomChange, "BmGame.RInventoryManager.OnRoomChange");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnequipAllGadgets;
    /// <summary>
    /// Function: UnequipAllGadgets
    /// </summary>
    public unsafe virtual void UnequipAllGadgets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnequipAllGadgets, "BmGame.RInventoryManager.UnequipAllGadgets");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGadgetButtonIcon;
    /// <summary>
    /// Function: GetGadgetButtonIcon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHUDPrompt.EControlIcon GetGadgetButtonIcon(BmSDK.Class GadgetClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetButtonIcon, "BmGame.RInventoryManager.GetGadgetButtonIcon");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TryToSelectBatarang;
    /// <summary>
    /// Function: TryToSelectBatarang
    /// </summary>
    public unsafe virtual void TryToSelectBatarang()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToSelectBatarang, "BmGame.RInventoryManager.TryToSelectBatarang");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetCancelled;
    /// <summary>
    /// Function: GadgetCancelled
    /// </summary>
    public unsafe virtual void GadgetCancelled(bool ResetGadget = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetCancelled, "BmGame.RInventoryManager.GadgetCancelled");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResetGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNextGadgetInDirection;
    /// <summary>
    /// Function: GetNextGadgetInDirection
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RInventoryGadget GetNextGadgetInDirection(BmSDK.BmGame.RInventoryManager.GadgetSelectionDirection Dir, bool bBatarangButton, out int gadgetIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextGadgetInDirection, "BmGame.RInventoryManager.GetNextGadgetInDirection");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBatarangButton, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out gadgetIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(gadgetIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        gadgetIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SelectGadgetDirection;
    /// <summary>
    /// Function: SelectGadgetDirection
    /// </summary>
    public unsafe virtual void SelectGadgetDirection(BmSDK.BmGame.RInventoryManager.GadgetSelectionDirection Dir, bool bBatarangButton)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectGadgetDirection, "BmGame.RInventoryManager.SelectGadgetDirection");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBatarangButton, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugUpgradeEquipment;
    /// <summary>
    /// Function: DebugUpgradeEquipment
    /// </summary>
    public unsafe virtual void DebugUpgradeEquipment()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugUpgradeEquipment, "BmGame.RInventoryManager.DebugUpgradeEquipment");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RestockAmmo;
    /// <summary>
    /// Function: RestockAmmo
    /// </summary>
    public unsafe virtual void RestockAmmo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestockAmmo, "BmGame.RInventoryManager.RestockAmmo");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Set1stPerson;
    /// <summary>
    /// Function: Set1stPerson
    /// </summary>
    public unsafe virtual void Set1stPerson(bool bHideMeshes)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Set1stPerson, "BmGame.RInventoryManager.Set1stPerson");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHideMeshes, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentGadgetByName;
    /// <summary>
    /// Function: SetCurrentGadgetByName
    /// </summary>
    public unsafe virtual bool SetCurrentGadgetByName(BmSDK.FName SelectedGadgetClass, bool NotifyController = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentGadgetByName, "BmGame.RInventoryManager.SetCurrentGadgetByName");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SelectedGadgetClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyController, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetForQuickGadget;
    /// <summary>
    /// Function: SetForQuickGadget
    /// </summary>
    public unsafe virtual bool SetForQuickGadget(BmSDK.BmGame.RInventoryGadget QuickGadget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetForQuickGadget, "BmGame.RInventoryManager.SetForQuickGadget");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QuickGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetGadgetByName;
    /// <summary>
    /// Function: GetGadgetByName
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RInventoryGadget GetGadgetByName(BmSDK.FName SelectedGadgetClass, bool AllowSubClasses = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetByName, "BmGame.RInventoryManager.GetGadgetByName");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SelectedGadgetClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowSubClasses, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetCurrentGadget;
    /// <summary>
    /// Function: SetCurrentGadget
    /// </summary>
    public unsafe virtual bool SetCurrentGadget(BmSDK.BmGame.RInventoryGadget Gadget, bool NotifyController = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentGadget, "BmGame.RInventoryManager.SetCurrentGadget");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gadget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyController, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetGadgetName;
    /// <summary>
    /// Function: GetGadgetName
    /// </summary>
    public unsafe virtual BmSDK.FName GetGadgetName(int gadget_index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetName, "BmGame.RInventoryManager.GetGadgetName");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(gadget_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OwnerDied;
    /// <summary>
    /// Function: OwnerDied
    /// </summary>
    public unsafe override void OwnerDied()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OwnerDied, "BmGame.RInventoryManager.OwnerDied");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddInventory;
    /// <summary>
    /// Function: AddInventory
    /// </summary>
    public unsafe override bool AddInventory(BmSDK.Engine.Inventory NewItem, bool bDoNotActivate = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddInventory, "BmGame.RInventoryManager.AddInventory");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewItem, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoNotActivate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_DiscardInventory;
    /// <summary>
    /// Function: DiscardInventory
    /// </summary>
    public unsafe override void DiscardInventory()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DiscardInventory, "BmGame.RInventoryManager.DiscardInventory");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FGadgetDirection
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FGadgetDirection
    {
        /// <summary>
        /// ArrayProperty: SelectableGadgets
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> SelectableGadgets
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: GadgetSelectionDirection
    /// </summary>
    public enum GadgetSelectionDirection : byte
    {
        GSD_Up = 0,
        GSD_Down = 1,
        GSD_Left = 2,
        GSD_Right = 3,
        GSD_NoGadgetSelected = 4,
        GSD_MAX = 5,
    }

    /// <summary>
    /// ObjectProperty: CurrentGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget CurrentGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: PrevGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget PrevGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: DisplayedGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget DisplayedGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// IntProperty: DeviceRequestedIndex
    /// </summary>
    public unsafe int DeviceRequestedIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// IntProperty: SelectableGadgetCount
    /// </summary>
    public unsafe int SelectableGadgetCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: AvailableGadgets
    /// </summary>
    public InlineArray<BmSDK.BmGame.RInventoryManager.FGadgetDirection> AvailableGadgets => new(4, Ptr + 744, 16, this);

    /// <summary>
    /// StructProperty: AvailableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryManager.FGadgetDirection AvailableGadgets_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryManager.FGadgetDirection>(Ptr + 744);
    /// <summary>
    /// StructProperty: AvailableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryManager.FGadgetDirection AvailableGadgets_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryManager.FGadgetDirection>(Ptr + 760);
    /// <summary>
    /// StructProperty: AvailableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryManager.FGadgetDirection AvailableGadgets_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryManager.FGadgetDirection>(Ptr + 776);
    /// <summary>
    /// StructProperty: AvailableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryManager.FGadgetDirection AvailableGadgets_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryManager.FGadgetDirection>(Ptr + 792);

    /// <summary>
    /// InlineArray{StructProperty}: BatarangGadgets
    /// </summary>
    public InlineArray<BmSDK.BmGame.RInventoryManager.FGadgetDirection> BatarangGadgets => new(4, Ptr + 808, 16, this);

    /// <summary>
    /// StructProperty: BatarangGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryManager.FGadgetDirection BatarangGadgets_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryManager.FGadgetDirection>(Ptr + 808);
    /// <summary>
    /// StructProperty: BatarangGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryManager.FGadgetDirection BatarangGadgets_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryManager.FGadgetDirection>(Ptr + 824);
    /// <summary>
    /// StructProperty: BatarangGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryManager.FGadgetDirection BatarangGadgets_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryManager.FGadgetDirection>(Ptr + 840);
    /// <summary>
    /// StructProperty: BatarangGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryManager.FGadgetDirection BatarangGadgets_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryManager.FGadgetDirection>(Ptr + 856);

    /// <summary>
    /// ByteProperty: CurrentGadgetDir
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryManager.GadgetSelectionDirection CurrentGadgetDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryManager.GadgetSelectionDirection>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ByteProperty: GadgetSelectSkin
    /// </summary>
    public unsafe byte GadgetSelectSkin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 873); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 873); }
    }

    /// <summary>
    /// IntProperty: CurrentGadgetIndex
    /// </summary>
    public unsafe int CurrentGadgetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ArrayProperty: BM2SelectableGadgets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BM2SelectableGadgets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// ArrayProperty: PCSelectableGadgets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> PCSelectableGadgets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }
}
