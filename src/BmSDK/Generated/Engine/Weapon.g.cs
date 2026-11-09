#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: Weapon<br/>
/// (size = 992)
/// (flags = 144703671)
/// </summary>
public partial class Weapon : BmSDK.Engine.Inventory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Weapon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as Weapon.
    /// </summary>
    public static Weapon DefaultObject => (Weapon)StaticClass().DefaultObject;

    internal Weapon() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Weapon(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Weapon>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Weapon>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Weapon>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Weapon>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Weapon>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Weapon>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Weapon>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Weapon>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetTargetDistance;
    /// <summary>
    /// Function: GetTargetDistance
    /// </summary>
    public unsafe virtual float GetTargetDistance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetDistance, "Engine.Weapon.GetTargetDistance");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CacheAIController;
    /// <summary>
    /// Function: CacheAIController
    /// </summary>
    public unsafe virtual void CacheAIController()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CacheAIController, "Engine.Weapon.CacheAIController");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponIsDown;
    /// <summary>
    /// Function: WeaponIsDown
    /// </summary>
    public unsafe virtual void WeaponIsDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponIsDown, "Engine.Weapon.WeaponIsDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StillFiring;
    /// <summary>
    /// Function: StillFiring
    /// </summary>
    public unsafe virtual bool StillFiring(byte FireMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StillFiring, "Engine.Weapon.StillFiring");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShouldRefire;
    /// <summary>
    /// Function: ShouldRefire
    /// </summary>
    public unsafe virtual bool ShouldRefire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldRefire, "Engine.Weapon.ShouldRefire");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NotifyWeaponFinishedFiring;
    /// <summary>
    /// Function: NotifyWeaponFinishedFiring
    /// </summary>
    public unsafe virtual void NotifyWeaponFinishedFiring(byte FireMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyWeaponFinishedFiring, "Engine.Weapon.NotifyWeaponFinishedFiring");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyWeaponFired;
    /// <summary>
    /// Function: NotifyWeaponFired
    /// </summary>
    public unsafe virtual void NotifyWeaponFired(byte FireMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyWeaponFired, "Engine.Weapon.NotifyWeaponFired");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleFinishedFiring;
    /// <summary>
    /// Function: HandleFinishedFiring
    /// </summary>
    public unsafe virtual void HandleFinishedFiring()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleFinishedFiring, "Engine.Weapon.HandleFinishedFiring");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryPutDown;
    /// <summary>
    /// Function: TryPutDown
    /// </summary>
    public unsafe virtual bool TryPutDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryPutDown, "Engine.Weapon.TryPutDown");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPhysicalFireStartLoc;
    /// <summary>
    /// Function: GetPhysicalFireStartLoc
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPhysicalFireStartLoc(System.Numerics.Vector3 AimDir = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPhysicalFireStartLoc, "Engine.Weapon.GetPhysicalFireStartLoc");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDir, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetMuzzleLoc;
    /// <summary>
    /// Function: GetMuzzleLoc
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetMuzzleLoc()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMuzzleLoc, "Engine.Weapon.GetMuzzleLoc");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CustomFire;
    /// <summary>
    /// Function: CustomFire
    /// </summary>
    public unsafe virtual void CustomFire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CustomFire, "Engine.Weapon.CustomFire");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProjectileFire;
    /// <summary>
    /// Function: ProjectileFire
    /// </summary>
    public unsafe virtual BmSDK.Engine.Projectile ProjectileFire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProjectileFire, "Engine.Weapon.ProjectileFire");
        byte* paramsPtr = stackalloc byte[176];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Projectile>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ProcessInstantHit;
    /// <summary>
    /// Function: ProcessInstantHit
    /// </summary>
    public unsafe virtual void ProcessInstantHit(byte FiringMode, BmSDK.Engine.Actor.FImpactInfo Impact, int NumHits = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessInstantHit, "Engine.Weapon.ProcessInstantHit");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FiringMode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Impact, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumHits, paramsPtr + 100);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InstantFire;
    /// <summary>
    /// Function: InstantFire
    /// </summary>
    public unsafe virtual void InstantFire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstantFire, "Engine.Weapon.InstantFire");
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PassThroughDamage;
    /// <summary>
    /// Function: PassThroughDamage
    /// </summary>
    public unsafe static bool PassThroughDamage(BmSDK.Engine.Actor HitActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PassThroughDamage, "Engine.Weapon.PassThroughDamage");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CalcWeaponFire;
    /// <summary>
    /// Function: CalcWeaponFire
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor.FImpactInfo CalcWeaponFire(System.Numerics.Vector3 StartTrace, System.Numerics.Vector3 EndTrace, out BmSDK.TArray<BmSDK.Engine.Actor.FImpactInfo> ImpactList, System.Numerics.Vector3 Extent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalcWeaponFire, "Engine.Weapon.CalcWeaponFire");
        byte* paramsPtr = stackalloc byte[364];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTrace, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndTrace, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ImpactList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FImpactInfo>>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FImpactInfo>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_GetTraceOwner;
    /// <summary>
    /// Function: GetTraceOwner
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetTraceOwner()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTraceOwner, "Engine.Weapon.GetTraceOwner");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTraceRange;
    /// <summary>
    /// Function: GetTraceRange
    /// </summary>
    public unsafe virtual float GetTraceRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTraceRange, "Engine.Weapon.GetTraceRange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAdjustedAim;
    /// <summary>
    /// Function: GetAdjustedAim
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetAdjustedAim(System.Numerics.Vector3 StartFireLoc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAdjustedAim, "Engine.Weapon.GetAdjustedAim");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartFireLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_FireAmmunition;
    /// <summary>
    /// Function: FireAmmunition
    /// </summary>
    public unsafe virtual void FireAmmunition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireAmmunition, "Engine.Weapon.FireAmmunition");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireModeUpdated;
    /// <summary>
    /// Function: FireModeUpdated
    /// </summary>
    public unsafe virtual void FireModeUpdated(byte FiringMode, bool bViaReplication)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireModeUpdated, "Engine.Weapon.FireModeUpdated");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FiringMode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bViaReplication, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentFireMode;
    /// <summary>
    /// Function: SetCurrentFireMode
    /// </summary>
    public unsafe virtual void SetCurrentFireMode(byte FiringModeNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentFireMode, "Engine.Weapon.SetCurrentFireMode");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FiringModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendToFiringState;
    /// <summary>
    /// Function: SendToFiringState
    /// </summary>
    public unsafe virtual void SendToFiringState(byte FireModeNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendToFiringState, "Engine.Weapon.SendToFiringState");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceEndFire;
    /// <summary>
    /// Function: ForceEndFire
    /// </summary>
    public unsafe virtual void ForceEndFire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceEndFire, "Engine.Weapon.ForceEndFire");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndFire;
    /// <summary>
    /// Function: EndFire
    /// </summary>
    public unsafe virtual void EndFire(byte FireModeNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndFire, "Engine.Weapon.EndFire");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerStopFire;
    /// <summary>
    /// Function: ServerStopFire
    /// </summary>
    public unsafe virtual void ServerStopFire(byte FireModeNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerStopFire, "Engine.Weapon.ServerStopFire");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopFire;
    /// <summary>
    /// Function: StopFire
    /// </summary>
    public unsafe virtual void StopFire(byte FireModeNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFire, "Engine.Weapon.StopFire");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginFire;
    /// <summary>
    /// Function: BeginFire
    /// </summary>
    public unsafe virtual void BeginFire(byte FireModeNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginFire, "Engine.Weapon.BeginFire");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerStartFire;
    /// <summary>
    /// Function: ServerStartFire
    /// </summary>
    public unsafe virtual void ServerStartFire(byte FireModeNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerStartFire, "Engine.Weapon.ServerStartFire");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartFire;
    /// <summary>
    /// Function: StartFire
    /// </summary>
    public unsafe virtual void StartFire(byte FireModeNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFire, "Engine.Weapon.StartFire");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientWeaponSet;
    /// <summary>
    /// Function: ClientWeaponSet
    /// </summary>
    public unsafe virtual void ClientWeaponSet(bool bOptionalSet, bool bDoNotActivate = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientWeaponSet, "Engine.Weapon.ClientWeaponSet");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOptionalSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoNotActivate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientGivenTo;
    /// <summary>
    /// Function: ClientGivenTo
    /// </summary>
    public unsafe override void ClientGivenTo(BmSDK.Engine.Pawn NewOwner, bool bDoNotActivate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientGivenTo, "Engine.Weapon.ClientGivenTo");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoNotActivate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetachWeapon;
    /// <summary>
    /// Function: DetachWeapon
    /// </summary>
    public unsafe virtual void DetachWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachWeapon, "Engine.Weapon.DetachWeapon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachWeaponTo;
    /// <summary>
    /// Function: AttachWeaponTo
    /// </summary>
    public unsafe virtual void AttachWeaponTo(BmSDK.Engine.SkeletalMeshComponent MeshCpnt, BmSDK.FName SocketName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachWeaponTo, "Engine.Weapon.AttachWeaponTo");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshCpnt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SocketName, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearFlashLocation;
    /// <summary>
    /// Function: ClearFlashLocation
    /// </summary>
    public unsafe virtual void ClearFlashLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFlashLocation, "Engine.Weapon.ClearFlashLocation");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFlashLocation;
    /// <summary>
    /// Function: SetFlashLocation
    /// </summary>
    public unsafe virtual void SetFlashLocation(System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFlashLocation, "Engine.Weapon.SetFlashLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearFlashCount;
    /// <summary>
    /// Function: ClearFlashCount
    /// </summary>
    public unsafe virtual void ClearFlashCount()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFlashCount, "Engine.Weapon.ClearFlashCount");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncrementFlashCount;
    /// <summary>
    /// Function: IncrementFlashCount
    /// </summary>
    public unsafe virtual void IncrementFlashCount()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncrementFlashCount, "Engine.Weapon.IncrementFlashCount");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponEmpty;
    /// <summary>
    /// Function: WeaponEmpty
    /// </summary>
    public unsafe virtual void WeaponEmpty()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponEmpty, "Engine.Weapon.WeaponEmpty");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DenyPickupQuery;
    /// <summary>
    /// Function: DenyPickupQuery
    /// </summary>
    public unsafe override bool DenyPickupQuery(BmSDK.Class ItemClass, BmSDK.Engine.Actor Pickup)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DenyPickupQuery, "Engine.Weapon.DenyPickupQuery");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pickup, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_PutDownWeapon;
    /// <summary>
    /// Function: PutDownWeapon
    /// </summary>
    public unsafe virtual void PutDownWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PutDownWeapon, "Engine.Weapon.PutDownWeapon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Activate;
    /// <summary>
    /// Function: Activate
    /// </summary>
    public unsafe virtual void Activate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Activate, "Engine.Weapon.Activate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimeWeaponEquipping;
    /// <summary>
    /// Function: TimeWeaponEquipping
    /// </summary>
    public unsafe virtual void TimeWeaponEquipping()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimeWeaponEquipping, "Engine.Weapon.TimeWeaponEquipping");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimeWeaponPutDown;
    /// <summary>
    /// Function: TimeWeaponPutDown
    /// </summary>
    public unsafe virtual void TimeWeaponPutDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimeWeaponPutDown, "Engine.Weapon.TimeWeaponPutDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefireCheckTimer;
    /// <summary>
    /// Function: RefireCheckTimer
    /// </summary>
    public unsafe virtual void RefireCheckTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefireCheckTimer, "Engine.Weapon.RefireCheckTimer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimeWeaponFiring;
    /// <summary>
    /// Function: TimeWeaponFiring
    /// </summary>
    public unsafe virtual void TimeWeaponFiring(byte FireModeNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimeWeaponFiring, "Engine.Weapon.TimeWeaponFiring");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFireInterval;
    /// <summary>
    /// Function: GetFireInterval
    /// </summary>
    public unsafe virtual float GetFireInterval(byte FireModeNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFireInterval, "Engine.Weapon.GetFireInterval");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StopFireEffects;
    /// <summary>
    /// Function: StopFireEffects
    /// </summary>
    public unsafe virtual void StopFireEffects(byte FireModeNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFireEffects, "Engine.Weapon.StopFireEffects");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFireEffects;
    /// <summary>
    /// Function: PlayFireEffects
    /// </summary>
    public unsafe virtual void PlayFireEffects(byte FireModeNum, System.Numerics.Vector3 HitLocation = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFireEffects, "Engine.Weapon.PlayFireEffects");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopWeaponAnimation;
    /// <summary>
    /// Function: StopWeaponAnimation
    /// </summary>
    public unsafe virtual void StopWeaponAnimation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopWeaponAnimation, "Engine.Weapon.StopWeaponAnimation");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayWeaponAnimation;
    /// <summary>
    /// Function: PlayWeaponAnimation
    /// </summary>
    public unsafe virtual void PlayWeaponAnimation(BmSDK.FName Sequence, float fDesiredDuration, bool bLoop = default, BmSDK.Engine.SkeletalMeshComponent SkelMesh = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayWeaponAnimation, "Engine.Weapon.PlayWeaponAnimation");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Sequence, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDesiredDuration, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLoop, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWeaponAnimNodeSeq;
    /// <summary>
    /// Function: GetWeaponAnimNodeSeq
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimNodeSequence GetWeaponAnimNodeSeq()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponAnimNodeSeq, "Engine.Weapon.GetWeaponAnimNodeSeq");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimNodeSequence>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FireOnRelease;
    /// <summary>
    /// Function: FireOnRelease
    /// </summary>
    public unsafe virtual bool FireOnRelease()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireOnRelease, "Engine.Weapon.FireOnRelease");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanAttack;
    /// <summary>
    /// Function: CanAttack
    /// </summary>
    public unsafe virtual bool CanAttack(BmSDK.Engine.Actor Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanAttack, "Engine.Weapon.CanAttack");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetWeaponRating;
    /// <summary>
    /// Function: GetWeaponRating
    /// </summary>
    public unsafe virtual float GetWeaponRating()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponRating, "Engine.Weapon.GetWeaponRating");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAIRating;
    /// <summary>
    /// Function: GetAIRating
    /// </summary>
    public unsafe virtual float GetAIRating()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAIRating, "Engine.Weapon.GetAIRating");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MaxRange;
    /// <summary>
    /// Function: MaxRange
    /// </summary>
    public unsafe virtual float MaxRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MaxRange, "Engine.Weapon.MaxRange");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AddSpread;
    /// <summary>
    /// Function: AddSpread
    /// </summary>
    public unsafe virtual BmSDK.Rotator AddSpread(BmSDK.Rotator BaseAim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSpread, "Engine.Weapon.AddSpread");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseAim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetProjectileClass;
    /// <summary>
    /// Function: GetProjectileClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetProjectileClass()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProjectileClass, "Engine.Weapon.GetProjectileClass");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearPendingFire;
    /// <summary>
    /// Function: ClearPendingFire
    /// </summary>
    public unsafe virtual void ClearPendingFire(int FireMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPendingFire, "Engine.Weapon.ClearPendingFire");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPendingFire;
    /// <summary>
    /// Function: SetPendingFire
    /// </summary>
    public unsafe virtual void SetPendingFire(int FireMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPendingFire, "Engine.Weapon.SetPendingFire");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PendingFire;
    /// <summary>
    /// Function: PendingFire
    /// </summary>
    public unsafe virtual bool PendingFire(int FireMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PendingFire, "Engine.Weapon.PendingFire");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPendingFireLength;
    /// <summary>
    /// Function: GetPendingFireLength
    /// </summary>
    public unsafe virtual int GetPendingFireLength()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPendingFireLength, "Engine.Weapon.GetPendingFireLength");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasAnyAmmo;
    /// <summary>
    /// Function: HasAnyAmmo
    /// </summary>
    public unsafe virtual bool HasAnyAmmo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasAnyAmmo, "Engine.Weapon.HasAnyAmmo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasAmmo;
    /// <summary>
    /// Function: HasAmmo
    /// </summary>
    public unsafe virtual bool HasAmmo(byte FireModeNum, int Amount = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasAmmo, "Engine.Weapon.HasAmmo");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AddAmmo;
    /// <summary>
    /// Function: AddAmmo
    /// </summary>
    public unsafe virtual int AddAmmo(int Amount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddAmmo, "Engine.Weapon.AddAmmo");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ConsumeAmmo;
    /// <summary>
    /// Function: ConsumeAmmo
    /// </summary>
    public unsafe virtual void ConsumeAmmo(byte FireModeNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConsumeAmmo, "Engine.Weapon.ConsumeAmmo");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWeaponDebug;
    /// <summary>
    /// Function: GetWeaponDebug
    /// </summary>
    public unsafe virtual void GetWeaponDebug(out BmSDK.TArray<BmSDK.FString> DebugInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponDebug, "Engine.Weapon.GetWeaponDebug");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DebugInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayDebug;
    /// <summary>
    /// Function: DisplayDebug
    /// </summary>
    public unsafe override void DisplayDebug(BmSDK.Engine.HUD HUD, out float out_YL, out float out_YPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayDebug, "Engine.Weapon.DisplayDebug");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HUD, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_YL);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_YL, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_YPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_YPos, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_YL = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        out_YPos = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_DenyClientWeaponSet;
    /// <summary>
    /// Function: DenyClientWeaponSet
    /// </summary>
    public unsafe virtual bool DenyClientWeaponSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DenyClientWeaponSet, "Engine.Weapon.DenyClientWeaponSet");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsFiring;
    /// <summary>
    /// Function: IsFiring
    /// </summary>
    public unsafe virtual bool IsFiring()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFiring, "Engine.Weapon.IsFiring");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClientWeaponThrown;
    /// <summary>
    /// Function: ClientWeaponThrown
    /// </summary>
    public unsafe virtual void ClientWeaponThrown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientWeaponThrown, "Engine.Weapon.ClientWeaponThrown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanThrow;
    /// <summary>
    /// Function: CanThrow
    /// </summary>
    public unsafe virtual bool CanThrow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanThrow, "Engine.Weapon.CanThrow");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DropFrom;
    /// <summary>
    /// Function: DropFrom
    /// </summary>
    public unsafe override void DropFrom(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 StartVelocity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropFrom, "Engine.Weapon.DropFrom");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartVelocity, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoOverridePrevWeapon;
    /// <summary>
    /// Function: DoOverridePrevWeapon
    /// </summary>
    public unsafe virtual bool DoOverridePrevWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoOverridePrevWeapon, "Engine.Weapon.DoOverridePrevWeapon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DoOverrideNextWeapon;
    /// <summary>
    /// Function: DoOverrideNextWeapon
    /// </summary>
    public unsafe virtual bool DoOverrideNextWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoOverrideNextWeapon, "Engine.Weapon.DoOverrideNextWeapon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HolderDied;
    /// <summary>
    /// Function: HolderDied
    /// </summary>
    public unsafe virtual void HolderDied()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HolderDied, "Engine.Weapon.HolderDied");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ItemRemovedFromInvManager;
    /// <summary>
    /// Function: ItemRemovedFromInvManager
    /// </summary>
    public unsafe override void ItemRemovedFromInvManager()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemRemovedFromInvManager, "Engine.Weapon.ItemRemovedFromInvManager");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "Engine.Weapon.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ByteProperty: CurrentFireMode
    /// </summary>
    public unsafe byte CurrentFireMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ArrayProperty: FiringStatesArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> FiringStatesArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ArrayProperty: WeaponFireTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Weapon.EWeaponFireType> WeaponFireTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Weapon.EWeaponFireType>>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ArrayProperty: WeaponProjectiles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> WeaponProjectiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ArrayProperty: FireInterval
    /// </summary>
    public unsafe BmSDK.TArray<float> FireInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ArrayProperty: Spread
    /// </summary>
    public unsafe BmSDK.TArray<float> Spread
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ArrayProperty: InstantHitDamage
    /// </summary>
    public unsafe BmSDK.TArray<float> InstantHitDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ArrayProperty: InstantHitMomentum
    /// </summary>
    public unsafe BmSDK.TArray<float> InstantHitMomentum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ArrayProperty: InstantHitDamageTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> InstantHitDamageTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// FloatProperty: EquipTime
    /// </summary>
    public unsafe float EquipTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// FloatProperty: PutDownTime
    /// </summary>
    public unsafe float PutDownTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// StructProperty: FireOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FireOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 924);

    /// <summary>
    /// BoolProperty: bWeaponPutDown
    /// </summary>
    public unsafe bool bWeaponPutDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bCanThrow
    /// </summary>
    public unsafe bool bCanThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bWasOptionalSet
    /// </summary>
    public unsafe bool bWasOptionalSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bWasDoNotActivate
    /// </summary>
    public unsafe bool bWasDoNotActivate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bInstantHit
    /// </summary>
    public unsafe bool bInstantHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bMeleeWeapon
    /// </summary>
    public unsafe bool bMeleeWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: WeaponRange
    /// </summary>
    public unsafe float WeaponRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.MeshComponent Mesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MeshComponent>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// FloatProperty: DefaultAnimSpeed
    /// </summary>
    public unsafe float DefaultAnimSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: Priority
    /// </summary>
    public unsafe float Priority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ObjectProperty: AIController
    /// </summary>
    public unsafe BmSDK.Engine.AIController AIController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AIController>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ArrayProperty: ShouldFireOnRelease
    /// </summary>
    public unsafe BmSDK.TArray<byte> ShouldFireOnRelease
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// FloatProperty: AIRating
    /// </summary>
    public unsafe float AIRating
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// FloatProperty: CachedMaxRange
    /// </summary>
    public unsafe float CachedMaxRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// Enum: EWeaponFireType
    /// </summary>
    public enum EWeaponFireType : byte
    {
        EWFT_InstantHit = 0,
        EWFT_Projectile = 1,
        EWFT_Custom = 2,
        EWFT_None = 3,
        EWFT_MAX = 4,
    }
}
