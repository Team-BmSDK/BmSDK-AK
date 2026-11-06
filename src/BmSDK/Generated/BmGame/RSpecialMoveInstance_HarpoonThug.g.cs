#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveInstance_HarpoonThug<br/>
/// (size = 948)
/// (flags = 144703634)
/// </summary>
public partial class RSpecialMoveInstance_HarpoonThug : BmSDK.BmGame.RSpecialMoveInstance_HarpoonBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveInstance_HarpoonThug", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMoveInstance_HarpoonThug.
    /// </summary>
    public static RSpecialMoveInstance_HarpoonThug DefaultObject => (RSpecialMoveInstance_HarpoonThug)StaticClass().DefaultObject;

    internal RSpecialMoveInstance_HarpoonThug() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_HarpoonThug
    /// </summary>
    public RSpecialMoveInstance_HarpoonThug(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_HarpoonThug(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HarpoonThug>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HarpoonThug>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HarpoonThug>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HarpoonThug>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HarpoonThug>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HarpoonThug>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HarpoonThug>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HarpoonThug>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_StopHarpoonAim;
    /// <summary>
    /// Function: StopHarpoonAim
    /// </summary>
    public unsafe virtual void StopHarpoonAim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopHarpoonAim, "BmGame.RSpecialMoveInstance_HarpoonThug.StopHarpoonAim");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRopeRetractTime;
    /// <summary>
    /// Function: GetRopeRetractTime
    /// </summary>
    public unsafe override float GetRopeRetractTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRopeRetractTime, "BmGame.RSpecialMoveInstance_HarpoonThug.GetRopeRetractTime");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Tug;
    /// <summary>
    /// Function: Tug
    /// </summary>
    public unsafe virtual void Tug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tug, "BmGame.RSpecialMoveInstance_HarpoonThug.Tug");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_YankThug;
    /// <summary>
    /// Function: YankThug
    /// </summary>
    public unsafe virtual void YankThug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_YankThug, "BmGame.RSpecialMoveInstance_HarpoonThug.YankThug");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LeftHandOn;
    /// <summary>
    /// Function: LeftHandOn
    /// </summary>
    public unsafe override void LeftHandOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LeftHandOn, "BmGame.RSpecialMoveInstance_HarpoonThug.LeftHandOn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RightHandOn;
    /// <summary>
    /// Function: RightHandOn
    /// </summary>
    public unsafe override void RightHandOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RightHandOn, "BmGame.RSpecialMoveInstance_HarpoonThug.RightHandOn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseClaws;
    /// <summary>
    /// Function: ReleaseClaws
    /// </summary>
    public unsafe override void ReleaseClaws()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseClaws, "BmGame.RSpecialMoveInstance_HarpoonThug.ReleaseClaws");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanDoCombat;
    /// <summary>
    /// Function: CanDoCombat
    /// </summary>
    public unsafe override bool CanDoCombat(bool CheckForEvade = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoCombat, "BmGame.RSpecialMoveInstance_HarpoonThug.CanDoCombat");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckForEvade, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DissipateChargeEnd;
    /// <summary>
    /// Function: DissipateChargeEnd
    /// </summary>
    public unsafe virtual void DissipateChargeEnd()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DissipateChargeEnd, "BmGame.RSpecialMoveInstance_HarpoonThug.DissipateChargeEnd");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DissipateCharge;
    /// <summary>
    /// Function: DissipateCharge
    /// </summary>
    public unsafe virtual void DissipateCharge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DissipateCharge, "BmGame.RSpecialMoveInstance_HarpoonThug.DissipateCharge");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProjectileHit;
    /// <summary>
    /// Function: ProjectileHit
    /// </summary>
    public unsafe override void ProjectileHit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProjectileHit, "BmGame.RSpecialMoveInstance_HarpoonThug.ProjectileHit");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelSpecialMove;
    /// <summary>
    /// Function: CancelSpecialMove
    /// </summary>
    public unsafe override void CancelSpecialMove(BmSDK.BmGame.RSpecialMoveConfig NextSpecialMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelSpecialMove, "BmGame.RSpecialMoveInstance_HarpoonThug.CancelSpecialMove");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextSpecialMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishSpecialMove;
    /// <summary>
    /// Function: FinishSpecialMove
    /// </summary>
    public unsafe override void FinishSpecialMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishSpecialMove, "BmGame.RSpecialMoveInstance_HarpoonThug.FinishSpecialMove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireBatclaw;
    /// <summary>
    /// Function: FireBatclaw
    /// </summary>
    public unsafe virtual void FireBatclaw()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireBatclaw, "BmGame.RSpecialMoveInstance_HarpoonThug.FireBatclaw");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateSpecialMove;
    /// <summary>
    /// Function: UpdateSpecialMove
    /// </summary>
    public unsafe override bool UpdateSpecialMove(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSpecialMove, "BmGame.RSpecialMoveInstance_HarpoonThug.UpdateSpecialMove");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetHarpoonTarget;
    /// <summary>
    /// Function: GetHarpoonTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain GetHarpoonTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHarpoonTarget, "BmGame.RSpecialMoveInstance_HarpoonThug.GetHarpoonTarget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHitVillainHitReaction;
    /// <summary>
    /// Function: GetHitVillainHitReaction
    /// </summary>
    public unsafe virtual BmSDK.FName GetHitVillainHitReaction(BmSDK.Engine.AnimSet HitReactionAnimSet, bool bDisarmsThug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitVillainHitReaction, "BmGame.RSpecialMoveInstance_HarpoonThug.GetHitVillainHitReaction");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitReactionAnimSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDisarmsThug, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_OverrideStumbleHeading;
    /// <summary>
    /// Function: OverrideStumbleHeading
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 OverrideStumbleHeading(BmSDK.BmGame.RPawnVillain Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideStumbleHeading, "BmGame.RSpecialMoveInstance_HarpoonThug.OverrideStumbleHeading");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DoHarpoonDamage;
    /// <summary>
    /// Function: DoHarpoonDamage
    /// </summary>
    public unsafe virtual void DoHarpoonDamage(BmSDK.BmGame.RPawnVillain Target, bool DelayedFrozenDmg)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoHarpoonDamage, "BmGame.RSpecialMoveInstance_HarpoonThug.DoHarpoonDamage");
        byte* paramsPtr = stackalloc byte[284];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DelayedFrozenDmg, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHarpoonAnim;
    /// <summary>
    /// Function: PlayHarpoonAnim
    /// </summary>
    public unsafe virtual void PlayHarpoonAnim(BmSDK.FName AnimName, bool bMirrored, bool bCanAim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHarpoonAnim, "BmGame.RSpecialMoveInstance_HarpoonThug.PlayHarpoonAnim");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanAim, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DelayHarpoonDamage;
    /// <summary>
    /// Function: DelayHarpoonDamage
    /// </summary>
    public unsafe virtual bool DelayHarpoonDamage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DelayHarpoonDamage, "BmGame.RSpecialMoveInstance_HarpoonThug.DelayHarpoonDamage");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerSpecialMove;
    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe override void TriggerSpecialMove(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSpecialMove, "BmGame.RSpecialMoveInstance_HarpoonThug.TriggerSpecialMove");
        byte* paramsPtr = stackalloc byte[188];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: FireTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId FireTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 916);

    /// <summary>
    /// BoolProperty: bDisarm
    /// </summary>
    public unsafe bool bDisarm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bFrozenTarget
    /// </summary>
    public unsafe bool bFrozenTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bTargetWasChargedUp
    /// </summary>
    public unsafe bool bTargetWasChargedUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bClearComboOnCancel
    /// </summary>
    public unsafe bool bClearComboOnCancel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// StructProperty: ReleaseClawImpulse
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ReleaseClawImpulse
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 924);

    /// <summary>
    /// IntProperty: bTugNextFrame
    /// </summary>
    public unsafe int bTugNextFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// ObjectProperty: ChargeEmitter
    /// </summary>
    public unsafe BmSDK.Engine.Emitter ChargeEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }
}
