#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RStealthTakedownStageQuickBase<br/>
/// (size = 1700)
/// (flags = 10485778)
/// </summary>
public partial class RStealthTakedownStageQuickBase : BmSDK.BmGame.RStealthTakeDownStage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RStealthTakedownStageQuickBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RStealthTakedownStageQuickBase.
    /// </summary>
    public static RStealthTakedownStageQuickBase DefaultObject => (RStealthTakedownStageQuickBase)StaticClass().DefaultObject;

    internal RStealthTakedownStageQuickBase() { }

    /// <summary>
    /// Constructs a new RStealthTakedownStageQuickBase
    /// </summary>
    public RStealthTakedownStageQuickBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RStealthTakedownStageQuickBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStageQuickBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStageQuickBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStageQuickBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStageQuickBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStageQuickBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStageQuickBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStageQuickBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStageQuickBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override void GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.RStealthTakedownStageQuickBase.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StrikePressed;
    /// <summary>
    /// Function: StrikePressed
    /// </summary>
    public unsafe override void StrikePressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StrikePressed, "BmGame.RStealthTakedownStageQuickBase.StrikePressed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SlowMoForFearTakedown;
    /// <summary>
    /// Function: SlowMoForFearTakedown
    /// </summary>
    public unsafe virtual bool SlowMoForFearTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SlowMoForFearTakedown, "BmGame.RStealthTakedownStageQuickBase.SlowMoForFearTakedown");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerEscapeTakedown;
    /// <summary>
    /// Function: TriggerEscapeTakedown
    /// </summary>
    public unsafe override void TriggerEscapeTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerEscapeTakedown, "BmGame.RStealthTakedownStageQuickBase.TriggerEscapeTakedown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerEnvironmentTakedown;
    /// <summary>
    /// Function: TriggerEnvironmentTakedown
    /// </summary>
    public unsafe virtual bool TriggerEnvironmentTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerEnvironmentTakedown, "BmGame.RStealthTakedownStageQuickBase.TriggerEnvironmentTakedown");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CantCancelTakedown;
    /// <summary>
    /// Function: CantCancelTakedown
    /// </summary>
    public unsafe virtual void CantCancelTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CantCancelTakedown, "BmGame.RStealthTakedownStageQuickBase.CantCancelTakedown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CriticalPointEndTimer;
    /// <summary>
    /// Function: CriticalPointEndTimer
    /// </summary>
    public unsafe virtual void CriticalPointEndTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CriticalPointEndTimer, "BmGame.RStealthTakedownStageQuickBase.CriticalPointEndTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlayQuickFinishFromHere;
    /// <summary>
    /// Function: CanPlayQuickFinishFromHere
    /// </summary>
    public unsafe virtual void CanPlayQuickFinishFromHere()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayQuickFinishFromHere, "BmGame.RStealthTakedownStageQuickBase.CanPlayQuickFinishFromHere");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CriticalPointStart;
    /// <summary>
    /// Function: CriticalPointStart
    /// </summary>
    public unsafe virtual void CriticalPointStart()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CriticalPointStart, "BmGame.RStealthTakedownStageQuickBase.CriticalPointStart");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChanceToSucceed;
    /// <summary>
    /// Function: ChanceToSucceed
    /// </summary>
    public unsafe virtual void ChanceToSucceed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChanceToSucceed, "BmGame.RStealthTakedownStageQuickBase.ChanceToSucceed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanTriggerQuickFinish;
    /// <summary>
    /// Function: CanTriggerQuickFinish
    /// </summary>
    public unsafe virtual bool CanTriggerQuickFinish()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTriggerQuickFinish, "BmGame.RStealthTakedownStageQuickBase.CanTriggerQuickFinish");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPressStrangleButton;
    /// <summary>
    /// Function: CanPressStrangleButton
    /// </summary>
    public unsafe virtual bool CanPressStrangleButton()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPressStrangleButton, "BmGame.RStealthTakedownStageQuickBase.CanPressStrangleButton");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TimerCritical;
    /// <summary>
    /// Function: TimerCritical
    /// </summary>
    public unsafe virtual bool TimerCritical()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimerCritical, "BmGame.RStealthTakedownStageQuickBase.TimerCritical");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AlwaysAllowFearTakedownTimer;
    /// <summary>
    /// Function: AlwaysAllowFearTakedownTimer
    /// </summary>
    public unsafe virtual void AlwaysAllowFearTakedownTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlwaysAllowFearTakedownTimer, "BmGame.RStealthTakedownStageQuickBase.AlwaysAllowFearTakedownTimer");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Begin, "BmGame.RStealthTakedownStageQuickBase.Begin");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bStartedStraining
    /// </summary>
    public unsafe bool bStartedStraining
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bChanceToSucceed
    /// </summary>
    public unsafe bool bChanceToSucceed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bCanCancelTakedown
    /// </summary>
    public unsafe bool bCanCancelTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: TryingToDoQuickTakedown
    /// </summary>
    public unsafe bool TryingToDoQuickTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bAutoTriggerQuickTakedown
    /// </summary>
    public unsafe bool bAutoTriggerQuickTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bCanTriggerQuickFinish
    /// </summary>
    public unsafe bool bCanTriggerQuickFinish
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bUseQuickFinishAnimationNotify
    /// </summary>
    public unsafe bool bUseQuickFinishAnimationNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bFinalVictim
    /// </summary>
    public unsafe bool bFinalVictim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: BombDefuse
    /// </summary>
    public unsafe bool BombDefuse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bPressingStrikeButtonWillPerformFearTakedown
    /// </summary>
    public unsafe bool bPressingStrikeButtonWillPerformFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bPerformFearTakedownCheckFromBatmansPosition
    /// </summary>
    public unsafe bool bPerformFearTakedownCheckFromBatmansPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// ByteProperty: SuccessTakedownClass
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EStealthTakeDownStages SuccessTakedownClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStealthTakeDownStages>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// ByteProperty: SpecialGrateFinish
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EStealthTakeDownStages SpecialGrateFinish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStealthTakeDownStages>(Ptr + 1669); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1669); }
    }

    /// <summary>
    /// ByteProperty: SpecialLedgeFinish
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EStealthTakeDownStages SpecialLedgeFinish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStealthTakeDownStages>(Ptr + 1670); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1670); }
    }

    /// <summary>
    /// ByteProperty: SpecialGrappleFinish
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EStealthTakeDownStages SpecialGrappleFinish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStealthTakeDownStages>(Ptr + 1671); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1671); }
    }

    /// <summary>
    /// ByteProperty: CurrentButton
    /// </summary>
    public unsafe BmSDK.BmGame.RInteractInterface.EInteractableItemFaceButton CurrentButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInteractInterface.EInteractableItemFaceButton>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }

    /// <summary>
    /// ClassProperty: AbortTakedownClass
    /// </summary>
    public unsafe BmSDK.Class AbortTakedownClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// ObjectProperty: QuickTakedownHintRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform QuickTakedownHintRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// FloatProperty: QuickTakedownDelay
    /// </summary>
    public unsafe float QuickTakedownDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// IntProperty: BombStage
    /// </summary>
    public unsafe int BombStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }
    }
}
