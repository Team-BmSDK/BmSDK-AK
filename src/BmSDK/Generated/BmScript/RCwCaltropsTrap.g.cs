#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCwCaltropsTrap<br/>
/// (size = 796)
/// (flags = 10485778)
/// </summary>
public partial class RCwCaltropsTrap : BmSDK.BmGame.RCwCaltropsTrapBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCwCaltropsTrap", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCwCaltropsTrap.
    /// </summary>
    public static RCwCaltropsTrap DefaultObject => (RCwCaltropsTrap)StaticClass().DefaultObject;

    internal RCwCaltropsTrap() { }

    /// <summary>
    /// Constructs a new RCwCaltropsTrap
    /// </summary>
    public RCwCaltropsTrap(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCwCaltropsTrap(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwCaltropsTrap>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwCaltropsTrap>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwCaltropsTrap>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwCaltropsTrap>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwCaltropsTrap>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwCaltropsTrap>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwCaltropsTrap>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwCaltropsTrap>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_StartleNearbyThugs;
    /// <summary>
    /// Function: StartleNearbyThugs
    /// </summary>
    public unsafe virtual void StartleNearbyThugs(BmSDK.BmGame.RPawnVillain Victim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartleNearbyThugs, "BmScript.RCwCaltropsTrap.StartleNearbyThugs");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawCollisionCylinders;
    /// <summary>
    /// Function: DrawCollisionCylinders
    /// </summary>
    public unsafe virtual void DrawCollisionCylinders()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawCollisionCylinders, "BmScript.RCwCaltropsTrap.DrawCollisionCylinders");
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Swipe;
    /// <summary>
    /// Function: Swipe
    /// </summary>
    public unsafe virtual void Swipe()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Swipe, "BmScript.RCwCaltropsTrap.Swipe");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugStartsSwiping;
    /// <summary>
    /// Function: ThugStartsSwiping
    /// </summary>
    public unsafe override void ThugStartsSwiping(BmSDK.BmGame.RPawnVillain Villain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugStartsSwiping, "BmScript.RCwCaltropsTrap.ThugStartsSwiping");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsThugAwareOfCaltrops;
    /// <summary>
    /// Function: IsThugAwareOfCaltrops
    /// </summary>
    public unsafe virtual bool IsThugAwareOfCaltrops(BmSDK.BmGame.RPawnVillain Villain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsThugAwareOfCaltrops, "BmScript.RCwCaltropsTrap.IsThugAwareOfCaltrops");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SpreadCaltrops;
    /// <summary>
    /// Function: SpreadCaltrops
    /// </summary>
    public unsafe virtual void SpreadCaltrops(BmSDK.BmGame.RPawnVillain touchVillain, bool bSwiping = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpreadCaltrops, "BmScript.RCwCaltropsTrap.SpreadCaltrops");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(touchVillain, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSwiping, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateTouchingCaltrops;
    /// <summary>
    /// Function: ActivateTouchingCaltrops
    /// </summary>
    public unsafe virtual void ActivateTouchingCaltrops(BmSDK.BmGame.RPawnVillain touchVillain, bool bSwiping = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateTouchingCaltrops, "BmScript.RCwCaltropsTrap.ActivateTouchingCaltrops");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(touchVillain, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSwiping, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.RCwCaltropsTrap.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmScript.RCwCaltropsTrap.Destroyed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroySelf;
    /// <summary>
    /// Function: DestroySelf
    /// </summary>
    public unsafe virtual void DestroySelf()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroySelf, "BmScript.RCwCaltropsTrap.DestroySelf");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnActivated;
    /// <summary>
    /// Function: OnActivated
    /// </summary>
    public unsafe virtual void OnActivated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivated, "BmScript.RCwCaltropsTrap.OnActivated");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartleNearbyThugsTimer;
    /// <summary>
    /// Function: StartleNearbyThugsTimer
    /// </summary>
    public unsafe virtual void StartleNearbyThugsTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartleNearbyThugsTimer, "BmScript.RCwCaltropsTrap.StartleNearbyThugsTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetStartleNearbyThugsDelayed;
    /// <summary>
    /// Function: SetStartleNearbyThugsDelayed
    /// </summary>
    public unsafe virtual void SetStartleNearbyThugsDelayed(BmSDK.BmGame.RPawnVillain Villain, float Delay = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStartleNearbyThugsDelayed, "BmScript.RCwCaltropsTrap.SetStartleNearbyThugsDelayed");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delay, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnTouchVillain;
    /// <summary>
    /// Function: OnTouchVillain
    /// </summary>
    public unsafe virtual void OnTouchVillain(BmSDK.BmGame.RPawnVillain touchVillain, BmSDK.BmScript.RCwCaltropsProjectile caltropsInFlight, System.Numerics.Vector3 LaunchPosition = default, bool bLaunchedFromGarg = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnTouchVillain, "BmScript.RCwCaltropsTrap.OnTouchVillain");
        byte* paramsPtr = stackalloc byte[308];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(touchVillain, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(caltropsInFlight, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLaunchedFromGarg, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckPreviouslyIgnoredVillains;
    /// <summary>
    /// Function: CheckPreviouslyIgnoredVillains
    /// </summary>
    public unsafe virtual void CheckPreviouslyIgnoredVillains()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckPreviouslyIgnoredVillains, "BmScript.RCwCaltropsTrap.CheckPreviouslyIgnoredVillains");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Touch;
    /// <summary>
    /// Function: Touch
    /// </summary>
    public unsafe override void Touch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Touch, "BmScript.RCwCaltropsTrap.Touch");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishedCylinderUpdates;
    /// <summary>
    /// Function: FinishedCylinderUpdates
    /// </summary>
    public unsafe override void FinishedCylinderUpdates()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedCylinderUpdates, "BmScript.RCwCaltropsTrap.FinishedCylinderUpdates");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.RCwCaltropsTrap.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bActivated
    /// </summary>
    public unsafe bool bActivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 740); }
    }

    /// <summary>
    /// BoolProperty: bTrapGettingSwiped
    /// </summary>
    public unsafe bool bTrapGettingSwiped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 740); }
    }

    /// <summary>
    /// BoolProperty: bPerformedMove
    /// </summary>
    public unsafe bool bPerformedMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 740); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawCylinders
    /// </summary>
    public unsafe bool bDebugDrawCylinders
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 740); }
    }

    /// <summary>
    /// FloatProperty: PostActivationDestroyPause
    /// </summary>
    public unsafe float PostActivationDestroyPause
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: PostActivationDestroyDelay
    /// </summary>
    public unsafe float PostActivationDestroyDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: CaltropsTrapActivateSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CaltropsTrapActivateSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// ObjectProperty: RifleHitReactionAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet RifleHitReactionAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// ObjectProperty: UnarmedHitReactionAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet UnarmedHitReactionAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ObjectProperty: Swiper
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain Swiper
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ObjectProperty: LastVillainStartleNearbyThugs
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain LastVillainStartleNearbyThugs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceActivated
    /// </summary>
    public unsafe float TimeSinceActivated
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }
}
