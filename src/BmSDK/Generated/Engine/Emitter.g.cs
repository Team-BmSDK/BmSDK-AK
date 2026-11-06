#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Emitter<br/>
/// (size = 729)
/// (flags = 144704146)
/// </summary>
public partial class Emitter : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Emitter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as Emitter.
    /// </summary>
    public static Emitter DefaultObject => (Emitter)StaticClass().DefaultObject;

    internal Emitter() { }

    /// <summary>
    /// Constructs a new Emitter
    /// </summary>
    public Emitter(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Emitter(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Emitter>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Emitter>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Emitter>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Emitter>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Emitter>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Emitter>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Emitter>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Emitter>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_InterpolationChanged;
    /// <summary>
    /// Function: InterpolationChanged
    /// </summary>
    public unsafe override void InterpolationChanged(BmSDK.Engine.SeqAct_Interp InterpAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterpolationChanged, "Engine.Emitter.InterpolationChanged");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideSelf;
    /// <summary>
    /// Function: HideSelf
    /// </summary>
    public unsafe virtual void HideSelf()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideSelf, "Engine.Emitter.HideSelf");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyCheckpointRecord;
    /// <summary>
    /// Function: ApplyCheckpointRecord
    /// </summary>
    public unsafe virtual void ApplyCheckpointRecord(out BmSDK.Engine.Emitter.FCheckpointRecord Record)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyCheckpointRecord, "Engine.Emitter.ApplyCheckpointRecord");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Record);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Record, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Record = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Emitter.FCheckpointRecord>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_CreateCheckpointRecord;
    /// <summary>
    /// Function: CreateCheckpointRecord
    /// </summary>
    public unsafe virtual void CreateCheckpointRecord(out BmSDK.Engine.Emitter.FCheckpointRecord Record)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateCheckpointRecord, "Engine.Emitter.CreateCheckpointRecord");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Record);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Record, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Record = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Emitter.FCheckpointRecord>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldSaveForCheckpoint;
    /// <summary>
    /// Function: ShouldSaveForCheckpoint
    /// </summary>
    public unsafe virtual bool ShouldSaveForCheckpoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSaveForCheckpoint, "Engine.Emitter.ShouldSaveForCheckpoint");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnSetParticleSysParam;
    /// <summary>
    /// Function: OnSetParticleSysParam
    /// </summary>
    public unsafe virtual void OnSetParticleSysParam(BmSDK.Engine.SeqAct_SetParticleSysParam Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSetParticleSysParam, "Engine.Emitter.OnSetParticleSysParam");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetActorParameter;
    /// <summary>
    /// Function: SetActorParameter
    /// </summary>
    public unsafe virtual void SetActorParameter(BmSDK.FName ParameterName, BmSDK.Engine.Actor Param)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetActorParameter, "Engine.Emitter.SetActorParameter");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Param, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetExtColorParameter;
    /// <summary>
    /// Function: SetExtColorParameter
    /// </summary>
    public unsafe virtual void SetExtColorParameter(BmSDK.FName ParameterName, byte Red, byte Green, byte Blue, byte Alpha)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetExtColorParameter, "Engine.Emitter.SetExtColorParameter");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Red, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Green, paramsPtr + 9);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Blue, paramsPtr + 10);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 11);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetColorParameter;
    /// <summary>
    /// Function: SetColorParameter
    /// </summary>
    public unsafe virtual void SetColorParameter(BmSDK.FName ParameterName, BmSDK.GameObject.FColor Param)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetColorParameter, "Engine.Emitter.SetColorParameter");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Param, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVectorParameter;
    /// <summary>
    /// Function: SetVectorParameter
    /// </summary>
    public unsafe virtual void SetVectorParameter(BmSDK.FName ParameterName, System.Numerics.Vector3 Param)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVectorParameter, "Engine.Emitter.SetVectorParameter");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Param, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFloatParameter;
    /// <summary>
    /// Function: SetFloatParameter
    /// </summary>
    public unsafe virtual void SetFloatParameter(BmSDK.FName ParameterName, float Param)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFloatParameter, "Engine.Emitter.SetFloatParameter");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Param, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShutDown;
    /// <summary>
    /// Function: ShutDown
    /// </summary>
    public unsafe override void ShutDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShutDown, "Engine.Emitter.ShutDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndMatineeControl;
    /// <summary>
    /// Function: EndMatineeControl
    /// </summary>
    public unsafe override void EndMatineeControl(BmSDK.Engine.InterpGroup InInterpGroup, BmSDK.Engine.InterpGroupInst InInterpGroupInst)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndMatineeControl, "Engine.Emitter.EndMatineeControl");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroupInst, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginMatineeControl;
    /// <summary>
    /// Function: BeginMatineeControl
    /// </summary>
    public unsafe override void BeginMatineeControl(BmSDK.Engine.InterpGroup InInterpGroup, BmSDK.Engine.InterpGroupInst InInterpGroupInst)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginMatineeControl, "Engine.Emitter.BeginMatineeControl");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroupInst, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnParticleEventGenerator;
    /// <summary>
    /// Function: OnParticleEventGenerator
    /// </summary>
    public unsafe virtual void OnParticleEventGenerator(BmSDK.Engine.SeqAct_ParticleEventGenerator Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnParticleEventGenerator, "Engine.Emitter.OnParticleEventGenerator");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnToggle;
    /// <summary>
    /// Function: OnToggle
    /// </summary>
    public unsafe virtual void OnToggle(BmSDK.Engine.SeqAct_Toggle Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggle, "Engine.Emitter.OnToggle");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnParticleSystemFinished;
    /// <summary>
    /// Function: OnParticleSystemFinished
    /// </summary>
    public unsafe virtual void OnParticleSystemFinished(BmSDK.Engine.ParticleSystemComponent FinishedComponent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnParticleSystemFinished, "Engine.Emitter.OnParticleSystemFinished");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedComponent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReplicatedEvent;
    /// <summary>
    /// Function: ReplicatedEvent
    /// </summary>
    public unsafe override void ReplicatedEvent(BmSDK.FName VarName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicatedEvent, "Engine.Emitter.ReplicatedEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "Engine.Emitter.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTemplate;
    /// <summary>
    /// Function: SetTemplate
    /// </summary>
    public unsafe virtual void SetTemplate(BmSDK.Engine.ParticleSystem NewTemplate, bool bDestroyOnFinish)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTemplate, "Engine.Emitter.SetTemplate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTemplate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDestroyOnFinish, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetAkAudible;
    /// <summary>
    /// Function: GetAkAudible
    /// </summary>
    public unsafe override BmSDK.Engine.RAkAudible GetAkAudible(bool allowCreate = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAkAudible, "Engine.Emitter.GetAkAudible");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(allowCreate, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.RAkAudible>(paramsPtr + 4);
    }

    /// <summary>
    /// Enum: EEmitterTickReason
    /// </summary>
    public enum EEmitterTickReason : byte
    {
        EMITTERTICKREASON_NotTicking_HiddenOrInactive = 0,
        EMITTERTICKREASON_NotTicking_LoopingAndNotRecentlyRendered = 1,
        EMITTERTICKREASON_Ticking_Matinee = 2,
        EMITTERTICKREASON_Ticking_LoopingAndRecentlyRendered = 3,
        EMITTERTICKREASON_Ticking_OneShotAndRecentlyRendered = 4,
        EMITTERTICKREASON_Ticking_OneShotAndNotRecentlyRendered = 5,
        EMITTERTICKREASON_Ticking_AudioProximity = 6,
        EMITTERTICKREASON_MAX = 7,
    }

    /// <summary>
    /// Struct: FCheckpointRecord
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FCheckpointRecord
    {
        /// <summary>
        /// BoolProperty: bIsActive
        /// </summary>
        public unsafe bool bIsActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// ComponentProperty: ParticleSystemComponent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ParticleSystemComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ArrayProperty: OverrideParticleAudio
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkWwise.FAkParticleEvents> OverrideParticleAudio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkWwise.FAkParticleEvents>>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// BoolProperty: DisableAudio
    /// </summary>
    public unsafe bool DisableAudio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bDestroyOnSystemFinish
    /// </summary>
    public unsafe bool bDestroyOnSystemFinish
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bPostUpdateTickGroup
    /// </summary>
    public unsafe bool bPostUpdateTickGroup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bAllowMatineeToPause
    /// </summary>
    public unsafe bool bAllowMatineeToPause
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bSkipFirstTick
    /// </summary>
    public unsafe bool bSkipFirstTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bCurrentlyActive
    /// </summary>
    public unsafe bool bCurrentlyActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// ArrayProperty: MatineeControlReferences
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.InterpGroupInst> MatineeControlReferences
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.InterpGroupInst>>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ArrayProperty: WhooshBys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkWwise.FSimpleWhooshBy> WhooshBys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkWwise.FSimpleWhooshBy>>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ByteProperty: TickReason
    /// </summary>
    public unsafe BmSDK.Engine.Emitter.EEmitterTickReason TickReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter.EEmitterTickReason>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }
}
