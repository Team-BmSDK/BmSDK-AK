#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_Attack_WatchAndWait<br/>
/// (size = 764)
/// (flags = 10485778)
/// </summary>
public partial class RAEC_Attack_WatchAndWait : BmSDK.BmGame.RAlertEventCoordinatorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Attack_WatchAndWait", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_Attack_WatchAndWait.
    /// </summary>
    public static RAEC_Attack_WatchAndWait DefaultObject => (RAEC_Attack_WatchAndWait)StaticClass().DefaultObject;

    internal RAEC_Attack_WatchAndWait() { }

    /// <summary>
    /// Constructs a new RAEC_Attack_WatchAndWait
    /// </summary>
    public RAEC_Attack_WatchAndWait(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Attack_WatchAndWait(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_WatchAndWait>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_WatchAndWait>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_WatchAndWait>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_WatchAndWait>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_WatchAndWait>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_WatchAndWait>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_WatchAndWait>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_WatchAndWait>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetRandomThugToSpeak;
    /// <summary>
    /// Function: GetRandomThugToSpeak
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIController GetRandomThugToSpeak()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRandomThugToSpeak, "BmGame.RAEC_Attack_WatchAndWait.GetRandomThugToSpeak");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIController>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryGrenadeThrow;
    /// <summary>
    /// Function: TryGrenadeThrow
    /// </summary>
    public unsafe virtual bool TryGrenadeThrow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryGrenadeThrow, "BmGame.RAEC_Attack_WatchAndWait.TryGrenadeThrow");
        byte* paramsPtr = stackalloc byte[96];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SecondGrenade;
    /// <summary>
    /// Function: SecondGrenade
    /// </summary>
    public unsafe virtual void SecondGrenade()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SecondGrenade, "BmGame.RAEC_Attack_WatchAndWait.SecondGrenade");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnoughWatchersAreInPosition;
    /// <summary>
    /// Function: EnoughWatchersAreInPosition
    /// </summary>
    public unsafe virtual bool EnoughWatchersAreInPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnoughWatchersAreInPosition, "BmGame.RAEC_Attack_WatchAndWait.EnoughWatchersAreInPosition");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FirstGrenadeFinished;
    /// <summary>
    /// Function: FirstGrenadeFinished
    /// </summary>
    public unsafe virtual void FirstGrenadeFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FirstGrenadeFinished, "BmGame.RAEC_Attack_WatchAndWait.FirstGrenadeFinished");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddVentGrenadier;
    /// <summary>
    /// Function: AddVentGrenadier
    /// </summary>
    public unsafe virtual void AddVentGrenadier(BmSDK.BmGame.RBMAIController VentThrowCon, System.Numerics.Vector3 StandPos, BmSDK.BmGame.RTunnelFunnel VentGrenadeTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddVentGrenadier, "BmGame.RAEC_Attack_WatchAndWait.AddVentGrenadier");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VentThrowCon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StandPos, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VentGrenadeTarget, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddWatcherOnFence;
    /// <summary>
    /// Function: AddWatcherOnFence
    /// </summary>
    public unsafe virtual void AddWatcherOnFence(BmSDK.BmGame.RBMAIController C, BmSDK.BmGame.RBMPathNode_FenceJumpProxy NewFence)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddWatcherOnFence, "BmGame.RAEC_Attack_WatchAndWait.AddWatcherOnFence");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFence, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddWatcherWithPosition;
    /// <summary>
    /// Function: AddWatcherWithPosition
    /// </summary>
    public unsafe virtual void AddWatcherWithPosition(BmSDK.BmGame.RBMAIController C, System.Numerics.Vector3 NewPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddWatcherWithPosition, "BmGame.RAEC_Attack_WatchAndWait.AddWatcherWithPosition");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPos, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddWatcher;
    /// <summary>
    /// Function: AddWatcher
    /// </summary>
    public unsafe virtual void AddWatcher(BmSDK.BmGame.RBMAIController C)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddWatcher, "BmGame.RAEC_Attack_WatchAndWait.AddWatcher");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RAEC_Attack_WatchAndWait.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWatchTarget;
    /// <summary>
    /// Function: SetWatchTarget
    /// </summary>
    public unsafe virtual void SetWatchTarget(System.Numerics.Vector3 NewWatchTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWatchTarget, "BmGame.RAEC_Attack_WatchAndWait.SetWatchTarget");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWatchTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignGrenadeLobber;
    /// <summary>
    /// Function: AssignGrenadeLobber
    /// </summary>
    public unsafe virtual void AssignGrenadeLobber(BmSDK.BmGame.RAEC_Attack_Sub_LobGrenade FinishedGrenAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignGrenadeLobber, "BmGame.RAEC_Attack_WatchAndWait.AssignGrenadeLobber");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedGrenAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRemoveSoloChild;
    /// <summary>
    /// Function: OnRemoveSoloChild
    /// </summary>
    public unsafe override void OnRemoveSoloChild(BmSDK.BmGame.RAlertEventCoordinatorSolo RemAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRemoveSoloChild, "BmGame.RAEC_Attack_WatchAndWait.OnRemoveSoloChild");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: WatchTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WatchTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 720);

    /// <summary>
    /// FloatProperty: WatchDuration
    /// </summary>
    public unsafe float WatchDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// FloatProperty: WatchTimer
    /// </summary>
    public unsafe float WatchTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: ReleaseTimer
    /// </summary>
    public unsafe float ReleaseTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: AEC_LobGrenade
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_Sub_LobGrenade AEC_LobGrenade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_Sub_LobGrenade>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// ObjectProperty: AEC_GrenInVent
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_Sub_ThrowGrenadeInVent AEC_GrenInVent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_Sub_ThrowGrenadeInVent>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bCanThrowGrenade
    /// </summary>
    public unsafe bool bCanThrowGrenade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bBarkOnDisperse
    /// </summary>
    public unsafe bool bBarkOnDisperse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }
}
