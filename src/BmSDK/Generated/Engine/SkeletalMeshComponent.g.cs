#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkeletalMeshComponent<br/>
/// (size = 2648)
/// (flags = 2157973974)
/// </summary>
public partial class SkeletalMeshComponent : BmSDK.Engine.MeshComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkeletalMeshComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as SkeletalMeshComponent.
    /// </summary>
    public static SkeletalMeshComponent DefaultObject => (SkeletalMeshComponent)StaticClass().DefaultObject;

    internal SkeletalMeshComponent() { }

    /// <summary>
    /// Constructs a new SkeletalMeshComponent
    /// </summary>
    public SkeletalMeshComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkeletalMeshComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkeletalMeshComponent(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SkeletalMeshComponent>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkeletalMeshComponent>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SkeletalMeshComponent>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkeletalMeshComponent>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkeletalMeshComponent>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkeletalMeshComponent>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SkeletalMeshComponent>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkeletalMeshComponent>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_AddRandomTorqueImpulseToBodies;
    /// <summary>
    /// Function: AddRandomTorqueImpulseToBodies
    /// </summary>
    public unsafe virtual void AddRandomTorqueImpulseToBodies(float TorqueMin, float TorqueMax)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRandomTorqueImpulseToBodies, "Engine.SkeletalMeshComponent.AddRandomTorqueImpulseToBodies");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TorqueMin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TorqueMax, paramsPtr + 4);
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

    private static BmSDK.Function __fn_AttachChildMeshes;
    /// <summary>
    /// Function: AttachChildMeshes
    /// </summary>
    public unsafe static void AttachChildMeshes(BmSDK.Engine.Actor Actor, BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent> ToReattach)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachChildMeshes, "Engine.SkeletalMeshComponent.AttachChildMeshes");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToReattach, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DetachChildMeshes;
    /// <summary>
    /// Function: DetachChildMeshes
    /// </summary>
    public unsafe static BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent> DetachChildMeshes(BmSDK.Engine.Actor Actor, BmSDK.Engine.SkeletalMeshComponent SkelComponent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachChildMeshes, "Engine.SkeletalMeshComponent.DetachChildMeshes");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelComponent, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent>>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SetContactModification;
    /// <summary>
    /// Function: SetContactModification
    /// </summary>
    public unsafe override void SetContactModification(bool isEnableContactModificationCallback)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetContactModification, "Engine.SkeletalMeshComponent.SetContactModification");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isEnableContactModificationCallback, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ResetRagdollCalmingMeasures;
    /// <summary>
    /// Function: ResetRagdollCalmingMeasures
    /// </summary>
    public unsafe virtual void ResetRagdollCalmingMeasures()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetRagdollCalmingMeasures, "Engine.SkeletalMeshComponent.ResetRagdollCalmingMeasures");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_SetDisableRagdollCalmingMeasures;
    /// <summary>
    /// Function: SetDisableRagdollCalmingMeasures
    /// </summary>
    public unsafe virtual void SetDisableRagdollCalmingMeasures(bool bEnabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDisableRagdollCalmingMeasures, "Engine.SkeletalMeshComponent.SetDisableRagdollCalmingMeasures");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetAreRagdollCalmingMeasuresDisabled;
    /// <summary>
    /// Function: GetAreRagdollCalmingMeasuresDisabled
    /// </summary>
    public unsafe virtual bool GetAreRagdollCalmingMeasuresDisabled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAreRagdollCalmingMeasuresDisabled, "Engine.SkeletalMeshComponent.GetAreRagdollCalmingMeasuresDisabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetUseSimpleLineCollision;
    /// <summary>
    /// Function: GetUseSimpleLineCollision
    /// </summary>
    public unsafe override bool GetUseSimpleLineCollision()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUseSimpleLineCollision, "Engine.SkeletalMeshComponent.GetUseSimpleLineCollision");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetUseSimpleBoxCollision;
    /// <summary>
    /// Function: GetUseSimpleBoxCollision
    /// </summary>
    public unsafe override bool GetUseSimpleBoxCollision()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUseSimpleBoxCollision, "Engine.SkeletalMeshComponent.GetUseSimpleBoxCollision");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetDisableColourWrites;
    /// <summary>
    /// Function: SetDisableColourWrites
    /// </summary>
    public unsafe virtual void SetDisableColourWrites(bool bNewDisableColourWrites)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDisableColourWrites, "Engine.SkeletalMeshComponent.SetDisableColourWrites");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewDisableColourWrites, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetDepthBias;
    /// <summary>
    /// Function: SetDepthBias
    /// </summary>
    public unsafe virtual void SetDepthBias(BmSDK.Engine.SkeletalMeshComponent.FDepthBiasData NewDepthBiasData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDepthBias, "Engine.SkeletalMeshComponent.SetDepthBias");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDepthBiasData, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetDepthBiasData;
    /// <summary>
    /// Function: GetDepthBiasData
    /// </summary>
    public unsafe virtual void GetDepthBiasData(out BmSDK.Engine.SkeletalMeshComponent.FDepthBiasData OutDepthBiasData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDepthBiasData, "Engine.SkeletalMeshComponent.GetDepthBiasData");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutDepthBiasData);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutDepthBiasData, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutDepthBiasData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.SkeletalMeshComponent.FDepthBiasData>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetMaterial;
    /// <summary>
    /// Function: SetMaterial
    /// </summary>
    public unsafe override void SetMaterial(int ElementIndex, BmSDK.Engine.MaterialInterface Material)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMaterial, "Engine.SkeletalMeshComponent.SetMaterial");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ElementIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Material, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetRotation;
    /// <summary>
    /// Function: GetRotation
    /// </summary>
    public unsafe override BmSDK.Rotator GetRotation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRotation, "Engine.SkeletalMeshComponent.GetRotation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPosition;
    /// <summary>
    /// Function: GetPosition
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPosition, "Engine.SkeletalMeshComponent.GetPosition");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SkelMeshCompOnParticleSystemFinished;
    /// <summary>
    /// Function: SkelMeshCompOnParticleSystemFinished
    /// </summary>
    public unsafe virtual void SkelMeshCompOnParticleSystemFinished(BmSDK.Engine.ParticleSystemComponent PSC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SkelMeshCompOnParticleSystemFinished, "Engine.SkeletalMeshComponent.SkelMeshCompOnParticleSystemFinished");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PSC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayParticleEffect;
    /// <summary>
    /// Function: PlayParticleEffect
    /// </summary>
    public unsafe virtual bool PlayParticleEffect(BmSDK.Engine.AnimNotify_PlayParticleEffect AnimNotifyData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayParticleEffect, "Engine.SkeletalMeshComponent.PlayParticleEffect");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimNotifyData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CreateForceField;
    /// <summary>
    /// Function: CreateForceField
    /// </summary>
    public unsafe virtual bool CreateForceField(BmSDK.Engine.AnimNotify_ForceField AnimNotifyData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateForceField, "Engine.SkeletalMeshComponent.CreateForceField");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimNotifyData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SpawnApexVortexFieldSampler;
    /// <summary>
    /// Function: SpawnApexVortexFieldSampler
    /// </summary>
    public unsafe virtual void SpawnApexVortexFieldSampler(BmSDK.Engine.AnimNotify_ForceField AnimNotifyData, BmSDK.Engine.NxForceFieldTornadoComponent TornadoForceFieldComponent, BmSDK.Engine.ApexFieldSamplerComponent.FSS_FieldSamplerScene FieldSamplerScene, float RotationalStrengthMultiplier, float RadialStrengthMultiplier, float LiftStrengthMultiplier, float DurationMultiplier)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnApexVortexFieldSampler, "Engine.SkeletalMeshComponent.SpawnApexVortexFieldSampler");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimNotifyData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TornadoForceFieldComponent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldSamplerScene, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RotationalStrengthMultiplier, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RadialStrengthMultiplier, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LiftStrengthMultiplier, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DurationMultiplier, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopAnim;
    /// <summary>
    /// Function: StopAnim
    /// </summary>
    public unsafe virtual void StopAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAnim, "Engine.SkeletalMeshComponent.StopAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayAnim;
    /// <summary>
    /// Function: PlayAnim
    /// </summary>
    public unsafe virtual void PlayAnim(BmSDK.FName AnimName, float Duration = default, bool bLoop = default, bool bRestartIfAlreadyPlaying = default, float StartTime = default, bool bPlayBackwards = default, float PlayRate = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAnim, "Engine.SkeletalMeshComponent.PlayAnim");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLoop, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRestartIfAlreadyPlaying, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayBackwards, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayRate, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveApexClothCollision;
    /// <summary>
    /// Function: RemoveApexClothCollision
    /// </summary>
    public unsafe virtual void RemoveApexClothCollision()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveApexClothCollision, "Engine.SkeletalMeshComponent.RemoveApexClothCollision");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_SetHidden;
    /// <summary>
    /// Function: SetHidden
    /// </summary>
    public unsafe override void SetHidden(bool NewHidden)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHidden, "Engine.SkeletalMeshComponent.SetHidden");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewHidden, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddApexClothCollision;
    /// <summary>
    /// Function: AddApexClothCollision
    /// </summary>
    public unsafe virtual void AddApexClothCollision(BmSDK.Engine.RApexClothBlockingVolume ClothBlockingVolume)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddApexClothCollision, "Engine.SkeletalMeshComponent.AddApexClothCollision");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClothBlockingVolume, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsPermanentlyFixed;
    /// <summary>
    /// Function: IsPermanentlyFixed
    /// </summary>
    public unsafe virtual bool IsPermanentlyFixed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPermanentlyFixed, "Engine.SkeletalMeshComponent.IsPermanentlyFixed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShowMaterialSection;
    /// <summary>
    /// Function: ShowMaterialSection
    /// </summary>
    public unsafe virtual void ShowMaterialSection(int MaterialID, bool bShow, int LODIndex = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowMaterialSection, "Engine.SkeletalMeshComponent.ShowMaterialSection");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaterialID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LODIndex, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetPhysicalMaterial;
    /// <summary>
    /// Function: GetPhysicalMaterial
    /// </summary>
    public unsafe override BmSDK.Engine.PhysicalMaterial GetPhysicalMaterial(int BodyIndex = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPhysicalMaterial, "Engine.SkeletalMeshComponent.GetPhysicalMaterial");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BodyIndex, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PhysicalMaterial>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateDampingRampUp;
    /// <summary>
    /// Function: UpdateDampingRampUp
    /// </summary>
    public unsafe virtual void UpdateDampingRampUp(float DeltaTime, bool bAllowDampingRampup)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateDampingRampUp, "Engine.SkeletalMeshComponent.UpdateDampingRampUp");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowDampingRampup, paramsPtr + 4);
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

    private static BmSDK.Function __fn_UpdatePermanentFixing;
    /// <summary>
    /// Function: UpdatePermanentFixing
    /// </summary>
    public unsafe virtual void UpdatePermanentFixing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePermanentFixing, "Engine.SkeletalMeshComponent.UpdatePermanentFixing");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_GetHasFallenOutOfWorld;
    /// <summary>
    /// Function: GetHasFallenOutOfWorld
    /// </summary>
    public unsafe override bool GetHasFallenOutOfWorld()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHasFallenOutOfWorld, "Engine.SkeletalMeshComponent.GetHasFallenOutOfWorld");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetForceJointProjection;
    /// <summary>
    /// Function: SetForceJointProjection
    /// </summary>
    public unsafe virtual void SetForceJointProjection(bool bNewForceJointProjection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetForceJointProjection, "Engine.SkeletalMeshComponent.SetForceJointProjection");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewForceJointProjection, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateMeshForBrokenConstraints;
    /// <summary>
    /// Function: UpdateMeshForBrokenConstraints
    /// </summary>
    public unsafe virtual void UpdateMeshForBrokenConstraints()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMeshForBrokenConstraints, "Engine.SkeletalMeshComponent.UpdateMeshForBrokenConstraints");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_UnHideBoneByName;
    /// <summary>
    /// Function: UnHideBoneByName
    /// </summary>
    public unsafe virtual void UnHideBoneByName(BmSDK.FName BoneName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnHideBoneByName, "Engine.SkeletalMeshComponent.UnHideBoneByName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_HideBoneByName;
    /// <summary>
    /// Function: HideBoneByName
    /// </summary>
    public unsafe virtual void HideBoneByName(BmSDK.FName BoneName, BmSDK.Engine.SkeletalMeshComponent.EPhysBodyOp PhysBodyOption)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideBoneByName, "Engine.SkeletalMeshComponent.HideBoneByName");
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PhysBodyOption, paramsPtr + 8);
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

    private static BmSDK.Function __fn_IsBoneHidden;
    /// <summary>
    /// Function: IsBoneHidden
    /// </summary>
    public unsafe virtual bool IsBoneHidden(int BoneIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBoneHidden, "Engine.SkeletalMeshComponent.IsBoneHidden");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneIndex, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UnHideBone;
    /// <summary>
    /// Function: UnHideBone
    /// </summary>
    public unsafe virtual void UnHideBone(int BoneIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnHideBone, "Engine.SkeletalMeshComponent.UnHideBone");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneIndex, paramsPtr + 0);
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

    private static BmSDK.Function __fn_HideBone;
    /// <summary>
    /// Function: HideBone
    /// </summary>
    public unsafe virtual void HideBone(int BoneIndex, BmSDK.Engine.SkeletalMeshComponent.EPhysBodyOp PhysBodyOption)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideBone, "Engine.SkeletalMeshComponent.HideBone");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PhysBodyOption, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ResetFaceFXRegistersByOwner;
    /// <summary>
    /// Function: ResetFaceFXRegistersByOwner
    /// </summary>
    public unsafe virtual void ResetFaceFXRegistersByOwner(BmSDK.Engine.RSkeletalMeshComponent_Export.EFaceFXRegisterOwner RegOwner)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetFaceFXRegistersByOwner, "Engine.SkeletalMeshComponent.ResetFaceFXRegistersByOwner");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegOwner, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ResetAllFaceFXRegisters;
    /// <summary>
    /// Function: ResetAllFaceFXRegisters
    /// </summary>
    public unsafe virtual void ResetAllFaceFXRegisters()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetAllFaceFXRegisters, "Engine.SkeletalMeshComponent.ResetAllFaceFXRegisters");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_SetFaceFXRegisterByOwner;
    /// <summary>
    /// Function: SetFaceFXRegisterByOwner
    /// </summary>
    public unsafe virtual void SetFaceFXRegisterByOwner(BmSDK.FString RegName, float RegVal, BmSDK.Engine.RSkeletalMeshComponent_Export.EFaceFXRegisterOwner RegOwner, float InterpDuration = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFaceFXRegisterByOwner, "Engine.SkeletalMeshComponent.SetFaceFXRegisterByOwner");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegVal, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegOwner, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpDuration, paramsPtr + 24);
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

    private static BmSDK.Function __fn_SetFaceFXRegister;
    /// <summary>
    /// Function: SetFaceFXRegister
    /// </summary>
    public unsafe virtual void SetFaceFXRegister(BmSDK.FString RegName, float RegVal, BmSDK.Engine.SkeletalMeshComponent.EFaceFXRegOp RegOp, float InterpDuration = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFaceFXRegister, "Engine.SkeletalMeshComponent.SetFaceFXRegister");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegVal, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegOp, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpDuration, paramsPtr + 24);
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

    private static BmSDK.Function __fn_IsPlayingFaceFXAnim;
    /// <summary>
    /// Function: IsPlayingFaceFXAnim
    /// </summary>
    public unsafe virtual bool IsPlayingFaceFXAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayingFaceFXAnim, "Engine.SkeletalMeshComponent.IsPlayingFaceFXAnim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopFaceFXAnim;
    /// <summary>
    /// Function: StopFaceFXAnim
    /// </summary>
    public unsafe virtual void StopFaceFXAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFaceFXAnim, "Engine.SkeletalMeshComponent.StopFaceFXAnim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_PlayFaceFXAnim;
    /// <summary>
    /// Function: PlayFaceFXAnim
    /// </summary>
    public unsafe virtual bool PlayFaceFXAnim(BmSDK.Engine.FaceFXAnimSet FaceFXAnimSetRef, BmSDK.FString AnimName, BmSDK.FString GroupName, BmSDK.Engine.SoundCue SoundCueToPlay)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFaceFXAnim, "Engine.SkeletalMeshComponent.PlayFaceFXAnim");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FaceFXAnimSetRef, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCueToPlay, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_ToggleInstanceVertexWeights;
    /// <summary>
    /// Function: ToggleInstanceVertexWeights
    /// </summary>
    public unsafe virtual void ToggleInstanceVertexWeights(bool bEnable, int LODIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleInstanceVertexWeights, "Engine.SkeletalMeshComponent.ToggleInstanceVertexWeights");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnable, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LODIdx, paramsPtr + 4);
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

    private static BmSDK.Function __fn_UpdateInstanceVertexWeightBones;
    /// <summary>
    /// Function: UpdateInstanceVertexWeightBones
    /// </summary>
    public unsafe virtual void UpdateInstanceVertexWeightBones(BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FBonePair> BonePairs)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateInstanceVertexWeightBones, "Engine.SkeletalMeshComponent.UpdateInstanceVertexWeightBones");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BonePairs, paramsPtr + 0);
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

    private static BmSDK.Function __fn_FindInstanceVertexweightBonePair;
    /// <summary>
    /// Function: FindInstanceVertexweightBonePair
    /// </summary>
    public unsafe virtual int FindInstanceVertexweightBonePair(BmSDK.Engine.SkeletalMeshComponent.FBonePair Bones)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindInstanceVertexweightBonePair, "Engine.SkeletalMeshComponent.FindInstanceVertexweightBonePair");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bones, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_RemoveInstanceVertexWeightBoneParented;
    /// <summary>
    /// Function: RemoveInstanceVertexWeightBoneParented
    /// </summary>
    public unsafe virtual void RemoveInstanceVertexWeightBoneParented(BmSDK.FName BoneName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveInstanceVertexWeightBoneParented, "Engine.SkeletalMeshComponent.RemoveInstanceVertexWeightBoneParented");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddInstanceVertexWeightBoneParented;
    /// <summary>
    /// Function: AddInstanceVertexWeightBoneParented
    /// </summary>
    public unsafe virtual void AddInstanceVertexWeightBoneParented(BmSDK.FName BoneName, bool bPairWithParent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddInstanceVertexWeightBoneParented, "Engine.SkeletalMeshComponent.AddInstanceVertexWeightBoneParented");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPairWithParent, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetBonesWithinRadius;
    /// <summary>
    /// Function: GetBonesWithinRadius
    /// </summary>
    public unsafe virtual bool GetBonesWithinRadius(System.Numerics.Vector3 Origin, float Radius, int TraceFlags, out BmSDK.TArray<BmSDK.FName> out_Bones)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBonesWithinRadius, "Engine.SkeletalMeshComponent.GetBonesWithinRadius");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Origin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceFlags, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Bones = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_UpdateAnimations;
    /// <summary>
    /// Function: UpdateAnimations
    /// </summary>
    public unsafe virtual void UpdateAnimations()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAnimations, "Engine.SkeletalMeshComponent.UpdateAnimations");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_ForceSkelUpdate;
    /// <summary>
    /// Function: ForceSkelUpdate
    /// </summary>
    public unsafe virtual void ForceSkelUpdate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceSkelUpdate, "Engine.SkeletalMeshComponent.ForceSkelUpdate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_UpdateRBBonesFromSpaceBases;
    /// <summary>
    /// Function: UpdateRBBonesFromSpaceBases
    /// </summary>
    public unsafe virtual void UpdateRBBonesFromSpaceBases(bool bMoveUnfixedBodies, bool bTeleport)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRBBonesFromSpaceBases, "Engine.SkeletalMeshComponent.UpdateRBBonesFromSpaceBases");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMoveUnfixedBodies, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTeleport, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetAllowRFlapsAssetInstance;
    /// <summary>
    /// Function: SetAllowRFlapsAssetInstance
    /// </summary>
    public unsafe virtual void SetAllowRFlapsAssetInstance(bool bHasInstance)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAllowRFlapsAssetInstance, "Engine.SkeletalMeshComponent.SetAllowRFlapsAssetInstance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHasInstance, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetHasPhysicsAssetInstance;
    /// <summary>
    /// Function: SetHasPhysicsAssetInstance
    /// </summary>
    public unsafe virtual void SetHasPhysicsAssetInstance(bool bHasInstance, bool bUseCurrentPosition = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHasPhysicsAssetInstance, "Engine.SkeletalMeshComponent.SetHasPhysicsAssetInstance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHasInstance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseCurrentPosition, paramsPtr + 4);
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

    private static BmSDK.Function __fn_FindBodyInstanceNamed;
    /// <summary>
    /// Function: FindBodyInstanceNamed
    /// </summary>
    public unsafe virtual BmSDK.Engine.RB_BodyInstance FindBodyInstanceNamed(BmSDK.FName BoneName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindBodyInstanceNamed, "Engine.SkeletalMeshComponent.FindBodyInstanceNamed");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.RB_BodyInstance>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindConstraintBoneName;
    /// <summary>
    /// Function: FindConstraintBoneName
    /// </summary>
    public unsafe virtual BmSDK.FName FindConstraintBoneName(int ConstraintIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindConstraintBoneName, "Engine.SkeletalMeshComponent.FindConstraintBoneName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConstraintIndex, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FindConstraintIndex;
    /// <summary>
    /// Function: FindConstraintIndex
    /// </summary>
    public unsafe virtual int FindConstraintIndex(BmSDK.FName ConstraintName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindConstraintIndex, "Engine.SkeletalMeshComponent.FindConstraintIndex");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConstraintName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_InitMorphTargets;
    /// <summary>
    /// Function: InitMorphTargets
    /// </summary>
    public unsafe virtual void InitMorphTargets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitMorphTargets, "Engine.SkeletalMeshComponent.InitMorphTargets");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_InitSkelControls;
    /// <summary>
    /// Function: InitSkelControls
    /// </summary>
    public unsafe virtual void InitSkelControls()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitSkelControls, "Engine.SkeletalMeshComponent.InitSkelControls");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_UpdateParentBoneMap;
    /// <summary>
    /// Function: UpdateParentBoneMap
    /// </summary>
    public unsafe virtual void UpdateParentBoneMap()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateParentBoneMap, "Engine.SkeletalMeshComponent.UpdateParentBoneMap");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_SetParentAnimComponent;
    /// <summary>
    /// Function: SetParentAnimComponent
    /// </summary>
    public unsafe virtual void SetParentAnimComponent(BmSDK.Engine.SkeletalMeshComponent NewParentAnimComp)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetParentAnimComponent, "Engine.SkeletalMeshComponent.SetParentAnimComponent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewParentAnimComp, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetAnimTreeTemplate;
    /// <summary>
    /// Function: SetAnimTreeTemplate
    /// </summary>
    public unsafe virtual void SetAnimTreeTemplate(BmSDK.Engine.AnimTree NewTemplate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAnimTreeTemplate, "Engine.SkeletalMeshComponent.SetAnimTreeTemplate");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTemplate, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetAnimations;
    /// <summary>
    /// Function: SetAnimations
    /// </summary>
    public unsafe virtual void SetAnimations(BmSDK.Engine.AnimNode NewAnimations)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAnimations, "Engine.SkeletalMeshComponent.SetAnimations");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAnimations, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetClosestCollidingBoneLocation;
    /// <summary>
    /// Function: GetClosestCollidingBoneLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetClosestCollidingBoneLocation(System.Numerics.Vector3 TestLocation, bool bCheckZeroExtent, bool bCheckNonZeroExtent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestCollidingBoneLocation, "Engine.SkeletalMeshComponent.GetClosestCollidingBoneLocation");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckZeroExtent, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckNonZeroExtent, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_FindClosestBone;
    /// <summary>
    /// Function: FindClosestBone
    /// </summary>
    public unsafe virtual BmSDK.FName FindClosestBone(System.Numerics.Vector3 TestLocation, out System.Numerics.Vector3 BoneLocation, float IgnoreScale)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindClosestBone, "Engine.SkeletalMeshComponent.FindClosestBone");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BoneLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreScale, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BoneLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_TransformFromBoneSpace;
    /// <summary>
    /// Function: TransformFromBoneSpace
    /// </summary>
    public unsafe virtual void TransformFromBoneSpace(BmSDK.FName BoneName, System.Numerics.Vector3 InPosition, BmSDK.Rotator InRotation, out System.Numerics.Vector3 OutPosition, out BmSDK.Rotator OutRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TransformFromBoneSpace, "Engine.SkeletalMeshComponent.TransformFromBoneSpace");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPosition, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InRotation, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutPosition, paramsPtr + 32);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutRotation, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 32);
        OutRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 44);
        return;
    }

    private static BmSDK.Function __fn_TransformToBoneSpace;
    /// <summary>
    /// Function: TransformToBoneSpace
    /// </summary>
    public unsafe virtual void TransformToBoneSpace(BmSDK.FName BoneName, System.Numerics.Vector3 InPosition, BmSDK.Rotator InRotation, out System.Numerics.Vector3 OutPosition, out BmSDK.Rotator OutRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TransformToBoneSpace, "Engine.SkeletalMeshComponent.TransformToBoneSpace");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPosition, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InRotation, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutPosition, paramsPtr + 32);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutRotation, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 32);
        OutRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 44);
        return;
    }

    private static BmSDK.Function __fn_GetBoneAxis;
    /// <summary>
    /// Function: GetBoneAxis
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetBoneAxis(BmSDK.FName BoneName, BmSDK.GameObject.EAxis Axis)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBoneAxis, "Engine.SkeletalMeshComponent.GetBoneAxis");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Axis, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetRefPosePosition;
    /// <summary>
    /// Function: GetRefPosePosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRefPosePosition(int BoneIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRefPosePosition, "Engine.SkeletalMeshComponent.GetRefPosePosition");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneIndex, paramsPtr + 0);
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

    private static BmSDK.Function __fn_BoneIsChildOf;
    /// <summary>
    /// Function: BoneIsChildOf
    /// </summary>
    public unsafe virtual bool BoneIsChildOf(BmSDK.FName BoneName, BmSDK.FName ParentBoneName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BoneIsChildOf, "Engine.SkeletalMeshComponent.BoneIsChildOf");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParentBoneName, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetBoneNames;
    /// <summary>
    /// Function: GetBoneNames
    /// </summary>
    public unsafe virtual void GetBoneNames(out BmSDK.TArray<BmSDK.FName> BoneNames)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBoneNames, "Engine.SkeletalMeshComponent.GetBoneNames");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BoneNames = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetParentBone;
    /// <summary>
    /// Function: GetParentBone
    /// </summary>
    public unsafe virtual BmSDK.FName GetParentBone(BmSDK.FName BoneName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetParentBone, "Engine.SkeletalMeshComponent.GetParentBone");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetBoneMatrix;
    /// <summary>
    /// Function: GetBoneMatrix
    /// </summary>
    public unsafe virtual BmSDK.GameObject.FMatrix GetBoneMatrix(int BoneIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBoneMatrix, "Engine.SkeletalMeshComponent.GetBoneMatrix");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneIndex, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FMatrix>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetBoneName;
    /// <summary>
    /// Function: GetBoneName
    /// </summary>
    public unsafe virtual BmSDK.FName GetBoneName(int BoneIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBoneName, "Engine.SkeletalMeshComponent.GetBoneName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneIndex, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_MatchRefBone;
    /// <summary>
    /// Function: MatchRefBone
    /// </summary>
    public unsafe virtual int MatchRefBone(BmSDK.FName BoneName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatchRefBone, "Engine.SkeletalMeshComponent.MatchRefBone");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetBoneLocation;
    /// <summary>
    /// Function: GetBoneLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetBoneLocation(BmSDK.FName BoneName, int Space = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBoneLocation, "Engine.SkeletalMeshComponent.GetBoneLocation");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Space, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetBoneQuaternion;
    /// <summary>
    /// Function: GetBoneQuaternion
    /// </summary>
    public unsafe virtual BmSDK.GameObject.FQuat GetBoneQuaternion(BmSDK.FName BoneName, int Space = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBoneQuaternion, "Engine.SkeletalMeshComponent.GetBoneQuaternion");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Space, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FQuat>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_FindMorphNode;
    /// <summary>
    /// Function: FindMorphNode
    /// </summary>
    public unsafe virtual BmSDK.Engine.MorphNodeBase FindMorphNode(BmSDK.FName InNodeName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindMorphNode, "Engine.SkeletalMeshComponent.FindMorphNode");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InNodeName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.MorphNodeBase>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindSkelControls;
    /// <summary>
    /// Function: FindSkelControls
    /// </summary>
    public unsafe virtual void FindSkelControls(BmSDK.FName InControlName, out BmSDK.TArray<BmSDK.Engine.SkelControlBase> SkelControls)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindSkelControls, "Engine.SkeletalMeshComponent.FindSkelControls");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InControlName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SkelControls = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.SkelControlBase>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_FindSkelControl;
    /// <summary>
    /// Function: FindSkelControl
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkelControlBase FindSkelControl(BmSDK.FName InControlName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindSkelControl, "Engine.SkeletalMeshComponent.FindSkelControl");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InControlName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.SkelControlBase>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindAnimNode;
    /// <summary>
    /// Function: FindAnimNode
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimNode FindAnimNode(BmSDK.FName InNodeName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAnimNode, "Engine.SkeletalMeshComponent.FindAnimNode");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InNodeName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimNode>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindMorphTarget;
    /// <summary>
    /// Function: FindMorphTarget
    /// </summary>
    public unsafe virtual BmSDK.Engine.MorphTarget FindMorphTarget(BmSDK.FName MorphTargetName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindMorphTarget, "Engine.SkeletalMeshComponent.FindMorphTarget");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MorphTargetName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.MorphTarget>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetAnimLength;
    /// <summary>
    /// Function: GetAnimLength
    /// </summary>
    public unsafe virtual float GetAnimLength(BmSDK.FName AnimSeqName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimLength, "Engine.SkeletalMeshComponent.GetAnimLength");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSeqName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetAnimRateByDuration;
    /// <summary>
    /// Function: GetAnimRateByDuration
    /// </summary>
    public unsafe virtual float GetAnimRateByDuration(BmSDK.FName AnimSeqName, float Duration)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimRateByDuration, "Engine.SkeletalMeshComponent.GetAnimRateByDuration");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSeqName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RestoreSavedAnimSets;
    /// <summary>
    /// Function: RestoreSavedAnimSets
    /// </summary>
    public unsafe virtual void RestoreSavedAnimSets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreSavedAnimSets, "Engine.SkeletalMeshComponent.RestoreSavedAnimSets");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_SaveAnimSets;
    /// <summary>
    /// Function: SaveAnimSets
    /// </summary>
    public unsafe virtual void SaveAnimSets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveAnimSets, "Engine.SkeletalMeshComponent.SaveAnimSets");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_FindAnimSequence;
    /// <summary>
    /// Function: FindAnimSequence
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSequence FindAnimSequence(BmSDK.FName AnimSeqName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAnimSequence, "Engine.SkeletalMeshComponent.FindAnimSequence");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSeqName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSequence>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_WakeSoftBody;
    /// <summary>
    /// Function: WakeSoftBody
    /// </summary>
    public unsafe virtual void WakeSoftBody()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WakeSoftBody, "Engine.SkeletalMeshComponent.WakeSoftBody");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_SetSoftBodyFrozen;
    /// <summary>
    /// Function: SetSoftBodyFrozen
    /// </summary>
    public unsafe virtual void SetSoftBodyFrozen(bool bNewFrozen)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSoftBodyFrozen, "Engine.SkeletalMeshComponent.SetSoftBodyFrozen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewFrozen, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateSoftBodyParams;
    /// <summary>
    /// Function: UpdateSoftBodyParams
    /// </summary>
    public unsafe virtual void UpdateSoftBodyParams()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSoftBodyParams, "Engine.SkeletalMeshComponent.UpdateSoftBodyParams");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_SetClothValidBounds;
    /// <summary>
    /// Function: SetClothValidBounds
    /// </summary>
    public unsafe virtual void SetClothValidBounds(System.Numerics.Vector3 ClothValidBoundsMin, System.Numerics.Vector3 ClothValidBoundsMax)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothValidBounds, "Engine.SkeletalMeshComponent.SetClothValidBounds");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClothValidBoundsMin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClothValidBoundsMax, paramsPtr + 12);
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

    private static BmSDK.Function __fn_EnableClothValidBounds;
    /// <summary>
    /// Function: EnableClothValidBounds
    /// </summary>
    public unsafe virtual void EnableClothValidBounds(bool IfEnableClothValidBounds)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableClothValidBounds, "Engine.SkeletalMeshComponent.EnableClothValidBounds");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IfEnableClothValidBounds, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AttachClothToCollidingShapes;
    /// <summary>
    /// Function: AttachClothToCollidingShapes
    /// </summary>
    public unsafe virtual void AttachClothToCollidingShapes(bool AttatchTwoWay, bool AttachTearable)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachClothToCollidingShapes, "Engine.SkeletalMeshComponent.AttachClothToCollidingShapes");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttatchTwoWay, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachTearable, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetClothVelocity;
    /// <summary>
    /// Function: SetClothVelocity
    /// </summary>
    public unsafe virtual void SetClothVelocity(System.Numerics.Vector3 VelocityOffSet)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothVelocity, "Engine.SkeletalMeshComponent.SetClothVelocity");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VelocityOffSet, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothPosition;
    /// <summary>
    /// Function: SetClothPosition
    /// </summary>
    public unsafe virtual void SetClothPosition(System.Numerics.Vector3 ClothOffSet)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothPosition, "Engine.SkeletalMeshComponent.SetClothPosition");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClothOffSet, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothSleep;
    /// <summary>
    /// Function: SetClothSleep
    /// </summary>
    public unsafe virtual void SetClothSleep(bool IfClothSleep)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothSleep, "Engine.SkeletalMeshComponent.SetClothSleep");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IfClothSleep, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothThickness;
    /// <summary>
    /// Function: SetClothThickness
    /// </summary>
    public unsafe virtual void SetClothThickness(float ClothThickness)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothThickness, "Engine.SkeletalMeshComponent.SetClothThickness");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClothThickness, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothTearFactor;
    /// <summary>
    /// Function: SetClothTearFactor
    /// </summary>
    public unsafe virtual void SetClothTearFactor(float ClothTearFactor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothTearFactor, "Engine.SkeletalMeshComponent.SetClothTearFactor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClothTearFactor, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothStretchingStiffness;
    /// <summary>
    /// Function: SetClothStretchingStiffness
    /// </summary>
    public unsafe virtual void SetClothStretchingStiffness(float ClothStretchingStiffness)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothStretchingStiffness, "Engine.SkeletalMeshComponent.SetClothStretchingStiffness");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClothStretchingStiffness, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothSolverIterations;
    /// <summary>
    /// Function: SetClothSolverIterations
    /// </summary>
    public unsafe virtual void SetClothSolverIterations(int ClothSolverIterations)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothSolverIterations, "Engine.SkeletalMeshComponent.SetClothSolverIterations");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClothSolverIterations, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothSleepLinearVelocity;
    /// <summary>
    /// Function: SetClothSleepLinearVelocity
    /// </summary>
    public unsafe virtual void SetClothSleepLinearVelocity(float ClothSleepLinearVelocity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothSleepLinearVelocity, "Engine.SkeletalMeshComponent.SetClothSleepLinearVelocity");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClothSleepLinearVelocity, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothPressure;
    /// <summary>
    /// Function: SetClothPressure
    /// </summary>
    public unsafe virtual void SetClothPressure(float ClothPressure)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothPressure, "Engine.SkeletalMeshComponent.SetClothPressure");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClothPressure, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothFriction;
    /// <summary>
    /// Function: SetClothFriction
    /// </summary>
    public unsafe virtual void SetClothFriction(float ClothFriction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothFriction, "Engine.SkeletalMeshComponent.SetClothFriction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClothFriction, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothFlags;
    /// <summary>
    /// Function: SetClothFlags
    /// </summary>
    public unsafe virtual void SetClothFlags(int ClothFlags)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothFlags, "Engine.SkeletalMeshComponent.SetClothFlags");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClothFlags, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothDampingCoefficient;
    /// <summary>
    /// Function: SetClothDampingCoefficient
    /// </summary>
    public unsafe virtual void SetClothDampingCoefficient(float ClothDampingCoefficient)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothDampingCoefficient, "Engine.SkeletalMeshComponent.SetClothDampingCoefficient");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClothDampingCoefficient, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothCollisionResponseCoefficient;
    /// <summary>
    /// Function: SetClothCollisionResponseCoefficient
    /// </summary>
    public unsafe virtual void SetClothCollisionResponseCoefficient(float ClothCollisionResponseCoefficient)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothCollisionResponseCoefficient, "Engine.SkeletalMeshComponent.SetClothCollisionResponseCoefficient");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClothCollisionResponseCoefficient, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothBendingStiffness;
    /// <summary>
    /// Function: SetClothBendingStiffness
    /// </summary>
    public unsafe virtual void SetClothBendingStiffness(float ClothBendingStiffness)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothBendingStiffness, "Engine.SkeletalMeshComponent.SetClothBendingStiffness");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClothBendingStiffness, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothAttachmentTearFactor;
    /// <summary>
    /// Function: SetClothAttachmentTearFactor
    /// </summary>
    public unsafe virtual void SetClothAttachmentTearFactor(float ClothAttachTearFactor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothAttachmentTearFactor, "Engine.SkeletalMeshComponent.SetClothAttachmentTearFactor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClothAttachTearFactor, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothAttachmentResponseCoefficient;
    /// <summary>
    /// Function: SetClothAttachmentResponseCoefficient
    /// </summary>
    public unsafe virtual void SetClothAttachmentResponseCoefficient(float ClothAttachmentResponseCoefficient)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothAttachmentResponseCoefficient, "Engine.SkeletalMeshComponent.SetClothAttachmentResponseCoefficient");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClothAttachmentResponseCoefficient, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetClothThickness;
    /// <summary>
    /// Function: GetClothThickness
    /// </summary>
    public unsafe virtual float GetClothThickness()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClothThickness, "Engine.SkeletalMeshComponent.GetClothThickness");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetClothTearFactor;
    /// <summary>
    /// Function: GetClothTearFactor
    /// </summary>
    public unsafe virtual float GetClothTearFactor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClothTearFactor, "Engine.SkeletalMeshComponent.GetClothTearFactor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetClothStretchingStiffness;
    /// <summary>
    /// Function: GetClothStretchingStiffness
    /// </summary>
    public unsafe virtual float GetClothStretchingStiffness()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClothStretchingStiffness, "Engine.SkeletalMeshComponent.GetClothStretchingStiffness");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetClothSolverIterations;
    /// <summary>
    /// Function: GetClothSolverIterations
    /// </summary>
    public unsafe virtual int GetClothSolverIterations()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClothSolverIterations, "Engine.SkeletalMeshComponent.GetClothSolverIterations");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetClothSleepLinearVelocity;
    /// <summary>
    /// Function: GetClothSleepLinearVelocity
    /// </summary>
    public unsafe virtual float GetClothSleepLinearVelocity()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClothSleepLinearVelocity, "Engine.SkeletalMeshComponent.GetClothSleepLinearVelocity");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetClothPressure;
    /// <summary>
    /// Function: GetClothPressure
    /// </summary>
    public unsafe virtual float GetClothPressure()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClothPressure, "Engine.SkeletalMeshComponent.GetClothPressure");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetClothFriction;
    /// <summary>
    /// Function: GetClothFriction
    /// </summary>
    public unsafe virtual float GetClothFriction()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClothFriction, "Engine.SkeletalMeshComponent.GetClothFriction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetClothFlags;
    /// <summary>
    /// Function: GetClothFlags
    /// </summary>
    public unsafe virtual int GetClothFlags()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClothFlags, "Engine.SkeletalMeshComponent.GetClothFlags");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetClothDampingCoefficient;
    /// <summary>
    /// Function: GetClothDampingCoefficient
    /// </summary>
    public unsafe virtual float GetClothDampingCoefficient()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClothDampingCoefficient, "Engine.SkeletalMeshComponent.GetClothDampingCoefficient");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetClothCollisionResponseCoefficient;
    /// <summary>
    /// Function: GetClothCollisionResponseCoefficient
    /// </summary>
    public unsafe virtual float GetClothCollisionResponseCoefficient()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClothCollisionResponseCoefficient, "Engine.SkeletalMeshComponent.GetClothCollisionResponseCoefficient");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetClothBendingStiffness;
    /// <summary>
    /// Function: GetClothBendingStiffness
    /// </summary>
    public unsafe virtual float GetClothBendingStiffness()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClothBendingStiffness, "Engine.SkeletalMeshComponent.GetClothBendingStiffness");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetClothAttachmentTearFactor;
    /// <summary>
    /// Function: GetClothAttachmentTearFactor
    /// </summary>
    public unsafe virtual float GetClothAttachmentTearFactor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClothAttachmentTearFactor, "Engine.SkeletalMeshComponent.GetClothAttachmentTearFactor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetClothAttachmentResponseCoefficient;
    /// <summary>
    /// Function: GetClothAttachmentResponseCoefficient
    /// </summary>
    public unsafe virtual float GetClothAttachmentResponseCoefficient()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClothAttachmentResponseCoefficient, "Engine.SkeletalMeshComponent.GetClothAttachmentResponseCoefficient");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EnableApexClothing;
    /// <summary>
    /// Function: EnableApexClothing
    /// </summary>
    public unsafe virtual void EnableApexClothing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableApexClothing, "Engine.SkeletalMeshComponent.EnableApexClothing");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_DisableApexClothing;
    /// <summary>
    /// Function: DisableApexClothing
    /// </summary>
    public unsafe virtual void DisableApexClothing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableApexClothing, "Engine.SkeletalMeshComponent.DisableApexClothing");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_ForceApexClothingTeleport;
    /// <summary>
    /// Function: ForceApexClothingTeleport
    /// </summary>
    public unsafe virtual void ForceApexClothingTeleport()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceApexClothingTeleport, "Engine.SkeletalMeshComponent.ForceApexClothingTeleport");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_ForceApexClothingTeleportAndReset;
    /// <summary>
    /// Function: ForceApexClothingTeleportAndReset
    /// </summary>
    public unsafe virtual void ForceApexClothingTeleportAndReset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceApexClothingTeleportAndReset, "Engine.SkeletalMeshComponent.ForceApexClothingTeleportAndReset");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_ResetClothVertsToRefPose;
    /// <summary>
    /// Function: ResetClothVertsToRefPose
    /// </summary>
    public unsafe virtual void ResetClothVertsToRefPose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetClothVertsToRefPose, "Engine.SkeletalMeshComponent.ResetClothVertsToRefPose");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_SetAttachClothVertsToBaseBody;
    /// <summary>
    /// Function: SetAttachClothVertsToBaseBody
    /// </summary>
    public unsafe virtual void SetAttachClothVertsToBaseBody(bool bAttachVerts)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAttachClothVertsToBaseBody, "Engine.SkeletalMeshComponent.SetAttachClothVertsToBaseBody");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAttachVerts, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothExternalForce;
    /// <summary>
    /// Function: SetClothExternalForce
    /// </summary>
    public unsafe virtual void SetClothExternalForce(System.Numerics.Vector3 InForce)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothExternalForce, "Engine.SkeletalMeshComponent.SetClothExternalForce");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InForce, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateClothParams;
    /// <summary>
    /// Function: UpdateClothParams
    /// </summary>
    public unsafe virtual void UpdateClothParams()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateClothParams, "Engine.SkeletalMeshComponent.UpdateClothParams");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_SetEnableClothingSimulation;
    /// <summary>
    /// Function: SetEnableClothingSimulation
    /// </summary>
    public unsafe virtual void SetEnableClothingSimulation(bool bInEnable)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEnableClothingSimulation, "Engine.SkeletalMeshComponent.SetEnableClothingSimulation");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInEnable, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothFrozen;
    /// <summary>
    /// Function: SetClothFrozen
    /// </summary>
    public unsafe virtual void SetClothFrozen(bool bNewFrozen)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothFrozen, "Engine.SkeletalMeshComponent.SetClothFrozen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewFrozen, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetEnableClothSimulation;
    /// <summary>
    /// Function: SetEnableClothSimulation
    /// </summary>
    public unsafe virtual void SetEnableClothSimulation(bool bInEnable)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEnableClothSimulation, "Engine.SkeletalMeshComponent.SetEnableClothSimulation");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInEnable, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetClothRBCollidesWithChannel;
    /// <summary>
    /// Function: SetClothRBCollidesWithChannel
    /// </summary>
    public unsafe virtual void SetClothRBCollidesWithChannel(BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel Channel, bool bNewCollides)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClothRBCollidesWithChannel, "Engine.SkeletalMeshComponent.SetClothRBCollidesWithChannel");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Channel, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewCollides, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetForceRefPose;
    /// <summary>
    /// Function: SetForceRefPose
    /// </summary>
    public unsafe virtual void SetForceRefPose(bool bNewForceRefPose)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetForceRefPose, "Engine.SkeletalMeshComponent.SetForceRefPose");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewForceRefPose, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetPhysicsAsset;
    /// <summary>
    /// Function: SetPhysicsAsset
    /// </summary>
    public unsafe virtual void SetPhysicsAsset(BmSDK.Engine.PhysicsAsset NewPhysicsAsset, bool bForceReInit = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPhysicsAsset, "Engine.SkeletalMeshComponent.SetPhysicsAsset");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPhysicsAsset, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceReInit, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetSkeletalMesh;
    /// <summary>
    /// Function: SetSkeletalMesh
    /// </summary>
    public unsafe virtual void SetSkeletalMesh(BmSDK.Engine.SkeletalMesh NewMesh, bool bKeepSpaceBases = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSkeletalMesh, "Engine.SkeletalMeshComponent.SetSkeletalMesh");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKeepSpaceBases, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetTransformMatrix;
    /// <summary>
    /// Function: GetTransformMatrix
    /// </summary>
    public unsafe virtual BmSDK.GameObject.FMatrix GetTransformMatrix()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransformMatrix, "Engine.SkeletalMeshComponent.GetTransformMatrix");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FMatrix>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsComponentAttached;
    /// <summary>
    /// Function: IsComponentAttached
    /// </summary>
    public unsafe virtual bool IsComponentAttached(BmSDK.Engine.ActorComponent Component, BmSDK.FName BoneName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsComponentAttached, "Engine.SkeletalMeshComponent.IsComponentAttached");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Component, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_FindComponentAttachedToBone;
    /// <summary>
    /// Function: FindComponentAttachedToBone
    /// </summary>
    public unsafe virtual BmSDK.Engine.ActorComponent FindComponentAttachedToBone(BmSDK.FName InBoneName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindComponentAttachedToBone, "Engine.SkeletalMeshComponent.FindComponentAttachedToBone");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InBoneName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ActorComponent>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetSocketBoneName;
    /// <summary>
    /// Function: GetSocketBoneName
    /// </summary>
    public unsafe virtual BmSDK.FName GetSocketBoneName(BmSDK.FName InSocketName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSocketBoneName, "Engine.SkeletalMeshComponent.GetSocketBoneName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSocketName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetSocketByName;
    /// <summary>
    /// Function: GetSocketByName
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkeletalMeshSocket GetSocketByName(BmSDK.FName InSocketName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSocketByName, "Engine.SkeletalMeshComponent.GetSocketByName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSocketName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.SkeletalMeshSocket>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetSocketWorldLocationAndRotation;
    /// <summary>
    /// Function: GetSocketWorldLocationAndRotation
    /// </summary>
    public unsafe virtual bool GetSocketWorldLocationAndRotation(BmSDK.FName InSocketName, out System.Numerics.Vector3 OutLocation, out BmSDK.Rotator OutRotation, int Space)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSocketWorldLocationAndRotation, "Engine.SkeletalMeshComponent.GetSocketWorldLocationAndRotation");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSocketName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutLocation, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutRotation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Space, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        OutRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_AttachComponentToSocket;
    /// <summary>
    /// Function: AttachComponentToSocket
    /// </summary>
    public unsafe virtual void AttachComponentToSocket(BmSDK.Engine.ActorComponent Component, BmSDK.FName SocketName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachComponentToSocket, "Engine.SkeletalMeshComponent.AttachComponentToSocket");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Component, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SocketName, paramsPtr + 8);
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

    private static BmSDK.Function __fn_OverrideApexClothingMaxDistanceScale;
    /// <summary>
    /// Function: OverrideApexClothingMaxDistanceScale
    /// </summary>
    public unsafe virtual void OverrideApexClothingMaxDistanceScale(float StartScale, float EndScale, float Duration)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideApexClothingMaxDistanceScale, "Engine.SkeletalMeshComponent.OverrideApexClothingMaxDistanceScale");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartScale, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndScale, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 8);
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

    private static BmSDK.Function __fn_DetachComponent;
    /// <summary>
    /// Function: DetachComponent
    /// </summary>
    public unsafe virtual void DetachComponent(BmSDK.Engine.ActorComponent Component)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachComponent, "Engine.SkeletalMeshComponent.DetachComponent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Component, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AttachComponent;
    /// <summary>
    /// Function: AttachComponent
    /// </summary>
    public unsafe virtual void AttachComponent(BmSDK.Engine.ActorComponent Component, BmSDK.FName BoneName, System.Numerics.Vector3 RelativeLocation = default, BmSDK.Rotator RelativeRotation = default, System.Numerics.Vector3 RelativeScale = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachComponent, "Engine.SkeletalMeshComponent.AttachComponent");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Component, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelativeLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelativeRotation, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelativeScale, paramsPtr + 40);
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

    /// <summary>
    /// Enum: EApexClothSkinningTickGroup
    /// </summary>
    public enum EApexClothSkinningTickGroup : byte
    {
        ApexClothSkinningTickGroup_PreAsync = 0,
        ApexClothSkinningTickGroup_Async = 1,
        ApexClothSkinningTickGroup_PostAsync = 2,
        ApexClothSkinningTickGroup_MAX = 3,
    }

    /// <summary>
    /// Enum: EPhysBodyOp
    /// </summary>
    public enum EPhysBodyOp : byte
    {
        PBO_None = 0,
        PBO_Term = 1,
        PBO_Disable = 2,
        PBO_MAX = 3,
    }

    /// <summary>
    /// Struct: FDepthBiasData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial record struct FDepthBiasData
    {
        /// <summary>
        /// FloatProperty: DepthBias
        /// </summary>
        public unsafe float DepthBias
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: DepthBiasCalculationType
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMeshComponent.EDepthBiasCalculationType DepthBiasCalculationType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.EDepthBiasCalculationType>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: DepthBiasVaryingDirection
        /// </summary>
        public unsafe System.Numerics.Vector3 DepthBiasVaryingDirection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: InterpStartAngle
        /// </summary>
        public unsafe float InterpStartAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: InterpEndAngle
        /// </summary>
        public unsafe float InterpEndAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: AlternateDepthBias
        /// </summary>
        public unsafe float AlternateDepthBias
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ByteProperty: DepthBiasApplicationType
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMeshComponent.EDepthBiasApplicationType DepthBiasApplicationType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.EDepthBiasApplicationType>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: DepthBiasCustomTestPoint
        /// </summary>
        public unsafe System.Numerics.Vector3 DepthBiasCustomTestPoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: DepthBiasMinDistanceFromCameraPlaneOverride
        /// </summary>
        public unsafe float DepthBiasMinDistanceFromCameraPlaneOverride
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: MinDepthBiasMultiplier
        /// </summary>
        public unsafe float MinDepthBiasMultiplier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }
    }

    /// <summary>
    /// Enum: EDepthBiasApplicationType
    /// </summary>
    public enum EDepthBiasApplicationType : byte
    {
        DEPTHBIASAPPLICATIONTYPE_World = 0,
        DEPTHBIASAPPLICATIONTYPE_Screen = 1,
        DEPTHBIASAPPLICATIONTYPE_WorldCustomTestPoint = 2,
        DEPTHBIASAPPLICATIONTYPE_MAX = 3,
    }

    /// <summary>
    /// Enum: EDepthBiasCalculationType
    /// </summary>
    public enum EDepthBiasCalculationType : byte
    {
        DEPTHBIASCALCULATIONTYPE_Constant = 0,
        DEPTHBIASCALCULATIONTYPE_DirectionVariable = 1,
        DEPTHBIASCALCULATIONTYPE_MAX = 2,
    }

    /// <summary>
    /// Enum: EBoneVisibilityStatus
    /// </summary>
    public enum EBoneVisibilityStatus : byte
    {
        BVS_HiddenByParent = 0,
        BVS_Visible = 1,
        BVS_ExplicitlyHidden = 2,
        BVS_MAX = 3,
    }

    /// <summary>
    /// Enum: EFaceFXRegOp
    /// </summary>
    public enum EFaceFXRegOp : byte
    {
        FXRO_Add = 0,
        FXRO_Multiply = 1,
        FXRO_Replace = 2,
        FXRO_MAX = 3,
    }

    /// <summary>
    /// Enum: EFaceFXBlendMode
    /// </summary>
    public enum EFaceFXBlendMode : byte
    {
        FXBM_Overwrite = 0,
        FXBM_Additive = 1,
        FXBM_MAX = 2,
    }

    /// <summary>
    /// Enum: EAnimRotationOnly
    /// </summary>
    public enum EAnimRotationOnly : byte
    {
        EARO_AnimSet = 0,
        EARO_ForceEnabled = 1,
        EARO_ForceDisabled = 2,
        EARO_MAX = 3,
    }

    /// <summary>
    /// Enum: ERootMotionRotationMode
    /// </summary>
    public enum ERootMotionRotationMode : byte
    {
        RMRM_Ignore = 0,
        RMRM_RotateActor = 1,
        RMRM_MAX = 2,
    }

    /// <summary>
    /// Struct: FSkelMeshComponentLODInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSkelMeshComponentLODInfo
    {
        /// <summary>
        /// ArrayProperty: HiddenMaterials
        /// </summary>
        public unsafe BmSDK.TArray<bool> HiddenMaterials
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FBonePair
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FBonePair
    {
        /// <summary>
        /// NameProperty: Bones
        /// </summary>
        public unsafe BmSDK.FName Bones_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// NameProperty: Bones
        /// </summary>
        public unsafe BmSDK.FName Bones_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: EInstanceWeightUsage
    /// </summary>
    public enum EInstanceWeightUsage : byte
    {
        IWU_PartialSwap = 0,
        IWU_FullSwap = 1,
        IWU_MAX = 2,
    }

    /// <summary>
    /// Struct: FAttachment
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FAttachment
    {
        /// <summary>
        /// ComponentProperty: Component
        /// </summary>
        public unsafe BmSDK.Engine.ActorComponent Component
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ActorComponent>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: BoneName
        /// </summary>
        public unsafe BmSDK.FName BoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: RelativeLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 RelativeLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: RelativeRotation
        /// </summary>
        public unsafe BmSDK.Rotator RelativeRotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: RelativeScale
        /// </summary>
        public unsafe System.Numerics.Vector3 RelativeScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FActiveMorph
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FActiveMorph
    {
        /// <summary>
        /// ObjectProperty: Target
        /// </summary>
        public unsafe BmSDK.Engine.MorphTarget Target
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MorphTarget>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Weight
        /// </summary>
        public unsafe float Weight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: EApexClothMaxDistanceScaleMode
    /// </summary>
    public enum EApexClothMaxDistanceScaleMode : byte
    {
        ApexClothMaxDistanceScaleMode_LODBlend = 0,
        ApexClothMaxDistanceScaleMode_Overridden = 1,
        ApexClothMaxDistanceScaleMode_MAX = 2,
    }

    /// <summary>
    /// ObjectProperty: SkeletalMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh SkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// ComponentProperty: AttachedToSkelComponent
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent AttachedToSkelComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ObjectProperty: AnimTreeTemplate
    /// </summary>
    public unsafe BmSDK.Engine.AnimTree AnimTreeTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimTree>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ObjectProperty: Animations
    /// </summary>
    public unsafe BmSDK.Engine.AnimNode Animations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNode>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ArrayProperty: AnimTickArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimNode> AnimTickArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimNode>>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ArrayProperty: AnimAlwaysTickArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimNode> AnimAlwaysTickArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimNode>>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ArrayProperty: AnimTickRelevancyArray
    /// </summary>
    public unsafe BmSDK.TArray<int> AnimTickRelevancyArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ArrayProperty: AnimTickWeightsArray
    /// </summary>
    public unsafe BmSDK.TArray<float> AnimTickWeightsArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ArrayProperty: SkelControlTickArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkelControlBase> SkelControlTickArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkelControlBase>>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ArrayProperty: SkelControlInstances
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FSkelControlInstance> SkelControlInstances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FSkelControlInstance>>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// ArrayProperty: PostFixerUpdateBones
    /// </summary>
    public unsafe BmSDK.TArray<int> PostFixerUpdateBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ArrayProperty: AnimNotifies
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> AnimNotifies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ObjectProperty: AnimNodePose
    /// </summary>
    public unsafe BmSDK.Engine.AnimNode AnimNodePose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNode>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// ArrayProperty: TrackedNotifies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FTrackedNotify> TrackedNotifies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FTrackedNotify>>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ObjectProperty: PhysicsAsset
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsAsset PhysicsAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAsset>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ObjectProperty: PhysicsAssetInstance
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsAssetInstance PhysicsAssetInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAssetInstance>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ObjectProperty: FlapsAssetInstance
    /// </summary>
    public unsafe BmSDK.Engine.RFlapsAssetInstance FlapsAssetInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlapsAssetInstance>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// StructProperty: ApexClothing
    /// </summary>
    public unsafe System.IntPtr ApexClothing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// ArrayProperty: ForceFieldComponents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.NxForceFieldComponent> ForceFieldComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.NxForceFieldComponent>>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// FloatProperty: ApexClothMaxDistanceStartScale
    /// </summary>
    public unsafe float ApexClothMaxDistanceStartScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// FloatProperty: ApexClothMaxDistanceEndScale
    /// </summary>
    public unsafe float ApexClothMaxDistanceEndScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// FloatProperty: ApexClothMaxDistanceStartTime
    /// </summary>
    public unsafe float ApexClothMaxDistanceStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// FloatProperty: ApexClothMaxDistanceEndTime
    /// </summary>
    public unsafe float ApexClothMaxDistanceEndTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ByteProperty: ApexClothMaxDistanceScaleMode
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.EApexClothMaxDistanceScaleMode ApexClothMaxDistanceScaleMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.EApexClothMaxDistanceScaleMode>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// FloatProperty: PhysicsWeight
    /// </summary>
    public unsafe float PhysicsWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// FloatProperty: MaxNearlyStillSpeed
    /// </summary>
    public unsafe float MaxNearlyStillSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// ByteProperty: BoundsType
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.ESkeletalMeshComponentBoundsType BoundsType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.ESkeletalMeshComponentBoundsType>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// StructProperty: FixedBounds
    /// </summary>
    public unsafe ref BmSDK.GameObject.FBoxSphereBounds FixedBounds
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FBoxSphereBounds>(Ptr + 904);

    /// <summary>
    /// StructProperty: OriginalBounds
    /// </summary>
    public unsafe ref BmSDK.GameObject.FBoxSphereBounds OriginalBounds
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FBoxSphereBounds>(Ptr + 932);

    /// <summary>
    /// ArrayProperty: ExtraBounds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FSkeletalMeshComponentExtraBounds> ExtraBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FSkeletalMeshComponentExtraBounds>>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ArrayProperty: ExtraBoundsInstances
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FSkeletalMeshComponentExtraBoundsInstance> ExtraBoundsInstances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FSkeletalMeshComponentExtraBoundsInstance>>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// FloatProperty: GlobalAnimRateScale
    /// </summary>
    public unsafe float GlobalAnimRateScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// FloatProperty: StreamingDistanceMultiplier
    /// </summary>
    public unsafe float StreamingDistanceMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// StructProperty: MeshObject
    /// </summary>
    public unsafe System.IntPtr MeshObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// StructProperty: WireframeColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor WireframeColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1008);

    /// <summary>
    /// ArrayProperty: SpaceBases
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FBoneAtom> SpaceBases
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FBoneAtom>>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ArrayProperty: LocalAtoms
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FBoneAtom> LocalAtoms
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FBoneAtom>>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ArrayProperty: CachedLocalAtoms
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FBoneAtom> CachedLocalAtoms
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FBoneAtom>>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ArrayProperty: CachedSpaceBases
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FBoneAtom> CachedSpaceBases
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FBoneAtom>>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// IntProperty: LowUpdateFrameRate
    /// </summary>
    public unsafe int LowUpdateFrameRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// ArrayProperty: RequiredBones
    /// </summary>
    public unsafe BmSDK.TArray<int> RequiredBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: ComposeOrderedRequiredBones
    /// </summary>
    public unsafe BmSDK.TArray<int> ComposeOrderedRequiredBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ComponentProperty: ParentAnimComponent
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent ParentAnimComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ByteProperty: ParentAnimComponentMode
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.EParentAnimComponentMode ParentAnimComponentMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.EParentAnimComponentMode>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// NameProperty: ParentAnimComponentOverrideRoot
    /// </summary>
    public unsafe BmSDK.FName ParentAnimComponentOverrideRoot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// ArrayProperty: ParentBoneMap
    /// </summary>
    public unsafe BmSDK.TArray<int> ParentBoneMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// ArrayProperty: AnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// ArrayProperty: TemporarySavedAnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> TemporarySavedAnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// ArrayProperty: MorphSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MorphTargetSet> MorphSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MorphTargetSet>>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// ArrayProperty: ActiveMorphs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FActiveMorph> ActiveMorphs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FActiveMorph>>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// ArrayProperty: ActiveCurveMorphs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FActiveMorph> ActiveCurveMorphs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FActiveMorph>>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// MapProperty: MorphTargetIndexMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ MorphTargetIndexMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// ArrayProperty: Attachments
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FAttachment> Attachments
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FAttachment>>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// StructProperty: Stretches
    /// </summary>
    public unsafe ref BmSDK.Engine.RSkeletalMeshComponent_Export.FStretchInstances Stretches
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RSkeletalMeshComponent_Export.FStretchInstances>(Ptr + 1316);

    /// <summary>
    /// IntProperty: ForcedLodModel
    /// </summary>
    public unsafe int ForcedLodModel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// IntProperty: MinLodModel
    /// </summary>
    public unsafe int MinLodModel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// IntProperty: PredictedLODLevel
    /// </summary>
    public unsafe int PredictedLODLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// IntProperty: OldPredictedLODLevel
    /// </summary>
    public unsafe int OldPredictedLODLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// FloatProperty: AnimationLODDistanceFactor
    /// </summary>
    public unsafe float AnimationLODDistanceFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// IntProperty: AnimationLODFrameRate
    /// </summary>
    public unsafe int AnimationLODFrameRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// FloatProperty: MaxDistanceFactor
    /// </summary>
    public unsafe float MaxDistanceFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// IntProperty: ChunkIndexPreview
    /// </summary>
    public unsafe int ChunkIndexPreview
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// IntProperty: SectionIndexPreview
    /// </summary>
    public unsafe int SectionIndexPreview
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// IntProperty: bForceWireframe
    /// </summary>
    public unsafe int bForceWireframe
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// IntProperty: bForceRefpose
    /// </summary>
    public unsafe int bForceRefpose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// IntProperty: bOldForceRefPose
    /// </summary>
    public unsafe int bOldForceRefPose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// BoolProperty: bNoSkeletonUpdate
    /// </summary>
    public unsafe bool bNoSkeletonUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1396) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1396); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1396); }
    }

    /// <summary>
    /// IntProperty: bDisplayBones
    /// </summary>
    public unsafe int bDisplayBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// IntProperty: bDisplayRFlaps
    /// </summary>
    public unsafe int bDisplayRFlaps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// IntProperty: bShowPrePhysBones
    /// </summary>
    public unsafe int bShowPrePhysBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// IntProperty: bHideSkin
    /// </summary>
    public unsafe int bHideSkin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// IntProperty: bForceRawOffset
    /// </summary>
    public unsafe int bForceRawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// IntProperty: bIgnoreControllers
    /// </summary>
    public unsafe int bIgnoreControllers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// IntProperty: bTransformFromAnimParent
    /// </summary>
    public unsafe int bTransformFromAnimParent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// IntProperty: TickTag
    /// </summary>
    public unsafe int TickTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// IntProperty: InitTag
    /// </summary>
    public unsafe int InitTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// IntProperty: CachedAtomsTag
    /// </summary>
    public unsafe int CachedAtomsTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// IntProperty: bUseSingleBodyPhysics
    /// </summary>
    public unsafe int bUseSingleBodyPhysics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// IntProperty: bRequiredBonesUpToDate
    /// </summary>
    public unsafe int bRequiredBonesUpToDate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// FloatProperty: MinDistFactorForKinematicUpdate
    /// </summary>
    public unsafe float MinDistFactorForKinematicUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// IntProperty: FramesPhysicsAsleep
    /// </summary>
    public unsafe int FramesPhysicsAsleep
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// BoolProperty: bHasValidBodies
    /// </summary>
    public unsafe bool bHasValidBodies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bSkipAllUpdateWhenPhysicsAsleep
    /// </summary>
    public unsafe bool bSkipAllUpdateWhenPhysicsAsleep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bComponentUseFixedSkelBounds
    /// </summary>
    public unsafe bool bComponentUseFixedSkelBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bUseBoundsFromParentAnimComponent
    /// </summary>
    public unsafe bool bUseBoundsFromParentAnimComponent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bConsiderAllBodiesForBounds
    /// </summary>
    public unsafe bool bConsiderAllBodiesForBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bUpdateSkelWhenNotRendered
    /// </summary>
    public unsafe bool bUpdateSkelWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreControllersWhenNotRendered
    /// </summary>
    public unsafe bool bIgnoreControllersWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bTickAnimNodesWhenNotRendered
    /// </summary>
    public unsafe bool bTickAnimNodesWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bNotUpdatingKinematicDueToDistance
    /// </summary>
    public unsafe bool bNotUpdatingKinematicDueToDistance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bForceDiscardRootMotion
    /// </summary>
    public unsafe bool bForceDiscardRootMotion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bNotifyRootMotionProcessed
    /// </summary>
    public unsafe bool bNotifyRootMotionProcessed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bRootMotionModeChangeNotify
    /// </summary>
    public unsafe bool bRootMotionModeChangeNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bRootMotionExtractedNotify
    /// </summary>
    public unsafe bool bRootMotionExtractedNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bProcessingRootMotion
    /// </summary>
    public unsafe bool bProcessingRootMotion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bDisableFaceFXMaterialInstanceCreation
    /// </summary>
    public unsafe bool bDisableFaceFXMaterialInstanceCreation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bDisableFaceFX
    /// </summary>
    public unsafe bool bDisableFaceFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: EnableFaceFXLOD
    /// </summary>
    public unsafe bool EnableFaceFXLOD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: FaceFXNeedsUpdate
    /// </summary>
    public unsafe bool FaceFXNeedsUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bAnimTreeInitialised
    /// </summary>
    public unsafe bool bAnimTreeInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bForceMeshObjectUpdate
    /// </summary>
    public unsafe bool bForceMeshObjectUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bHasPhysicsAssetInstance
    /// </summary>
    public unsafe bool bHasPhysicsAssetInstance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bAllowRFlapsAssetInstance
    /// </summary>
    public unsafe bool bAllowRFlapsAssetInstance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bUpdateKinematicBonesFromAnimation
    /// </summary>
    public unsafe bool bUpdateKinematicBonesFromAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bUpdateJointsFromAnimation
    /// </summary>
    public unsafe bool bUpdateJointsFromAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bSkelCompFixed
    /// </summary>
    public unsafe bool bSkelCompFixed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bHasHadPhysicsBlendedIn
    /// </summary>
    public unsafe bool bHasHadPhysicsBlendedIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: AllowPhysicsBlendOutsidePostTick
    /// </summary>
    public unsafe bool AllowPhysicsBlendOutsidePostTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bForceUpdateAttachmentsInTick
    /// </summary>
    public unsafe bool bForceUpdateAttachmentsInTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bEnableFullAnimWeightBodies
    /// </summary>
    public unsafe bool bEnableFullAnimWeightBodies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bPerBoneVolumeEffects
    /// </summary>
    public unsafe bool bPerBoneVolumeEffects
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bPerBoneMotionBlur
    /// </summary>
    public unsafe bool bPerBoneMotionBlur
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bSyncActorLocationToRootRigidBody
    /// </summary>
    public unsafe bool bSyncActorLocationToRootRigidBody
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bUseRawData
    /// </summary>
    public unsafe bool bUseRawData
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bDisableWarningWhenAnimNotFound
    /// </summary>
    public unsafe bool bDisableWarningWhenAnimNotFound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bOverrideAttachmentOwnerVisibility
    /// </summary>
    public unsafe bool bOverrideAttachmentOwnerVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bNeedsToDeleteHitMask
    /// </summary>
    public unsafe bool bNeedsToDeleteHitMask
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bPauseAnims
    /// </summary>
    public unsafe bool bPauseAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bChartDistanceFactor
    /// </summary>
    public unsafe bool bChartDistanceFactor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bEnableLineCheckWithBounds
    /// </summary>
    public unsafe bool bEnableLineCheckWithBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bCanHighlightSelectedSections
    /// </summary>
    public unsafe bool bCanHighlightSelectedSections
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bUseAggressiveLODScale
    /// </summary>
    public unsafe bool bUseAggressiveLODScale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bAutomaticEmbeddedFaceFXAnims
    /// </summary>
    public unsafe bool bAutomaticEmbeddedFaceFXAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bPhysicsAssetOverridesBoundsType
    /// </summary>
    public unsafe bool bPhysicsAssetOverridesBoundsType
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bUpdateMorphWhenParentAnimComponentExists
    /// </summary>
    public unsafe bool bUpdateMorphWhenParentAnimComponentExists
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// StructProperty: LineCheckBoundsScale
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LineCheckBoundsScale
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1464);

    /// <summary>
    /// BoolProperty: bAllowPermanentFixOnSleep
    /// </summary>
    public unsafe bool bAllowPermanentFixOnSleep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bHasBeenPermanentlyFixed
    /// </summary>
    public unsafe bool bHasBeenPermanentlyFixed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bDisableRagdollCalmingMeasures
    /// </summary>
    public unsafe bool bDisableRagdollCalmingMeasures
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bDisableRagdollCalmingMeasures_FromAnimationSystem
    /// </summary>
    public unsafe bool bDisableRagdollCalmingMeasures_FromAnimationSystem
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bDebugDisableRagdollCalmingMeasures
    /// </summary>
    public unsafe bool bDebugDisableRagdollCalmingMeasures
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bDisableCollisionWhenPermanentlyFixed
    /// </summary>
    public unsafe bool bDisableCollisionWhenPermanentlyFixed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bForceJointProjection
    /// </summary>
    public unsafe bool bForceJointProjection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bForceUseRagdollPhysicsTranslation
    /// </summary>
    public unsafe bool bForceUseRagdollPhysicsTranslation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysBlendInKinematicBodies
    /// </summary>
    public unsafe bool bAlwaysBlendInKinematicBodies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bAllowAngularDampingRamping
    /// </summary>
    public unsafe bool bAllowAngularDampingRamping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// FloatProperty: CurrDampingRampupTime
    /// </summary>
    public unsafe float CurrDampingRampupTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// FloatProperty: DampingRampupMinTime
    /// </summary>
    public unsafe float DampingRampupMinTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// FloatProperty: DampingRampupMaxTime
    /// </summary>
    public unsafe float DampingRampupMaxTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// FloatProperty: PermanentFixRampupTime
    /// </summary>
    public unsafe float PermanentFixRampupTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// FloatProperty: AggressiveLODMultiplier
    /// </summary>
    public unsafe float AggressiveLODMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothSimulation
    /// </summary>
    public unsafe bool bEnableClothSimulation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bDisableClothCollision
    /// </summary>
    public unsafe bool bDisableClothCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothFrozen
    /// </summary>
    public unsafe bool bClothFrozen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bAutoFreezeClothWhenNotRendered
    /// </summary>
    public unsafe bool bAutoFreezeClothWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothAwakeOnStartup
    /// </summary>
    public unsafe bool bClothAwakeOnStartup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothBaseVelClamp
    /// </summary>
    public unsafe bool bClothBaseVelClamp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothBaseVelInterp
    /// </summary>
    public unsafe bool bClothBaseVelInterp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bAttachClothVertsToBaseBody
    /// </summary>
    public unsafe bool bAttachClothVertsToBaseBody
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bIsClothOnStaticObject
    /// </summary>
    public unsafe bool bIsClothOnStaticObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bUpdatedFixedClothVerts
    /// </summary>
    public unsafe bool bUpdatedFixedClothVerts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothPositionalDampening
    /// </summary>
    public unsafe bool bClothPositionalDampening
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothWindRelativeToOwner
    /// </summary>
    public unsafe bool bClothWindRelativeToOwner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bRecentlyRendered
    /// </summary>
    public unsafe bool bRecentlyRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bCacheAnimSequenceNodes
    /// </summary>
    public unsafe bool bCacheAnimSequenceNodes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bNeedsInstanceWeightUpdate
    /// </summary>
    public unsafe bool bNeedsInstanceWeightUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysUseInstanceWeights
    /// </summary>
    public unsafe bool bAlwaysUseInstanceWeights
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bUpdateComposeSkeletonPasses
    /// </summary>
    public unsafe bool bUpdateComposeSkeletonPasses
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bValidTemporarySavedAnimSets
    /// </summary>
    public unsafe bool bValidTemporarySavedAnimSets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bUseParentAnimComponentLODLevel
    /// </summary>
    public unsafe bool bUseParentAnimComponentLODLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bDeferredUpdateAnimatedMaterialParameters
    /// </summary>
    public unsafe bool bDeferredUpdateAnimatedMaterialParameters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bDeferredTrackedNotifyTick
    /// </summary>
    public unsafe bool bDeferredTrackedNotifyTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bOnlyCollideWithRootBone
    /// </summary>
    public unsafe bool bOnlyCollideWithRootBone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bHasCachedLocalNavMeshBounds
    /// </summary>
    public unsafe bool bHasCachedLocalNavMeshBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// StructProperty: CachedLocalNavMeshBounds
    /// </summary>
    public unsafe ref BmSDK.GameObject.FBox CachedLocalNavMeshBounds
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FBox>(Ptr + 1504);

    /// <summary>
    /// ArrayProperty: LODInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FSkelMeshComponentLODInfo> LODInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FSkelMeshComponentLODInfo>>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// StructProperty: FrozenLocalToWorldPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FrozenLocalToWorldPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1548);

    /// <summary>
    /// StructProperty: FrozenLocalToWorldRot
    /// </summary>
    public unsafe ref BmSDK.Rotator FrozenLocalToWorldRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1560);

    /// <summary>
    /// StructProperty: ClothExternalForce
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ClothExternalForce
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1572);

    /// <summary>
    /// StructProperty: ClothWind
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ClothWind
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1584);

    /// <summary>
    /// StructProperty: ClothBaseVelClampRange
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ClothBaseVelClampRange
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1596);

    /// <summary>
    /// FloatProperty: ClothBlendWeight
    /// </summary>
    public unsafe float ClothBlendWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// FloatProperty: ClothDynamicBlendWeight
    /// </summary>
    public unsafe float ClothDynamicBlendWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// FloatProperty: ClothBlendMinDistanceFactor
    /// </summary>
    public unsafe float ClothBlendMinDistanceFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// FloatProperty: ClothBlendMaxDistanceFactor
    /// </summary>
    public unsafe float ClothBlendMaxDistanceFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// StructProperty: MinPosDampRange
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MinPosDampRange
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1624);

    /// <summary>
    /// StructProperty: MaxPosDampRange
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MaxPosDampRange
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1636);

    /// <summary>
    /// StructProperty: MinPosDampScale
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MinPosDampScale
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1648);

    /// <summary>
    /// StructProperty: MaxPosDampScale
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MaxPosDampScale
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1660);

    /// <summary>
    /// StructProperty: ClothSim
    /// </summary>
    public unsafe System.IntPtr ClothSim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }

    /// <summary>
    /// IntProperty: SceneIndex
    /// </summary>
    public unsafe int SceneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshPosData
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> ClothMeshPosData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshNormalData
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> ClothMeshNormalData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshIndexData
    /// </summary>
    public unsafe BmSDK.TArray<int> ClothMeshIndexData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// IntProperty: NumClothMeshVerts
    /// </summary>
    public unsafe int NumClothMeshVerts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// IntProperty: NumClothMeshIndices
    /// </summary>
    public unsafe int NumClothMeshIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshParentData
    /// </summary>
    public unsafe BmSDK.TArray<int> ClothMeshParentData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1740); }
    }

    /// <summary>
    /// IntProperty: NumClothMeshParentIndices
    /// </summary>
    public unsafe int NumClothMeshParentIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1756); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshWeldedPosData
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> ClothMeshWeldedPosData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshWeldedNormalData
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> ClothMeshWeldedNormalData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshWeldedIndexData
    /// </summary>
    public unsafe BmSDK.TArray<int> ClothMeshWeldedIndexData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// IntProperty: ClothDirtyBufferFlag
    /// </summary>
    public unsafe int ClothDirtyBufferFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// ByteProperty: ClothRBChannel
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel ClothRBChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// StructProperty: ClothRBCollideWithChannels
    /// </summary>
    public unsafe ref BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer ClothRBCollideWithChannels
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer>(Ptr + 1816);

    /// <summary>
    /// FloatProperty: ClothForceScale
    /// </summary>
    public unsafe float ClothForceScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// FloatProperty: ClothImpulseScale
    /// </summary>
    public unsafe float ClothImpulseScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }
    }

    /// <summary>
    /// FloatProperty: ClothAttachmentTearFactor
    /// </summary>
    public unsafe float ClothAttachmentTearFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// BoolProperty: bClothUseCompartment
    /// </summary>
    public unsafe bool bClothUseCompartment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1832) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1832); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1832); }
    }

    /// <summary>
    /// FloatProperty: MinDistanceForClothReset
    /// </summary>
    public unsafe float MinDistanceForClothReset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }

    /// <summary>
    /// StructProperty: LastClothLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastClothLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1840);

    /// <summary>
    /// ByteProperty: ApexClothingRBChannel
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel ApexClothingRBChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// StructProperty: ApexClothingRBCollideWithChannels
    /// </summary>
    public unsafe ref BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer ApexClothingRBCollideWithChannels
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer>(Ptr + 1856);

    /// <summary>
    /// ByteProperty: ApexClothingCollisionRBChannel
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel ApexClothingCollisionRBChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// BoolProperty: bAutoFreezeApexClothingWhenNotRendered
    /// </summary>
    public unsafe bool bAutoFreezeApexClothingWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1864); }
    }

    /// <summary>
    /// BoolProperty: bLocalSpaceWind
    /// </summary>
    public unsafe bool bLocalSpaceWind
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1864); }
    }

    /// <summary>
    /// BoolProperty: bApexClothingBaseVelClamp
    /// </summary>
    public unsafe bool bApexClothingBaseVelClamp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1864); }
    }

    /// <summary>
    /// StructProperty: ApexClothingBaseVelClampRange
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ApexClothingBaseVelClampRange
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1868);

    /// <summary>
    /// StructProperty: WindVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WindVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1880);

    /// <summary>
    /// FloatProperty: WindVelocityBlendTime
    /// </summary>
    public unsafe float WindVelocityBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bClothingMaterialOverride
    /// </summary>
    public unsafe bool bClothingMaterialOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1896); }
    }

    /// <summary>
    /// ObjectProperty: ClothingMaterial
    /// </summary>
    public unsafe BmSDK.Engine.ClothingMaterial ClothingMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ClothingMaterial>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// BoolProperty: bSkipInitClothing
    /// </summary>
    public unsafe bool bSkipInitClothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1908) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1908); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1908); }
    }

    /// <summary>
    /// StructProperty: AudioBonesToTrack
    /// </summary>
    public unsafe ref BmSDK.Engine.RSkeletalMeshComponent_Export.FAudioBoneTracking AudioBonesToTrack
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RSkeletalMeshComponent_Export.FAudioBoneTracking>(Ptr + 1912);

    /// <summary>
    /// StructProperty: PersistentSoundNotifies
    /// </summary>
    public unsafe ref BmSDK.Engine.RSkeletalMeshComponent_Export.FPersistentSoundData PersistentSoundNotifies
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RSkeletalMeshComponent_Export.FPersistentSoundData>(Ptr + 1928);

    /// <summary>
    /// ObjectProperty: LimitMaterial
    /// </summary>
    public unsafe BmSDK.Engine.Material LimitMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// StructProperty: RootMotionDelta
    /// </summary>
    public unsafe ref BmSDK.GameObject.FBoneAtom RootMotionDelta
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FBoneAtom>(Ptr + 1968);

    /// <summary>
    /// StructProperty: RootMotionVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RootMotionVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2000);

    /// <summary>
    /// StructProperty: RootMotionAccelScale
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RootMotionAccelScale
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2012);

    /// <summary>
    /// ByteProperty: RootMotionMode
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.ERootMotionMode RootMotionMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.ERootMotionMode>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// ByteProperty: PreviousRMM
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.ERootMotionMode PreviousRMM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.ERootMotionMode>(Ptr + 2025); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2025); }
    }

    /// <summary>
    /// ByteProperty: PendingRMM
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.ERootMotionMode PendingRMM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.ERootMotionMode>(Ptr + 2026); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2026); }
    }

    /// <summary>
    /// ByteProperty: OldPendingRMM
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.ERootMotionMode OldPendingRMM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.ERootMotionMode>(Ptr + 2027); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2027); }
    }

    /// <summary>
    /// IntProperty: bRMMOneFrameDelay
    /// </summary>
    public unsafe int bRMMOneFrameDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// ByteProperty: RootMotionRotationMode
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.ERootMotionRotationMode RootMotionRotationMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.ERootMotionRotationMode>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// ByteProperty: AnimRotationOnly
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.EAnimRotationOnly AnimRotationOnly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.EAnimRotationOnly>(Ptr + 2033); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2033); }
    }

    /// <summary>
    /// ByteProperty: FaceFXBlendMode
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.EFaceFXBlendMode FaceFXBlendMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.EFaceFXBlendMode>(Ptr + 2034); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2034); }
    }

    /// <summary>
    /// StructProperty: FaceFXActorInstance
    /// </summary>
    public unsafe System.IntPtr FaceFXActorInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2036); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXRegisterTransitions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXRegisterTransition> FaceFXRegisterTransitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXRegisterTransition>>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXRegisterConstants
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXRegisterConstant> FaceFXRegisterConstants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXRegisterConstant>>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXEmbeddedAnimSamples
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXEmbeddedAnimSample> FaceFXEmbeddedAnimSamples
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXEmbeddedAnimSample>>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXBaseExpressionSamples
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXBaseExpressionSample> FaceFXBaseExpressionSamples
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXBaseExpressionSample>>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXBoneAtoms
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FBoneAtom> FaceFXBoneAtoms
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FBoneAtom>>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// ObjectProperty: FaceFXPlayAnim_AnimSet
    /// </summary>
    public unsafe BmSDK.Engine.FaceFXAnimSet FaceFXPlayAnim_AnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FaceFXAnimSet>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// StrProperty: FaceFXPlayAnim_AnimName
    /// </summary>
    public unsafe BmSDK.FString FaceFXPlayAnim_AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// FloatProperty: FaceFXPlayAnim_Time
    /// </summary>
    public unsafe float FaceFXPlayAnim_Time
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// ObjectProperty: FaceFXForceAnim_AnimSet
    /// </summary>
    public unsafe BmSDK.Engine.FaceFXAnimSet FaceFXForceAnim_AnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FaceFXAnimSet>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }

    /// <summary>
    /// StrProperty: FaceFXForceAnim_AnimName
    /// </summary>
    public unsafe BmSDK.FString FaceFXForceAnim_AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// FloatProperty: FaceFXForceAnim_Time
    /// </summary>
    public unsafe float FaceFXForceAnim_Time
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// IntProperty: EnableFaceFXAtLODIndex
    /// </summary>
    public unsafe int EnableFaceFXAtLODIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2180); }
    }

    /// <summary>
    /// StructProperty: MatineeLookAt
    /// </summary>
    public unsafe ref BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXMatineeLookAt MatineeLookAt
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXMatineeLookAt>(Ptr + 2184);

    /// <summary>
    /// ObjectProperty: DrivenMaterialParameterInstance
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshDrivenMaterialParameterInstance DrivenMaterialParameterInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshDrivenMaterialParameterInstance>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// ArrayProperty: DrivenMaterialParameterInstanceErrors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DrivenMaterialParameterInstanceErrors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// StructProperty: AnimatedMaterialParameters
    /// </summary>
    public unsafe ref BmSDK.Engine.RSkeletalMeshComponent_Export.FAnimatedMaterialParameters AnimatedMaterialParameters
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RSkeletalMeshComponent_Export.FAnimatedMaterialParameters>(Ptr + 2256);

    /// <summary>
    /// ArrayProperty: BoneVisibilityStates
    /// </summary>
    public unsafe BmSDK.TArray<byte> BoneVisibilityStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 2288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }
    }

    /// <summary>
    /// ArrayProperty: AlternativeBoneVisibilityStates
    /// </summary>
    public unsafe BmSDK.TArray<bool> AlternativeBoneVisibilityStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// StructProperty: LocalToWorldBoneAtom
    /// </summary>
    public unsafe ref BmSDK.GameObject.FBoneAtom LocalToWorldBoneAtom
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FBoneAtom>(Ptr + 2320);

    /// <summary>
    /// StructProperty: DiscardedRootMotion
    /// </summary>
    public unsafe ref BmSDK.GameObject.FBoneAtom DiscardedRootMotion
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FBoneAtom>(Ptr + 2352);

    /// <summary>
    /// StructProperty: CurrDepthBiasData
    /// </summary>
    public unsafe ref BmSDK.Engine.SkeletalMeshComponent.FDepthBiasData CurrDepthBiasData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.SkeletalMeshComponent.FDepthBiasData>(Ptr + 2384);

    /// <summary>
    /// BoolProperty: bDisableColourWrites
    /// </summary>
    public unsafe bool bDisableColourWrites
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableTwistBoneFixers
    /// </summary>
    public unsafe bool bEnableTwistBoneFixers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableKneeElbowFixers
    /// </summary>
    public unsafe bool bEnableKneeElbowFixers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableNeckTwistFixer
    /// </summary>
    public unsafe bool bEnableNeckTwistFixer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableCollarTwistFixer
    /// </summary>
    public unsafe bool bEnableCollarTwistFixer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableBreathingFixer
    /// </summary>
    public unsafe bool bEnableBreathingFixer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableSkeletalMeshSkelControls
    /// </summary>
    public unsafe bool bEnableSkeletalMeshSkelControls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableDrivenMaterialParameters
    /// </summary>
    public unsafe bool bEnableDrivenMaterialParameters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bInsideWindForceFieldVolume
    /// </summary>
    public unsafe bool bInsideWindForceFieldVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bAllowRagdollContainmentChecks
    /// </summary>
    public unsafe bool bAllowRagdollContainmentChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bStuckAsARagdoll
    /// </summary>
    public unsafe bool bStuckAsARagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// IntProperty: StuckBodyPartIndex
    /// </summary>
    public unsafe int StuckBodyPartIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2444); }
    }

    /// <summary>
    /// StructProperty: StuckStartTime
    /// </summary>
    public unsafe double StuckStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<double>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// FloatProperty: CurrRagdollTime
    /// </summary>
    public unsafe float CurrRagdollTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// FloatProperty: ContainmentTestDelay
    /// </summary>
    public unsafe float ContainmentTestDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// FloatProperty: MaxRagdollLiveTime
    /// </summary>
    public unsafe float MaxRagdollLiveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// FloatProperty: MinRagdollStuckTime
    /// </summary>
    public unsafe float MinRagdollStuckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }

    /// <summary>
    /// FloatProperty: MinNearlyStillBodiesProportionForNearlyStillRagdoll
    /// </summary>
    public unsafe float MinNearlyStillBodiesProportionForNearlyStillRagdoll
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// ArrayProperty: BoneToBody
    /// </summary>
    public unsafe BmSDK.TArray<int> BoneToBody
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }
    }

    /// <summary>
    /// ArrayProperty: BodyToBone
    /// </summary>
    public unsafe BmSDK.TArray<int> BodyToBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// StructProperty: Fixers
    /// </summary>
    public unsafe ref BmSDK.Engine.RSkeletalMeshComponent_Export.FFixers Fixers
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RSkeletalMeshComponent_Export.FFixers>(Ptr + 2508);

    /// <summary>
    /// StructProperty: BreathingFixer
    /// </summary>
    public unsafe ref BmSDK.Engine.RSkeletalMeshComponent_Export.FBreathingFixer BreathingFixer
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RSkeletalMeshComponent_Export.FBreathingFixer>(Ptr + 2568);

    /// <summary>
    /// ArrayProperty: ExtraSocketMeshes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh> ExtraSocketMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh>>(Ptr + 2588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2588); }
    }

    /// <summary>
    /// FloatProperty: ProgressiveDrawingFraction
    /// </summary>
    public unsafe float ProgressiveDrawingFraction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2604); }
    }

    /// <summary>
    /// ByteProperty: CustomSortAlternateIndexMode
    /// </summary>
    public unsafe byte CustomSortAlternateIndexMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// ArrayProperty: MorphTargetsQueried
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> MorphTargetsQueried
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// StructProperty: PhysXAggregate
    /// </summary>
    public unsafe System.IntPtr PhysXAggregate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }

    /// <summary>
    /// StructProperty: AsyncJob
    /// </summary>
    public unsafe System.IntPtr AsyncJob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// FloatProperty: RFlapsInitialBlendWeightOverride
    /// </summary>
    public unsafe float RFlapsInitialBlendWeightOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2644); }
    }
}
