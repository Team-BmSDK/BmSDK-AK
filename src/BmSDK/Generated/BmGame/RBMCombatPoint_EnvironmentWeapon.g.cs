#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RBMCombatPoint_EnvironmentWeapon<br/>
/// (size = 808)
/// (flags = 144704147)
/// </summary>
public partial class RBMCombatPoint_EnvironmentWeapon : BmSDK.BmGame.RBMCombatPoint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMCombatPoint_EnvironmentWeapon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMCombatPoint_EnvironmentWeapon.
    /// </summary>
    public static RBMCombatPoint_EnvironmentWeapon DefaultObject => (RBMCombatPoint_EnvironmentWeapon)StaticClass().DefaultObject;

    internal RBMCombatPoint_EnvironmentWeapon() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMCombatPoint_EnvironmentWeapon(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_EnvironmentWeapon>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_EnvironmentWeapon>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_EnvironmentWeapon>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_EnvironmentWeapon>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_EnvironmentWeapon>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_EnvironmentWeapon>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_EnvironmentWeapon>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_EnvironmentWeapon>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UnhideAfterDestroy;
    /// <summary>
    /// Function: UnhideAfterDestroy
    /// </summary>
    public unsafe virtual void UnhideAfterDestroy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnhideAfterDestroy, "BmGame.RBMCombatPoint_EnvironmentWeapon.UnhideAfterDestroy");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideOnDestroy;
    /// <summary>
    /// Function: HideOnDestroy
    /// </summary>
    public unsafe virtual void HideOnDestroy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideOnDestroy, "BmGame.RBMCombatPoint_EnvironmentWeapon.HideOnDestroy");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyedByImpact;
    /// <summary>
    /// Function: DestroyedByImpact
    /// </summary>
    public unsafe virtual void DestroyedByImpact(BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 TotalNormalForceVector)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyedByImpact, "BmGame.RBMCombatPoint_EnvironmentWeapon.DestroyedByImpact");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalNormalForceVector, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CallDestroyedByImpact;
    /// <summary>
    /// Function: CallDestroyedByImpact
    /// </summary>
    public unsafe virtual void CallDestroyedByImpact()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CallDestroyedByImpact, "BmGame.RBMCombatPoint_EnvironmentWeapon.CallDestroyedByImpact");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RigidBodyCollisionDetected;
    /// <summary>
    /// Function: RigidBodyCollisionDetected
    /// </summary>
    public unsafe virtual void RigidBodyCollisionDetected(BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 TotalNormalForceVector)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RigidBodyCollisionDetected, "BmGame.RBMCombatPoint_EnvironmentWeapon.RigidBodyCollisionDetected");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalNormalForceVector, paramsPtr + 8);
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

    private static BmSDK.Function __fn_WeaponRemoved;
    /// <summary>
    /// Function: WeaponRemoved
    /// </summary>
    public unsafe virtual void WeaponRemoved(BmSDK.BmGame.RBMWeapon SpawnedWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponRemoved, "BmGame.RBMCombatPoint_EnvironmentWeapon.WeaponRemoved");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnedWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponRemovalFX;
    /// <summary>
    /// Function: WeaponRemovalFX
    /// </summary>
    public unsafe virtual void WeaponRemovalFX(BmSDK.BmGame.RBMWeapon SpawnedWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponRemovalFX, "BmGame.RBMCombatPoint_EnvironmentWeapon.WeaponRemovalFX");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnedWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponDetached;
    /// <summary>
    /// Function: WeaponDetached
    /// </summary>
    public unsafe virtual void WeaponDetached()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponDetached, "BmGame.RBMCombatPoint_EnvironmentWeapon.WeaponDetached");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UsedByPawn;
    /// <summary>
    /// Function: UsedByPawn
    /// </summary>
    public unsafe override void UsedByPawn(BmSDK.BmGame.RPawnCombat NewUser, BmSDK.Engine.Actor NewTarget = default, bool bUsedDuringTaunt = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UsedByPawn, "BmGame.RBMCombatPoint_EnvironmentWeapon.UsedByPawn");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUser, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUsedDuringTaunt, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAnimInfo_AimAtLocation;
    /// <summary>
    /// Function: GetAnimInfo_AimAtLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAnimInfo_AimAtLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimInfo_AimAtLocation, "BmGame.RBMCombatPoint_EnvironmentWeapon.GetAnimInfo_AimAtLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnimInfo_MoveToLocation;
    /// <summary>
    /// Function: GetAnimInfo_MoveToLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAnimInfo_MoveToLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimInfo_MoveToLocation, "BmGame.RBMCombatPoint_EnvironmentWeapon.GetAnimInfo_MoveToLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnimInfo_Yaw;
    /// <summary>
    /// Function: GetAnimInfo_Yaw
    /// </summary>
    public unsafe virtual float GetAnimInfo_Yaw()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimInfo_Yaw, "BmGame.RBMCombatPoint_EnvironmentWeapon.GetAnimInfo_Yaw");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnimInfo_Location;
    /// <summary>
    /// Function: GetAnimInfo_Location
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAnimInfo_Location()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimInfo_Location, "BmGame.RBMCombatPoint_EnvironmentWeapon.GetAnimInfo_Location");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnimInfo_Animset;
    /// <summary>
    /// Function: GetAnimInfo_Animset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetAnimInfo_Animset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimInfo_Animset, "BmGame.RBMCombatPoint_EnvironmentWeapon.GetAnimInfo_Animset");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnimInfo_Name;
    /// <summary>
    /// Function: GetAnimInfo_Name
    /// </summary>
    public unsafe virtual BmSDK.FName GetAnimInfo_Name()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimInfo_Name, "BmGame.RBMCombatPoint_EnvironmentWeapon.GetAnimInfo_Name");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeUsedByPawn;
    /// <summary>
    /// Function: CanBeUsedByPawn
    /// </summary>
    public unsafe override bool CanBeUsedByPawn(BmSDK.BmGame.RPawnCombat NewUser, BmSDK.Engine.Actor TargetActor, bool bTaunting)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeUsedByPawn, "BmGame.RBMCombatPoint_EnvironmentWeapon.CanBeUsedByPawn");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUser, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetActor, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTaunting, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RBMCombatPoint_EnvironmentWeapon.Destroyed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RBMCombatPoint_EnvironmentWeapon.PreStreamOut");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RBMCombatPoint_EnvironmentWeapon.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitByGel;
    /// <summary>
    /// Function: HitByGel
    /// </summary>
    public unsafe virtual void HitByGel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByGel, "BmGame.RBMCombatPoint_EnvironmentWeapon.HitByGel");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelWeaponLoading;
    /// <summary>
    /// Function: CancelWeaponLoading
    /// </summary>
    public unsafe virtual void CancelWeaponLoading()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelWeaponLoading, "BmGame.RBMCombatPoint_EnvironmentWeapon.CancelWeaponLoading");
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

    private static BmSDK.Function __fn_LoadWeapon;
    /// <summary>
    /// Function: LoadWeapon
    /// </summary>
    public unsafe virtual bool LoadWeapon(BmSDK.FString WeaponPackageString)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadWeapon, "BmGame.RBMCombatPoint_EnvironmentWeapon.LoadWeapon");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponPackageString, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// BoolProperty: bWaitingForWeaponLoad
    /// </summary>
    public unsafe bool bWaitingForWeaponLoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bDestroyedByRigidBodyCollision
    /// </summary>
    public unsafe bool bDestroyedByRigidBodyCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bOneShot
    /// </summary>
    public unsafe bool bOneShot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bDestroyOnPickup
    /// </summary>
    public unsafe bool bDestroyOnPickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bHiddenOnDestroy
    /// </summary>
    public unsafe bool bHiddenOnDestroy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bNewGamePlusOnly
    /// </summary>
    public unsafe bool bNewGamePlusOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bUseSaveFlag
    /// </summary>
    public unsafe bool bUseSaveFlag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// StrProperty: WeaponPackage
    /// </summary>
    public unsafe BmSDK.FString WeaponPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// StrProperty: LoadingWeaponPackage
    /// </summary>
    public unsafe BmSDK.FString LoadingWeaponPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: LoadedWeaponRefHolder
    /// </summary>
    public unsafe BmSDK.BmGame.RCharacterBioCue LoadedWeaponRefHolder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterBioCue>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: StoredCollisionInstigator
    /// </summary>
    public unsafe BmSDK.Engine.Controller StoredCollisionInstigator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Controller>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: PickupAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PickupAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ClassProperty: WeaponClass
    /// </summary>
    public unsafe BmSDK.Class WeaponClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ComponentProperty: WeaponSkeletalMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent WeaponSkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ComponentProperty: WeaponStaticMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent WeaponStaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// StructProperty: StoredCollisionForce
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StoredCollisionForce
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 788);

    /// <summary>
    /// NameProperty: PickupAnimName
    /// </summary>
    public unsafe BmSDK.FName PickupAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }
}
