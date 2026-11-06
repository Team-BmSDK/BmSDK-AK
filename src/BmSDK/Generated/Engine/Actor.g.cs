#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: Actor<br/>
/// (size = 668)
/// (flags = 144705683)
/// </summary>
public partial class Actor : BmSDK.StateObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Actor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as Actor.
    /// </summary>
    public static Actor DefaultObject => (Actor)StaticClass().DefaultObject;

    internal Actor() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Actor(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Actor>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Actor>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Actor>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Actor>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Actor>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Actor>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Actor>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Actor>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_IsStaticForFloorCorrection;
    /// <summary>
    /// Function: IsStaticForFloorCorrection
    /// </summary>
    public unsafe virtual bool IsStaticForFloorCorrection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStaticForFloorCorrection, "Engine.Actor.IsStaticForFloorCorrection");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_OverrideHighResTextureStreaming;
    /// <summary>
    /// Function: OverrideHighResTextureStreaming
    /// </summary>
    public unsafe virtual void OverrideHighResTextureStreaming(float SecondsToOverride)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideHighResTextureStreaming, "Engine.Actor.OverrideHighResTextureStreaming");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondsToOverride, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetTimeSince;
    /// <summary>
    /// Function: GetTimeSince
    /// </summary>
    public unsafe virtual float GetTimeSince(double StartTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeSince, "Engine.Actor.GetTimeSince");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetTimerStart;
    /// <summary>
    /// Function: GetTimerStart
    /// </summary>
    public unsafe virtual double GetTimerStart()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimerStart, "Engine.Actor.GetTimerStart");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<double>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetBatmanCanClimb;
    /// <summary>
    /// Function: SetBatmanCanClimb
    /// </summary>
    public unsafe virtual void SetBatmanCanClimb(bool bCanClimb)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBatmanCanClimb, "Engine.Actor.SetBatmanCanClimb");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanClimb, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetScriptCallstackAsDetailThoughts;
    /// <summary>
    /// Function: GetScriptCallstackAsDetailThoughts
    /// </summary>
    public unsafe static BmSDK.TArray<BmSDK.Engine.Actor.FDetailThought> GetScriptCallstackAsDetailThoughts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScriptCallstackAsDetailThoughts, "Engine.Actor.GetScriptCallstackAsDetailThoughts");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FDetailThought>>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_LogThoughtInternal;
    /// <summary>
    /// Function: LogThoughtInternal
    /// </summary>
    public unsafe static void LogThoughtInternal(BmSDK.Engine.Actor Actor, BmSDK.FName SubGroup, int Flags, BmSDK.FString Text, BmSDK.TArray<BmSDK.Engine.Actor.FDetailThought> DetailThoughts = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogThoughtInternal, "Engine.Actor.LogThoughtInternal");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubGroup, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Flags, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DetailThoughts, paramsPtr + 36);
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

    private static BmSDK.Function __fn_GetThoughts;
    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe virtual void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList, BmSDK.FName SubGroup)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "Engine.Actor.GetThoughts");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubGroup, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetActorSpriteComponent;
    /// <summary>
    /// Function: GetActorSpriteComponent
    /// </summary>
    public unsafe virtual BmSDK.Engine.SpriteComponent GetActorSpriteComponent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActorSpriteComponent, "Engine.Actor.GetActorSpriteComponent");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.SpriteComponent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetActorMetrics;
    /// <summary>
    /// Function: GetActorMetrics
    /// </summary>
    public unsafe virtual int GetActorMetrics(BmSDK.Engine.Actor.EActorMetricsType MetricsType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActorMetrics, "Engine.Actor.GetActorMetrics");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MetricsType, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsMobileTouchEnabled;
    /// <summary>
    /// Function: IsMobileTouchEnabled
    /// </summary>
    public unsafe virtual bool IsMobileTouchEnabled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMobileTouchEnabled, "Engine.Actor.IsMobileTouchEnabled");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ParticleCollisionEvent;
    /// <summary>
    /// Function: ParticleCollisionEvent
    /// </summary>
    public unsafe virtual void ParticleCollisionEvent(BmSDK.GameObject ParticleSystemComponent, BmSDK.Engine.Actor HitActor, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ParticleCollisionEvent, "Engine.Actor.ParticleCollisionEvent");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParticleSystemComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitActor, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAIPointOfInterestExtent;
    /// <summary>
    /// Function: GetAIPointOfInterestExtent
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAIPointOfInterestExtent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAIPointOfInterestExtent, "Engine.Actor.GetAIPointOfInterestExtent");
        byte* paramsPtr = stackalloc byte[12];
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

    private static BmSDK.Function __fn_GetAIPointOfInterestPosition;
    /// <summary>
    /// Function: GetAIPointOfInterestPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAIPointOfInterestPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAIPointOfInterestPosition, "Engine.Actor.GetAIPointOfInterestPosition");
        byte* paramsPtr = stackalloc byte[12];
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

    private static BmSDK.Function __fn_DeregisterAsAIPointOfInterestWithNavMesh;
    /// <summary>
    /// Function: DeregisterAsAIPointOfInterestWithNavMesh
    /// </summary>
    public unsafe virtual void DeregisterAsAIPointOfInterestWithNavMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeregisterAsAIPointOfInterestWithNavMesh, "Engine.Actor.DeregisterAsAIPointOfInterestWithNavMesh");
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

    private static BmSDK.Function __fn_RegisterAsAIPointOfInterestWithNavMesh;
    /// <summary>
    /// Function: RegisterAsAIPointOfInterestWithNavMesh
    /// </summary>
    public unsafe virtual void RegisterAsAIPointOfInterestWithNavMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterAsAIPointOfInterestWithNavMesh, "Engine.Actor.RegisterAsAIPointOfInterestWithNavMesh");
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

    private static BmSDK.Function __fn_CanBasePawn;
    /// <summary>
    /// Function: CanBasePawn
    /// </summary>
    public unsafe virtual bool CanBasePawn(BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBasePawn, "Engine.Actor.CanBasePawn");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsLevelHidden;
    /// <summary>
    /// Function: IsLevelHidden
    /// </summary>
    public unsafe virtual bool IsLevelHidden()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLevelHidden, "Engine.Actor.IsLevelHidden");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_NotifyPhysicsAudioEvent;
    /// <summary>
    /// Function: NotifyPhysicsAudioEvent
    /// </summary>
    public unsafe virtual void NotifyPhysicsAudioEvent(BmSDK.Engine.AkWwise.EAkPhysicsNotifyType colType, System.Numerics.Vector3 colPos, float colVel, float colMag, float colWet, BmSDK.Engine.AkEvent colEvent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPhysicsAudioEvent, "Engine.Actor.NotifyPhysicsAudioEvent");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(colType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(colPos, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(colVel, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(colMag, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(colWet, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(colEvent, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetGlobalAudioState;
    /// <summary>
    /// Function: ResetGlobalAudioState
    /// </summary>
    public unsafe static void ResetGlobalAudioState(BmSDK.Engine.AkStateName StateName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetGlobalAudioState, "Engine.Actor.ResetGlobalAudioState");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGlobalAudioState;
    /// <summary>
    /// Function: SetGlobalAudioState
    /// </summary>
    public unsafe static void SetGlobalAudioState(BmSDK.Engine.AkStateName StateName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGlobalAudioState, "Engine.Actor.SetGlobalAudioState");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGlobalAudioParameter;
    /// <summary>
    /// Function: SetGlobalAudioParameter
    /// </summary>
    public unsafe static void SetGlobalAudioParameter(BmSDK.Engine.AkParameterName ParamName, float ParamValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGlobalAudioParameter, "Engine.Actor.SetGlobalAudioParameter");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamValue, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasSoundPlayed;
    /// <summary>
    /// Function: HasSoundPlayed
    /// </summary>
    public unsafe static bool HasSoundPlayed(BmSDK.Engine.AkWwise.FAkSoundHandle SoundHandleToTest)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasSoundPlayed, "Engine.Actor.HasSoundPlayed");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundHandleToTest, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_StartGlobalAudioEvent;
    /// <summary>
    /// Function: StartGlobalAudioEvent
    /// </summary>
    public unsafe static BmSDK.Engine.AkWwise.FAkSoundHandle StartGlobalAudioEvent(BmSDK.Engine.AkEvent AudioEvent, BmSDK.Engine.AkWwise.EGlobalAudioSourceID GlobalSource, System.IntPtr SoundCallbackDelegate = default, int SoundCallbackFlags = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGlobalAudioEvent, "Engine.Actor.StartGlobalAudioEvent");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AudioEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GlobalSource, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCallbackDelegate, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCallbackFlags, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkWwise.FAkSoundHandle>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetAudioThoughts;
    /// <summary>
    /// Function: GetAudioThoughts
    /// </summary>
    public unsafe virtual bool GetAudioThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList, out System.Numerics.Vector3 thoughtLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAudioThoughts, "Engine.Actor.GetAudioThoughts");
        byte* paramsPtr = stackalloc byte[32];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out thoughtLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(thoughtLocation, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        thoughtLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetSocketSpatial;
    /// <summary>
    /// Function: GetSocketSpatial
    /// </summary>
    public unsafe virtual bool GetSocketSpatial(BmSDK.FName socketOrBone, out System.Numerics.Vector3 sckPosition, out BmSDK.Rotator sckOrientation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSocketSpatial, "Engine.Actor.GetSocketSpatial");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(socketOrBone, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out sckPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sckPosition, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out sckOrientation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sckOrientation, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        sckPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        sckOrientation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetDialogueSpatial;
    /// <summary>
    /// Function: GetDialogueSpatial
    /// </summary>
    public unsafe virtual void GetDialogueSpatial(out System.Numerics.Vector3 dlgPosition, out BmSDK.Rotator dlgOrientation, BmSDK.GameObject caller = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDialogueSpatial, "Engine.Actor.GetDialogueSpatial");
        byte* paramsPtr = stackalloc byte[32];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out dlgPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgPosition, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out dlgOrientation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgOrientation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(caller, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        dlgPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        dlgOrientation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetAudioSpatial;
    /// <summary>
    /// Function: GetAudioSpatial
    /// </summary>
    public unsafe virtual void GetAudioSpatial(out System.Numerics.Vector3 sndPosition, out BmSDK.Rotator sndOrientation, BmSDK.GameObject caller = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAudioSpatial, "Engine.Actor.GetAudioSpatial");
        byte* paramsPtr = stackalloc byte[32];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out sndPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sndPosition, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out sndOrientation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sndOrientation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(caller, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        sndPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        sndOrientation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_AudibleUpdateSourceCallback;
    /// <summary>
    /// Function: AudibleUpdateSourceCallback
    /// </summary>
    public unsafe virtual void AudibleUpdateSourceCallback(BmSDK.Engine.RAkAudible akAud, bool hasSource)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudibleUpdateSourceCallback, "Engine.Actor.AudibleUpdateSourceCallback");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(akAud, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hasSource, paramsPtr + 8);
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

    private static BmSDK.Function __fn_CancelAudioCallbacks;
    /// <summary>
    /// Function: CancelAudioCallbacks
    /// </summary>
    public unsafe virtual void CancelAudioCallbacks()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelAudioCallbacks, "Engine.Actor.CancelAudioCallbacks");
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

    private static BmSDK.Function __fn_SetAudioSwitch;
    /// <summary>
    /// Function: SetAudioSwitch
    /// </summary>
    public unsafe virtual void SetAudioSwitch(BmSDK.Engine.AkSwitchName SwitchName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAudioSwitch, "Engine.Actor.SetAudioSwitch");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwitchName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetAudioParameter;
    /// <summary>
    /// Function: SetAudioParameter
    /// </summary>
    public unsafe virtual void SetAudioParameter(BmSDK.Engine.AkParameterName ParamName, float ParamValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAudioParameter, "Engine.Actor.SetAudioParameter");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamValue, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetPortraitName;
    /// <summary>
    /// Function: GetPortraitName
    /// </summary>
    public unsafe virtual BmSDK.FString GetPortraitName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPortraitName, "Engine.Actor.GetPortraitName");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetVoiceName;
    /// <summary>
    /// Function: GetVoiceName
    /// </summary>
    public unsafe virtual BmSDK.FString GetVoiceName(bool forSubtitle = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVoiceName, "Engine.Actor.GetVoiceName");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(forSubtitle, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetDialogueVoice;
    /// <summary>
    /// Function: SetDialogueVoice
    /// </summary>
    public unsafe virtual void SetDialogueVoice(BmSDK.Engine.AkDialogueVoice dlgVoice)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDialogueVoice, "Engine.Actor.SetDialogueVoice");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgVoice, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetDialogueVoice;
    /// <summary>
    /// Function: GetDialogueVoice
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkDialogueVoice GetDialogueVoice()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDialogueVoice, "Engine.Actor.GetDialogueVoice");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogueVoice>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanEmote;
    /// <summary>
    /// Function: CanEmote
    /// </summary>
    public unsafe virtual bool CanEmote()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanEmote, "Engine.Actor.CanEmote");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CantSpeakReason;
    /// <summary>
    /// Function: CantSpeakReason
    /// </summary>
    public unsafe virtual BmSDK.FString CantSpeakReason(BmSDK.Engine.AkDialogueSpeech Speech, BmSDK.Engine.AkDialogue.FAkSpeechOptions dlgOpts = default, bool dlgContinuation = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CantSpeakReason, "Engine.Actor.CantSpeakReason");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speech, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgOpts, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgContinuation, paramsPtr + 124);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 128);
    }

    private static BmSDK.Function __fn_CanSpeak;
    /// <summary>
    /// Function: CanSpeak
    /// </summary>
    public unsafe virtual bool CanSpeak(BmSDK.Engine.AkDialogueSpeech Speech, BmSDK.Engine.AkDialogue.FAkSpeechOptions dlgOpts = default, bool dlgContinuation = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSpeak, "Engine.Actor.CanSpeak");
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speech, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgOpts, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgContinuation, paramsPtr + 124);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 128);
    }

    private static BmSDK.Function __fn_IsSpeaking;
    /// <summary>
    /// Function: IsSpeaking
    /// </summary>
    public unsafe virtual bool IsSpeaking(bool rightNow = default, bool withPlayer = default, bool checkVoiceAlso = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSpeaking, "Engine.Actor.IsSpeaking");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rightNow, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(withPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(checkVoiceAlso, paramsPtr + 8);
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

    private static BmSDK.Function __fn_TriggerEmote;
    /// <summary>
    /// Function: TriggerEmote
    /// </summary>
    public unsafe virtual bool TriggerEmote(BmSDK.Engine.AkEmoteType em, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerEmote, "Engine.Actor.TriggerEmote");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(em, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_InterruptSpeech;
    /// <summary>
    /// Function: InterruptSpeech
    /// </summary>
    public unsafe virtual void InterruptSpeech(float fadeTime = default, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterruptSpeech, "Engine.Actor.InterruptSpeech");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fadeTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 4);
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

    private static BmSDK.Function __fn_StopSpeech;
    /// <summary>
    /// Function: StopSpeech
    /// </summary>
    public unsafe virtual void StopSpeech(bool exceptEmotes = default, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSpeech, "Engine.Actor.StopSpeech");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(exceptEmotes, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 4);
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

    private static BmSDK.Function __fn_StartSpeech;
    /// <summary>
    /// Function: StartSpeech
    /// </summary>
    public unsafe virtual bool StartSpeech(BmSDK.Engine.AkDialogueSpeech dlgSpeech, BmSDK.Engine.AkDialogue.FAkSpeechOptions dlgOpts = default, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSpeech, "Engine.Actor.StartSpeech");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeech, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgOpts, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 124);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_HasLoopingAudioEvent;
    /// <summary>
    /// Function: HasLoopingAudioEvent
    /// </summary>
    public unsafe virtual bool HasLoopingAudioEvent(BmSDK.Engine.AkEvent loopingEvent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasLoopingAudioEvent, "Engine.Actor.HasLoopingAudioEvent");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(loopingEvent, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RemoveLoopingAudioEvent;
    /// <summary>
    /// Function: RemoveLoopingAudioEvent
    /// </summary>
    public unsafe virtual void RemoveLoopingAudioEvent(BmSDK.Engine.AkEvent loopingEvent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveLoopingAudioEvent, "Engine.Actor.RemoveLoopingAudioEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(loopingEvent, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddLoopingAudioEvent;
    /// <summary>
    /// Function: AddLoopingAudioEvent
    /// </summary>
    public unsafe virtual void AddLoopingAudioEvent(BmSDK.Engine.AkEvent loopingEvent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLoopingAudioEvent, "Engine.Actor.AddLoopingAudioEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(loopingEvent, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SeekAudioEvent;
    /// <summary>
    /// Function: SeekAudioEvent
    /// </summary>
    public unsafe virtual void SeekAudioEvent(out BmSDK.Engine.AkWwise.FAkSoundHandle SoundHandle, float timeinMS)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SeekAudioEvent, "Engine.Actor.SeekAudioEvent");
        byte* paramsPtr = stackalloc byte[20];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SoundHandle);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundHandle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeinMS, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SoundHandle = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkWwise.FAkSoundHandle>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_StartDeathAudioEvent;
    /// <summary>
    /// Function: StartDeathAudioEvent
    /// </summary>
    public unsafe virtual void StartDeathAudioEvent(BmSDK.Engine.AkEvent DeathEvent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartDeathAudioEvent, "Engine.Actor.StartDeathAudioEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeathEvent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopAudioEvent;
    /// <summary>
    /// Function: StopAudioEvent
    /// </summary>
    public unsafe virtual void StopAudioEvent(out BmSDK.Engine.AkWwise.FAkSoundHandle SoundHandle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAudioEvent, "Engine.Actor.StopAudioEvent");
        byte* paramsPtr = stackalloc byte[16];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SoundHandle);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundHandle, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SoundHandle = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkWwise.FAkSoundHandle>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_StartAudioEvent;
    /// <summary>
    /// Function: StartAudioEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkWwise.FAkSoundHandle StartAudioEvent(BmSDK.Engine.AkEvent AudioEvent, System.IntPtr SoundCallbackDelegate = default, int SoundCallbackFlags = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAudioEvent, "Engine.Actor.StartAudioEvent");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AudioEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCallbackDelegate, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCallbackFlags, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkWwise.FAkSoundHandle>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_OverrideAkDialogueComponentDefaults;
    /// <summary>
    /// Function: OverrideAkDialogueComponentDefaults
    /// </summary>
    public unsafe virtual void OverrideAkDialogueComponentDefaults(BmSDK.Engine.AkDialogueComponent akDlgComp)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideAkDialogueComponentDefaults, "Engine.Actor.OverrideAkDialogueComponentDefaults");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(akDlgComp, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAkDialogueComponent;
    /// <summary>
    /// Function: GetAkDialogueComponent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkDialogueComponent GetAkDialogueComponent(bool allowCreate = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAkDialogueComponent, "Engine.Actor.GetAkDialogueComponent");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(allowCreate, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogueComponent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OverrideDefaultAkAudible;
    /// <summary>
    /// Function: OverrideDefaultAkAudible
    /// </summary>
    public unsafe virtual BmSDK.Engine.RAkAudible OverrideDefaultAkAudible(bool allowCreate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideDefaultAkAudible, "Engine.Actor.OverrideDefaultAkAudible");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(allowCreate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.RAkAudible>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OverrideDefaultAkAudibleSetup;
    /// <summary>
    /// Function: OverrideDefaultAkAudibleSetup
    /// </summary>
    public unsafe virtual void OverrideDefaultAkAudibleSetup(BmSDK.Engine.RAkAudible akAud)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideDefaultAkAudibleSetup, "Engine.Actor.OverrideDefaultAkAudibleSetup");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(akAud, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAkAudible;
    /// <summary>
    /// Function: GetAkAudible
    /// </summary>
    public unsafe virtual BmSDK.Engine.RAkAudible GetAkAudible(bool allowCreate = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAkAudible, "Engine.Actor.GetAkAudible");
        byte* paramsPtr = stackalloc byte[12];
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

    private static BmSDK.Function __fn_ShouldContinueSurveillance;
    /// <summary>
    /// Function: ShouldContinueSurveillance
    /// </summary>
    public unsafe virtual bool ShouldContinueSurveillance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldContinueSurveillance, "Engine.Actor.ShouldContinueSurveillance");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_ShouldBeHiddenBySHOW_NavigationNodes;
    /// <summary>
    /// Function: ShouldBeHiddenBySHOW_NavigationNodes
    /// </summary>
    public unsafe virtual bool ShouldBeHiddenBySHOW_NavigationNodes()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldBeHiddenBySHOW_NavigationNodes, "Engine.Actor.ShouldBeHiddenBySHOW_NavigationNodes");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_WillOverlap;
    /// <summary>
    /// Function: WillOverlap
    /// </summary>
    public unsafe virtual bool WillOverlap(System.Numerics.Vector3 PosA, System.Numerics.Vector3 VelA, System.Numerics.Vector3 PosB, System.Numerics.Vector3 VelB, float StepSize, float Radius, out float Time)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WillOverlap, "Engine.Actor.WillOverlap");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PosA, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VelA, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PosB, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VelB, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StepSize, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 52);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Time);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 56);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Time = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 56);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_GetAvoidanceVector;
    /// <summary>
    /// Function: GetAvoidanceVector
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAvoidanceVector(out BmSDK.TArray<BmSDK.Engine.Actor> Obstacles, System.Numerics.Vector3 GoalLocation, float CollisionRadius, float MaxSpeed, int NumSamples = default, float VelocityStepRate = default, float MaxTimeTilOverlap = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAvoidanceVector, "Engine.Actor.GetAvoidanceVector");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoalLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionRadius, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxSpeed, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumSamples, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VelocityStepRate, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxTimeTilOverlap, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Obstacles = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_IsClient;
    /// <summary>
    /// Function: IsClient
    /// </summary>
    public unsafe virtual bool IsClient()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsClient, "Engine.Actor.IsClient");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsServer;
    /// <summary>
    /// Function: IsServer
    /// </summary>
    public unsafe virtual bool IsServer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsServer, "Engine.Actor.IsServer");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsOwningClient;
    /// <summary>
    /// Function: IsOwningClient
    /// </summary>
    public unsafe virtual bool IsOwningClient()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOwningClient, "Engine.Actor.IsOwningClient");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ReplicationEnded;
    /// <summary>
    /// Function: ReplicationEnded
    /// </summary>
    public unsafe virtual void ReplicationEnded()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicationEnded, "Engine.Actor.ReplicationEnded");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInvestigateHighlighted;
    /// <summary>
    /// Function: SetInvestigateHighlighted
    /// </summary>
    public unsafe virtual void SetInvestigateHighlighted(BmSDK.Engine.MaterialInstanceConstant highMat, bool On)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInvestigateHighlighted, "Engine.Actor.SetInvestigateHighlighted");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(highMat, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInvestigationArray;
    /// <summary>
    /// Function: SetInvestigationArray
    /// </summary>
    public unsafe virtual void SetInvestigationArray(BmSDK.TArray<BmSDK.Engine.Actor.FInvestigationData> NewInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInvestigationArray, "Engine.Actor.SetInvestigationArray");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostDemoRewind;
    /// <summary>
    /// Function: PostDemoRewind
    /// </summary>
    public unsafe virtual void PostDemoRewind()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostDemoRewind, "Engine.Actor.PostDemoRewind");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AnimTreeUpdated;
    /// <summary>
    /// Function: AnimTreeUpdated
    /// </summary>
    public unsafe virtual void AnimTreeUpdated(BmSDK.Engine.SkeletalMeshComponent SkelMesh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnimTreeUpdated, "Engine.Actor.AnimTreeUpdated");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SupportsKismetModification;
    /// <summary>
    /// Function: SupportsKismetModification
    /// </summary>
    public unsafe virtual bool SupportsKismetModification(BmSDK.Engine.SequenceOp AskingOp, out BmSDK.FString Reason)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SupportsKismetModification, "Engine.Actor.SupportsKismetModification");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AskingOp, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Reason = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetAnimTrailParticleSystem;
    /// <summary>
    /// Function: GetAnimTrailParticleSystem
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetAnimTrailParticleSystem(BmSDK.Engine.AnimNotify_Trails AnimNotifyData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimTrailParticleSystem, "Engine.Actor.GetAnimTrailParticleSystem");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimNotifyData, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TrailsNotifyEnd;
    /// <summary>
    /// Function: TrailsNotifyEnd
    /// </summary>
    public unsafe virtual void TrailsNotifyEnd(BmSDK.Engine.AnimNotify_Trails AnimNotifyData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrailsNotifyEnd, "Engine.Actor.TrailsNotifyEnd");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimNotifyData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TrailsNotifyTick;
    /// <summary>
    /// Function: TrailsNotifyTick
    /// </summary>
    public unsafe virtual void TrailsNotifyTick(BmSDK.Engine.AnimNotify_Trails AnimNotifyData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrailsNotifyTick, "Engine.Actor.TrailsNotifyTick");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimNotifyData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TrailsNotify;
    /// <summary>
    /// Function: TrailsNotify
    /// </summary>
    public unsafe virtual void TrailsNotify(BmSDK.Engine.AnimNotify_Trails AnimNotifyData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrailsNotify, "Engine.Actor.TrailsNotify");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimNotifyData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateForceField;
    /// <summary>
    /// Function: CreateForceField
    /// </summary>
    public unsafe virtual bool CreateForceField(BmSDK.Engine.AnimNotify_ForceField AnimNotifyData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateForceField, "Engine.Actor.CreateForceField");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimNotifyData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PlayParticleEffect;
    /// <summary>
    /// Function: PlayParticleEffect
    /// </summary>
    public unsafe virtual bool PlayParticleEffect(BmSDK.Engine.AnimNotify_PlayParticleEffect AnimNotifyData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayParticleEffect, "Engine.Actor.PlayParticleEffect");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimNotifyData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetAimAdhesionExtent;
    /// <summary>
    /// Function: GetAimAdhesionExtent
    /// </summary>
    public unsafe virtual void GetAimAdhesionExtent(out float Width, out float Height, out System.Numerics.Vector3 Center)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAimAdhesionExtent, "Engine.Actor.GetAimAdhesionExtent");
        byte* paramsPtr = stackalloc byte[20];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Width);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Width, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Height);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Height, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Center);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Center, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Width = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        Height = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        Center = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_GetAimFrictionExtent;
    /// <summary>
    /// Function: GetAimFrictionExtent
    /// </summary>
    public unsafe virtual void GetAimFrictionExtent(out float Width, out float Height, out System.Numerics.Vector3 Center)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAimFrictionExtent, "Engine.Actor.GetAimFrictionExtent");
        byte* paramsPtr = stackalloc byte[20];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Width);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Width, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Height);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Height, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Center);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Center, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Width = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        Height = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        Center = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_IsInPersistentLevel;
    /// <summary>
    /// Function: IsInPersistentLevel
    /// </summary>
    public unsafe virtual bool IsInPersistentLevel(bool bIncludeLevelStreamingPersistent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInPersistentLevel, "Engine.Actor.IsInPersistentLevel");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludeLevelStreamingPersistent, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnRigidBodySpringOverextension;
    /// <summary>
    /// Function: OnRigidBodySpringOverextension
    /// </summary>
    public unsafe virtual void OnRigidBodySpringOverextension(BmSDK.Engine.RB_BodyInstance BodyInstance)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRigidBodySpringOverextension, "Engine.Actor.OnRigidBodySpringOverextension");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BodyInstance, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPackageGuid;
    /// <summary>
    /// Function: GetPackageGuid
    /// </summary>
    public unsafe static BmSDK.GameObject.FGuid GetPackageGuid(BmSDK.FName PackageName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPackageGuid, "Engine.Actor.GetPackageGuid");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FGuid>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PostEditChangeScript;
    /// <summary>
    /// Function: PostEditChangeScript
    /// </summary>
    public unsafe virtual void PostEditChangeScript()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostEditChangeScript, "Engine.Actor.PostEditChangeScript");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlinkToActor;
    /// <summary>
    /// Function: UnlinkToActor
    /// </summary>
    public unsafe virtual bool UnlinkToActor(BmSDK.Engine.Actor LinkTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlinkToActor, "Engine.Actor.UnlinkToActor");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_LinkToActor;
    /// <summary>
    /// Function: LinkToActor
    /// </summary>
    public unsafe virtual bool LinkToActor(BmSDK.Engine.Actor LinkTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LinkToActor, "Engine.Actor.LinkToActor");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe virtual void PreStreamOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "Engine.Actor.PreStreamOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RootMotionExtracted;
    /// <summary>
    /// Function: RootMotionExtracted
    /// </summary>
    public unsafe virtual void RootMotionExtracted(BmSDK.Engine.SkeletalMeshComponent SkelComp, out BmSDK.GameObject.FBoneAtom ExtractedRootMotionDelta)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RootMotionExtracted, "Engine.Actor.RootMotionExtracted");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelComp, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ExtractedRootMotionDelta);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtractedRootMotionDelta, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ExtractedRootMotionDelta = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FBoneAtom>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_RootMotionProcessed;
    /// <summary>
    /// Function: RootMotionProcessed
    /// </summary>
    public unsafe virtual void RootMotionProcessed(BmSDK.Engine.SkeletalMeshComponent SkelComp)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RootMotionProcessed, "Engine.Actor.RootMotionProcessed");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelComp, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RootMotionModeChanged;
    /// <summary>
    /// Function: RootMotionModeChanged
    /// </summary>
    public unsafe virtual void RootMotionModeChanged(BmSDK.Engine.SkeletalMeshComponent SkelComp)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RootMotionModeChanged, "Engine.Actor.RootMotionModeChanged");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelComp, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostRenderFor;
    /// <summary>
    /// Function: PostRenderFor
    /// </summary>
    public unsafe virtual void PostRenderFor(BmSDK.Engine.PlayerController PC, BmSDK.Engine.Canvas Canvas, System.Numerics.Vector3 CameraPosition, System.Numerics.Vector3 CameraDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostRenderFor, "Engine.Actor.PostRenderFor");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraDir, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NativePostRenderFor;
    /// <summary>
    /// Function: NativePostRenderFor
    /// </summary>
    public unsafe virtual void NativePostRenderFor(BmSDK.Engine.PlayerController PC, BmSDK.Engine.Canvas Canvas, System.Numerics.Vector3 CameraPosition, System.Numerics.Vector3 CameraDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NativePostRenderFor, "Engine.Actor.NativePostRenderFor");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraDir, paramsPtr + 28);
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

    private static BmSDK.Function __fn_SetHUDLocation;
    /// <summary>
    /// Function: SetHUDLocation
    /// </summary>
    public unsafe virtual void SetHUDLocation(System.Numerics.Vector3 NewHUDLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHUDLocation, "Engine.Actor.SetHUDLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewHUDLocation, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnRanOver;
    /// <summary>
    /// Function: OnRanOver
    /// </summary>
    public unsafe virtual void OnRanOver(BmSDK.Engine.SVehicle Vehicle, BmSDK.Engine.PrimitiveComponent RunOverComponent, int WheelIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRanOver, "Engine.Actor.OnRanOver");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vehicle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RunOverComponent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WheelIndex, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RigidBodyCollision;
    /// <summary>
    /// Function: RigidBodyCollision
    /// </summary>
    public unsafe virtual void RigidBodyCollision(BmSDK.Engine.PrimitiveComponent HitComponent, BmSDK.Engine.PrimitiveComponent OtherComponent, out BmSDK.Engine.Actor.FCollisionImpactData RigidCollisionData, int ContactIndex, float Speed, int Index0, int Index1)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RigidBodyCollision, "Engine.Actor.RigidBodyCollision");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComponent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactIndex, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index0, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index1, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RigidCollisionData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FCollisionImpactData>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_InterpolationChanged;
    /// <summary>
    /// Function: InterpolationChanged
    /// </summary>
    public unsafe virtual void InterpolationChanged(BmSDK.Engine.SeqAct_Interp InterpAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterpolationChanged, "Engine.Actor.InterpolationChanged");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InterpolationFinished;
    /// <summary>
    /// Function: InterpolationFinished
    /// </summary>
    public unsafe virtual void InterpolationFinished(BmSDK.Engine.SeqAct_Interp InterpAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterpolationFinished, "Engine.Actor.InterpolationFinished");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InterpolationStarted;
    /// <summary>
    /// Function: InterpolationStarted
    /// </summary>
    public unsafe virtual void InterpolationStarted(BmSDK.Engine.SeqAct_Interp InterpAction, BmSDK.Engine.InterpGroupInst GroupInst)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterpolationStarted, "Engine.Actor.InterpolationStarted");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpAction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupInst, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnedByKismet;
    /// <summary>
    /// Function: SpawnedByKismet
    /// </summary>
    public unsafe virtual void SpawnedByKismet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnedByKismet, "Engine.Actor.SpawnedByKismet");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFOVCheckLocation;
    /// <summary>
    /// Function: GetFOVCheckLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFOVCheckLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFOVCheckLocation, "Engine.Actor.GetFOVCheckLocation");
        byte* paramsPtr = stackalloc byte[12];
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

    private static BmSDK.Function __fn_GetTargetLocation;
    /// <summary>
    /// Function: GetTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetTargetLocation(BmSDK.Engine.Actor RequestedBy = default, bool bRequestAlternateLoc = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetLocation, "Engine.Actor.GetTargetLocation");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRequestAlternateLoc, paramsPtr + 8);
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

    private static BmSDK.Function __fn_FindGoodEndView;
    /// <summary>
    /// Function: FindGoodEndView
    /// </summary>
    public unsafe virtual void FindGoodEndView(BmSDK.Engine.PlayerController PC, out BmSDK.Rotator GoodRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindGoodEndView, "Engine.Actor.FindGoodEndView");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out GoodRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoodRotation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        GoodRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_NotifyLocalPlayerTeamReceived;
    /// <summary>
    /// Function: NotifyLocalPlayerTeamReceived
    /// </summary>
    public unsafe virtual void NotifyLocalPlayerTeamReceived()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyLocalPlayerTeamReceived, "Engine.Actor.NotifyLocalPlayerTeamReceived");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScriptGetTeamNum;
    /// <summary>
    /// Function: ScriptGetTeamNum
    /// </summary>
    public unsafe virtual byte ScriptGetTeamNum()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScriptGetTeamNum, "Engine.Actor.ScriptGetTeamNum");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTeamNum;
    /// <summary>
    /// Function: GetTeamNum
    /// </summary>
    public unsafe virtual byte GetTeamNum()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTeamNum, "Engine.Actor.GetTeamNum");
        byte* paramsPtr = stackalloc byte[1];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PawnBaseDied;
    /// <summary>
    /// Function: PawnBaseDied
    /// </summary>
    public unsafe virtual void PawnBaseDied()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnBaseDied, "Engine.Actor.PawnBaseDied");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPlayerOwned;
    /// <summary>
    /// Function: IsPlayerOwned
    /// </summary>
    public unsafe virtual bool IsPlayerOwned()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayerOwned, "Engine.Actor.IsPlayerOwned");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_GetActorEyesViewPoint;
    /// <summary>
    /// Function: GetActorEyesViewPoint
    /// </summary>
    public unsafe virtual void GetActorEyesViewPoint(out System.Numerics.Vector3 out_Location, out BmSDK.Rotator out_Rotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActorEyesViewPoint, "Engine.Actor.GetActorEyesViewPoint");
        byte* paramsPtr = stackalloc byte[24];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Location);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Location, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Rotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Rotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_Location = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        out_Rotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_IsStationary;
    /// <summary>
    /// Function: IsStationary
    /// </summary>
    public unsafe virtual bool IsStationary()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStationary, "Engine.Actor.IsStationary");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetActorFaceFXAsset;
    /// <summary>
    /// Function: GetActorFaceFXAsset
    /// </summary>
    public unsafe virtual BmSDK.Engine.FaceFXAsset GetActorFaceFXAsset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActorFaceFXAsset, "Engine.Actor.GetActorFaceFXAsset");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.FaceFXAsset>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanActorPlayFaceFXAnim;
    /// <summary>
    /// Function: CanActorPlayFaceFXAnim
    /// </summary>
    public unsafe virtual bool CanActorPlayFaceFXAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanActorPlayFaceFXAnim, "Engine.Actor.CanActorPlayFaceFXAnim");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsActorPlayingFaceFXAnim;
    /// <summary>
    /// Function: IsActorPlayingFaceFXAnim
    /// </summary>
    public unsafe virtual bool IsActorPlayingFaceFXAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsActorPlayingFaceFXAnim, "Engine.Actor.IsActorPlayingFaceFXAnim");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TickSkelControl;
    /// <summary>
    /// Function: TickSkelControl
    /// </summary>
    public unsafe virtual void TickSkelControl(float DeltaTime, BmSDK.Engine.SkeletalMeshComponent SkelComp, BmSDK.Engine.SkelControlBase SkelCtrl)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickSkelControl, "Engine.Actor.TickSkelControl");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelCtrl, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSkelControlScale;
    /// <summary>
    /// Function: SetSkelControlScale
    /// </summary>
    public unsafe virtual void SetSkelControlScale(BmSDK.FName SkelControlName, float Scale)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSkelControlScale, "Engine.Actor.SetSkelControlScale");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelControlName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMorphWeight;
    /// <summary>
    /// Function: SetMorphWeight
    /// </summary>
    public unsafe virtual void SetMorphWeight(BmSDK.FName MorphNodeName, float MorphWeight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMorphWeight, "Engine.Actor.SetMorphWeight");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MorphNodeName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MorphWeight, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MatineeSetFaceFXRegister;
    /// <summary>
    /// Function: MatineeSetFaceFXRegister
    /// </summary>
    public unsafe virtual void MatineeSetFaceFXRegister(BmSDK.FString RegisterName, float Value, BmSDK.Engine.RSkeletalMeshComponent_Export.EFaceFXRegisterOwner RegisterOwner)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatineeSetFaceFXRegister, "Engine.Actor.MatineeSetFaceFXRegister");
        byte* paramsPtr = stackalloc byte[21];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegisterName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegisterOwner, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopActorFaceFXAnim;
    /// <summary>
    /// Function: StopActorFaceFXAnim
    /// </summary>
    public unsafe virtual void StopActorFaceFXAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopActorFaceFXAnim, "Engine.Actor.StopActorFaceFXAnim");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayActorFaceFXAnim;
    /// <summary>
    /// Function: PlayActorFaceFXAnim
    /// </summary>
    public unsafe virtual bool PlayActorFaceFXAnim(BmSDK.Engine.FaceFXAnimSet AnimSet, BmSDK.FString GroupName, BmSDK.FString SeqName, BmSDK.Engine.SoundCue SoundCueToPlay)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayActorFaceFXAnim, "Engine.Actor.PlayActorFaceFXAnim");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SeqName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCueToPlay, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_EndMatineeControl;
    /// <summary>
    /// Function: EndMatineeControl
    /// </summary>
    public unsafe virtual void EndMatineeControl(BmSDK.Engine.InterpGroup InInterpGroup, BmSDK.Engine.InterpGroupInst InInterpGroupInst)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndMatineeControl, "Engine.Actor.EndMatineeControl");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroupInst, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginMatineeControl;
    /// <summary>
    /// Function: BeginMatineeControl
    /// </summary>
    public unsafe virtual void BeginMatineeControl(BmSDK.Engine.InterpGroup InInterpGroup, BmSDK.Engine.InterpGroupInst InInterpGroupInst)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginMatineeControl, "Engine.Actor.BeginMatineeControl");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroupInst, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishAnimControl;
    /// <summary>
    /// Function: FinishAnimControl
    /// </summary>
    public unsafe virtual void FinishAnimControl(BmSDK.Engine.InterpGroup InInterpGroup, BmSDK.Engine.InterpGroupInst InInterpGroupInst)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishAnimControl, "Engine.Actor.FinishAnimControl");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroupInst, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlendOutAnimControl;
    /// <summary>
    /// Function: BlendOutAnimControl
    /// </summary>
    public unsafe virtual void BlendOutAnimControl(BmSDK.Engine.InterpGroup InInterpGroup, BmSDK.Engine.InterpGroupInst InInterpGroupInst, float BlendOutDuration)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlendOutAnimControl, "Engine.Actor.BlendOutAnimControl");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroupInst, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendOutDuration, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MatineeTeleport;
    /// <summary>
    /// Function: MatineeTeleport
    /// </summary>
    public unsafe virtual void MatineeTeleport(BmSDK.Engine.InterpGroupInst InterpGroupInst, BmSDK.FName DebugSource)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatineeTeleport, "Engine.Actor.MatineeTeleport");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpGroupInst, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DebugSource, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetAnimPosition;
    /// <summary>
    /// Function: SetAnimPosition
    /// </summary>
    public unsafe virtual void SetAnimPosition(BmSDK.Engine.InterpGroupInst InterpGroupInst, BmSDK.FName SlotName, int ChannelIndex, BmSDK.FName InAnimSeqName, float InPosition, bool bFireNotifies, bool bLooping, bool bEnableRootMotion)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAnimPosition, "Engine.Actor.SetAnimPosition");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpGroupInst, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChannelIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAnimSeqName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPosition, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFireNotifies, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLooping, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableRootMotion, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginAnimControl;
    /// <summary>
    /// Function: BeginAnimControl
    /// </summary>
    public unsafe virtual void BeginAnimControl(BmSDK.Engine.InterpGroup InInterpGroup, BmSDK.Engine.InterpGroupInst InInterpGroupInst)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginAnimControl, "Engine.Actor.BeginAnimControl");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroupInst, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAnimPlay;
    /// <summary>
    /// Function: OnAnimPlay
    /// </summary>
    public unsafe virtual void OnAnimPlay(BmSDK.Engine.AnimNodeSequence SeqNode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAnimPlay, "Engine.Actor.OnAnimPlay");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SeqNode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAnimEnd;
    /// <summary>
    /// Function: OnAnimEnd
    /// </summary>
    public unsafe virtual void OnAnimEnd(BmSDK.Engine.AnimNodeSequence SeqNode, float PlayedTime, float ExcessTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAnimEnd, "Engine.Actor.OnAnimEnd");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SeqNode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayedTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExcessTime, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoKismetAttachment;
    /// <summary>
    /// Function: DoKismetAttachment
    /// </summary>
    public unsafe virtual void DoKismetAttachment(BmSDK.Engine.Actor Attachment, BmSDK.Engine.SeqAct_AttachToActor Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoKismetAttachment, "Engine.Actor.DoKismetAttachment");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attachment, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAttachToActor;
    /// <summary>
    /// Function: OnAttachToActor
    /// </summary>
    public unsafe virtual void OnAttachToActor(BmSDK.Engine.SeqAct_AttachToActor Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAttachToActor, "Engine.Actor.OnAttachToActor");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetachedFromActor;
    /// <summary>
    /// Function: DetachedFromActor
    /// </summary>
    public unsafe virtual void DetachedFromActor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachedFromActor, "Engine.Actor.DetachedFromActor");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnToggleHidden;
    /// <summary>
    /// Function: OnToggleHidden
    /// </summary>
    public unsafe virtual void OnToggleHidden(BmSDK.Engine.SeqAct_ToggleHidden Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggleHidden, "Engine.Actor.OnToggleHidden");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnChangeCollision;
    /// <summary>
    /// Function: OnChangeCollision
    /// </summary>
    public unsafe virtual void OnChangeCollision(BmSDK.Engine.SeqAct_ChangeCollision Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnChangeCollision, "Engine.Actor.OnChangeCollision");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSetPhysics;
    /// <summary>
    /// Function: OnSetPhysics
    /// </summary>
    public unsafe virtual void OnSetPhysics(BmSDK.Engine.SeqAct_SetPhysics Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSetPhysics, "Engine.Actor.OnSetPhysics");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSetBlockRigidBody;
    /// <summary>
    /// Function: OnSetBlockRigidBody
    /// </summary>
    public unsafe virtual void OnSetBlockRigidBody(BmSDK.Engine.SeqAct_SetBlockRigidBody Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSetBlockRigidBody, "Engine.Actor.OnSetBlockRigidBody");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSetVelocity;
    /// <summary>
    /// Function: OnSetVelocity
    /// </summary>
    public unsafe virtual void OnSetVelocity(BmSDK.Engine.SeqAct_SetVelocity Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSetVelocity, "Engine.Actor.OnSetVelocity");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnTeleport;
    /// <summary>
    /// Function: OnTeleport
    /// </summary>
    public unsafe virtual void OnTeleport(BmSDK.Engine.SeqAct_Teleport Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnTeleport, "Engine.Actor.OnTeleport");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnModifyHealth;
    /// <summary>
    /// Function: OnModifyHealth
    /// </summary>
    public unsafe virtual void OnModifyHealth(BmSDK.Engine.SeqAct_ModifyHealth Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnModifyHealth, "Engine.Actor.OnModifyHealth");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrestreamTextures2;
    /// <summary>
    /// Function: PrestreamTextures2
    /// </summary>
    public unsafe virtual void PrestreamTextures2(float Seconds, bool FullMips, bool HighPriority, bool GentleLastRenderTimeHint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrestreamTextures2, "Engine.Actor.PrestreamTextures2");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Seconds, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FullMips, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HighPriority, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GentleLastRenderTimeHint, paramsPtr + 12);
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

    private static BmSDK.Function __fn_PrestreamTextures;
    /// <summary>
    /// Function: PrestreamTextures
    /// </summary>
    public unsafe virtual void PrestreamTextures(float Seconds, bool bEnableStreaming, int CinematicTextureGroups = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrestreamTextures, "Engine.Actor.PrestreamTextures");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Seconds, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableStreaming, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CinematicTextureGroups, paramsPtr + 8);
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

    private static BmSDK.Function __fn_ShutDown;
    /// <summary>
    /// Function: ShutDown
    /// </summary>
    public unsafe virtual void ShutDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShutDown, "Engine.Actor.ShutDown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNetUpdateTime;
    /// <summary>
    /// Function: SetNetUpdateTime
    /// </summary>
    public unsafe virtual void SetNetUpdateTime(float NewUpdateTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNetUpdateTime, "Engine.Actor.SetNetUpdateTime");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUpdateTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ForceNetRelevant;
    /// <summary>
    /// Function: ForceNetRelevant
    /// </summary>
    public unsafe virtual void ForceNetRelevant()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceNetRelevant, "Engine.Actor.ForceNetRelevant");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDestroy;
    /// <summary>
    /// Function: OnDestroy
    /// </summary>
    public unsafe virtual void OnDestroy(BmSDK.Engine.SeqAct_Destroy Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDestroy, "Engine.Actor.OnDestroy");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLatentAction;
    /// <summary>
    /// Function: ClearLatentAction
    /// </summary>
    public unsafe virtual void ClearLatentAction(BmSDK.Class actionClass, bool bAborted = default, BmSDK.Engine.SeqAct_Latent exceptionAction = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLatentAction, "Engine.Actor.ClearLatentAction");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actionClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAborted, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(exceptionAction, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindEventsOfClass;
    /// <summary>
    /// Function: FindEventsOfClass
    /// </summary>
    public unsafe virtual bool FindEventsOfClass(BmSDK.Class EventClass, out BmSDK.TArray<BmSDK.Engine.SequenceEvent> out_EventList, bool bIncludeDisabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindEventsOfClass, "Engine.Actor.FindEventsOfClass");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludeDisabled, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_EventList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.SequenceEvent>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ActivateEventClass;
    /// <summary>
    /// Function: ActivateEventClass
    /// </summary>
    public unsafe virtual bool ActivateEventClass(BmSDK.Class InClass, BmSDK.Engine.Actor InInstigator, out BmSDK.TArray<BmSDK.Engine.SequenceEvent> EventList, out BmSDK.TArray<int> ActivateIndices, bool bTest, out BmSDK.TArray<BmSDK.Engine.SequenceEvent> ActivatedEvents)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateEventClass, "Engine.Actor.ActivateEventClass");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInstigator, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTest, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        EventList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.SequenceEvent>>(paramsPtr + 16);
        ActivateIndices = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 32);
        ActivatedEvents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.SequenceEvent>>(paramsPtr + 52);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 68);
    }

    private static BmSDK.Function __fn_TriggerGlobalEventClass;
    /// <summary>
    /// Function: TriggerGlobalEventClass
    /// </summary>
    public unsafe virtual bool TriggerGlobalEventClass(BmSDK.Class InEventClass, BmSDK.Engine.Actor InInstigator, int ActivateIndex = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerGlobalEventClass, "Engine.Actor.TriggerGlobalEventClass");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InEventClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInstigator, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActivateIndex, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ReceivedNewEvent;
    /// <summary>
    /// Function: ReceivedNewEvent
    /// </summary>
    public unsafe virtual void ReceivedNewEvent(BmSDK.Engine.SequenceEvent Evt)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReceivedNewEvent, "Engine.Actor.ReceivedNewEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Evt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerEventClass;
    /// <summary>
    /// Function: TriggerEventClass
    /// </summary>
    public unsafe virtual bool TriggerEventClass(BmSDK.Class InEventClass, BmSDK.Engine.Actor InInstigator, int ActivateIndex, bool bTest, out BmSDK.TArray<BmSDK.Engine.SequenceEvent> ActivatedEvents)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerEventClass, "Engine.Actor.TriggerEventClass");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InEventClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInstigator, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActivateIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTest, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ActivatedEvents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.SequenceEvent>>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_DebugMessagePlayer;
    /// <summary>
    /// Function: DebugMessagePlayer
    /// </summary>
    public unsafe virtual void DebugMessagePlayer(BmSDK.FString msg)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMessagePlayer, "Engine.Actor.DebugMessagePlayer");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(msg, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ImpactEffectIsRelevant;
    /// <summary>
    /// Function: ImpactEffectIsRelevant
    /// </summary>
    public unsafe virtual bool ImpactEffectIsRelevant(BmSDK.Engine.Pawn EffectInstigator, System.Numerics.Vector3 SpawnLocation, bool bForceDedicated, float VisibleCullDistance = default, float HiddenCullDistance = default, bool bSkipLOSCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ImpactEffectIsRelevant, "Engine.Actor.ImpactEffectIsRelevant");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EffectInstigator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDedicated, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VisibleCullDistance, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HiddenCullDistance, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipLOSCheck, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_ActorEffectIsRelevant;
    /// <summary>
    /// Function: ActorEffectIsRelevant
    /// </summary>
    public unsafe virtual bool ActorEffectIsRelevant(BmSDK.Engine.Pawn EffectInstigator, bool bForceDedicated, float VisibleCullDistance = default, float HiddenCullDistance = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActorEffectIsRelevant, "Engine.Actor.ActorEffectIsRelevant");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EffectInstigator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDedicated, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VisibleCullDistance, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HiddenCullDistance, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_EffectIsRelevant;
    /// <summary>
    /// Function: EffectIsRelevant
    /// </summary>
    public unsafe virtual bool EffectIsRelevant(System.Numerics.Vector3 SpawnLocation, bool bForceDedicated, float VisibleCullDistance = default, float HiddenCullDistance = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EffectIsRelevant, "Engine.Actor.EffectIsRelevant");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDedicated, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VisibleCullDistance, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HiddenCullDistance, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ApplyFluidSurfaceImpact;
    /// <summary>
    /// Function: ApplyFluidSurfaceImpact
    /// </summary>
    public unsafe virtual void ApplyFluidSurfaceImpact(BmSDK.Engine.FluidSurfaceActor Fluid, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyFluidSurfaceImpact, "Engine.Actor.ApplyFluidSurfaceImpact");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fluid, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSplash;
    /// <summary>
    /// Function: CanSplash
    /// </summary>
    public unsafe virtual bool CanSplash()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSplash, "Engine.Actor.CanSplash");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayTeleportEffect;
    /// <summary>
    /// Function: PlayTeleportEffect
    /// </summary>
    public unsafe virtual void PlayTeleportEffect(bool bOut, bool bSound)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayTeleportEffect, "Engine.Actor.PlayTeleportEffect");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOut, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSound, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInPain;
    /// <summary>
    /// Function: IsInPain
    /// </summary>
    public unsafe virtual bool IsInPain()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInPain, "Engine.Actor.IsInPain");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInVolume;
    /// <summary>
    /// Function: IsInVolume
    /// </summary>
    public unsafe virtual bool IsInVolume(BmSDK.Engine.Volume aVolume)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInVolume, "Engine.Actor.IsInVolume");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aVolume, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_Reset;
    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe virtual void Reset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reset, "Engine.Actor.Reset");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ModifyHearSoundComponent;
    /// <summary>
    /// Function: ModifyHearSoundComponent
    /// </summary>
    public unsafe virtual void ModifyHearSoundComponent(BmSDK.Engine.AudioComponent AC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyHearSoundComponent, "Engine.Actor.ModifyHearSoundComponent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPhysicsName;
    /// <summary>
    /// Function: GetPhysicsName
    /// </summary>
    public unsafe virtual BmSDK.FString GetPhysicsName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPhysicsName, "Engine.Actor.GetPhysicsName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetActorThoughts;
    /// <summary>
    /// Function: GetActorThoughts
    /// </summary>
    public unsafe virtual void GetActorThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList, out System.Numerics.Vector3 ThoughtLocationOverride, BmSDK.FString IndentString = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActorThoughts, "Engine.Actor.GetActorThoughts");
        byte* paramsPtr = stackalloc byte[80];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThoughtLocationOverride);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThoughtLocationOverride, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IndentString, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        ThoughtLocationOverride = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_DisplayDebug;
    /// <summary>
    /// Function: DisplayDebug
    /// </summary>
    public unsafe virtual void DisplayDebug(BmSDK.Engine.HUD HUD, out float out_YL, out float out_YPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayDebug, "Engine.Actor.DisplayDebug");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HUD, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_YL);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_YL, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_YPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_YPos, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_YL = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        out_YPos = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetDebugName;
    /// <summary>
    /// Function: GetDebugName
    /// </summary>
    public unsafe virtual BmSDK.FString GetDebugName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDebugName, "Engine.Actor.GetDebugName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MatchStarting;
    /// <summary>
    /// Function: MatchStarting
    /// </summary>
    public unsafe virtual void MatchStarting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatchStarting, "Engine.Actor.MatchStarting");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLocalString;
    /// <summary>
    /// Function: GetLocalString
    /// </summary>
    public unsafe static BmSDK.FString GetLocalString(int Switch = default, BmSDK.Engine.PlayerReplicationInfo RelatedPRI_1 = default, BmSDK.Engine.PlayerReplicationInfo RelatedPRI_2 = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalString, "Engine.Actor.GetLocalString");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Switch, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelatedPRI_1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelatedPRI_2, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ReplaceText;
    /// <summary>
    /// Function: ReplaceText
    /// </summary>
    public unsafe static void ReplaceText(out BmSDK.FString Text, BmSDK.FString Replace, BmSDK.FString With)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplaceText, "Engine.Actor.ReplaceText");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Replace, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(With, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Text = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetHumanReadableName;
    /// <summary>
    /// Function: GetHumanReadableName
    /// </summary>
    public unsafe virtual BmSDK.FString GetHumanReadableName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHumanReadableName, "Engine.Actor.GetHumanReadableName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetItemName;
    /// <summary>
    /// Function: GetItemName
    /// </summary>
    public unsafe virtual BmSDK.FString GetItemName(BmSDK.FString FullName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetItemName, "Engine.Actor.GetItemName");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FullName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CalcCamera;
    /// <summary>
    /// Function: CalcCamera
    /// </summary>
    public unsafe virtual bool CalcCamera(float fDeltaTime, out System.Numerics.Vector3 out_CamLoc, out BmSDK.Rotator out_CamRot, out float out_FOV)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalcCamera, "Engine.Actor.CalcCamera");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDeltaTime, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_CamLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_CamLoc, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_CamRot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_CamRot, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_FOV);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_FOV, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_CamLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        out_CamRot = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 16);
        out_FOV = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_EndViewTarget;
    /// <summary>
    /// Function: EndViewTarget
    /// </summary>
    public unsafe virtual void EndViewTarget(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndViewTarget, "Engine.Actor.EndViewTarget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BecomeViewTarget;
    /// <summary>
    /// Function: BecomeViewTarget
    /// </summary>
    public unsafe virtual void BecomeViewTarget(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BecomeViewTarget, "Engine.Actor.BecomeViewTarget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForErrors;
    /// <summary>
    /// Function: CheckForErrors
    /// </summary>
    public unsafe virtual bool CheckForErrors()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForErrors, "Engine.Actor.CheckForErrors");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DebugFreezeGame;
    /// <summary>
    /// Function: DebugFreezeGame
    /// </summary>
    public unsafe virtual void DebugFreezeGame(BmSDK.Engine.Actor ActorToLookAt = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugFreezeGame, "Engine.Actor.DebugFreezeGame");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorToLookAt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGravityZ;
    /// <summary>
    /// Function: GetGravityZ
    /// </summary>
    public unsafe virtual float GetGravityZ()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGravityZ, "Engine.Actor.GetGravityZ");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_CheckHitInfo;
    /// <summary>
    /// Function: CheckHitInfo
    /// </summary>
    public unsafe virtual void CheckHitInfo(out BmSDK.Engine.Actor.FTraceHitInfo HitInfo, BmSDK.Engine.PrimitiveComponent FallBackComponent, System.Numerics.Vector3 Dir, out System.Numerics.Vector3 out_HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckHitInfo, "Engine.Actor.CheckHitInfo");
        byte* paramsPtr = stackalloc byte[160];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FallBackComponent, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 48);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_HitLocation, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FTraceHitInfo>(paramsPtr + 0);
        out_HitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 60);
        return;
    }

    private static BmSDK.Function __fn_TakeRadiusDamageFromWeapon;
    /// <summary>
    /// Function: TakeRadiusDamageFromWeapon
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor.EWeaponDamageResult TakeRadiusDamageFromWeapon(BmSDK.Engine.Controller InstigatedBy, float BaseDamage, float DamageRadius, BmSDK.Class DamageType, float Momentum, System.Numerics.Vector3 HurtOrigin, bool bFullDamage, BmSDK.Engine.Actor DamageCauser, float DamageFalloffExponent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeRadiusDamageFromWeapon, "Engine.Actor.TakeRadiusDamageFromWeapon");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseDamage, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageRadius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HurtOrigin, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFullDamage, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageFalloffExponent, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.EWeaponDamageResult>(paramsPtr + 56);
    }

    private static BmSDK.Function __fn_TakeDamageFromWeapon;
    /// <summary>
    /// Function: TakeDamageFromWeapon
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor.EWeaponDamageResult TakeDamageFromWeapon(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default, bool bHeadShot = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamageFromWeapon, "Engine.Actor.TakeDamageFromWeapon");
        byte* paramsPtr = stackalloc byte[109];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHeadShot, paramsPtr + 104);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.EWeaponDamageResult>(paramsPtr + 108);
    }

    private static BmSDK.Function __fn_TakeRadiusDamage;
    /// <summary>
    /// Function: TakeRadiusDamage
    /// </summary>
    public unsafe virtual void TakeRadiusDamage(BmSDK.Engine.Controller InstigatedBy, float BaseDamage, float DamageRadius, BmSDK.Class DamageType, float Momentum, System.Numerics.Vector3 HurtOrigin, bool bFullDamage, BmSDK.Engine.Actor DamageCauser, float DamageFalloffExponent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeRadiusDamage, "Engine.Actor.TakeRadiusDamage");
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseDamage, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageRadius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HurtOrigin, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFullDamage, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageFalloffExponent, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HealDamage;
    /// <summary>
    /// Function: HealDamage
    /// </summary>
    public unsafe virtual bool HealDamage(int Amount, BmSDK.Engine.Controller Healer, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HealDamage, "Engine.Actor.HealDamage");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Healer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_TakeDamage;
    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe virtual void TakeDamage(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamage, "Engine.Actor.TakeDamage");
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 84);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KilledBy;
    /// <summary>
    /// Function: KilledBy
    /// </summary>
    public unsafe virtual void KilledBy(BmSDK.Engine.Pawn EventInstigator)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KilledBy, "Engine.Actor.KilledBy");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HurtRadius;
    /// <summary>
    /// Function: HurtRadius
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor.EWeaponDamageResult HurtRadius(float BaseDamage, float DamageRadius, BmSDK.Class DamageType, float Momentum, System.Numerics.Vector3 HurtOrigin, BmSDK.Engine.Actor IgnoredActor = default, BmSDK.Engine.Controller InstigatedByController = default, bool bDoFullDamage = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HurtRadius, "Engine.Actor.HurtRadius");
        byte* paramsPtr = stackalloc byte[160];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseDamage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageRadius, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HurtOrigin, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoredActor, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedByController, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoFullDamage, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.EWeaponDamageResult>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_StopsProjectile;
    /// <summary>
    /// Function: StopsProjectile
    /// </summary>
    public unsafe virtual bool StopsProjectile(BmSDK.Engine.Projectile P, BmSDK.Engine.PrimitiveComponent HitComponent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopsProjectile, "Engine.Actor.StopsProjectile");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_NotifySkelControlBeyondLimit;
    /// <summary>
    /// Function: NotifySkelControlBeyondLimit
    /// </summary>
    public unsafe virtual void NotifySkelControlBeyondLimit(BmSDK.Engine.SkelControlLookAt LookAt)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifySkelControlBeyondLimit, "Engine.Actor.NotifySkelControlBeyondLimit");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ConstraintBrokenNotify;
    /// <summary>
    /// Function: ConstraintBrokenNotify
    /// </summary>
    public unsafe virtual void ConstraintBrokenNotify(BmSDK.Engine.Actor ConOwner, BmSDK.Engine.RB_ConstraintSetup ConSetup, BmSDK.Engine.RB_ConstraintInstance ConInstance)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConstraintBrokenNotify, "Engine.Actor.ConstraintBrokenNotify");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConSetup, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConInstance, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe virtual void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "Engine.Actor.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreBeginPlay;
    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe virtual void PreBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreBeginPlay, "Engine.Actor.PreBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetALocalPlayerController;
    /// <summary>
    /// Function: GetALocalPlayerController
    /// </summary>
    public unsafe virtual BmSDK.Engine.PlayerController GetALocalPlayerController()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetALocalPlayerController, "Engine.Actor.GetALocalPlayerController");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlayerController>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetURLMap;
    /// <summary>
    /// Function: GetURLMap
    /// </summary>
    public unsafe virtual BmSDK.FString GetURLMap()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetURLMap, "Engine.Actor.GetURLMap");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PostTeleport;
    /// <summary>
    /// Function: PostTeleport
    /// </summary>
    public unsafe virtual void PostTeleport(BmSDK.Engine.Teleporter OutTeleporter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostTeleport, "Engine.Actor.PostTeleport");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutTeleporter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreTeleport;
    /// <summary>
    /// Function: PreTeleport
    /// </summary>
    public unsafe virtual bool PreTeleport(BmSDK.Engine.Teleporter InTeleporter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreTeleport, "Engine.Actor.PreTeleport");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTeleporter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetDestination;
    /// <summary>
    /// Function: GetDestination
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDestination(BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDestination, "Engine.Actor.GetDestination");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
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

    private static BmSDK.Function __fn_CalculateMinSpeedTrajectory;
    /// <summary>
    /// Function: CalculateMinSpeedTrajectory
    /// </summary>
    public unsafe virtual bool CalculateMinSpeedTrajectory(out System.Numerics.Vector3 out_Velocity, System.Numerics.Vector3 End, System.Numerics.Vector3 Start, float MaxTossSpeed, float MinTossSpeed, System.Numerics.Vector3 CollisionSize = default, float TerminalVelocity = default, float GravityZ = default, bool bOnlyTraceUp = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateMinSpeedTrajectory, "Engine.Actor.CalculateMinSpeedTrajectory");
        byte* paramsPtr = stackalloc byte[72];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Velocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Velocity, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxTossSpeed, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinTossSpeed, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionSize, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TerminalVelocity, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GravityZ, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyTraceUp, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Velocity = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 68);
    }

    private static BmSDK.Function __fn_SuggestTossVelocity;
    /// <summary>
    /// Function: SuggestTossVelocity
    /// </summary>
    public unsafe virtual bool SuggestTossVelocity(out System.Numerics.Vector3 TossVelocity, System.Numerics.Vector3 Destination, System.Numerics.Vector3 Start, float TossSpeed, float BaseTossZ = default, float DesiredZPct = default, System.Numerics.Vector3 CollisionSize = default, float TerminalVelocity = default, float OverrideGravityZ = default, bool bOnlyTraceUp = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuggestTossVelocity, "Engine.Actor.SuggestTossVelocity");
        byte* paramsPtr = stackalloc byte[76];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TossVelocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TossVelocity, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Destination, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TossSpeed, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseTossZ, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredZPct, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionSize, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TerminalVelocity, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideGravityZ, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyTraceUp, paramsPtr + 68);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        TossVelocity = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 72);
    }

    private static BmSDK.Function __fn_PlayerCanSeeMe;
    /// <summary>
    /// Function: PlayerCanSeeMe
    /// </summary>
    public unsafe virtual bool PlayerCanSeeMe(bool bForceLOSCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerCanSeeMe, "Engine.Actor.PlayerCanSeeMe");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceLOSCheck, paramsPtr + 0);
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

    private static BmSDK.Function __fn_MakeNoise;
    /// <summary>
    /// Function: MakeNoise
    /// </summary>
    public unsafe virtual void MakeNoise(float Loudness, BmSDK.FName NoiseType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeNoise, "Engine.Actor.MakeNoise");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loudness, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoiseType, paramsPtr + 4);
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

    private static BmSDK.Function __fn_PlaySound;
    /// <summary>
    /// Function: PlaySound
    /// </summary>
    public unsafe virtual void PlaySound(BmSDK.Engine.SoundCue InSoundCue, bool bNotReplicated = default, bool bNoRepToOwner = default, bool bStopWhenOwnerDestroyed = default, System.Numerics.Vector3 SoundLocation = default, bool bNoRepToRelevant = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound, "Engine.Actor.PlaySound");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoundCue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNotReplicated, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoRepToOwner, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStopWhenOwnerDestroyed, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundLocation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoRepToRelevant, paramsPtr + 32);
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

    private static BmSDK.Function __fn_CreateAudioComponent;
    /// <summary>
    /// Function: CreateAudioComponent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AudioComponent CreateAudioComponent(BmSDK.Engine.SoundCue InSoundCue, bool bPlay = default, bool bStopWhenOwnerDestroyed = default, bool bUseLocation = default, System.Numerics.Vector3 SourceLocation = default, bool bAttachToSelf = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateAudioComponent, "Engine.Actor.CreateAudioComponent");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoundCue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlay, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStopWhenOwnerDestroyed, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceLocation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAttachToSelf, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AudioComponent>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_ResetTimerTimeDilation;
    /// <summary>
    /// Function: ResetTimerTimeDilation
    /// </summary>
    public unsafe virtual void ResetTimerTimeDilation(BmSDK.FName TimerName, BmSDK.GameObject inObj = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetTimerTimeDilation, "Engine.Actor.ResetTimerTimeDilation");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimerName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 8);
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

    private static BmSDK.Function __fn_ModifyTimerTimeDilation;
    /// <summary>
    /// Function: ModifyTimerTimeDilation
    /// </summary>
    public unsafe virtual void ModifyTimerTimeDilation(BmSDK.FName TimerName, float InTimerTimeDilation, BmSDK.GameObject inObj = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyTimerTimeDilation, "Engine.Actor.ModifyTimerTimeDilation");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimerName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTimerTimeDilation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 12);
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

    private static BmSDK.Function __fn_GetRemainingTimeForTimer;
    /// <summary>
    /// Function: GetRemainingTimeForTimer
    /// </summary>
    public unsafe virtual float GetRemainingTimeForTimer(BmSDK.FName TimerFuncName = default, BmSDK.GameObject inObj = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRemainingTimeForTimer, "Engine.Actor.GetRemainingTimeForTimer");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimerFuncName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetTimerRate;
    /// <summary>
    /// Function: GetTimerRate
    /// </summary>
    public unsafe virtual float GetTimerRate(BmSDK.FName TimerFuncName = default, BmSDK.GameObject inObj = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimerRate, "Engine.Actor.GetTimerRate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimerFuncName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetTimerCount;
    /// <summary>
    /// Function: GetTimerCount
    /// </summary>
    public unsafe virtual float GetTimerCount(BmSDK.FName inTimerFunc = default, BmSDK.GameObject inObj = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimerCount, "Engine.Actor.GetTimerCount");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTimerFunc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 8);
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

    private static BmSDK.Function __fn_IsTimerActive;
    /// <summary>
    /// Function: IsTimerActive
    /// </summary>
    public unsafe virtual bool IsTimerActive(BmSDK.FName inTimerFunc = default, BmSDK.GameObject inObj = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTimerActive, "Engine.Actor.IsTimerActive");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTimerFunc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 8);
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

    private static BmSDK.Function __fn_PauseTimer;
    /// <summary>
    /// Function: PauseTimer
    /// </summary>
    public unsafe virtual void PauseTimer(bool bPause, BmSDK.FName inTimerFunc = default, BmSDK.GameObject inObj = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PauseTimer, "Engine.Actor.PauseTimer");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPause, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTimerFunc, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 12);
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

    private static BmSDK.Function __fn_ClearAllTimers;
    /// <summary>
    /// Function: ClearAllTimers
    /// </summary>
    public unsafe virtual void ClearAllTimers(BmSDK.GameObject inObj = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAllTimers, "Engine.Actor.ClearAllTimers");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearTimer;
    /// <summary>
    /// Function: ClearTimer
    /// </summary>
    public unsafe virtual void ClearTimer(BmSDK.FName inTimerFunc = default, BmSDK.GameObject inObj = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearTimer, "Engine.Actor.ClearTimer");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTimerFunc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetTimer;
    /// <summary>
    /// Function: SetTimer
    /// </summary>
    public unsafe virtual void SetTimer(float InRate, bool inbLoop = default, BmSDK.FName inTimerFunc = default, bool bRealTimeTimer = default, BmSDK.GameObject inObj = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTimer, "Engine.Actor.SetTimer");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InRate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inbLoop, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTimerFunc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRealTimeTimer, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 20);
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

    private static BmSDK.Function __fn_TornOff;
    /// <summary>
    /// Function: TornOff
    /// </summary>
    public unsafe virtual void TornOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TornOff, "Engine.Actor.TornOff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroy;
    /// <summary>
    /// Function: Destroy
    /// </summary>
    public unsafe virtual bool Destroy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroy, "Engine.Actor.Destroy");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_Spawn;
    /// <summary>
    /// Function: Spawn
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor Spawn(BmSDK.Class SpawnClass, BmSDK.Engine.Actor SpawnOwner = default, BmSDK.FName SpawnTag = default, System.Numerics.Vector3 SpawnLocation = default, BmSDK.Rotator SpawnRotation = default, BmSDK.Engine.Actor ActorTemplate = default, bool bNoCollisionFail = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Spawn, "Engine.Actor.Spawn");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnOwner, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnTag, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorTemplate, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoCollisionFail, paramsPtr + 56);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_IsBlockedBy;
    /// <summary>
    /// Function: IsBlockedBy
    /// </summary>
    public unsafe virtual bool IsBlockedBy(BmSDK.Engine.Actor Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBlockedBy, "Engine.Actor.IsBlockedBy");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetBoundingCylinder;
    /// <summary>
    /// Function: GetBoundingCylinder
    /// </summary>
    public unsafe virtual void GetBoundingCylinder(out float CollisionRadius, out float CollisionHeight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBoundingCylinder, "Engine.Actor.GetBoundingCylinder");
        byte* paramsPtr = stackalloc byte[8];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CollisionRadius);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionRadius, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CollisionHeight);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionHeight, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CollisionRadius = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        CollisionHeight = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_GetComponentsBoundingBox;
    /// <summary>
    /// Function: GetComponentsBoundingBox
    /// </summary>
    public unsafe virtual void GetComponentsBoundingBox(out BmSDK.GameObject.FBox ActorBox)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComponentsBoundingBox, "Engine.Actor.GetComponentsBoundingBox");
        byte* paramsPtr = stackalloc byte[28];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ActorBox);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorBox, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ActorBox = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FBox>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_IsOverlapping;
    /// <summary>
    /// Function: IsOverlapping
    /// </summary>
    public unsafe virtual bool IsOverlapping(BmSDK.Engine.Actor A)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOverlapping, "Engine.Actor.IsOverlapping");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ContainsPointNoFilter;
    /// <summary>
    /// Function: ContainsPointNoFilter
    /// </summary>
    public unsafe virtual bool ContainsPointNoFilter(System.Numerics.Vector3 Spot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ContainsPointNoFilter, "Engine.Actor.ContainsPointNoFilter");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spot, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ContainsPoint;
    /// <summary>
    /// Function: ContainsPoint
    /// </summary>
    public unsafe virtual bool ContainsPoint(System.Numerics.Vector3 Spot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ContainsPoint, "Engine.Actor.ContainsPoint");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spot, paramsPtr + 0);
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

    private static BmSDK.Function __fn_FindSpot;
    /// <summary>
    /// Function: FindSpot
    /// </summary>
    public unsafe virtual bool FindSpot(System.Numerics.Vector3 BoxExtent, out System.Numerics.Vector3 SpotLocation, bool DontEaryOut = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindSpot, "Engine.Actor.FindSpot");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoxExtent, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SpotLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpotLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DontEaryOut, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SpotLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_TraceAllPhysicsAssetInteractions;
    /// <summary>
    /// Function: TraceAllPhysicsAssetInteractions
    /// </summary>
    public unsafe virtual bool TraceAllPhysicsAssetInteractions(BmSDK.Engine.SkeletalMeshComponent SkelMeshComp, System.Numerics.Vector3 EndTrace, System.Numerics.Vector3 StartTrace, out BmSDK.TArray<BmSDK.Engine.Actor.FImpactInfo> out_Hits, System.Numerics.Vector3 Extent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceAllPhysicsAssetInteractions, "Engine.Actor.TraceAllPhysicsAssetInteractions");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMeshComp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndTrace, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTrace, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Hits = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FImpactInfo>>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_FastTrace;
    /// <summary>
    /// Function: FastTrace
    /// </summary>
    public unsafe virtual bool FastTrace(System.Numerics.Vector3 TraceEnd, System.Numerics.Vector3 TraceStart = default, System.Numerics.Vector3 BoxExtent = default, bool bTraceBullet = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FastTrace, "Engine.Actor.FastTrace");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceEnd, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceStart, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoxExtent, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTraceBullet, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_PointCheckComponent;
    /// <summary>
    /// Function: PointCheckComponent
    /// </summary>
    public unsafe virtual bool PointCheckComponent(BmSDK.Engine.PrimitiveComponent InComponent, System.Numerics.Vector3 PointLocation, System.Numerics.Vector3 PointExtent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PointCheckComponent, "Engine.Actor.PointCheckComponent");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointExtent, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_TraceComponent;
    /// <summary>
    /// Function: TraceComponent
    /// </summary>
    public unsafe virtual bool TraceComponent(out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, BmSDK.Engine.PrimitiveComponent InComponent, System.Numerics.Vector3 TraceEnd, System.Numerics.Vector3 TraceStart, System.Numerics.Vector3 Extent, out BmSDK.Engine.Actor.FTraceHitInfo HitInfo, bool bComplexCollision)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceComponent, "Engine.Actor.TraceComponent");
        byte* paramsPtr = stackalloc byte[116];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InComponent, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceEnd, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceStart, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 56);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bComplexCollision, paramsPtr + 108);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        HitInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FTraceHitInfo>(paramsPtr + 68);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 112);
    }

    private static BmSDK.Function __fn_Trace;
    /// <summary>
    /// Function: Trace
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor Trace(out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 TraceEnd, System.Numerics.Vector3 TraceStart, BmSDK.Component.ECollisionFilter TraceFilter, System.Numerics.Vector3 Extent, out BmSDK.Engine.Actor.FTraceHitInfo HitInfo, int ExtraTraceFlags)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Trace, "Engine.Actor.Trace");
        byte* paramsPtr = stackalloc byte[116];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceEnd, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceStart, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceFilter, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 52);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraTraceFlags, paramsPtr + 104);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        HitInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FTraceHitInfo>(paramsPtr + 64);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 108);
    }

    private static BmSDK.Function __fn_VolumeBasedDestroy;
    /// <summary>
    /// Function: VolumeBasedDestroy
    /// </summary>
    public unsafe virtual void VolumeBasedDestroy(BmSDK.Engine.PhysicsVolume PV)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VolumeBasedDestroy, "Engine.Actor.VolumeBasedDestroy");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OutsideWorldBounds;
    /// <summary>
    /// Function: OutsideWorldBounds
    /// </summary>
    public unsafe virtual void OutsideWorldBounds()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OutsideWorldBounds, "Engine.Actor.OutsideWorldBounds");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FellOutOfWorld;
    /// <summary>
    /// Function: FellOutOfWorld
    /// </summary>
    public unsafe virtual void FellOutOfWorld(BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FellOutOfWorld, "Engine.Actor.FellOutOfWorld");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UsedBy;
    /// <summary>
    /// Function: UsedBy
    /// </summary>
    public unsafe virtual bool UsedBy(BmSDK.Engine.Pawn User)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UsedBy, "Engine.Actor.UsedBy");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(User, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AsyncLoadDone;
    /// <summary>
    /// Function: AsyncLoadDone
    /// </summary>
    public unsafe virtual void AsyncLoadDone(BmSDK.FString ObjectFinished)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AsyncLoadDone, "Engine.Actor.AsyncLoadDone");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectFinished, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverRotated;
    /// <summary>
    /// Function: OverRotated
    /// </summary>
    public unsafe virtual bool OverRotated(out BmSDK.Rotator out_Desired, out BmSDK.Rotator out_Actual)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverRotated, "Engine.Actor.OverRotated");
        byte* paramsPtr = stackalloc byte[28];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Desired);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Desired, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Actual);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Actual, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_Desired = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
        out_Actual = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ClampRotation;
    /// <summary>
    /// Function: ClampRotation
    /// </summary>
    public unsafe virtual bool ClampRotation(out BmSDK.Rotator out_Rot, BmSDK.Rotator rBase, BmSDK.Rotator rUpperLimits, BmSDK.Rotator rLowerLimits)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClampRotation, "Engine.Actor.ClampRotation");
        byte* paramsPtr = stackalloc byte[52];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Rot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rBase, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rUpperLimits, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rLowerLimits, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_OnSleepRBPhysics;
    /// <summary>
    /// Function: OnSleepRBPhysics
    /// </summary>
    public unsafe virtual void OnSleepRBPhysics()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSleepRBPhysics, "Engine.Actor.OnSleepRBPhysics");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnWakeRBPhysics;
    /// <summary>
    /// Function: OnWakeRBPhysics
    /// </summary>
    public unsafe virtual void OnWakeRBPhysics()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWakeRBPhysics, "Engine.Actor.OnWakeRBPhysics");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AnimationTriggerCallback;
    /// <summary>
    /// Function: AnimationTriggerCallback
    /// </summary>
    public unsafe virtual void AnimationTriggerCallback(BmSDK.FName TagName, BmSDK.TArray<BmSDK.FString> Params, BmSDK.Engine.AnimSet TagAnimSet, float Time)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnimationTriggerCallback, "Engine.Actor.AnimationTriggerCallback");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagAnimSet, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RanInto;
    /// <summary>
    /// Function: RanInto
    /// </summary>
    public unsafe virtual void RanInto(BmSDK.Engine.Actor Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RanInto, "Engine.Actor.RanInto");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EncroachedBy;
    /// <summary>
    /// Function: EncroachedBy
    /// </summary>
    public unsafe virtual void EncroachedBy(BmSDK.Engine.Actor Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EncroachedBy, "Engine.Actor.EncroachedBy");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CollisionChanged;
    /// <summary>
    /// Function: CollisionChanged
    /// </summary>
    public unsafe virtual void CollisionChanged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CollisionChanged, "Engine.Actor.CollisionChanged");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpecialHandling;
    /// <summary>
    /// Function: SpecialHandling
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor SpecialHandling(BmSDK.Engine.Pawn Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialHandling, "Engine.Actor.SpecialHandling");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_Detach;
    /// <summary>
    /// Function: Detach
    /// </summary>
    public unsafe virtual void Detach(BmSDK.Engine.Actor Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Detach, "Engine.Actor.Detach");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Attach;
    /// <summary>
    /// Function: Attach
    /// </summary>
    public unsafe virtual void Attach(BmSDK.Engine.Actor Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Attach, "Engine.Actor.Attach");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BaseChange;
    /// <summary>
    /// Function: BaseChange
    /// </summary>
    public unsafe virtual void BaseChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BaseChange, "Engine.Actor.BaseChange");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Bump;
    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe virtual void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Bump, "Engine.Actor.Bump");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnTouch;
    /// <summary>
    /// Function: UnTouch
    /// </summary>
    public unsafe virtual void UnTouch(BmSDK.Engine.Actor Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnTouch, "Engine.Actor.UnTouch");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostTouch;
    /// <summary>
    /// Function: PostTouch
    /// </summary>
    public unsafe virtual void PostTouch(BmSDK.Engine.Actor Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostTouch, "Engine.Actor.PostTouch");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Touch;
    /// <summary>
    /// Function: Touch
    /// </summary>
    public unsafe virtual void Touch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Touch, "Engine.Actor.Touch");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Landed;
    /// <summary>
    /// Function: Landed
    /// </summary>
    public unsafe virtual void Landed(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor FloorActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Landed, "Engine.Actor.Landed");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FloorActor, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Falling;
    /// <summary>
    /// Function: Falling
    /// </summary>
    public unsafe virtual void Falling()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Falling, "Engine.Actor.Falling");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitWall;
    /// <summary>
    /// Function: HitWall
    /// </summary>
    public unsafe virtual void HitWall(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor Wall, BmSDK.Engine.PrimitiveComponent WallComp)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitWall, "Engine.Actor.HitWall");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Wall, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallComp, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Timer;
    /// <summary>
    /// Function: Timer
    /// </summary>
    public unsafe virtual void Timer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Timer, "Engine.Actor.Timer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe virtual void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "Engine.Actor.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LostChild;
    /// <summary>
    /// Function: LostChild
    /// </summary>
    public unsafe virtual void LostChild(BmSDK.Engine.Actor Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LostChild, "Engine.Actor.LostChild");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GainedChild;
    /// <summary>
    /// Function: GainedChild
    /// </summary>
    public unsafe virtual void GainedChild(BmSDK.Engine.Actor Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GainedChild, "Engine.Actor.GainedChild");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe virtual void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "Engine.Actor.Destroyed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndOverrideApexClothSimulationEnabled;
    /// <summary>
    /// Function: EndOverrideApexClothSimulationEnabled
    /// </summary>
    public unsafe virtual void EndOverrideApexClothSimulationEnabled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndOverrideApexClothSimulationEnabled, "Engine.Actor.EndOverrideApexClothSimulationEnabled");
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

    private static BmSDK.Function __fn_BeginOverrideApexClothSimulationEnabled;
    /// <summary>
    /// Function: BeginOverrideApexClothSimulationEnabled
    /// </summary>
    public unsafe virtual void BeginOverrideApexClothSimulationEnabled(bool bSimulationEnabled, bool bClothVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginOverrideApexClothSimulationEnabled, "Engine.Actor.BeginOverrideApexClothSimulationEnabled");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSimulationEnabled, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bClothVisible, paramsPtr + 4);
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

    private static BmSDK.Function __fn_EndOverrideApexClothTeleportMode;
    /// <summary>
    /// Function: EndOverrideApexClothTeleportMode
    /// </summary>
    public unsafe virtual void EndOverrideApexClothTeleportMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndOverrideApexClothTeleportMode, "Engine.Actor.EndOverrideApexClothTeleportMode");
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

    private static BmSDK.Function __fn_BeginOverrideApexClothTeleportMode;
    /// <summary>
    /// Function: BeginOverrideApexClothTeleportMode
    /// </summary>
    public unsafe virtual void BeginOverrideApexClothTeleportMode(BmSDK.Engine.Actor.EApexClothTeleportMode TeleportMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginOverrideApexClothTeleportMode, "Engine.Actor.BeginOverrideApexClothTeleportMode");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeleportMode, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetApexClothSimulationEnabled;
    /// <summary>
    /// Function: SetApexClothSimulationEnabled
    /// </summary>
    public unsafe virtual void SetApexClothSimulationEnabled(bool bSimulationEnabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetApexClothSimulationEnabled, "Engine.Actor.SetApexClothSimulationEnabled");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSimulationEnabled, paramsPtr + 0);
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

    private static BmSDK.Function __fn_StartASyncLoad;
    /// <summary>
    /// Function: StartASyncLoad
    /// </summary>
    public unsafe virtual bool StartASyncLoad(BmSDK.FString FullPath, bool bIgnoreMissingPackage = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartASyncLoad, "Engine.Actor.StartASyncLoad");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FullPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreMissingPackage, paramsPtr + 16);
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

    private static BmSDK.Function __fn_SetStasis;
    /// <summary>
    /// Function: SetStasis
    /// </summary>
    public unsafe virtual void SetStasis(bool bInStasis)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStasis, "Engine.Actor.SetStasis");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInStasis, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnSetTickIsDisabledNative;
    /// <summary>
    /// Function: OnSetTickIsDisabledNative
    /// </summary>
    public unsafe virtual void OnSetTickIsDisabledNative(bool bDisabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSetTickIsDisabledNative, "Engine.Actor.OnSetTickIsDisabledNative");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDisabled, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnSetTickIsDisabled;
    /// <summary>
    /// Function: OnSetTickIsDisabled
    /// </summary>
    public unsafe virtual void OnSetTickIsDisabled(bool bDisabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSetTickIsDisabled, "Engine.Actor.OnSetTickIsDisabled");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDisabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTickIsDisabled;
    /// <summary>
    /// Function: SetTickIsDisabled
    /// </summary>
    public unsafe virtual void SetTickIsDisabled(bool bInDisabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTickIsDisabled, "Engine.Actor.SetTickIsDisabled");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInDisabled, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetTickGroup;
    /// <summary>
    /// Function: SetTickGroup
    /// </summary>
    public unsafe virtual void SetTickGroup(BmSDK.GameObject.ETickingGroup NewTickGroup)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTickGroup, "Engine.Actor.SetTickGroup");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTickGroup, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ReattachComponent;
    /// <summary>
    /// Function: ReattachComponent
    /// </summary>
    public unsafe virtual void ReattachComponent(BmSDK.Engine.ActorComponent ComponentToReattach)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReattachComponent, "Engine.Actor.ReattachComponent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComponentToReattach, paramsPtr + 0);
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
    public unsafe virtual void DetachComponent(BmSDK.Engine.ActorComponent ExComponent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachComponent, "Engine.Actor.DetachComponent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExComponent, paramsPtr + 0);
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
    public unsafe virtual void AttachComponent(BmSDK.Engine.ActorComponent NewComponent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachComponent, "Engine.Actor.AttachComponent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewComponent, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UnClock;
    /// <summary>
    /// Function: UnClock
    /// </summary>
    public unsafe virtual void UnClock(out float Time)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnClock, "Engine.Actor.UnClock");
        byte* paramsPtr = stackalloc byte[4];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Time);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Time = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_Clock;
    /// <summary>
    /// Function: Clock
    /// </summary>
    public unsafe virtual void Clock(out float Time)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Clock, "Engine.Actor.Clock");
        byte* paramsPtr = stackalloc byte[4];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Time);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Time = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetPhysics;
    /// <summary>
    /// Function: SetPhysics
    /// </summary>
    public unsafe virtual void SetPhysics(BmSDK.Engine.Actor.EPhysics newPhysics, bool WakePhysics = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPhysics, "Engine.Actor.SetPhysics");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newPhysics, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WakePhysics, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetOnlyOwnerSee;
    /// <summary>
    /// Function: SetOnlyOwnerSee
    /// </summary>
    public unsafe virtual void SetOnlyOwnerSee(bool bNewOnlyOwnerSee)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOnlyOwnerSee, "Engine.Actor.SetOnlyOwnerSee");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewOnlyOwnerSee, paramsPtr + 0);
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
    public unsafe virtual void SetHidden(bool bNewHidden)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHidden, "Engine.Actor.SetHidden");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewHidden, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ChartData;
    /// <summary>
    /// Function: ChartData
    /// </summary>
    public unsafe virtual void ChartData(BmSDK.FString DataName, float DataValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChartData, "Engine.Actor.ChartData");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataValue, paramsPtr + 16);
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

    private static BmSDK.Function __fn_FlushDebugStrings;
    /// <summary>
    /// Function: FlushDebugStrings
    /// </summary>
    public unsafe static void FlushDebugStrings()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushDebugStrings, "Engine.Actor.FlushDebugStrings");
        byte* paramsPtr = stackalloc byte[0];
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

    private static BmSDK.Function __fn_DrawDebugOrientedBox;
    /// <summary>
    /// Function: DrawDebugOrientedBox
    /// </summary>
    public unsafe static void DrawDebugOrientedBox(BmSDK.GameObject.FMatrix Transform, System.Numerics.Vector3 HalfExtents, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugOrientedBox, "Engine.Actor.DrawDebugOrientedBox");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Transform, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HalfExtents, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 77);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 78);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 80);
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

    private static BmSDK.Function __fn_DrawDebugFrustrum;
    /// <summary>
    /// Function: DrawDebugFrustrum
    /// </summary>
    public unsafe static void DrawDebugFrustrum(out BmSDK.GameObject.FMatrix FrustumToWorld, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugFrustrum, "Engine.Actor.DrawDebugFrustrum");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 65);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 66);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 68);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FrustumToWorld = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FMatrix>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_DrawDebugString;
    /// <summary>
    /// Function: DrawDebugString
    /// </summary>
    public unsafe static void DrawDebugString(System.Numerics.Vector3 TextLocation, BmSDK.FString Text, BmSDK.Engine.Actor TestBaseActor = default, BmSDK.GameObject.FColor TextColor = default, float Duration = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugString, "Engine.Actor.DrawDebugString");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestBaseActor, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextColor, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 40);
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

    private static BmSDK.Function __fn_DrawDebugSolidBox;
    /// <summary>
    /// Function: DrawDebugSolidBox
    /// </summary>
    public unsafe static void DrawDebugSolidBox(System.Numerics.Vector3 Center, System.Numerics.Vector3 Extent, byte R, byte G, byte B, byte Opacity, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugSolidBox, "Engine.Actor.DrawDebugSolidBox");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Center, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 25);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 26);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Opacity, paramsPtr + 27);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 28);
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

    private static BmSDK.Function __fn_DrawDebugCone;
    /// <summary>
    /// Function: DrawDebugCone
    /// </summary>
    public unsafe static void DrawDebugCone(System.Numerics.Vector3 Origin, System.Numerics.Vector3 Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, BmSDK.GameObject.FColor DrawColor, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugCone, "Engine.Actor.DrawDebugCone");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Origin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Length, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngleWidth, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngleHeight, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumSides, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DrawColor, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 44);
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

    private static BmSDK.Function __fn_DrawDebugCylinder;
    /// <summary>
    /// Function: DrawDebugCylinder
    /// </summary>
    public unsafe static void DrawDebugCylinder(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, float Radius, int Segments, byte R, byte G, byte B, bool bPersistentLines = default, BmSDK.FName DebugName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugCylinder, "Engine.Actor.DrawDebugCylinder");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Segments, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 33);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 34);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DebugName, paramsPtr + 40);
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

    private static BmSDK.Function __fn_DrawDebugSphere;
    /// <summary>
    /// Function: DrawDebugSphere
    /// </summary>
    public unsafe static void DrawDebugSphere(System.Numerics.Vector3 Center, float Radius, int Segments, byte R, byte G, byte B, bool bPersistentLines = default, BmSDK.FName DebugName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugSphere, "Engine.Actor.DrawDebugSphere");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Center, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Segments, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 21);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 22);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DebugName, paramsPtr + 28);
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

    private static BmSDK.Function __fn_DrawDebugCoordinateSystem;
    /// <summary>
    /// Function: DrawDebugCoordinateSystem
    /// </summary>
    public unsafe static void DrawDebugCoordinateSystem(System.Numerics.Vector3 AxisLoc, BmSDK.Rotator AxisRot, float Scale, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugCoordinateSystem, "Engine.Actor.DrawDebugCoordinateSystem");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 28);
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

    private static BmSDK.Function __fn_DrawDebugStar;
    /// <summary>
    /// Function: DrawDebugStar
    /// </summary>
    public unsafe static void DrawDebugStar(System.Numerics.Vector3 Position, float Size, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugStar, "Engine.Actor.DrawDebugStar");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Size, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 17);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 18);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 20);
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

    private static BmSDK.Function __fn_DrawDebugBounds;
    /// <summary>
    /// Function: DrawDebugBounds
    /// </summary>
    public unsafe static void DrawDebugBounds(System.Numerics.Vector3 AxisLoc, BmSDK.Rotator AxisRot, BmSDK.GameObject.FBox Bounds, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugBounds, "Engine.Actor.DrawDebugBounds");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bounds, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 53);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 54);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 56);
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

    private static BmSDK.Function __fn_DrawDebugBox;
    /// <summary>
    /// Function: DrawDebugBox
    /// </summary>
    public unsafe static void DrawDebugBox(System.Numerics.Vector3 Center, System.Numerics.Vector3 Extent, byte R, byte G, byte B, bool bPersistentLines = default, BmSDK.FName DebugName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugBox, "Engine.Actor.DrawDebugBox");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Center, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 25);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 26);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DebugName, paramsPtr + 32);
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

    private static BmSDK.Function __fn_DrawDebugPoint;
    /// <summary>
    /// Function: DrawDebugPoint
    /// </summary>
    public unsafe static void DrawDebugPoint(System.Numerics.Vector3 Position, float Size, BmSDK.GameObject.FLinearColor PointColor, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugPoint, "Engine.Actor.DrawDebugPoint");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Size, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointColor, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 32);
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

    private static BmSDK.Function __fn_DrawDebugLine;
    /// <summary>
    /// Function: DrawDebugLine
    /// </summary>
    public unsafe static void DrawDebugLine(System.Numerics.Vector3 LineStart, System.Numerics.Vector3 LineEnd, byte R, byte G, byte B, bool bPersistentLines = default, BmSDK.FName DebugName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugLine, "Engine.Actor.DrawDebugLine");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineStart, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineEnd, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 25);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 26);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DebugName, paramsPtr + 32);
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

    private static BmSDK.Function __fn_FlushAllPersistentDebugLines;
    /// <summary>
    /// Function: FlushAllPersistentDebugLines
    /// </summary>
    public unsafe static void FlushAllPersistentDebugLines()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushAllPersistentDebugLines, "Engine.Actor.FlushAllPersistentDebugLines");
        byte* paramsPtr = stackalloc byte[0];
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

    private static BmSDK.Function __fn_FlushPersistentDebugLines;
    /// <summary>
    /// Function: FlushPersistentDebugLines
    /// </summary>
    public unsafe static void FlushPersistentDebugLines(BmSDK.FName DebugName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushPersistentDebugLines, "Engine.Actor.FlushPersistentDebugLines");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DebugName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetBasedPosition;
    /// <summary>
    /// Function: GetBasedPosition
    /// </summary>
    public unsafe static System.Numerics.Vector3 GetBasedPosition(BmSDK.Engine.Actor.FBasedPosition BP)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBasedPosition, "Engine.Actor.GetBasedPosition");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BP, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 56);
    }

    private static BmSDK.Function __fn_SetBasedPosition;
    /// <summary>
    /// Function: SetBasedPosition
    /// </summary>
    public unsafe static void SetBasedPosition(out BmSDK.Engine.Actor.FBasedPosition BP, System.Numerics.Vector3 pos, BmSDK.Engine.Actor ForcedBase = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBasedPosition, "Engine.Actor.SetBasedPosition");
        byte* paramsPtr = stackalloc byte[76];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BP);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BP, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForcedBase, paramsPtr + 68);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BP = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FBasedPosition>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_BP2Vect;
    /// <summary>
    /// Function: BP2Vect
    /// </summary>
    public unsafe static System.Numerics.Vector3 BP2Vect(BmSDK.Engine.Actor.FBasedPosition BP)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BP2Vect, "Engine.Actor.BP2Vect");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BP, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 56);
    }

    private static BmSDK.Function __fn_Vect2BP;
    /// <summary>
    /// Function: Vect2BP
    /// </summary>
    public unsafe static void Vect2BP(out BmSDK.Engine.Actor.FBasedPosition BP, System.Numerics.Vector3 pos, BmSDK.Engine.Actor ForcedBase = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Vect2BP, "Engine.Actor.Vect2BP");
        byte* paramsPtr = stackalloc byte[76];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BP);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BP, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForcedBase, paramsPtr + 68);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BP = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FBasedPosition>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetForcedInitialReplicatedProperty;
    /// <summary>
    /// Function: SetForcedInitialReplicatedProperty
    /// </summary>
    public unsafe virtual void SetForcedInitialReplicatedProperty(BmSDK.Property PropToReplicate, bool bAdd)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetForcedInitialReplicatedProperty, "Engine.Actor.SetForcedInitialReplicatedProperty");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropToReplicate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAdd, paramsPtr + 8);
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

    private static BmSDK.Function __fn_ReplicatedEvent;
    /// <summary>
    /// Function: ReplicatedEvent
    /// </summary>
    public unsafe virtual void ReplicatedEvent(BmSDK.FName VarName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicatedEvent, "Engine.Actor.ReplicatedEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAggregateBaseVelocity;
    /// <summary>
    /// Function: GetAggregateBaseVelocity
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAggregateBaseVelocity(BmSDK.Engine.Actor TestBase = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAggregateBaseVelocity, "Engine.Actor.GetAggregateBaseVelocity");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestBase, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsOwnedBy;
    /// <summary>
    /// Function: IsOwnedBy
    /// </summary>
    public unsafe virtual bool IsOwnedBy(BmSDK.Engine.Actor TestActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOwnedBy, "Engine.Actor.IsOwnedBy");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetBaseMost;
    /// <summary>
    /// Function: GetBaseMost
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetBaseMost()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBaseMost, "Engine.Actor.GetBaseMost");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBasedOn;
    /// <summary>
    /// Function: IsBasedOn
    /// </summary>
    public unsafe virtual bool IsBasedOn(BmSDK.Engine.Actor TestActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBasedOn, "Engine.Actor.IsBasedOn");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SearchForBaseBelow;
    /// <summary>
    /// Function: SearchForBaseBelow
    /// </summary>
    public unsafe virtual void SearchForBaseBelow(float HeightBelow, out BmSDK.Engine.Actor NewBase, out System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SearchForBaseBelow, "Engine.Actor.SearchForBaseBelow");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeightBelow, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewBase);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBase, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NewBase = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 4);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_FindBase;
    /// <summary>
    /// Function: FindBase
    /// </summary>
    public unsafe virtual void FindBase()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindBase, "Engine.Actor.FindBase");
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

    private static BmSDK.Function __fn_SetOwner;
    /// <summary>
    /// Function: SetOwner
    /// </summary>
    public unsafe virtual void SetOwner(BmSDK.Engine.Actor NewOwner)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOwner, "Engine.Actor.SetOwner");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetBase;
    /// <summary>
    /// Function: SetBase
    /// </summary>
    public unsafe virtual void SetBase(BmSDK.Engine.Actor NewBase, System.Numerics.Vector3 NewFloor = default, BmSDK.Engine.SkeletalMeshComponent SkelComp = default, BmSDK.FName AttachName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBase, "Engine.Actor.SetBase");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBase, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFloor, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelComp, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachName, paramsPtr + 28);
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

    private static BmSDK.Function __fn_GetTerminalVelocity;
    /// <summary>
    /// Function: GetTerminalVelocity
    /// </summary>
    public unsafe virtual float GetTerminalVelocity()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTerminalVelocity, "Engine.Actor.GetTerminalVelocity");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_AutonomousPhysics;
    /// <summary>
    /// Function: AutonomousPhysics
    /// </summary>
    public unsafe virtual void AutonomousPhysics(float DeltaSeconds)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutonomousPhysics, "Engine.Actor.AutonomousPhysics");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaSeconds, paramsPtr + 0);
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

    private static BmSDK.Function __fn_MoveSmooth;
    /// <summary>
    /// Function: MoveSmooth
    /// </summary>
    public unsafe virtual bool MoveSmooth(System.Numerics.Vector3 Delta)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveSmooth, "Engine.Actor.MoveSmooth");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 0);
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

    private static BmSDK.Function __fn_fixedTurn;
    /// <summary>
    /// Function: fixedTurn
    /// </summary>
    public unsafe virtual int fixedTurn(int Current, int Desired, int DeltaRate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_fixedTurn, "Engine.Actor.fixedTurn");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Desired, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaRate, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetHardAttach;
    /// <summary>
    /// Function: SetHardAttach
    /// </summary>
    public unsafe virtual void SetHardAttach(bool bNewHardAttach = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHardAttach, "Engine.Actor.SetHardAttach");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewHardAttach, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetRelativeLocation;
    /// <summary>
    /// Function: SetRelativeLocation
    /// </summary>
    public unsafe virtual bool SetRelativeLocation(System.Numerics.Vector3 NewLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRelativeLocation, "Engine.Actor.SetRelativeLocation");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLocation, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetRelativeRotation;
    /// <summary>
    /// Function: SetRelativeRotation
    /// </summary>
    public unsafe virtual bool SetRelativeRotation(BmSDK.Rotator NewRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRelativeRotation, "Engine.Actor.SetRelativeRotation");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRotation, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetZone;
    /// <summary>
    /// Function: SetZone
    /// </summary>
    public unsafe virtual void SetZone(bool bForceRefresh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetZone, "Engine.Actor.SetZone");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceRefresh, paramsPtr + 0);
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

    private static BmSDK.Function __fn_FarMoveActor;
    /// <summary>
    /// Function: FarMoveActor
    /// </summary>
    public unsafe virtual bool FarMoveActor(System.Numerics.Vector3 NewLocation, bool Test = default, bool NoCheck = default, bool AttachedMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FarMoveActor, "Engine.Actor.FarMoveActor");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Test, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoCheck, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachedMove, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_MovingWhichWay;
    /// <summary>
    /// Function: MovingWhichWay
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor.EMoveDir MovingWhichWay(out float Amount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MovingWhichWay, "Engine.Actor.MovingWhichWay");
        byte* paramsPtr = stackalloc byte[5];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Amount);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Amount = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.EMoveDir>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetRotation;
    /// <summary>
    /// Function: SetRotation
    /// </summary>
    public unsafe virtual bool SetRotation(BmSDK.Rotator NewRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRotation, "Engine.Actor.SetRotation");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRotation, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetLocation;
    /// <summary>
    /// Function: SetLocation
    /// </summary>
    public unsafe virtual bool SetLocation(System.Numerics.Vector3 NewLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLocation, "Engine.Actor.SetLocation");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLocation, paramsPtr + 0);
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

    private static BmSDK.Function __fn_Move;
    /// <summary>
    /// Function: Move
    /// </summary>
    public unsafe virtual bool Move(System.Numerics.Vector3 Delta)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Move, "Engine.Actor.Move");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetCollisionFilter;
    /// <summary>
    /// Function: SetCollisionFilter
    /// </summary>
    public unsafe virtual void SetCollisionFilter(BmSDK.Component.ECollisionFilter Filter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCollisionFilter, "Engine.Actor.SetCollisionFilter");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filter, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetDrawScale3D;
    /// <summary>
    /// Function: SetDrawScale3D
    /// </summary>
    public unsafe virtual void SetDrawScale3D(System.Numerics.Vector3 NewScale3D)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDrawScale3D, "Engine.Actor.SetDrawScale3D");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewScale3D, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetDrawScale;
    /// <summary>
    /// Function: SetDrawScale
    /// </summary>
    public unsafe virtual void SetDrawScale(float NewScale)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDrawScale, "Engine.Actor.SetDrawScale");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewScale, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetCollisionType;
    /// <summary>
    /// Function: SetCollisionType
    /// </summary>
    public unsafe virtual void SetCollisionType(BmSDK.Engine.Actor.ECollisionType NewCollisionType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCollisionType, "Engine.Actor.SetCollisionType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCollisionType, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetCollisionSize;
    /// <summary>
    /// Function: SetCollisionSize
    /// </summary>
    public unsafe virtual void SetCollisionSize(float NewRadius, float NewHeight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCollisionSize, "Engine.Actor.SetCollisionSize");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRadius, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewHeight, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetCollision;
    /// <summary>
    /// Function: SetCollision
    /// </summary>
    public unsafe virtual void SetCollision(bool bNewColActors = default, bool bNewBlockActors = default, bool bNewIgnoreEncroachers = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCollision, "Engine.Actor.SetCollision");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewColActors, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewBlockActors, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewIgnoreEncroachers, paramsPtr + 8);
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

    private static BmSDK.Function __fn_FinishAnim;
    /// <summary>
    /// Function: FinishAnim
    /// </summary>
    public unsafe virtual void FinishAnim(BmSDK.Engine.AnimNodeSequence SeqNode, bool bFinishOnBlendOut = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishAnim, "Engine.Actor.FinishAnim");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SeqNode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinishOnBlendOut, paramsPtr + 8);
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

    private static BmSDK.Function __fn_Sleep;
    /// <summary>
    /// Function: Sleep
    /// </summary>
    public unsafe virtual void Sleep(float Seconds)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Sleep, "Engine.Actor.Sleep");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Seconds, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ConsoleCommand;
    /// <summary>
    /// Function: ConsoleCommand
    /// </summary>
    public unsafe virtual BmSDK.FString ConsoleCommand(BmSDK.FString Command, bool bWriteToLog = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConsoleCommand, "Engine.Actor.ConsoleCommand");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Command, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWriteToLog, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ForceUpdateComponents;
    /// <summary>
    /// Function: ForceUpdateComponents
    /// </summary>
    public unsafe virtual void ForceUpdateComponents(bool bCollisionUpdate = default, bool bTransformOnly = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceUpdateComponents, "Engine.Actor.ForceUpdateComponents");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCollisionUpdate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTransformOnly, paramsPtr + 4);
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
    /// Struct: FASyncLoadRequestInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FASyncLoadRequestInfo
    {
        /// <summary>
        /// ObjectProperty: SelfRef
        /// </summary>
        public unsafe BmSDK.Engine.Actor SelfRef
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: ObjectName
        /// </summary>
        public unsafe BmSDK.FString ObjectName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FBasedPosition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial record struct FBasedPosition
    {
        /// <summary>
        /// ObjectProperty: Base
        /// </summary>
        public unsafe BmSDK.Engine.Actor Base
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Position
        /// </summary>
        public unsafe System.Numerics.Vector3 Position
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: CachedBaseLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 CachedBaseLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// StructProperty: CachedBaseRotation
        /// </summary>
        public unsafe BmSDK.Rotator CachedBaseRotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: CachedTransPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 CachedTransPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }

    /// <summary>
    /// Struct: FNavReference
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FNavReference
    {
        /// <summary>
        /// ObjectProperty: Nav
        /// </summary>
        public unsafe BmSDK.Engine.NavigationPoint Nav
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavigationPoint>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Guid
        /// </summary>
        public unsafe BmSDK.GameObject.FGuid Guid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FGuid>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FActorReference
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FActorReference
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
        /// StructProperty: Guid
        /// </summary>
        public unsafe BmSDK.GameObject.FGuid Guid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FGuid>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: EDoubleClickDir
    /// </summary>
    public enum EDoubleClickDir : byte
    {
        DCLICK_None = 0,
        DCLICK_Left = 1,
        DCLICK_Right = 2,
        DCLICK_Forward = 3,
        DCLICK_Back = 4,
        DCLICK_Active = 5,
        DCLICK_Done = 6,
        DCLICK_MAX = 7,
    }

    /// <summary>
    /// Enum: ETravelType
    /// </summary>
    public enum ETravelType : byte
    {
        TRAVEL_Absolute = 0,
        TRAVEL_Partial = 1,
        TRAVEL_Relative = 2,
        TRAVEL_MAX = 3,
    }

    /// <summary>
    /// Struct: FInvestigationData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FInvestigationData
    {
        /// <summary>
        /// StrProperty: InvestigationInfoTitle
        /// </summary>
        public unsafe BmSDK.FString InvestigationInfoTitle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: InvestigationInfo
        /// </summary>
        public unsafe BmSDK.FString InvestigationInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// NameProperty: GlobalFlagCheck
        /// </summary>
        public unsafe BmSDK.FName GlobalFlagCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bInvertFlag
        /// </summary>
        public unsafe bool bInvertFlag
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: bWarningFlag
        /// </summary>
        public unsafe bool bWarningFlag
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FPhysEffectInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FPhysEffectInfo
    {
        /// <summary>
        /// FloatProperty: MinEffectSpeed
        /// </summary>
        public unsafe float MinEffectSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MaxEffectSpeed
        /// </summary>
        public unsafe float MaxEffectSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: ReFireDelay
        /// </summary>
        public unsafe float ReFireDelay
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: Effect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem Effect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ComponentProperty: Force
        /// </summary>
        public unsafe BmSDK.Engine.RB_ForceComponent Force
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_ForceComponent>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FCollisionImpactData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FCollisionImpactData
    {
        /// <summary>
        /// ArrayProperty: ContactInfos
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.Actor.FRigidBodyContactInfo> ContactInfos
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FRigidBodyContactInfo>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: TotalNormalForceVector
        /// </summary>
        public unsafe System.Numerics.Vector3 TotalNormalForceVector
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: TotalFrictionForceVector
        /// </summary>
        public unsafe System.Numerics.Vector3 TotalFrictionForceVector
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Struct: FRigidBodyContactInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 84)]
    public partial record struct FRigidBodyContactInfo
    {
        /// <summary>
        /// StructProperty: ContactPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 ContactPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: ContactNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 ContactNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: ContactPenetration
        /// </summary>
        public unsafe float ContactPenetration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: ContactVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 ContactVelocity_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
        /// <summary>
        /// StructProperty: ContactVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 ContactVelocity_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ObjectProperty: PhysMaterial
        /// </summary>
        public unsafe BmSDK.Engine.PhysicalMaterial PhysMaterial_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicalMaterial>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }
        /// <summary>
        /// ObjectProperty: PhysMaterial
        /// </summary>
        public unsafe BmSDK.Engine.PhysicalMaterial PhysMaterial_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicalMaterial>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// StructProperty: Shapes
        /// </summary>
        public unsafe System.IntPtr Shapes_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }
        /// <summary>
        /// StructProperty: Shapes
        /// </summary>
        public unsafe System.IntPtr Shapes_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }
    }

    /// <summary>
    /// Struct: FRigidBodyState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 57)]
    public partial record struct FRigidBodyState
    {
        /// <summary>
        /// StructProperty: Position
        /// </summary>
        public unsafe System.Numerics.Vector3 Position
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Quaternion
        /// </summary>
        public unsafe BmSDK.GameObject.FQuat Quaternion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FQuat>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: LinVel
        /// </summary>
        public unsafe System.Numerics.Vector3 LinVel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: AngVel
        /// </summary>
        public unsafe System.Numerics.Vector3 AngVel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// ByteProperty: bNewData
        /// </summary>
        public unsafe byte bNewData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Struct: FPhysContactModificationData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FPhysContactModificationData
    {
        /// <summary>
        /// IntProperty: ChangeFlags
        /// </summary>
        public unsafe int ChangeFlags
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: PhysShape0
        /// </summary>
        public unsafe System.IntPtr PhysShape0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: PhysShape1
        /// </summary>
        public unsafe System.IntPtr PhysShape1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: Actor0
        /// </summary>
        public unsafe BmSDK.Engine.Actor Actor0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ObjectProperty: Actor1
        /// </summary>
        public unsafe BmSDK.Engine.Actor Actor1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: PhysFeatureIndex0
        /// </summary>
        public unsafe int PhysFeatureIndex0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: physFeatureIndex1
        /// </summary>
        public unsafe int physFeatureIndex1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: PhysData
        /// </summary>
        public unsafe System.IntPtr PhysData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }

    /// <summary>
    /// Enum: ECollisionType
    /// </summary>
    public enum ECollisionType : byte
    {
        COLLIDE_CustomDefault = 0,
        COLLIDE_NoCollision = 1,
        COLLIDE_BlockAll = 2,
        COLLIDE_BlockWeapons = 3,
        COLLIDE_TouchAll = 4,
        COLLIDE_TouchWeapons = 5,
        COLLIDE_BlockAllButWeapons = 6,
        COLLIDE_TouchAllButWeapons = 7,
        COLLIDE_BlockWeaponsKickable = 8,
        COLLIDE_MAX = 9,
    }

    /// <summary>
    /// Struct: FPendingTouch
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FPendingTouch
    {
        /// <summary>
        /// ObjectProperty: TouchingActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor TouchingActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ComponentProperty: HitComponent
        /// </summary>
        public unsafe BmSDK.Engine.PrimitiveComponent HitComponent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: HitLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 HitLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: HitNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 HitNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ComponentProperty: SourceComponent
        /// </summary>
        public unsafe BmSDK.Engine.PrimitiveComponent SourceComponent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FAnimSlotDesc
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FAnimSlotDesc
    {
        /// <summary>
        /// NameProperty: SlotName
        /// </summary>
        public unsafe BmSDK.FName SlotName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: NumChannels
        /// </summary>
        public unsafe int NumChannels
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FAnimSlotInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FAnimSlotInfo
    {
        /// <summary>
        /// NameProperty: SlotName
        /// </summary>
        public unsafe BmSDK.FName SlotName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: ChannelWeights
        /// </summary>
        public unsafe BmSDK.TArray<float> ChannelWeights
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FImpactInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public partial record struct FImpactInfo
    {
        /// <summary>
        /// ObjectProperty: HitActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor HitActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: HitLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 HitLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: HitNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 HitNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// StructProperty: RayDir
        /// </summary>
        public unsafe System.Numerics.Vector3 RayDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: StartTrace
        /// </summary>
        public unsafe System.Numerics.Vector3 StartTrace
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// StructProperty: HitInfo
        /// </summary>
        public unsafe BmSDK.Engine.Actor.FTraceHitInfo HitInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.FTraceHitInfo>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Struct: FTraceHitInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FTraceHitInfo
    {
        /// <summary>
        /// ObjectProperty: Material
        /// </summary>
        public unsafe BmSDK.Engine.Material Material
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: PhysMaterial
        /// </summary>
        public unsafe BmSDK.Engine.PhysicalMaterial PhysMaterial
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicalMaterial>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: Item
        /// </summary>
        public unsafe int Item
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: LevelIndex
        /// </summary>
        public unsafe int LevelIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// NameProperty: BoneName
        /// </summary>
        public unsafe BmSDK.FName BoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ComponentProperty: HitComponent
        /// </summary>
        public unsafe BmSDK.Engine.PrimitiveComponent HitComponent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Enum: ENetRole
    /// </summary>
    public enum ENetRole : byte
    {
        ROLE_None = 0,
        ROLE_SimulatedProxy = 1,
        ROLE_AutonomousProxy = 2,
        ROLE_Authority = 3,
        ROLE_MAX = 4,
    }

    /// <summary>
    /// Struct: FTimerData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FTimerData
    {
        /// <summary>
        /// BoolProperty: bLoop
        /// </summary>
        public unsafe bool bLoop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bPaused
        /// </summary>
        public unsafe bool bPaused
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bIgnoreGameTimeDilation
        /// </summary>
        public unsafe bool bIgnoreGameTimeDilation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: FuncName
        /// </summary>
        public unsafe BmSDK.FName FuncName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: Rate
        /// </summary>
        public unsafe float Rate
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: Count
        /// </summary>
        public unsafe float Count
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: TimerTimeDilation
        /// </summary>
        public unsafe float TimerTimeDilation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ObjectProperty: TimerObj
        /// </summary>
        public unsafe BmSDK.GameObject TimerObj
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: EApexClothTeleportMode
    /// </summary>
    public enum EApexClothTeleportMode : byte
    {
        ApexClothTeleportMode_Continuous = 0,
        ApexClothTeleportMode_Teleport = 1,
        ApexClothTeleportMode_TeleportAndReset = 2,
        ApexClothTeleportMode_MAX = 3,
    }

    /// <summary>
    /// Enum: EWeaponDamageResult
    /// </summary>
    public enum EWeaponDamageResult : byte
    {
        EWDR_NoReaction = 0,
        EWDR_Armoured = 1,
        EWDR_Damaged = 2,
        EWDR_MAX = 3,
    }

    /// <summary>
    /// Enum: EActorMetricsType
    /// </summary>
    public enum EActorMetricsType : byte
    {
        METRICS_VERTS = 0,
        METRICS_TRIS = 1,
        METRICS_SECTIONS = 2,
        METRICS_MAX = 3,
    }

    /// <summary>
    /// Enum: EMoveDir
    /// </summary>
    public enum EMoveDir : byte
    {
        MD_Stationary = 0,
        MD_Forward = 1,
        MD_Backward = 2,
        MD_Left = 3,
        MD_Right = 4,
        MD_Up = 5,
        MD_Down = 6,
        MD_MAX = 7,
    }

    /// <summary>
    /// Enum: EPhysics
    /// </summary>
    public enum EPhysics : byte
    {
        PHYS_None = 0,
        PHYS_Walking = 1,
        PHYS_Falling = 2,
        PHYS_Swimming = 3,
        PHYS_Flying = 4,
        PHYS_Rotating = 5,
        PHYS_Projectile = 6,
        PHYS_Interpolating = 7,
        PHYS_Spider = 8,
        PHYS_Ladder = 9,
        PHYS_RigidBody = 10,
        PHYS_SoftBody = 11,
        PHYS_NavMeshWalking = 12,
        PHYS_Floating = 13,
        PHYS_Driving = 14,
        PHYS_Shimmying = 15,
        PHYS_Ceiling = 16,
        PHYS_Unused = 17,
        PHYS_Custom = 18,
        PHYS_MAX = 19,
    }

    /// <summary>
    /// Enum: EHideRule
    /// </summary>
    public enum EHideRule : byte
    {
        EHideRule_Never = 0,
        EHideRule_AfterCh0 = 1,
        EHideRule_AfterCh1 = 2,
        EHideRule_AfterCh2 = 3,
        EHideRule_AfterCh3 = 4,
        EHideRule_AfterCh4 = 5,
        EHideRule_AfterCh5 = 6,
        EHideRule_AfterCh6 = 7,
        EHideRule_AfterCh7 = 8,
        EHideRule_AfterCh8 = 9,
        EHideRule_AfterCh9 = 10,
        EHideRule_BeforeCh1 = 11,
        EHideRule_BeforeCh2 = 12,
        EHideRule_BeforeCh3 = 13,
        EHideRule_BeforeCh4 = 14,
        EHideRule_BeforeCh5 = 15,
        EHideRule_BeforeCh6 = 16,
        EHideRule_BeforeCh7 = 17,
        EHideRule_BeforeCh8 = 18,
        EHideRule_BeforeCh9 = 19,
        EHideRule_BeforeCh10 = 20,
        EHideRule_InFearGas = 21,
        EHideRule_MAX = 22,
    }

    /// <summary>
    /// Enum: ESideStory
    /// </summary>
    public enum ESideStory : byte
    {
        ESideStory_None = 0,
        ESideStory_Azrael = 1,
        ESideStory_Bane = 2,
        ESideStory_C = 3,
        ESideStory_DeadShot = 4,
        ESideStory_E = 5,
        ESideStory_F = 6,
        ESideStory_G = 7,
        ESideStory_Hush = 8,
        ESideStory_I = 9,
        ESideStory_AutoJez = 10,
        ESideStory_K = 11,
        ESideStory_L = 12,
        ESideStory_MadHatter = 13,
        ESideStory_Nora = 14,
        ESideStory_O = 15,
        ESideStory_Paths = 16,
        ESideStory_Q = 17,
        ESideStory_Races = 18,
        ESideStory_S = 19,
        ESideStory_ThugBullies = 20,
        ESideStory_U = 21,
        ESideStory_V = 22,
        ESideStory_W = 23,
        ESideStory_X = 24,
        ESideStory_Y = 25,
        ESideStory_Zsasz = 26,
        ESideStory__A_DontUse = 27,
        ESideStory__B_DontUse = 28,
        ESideStory__C_DontUse = 29,
        ESideStory__D = 30,
        ESideStory__E = 31,
        ESideStory__F = 32,
        ESideStory__G = 33,
        ESideStory__H = 34,
        ESideStory__I = 35,
        ESideStory__J = 36,
        ESideStory__K = 37,
        ESideStory__L = 38,
        ESideStory__M = 39,
        ESideStory__N_DontUse = 40,
        ESideStory__O_DontUse = 41,
        ESideStory__P = 42,
        ESideStory__Q_DontUse = 43,
        ESideStory__R_DontUse = 44,
        ESideStory__S_DontUse = 45,
        ESideStory__T = 46,
        ESideStory__U = 47,
        ESideStory__V_DontUse = 48,
        ESideStory__W = 49,
        ESideStory__X_DontUse = 50,
        ESideStory__Y = 51,
        ESideStory__Z = 52,
        ESideStory_MAX = 53,
    }

    /// <summary>
    /// ArrayProperty: Components
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ActorComponent> Components
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ActorComponent>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: AllComponents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ActorComponent> AllComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ActorComponent>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: DefaultAkAudible
    /// </summary>
    public unsafe BmSDK.Engine.RAkAudible DefaultAkAudible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAkAudible>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: Owner
    /// </summary>
    public unsafe BmSDK.Engine.Actor Owner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: Base
    /// </summary>
    public unsafe BmSDK.Engine.Actor Base
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: Instigator
    /// </summary>
    public unsafe BmSDK.Engine.Pawn Instigator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: WorldInfo
    /// </summary>
    public unsafe BmSDK.Engine.WorldInfo WorldInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ObjectProperty: LatentSeqNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence LatentSeqNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ObjectProperty: PhysicsVolume
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsVolume PhysicsVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsVolume>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ComponentProperty: CollisionComponent
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent CollisionComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ComponentProperty: BaseSkelComponent
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BaseSkelComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// StructProperty: Location
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Location
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 196);

    /// <summary>
    /// StructProperty: Rotation
    /// </summary>
    public unsafe ref BmSDK.Rotator Rotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 208);

    /// <summary>
    /// FloatProperty: DrawScale
    /// </summary>
    public unsafe float DrawScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// StructProperty: DrawScale3D
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DrawScale3D
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 224);

    /// <summary>
    /// StructProperty: PrePivot
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PrePivot
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 236);

    /// <summary>
    /// StructProperty: EditorIconColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor EditorIconColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 248);

    /// <summary>
    /// FloatProperty: EditorIconDrawScale
    /// </summary>
    public unsafe float EditorIconDrawScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// BoolProperty: HighResTextureStreaming
    /// </summary>
    public unsafe bool HighResTextureStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: BoostDynamicTextureStreaming
    /// </summary>
    public unsafe bool BoostDynamicTextureStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bHidingIsTemporary
    /// </summary>
    public unsafe bool bHidingIsTemporary
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bIsTemporarilyHidden
    /// </summary>
    public unsafe bool bIsTemporarilyHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bStatic
    /// </summary>
    public unsafe bool bStatic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bHidden
    /// </summary>
    public unsafe bool bHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bHiddenInitial
    /// </summary>
    public unsafe bool bHiddenInitial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bNoDelete
    /// </summary>
    public unsafe bool bNoDelete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bDeleteMe
    /// </summary>
    public unsafe bool bDeleteMe
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bOnlyOwnerSee
    /// </summary>
    public unsafe bool bOnlyOwnerSee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bTickIsDisabled
    /// </summary>
    public unsafe bool bTickIsDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bStasis
    /// </summary>
    public unsafe bool bStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bWaitForTickBeforeStasis
    /// </summary>
    public unsafe bool bWaitForTickBeforeStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bEnableChunkyTick
    /// </summary>
    public unsafe bool bEnableChunkyTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bWorldGeometry
    /// </summary>
    public unsafe bool bWorldGeometry
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreRigidBodyPawns
    /// </summary>
    public unsafe bool bIgnoreRigidBodyPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bOrientOnSlope
    /// </summary>
    public unsafe bool bOrientOnSlope
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreEncroachers
    /// </summary>
    public unsafe bool bIgnoreEncroachers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bDestroyedByInterpActor
    /// </summary>
    public unsafe bool bDestroyedByInterpActor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bRouteBeginPlayEvenIfStatic
    /// </summary>
    public unsafe bool bRouteBeginPlayEvenIfStatic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bIsMoving
    /// </summary>
    public unsafe bool bIsMoving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysEncroachCheck
    /// </summary>
    public unsafe bool bAlwaysEncroachCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bHasAlternateTargetLocation
    /// </summary>
    public unsafe bool bHasAlternateTargetLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bCanStepUpOn
    /// </summary>
    public unsafe bool bCanStepUpOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bAICanStepUpOn
    /// </summary>
    public unsafe bool bAICanStepUpOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bNetTemporary
    /// </summary>
    public unsafe bool bNetTemporary
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bOnlyRelevantToOwner
    /// </summary>
    public unsafe bool bOnlyRelevantToOwner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bNetDirty
    /// </summary>
    public unsafe bool bNetDirty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysRelevant
    /// </summary>
    public unsafe bool bAlwaysRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bReplicateInstigator
    /// </summary>
    public unsafe bool bReplicateInstigator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bReplicateMovement
    /// </summary>
    public unsafe bool bReplicateMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bSkipActorPropertyReplication
    /// </summary>
    public unsafe bool bSkipActorPropertyReplication
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bUpdateSimulatedPosition
    /// </summary>
    public unsafe bool bUpdateSimulatedPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bTearOff
    /// </summary>
    public unsafe bool bTearOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bOnlyDirtyReplication
    /// </summary>
    public unsafe bool bOnlyDirtyReplication
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bAllowFluidSurfaceInteraction
    /// </summary>
    public unsafe bool bAllowFluidSurfaceInteraction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bDemoRecording
    /// </summary>
    public unsafe bool bDemoRecording
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bDemoOwner
    /// </summary>
    public unsafe bool bDemoOwner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bForceDemoRelevant
    /// </summary>
    public unsafe bool bForceDemoRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bNetInitialRotation
    /// </summary>
    public unsafe bool bNetInitialRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bReplicateRigidBodyLocation
    /// </summary>
    public unsafe bool bReplicateRigidBodyLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bKillDuringLevelTransition
    /// </summary>
    public unsafe bool bKillDuringLevelTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bExchangedRoles
    /// </summary>
    public unsafe bool bExchangedRoles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bConsiderAllStaticMeshComponentsForStreaming
    /// </summary>
    public unsafe bool bConsiderAllStaticMeshComponentsForStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bDebug
    /// </summary>
    public unsafe bool bDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bPostRenderIfNotVisible
    /// </summary>
    public unsafe bool bPostRenderIfNotVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bAllowActorThoughts
    /// </summary>
    public unsafe bool bAllowActorThoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bAllowTwoWayEncroach
    /// </summary>
    public unsafe bool bAllowTwoWayEncroach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bAllowDisableRigidBody
    /// </summary>
    public unsafe bool bAllowDisableRigidBody
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bEnableOptionalRBCollision
    /// </summary>
    public unsafe bool bEnableOptionalRBCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bForceSetAnimPositionInMatinee
    /// </summary>
    public unsafe bool bForceSetAnimPositionInMatinee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bIsRoad
    /// </summary>
    public unsafe bool bIsRoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bIsTunnel
    /// </summary>
    public unsafe bool bIsTunnel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bIsTrainTracks
    /// </summary>
    public unsafe bool bIsTrainTracks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bIsVehicleJumpRamp
    /// </summary>
    public unsafe bool bIsVehicleJumpRamp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bNoBatmobileImpactSparks
    /// </summary>
    public unsafe bool bNoBatmobileImpactSparks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bForceNetUpdate
    /// </summary>
    public unsafe bool bForceNetUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bLightsUpdateLastRenderTime
    /// </summary>
    public unsafe bool bLightsUpdateLastRenderTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bManualPerformPhysics
    /// </summary>
    public unsafe bool bManualPerformPhysics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bHardAttach
    /// </summary>
    public unsafe bool bHardAttach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bSnapAttach
    /// </summary>
    public unsafe bool bSnapAttach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreBaseRotation
    /// </summary>
    public unsafe bool bIgnoreBaseRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bBasedActorsNoMove
    /// </summary>
    public unsafe bool bBasedActorsNoMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bSkipAttachedMoves
    /// </summary>
    public unsafe bool bSkipAttachedMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bCanBeAdheredTo
    /// </summary>
    public unsafe bool bCanBeAdheredTo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCanBeFrictionedTo
    /// </summary>
    public unsafe bool bCanBeFrictionedTo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bHurtEntry
    /// </summary>
    public unsafe bool bHurtEntry
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bGameRelevant
    /// </summary>
    public unsafe bool bGameRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bMovable
    /// </summary>
    public unsafe bool bMovable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bDestroyInPainVolume
    /// </summary>
    public unsafe bool bDestroyInPainVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCanBeDamaged
    /// </summary>
    public unsafe bool bCanBeDamaged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bShouldBaseAtStartup
    /// </summary>
    public unsafe bool bShouldBaseAtStartup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bPendingDelete
    /// </summary>
    public unsafe bool bPendingDelete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCanTeleport
    /// </summary>
    public unsafe bool bCanTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysTick
    /// </summary>
    public unsafe bool bAlwaysTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bBlocksNavigation
    /// </summary>
    public unsafe bool bBlocksNavigation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bInvalidateParentLODOnRemove
    /// </summary>
    public unsafe bool bInvalidateParentLODOnRemove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: BlockRigidBody
    /// </summary>
    public unsafe bool BlockRigidBody
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideWhenPlacing
    /// </summary>
    public unsafe bool bCollideWhenPlacing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideActors
    /// </summary>
    public unsafe bool bCollideActors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideActorsInitial
    /// </summary>
    public unsafe bool bCollideActorsInitial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideWorld
    /// </summary>
    public unsafe bool bCollideWorld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideComplex
    /// </summary>
    public unsafe bool bCollideComplex
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bBlockActors
    /// </summary>
    public unsafe bool bBlockActors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bProjTarget
    /// </summary>
    public unsafe bool bProjTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bBlocksTeleport
    /// </summary>
    public unsafe bool bBlocksTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bPlayerMovementCheck
    /// </summary>
    public unsafe bool bPlayerMovementCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bMoveCollidesWithDynamicApexChunks
    /// </summary>
    public unsafe bool bMoveCollidesWithDynamicApexChunks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bProjectileMoveSingleBlocking
    /// </summary>
    public unsafe bool bProjectileMoveSingleBlocking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bForceNoVolumeTrace
    /// </summary>
    public unsafe bool bForceNoVolumeTrace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bNoEncroachCheck
    /// </summary>
    public unsafe bool bNoEncroachCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideAsEncroacher
    /// </summary>
    public unsafe bool bCollideAsEncroacher
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bPhysRigidBodyOutOfWorldCheck
    /// </summary>
    public unsafe bool bPhysRigidBodyOutOfWorldCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bComponentOutsideWorld
    /// </summary>
    public unsafe bool bComponentOutsideWorld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bForceOctreeSNFilter
    /// </summary>
    public unsafe bool bForceOctreeSNFilter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bForceOctreeMNFilter
    /// </summary>
    public unsafe bool bForceOctreeMNFilter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bRigidBodyWasAwake
    /// </summary>
    public unsafe bool bRigidBodyWasAwake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bCallRigidBodyWakeEvents
    /// </summary>
    public unsafe bool bCallRigidBodyWakeEvents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreHurtRadiusLosCheck
    /// </summary>
    public unsafe bool bIgnoreHurtRadiusLosCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bBounce
    /// </summary>
    public unsafe bool bBounce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bJustTeleported
    /// </summary>
    public unsafe bool bJustTeleported
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bEnableMobileTouch
    /// </summary>
    public unsafe bool bEnableMobileTouch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bNetInitial
    /// </summary>
    public unsafe bool bNetInitial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bNetOwner
    /// </summary>
    public unsafe bool bNetOwner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bOwnerAlwaysReplicated
    /// </summary>
    public unsafe bool bOwnerAlwaysReplicated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEd
    /// </summary>
    public unsafe bool bHiddenEd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bEditable
    /// </summary>
    public unsafe bool bEditable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEdGroup
    /// </summary>
    public unsafe bool bHiddenEdGroup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEdLayer
    /// </summary>
    public unsafe bool bHiddenEdLayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEdCustom
    /// </summary>
    public unsafe bool bHiddenEdCustom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEdTemporary
    /// </summary>
    public unsafe bool bHiddenEdTemporary
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEdLevel
    /// </summary>
    public unsafe bool bHiddenEdLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEdScene
    /// </summary>
    public unsafe bool bHiddenEdScene
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bEdShouldSnap
    /// </summary>
    public unsafe bool bEdShouldSnap
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bTempEditor
    /// </summary>
    public unsafe bool bTempEditor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bPathColliding
    /// </summary>
    public unsafe bool bPathColliding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreStaticForPathBuilding
    /// </summary>
    public unsafe bool bIgnoreStaticForPathBuilding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bPathTemp
    /// </summary>
    public unsafe bool bPathTemp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bScriptInitialized
    /// </summary>
    public unsafe bool bScriptInitialized
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bLockLocation
    /// </summary>
    public unsafe bool bLockLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bForceAllowKismetModification
    /// </summary>
    public unsafe bool bForceAllowKismetModification
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bStripThisActorWhenCooking
    /// </summary>
    public unsafe bool bStripThisActorWhenCooking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bEdCanScale
    /// </summary>
    public unsafe bool bEdCanScale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bEdCanNonUniformScale
    /// </summary>
    public unsafe bool bEdCanNonUniformScale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bEdCanNegativeScale
    /// </summary>
    public unsafe bool bEdCanNegativeScale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bDonePostBeginPlay
    /// </summary>
    public unsafe bool bDonePostBeginPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bBatmanCanClimb
    /// </summary>
    public unsafe bool bBatmanCanClimb
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bAllowSlopedEdges
    /// </summary>
    public unsafe bool bAllowSlopedEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bAllowCrevice
    /// </summary>
    public unsafe bool bAllowCrevice
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bAutoGrapplePoints
    /// </summary>
    public unsafe bool bAutoGrapplePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bAutoGrapplePointsAreLowPriority
    /// </summary>
    public unsafe bool bAutoGrapplePointsAreLowPriority
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bAutoGrapplePointsAllowSwinging
    /// </summary>
    public unsafe bool bAutoGrapplePointsAllowSwinging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: CanAlwaysLinkEdges
    /// </summary>
    public unsafe bool CanAlwaysLinkEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bDisallowShimmy
    /// </summary>
    public unsafe bool bDisallowShimmy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bAllowNarrowAutoGrappleForConcaveEdge
    /// </summary>
    public unsafe bool bAllowNarrowAutoGrappleForConcaveEdge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bValidLineLauncherTarget
    /// </summary>
    public unsafe bool bValidLineLauncherTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bValidGelTarget
    /// </summary>
    public unsafe bool bValidGelTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bPlayerAlwaysSlidesOff
    /// </summary>
    public unsafe bool bPlayerAlwaysSlidesOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bCurrentInvestigateHightlighted
    /// </summary>
    public unsafe bool bCurrentInvestigateHightlighted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: CachedInvestigateSightCheck
    /// </summary>
    public unsafe bool CachedInvestigateSightCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreLOSCheck
    /// </summary>
    public unsafe bool bIgnoreLOSCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bDebugEffectIsRelevant
    /// </summary>
    public unsafe bool bDebugEffectIsRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bUpdateComponentsInPriorityOrder
    /// </summary>
    public unsafe bool bUpdateComponentsInPriorityOrder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bHasAPEXCloth
    /// </summary>
    public unsafe bool bHasAPEXCloth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// FloatProperty: HighResTextureStreamingOverrideTimestamp
    /// </summary>
    public unsafe float HighResTextureStreamingOverrideTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ByteProperty: HideOnChapterCondition
    /// </summary>
    public unsafe BmSDK.Engine.Actor.EHideRule HideOnChapterCondition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.EHideRule>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// ByteProperty: HideOnSideStory
    /// </summary>
    public unsafe BmSDK.Engine.Actor.ESideStory HideOnSideStory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.ESideStory>(Ptr + 281); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 281); }
    }

    /// <summary>
    /// ByteProperty: HideOnSideStoryCondition
    /// </summary>
    public unsafe BmSDK.Engine.Actor.EHideRule HideOnSideStoryCondition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.EHideRule>(Ptr + 282); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 282); }
    }

    /// <summary>
    /// ByteProperty: Physics
    /// </summary>
    public unsafe BmSDK.Engine.Actor.EPhysics Physics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.EPhysics>(Ptr + 283); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 283); }
    }

    /// <summary>
    /// ByteProperty: HideOnSideStoryInitialPhysics
    /// </summary>
    public unsafe BmSDK.Engine.Actor.EPhysics HideOnSideStoryInitialPhysics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.EPhysics>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ByteProperty: RemoteRole
    /// </summary>
    public unsafe BmSDK.Engine.Actor.ENetRole RemoteRole
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.ENetRole>(Ptr + 285); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 285); }
    }

    /// <summary>
    /// ByteProperty: Role
    /// </summary>
    public unsafe BmSDK.Engine.Actor.ENetRole Role
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.ENetRole>(Ptr + 286); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 286); }
    }

    /// <summary>
    /// ByteProperty: CollisionFilter
    /// </summary>
    public unsafe BmSDK.Component.ECollisionFilter CollisionFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Component.ECollisionFilter>(Ptr + 287); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 287); }
    }

    /// <summary>
    /// ByteProperty: CollisionType
    /// </summary>
    public unsafe BmSDK.Engine.Actor.ECollisionType CollisionType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.ECollisionType>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// ByteProperty: ReplicatedCollisionType
    /// </summary>
    public unsafe BmSDK.Engine.Actor.ECollisionType ReplicatedCollisionType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.ECollisionType>(Ptr + 289); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 289); }
    }

    /// <summary>
    /// ByteProperty: TickGroup
    /// </summary>
    public unsafe BmSDK.GameObject.ETickingGroup TickGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.ETickingGroup>(Ptr + 290); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 290); }
    }

    /// <summary>
    /// StructProperty: DetachFence
    /// </summary>
    public unsafe ref BmSDK.GameObject.FRenderCommandFence DetachFence
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FRenderCommandFence>(Ptr + 292);

    /// <summary>
    /// ArrayProperty: Timers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor.FTimerData> Timers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FTimerData>>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// IntProperty: EditorTrackingVal
    /// </summary>
    public unsafe int EditorTrackingVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// StructProperty: TickedFrame
    /// </summary>
    public unsafe ulong TickedFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<ulong>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// IntProperty: ChunkyTick_DeferredNumFrames
    /// </summary>
    public unsafe int ChunkyTick_DeferredNumFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// FloatProperty: ChunkyTick_DeferredDeltaSeconds
    /// </summary>
    public unsafe float ChunkyTick_DeferredDeltaSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// StrProperty: LastEdit
    /// </summary>
    public unsafe BmSDK.FString LastEdit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// FloatProperty: LifeSpan
    /// </summary>
    public unsafe float LifeSpan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// StructProperty: CanTraceActorBlockedTypes
    /// </summary>
    public unsafe ref BmSDK.Engine.Actor.FBlockingVolumeTypesContainer CanTraceActorBlockedTypes
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.Actor.FBlockingVolumeTypesContainer>(Ptr + 352);

    /// <summary>
    /// FloatProperty: LastRenderTime
    /// </summary>
    public unsafe float LastRenderTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// NameProperty: Tag
    /// </summary>
    public unsafe BmSDK.FName Tag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// NameProperty: Layer
    /// </summary>
    public unsafe BmSDK.FName Layer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// NameProperty: Group
    /// </summary>
    public unsafe BmSDK.FName Group
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// StructProperty: HiddenEditorViews
    /// </summary>
    public unsafe ulong HiddenEditorViews
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<ulong>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ArrayProperty: Touching
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> Touching
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ArrayProperty: Children
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> Children
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// FloatProperty: LatentFloat
    /// </summary>
    public unsafe float LatentFloat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// ArrayProperty: PendingTouches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor.FPendingTouch> PendingTouches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FPendingTouch>>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// StructProperty: Velocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Velocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 444);

    /// <summary>
    /// StructProperty: Acceleration
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Acceleration
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 456);

    /// <summary>
    /// StructProperty: AngularVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AngularVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 468);

    /// <summary>
    /// NameProperty: BaseBoneName
    /// </summary>
    public unsafe BmSDK.FName BaseBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ArrayProperty: Attached
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> Attached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// StructProperty: RelativeLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RelativeLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 504);

    /// <summary>
    /// StructProperty: RelativeRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator RelativeRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 516);

    /// <summary>
    /// IntProperty: OverlapTag
    /// </summary>
    public unsafe int OverlapTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// StructProperty: RotationRate
    /// </summary>
    public unsafe ref BmSDK.Rotator RotationRate
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 532);

    /// <summary>
    /// ArrayProperty: SupportedEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> SupportedEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ArrayProperty: GeneratedEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceEvent> GeneratedEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceEvent>>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ArrayProperty: DuplicatedEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceEvent> DuplicatedEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceEvent>>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// ArrayProperty: LatentActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SeqAct_Latent> LatentActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SeqAct_Latent>>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// FloatProperty: InvestigationMaxDistance
    /// </summary>
    public unsafe float InvestigationMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ArrayProperty: InvestigationDataArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor.FInvestigationData> InvestigationDataArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FInvestigationData>>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// FloatProperty: InvestigationPriorityOverride
    /// </summary>
    public unsafe float InvestigationPriorityOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: CachedInvestigateTimestamp
    /// </summary>
    public unsafe float CachedInvestigateTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: CachedInvestigateUrgency
    /// </summary>
    public unsafe float CachedInvestigateUrgency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// StructProperty: InvestigateOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 InvestigateOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 640);

    /// <summary>
    /// ArrayProperty: PendingASyncLoads
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> PendingASyncLoads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// Struct: FBlockingVolumeTypesContainer
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FBlockingVolumeTypesContainer
    {
        /// <summary>
        /// BoolProperty: AllActors
        /// </summary>
        public unsafe bool AllActors
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Player
        /// </summary>
        public unsafe bool Player
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Enemies
        /// </summary>
        public unsafe bool Enemies
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Friendlies
        /// </summary>
        public unsafe bool Friendlies
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Physics
        /// </summary>
        public unsafe bool Physics
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Batarang
        /// </summary>
        public unsafe bool Batarang
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: BatClaw
        /// </summary>
        public unsafe bool BatClaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: LineLauncher
        /// </summary>
        public unsafe bool LineLauncher
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: GrappleGun
        /// </summary>
        public unsafe bool GrappleGun
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 256) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Camera
        /// </summary>
        public unsafe bool Camera
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 512) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: WeaponsOrLOS
        /// </summary>
        public unsafe bool WeaponsOrLOS
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1024) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: MagneticObjects
        /// </summary>
        public unsafe bool MagneticObjects
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2048) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: ClimbOnly
        /// </summary>
        public unsafe bool ClimbOnly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4096) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: IgnoreWallPounces
        /// </summary>
        public unsafe bool IgnoreWallPounces
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8192) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: FreezeGrenades
        /// </summary>
        public unsafe bool FreezeGrenades
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16384) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: SmokeBomb
        /// </summary>
        public unsafe bool SmokeBomb
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 32768) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: REC
        /// </summary>
        public unsafe bool REC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 65536) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FThought
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FThought
    {
        /// <summary>
        /// StrProperty: Text
        /// </summary>
        public unsafe BmSDK.FString Text
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: Red
        /// </summary>
        public unsafe byte Red
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: Green
        /// </summary>
        public unsafe byte Green
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 17); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 17); }; }
        }

        /// <summary>
        /// ByteProperty: Blue
        /// </summary>
        public unsafe byte Blue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 18); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18); }; }
        }

        /// <summary>
        /// ByteProperty: Alpha
        /// </summary>
        public unsafe byte Alpha
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 19); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19); }; }
        }

        /// <summary>
        /// ArrayProperty: DetailThoughts
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.Actor.FDetailThought> DetailThoughts
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FDetailThought>>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FDetailThought
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FDetailThought
    {
        /// <summary>
        /// StrProperty: Text
        /// </summary>
        public unsafe BmSDK.FString Text
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: Red
        /// </summary>
        public unsafe byte Red
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: Green
        /// </summary>
        public unsafe byte Green
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 17); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 17); }; }
        }

        /// <summary>
        /// ByteProperty: Blue
        /// </summary>
        public unsafe byte Blue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 18); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18); }; }
        }

        /// <summary>
        /// ByteProperty: Alpha
        /// </summary>
        public unsafe byte Alpha
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 19); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19); }; }
        }
    }

    /// <summary>
    /// Enum: EThoughtGroup
    /// </summary>
    public enum EThoughtGroup : byte
    {
        THOUGHTGROUP_Player = 0,
        THOUGHTGROUP_AI = 1,
        THOUGHTGROUP_Cinematic = 2,
        THOUGHTGROUP_Vehicle = 3,
        THOUGHTGROUP_Batmobile = 4,
        THOUGHTGROUP_MAX = 5,
    }
}
