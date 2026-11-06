#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RBMPathNode_SpecialMove<br/>
/// (size = 976)
/// (flags = 144704147)
/// </summary>
public partial class RBMPathNode_SpecialMove : BmSDK.BmGame.RPathNode, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMPathNode_SpecialMove", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMPathNode_SpecialMove.
    /// </summary>
    public static RBMPathNode_SpecialMove DefaultObject => (RBMPathNode_SpecialMove)StaticClass().DefaultObject;

    internal RBMPathNode_SpecialMove() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMPathNode_SpecialMove(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPathNode_SpecialMove>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPathNode_SpecialMove>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPathNode_SpecialMove>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPathNode_SpecialMove>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPathNode_SpecialMove>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPathNode_SpecialMove>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPathNode_SpecialMove>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPathNode_SpecialMove>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UnlockSlot;
    /// <summary>
    /// Function: UnlockSlot
    /// </summary>
    public unsafe virtual void UnlockSlot(BmSDK.BmGame.RPawn User)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockSlot, "BmGame.RBMPathNode_SpecialMove.UnlockSlot");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(User, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDynamicMoveSlotFor;
    /// <summary>
    /// Function: GetDynamicMoveSlotFor
    /// </summary>
    public unsafe virtual bool GetDynamicMoveSlotFor(BmSDK.BmGame.RPawn User, System.Numerics.Vector3 DestPoint, out System.Numerics.Vector3 SlotLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDynamicMoveSlotFor, "BmGame.RBMPathNode_SpecialMove.GetDynamicMoveSlotFor");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(User, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestPoint, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SlotLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_ReachedBy;
    /// <summary>
    /// Function: ReachedBy
    /// </summary>
    public unsafe virtual bool ReachedBy(BmSDK.BmGame.RPawn TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReachedBy, "BmGame.RBMPathNode_SpecialMove.ReachedBy");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetUsePosition;
    /// <summary>
    /// Function: GetUsePosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetUsePosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUsePosition, "BmGame.RBMPathNode_SpecialMove.GetUsePosition");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanUseSpecialMoveNode;
    /// <summary>
    /// Function: CanUseSpecialMoveNode
    /// </summary>
    public unsafe virtual bool CanUseSpecialMoveNode(BmSDK.BmGame.RBMAIController User)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseSpecialMoveNode, "BmGame.RBMPathNode_SpecialMove.CanUseSpecialMoveNode");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(User, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// IntProperty: NodesInSpecialMove
    /// </summary>
    public unsafe int NodesInSpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ObjectProperty: PairedNode
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPathNode_SpecialMove PairedNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPathNode_SpecialMove>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }
}
