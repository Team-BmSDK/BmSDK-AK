#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RFreezeClusterGrenade<br/>
/// (size = 2676)
/// (flags = 144703667)
/// </summary>
public partial class RFreezeClusterGrenade : BmSDK.BmGame.RProjectileGadgetBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RFreezeClusterGrenade", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RFreezeClusterGrenade.
    /// </summary>
    public static RFreezeClusterGrenade DefaultObject => (RFreezeClusterGrenade)StaticClass().DefaultObject;

    internal RFreezeClusterGrenade() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFreezeClusterGrenade(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezeClusterGrenade>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeClusterGrenade>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezeClusterGrenade>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeClusterGrenade>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeClusterGrenade>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeClusterGrenade>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezeClusterGrenade>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeClusterGrenade>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RFreezeClusterGrenade.Destroyed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRoomChange;
    /// <summary>
    /// Function: OnRoomChange
    /// </summary>
    public unsafe override void OnRoomChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRoomChange, "BmGame.RFreezeClusterGrenade.OnRoomChange");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Throw;
    /// <summary>
    /// Function: Throw
    /// </summary>
    public unsafe override bool Throw(bool bSecondary = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Throw, "BmGame.RFreezeClusterGrenade.Throw");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSecondary, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnIceSphere;
    /// <summary>
    /// Function: SpawnIceSphere
    /// </summary>
    public unsafe virtual void SpawnIceSphere(System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnIceSphere, "BmGame.RFreezeClusterGrenade.SpawnIceSphere");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoFloorBlastEffects;
    /// <summary>
    /// Function: DoFloorBlastEffects
    /// </summary>
    public unsafe virtual void DoFloorBlastEffects(System.Numerics.Vector3 Position, bool bNoGroundParticles = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoFloorBlastEffects, "BmGame.RFreezeClusterGrenade.DoFloorBlastEffects");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoGroundParticles, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitFloorBlastVictims;
    /// <summary>
    /// Function: HitFloorBlastVictims
    /// </summary>
    public unsafe virtual bool HitFloorBlastVictims(System.Numerics.Vector3 CheckLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitFloorBlastVictims, "BmGame.RFreezeClusterGrenade.HitFloorBlastVictims");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_FreezeVictimLegs;
    /// <summary>
    /// Function: FreezeVictimLegs
    /// </summary>
    public unsafe virtual bool FreezeVictimLegs(BmSDK.BmGame.RPawnVillain Victim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FreezeVictimLegs, "BmGame.RFreezeClusterGrenade.FreezeVictimLegs");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanFreezeVillain;
    /// <summary>
    /// Function: CanFreezeVillain
    /// </summary>
    public unsafe virtual bool CanFreezeVillain(BmSDK.BmGame.RPawnVillain V)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanFreezeVillain, "BmGame.RFreezeClusterGrenade.CanFreezeVillain");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TriggerFreezeBlastHitEvent;
    /// <summary>
    /// Function: TriggerFreezeBlastHitEvent
    /// </summary>
    public unsafe virtual void TriggerFreezeBlastHitEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerFreezeBlastHitEvent, "BmGame.RFreezeClusterGrenade.TriggerFreezeBlastHitEvent");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayThrowSound;
    /// <summary>
    /// Function: PlayThrowSound
    /// </summary>
    public unsafe virtual void PlayThrowSound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayThrowSound, "BmGame.RFreezeClusterGrenade.PlayThrowSound");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThrowProjectile;
    /// <summary>
    /// Function: ThrowProjectile
    /// </summary>
    public unsafe override void ThrowProjectile()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowProjectile, "BmGame.RFreezeClusterGrenade.ThrowProjectile");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachToHand;
    /// <summary>
    /// Function: AttachToHand
    /// </summary>
    public unsafe override void AttachToHand(BmSDK.FName CustomBone = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachToHand, "BmGame.RFreezeClusterGrenade.AttachToHand");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomBone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyClusterTraps;
    /// <summary>
    /// Function: DestroyClusterTraps
    /// </summary>
    public unsafe virtual void DestroyClusterTraps()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyClusterTraps, "BmGame.RFreezeClusterGrenade.DestroyClusterTraps");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnFreezeAll;
    /// <summary>
    /// Function: UnFreezeAll
    /// </summary>
    public unsafe virtual void UnFreezeAll(bool bIgnoreRaft = default, BmSDK.BmGame.RPawnVillain IgnoreVillain = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnFreezeAll, "BmGame.RFreezeClusterGrenade.UnFreezeAll");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreRaft, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreVillain, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckAutoTarget;
    /// <summary>
    /// Function: CheckAutoTarget
    /// </summary>
    public unsafe override bool CheckAutoTarget(BmSDK.Engine.Actor Target, out System.Numerics.Vector3 TargetPosition, out float OverridePriority, out float OverrideMaxRange, out byte DoLOSCheck)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAutoTarget, "BmGame.RFreezeClusterGrenade.CheckAutoTarget");
        byte* paramsPtr = stackalloc byte[36];
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

    private static BmSDK.Function __fn_RemovePendingIceRaftProjectile;
    /// <summary>
    /// Function: RemovePendingIceRaftProjectile
    /// </summary>
    public unsafe virtual void RemovePendingIceRaftProjectile(BmSDK.BmGame.RFreezeClusterGrenadeProjectile Projectile)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemovePendingIceRaftProjectile, "BmGame.RFreezeClusterGrenade.RemovePendingIceRaftProjectile");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Projectile, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPendingIceRaftProjectile;
    /// <summary>
    /// Function: AddPendingIceRaftProjectile
    /// </summary>
    public unsafe virtual void AddPendingIceRaftProjectile(BmSDK.BmGame.RFreezeClusterGrenadeProjectile Projectile)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPendingIceRaftProjectile, "BmGame.RFreezeClusterGrenade.AddPendingIceRaftProjectile");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Projectile, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveClusterTrap;
    /// <summary>
    /// Function: RemoveClusterTrap
    /// </summary>
    public unsafe virtual void RemoveClusterTrap(BmSDK.BmGame.RFreezeClusterTrapBase Trap)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveClusterTrap, "BmGame.RFreezeClusterGrenade.RemoveClusterTrap");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Trap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddClusterTrap;
    /// <summary>
    /// Function: AddClusterTrap
    /// </summary>
    public unsafe virtual void AddClusterTrap(BmSDK.BmGame.RFreezeClusterTrapBase Trap)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddClusterTrap, "BmGame.RFreezeClusterGrenade.AddClusterTrap");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Trap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveFrozenVillain;
    /// <summary>
    /// Function: RemoveFrozenVillain
    /// </summary>
    public unsafe virtual void RemoveFrozenVillain(BmSDK.BmGame.RPawnVillain Villain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveFrozenVillain, "BmGame.RFreezeClusterGrenade.RemoveFrozenVillain");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFrozenVillain;
    /// <summary>
    /// Function: AddFrozenVillain
    /// </summary>
    public unsafe virtual void AddFrozenVillain(BmSDK.BmGame.RPawnVillain Villain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFrozenVillain, "BmGame.RFreezeClusterGrenade.AddFrozenVillain");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RFreezeClusterGrenade.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStopFreezeIceBubbleAkEvent;
    /// <summary>
    /// Function: GetStopFreezeIceBubbleAkEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetStopFreezeIceBubbleAkEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStopFreezeIceBubbleAkEvent, "BmGame.RFreezeClusterGrenade.GetStopFreezeIceBubbleAkEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPlayFreezeIceBubbleAkEvent;
    /// <summary>
    /// Function: GetPlayFreezeIceBubbleAkEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetPlayFreezeIceBubbleAkEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayFreezeIceBubbleAkEvent, "BmGame.RFreezeClusterGrenade.GetPlayFreezeIceBubbleAkEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: ThrowSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ThrowSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// ObjectProperty: IceExplodeEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem IceExplodeEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// ObjectProperty: GroundBlastParticles
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GroundBlastParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// ObjectProperty: FloorBlastSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FloorBlastSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// ArrayProperty: FrozenVillains
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> FrozenVillains
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// ArrayProperty: PendingProjectiles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RFreezeClusterGrenadeProjectile> PendingProjectiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RFreezeClusterGrenadeProjectile>>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// ArrayProperty: ClusterTraps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RFreezeClusterTrapBase> ClusterTraps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RFreezeClusterTrapBase>>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// FloatProperty: BlastRadius
    /// </summary>
    public unsafe float BlastRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }
}
