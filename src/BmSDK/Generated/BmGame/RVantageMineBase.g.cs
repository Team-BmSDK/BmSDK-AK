#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVantageMineBase<br/>
/// (size = 856)
/// (flags = 144703634)
/// </summary>
public partial class RVantageMineBase : BmSDK.BmGame.RMineBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVantageMineBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RVantageMineBase.
    /// </summary>
    public static RVantageMineBase DefaultObject => (RVantageMineBase)StaticClass().DefaultObject;

    internal RVantageMineBase() { }

    /// <summary>
    /// Constructs a new RVantageMineBase
    /// </summary>
    public RVantageMineBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVantageMineBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVantageMineBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVantageMineBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVantageMineBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVantageMineBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVantageMineBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVantageMineBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVantageMineBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVantageMineBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetDepthPriorityGroup;
    /// <summary>
    /// Function: SetDepthPriorityGroup
    /// </summary>
    public unsafe virtual void SetDepthPriorityGroup(BmSDK.Engine.Scene.ESceneDepthPriorityGroup NewGroup)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDepthPriorityGroup, "BmGame.RVantageMineBase.SetDepthPriorityGroup");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsDisrupted;
    /// <summary>
    /// Function: IsDisrupted
    /// </summary>
    public unsafe virtual bool IsDisrupted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDisrupted, "BmGame.RVantageMineBase.IsDisrupted");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisruptorDescriptionParameters;
    /// <summary>
    /// Function: GetDisruptorDescriptionParameters
    /// </summary>
    public unsafe virtual BmSDK.FString GetDisruptorDescriptionParameters()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisruptorDescriptionParameters, "BmGame.RVantageMineBase.GetDisruptorDescriptionParameters");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RequiresDisruptorUpgrade;
    /// <summary>
    /// Function: RequiresDisruptorUpgrade
    /// </summary>
    public unsafe virtual bool RequiresDisruptorUpgrade()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequiresDisruptorUpgrade, "BmGame.RVantageMineBase.RequiresDisruptorUpgrade");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RequiresDroneDisruptor;
    /// <summary>
    /// Function: RequiresDroneDisruptor
    /// </summary>
    public unsafe virtual bool RequiresDroneDisruptor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequiresDroneDisruptor, "BmGame.RVantageMineBase.RequiresDroneDisruptor");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisruptorTargetMesh;
    /// <summary>
    /// Function: GetDisruptorTargetMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.MeshComponent GetDisruptorTargetMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisruptorTargetMesh, "BmGame.RVantageMineBase.GetDisruptorTargetMesh");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.MeshComponent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisruptorOverridePriority;
    /// <summary>
    /// Function: GetDisruptorOverridePriority
    /// </summary>
    public unsafe virtual float GetDisruptorOverridePriority()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisruptorOverridePriority, "BmGame.RVantageMineBase.GetDisruptorOverridePriority");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HitByDisruptorGadgetSecondary;
    /// <summary>
    /// Function: HitByDisruptorGadgetSecondary
    /// </summary>
    public unsafe virtual bool HitByDisruptorGadgetSecondary()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByDisruptorGadgetSecondary, "BmGame.RVantageMineBase.HitByDisruptorGadgetSecondary");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeDisruptedSecondary;
    /// <summary>
    /// Function: CanBeDisruptedSecondary
    /// </summary>
    public unsafe virtual bool CanBeDisruptedSecondary()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeDisruptedSecondary, "BmGame.RVantageMineBase.CanBeDisruptedSecondary");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HitByDisruptorGadgetCharge;
    /// <summary>
    /// Function: HitByDisruptorGadgetCharge
    /// </summary>
    public unsafe virtual bool HitByDisruptorGadgetCharge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByDisruptorGadgetCharge, "BmGame.RVantageMineBase.HitByDisruptorGadgetCharge");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeDisrupted;
    /// <summary>
    /// Function: CanBeDisrupted
    /// </summary>
    public unsafe virtual bool CanBeDisrupted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeDisrupted, "BmGame.RVantageMineBase.CanBeDisrupted");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DestroyAfterJam;
    /// <summary>
    /// Function: DestroyAfterJam
    /// </summary>
    public unsafe virtual void DestroyAfterJam()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyAfterJam, "BmGame.RVantageMineBase.DestroyAfterJam");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDisruptorTargetPosition;
    /// <summary>
    /// Function: GetDisruptorTargetPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDisruptorTargetPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisruptorTargetPosition, "BmGame.RVantageMineBase.GetDisruptorTargetPosition");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BlowUp;
    /// <summary>
    /// Function: BlowUp
    /// </summary>
    public unsafe override void BlowUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlowUp, "BmGame.RVantageMineBase.BlowUp");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RVantageMineBase.Tick");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPlayerNearMine;
    /// <summary>
    /// Function: IsPlayerNearMine
    /// </summary>
    public unsafe virtual bool IsPlayerNearMine(BmSDK.BmGame.RPawnPlayer PawnPlayer, out float Dist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayerNearMine, "BmGame.RVantageMineBase.IsPlayerNearMine");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnPlayer, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Dist);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dist, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Dist = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetDangerEffects;
    /// <summary>
    /// Function: SetDangerEffects
    /// </summary>
    public unsafe override void SetDangerEffects(float NewSpeed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDangerEffects, "BmGame.RVantageMineBase.SetDangerEffects");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSpeed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHidePointAttached;
    /// <summary>
    /// Function: SetHidePointAttached
    /// </summary>
    public unsafe virtual void SetHidePointAttached(BmSDK.BmGame.RHidePoint NewVantage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHidePointAttached, "BmGame.RVantageMineBase.SetHidePointAttached");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVantage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RVantageMineBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: VfTable_IRDisruptableInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRDisruptableInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ComponentProperty: SkeletalMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent SkeletalMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ComponentProperty: InteractionList
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent InteractionList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: HidePointAttached
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint HidePointAttached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: SoloVisFXTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SoloVisFXTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: BeamVisFXTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem BeamVisFXTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: DisruptedSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DisruptedSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ComponentProperty: LightFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent LightFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ComponentProperty: VisibilityFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent VisibilityFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// FloatProperty: PlayerOnMineTime
    /// </summary>
    public unsafe float PlayerOnMineTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: BoomTime
    /// </summary>
    public unsafe float BoomTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bHasBeenJammed
    /// </summary>
    public unsafe bool bHasBeenJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: bAddedAudioLoop
    /// </summary>
    public unsafe bool bAddedAudioLoop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: bEnRouteToVantagePoint
    /// </summary>
    public unsafe bool bEnRouteToVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// FloatProperty: BeamDetectRadius
    /// </summary>
    public unsafe float BeamDetectRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// StructProperty: vVantagePointTargetLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 vVantagePointTargetLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 828);

    /// <summary>
    /// StructProperty: rVantagePointTargetRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator rVantagePointTargetRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 840);

    /// <summary>
    /// FloatProperty: fNumberOfFramesUntilVantagePointIsHit
    /// </summary>
    public unsafe float fNumberOfFramesUntilVantagePointIsHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }
}
