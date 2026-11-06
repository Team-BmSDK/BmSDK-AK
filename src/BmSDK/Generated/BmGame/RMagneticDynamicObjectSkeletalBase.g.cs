#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RMagneticDynamicObjectSkeletalBase<br/>
/// (size = 772)
/// (flags = 144703634)
/// </summary>
public partial class RMagneticDynamicObjectSkeletalBase : BmSDK.Engine.SkeletalMeshActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RMagneticDynamicObjectSkeletalBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RMagneticDynamicObjectSkeletalBase.
    /// </summary>
    public static RMagneticDynamicObjectSkeletalBase DefaultObject => (RMagneticDynamicObjectSkeletalBase)StaticClass().DefaultObject;

    internal RMagneticDynamicObjectSkeletalBase() { }

    /// <summary>
    /// Constructs a new RMagneticDynamicObjectSkeletalBase
    /// </summary>
    public RMagneticDynamicObjectSkeletalBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMagneticDynamicObjectSkeletalBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticDynamicObjectSkeletalBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticDynamicObjectSkeletalBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticDynamicObjectSkeletalBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticDynamicObjectSkeletalBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticDynamicObjectSkeletalBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticDynamicObjectSkeletalBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticDynamicObjectSkeletalBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticDynamicObjectSkeletalBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObstacleActor;
    /// <summary>
    /// Function: GetObstacleActor
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetObstacleActor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObstacleActor, "BmGame.RMagneticDynamicObjectSkeletalBase.GetObstacleActor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsValidTargetComp;
    /// <summary>
    /// Function: IsValidTargetComp
    /// </summary>
    public unsafe virtual bool IsValidTargetComp(BmSDK.Engine.PrimitiveComponent TargetComp)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidTargetComp, "BmGame.RMagneticDynamicObjectSkeletalBase.IsValidTargetComp");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetComp, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetMagTargetTangent;
    /// <summary>
    /// Function: GetMagTargetTangent
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetMagTargetTangent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMagTargetTangent, "BmGame.RMagneticDynamicObjectSkeletalBase.GetMagTargetTangent");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMotorActivationFXLocation;
    /// <summary>
    /// Function: GetMotorActivationFXLocation
    /// </summary>
    public unsafe virtual void GetMotorActivationFXLocation(BmSDK.Engine.PrimitiveComponent MotorComp, out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Normal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMotorActivationFXLocation, "BmGame.RMagneticDynamicObjectSkeletalBase.GetMotorActivationFXLocation");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MotorComp, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
        Normal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_IsDoorOpen;
    /// <summary>
    /// Function: IsDoorOpen
    /// </summary>
    public unsafe virtual bool IsDoorOpen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDoorOpen, "BmGame.RMagneticDynamicObjectSkeletalBase.IsDoorOpen");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HitByREC;
    /// <summary>
    /// Function: HitByREC
    /// </summary>
    public unsafe virtual bool HitByREC(System.Numerics.Vector3 HitLoc, BmSDK.Engine.PrimitiveComponent OtherComp, BmSDK.BmGame.RMagneticBlast.MBImpulseType ImpulseType, BmSDK.BmGame.RMagneticBlastReceiver RECProjectile)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByREC, "BmGame.RMagneticDynamicObjectSkeletalBase.HitByREC");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpulseType, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RECProjectile, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetAutoTargetLocation;
    /// <summary>
    /// Function: GetAutoTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAutoTargetLocation(System.Numerics.Vector3 PlayerPosition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAutoTargetLocation, "BmGame.RMagneticDynamicObjectSkeletalBase.GetAutoTargetLocation");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPosition, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CanRECAutoTarget;
    /// <summary>
    /// Function: CanRECAutoTarget
    /// </summary>
    public unsafe virtual bool CanRECAutoTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanRECAutoTarget, "BmGame.RMagneticDynamicObjectSkeletalBase.CanRECAutoTarget");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsSecondaryTarget;
    /// <summary>
    /// Function: IsSecondaryTarget
    /// </summary>
    public unsafe virtual bool IsSecondaryTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSecondaryTarget, "BmGame.RMagneticDynamicObjectSkeletalBase.IsSecondaryTarget");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsMagActive;
    /// <summary>
    /// Function: IsMagActive
    /// </summary>
    public unsafe virtual bool IsMagActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMagActive, "BmGame.RMagneticDynamicObjectSkeletalBase.IsMagActive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMagLocation;
    /// <summary>
    /// Function: GetMagLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetMagLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMagLocation, "BmGame.RMagneticDynamicObjectSkeletalBase.GetMagLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RMagneticDynamicObjectSkeletalBase.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMagnetStrength;
    /// <summary>
    /// Function: SetMagnetStrength
    /// </summary>
    public unsafe virtual float SetMagnetStrength(BmSDK.BmGame.RMagneticBlastReceiver REC, float MagStr, System.Numerics.Vector3 MagPos, float DeltaTime, bool bInitialImpulse, BmSDK.BmGame.RMagneticSurfaceSMBase Surface)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMagnetStrength, "BmGame.RMagneticDynamicObjectSkeletalBase.SetMagnetStrength");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(REC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MagStr, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MagPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInitialImpulse, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Surface, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetActor;
    /// <summary>
    /// Function: GetActor
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetActor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActor, "BmGame.RMagneticDynamicObjectSkeletalBase.GetActor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPlayingAnim;
    /// <summary>
    /// Function: IsPlayingAnim
    /// </summary>
    public unsafe virtual bool IsPlayingAnim(BmSDK.FName AnimName = default, bool bCheckBlendOutPoint = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayingAnim, "BmGame.RMagneticDynamicObjectSkeletalBase.IsPlayingAnim");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckBlendOutPoint, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetFXLocation;
    /// <summary>
    /// Function: SetFXLocation
    /// </summary>
    public unsafe virtual void SetFXLocation(BmSDK.Engine.PrimitiveComponent MotorComp)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFXLocation, "BmGame.RMagneticDynamicObjectSkeletalBase.SetFXLocation");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MotorComp, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RMagneticDynamicObjectSkeletalBase.Destroyed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RMagneticDynamicObjectSkeletalBase.PreStreamOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RMagneticDynamicObjectSkeletalBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBlendingOut;
    /// <summary>
    /// Function: IsBlendingOut
    /// </summary>
    public unsafe virtual bool IsBlendingOut(BmSDK.Engine.AnimNodeSequence AnimNode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBlendingOut, "BmGame.RMagneticDynamicObjectSkeletalBase.IsBlendingOut");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimNode, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UnRegisterObstacle;
    /// <summary>
    /// Function: UnRegisterObstacle
    /// </summary>
    public unsafe virtual void UnRegisterObstacle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnRegisterObstacle, "BmGame.RMagneticDynamicObjectSkeletalBase.UnRegisterObstacle");
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

    private static BmSDK.Function __fn_RegisterObstacle;
    /// <summary>
    /// Function: RegisterObstacle
    /// </summary>
    public unsafe virtual void RegisterObstacle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterObstacle, "BmGame.RMagneticDynamicObjectSkeletalBase.RegisterObstacle");
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

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavMeshPathObstacle
    /// </summary>
    public unsafe System.IntPtr VfTable_IInterface_NavMeshPathObstacle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: LastMagStr
    /// </summary>
    public unsafe float LastMagStr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: MinMagStrength
    /// </summary>
    public unsafe float MinMagStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bNeedsMaterialUpdate
    /// </summary>
    public unsafe bool bNeedsMaterialUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bMagActive
    /// </summary>
    public unsafe bool bMagActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bUseAutomaticNavMeshObstacle
    /// </summary>
    public unsafe bool bUseAutomaticNavMeshObstacle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// ComponentProperty: MovingFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MovingFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ComponentProperty: JammedFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent JammedFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }
}
