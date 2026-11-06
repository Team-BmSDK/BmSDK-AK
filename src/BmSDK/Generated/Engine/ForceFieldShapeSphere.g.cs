#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ForceFieldShapeSphere<br/>
/// (size = 92)
/// (flags = 142610578)
/// </summary>
public partial class ForceFieldShapeSphere : BmSDK.Engine.ForceFieldShape, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ForceFieldShapeSphere", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as ForceFieldShapeSphere.
    /// </summary>
    public static ForceFieldShapeSphere DefaultObject => (ForceFieldShapeSphere)StaticClass().DefaultObject;

    internal ForceFieldShapeSphere() { }

    /// <summary>
    /// Constructs a new ForceFieldShapeSphere
    /// </summary>
    public ForceFieldShapeSphere(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ForceFieldShapeSphere Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ForceFieldShapeSphere(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ForceFieldShapeSphere>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ForceFieldShapeSphere>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ForceFieldShapeSphere>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ForceFieldShapeSphere>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ForceFieldShapeSphere>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ForceFieldShapeSphere>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ForceFieldShapeSphere>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ForceFieldShapeSphere>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetDrawComponent;
    /// <summary>
    /// Function: GetDrawComponent
    /// </summary>
    public unsafe override BmSDK.Engine.PrimitiveComponent GetDrawComponent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDrawComponent, "Engine.ForceFieldShapeSphere.GetDrawComponent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PrimitiveComponent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FillByCylinder;
    /// <summary>
    /// Function: FillByCylinder
    /// </summary>
    public unsafe override void FillByCylinder(float BottomRadius, float TopRadius, float Height, float HeightOffset)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FillByCylinder, "Engine.ForceFieldShapeSphere.FillByCylinder");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BottomRadius, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TopRadius, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Height, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeightOffset, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FillByCapsule;
    /// <summary>
    /// Function: FillByCapsule
    /// </summary>
    public unsafe override void FillByCapsule(float Height, float Radius)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FillByCapsule, "Engine.ForceFieldShapeSphere.FillByCapsule");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Height, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FillByBox;
    /// <summary>
    /// Function: FillByBox
    /// </summary>
    public unsafe override void FillByBox(System.Numerics.Vector3 Extent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FillByBox, "Engine.ForceFieldShapeSphere.FillByBox");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FillBySphere;
    /// <summary>
    /// Function: FillBySphere
    /// </summary>
    public unsafe override void FillBySphere(float Radius)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FillBySphere, "Engine.ForceFieldShapeSphere.FillBySphere");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRadius;
    /// <summary>
    /// Function: GetRadius
    /// </summary>
    public unsafe virtual float GetRadius()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRadius, "Engine.ForceFieldShapeSphere.GetRadius");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    /// <summary>
    /// ComponentProperty: Shape
    /// </summary>
    public unsafe BmSDK.Engine.DrawSphereComponent Shape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DrawSphereComponent>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
