#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RRiotObject<br/>
/// (size = 848)
/// (flags = 10486290)
/// </summary>
public partial class RRiotObject : BmSDK.BmGame.RRiotObjectBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RRiotObject", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RRiotObject.
    /// </summary>
    public static RRiotObject DefaultObject => (RRiotObject)StaticClass().DefaultObject;

    internal RRiotObject() { }

    /// <summary>
    /// Constructs a new RRiotObject
    /// </summary>
    public RRiotObject(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRiotObject(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRiotObject>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRiotObject>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRiotObject>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRiotObject>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRiotObject>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRiotObject>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRiotObject>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRiotObject>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_HammerBeatingFx;
    /// <summary>
    /// Function: HammerBeatingFx
    /// </summary>
    public unsafe virtual void HammerBeatingFx()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HammerBeatingFx, "BmScript.RRiotObject.HammerBeatingFx");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopWelding;
    /// <summary>
    /// Function: StopWelding
    /// </summary>
    public unsafe virtual void StopWelding()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopWelding, "BmScript.RRiotObject.StopWelding");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartWelding;
    /// <summary>
    /// Function: StartWelding
    /// </summary>
    public unsafe virtual void StartWelding()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartWelding, "BmScript.RRiotObject.StartWelding");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopGrinding;
    /// <summary>
    /// Function: StopGrinding
    /// </summary>
    public unsafe virtual void StopGrinding()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopGrinding, "BmScript.RRiotObject.StopGrinding");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartGrinding;
    /// <summary>
    /// Function: StartGrinding
    /// </summary>
    public unsafe virtual void StartGrinding()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGrinding, "BmScript.RRiotObject.StartGrinding");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopSprayCan;
    /// <summary>
    /// Function: StopSprayCan
    /// </summary>
    public unsafe virtual void StopSprayCan()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSprayCan, "BmScript.RRiotObject.StopSprayCan");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSprayCan;
    /// <summary>
    /// Function: StartSprayCan
    /// </summary>
    public unsafe virtual void StartSprayCan()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSprayCan, "BmScript.RRiotObject.StartSprayCan");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IgniteFlare;
    /// <summary>
    /// Function: IgniteFlare
    /// </summary>
    public unsafe virtual void IgniteFlare(bool bForMilitia)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IgniteFlare, "BmScript.RRiotObject.IgniteFlare");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForMilitia, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExplodeMolotov;
    /// <summary>
    /// Function: ExplodeMolotov
    /// </summary>
    public unsafe virtual void ExplodeMolotov()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExplodeMolotov, "BmScript.RRiotObject.ExplodeMolotov");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IgniteMolotov;
    /// <summary>
    /// Function: IgniteMolotov
    /// </summary>
    public unsafe virtual void IgniteMolotov()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IgniteMolotov, "BmScript.RRiotObject.IgniteMolotov");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPickup;
    /// <summary>
    /// Function: SetPickup
    /// </summary>
    public unsafe override void SetPickup(BmSDK.BmGame.RAnimNotify_PickupProp PickType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPickup, "BmScript.RRiotObject.SetPickup");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PickType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFlare;
    /// <summary>
    /// Function: SetFlare
    /// </summary>
    public unsafe virtual void SetFlare()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFlare, "BmScript.RRiotObject.SetFlare");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMolotov;
    /// <summary>
    /// Function: SetMolotov
    /// </summary>
    public unsafe virtual void SetMolotov()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMolotov, "BmScript.RRiotObject.SetMolotov");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetStone;
    /// <summary>
    /// Function: SetStone
    /// </summary>
    public unsafe virtual void SetStone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStone, "BmScript.RRiotObject.SetStone");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBrick;
    /// <summary>
    /// Function: SetBrick
    /// </summary>
    public unsafe virtual void SetBrick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBrick, "BmScript.RRiotObject.SetBrick");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSpraycan;
    /// <summary>
    /// Function: SetSpraycan
    /// </summary>
    public unsafe virtual void SetSpraycan()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSpraycan, "BmScript.RRiotObject.SetSpraycan");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPipe;
    /// <summary>
    /// Function: SetPipe
    /// </summary>
    public unsafe virtual void SetPipe()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPipe, "BmScript.RRiotObject.SetPipe");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_canDestroy;
    /// <summary>
    /// Function: canDestroy
    /// </summary>
    public unsafe override bool canDestroy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_canDestroy, "BmScript.RRiotObject.canDestroy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DropObject;
    /// <summary>
    /// Function: DropObject
    /// </summary>
    public unsafe override void DropObject(BmSDK.BmGame.RAnimNotify_PickupProp DropNotify)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropObject, "BmScript.RRiotObject.DropObject");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DropNotify, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopAllFx;
    /// <summary>
    /// Function: StopAllFx
    /// </summary>
    public unsafe override void StopAllFx()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAllFx, "BmScript.RRiotObject.StopAllFx");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: MolotovFlamePfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem MolotovFlamePfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ObjectProperty: MolotovExplodePfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem MolotovExplodePfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ObjectProperty: FlareFlameMilitiaArch
    /// </summary>
    public unsafe BmSDK.Engine.Emitter FlareFlameMilitiaArch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ObjectProperty: SpraycanSprayPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SpraycanSprayPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// ObjectProperty: GrindingPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GrindingPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// ObjectProperty: WeldingPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WeldingPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ObjectProperty: HammerBeatingPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HammerBeatingPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ArrayProperty: FlareFlameArch
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Emitter> FlareFlameArch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Emitter>>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// FloatProperty: SprayColourRand
    /// </summary>
    public unsafe float SprayColourRand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: bPFX1AttachedToMesh
    /// </summary>
    public unsafe bool bPFX1AttachedToMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 844); }
    }

    /// <summary>
    /// BoolProperty: bPFX2AttachedToMesh
    /// </summary>
    public unsafe bool bPFX2AttachedToMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 844); }
    }

    /// <summary>
    /// BoolProperty: bStopFXOnDrop
    /// </summary>
    public unsafe bool bStopFXOnDrop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 844); }
    }
}
