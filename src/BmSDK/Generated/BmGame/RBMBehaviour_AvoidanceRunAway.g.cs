#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_AvoidanceRunAway<br/>
/// (size = 1148)
/// (flags = 134226066)
/// </summary>
public partial class RBMBehaviour_AvoidanceRunAway : BmSDK.BmGame.RBMBehaviour_GangMovementBaseBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_AvoidanceRunAway", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMBehaviour_AvoidanceRunAway.
    /// </summary>
    public static RBMBehaviour_AvoidanceRunAway DefaultObject => (RBMBehaviour_AvoidanceRunAway)StaticClass().DefaultObject;

    internal RBMBehaviour_AvoidanceRunAway() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_AvoidanceRunAway
    /// </summary>
    public RBMBehaviour_AvoidanceRunAway(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_AvoidanceRunAway Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_AvoidanceRunAway(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_AvoidanceRunAway>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_AvoidanceRunAway>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_AvoidanceRunAway>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_AvoidanceRunAway>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_AvoidanceRunAway>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_AvoidanceRunAway>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_AvoidanceRunAway>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_AvoidanceRunAway>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UnAwareOfPlayer;
    /// <summary>
    /// Function: UnAwareOfPlayer
    /// </summary>
    public unsafe override bool UnAwareOfPlayer(BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnAwareOfPlayer, "BmGame.RBMBehaviour_AvoidanceRunAway.UnAwareOfPlayer");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AwareOfPlayer;
    /// <summary>
    /// Function: AwareOfPlayer
    /// </summary>
    public unsafe override bool AwareOfPlayer(BmSDK.Engine.Actor Player, BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwareOfPlayer, "BmGame.RBMBehaviour_AvoidanceRunAway.AwareOfPlayer");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetThoughts;
    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe override void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmGame.RBMBehaviour_AvoidanceRunAway.GetThoughts");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_OnDeactivate;
    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeactivate, "BmGame.RBMBehaviour_AvoidanceRunAway.OnDeactivate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickIsDisabledStateChanged;
    /// <summary>
    /// Function: TickIsDisabledStateChanged
    /// </summary>
    public unsafe override void TickIsDisabledStateChanged(bool bTickIsDisabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickIsDisabledStateChanged, "BmGame.RBMBehaviour_AvoidanceRunAway.TickIsDisabledStateChanged");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTickIsDisabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableAutomaticTransitions;
    /// <summary>
    /// Function: DisableAutomaticTransitions
    /// </summary>
    public unsafe virtual void DisableAutomaticTransitions()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableAutomaticTransitions, "BmGame.RBMBehaviour_AvoidanceRunAway.DisableAutomaticTransitions");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickCower;
    /// <summary>
    /// Function: TickCower
    /// </summary>
    public unsafe virtual void TickCower(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickCower, "BmGame.RBMBehaviour_AvoidanceRunAway.TickCower");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveUpAndCower;
    /// <summary>
    /// Function: GiveUpAndCower
    /// </summary>
    public unsafe virtual void GiveUpAndCower()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveUpAndCower, "BmGame.RBMBehaviour_AvoidanceRunAway.GiveUpAndCower");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetClosestThug;
    /// <summary>
    /// Function: SetClosestThug
    /// </summary>
    public unsafe virtual void SetClosestThug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClosestThug, "BmGame.RBMBehaviour_AvoidanceRunAway.SetClosestThug");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTimeOffscreen;
    /// <summary>
    /// Function: GetTimeOffscreen
    /// </summary>
    public unsafe virtual float GetTimeOffscreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeOffscreen, "BmGame.RBMBehaviour_AvoidanceRunAway.GetTimeOffscreen");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateThreatAndDestroyCheck;
    /// <summary>
    /// Function: UpdateThreatAndDestroyCheck
    /// </summary>
    public unsafe virtual bool UpdateThreatAndDestroyCheck(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateThreatAndDestroyCheck, "BmGame.RBMBehaviour_AvoidanceRunAway.UpdateThreatAndDestroyCheck");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StopRunningAtPlayer;
    /// <summary>
    /// Function: StopRunningAtPlayer
    /// </summary>
    public unsafe virtual void StopRunningAtPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopRunningAtPlayer, "BmGame.RBMBehaviour_AvoidanceRunAway.StopRunningAtPlayer");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnEndInterrupt;
    /// <summary>
    /// Function: OnEndInterrupt
    /// </summary>
    public unsafe override void OnEndInterrupt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEndInterrupt, "BmGame.RBMBehaviour_AvoidanceRunAway.OnEndInterrupt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBeginInterrupt;
    /// <summary>
    /// Function: OnBeginInterrupt
    /// </summary>
    public unsafe override void OnBeginInterrupt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBeginInterrupt, "BmGame.RBMBehaviour_AvoidanceRunAway.OnBeginInterrupt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_JumpOverVehicle;
    /// <summary>
    /// Function: JumpOverVehicle
    /// </summary>
    public unsafe virtual bool JumpOverVehicle(BmSDK.BmGame.RVehicle Vehicle, System.Numerics.Vector3 MoveInDirection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JumpOverVehicle, "BmGame.RBMBehaviour_AvoidanceRunAway.JumpOverVehicle");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vehicle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveInDirection, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_JumpOverProp;
    /// <summary>
    /// Function: JumpOverProp
    /// </summary>
    public unsafe virtual bool JumpOverProp(BmSDK.BmGame.RDestructibleProp Prop, System.Numerics.Vector3 MoveInDirection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JumpOverProp, "BmGame.RBMBehaviour_AvoidanceRunAway.JumpOverProp");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prop, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveInDirection, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetRunToPointForLinkFromPosition;
    /// <summary>
    /// Function: GetRunToPointForLinkFromPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRunToPointForLinkFromPosition(int LinkStartID, int LinkEndID, int RoadLink, System.Numerics.Vector3 CurrentPosition, bool bDebug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRunToPointForLinkFromPosition, "BmGame.RBMBehaviour_AvoidanceRunAway.GetRunToPointForLinkFromPosition");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkStartID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkEndID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RoadLink, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentPosition, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebug, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ShouldStopRunning;
    /// <summary>
    /// Function: ShouldStopRunning
    /// </summary>
    public unsafe virtual bool ShouldStopRunning(System.Numerics.Vector3 MoveDirection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldStopRunning, "BmGame.RBMBehaviour_AvoidanceRunAway.ShouldStopRunning");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDirection, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_TickRunAway;
    /// <summary>
    /// Function: TickRunAway
    /// </summary>
    public unsafe virtual void TickRunAway(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickRunAway, "BmGame.RBMBehaviour_AvoidanceRunAway.TickRunAway");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetRunAwayForce;
    /// <summary>
    /// Function: GetRunAwayForce
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRunAwayForce(float DeltaTime, bool bDebug = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRunAwayForce, "BmGame.RBMBehaviour_AvoidanceRunAway.GetRunAwayForce");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebug, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetRoadDirectionForceForActor;
    /// <summary>
    /// Function: GetRoadDirectionForceForActor
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRoadDirectionForceForActor(int AvoidIdx, bool bDebug = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRoadDirectionForceForActor, "BmGame.RBMBehaviour_AvoidanceRunAway.GetRoadDirectionForceForActor");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvoidIdx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebug, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsValidAnchorVert;
    /// <summary>
    /// Function: IsValidAnchorVert
    /// </summary>
    public unsafe virtual bool IsValidAnchorVert(int VertID, bool bAllowNonFleeLinksFallback = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidAnchorVert, "BmGame.RBMBehaviour_AvoidanceRunAway.IsValidAnchorVert");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VertID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowNonFleeLinksFallback, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetRoadOffset;
    /// <summary>
    /// Function: GetRoadOffset
    /// </summary>
    public unsafe virtual float GetRoadOffset(int CurrPoint, int NextPoint, int Link, bool bLeft)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRoadOffset, "BmGame.RBMBehaviour_AvoidanceRunAway.GetRoadOffset");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextPoint, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLeft, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetAllLinksFromPoint;
    /// <summary>
    /// Function: GetAllLinksFromPoint
    /// </summary>
    public unsafe virtual void GetAllLinksFromPoint(int PointId, out BmSDK.TArray<int> Links, bool bAllowNonFleeLinksFallback)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAllLinksFromPoint, "BmGame.RBMBehaviour_AvoidanceRunAway.GetAllLinksFromPoint");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowNonFleeLinksFallback, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Links = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_GetForceForActor;
    /// <summary>
    /// Function: GetForceForActor
    /// </summary>
    public unsafe virtual bool GetForceForActor(int Idx, out System.Numerics.Vector3 TotalForce, out int TotalInfluencers)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetForceForActor, "BmGame.RBMBehaviour_AvoidanceRunAway.GetForceForActor");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Idx, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TotalForce);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalForce, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TotalInfluencers);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalInfluencers, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        TotalForce = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        TotalInfluencers = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_OverrideGetupStances;
    /// <summary>
    /// Function: OverrideGetupStances
    /// </summary>
    public unsafe override bool OverrideGetupStances(out BmSDK.FName MovementStance, out BmSDK.FName WeaponStance)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideGetupStances, "BmGame.RBMBehaviour_AvoidanceRunAway.OverrideGetupStances");
        byte* paramsPtr = stackalloc byte[20];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MovementStance);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out WeaponStance);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MovementStance = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
        WeaponStance = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsVillainInPositionToPlayFleeBark;
    /// <summary>
    /// Function: IsVillainInPositionToPlayFleeBark
    /// </summary>
    public unsafe virtual bool IsVillainInPositionToPlayFleeBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVillainInPositionToPlayFleeBark, "BmGame.RBMBehaviour_AvoidanceRunAway.IsVillainInPositionToPlayFleeBark");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayFleeReaction;
    /// <summary>
    /// Function: PlayFleeReaction
    /// </summary>
    public unsafe virtual void PlayFleeReaction()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFleeReaction, "BmGame.RBMBehaviour_AvoidanceRunAway.PlayFleeReaction");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddUnpathableLink;
    /// <summary>
    /// Function: AddUnpathableLink
    /// </summary>
    public unsafe virtual void AddUnpathableLink(int StartVertID, int EndVertID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddUnpathableLink, "BmGame.RBMBehaviour_AvoidanceRunAway.AddUnpathableLink");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartVertID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndVertID, paramsPtr + 4);
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

    private static BmSDK.Function __fn_NativePathNotFound;
    /// <summary>
    /// Function: NativePathNotFound
    /// </summary>
    public unsafe virtual void NativePathNotFound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NativePathNotFound, "BmGame.RBMBehaviour_AvoidanceRunAway.NativePathNotFound");
        byte* paramsPtr = stackalloc byte[0];
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

    private static BmSDK.Function __fn_PathNotFound;
    /// <summary>
    /// Function: PathNotFound
    /// </summary>
    public unsafe virtual void PathNotFound(BmSDK.BmGame.RNavigationHandle Handle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathNotFound, "BmGame.RBMBehaviour_AvoidanceRunAway.PathNotFound");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Handle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PathFound;
    /// <summary>
    /// Function: PathFound
    /// </summary>
    public unsafe virtual void PathFound(BmSDK.BmGame.RNavigationHandle Handle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathFound, "BmGame.RBMBehaviour_AvoidanceRunAway.PathFound");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Handle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSearchingPathFind;
    /// <summary>
    /// Function: StartSearchingPathFind
    /// </summary>
    public unsafe virtual void StartSearchingPathFind(System.Numerics.Vector3 RoadPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSearchingPathFind, "BmGame.RBMBehaviour_AvoidanceRunAway.StartSearchingPathFind");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RoadPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AdvanceLinks;
    /// <summary>
    /// Function: AdvanceLinks
    /// </summary>
    public unsafe virtual void AdvanceLinks()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdvanceLinks, "BmGame.RBMBehaviour_AvoidanceRunAway.AdvanceLinks");
        byte* paramsPtr = stackalloc byte[0];
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

    private static BmSDK.Function __fn_SetCurrentLink;
    /// <summary>
    /// Function: SetCurrentLink
    /// </summary>
    public unsafe virtual void SetCurrentLink(BmSDK.BmGame.RBMBehaviour_AvoidanceRunAway.FStoredLink NewLink)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentLink, "BmGame.RBMBehaviour_AvoidanceRunAway.SetCurrentLink");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLink, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetAvoidLocation;
    /// <summary>
    /// Function: GetAvoidLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAvoidLocation(int AvoidIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAvoidLocation, "BmGame.RBMBehaviour_AvoidanceRunAway.GetAvoidLocation");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvoidIdx, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_NativeInit;
    /// <summary>
    /// Function: NativeInit
    /// </summary>
    public unsafe virtual void NativeInit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NativeInit, "BmGame.RBMBehaviour_AvoidanceRunAway.NativeInit");
        byte* paramsPtr = stackalloc byte[0];
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

    private static BmSDK.Function __fn_HasValidStoredLink;
    /// <summary>
    /// Function: HasValidStoredLink
    /// </summary>
    public unsafe virtual bool HasValidStoredLink(int TestLinkID = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasValidStoredLink, "BmGame.RBMBehaviour_AvoidanceRunAway.HasValidStoredLink");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLinkID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ClearStoredLinks;
    /// <summary>
    /// Function: ClearStoredLinks
    /// </summary>
    public unsafe virtual void ClearStoredLinks()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearStoredLinks, "BmGame.RBMBehaviour_AvoidanceRunAway.ClearStoredLinks");
        byte* paramsPtr = stackalloc byte[0];
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

    private static BmSDK.Function __fn_OnActivate;
    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmGame.RBMBehaviour_AvoidanceRunAway.OnActivate");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FValidLink
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FValidLink
    {
        /// <summary>
        /// StructProperty: StartPos
        /// </summary>
        public unsafe System.Numerics.Vector3 StartPos
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: EndPos
        /// </summary>
        public unsafe System.Numerics.Vector3 EndPos
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FInvalidLink
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FInvalidLink
    {
        /// <summary>
        /// IntProperty: StartVert
        /// </summary>
        public unsafe int StartVert
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: EndVert
        /// </summary>
        public unsafe int EndVert
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: PathFails
        /// </summary>
        public unsafe int PathFails
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FStoredLink
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FStoredLink
    {
        /// <summary>
        /// IntProperty: StartID
        /// </summary>
        public unsafe int StartID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: EndID
        /// </summary>
        public unsafe int EndID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: RoadLinkID
        /// </summary>
        public unsafe int RoadLinkID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: EAvoidType
    /// </summary>
    public enum EAvoidType : byte
    {
        AVOID_Player = 0,
        AVOID_ClosestThug = 1,
        AVOID_CustomThreat = 2,
        AVOID_MAX = 3,
    }

    /// <summary>
    /// ArrayProperty: AvoidActorList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_AvoidanceRunAway.FAvoidActor> AvoidActorList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_AvoidanceRunAway.FAvoidActor>>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// StructProperty: OverrideAvoidLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 OverrideAvoidLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 788);

    /// <summary>
    /// FloatProperty: MinWallDist
    /// </summary>
    public unsafe float MinWallDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// FloatProperty: MaxWallDist
    /// </summary>
    public unsafe float MaxWallDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// FloatProperty: WallDistanceCheck
    /// </summary>
    public unsafe float WallDistanceCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// FloatProperty: MinWallForce
    /// </summary>
    public unsafe float MinWallForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: MaxWallForce
    /// </summary>
    public unsafe float MaxWallForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// FloatProperty: WallForce
    /// </summary>
    public unsafe float WallForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// FloatProperty: MaxWallSideForceMultiplier
    /// </summary>
    public unsafe float MaxWallSideForceMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// FloatProperty: CowerWallForce
    /// </summary>
    public unsafe float CowerWallForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// FloatProperty: CowerWallDistanceCheck
    /// </summary>
    public unsafe float CowerWallDistanceCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// StructProperty: FleeReactionID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId FleeReactionID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 836);

    /// <summary>
    /// ObjectProperty: RoadNetwork
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadNetwork RoadNetwork
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// ObjectProperty: CurrentHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle CurrentHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// ObjectProperty: SearchingHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle SearchingHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// FloatProperty: PathForce
    /// </summary>
    public unsafe float PathForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// FloatProperty: MinRoadLookAhead
    /// </summary>
    public unsafe float MinRoadLookAhead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// FloatProperty: MaxRoadLookAhead
    /// </summary>
    public unsafe float MaxRoadLookAhead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// FloatProperty: RoadOffset
    /// </summary>
    public unsafe float RoadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// FloatProperty: MinRoadOffset
    /// </summary>
    public unsafe float MinRoadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// FloatProperty: MaxRoadOffset
    /// </summary>
    public unsafe float MaxRoadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// StructProperty: AnchorVertPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AnchorVertPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 888);

    /// <summary>
    /// StructProperty: NextVertPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 NextVertPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 900);

    /// <summary>
    /// StructProperty: NextUltimateVertPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 NextUltimateVertPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 912);

    /// <summary>
    /// StructProperty: PrevAvoidDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PrevAvoidDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 924);

    /// <summary>
    /// FloatProperty: KeepPrevDestPointCos
    /// </summary>
    public unsafe float KeepPrevDestPointCos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: TimeBehaviourStarted
    /// </summary>
    public unsafe float TimeBehaviourStarted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: TimeHiddenForDestroy
    /// </summary>
    public unsafe float TimeHiddenForDestroy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// FloatProperty: MinDistanceFromThreatToDestroy
    /// </summary>
    public unsafe float MinDistanceFromThreatToDestroy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// FloatProperty: WaitingtoReactTime
    /// </summary>
    public unsafe float WaitingtoReactTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: PlayFleeBarkTimer
    /// </summary>
    public unsafe float PlayFleeBarkTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// FloatProperty: RunningIntoWallTime
    /// </summary>
    public unsafe float RunningIntoWallTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// FloatProperty: GiveUpTime
    /// </summary>
    public unsafe float GiveUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// FloatProperty: RunningAtWallTime
    /// </summary>
    public unsafe float RunningAtWallTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// FloatProperty: EmergencyActionTime
    /// </summary>
    public unsafe float EmergencyActionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// FloatProperty: EmergencyActionHitNormalCos
    /// </summary>
    public unsafe float EmergencyActionHitNormalCos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// FloatProperty: EmergencyActionRecoveryTime
    /// </summary>
    public unsafe float EmergencyActionRecoveryTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// FloatProperty: EmergencyActionRecoveryMaxTime
    /// </summary>
    public unsafe float EmergencyActionRecoveryMaxTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// FloatProperty: MinCowerMoveForce
    /// </summary>
    public unsafe float MinCowerMoveForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: MaxCowerStopForce
    /// </summary>
    public unsafe float MaxCowerStopForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// StructProperty: InitialCowerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 InitialCowerPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 996);

    /// <summary>
    /// StructProperty: InitialCowerAvoidActorOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 InitialCowerAvoidActorOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1008);

    /// <summary>
    /// FloatProperty: RepathCowerMoveStartTime
    /// </summary>
    public unsafe float RepathCowerMoveStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: RepathCowerMoveTime
    /// </summary>
    public unsafe float RepathCowerMoveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: RepathCowerMoveAmount
    /// </summary>
    public unsafe float RepathCowerMoveAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: RepathCowerAvoidActorCosDiff
    /// </summary>
    public unsafe float RepathCowerAvoidActorCosDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bShowDebug
    /// </summary>
    public unsafe bool bShowDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1036) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1036); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1036); }
    }

    /// <summary>
    /// BoolProperty: bHaveSearchedForNextLinks
    /// </summary>
    public unsafe bool bHaveSearchedForNextLinks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1036) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1036); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1036); }
    }

    /// <summary>
    /// BoolProperty: bForceRepathASAP
    /// </summary>
    public unsafe bool bForceRepathASAP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1036) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1036); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1036); }
    }

    /// <summary>
    /// IntProperty: SearchingLinkStartID
    /// </summary>
    public unsafe int SearchingLinkStartID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// IntProperty: SearchingLinkEndID
    /// </summary>
    public unsafe int SearchingLinkEndID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: LastUpdateNextLinkTime
    /// </summary>
    public unsafe float LastUpdateNextLinkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// ArrayProperty: StoredLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_AvoidanceRunAway.FStoredLink> StoredLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_AvoidanceRunAway.FStoredLink>>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ArrayProperty: PreviousLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_AvoidanceRunAway.FStoredLink> PreviousLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_AvoidanceRunAway.FStoredLink>>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// ArrayProperty: InvalidLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_AvoidanceRunAway.FInvalidLink> InvalidLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_AvoidanceRunAway.FInvalidLink>>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ArrayProperty: ValidLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_AvoidanceRunAway.FValidLink> ValidLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_AvoidanceRunAway.FValidLink>>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ArrayProperty: FailedLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_AvoidanceRunAway.FValidLink> FailedLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_AvoidanceRunAway.FValidLink>>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// IntProperty: MaxLinkPathFailsBeforeInvalid
    /// </summary>
    public unsafe int MaxLinkPathFailsBeforeInvalid
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// FloatProperty: InitialRoadOffset
    /// </summary>
    public unsafe float InitialRoadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// FloatProperty: RoadOffsetPerFail
    /// </summary>
    public unsafe float RoadOffsetPerFail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// FloatProperty: TimeHiddenForDestroyInformant
    /// </summary>
    public unsafe float TimeHiddenForDestroyInformant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// Struct: FAvoidActor
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FAvoidActor
    {
        /// <summary>
        /// ObjectProperty: Actor
        /// </summary>
        public unsafe BmSDK.Engine.Actor Actor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: AvoidStrength
        /// </summary>
        public unsafe float AvoidStrength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: AvoidRadius
        /// </summary>
        public unsafe float AvoidRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bAlwaysAvoid
        /// </summary>
        public unsafe bool bAlwaysAvoid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }
    }
}
