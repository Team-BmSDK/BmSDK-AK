#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RTurret_Watchtower<br/>
/// (size = 1696)
/// (flags = 10486290)
/// </summary>
public partial class RTurret_Watchtower : BmSDK.BmGame.RTurret_WatchtowerBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RTurret_Watchtower", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RTurret_Watchtower.
    /// </summary>
    public static RTurret_Watchtower DefaultObject => (RTurret_Watchtower)StaticClass().DefaultObject;

    internal RTurret_Watchtower() { }

    /// <summary>
    /// Constructs a new RTurret_Watchtower
    /// </summary>
    public RTurret_Watchtower(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RTurret_Watchtower(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RTurret_Watchtower>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RTurret_Watchtower>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RTurret_Watchtower>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RTurret_Watchtower>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RTurret_Watchtower>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RTurret_Watchtower>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RTurret_Watchtower>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RTurret_Watchtower>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SuppressDetectiveModeVisibilityThroughWalls;
    /// <summary>
    /// Function: SuppressDetectiveModeVisibilityThroughWalls
    /// </summary>
    public unsafe virtual void SuppressDetectiveModeVisibilityThroughWalls(bool bSuppress)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuppressDetectiveModeVisibilityThroughWalls, "BmScript.RTurret_Watchtower.SuppressDetectiveModeVisibilityThroughWalls");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuppress, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnregisterDMThroughWallsSuppressable;
    /// <summary>
    /// Function: UnregisterDMThroughWallsSuppressable
    /// </summary>
    public unsafe virtual void UnregisterDMThroughWallsSuppressable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterDMThroughWallsSuppressable, "BmScript.RTurret_Watchtower.UnregisterDMThroughWallsSuppressable");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterDMThroughWallsSuppressable;
    /// <summary>
    /// Function: RegisterDMThroughWallsSuppressable
    /// </summary>
    public unsafe virtual void RegisterDMThroughWallsSuppressable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterDMThroughWallsSuppressable, "BmScript.RTurret_Watchtower.RegisterDMThroughWallsSuppressable");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetachFiringComponents;
    /// <summary>
    /// Function: DetachFiringComponents
    /// </summary>
    public unsafe virtual void DetachFiringComponents()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachFiringComponents, "BmScript.RTurret_Watchtower.DetachFiringComponents");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachFiringComponents;
    /// <summary>
    /// Function: AttachFiringComponents
    /// </summary>
    public unsafe override void AttachFiringComponents()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachFiringComponents, "BmScript.RTurret_Watchtower.AttachFiringComponents");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanDamagePlayer;
    /// <summary>
    /// Function: CanDamagePlayer
    /// </summary>
    public unsafe override bool CanDamagePlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDamagePlayer, "BmScript.RTurret_Watchtower.CanDamagePlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldForceMissedShot;
    /// <summary>
    /// Function: ShouldForceMissedShot
    /// </summary>
    public unsafe virtual bool ShouldForceMissedShot(BmSDK.BmGame.RPawnPlayer TargetPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceMissedShot, "BmScript.RTurret_Watchtower.ShouldForceMissedShot");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ClearInvestigateData;
    /// <summary>
    /// Function: ClearInvestigateData
    /// </summary>
    public unsafe override void ClearInvestigateData()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearInvestigateData, "BmScript.RTurret_Watchtower.ClearInvestigateData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoShotFX;
    /// <summary>
    /// Function: DoShotFX
    /// </summary>
    public unsafe override void DoShotFX(System.Numerics.Vector3 TargetLoc, bool bDoImpactFX)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoShotFX, "BmScript.RTurret_Watchtower.DoShotFX");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoImpactFX, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StoppedShooting;
    /// <summary>
    /// Function: StoppedShooting
    /// </summary>
    public unsafe override void StoppedShooting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StoppedShooting, "BmScript.RTurret_Watchtower.StoppedShooting");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartedShooting;
    /// <summary>
    /// Function: StartedShooting
    /// </summary>
    public unsafe override void StartedShooting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartedShooting, "BmScript.RTurret_Watchtower.StartedShooting");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveInvalidTargets;
    /// <summary>
    /// Function: RemoveInvalidTargets
    /// </summary>
    public unsafe override void RemoveInvalidTargets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveInvalidTargets, "BmScript.RTurret_Watchtower.RemoveInvalidTargets");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopsProjectile;
    /// <summary>
    /// Function: StopsProjectile
    /// </summary>
    public unsafe override bool StopsProjectile(BmSDK.Engine.Projectile P, BmSDK.Engine.PrimitiveComponent HitComponent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopsProjectile, "BmScript.RTurret_Watchtower.StopsProjectile");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ShieldCooldown;
    /// <summary>
    /// Function: ShieldCooldown
    /// </summary>
    public unsafe virtual void ShieldCooldown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShieldCooldown, "BmScript.RTurret_Watchtower.ShieldCooldown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Touch;
    /// <summary>
    /// Function: Touch
    /// </summary>
    public unsafe override void Touch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Touch, "BmScript.RTurret_Watchtower.Touch");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WatchtowerTakenOut;
    /// <summary>
    /// Function: WatchtowerTakenOut
    /// </summary>
    public unsafe virtual void WatchtowerTakenOut(bool bForceSilent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WatchtowerTakenOut, "BmScript.RTurret_Watchtower.WatchtowerTakenOut");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceSilent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmScript.RTurret_Watchtower.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmScript.RTurret_Watchtower.PreStreamOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.RTurret_Watchtower.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchOff;
    /// <summary>
    /// Function: SwitchOff
    /// </summary>
    public unsafe override void SwitchOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchOff, "BmScript.RTurret_Watchtower.SwitchOff");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchOn;
    /// <summary>
    /// Function: SwitchOn
    /// </summary>
    public unsafe override void SwitchOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchOn, "BmScript.RTurret_Watchtower.SwitchOn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDisplayTargetLocation;
    /// <summary>
    /// Function: GetDisplayTargetLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetDisplayTargetLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayTargetLocation, "BmScript.RTurret_Watchtower.GetDisplayTargetLocation");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Trigger;
    /// <summary>
    /// Function: Trigger
    /// </summary>
    public unsafe override bool Trigger(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Trigger, "BmScript.RTurret_Watchtower.Trigger");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// BoolProperty: bDMVisThroughWalls_Suppressed
    /// </summary>
    public unsafe bool bDMVisThroughWalls_Suppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1692); }
    }

    /// <summary>
    /// BoolProperty: bDMVisThroughWalls_Old
    /// </summary>
    public unsafe bool bDMVisThroughWalls_Old
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1692); }
    }
}
