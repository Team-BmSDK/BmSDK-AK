#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBatmobileCannon<br/>
/// (size = 3220)
/// (flags = 144703666)
/// </summary>
public partial class RBatmobileCannon : BmSDK.BmGame.RVehicleWeapon, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBatmobileCannon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBatmobileCannon.
    /// </summary>
    public static RBatmobileCannon DefaultObject => (RBatmobileCannon)StaticClass().DefaultObject;

    internal RBatmobileCannon() { }

    /// <summary>
    /// Constructs a new RBatmobileCannon
    /// </summary>
    public RBatmobileCannon(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatmobileCannon(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileCannon>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileCannon>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileCannon>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileCannon>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileCannon>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileCannon>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileCannon>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileCannon>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_TryToShowInfeffectiveInstructions;
    /// <summary>
    /// Function: TryToShowInfeffectiveInstructions
    /// </summary>
    public unsafe virtual void TryToShowInfeffectiveInstructions()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToShowInfeffectiveInstructions, "BmGame.RBatmobileCannon.TryToShowInfeffectiveInstructions");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BattleModeExitted;
    /// <summary>
    /// Function: BattleModeExitted
    /// </summary>
    public unsafe override void BattleModeExitted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BattleModeExitted, "BmGame.RBatmobileCannon.BattleModeExitted");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnNVGunFX;
    /// <summary>
    /// Function: SpawnNVGunFX
    /// </summary>
    public unsafe virtual void SpawnNVGunFX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnNVGunFX, "BmGame.RBatmobileCannon.SpawnNVGunFX");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForUpgrades;
    /// <summary>
    /// Function: CheckForUpgrades
    /// </summary>
    public unsafe override void CheckForUpgrades(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForUpgrades, "BmGame.RBatmobileCannon.CheckForUpgrades");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetPerfectShot;
    /// <summary>
    /// Function: ResetPerfectShot
    /// </summary>
    public unsafe virtual void ResetPerfectShot()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPerfectShot, "BmGame.RBatmobileCannon.ResetPerfectShot");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitTargetTimer;
    /// <summary>
    /// Function: HitTargetTimer
    /// </summary>
    public unsafe virtual void HitTargetTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitTargetTimer, "BmGame.RBatmobileCannon.HitTargetTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetSuccessiveMisses;
    /// <summary>
    /// Function: ResetSuccessiveMisses
    /// </summary>
    public unsafe virtual void ResetSuccessiveMisses()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetSuccessiveMisses, "BmGame.RBatmobileCannon.ResetSuccessiveMisses");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopFiringLoop;
    /// <summary>
    /// Function: StopFiringLoop
    /// </summary>
    public unsafe override void StopFiringLoop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFiringLoop, "BmGame.RBatmobileCannon.StopFiringLoop");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartFiringLoop;
    /// <summary>
    /// Function: StartFiringLoop
    /// </summary>
    public unsafe override void StartFiringLoop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFiringLoop, "BmGame.RBatmobileCannon.StartFiringLoop");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanDisableTick;
    /// <summary>
    /// Function: CanDisableTick
    /// </summary>
    public unsafe override bool CanDisableTick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDisableTick, "BmGame.RBatmobileCannon.CanDisableTick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopOverHeat;
    /// <summary>
    /// Function: StopOverHeat
    /// </summary>
    public unsafe virtual void StopOverHeat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopOverHeat, "BmGame.RBatmobileCannon.StopOverHeat");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverHeat;
    /// <summary>
    /// Function: OverHeat
    /// </summary>
    public unsafe virtual void OverHeat(float OverheatTime = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverHeat, "BmGame.RBatmobileCannon.OverHeat");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverheatTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RBatmobileCannon.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Reloaded;
    /// <summary>
    /// Function: Reloaded
    /// </summary>
    public unsafe virtual void Reloaded()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reloaded, "BmGame.RBatmobileCannon.Reloaded");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Reload;
    /// <summary>
    /// Function: Reload
    /// </summary>
    public unsafe virtual void Reload()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reload, "BmGame.RBatmobileCannon.Reload");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DodgedTimer;
    /// <summary>
    /// Function: DodgedTimer
    /// </summary>
    public unsafe virtual void DodgedTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DodgedTimer, "BmGame.RBatmobileCannon.DodgedTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponHit;
    /// <summary>
    /// Function: WeaponHit
    /// </summary>
    public unsafe override void WeaponHit(bool bKill)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponHit, "BmGame.RBatmobileCannon.WeaponHit");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKill, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetNoiseEvent;
    /// <summary>
    /// Function: GadgetNoiseEvent
    /// </summary>
    public unsafe virtual void GadgetNoiseEvent(System.Numerics.Vector3 Loc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetNoiseEvent, "BmGame.RBatmobileCannon.GadgetNoiseEvent");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyWindowsAlongRiotSuppressorPath;
    /// <summary>
    /// Function: DestroyWindowsAlongRiotSuppressorPath
    /// </summary>
    public unsafe virtual void DestroyWindowsAlongRiotSuppressorPath(System.Numerics.Vector3 FireFrom, System.Numerics.Vector3 FireTo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyWindowsAlongRiotSuppressorPath, "BmGame.RBatmobileCannon.DestroyWindowsAlongRiotSuppressorPath");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireFrom, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireTo, paramsPtr + 12);
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

    private static BmSDK.Function __fn_GetImpactAudioEvent;
    /// <summary>
    /// Function: GetImpactAudioEvent
    /// </summary>
    public unsafe override BmSDK.Engine.AkEvent GetImpactAudioEvent(BmSDK.Engine.AkWwise.EAkWorldMaterial Mat)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetImpactAudioEvent, "BmGame.RBatmobileCannon.GetImpactAudioEvent");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FireRiotSuppressor;
    /// <summary>
    /// Function: FireRiotSuppressor
    /// </summary>
    public unsafe virtual bool FireRiotSuppressor(System.Numerics.Vector3 OverrideTargetPosition = default, bool bKillShot = default, float OverrideImpulse = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireRiotSuppressor, "BmGame.RBatmobileCannon.FireRiotSuppressor");
        byte* paramsPtr = stackalloc byte[524];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideTargetPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKillShot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideImpulse, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_CheckForFiringOverBarrier;
    /// <summary>
    /// Function: CheckForFiringOverBarrier
    /// </summary>
    public unsafe virtual bool CheckForFiringOverBarrier(out System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForFiringOverBarrier, "BmGame.RBatmobileCannon.CheckForFiringOverBarrier");
        byte* paramsPtr = stackalloc byte[16];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_DamagePawnWithChainGun;
    /// <summary>
    /// Function: DamagePawnWithChainGun
    /// </summary>
    public unsafe virtual void DamagePawnWithChainGun(BmSDK.BmGame.RPawnVillain PawnTarget, BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagePawnWithChainGun, "BmGame.RBatmobileCannon.DamagePawnWithChainGun");
        byte* paramsPtr = stackalloc byte[256];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireChainGun;
    /// <summary>
    /// Function: FireChainGun
    /// </summary>
    public unsafe virtual bool FireChainGun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireChainGun, "BmGame.RBatmobileCannon.FireChainGun");
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

    private static BmSDK.Function __fn_FireBulletBy;
    /// <summary>
    /// Function: FireBulletBy
    /// </summary>
    public unsafe virtual void FireBulletBy(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, BmSDK.Engine.Actor.FImpactInfo Impact)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireBulletBy, "BmGame.RBatmobileCannon.FireBulletBy");
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Impact, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireWeapon;
    /// <summary>
    /// Function: FireWeapon
    /// </summary>
    public unsafe override bool FireWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireWeapon, "BmGame.RBatmobileCannon.FireWeapon");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckForInvalidTarget;
    /// <summary>
    /// Function: CheckForInvalidTarget
    /// </summary>
    public unsafe override bool CheckForInvalidTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForInvalidTarget, "BmGame.RBatmobileCannon.CheckForInvalidTarget");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckAutoTarget;
    /// <summary>
    /// Function: CheckAutoTarget
    /// </summary>
    public unsafe override bool CheckAutoTarget(BmSDK.Engine.Actor Target, out System.Numerics.Vector3 TargetPosition, out float OverridePriority, out float OverrideMaxRange, out byte DoLOSCheck)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAutoTarget, "BmGame.RBatmobileCannon.CheckAutoTarget");
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
        TargetPosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
        OverridePriority = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 20);
        OverrideMaxRange = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 24);
        DoLOSCheck = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_SetCurrentMode;
    /// <summary>
    /// Function: SetCurrentMode
    /// </summary>
    public unsafe virtual void SetCurrentMode(BmSDK.BmGame.RBatmobileCannon.EBatmobileCannonMode NewMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentMode, "BmGame.RBatmobileCannon.SetCurrentMode");
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireEMP;
    /// <summary>
    /// Function: FireEMP
    /// </summary>
    public unsafe virtual void FireEMP()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireEMP, "BmGame.RBatmobileCannon.FireEMP");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateEmp;
    /// <summary>
    /// Function: UpdateEmp
    /// </summary>
    public unsafe virtual void UpdateEmp(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateEmp, "BmGame.RBatmobileCannon.UpdateEmp");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAimPosition;
    /// <summary>
    /// Function: GetAimPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAimPosition(System.Numerics.Vector3 AimOrigin, System.Numerics.Vector3 AimAtPosition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAimPosition, "BmGame.RBatmobileCannon.GetAimPosition");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimOrigin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimAtPosition, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_DontMoveCursor;
    /// <summary>
    /// Function: DontMoveCursor
    /// </summary>
    public unsafe override void DontMoveCursor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DontMoveCursor, "BmGame.RBatmobileCannon.DontMoveCursor");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGunRotation;
    /// <summary>
    /// Function: UpdateGunRotation
    /// </summary>
    public unsafe virtual void UpdateGunRotation(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGunRotation, "BmGame.RBatmobileCannon.UpdateGunRotation");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGunLocation;
    /// <summary>
    /// Function: GetGunLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGunLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGunLocation, "BmGame.RBatmobileCannon.GetGunLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetGunYawAbsolute;
    /// <summary>
    /// Function: SetGunYawAbsolute
    /// </summary>
    public unsafe virtual void SetGunYawAbsolute(BmSDK.Rotator Absolute)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGunYawAbsolute, "BmGame.RBatmobileCannon.SetGunYawAbsolute");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Absolute, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGunYawRelative;
    /// <summary>
    /// Function: SetGunYawRelative
    /// </summary>
    public unsafe virtual void SetGunYawRelative(int NewRelYaw)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGunYawRelative, "BmGame.RBatmobileCannon.SetGunYawRelative");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRelYaw, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GivenTo;
    /// <summary>
    /// Function: GivenTo
    /// </summary>
    public unsafe override void GivenTo(BmSDK.Engine.Pawn thisPawn, bool bDoNotActivate = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GivenTo, "BmGame.RBatmobileCannon.GivenTo");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(thisPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoNotActivate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowFailedWeapon;
    /// <summary>
    /// Function: ShowFailedWeapon
    /// </summary>
    public unsafe override void ShowFailedWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowFailedWeapon, "BmGame.RBatmobileCannon.ShowFailedWeapon");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGadgetCamera;
    /// <summary>
    /// Function: GetGadgetCamera
    /// </summary>
    public unsafe override BmSDK.FName GetGadgetCamera(bool InSoftCover = default, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetCamera, "BmGame.RBatmobileCannon.GetGadgetCamera");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RBatmobileCannon.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: EBatmobileCannonMode
    /// </summary>
    public enum EBatmobileCannonMode : byte
    {
        EBCM_ChainGun = 0,
        EBCM_ComboChainGun = 1,
        EBCM_RiotSuppressor = 2,
        EBCM_EMPGun = 3,
        EBCM_Init = 4,
        EBCM_MAX = 5,
    }

    /// <summary>
    /// BoolProperty: bNonAimedCannonIsCameraRelative
    /// </summary>
    public unsafe bool bNonAimedCannonIsCameraRelative
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bHasRiotSurpressor
    /// </summary>
    public unsafe bool bHasRiotSurpressor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bCanHurtThugs
    /// </summary>
    public unsafe bool bCanHurtThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bUseRiotTargettingForChainGun
    /// </summary>
    public unsafe bool bUseRiotTargettingForChainGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bOverheating
    /// </summary>
    public unsafe bool bOverheating
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bChainGunScreenShake
    /// </summary>
    public unsafe bool bChainGunScreenShake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bChaingunLocksOntoTanks
    /// </summary>
    public unsafe bool bChaingunLocksOntoTanks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bReloading
    /// </summary>
    public unsafe bool bReloading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bPerfectShot
    /// </summary>
    public unsafe bool bPerfectShot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bLoseAccuracyOverTime
    /// </summary>
    public unsafe bool bLoseAccuracyOverTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: AudioTurrentMovingH
    /// </summary>
    public unsafe bool AudioTurrentMovingH
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: AudioTurrentMovingV
    /// </summary>
    public unsafe bool AudioTurrentMovingV
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bDisableCannonAimAtTargets
    /// </summary>
    public unsafe bool bDisableCannonAimAtTargets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bHalfFireRate
    /// </summary>
    public unsafe bool bHalfFireRate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// NameProperty: CannonYawBone
    /// </summary>
    public unsafe BmSDK.FName CannonYawBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }

    /// <summary>
    /// NameProperty: CannonPitchBone
    /// </summary>
    public unsafe BmSDK.FName CannonPitchBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }

    /// <summary>
    /// NameProperty: CannonSocket
    /// </summary>
    public unsafe BmSDK.FName CannonSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// ObjectProperty: GunFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GunFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// ObjectProperty: GunImpactFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GunImpactFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// ObjectProperty: RiotSuppressorImpactEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem RiotSuppressorImpactEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }

    /// <summary>
    /// ObjectProperty: RiotSuppressorMuzzleFlash
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem RiotSuppressorMuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// ObjectProperty: RiotSuppressorTracerSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem RiotSuppressorTracerSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// ObjectProperty: ChainGunTracerSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChainGunTracerSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// ObjectProperty: ChainGunLoopingShells
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChainGunLoopingShells
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// ObjectProperty: RiotSuppressorShell
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem RiotSuppressorShell
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }

    /// <summary>
    /// ObjectProperty: RiotSuppressorIndividualFireEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RiotSuppressorIndividualFireEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// ObjectProperty: RiotSuppressorHitSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RiotSuppressorHitSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// ObjectProperty: ChainGunOverheatSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChainGunOverheatSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2504); }
    }

    /// <summary>
    /// ObjectProperty: ChainGunCooledSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChainGunCooledSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// ObjectProperty: EMPTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor EMPTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }
    }

    /// <summary>
    /// ObjectProperty: RiotSuppressorTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor RiotSuppressorTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// ObjectProperty: SuppressFireTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor SuppressFireTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2536); }
    }

    /// <summary>
    /// ObjectProperty: GunSpinController
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSingleBone GunSpinController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSingleBone>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// ObjectProperty: ComboFireStartEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ComboFireStartEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// ObjectProperty: ComboFireStopEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ComboFireStopEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// ObjectProperty: ComboFireLoopingEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ComboFireLoopingEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }

    /// <summary>
    /// ObjectProperty: EnterComboSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent EnterComboSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// ObjectProperty: ExitComboSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ExitComboSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2584); }
    }

    /// <summary>
    /// ObjectProperty: TankHeadShotFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform TankHeadShotFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// ObjectProperty: RayCheckActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor RayCheckActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// ComponentProperty: ChainGunShells
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ChainGunShells
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// ClassProperty: DamageType
    /// </summary>
    public unsafe BmSDK.Class DamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// IntProperty: GunYawOffset
    /// </summary>
    public unsafe int GunYawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// StructProperty: TargetGunRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator TargetGunRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2628);

    /// <summary>
    /// StructProperty: TargetLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TargetLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2640);

    /// <summary>
    /// FloatProperty: AutoTargetRange
    /// </summary>
    public unsafe float AutoTargetRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2652); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetAngle
    /// </summary>
    public unsafe float AutoTargetAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetAngleAimed
    /// </summary>
    public unsafe float AutoTargetAngleAimed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2660); }
    }

    /// <summary>
    /// FloatProperty: ImpactMomentum
    /// </summary>
    public unsafe float ImpactMomentum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// FloatProperty: RecoilImpulse
    /// </summary>
    public unsafe float RecoilImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2668); }
    }

    /// <summary>
    /// FloatProperty: InaccuracyAngle
    /// </summary>
    public unsafe float InaccuracyAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// IntProperty: LaunchID
    /// </summary>
    public unsafe int LaunchID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2676); }
    }

    /// <summary>
    /// FloatProperty: HeatUpPerSecond
    /// </summary>
    public unsafe float HeatUpPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }
    }

    /// <summary>
    /// FloatProperty: HeadDownPerSecond
    /// </summary>
    public unsafe float HeadDownPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2684); }
    }

    /// <summary>
    /// FloatProperty: OverheatOffValue
    /// </summary>
    public unsafe float OverheatOffValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// FloatProperty: CurrentHeatLevel
    /// </summary>
    public unsafe float CurrentHeatLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2692); }
    }

    /// <summary>
    /// StructProperty: HeatBarStart
    /// </summary>
    public unsafe ref System.Numerics.Vector2 HeatBarStart
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>(Ptr + 2696);

    /// <summary>
    /// StructProperty: HeatBarSize
    /// </summary>
    public unsafe ref System.Numerics.Vector2 HeatBarSize
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>(Ptr + 2704);

    /// <summary>
    /// FloatProperty: ChainGunMaxSpinSpeed
    /// </summary>
    public unsafe float ChainGunMaxSpinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2712); }
    }

    /// <summary>
    /// FloatProperty: ChainGunSpinAccel
    /// </summary>
    public unsafe float ChainGunSpinAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2716); }
    }

    /// <summary>
    /// FloatProperty: ChainGunSpinDecel
    /// </summary>
    public unsafe float ChainGunSpinDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }

    /// <summary>
    /// FloatProperty: CurrentChainGunSpin
    /// </summary>
    public unsafe float CurrentChainGunSpin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2724); }
    }

    /// <summary>
    /// FloatProperty: CurrentChainGunSpinSpeed
    /// </summary>
    public unsafe float CurrentChainGunSpinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2728); }
    }

    /// <summary>
    /// FloatProperty: RiotSuppressorLockOnAngle
    /// </summary>
    public unsafe float RiotSuppressorLockOnAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2732); }
    }

    /// <summary>
    /// FloatProperty: RiotSuppressorRange
    /// </summary>
    public unsafe float RiotSuppressorRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }

    /// <summary>
    /// FloatProperty: RiotSuppressorFiringInterval
    /// </summary>
    public unsafe float RiotSuppressorFiringInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2740); }
    }

    /// <summary>
    /// FloatProperty: RiotSuppressorVillainImpulse
    /// </summary>
    public unsafe float RiotSuppressorVillainImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2744); }
    }

    /// <summary>
    /// StructProperty: RiotSuppressorFireScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct RiotSuppressorFireScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2748);

    /// <summary>
    /// FloatProperty: ComboFiringInterval
    /// </summary>
    public unsafe float ComboFiringInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2904); }
    }

    /// <summary>
    /// FloatProperty: MinTurretPitch
    /// </summary>
    public unsafe float MinTurretPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2908); }
    }

    /// <summary>
    /// FloatProperty: MaxTurretPitch
    /// </summary>
    public unsafe float MaxTurretPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2912); }
    }

    /// <summary>
    /// IntProperty: ChainGunDamage
    /// </summary>
    public unsafe int ChainGunDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2916); }
    }

    /// <summary>
    /// IntProperty: UpgradedDamage
    /// </summary>
    public unsafe int UpgradedDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2920); }
    }

    /// <summary>
    /// FloatProperty: EMPLockOnTime
    /// </summary>
    public unsafe float EMPLockOnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2924); }
    }

    /// <summary>
    /// FloatProperty: EMPLockOn
    /// </summary>
    public unsafe float EMPLockOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2928); }
    }

    /// <summary>
    /// IntProperty: NumSuccessiveMisses
    /// </summary>
    public unsafe int NumSuccessiveMisses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2932); }
    }

    /// <summary>
    /// NameProperty: TracerLifetimeParamName
    /// </summary>
    public unsafe BmSDK.FName TracerLifetimeParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2936); }
    }

    /// <summary>
    /// FloatProperty: TracerFXMaxRange
    /// </summary>
    public unsafe float TracerFXMaxRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2944); }
    }

    /// <summary>
    /// NameProperty: ChainGunShellsSocket
    /// </summary>
    public unsafe BmSDK.FName ChainGunShellsSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2948); }
    }

    /// <summary>
    /// NameProperty: RiotSuppressorShellsSocket
    /// </summary>
    public unsafe BmSDK.FName RiotSuppressorShellsSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2956); }
    }

    /// <summary>
    /// ArrayProperty: RiotSuppressorImpactBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> RiotSuppressorImpactBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2964); }
    }

    /// <summary>
    /// StructProperty: ChainGunScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ChainGunScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2980);

    /// <summary>
    /// IntProperty: AmmoPerMagazine
    /// </summary>
    public unsafe int AmmoPerMagazine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3136); }
    }

    /// <summary>
    /// IntProperty: CurrentAmmo
    /// </summary>
    public unsafe int CurrentAmmo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3140); }
    }

    /// <summary>
    /// FloatProperty: ReloadTime
    /// </summary>
    public unsafe float ReloadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3144); }
    }

    /// <summary>
    /// StructProperty: InaccuracyVsTime
    /// </summary>
    public unsafe ref BmSDK.GameObject.FInterpCurveFloat InaccuracyVsTime
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 3148);

    /// <summary>
    /// FloatProperty: InaccuracyDropMultiplier
    /// </summary>
    public unsafe float InaccuracyDropMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3168); }
    }

    /// <summary>
    /// FloatProperty: MaxHeadshotAccuracyAngle
    /// </summary>
    public unsafe float MaxHeadshotAccuracyAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3172); }
    }

    /// <summary>
    /// StructProperty: InaccuracyVsTimeUpgrade
    /// </summary>
    public unsafe ref BmSDK.GameObject.FInterpCurveFloat InaccuracyVsTimeUpgrade
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 3176);

    /// <summary>
    /// FloatProperty: CurrentInaccuracyTime
    /// </summary>
    public unsafe float CurrentInaccuracyTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3196); }
    }

    /// <summary>
    /// FloatProperty: CurrentAccuracyZeroToOne
    /// </summary>
    public unsafe float CurrentAccuracyZeroToOne
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3200); }
    }

    /// <summary>
    /// FloatProperty: InaccuracyMaxValueInverse
    /// </summary>
    public unsafe float InaccuracyMaxValueInverse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3204); }
    }

    /// <summary>
    /// IntProperty: AudioOldTurretPitch
    /// </summary>
    public unsafe int AudioOldTurretPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3208); }
    }

    /// <summary>
    /// ByteProperty: CurrentMode
    /// </summary>
    public unsafe BmSDK.BmGame.RBatmobileCannon.EBatmobileCannonMode CurrentMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatmobileCannon.EBatmobileCannonMode>(Ptr + 3212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3212); }
    }

    /// <summary>
    /// ByteProperty: PendingMode
    /// </summary>
    public unsafe BmSDK.BmGame.RBatmobileCannon.EBatmobileCannonMode PendingMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatmobileCannon.EBatmobileCannonMode>(Ptr + 3213); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3213); }
    }

    /// <summary>
    /// FloatProperty: DamageRemainder
    /// </summary>
    public unsafe float DamageRemainder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3216); }
    }
}
