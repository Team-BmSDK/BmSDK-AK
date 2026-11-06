#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RVehicleBatmobileBase<br/>
/// (size = 8352)
/// (flags = 144704183)
/// </summary>
public partial class RVehicleBatmobileBase : BmSDK.BmGame.RVehicle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBatmobileBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RVehicleBatmobileBase.
    /// </summary>
    public static RVehicleBatmobileBase DefaultObject => (RVehicleBatmobileBase)StaticClass().DefaultObject;

    internal RVehicleBatmobileBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBatmobileBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobileBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobileBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobileBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobileBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobileBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobileBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobileBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobileBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetCameraTrackingOffset;
    /// <summary>
    /// Function: GetCameraTrackingOffset
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetCameraTrackingOffset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraTrackingOffset, "BmGame.RVehicleBatmobileBase.GetCameraTrackingOffset");
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

    private static BmSDK.Function __fn_NoFailWeapon;
    /// <summary>
    /// Function: NoFailWeapon
    /// </summary>
    public unsafe virtual void NoFailWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NoFailWeapon, "BmGame.RVehicleBatmobileBase.NoFailWeapon");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBatmobileTouchingAGlideOutOfBoundsVolume;
    /// <summary>
    /// Function: IsBatmobileTouchingAGlideOutOfBoundsVolume
    /// </summary>
    public unsafe virtual bool IsBatmobileTouchingAGlideOutOfBoundsVolume()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatmobileTouchingAGlideOutOfBoundsVolume, "BmGame.RVehicleBatmobileBase.IsBatmobileTouchingAGlideOutOfBoundsVolume");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAbseilBlocked;
    /// <summary>
    /// Function: IsAbseilBlocked
    /// </summary>
    public unsafe virtual bool IsAbseilBlocked()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAbseilBlocked, "BmGame.RVehicleBatmobileBase.IsAbseilBlocked");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CLearAbseilBlocked;
    /// <summary>
    /// Function: CLearAbseilBlocked
    /// </summary>
    public unsafe virtual void CLearAbseilBlocked()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CLearAbseilBlocked, "BmGame.RVehicleBatmobileBase.CLearAbseilBlocked");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAbseilBlocked;
    /// <summary>
    /// Function: SetAbseilBlocked
    /// </summary>
    public unsafe virtual void SetAbseilBlocked(BmSDK.Engine.ParticleSystem blockingParticle, BmSDK.Engine.AkEvent particleSFX)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAbseilBlocked, "BmGame.RVehicleBatmobileBase.SetAbseilBlocked");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(blockingParticle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(particleSFX, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RigidBodyCollisionWithScrew;
    /// <summary>
    /// Function: RigidBodyCollisionWithScrew
    /// </summary>
    public unsafe virtual void RigidBodyCollisionWithScrew(BmSDK.BmGame.RBatmobileScrewSpikesBase Spikes, BmSDK.BmGame.RBatmobileScrewBase Screw, System.Numerics.Vector3 PosOnSelf, System.Numerics.Vector3 ContactPos, System.Numerics.Vector3 ContactNormal, float Speed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RigidBodyCollisionWithScrew, "BmGame.RVehicleBatmobileBase.RigidBodyCollisionWithScrew");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spikes, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Screw, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PosOnSelf, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactPos, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactNormal, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldRadialDamageHit;
    /// <summary>
    /// Function: ShouldRadialDamageHit
    /// </summary>
    public unsafe virtual bool ShouldRadialDamageHit(System.Numerics.Vector3 DamageLocation, float DamageRadius)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldRadialDamageHit, "BmGame.RVehicleBatmobileBase.ShouldRadialDamageHit");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageRadius, paramsPtr + 12);
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

    private static BmSDK.Function __fn_DoubleDodgeTimer;
    /// <summary>
    /// Function: DoubleDodgeTimer
    /// </summary>
    public unsafe virtual void DoubleDodgeTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoubleDodgeTimer, "BmGame.RVehicleBatmobileBase.DoubleDodgeTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnModifyHealth;
    /// <summary>
    /// Function: OnModifyHealth
    /// </summary>
    public unsafe override void OnModifyHealth(BmSDK.Engine.SeqAct_ModifyHealth Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnModifyHealth, "BmGame.RVehicleBatmobileBase.OnModifyHealth");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LandedJumpFinished;
    /// <summary>
    /// Function: LandedJumpFinished
    /// </summary>
    public unsafe virtual void LandedJumpFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LandedJumpFinished, "BmGame.RVehicleBatmobileBase.LandedJumpFinished");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LandedJump;
    /// <summary>
    /// Function: LandedJump
    /// </summary>
    public unsafe virtual void LandedJump()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LandedJump, "BmGame.RVehicleBatmobileBase.LandedJump");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBatmanVsBatmobileCollisionMode;
    /// <summary>
    /// Function: SetBatmanVsBatmobileCollisionMode
    /// </summary>
    public unsafe virtual void SetBatmanVsBatmobileCollisionMode(BmSDK.BmGame.RVehicleBatmobileBase.EBatmanVsBatmobileCollisionMode Mode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBatmanVsBatmobileCollisionMode, "BmGame.RVehicleBatmobileBase.SetBatmanVsBatmobileCollisionMode");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsJokerfiedBatmobile;
    /// <summary>
    /// Function: IsJokerfiedBatmobile
    /// </summary>
    public unsafe virtual bool IsJokerfiedBatmobile()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsJokerfiedBatmobile, "BmGame.RVehicleBatmobileBase.IsJokerfiedBatmobile");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPrototypeBatmobile;
    /// <summary>
    /// Function: IsPrototypeBatmobile
    /// </summary>
    public unsafe virtual bool IsPrototypeBatmobile()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPrototypeBatmobile, "BmGame.RVehicleBatmobileBase.IsPrototypeBatmobile");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CancelPickup;
    /// <summary>
    /// Function: CancelPickup
    /// </summary>
    public unsafe virtual void CancelPickup()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelPickup, "BmGame.RVehicleBatmobileBase.CancelPickup");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckRiddleScanVisibility;
    /// <summary>
    /// Function: CheckRiddleScanVisibility
    /// </summary>
    public unsafe virtual bool CheckRiddleScanVisibility(BmSDK.GameObject.FTPOV CameraPOV, out BmSDK.BmGame.RGameInfo.FVisibilityResult ReasonItFailed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckRiddleScanVisibility, "BmGame.RVehicleBatmobileBase.CheckRiddleScanVisibility");
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraPOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ReasonItFailed = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.FVisibilityResult>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_RiddleFound;
    /// <summary>
    /// Function: RiddleFound
    /// </summary>
    public unsafe virtual void RiddleFound(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RiddleFound, "BmGame.RVehicleBatmobileBase.RiddleFound");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRiddle;
    /// <summary>
    /// Function: GetRiddle
    /// </summary>
    public unsafe virtual BmSDK.FString GetRiddle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRiddle, "BmGame.RVehicleBatmobileBase.GetRiddle");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RiddleReScanned;
    /// <summary>
    /// Function: RiddleReScanned
    /// </summary>
    public unsafe virtual void RiddleReScanned(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RiddleReScanned, "BmGame.RVehicleBatmobileBase.RiddleReScanned");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakePhoto;
    /// <summary>
    /// Function: TakePhoto
    /// </summary>
    public unsafe virtual void TakePhoto(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakePhoto, "BmGame.RVehicleBatmobileBase.TakePhoto");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExperienceAwarded;
    /// <summary>
    /// Function: ExperienceAwarded
    /// </summary>
    public unsafe virtual void ExperienceAwarded(int XpAwarded, int TeethXpAwarded)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExperienceAwarded, "BmGame.RVehicleBatmobileBase.ExperienceAwarded");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XpAwarded, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeethXpAwarded, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendHydraEventBankXP;
    /// <summary>
    /// Function: SendHydraEventBankXP
    /// </summary>
    public unsafe virtual void SendHydraEventBankXP(int XpAwarded, int XpTotal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraEventBankXP, "BmGame.RVehicleBatmobileBase.SendHydraEventBankXP");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XpAwarded, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XpTotal, paramsPtr + 4);
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

    private static BmSDK.Function __fn_Detonate;
    /// <summary>
    /// Function: Detonate
    /// </summary>
    public unsafe virtual void Detonate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Detonate, "BmGame.RVehicleBatmobileBase.Detonate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDetonatePrompt;
    /// <summary>
    /// Function: GetDetonatePrompt
    /// </summary>
    public unsafe virtual BmSDK.FString GetDetonatePrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDetonatePrompt, "BmGame.RVehicleBatmobileBase.GetDetonatePrompt");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayDetonateAnim;
    /// <summary>
    /// Function: PlayDetonateAnim
    /// </summary>
    public unsafe virtual bool PlayDetonateAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDetonateAnim, "BmGame.RVehicleBatmobileBase.PlayDetonateAnim");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ReadyToDetonate;
    /// <summary>
    /// Function: ReadyToDetonate
    /// </summary>
    public unsafe virtual bool ReadyToDetonate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadyToDetonate, "BmGame.RVehicleBatmobileBase.ReadyToDetonate");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NoLongerZappable;
    /// <summary>
    /// Function: NoLongerZappable
    /// </summary>
    public unsafe virtual void NoLongerZappable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NoLongerZappable, "BmGame.RVehicleBatmobileBase.NoLongerZappable");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MakeReadyForThugZapper;
    /// <summary>
    /// Function: MakeReadyForThugZapper
    /// </summary>
    public unsafe virtual void MakeReadyForThugZapper()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeReadyForThugZapper, "BmGame.RVehicleBatmobileBase.MakeReadyForThugZapper");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopEMP;
    /// <summary>
    /// Function: StopEMP
    /// </summary>
    public unsafe virtual void StopEMP()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopEMP, "BmGame.RVehicleBatmobileBase.StopEMP");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FiredEMP;
    /// <summary>
    /// Function: FiredEMP
    /// </summary>
    public unsafe virtual void FiredEMP()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FiredEMP, "BmGame.RVehicleBatmobileBase.FiredEMP");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugSetTireLatSlipMod;
    /// <summary>
    /// Function: DebugSetTireLatSlipMod
    /// </summary>
    public unsafe static void DebugSetTireLatSlipMod(BmSDK.Engine.SVehicleWheel.ETyreType TyreType, float NewLatSlipMod)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugSetTireLatSlipMod, "BmGame.RVehicleBatmobileBase.DebugSetTireLatSlipMod");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TyreType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLatSlipMod, paramsPtr + 4);
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

    private static BmSDK.Function __fn_DebugSetTireFrictionMod;
    /// <summary>
    /// Function: DebugSetTireFrictionMod
    /// </summary>
    public unsafe static void DebugSetTireFrictionMod(BmSDK.Engine.SVehicleWheel.ETyreType TyreType, float NewFrictionMod)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugSetTireFrictionMod, "BmGame.RVehicleBatmobileBase.DebugSetTireFrictionMod");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TyreType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFrictionMod, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetTargetLocation;
    /// <summary>
    /// Function: GetTargetLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetTargetLocation(BmSDK.Engine.Actor RequestedBy = default, bool bRequestAlternateLoc = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetLocation, "BmGame.RVehicleBatmobileBase.GetTargetLocation");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRequestAlternateLoc, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_TutorialActionAchieved;
    /// <summary>
    /// Function: TutorialActionAchieved
    /// </summary>
    public unsafe virtual void TutorialActionAchieved(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TutorialActionAchieved, "BmGame.RVehicleBatmobileBase.TutorialActionAchieved");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetChainGun;
    /// <summary>
    /// Function: GetChainGun
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBatmobileCannon GetChainGun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChainGun, "BmGame.RVehicleBatmobileBase.GetChainGun");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBatmobileCannon>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ReloadBattleModeWeapons;
    /// <summary>
    /// Function: ReloadBattleModeWeapons
    /// </summary>
    public unsafe virtual void ReloadBattleModeWeapons()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReloadBattleModeWeapons, "BmGame.RVehicleBatmobileBase.ReloadBattleModeWeapons");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GrappleSwingIn;
    /// <summary>
    /// Function: GrappleSwingIn
    /// </summary>
    public unsafe virtual void GrappleSwingIn(BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrappleSwingIn, "BmGame.RVehicleBatmobileBase.GrappleSwingIn");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelBatmobileTakedown;
    /// <summary>
    /// Function: CancelBatmobileTakedown
    /// </summary>
    public unsafe virtual void CancelBatmobileTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelBatmobileTakedown, "BmGame.RVehicleBatmobileBase.CancelBatmobileTakedown");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExecuteBatmobileTakedown;
    /// <summary>
    /// Function: ExecuteBatmobileTakedown
    /// </summary>
    public unsafe virtual void ExecuteBatmobileTakedown(BmSDK.BmGame.RPawnVillain Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExecuteBatmobileTakedown, "BmGame.RVehicleBatmobileBase.ExecuteBatmobileTakedown");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrepareForBatmobileTakedown;
    /// <summary>
    /// Function: PrepareForBatmobileTakedown
    /// </summary>
    public unsafe virtual void PrepareForBatmobileTakedown(BmSDK.BmGame.RPawnVillain Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepareForBatmobileTakedown, "BmGame.RVehicleBatmobileBase.PrepareForBatmobileTakedown");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NoSteerTimer;
    /// <summary>
    /// Function: NoSteerTimer
    /// </summary>
    public unsafe virtual void NoSteerTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NoSteerTimer, "BmGame.RVehicleBatmobileBase.NoSteerTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableThrottleUntilReleased;
    /// <summary>
    /// Function: DisableThrottleUntilReleased
    /// </summary>
    public unsafe virtual void DisableThrottleUntilReleased()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableThrottleUntilReleased, "BmGame.RVehicleBatmobileBase.DisableThrottleUntilReleased");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldCameraZFollowVehicleUp;
    /// <summary>
    /// Function: ShouldCameraZFollowVehicleUp
    /// </summary>
    public unsafe override bool ShouldCameraZFollowVehicleUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldCameraZFollowVehicleUp, "BmGame.RVehicleBatmobileBase.ShouldCameraZFollowVehicleUp");
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

    private static BmSDK.Function __fn_SpawnThugStunEffect;
    /// <summary>
    /// Function: SpawnThugStunEffect
    /// </summary>
    public unsafe virtual void SpawnThugStunEffect(BmSDK.BmGame.RBMPawnAI Thug, System.Numerics.Vector3 ThugDiveDirection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnThugStunEffect, "BmGame.RVehicleBatmobileBase.SpawnThugStunEffect");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thug, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugDiveDirection, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoseMissileLock;
    /// <summary>
    /// Function: LoseMissileLock
    /// </summary>
    public unsafe virtual void LoseMissileLock(BmSDK.BmGame.RVehicleNPC ImpactedVeh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoseMissileLock, "BmGame.RVehicleBatmobileBase.LoseMissileLock");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactedVeh, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NewTargetTracked;
    /// <summary>
    /// Function: NewTargetTracked
    /// </summary>
    public unsafe virtual void NewTargetTracked(BmSDK.BmGame.RVehicleNPC NewTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NewTargetTracked, "BmGame.RVehicleBatmobileBase.NewTargetTracked");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UsedWhenStolen;
    /// <summary>
    /// Function: UsedWhenStolen
    /// </summary>
    public unsafe virtual void UsedWhenStolen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UsedWhenStolen, "BmGame.RVehicleBatmobileBase.UsedWhenStolen");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIsStolen;
    /// <summary>
    /// Function: SetIsStolen
    /// </summary>
    public unsafe virtual void SetIsStolen(bool Stolen, BmSDK.Engine.SequenceAction Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIsStolen, "BmGame.RVehicleBatmobileBase.SetIsStolen");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stolen, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNextEjectAction;
    /// <summary>
    /// Function: SetNextEjectAction
    /// </summary>
    public unsafe virtual void SetNextEjectAction(BmSDK.BmGame.RSeqAct_OverrideBatmobileEject NextEjectAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNextEjectAction, "BmGame.RVehicleBatmobileBase.SetNextEjectAction");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextEjectAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckSpaceToGetOutOfBatmobileFromKismet;
    /// <summary>
    /// Function: CheckSpaceToGetOutOfBatmobileFromKismet
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileGetOutSpace CheckSpaceToGetOutOfBatmobileFromKismet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckSpaceToGetOutOfBatmobileFromKismet, "BmGame.RVehicleBatmobileBase.CheckSpaceToGetOutOfBatmobileFromKismet");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileGetOutSpace>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckSpaceToGetOutOfBatmobile;
    /// <summary>
    /// Function: CheckSpaceToGetOutOfBatmobile
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileGetOutSpace CheckSpaceToGetOutOfBatmobile(BmSDK.BmGame.RSpecialMoveConfig MoveToGetOut, out BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckSpaceToGetOutOfBatmobile, "BmGame.RVehicleBatmobileBase.CheckSpaceToGetOutOfBatmobile");
        byte* paramsPtr = stackalloc byte[141];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveToGetOut, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileGetOutSpace>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_CheckSpaceAboveBatmobileCockpit;
    /// <summary>
    /// Function: CheckSpaceAboveBatmobileCockpit
    /// </summary>
    public unsafe virtual bool CheckSpaceAboveBatmobileCockpit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckSpaceAboveBatmobileCockpit, "BmGame.RVehicleBatmobileBase.CheckSpaceAboveBatmobileCockpit");
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

    private static BmSDK.Function __fn_IsLocationInDangerOfCollision;
    /// <summary>
    /// Function: IsLocationInDangerOfCollision
    /// </summary>
    public unsafe override bool IsLocationInDangerOfCollision(System.Numerics.Vector3 TestLocation, float Speed, System.Numerics.Vector3 Direction, System.Numerics.Vector3 LeftVec, float CheckWidth, float MinCos, out int bZap)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLocationInDangerOfCollision, "BmGame.RVehicleBatmobileBase.IsLocationInDangerOfCollision");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeftVec, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckWidth, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinCos, paramsPtr + 44);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bZap);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bZap, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        bZap = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 48);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_DrawCollisionWidthDebug;
    /// <summary>
    /// Function: DrawCollisionWidthDebug
    /// </summary>
    public unsafe virtual void DrawCollisionWidthDebug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawCollisionWidthDebug, "BmGame.RVehicleBatmobileBase.DrawCollisionWidthDebug");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EjectToSpot;
    /// <summary>
    /// Function: EjectToSpot
    /// </summary>
    public unsafe virtual void EjectToSpot(System.Numerics.Vector3 EjectTarget, BmSDK.BmGame.RPawnPlayer Batman, BmSDK.BmGame.RSpecialMoveConfig OverrideMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EjectToSpot, "BmGame.RVehicleBatmobileBase.EjectToSpot");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EjectTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Batman, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMove, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ModifyEjectUpLoc;
    /// <summary>
    /// Function: ModifyEjectUpLoc
    /// </summary>
    public unsafe virtual bool ModifyEjectUpLoc(out BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator outLoc, BmSDK.Engine.Actor CapeTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyEjectUpLoc, "BmGame.RVehicleBatmobileBase.ModifyEjectUpLoc");
        byte* paramsPtr = stackalloc byte[144];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CapeTarget, paramsPtr + 132);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        outLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_FellOutOfWorld;
    /// <summary>
    /// Function: FellOutOfWorld
    /// </summary>
    public unsafe override void FellOutOfWorld(BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FellOutOfWorld, "BmGame.RVehicleBatmobileBase.FellOutOfWorld");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBatmobileViewMeshVisible;
    /// <summary>
    /// Function: SetBatmobileViewMeshVisible
    /// </summary>
    public unsafe virtual void SetBatmobileViewMeshVisible(bool bVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBatmobileViewMeshVisible, "BmGame.RVehicleBatmobileBase.SetBatmobileViewMeshVisible");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AudioVehicleRotating;
    /// <summary>
    /// Function: AudioVehicleRotating
    /// </summary>
    public unsafe override bool AudioVehicleRotating()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioVehicleRotating, "BmGame.RVehicleBatmobileBase.AudioVehicleRotating");
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

    private static BmSDK.Function __fn_AudioAltGetForceWheelSpin;
    /// <summary>
    /// Function: AudioAltGetForceWheelSpin
    /// </summary>
    public unsafe override bool AudioAltGetForceWheelSpin()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioAltGetForceWheelSpin, "BmGame.RVehicleBatmobileBase.AudioAltGetForceWheelSpin");
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

    private static BmSDK.Function __fn_AudioGetForceStop;
    /// <summary>
    /// Function: AudioGetForceStop
    /// </summary>
    public unsafe override bool AudioGetForceStop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioGetForceStop, "BmGame.RVehicleBatmobileBase.AudioGetForceStop");
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

    private static BmSDK.Function __fn_AudioGetAlternateRPMVector;
    /// <summary>
    /// Function: AudioGetAlternateRPMVector
    /// </summary>
    public unsafe override System.Numerics.Vector3 AudioGetAlternateRPMVector()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioGetAlternateRPMVector, "BmGame.RVehicleBatmobileBase.AudioGetAlternateRPMVector");
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

    private static BmSDK.Function __fn_AudioGetAlternateLoad;
    /// <summary>
    /// Function: AudioGetAlternateLoad
    /// </summary>
    public unsafe override float AudioGetAlternateLoad(int Mode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioGetAlternateLoad, "BmGame.RVehicleBatmobileBase.AudioGetAlternateLoad");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AudioGetAlternateRPM;
    /// <summary>
    /// Function: AudioGetAlternateRPM
    /// </summary>
    public unsafe override float AudioGetAlternateRPM(int Mode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioGetAlternateRPM, "BmGame.RVehicleBatmobileBase.AudioGetAlternateRPM");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AudioAltRPMIsPriority;
    /// <summary>
    /// Function: AudioAltRPMIsPriority
    /// </summary>
    public unsafe override bool AudioAltRPMIsPriority(int Mode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioAltRPMIsPriority, "BmGame.RVehicleBatmobileBase.AudioAltRPMIsPriority");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AudioInAlternativeMode;
    /// <summary>
    /// Function: AudioInAlternativeMode
    /// </summary>
    public unsafe override int AudioInAlternativeMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioInAlternativeMode, "BmGame.RVehicleBatmobileBase.AudioInAlternativeMode");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_GetPredictedLocationAndRotation;
    /// <summary>
    /// Function: GetPredictedLocationAndRotation
    /// </summary>
    public unsafe virtual void GetPredictedLocationAndRotation(float TimeInFuture, out System.Numerics.Vector3 PredictedLocation, out BmSDK.Rotator PredictedRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPredictedLocationAndRotation, "BmGame.RVehicleBatmobileBase.GetPredictedLocationAndRotation");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInFuture, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PredictedLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PredictedLocation, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PredictedRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PredictedRotation, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PredictedLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        PredictedRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_SkidToStopJumpIn;
    /// <summary>
    /// Function: SkidToStopJumpIn
    /// </summary>
    public unsafe virtual void SkidToStopJumpIn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SkidToStopJumpIn, "BmGame.RVehicleBatmobileBase.SkidToStopJumpIn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestReachedBrakeToStop;
    /// <summary>
    /// Function: DestReachedBrakeToStop
    /// </summary>
    public unsafe virtual void DestReachedBrakeToStop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestReachedBrakeToStop, "BmGame.RVehicleBatmobileBase.DestReachedBrakeToStop");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestReachedSkidToStop;
    /// <summary>
    /// Function: DestReachedSkidToStop
    /// </summary>
    public unsafe virtual void DestReachedSkidToStop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestReachedSkidToStop, "BmGame.RVehicleBatmobileBase.DestReachedSkidToStop");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBasePawn;
    /// <summary>
    /// Function: CanBasePawn
    /// </summary>
    public unsafe override bool CanBasePawn(BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBasePawn, "BmGame.RVehicleBatmobileBase.CanBasePawn");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_OnSelfDriveArrived;
    /// <summary>
    /// Function: OnSelfDriveArrived
    /// </summary>
    public unsafe override void OnSelfDriveArrived()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSelfDriveArrived, "BmGame.RVehicleBatmobileBase.OnSelfDriveArrived");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelSelfDrive;
    /// <summary>
    /// Function: CancelSelfDrive
    /// </summary>
    public unsafe override void CancelSelfDrive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelSelfDrive, "BmGame.RVehicleBatmobileBase.CancelSelfDrive");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSelfDriveSpline;
    /// <summary>
    /// Function: StartSelfDriveSpline
    /// </summary>
    public unsafe override void StartSelfDriveSpline(BmSDK.BmGame.RRoadSplinePoint StartPoint, BmSDK.BmGame.RSeqAct_VehicleDriveSpline Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSelfDriveSpline, "BmGame.RVehicleBatmobileBase.StartSelfDriveSpline");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetUseFixedTimeDelta;
    /// <summary>
    /// Function: SetUseFixedTimeDelta
    /// </summary>
    public unsafe virtual void SetUseFixedTimeDelta(bool UseFixed, float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetUseFixedTimeDelta, "BmGame.RVehicleBatmobileBase.SetUseFixedTimeDelta");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UseFixed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 4);
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

    private static BmSDK.Function __fn_StartSelfDrive;
    /// <summary>
    /// Function: StartSelfDrive
    /// </summary>
    public unsafe override void StartSelfDrive(BmSDK.BmGame.RRoadNetwork Roads, BmSDK.BmGame.RVehicleBehaviour TellArrived = default, bool WasTeleported = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSelfDrive, "BmGame.RVehicleBatmobileBase.StartSelfDrive");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Roads, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TellArrived, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WasTeleported, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MemoryProfilingMagic;
    /// <summary>
    /// Function: MemoryProfilingMagic
    /// </summary>
    public unsafe virtual void MemoryProfilingMagic()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MemoryProfilingMagic, "BmGame.RVehicleBatmobileBase.MemoryProfilingMagic");
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

    private static BmSDK.Function __fn_EmergencyBrake;
    /// <summary>
    /// Function: EmergencyBrake
    /// </summary>
    public unsafe virtual void EmergencyBrake()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EmergencyBrake, "BmGame.RVehicleBatmobileBase.EmergencyBrake");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FreeBoostTimer;
    /// <summary>
    /// Function: FreeBoostTimer
    /// </summary>
    public unsafe virtual void FreeBoostTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FreeBoostTimer, "BmGame.RVehicleBatmobileBase.FreeBoostTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldMakeFakeRoadCollisionOnSleep;
    /// <summary>
    /// Function: ShouldMakeFakeRoadCollisionOnSleep
    /// </summary>
    public unsafe override bool ShouldMakeFakeRoadCollisionOnSleep()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldMakeFakeRoadCollisionOnSleep, "BmGame.RVehicleBatmobileBase.ShouldMakeFakeRoadCollisionOnSleep");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TeleportCleanup;
    /// <summary>
    /// Function: TeleportCleanup
    /// </summary>
    public unsafe virtual void TeleportCleanup(System.Numerics.Vector3 Loc, BmSDK.Rotator Rot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TeleportCleanup, "BmGame.RVehicleBatmobileBase.TeleportCleanup");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnTeleport;
    /// <summary>
    /// Function: OnTeleport
    /// </summary>
    public unsafe override void OnTeleport(BmSDK.Engine.SeqAct_Teleport Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnTeleport, "BmGame.RVehicleBatmobileBase.OnTeleport");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDistanceToRemoteControlBoundary;
    /// <summary>
    /// Function: GetDistanceToRemoteControlBoundary
    /// </summary>
    public unsafe virtual float GetDistanceToRemoteControlBoundary(float MinDistFromStreamingEdge, float ClearDistFromStreamingEdge, out System.Numerics.Vector3 SafeDir, out byte CompletelyOutsideWorld)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDistanceToRemoteControlBoundary, "BmGame.RVehicleBatmobileBase.GetDistanceToRemoteControlBoundary");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinDistFromStreamingEdge, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClearDistFromStreamingEdge, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SafeDir);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SafeDir, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CompletelyOutsideWorld);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CompletelyOutsideWorld, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SafeDir = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        CompletelyOutsideWorld = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetLocationDistanceToRemoteControlBoundary;
    /// <summary>
    /// Function: GetLocationDistanceToRemoteControlBoundary
    /// </summary>
    public unsafe virtual float GetLocationDistanceToRemoteControlBoundary(System.Numerics.Vector3 Loc, float MinDistFromStreamingEdge, float ClearDistFromStreamingEdge, out System.Numerics.Vector3 SafeDir, bool OnlyCheckRemoteVolumes, out byte CompletelyOutsideWorld)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocationDistanceToRemoteControlBoundary, "BmGame.RVehicleBatmobileBase.GetLocationDistanceToRemoteControlBoundary");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinDistFromStreamingEdge, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClearDistFromStreamingEdge, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SafeDir);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SafeDir, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnlyCheckRemoteVolumes, paramsPtr + 32);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CompletelyOutsideWorld);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CompletelyOutsideWorld, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SafeDir = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
        CompletelyOutsideWorld = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_ForceUnTouch;
    /// <summary>
    /// Function: ForceUnTouch
    /// </summary>
    public unsafe virtual void ForceUnTouch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceUnTouch, "BmGame.RVehicleBatmobileBase.ForceUnTouch");
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

    private static BmSDK.Function __fn_UnPossessed;
    /// <summary>
    /// Function: UnPossessed
    /// </summary>
    public unsafe override void UnPossessed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnPossessed, "BmGame.RVehicleBatmobileBase.UnPossessed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PossessedBy;
    /// <summary>
    /// Function: PossessedBy
    /// </summary>
    public unsafe override void PossessedBy(BmSDK.Engine.Controller C, bool bVehicleTransition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PossessedBy, "BmGame.RVehicleBatmobileBase.PossessedBy");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVehicleTransition, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPassengerInformationSuppressedByFocusDetail;
    /// <summary>
    /// Function: SetPassengerInformationSuppressedByFocusDetail
    /// </summary>
    public unsafe virtual void SetPassengerInformationSuppressedByFocusDetail(bool is_suppressed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPassengerInformationSuppressedByFocusDetail, "BmGame.RVehicleBatmobileBase.SetPassengerInformationSuppressedByFocusDetail");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_suppressed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPassengerInformationSuppressed;
    /// <summary>
    /// Function: SetPassengerInformationSuppressed
    /// </summary>
    public unsafe virtual void SetPassengerInformationSuppressed(bool is_suppressed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPassengerInformationSuppressed, "BmGame.RVehicleBatmobileBase.SetPassengerInformationSuppressed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_suppressed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushPassengerInformationToFlash;
    /// <summary>
    /// Function: PushPassengerInformationToFlash
    /// </summary>
    public unsafe virtual void PushPassengerInformationToFlash()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushPassengerInformationToFlash, "BmGame.RVehicleBatmobileBase.PushPassengerInformationToFlash");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalculateAndStoreImpactDamage;
    /// <summary>
    /// Function: CalculateAndStoreImpactDamage
    /// </summary>
    public unsafe virtual int CalculateAndStoreImpactDamage(BmSDK.BmGame.RVehicle OtherVeh, System.Numerics.Vector3 ImpactPosition, float Speed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateAndStoreImpactDamage, "BmGame.RVehicleBatmobileBase.CalculateAndStoreImpactDamage");
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherVeh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactPosition, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_FlipVehicle;
    /// <summary>
    /// Function: FlipVehicle
    /// </summary>
    public unsafe virtual void FlipVehicle(BmSDK.BmGame.RVehicle OtherVeh, System.Numerics.Vector3 HitPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlipVehicle, "BmGame.RVehicleBatmobileBase.FlipVehicle");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherVeh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPos, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoVehicleHitDamage;
    /// <summary>
    /// Function: DoVehicleHitDamage
    /// </summary>
    public unsafe override int DoVehicleHitDamage(BmSDK.BmGame.RVehicleNPC OtherVeh, System.Numerics.Vector3 pos, BmSDK.Engine.PrimitiveComponent OtherComponent, out BmSDK.Engine.Actor.FCollisionImpactData RigidCollisionData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoVehicleHitDamage, "BmGame.RVehicleBatmobileBase.DoVehicleHitDamage");
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherVeh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComponent, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RigidCollisionData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FCollisionImpactData>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 68);
    }

    private static BmSDK.Function __fn_DoImpactEffects;
    /// <summary>
    /// Function: DoImpactEffects
    /// </summary>
    public unsafe override void DoImpactEffects(System.Numerics.Vector3 NormalForce, BmSDK.Engine.Actor ImpactActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoImpactEffects, "BmGame.RVehicleBatmobileBase.DoImpactEffects");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NormalForce, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactActor, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCollisionRumble;
    /// <summary>
    /// Function: PlayCollisionRumble
    /// </summary>
    public unsafe virtual void PlayCollisionRumble(System.Numerics.Vector3 ImpactVector, BmSDK.Engine.PrimitiveComponent OtherComponent, float Speed, int Index1)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCollisionRumble, "BmGame.RVehicleBatmobileBase.PlayCollisionRumble");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactVector, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComponent, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index1, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBatmobileDoImpactDamage;
    /// <summary>
    /// Function: CanBatmobileDoImpactDamage
    /// </summary>
    public unsafe virtual bool CanBatmobileDoImpactDamage(BmSDK.BmGame.RVehicleNPC OtherVehicle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBatmobileDoImpactDamage, "BmGame.RVehicleBatmobileBase.CanBatmobileDoImpactDamage");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherVehicle, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AccumulateCrushed;
    /// <summary>
    /// Function: AccumulateCrushed
    /// </summary>
    public unsafe virtual void AccumulateCrushed(BmSDK.Engine.PrimitiveComponent OtherComponent, out BmSDK.Engine.Actor.FCollisionImpactData RigidCollisionData, float Speed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AccumulateCrushed, "BmGame.RVehicleBatmobileBase.AccumulateCrushed");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        RigidCollisionData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FCollisionImpactData>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_GetMaxHealth;
    /// <summary>
    /// Function: GetMaxHealth
    /// </summary>
    public unsafe override int GetMaxHealth()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxHealth, "BmGame.RVehicleBatmobileBase.GetMaxHealth");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TakesDamageFromRam;
    /// <summary>
    /// Function: TakesDamageFromRam
    /// </summary>
    public unsafe virtual bool TakesDamageFromRam(BmSDK.BmGame.RVehicleNPC Target, float RamSpeed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakesDamageFromRam, "BmGame.RVehicleBatmobileBase.TakesDamageFromRam");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RamSpeed, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetCurrentSideSwipeTarget;
    /// <summary>
    /// Function: GetCurrentSideSwipeTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RVehicleNPC GetCurrentSideSwipeTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentSideSwipeTarget, "BmGame.RVehicleBatmobileBase.GetCurrentSideSwipeTarget");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RVehicleNPC>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSideSwipeTarget;
    /// <summary>
    /// Function: GetSideSwipeTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RVehicleNPC GetSideSwipeTarget(BmSDK.Engine.RInteractionClass SideSwipeTargets, float Direction, out float TargetDistance)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSideSwipeTarget, "BmGame.RVehicleBatmobileBase.GetSideSwipeTarget");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideSwipeTargets, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TargetDistance);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetDistance, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        TargetDistance = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RVehicleNPC>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetBatmobileDodgeDirection;
    /// <summary>
    /// Function: GetBatmobileDodgeDirection
    /// </summary>
    public unsafe virtual float GetBatmobileDodgeDirection(BmSDK.BmGame.RVehicleNPC SideSwipeTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatmobileDodgeDirection, "BmGame.RVehicleBatmobileBase.GetBatmobileDodgeDirection");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideSwipeTarget, paramsPtr + 0);
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

    private static BmSDK.Function __fn_VehicleStrafe;
    /// <summary>
    /// Function: VehicleStrafe
    /// </summary>
    public unsafe virtual bool VehicleStrafe(float Direction, BmSDK.BmGame.RVehicleNPC Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VehicleStrafe, "BmGame.RVehicleBatmobileBase.VehicleStrafe");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_InAndOutOfBattleModeTimer;
    /// <summary>
    /// Function: InAndOutOfBattleModeTimer
    /// </summary>
    public unsafe virtual void InAndOutOfBattleModeTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InAndOutOfBattleModeTimer, "BmGame.RVehicleBatmobileBase.InAndOutOfBattleModeTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryRightingFlip;
    /// <summary>
    /// Function: TryRightingFlip
    /// </summary>
    public unsafe virtual bool TryRightingFlip(bool ForceFlip, System.Numerics.Vector3 AwayFromPoint = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryRightingFlip, "BmGame.RVehicleBatmobileBase.TryRightingFlip");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceFlip, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AwayFromPoint, paramsPtr + 4);
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

    private static BmSDK.Function __fn_BattleDodge;
    /// <summary>
    /// Function: BattleDodge
    /// </summary>
    public unsafe virtual void BattleDodge(System.Numerics.Vector3 Direction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BattleDodge, "BmGame.RVehicleBatmobileBase.BattleDodge");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToFallIn;
    /// <summary>
    /// Function: TryToFallIn
    /// </summary>
    public unsafe virtual void TryToFallIn(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToFallIn, "BmGame.RVehicleBatmobileBase.TryToFallIn");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToGlideIn;
    /// <summary>
    /// Function: TryToGlideIn
    /// </summary>
    public unsafe virtual void TryToGlideIn(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToGlideIn, "BmGame.RVehicleBatmobileBase.TryToGlideIn");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetArmouredMode;
    /// <summary>
    /// Function: SetArmouredMode
    /// </summary>
    public unsafe virtual void SetArmouredMode(bool OnOrOff)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetArmouredMode, "BmGame.RVehicleBatmobileBase.SetArmouredMode");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnOrOff, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsReadyToTransform;
    /// <summary>
    /// Function: IsReadyToTransform
    /// </summary>
    public unsafe virtual bool IsReadyToTransform()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsReadyToTransform, "BmGame.RVehicleBatmobileBase.IsReadyToTransform");
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

    private static BmSDK.Function __fn_ApplyAligningTorque;
    /// <summary>
    /// Function: ApplyAligningTorque
    /// </summary>
    public unsafe virtual void ApplyAligningTorque(int LocalAxis, System.Numerics.Vector3 RefAxisWorld, float forceScale, float DampingScale, float ForceLimit)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyAligningTorque, "BmGame.RVehicleBatmobileBase.ApplyAligningTorque");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalAxis, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RefAxisWorld, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(forceScale, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DampingScale, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceLimit, paramsPtr + 24);
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

    private static BmSDK.Function __fn_TryToChangeMode;
    /// <summary>
    /// Function: TryToChangeMode
    /// </summary>
    public unsafe virtual bool TryToChangeMode(BmSDK.FName ModeName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToChangeMode, "BmGame.RVehicleBatmobileBase.TryToChangeMode");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ModeName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ZeroThrottleForBattleDodge;
    /// <summary>
    /// Function: ZeroThrottleForBattleDodge
    /// </summary>
    public unsafe virtual void ZeroThrottleForBattleDodge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ZeroThrottleForBattleDodge, "BmGame.RVehicleBatmobileBase.ZeroThrottleForBattleDodge");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponsReady;
    /// <summary>
    /// Function: WeaponsReady
    /// </summary>
    public unsafe virtual void WeaponsReady()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponsReady, "BmGame.RVehicleBatmobileBase.WeaponsReady");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsUpsideDown;
    /// <summary>
    /// Function: IsUpsideDown
    /// </summary>
    public unsafe virtual bool IsUpsideDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsUpsideDown, "BmGame.RVehicleBatmobileBase.IsUpsideDown");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsUprightForSelfDrive;
    /// <summary>
    /// Function: IsUprightForSelfDrive
    /// </summary>
    public unsafe virtual bool IsUprightForSelfDrive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsUprightForSelfDrive, "BmGame.RVehicleBatmobileBase.IsUprightForSelfDrive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAdjustedAvoidanceDirection;
    /// <summary>
    /// Function: GetAdjustedAvoidanceDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAdjustedAvoidanceDirection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAdjustedAvoidanceDirection, "BmGame.RVehicleBatmobileBase.GetAdjustedAvoidanceDirection");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdatePressurePads;
    /// <summary>
    /// Function: UpdatePressurePads
    /// </summary>
    public unsafe virtual void UpdatePressurePads()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePressurePads, "BmGame.RVehicleBatmobileBase.UpdatePressurePads");
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

    private static BmSDK.Function __fn_UpdateDriveAssist;
    /// <summary>
    /// Function: UpdateDriveAssist
    /// </summary>
    public unsafe virtual void UpdateDriveAssist(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateDriveAssist, "BmGame.RVehicleBatmobileBase.UpdateDriveAssist");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateDrifting;
    /// <summary>
    /// Function: UpdateDrifting
    /// </summary>
    public unsafe virtual void UpdateDrifting(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateDrifting, "BmGame.RVehicleBatmobileBase.UpdateDrifting");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_StopDecelerateDuringTransformation;
    /// <summary>
    /// Function: StopDecelerateDuringTransformation
    /// </summary>
    public unsafe virtual void StopDecelerateDuringTransformation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopDecelerateDuringTransformation, "BmGame.RVehicleBatmobileBase.StopDecelerateDuringTransformation");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmGame.RVehicleBatmobileBase.Died");
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_SendHydraEventBatmobileDiedInCombatEncounter;
    /// <summary>
    /// Function: SendHydraEventBatmobileDiedInCombatEncounter
    /// </summary>
    public unsafe virtual void SendHydraEventBatmobileDiedInCombatEncounter(byte ecounterType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraEventBatmobileDiedInCombatEncounter, "BmGame.RVehicleBatmobileBase.SendHydraEventBatmobileDiedInCombatEncounter");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ecounterType, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SendHydraEventBatmobileFellOutOfWorld;
    /// <summary>
    /// Function: SendHydraEventBatmobileFellOutOfWorld
    /// </summary>
    public unsafe virtual void SendHydraEventBatmobileFellOutOfWorld()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraEventBatmobileFellOutOfWorld, "BmGame.RVehicleBatmobileBase.SendHydraEventBatmobileFellOutOfWorld");
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

    private static BmSDK.Function __fn_SendHydraEventBatmobileInputNormalMode;
    /// <summary>
    /// Function: SendHydraEventBatmobileInputNormalMode
    /// </summary>
    public unsafe virtual void SendHydraEventBatmobileInputNormalMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraEventBatmobileInputNormalMode, "BmGame.RVehicleBatmobileBase.SendHydraEventBatmobileInputNormalMode");
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

    private static BmSDK.Function __fn_SendHydraEventBatmobileInputBattleMode;
    /// <summary>
    /// Function: SendHydraEventBatmobileInputBattleMode
    /// </summary>
    public unsafe virtual void SendHydraEventBatmobileInputBattleMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraEventBatmobileInputBattleMode, "BmGame.RVehicleBatmobileBase.SendHydraEventBatmobileInputBattleMode");
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

    private static BmSDK.Function __fn_SendHydraEventBatmobileResetByBlowingUp;
    /// <summary>
    /// Function: SendHydraEventBatmobileResetByBlowingUp
    /// </summary>
    public unsafe virtual void SendHydraEventBatmobileResetByBlowingUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraEventBatmobileResetByBlowingUp, "BmGame.RVehicleBatmobileBase.SendHydraEventBatmobileResetByBlowingUp");
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

    private static BmSDK.Function __fn_SendHydraEventBatmobileResetByGettingCrushed;
    /// <summary>
    /// Function: SendHydraEventBatmobileResetByGettingCrushed
    /// </summary>
    public unsafe virtual void SendHydraEventBatmobileResetByGettingCrushed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraEventBatmobileResetByGettingCrushed, "BmGame.RVehicleBatmobileBase.SendHydraEventBatmobileResetByGettingCrushed");
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

    private static BmSDK.Function __fn_SendHydraEventBatmobileResetByGettingStuck;
    /// <summary>
    /// Function: SendHydraEventBatmobileResetByGettingStuck
    /// </summary>
    public unsafe virtual void SendHydraEventBatmobileResetByGettingStuck()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraEventBatmobileResetByGettingStuck, "BmGame.RVehicleBatmobileBase.SendHydraEventBatmobileResetByGettingStuck");
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

    private static BmSDK.Function __fn_SendHydraEventBatmobileResetByFalling;
    /// <summary>
    /// Function: SendHydraEventBatmobileResetByFalling
    /// </summary>
    public unsafe virtual void SendHydraEventBatmobileResetByFalling()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendHydraEventBatmobileResetByFalling, "BmGame.RVehicleBatmobileBase.SendHydraEventBatmobileResetByFalling");
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

    private static BmSDK.Function __fn_CanPlayerPurchaseBatmobileArmourUpgrade;
    /// <summary>
    /// Function: CanPlayerPurchaseBatmobileArmourUpgrade
    /// </summary>
    public unsafe virtual bool CanPlayerPurchaseBatmobileArmourUpgrade(BmSDK.BmGame.RPlayerController RPCC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayerPurchaseBatmobileArmourUpgrade, "BmGame.RVehicleBatmobileBase.CanPlayerPurchaseBatmobileArmourUpgrade");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPCC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SelectDeathTip_BMBL;
    /// <summary>
    /// Function: SelectDeathTip_BMBL
    /// </summary>
    public unsafe virtual void SelectDeathTip_BMBL(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation, bool bKilledInCombat)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectDeathTip_BMBL, "BmGame.RVehicleBatmobileBase.SelectDeathTip_BMBL");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKilledInCombat, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SelectDeathMovie_BMBL;
    /// <summary>
    /// Function: SelectDeathMovie_BMBL
    /// </summary>
    public unsafe virtual void SelectDeathMovie_BMBL(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectDeathMovie_BMBL, "BmGame.RVehicleBatmobileBase.SelectDeathMovie_BMBL");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateBatmobileOnFire;
    /// <summary>
    /// Function: UpdateBatmobileOnFire
    /// </summary>
    public unsafe virtual void UpdateBatmobileOnFire(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateBatmobileOnFire, "BmGame.RVehicleBatmobileBase.UpdateBatmobileOnFire");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetBatmobileOnFire;
    /// <summary>
    /// Function: SetBatmobileOnFire
    /// </summary>
    public unsafe virtual void SetBatmobileOnFire(float DamageAmount, System.Numerics.Vector3 DamageLoc, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBatmobileOnFire, "BmGame.RVehicleBatmobileBase.SetBatmobileOnFire");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageLoc, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDisabledByEMP;
    /// <summary>
    /// Function: SetDisabledByEMP
    /// </summary>
    public unsafe virtual void SetDisabledByEMP(bool Disabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDisabledByEMP, "BmGame.RVehicleBatmobileBase.SetDisabledByEMP");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Disabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamageBarkCheck;
    /// <summary>
    /// Function: DamageBarkCheck
    /// </summary>
    public unsafe virtual void DamageBarkCheck()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageBarkCheck, "BmGame.RVehicleBatmobileBase.DamageBarkCheck");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeDamage;
    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamage, "BmGame.RVehicleBatmobileBase.TakeDamage");
        byte* paramsPtr = stackalloc byte[144];
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

    private static BmSDK.Function __fn_InGodMode;
    /// <summary>
    /// Function: InGodMode
    /// </summary>
    public unsafe override bool InGodMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InGodMode, "BmGame.RVehicleBatmobileBase.InGodMode");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TakeRadiusDamageFromWeapon;
    /// <summary>
    /// Function: TakeRadiusDamageFromWeapon
    /// </summary>
    public unsafe override BmSDK.Engine.Actor.EWeaponDamageResult TakeRadiusDamageFromWeapon(BmSDK.Engine.Controller InstigatedBy, float BaseDamage, float DamageRadius, BmSDK.Class DamageType, float Momentum, System.Numerics.Vector3 HurtOrigin, bool bFullDamage, BmSDK.Engine.Actor DamageCauser, float DamageFalloffExponent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeRadiusDamageFromWeapon, "BmGame.RVehicleBatmobileBase.TakeRadiusDamageFromWeapon");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.EWeaponDamageResult>(paramsPtr + 56);
    }

    private static BmSDK.Function __fn_EquipSecondaryWeapon;
    /// <summary>
    /// Function: EquipSecondaryWeapon
    /// </summary>
    public unsafe virtual bool EquipSecondaryWeapon(BmSDK.BmGame.RVehicleWeapon NewWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EquipSecondaryWeapon, "BmGame.RVehicleBatmobileBase.EquipSecondaryWeapon");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_EquipWeapon;
    /// <summary>
    /// Function: EquipWeapon
    /// </summary>
    public unsafe virtual bool EquipWeapon(BmSDK.BmGame.RVehicleWeapon NewWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EquipWeapon, "BmGame.RVehicleBatmobileBase.EquipWeapon");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_EquipWeaponAchetype;
    /// <summary>
    /// Function: EquipWeaponAchetype
    /// </summary>
    public unsafe virtual void EquipWeaponAchetype(BmSDK.BmGame.RVehicleWeapon WeaponArch)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EquipWeaponAchetype, "BmGame.RVehicleBatmobileBase.EquipWeaponAchetype");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponArch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SelectWeapon;
    /// <summary>
    /// Function: SelectWeapon
    /// </summary>
    public unsafe virtual void SelectWeapon(BmSDK.BmGame.RVehicleBatmobileBase.EVehicleWeaponSelection Type, bool bCanDeselect = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectWeapon, "BmGame.RVehicleBatmobileBase.SelectWeapon");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanDeselect, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInBatmobileInstant;
    /// <summary>
    /// Function: GetInBatmobileInstant
    /// </summary>
    public unsafe virtual void GetInBatmobileInstant(BmSDK.BmGame.RPawnPlayer PlayerGettingIn, bool bEndOfMatinee = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInBatmobileInstant, "BmGame.RVehicleBatmobileBase.GetInBatmobileInstant");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerGettingIn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEndOfMatinee, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInBatmobile;
    /// <summary>
    /// Function: GetInBatmobile
    /// </summary>
    public unsafe virtual void GetInBatmobile(BmSDK.Engine.Pawn PlayerGettingIn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInBatmobile, "BmGame.RVehicleBatmobileBase.GetInBatmobile");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerGettingIn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachDriver;
    /// <summary>
    /// Function: AttachDriver
    /// </summary>
    public unsafe override void AttachDriver(BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachDriver, "BmGame.RVehicleBatmobileBase.AttachDriver");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Interact;
    /// <summary>
    /// Function: Interact
    /// </summary>
    public unsafe override void Interact(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Interact, "BmGame.RVehicleBatmobileBase.Interact");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveAllGadgets;
    /// <summary>
    /// Function: DebugGiveAllGadgets
    /// </summary>
    public unsafe virtual void DebugGiveAllGadgets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveAllGadgets, "BmGame.RVehicleBatmobileBase.DebugGiveAllGadgets");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForUpgrades;
    /// <summary>
    /// Function: CheckForUpgrades
    /// </summary>
    public unsafe virtual void CheckForUpgrades(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForUpgrades, "BmGame.RVehicleBatmobileBase.CheckForUpgrades");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentGeneratorLevel;
    /// <summary>
    /// Function: SetCurrentGeneratorLevel
    /// </summary>
    public unsafe virtual void SetCurrentGeneratorLevel(int Level)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentGeneratorLevel, "BmGame.RVehicleBatmobileBase.SetCurrentGeneratorLevel");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Level, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GiveMaxEnergy;
    /// <summary>
    /// Function: GiveMaxEnergy
    /// </summary>
    public unsafe virtual void GiveMaxEnergy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveMaxEnergy, "BmGame.RVehicleBatmobileBase.GiveMaxEnergy");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveMaxHealth;
    /// <summary>
    /// Function: GiveMaxHealth
    /// </summary>
    public unsafe virtual void GiveMaxHealth()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveMaxHealth, "BmGame.RVehicleBatmobileBase.GiveMaxHealth");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HealthUpdated;
    /// <summary>
    /// Function: HealthUpdated
    /// </summary>
    public unsafe virtual void HealthUpdated(bool Snap = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HealthUpdated, "BmGame.RVehicleBatmobileBase.HealthUpdated");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Snap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadHealth;
    /// <summary>
    /// Function: LoadHealth
    /// </summary>
    public unsafe virtual void LoadHealth()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadHealth, "BmGame.RVehicleBatmobileBase.LoadHealth");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddBatmobileWeapons;
    /// <summary>
    /// Function: AddBatmobileWeapons
    /// </summary>
    public unsafe virtual void AddBatmobileWeapons(bool bForceAllWeapons = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddBatmobileWeapons, "BmGame.RVehicleBatmobileBase.AddBatmobileWeapons");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceAllWeapons, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveBatmobileWeapon;
    /// <summary>
    /// Function: RemoveBatmobileWeapon
    /// </summary>
    public unsafe virtual void RemoveBatmobileWeapon(BmSDK.FString WeaponFlag)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveBatmobileWeapon, "BmGame.RVehicleBatmobileBase.RemoveBatmobileWeapon");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponFlag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddBatmobileWeapon;
    /// <summary>
    /// Function: AddBatmobileWeapon
    /// </summary>
    public unsafe virtual void AddBatmobileWeapon(BmSDK.FString WeaponFlag)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddBatmobileWeapon, "BmGame.RVehicleBatmobileBase.AddBatmobileWeapon");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponFlag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetOverrideCamera;
    /// <summary>
    /// Function: GetOverrideCamera
    /// </summary>
    public unsafe virtual BmSDK.FName GetOverrideCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverrideCamera, "BmGame.RVehicleBatmobileBase.GetOverrideCamera");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopWaterImpactEffect;
    /// <summary>
    /// Function: StopWaterImpactEffect
    /// </summary>
    public unsafe virtual void StopWaterImpactEffect()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopWaterImpactEffect, "BmGame.RVehicleBatmobileBase.StopWaterImpactEffect");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnWaterImpactEffect;
    /// <summary>
    /// Function: SpawnWaterImpactEffect
    /// </summary>
    public unsafe virtual void SpawnWaterImpactEffect(System.Numerics.Vector3 HitLocation, BmSDK.Engine.Camera PlayerCamera)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnWaterImpactEffect, "BmGame.RVehicleBatmobileBase.SpawnWaterImpactEffect");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerCamera, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnAbseilImpactRear;
    /// <summary>
    /// Function: SpawnAbseilImpactRear
    /// </summary>
    public unsafe virtual void SpawnAbseilImpactRear()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnAbseilImpactRear, "BmGame.RVehicleBatmobileBase.SpawnAbseilImpactRear");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnAbseilImpactFront;
    /// <summary>
    /// Function: SpawnAbseilImpactFront
    /// </summary>
    public unsafe virtual void SpawnAbseilImpactFront()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnAbseilImpactFront, "BmGame.RVehicleBatmobileBase.SpawnAbseilImpactFront");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWantAirBrakes;
    /// <summary>
    /// Function: SetWantAirBrakes
    /// </summary>
    public unsafe virtual void SetWantAirBrakes(float Left, float Right)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWantAirBrakes, "BmGame.RVehicleBatmobileBase.SetWantAirBrakes");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Left, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Right, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsCockpitOpen;
    /// <summary>
    /// Function: IsCockpitOpen
    /// </summary>
    public unsafe virtual bool IsCockpitOpen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCockpitOpen, "BmGame.RVehicleBatmobileBase.IsCockpitOpen");
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

    private static BmSDK.Function __fn_PlayCockpitClose;
    /// <summary>
    /// Function: PlayCockpitClose
    /// </summary>
    public unsafe virtual void PlayCockpitClose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCockpitClose, "BmGame.RVehicleBatmobileBase.PlayCockpitClose");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCockpitOpenFast;
    /// <summary>
    /// Function: PlayCockpitOpenFast
    /// </summary>
    public unsafe virtual void PlayCockpitOpenFast()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCockpitOpenFast, "BmGame.RVehicleBatmobileBase.PlayCockpitOpenFast");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCockpitOpen;
    /// <summary>
    /// Function: PlayCockpitOpen
    /// </summary>
    public unsafe virtual void PlayCockpitOpen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCockpitOpen, "BmGame.RVehicleBatmobileBase.PlayCockpitOpen");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RVehicleBatmobileBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmobileSnapToGround;
    /// <summary>
    /// Function: BatmobileSnapToGround
    /// </summary>
    public unsafe static void BatmobileSnapToGround(out System.Numerics.Vector3 BatmobilePos, out BmSDK.Rotator BatmobileRot, BmSDK.BmGame.RVehicleBatmobileBase BatmobileArchetype)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmobileSnapToGround, "BmGame.RVehicleBatmobileBase.BatmobileSnapToGround");
        byte* paramsPtr = stackalloc byte[32];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BatmobilePos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmobilePos, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BatmobileRot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmobileRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmobileArchetype, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BatmobilePos = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        BatmobileRot = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_SetBatmobileExit;
    /// <summary>
    /// Function: SetBatmobileExit
    /// </summary>
    public unsafe virtual void SetBatmobileExit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBatmobileExit, "BmGame.RVehicleBatmobileBase.SetBatmobileExit");
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

    private static BmSDK.Function __fn_UpdateOceanRescue;
    /// <summary>
    /// Function: UpdateOceanRescue
    /// </summary>
    public unsafe virtual void UpdateOceanRescue(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateOceanRescue, "BmGame.RVehicleBatmobileBase.UpdateOceanRescue");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetSafePoint;
    /// <summary>
    /// Function: SetSafePoint
    /// </summary>
    public unsafe virtual void SetSafePoint(System.Numerics.Vector3 Loc = default, BmSDK.Rotator Rot = default, bool bAllowNonVisibleLevels = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSafePoint, "BmGame.RVehicleBatmobileBase.SetSafePoint");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowNonVisibleLevels, paramsPtr + 24);
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

    private static BmSDK.Function __fn_DebugDisplayTauntPositions;
    /// <summary>
    /// Function: DebugDisplayTauntPositions
    /// </summary>
    public unsafe virtual void DebugDisplayTauntPositions()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugDisplayTauntPositions, "BmGame.RVehicleBatmobileBase.DebugDisplayTauntPositions");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseGuarder;
    /// <summary>
    /// Function: ReleaseGuarder
    /// </summary>
    public unsafe virtual void ReleaseGuarder(BmSDK.BmGame.RPawnCombat Guarder)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseGuarder, "BmGame.RVehicleBatmobileBase.ReleaseGuarder");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Guarder, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseGuardPositionID;
    /// <summary>
    /// Function: ReleaseGuardPositionID
    /// </summary>
    public unsafe virtual void ReleaseGuardPositionID(int GuardID, BmSDK.BmGame.RPawnCombat Guarder)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseGuardPositionID, "BmGame.RVehicleBatmobileBase.ReleaseGuardPositionID");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GuardID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Guarder, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LockGuardPositionID;
    /// <summary>
    /// Function: LockGuardPositionID
    /// </summary>
    public unsafe virtual bool LockGuardPositionID(int GuardID, BmSDK.BmGame.RPawnCombat Guarder)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LockGuardPositionID, "BmGame.RVehicleBatmobileBase.LockGuardPositionID");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GuardID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Guarder, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetGuardPositionFromID;
    /// <summary>
    /// Function: GetGuardPositionFromID
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGuardPositionFromID(int GuardID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGuardPositionFromID, "BmGame.RVehicleBatmobileBase.GetGuardPositionFromID");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GuardID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetGuardPositionID;
    /// <summary>
    /// Function: GetGuardPositionID
    /// </summary>
    public unsafe virtual int GetGuardPositionID(BmSDK.BmGame.RPawnCombat Guarder, out System.Numerics.Vector3 GuardPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGuardPositionID, "BmGame.RVehicleBatmobileBase.GetGuardPositionID");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Guarder, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out GuardPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GuardPos, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        GuardPos = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ReleaseTauntPositions;
    /// <summary>
    /// Function: ReleaseTauntPositions
    /// </summary>
    public unsafe virtual void ReleaseTauntPositions(BmSDK.BmGame.RPawnVillain Taunter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseTauntPositions, "BmGame.RVehicleBatmobileBase.ReleaseTauntPositions");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Taunter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LockTauntPositions;
    /// <summary>
    /// Function: LockTauntPositions
    /// </summary>
    public unsafe virtual void LockTauntPositions(BmSDK.TArray<bool> LockPositions, BmSDK.BmGame.RPawnVillain Taunter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LockTauntPositions, "BmGame.RVehicleBatmobileBase.LockTauntPositions");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LockPositions, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Taunter, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanUseTauntAnimWithPositions;
    /// <summary>
    /// Function: CanUseTauntAnimWithPositions
    /// </summary>
    public unsafe virtual bool CanUseTauntAnimWithPositions(BmSDK.TArray<bool> TestPositions, BmSDK.BmGame.RPawnVillain Taunter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseTauntAnimWithPositions, "BmGame.RVehicleBatmobileBase.CanUseTauntAnimWithPositions");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPositions, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Taunter, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_TauntPositionIsValidForPawn;
    /// <summary>
    /// Function: TauntPositionIsValidForPawn
    /// </summary>
    public unsafe virtual bool TauntPositionIsValidForPawn(int PositionID, BmSDK.BmGame.RPawnVillain Taunter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TauntPositionIsValidForPawn, "BmGame.RVehicleBatmobileBase.TauntPositionIsValidForPawn");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PositionID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Taunter, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetApproximateTauntPosition;
    /// <summary>
    /// Function: GetApproximateTauntPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetApproximateTauntPosition(int PositionID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetApproximateTauntPosition, "BmGame.RVehicleBatmobileBase.GetApproximateTauntPosition");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PositionID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsCombatThreat;
    /// <summary>
    /// Function: IsCombatThreat
    /// </summary>
    public unsafe virtual bool IsCombatThreat(BmSDK.BmGame.RPawnVillain TestThug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCombatThreat, "BmGame.RVehicleBatmobileBase.IsCombatThreat");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestThug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PickUpPlayer;
    /// <summary>
    /// Function: PickUpPlayer
    /// </summary>
    public unsafe virtual void PickUpPlayer(BmSDK.BmGame.RPawnPlayer PlayerToPickUp, bool bHighSpeedPickup = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickUpPlayer, "BmGame.RVehicleBatmobileBase.PickUpPlayer");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerToPickUp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHighSpeedPickup, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveBatmobileBindsAndSetBatmanBinds;
    /// <summary>
    /// Function: RemoveBatmobileBindsAndSetBatmanBinds
    /// </summary>
    public unsafe virtual void RemoveBatmobileBindsAndSetBatmanBinds()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveBatmobileBindsAndSetBatmanBinds, "BmGame.RVehicleBatmobileBase.RemoveBatmobileBindsAndSetBatmanBinds");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToGetOutOfBatmobile;
    /// <summary>
    /// Function: TryToGetOutOfBatmobile
    /// </summary>
    public unsafe virtual void TryToGetOutOfBatmobile()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToGetOutOfBatmobile, "BmGame.RVehicleBatmobileBase.TryToGetOutOfBatmobile");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireEventClassic;
    /// <summary>
    /// Function: FireEventClassic
    /// </summary>
    public unsafe virtual void FireEventClassic()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireEventClassic, "BmGame.RVehicleBatmobileBase.FireEventClassic");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireEventClassicAudio;
    /// <summary>
    /// Function: FireEventClassicAudio
    /// </summary>
    public unsafe virtual void FireEventClassicAudio()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireEventClassicAudio, "BmGame.RVehicleBatmobileBase.FireEventClassicAudio");
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

    private static BmSDK.Function __fn_DriverEnter;
    /// <summary>
    /// Function: DriverEnter
    /// </summary>
    public unsafe override bool DriverEnter(BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DriverEnter, "BmGame.RVehicleBatmobileBase.DriverEnter");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DriverLeft;
    /// <summary>
    /// Function: DriverLeft
    /// </summary>
    public unsafe override void DriverLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DriverLeft, "BmGame.RVehicleBatmobileBase.DriverLeft");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCranePlatform;
    /// <summary>
    /// Function: OnCranePlatform
    /// </summary>
    public unsafe virtual bool OnCranePlatform(out BmSDK.BmGame.RCranePlatformBase CranePlatform)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCranePlatform, "BmGame.RVehicleBatmobileBase.OnCranePlatform");
        byte* paramsPtr = stackalloc byte[16];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CranePlatform);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CranePlatform, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CranePlatform = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCranePlatformBase>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PlayerIsInBatmobile;
    /// <summary>
    /// Function: PlayerIsInBatmobile
    /// </summary>
    public unsafe virtual bool PlayerIsInBatmobile()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerIsInBatmobile, "BmGame.RVehicleBatmobileBase.PlayerIsInBatmobile");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInActiveBattleMode;
    /// <summary>
    /// Function: IsInActiveBattleMode
    /// </summary>
    public unsafe virtual bool IsInActiveBattleMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInActiveBattleMode, "BmGame.RVehicleBatmobileBase.IsInActiveBattleMode");
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

    private static BmSDK.Function __fn_IsInBattleMode;
    /// <summary>
    /// Function: IsInBattleMode
    /// </summary>
    public unsafe virtual bool IsInBattleMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInBattleMode, "BmGame.RVehicleBatmobileBase.IsInBattleMode");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GeneratorPowerUpdated;
    /// <summary>
    /// Function: GeneratorPowerUpdated
    /// </summary>
    public unsafe virtual void GeneratorPowerUpdated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GeneratorPowerUpdated, "BmGame.RVehicleBatmobileBase.GeneratorPowerUpdated");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpendWeaponPower;
    /// <summary>
    /// Function: SpendWeaponPower
    /// </summary>
    public unsafe virtual void SpendWeaponPower(float Power, BmSDK.BmGame.RVehicleWeapon UsedWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpendWeaponPower, "BmGame.RVehicleBatmobileBase.SpendWeaponPower");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Power, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UsedWeapon, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrainWeaponGeneratorForDamage;
    /// <summary>
    /// Function: DrainWeaponGeneratorForDamage
    /// </summary>
    public unsafe virtual void DrainWeaponGeneratorForDamage(int HitNumber)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrainWeaponGeneratorForDamage, "BmGame.RVehicleBatmobileBase.DrainWeaponGeneratorForDamage");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNumber, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerWeaponGeneratorScarecrowBonus;
    /// <summary>
    /// Function: TriggerWeaponGeneratorScarecrowBonus
    /// </summary>
    public unsafe virtual void TriggerWeaponGeneratorScarecrowBonus(float DamageRatioDone)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerWeaponGeneratorScarecrowBonus, "BmGame.RVehicleBatmobileBase.TriggerWeaponGeneratorScarecrowBonus");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageRatioDone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerWeaponGeneratorMissileBonus;
    /// <summary>
    /// Function: TriggerWeaponGeneratorMissileBonus
    /// </summary>
    public unsafe virtual void TriggerWeaponGeneratorMissileBonus()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerWeaponGeneratorMissileBonus, "BmGame.RVehicleBatmobileBase.TriggerWeaponGeneratorMissileBonus");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerWeaponGeneratorDodgeBonus;
    /// <summary>
    /// Function: TriggerWeaponGeneratorDodgeBonus
    /// </summary>
    public unsafe virtual void TriggerWeaponGeneratorDodgeBonus(int Dodges)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerWeaponGeneratorDodgeBonus, "BmGame.RVehicleBatmobileBase.TriggerWeaponGeneratorDodgeBonus");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dodges, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerWeaponGeneratorArmourShotBonus;
    /// <summary>
    /// Function: TriggerWeaponGeneratorArmourShotBonus
    /// </summary>
    public unsafe virtual void TriggerWeaponGeneratorArmourShotBonus()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerWeaponGeneratorArmourShotBonus, "BmGame.RVehicleBatmobileBase.TriggerWeaponGeneratorArmourShotBonus");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetCriticalCounter;
    /// <summary>
    /// Function: ResetCriticalCounter
    /// </summary>
    public unsafe virtual void ResetCriticalCounter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetCriticalCounter, "BmGame.RVehicleBatmobileBase.ResetCriticalCounter");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerWeaponGeneratorPerfectHeadShotBonus;
    /// <summary>
    /// Function: TriggerWeaponGeneratorPerfectHeadShotBonus
    /// </summary>
    public unsafe virtual void TriggerWeaponGeneratorPerfectHeadShotBonus()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerWeaponGeneratorPerfectHeadShotBonus, "BmGame.RVehicleBatmobileBase.TriggerWeaponGeneratorPerfectHeadShotBonus");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerWeaponGeneratorHeadShotBonus;
    /// <summary>
    /// Function: TriggerWeaponGeneratorHeadShotBonus
    /// </summary>
    public unsafe virtual void TriggerWeaponGeneratorHeadShotBonus()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerWeaponGeneratorHeadShotBonus, "BmGame.RVehicleBatmobileBase.TriggerWeaponGeneratorHeadShotBonus");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerWeaponGeneratorHeavyTankKillBonus;
    /// <summary>
    /// Function: TriggerWeaponGeneratorHeavyTankKillBonus
    /// </summary>
    public unsafe virtual void TriggerWeaponGeneratorHeavyTankKillBonus(BmSDK.Class DamageType, BmSDK.Engine.Controller Killer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerWeaponGeneratorHeavyTankKillBonus, "BmGame.RVehicleBatmobileBase.TriggerWeaponGeneratorHeavyTankKillBonus");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerWeaponGeneratorKillBonus;
    /// <summary>
    /// Function: TriggerWeaponGeneratorKillBonus
    /// </summary>
    public unsafe virtual void TriggerWeaponGeneratorKillBonus(BmSDK.Class DamageType, BmSDK.Engine.Controller Killer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerWeaponGeneratorKillBonus, "BmGame.RVehicleBatmobileBase.TriggerWeaponGeneratorKillBonus");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerWeaponGeneratorThugKillBonus;
    /// <summary>
    /// Function: TriggerWeaponGeneratorThugKillBonus
    /// </summary>
    public unsafe virtual void TriggerWeaponGeneratorThugKillBonus(BmSDK.Class DamageType, BmSDK.Engine.Controller Killer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerWeaponGeneratorThugKillBonus, "BmGame.RVehicleBatmobileBase.TriggerWeaponGeneratorThugKillBonus");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerWeaponGeneratorBonus;
    /// <summary>
    /// Function: TriggerWeaponGeneratorBonus
    /// </summary>
    public unsafe void TriggerWeaponGeneratorBonus(float PowerBonus)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerWeaponGeneratorBonus, "BmGame.RVehicleBatmobileBase.TriggerWeaponGeneratorBonus");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PowerBonus, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncSteamEffect;
    /// <summary>
    /// Function: IncSteamEffect
    /// </summary>
    public unsafe virtual void IncSteamEffect(float Amount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncSteamEffect, "BmGame.RVehicleBatmobileBase.IncSteamEffect");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsChainGunDrainingWeaponGenerator;
    /// <summary>
    /// Function: IsChainGunDrainingWeaponGenerator
    /// </summary>
    public unsafe virtual bool IsChainGunDrainingWeaponGenerator()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsChainGunDrainingWeaponGenerator, "BmGame.RVehicleBatmobileBase.IsChainGunDrainingWeaponGenerator");
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

    private static BmSDK.Function __fn_GetPlayerConfig;
    /// <summary>
    /// Function: GetPlayerConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAddContentBatmobile GetPlayerConfig(out BmSDK.BmGame.RAddContentBatmobileMesh MeshData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerConfig, "BmGame.RVehicleBatmobileBase.GetPlayerConfig");
        byte* paramsPtr = stackalloc byte[28];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MeshData);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MeshData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAddContentBatmobileMesh>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAddContentBatmobile>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetupPlayerMesh;
    /// <summary>
    /// Function: SetupPlayerMesh
    /// </summary>
    public unsafe virtual void SetupPlayerMesh(bool InPlay)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupPlayerMesh, "BmGame.RVehicleBatmobileBase.SetupPlayerMesh");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RVehicleBatmobileBase.Destroyed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreBeginPlay;
    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe override void PreBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreBeginPlay, "BmGame.RVehicleBatmobileBase.PreBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGlanceScore;
    /// <summary>
    /// Function: GetGlanceScore
    /// </summary>
    public unsafe virtual int GetGlanceScore()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlanceScore, "BmGame.RVehicleBatmobileBase.GetGlanceScore");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBoostPct;
    /// <summary>
    /// Function: GetBoostPct
    /// </summary>
    public unsafe virtual float GetBoostPct()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBoostPct, "BmGame.RVehicleBatmobileBase.GetBoostPct");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsActive;
    /// <summary>
    /// Function: IsActive
    /// </summary>
    public unsafe override bool IsActive(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsActive, "BmGame.RVehicleBatmobileBase.IsActive");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TickWeaponWarnings;
    /// <summary>
    /// Function: TickWeaponWarnings
    /// </summary>
    public unsafe virtual void TickWeaponWarnings(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickWeaponWarnings, "BmGame.RVehicleBatmobileBase.TickWeaponWarnings");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddWeaponWarning;
    /// <summary>
    /// Function: AddWeaponWarning
    /// </summary>
    public unsafe virtual void AddWeaponWarning(out BmSDK.BmGame.RVehicleBatmobileBase.FBatmobileWeaponWarningContainer NewWarning, bool ProhibitPursuitModeWarnings = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddWeaponWarning, "BmGame.RVehicleBatmobileBase.AddWeaponWarning");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProhibitPursuitModeWarnings, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NewWarning = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobileWeaponWarningContainer>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerWrongWayEvent;
    /// <summary>
    /// Function: TriggerWrongWayEvent
    /// </summary>
    public unsafe virtual void TriggerWrongWayEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerWrongWayEvent, "BmGame.RVehicleBatmobileBase.TriggerWrongWayEvent");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AfterburnerOnForDuration;
    /// <summary>
    /// Function: AfterburnerOnForDuration
    /// </summary>
    public unsafe virtual void AfterburnerOnForDuration(float Duration, bool bFront = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AfterburnerOnForDuration, "BmGame.RVehicleBatmobileBase.AfterburnerOnForDuration");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFront, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnRightExhaustBurst;
    /// <summary>
    /// Function: SpawnRightExhaustBurst
    /// </summary>
    public unsafe virtual void SpawnRightExhaustBurst()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnRightExhaustBurst, "BmGame.RVehicleBatmobileBase.SpawnRightExhaustBurst");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnLeftExhaustBurst;
    /// <summary>
    /// Function: SpawnLeftExhaustBurst
    /// </summary>
    public unsafe virtual void SpawnLeftExhaustBurst()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnLeftExhaustBurst, "BmGame.RVehicleBatmobileBase.SpawnLeftExhaustBurst");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnExhaustBurst;
    /// <summary>
    /// Function: SpawnExhaustBurst
    /// </summary>
    public unsafe virtual void SpawnExhaustBurst(bool bFront, bool bDoSideExhaustBurst)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnExhaustBurst, "BmGame.RVehicleBatmobileBase.SpawnExhaustBurst");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFront, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoSideExhaustBurst, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AfterburnerWarmupOff;
    /// <summary>
    /// Function: AfterburnerWarmupOff
    /// </summary>
    public unsafe virtual void AfterburnerWarmupOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AfterburnerWarmupOff, "BmGame.RVehicleBatmobileBase.AfterburnerWarmupOff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AfterburnerWarmupOn;
    /// <summary>
    /// Function: AfterburnerWarmupOn
    /// </summary>
    public unsafe virtual void AfterburnerWarmupOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AfterburnerWarmupOn, "BmGame.RVehicleBatmobileBase.AfterburnerWarmupOn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AfterburnerOff;
    /// <summary>
    /// Function: AfterburnerOff
    /// </summary>
    public unsafe virtual void AfterburnerOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AfterburnerOff, "BmGame.RVehicleBatmobileBase.AfterburnerOff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AfterburnerOn;
    /// <summary>
    /// Function: AfterburnerOn
    /// </summary>
    public unsafe virtual void AfterburnerOn(bool bFront = default, bool bDoSideExhaustBurst = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AfterburnerOn, "BmGame.RVehicleBatmobileBase.AfterburnerOn");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFront, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoSideExhaustBurst, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateBattleModeViewMesh;
    /// <summary>
    /// Function: CreateBattleModeViewMesh
    /// </summary>
    public unsafe virtual void CreateBattleModeViewMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateBattleModeViewMesh, "BmGame.RVehicleBatmobileBase.CreateBattleModeViewMesh");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoXrayUpdate;
    /// <summary>
    /// Function: DoXrayUpdate
    /// </summary>
    public unsafe virtual void DoXrayUpdate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoXrayUpdate, "BmGame.RVehicleBatmobileBase.DoXrayUpdate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetForceToGiveToPawn;
    /// <summary>
    /// Function: GetForceToGiveToPawn
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetForceToGiveToPawn(BmSDK.BmGame.RPawnCombat Receiver, float MaxForce, float MinRange = default, float MaxRange = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetForceToGiveToPawn, "BmGame.RVehicleBatmobileBase.GetForceToGiveToPawn");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Receiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxForce, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinRange, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxRange, paramsPtr + 16);
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

    private static BmSDK.Function __fn_GetOffscreenThreats;
    /// <summary>
    /// Function: GetOffscreenThreats
    /// </summary>
    public unsafe virtual void GetOffscreenThreats(BmSDK.BmGame.RPlayerController PC, out BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FOffScreenThreat> ThreatsToDisplay, BmSDK.Engine.RInteractionClass Threats)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOffscreenThreats, "BmGame.RVehicleBatmobileBase.GetOffscreenThreats");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Threats, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ThreatsToDisplay = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FOffScreenThreat>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_UpdateStrafe;
    /// <summary>
    /// Function: UpdateStrafe
    /// </summary>
    public unsafe virtual void UpdateStrafe(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateStrafe, "BmGame.RVehicleBatmobileBase.UpdateStrafe");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_KickStrafe;
    /// <summary>
    /// Function: KickStrafe
    /// </summary>
    public unsafe virtual void KickStrafe(float Force, float Torque, float Duration)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KickStrafe, "BmGame.RVehicleBatmobileBase.KickStrafe");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Force, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Torque, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SelfDrive;
    /// <summary>
    /// Function: SelfDrive
    /// </summary>
    public unsafe override bool SelfDrive(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelfDrive, "BmGame.RVehicleBatmobileBase.SelfDrive");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetLookAheadOnRacingLine;
    /// <summary>
    /// Function: GetLookAheadOnRacingLine
    /// </summary>
    public unsafe virtual bool GetLookAheadOnRacingLine(BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkSpan> Spans, BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRacingLineSeg> RacingLine, float LookAheadDist, out System.Numerics.Vector3 Position, out System.Numerics.Vector3 Direction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLookAheadOnRacingLine, "BmGame.RVehicleBatmobileBase.GetLookAheadOnRacingLine");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spans, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RacingLine, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAheadDist, paramsPtr + 32);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Position);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Direction);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Position = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
        Direction = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 48);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_ApplyForces;
    /// <summary>
    /// Function: ApplyForces
    /// </summary>
    public unsafe virtual void ApplyForces(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyForces, "BmGame.RVehicleBatmobileBase.ApplyForces");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateEffects;
    /// <summary>
    /// Function: UpdateEffects
    /// </summary>
    public unsafe virtual void UpdateEffects(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateEffects, "BmGame.RVehicleBatmobileBase.UpdateEffects");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateForensicsLight;
    /// <summary>
    /// Function: UpdateForensicsLight
    /// </summary>
    public unsafe virtual void UpdateForensicsLight(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateForensicsLight, "BmGame.RVehicleBatmobileBase.UpdateForensicsLight");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateLights;
    /// <summary>
    /// Function: UpdateLights
    /// </summary>
    public unsafe override void UpdateLights(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateLights, "BmGame.RVehicleBatmobileBase.UpdateLights");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetMudWashOffSpeed;
    /// <summary>
    /// Function: GetMudWashOffSpeed
    /// </summary>
    public unsafe virtual float GetMudWashOffSpeed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMudWashOffSpeed, "BmGame.RVehicleBatmobileBase.GetMudWashOffSpeed");
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

    private static BmSDK.Function __fn_ApplyMeshData;
    /// <summary>
    /// Function: ApplyMeshData
    /// </summary>
    public unsafe virtual void ApplyMeshData(BmSDK.BmGame.RAddContentBatmobileMesh MeshData, bool InPlay)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyMeshData, "BmGame.RVehicleBatmobileBase.ApplyMeshData");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPlay, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetDamageLevel;
    /// <summary>
    /// Function: SetDamageLevel
    /// </summary>
    public unsafe static void SetDamageLevel(BmSDK.FName PlayerBatmobileName, int NewDamageLevel)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDamageLevel, "BmGame.RVehicleBatmobileBase.SetDamageLevel");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerBatmobileName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDamageLevel, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetBattleModeFactor;
    /// <summary>
    /// Function: GetBattleModeFactor
    /// </summary>
    public unsafe virtual float GetBattleModeFactor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBattleModeFactor, "BmGame.RVehicleBatmobileBase.GetBattleModeFactor");
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

    private static BmSDK.Function __fn_TraceEmptyVehicleNPC;
    /// <summary>
    /// Function: TraceEmptyVehicleNPC
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RVehicleNPC TraceEmptyVehicleNPC(out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 End, System.Numerics.Vector3 Start, BmSDK.Component.ECollisionFilter Filter, System.Numerics.Vector3 Extent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceEmptyVehicleNPC, "BmGame.RVehicleBatmobileBase.TraceEmptyVehicleNPC");
        byte* paramsPtr = stackalloc byte[72];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filter, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 52);
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RVehicleNPC>(paramsPtr + 64);
    }

    private static BmSDK.Function __fn_TraceAbandonedVehicle;
    /// <summary>
    /// Function: TraceAbandonedVehicle
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAbandonedVehicle TraceAbandonedVehicle(out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 End, System.Numerics.Vector3 Start, BmSDK.Component.ECollisionFilter Filter, System.Numerics.Vector3 Extent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceAbandonedVehicle, "BmGame.RVehicleBatmobileBase.TraceAbandonedVehicle");
        byte* paramsPtr = stackalloc byte[72];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filter, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 52);
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAbandonedVehicle>(paramsPtr + 64);
    }

    private static BmSDK.Function __fn_FireSeqEvent_Touch_BatmanInBatmobileOnly;
    /// <summary>
    /// Function: FireSeqEvent_Touch_BatmanInBatmobileOnly
    /// </summary>
    public unsafe virtual void FireSeqEvent_Touch_BatmanInBatmobileOnly()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireSeqEvent_Touch_BatmanInBatmobileOnly, "BmGame.RVehicleBatmobileBase.FireSeqEvent_Touch_BatmanInBatmobileOnly");
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

    private static BmSDK.Function __fn_IsAnyWheelOnCheckpointBlockade;
    /// <summary>
    /// Function: IsAnyWheelOnCheckpointBlockade
    /// </summary>
    public unsafe virtual bool IsAnyWheelOnCheckpointBlockade(out System.Numerics.Vector3 CantMoveDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAnyWheelOnCheckpointBlockade, "BmGame.RVehicleBatmobileBase.IsAnyWheelOnCheckpointBlockade");
        byte* paramsPtr = stackalloc byte[16];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CantMoveDir);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CantMoveDir, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CantMoveDir = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetLocationPredictor;
    /// <summary>
    /// Function: GetLocationPredictor
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RVehicleBatmobilePredictor GetLocationPredictor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocationPredictor, "BmGame.RVehicleBatmobileBase.GetLocationPredictor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RVehicleBatmobilePredictor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBoosting;
    /// <summary>
    /// Function: IsBoosting
    /// </summary>
    public unsafe virtual bool IsBoosting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBoosting, "BmGame.RVehicleBatmobileBase.IsBoosting");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RescueMe;
    /// <summary>
    /// Function: RescueMe
    /// </summary>
    public unsafe virtual bool RescueMe(bool FindOffScreenLocation = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RescueMe, "BmGame.RVehicleBatmobileBase.RescueMe");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FindOffScreenLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RemoveBatmobileViewNonPassenger;
    /// <summary>
    /// Function: RemoveBatmobileViewNonPassenger
    /// </summary>
    public unsafe virtual void RemoveBatmobileViewNonPassenger(BmSDK.BmGame.RBMPawnAI P)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveBatmobileViewNonPassenger, "BmGame.RVehicleBatmobileBase.RemoveBatmobileViewNonPassenger");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddBatmobileViewNonPassenger;
    /// <summary>
    /// Function: AddBatmobileViewNonPassenger
    /// </summary>
    public unsafe virtual void AddBatmobileViewNonPassenger(BmSDK.BmGame.RBMPawnAI P)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddBatmobileViewNonPassenger, "BmGame.RVehicleBatmobileBase.AddBatmobileViewNonPassenger");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPassengersIntoBattleModeView;
    /// <summary>
    /// Function: SetPassengersIntoBattleModeView
    /// </summary>
    public unsafe virtual void SetPassengersIntoBattleModeView(bool bOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPassengersIntoBattleModeView, "BmGame.RVehicleBatmobileBase.SetPassengersIntoBattleModeView");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GainedChild;
    /// <summary>
    /// Function: GainedChild
    /// </summary>
    public unsafe override void GainedChild(BmSDK.Engine.Actor Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GainedChild, "BmGame.RVehicleBatmobileBase.GainedChild");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemovePassenger;
    /// <summary>
    /// Function: RemovePassenger
    /// </summary>
    public unsafe virtual bool RemovePassenger(int Slot, bool DestroyPassenger = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemovePassenger, "BmGame.RVehicleBatmobileBase.RemovePassenger");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Slot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestroyPassenger, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RemoveAllPassengers;
    /// <summary>
    /// Function: RemoveAllPassengers
    /// </summary>
    public unsafe virtual void RemoveAllPassengers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAllPassengers, "BmGame.RVehicleBatmobileBase.RemoveAllPassengers");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachPassenger;
    /// <summary>
    /// Function: AttachPassenger
    /// </summary>
    public unsafe virtual void AttachPassenger(int Slot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachPassenger, "BmGame.RVehicleBatmobileBase.AttachPassenger");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Slot, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePSMLightInstanceLocation;
    /// <summary>
    /// Function: UpdatePSMLightInstanceLocation
    /// </summary>
    public unsafe virtual void UpdatePSMLightInstanceLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePSMLightInstanceLocation, "BmGame.RVehicleBatmobileBase.UpdatePSMLightInstanceLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitPSMLightInstance;
    /// <summary>
    /// Function: InitPSMLightInstance
    /// </summary>
    public unsafe virtual void InitPSMLightInstance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitPSMLightInstance, "BmGame.RVehicleBatmobileBase.InitPSMLightInstance");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePassengerNoise;
    /// <summary>
    /// Function: UpdatePassengerNoise
    /// </summary>
    public unsafe virtual void UpdatePassengerNoise(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePassengerNoise, "BmGame.RVehicleBatmobileBase.UpdatePassengerNoise");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPassengerNoise;
    /// <summary>
    /// Function: SetPassengerNoise
    /// </summary>
    public unsafe virtual void SetPassengerNoise(BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassengerNoise> Noise)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPassengerNoise, "BmGame.RVehicleBatmobileBase.SetPassengerNoise");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Noise, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPassenger;
    /// <summary>
    /// Function: AddPassenger
    /// </summary>
    public unsafe virtual bool AddPassenger(int Slot, BmSDK.BmGame.RBMPawnAI Pawn, BmSDK.Engine.AnimSet PawnAnimSet, BmSDK.FName PawnAnimName, bool ForceIsVillain = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPassenger, "BmGame.RVehicleBatmobileBase.AddPassenger");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Slot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnAnimSet, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnAnimName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceIsVillain, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_HasAnyPassenger;
    /// <summary>
    /// Function: HasAnyPassenger
    /// </summary>
    public unsafe virtual bool HasAnyPassenger()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasAnyPassenger, "BmGame.RVehicleBatmobileBase.HasAnyPassenger");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasVillainPassenger;
    /// <summary>
    /// Function: HasVillainPassenger
    /// </summary>
    public unsafe virtual bool HasVillainPassenger()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasVillainPassenger, "BmGame.RVehicleBatmobileBase.HasVillainPassenger");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: EBatmobileEjectType
    /// </summary>
    public enum EBatmobileEjectType : byte
    {
        EBET_None = 0,
        EBET_NormalEject = 1,
        EBET_SuperEject1 = 2,
        EBET_SuperEject2 = 3,
        EBET_MAX = 4,
    }

    /// <summary>
    /// Struct: FBatmobileOnFireInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FBatmobileOnFireInfo
    {
        /// <summary>
        /// FloatProperty: PosX
        /// </summary>
        public unsafe float PosX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: PosY
        /// </summary>
        public unsafe float PosY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: Radius
        /// </summary>
        public unsafe float Radius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: DecayDelay
        /// </summary>
        public unsafe float DecayDelay
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FBatmobilePassengerNoise
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FBatmobilePassengerNoise
    {
        /// <summary>
        /// FloatProperty: MinDelay
        /// </summary>
        public unsafe float MinDelay
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MaxDelay
        /// </summary>
        public unsafe float MaxDelay
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: AudioEvent
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent AudioEvent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: BatmobileShake
        /// </summary>
        public unsafe float BatmobileShake
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FBatmobilePassenger
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public partial record struct FBatmobilePassenger
    {
        /// <summary>
        /// StrProperty: UI_LocalisedName
        /// </summary>
        public unsafe BmSDK.FString UI_LocalisedName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: UI_PortraitName
        /// </summary>
        public unsafe BmSDK.FString UI_PortraitName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: Pawn
        /// </summary>
        public unsafe BmSDK.BmGame.RBMPawnAI Pawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ObjectProperty: PawnAnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet PawnAnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// NameProperty: PawnAnimName
        /// </summary>
        public unsafe BmSDK.FName PawnAnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// BoolProperty: IsVillain
        /// </summary>
        public unsafe bool IsVillain
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Enum: EBatmobileGetOutSpace
    /// </summary>
    public enum EBatmobileGetOutSpace : byte
    {
        EBGOS_Clear = 0,
        EBGOS_LeftOnly = 1,
        EBGOS_RightOnly = 2,
        EBGOS_NoSpace = 3,
        EBGOS_MAX = 4,
    }

    /// <summary>
    /// Enum: EHandbrakeTurnType
    /// </summary>
    public enum EHandbrakeTurnType : byte
    {
        EHTT_None = 0,
        EHTT_Left = 1,
        EHTT_Right = 2,
        EHTT_MAX = 3,
    }

    /// <summary>
    /// Enum: EBatmanVsBatmobileCollisionMode
    /// </summary>
    public enum EBatmanVsBatmobileCollisionMode : byte
    {
        EBVB_Normal = 0,
        EBVB_Pursuit = 1,
        EBVB_Battle = 2,
        EBVB_MAX = 3,
    }

    /// <summary>
    /// Struct: FFloatingDamageNumber
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 76)]
    public partial record struct FFloatingDamageNumber
    {
        /// <summary>
        /// BoolProperty: bDoneInitial
        /// </summary>
        public unsafe bool bDoneInitial
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: InitialLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 InitialLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: Position
        /// </summary>
        public unsafe System.Numerics.Vector3 Position
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: Velocity
        /// </summary>
        public unsafe System.Numerics.Vector3 Velocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: RemainingDuration
        /// </summary>
        public unsafe float RemainingDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: TotalForce
        /// </summary>
        public unsafe float TotalForce
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// IntProperty: Damage
        /// </summary>
        public unsafe int Damage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// ObjectProperty: TargetActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor TargetActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: bStrafeTarget
        /// </summary>
        public unsafe bool bStrafeTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: bBoostTarget
        /// </summary>
        public unsafe bool bBoostTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: BattleModeImpact
        /// </summary>
        public unsafe bool BattleModeImpact
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: WeakPointNotHit
        /// </summary>
        public unsafe bool WeakPointNotHit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }; }
        }

        /// <summary>
        /// StructProperty: ImpactImpulse
        /// </summary>
        public unsafe System.Numerics.Vector3 ImpactImpulse
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Struct: FQueuedVehicleImpactDamage
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FQueuedVehicleImpactDamage
    {
        /// <summary>
        /// ObjectProperty: TargetVehicle
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicle TargetVehicle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: ImpactVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 ImpactVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: NumContanctsReported
        /// </summary>
        public unsafe int NumContanctsReported
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FBatmobileWeaponWarningContainer
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FBatmobileWeaponWarningContainer
    {
        /// <summary>
        /// ObjectProperty: AttackingActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor AttackingActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: StillRelevant
        /// </summary>
        public unsafe bool StillRelevant
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: WeaponWarning
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobileWeaponWarning> WeaponWarning
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobileWeaponWarning>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: VisibleInPursuitMode
        /// </summary>
        public unsafe bool VisibleInPursuitMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bOnlyShowIfCloseToBatmobile
        /// </summary>
        public unsafe bool bOnlyShowIfCloseToBatmobile
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Struct: FBatmobileWeaponWarning
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial record struct FBatmobileWeaponWarning
    {
        /// <summary>
        /// StructProperty: SourceLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 SourceLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: TargetLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: Radius
        /// </summary>
        public unsafe float Radius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ByteProperty: AttackType
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleBatmobileBase.EWeaponWarningAttackType AttackType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.EWeaponWarningAttackType>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ComponentProperty: ThisComponent
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent ThisComponent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bAttackBlocked
        /// </summary>
        public unsafe bool bAttackBlocked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: bAttackBlockedChecked
        /// </summary>
        public unsafe bool bAttackBlockedChecked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: BlockedHitLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 BlockedHitLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }

    /// <summary>
    /// Enum: EWeaponWarningAttackType
    /// </summary>
    public enum EWeaponWarningAttackType : byte
    {
        EWWAT_DirectAttack = 0,
        EWWAT_MissileAttack = 1,
        EWWAT_AreaAttack = 2,
        EWWAT_AerialAttack = 3,
        EWWAT_TurretAttack = 4,
        EWWAT_MAX = 5,
    }

    /// <summary>
    /// Enum: EBatmobilePickupMode
    /// </summary>
    public enum EBatmobilePickupMode : byte
    {
        BPM_None = 0,
        BPM_StandingPickup = 1,
        BPM_DiveBoostPickup = 2,
        BPM_RunningPickup = 3,
        BPM_GlidingPickup = 4,
        BPM_FullStopPickup = 5,
        BPM_CombatSupport = 6,
        BPM_BlockedByHeavyTanks = 7,
        BPM_Unavailable = 8,
        BPM_MAX = 9,
    }

    /// <summary>
    /// Struct: FOffScreenThreat
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FOffScreenThreat
    {
        /// <summary>
        /// StructProperty: ScreenPos
        /// </summary>
        public unsafe System.Numerics.Vector2 ScreenPos
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Orientation
        /// </summary>
        public unsafe float Orientation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: Actor
        /// </summary>
        public unsafe BmSDK.Engine.Actor Actor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ComponentProperty: Threat
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleThreatComponent Threat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleThreatComponent>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Enum: EAudioAltModeTypes
    /// </summary>
    public enum EAudioAltModeTypes : byte
    {
        ALTMODE_Normal = 0,
        ALTMODE_BattleMode = 1,
        ALTMODE_Electricity = 2,
        ALTMODE_Cinematic = 3,
        ALTMODE_Drifting = 4,
        ALTMODE_MAX = 5,
    }

    /// <summary>
    /// Enum: EVehicleWeaponSelection
    /// </summary>
    public enum EVehicleWeaponSelection : byte
    {
        VGS_Up = 0,
        VGS_Right = 1,
        VGS_Down = 2,
        VGS_Left = 3,
        VGS_AButton = 4,
        VGS_BButton = 5,
        VGS_XButton = 6,
        VGS_YButton = 7,
        VGS_DPad = 8,
        VGS_StrafeButton = 9,
        VGS_MAX = 10,
    }

    /// <summary>
    /// Struct: FTauntPosition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FTauntPosition
    {
        /// <summary>
        /// StructProperty: Offset
        /// </summary>
        public unsafe System.Numerics.Vector3 Offset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: LockedBy
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnVillain LockedBy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// StructProperty: VfTable_IRSpotableInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRSpotableInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4560); }
    }

    /// <summary>
    /// BoolProperty: RollingStart
    /// </summary>
    public unsafe bool RollingStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: ArmouredMode
    /// </summary>
    public unsafe bool ArmouredMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: ArmouredModeOld
    /// </summary>
    public unsafe bool ArmouredModeOld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bTransforming
    /// </summary>
    public unsafe bool bTransforming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bWeaponsReady
    /// </summary>
    public unsafe bool bWeaponsReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: KismetForceWheelspin
    /// </summary>
    public unsafe bool KismetForceWheelspin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: StopBoxForceWheelspin
    /// </summary>
    public unsafe bool StopBoxForceWheelspin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: WallScrapeL
    /// </summary>
    public unsafe bool WallScrapeL
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: WallScrapeR
    /// </summary>
    public unsafe bool WallScrapeR
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: EnemyTaunt_DebugVisualisation
    /// </summary>
    public unsafe bool EnemyTaunt_DebugVisualisation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: AudioPlayingIn
    /// </summary>
    public unsafe bool AudioPlayingIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bIsPrototypeBatmobile
    /// </summary>
    public unsafe bool bIsPrototypeBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bIsJokerfiedBatmobile
    /// </summary>
    public unsafe bool bIsJokerfiedBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: AbseilBlocked
    /// </summary>
    public unsafe bool AbseilBlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bBoostLocked
    /// </summary>
    public unsafe bool bBoostLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bBattleModeLocked
    /// </summary>
    public unsafe bool bBattleModeLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bLockInBattleMode
    /// </summary>
    public unsafe bool bLockInBattleMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: ForceHeadlightsSwitchedOn
    /// </summary>
    public unsafe bool ForceHeadlightsSwitchedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bFailedWeaponFlag
    /// </summary>
    public unsafe bool bFailedWeaponFlag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bCockpitOpen
    /// </summary>
    public unsafe bool bCockpitOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: AudioClutch
    /// </summary>
    public unsafe bool AudioClutch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: SatNavChallengeActive
    /// </summary>
    public unsafe bool SatNavChallengeActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveAllowBoost
    /// </summary>
    public unsafe bool SelfDriveAllowBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveUturn
    /// </summary>
    public unsafe bool SelfDriveUturn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bRemoteDrive
    /// </summary>
    public unsafe bool bRemoteDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bFakeRemoteDrive
    /// </summary>
    public unsafe bool bFakeRemoteDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bRemoteScoopUp
    /// </summary>
    public unsafe bool bRemoteScoopUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bWasRemoteDriving
    /// </summary>
    public unsafe bool bWasRemoteDriving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bRemoteDriveBatmanTrackerDisabled
    /// </summary>
    public unsafe bool bRemoteDriveBatmanTrackerDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: InfiniteBoost
    /// </summary>
    public unsafe bool InfiniteBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: DisabledByEMP
    /// </summary>
    public unsafe bool DisabledByEMP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: VulnerableToEMP
    /// </summary>
    public unsafe bool VulnerableToEMP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: EMPRepairable
    /// </summary>
    public unsafe bool EMPRepairable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: IsStolen
    /// </summary>
    public unsafe bool IsStolen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: DoNotBreakRemoteControlIfBatmanInCombat
    /// </summary>
    public unsafe bool DoNotBreakRemoteControlIfBatmanInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: CurrentStrafeTargetOnRight
    /// </summary>
    public unsafe bool CurrentStrafeTargetOnRight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: SideSwipeInSweetSpot
    /// </summary>
    public unsafe bool SideSwipeInSweetSpot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: RemoteTeleported
    /// </summary>
    public unsafe bool RemoteTeleported
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: bControlledBySeqAct
    /// </summary>
    public unsafe bool bControlledBySeqAct
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: bForceBattleModeMovement
    /// </summary>
    public unsafe bool bForceBattleModeMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: bDisableProximityPickup
    /// </summary>
    public unsafe bool bDisableProximityPickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: bDebugAdjustedAvoidanceDirection
    /// </summary>
    public unsafe bool bDebugAdjustedAvoidanceDirection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: RemoteCallIn
    /// </summary>
    public unsafe bool RemoteCallIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: OverrideSkidToStopYaw
    /// </summary>
    public unsafe bool OverrideSkidToStopYaw
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: bPMWeaponWarning
    /// </summary>
    public unsafe bool bPMWeaponWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: ForcedFixedTimeDelta
    /// </summary>
    public unsafe bool ForcedFixedTimeDelta
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: DisableWeaponWarnings
    /// </summary>
    public unsafe bool DisableWeaponWarnings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: BatmobileHitWater
    /// </summary>
    public unsafe bool BatmobileHitWater
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: BatmobileAboveOceanLevel
    /// </summary>
    public unsafe bool BatmobileAboveOceanLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: BatmobileAboutToHitWater
    /// </summary>
    public unsafe bool BatmobileAboutToHitWater
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: BatmobileAboutToAboveOceanLevel
    /// </summary>
    public unsafe bool BatmobileAboutToAboveOceanLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: SceneryCollisionDisabled
    /// </summary>
    public unsafe bool SceneryCollisionDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: DisableFallOutOfWorldLogic
    /// </summary>
    public unsafe bool DisableFallOutOfWorldLogic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: RemoteSafePointBlocked
    /// </summary>
    public unsafe bool RemoteSafePointBlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: CheatBatmobilePower
    /// </summary>
    public unsafe bool CheatBatmobilePower
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: PingHushCamera
    /// </summary>
    public unsafe bool PingHushCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: CheatIgnoreCollisionLeft
    /// </summary>
    public unsafe bool CheatIgnoreCollisionLeft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: CheatIgnoreCollisionRight
    /// </summary>
    public unsafe bool CheatIgnoreCollisionRight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: bPreventBatmbileExit
    /// </summary>
    public unsafe bool bPreventBatmbileExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: bJustLandedJump
    /// </summary>
    public unsafe bool bJustLandedJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: PassengerInformationSuppressed
    /// </summary>
    public unsafe bool PassengerInformationSuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: PassengerInformationSuppressedByFocusDetail
    /// </summary>
    public unsafe bool PassengerInformationSuppressedByFocusDetail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: DisableJumpCamera
    /// </summary>
    public unsafe bool DisableJumpCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: DisableUnderAttackWarning
    /// </summary>
    public unsafe bool DisableUnderAttackWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: MovementDisabled
    /// </summary>
    public unsafe bool MovementDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bCanGetOutOnLeftSide
    /// </summary>
    public unsafe bool bCanGetOutOnLeftSide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bDisableBoostOut
    /// </summary>
    public unsafe bool bDisableBoostOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bBattleModeControlled
    /// </summary>
    public unsafe bool bBattleModeControlled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: DoingEmergencyStop
    /// </summary>
    public unsafe bool DoingEmergencyStop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: BlockThrottleUntilReleased
    /// </summary>
    public unsafe bool BlockThrottleUntilReleased
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: CanBeCrushed
    /// </summary>
    public unsafe bool CanBeCrushed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: CrushedThisFrame
    /// </summary>
    public unsafe bool CrushedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: BouncedThisFrame
    /// </summary>
    public unsafe bool BouncedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bAwardDodgeBonus
    /// </summary>
    public unsafe bool bAwardDodgeBonus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bAreKeysBound
    /// </summary>
    public unsafe bool bAreKeysBound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bAllowPMDodge
    /// </summary>
    public unsafe bool bAllowPMDodge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: CameraFollowsRotationForLoopTheLoop
    /// </summary>
    public unsafe bool CameraFollowsRotationForLoopTheLoop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bEmergencyWeaponGenerator
    /// </summary>
    public unsafe bool bEmergencyWeaponGenerator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bWeaponGeneratorShielding
    /// </summary>
    public unsafe bool bWeaponGeneratorShielding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bDoubleDodgeUpgrade
    /// </summary>
    public unsafe bool bDoubleDodgeUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bUsedAirControlDuringJump
    /// </summary>
    public unsafe bool bUsedAirControlDuringJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bRollingPickup
    /// </summary>
    public unsafe bool bRollingPickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// FloatProperty: StrafeCooldown
    /// </summary>
    public unsafe float StrafeCooldown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4580); }
    }

    /// <summary>
    /// FloatProperty: CurrentStrafeCooldown
    /// </summary>
    public unsafe float CurrentStrafeCooldown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4584); }
    }

    /// <summary>
    /// StructProperty: StrafeRight
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StrafeRight
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4588);

    /// <summary>
    /// FloatProperty: StrafeForce
    /// </summary>
    public unsafe float StrafeForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4600); }
    }

    /// <summary>
    /// FloatProperty: StrafeTorque
    /// </summary>
    public unsafe float StrafeTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4604); }
    }

    /// <summary>
    /// FloatProperty: StrafeDuration
    /// </summary>
    public unsafe float StrafeDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4608); }
    }

    /// <summary>
    /// FloatProperty: StrafeTime
    /// </summary>
    public unsafe float StrafeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4612); }
    }

    /// <summary>
    /// FloatProperty: StrafeFwdCorrectionForce
    /// </summary>
    public unsafe float StrafeFwdCorrectionForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4616); }
    }

    /// <summary>
    /// FloatProperty: EmergencyBrakeTimer
    /// </summary>
    public unsafe float EmergencyBrakeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4620); }
    }

    /// <summary>
    /// FloatProperty: EbrakeTime
    /// </summary>
    public unsafe float EbrakeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4624); }
    }

    /// <summary>
    /// FloatProperty: EBrakeBrakeForce
    /// </summary>
    public unsafe float EBrakeBrakeForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4628); }
    }

    /// <summary>
    /// FloatProperty: EBrakeAccelForce
    /// </summary>
    public unsafe float EBrakeAccelForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4632); }
    }

    /// <summary>
    /// ComponentProperty: AfterburnerSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent AfterburnerSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4636); }
    }

    /// <summary>
    /// ComponentProperty: AfterburnerWarmupSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent AfterburnerWarmupSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4644); }
    }

    /// <summary>
    /// ComponentProperty: RearFinTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent RearFinTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4652); }
    }

    /// <summary>
    /// ComponentProperty: BrakeLightTrailSystemL
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BrakeLightTrailSystemL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4660); }
    }

    /// <summary>
    /// ComponentProperty: BrakeLightTrailSystemR
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BrakeLightTrailSystemR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4668); }
    }

    /// <summary>
    /// ComponentProperty: SpeedLinesSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent SpeedLinesSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4676); }
    }

    /// <summary>
    /// ObjectProperty: ExhaustBurstEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ExhaustBurstEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4684); }
    }

    /// <summary>
    /// ObjectProperty: SideExhaustBurstEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SideExhaustBurstEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4692); }
    }

    /// <summary>
    /// ObjectProperty: SideExhaustBoostEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SideExhaustBoostEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4700); }
    }

    /// <summary>
    /// ObjectProperty: ImpactSparks
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ImpactSparks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4708); }
    }

    /// <summary>
    /// ObjectProperty: JumpLandSparksEffectL
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem JumpLandSparksEffectL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4716); }
    }

    /// <summary>
    /// ObjectProperty: JumpLandSparksEffectR
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem JumpLandSparksEffectR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4724); }
    }

    /// <summary>
    /// ObjectProperty: AbseilSparksEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem AbseilSparksEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4732); }
    }

    /// <summary>
    /// ObjectProperty: AbseilSparksSoundEffect
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AbseilSparksSoundEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4740); }
    }

    /// <summary>
    /// ObjectProperty: BurnoutDynamicGridActorTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridActor BurnoutDynamicGridActorTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridActor>(Ptr + 4748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4748); }
    }

    /// <summary>
    /// ObjectProperty: BurnoutDynamicGridActorInstance
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridActor BurnoutDynamicGridActorInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridActor>(Ptr + 4756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4756); }
    }

    /// <summary>
    /// ObjectProperty: WispyDynamicGridActorTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridActor WispyDynamicGridActorTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridActor>(Ptr + 4764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4764); }
    }

    /// <summary>
    /// ObjectProperty: WispyDynamicGridActorInstance
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridActor WispyDynamicGridActorInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridActor>(Ptr + 4772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4772); }
    }

    /// <summary>
    /// ObjectProperty: PSMLightTemplate
    /// </summary>
    public unsafe BmSDK.BmGame.RDeferred_SpotLight_Shadowed_Spawnable PSMLightTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeferred_SpotLight_Shadowed_Spawnable>(Ptr + 4780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4780); }
    }

    /// <summary>
    /// ObjectProperty: PSMLightInstance
    /// </summary>
    public unsafe BmSDK.BmGame.RDeferred_SpotLight_Shadowed_Spawnable PSMLightInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeferred_SpotLight_Shadowed_Spawnable>(Ptr + 4788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4788); }
    }

    /// <summary>
    /// ObjectProperty: PlayerVehicleInfo
    /// </summary>
    public unsafe BmSDK.Engine.AkPlayerVehicleSoundInfo PlayerVehicleInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkPlayerVehicleSoundInfo>(Ptr + 4796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4796); }
    }

    /// <summary>
    /// ObjectProperty: ExplosiveImpactSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ExplosiveImpactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4804); }
    }

    /// <summary>
    /// ObjectProperty: SpinningSpikesImpactFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SpinningSpikesImpactFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4812); }
    }

    /// <summary>
    /// ObjectProperty: SpinningSpikesImpactSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SpinningSpikesImpactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4820); }
    }

    /// <summary>
    /// ObjectProperty: TransformationReverseDirectionIntoPursuitModeSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TransformationReverseDirectionIntoPursuitModeSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4828); }
    }

    /// <summary>
    /// ObjectProperty: TransformationReverseDirectionIntoBattleModeSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TransformationReverseDirectionIntoBattleModeSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4836); }
    }

    /// <summary>
    /// ObjectProperty: Transform_In_Bed
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent Transform_In_Bed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4844); }
    }

    /// <summary>
    /// ObjectProperty: Transform_In_Reverse_Bed
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent Transform_In_Reverse_Bed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4852); }
    }

    /// <summary>
    /// ObjectProperty: Transform_Out_Bed
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent Transform_Out_Bed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4860); }
    }

    /// <summary>
    /// ObjectProperty: Transform_Out_Reverse_Bed
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent Transform_Out_Reverse_Bed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4868); }
    }

    /// <summary>
    /// ObjectProperty: CurrentWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon CurrentWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4876); }
    }

    /// <summary>
    /// ObjectProperty: SecondaryWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon SecondaryWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4884); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileWinch
    /// </summary>
    public unsafe BmSDK.BmGame.RBatmobileWinch BatmobileWinch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatmobileWinch>(Ptr + 4892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4892); }
    }

    /// <summary>
    /// ObjectProperty: SideSwipeTargetsList
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass SideSwipeTargetsList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 4900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4900); }
    }

    /// <summary>
    /// ObjectProperty: ZappableThugs
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass ZappableThugs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 4908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4908); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: VehicleWeapons
    /// </summary>
    public InlineArray<BmSDK.BmGame.RVehicleWeapon> VehicleWeapons => new(10, Ptr + 4916, 8, this);

    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4916); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4924); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4932); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4940); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4948); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4956); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4964); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4972); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4980); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4988); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: PursuitModeWeapons
    /// </summary>
    public InlineArray<BmSDK.BmGame.RVehicleWeapon> PursuitModeWeapons => new(10, Ptr + 4996, 8, this);

    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4996); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5004); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5012); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5020); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5028); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5036); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5044); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5052); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5060); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5068); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: ActualWeapons
    /// </summary>
    public InlineArray<BmSDK.BmGame.RVehicleWeapon> ActualWeapons => new(10, Ptr + 5076, 8, this);

    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5076); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5084); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5092); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5100); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5108); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5116); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5124); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5132); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5140); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5148); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: ActualPMWeapons
    /// </summary>
    public InlineArray<BmSDK.BmGame.RVehicleWeapon> ActualPMWeapons => new(10, Ptr + 5156, 8, this);

    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5156); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5164); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5172); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5180); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5188); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5196); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5204); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5212); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5220); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5228); }
    }

    /// <summary>
    /// ObjectProperty: PursuitModePrimaryWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModePrimaryWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5236); }
    }

    /// <summary>
    /// ObjectProperty: BattleModePrimaryWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon BattleModePrimaryWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5244); }
    }

    /// <summary>
    /// ObjectProperty: BattleDodgeFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform BattleDodgeFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 5252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5252); }
    }

    /// <summary>
    /// ObjectProperty: DiedFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform DiedFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 5260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5260); }
    }

    /// <summary>
    /// ObjectProperty: TransformationAnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence TransformationAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 5268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5268); }
    }

    /// <summary>
    /// ObjectProperty: CockpitAnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence CockpitAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 5276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5276); }
    }

    /// <summary>
    /// ObjectProperty: TurretController
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSingleBone TurretController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSingleBone>(Ptr + 5284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5284); }
    }

    /// <summary>
    /// ObjectProperty: BoostBlendNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend BoostBlendNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 5292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5292); }
    }

    /// <summary>
    /// ObjectProperty: ArmourBlendNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend ArmourBlendNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 5300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5300); }
    }

    /// <summary>
    /// ObjectProperty: AirBrakeLeftNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence AirBrakeLeftNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 5308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5308); }
    }

    /// <summary>
    /// ObjectProperty: AirBrakeRightNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence AirBrakeRightNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 5316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5316); }
    }

    /// <summary>
    /// ObjectProperty: AfterburnerBlendNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend AfterburnerBlendNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 5324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5324); }
    }

    /// <summary>
    /// ObjectProperty: AfterburnerAnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence AfterburnerAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 5332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5332); }
    }

    /// <summary>
    /// ObjectProperty: GeneratorPowerMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant GeneratorPowerMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 5340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5340); }
    }

    /// <summary>
    /// ObjectProperty: StrafeTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle StrafeTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle>(Ptr + 5348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5348); }
    }

    /// <summary>
    /// ObjectProperty: CurrentStrafeTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle CurrentStrafeTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle>(Ptr + 5356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5356); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileRoadNetwork
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadNetwork BatmobileRoadNetwork
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork>(Ptr + 5364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5364); }
    }

    /// <summary>
    /// ObjectProperty: BatwingRescueArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RBatwing BatwingRescueArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatwing>(Ptr + 5372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5372); }
    }

    /// <summary>
    /// ObjectProperty: BatwingRescue
    /// </summary>
    public unsafe BmSDK.BmGame.RBatwing BatwingRescue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatwing>(Ptr + 5380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5380); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: WarningParticleSystemTemplate
    /// </summary>
    public InlineArray<BmSDK.Engine.ParticleSystem> WarningParticleSystemTemplate => new(5, Ptr + 5388, 8, this);

    /// <summary>
    /// ObjectProperty: WarningParticleSystemTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WarningParticleSystemTemplate_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5388); }
    }
    /// <summary>
    /// ObjectProperty: WarningParticleSystemTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WarningParticleSystemTemplate_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5396); }
    }
    /// <summary>
    /// ObjectProperty: WarningParticleSystemTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WarningParticleSystemTemplate_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5404); }
    }
    /// <summary>
    /// ObjectProperty: WarningParticleSystemTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WarningParticleSystemTemplate_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5412); }
    }
    /// <summary>
    /// ObjectProperty: WarningParticleSystemTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WarningParticleSystemTemplate_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5420); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: WarningOnAudioEvent
    /// </summary>
    public InlineArray<BmSDK.Engine.AkEvent> WarningOnAudioEvent => new(5, Ptr + 5428, 8, this);

    /// <summary>
    /// ObjectProperty: WarningOnAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WarningOnAudioEvent_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5428); }
    }
    /// <summary>
    /// ObjectProperty: WarningOnAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WarningOnAudioEvent_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5436); }
    }
    /// <summary>
    /// ObjectProperty: WarningOnAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WarningOnAudioEvent_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5444); }
    }
    /// <summary>
    /// ObjectProperty: WarningOnAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WarningOnAudioEvent_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5452); }
    }
    /// <summary>
    /// ObjectProperty: WarningOnAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WarningOnAudioEvent_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5460); }
    }

    /// <summary>
    /// ObjectProperty: InPollenWarningMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant InPollenWarningMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 5468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5468); }
    }

    /// <summary>
    /// ObjectProperty: OneTimeSpecialGetIn
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig OneTimeSpecialGetIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5476); }
    }

    /// <summary>
    /// ObjectProperty: ShortRangeGlideKick
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ShortRangeGlideKick
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5484); }
    }

    /// <summary>
    /// ObjectProperty: HeadLightsMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant HeadLightsMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 5492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5492); }
    }

    /// <summary>
    /// ObjectProperty: DiskBrakeMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant DiskBrakeMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 5500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5500); }
    }

    /// <summary>
    /// ObjectProperty: EMPMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant EMPMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 5508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5508); }
    }

    /// <summary>
    /// ObjectProperty: BrakeLightsLensFlare
    /// </summary>
    public unsafe BmSDK.Engine.LensFlare BrakeLightsLensFlare
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LensFlare>(Ptr + 5516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5516); }
    }

    /// <summary>
    /// ObjectProperty: TailLightsLensFlare
    /// </summary>
    public unsafe BmSDK.Engine.LensFlare TailLightsLensFlare
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LensFlare>(Ptr + 5524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5524); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileViewMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface BatmobileViewMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 5532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5532); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileViewMaterialForPawns
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface BatmobileViewMaterialForPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 5540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5540); }
    }

    /// <summary>
    /// ObjectProperty: QueuedImpactActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor QueuedImpactActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 5548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5548); }
    }

    /// <summary>
    /// ObjectProperty: DeadBatmobileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RDeadVehicle DeadBatmobileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeadVehicle>(Ptr + 5556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5556); }
    }

    /// <summary>
    /// ObjectProperty: DeathExplosion
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DeathExplosion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5564); }
    }

    /// <summary>
    /// ObjectProperty: DeathExplosionSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DeathExplosionSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5572); }
    }

    /// <summary>
    /// ObjectProperty: LocationPredictor
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobilePredictor LocationPredictor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobilePredictor>(Ptr + 5580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5580); }
    }

    /// <summary>
    /// ObjectProperty: FakeDestructibleEffectMat
    /// </summary>
    public unsafe BmSDK.Engine.PhysicalMaterial FakeDestructibleEffectMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicalMaterial>(Ptr + 5588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5588); }
    }

    /// <summary>
    /// ObjectProperty: CollisionFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform CollisionFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 5596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5596); }
    }

    /// <summary>
    /// ObjectProperty: OverrideNextEject
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_OverrideBatmobileEject OverrideNextEject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_OverrideBatmobileEject>(Ptr + 5604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5604); }
    }

    /// <summary>
    /// ObjectProperty: HeatSteamEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HeatSteamEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5612); }
    }

    /// <summary>
    /// ObjectProperty: WaitForBatmobileActionSequenceAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_WaitForBatmobileAction WaitForBatmobileActionSequenceAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_WaitForBatmobileAction>(Ptr + 5620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5620); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileOnFireMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BatmobileOnFireMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 5628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5628); }
    }

    /// <summary>
    /// ObjectProperty: CurrentWeaponGeneratorMesh
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponGeneratorContainer CurrentWeaponGeneratorMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponGeneratorContainer>(Ptr + 5636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5636); }
    }

    /// <summary>
    /// ObjectProperty: LastDamageCauser
    /// </summary>
    public unsafe BmSDK.Engine.Actor LastDamageCauser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 5644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5644); }
    }

    /// <summary>
    /// ObjectProperty: RunningPickup
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RunningPickup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5652); }
    }

    /// <summary>
    /// ComponentProperty: WeaponGeneratorMeshComp
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent WeaponGeneratorMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 5660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5660); }
    }

    /// <summary>
    /// ClassProperty: CrushDamageType
    /// </summary>
    public unsafe BmSDK.Class CrushDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5668); }
    }

    /// <summary>
    /// ClassProperty: RamDamageType
    /// </summary>
    public unsafe BmSDK.Class RamDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5676); }
    }

    /// <summary>
    /// ComponentProperty: BatmobileOnFireMeshComp
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BatmobileOnFireMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 5684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5684); }
    }

    /// <summary>
    /// ComponentProperty: RearCylinderComponent
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent RearCylinderComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 5692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5692); }
    }

    /// <summary>
    /// ComponentProperty: FrontCylinderComponent
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent FrontCylinderComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 5700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5700); }
    }

    /// <summary>
    /// ComponentProperty: HeatSteam
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent HeatSteam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5708); }
    }

    /// <summary>
    /// ComponentProperty: BatmobileViewMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BatmobileViewMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 5716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5716); }
    }

    /// <summary>
    /// ComponentProperty: BatmanCollisionMeshBattleMode
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent BatmanCollisionMeshBattleMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 5724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5724); }
    }

    /// <summary>
    /// ComponentProperty: BatmanCollisionMeshPursuitMode
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent BatmanCollisionMeshPursuitMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 5732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5732); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: WarningPSCache
    /// </summary>
    public InlineArray<BmSDK.Engine.ParticleSystemComponent> WarningPSCache => new(8, Ptr + 5740, 8, this);

    /// <summary>
    /// ComponentProperty: WarningPSCache
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WarningPSCache_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5740); }
    }
    /// <summary>
    /// ComponentProperty: WarningPSCache
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WarningPSCache_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5748); }
    }
    /// <summary>
    /// ComponentProperty: WarningPSCache
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WarningPSCache_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5756); }
    }
    /// <summary>
    /// ComponentProperty: WarningPSCache
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WarningPSCache_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5764); }
    }
    /// <summary>
    /// ComponentProperty: WarningPSCache
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WarningPSCache_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5772); }
    }
    /// <summary>
    /// ComponentProperty: WarningPSCache
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WarningPSCache_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5780); }
    }
    /// <summary>
    /// ComponentProperty: WarningPSCache
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WarningPSCache_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5788); }
    }
    /// <summary>
    /// ComponentProperty: WarningPSCache
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WarningPSCache_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5796); }
    }

    /// <summary>
    /// ComponentProperty: ThugZapperInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent ThugZapperInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 5804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5804); }
    }

    /// <summary>
    /// ComponentProperty: XrayLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent XrayLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 5812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5812); }
    }

    /// <summary>
    /// ComponentProperty: NVBurnoutIosPSC
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent NVBurnoutIosPSC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5820); }
    }

    /// <summary>
    /// ComponentProperty: NVCannonIosPSC
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent NVCannonIosPSC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5828); }
    }

    /// <summary>
    /// ComponentProperty: ZapperRR
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ZapperRR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5836); }
    }

    /// <summary>
    /// ComponentProperty: ZapperRL
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ZapperRL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5844); }
    }

    /// <summary>
    /// ComponentProperty: ZapperFR
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ZapperFR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5852); }
    }

    /// <summary>
    /// ComponentProperty: ZapperFL
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ZapperFL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5860); }
    }

    /// <summary>
    /// ComponentProperty: WallScrapeSparksSystemR
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WallScrapeSparksSystemR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5868); }
    }

    /// <summary>
    /// ComponentProperty: WallScrapeSparksSystemL
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WallScrapeSparksSystemL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5876); }
    }

    /// <summary>
    /// FloatProperty: ZapperTime
    /// </summary>
    public unsafe float ZapperTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5884); }
    }

    /// <summary>
    /// ByteProperty: WallScrapeCounterL
    /// </summary>
    public unsafe byte WallScrapeCounterL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5888); }
    }

    /// <summary>
    /// ByteProperty: WallScrapeCounterR
    /// </summary>
    public unsafe byte WallScrapeCounterR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5889); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5889); }
    }

    /// <summary>
    /// ByteProperty: JumpLandSparksCounterL
    /// </summary>
    public unsafe byte JumpLandSparksCounterL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5890); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5890); }
    }

    /// <summary>
    /// ByteProperty: JumpLandSparksCounterR
    /// </summary>
    public unsafe byte JumpLandSparksCounterR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5891); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5891); }
    }

    /// <summary>
    /// ByteProperty: InCrushVolume
    /// </summary>
    public unsafe byte InCrushVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5892); }
    }

    /// <summary>
    /// ByteProperty: InTunnelVolume
    /// </summary>
    public unsafe byte InTunnelVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5893); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5893); }
    }

    /// <summary>
    /// ByteProperty: PickupMode
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.EBatmobilePickupMode PickupMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.EBatmobilePickupMode>(Ptr + 5894); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5894); }
    }

    /// <summary>
    /// ByteProperty: BatmanVsBatmobileCollisionMode
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.EBatmanVsBatmobileCollisionMode BatmanVsBatmobileCollisionMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.EBatmanVsBatmobileCollisionMode>(Ptr + 5895); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5895); }
    }

    /// <summary>
    /// ByteProperty: ZeroStoredAccelFrames
    /// </summary>
    public unsafe byte ZeroStoredAccelFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5896); }
    }

    /// <summary>
    /// ByteProperty: DisableStasisFrames
    /// </summary>
    public unsafe byte DisableStasisFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5897); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5897); }
    }

    /// <summary>
    /// ByteProperty: HandbrakeTurnType
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.EHandbrakeTurnType HandbrakeTurnType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.EHandbrakeTurnType>(Ptr + 5898); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5898); }
    }

    /// <summary>
    /// ByteProperty: WeaponUnavailableReason
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon.EHudDisplayLevel WeaponUnavailableReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon.EHudDisplayLevel>(Ptr + 5899); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5899); }
    }

    /// <summary>
    /// ByteProperty: SelfRightingMode
    /// </summary>
    public unsafe byte SelfRightingMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5900); }
    }

    /// <summary>
    /// ByteProperty: BoostingOut
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileEjectType BoostingOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileEjectType>(Ptr + 5901); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5901); }
    }

    /// <summary>
    /// ByteProperty: MaxEjectType
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileEjectType MaxEjectType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileEjectType>(Ptr + 5902); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5902); }
    }

    /// <summary>
    /// NameProperty: ImpactSparksSizeName
    /// </summary>
    public unsafe BmSDK.FName ImpactSparksSizeName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5904); }
    }

    /// <summary>
    /// IntProperty: HeadLightMaterialIndex
    /// </summary>
    public unsafe int HeadLightMaterialIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5912); }
    }

    /// <summary>
    /// IntProperty: DiskBrakeMaterialIndex
    /// </summary>
    public unsafe int DiskBrakeMaterialIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5916); }
    }

    /// <summary>
    /// ArrayProperty: MuddyCarMaterialIndices
    /// </summary>
    public unsafe BmSDK.TArray<int> MuddyCarMaterialIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 5920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5920); }
    }

    /// <summary>
    /// IntProperty: EMPMaterialIndex
    /// </summary>
    public unsafe int EMPMaterialIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5936); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceDriving
    /// </summary>
    public unsafe float TimeSinceDriving
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5940); }
    }

    /// <summary>
    /// FloatProperty: LastMobileTime
    /// </summary>
    public unsafe float LastMobileTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5944); }
    }

    /// <summary>
    /// StructProperty: ImmobileCheckLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ImmobileCheckLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5948);

    /// <summary>
    /// ArrayProperty: TauntPositions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FTauntPosition> TauntPositions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FTauntPosition>>(Ptr + 5960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5960); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistTimer
    /// </summary>
    public unsafe float ImpactRoadAssistTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5976); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistSceneryDuration
    /// </summary>
    public unsafe float ImpactRoadAssistSceneryDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5980); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistEnemyDuration
    /// </summary>
    public unsafe float ImpactRoadAssistEnemyDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5984); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistFactor
    /// </summary>
    public unsafe float ImpactRoadAssistFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5988); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistMaxTorque
    /// </summary>
    public unsafe float ImpactRoadAssistMaxTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5992); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistMaxAngle
    /// </summary>
    public unsafe float ImpactRoadAssistMaxAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5996); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistAngVelocityTime
    /// </summary>
    public unsafe float ImpactRoadAssistAngVelocityTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6000); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistSteeringFactor
    /// </summary>
    public unsafe float ImpactRoadAssistSteeringFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6004); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistLookAheadTime
    /// </summary>
    public unsafe float ImpactRoadAssistLookAheadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6008); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistAngleStrength
    /// </summary>
    public unsafe float ImpactRoadAssistAngleStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6012); }
    }

    /// <summary>
    /// StructProperty: TransformBed
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle TransformBed
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 6016);

    /// <summary>
    /// FloatProperty: EjectUpDist
    /// </summary>
    public unsafe float EjectUpDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6032); }
    }

    /// <summary>
    /// StructProperty: CheckpointBlockadeCantMoveDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CheckpointBlockadeCantMoveDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6036);

    /// <summary>
    /// FloatProperty: AccelTorqueFactor
    /// </summary>
    public unsafe float AccelTorqueFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6048); }
    }

    /// <summary>
    /// FloatProperty: BrakeSpinOutAngVel
    /// </summary>
    public unsafe float BrakeSpinOutAngVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6052); }
    }

    /// <summary>
    /// FloatProperty: BrakeSpinOutTorqueFactor
    /// </summary>
    public unsafe float BrakeSpinOutTorqueFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6056); }
    }

    /// <summary>
    /// FloatProperty: GearChangeBodyPitch
    /// </summary>
    public unsafe float GearChangeBodyPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6060); }
    }

    /// <summary>
    /// ArrayProperty: PressurePads
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPresurePadBase> PressurePads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPresurePadBase>>(Ptr + 6064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6064); }
    }

    /// <summary>
    /// InlineArray{StrProperty}: VehicleWeaponFlags
    /// </summary>
    public InlineArray<BmSDK.FString> VehicleWeaponFlags => new(10, Ptr + 6080, 16, this);

    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6080); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6096); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6112); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6128); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6144); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6160); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6176); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6192); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6208); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6224); }
    }

    /// <summary>
    /// InlineArray{StrProperty}: PursuitModeWeaponFlags
    /// </summary>
    public InlineArray<BmSDK.FString> PursuitModeWeaponFlags => new(10, Ptr + 6240, 16, this);

    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6240); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6256); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6272); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6288); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6304); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6320); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6336); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6352); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6368); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6384); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveStuckTime
    /// </summary>
    public unsafe float SelfDriveStuckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6400); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveReverseTime
    /// </summary>
    public unsafe float SelfDriveReverseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6404); }
    }

    /// <summary>
    /// FloatProperty: CurrentThrottle
    /// </summary>
    public unsafe float CurrentThrottle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6408); }
    }

    /// <summary>
    /// FloatProperty: ThrottleSpeed
    /// </summary>
    public unsafe float ThrottleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6412); }
    }

    /// <summary>
    /// IntProperty: BattleModeYawOffset
    /// </summary>
    public unsafe int BattleModeYawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6416); }
    }

    /// <summary>
    /// FloatProperty: BattleDodgeImpulse
    /// </summary>
    public unsafe float BattleDodgeImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6420); }
    }

    /// <summary>
    /// IntProperty: ArmourModeDamageReduction
    /// </summary>
    public unsafe int ArmourModeDamageReduction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6424); }
    }

    /// <summary>
    /// ArrayProperty: TurretPitchController
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkelControlSingleBone> TurretPitchController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkelControlSingleBone>>(Ptr + 6428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6428); }
    }

    /// <summary>
    /// FloatProperty: AirBrakeLeft
    /// </summary>
    public unsafe float AirBrakeLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6444); }
    }

    /// <summary>
    /// FloatProperty: AirBrakeRight
    /// </summary>
    public unsafe float AirBrakeRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6448); }
    }

    /// <summary>
    /// FloatProperty: WantAirBrakeLeft
    /// </summary>
    public unsafe float WantAirBrakeLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6452); }
    }

    /// <summary>
    /// FloatProperty: WantAirBrakeRight
    /// </summary>
    public unsafe float WantAirBrakeRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6456); }
    }

    /// <summary>
    /// NameProperty: BattleModeTransformationAnimName
    /// </summary>
    public unsafe BmSDK.FName BattleModeTransformationAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6460); }
    }

    /// <summary>
    /// NameProperty: PursuitModeTransformationAnimName
    /// </summary>
    public unsafe BmSDK.FName PursuitModeTransformationAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6468); }
    }

    /// <summary>
    /// FloatProperty: LastStrafeRange
    /// </summary>
    public unsafe float LastStrafeRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6476); }
    }

    /// <summary>
    /// IntProperty: CurrentGeneratorLevel
    /// </summary>
    public unsafe int CurrentGeneratorLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6480); }
    }

    /// <summary>
    /// ArrayProperty: ColourLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FLinearColor> ColourLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FLinearColor>>(Ptr + 6484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6484); }
    }

    /// <summary>
    /// FloatProperty: CurrentStrafeTargetRange
    /// </summary>
    public unsafe float CurrentStrafeTargetRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6500); }
    }

    /// <summary>
    /// IntProperty: BatmobileRoadLink
    /// </summary>
    public unsafe int BatmobileRoadLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6504); }
    }

    /// <summary>
    /// FloatProperty: BatmobileRoadLinkTime
    /// </summary>
    public unsafe float BatmobileRoadLinkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6508); }
    }

    /// <summary>
    /// StructProperty: RemoteSafePointLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RemoteSafePointLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6512);

    /// <summary>
    /// StructProperty: RemoteSafePointRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator RemoteSafePointRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 6524);

    /// <summary>
    /// IntProperty: SafePointLevelIndex
    /// </summary>
    public unsafe int SafePointLevelIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6536); }
    }

    /// <summary>
    /// IntProperty: BatmobileLevelVolIndex
    /// </summary>
    public unsafe int BatmobileLevelVolIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6540); }
    }

    /// <summary>
    /// FloatProperty: PreventModeSwitchDuration
    /// </summary>
    public unsafe float PreventModeSwitchDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6544); }
    }

    /// <summary>
    /// FloatProperty: BattleModeWidth
    /// </summary>
    public unsafe float BattleModeWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6548); }
    }

    /// <summary>
    /// FloatProperty: BattleModeLength
    /// </summary>
    public unsafe float BattleModeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6552); }
    }

    /// <summary>
    /// FloatProperty: BattleModeHeight
    /// </summary>
    public unsafe float BattleModeHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6556); }
    }

    /// <summary>
    /// FloatProperty: PursuitModeWidth
    /// </summary>
    public unsafe float PursuitModeWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6560); }
    }

    /// <summary>
    /// FloatProperty: PursuitModeLength
    /// </summary>
    public unsafe float PursuitModeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6564); }
    }

    /// <summary>
    /// FloatProperty: PursuitModeHeight
    /// </summary>
    public unsafe float PursuitModeHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6568); }
    }

    /// <summary>
    /// FloatProperty: AdjustedCarDirectionFactor
    /// </summary>
    public unsafe float AdjustedCarDirectionFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6572); }
    }

    /// <summary>
    /// IntProperty: OverrideSkidToStopYawAngle
    /// </summary>
    public unsafe int OverrideSkidToStopYawAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6576); }
    }

    /// <summary>
    /// FloatProperty: LastBoostPickupTime
    /// </summary>
    public unsafe float LastBoostPickupTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6580); }
    }

    /// <summary>
    /// FloatProperty: AfterburnerRumbleStrength
    /// </summary>
    public unsafe float AfterburnerRumbleStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6584); }
    }

    /// <summary>
    /// NameProperty: InPollenWarningOverrideName
    /// </summary>
    public unsafe BmSDK.FName InPollenWarningOverrideName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6588); }
    }

    /// <summary>
    /// StructProperty: ExplosiveImpactScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ExplosiveImpactScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 6596);

    /// <summary>
    /// FloatProperty: JumpRampUpwardForce
    /// </summary>
    public unsafe float JumpRampUpwardForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6752); }
    }

    /// <summary>
    /// FloatProperty: JumpRampRightingTorque
    /// </summary>
    public unsafe float JumpRampRightingTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6756); }
    }

    /// <summary>
    /// FloatProperty: JumpNoRampRightingTorque
    /// </summary>
    public unsafe float JumpNoRampRightingTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6760); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: MissileBoneNames
    /// </summary>
    public InlineArray<BmSDK.FName> MissileBoneNames => new(8, Ptr + 6764, 8, this);

    /// <summary>
    /// NameProperty: MissileBoneNames
    /// </summary>
    public unsafe BmSDK.FName MissileBoneNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6764); }
    }
    /// <summary>
    /// NameProperty: MissileBoneNames
    /// </summary>
    public unsafe BmSDK.FName MissileBoneNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6772); }
    }
    /// <summary>
    /// NameProperty: MissileBoneNames
    /// </summary>
    public unsafe BmSDK.FName MissileBoneNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6780); }
    }
    /// <summary>
    /// NameProperty: MissileBoneNames
    /// </summary>
    public unsafe BmSDK.FName MissileBoneNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6788); }
    }
    /// <summary>
    /// NameProperty: MissileBoneNames
    /// </summary>
    public unsafe BmSDK.FName MissileBoneNames_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6796); }
    }
    /// <summary>
    /// NameProperty: MissileBoneNames
    /// </summary>
    public unsafe BmSDK.FName MissileBoneNames_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6804); }
    }
    /// <summary>
    /// NameProperty: MissileBoneNames
    /// </summary>
    public unsafe BmSDK.FName MissileBoneNames_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6812); }
    }
    /// <summary>
    /// NameProperty: MissileBoneNames
    /// </summary>
    public unsafe BmSDK.FName MissileBoneNames_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6820); }
    }

    /// <summary>
    /// ArrayProperty: WeaponWarnings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobileWeaponWarningContainer> WeaponWarnings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobileWeaponWarningContainer>>(Ptr + 6828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6828); }
    }

    /// <summary>
    /// IntProperty: CurrentWeaponWarningCheckId
    /// </summary>
    public unsafe int CurrentWeaponWarningCheckId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6844); }
    }

    /// <summary>
    /// FloatProperty: ShortRangeGlideKickRange
    /// </summary>
    public unsafe float ShortRangeGlideKickRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6848); }
    }

    /// <summary>
    /// StructProperty: SelfDriveRoadObstacleTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicle.FRoadObstacleTypes SelfDriveRoadObstacleTypes
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicle.FRoadObstacleTypes>(Ptr + 6852);

    /// <summary>
    /// FloatProperty: ImpactMaxDamage
    /// </summary>
    public unsafe float ImpactMaxDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6856); }
    }

    /// <summary>
    /// FloatProperty: ImpactMaxDamageSpeed
    /// </summary>
    public unsafe float ImpactMaxDamageSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6860); }
    }

    /// <summary>
    /// FloatProperty: ImpactMinDamageSpeed
    /// </summary>
    public unsafe float ImpactMinDamageSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6864); }
    }

    /// <summary>
    /// FloatProperty: ImpactStrafeMod
    /// </summary>
    public unsafe float ImpactStrafeMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6868); }
    }

    /// <summary>
    /// FloatProperty: ImpactCivilianVehicleMod
    /// </summary>
    public unsafe float ImpactCivilianVehicleMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6872); }
    }

    /// <summary>
    /// FloatProperty: ImpactBoostMod
    /// </summary>
    public unsafe float ImpactBoostMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6876); }
    }

    /// <summary>
    /// FloatProperty: ImpactMaxDamagePow
    /// </summary>
    public unsafe float ImpactMaxDamagePow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6880); }
    }

    /// <summary>
    /// FloatProperty: BattleModeImpactMaxDamageSpeed
    /// </summary>
    public unsafe float BattleModeImpactMaxDamageSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6884); }
    }

    /// <summary>
    /// FloatProperty: BattleModeImpactMinDamageSpeed
    /// </summary>
    public unsafe float BattleModeImpactMinDamageSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6888); }
    }

    /// <summary>
    /// FloatProperty: BattleModeImpactMaxDamagePow
    /// </summary>
    public unsafe float BattleModeImpactMaxDamagePow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6892); }
    }

    /// <summary>
    /// FloatProperty: StafeImpactImpulse
    /// </summary>
    public unsafe float StafeImpactImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6896); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: QueuedVehDamage
    /// </summary>
    public InlineArray<BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage> QueuedVehDamage => new(8, Ptr + 6900, 24, this);

    /// <summary>
    /// StructProperty: QueuedVehDamage
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage QueuedVehDamage_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage>(Ptr + 6900);
    /// <summary>
    /// StructProperty: QueuedVehDamage
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage QueuedVehDamage_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage>(Ptr + 6924);
    /// <summary>
    /// StructProperty: QueuedVehDamage
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage QueuedVehDamage_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage>(Ptr + 6948);
    /// <summary>
    /// StructProperty: QueuedVehDamage
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage QueuedVehDamage_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage>(Ptr + 6972);
    /// <summary>
    /// StructProperty: QueuedVehDamage
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage QueuedVehDamage_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage>(Ptr + 6996);
    /// <summary>
    /// StructProperty: QueuedVehDamage
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage QueuedVehDamage_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage>(Ptr + 7020);
    /// <summary>
    /// StructProperty: QueuedVehDamage
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage QueuedVehDamage_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage>(Ptr + 7044);
    /// <summary>
    /// StructProperty: QueuedVehDamage
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage QueuedVehDamage_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage>(Ptr + 7068);

    /// <summary>
    /// ArrayProperty: MuddyCarMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> MuddyCarMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 7092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7092); }
    }

    /// <summary>
    /// StructProperty: HeadLightsColourPursuit
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor HeadLightsColourPursuit
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 7108);

    /// <summary>
    /// StructProperty: HeadLightsColourBattle
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor HeadLightsColourBattle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 7124);

    /// <summary>
    /// FloatProperty: DiskBrakeHeatFront
    /// </summary>
    public unsafe float DiskBrakeHeatFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7140); }
    }

    /// <summary>
    /// FloatProperty: DiskBrakeHeatRear
    /// </summary>
    public unsafe float DiskBrakeHeatRear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7144); }
    }

    /// <summary>
    /// FloatProperty: MuddyCar
    /// </summary>
    public unsafe float MuddyCar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7148); }
    }

    /// <summary>
    /// FloatProperty: FakeExtraSpeed
    /// </summary>
    public unsafe float FakeExtraSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7152); }
    }

    /// <summary>
    /// FloatProperty: FakeExtraSpeedMax
    /// </summary>
    public unsafe float FakeExtraSpeedMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7156); }
    }

    /// <summary>
    /// FloatProperty: FakeExtaSpeedAccel
    /// </summary>
    public unsafe float FakeExtaSpeedAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7160); }
    }

    /// <summary>
    /// FloatProperty: FakeExtaSpeedDecel
    /// </summary>
    public unsafe float FakeExtaSpeedDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7164); }
    }

    /// <summary>
    /// ArrayProperty: DamageNumbers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FFloatingDamageNumber> DamageNumbers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FFloatingDamageNumber>>(Ptr + 7168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7168); }
    }

    /// <summary>
    /// FloatProperty: SideSwipeRange
    /// </summary>
    public unsafe float SideSwipeRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7184); }
    }

    /// <summary>
    /// FloatProperty: SideSwipeFwdRange
    /// </summary>
    public unsafe float SideSwipeFwdRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7188); }
    }

    /// <summary>
    /// FloatProperty: KillFlipTorque
    /// </summary>
    public unsafe float KillFlipTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7192); }
    }

    /// <summary>
    /// FloatProperty: KillFlipTorqueDuration
    /// </summary>
    public unsafe float KillFlipTorqueDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7196); }
    }

    /// <summary>
    /// FloatProperty: KillKeepyUpFactor
    /// </summary>
    public unsafe float KillKeepyUpFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7200); }
    }

    /// <summary>
    /// FloatProperty: KillKeepyUpFactorDuration
    /// </summary>
    public unsafe float KillKeepyUpFactorDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7204); }
    }

    /// <summary>
    /// StructProperty: ImpactShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 7208);

    /// <summary>
    /// FloatProperty: ImpactShakeForceFactor
    /// </summary>
    public unsafe float ImpactShakeForceFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7364); }
    }

    /// <summary>
    /// FloatProperty: ImpactShakeVehicleFactor
    /// </summary>
    public unsafe float ImpactShakeVehicleFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7368); }
    }

    /// <summary>
    /// FloatProperty: ImpactShakeAbandonedVehicleFactor
    /// </summary>
    public unsafe float ImpactShakeAbandonedVehicleFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7372); }
    }

    /// <summary>
    /// FloatProperty: ImpactShakeDestructiblesFactor
    /// </summary>
    public unsafe float ImpactShakeDestructiblesFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7376); }
    }

    /// <summary>
    /// FloatProperty: ImpactShakeCoolDown
    /// </summary>
    public unsafe float ImpactShakeCoolDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7380); }
    }

    /// <summary>
    /// FloatProperty: CameraImpactEffectFactorFwd
    /// </summary>
    public unsafe float CameraImpactEffectFactorFwd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7384); }
    }

    /// <summary>
    /// FloatProperty: CameraImpactEffectFactorSide
    /// </summary>
    public unsafe float CameraImpactEffectFactorSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7388); }
    }

    /// <summary>
    /// FloatProperty: VehicleImpactEffectFactorFwd
    /// </summary>
    public unsafe float VehicleImpactEffectFactorFwd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7392); }
    }

    /// <summary>
    /// FloatProperty: VehicleImpactEffectFactorSide
    /// </summary>
    public unsafe float VehicleImpactEffectFactorSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7396); }
    }

    /// <summary>
    /// FloatProperty: VehicleImpactForceFactorFwd
    /// </summary>
    public unsafe float VehicleImpactForceFactorFwd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7400); }
    }

    /// <summary>
    /// FloatProperty: VehicleImpactForceFalloff
    /// </summary>
    public unsafe float VehicleImpactForceFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7404); }
    }

    /// <summary>
    /// FloatProperty: VehicleImpactForceMax
    /// </summary>
    public unsafe float VehicleImpactForceMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7408); }
    }

    /// <summary>
    /// FloatProperty: CurrentImpactEffectForce
    /// </summary>
    public unsafe float CurrentImpactEffectForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7412); }
    }

    /// <summary>
    /// FloatProperty: VehicleShovingTorque
    /// </summary>
    public unsafe float VehicleShovingTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7416); }
    }

    /// <summary>
    /// StructProperty: QueuedImpactEffect
    /// </summary>
    public unsafe ref System.Numerics.Vector3 QueuedImpactEffect
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7420);

    /// <summary>
    /// ArrayProperty: DeathExplosionSoundArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkEvent> DeathExplosionSoundArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkEvent>>(Ptr + 7432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7432); }
    }

    /// <summary>
    /// FloatProperty: BatmobileStuckTime
    /// </summary>
    public unsafe float BatmobileStuckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7448); }
    }

    /// <summary>
    /// FloatProperty: BatmobileStuckTimeMax
    /// </summary>
    public unsafe float BatmobileStuckTimeMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7452); }
    }

    /// <summary>
    /// FloatProperty: BatmobileStuckTimeFlip
    /// </summary>
    public unsafe float BatmobileStuckTimeFlip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7456); }
    }

    /// <summary>
    /// IntProperty: NumFlipTries
    /// </summary>
    public unsafe int NumFlipTries
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7460); }
    }

    /// <summary>
    /// FloatProperty: LastDeltaTime
    /// </summary>
    public unsafe float LastDeltaTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7464); }
    }

    /// <summary>
    /// StructProperty: OldVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 OldVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7468);

    /// <summary>
    /// StructProperty: StoredAccel
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StoredAccel
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7480);

    /// <summary>
    /// FloatProperty: CheatIgnoreCollisionWidth
    /// </summary>
    public unsafe float CheatIgnoreCollisionWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7492); }
    }

    /// <summary>
    /// FloatProperty: CheatIgnoreCollisionMinSpeedFactor
    /// </summary>
    public unsafe float CheatIgnoreCollisionMinSpeedFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7496); }
    }

    /// <summary>
    /// FloatProperty: FakeDestructibleEffectTimer
    /// </summary>
    public unsafe float FakeDestructibleEffectTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7500); }
    }

    /// <summary>
    /// StructProperty: FakeDestructibleEffectLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FakeDestructibleEffectLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7504);

    /// <summary>
    /// StructProperty: FakeDestructibleEffectNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FakeDestructibleEffectNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7516);

    /// <summary>
    /// InlineArray{StructProperty}: Passengers
    /// </summary>
    public InlineArray<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassenger> Passengers => new(4, Ptr + 7528, 60, this);

    /// <summary>
    /// StructProperty: Passengers
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassenger Passengers_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassenger>(Ptr + 7528);
    /// <summary>
    /// StructProperty: Passengers
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassenger Passengers_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassenger>(Ptr + 7588);
    /// <summary>
    /// StructProperty: Passengers
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassenger Passengers_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassenger>(Ptr + 7648);
    /// <summary>
    /// StructProperty: Passengers
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassenger Passengers_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassenger>(Ptr + 7708);

    /// <summary>
    /// ArrayProperty: BatmobileViewNonPassengers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> BatmobileViewNonPassengers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 7768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7768); }
    }

    /// <summary>
    /// ArrayProperty: PassengerNoise
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassengerNoise> PassengerNoise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassengerNoise>>(Ptr + 7784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7784); }
    }

    /// <summary>
    /// FloatProperty: PassengerNoiseDelay
    /// </summary>
    public unsafe float PassengerNoiseDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7800); }
    }

    /// <summary>
    /// IntProperty: PassengerNoiseIndex
    /// </summary>
    public unsafe int PassengerNoiseIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7804); }
    }

    /// <summary>
    /// FloatProperty: fRumbleMinimumThreshold
    /// </summary>
    public unsafe float fRumbleMinimumThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7808); }
    }

    /// <summary>
    /// FloatProperty: fRumbleWallImpactScaleMultiplier
    /// </summary>
    public unsafe float fRumbleWallImpactScaleMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7812); }
    }

    /// <summary>
    /// FloatProperty: fRumblePhysicsObjectScaleMultiplier
    /// </summary>
    public unsafe float fRumblePhysicsObjectScaleMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7816); }
    }

    /// <summary>
    /// FloatProperty: fRumblePhysicsObjectMaxValue
    /// </summary>
    public unsafe float fRumblePhysicsObjectMaxValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7820); }
    }

    /// <summary>
    /// FloatProperty: fRumbleAbandonedVehicleScaleMultiplier
    /// </summary>
    public unsafe float fRumbleAbandonedVehicleScaleMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7824); }
    }

    /// <summary>
    /// FloatProperty: fRumbleJumpLandingScaleMultiplier
    /// </summary>
    public unsafe float fRumbleJumpLandingScaleMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7828); }
    }

    /// <summary>
    /// StructProperty: LowerChassisCollision
    /// </summary>
    public unsafe System.IntPtr LowerChassisCollision
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 7832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7832); }
    }

    /// <summary>
    /// StructProperty: TurbulenceChassisCollision
    /// </summary>
    public unsafe System.IntPtr TurbulenceChassisCollision
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 7840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7840); }
    }

    /// <summary>
    /// IntProperty: InitialNumShapes
    /// </summary>
    public unsafe int InitialNumShapes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7848); }
    }

    /// <summary>
    /// FloatProperty: LastBattleModeControlledTime
    /// </summary>
    public unsafe float LastBattleModeControlledTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7852); }
    }

    /// <summary>
    /// FloatProperty: EmergencyStopDist
    /// </summary>
    public unsafe float EmergencyStopDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7856); }
    }

    /// <summary>
    /// FloatProperty: BattleModeSpeedDelta
    /// </summary>
    public unsafe float BattleModeSpeedDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7860); }
    }

    /// <summary>
    /// FloatProperty: CrushThreshold
    /// </summary>
    public unsafe float CrushThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7864); }
    }

    /// <summary>
    /// StructProperty: CrushTotal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CrushTotal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7868);

    /// <summary>
    /// StructProperty: CrushAbsTotal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CrushAbsTotal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7880);

    /// <summary>
    /// StructProperty: BounceOrigin
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BounceOrigin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7892);

    /// <summary>
    /// FloatProperty: AirborneTime
    /// </summary>
    public unsafe float AirborneTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7904); }
    }

    /// <summary>
    /// FloatProperty: lastDamagedByCheckPointMineTime
    /// </summary>
    public unsafe float lastDamagedByCheckPointMineTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7908); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorPower
    /// </summary>
    public unsafe float WeaponGeneratorPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7912); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorPowerTickUp
    /// </summary>
    public unsafe float WeaponGeneratorPowerTickUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7916); }
    }

    /// <summary>
    /// ArrayProperty: MaxWeaponGeneratorPower
    /// </summary>
    public unsafe BmSDK.TArray<float> MaxWeaponGeneratorPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 7920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7920); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorKillBonus
    /// </summary>
    public unsafe float WeaponGeneratorKillBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7936); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorHeavyTankKillBonus
    /// </summary>
    public unsafe float WeaponGeneratorHeavyTankKillBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7940); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorThugKillBonus
    /// </summary>
    public unsafe float WeaponGeneratorThugKillBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7944); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorHeadShotBonus
    /// </summary>
    public unsafe float WeaponGeneratorHeadShotBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7948); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorArmourShotBonus
    /// </summary>
    public unsafe float WeaponGeneratorArmourShotBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7952); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorMissileBonus
    /// </summary>
    public unsafe float WeaponGeneratorMissileBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7956); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorDodgeBonus
    /// </summary>
    public unsafe float WeaponGeneratorDodgeBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7960); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorBonusMultiplier
    /// </summary>
    public unsafe float WeaponGeneratorBonusMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7964); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorDrain
    /// </summary>
    public unsafe float WeaponGeneratorDrain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7968); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorDefaultPower
    /// </summary>
    public unsafe float WeaponGeneratorDefaultPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7972); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorShielding
    /// </summary>
    public unsafe float WeaponGeneratorShielding
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7976); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorScarecrowBonus
    /// </summary>
    public unsafe float WeaponGeneratorScarecrowBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7980); }
    }

    /// <summary>
    /// IntProperty: CriticalCounter
    /// </summary>
    public unsafe int CriticalCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7984); }
    }

    /// <summary>
    /// IntProperty: PerfectCriticalCounter
    /// </summary>
    public unsafe int PerfectCriticalCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7988); }
    }

    /// <summary>
    /// FloatProperty: CurrentSteaminess
    /// </summary>
    public unsafe float CurrentSteaminess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7992); }
    }

    /// <summary>
    /// FloatProperty: HeatSteamFallOffTime
    /// </summary>
    public unsafe float HeatSteamFallOffTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7996); }
    }

    /// <summary>
    /// FloatProperty: HeatSteamBuildUpTime
    /// </summary>
    public unsafe float HeatSteamBuildUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8000); }
    }

    /// <summary>
    /// FloatProperty: HowMuchTheRainAffectsHeatSteam
    /// </summary>
    public unsafe float HowMuchTheRainAffectsHeatSteam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8004); }
    }

    /// <summary>
    /// StructProperty: DriftAngularVelocityBySteer
    /// </summary>
    public unsafe ref BmSDK.GameObject.FInterpCurveFloat DriftAngularVelocityBySteer
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 8008);

    /// <summary>
    /// StructProperty: DriftSpeedBySteer
    /// </summary>
    public unsafe ref BmSDK.GameObject.FInterpCurveFloat DriftSpeedBySteer
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 8028);

    /// <summary>
    /// FloatProperty: DriftAngularVelocityFactor
    /// </summary>
    public unsafe float DriftAngularVelocityFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8048); }
    }

    /// <summary>
    /// FloatProperty: DriftAngularVelocityFactorMax
    /// </summary>
    public unsafe float DriftAngularVelocityFactorMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8052); }
    }

    /// <summary>
    /// FloatProperty: DriftVelocityFactor
    /// </summary>
    public unsafe float DriftVelocityFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8056); }
    }

    /// <summary>
    /// FloatProperty: DriftVelocityFactorMax
    /// </summary>
    public unsafe float DriftVelocityFactorMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8060); }
    }

    /// <summary>
    /// StructProperty: DriftVelocityForcePosOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DriftVelocityForcePosOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 8064);

    /// <summary>
    /// FloatProperty: DriftCorrectionSteerSpeed
    /// </summary>
    public unsafe float DriftCorrectionSteerSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8076); }
    }

    /// <summary>
    /// FloatProperty: DriftWobbleFrequencyMax
    /// </summary>
    public unsafe float DriftWobbleFrequencyMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8080); }
    }

    /// <summary>
    /// FloatProperty: DriftWobblePeriodMaxSpeed
    /// </summary>
    public unsafe float DriftWobblePeriodMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8084); }
    }

    /// <summary>
    /// FloatProperty: DriftWobbleStrengthMax
    /// </summary>
    public unsafe float DriftWobbleStrengthMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8088); }
    }

    /// <summary>
    /// FloatProperty: CurrentDriftWobbleTimer
    /// </summary>
    public unsafe float CurrentDriftWobbleTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8092); }
    }

    /// <summary>
    /// FloatProperty: LastDriftDir
    /// </summary>
    public unsafe float LastDriftDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8096); }
    }

    /// <summary>
    /// FloatProperty: CurrentDriftSteer
    /// </summary>
    public unsafe float CurrentDriftSteer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8100); }
    }

    /// <summary>
    /// IntProperty: CurrentArmourLevel
    /// </summary>
    public unsafe int CurrentArmourLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8104); }
    }

    /// <summary>
    /// ArrayProperty: ArmourLevels
    /// </summary>
    public unsafe BmSDK.TArray<int> ArmourLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 8108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8108); }
    }

    /// <summary>
    /// IntProperty: LowHealthWarningLevel
    /// </summary>
    public unsafe int LowHealthWarningLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8124); }
    }

    /// <summary>
    /// FloatProperty: BatmobileOnFireDamageRadiusScale
    /// </summary>
    public unsafe float BatmobileOnFireDamageRadiusScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8128); }
    }

    /// <summary>
    /// FloatProperty: BatmobileOnFireRadiusDecayDelay
    /// </summary>
    public unsafe float BatmobileOnFireRadiusDecayDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8132); }
    }

    /// <summary>
    /// FloatProperty: BatmobileOnFireRadiusDecayRate
    /// </summary>
    public unsafe float BatmobileOnFireRadiusDecayRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8136); }
    }

    /// <summary>
    /// ArrayProperty: BatmobileOnFire
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobileOnFireInfo> BatmobileOnFire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobileOnFireInfo>>(Ptr + 8140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8140); }
    }

    /// <summary>
    /// FloatProperty: PMDodgeTorque
    /// </summary>
    public unsafe float PMDodgeTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8156); }
    }

    /// <summary>
    /// FloatProperty: PMDodgeForce
    /// </summary>
    public unsafe float PMDodgeForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8160); }
    }

    /// <summary>
    /// FloatProperty: PMDodgeDuration
    /// </summary>
    public unsafe float PMDodgeDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8164); }
    }

    /// <summary>
    /// ArrayProperty: PreviousAllComponentsList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PreviousAllComponentsList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 8168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8168); }
    }

    /// <summary>
    /// ArrayProperty: WeaponGeneratorMeshPackage
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> WeaponGeneratorMeshPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 8184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8184); }
    }

    /// <summary>
    /// ArrayProperty: WeaponGeneratorMesh
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh> WeaponGeneratorMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh>>(Ptr + 8200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8200); }
    }

    /// <summary>
    /// IntProperty: CurrentDisplayedWeaponGenerator
    /// </summary>
    public unsafe int CurrentDisplayedWeaponGenerator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8216); }
    }

    /// <summary>
    /// ArrayProperty: HealthRecoverRate
    /// </summary>
    public unsafe BmSDK.TArray<float> HealthRecoverRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 8220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8220); }
    }

    /// <summary>
    /// StructProperty: JumpStartLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 JumpStartLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 8236);

    /// <summary>
    /// ArrayProperty: Guarders
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat> Guarders
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(Ptr + 8248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8248); }
    }

    /// <summary>
    /// IntProperty: NumGuardPoints
    /// </summary>
    public unsafe int NumGuardPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8264); }
    }

    /// <summary>
    /// StructProperty: BatmobileSafePointLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatmobileSafePointLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 8268);

    /// <summary>
    /// StructProperty: BatmobileSafePointRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator BatmobileSafePointRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 8280);

    /// <summary>
    /// StrProperty: BatmobileSafePointLevel
    /// </summary>
    public unsafe BmSDK.FString BatmobileSafePointLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8292); }
    }

    /// <summary>
    /// ArrayProperty: BatmobileSafePointStreamingLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> BatmobileSafePointStreamingLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 8308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8308); }
    }

    /// <summary>
    /// ArrayProperty: BatmobileSafePointStreamingLevelsLODs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> BatmobileSafePointStreamingLevelsLODs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 8324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8324); }
    }

    /// <summary>
    /// FloatProperty: ScalarToReduceDestructibleParticlesAtHighSpeed
    /// </summary>
    public unsafe float ScalarToReduceDestructibleParticlesAtHighSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8340); }
    }

    /// <summary>
    /// IntProperty: HideDriverPitch
    /// </summary>
    public unsafe int HideDriverPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8344); }
    }

    /// <summary>
    /// IntProperty: HideDriverYaw
    /// </summary>
    public unsafe int HideDriverYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8348); }
    }
}
