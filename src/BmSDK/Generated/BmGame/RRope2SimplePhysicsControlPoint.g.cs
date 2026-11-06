#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRope2SimplePhysicsControlPoint<br/>
/// (size = 92)
/// (flags = 134217874)
/// </summary>
public partial class RRope2SimplePhysicsControlPoint : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRope2SimplePhysicsControlPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RRope2SimplePhysicsControlPoint.
    /// </summary>
    public static RRope2SimplePhysicsControlPoint DefaultObject => (RRope2SimplePhysicsControlPoint)StaticClass().DefaultObject;

    internal RRope2SimplePhysicsControlPoint() { }

    /// <summary>
    /// Constructs a new RRope2SimplePhysicsControlPoint
    /// </summary>
    public RRope2SimplePhysicsControlPoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRope2SimplePhysicsControlPoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRope2SimplePhysicsControlPoint(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRope2SimplePhysicsControlPoint>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRope2SimplePhysicsControlPoint>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRope2SimplePhysicsControlPoint>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRope2SimplePhysicsControlPoint>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRope2SimplePhysicsControlPoint>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRope2SimplePhysicsControlPoint>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRope2SimplePhysicsControlPoint>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRope2SimplePhysicsControlPoint>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_Invalidate;
    /// <summary>
    /// Function: Invalidate
    /// </summary>
    public unsafe virtual void Invalidate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Invalidate, "BmGame.RRope2SimplePhysicsControlPoint.Invalidate");
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

    private static BmSDK.Function __fn_GetIsValid;
    /// <summary>
    /// Function: GetIsValid
    /// </summary>
    public unsafe virtual bool GetIsValid()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIsValid, "BmGame.RRope2SimplePhysicsControlPoint.GetIsValid");
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

    private static BmSDK.Function __fn_SetVelocity;
    /// <summary>
    /// Function: SetVelocity
    /// </summary>
    public unsafe virtual void SetVelocity(out System.Numerics.Vector3 NewVelocity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVelocity, "BmGame.RRope2SimplePhysicsControlPoint.SetVelocity");
        byte* paramsPtr = stackalloc byte[12];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewVelocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVelocity, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NewVelocity = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetVelocity;
    /// <summary>
    /// Function: GetVelocity
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetVelocity()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVelocity, "BmGame.RRope2SimplePhysicsControlPoint.GetVelocity");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetPosition;
    /// <summary>
    /// Function: SetPosition
    /// </summary>
    public unsafe virtual void SetPosition(out System.Numerics.Vector3 NewPosition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPosition, "BmGame.RRope2SimplePhysicsControlPoint.SetPosition");
        byte* paramsPtr = stackalloc byte[12];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPosition, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NewPosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetPosition;
    /// <summary>
    /// Function: GetPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPosition, "BmGame.RRope2SimplePhysicsControlPoint.GetPosition");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearForces;
    /// <summary>
    /// Function: ClearForces
    /// </summary>
    public unsafe virtual void ClearForces()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearForces, "BmGame.RRope2SimplePhysicsControlPoint.ClearForces");
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

    private static BmSDK.Function __fn_ApplyImpulse;
    /// <summary>
    /// Function: ApplyImpulse
    /// </summary>
    public unsafe virtual void ApplyImpulse(out System.Numerics.Vector3 ImpulseToApply)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyImpulse, "BmGame.RRope2SimplePhysicsControlPoint.ApplyImpulse");
        byte* paramsPtr = stackalloc byte[12];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ImpulseToApply);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpulseToApply, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ImpulseToApply = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyForce;
    /// <summary>
    /// Function: ApplyForce
    /// </summary>
    public unsafe virtual void ApplyForce(out System.Numerics.Vector3 ForceToApply)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyForce, "BmGame.RRope2SimplePhysicsControlPoint.ApplyForce");
        byte* paramsPtr = stackalloc byte[12];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ForceToApply);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceToApply, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ForceToApply = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetControlPointPhysicsType;
    /// <summary>
    /// Function: SetControlPointPhysicsType
    /// </summary>
    public unsafe virtual void SetControlPointPhysicsType(BmSDK.BmGame.RRope2SimplePhysicsControlPoint.ControlPointPhysicsType NewPhysicsType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetControlPointPhysicsType, "BmGame.RRope2SimplePhysicsControlPoint.SetControlPointPhysicsType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPhysicsType, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetControlPointPhysicsType;
    /// <summary>
    /// Function: GetControlPointPhysicsType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RRope2SimplePhysicsControlPoint.ControlPointPhysicsType GetControlPointPhysicsType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetControlPointPhysicsType, "BmGame.RRope2SimplePhysicsControlPoint.GetControlPointPhysicsType");
        byte* paramsPtr = stackalloc byte[1];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint.ControlPointPhysicsType>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: ControlPointPhysicsType
    /// </summary>
    public enum ControlPointPhysicsType : byte
    {
        ROPE2SIMPLECONTROLPOINTTYPE_Dynamic = 0,
        ROPE2SIMPLECONTROLPOINTTYPE_Fixed = 1,
        ROPE2SIMPLECONTROLPOINTTYPE_MAX = 2,
    }

    /// <summary>
    /// StructProperty: ControlPointPhysicsNode
    /// </summary>
    public unsafe System.IntPtr ControlPointPhysicsNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
