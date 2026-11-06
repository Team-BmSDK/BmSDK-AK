#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RMagneticSurfaceSMBase<br/>
/// (size = 1024)
/// (flags = 144703634)
/// </summary>
public partial class RMagneticSurfaceSMBase : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RMagneticSurfaceSMBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RMagneticSurfaceSMBase.
    /// </summary>
    public static RMagneticSurfaceSMBase DefaultObject => (RMagneticSurfaceSMBase)StaticClass().DefaultObject;

    internal RMagneticSurfaceSMBase() { }

    /// <summary>
    /// Constructs a new RMagneticSurfaceSMBase
    /// </summary>
    public RMagneticSurfaceSMBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMagneticSurfaceSMBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticSurfaceSMBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticSurfaceSMBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticSurfaceSMBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticSurfaceSMBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticSurfaceSMBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticSurfaceSMBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticSurfaceSMBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticSurfaceSMBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetRTPromptOverride;
    /// <summary>
    /// Function: GetRTPromptOverride
    /// </summary>
    public unsafe virtual BmSDK.FString GetRTPromptOverride()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRTPromptOverride, "BmGame.RMagneticSurfaceSMBase.GetRTPromptOverride");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRBPromptOverride;
    /// <summary>
    /// Function: GetRBPromptOverride
    /// </summary>
    public unsafe virtual BmSDK.FString GetRBPromptOverride()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRBPromptOverride, "BmGame.RMagneticSurfaceSMBase.GetRBPromptOverride");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OverrideRECPrompts;
    /// <summary>
    /// Function: OverrideRECPrompts
    /// </summary>
    public unsafe virtual bool OverrideRECPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideRECPrompts, "BmGame.RMagneticSurfaceSMBase.OverrideRECPrompts");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HitByREC;
    /// <summary>
    /// Function: HitByREC
    /// </summary>
    public unsafe virtual void HitByREC(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByREC, "BmGame.RMagneticSurfaceSMBase.HitByREC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMagneticBlastReceiverHomingLocation;
    /// <summary>
    /// Function: GetMagneticBlastReceiverHomingLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetMagneticBlastReceiverHomingLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMagneticBlastReceiverHomingLocation, "BmGame.RMagneticSurfaceSMBase.GetMagneticBlastReceiverHomingLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EmergencyStop;
    /// <summary>
    /// Function: EmergencyStop
    /// </summary>
    public unsafe virtual bool EmergencyStop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EmergencyStop, "BmGame.RMagneticSurfaceSMBase.EmergencyStop");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetFXLocation;
    /// <summary>
    /// Function: SetFXLocation
    /// </summary>
    public unsafe virtual void SetFXLocation(BmSDK.Engine.PrimitiveComponent MotorComp)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFXLocation, "BmGame.RMagneticSurfaceSMBase.SetFXLocation");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MotorComp, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBlockingPlayerInteraction;
    /// <summary>
    /// Function: IsBlockingPlayerInteraction
    /// </summary>
    public unsafe virtual bool IsBlockingPlayerInteraction(BmSDK.BmGame.RPawnPlayer Player, bool bDebugDraw = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBlockingPlayerInteraction, "BmGame.RMagneticSurfaceSMBase.IsBlockingPlayerInteraction");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetMotorActivationFXLocation;
    /// <summary>
    /// Function: GetMotorActivationFXLocation
    /// </summary>
    public unsafe virtual void GetMotorActivationFXLocation(BmSDK.Engine.PrimitiveComponent MotorComp, out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Normal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMotorActivationFXLocation, "BmGame.RMagneticSurfaceSMBase.GetMotorActivationFXLocation");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MotorComp, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Normal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Normal, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
        Normal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_UnlinkToActor;
    /// <summary>
    /// Function: UnlinkToActor
    /// </summary>
    public unsafe override bool UnlinkToActor(BmSDK.Engine.Actor LinkTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlinkToActor, "BmGame.RMagneticSurfaceSMBase.UnlinkToActor");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_LinkToActor;
    /// <summary>
    /// Function: LinkToActor
    /// </summary>
    public unsafe override bool LinkToActor(BmSDK.Engine.Actor LinkTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LinkToActor, "BmGame.RMagneticSurfaceSMBase.LinkToActor");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsCharged;
    /// <summary>
    /// Function: IsCharged
    /// </summary>
    public unsafe virtual bool IsCharged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCharged, "BmGame.RMagneticSurfaceSMBase.IsCharged");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetClosestPoint;
    /// <summary>
    /// Function: GetClosestPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetClosestPoint(System.Numerics.Vector3 TestPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestPoint, "BmGame.RMagneticSurfaceSMBase.GetClosestPoint");
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetInvestigateHighlighted;
    /// <summary>
    /// Function: SetInvestigateHighlighted
    /// </summary>
    public unsafe override void SetInvestigateHighlighted(BmSDK.Engine.MaterialInstanceConstant highMat, bool On)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInvestigateHighlighted, "BmGame.RMagneticSurfaceSMBase.SetInvestigateHighlighted");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(highMat, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RMagneticSurfaceSMBase.Tick");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StressTest;
    /// <summary>
    /// Function: StressTest
    /// </summary>
    public unsafe virtual void StressTest()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StressTest, "BmGame.RMagneticSurfaceSMBase.StressTest");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_converge;
    /// <summary>
    /// Function: converge
    /// </summary>
    public unsafe virtual void converge(out float Value, float Target, float Speed, float Tolerance = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_converge, "BmGame.RMagneticSurfaceSMBase.converge");
        byte* paramsPtr = stackalloc byte[20];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Value);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Tolerance, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Value = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_HitWhileDeactivated;
    /// <summary>
    /// Function: HitWhileDeactivated
    /// </summary>
    public unsafe virtual void HitWhileDeactivated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitWhileDeactivated, "BmGame.RMagneticSurfaceSMBase.HitWhileDeactivated");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Recover;
    /// <summary>
    /// Function: Recover
    /// </summary>
    public unsafe virtual void Recover()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Recover, "BmGame.RMagneticSurfaceSMBase.Recover");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRecoveryTime;
    /// <summary>
    /// Function: SetRecoveryTime
    /// </summary>
    public unsafe virtual void SetRecoveryTime(float RecoveryTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRecoveryTime, "BmGame.RMagneticSurfaceSMBase.SetRecoveryTime");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RecoveryTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMagStr;
    /// <summary>
    /// Function: SetMagStr
    /// </summary>
    public unsafe virtual void SetMagStr(float NewStr, bool bInitialFrame, BmSDK.BmGame.RPawnPlayer Player, BmSDK.BmGame.RMagneticSurfaceSMBase CallFromMaster = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMagStr, "BmGame.RMagneticSurfaceSMBase.SetMagStr");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStr, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInitialFrame, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CallFromMaster, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopMotor;
    /// <summary>
    /// Function: StopMotor
    /// </summary>
    public unsafe virtual void StopMotor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopMotor, "BmGame.RMagneticSurfaceSMBase.StopMotor");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayMotorDown;
    /// <summary>
    /// Function: PlayMotorDown
    /// </summary>
    public unsafe virtual void PlayMotorDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayMotorDown, "BmGame.RMagneticSurfaceSMBase.PlayMotorDown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayMotorUp;
    /// <summary>
    /// Function: PlayMotorUp
    /// </summary>
    public unsafe virtual void PlayMotorUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayMotorUp, "BmGame.RMagneticSurfaceSMBase.PlayMotorUp");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInfluencedVillains;
    /// <summary>
    /// Function: GetInfluencedVillains
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RPawnVillain> GetInfluencedVillains(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInfluencedVillains, "BmGame.RMagneticSurfaceSMBase.GetInfluencedVillains");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetBeamEffectsTargets;
    /// <summary>
    /// Function: GetBeamEffectsTargets
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.Engine.Actor> GetBeamEffectsTargets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBeamEffectsTargets, "BmGame.RMagneticSurfaceSMBase.GetBeamEffectsTargets");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInfluencedDynamicObjects;
    /// <summary>
    /// Function: GetInfluencedDynamicObjects
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RMagneticBlastInterface> GetInfluencedDynamicObjects(bool bInitialFrame)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInfluencedDynamicObjects, "BmGame.RMagneticSurfaceSMBase.GetInfluencedDynamicObjects");
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInitialFrame, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RMagneticBlastInterface>>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetAccumulatedMagStr;
    /// <summary>
    /// Function: GetAccumulatedMagStr
    /// </summary>
    public unsafe virtual float GetAccumulatedMagStr()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAccumulatedMagStr, "BmGame.RMagneticSurfaceSMBase.GetAccumulatedMagStr");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMasterGenerator;
    /// <summary>
    /// Function: GetMasterGenerator
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RMagneticSurfaceSMBase GetMasterGenerator()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMasterGenerator, "BmGame.RMagneticSurfaceSMBase.GetMasterGenerator");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticSurfaceSMBase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearMatinee;
    /// <summary>
    /// Function: ClearMatinee
    /// </summary>
    public unsafe virtual void ClearMatinee()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearMatinee, "BmGame.RMagneticSurfaceSMBase.ClearMatinee");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMatinee;
    /// <summary>
    /// Function: SetMatinee
    /// </summary>
    public unsafe virtual void SetMatinee(BmSDK.Engine.SeqAct_Interp M)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMatinee, "BmGame.RMagneticSurfaceSMBase.SetMatinee");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(M, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RMagneticSurfaceSMBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBlowUpState;
    /// <summary>
    /// Function: SetBlowUpState
    /// </summary>
    public unsafe virtual void SetBlowUpState(bool bNewBlownUp)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBlowUpState, "BmGame.RMagneticSurfaceSMBase.SetBlowUpState");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewBlownUp, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlowUp;
    /// <summary>
    /// Function: BlowUp
    /// </summary>
    public unsafe virtual void BlowUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlowUp, "BmGame.RMagneticSurfaceSMBase.BlowUp");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetActive;
    /// <summary>
    /// Function: SetActive
    /// </summary>
    public unsafe virtual void SetActive(bool _active)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetActive, "BmGame.RMagneticSurfaceSMBase.SetActive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveCurrentReceiver;
    /// <summary>
    /// Function: RemoveCurrentReceiver
    /// </summary>
    public unsafe virtual void RemoveCurrentReceiver(BmSDK.BmGame.RMagneticBlastReceiver OldReceiver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveCurrentReceiver, "BmGame.RMagneticSurfaceSMBase.RemoveCurrentReceiver");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentReceiver;
    /// <summary>
    /// Function: SetCurrentReceiver
    /// </summary>
    public unsafe virtual void SetCurrentReceiver(BmSDK.BmGame.RMagneticBlastReceiver NewReceiver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentReceiver, "BmGame.RMagneticSurfaceSMBase.SetCurrentReceiver");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnToggle;
    /// <summary>
    /// Function: OnToggle
    /// </summary>
    public unsafe virtual void OnToggle(BmSDK.Engine.SeqAct_Toggle Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggle, "BmGame.RMagneticSurfaceSMBase.OnToggle");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFOVCheckLocation;
    /// <summary>
    /// Function: GetFOVCheckLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetFOVCheckLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFOVCheckLocation, "BmGame.RMagneticSurfaceSMBase.GetFOVCheckLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAutoTargetLocation;
    /// <summary>
    /// Function: GetAutoTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAutoTargetLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAutoTargetLocation, "BmGame.RMagneticSurfaceSMBase.GetAutoTargetLocation");
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

    private static BmSDK.Function __fn_GetClosestTriangle;
    /// <summary>
    /// Function: GetClosestTriangle
    /// </summary>
    public unsafe virtual void GetClosestTriangle(System.Numerics.Vector3 P, out System.Numerics.Vector3 v0, out System.Numerics.Vector3 v1, out System.Numerics.Vector3 v2)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestTriangle, "BmGame.RMagneticSurfaceSMBase.GetClosestTriangle");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out v0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(v0, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out v1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(v1, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out v2);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(v2, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        v0 = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        v1 = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
        v2 = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 36);
        return;
    }

    private static BmSDK.Function __fn_GetMatineeLength;
    /// <summary>
    /// Function: GetMatineeLength
    /// </summary>
    public unsafe virtual float GetMatineeLength()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMatineeLength, "BmGame.RMagneticSurfaceSMBase.GetMatineeLength");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMatineePosition;
    /// <summary>
    /// Function: GetMatineePosition
    /// </summary>
    public unsafe virtual float GetMatineePosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMatineePosition, "BmGame.RMagneticSurfaceSMBase.GetMatineePosition");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StepMatinee;
    /// <summary>
    /// Function: StepMatinee
    /// </summary>
    public unsafe virtual bool StepMatinee(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StepMatinee, "BmGame.RMagneticSurfaceSMBase.StepMatinee");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateEditorComponents;
    /// <summary>
    /// Function: UpdateEditorComponents
    /// </summary>
    public unsafe virtual void UpdateEditorComponents()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateEditorComponents, "BmGame.RMagneticSurfaceSMBase.UpdateEditorComponents");
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

    private static BmSDK.Function __fn_ConvertPosToActorSpace;
    /// <summary>
    /// Function: ConvertPosToActorSpace
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 ConvertPosToActorSpace(BmSDK.Engine.Actor Object, System.Numerics.Vector3 WorldPosition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConvertPosToActorSpace, "BmGame.RMagneticSurfaceSMBase.ConvertPosToActorSpace");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Object, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldPosition, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 20);
    }

    /// <summary>
    /// Enum: EEmergencyStopMode
    /// </summary>
    public enum EEmergencyStopMode : byte
    {
        EESM_AlwaysStop = 0,
        EESM_StopWhenMatineePlaysForward = 1,
        EESM_StopWhenMatineePlaysBackward = 2,
        EESM_MAX = 3,
    }

    /// <summary>
    /// Enum: EForceFieldAxis
    /// </summary>
    public enum EForceFieldAxis : byte
    {
        EFFA_None = 0,
        EFFA_X_Axis = 1,
        EFFA_Y_Axis = 2,
        EFFA_Z_Axis = 3,
        EFFA_MAX = 4,
    }

    /// <summary>
    /// ComponentProperty: SkeletalMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent SkeletalMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ComponentProperty: DestroyedMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent DestroyedMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: BlowUpFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem BlowUpFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: BlowUpSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BlowUpSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: AreaOfInfluence
    /// </summary>
    public unsafe BmSDK.Engine.Volume AreaOfInfluence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: Matinee
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_Interp Matinee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_Interp>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: BlockPlayerInteractionVolume
    /// </summary>
    public unsafe BmSDK.Engine.Volume BlockPlayerInteractionVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: CachedInterpData
    /// </summary>
    public unsafe BmSDK.Engine.InterpData CachedInterpData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpData>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: CameraTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CameraTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: CurrentReceiver
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlastReceiver CurrentReceiver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlastReceiver>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: Master
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticSurfaceSMBase Master
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticSurfaceSMBase>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: slave
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticSurfaceSMBase slave
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticSurfaceSMBase>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: PredShootTargetPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RDummyTarget PredShootTargetPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDummyTarget>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ComponentProperty: JammedFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent JammedFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ComponentProperty: MovingFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MovingFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ComponentProperty: MagBlastInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent MagBlastInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ComponentProperty: TargetOffsetSphere
    /// </summary>
    public unsafe BmSDK.Engine.DrawSphereComponent TargetOffsetSphere
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DrawSphereComponent>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ComponentProperty: MinimumPlayerDistanceSphere
    /// </summary>
    public unsafe BmSDK.Engine.DrawSphereComponent MinimumPlayerDistanceSphere
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DrawSphereComponent>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// FloatProperty: CurrentMagStr
    /// </summary>
    public unsafe float CurrentMagStr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: AccumulatedMagStr
    /// </summary>
    public unsafe float AccumulatedMagStr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// FloatProperty: EnergyDrainPerSecond
    /// </summary>
    public unsafe float EnergyDrainPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ArrayProperty: ExtraAreasOfInfluence
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Volume> ExtraAreasOfInfluence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Volume>>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// FloatProperty: MatineeSpeed
    /// </summary>
    public unsafe float MatineeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// FloatProperty: DesiredMatineeSpeed
    /// </summary>
    public unsafe float DesiredMatineeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// FloatProperty: MatineeAttractPlaybackSpeed
    /// </summary>
    public unsafe float MatineeAttractPlaybackSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// FloatProperty: MatineeRepelPlaybackSpeed
    /// </summary>
    public unsafe float MatineeRepelPlaybackSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// FloatProperty: MatineeAttractAcceleration
    /// </summary>
    public unsafe float MatineeAttractAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// FloatProperty: MatineeRepelAcceleration
    /// </summary>
    public unsafe float MatineeRepelAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// FloatProperty: MatineeDeceleration
    /// </summary>
    public unsafe float MatineeDeceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// BoolProperty: bMatineeAutoAttract
    /// </summary>
    public unsafe bool bMatineeAutoAttract
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bMatineeAutoRepel
    /// </summary>
    public unsafe bool bMatineeAutoRepel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bBlockPlayerInteractionVolumesAlsoBlockOnSecondaryPlayer
    /// </summary>
    public unsafe bool bBlockPlayerInteractionVolumesAlsoBlockOnSecondaryPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bActive
    /// </summary>
    public unsafe bool bActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bBlownUp
    /// </summary>
    public unsafe bool bBlownUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bCameraTargetActive
    /// </summary>
    public unsafe bool bCameraTargetActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bIsCharged
    /// </summary>
    public unsafe bool bIsCharged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bUseHomingForMagneticBlastReceiver
    /// </summary>
    public unsafe bool bUseHomingForMagneticBlastReceiver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bNeedsTicking
    /// </summary>
    public unsafe bool bNeedsTicking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bNeedsMaterialUpdate
    /// </summary>
    public unsafe bool bNeedsMaterialUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bNeedsAnimationUpdate
    /// </summary>
    public unsafe bool bNeedsAnimationUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bIsMotor
    /// </summary>
    public unsafe bool bIsMotor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bOpenLeftRight
    /// </summary>
    public unsafe bool bOpenLeftRight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bMotorFlipLowerRaisePrompts
    /// </summary>
    public unsafe bool bMotorFlipLowerRaisePrompts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bForceOpenDoorPrompt
    /// </summary>
    public unsafe bool bForceOpenDoorPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bIsMagnet
    /// </summary>
    public unsafe bool bIsMagnet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bDisableUntilGiveGadget
    /// </summary>
    public unsafe bool bDisableUntilGiveGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bActivateMatineeWhenStepping
    /// </summary>
    public unsafe bool bActivateMatineeWhenStepping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bCacheDestroyGeneratorPointsDone
    /// </summary>
    public unsafe bool bCacheDestroyGeneratorPointsDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bFlipQuickFiredRECImpulses
    /// </summary>
    public unsafe bool bFlipQuickFiredRECImpulses
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bOverrideRECPrompts
    /// </summary>
    public unsafe bool bOverrideRECPrompts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bUseSpecialRiddlerMotorUI
    /// </summary>
    public unsafe bool bUseSpecialRiddlerMotorUI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// FloatProperty: OverrideMagneticChargeTime
    /// </summary>
    public unsafe float OverrideMagneticChargeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// FloatProperty: AttractForceFactor
    /// </summary>
    public unsafe float AttractForceFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// FloatProperty: RepelForceFactor
    /// </summary>
    public unsafe float RepelForceFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// FloatProperty: MinimumPlayerDistance
    /// </summary>
    public unsafe float MinimumPlayerDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ArrayProperty: BlockPlayerInteractionVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Volume> BlockPlayerInteractionVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Volume>>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// InterfaceProperty: MatineeControl
    /// </summary>
    public unsafe BmSDK.BmGame.RMatineeController MatineeControl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMatineeController>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// StructProperty: CameraTargetOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraTargetOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 920);

    /// <summary>
    /// ByteProperty: ForceFieldAxis
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticSurfaceSMBase.EForceFieldAxis ForceFieldAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticSurfaceSMBase.EForceFieldAxis>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ByteProperty: EmergencyStopMode
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticSurfaceSMBase.EEmergencyStopMode EmergencyStopMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticSurfaceSMBase.EEmergencyStopMode>(Ptr + 933); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 933); }
    }

    /// <summary>
    /// FloatProperty: RecoverTime
    /// </summary>
    public unsafe float RecoverTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// StructProperty: MagneticSourceOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MagneticSourceOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 940);

    /// <summary>
    /// ArrayProperty: BeamEffectsTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> BeamEffectsTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: InfluenceRadius
    /// </summary>
    public unsafe float InfluenceRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ArrayProperty: CachedDestroyPoints
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> CachedDestroyPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// FloatProperty: MagneticEffectsDelay
    /// </summary>
    public unsafe float MagneticEffectsDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// StrProperty: sPromptOverrideForRB
    /// </summary>
    public unsafe BmSDK.FString sPromptOverrideForRB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// StrProperty: sPromptOverrideForRT
    /// </summary>
    public unsafe BmSDK.FString sPromptOverrideForRT
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }
}
