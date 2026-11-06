#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRemoteSwitchBase<br/>
/// (size = 1120)
/// (flags = 10486290)
/// </summary>
public partial class RRemoteSwitchBase : BmSDK.BmGame.RInteractableItem, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRemoteSwitchBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RRemoteSwitchBase.
    /// </summary>
    public static RRemoteSwitchBase DefaultObject => (RRemoteSwitchBase)StaticClass().DefaultObject;

    internal RRemoteSwitchBase() { }

    /// <summary>
    /// Constructs a new RRemoteSwitchBase
    /// </summary>
    public RRemoteSwitchBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRemoteSwitchBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRemoteSwitchBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRemoteSwitchBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRemoteSwitchBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRemoteSwitchBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRemoteSwitchBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRemoteSwitchBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRemoteSwitchBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRemoteSwitchBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ResetStateForARChallenge;
    /// <summary>
    /// Function: ResetStateForARChallenge
    /// </summary>
    public unsafe virtual void ResetStateForARChallenge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetStateForARChallenge, "BmGame.RRemoteSwitchBase.ResetStateForARChallenge");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerRemoteSwitchSwitchedOffEvent;
    /// <summary>
    /// Function: TriggerRemoteSwitchSwitchedOffEvent
    /// </summary>
    public unsafe virtual void TriggerRemoteSwitchSwitchedOffEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerRemoteSwitchSwitchedOffEvent, "BmGame.RRemoteSwitchBase.TriggerRemoteSwitchSwitchedOffEvent");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerRemoteSwitchSwitchedOnEvent;
    /// <summary>
    /// Function: TriggerRemoteSwitchSwitchedOnEvent
    /// </summary>
    public unsafe virtual void TriggerRemoteSwitchSwitchedOnEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerRemoteSwitchSwitchedOnEvent, "BmGame.RRemoteSwitchBase.TriggerRemoteSwitchSwitchedOnEvent");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequiresBlindDroneUpgrade;
    /// <summary>
    /// Function: RequiresBlindDroneUpgrade
    /// </summary>
    public unsafe virtual bool RequiresBlindDroneUpgrade()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequiresBlindDroneUpgrade, "BmGame.RRemoteSwitchBase.RequiresBlindDroneUpgrade");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerSecondary;
    /// <summary>
    /// Function: TriggerSecondary
    /// </summary>
    public unsafe virtual bool TriggerSecondary(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSecondary, "BmGame.RRemoteSwitchBase.TriggerSecondary");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TriggerRight;
    /// <summary>
    /// Function: TriggerRight
    /// </summary>
    public unsafe virtual void TriggerRight(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerRight, "BmGame.RRemoteSwitchBase.TriggerRight");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerLeft;
    /// <summary>
    /// Function: TriggerLeft
    /// </summary>
    public unsafe virtual void TriggerLeft(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerLeft, "BmGame.RRemoteSwitchBase.TriggerLeft");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Trigger;
    /// <summary>
    /// Function: Trigger
    /// </summary>
    public unsafe virtual bool Trigger(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Trigger, "BmGame.RRemoteSwitchBase.Trigger");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanTrigger;
    /// <summary>
    /// Function: CanTrigger
    /// </summary>
    public unsafe virtual bool CanTrigger(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTrigger, "BmGame.RRemoteSwitchBase.CanTrigger");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetMiniGameHelpPrompt;
    /// <summary>
    /// Function: GetMiniGameHelpPrompt
    /// </summary>
    public unsafe virtual void GetMiniGameHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMiniGameHelpPrompt, "BmGame.RRemoteSwitchBase.GetMiniGameHelpPrompt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanTargetTroughWalls;
    /// <summary>
    /// Function: CanTargetTroughWalls
    /// </summary>
    public unsafe virtual bool CanTargetTroughWalls()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTargetTroughWalls, "BmGame.RRemoteSwitchBase.CanTargetTroughWalls");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInteractionType;
    /// <summary>
    /// Function: GetInteractionType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RRemoteControlLowSecurityInterface.EOmnitronInteractionType GetInteractionType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInteractionType, "BmGame.RRemoteSwitchBase.GetInteractionType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RRemoteControlLowSecurityInterface.EOmnitronInteractionType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInteractionPromptSecondary;
    /// <summary>
    /// Function: GetInteractionPromptSecondary
    /// </summary>
    public unsafe virtual BmSDK.FString GetInteractionPromptSecondary()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInteractionPromptSecondary, "BmGame.RRemoteSwitchBase.GetInteractionPromptSecondary");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldInteractionPromptBeDisplayedInCentreOfScreen;
    /// <summary>
    /// Function: ShouldInteractionPromptBeDisplayedInCentreOfScreen
    /// </summary>
    public unsafe virtual bool ShouldInteractionPromptBeDisplayedInCentreOfScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldInteractionPromptBeDisplayedInCentreOfScreen, "BmGame.RRemoteSwitchBase.ShouldInteractionPromptBeDisplayedInCentreOfScreen");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeTargettedByRHD;
    /// <summary>
    /// Function: CanBeTargettedByRHD
    /// </summary>
    public unsafe virtual bool CanBeTargettedByRHD(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeTargettedByRHD, "BmGame.RRemoteSwitchBase.CanBeTargettedByRHD");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_NeedDisplayRefresh;
    /// <summary>
    /// Function: NeedDisplayRefresh
    /// </summary>
    public unsafe virtual bool NeedDisplayRefresh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NeedDisplayRefresh, "BmGame.RRemoteSwitchBase.NeedDisplayRefresh");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInteractionPrompt;
    /// <summary>
    /// Function: GetInteractionPrompt
    /// </summary>
    public unsafe virtual BmSDK.FString GetInteractionPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInteractionPrompt, "BmGame.RRemoteSwitchBase.GetInteractionPrompt");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayIconName;
    /// <summary>
    /// Function: GetDisplayIconName
    /// </summary>
    public unsafe virtual BmSDK.FString GetDisplayIconName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayIconName, "BmGame.RRemoteSwitchBase.GetDisplayIconName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayDescription;
    /// <summary>
    /// Function: GetDisplayDescription
    /// </summary>
    public unsafe virtual BmSDK.FString GetDisplayDescription()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayDescription, "BmGame.RRemoteSwitchBase.GetDisplayDescription");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayTitle;
    /// <summary>
    /// Function: GetDisplayTitle
    /// </summary>
    public unsafe virtual BmSDK.FString GetDisplayTitle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayTitle, "BmGame.RRemoteSwitchBase.GetDisplayTitle");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayLockOnState;
    /// <summary>
    /// Function: GetDisplayLockOnState
    /// </summary>
    public unsafe virtual BmSDK.FString GetDisplayLockOnState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayLockOnState, "BmGame.RRemoteSwitchBase.GetDisplayLockOnState");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayTargetLocation;
    /// <summary>
    /// Function: GetDisplayTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDisplayTargetLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayTargetLocation, "BmGame.RRemoteSwitchBase.GetDisplayTargetLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Explode;
    /// <summary>
    /// Function: Explode
    /// </summary>
    public unsafe virtual void Explode(bool bSilent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Explode, "BmGame.RRemoteSwitchBase.Explode");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSilent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpecialExplode;
    /// <summary>
    /// Function: SpecialExplode
    /// </summary>
    public unsafe virtual void SpecialExplode(bool bSetTimerToTriggerOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialExplode, "BmGame.RRemoteSwitchBase.SpecialExplode");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetTimerToTriggerOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RRemoteSwitchBase.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RRemoteSwitchBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsTargetable;
    /// <summary>
    /// Function: IsTargetable
    /// </summary>
    public unsafe virtual bool IsTargetable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTargetable, "BmGame.RRemoteSwitchBase.IsTargetable");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsActive;
    /// <summary>
    /// Function: IsActive
    /// </summary>
    public unsafe override bool IsActive(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsActive, "BmGame.RRemoteSwitchBase.IsActive");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_EnableSwitchAfterInactivePeriod;
    /// <summary>
    /// Function: EnableSwitchAfterInactivePeriod
    /// </summary>
    public unsafe virtual void EnableSwitchAfterInactivePeriod()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableSwitchAfterInactivePeriod, "BmGame.RRemoteSwitchBase.EnableSwitchAfterInactivePeriod");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableTickIfNecessary;
    /// <summary>
    /// Function: DisableTickIfNecessary
    /// </summary>
    public unsafe virtual void DisableTickIfNecessary()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableTickIfNecessary, "BmGame.RRemoteSwitchBase.DisableTickIfNecessary");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsAnyTimerActive;
    /// <summary>
    /// Function: IsAnyTimerActive
    /// </summary>
    public unsafe virtual bool IsAnyTimerActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAnyTimerActive, "BmGame.RRemoteSwitchBase.IsAnyTimerActive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnToggleRemoteSwitchUsable;
    /// <summary>
    /// Function: OnToggleRemoteSwitchUsable
    /// </summary>
    public unsafe virtual void OnToggleRemoteSwitchUsable(BmSDK.BmGame.RSeqAct_ToggleRemoteSwitchUsable Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggleRemoteSwitchUsable, "BmGame.RRemoteSwitchBase.OnToggleRemoteSwitchUsable");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMaterialUnusable;
    /// <summary>
    /// Function: SetMaterialUnusable
    /// </summary>
    public unsafe virtual void SetMaterialUnusable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMaterialUnusable, "BmGame.RRemoteSwitchBase.SetMaterialUnusable");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMaterialOff;
    /// <summary>
    /// Function: SetMaterialOff
    /// </summary>
    public unsafe virtual void SetMaterialOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMaterialOff, "BmGame.RRemoteSwitchBase.SetMaterialOff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMaterialOn;
    /// <summary>
    /// Function: SetMaterialOn
    /// </summary>
    public unsafe virtual void SetMaterialOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMaterialOn, "BmGame.RRemoteSwitchBase.SetMaterialOn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnToggle;
    /// <summary>
    /// Function: OnToggle
    /// </summary>
    public unsafe virtual void OnToggle(BmSDK.Engine.SeqAct_Toggle Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggle, "BmGame.RRemoteSwitchBase.OnToggle");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeLight;
    /// <summary>
    /// Function: ChangeLight
    /// </summary>
    public unsafe virtual void ChangeLight(bool bNewState, bool bInitialSetting = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeLight, "BmGame.RRemoteSwitchBase.ChangeLight");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInitialSetting, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOn;
    /// <summary>
    /// Function: TurnOn
    /// </summary>
    public unsafe virtual void TurnOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOn, "BmGame.RRemoteSwitchBase.TurnOn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOff;
    /// <summary>
    /// Function: TurnOff
    /// </summary>
    public unsafe virtual void TurnOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOff, "BmGame.RRemoteSwitchBase.TurnOff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: LightMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant LightMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ObjectProperty: LightMatXray
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant LightMatXray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// ObjectProperty: ExplodedStateMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMesh ExplodedStateMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// ObjectProperty: ExplodeEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ExplodeEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// ObjectProperty: BankStartlePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RStartlePoint_Bank BankStartlePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStartlePoint_Bank>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// ObjectProperty: TriggerSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TriggerSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bCreateNewXrayMaterial
    /// </summary>
    public unsafe bool bCreateNewXrayMaterial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bUsable
    /// </summary>
    public unsafe bool bUsable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bLightOn
    /// </summary>
    public unsafe bool bLightOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bInitialLightOn
    /// </summary>
    public unsafe bool bInitialLightOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bCanTargetTroughWalls
    /// </summary>
    public unsafe bool bCanTargetTroughWalls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bDisplayInteractionPromptInCentreOfScreen
    /// </summary>
    public unsafe bool bDisplayInteractionPromptInCentreOfScreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bExplodeWhenUsed
    /// </summary>
    public unsafe bool bExplodeWhenUsed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bExploded
    /// </summary>
    public unsafe bool bExploded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bLockInRemoteSwitch
    /// </summary>
    public unsafe bool bLockInRemoteSwitch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: TimeTillReset
    /// </summary>
    public unsafe float TimeTillReset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// FloatProperty: fInactiveTimeAfterBeingUsed
    /// </summary>
    public unsafe float fInactiveTimeAfterBeingUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// IntProperty: MaxUseCount
    /// </summary>
    public unsafe int MaxUseCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// IntProperty: UseCount
    /// </summary>
    public unsafe int UseCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// StructProperty: OmnitronOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 OmnitronOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 972);

    /// <summary>
    /// StrProperty: RemoteHackingDeviceIcon
    /// </summary>
    public unsafe BmSDK.FString RemoteHackingDeviceIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// StrProperty: RemoteHackingDeviceIconOff
    /// </summary>
    public unsafe BmSDK.FString RemoteHackingDeviceIconOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// StrProperty: DisplayTitle
    /// </summary>
    public unsafe BmSDK.FString DisplayTitle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// StrProperty: Description
    /// </summary>
    public unsafe BmSDK.FString Description
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// StrProperty: DescriptionOff
    /// </summary>
    public unsafe BmSDK.FString DescriptionOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// StrProperty: SwitchOnPrompt
    /// </summary>
    public unsafe BmSDK.FString SwitchOnPrompt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// StrProperty: SwitchOffPrompt
    /// </summary>
    public unsafe BmSDK.FString SwitchOffPrompt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: AssociatedLockInRemoteSwitches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRemoteSwitchBase> AssociatedLockInRemoteSwitches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRemoteSwitchBase>>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// FloatProperty: fDurationBeforeLockInRemoteSwitchOpensDoor
    /// </summary>
    public unsafe float fDurationBeforeLockInRemoteSwitchOpensDoor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// FloatProperty: fLockInWaitingForDoorOpenTimer
    /// </summary>
    public unsafe float fLockInWaitingForDoorOpenTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }
}
