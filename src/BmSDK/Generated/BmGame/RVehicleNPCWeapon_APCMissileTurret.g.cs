#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleNPCWeapon_APCMissileTurret<br/>
/// (size = 784)
/// (flags = 144703634)
/// </summary>
public partial class RVehicleNPCWeapon_APCMissileTurret : BmSDK.BmGame.RVehicleNPCWeapon, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleNPCWeapon_APCMissileTurret", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RVehicleNPCWeapon_APCMissileTurret.
    /// </summary>
    public static RVehicleNPCWeapon_APCMissileTurret DefaultObject => (RVehicleNPCWeapon_APCMissileTurret)StaticClass().DefaultObject;

    internal RVehicleNPCWeapon_APCMissileTurret() { }

    /// <summary>
    /// Constructs a new RVehicleNPCWeapon_APCMissileTurret
    /// </summary>
    public RVehicleNPCWeapon_APCMissileTurret(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleNPCWeapon_APCMissileTurret(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCWeapon_APCMissileTurret>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCWeapon_APCMissileTurret>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCWeapon_APCMissileTurret>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCWeapon_APCMissileTurret>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCWeapon_APCMissileTurret>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCWeapon_APCMissileTurret>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCWeapon_APCMissileTurret>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCWeapon_APCMissileTurret>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CanDisableTick;
    /// <summary>
    /// Function: CanDisableTick
    /// </summary>
    public unsafe override bool CanDisableTick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDisableTick, "BmGame.RVehicleNPCWeapon_APCMissileTurret.CanDisableTick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_WeaponHit;
    /// <summary>
    /// Function: WeaponHit
    /// </summary>
    public unsafe override void WeaponHit(BmSDK.Engine.Actor ImpactedActor, BmSDK.BmGame.RBasicProjectile Proj)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponHit, "BmGame.RVehicleNPCWeapon_APCMissileTurret.WeaponHit");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactedActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proj, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanShootTarget;
    /// <summary>
    /// Function: CanShootTarget
    /// </summary>
    public unsafe override bool CanShootTarget(BmSDK.Engine.Actor Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanShootTarget, "BmGame.RVehicleNPCWeapon_APCMissileTurret.CanShootTarget");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CancelAttack;
    /// <summary>
    /// Function: CancelAttack
    /// </summary>
    public unsafe override void CancelAttack(bool DueToBeingRammed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelAttack, "BmGame.RVehicleNPCWeapon_APCMissileTurret.CancelAttack");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DueToBeingRammed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopAttack;
    /// <summary>
    /// Function: StopAttack
    /// </summary>
    public unsafe override void StopAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAttack, "BmGame.RVehicleNPCWeapon_APCMissileTurret.StopAttack");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Fire;
    /// <summary>
    /// Function: Fire
    /// </summary>
    public unsafe virtual bool Fire(bool DoNoDamage = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Fire, "BmGame.RVehicleNPCWeapon_APCMissileTurret.Fire");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DoNoDamage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FireSoon;
    /// <summary>
    /// Function: FireSoon
    /// </summary>
    public unsafe virtual void FireSoon(float WarningTime = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireSoon, "BmGame.RVehicleNPCWeapon_APCMissileTurret.FireSoon");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WarningTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsFiring;
    /// <summary>
    /// Function: IsFiring
    /// </summary>
    public unsafe override bool IsFiring()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFiring, "BmGame.RVehicleNPCWeapon_APCMissileTurret.IsFiring");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RVehicleNPCWeapon_APCMissileTurret.Tick");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAttack;
    /// <summary>
    /// Function: StartAttack
    /// </summary>
    public unsafe override bool StartAttack(BmSDK.Engine.Actor Target, float WarningTime, System.Numerics.Vector3 AttackLoc = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAttack, "BmGame.RVehicleNPCWeapon_APCMissileTurret.StartAttack");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WarningTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackLoc, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CreateAimingPoseConfig;
    /// <summary>
    /// Function: CreateAimingPoseConfig
    /// </summary>
    public unsafe virtual bool CreateAimingPoseConfig(BmSDK.BmGame.RBMPawnAI Pawn, BmSDK.Engine.AnimSet Anims)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateAimingPoseConfig, "BmGame.RVehicleNPCWeapon_APCMissileTurret.CreateAimingPoseConfig");
        byte* paramsPtr = stackalloc byte[456];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anims, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(int PassengerIndex, BmSDK.BmGame.RVehicleNPC NewOwner)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RVehicleNPCWeapon_APCMissileTurret.Init");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PassengerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: Range
    /// </summary>
    public unsafe float Range
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: ProjectileLifespan
    /// </summary>
    public unsafe float ProjectileLifespan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// IntProperty: SeatIndex
    /// </summary>
    public unsafe int SeatIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: FireTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor FireTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: FireMuzzleFlash
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem FireMuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: FireEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// StructProperty: FireDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FireDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 732);

    /// <summary>
    /// StructProperty: FireTargetLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FireTargetLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 744);

    /// <summary>
    /// StructProperty: FireTargetDiff
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FireTargetDiff
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 756);

    /// <summary>
    /// StructProperty: FireTargetVel
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FireTargetVel
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 768);

    /// <summary>
    /// FloatProperty: FireTargetLag
    /// </summary>
    public unsafe float FireTargetLag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }
}
