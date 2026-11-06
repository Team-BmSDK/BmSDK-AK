#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RCombatMove_BatmanStrike<br/>
/// (size = 1564)
/// (flags = 144703635)
/// </summary>
public partial class RCombatMove_BatmanStrike : BmSDK.BmGame.RCombatMove_BatmanWeaponAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatMove_BatmanStrike", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCombatMove_BatmanStrike.
    /// </summary>
    public static RCombatMove_BatmanStrike DefaultObject => (RCombatMove_BatmanStrike)StaticClass().DefaultObject;

    internal RCombatMove_BatmanStrike() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_BatmanStrike(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CanBeOverridenByQuickGadget;
    /// <summary>
    /// Function: CanBeOverridenByQuickGadget
    /// </summary>
    public unsafe override bool CanBeOverridenByQuickGadget(BmSDK.BmGame.RPawnPlayer.EQuickGadgetType QGType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeOverridenByQuickGadget, "BmGame.RCombatMove_BatmanStrike.CanBeOverridenByQuickGadget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QGType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OverrideSpeedUp;
    /// <summary>
    /// Function: OverrideSpeedUp
    /// </summary>
    public unsafe virtual void OverrideSpeedUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideSpeedUp, "BmGame.RCombatMove_BatmanStrike.OverrideSpeedUp");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanForceSlowStrike;
    /// <summary>
    /// Function: CanForceSlowStrike
    /// </summary>
    public unsafe virtual bool CanForceSlowStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanForceSlowStrike, "BmGame.RCombatMove_BatmanStrike.CanForceSlowStrike");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformFloorStrike;
    /// <summary>
    /// Function: CanPerformFloorStrike
    /// </summary>
    public unsafe override bool CanPerformFloorStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformFloorStrike, "BmGame.RCombatMove_BatmanStrike.CanPerformFloorStrike");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformWeaponDestroy;
    /// <summary>
    /// Function: CanPerformWeaponDestroy
    /// </summary>
    public unsafe override bool CanPerformWeaponDestroy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformWeaponDestroy, "BmGame.RCombatMove_BatmanStrike.CanPerformWeaponDestroy");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformPrimaryGroupMove;
    /// <summary>
    /// Function: CanPerformPrimaryGroupMove
    /// </summary>
    public unsafe override bool CanPerformPrimaryGroupMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformPrimaryGroupMove, "BmGame.RCombatMove_BatmanStrike.CanPerformPrimaryGroupMove");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformWeaponSnatchWithRun;
    /// <summary>
    /// Function: CanPerformWeaponSnatchWithRun
    /// </summary>
    public unsafe override bool CanPerformWeaponSnatchWithRun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformWeaponSnatchWithRun, "BmGame.RCombatMove_BatmanStrike.CanPerformWeaponSnatchWithRun");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformTakedownWithStun;
    /// <summary>
    /// Function: CanPerformTakedownWithStun
    /// </summary>
    public unsafe override bool CanPerformTakedownWithStun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformTakedownWithStun, "BmGame.RCombatMove_BatmanStrike.CanPerformTakedownWithStun");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformTakedownWithCounter;
    /// <summary>
    /// Function: CanPerformTakedownWithCounter
    /// </summary>
    public unsafe override bool CanPerformTakedownWithCounter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformTakedownWithCounter, "BmGame.RCombatMove_BatmanStrike.CanPerformTakedownWithCounter");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformThrow;
    /// <summary>
    /// Function: CanPerformThrow
    /// </summary>
    public unsafe override bool CanPerformThrow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformThrow, "BmGame.RCombatMove_BatmanStrike.CanPerformThrow");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ExitMove;
    /// <summary>
    /// Function: ExitMove
    /// </summary>
    public unsafe override void ExitMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMove, "BmGame.RCombatMove_BatmanStrike.ExitMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPerformFloorPickupThug;
    /// <summary>
    /// Function: CanPerformFloorPickupThug
    /// </summary>
    public unsafe override bool CanPerformFloorPickupThug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformFloorPickupThug, "BmGame.RCombatMove_BatmanStrike.CanPerformFloorPickupThug");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHitReactionLocation;
    /// <summary>
    /// Function: GetHitReactionLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetHitReactionLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitReactionLocation, "BmGame.RCombatMove_BatmanStrike.GetHitReactionLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHitReactionDirection;
    /// <summary>
    /// Function: GetHitReactionDirection
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetHitReactionDirection(BmSDK.BmGame.RPawnVillain HitPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitReactionDirection, "BmGame.RCombatMove_BatmanStrike.GetHitReactionDirection");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanStartFinishedCombatMove;
    /// <summary>
    /// Function: CanStartFinishedCombatMove
    /// </summary>
    public unsafe override bool CanStartFinishedCombatMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanStartFinishedCombatMove, "BmGame.RCombatMove_BatmanStrike.CanStartFinishedCombatMove");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayedJumpOffWall;
    /// <summary>
    /// Function: PlayedJumpOffWall
    /// </summary>
    public unsafe virtual void PlayedJumpOffWall(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId NewId, float TimeLeftOver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayedJumpOffWall, "BmGame.RCombatMove_BatmanStrike.PlayedJumpOffWall");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldTrackTargetThisFrame;
    /// <summary>
    /// Function: ShouldTrackTargetThisFrame
    /// </summary>
    public unsafe virtual bool ShouldTrackTargetThisFrame()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldTrackTargetThisFrame, "BmGame.RCombatMove_BatmanStrike.ShouldTrackTargetThisFrame");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FreeflowFocusTurnedOff;
    /// <summary>
    /// Function: FreeflowFocusTurnedOff
    /// </summary>
    public unsafe override void FreeflowFocusTurnedOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FreeflowFocusTurnedOff, "BmGame.RCombatMove_BatmanStrike.FreeflowFocusTurnedOff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayStrike;
    /// <summary>
    /// Function: PlayStrike
    /// </summary>
    public unsafe virtual void PlayStrike(bool bQueue, bool bSimulated)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayStrike, "BmGame.RCombatMove_BatmanStrike.PlayStrike");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bQueue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSimulated, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayedQueuedStrikeAnimSimulated;
    /// <summary>
    /// Function: PlayedQueuedStrikeAnimSimulated
    /// </summary>
    public unsafe virtual void PlayedQueuedStrikeAnimSimulated(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId QueuedAnimID, float TimeLeftOver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayedQueuedStrikeAnimSimulated, "BmGame.RCombatMove_BatmanStrike.PlayedQueuedStrikeAnimSimulated");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueuedAnimID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayedQueuedStrikeAnim;
    /// <summary>
    /// Function: PlayedQueuedStrikeAnim
    /// </summary>
    public unsafe virtual void PlayedQueuedStrikeAnim(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId QueuedAnimID, float TimeLeftOver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayedQueuedStrikeAnim, "BmGame.RCombatMove_BatmanStrike.PlayedQueuedStrikeAnim");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueuedAnimID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStrikeStartTime;
    /// <summary>
    /// Function: GetStrikeStartTime
    /// </summary>
    public unsafe virtual float GetStrikeStartTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeStartTime, "BmGame.RCombatMove_BatmanStrike.GetStrikeStartTime");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeAnimSet;
    /// <summary>
    /// Function: GetStrikeAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetStrikeAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeAnimSet, "BmGame.RCombatMove_BatmanStrike.GetStrikeAnimSet");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeDurationScale;
    /// <summary>
    /// Function: GetStrikeDurationScale
    /// </summary>
    public unsafe virtual float GetStrikeDurationScale()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeDurationScale, "BmGame.RCombatMove_BatmanStrike.GetStrikeDurationScale");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeBoneLocation;
    /// <summary>
    /// Function: GetStrikeBoneLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetStrikeBoneLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeBoneLocation, "BmGame.RCombatMove_BatmanStrike.GetStrikeBoneLocation");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeTargetLocation;
    /// <summary>
    /// Function: GetStrikeTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetStrikeTargetLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeTargetLocation, "BmGame.RCombatMove_BatmanStrike.GetStrikeTargetLocation");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopCapeAnim;
    /// <summary>
    /// Function: StopCapeAnim
    /// </summary>
    public unsafe virtual void StopCapeAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopCapeAnim, "BmGame.RCombatMove_BatmanStrike.StopCapeAnim");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCapeAnim;
    /// <summary>
    /// Function: PlayCapeAnim
    /// </summary>
    public unsafe virtual void PlayCapeAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCapeAnim, "BmGame.RCombatMove_BatmanStrike.PlayCapeAnim");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTrailPS;
    /// <summary>
    /// Function: GetTrailPS
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetTrailPS()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTrailPS, "BmGame.RCombatMove_BatmanStrike.GetTrailPS");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopTrail;
    /// <summary>
    /// Function: StopTrail
    /// </summary>
    public unsafe virtual void StopTrail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopTrail, "BmGame.RCombatMove_BatmanStrike.StopTrail");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartTrail;
    /// <summary>
    /// Function: StartTrail
    /// </summary>
    public unsafe virtual void StartTrail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartTrail, "BmGame.RCombatMove_BatmanStrike.StartTrail");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayBlockedFX;
    /// <summary>
    /// Function: PlayBlockedFX
    /// </summary>
    public unsafe virtual void PlayBlockedFX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBlockedFX, "BmGame.RCombatMove_BatmanStrike.PlayBlockedFX");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHitFX;
    /// <summary>
    /// Function: PlayHitFX
    /// </summary>
    public unsafe virtual void PlayHitFX(float FXScale)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHitFX, "BmGame.RCombatMove_BatmanStrike.PlayHitFX");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FXScale, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetImpactPS;
    /// <summary>
    /// Function: GetImpactPS
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetImpactPS(BmSDK.BmGame.RPawnCombat.DamageResult DmgResult, BmSDK.BmGame.RPawnCombat HitPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetImpactPS, "BmGame.RCombatMove_BatmanStrike.GetImpactPS");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgResult, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ProcessDamageResult;
    /// <summary>
    /// Function: ProcessDamageResult
    /// </summary>
    public unsafe virtual void ProcessDamageResult(BmSDK.BmGame.RPawnCombat.DamageResult DmgResult, BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessDamageResult, "BmGame.RCombatMove_BatmanStrike.ProcessDamageResult");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgResult, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyDamage;
    /// <summary>
    /// Function: ApplyDamage
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.DamageResult ApplyDamage(BmSDK.BmGame.RPawnCombat TargetPawn, System.Numerics.Vector3 DamageDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyDamage, "BmGame.RCombatMove_BatmanStrike.ApplyDamage");
        byte* paramsPtr = stackalloc byte[21];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageDir, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_DoHitPawnSimulated;
    /// <summary>
    /// Function: DoHitPawnSimulated
    /// </summary>
    public unsafe virtual void DoHitPawnSimulated(BmSDK.BmGame.RPawnCombat DamageReceiver, float DmgAmount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoHitPawnSimulated, "BmGame.RCombatMove_BatmanStrike.DoHitPawnSimulated");
        byte* paramsPtr = stackalloc byte[284];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoHitPawn;
    /// <summary>
    /// Function: DoHitPawn
    /// </summary>
    public unsafe virtual void DoHitPawn(BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoHitPawn, "BmGame.RCombatMove_BatmanStrike.DoHitPawn");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerStrikeAttempted;
    /// <summary>
    /// Function: TriggerStrikeAttempted
    /// </summary>
    public unsafe override void TriggerStrikeAttempted(bool bStun = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerStrikeAttempted, "BmGame.RCombatMove_BatmanStrike.TriggerStrikeAttempted");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStun, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayImpactSound;
    /// <summary>
    /// Function: PlayImpactSound
    /// </summary>
    public unsafe virtual void PlayImpactSound(BmSDK.BmGame.RPawnCombat DamageReceiver, BmSDK.BmGame.RPawnCombat.DamageResult DmgResult)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayImpactSound, "BmGame.RCombatMove_BatmanStrike.PlayImpactSound");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgResult, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFirstHitSound;
    /// <summary>
    /// Function: PlayFirstHitSound
    /// </summary>
    public unsafe virtual void PlayFirstHitSound(BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFirstHitSound, "BmGame.RCombatMove_BatmanStrike.PlayFirstHitSound");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamagePawn;
    /// <summary>
    /// Function: DamagePawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.DamageResult DamagePawn(BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagePawn, "BmGame.RCombatMove_BatmanStrike.DamagePawn");
        byte* paramsPtr = stackalloc byte[272];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetDamageInfo;
    /// <summary>
    /// Function: SetDamageInfo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.FDamageInfo SetDamageInfo(BmSDK.BmGame.RPawnCombat DamageReceiver, float DmgAmount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDamageInfo, "BmGame.RCombatMove_BatmanStrike.SetDamageInfo");
        byte* paramsPtr = stackalloc byte[508];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.FDamageInfo>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ShouldIncCombo;
    /// <summary>
    /// Function: ShouldIncCombo
    /// </summary>
    public unsafe virtual bool ShouldIncCombo(out int ComboIncrease, out int SpecialMoveCountIncrease)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldIncCombo, "BmGame.RCombatMove_BatmanStrike.ShouldIncCombo");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ComboIncrease = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        SpecialMoveCountIncrease = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetComboIncrease;
    /// <summary>
    /// Function: GetComboIncrease
    /// </summary>
    public unsafe virtual void GetComboIncrease(out int ComboIncrease, out int SpecialMoveCountIncrease)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboIncrease, "BmGame.RCombatMove_BatmanStrike.GetComboIncrease");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ComboIncrease = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        SpecialMoveCountIncrease = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_NotifyDeathCutsceneOfStrike;
    /// <summary>
    /// Function: NotifyDeathCutsceneOfStrike
    /// </summary>
    public unsafe virtual void NotifyDeathCutsceneOfStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyDeathCutsceneOfStrike, "BmGame.RCombatMove_BatmanStrike.NotifyDeathCutsceneOfStrike");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDamageAmount;
    /// <summary>
    /// Function: GetDamageAmount
    /// </summary>
    public unsafe virtual float GetDamageAmount(BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageAmount, "BmGame.RCombatMove_BatmanStrike.GetDamageAmount");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UpdateTargetAnimForFinalBlow;
    /// <summary>
    /// Function: UpdateTargetAnimForFinalBlow
    /// </summary>
    public unsafe virtual void UpdateTargetAnimForFinalBlow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTargetAnimForFinalBlow, "BmGame.RCombatMove_BatmanStrike.UpdateTargetAnimForFinalBlow");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFOVModifier;
    /// <summary>
    /// Function: GetFOVModifier
    /// </summary>
    public unsafe override float GetFOVModifier()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFOVModifier, "BmGame.RCombatMove_BatmanStrike.GetFOVModifier");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateSlowMo;
    /// <summary>
    /// Function: UpdateSlowMo
    /// </summary>
    public unsafe virtual void UpdateSlowMo(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSlowMo, "BmGame.RCombatMove_BatmanStrike.UpdateSlowMo");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStartFinalBlowTime;
    /// <summary>
    /// Function: GetStartFinalBlowTime
    /// </summary>
    public unsafe virtual float GetStartFinalBlowTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStartFinalBlowTime, "BmGame.RCombatMove_BatmanStrike.GetStartFinalBlowTime");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEndSlowMoTime;
    /// <summary>
    /// Function: GetEndSlowMoTime
    /// </summary>
    public unsafe virtual float GetEndSlowMoTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEndSlowMoTime, "BmGame.RCombatMove_BatmanStrike.GetEndSlowMoTime");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStartSlowMoTime;
    /// <summary>
    /// Function: GetStartSlowMoTime
    /// </summary>
    public unsafe virtual float GetStartSlowMoTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStartSlowMoTime, "BmGame.RCombatMove_BatmanStrike.GetStartSlowMoTime");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopSlowMo;
    /// <summary>
    /// Function: StopSlowMo
    /// </summary>
    public unsafe virtual void StopSlowMo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSlowMo, "BmGame.RCombatMove_BatmanStrike.StopSlowMo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldSlowMo;
    /// <summary>
    /// Function: ShouldSlowMo
    /// </summary>
    public unsafe virtual bool ShouldSlowMo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSlowMo, "BmGame.RCombatMove_BatmanStrike.ShouldSlowMo");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BatmanTargetted;
    /// <summary>
    /// Function: BatmanTargetted
    /// </summary>
    public unsafe virtual bool BatmanTargetted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmanTargetted, "BmGame.RCombatMove_BatmanStrike.BatmanTargetted");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsSliding;
    /// <summary>
    /// Function: IsSliding
    /// </summary>
    public unsafe virtual bool IsSliding()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSliding, "BmGame.RCombatMove_BatmanStrike.IsSliding");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHitImpactForce;
    /// <summary>
    /// Function: GetHitImpactForce
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetHitImpactForce(BmSDK.BmGame.RPawnCombat HitPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitImpactForce, "BmGame.RCombatMove_BatmanStrike.GetHitImpactForce");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetDamageDirection;
    /// <summary>
    /// Function: GetDamageDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDamageDirection(BmSDK.BmGame.RPawnCombat HitPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageDirection, "BmGame.RCombatMove_BatmanStrike.GetDamageDirection");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetDamagePower;
    /// <summary>
    /// Function: GetDamagePower
    /// </summary>
    public unsafe virtual float GetDamagePower()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamagePower, "BmGame.RCombatMove_BatmanStrike.GetDamagePower");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDamageCollisionProjection;
    /// <summary>
    /// Function: GetDamageCollisionProjection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDamageCollisionProjection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageCollisionProjection, "BmGame.RCombatMove_BatmanStrike.GetDamageCollisionProjection");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDamageCollisionDuration;
    /// <summary>
    /// Function: GetDamageCollisionDuration
    /// </summary>
    public unsafe virtual float GetDamageCollisionDuration()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageCollisionDuration, "BmGame.RCombatMove_BatmanStrike.GetDamageCollisionDuration");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDamageCollisionRadius;
    /// <summary>
    /// Function: GetDamageCollisionRadius
    /// </summary>
    public unsafe virtual float GetDamageCollisionRadius()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageCollisionRadius, "BmGame.RCombatMove_BatmanStrike.GetDamageCollisionRadius");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHitBone;
    /// <summary>
    /// Function: GetHitBone
    /// </summary>
    public unsafe virtual BmSDK.FName GetHitBone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitBone, "BmGame.RCombatMove_BatmanStrike.GetHitBone");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDamageBone;
    /// <summary>
    /// Function: GetDamageBone
    /// </summary>
    public unsafe virtual BmSDK.FName GetDamageBone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageBone, "BmGame.RCombatMove_BatmanStrike.GetDamageBone");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetImpactBoneEnum;
    /// <summary>
    /// Function: GetImpactBoneEnum
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.BoneNameList GetImpactBoneEnum()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetImpactBoneEnum, "BmGame.RCombatMove_BatmanStrike.GetImpactBoneEnum");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.BoneNameList>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDamageBoneEnum;
    /// <summary>
    /// Function: GetDamageBoneEnum
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.BoneNameList GetDamageBoneEnum()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageBoneEnum, "BmGame.RCombatMove_BatmanStrike.GetDamageBoneEnum");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.BoneNameList>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetValidTargetStrikeRange;
    /// <summary>
    /// Function: GetValidTargetStrikeRange
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.StrikeRange GetValidTargetStrikeRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetValidTargetStrikeRange, "BmGame.RCombatMove_BatmanStrike.GetValidTargetStrikeRange");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.StrikeRange>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeAnim;
    /// <summary>
    /// Function: GetStrikeAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetStrikeAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeAnim, "BmGame.RCombatMove_BatmanStrike.GetStrikeAnim");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeTimeUntilImpact;
    /// <summary>
    /// Function: GetStrikeTimeUntilImpact
    /// </summary>
    public unsafe virtual float GetStrikeTimeUntilImpact()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeTimeUntilImpact, "BmGame.RCombatMove_BatmanStrike.GetStrikeTimeUntilImpact");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeStruckBy;
    /// <summary>
    /// Function: CanBeStruckBy
    /// </summary>
    public unsafe override bool CanBeStruckBy(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.BmGame.RPawnCombat Defender)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeStruckBy, "BmGame.RCombatMove_BatmanStrike.CanBeStruckBy");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Defender, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CanReceiveAttackFromPawn;
    /// <summary>
    /// Function: CanReceiveAttackFromPawn
    /// </summary>
    public unsafe override bool CanReceiveAttackFromPawn(BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReceiveAttackFromPawn, "BmGame.RCombatMove_BatmanStrike.CanReceiveAttackFromPawn");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CanPerformNextComboMove;
    /// <summary>
    /// Function: CanPerformNextComboMove
    /// </summary>
    public unsafe override bool CanPerformNextComboMove(bool bSpecialMove = default, bool bStrike = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformNextComboMove, "BmGame.RCombatMove_BatmanStrike.CanPerformNextComboMove");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStrike, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DisallowEarlyExit;
    /// <summary>
    /// Function: DisallowEarlyExit
    /// </summary>
    public unsafe virtual void DisallowEarlyExit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisallowEarlyExit, "BmGame.RCombatMove_BatmanStrike.DisallowEarlyExit");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowEarlyExit;
    /// <summary>
    /// Function: AllowEarlyExit
    /// </summary>
    public unsafe virtual void AllowEarlyExit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowEarlyExit, "BmGame.RCombatMove_BatmanStrike.AllowEarlyExit");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowMovementExit;
    /// <summary>
    /// Function: AllowMovementExit
    /// </summary>
    public unsafe override void AllowMovementExit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowMovementExit, "BmGame.RCombatMove_BatmanStrike.AllowMovementExit");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BotTryNextStrike;
    /// <summary>
    /// Function: BotTryNextStrike
    /// </summary>
    public unsafe virtual void BotTryNextStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BotTryNextStrike, "BmGame.RCombatMove_BatmanStrike.BotTryNextStrike");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowNextNonStrikeMove;
    /// <summary>
    /// Function: AllowNextNonStrikeMove
    /// </summary>
    public unsafe virtual void AllowNextNonStrikeMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowNextNonStrikeMove, "BmGame.RCombatMove_BatmanStrike.AllowNextNonStrikeMove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowNextStrike;
    /// <summary>
    /// Function: AllowNextStrike
    /// </summary>
    public unsafe override void AllowNextStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowNextStrike, "BmGame.RCombatMove_BatmanStrike.AllowNextStrike");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableMotionBlur;
    /// <summary>
    /// Function: DisableMotionBlur
    /// </summary>
    public unsafe virtual void DisableMotionBlur()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableMotionBlur, "BmGame.RCombatMove_BatmanStrike.DisableMotionBlur");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableMotionBlur;
    /// <summary>
    /// Function: EnableMotionBlur
    /// </summary>
    public unsafe virtual void EnableMotionBlur()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableMotionBlur, "BmGame.RCombatMove_BatmanStrike.EnableMotionBlur");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamageCollisionDeactivated;
    /// <summary>
    /// Function: DamageCollisionDeactivated
    /// </summary>
    public unsafe virtual void DamageCollisionDeactivated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageCollisionDeactivated, "BmGame.RCombatMove_BatmanStrike.DamageCollisionDeactivated");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitTarget;
    /// <summary>
    /// Function: HitTarget
    /// </summary>
    public unsafe virtual void HitTarget(BmSDK.BmGame.RPawnVillain TargetPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitTarget, "BmGame.RCombatMove_BatmanStrike.HitTarget");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceHitTarget;
    /// <summary>
    /// Function: ForceHitTarget
    /// </summary>
    public unsafe virtual void ForceHitTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceHitTarget, "BmGame.RCombatMove_BatmanStrike.ForceHitTarget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartPreImpact;
    /// <summary>
    /// Function: StartPreImpact
    /// </summary>
    public unsafe virtual void StartPreImpact()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartPreImpact, "BmGame.RCombatMove_BatmanStrike.StartPreImpact");
        byte* paramsPtr = stackalloc byte[249];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartImpact;
    /// <summary>
    /// Function: StartImpact
    /// </summary>
    public unsafe virtual void StartImpact()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartImpact, "BmGame.RCombatMove_BatmanStrike.StartImpact");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StrikeContact;
    /// <summary>
    /// Function: StrikeContact
    /// </summary>
    public unsafe override void StrikeContact(bool bPreStrike)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StrikeContact, "BmGame.RCombatMove_BatmanStrike.StrikeContact");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPreStrike, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatAnimHit;
    /// <summary>
    /// Function: CombatAnimHit
    /// </summary>
    public unsafe virtual void CombatAnimHit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatAnimHit, "BmGame.RCombatMove_BatmanStrike.CombatAnimHit");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StrikeSlowMoStop;
    /// <summary>
    /// Function: StrikeSlowMoStop
    /// </summary>
    public unsafe virtual void StrikeSlowMoStop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StrikeSlowMoStop, "BmGame.RCombatMove_BatmanStrike.StrikeSlowMoStop");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StrikeSlowMoStart;
    /// <summary>
    /// Function: StrikeSlowMoStart
    /// </summary>
    public unsafe virtual void StrikeSlowMoStart()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StrikeSlowMoStart, "BmGame.RCombatMove_BatmanStrike.StrikeSlowMoStart");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldStartFinalBlowCam;
    /// <summary>
    /// Function: ShouldStartFinalBlowCam
    /// </summary>
    public unsafe virtual bool ShouldStartFinalBlowCam()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldStartFinalBlowCam, "BmGame.RCombatMove_BatmanStrike.ShouldStartFinalBlowCam");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DoCameraAssistance;
    /// <summary>
    /// Function: DoCameraAssistance
    /// </summary>
    public unsafe override bool DoCameraAssistance(float DelayTime = default, bool bCheckTarget = default, System.Numerics.Vector3 TestOffset = default, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed LookAtSpeed = default, BmSDK.Engine.Actor ForceTarget = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoCameraAssistance, "BmGame.RCombatMove_BatmanStrike.DoCameraAssistance");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DelayTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestOffset, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAtSpeed, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceTarget, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_HaveClearPathToTarget;
    /// <summary>
    /// Function: HaveClearPathToTarget
    /// </summary>
    public unsafe virtual bool HaveClearPathToTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HaveClearPathToTarget, "BmGame.RCombatMove_BatmanStrike.HaveClearPathToTarget");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GotoFirstState;
    /// <summary>
    /// Function: GotoFirstState
    /// </summary>
    public unsafe virtual void GotoFirstState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoFirstState, "BmGame.RCombatMove_BatmanStrike.GotoFirstState");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPData;
    /// <summary>
    /// Function: GetPData
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPersistentData GetPData()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPData, "BmGame.RCombatMove_BatmanStrike.GetPData");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NoTargetClearCombo;
    /// <summary>
    /// Function: NoTargetClearCombo
    /// </summary>
    public unsafe virtual void NoTargetClearCombo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NoTargetClearCombo, "BmGame.RCombatMove_BatmanStrike.NoTargetClearCombo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ModifyDmgTypeFromWeaponGrabbed;
    /// <summary>
    /// Function: ModifyDmgTypeFromWeaponGrabbed
    /// </summary>
    public unsafe virtual void ModifyDmgTypeFromWeaponGrabbed(BmSDK.BmGame.RBMCombatThrownObject WeaponInHand, out BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyDmgTypeFromWeaponGrabbed, "BmGame.RCombatMove_BatmanStrike.ModifyDmgTypeFromWeaponGrabbed");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponInHand, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        dmgType = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_FrameStrikeWithCamera;
    /// <summary>
    /// Function: FrameStrikeWithCamera
    /// </summary>
    public unsafe virtual void FrameStrikeWithCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FrameStrikeWithCamera, "BmGame.RCombatMove_BatmanStrike.FrameStrikeWithCamera");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmGame.RCombatMove_BatmanStrike.Initialise");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreFindStrikeInfo;
    /// <summary>
    /// Function: PreFindStrikeInfo
    /// </summary>
    public unsafe virtual void PreFindStrikeInfo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreFindStrikeInfo, "BmGame.RCombatMove_BatmanStrike.PreFindStrikeInfo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToFindTarget;
    /// <summary>
    /// Function: TryToFindTarget
    /// </summary>
    public unsafe virtual void TryToFindTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToFindTarget, "BmGame.RCombatMove_BatmanStrike.TryToFindTarget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNoTargetDir;
    /// <summary>
    /// Function: SetNoTargetDir
    /// </summary>
    public unsafe virtual void SetNoTargetDir()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNoTargetDir, "BmGame.RCombatMove_BatmanStrike.SetNoTargetDir");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCombatMoveVictim;
    /// <summary>
    /// Function: GetCombatMoveVictim
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawn GetCombatMoveVictim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatMoveVictim, "BmGame.RCombatMove_BatmanStrike.GetCombatMoveVictim");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatmanTransitionId;
    /// <summary>
    /// Function: GetBatmanTransitionId
    /// </summary>
    public unsafe override BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId GetBatmanTransitionId()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatmanTransitionId, "BmGame.RCombatMove_BatmanStrike.GetBatmanTransitionId");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Reset;
    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe override void Reset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reset, "BmGame.RCombatMove_BatmanStrike.Reset");
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEnvironmentInfo;
    /// <summary>
    /// Function: GetEnvironmentInfo
    /// </summary>
    public unsafe virtual int GetEnvironmentInfo(BmSDK.BmGame.RPawnVillain TargetPawn, out BmSDK.BmGame.RPawnPlayerCombat.StrikeEnvironmentDir EnvDir, bool bAllowInvalidWall = default, bool bAllowInNoEnvCounterVolume = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEnvironmentInfo, "BmGame.RCombatMove_BatmanStrike.GetEnvironmentInfo");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowInvalidWall, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowInNoEnvCounterVolume, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        EnvDir = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.StrikeEnvironmentDir>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ModifyInfoSearchParams;
    /// <summary>
    /// Function: ModifyInfoSearchParams
    /// </summary>
    public unsafe virtual void ModifyInfoSearchParams(out BmSDK.BmGame.RGameInfo.StrikeDirection InfoDir, out BmSDK.BmGame.RGameInfo.StrikeStrength InfoStrength, out BmSDK.BmGame.RGameInfo.StrikeRange InfoRange, out BmSDK.BmGame.RPawnPlayerCombat.StrikeEnvironmentDir InfoRailingDir, out BmSDK.BmGame.RPawnPlayerCombat.StrikeEnvironmentDir InfoWallDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyInfoSearchParams, "BmGame.RCombatMove_BatmanStrike.ModifyInfoSearchParams");
        byte* paramsPtr = stackalloc byte[5];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        InfoDir = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.StrikeDirection>(paramsPtr + 0);
        InfoStrength = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.StrikeStrength>(paramsPtr + 1);
        InfoRange = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.StrikeRange>(paramsPtr + 2);
        InfoRailingDir = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.StrikeEnvironmentDir>(paramsPtr + 3);
        InfoWallDir = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.StrikeEnvironmentDir>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_CanHitPawn;
    /// <summary>
    /// Function: CanHitPawn
    /// </summary>
    public unsafe virtual bool CanHitPawn(BmSDK.BmGame.RPawnCombat TargetPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanHitPawn, "BmGame.RCombatMove_BatmanStrike.CanHitPawn");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetScoreForStrikeWeaponPickup;
    /// <summary>
    /// Function: GetScoreForStrikeWeaponPickup
    /// </summary>
    public unsafe virtual int GetScoreForStrikeWeaponPickup(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreForStrikeWeaponPickup, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeWeaponPickup");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_GetScoreForStrikeWeaponGrabbed;
    /// <summary>
    /// Function: GetScoreForStrikeWeaponGrabbed
    /// </summary>
    public unsafe virtual int GetScoreForStrikeWeaponGrabbed(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreForStrikeWeaponGrabbed, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeWeaponGrabbed");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_GetScoreForStrikeStartingHeight;
    /// <summary>
    /// Function: GetScoreForStrikeStartingHeight
    /// </summary>
    public unsafe virtual int GetScoreForStrikeStartingHeight(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreForStrikeStartingHeight, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeStartingHeight");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_GetScoreForStrikeTurnMotion;
    /// <summary>
    /// Function: GetScoreForStrikeTurnMotion
    /// </summary>
    public unsafe virtual int GetScoreForStrikeTurnMotion(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreForStrikeTurnMotion, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeTurnMotion");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_GetScoreForStrikeSpeed;
    /// <summary>
    /// Function: GetScoreForStrikeSpeed
    /// </summary>
    public unsafe virtual int GetScoreForStrikeSpeed(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreForStrikeSpeed, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeSpeed");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_GetScoreForTimeSinceUse;
    /// <summary>
    /// Function: GetScoreForTimeSinceUse
    /// </summary>
    public unsafe virtual int GetScoreForTimeSinceUse(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreForTimeSinceUse, "BmGame.RCombatMove_BatmanStrike.GetScoreForTimeSinceUse");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_GetScoreForStrikeDir;
    /// <summary>
    /// Function: GetScoreForStrikeDir
    /// </summary>
    public unsafe virtual int GetScoreForStrikeDir(BmSDK.BmGame.RGameInfo.StrikeDirection TestDir, BmSDK.BmGame.RGameInfo.StrikeDirection DesDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreForStrikeDir, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeDir");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesDir, paramsPtr + 1);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetScoreForStrikeRange;
    /// <summary>
    /// Function: GetScoreForStrikeRange
    /// </summary>
    public unsafe virtual int GetScoreForStrikeRange(BmSDK.BmGame.RGameInfo.StrikeRange TestRange, BmSDK.BmGame.RGameInfo.StrikeRange DesRange)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreForStrikeRange, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeRange");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestRange, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesRange, paramsPtr + 1);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetScoreForHandedness;
    /// <summary>
    /// Function: GetScoreForHandedness
    /// </summary>
    public unsafe virtual int GetScoreForHandedness(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreForHandedness, "BmGame.RCombatMove_BatmanStrike.GetScoreForHandedness");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_GetStrikeInfoScore;
    /// <summary>
    /// Function: GetStrikeInfoScore
    /// </summary>
    public unsafe virtual float GetStrikeInfoScore(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike, BmSDK.BmGame.RGameInfo.StrikeDirection StrikeDir, BmSDK.BmGame.RGameInfo.StrikeStrength StrikeStrength, BmSDK.BmGame.RGameInfo.StrikeRange StrikeRange, BmSDK.BmGame.RPawnPlayerCombat.StrikeEnvironmentDir StrikeRailingDir, BmSDK.BmGame.RPawnPlayerCombat.StrikeEnvironmentDir StrikeWallDir, System.Numerics.Vector3 ControllerDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeInfoScore, "BmGame.RCombatMove_BatmanStrike.GetStrikeInfoScore");
        byte* paramsPtr = stackalloc byte[164];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDir, paramsPtr + 140);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeStrength, paramsPtr + 141);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeRange, paramsPtr + 142);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeRailingDir, paramsPtr + 143);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeWallDir, paramsPtr + 144);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerDir, paramsPtr + 148);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 160);
    }

    private static BmSDK.Function __fn_SetStrikeInfo;
    /// <summary>
    /// Function: SetStrikeInfo
    /// </summary>
    public unsafe virtual int SetStrikeInfo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStrikeInfo, "BmGame.RCombatMove_BatmanStrike.SetStrikeInfo");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// ClassProperty: StrikeDmgType
    /// </summary>
    public unsafe BmSDK.Class StrikeDmgType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// StructProperty: EnvLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EnvLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 876);

    /// <summary>
    /// StructProperty: EnvNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EnvNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 888);

    /// <summary>
    /// BoolProperty: bAnimAlreadyPlaying
    /// </summary>
    public unsafe bool bAnimAlreadyPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bTargetSet
    /// </summary>
    public unsafe bool bTargetSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bQueuedStrike
    /// </summary>
    public unsafe bool bQueuedStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bDisallowEarlyExit
    /// </summary>
    public unsafe bool bDisallowEarlyExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bIncreasedCombo
    /// </summary>
    public unsafe bool bIncreasedCombo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bCanBeStruck
    /// </summary>
    public unsafe bool bCanBeStruck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bCanStartNextNonStrikeMove
    /// </summary>
    public unsafe bool bCanStartNextNonStrikeMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bSlowMo
    /// </summary>
    public unsafe bool bSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bFinalBlow
    /// </summary>
    public unsafe bool bFinalBlow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bSpawnFinalBlowCam
    /// </summary>
    public unsafe bool bSpawnFinalBlowCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bFinalBlowSpawned
    /// </summary>
    public unsafe bool bFinalBlowSpawned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bSpawnFinalBlowNextFrame
    /// </summary>
    public unsafe bool bSpawnFinalBlowNextFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bFreeflowFocusStrike
    /// </summary>
    public unsafe bool bFreeflowFocusStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bCanBeCriticalStrike
    /// </summary>
    public unsafe bool bCanBeCriticalStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bDisableCameraAssist
    /// </summary>
    public unsafe bool bDisableCameraAssist
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bStrikeContactCalled
    /// </summary>
    public unsafe bool bStrikeContactCalled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bOverrideTargetStrike
    /// </summary>
    public unsafe bool bOverrideTargetStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bForceQuickStrike
    /// </summary>
    public unsafe bool bForceQuickStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bForceSlowStrike
    /// </summary>
    public unsafe bool bForceSlowStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bPreStrikeHit
    /// </summary>
    public unsafe bool bPreStrikeHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bNotifiedDeathCutscene
    /// </summary>
    public unsafe bool bNotifiedDeathCutscene
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bDoSlowMo
    /// </summary>
    public unsafe bool bDoSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bDoSlowMoSFX
    /// </summary>
    public unsafe bool bDoSlowMoSFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bBatmanIsInRelativeTransition
    /// </summary>
    public unsafe bool bBatmanIsInRelativeTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bCanShowTutorial
    /// </summary>
    public unsafe bool bCanShowTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bUsingJokerHallucination
    /// </summary>
    public unsafe bool bUsingJokerHallucination
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredJokerHallucinationReaction
    /// </summary>
    public unsafe bool bTriggeredJokerHallucinationReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bCalledHitTarget
    /// </summary>
    public unsafe bool bCalledHitTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bStrikeDepletesWeapon
    /// </summary>
    public unsafe bool bStrikeDepletesWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bZoomIn
    /// </summary>
    public unsafe bool bZoomIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bKeepCombo
    /// </summary>
    public unsafe bool bKeepCombo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysRemoveHelmets
    /// </summary>
    public unsafe bool bAlwaysRemoveHelmets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// StructProperty: TargetDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TargetDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 904);

    /// <summary>
    /// ObjectProperty: PrevTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain PrevTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: StrikeAnimSequence
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence StrikeAnimSequence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ComponentProperty: StrikeRainTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent StrikeRainTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ComponentProperty: StrikeTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent StrikeTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: SlowMoTimer
    /// </summary>
    public unsafe float SlowMoTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ByteProperty: TargetResponse
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat.TargetStrikeResponse TargetResponse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.TargetStrikeResponse>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: StrikeDamageAmount
    /// </summary>
    public unsafe float StrikeDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ArrayProperty: HitTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> HitTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// StructProperty: ImpactScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 976);

    /// <summary>
    /// StructProperty: StrikeInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo StrikeInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo>(Ptr + 1132);

    /// <summary>
    /// StructProperty: PrevStrikeInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo PrevStrikeInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo>(Ptr + 1272);

    /// <summary>
    /// FloatProperty: StrikeDurationScale
    /// </summary>
    public unsafe float StrikeDurationScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// FloatProperty: StrikeContactTime
    /// </summary>
    public unsafe float StrikeContactTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// StructProperty: BatmanStrikeID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId BatmanStrikeID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 1420);

    /// <summary>
    /// FloatProperty: StunRadius
    /// </summary>
    public unsafe float StunRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// FloatProperty: ChapterNumber
    /// </summary>
    public unsafe float ChapterNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// IntProperty: ComboLevel
    /// </summary>
    public unsafe int ComboLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// StructProperty: TargetHitReactionLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TargetHitReactionLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1436);

    /// <summary>
    /// NameProperty: ForceStrikeByName
    /// </summary>
    public unsafe BmSDK.FName ForceStrikeByName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// IntProperty: CapeStateChangeIndex
    /// </summary>
    public unsafe int CapeStateChangeIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }

    /// <summary>
    /// IntProperty: ThirdTimeSinceUseThresh
    /// </summary>
    public unsafe int ThirdTimeSinceUseThresh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// IntProperty: SecondTimeSinceUseThresh
    /// </summary>
    public unsafe int SecondTimeSinceUseThresh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// IntProperty: FirstTimeSinceUseThresh
    /// </summary>
    public unsafe int FirstTimeSinceUseThresh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// IntProperty: ThirdTimeSinceUseScore
    /// </summary>
    public unsafe int ThirdTimeSinceUseScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// IntProperty: SecondTimeSinceUseScore
    /// </summary>
    public unsafe int SecondTimeSinceUseScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// IntProperty: FirstTimeSinceUseScore
    /// </summary>
    public unsafe int FirstTimeSinceUseScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// IntProperty: CorrectRangeScore
    /// </summary>
    public unsafe int CorrectRangeScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// FloatProperty: JokerHallucinationFovModifier
    /// </summary>
    public unsafe float JokerHallucinationFovModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// FloatProperty: JokerHallucinationFovTimer
    /// </summary>
    public unsafe float JokerHallucinationFovTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// IntProperty: PickedJokerAnimIndex
    /// </summary>
    public unsafe int PickedJokerAnimIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// ArrayProperty: JokerStrikeAnimName
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> JokerStrikeAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// ArrayProperty: JokerStrikeIdleAnimName
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> JokerStrikeIdleAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// FloatProperty: MaxTargetDist
    /// </summary>
    public unsafe float MaxTargetDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// StructProperty: StartLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StartLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1536);

    /// <summary>
    /// ArrayProperty: StrikeTrailActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatThrownObject> StrikeTrailActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatThrownObject>>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }
}
