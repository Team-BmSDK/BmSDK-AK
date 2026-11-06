#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RDisruptorSniper<br/>
/// (size = 3200)
/// (flags = 144703667)
/// </summary>
public partial class RDisruptorSniper : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDisruptorSniper", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RDisruptorSniper.
    /// </summary>
    public static RDisruptorSniper DefaultObject => (RDisruptorSniper)StaticClass().DefaultObject;

    internal RDisruptorSniper() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDisruptorSniper(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDisruptorSniper>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptorSniper>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDisruptorSniper>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptorSniper>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptorSniper>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptorSniper>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDisruptorSniper>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptorSniper>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CanPlayerForgetTrackedTarget;
    /// <summary>
    /// Function: CanPlayerForgetTrackedTarget
    /// </summary>
    public unsafe virtual bool CanPlayerForgetTrackedTarget(BmSDK.BmGame.RPlayerController RPC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayerForgetTrackedTarget, "BmGame.RDisruptorSniper.CanPlayerForgetTrackedTarget");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CallFiredAtWrongTargetOnRestrictTargetSequenceActions;
    /// <summary>
    /// Function: CallFiredAtWrongTargetOnRestrictTargetSequenceActions
    /// </summary>
    public unsafe virtual void CallFiredAtWrongTargetOnRestrictTargetSequenceActions()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CallFiredAtWrongTargetOnRestrictTargetSequenceActions, "BmGame.RDisruptorSniper.CallFiredAtWrongTargetOnRestrictTargetSequenceActions");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsTargetAllowedByRestrictTargetSequenceAction;
    /// <summary>
    /// Function: IsTargetAllowedByRestrictTargetSequenceAction
    /// </summary>
    public unsafe virtual bool IsTargetAllowedByRestrictTargetSequenceAction(BmSDK.Engine.Actor CheckTarget, bool bTrackerTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTargetAllowedByRestrictTargetSequenceAction, "BmGame.RDisruptorSniper.IsTargetAllowedByRestrictTargetSequenceAction");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTrackerTarget, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RemoveRestrictTargetSequenceAction;
    /// <summary>
    /// Function: RemoveRestrictTargetSequenceAction
    /// </summary>
    public unsafe virtual void RemoveRestrictTargetSequenceAction(BmSDK.BmGame.RSeqAct_RestrictDisruptorTargets OldSequenceAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveRestrictTargetSequenceAction, "BmGame.RDisruptorSniper.RemoveRestrictTargetSequenceAction");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldSequenceAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddRestrictTargetSequenceAction;
    /// <summary>
    /// Function: AddRestrictTargetSequenceAction
    /// </summary>
    public unsafe virtual void AddRestrictTargetSequenceAction(BmSDK.BmGame.RSeqAct_RestrictDisruptorTargets NewSequenceAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRestrictTargetSequenceAction, "BmGame.RDisruptorSniper.AddRestrictTargetSequenceAction");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSequenceAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetForChallenge;
    /// <summary>
    /// Function: ResetForChallenge
    /// </summary>
    public unsafe override void ResetForChallenge(bool bChallengeStarted)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetForChallenge, "BmGame.RDisruptorSniper.ResetForChallenge");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bChallengeStarted, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillDisruptorViewMode;
    /// <summary>
    /// Function: KillDisruptorViewMode
    /// </summary>
    public unsafe virtual void KillDisruptorViewMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillDisruptorViewMode, "BmGame.RDisruptorSniper.KillDisruptorViewMode");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartDisruptorViewMode;
    /// <summary>
    /// Function: StartDisruptorViewMode
    /// </summary>
    public unsafe virtual void StartDisruptorViewMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartDisruptorViewMode, "BmGame.RDisruptorSniper.StartDisruptorViewMode");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartGadgetCamera;
    /// <summary>
    /// Function: StartGadgetCamera
    /// </summary>
    public unsafe virtual void StartGadgetCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGadgetCamera, "BmGame.RDisruptorSniper.StartGadgetCamera");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMuzzleAim;
    /// <summary>
    /// Function: UpdateMuzzleAim
    /// </summary>
    public unsafe virtual void UpdateMuzzleAim(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMuzzleAim, "BmGame.RDisruptorSniper.UpdateMuzzleAim");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartMuzzleAim;
    /// <summary>
    /// Function: StartMuzzleAim
    /// </summary>
    public unsafe virtual void StartMuzzleAim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartMuzzleAim, "BmGame.RDisruptorSniper.StartMuzzleAim");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateScreen;
    /// <summary>
    /// Function: UpdateScreen
    /// </summary>
    public unsafe virtual void UpdateScreen(float fNewScreenOnPercentage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateScreen, "BmGame.RDisruptorSniper.UpdateScreen");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fNewScreenOnPercentage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisruptorFinishedEquipping;
    /// <summary>
    /// Function: DisruptorFinishedEquipping
    /// </summary>
    public unsafe virtual void DisruptorFinishedEquipping()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisruptorFinishedEquipping, "BmGame.RDisruptorSniper.DisruptorFinishedEquipping");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLevelChange;
    /// <summary>
    /// Function: OnLevelChange
    /// </summary>
    public unsafe override void OnLevelChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLevelChange, "BmGame.RDisruptorSniper.OnLevelChange");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRoomChange;
    /// <summary>
    /// Function: OnRoomChange
    /// </summary>
    public unsafe override void OnRoomChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRoomChange, "BmGame.RDisruptorSniper.OnRoomChange");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FullyRestoreAmmo;
    /// <summary>
    /// Function: FullyRestoreAmmo
    /// </summary>
    public unsafe virtual void FullyRestoreAmmo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FullyRestoreAmmo, "BmGame.RDisruptorSniper.FullyRestoreAmmo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugRestoreAmmo;
    /// <summary>
    /// Function: DebugRestoreAmmo
    /// </summary>
    public unsafe override void DebugRestoreAmmo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugRestoreAmmo, "BmGame.RDisruptorSniper.DebugRestoreAmmo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReplenishAmmo;
    /// <summary>
    /// Function: ReplenishAmmo
    /// </summary>
    public unsafe virtual void ReplenishAmmo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplenishAmmo, "BmGame.RDisruptorSniper.ReplenishAmmo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReduceAmmo;
    /// <summary>
    /// Function: ReduceAmmo
    /// </summary>
    public unsafe virtual void ReduceAmmo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReduceAmmo, "BmGame.RDisruptorSniper.ReduceAmmo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsActorTagged;
    /// <summary>
    /// Function: IsActorTagged
    /// </summary>
    public unsafe virtual bool IsActorTagged(BmSDK.Engine.Actor Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsActorTagged, "BmGame.RDisruptorSniper.IsActorTagged");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsVehicleBeingTracked;
    /// <summary>
    /// Function: IsVehicleBeingTracked
    /// </summary>
    public unsafe virtual bool IsVehicleBeingTracked(BmSDK.BmGame.RVehicleNPC CheckVehicle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVehicleBeingTracked, "BmGame.RDisruptorSniper.IsVehicleBeingTracked");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckVehicle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CheckAutoTarget;
    /// <summary>
    /// Function: CheckAutoTarget
    /// </summary>
    public unsafe override bool CheckAutoTarget(BmSDK.Engine.Actor Target, out System.Numerics.Vector3 TargetPosition, out float OverridePriority, out float OverrideMaxRange, out byte DoLOSCheck)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAutoTarget, "BmGame.RDisruptorSniper.CheckAutoTarget");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TargetPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPosition, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OverridePriority);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridePriority, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OverrideMaxRange);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaxRange, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DoLOSCheck);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DoLOSCheck, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TargetPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        OverridePriority = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
        OverrideMaxRange = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        DoLOSCheck = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetGadgetCamera;
    /// <summary>
    /// Function: GetGadgetCamera
    /// </summary>
    public unsafe override BmSDK.FName GetGadgetCamera(bool InSoftCover = default, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetCamera, "BmGame.RDisruptorSniper.GetGadgetCamera");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_StartBulletTrailVFX;
    /// <summary>
    /// Function: StartBulletTrailVFX
    /// </summary>
    public unsafe virtual void StartBulletTrailVFX(System.Numerics.Vector3 vHitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartBulletTrailVFX, "BmGame.RDisruptorSniper.StartBulletTrailVFX");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vHitLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override bool GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.RDisruptorSniper.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetGadgetLookSensitivity;
    /// <summary>
    /// Function: GetGadgetLookSensitivity
    /// </summary>
    public unsafe override float GetGadgetLookSensitivity(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetLookSensitivity, "BmGame.RDisruptorSniper.GetGadgetLookSensitivity");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AimedFireDD;
    /// <summary>
    /// Function: AimedFireDD
    /// </summary>
    public unsafe virtual int AimedFireDD(BmSDK.BmGame.RInventoryGadget.FHighlightedMesh SniperTarget, System.Numerics.Vector3 vHitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimedFireDD, "BmGame.RDisruptorSniper.AimedFireDD");
        byte* paramsPtr = stackalloc byte[184];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SniperTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vHitLocation, paramsPtr + 88);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 100);
    }

    private static BmSDK.Function __fn_SetSurveillanceSuppressed;
    /// <summary>
    /// Function: SetSurveillanceSuppressed
    /// </summary>
    public unsafe virtual void SetSurveillanceSuppressed(bool do_suppress)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSurveillanceSuppressed, "BmGame.RDisruptorSniper.SetSurveillanceSuppressed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(do_suppress, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawAimingHUD;
    /// <summary>
    /// Function: DrawAimingHUD
    /// </summary>
    public unsafe virtual void DrawAimingHUD()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawAimingHUD, "BmGame.RDisruptorSniper.DrawAimingHUD");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__GetDetailString;
    /// <summary>
    /// Function: _GetDetailString
    /// </summary>
    public unsafe virtual BmSDK.FString _GetDetailString(BmSDK.BmGame.RInventoryGadget.FHighlightedMesh hHighlightTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__GetDetailString, "BmGame.RDisruptorSniper._GetDetailString");
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hHighlightTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 88);
    }

    private static BmSDK.Function __fn_GetFiringAnimationOverlay;
    /// <summary>
    /// Function: GetFiringAnimationOverlay
    /// </summary>
    public unsafe virtual BmSDK.FName GetFiringAnimationOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFiringAnimationOverlay, "BmGame.RDisruptorSniper.GetFiringAnimationOverlay");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayMagazineRotation;
    /// <summary>
    /// Function: PlayMagazineRotation
    /// </summary>
    public unsafe virtual void PlayMagazineRotation(BmSDK.BmGame.RInventoryGadget.EHighlightedTargetType DesiredMagazineType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayMagazineRotation, "BmGame.RDisruptorSniper.PlayMagazineRotation");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredMagazineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsAmmoTypeTheSame;
    /// <summary>
    /// Function: IsAmmoTypeTheSame
    /// </summary>
    public unsafe virtual bool IsAmmoTypeTheSame(BmSDK.BmGame.RInventoryGadget.EHighlightedTargetType OldTargetType, BmSDK.BmGame.RInventoryGadget.EHighlightedTargetType NewTargetType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAmmoTypeTheSame, "BmGame.RDisruptorSniper.IsAmmoTypeTheSame");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldTargetType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTargetType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateDisruptorUpgrades;
    /// <summary>
    /// Function: UpdateDisruptorUpgrades
    /// </summary>
    public unsafe virtual void UpdateDisruptorUpgrades()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateDisruptorUpgrades, "BmGame.RDisruptorSniper.UpdateDisruptorUpgrades");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPrimedPose;
    /// <summary>
    /// Function: GetPrimedPose
    /// </summary>
    public unsafe override BmSDK.FName GetPrimedPose(out BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, out BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess, bool InSoftCover, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType, out BmSDK.FName OutCapeState, out BmSDK.FName OutCapeTransitionState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrimedPose, "BmGame.RDisruptorSniper.GetPrimedPose");
        byte* paramsPtr = stackalloc byte[40];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StanceIsCrouched);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StanceIsCrouched, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MirroredNess);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredNess, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutCapeState);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCapeState, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutCapeTransitionState);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCapeTransitionState, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StanceIsCrouched = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch>(paramsPtr + 0);
        MirroredNess = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(paramsPtr + 1);
        OutCapeState = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 12);
        OutCapeTransitionState = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetAutoTargetRotation;
    /// <summary>
    /// Function: GetAutoTargetRotation
    /// </summary>
    public unsafe override BmSDK.Rotator GetAutoTargetRotation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAutoTargetRotation, "BmGame.RDisruptorSniper.GetAutoTargetRotation");
        byte* paramsPtr = stackalloc byte[12];
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

    private static BmSDK.Function __fn_GetNearestPointOnGeometryToHitLocation;
    /// <summary>
    /// Function: GetNearestPointOnGeometryToHitLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetNearestPointOnGeometryToHitLocation(BmSDK.BmGame.RInventoryGadget.FHighlightedMesh Target, System.Numerics.Vector3 vHitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNearestPointOnGeometryToHitLocation, "BmGame.RDisruptorSniper.GetNearestPointOnGeometryToHitLocation");
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vHitLocation, paramsPtr + 88);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 100);
    }

    private static BmSDK.Function __fn_GetSniperTarget;
    /// <summary>
    /// Function: GetSniperTarget
    /// </summary>
    public unsafe virtual bool GetSniperTarget(out BmSDK.BmGame.RInventoryGadget.FHighlightedMesh OutTarget, out System.Numerics.Vector3 vHitLocation, out BmSDK.BmGame.RInventoryGadget.FHighlightedMesh NearestTarget, float NearestAngleInDegrees)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSniperTarget, "BmGame.RDisruptorSniper.GetSniperTarget");
        byte* paramsPtr = stackalloc byte[196];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out vHitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vHitLocation, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NearestAngleInDegrees, paramsPtr + 188);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutTarget = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget.FHighlightedMesh>(paramsPtr + 0);
        vHitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 88);
        NearestTarget = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget.FHighlightedMesh>(paramsPtr + 100);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 192);
    }

    private static BmSDK.Function __fn_IsHighlightedMeshCurrentTarget;
    /// <summary>
    /// Function: IsHighlightedMeshCurrentTarget
    /// </summary>
    public unsafe override bool IsHighlightedMeshCurrentTarget(BmSDK.Engine.MeshComponent CheckHighlightedMesh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHighlightedMeshCurrentTarget, "BmGame.RDisruptorSniper.IsHighlightedMeshCurrentTarget");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckHighlightedMesh, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AllowHighlightToBeHidden;
    /// <summary>
    /// Function: AllowHighlightToBeHidden
    /// </summary>
    public unsafe override bool AllowHighlightToBeHidden(BmSDK.BmGame.RInventoryGadget.FHighlightedMesh CheckHighlightedMesh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowHighlightToBeHidden, "BmGame.RDisruptorSniper.AllowHighlightToBeHidden");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckHighlightedMesh, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 88);
    }

    private static BmSDK.Function __fn_SetViewInDisruptorModeOnPrimitiveComponent;
    /// <summary>
    /// Function: SetViewInDisruptorModeOnPrimitiveComponent
    /// </summary>
    public unsafe virtual void SetViewInDisruptorModeOnPrimitiveComponent(BmSDK.Engine.PrimitiveComponent TheComponent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetViewInDisruptorModeOnPrimitiveComponent, "BmGame.RDisruptorSniper.SetViewInDisruptorModeOnPrimitiveComponent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheComponent, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsDisruptorAimingAtValidDisruptableLocationOnTarget;
    /// <summary>
    /// Function: IsDisruptorAimingAtValidDisruptableLocationOnTarget
    /// </summary>
    public unsafe virtual bool IsDisruptorAimingAtValidDisruptableLocationOnTarget(BmSDK.Engine.Actor TargetActor, System.Numerics.Vector3 vTargetLocation, BmSDK.FName nHitBoneName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDisruptorAimingAtValidDisruptableLocationOnTarget, "BmGame.RDisruptorSniper.IsDisruptorAimingAtValidDisruptableLocationOnTarget");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vTargetLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nHitBoneName, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_UpdateCornerCoverLean;
    /// <summary>
    /// Function: UpdateCornerCoverLean
    /// </summary>
    public unsafe virtual void UpdateCornerCoverLean()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCornerCoverLean, "BmGame.RDisruptorSniper.UpdateCornerCoverLean");
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

    private static BmSDK.Function __fn_UpdateDisruptorHighlightMaterials;
    /// <summary>
    /// Function: UpdateDisruptorHighlightMaterials
    /// </summary>
    public unsafe virtual void UpdateDisruptorHighlightMaterials()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateDisruptorHighlightMaterials, "BmGame.RDisruptorSniper.UpdateDisruptorHighlightMaterials");
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

    private static BmSDK.Function __fn_GetCorrectMIC;
    /// <summary>
    /// Function: GetCorrectMIC
    /// </summary>
    public unsafe override BmSDK.Engine.MaterialInterface GetCorrectMIC(BmSDK.BmGame.RInventoryGadget.EHighlightedTargetType TargetType, bool bShotByDisruptor, bool bSniperHasAmmoLeft, bool bWeaponReadyToExplode, bool bUpgradeNeeded, bool bNormalViewMode, bool bForCamouflageThug, bool bSpecialTrackerTarget, bool bCurrentTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCorrectMIC, "BmGame.RDisruptorSniper.GetCorrectMIC");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShotByDisruptor, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSniperHasAmmoLeft, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWeaponReadyToExplode, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUpgradeNeeded, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNormalViewMode, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForCamouflageThug, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialTrackerTarget, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCurrentTarget, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.MaterialInterface>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_SetCorrectMICOnMesh;
    /// <summary>
    /// Function: SetCorrectMICOnMesh
    /// </summary>
    public unsafe override void SetCorrectMICOnMesh(BmSDK.Engine.Actor NewActor, BmSDK.Engine.MeshComponent HighlightMesh, BmSDK.BmGame.RInventoryGadget.EHighlightedTargetType TargetType, bool bShotByDisruptor, bool bSniperHasAmmoLeft, bool bWeaponReadyToExplode, bool bUpgradeNeeded, bool bNormalViewMode, bool bForCamouflageThug, bool bSpecialTrackerTarget, bool bCurrentTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCorrectMICOnMesh, "BmGame.RDisruptorSniper.SetCorrectMICOnMesh");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HighlightMesh, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShotByDisruptor, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSniperHasAmmoLeft, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWeaponReadyToExplode, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUpgradeNeeded, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNormalViewMode, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForCamouflageThug, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialTrackerTarget, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCurrentTarget, paramsPtr + 48);
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

    private static BmSDK.Function __fn_PrimedUpdateIndividualTargetHighlight;
    /// <summary>
    /// Function: PrimedUpdateIndividualTargetHighlight
    /// </summary>
    public unsafe override void PrimedUpdateIndividualTargetHighlight(BmSDK.Engine.Actor CheckTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrimedUpdateIndividualTargetHighlight, "BmGame.RDisruptorSniper.PrimedUpdateIndividualTargetHighlight");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckTarget, paramsPtr + 0);
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

    private static BmSDK.Function __fn_HolsteredShouldHighlightBeMaintained;
    /// <summary>
    /// Function: HolsteredShouldHighlightBeMaintained
    /// </summary>
    public unsafe override bool HolsteredShouldHighlightBeMaintained(BmSDK.BmGame.RInventoryGadget.FHighlightedMesh CheckHighlightedMesh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HolsteredShouldHighlightBeMaintained, "BmGame.RDisruptorSniper.HolsteredShouldHighlightBeMaintained");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckHighlightedMesh, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 88);
    }

    private static BmSDK.Function __fn_PrimedUpdateHighlights;
    /// <summary>
    /// Function: PrimedUpdateHighlights
    /// </summary>
    public unsafe override void PrimedUpdateHighlights()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrimedUpdateHighlights, "BmGame.RDisruptorSniper.PrimedUpdateHighlights");
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
    /// Struct: FDisruptedEquipmentRecord
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FDisruptedEquipmentRecord
    {
        /// <summary>
        /// ObjectProperty: OwnerPawn
        /// </summary>
        public unsafe BmSDK.BmGame.RPawn OwnerPawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ComponentProperty: LocationComponent
        /// </summary>
        public unsafe BmSDK.Engine.PrimitiveComponent LocationComponent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: OptionalWeaponActor
        /// </summary>
        public unsafe BmSDK.BmGame.RBMWeapon OptionalWeaponActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeapon>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: NameIndex
        /// </summary>
        public unsafe int NameIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: EHighlightedMaterialType
    /// </summary>
    public enum EHighlightedMaterialType : byte
    {
        HMT_Threat = 0,
        HMT_Tracker = 1,
        HMT_Tagged = 2,
        HMT_TaggedInNormalViewMode = 3,
        HMT_Explode = 4,
        HMT_ExplodeInNormalViewMode = 5,
        HMT_NoAmmo = 6,
        HMT_NeedsUpgrade = 7,
        HMT_MAX = 8,
    }

    /// <summary>
    /// StructProperty: FireOverlayAnimation
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId FireOverlayAnimation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 2068);

    /// <summary>
    /// BoolProperty: bBatmanHasFinishedEquippingGadget
    /// </summary>
    public unsafe bool bBatmanHasFinishedEquippingGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanCanPurchaseDroneDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanCanPurchaseDroneDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasDroneDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasDroneDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasMineDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasMineDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasDetectiveModeJammerDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasDetectiveModeJammerDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasDetectiveModeDetectorDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasDetectiveModeDetectorDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasMinidroneControllerDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasMinidroneControllerDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasStunStickDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasStunStickDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasMedicDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasMedicDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasInvisibleThugDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasInvisibleThugDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasExtraAmmoUpgrade
    /// </summary>
    public unsafe bool bBatmanHasExtraAmmoUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasSentryGunDispenserDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasSentryGunDispenserDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasRHDBlindDroneUpgrade
    /// </summary>
    public unsafe bool bBatmanHasRHDBlindDroneUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bScreenHasFinishedTurningOn
    /// </summary>
    public unsafe bool bScreenHasFinishedTurningOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bAllowedToUseGadgetCamera
    /// </summary>
    public unsafe bool bAllowedToUseGadgetCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bCanMuzzleAim
    /// </summary>
    public unsafe bool bCanMuzzleAim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bPostProcessIsTurnedOn
    /// </summary>
    public unsafe bool bPostProcessIsTurnedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: DisruptorSuppressingSurveillance
    /// </summary>
    public unsafe bool DisruptorSuppressingSurveillance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bPauseAmmoRechargeForTutorial
    /// </summary>
    public unsafe bool bPauseAmmoRechargeForTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// StructProperty: NormalFireScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct NormalFireScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2080);

    /// <summary>
    /// StructProperty: ZoomedFireScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ZoomedFireScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2236);

    /// <summary>
    /// FloatProperty: ReplenishTime
    /// </summary>
    public unsafe float ReplenishTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }
    }

    /// <summary>
    /// ArrayProperty: CurrentTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> CurrentTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// ByteProperty: CurrentMagazineType
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.EHighlightedTargetType CurrentMagazineType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.EHighlightedTargetType>(Ptr + 2412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2412); }
    }

    /// <summary>
    /// ByteProperty: LastPerchDirection
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.PerchDirection LastPerchDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.PerchDirection>(Ptr + 2413); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2413); }
    }

    /// <summary>
    /// FloatProperty: fDelayBetweenMagazineChanges
    /// </summary>
    public unsafe float fDelayBetweenMagazineChanges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// FloatProperty: fNextMagazineChangeAllowedCountdown
    /// </summary>
    public unsafe float fNextMagazineChangeAllowedCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// StructProperty: CrosshairTarget
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryGadget.FHighlightedMesh CrosshairTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryGadget.FHighlightedMesh>(Ptr + 2424);

    /// <summary>
    /// StructProperty: CrosshairNearestTarget
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryGadget.FHighlightedMesh CrosshairNearestTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryGadget.FHighlightedMesh>(Ptr + 2512);

    /// <summary>
    /// StructProperty: CrosshairTrackingTarget
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryGadget.FHighlightedMesh CrosshairTrackingTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryGadget.FHighlightedMesh>(Ptr + 2600);

    /// <summary>
    /// StructProperty: vCrosshairTargetHitLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 vCrosshairTargetHitLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2688);

    /// <summary>
    /// ObjectProperty: RestrictedTargetsSequenceAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_RestrictDisruptorTargets RestrictedTargetsSequenceAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_RestrictDisruptorTargets>(Ptr + 2700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2700); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: NormalDisruptorModeMaterials
    /// </summary>
    public InlineArray<BmSDK.Engine.MaterialInterface> NormalDisruptorModeMaterials => new(8, Ptr + 2708, 8, this);

    /// <summary>
    /// ObjectProperty: NormalDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface NormalDisruptorModeMaterials_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2708); }
    }
    /// <summary>
    /// ObjectProperty: NormalDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface NormalDisruptorModeMaterials_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2716); }
    }
    /// <summary>
    /// ObjectProperty: NormalDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface NormalDisruptorModeMaterials_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2724); }
    }
    /// <summary>
    /// ObjectProperty: NormalDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface NormalDisruptorModeMaterials_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2732); }
    }
    /// <summary>
    /// ObjectProperty: NormalDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface NormalDisruptorModeMaterials_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2740); }
    }
    /// <summary>
    /// ObjectProperty: NormalDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface NormalDisruptorModeMaterials_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2748); }
    }
    /// <summary>
    /// ObjectProperty: NormalDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface NormalDisruptorModeMaterials_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2756); }
    }
    /// <summary>
    /// ObjectProperty: NormalDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface NormalDisruptorModeMaterials_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2764); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: CurrentTargetDisruptorModeMaterials
    /// </summary>
    public InlineArray<BmSDK.Engine.MaterialInterface> CurrentTargetDisruptorModeMaterials => new(8, Ptr + 2772, 8, this);

    /// <summary>
    /// ObjectProperty: CurrentTargetDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface CurrentTargetDisruptorModeMaterials_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2772); }
    }
    /// <summary>
    /// ObjectProperty: CurrentTargetDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface CurrentTargetDisruptorModeMaterials_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2780); }
    }
    /// <summary>
    /// ObjectProperty: CurrentTargetDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface CurrentTargetDisruptorModeMaterials_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2788); }
    }
    /// <summary>
    /// ObjectProperty: CurrentTargetDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface CurrentTargetDisruptorModeMaterials_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2796); }
    }
    /// <summary>
    /// ObjectProperty: CurrentTargetDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface CurrentTargetDisruptorModeMaterials_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2804); }
    }
    /// <summary>
    /// ObjectProperty: CurrentTargetDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface CurrentTargetDisruptorModeMaterials_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2812); }
    }
    /// <summary>
    /// ObjectProperty: CurrentTargetDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface CurrentTargetDisruptorModeMaterials_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2820); }
    }
    /// <summary>
    /// ObjectProperty: CurrentTargetDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface CurrentTargetDisruptorModeMaterials_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2828); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: DisruptorModeMaterialsForCamouflageThug
    /// </summary>
    public InlineArray<BmSDK.Engine.MaterialInterface> DisruptorModeMaterialsForCamouflageThug => new(8, Ptr + 2836, 8, this);

    /// <summary>
    /// ObjectProperty: DisruptorModeMaterialsForCamouflageThug
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DisruptorModeMaterialsForCamouflageThug_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2836); }
    }
    /// <summary>
    /// ObjectProperty: DisruptorModeMaterialsForCamouflageThug
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DisruptorModeMaterialsForCamouflageThug_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2844); }
    }
    /// <summary>
    /// ObjectProperty: DisruptorModeMaterialsForCamouflageThug
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DisruptorModeMaterialsForCamouflageThug_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2852); }
    }
    /// <summary>
    /// ObjectProperty: DisruptorModeMaterialsForCamouflageThug
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DisruptorModeMaterialsForCamouflageThug_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2860); }
    }
    /// <summary>
    /// ObjectProperty: DisruptorModeMaterialsForCamouflageThug
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DisruptorModeMaterialsForCamouflageThug_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2868); }
    }
    /// <summary>
    /// ObjectProperty: DisruptorModeMaterialsForCamouflageThug
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DisruptorModeMaterialsForCamouflageThug_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2876); }
    }
    /// <summary>
    /// ObjectProperty: DisruptorModeMaterialsForCamouflageThug
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DisruptorModeMaterialsForCamouflageThug_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2884); }
    }
    /// <summary>
    /// ObjectProperty: DisruptorModeMaterialsForCamouflageThug
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DisruptorModeMaterialsForCamouflageThug_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2892); }
    }

    /// <summary>
    /// ObjectProperty: HighlightBlankMaterial
    /// </summary>
    public unsafe BmSDK.Engine.Material HighlightBlankMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material>(Ptr + 2900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2900); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: FireSound
    /// </summary>
    public InlineArray<BmSDK.Engine.AkEvent> FireSound => new(8, Ptr + 2908, 8, this);

    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2908); }
    }
    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2916); }
    }
    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2924); }
    }
    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2932); }
    }
    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2940); }
    }
    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2948); }
    }
    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2956); }
    }
    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2964); }
    }

    /// <summary>
    /// ObjectProperty: DoubleDisruptedFireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DoubleDisruptedFireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2972); }
    }

    /// <summary>
    /// ObjectProperty: NoAmmoFireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent NoAmmoFireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2980); }
    }

    /// <summary>
    /// ObjectProperty: AttemptToDisruptFullyDisruptedTargetFireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AttemptToDisruptFullyDisruptedTargetFireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2988); }
    }

    /// <summary>
    /// ObjectProperty: ShotGlassSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ShotGlassSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2996); }
    }

    /// <summary>
    /// ObjectProperty: TracerEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem TracerEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3004); }
    }

    /// <summary>
    /// ObjectProperty: CantDoubleJamMinigunThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CantDoubleJamMinigunThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3012); }
    }

    /// <summary>
    /// ObjectProperty: CantDoubleJamRocketLauncherThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CantDoubleJamRocketLauncherThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3020); }
    }

    /// <summary>
    /// ObjectProperty: NoAmmoLeftThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech NoAmmoLeftThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3028); }
    }

    /// <summary>
    /// ObjectProperty: CantShootSentryGunThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CantShootSentryGunThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3036); }
    }

    /// <summary>
    /// ObjectProperty: CantShootWatchtowerTurretThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CantShootWatchtowerTurretThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3044); }
    }

    /// <summary>
    /// ObjectProperty: CantShootSentryGunButHaveRHDBlinderThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CantShootSentryGunButHaveRHDBlinderThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3052); }
    }

    /// <summary>
    /// ObjectProperty: CantShootWatchtowerTurretButHaveRHDBlinderThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CantShootWatchtowerTurretButHaveRHDBlinderThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3060); }
    }

    /// <summary>
    /// ObjectProperty: CantShootRobotGunThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CantShootRobotGunThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3068); }
    }

    /// <summary>
    /// ObjectProperty: NeedUpgradeThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech NeedUpgradeThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3076); }
    }

    /// <summary>
    /// ObjectProperty: ScreenMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant ScreenMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3084); }
    }

    /// <summary>
    /// ObjectProperty: MuzzleAimSkelControl
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlLookAt MuzzleAimSkelControl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlLookAt>(Ptr + 3092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3092); }
    }

    /// <summary>
    /// ObjectProperty: HitRandomObjectVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HitRandomObjectVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3100); }
    }

    /// <summary>
    /// ObjectProperty: HitGlassVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HitGlassVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3108); }
    }

    /// <summary>
    /// FloatProperty: AimRadius
    /// </summary>
    public unsafe float AimRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3116); }
    }

    /// <summary>
    /// IntProperty: iAntiEquipmentMaximumAmmo
    /// </summary>
    public unsafe int iAntiEquipmentMaximumAmmo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3120); }
    }

    /// <summary>
    /// IntProperty: iAntiEquipmentRemainingAmmo
    /// </summary>
    public unsafe int iAntiEquipmentRemainingAmmo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3124); }
    }

    /// <summary>
    /// StrProperty: sNextTargetModuleEvent
    /// </summary>
    public unsafe BmSDK.FString sNextTargetModuleEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3128); }
    }

    /// <summary>
    /// FloatProperty: fScreenOnPercentage
    /// </summary>
    public unsafe float fScreenOnPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3144); }
    }

    /// <summary>
    /// FloatProperty: fScreenTurnOnSpeed
    /// </summary>
    public unsafe float fScreenTurnOnSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3148); }
    }

    /// <summary>
    /// FloatProperty: fMuzzleAimSkelControlFadeOutTimeLeft
    /// </summary>
    public unsafe float fMuzzleAimSkelControlFadeOutTimeLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3152); }
    }

    /// <summary>
    /// FloatProperty: fCornerCoverAimUpWeight
    /// </summary>
    public unsafe float fCornerCoverAimUpWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3156); }
    }

    /// <summary>
    /// FloatProperty: fCornerCoverAimDownWeight
    /// </summary>
    public unsafe float fCornerCoverAimDownWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3160); }
    }

    /// <summary>
    /// ArrayProperty: DisruptedEquipmentArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDisruptorSniper.FDisruptedEquipmentRecord> DisruptedEquipmentArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDisruptorSniper.FDisruptedEquipmentRecord>>(Ptr + 3164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3164); }
    }

    /// <summary>
    /// IntProperty: NameIndexTracker
    /// </summary>
    public unsafe int NameIndexTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3180); }
    }

    /// <summary>
    /// ArrayProperty: RestrictedTargetsSequenceActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_RestrictDisruptorTargets> RestrictedTargetsSequenceActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_RestrictDisruptorTargets>>(Ptr + 3184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3184); }
    }
}
