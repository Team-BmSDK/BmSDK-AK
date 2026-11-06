#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBatmobileHeavyCannon<br/>
/// (size = 2865)
/// (flags = 144703666)
/// </summary>
public partial class RBatmobileHeavyCannon : BmSDK.BmGame.RVehicleWeapon, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBatmobileHeavyCannon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBatmobileHeavyCannon.
    /// </summary>
    public static RBatmobileHeavyCannon DefaultObject => (RBatmobileHeavyCannon)StaticClass().DefaultObject;

    internal RBatmobileHeavyCannon() { }

    /// <summary>
    /// Constructs a new RBatmobileHeavyCannon
    /// </summary>
    public RBatmobileHeavyCannon(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatmobileHeavyCannon(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileHeavyCannon>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileHeavyCannon>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileHeavyCannon>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileHeavyCannon>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileHeavyCannon>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileHeavyCannon>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileHeavyCannon>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileHeavyCannon>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetAdditionalHelpPrompt;
    /// <summary>
    /// Function: GetAdditionalHelpPrompt
    /// </summary>
    public unsafe override void GetAdditionalHelpPrompt(BmSDK.BmGame.RHUDPrompt HUDPrompt)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAdditionalHelpPrompt, "BmGame.RBatmobileHeavyCannon.GetAdditionalHelpPrompt");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HUDPrompt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetNoiseEvent;
    /// <summary>
    /// Function: GadgetNoiseEvent
    /// </summary>
    public unsafe virtual void GadgetNoiseEvent(System.Numerics.Vector3 Loc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetNoiseEvent, "BmGame.RBatmobileHeavyCannon.GadgetNoiseEvent");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProjectileExploded;
    /// <summary>
    /// Function: ProjectileExploded
    /// </summary>
    public unsafe override void ProjectileExploded(BmSDK.BmGame.RProjectile Projectile, System.Numerics.Vector3 ImpactLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProjectileExploded, "BmGame.RBatmobileHeavyCannon.ProjectileExploded");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Projectile, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForUpgrades;
    /// <summary>
    /// Function: CheckForUpgrades
    /// </summary>
    public unsafe override void CheckForUpgrades(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForUpgrades, "BmGame.RBatmobileHeavyCannon.CheckForUpgrades");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForHit;
    /// <summary>
    /// Function: CheckForHit
    /// </summary>
    public unsafe virtual void CheckForHit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForHit, "BmGame.RBatmobileHeavyCannon.CheckForHit");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireNow;
    /// <summary>
    /// Function: FireNow
    /// </summary>
    public unsafe override bool FireNow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireNow, "BmGame.RBatmobileHeavyCannon.FireNow");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopCameraShake;
    /// <summary>
    /// Function: StopCameraShake
    /// </summary>
    public unsafe virtual void StopCameraShake()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopCameraShake, "BmGame.RBatmobileHeavyCannon.StopCameraShake");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckAutoTarget;
    /// <summary>
    /// Function: CheckAutoTarget
    /// </summary>
    public unsafe override bool CheckAutoTarget(BmSDK.Engine.Actor Target, out System.Numerics.Vector3 TargetPosition, out float OverridePriority, out float OverrideMaxRange, out byte DoLOSCheck)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAutoTarget, "BmGame.RBatmobileHeavyCannon.CheckAutoTarget");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TargetPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPosition, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OverridePriority);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridePriority, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OverrideMaxRange);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaxRange, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DoLOSCheck);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DoLOSCheck, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TargetPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        OverridePriority = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
        OverrideMaxRange = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        DoLOSCheck = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetGunLocation;
    /// <summary>
    /// Function: GetGunLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGunLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGunLocation, "BmGame.RBatmobileHeavyCannon.GetGunLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCannonTargetLocation;
    /// <summary>
    /// Function: GetCannonTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetCannonTargetLocation(BmSDK.Engine.Actor TargetActor, out int InSight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCannonTargetLocation, "BmGame.RBatmobileHeavyCannon.GetCannonTargetLocation");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetActor, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InSight);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSight, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        InSight = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PlayHeavyCannonRumble;
    /// <summary>
    /// Function: PlayHeavyCannonRumble
    /// </summary>
    public unsafe virtual void PlayHeavyCannonRumble()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHeavyCannonRumble, "BmGame.RBatmobileHeavyCannon.PlayHeavyCannonRumble");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ModifyCannonImpulse;
    /// <summary>
    /// Function: ModifyCannonImpulse
    /// </summary>
    public unsafe virtual void ModifyCannonImpulse(BmSDK.Rotator InRotation, out System.Numerics.Vector3 ImpulseDirection, out System.Numerics.Vector3 ImpulseLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyCannonImpulse, "BmGame.RBatmobileHeavyCannon.ModifyCannonImpulse");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InRotation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ImpulseDirection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpulseDirection, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ImpulseLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpulseLocation, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ImpulseDirection = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        ImpulseLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_WeaponHit;
    /// <summary>
    /// Function: WeaponHit
    /// </summary>
    public unsafe override void WeaponHit(bool bKill)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponHit, "BmGame.RBatmobileHeavyCannon.WeaponHit");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKill, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireWeapon;
    /// <summary>
    /// Function: FireWeapon
    /// </summary>
    public unsafe override bool FireWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireWeapon, "BmGame.RBatmobileHeavyCannon.FireWeapon");
        byte* paramsPtr = stackalloc byte[224];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckForInvalidTarget;
    /// <summary>
    /// Function: CheckForInvalidTarget
    /// </summary>
    public unsafe override bool CheckForInvalidTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForInvalidTarget, "BmGame.RBatmobileHeavyCannon.CheckForInvalidTarget");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: ProjectileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile ProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// ObjectProperty: UpgradedBodyShotProjectileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile UpgradedBodyShotProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 2404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2404); }
    }

    /// <summary>
    /// ObjectProperty: UpgradedHeadShotProjectileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile UpgradedHeadShotProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 2412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2412); }
    }

    /// <summary>
    /// ObjectProperty: BothUpgradesProjectileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile BothUpgradesProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// ObjectProperty: FireFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem FireFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2428); }
    }

    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// ObjectProperty: CurrentLockOnTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentLockOnTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2444); }
    }

    /// <summary>
    /// ObjectProperty: HeavyCannonFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform HeavyCannonFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 2452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2452); }
    }

    /// <summary>
    /// FloatProperty: RecoilImpulse
    /// </summary>
    public unsafe float RecoilImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// FloatProperty: RecoilImpulsePitch
    /// </summary>
    public unsafe float RecoilImpulsePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// IntProperty: FirePitchOffset
    /// </summary>
    public unsafe int FirePitchOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }

    /// <summary>
    /// IntProperty: ChargeShakeId
    /// </summary>
    public unsafe int ChargeShakeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// FloatProperty: LockOnRange
    /// </summary>
    public unsafe float LockOnRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }
    }

    /// <summary>
    /// FloatProperty: LockOnAngle
    /// </summary>
    public unsafe float LockOnAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }

    /// <summary>
    /// BoolProperty: AllowChargedShot
    /// </summary>
    public unsafe bool AllowChargedShot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2484); }
    }

    /// <summary>
    /// BoolProperty: bCanHurtThugs
    /// </summary>
    public unsafe bool bCanHurtThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2484); }
    }

    /// <summary>
    /// BoolProperty: ChargingShot
    /// </summary>
    public unsafe bool ChargingShot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2484); }
    }

    /// <summary>
    /// BoolProperty: bWeaponHit
    /// </summary>
    public unsafe bool bWeaponHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2484); }
    }

    /// <summary>
    /// BoolProperty: bHeavyCannonLure
    /// </summary>
    public unsafe bool bHeavyCannonLure
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2484); }
    }

    /// <summary>
    /// FloatProperty: LockOnTimeMin
    /// </summary>
    public unsafe float LockOnTimeMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// FloatProperty: LockOnTimeMax
    /// </summary>
    public unsafe float LockOnTimeMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// FloatProperty: CurrentLockOn
    /// </summary>
    public unsafe float CurrentLockOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// StructProperty: FireScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct FireScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2500);

    /// <summary>
    /// StructProperty: ChargingScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ChargingScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2656);

    /// <summary>
    /// FloatProperty: ChargingDelay
    /// </summary>
    public unsafe float ChargingDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2812); }
    }

    /// <summary>
    /// FloatProperty: ChargeUpTime
    /// </summary>
    public unsafe float ChargeUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2816); }
    }

    /// <summary>
    /// FloatProperty: ChargeMaxDamageRadius
    /// </summary>
    public unsafe float ChargeMaxDamageRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2820); }
    }

    /// <summary>
    /// FloatProperty: ChargeMaxDamageMultiplier
    /// </summary>
    public unsafe float ChargeMaxDamageMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2824); }
    }

    /// <summary>
    /// StructProperty: ChaingunAimOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ChaingunAimOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2828);

    /// <summary>
    /// FloatProperty: ChargeTime
    /// </summary>
    public unsafe float ChargeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2840); }
    }

    /// <summary>
    /// FloatProperty: ChargeProp
    /// </summary>
    public unsafe float ChargeProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2844); }
    }

    /// <summary>
    /// ArrayProperty: UpgradedReloadTime
    /// </summary>
    public unsafe BmSDK.TArray<float> UpgradedReloadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 2848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2848); }
    }

    /// <summary>
    /// ByteProperty: CoolDownAnim
    /// </summary>
    public unsafe byte CoolDownAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2864); }
    }
}
