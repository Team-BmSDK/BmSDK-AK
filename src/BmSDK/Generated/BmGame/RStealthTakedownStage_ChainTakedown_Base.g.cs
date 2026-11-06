#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RStealthTakedownStage_ChainTakedown_Base<br/>
/// (size = 1844)
/// (flags = 10485778)
/// </summary>
public partial class RStealthTakedownStage_ChainTakedown_Base : BmSDK.BmGame.RStealthTakeDownStage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RStealthTakedownStage_ChainTakedown_Base", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RStealthTakedownStage_ChainTakedown_Base.
    /// </summary>
    public static RStealthTakedownStage_ChainTakedown_Base DefaultObject => (RStealthTakedownStage_ChainTakedown_Base)StaticClass().DefaultObject;

    internal RStealthTakedownStage_ChainTakedown_Base() { }

    /// <summary>
    /// Constructs a new RStealthTakedownStage_ChainTakedown_Base
    /// </summary>
    public RStealthTakedownStage_ChainTakedown_Base(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RStealthTakedownStage_ChainTakedown_Base(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_Base>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_Base>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_Base>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_Base>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_Base>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_Base>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_Base>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_Base>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetTunnelGrateNextStage;
    /// <summary>
    /// Function: SetTunnelGrateNextStage
    /// </summary>
    public unsafe override void SetTunnelGrateNextStage(BmSDK.BmGame.RStealthTakeDownStage NextStageObject)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTunnelGrateNextStage, "BmGame.RStealthTakedownStage_ChainTakedown_Base.SetTunnelGrateNextStage");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextStageObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropOrBreakThugWeapon;
    /// <summary>
    /// Function: DropOrBreakThugWeapon
    /// </summary>
    public unsafe override void DropOrBreakThugWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropOrBreakThugWeapon, "BmGame.RStealthTakedownStage_ChainTakedown_Base.DropOrBreakThugWeapon");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopOverlay;
    /// <summary>
    /// Function: StopOverlay
    /// </summary>
    public unsafe virtual void StopOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopOverlay, "BmGame.RStealthTakedownStage_ChainTakedown_Base.StopOverlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartFearTakedownFinaleCamera;
    /// <summary>
    /// Function: StartFearTakedownFinaleCamera
    /// </summary>
    public unsafe virtual void StartFearTakedownFinaleCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFearTakedownFinaleCamera, "BmGame.RStealthTakedownStage_ChainTakedown_Base.StartFearTakedownFinaleCamera");
        byte* paramsPtr = stackalloc byte[180];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_End;
    /// <summary>
    /// Function: End
    /// </summary>
    public unsafe override void End(bool bLastStage = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_End, "BmGame.RStealthTakedownStage_ChainTakedown_Base.End");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLastStage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override void GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.RStealthTakedownStage_ChainTakedown_Base.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAimingConfig;
    /// <summary>
    /// Function: GetAimingConfig
    /// </summary>
    public unsafe override BmSDK.Engine.RAimingConfig GetAimingConfig()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAimingConfig, "BmGame.RStealthTakedownStage_ChainTakedown_Base.GetAimingConfig");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAimingConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RStealthTakedownStage_ChainTakedown_Base.Tick");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableLinearDampingOnRagdoll;
    /// <summary>
    /// Function: DisableLinearDampingOnRagdoll
    /// </summary>
    public unsafe virtual void DisableLinearDampingOnRagdoll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableLinearDampingOnRagdoll, "BmGame.RStealthTakedownStage_ChainTakedown_Base.DisableLinearDampingOnRagdoll");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldUseRagdollDamping;
    /// <summary>
    /// Function: ShouldUseRagdollDamping
    /// </summary>
    public unsafe override bool ShouldUseRagdollDamping(BmSDK.BmGame.RPawnVillain TheVictim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldUseRagdollDamping, "BmGame.RStealthTakedownStage_ChainTakedown_Base.ShouldUseRagdollDamping");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheVictim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CheckVoiceSynthToTripleFearTakedownChallenge;
    /// <summary>
    /// Function: CheckVoiceSynthToTripleFearTakedownChallenge
    /// </summary>
    public unsafe virtual void CheckVoiceSynthToTripleFearTakedownChallenge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckVoiceSynthToTripleFearTakedownChallenge, "BmGame.RStealthTakedownStage_ChainTakedown_Base.CheckVoiceSynthToTripleFearTakedownChallenge");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterTakedownVictim;
    /// <summary>
    /// Function: RegisterTakedownVictim
    /// </summary>
    public unsafe virtual void RegisterTakedownVictim(BmSDK.BmGame.RPawnVillain inVictim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterTakedownVictim, "BmGame.RStealthTakedownStage_ChainTakedown_Base.RegisterTakedownVictim");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inVictim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishAttackVictim;
    /// <summary>
    /// Function: FinishAttackVictim
    /// </summary>
    public unsafe override bool FinishAttackVictim(int iVictimNumber)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishAttackVictim, "BmGame.RStealthTakedownStage_ChainTakedown_Base.FinishAttackVictim");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iVictimNumber, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ChainTakedownPressed;
    /// <summary>
    /// Function: ChainTakedownPressed
    /// </summary>
    public unsafe virtual bool ChainTakedownPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChainTakedownPressed, "BmGame.RStealthTakedownStage_ChainTakedown_Base.ChainTakedownPressed");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_KillLastHitSlomo;
    /// <summary>
    /// Function: KillLastHitSlomo
    /// </summary>
    public unsafe virtual void KillLastHitSlomo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillLastHitSlomo, "BmGame.RStealthTakedownStage_ChainTakedown_Base.KillLastHitSlomo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartLastHitSlomo;
    /// <summary>
    /// Function: StartLastHitSlomo
    /// </summary>
    public unsafe virtual void StartLastHitSlomo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartLastHitSlomo, "BmGame.RStealthTakedownStage_ChainTakedown_Base.StartLastHitSlomo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreSloMoSound;
    /// <summary>
    /// Function: PreSloMoSound
    /// </summary>
    public unsafe virtual void PreSloMoSound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreSloMoSound, "BmGame.RStealthTakedownStage_ChainTakedown_Base.PreSloMoSound");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishSloMo;
    /// <summary>
    /// Function: FinishSloMo
    /// </summary>
    public unsafe virtual void FinishSloMo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishSloMo, "BmGame.RStealthTakedownStage_ChainTakedown_Base.FinishSloMo");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSlomoForNextTakedown;
    /// <summary>
    /// Function: StartSlomoForNextTakedown
    /// </summary>
    public unsafe virtual void StartSlomoForNextTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSlomoForNextTakedown, "BmGame.RStealthTakedownStage_ChainTakedown_Base.StartSlomoForNextTakedown");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetReferencePosition;
    /// <summary>
    /// Function: GetReferencePosition
    /// </summary>
    public unsafe override void GetReferencePosition(out System.Numerics.Vector3 ReferencePosition, out BmSDK.Rotator ReferenceRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetReferencePosition, "BmGame.RStealthTakedownStage_ChainTakedown_Base.GetReferencePosition");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ReferencePosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        ReferenceRotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_PrepareForFinaleCamera;
    /// <summary>
    /// Function: PrepareForFinaleCamera
    /// </summary>
    public unsafe virtual void PrepareForFinaleCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepareForFinaleCamera, "BmGame.RStealthTakedownStage_ChainTakedown_Base.PrepareForFinaleCamera");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanTakedownBeCancelledByDamage;
    /// <summary>
    /// Function: CanTakedownBeCancelledByDamage
    /// </summary>
    public unsafe override bool CanTakedownBeCancelledByDamage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTakedownBeCancelledByDamage, "BmGame.RStealthTakedownStage_ChainTakedown_Base.CanTakedownBeCancelledByDamage");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AttackerDamaged;
    /// <summary>
    /// Function: AttackerDamaged
    /// </summary>
    public unsafe override void AttackerDamaged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttackerDamaged, "BmGame.RStealthTakedownStage_ChainTakedown_Base.AttackerDamaged");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Begin;
    /// <summary>
    /// Function: Begin
    /// </summary>
    public unsafe override void Begin()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Begin, "BmGame.RStealthTakedownStage_ChainTakedown_Base.Begin");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: fSlowdownAmountToSelectNextVictim
    /// </summary>
    public unsafe float fSlowdownAmountToSelectNextVictim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }

    /// <summary>
    /// FloatProperty: fRealTimeWaitForSlowdownToEnd
    /// </summary>
    public unsafe float fRealTimeWaitForSlowdownToEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// BoolProperty: SpottedByAnotherThug
    /// </summary>
    public unsafe bool SpottedByAnotherThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1672); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredSloMo
    /// </summary>
    public unsafe bool bTriggeredSloMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1672); }
    }

    /// <summary>
    /// BoolProperty: bLinearDampingOnRagdollDisabled
    /// </summary>
    public unsafe bool bLinearDampingOnRagdollDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1672); }
    }

    /// <summary>
    /// BoolProperty: bDoingLastHitSlomo
    /// </summary>
    public unsafe bool bDoingLastHitSlomo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1672); }
    }

    /// <summary>
    /// BoolProperty: bCheckForNextFearTakedownTargetAtStart
    /// </summary>
    public unsafe bool bCheckForNextFearTakedownTargetAtStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1672); }
    }

    /// <summary>
    /// BoolProperty: bNextChainFearTakedownTargetExistedAtStart
    /// </summary>
    public unsafe bool bNextChainFearTakedownTargetExistedAtStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1672); }
    }

    /// <summary>
    /// BoolProperty: bCountThisMoveTowardsFearTakedownCount
    /// </summary>
    public unsafe bool bCountThisMoveTowardsFearTakedownCount
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1672); }
    }

    /// <summary>
    /// ObjectProperty: CachedTunnelGrate
    /// </summary>
    public unsafe BmSDK.Engine.Actor CachedTunnelGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// IntProperty: iScreenShakeId
    /// </summary>
    public unsafe int iScreenShakeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// StructProperty: FinalHitCameraShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct FinalHitCameraShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 1688);
}
