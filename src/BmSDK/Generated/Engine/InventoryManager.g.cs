#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InventoryManager<br/>
/// (size = 712)
/// (flags = 144703634)
/// </summary>
public partial class InventoryManager : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InventoryManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as InventoryManager.
    /// </summary>
    public static InventoryManager DefaultObject => (InventoryManager)StaticClass().DefaultObject;

    internal InventoryManager() { }

    /// <summary>
    /// Constructs a new InventoryManager
    /// </summary>
    public InventoryManager(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InventoryManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<InventoryManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<InventoryManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<InventoryManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<InventoryManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<InventoryManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<InventoryManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<InventoryManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<InventoryManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UpdateController;
    /// <summary>
    /// Function: UpdateController
    /// </summary>
    public unsafe virtual void UpdateController()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateController, "Engine.InventoryManager.UpdateController");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientWeaponSet;
    /// <summary>
    /// Function: ClientWeaponSet
    /// </summary>
    public unsafe virtual void ClientWeaponSet(BmSDK.Engine.Weapon NewWeapon, bool bOptionalSet, bool bDoNotActivate = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientWeaponSet, "Engine.InventoryManager.ClientWeaponSet");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOptionalSet, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoNotActivate, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangedWeapon;
    /// <summary>
    /// Function: ChangedWeapon
    /// </summary>
    public unsafe virtual void ChangedWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangedWeapon, "Engine.InventoryManager.ChangedWeapon");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearPendingWeapon;
    /// <summary>
    /// Function: ClearPendingWeapon
    /// </summary>
    public unsafe virtual void ClearPendingWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPendingWeapon, "Engine.InventoryManager.ClearPendingWeapon");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelWeaponChange;
    /// <summary>
    /// Function: CancelWeaponChange
    /// </summary>
    public unsafe virtual bool CancelWeaponChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelWeaponChange, "Engine.InventoryManager.CancelWeaponChange");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetPendingWeapon;
    /// <summary>
    /// Function: SetPendingWeapon
    /// </summary>
    public unsafe virtual void SetPendingWeapon(BmSDK.Engine.Weapon DesiredWeapon, BmSDK.FName MovementStance, BmSDK.FName WeaponStance)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPendingWeapon, "Engine.InventoryManager.SetPendingWeapon");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InternalSetCurrentWeapon;
    /// <summary>
    /// Function: InternalSetCurrentWeapon
    /// </summary>
    public unsafe void InternalSetCurrentWeapon(BmSDK.Engine.Weapon DesiredWeapon, BmSDK.FName MovementStance = default, BmSDK.FName WeaponStance = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InternalSetCurrentWeapon, "Engine.InventoryManager.InternalSetCurrentWeapon");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerSetCurrentWeapon;
    /// <summary>
    /// Function: ServerSetCurrentWeapon
    /// </summary>
    public unsafe virtual void ServerSetCurrentWeapon(BmSDK.Engine.Weapon DesiredWeapon, BmSDK.FName MovementStance = default, BmSDK.FName WeaponStance = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSetCurrentWeapon, "Engine.InventoryManager.ServerSetCurrentWeapon");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentWeapon;
    /// <summary>
    /// Function: SetCurrentWeapon
    /// </summary>
    public unsafe virtual void SetCurrentWeapon(BmSDK.Engine.Weapon DesiredWeapon, BmSDK.FName MovementStance = default, BmSDK.FName WeaponStance = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentWeapon, "Engine.InventoryManager.SetCurrentWeapon");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NextWeapon;
    /// <summary>
    /// Function: NextWeapon
    /// </summary>
    public unsafe virtual void NextWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NextWeapon, "Engine.InventoryManager.NextWeapon");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrevWeapon;
    /// <summary>
    /// Function: PrevWeapon
    /// </summary>
    public unsafe virtual void PrevWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrevWeapon, "Engine.InventoryManager.PrevWeapon");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchToBestWeapon;
    /// <summary>
    /// Function: SwitchToBestWeapon
    /// </summary>
    public unsafe virtual void SwitchToBestWeapon(bool bForceADifferentWeapon = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchToBestWeapon, "Engine.InventoryManager.SwitchToBestWeapon");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceADifferentWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBestWeapon;
    /// <summary>
    /// Function: GetBestWeapon
    /// </summary>
    public unsafe virtual BmSDK.Engine.Weapon GetBestWeapon(bool bForceADifferentWeapon = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestWeapon, "Engine.InventoryManager.GetBestWeapon");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceADifferentWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Weapon>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetWeaponRatingFor;
    /// <summary>
    /// Function: GetWeaponRatingFor
    /// </summary>
    public unsafe virtual float GetWeaponRatingFor(BmSDK.Engine.Weapon W)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponRatingFor, "Engine.InventoryManager.GetWeaponRatingFor");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(W, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe virtual void DrawHUD(BmSDK.Engine.HUD H)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "Engine.InventoryManager.DrawHUD");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OwnerDied;
    /// <summary>
    /// Function: OwnerDied
    /// </summary>
    public unsafe virtual void OwnerDied()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OwnerDied, "Engine.InventoryManager.OwnerDied");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DiscardInventory;
    /// <summary>
    /// Function: DiscardInventory
    /// </summary>
    public unsafe virtual void DiscardInventory()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DiscardInventory, "Engine.InventoryManager.DiscardInventory");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveFromInventory;
    /// <summary>
    /// Function: RemoveFromInventory
    /// </summary>
    public unsafe virtual void RemoveFromInventory(BmSDK.Engine.Inventory ItemToRemove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveFromInventory, "Engine.InventoryManager.RemoveFromInventory");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemToRemove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddInventory;
    /// <summary>
    /// Function: AddInventory
    /// </summary>
    public unsafe virtual bool AddInventory(BmSDK.Engine.Inventory NewItem, bool bDoNotActivate = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddInventory, "Engine.InventoryManager.AddInventory");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewItem, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoNotActivate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CreateInventory;
    /// <summary>
    /// Function: CreateInventory
    /// </summary>
    public unsafe virtual BmSDK.Engine.Inventory CreateInventory(BmSDK.Class NewInventoryItemClass, bool bDoNotActivate = default, BmSDK.Engine.Actor NewArchetype = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateInventory, "Engine.InventoryManager.CreateInventory");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewInventoryItemClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoNotActivate, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewArchetype, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Inventory>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_FindInventoryType;
    /// <summary>
    /// Function: FindInventoryType
    /// </summary>
    public unsafe virtual BmSDK.Engine.Inventory FindInventoryType(BmSDK.Class DesiredClass, bool bAllowSubclass = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindInventoryType, "Engine.InventoryManager.FindInventoryType");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowSubclass, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Inventory>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_HandlePickupQuery;
    /// <summary>
    /// Function: HandlePickupQuery
    /// </summary>
    public unsafe virtual bool HandlePickupQuery(BmSDK.Class ItemClass, BmSDK.Engine.Actor Pickup)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandlePickupQuery, "Engine.InventoryManager.HandlePickupQuery");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pickup, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "Engine.InventoryManager.Destroyed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupFor;
    /// <summary>
    /// Function: SetupFor
    /// </summary>
    public unsafe virtual void SetupFor(BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupFor, "Engine.InventoryManager.SetupFor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearAllPendingFire;
    /// <summary>
    /// Function: ClearAllPendingFire
    /// </summary>
    public unsafe virtual void ClearAllPendingFire(BmSDK.Engine.Weapon InWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAllPendingFire, "Engine.InventoryManager.ClearAllPendingFire");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPendingFire;
    /// <summary>
    /// Function: IsPendingFire
    /// </summary>
    public unsafe virtual bool IsPendingFire(BmSDK.Engine.Weapon InWeapon, int InFiringMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPendingFire, "Engine.InventoryManager.IsPendingFire");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFiringMode, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClearPendingFire;
    /// <summary>
    /// Function: ClearPendingFire
    /// </summary>
    public unsafe virtual void ClearPendingFire(BmSDK.Engine.Weapon InWeapon, int InFiringMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPendingFire, "Engine.InventoryManager.ClearPendingFire");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFiringMode, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPendingFire;
    /// <summary>
    /// Function: SetPendingFire
    /// </summary>
    public unsafe virtual void SetPendingFire(BmSDK.Engine.Weapon InWeapon, int InFiringMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPendingFire, "Engine.InventoryManager.SetPendingFire");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFiringMode, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPendingFireLength;
    /// <summary>
    /// Function: GetPendingFireLength
    /// </summary>
    public unsafe virtual int GetPendingFireLength(BmSDK.Engine.Weapon InWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPendingFireLength, "Engine.InventoryManager.GetPendingFireLength");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "Engine.InventoryManager.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: InventoryChain
    /// </summary>
    public unsafe BmSDK.Engine.Inventory InventoryChain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Inventory>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: PendingWeapon
    /// </summary>
    public unsafe BmSDK.Engine.Weapon PendingWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Weapon>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: LastAttemptedSwitchToWeapon
    /// </summary>
    public unsafe BmSDK.Engine.Weapon LastAttemptedSwitchToWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Weapon>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// BoolProperty: bMustHoldWeapon
    /// </summary>
    public unsafe bool bMustHoldWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// ArrayProperty: PendingFire
    /// </summary>
    public unsafe BmSDK.TArray<int> PendingFire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }
}
