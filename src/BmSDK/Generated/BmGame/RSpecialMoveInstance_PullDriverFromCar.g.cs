#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveInstance_PullDriverFromCar<br/>
/// (size = 1016)
/// (flags = 10485778)
/// </summary>
public partial class RSpecialMoveInstance_PullDriverFromCar : BmSDK.BmGame.RSpecialMoveInstance_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveInstance_PullDriverFromCar", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMoveInstance_PullDriverFromCar.
    /// </summary>
    public static RSpecialMoveInstance_PullDriverFromCar DefaultObject => (RSpecialMoveInstance_PullDriverFromCar)StaticClass().DefaultObject;

    internal RSpecialMoveInstance_PullDriverFromCar() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_PullDriverFromCar
    /// </summary>
    public RSpecialMoveInstance_PullDriverFromCar(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_PullDriverFromCar(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_PullDriverFromCar>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_PullDriverFromCar>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_PullDriverFromCar>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_PullDriverFromCar>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_PullDriverFromCar>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_PullDriverFromCar>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_PullDriverFromCar>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_PullDriverFromCar>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_StopAnimFollowingCar;
    /// <summary>
    /// Function: StopAnimFollowingCar
    /// </summary>
    public unsafe virtual void StopAnimFollowingCar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAnimFollowingCar, "BmGame.RSpecialMoveInstance_PullDriverFromCar.StopAnimFollowingCar");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WatchCar;
    /// <summary>
    /// Function: WatchCar
    /// </summary>
    public unsafe virtual void WatchCar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WatchCar, "BmGame.RSpecialMoveInstance_PullDriverFromCar.WatchCar");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExplodeBonnet;
    /// <summary>
    /// Function: ExplodeBonnet
    /// </summary>
    public unsafe virtual void ExplodeBonnet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExplodeBonnet, "BmGame.RSpecialMoveInstance_PullDriverFromCar.ExplodeBonnet");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PunchWindowRHand;
    /// <summary>
    /// Function: PunchWindowRHand
    /// </summary>
    public unsafe virtual void PunchWindowRHand()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PunchWindowRHand, "BmGame.RSpecialMoveInstance_PullDriverFromCar.PunchWindowRHand");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PunchWindowLHand;
    /// <summary>
    /// Function: PunchWindowLHand
    /// </summary>
    public unsafe virtual void PunchWindowLHand()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PunchWindowLHand, "BmGame.RSpecialMoveInstance_PullDriverFromCar.PunchWindowLHand");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AboutToJumpOff;
    /// <summary>
    /// Function: AboutToJumpOff
    /// </summary>
    public unsafe virtual void AboutToJumpOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AboutToJumpOff, "BmGame.RSpecialMoveInstance_PullDriverFromCar.AboutToJumpOff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TargetGoRagdoll;
    /// <summary>
    /// Function: TargetGoRagdoll
    /// </summary>
    public unsafe virtual void TargetGoRagdoll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargetGoRagdoll, "BmGame.RSpecialMoveInstance_PullDriverFromCar.TargetGoRagdoll");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlipCar;
    /// <summary>
    /// Function: FlipCar
    /// </summary>
    public unsafe virtual void FlipCar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlipCar, "BmGame.RSpecialMoveInstance_PullDriverFromCar.FlipCar");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DriverRescued;
    /// <summary>
    /// Function: DriverRescued
    /// </summary>
    public unsafe virtual void DriverRescued()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DriverRescued, "BmGame.RSpecialMoveInstance_PullDriverFromCar.DriverRescued");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateSpecialMove;
    /// <summary>
    /// Function: UpdateSpecialMove
    /// </summary>
    public unsafe override bool UpdateSpecialMove(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSpecialMove, "BmGame.RSpecialMoveInstance_PullDriverFromCar.UpdateSpecialMove");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PunchWindow;
    /// <summary>
    /// Function: PunchWindow
    /// </summary>
    public unsafe virtual void PunchWindow(BmSDK.FName BoneName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PunchWindow, "BmGame.RSpecialMoveInstance_PullDriverFromCar.PunchWindow");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishSpecialMove;
    /// <summary>
    /// Function: FinishSpecialMove
    /// </summary>
    public unsafe override void FinishSpecialMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishSpecialMove, "BmGame.RSpecialMoveInstance_PullDriverFromCar.FinishSpecialMove");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerSpecialMove;
    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe override void TriggerSpecialMove(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSpecialMove, "BmGame.RSpecialMoveInstance_PullDriverFromCar.TriggerSpecialMove");
        byte* paramsPtr = stackalloc byte[148];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PickRandomAnim;
    /// <summary>
    /// Function: PickRandomAnim
    /// </summary>
    public unsafe override void PickRandomAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickRandomAnim, "BmGame.RSpecialMoveInstance_PullDriverFromCar.PickRandomAnim");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: DriverTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId DriverTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 988);

    /// <summary>
    /// ObjectProperty: Driver
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI Driver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// BoolProperty: bDriverFinished
    /// </summary>
    public unsafe bool bDriverFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1000) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1000); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1000); }
    }

    /// <summary>
    /// BoolProperty: bStopAligningWithCar
    /// </summary>
    public unsafe bool bStopAligningWithCar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1000) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1000); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1000); }
    }

    /// <summary>
    /// StructProperty: UpdatedReferenceRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator UpdatedReferenceRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1004);
}
