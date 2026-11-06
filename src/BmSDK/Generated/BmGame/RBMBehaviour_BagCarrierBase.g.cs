#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_BagCarrierBase<br/>
/// (size = 692)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_BagCarrierBase : BmSDK.BmGame.RBMBehaviour_DoorHandler, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_BagCarrierBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMBehaviour_BagCarrierBase.
    /// </summary>
    public static RBMBehaviour_BagCarrierBase DefaultObject => (RBMBehaviour_BagCarrierBase)StaticClass().DefaultObject;

    internal RBMBehaviour_BagCarrierBase() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_BagCarrierBase
    /// </summary>
    public RBMBehaviour_BagCarrierBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_BagCarrierBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_BagCarrierBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_BagCarrierBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_BagCarrierBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_BagCarrierBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_BagCarrierBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_BagCarrierBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_BagCarrierBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_BagCarrierBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_BagCarrierBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ShouldStopAndShootPlayer;
    /// <summary>
    /// Function: ShouldStopAndShootPlayer
    /// </summary>
    public unsafe virtual bool ShouldStopAndShootPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldStopAndShootPlayer, "BmGame.RBMBehaviour_BagCarrierBase.ShouldStopAndShootPlayer");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsLongWayFromDropoff;
    /// <summary>
    /// Function: IsLongWayFromDropoff
    /// </summary>
    public unsafe virtual bool IsLongWayFromDropoff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLongWayFromDropoff, "BmGame.RBMBehaviour_BagCarrierBase.IsLongWayFromDropoff");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDistFromDropoff;
    /// <summary>
    /// Function: GetDistFromDropoff
    /// </summary>
    public unsafe virtual float GetDistFromDropoff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDistFromDropoff, "BmGame.RBMBehaviour_BagCarrierBase.GetDistFromDropoff");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetOverridingDropOffPoint;
    /// <summary>
    /// Function: SetOverridingDropOffPoint
    /// </summary>
    public unsafe virtual void SetOverridingDropOffPoint(BmSDK.BmGame.RLootDestinationBase dropoffPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOverridingDropOffPoint, "BmGame.RBMBehaviour_BagCarrierBase.SetOverridingDropOffPoint");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dropoffPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOverridingPickupPoint;
    /// <summary>
    /// Function: SetOverridingPickupPoint
    /// </summary>
    public unsafe virtual void SetOverridingPickupPoint(BmSDK.BmGame.RLootSourceBase PickupPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOverridingPickupPoint, "BmGame.RBMBehaviour_BagCarrierBase.SetOverridingPickupPoint");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PickupPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockCurrentDropoffPoint;
    /// <summary>
    /// Function: UnlockCurrentDropoffPoint
    /// </summary>
    public unsafe virtual void UnlockCurrentDropoffPoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockCurrentDropoffPoint, "BmGame.RBMBehaviour_BagCarrierBase.UnlockCurrentDropoffPoint");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockPickupPoints;
    /// <summary>
    /// Function: UnlockPickupPoints
    /// </summary>
    public unsafe virtual void UnlockPickupPoints()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockPickupPoints, "BmGame.RBMBehaviour_BagCarrierBase.UnlockPickupPoints");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBeginInterrupt, "BmGame.RBMBehaviour_BagCarrierBase.OnBeginInterrupt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDeactivate;
    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeactivate, "BmGame.RBMBehaviour_BagCarrierBase.OnDeactivate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bRunningToExit
    /// </summary>
    public unsafe bool bRunningToExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// BoolProperty: bCountsAsAttackingForAttackAEC
    /// </summary>
    public unsafe bool bCountsAsAttackingForAttackAEC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// ObjectProperty: bag
    /// </summary>
    public unsafe BmSDK.BmGame.RCarriableObjectBagBase bag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCarriableObjectBagBase>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }
}
