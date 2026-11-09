#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RVehicleWeapon<br/>
/// (size = 2396)
/// (flags = 144703667)
/// </summary>
public partial class RVehicleWeapon : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleWeapon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RVehicleWeapon.
    /// </summary>
    public static RVehicleWeapon DefaultObject => (RVehicleWeapon)StaticClass().DefaultObject;

    internal RVehicleWeapon() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleWeapon(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleWeapon>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleWeapon>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleWeapon>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleWeapon>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleWeapon>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleWeapon>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleWeapon>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleWeapon>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_BattleModeExitted;
    /// <summary>
    /// Function: BattleModeExitted
    /// </summary>
    public unsafe virtual void BattleModeExitted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BattleModeExitted, "BmGame.RVehicleWeapon.BattleModeExitted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyOwnerDamaged;
    /// <summary>
    /// Function: NotifyOwnerDamaged
    /// </summary>
    public unsafe virtual void NotifyOwnerDamaged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyOwnerDamaged, "BmGame.RVehicleWeapon.NotifyOwnerDamaged");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DriverLeft;
    /// <summary>
    /// Function: DriverLeft
    /// </summary>
    public unsafe virtual void DriverLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DriverLeft, "BmGame.RVehicleWeapon.DriverLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProjectileExploded;
    /// <summary>
    /// Function: ProjectileExploded
    /// </summary>
    public unsafe virtual void ProjectileExploded(BmSDK.BmGame.RProjectile Projectile, System.Numerics.Vector3 ImpactLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProjectileExploded, "BmGame.RVehicleWeapon.ProjectileExploded");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Projectile, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SoundTimeout;
    /// <summary>
    /// Function: SoundTimeout
    /// </summary>
    public unsafe virtual void SoundTimeout()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SoundTimeout, "BmGame.RVehicleWeapon.SoundTimeout");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessProjectileSound;
    /// <summary>
    /// Function: ProcessProjectileSound
    /// </summary>
    public unsafe virtual void ProcessProjectileSound(System.Numerics.Vector3 ProjectileOrigin, System.Numerics.Vector3 ProjectileDestination)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessProjectileSound, "BmGame.RVehicleWeapon.ProcessProjectileSound");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjectileOrigin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjectileDestination, paramsPtr + 12);
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

    private static BmSDK.Function __fn_CheckForUpgrades;
    /// <summary>
    /// Function: CheckForUpgrades
    /// </summary>
    public unsafe virtual void CheckForUpgrades(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForUpgrades, "BmGame.RVehicleWeapon.CheckForUpgrades");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleLockOnBeep;
    /// <summary>
    /// Function: HandleLockOnBeep
    /// </summary>
    public unsafe virtual void HandleLockOnBeep(bool bLockingOn, float LockProportion)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleLockOnBeep, "BmGame.RVehicleWeapon.HandleLockOnBeep");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLockingOn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LockProportion, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAdditionalHelpPrompt;
    /// <summary>
    /// Function: GetAdditionalHelpPrompt
    /// </summary>
    public unsafe virtual void GetAdditionalHelpPrompt(BmSDK.BmGame.RHUDPrompt HUDPrompt)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAdditionalHelpPrompt, "BmGame.RVehicleWeapon.GetAdditionalHelpPrompt");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HUDPrompt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProjectileHitActor;
    /// <summary>
    /// Function: ProjectileHitActor
    /// </summary>
    public unsafe virtual void ProjectileHitActor(BmSDK.Engine.Actor Target, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitVelocity, int Damage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProjectileHitActor, "BmGame.RVehicleWeapon.ProjectileHitActor");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitVelocity, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetCoolDown;
    /// <summary>
    /// Function: ResetCoolDown
    /// </summary>
    public unsafe virtual void ResetCoolDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetCoolDown, "BmGame.RVehicleWeapon.ResetCoolDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachToHand;
    /// <summary>
    /// Function: AttachToHand
    /// </summary>
    public unsafe override void AttachToHand(BmSDK.FName CustomBone = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachToHand, "BmGame.RVehicleWeapon.AttachToHand");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomBone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachToBelt;
    /// <summary>
    /// Function: AttachToBelt
    /// </summary>
    public unsafe override void AttachToBelt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachToBelt, "BmGame.RVehicleWeapon.AttachToBelt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAutoTargetRotation;
    /// <summary>
    /// Function: GetAutoTargetRotation
    /// </summary>
    public unsafe override BmSDK.Rotator GetAutoTargetRotation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAutoTargetRotation, "BmGame.RVehicleWeapon.GetAutoTargetRotation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckForProhibittedTarget;
    /// <summary>
    /// Function: CheckForProhibittedTarget
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor CheckForProhibittedTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForProhibittedTarget, "BmGame.RVehicleWeapon.CheckForProhibittedTarget");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayedRechargeTime;
    /// <summary>
    /// Function: GetDisplayedRechargeTime
    /// </summary>
    public unsafe virtual float GetDisplayedRechargeTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayedRechargeTime, "BmGame.RVehicleWeapon.GetDisplayedRechargeTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetOverrideCamera;
    /// <summary>
    /// Function: GetOverrideCamera
    /// </summary>
    public unsafe virtual BmSDK.FName GetOverrideCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverrideCamera, "BmGame.RVehicleWeapon.GetOverrideCamera");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RVehicleWeapon.Tick");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UsedWeaponDone;
    /// <summary>
    /// Function: UsedWeaponDone
    /// </summary>
    public unsafe virtual void UsedWeaponDone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UsedWeaponDone, "BmGame.RVehicleWeapon.UsedWeaponDone");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentHudDisplay;
    /// <summary>
    /// Function: SetCurrentHudDisplay
    /// </summary>
    public unsafe virtual void SetCurrentHudDisplay(BmSDK.BmGame.RVehicleWeapon.EHudDisplayLevel new_display)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentHudDisplay, "BmGame.RVehicleWeapon.SetCurrentHudDisplay");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_display, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GivenTo;
    /// <summary>
    /// Function: GivenTo
    /// </summary>
    public unsafe override void GivenTo(BmSDK.Engine.Pawn thisPawn, bool bDoNotActivate = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GivenTo, "BmGame.RVehicleWeapon.GivenTo");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(thisPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoNotActivate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowFailedWeapon;
    /// <summary>
    /// Function: ShowFailedWeapon
    /// </summary>
    public unsafe virtual void ShowFailedWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowFailedWeapon, "BmGame.RVehicleWeapon.ShowFailedWeapon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireNow;
    /// <summary>
    /// Function: FireNow
    /// </summary>
    public unsafe virtual bool FireNow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireNow, "BmGame.RVehicleWeapon.FireNow");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ButtonPressed;
    /// <summary>
    /// Function: ButtonPressed
    /// </summary>
    public unsafe override void ButtonPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ButtonPressed, "BmGame.RVehicleWeapon.ButtonPressed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToFireWeapon;
    /// <summary>
    /// Function: TryToFireWeapon
    /// </summary>
    public unsafe virtual bool TryToFireWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToFireWeapon, "BmGame.RVehicleWeapon.TryToFireWeapon");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FireWeapon;
    /// <summary>
    /// Function: FireWeapon
    /// </summary>
    public unsafe virtual bool FireWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireWeapon, "BmGame.RVehicleWeapon.FireWeapon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ProcessDrivingInput;
    /// <summary>
    /// Function: ProcessDrivingInput
    /// </summary>
    public unsafe virtual void ProcessDrivingInput(out float Accel, out float Steering, out System.Numerics.Vector3 AbsoluteMoveDirection, BmSDK.BmGame.RPlayerController Controller, float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessDrivingInput, "BmGame.RVehicleWeapon.ProcessDrivingInput");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Accel);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Accel, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Steering);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Steering, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AbsoluteMoveDirection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbsoluteMoveDirection, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Controller, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Accel = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        Steering = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        AbsoluteMoveDirection = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_InvalidTarget;
    /// <summary>
    /// Function: InvalidTarget
    /// </summary>
    public unsafe virtual void InvalidTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InvalidTarget, "BmGame.RVehicleWeapon.InvalidTarget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DelayFiring;
    /// <summary>
    /// Function: DelayFiring
    /// </summary>
    public unsafe virtual void DelayFiring()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DelayFiring, "BmGame.RVehicleWeapon.DelayFiring");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponBlocked;
    /// <summary>
    /// Function: WeaponBlocked
    /// </summary>
    public unsafe virtual void WeaponBlocked()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponBlocked, "BmGame.RVehicleWeapon.WeaponBlocked");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponHit;
    /// <summary>
    /// Function: WeaponHit
    /// </summary>
    public unsafe virtual void WeaponHit(bool bKill)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponHit, "BmGame.RVehicleWeapon.WeaponHit");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKill, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterGameAction;
    /// <summary>
    /// Function: RegisterGameAction
    /// </summary>
    public unsafe virtual void RegisterGameAction()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterGameAction, "BmGame.RVehicleWeapon.RegisterGameAction");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopFiringLoop;
    /// <summary>
    /// Function: StopFiringLoop
    /// </summary>
    public unsafe virtual void StopFiringLoop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFiringLoop, "BmGame.RVehicleWeapon.StopFiringLoop");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartFiringLoop;
    /// <summary>
    /// Function: StartFiringLoop
    /// </summary>
    public unsafe virtual void StartFiringLoop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFiringLoop, "BmGame.RVehicleWeapon.StartFiringLoop");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForInvalidTarget;
    /// <summary>
    /// Function: CheckForInvalidTarget
    /// </summary>
    public unsafe virtual bool CheckForInvalidTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForInvalidTarget, "BmGame.RVehicleWeapon.CheckForInvalidTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsHeavyWeaponValid;
    /// <summary>
    /// Function: IsHeavyWeaponValid
    /// </summary>
    public unsafe virtual bool IsHeavyWeaponValid()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHeavyWeaponValid, "BmGame.RVehicleWeapon.IsHeavyWeaponValid");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentValidTarget;
    /// <summary>
    /// Function: GetCurrentValidTarget
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetCurrentValidTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentValidTarget, "BmGame.RVehicleWeapon.GetCurrentValidTarget");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DontMoveCursor;
    /// <summary>
    /// Function: DontMoveCursor
    /// </summary>
    public unsafe virtual void DontMoveCursor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DontMoveCursor, "BmGame.RVehicleWeapon.DontMoveCursor");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadyToFire;
    /// <summary>
    /// Function: ReadyToFire
    /// </summary>
    public unsafe virtual bool ReadyToFire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadyToFire, "BmGame.RVehicleWeapon.ReadyToFire");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDisableTick;
    /// <summary>
    /// Function: CanDisableTick
    /// </summary>
    public unsafe override bool CanDisableTick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDisableTick, "BmGame.RVehicleWeapon.CanDisableTick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe override void DrawHUD(BmSDK.Engine.HUD H)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmGame.RVehicleWeapon.DrawHUD");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBattleDodge;
    /// <summary>
    /// Function: CanBattleDodge
    /// </summary>
    public unsafe virtual bool CanBattleDodge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBattleDodge, "BmGame.RVehicleWeapon.CanBattleDodge");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AllowUnhideBone;
    /// <summary>
    /// Function: AllowUnhideBone
    /// </summary>
    public unsafe virtual bool AllowUnhideBone(int WeaponBoneIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowUnhideBone, "BmGame.RVehicleWeapon.AllowUnhideBone");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponBoneIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Enum: EHudDisplayLevel
    /// </summary>
    public enum EHudDisplayLevel : byte
    {
        EHDL_Unavailable = 0,
        EHDL_Available = 1,
        EHDL_Used = 2,
        EHDL_Lost = 3,
        EHDL_MAX = 4,
    }

    /// <summary>
    /// Enum: ELockOnBeepStage
    /// </summary>
    public enum ELockOnBeepStage : byte
    {
        ELBS_None = 0,
        ELBS_LockingOn = 1,
        ELBS_Locked = 2,
        ELBS_MAX = 3,
    }

    /// <summary>
    /// StrProperty: TempName
    /// </summary>
    public unsafe BmSDK.FString TempName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: ContinuousFire
    /// </summary>
    public unsafe bool ContinuousFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: bFiring
    /// </summary>
    public unsafe bool bFiring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: bAimedWeapon
    /// </summary>
    public unsafe bool bAimedWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: bOnlySteerOnAimExtremes
    /// </summary>
    public unsafe bool bOnlySteerOnAimExtremes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: bRelativeAiming
    /// </summary>
    public unsafe bool bRelativeAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: DrawWorldAim
    /// </summary>
    public unsafe bool DrawWorldAim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: bFPSControls
    /// </summary>
    public unsafe bool bFPSControls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: bSecondaryWeapon
    /// </summary>
    public unsafe bool bSecondaryWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: bFailedWeaponFlag
    /// </summary>
    public unsafe bool bFailedWeaponFlag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: bBatmanProhibited
    /// </summary>
    public unsafe bool bBatmanProhibited
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// FloatProperty: FiringInterval
    /// </summary>
    public unsafe float FiringInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// FloatProperty: CoolDown
    /// </summary>
    public unsafe float CoolDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// FloatProperty: WeaponCoolDown
    /// </summary>
    public unsafe float WeaponCoolDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// StructProperty: AimPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AimPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2100);

    /// <summary>
    /// StructProperty: AimVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AimVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2112);

    /// <summary>
    /// StructProperty: WorldAimPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WorldAimPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2124);

    /// <summary>
    /// FloatProperty: CursorSpeed
    /// </summary>
    public unsafe float CursorSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }

    /// <summary>
    /// FloatProperty: CursorAccel
    /// </summary>
    public unsafe float CursorAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// FloatProperty: CursorDecel
    /// </summary>
    public unsafe float CursorDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// FloatProperty: CursorReturnFactor
    /// </summary>
    public unsafe float CursorReturnFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// FloatProperty: CursorReturnDelay
    /// </summary>
    public unsafe float CursorReturnDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }

    /// <summary>
    /// FloatProperty: MaxAimX
    /// </summary>
    public unsafe float MaxAimX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// FloatProperty: MaxAimY
    /// </summary>
    public unsafe float MaxAimY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// FloatProperty: RelativeAimingCurvePower
    /// </summary>
    public unsafe float RelativeAimingCurvePower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// ObjectProperty: AimTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor AimTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }

    /// <summary>
    /// ObjectProperty: FireStartEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireStartEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// ObjectProperty: FireStopEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireStopEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }

    /// <summary>
    /// ObjectProperty: FireLoopingEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireLoopingEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// ObjectProperty: IndividualFireEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent IndividualFireEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }

    /// <summary>
    /// ObjectProperty: ReloadSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ReloadSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// ObjectProperty: WeaponHitEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WeaponHitEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }

    /// <summary>
    /// ObjectProperty: FireWeaponAnimNode
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNode_Additive FireWeaponAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNode_Additive>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// ObjectProperty: MaterialToUpdateWhenPresent
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface MaterialToUpdateWhenPresent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// ObjectProperty: MaterialOriginalToUpdateWhenPresent
    /// </summary>
    public unsafe BmSDK.Engine.Material MaterialOriginalToUpdateWhenPresent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// ObjectProperty: LockOnBeepSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LockOnBeepSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }

    /// <summary>
    /// ObjectProperty: LockOnBeepProportionParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName LockOnBeepProportionParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// ObjectProperty: LockedOnSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LockedOnSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }

    /// <summary>
    /// ObjectProperty: LockedOnSoundOff
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LockedOnSoundOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }
    }

    /// <summary>
    /// ObjectProperty: LockOnBeepSoundOff
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LockOnBeepSoundOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// FloatProperty: ReloadSoundDuration
    /// </summary>
    public unsafe float ReloadSoundDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }
    }

    /// <summary>
    /// StructProperty: CrosshairOrigin
    /// </summary>
    public unsafe ref System.Numerics.Vector2 CrosshairOrigin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>(Ptr + 2292);

    /// <summary>
    /// FloatProperty: LethalRadius
    /// </summary>
    public unsafe float LethalRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// FloatProperty: LethalRange
    /// </summary>
    public unsafe float LethalRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// NameProperty: FireAnimNodeName
    /// </summary>
    public unsafe BmSDK.FName FireAnimNodeName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }

    /// <summary>
    /// NameProperty: CustomFireAnimName
    /// </summary>
    public unsafe BmSDK.FName CustomFireAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }

    /// <summary>
    /// ArrayProperty: BonesToHideWhenNotPresent
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BonesToHideWhenNotPresent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2324); }
    }

    /// <summary>
    /// NameProperty: BlendNodeToZeroWhenNotPresent
    /// </summary>
    public unsafe BmSDK.FName BlendNodeToZeroWhenNotPresent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2340); }
    }

    /// <summary>
    /// IntProperty: MaterialIndexToUpdateWhenPresent
    /// </summary>
    public unsafe int MaterialIndexToUpdateWhenPresent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// NameProperty: OverrideCamera
    /// </summary>
    public unsafe BmSDK.FName OverrideCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }
    }

    /// <summary>
    /// FloatProperty: PowerConsumption
    /// </summary>
    public unsafe float PowerConsumption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }

    /// <summary>
    /// FloatProperty: SoundRadiusOrigin
    /// </summary>
    public unsafe float SoundRadiusOrigin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2364); }
    }

    /// <summary>
    /// FloatProperty: SoundRadiusImpact
    /// </summary>
    public unsafe float SoundRadiusImpact
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }
    }

    /// <summary>
    /// FloatProperty: SoundRadiusTrail
    /// </summary>
    public unsafe float SoundRadiusTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2372); }
    }

    /// <summary>
    /// ByteProperty: CurrentLockOnSound
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon.ELockOnBeepStage CurrentLockOnSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon.ELockOnBeepStage>(Ptr + 2376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }
    }

    /// <summary>
    /// ByteProperty: CurrentHudDisplayLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon.EHudDisplayLevel CurrentHudDisplayLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon.EHudDisplayLevel>(Ptr + 2377); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2377); }
    }

    /// <summary>
    /// StrProperty: HeavyWeaponName
    /// </summary>
    public unsafe BmSDK.FString HeavyWeaponName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2380); }
    }
}
