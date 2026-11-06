#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCombatMove_BatmanStunStrike<br/>
/// (size = 1608)
/// (flags = 144703634)
/// </summary>
public partial class RCombatMove_BatmanStunStrike : BmSDK.BmGame.RCombatMove_BatmanStrike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatMove_BatmanStunStrike", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCombatMove_BatmanStunStrike.
    /// </summary>
    public static RCombatMove_BatmanStunStrike DefaultObject => (RCombatMove_BatmanStunStrike)StaticClass().DefaultObject;

    internal RCombatMove_BatmanStunStrike() { }

    /// <summary>
    /// Constructs a new RCombatMove_BatmanStunStrike
    /// </summary>
    public RCombatMove_BatmanStunStrike(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_BatmanStunStrike(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStunStrike>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStunStrike>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStunStrike>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStunStrike>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStunStrike>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStunStrike>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStunStrike>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStunStrike>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CanPerformWeaponSnatchWithRun;
    /// <summary>
    /// Function: CanPerformWeaponSnatchWithRun
    /// </summary>
    public unsafe override bool CanPerformWeaponSnatchWithRun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformWeaponSnatchWithRun, "BmGame.RCombatMove_BatmanStunStrike.CanPerformWeaponSnatchWithRun");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldPlayHitReactionToGunFire;
    /// <summary>
    /// Function: ShouldPlayHitReactionToGunFire
    /// </summary>
    public unsafe override bool ShouldPlayHitReactionToGunFire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldPlayHitReactionToGunFire, "BmGame.RCombatMove_BatmanStunStrike.ShouldPlayHitReactionToGunFire");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanForceSlowStrike;
    /// <summary>
    /// Function: CanForceSlowStrike
    /// </summary>
    public unsafe override bool CanForceSlowStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanForceSlowStrike, "BmGame.RCombatMove_BatmanStunStrike.CanForceSlowStrike");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStartSlowMoTime;
    /// <summary>
    /// Function: GetStartSlowMoTime
    /// </summary>
    public unsafe override float GetStartSlowMoTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStartSlowMoTime, "BmGame.RCombatMove_BatmanStunStrike.GetStartSlowMoTime");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEndSlowMoTime;
    /// <summary>
    /// Function: GetEndSlowMoTime
    /// </summary>
    public unsafe override float GetEndSlowMoTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEndSlowMoTime, "BmGame.RCombatMove_BatmanStunStrike.GetEndSlowMoTime");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformSecondaryGroupMove;
    /// <summary>
    /// Function: CanPerformSecondaryGroupMove
    /// </summary>
    public unsafe override bool CanPerformSecondaryGroupMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformSecondaryGroupMove, "BmGame.RCombatMove_BatmanStunStrike.CanPerformSecondaryGroupMove");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BotTryNextStrike;
    /// <summary>
    /// Function: BotTryNextStrike
    /// </summary>
    public unsafe override void BotTryNextStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BotTryNextStrike, "BmGame.RCombatMove_BatmanStunStrike.BotTryNextStrike");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPerformNextComboMove;
    /// <summary>
    /// Function: CanPerformNextComboMove
    /// </summary>
    public unsafe override bool CanPerformNextComboMove(bool bSpecialMove = default, bool bStrike = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformNextComboMove, "BmGame.RCombatMove_BatmanStunStrike.CanPerformNextComboMove");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStrike, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AllowNextStrike;
    /// <summary>
    /// Function: AllowNextStrike
    /// </summary>
    public unsafe override void AllowNextStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowNextStrike, "BmGame.RCombatMove_BatmanStunStrike.AllowNextStrike");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitMove;
    /// <summary>
    /// Function: ExitMove
    /// </summary>
    public unsafe override void ExitMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMove, "BmGame.RCombatMove_BatmanStunStrike.ExitMove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopStunFX;
    /// <summary>
    /// Function: StopStunFX
    /// </summary>
    public unsafe virtual void StopStunFX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopStunFX, "BmGame.RCombatMove_BatmanStunStrike.StopStunFX");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartStunFX;
    /// <summary>
    /// Function: StartStunFX
    /// </summary>
    public unsafe virtual void StartStunFX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartStunFX, "BmGame.RCombatMove_BatmanStunStrike.StartStunFX");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveSprayCan;
    /// <summary>
    /// Function: RemoveSprayCan
    /// </summary>
    public unsafe virtual void RemoveSprayCan()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveSprayCan, "BmGame.RCombatMove_BatmanStunStrike.RemoveSprayCan");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnSprayCan;
    /// <summary>
    /// Function: SpawnSprayCan
    /// </summary>
    public unsafe virtual void SpawnSprayCan(bool bLeftHand)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSprayCan, "BmGame.RCombatMove_BatmanStunStrike.SpawnSprayCan");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLeftHand, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnSprayCanRight;
    /// <summary>
    /// Function: SpawnSprayCanRight
    /// </summary>
    public unsafe virtual void SpawnSprayCanRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSprayCanRight, "BmGame.RCombatMove_BatmanStunStrike.SpawnSprayCanRight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnSprayCanLeft;
    /// <summary>
    /// Function: SpawnSprayCanLeft
    /// </summary>
    public unsafe virtual void SpawnSprayCanLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSprayCanLeft, "BmGame.RCombatMove_BatmanStunStrike.SpawnSprayCanLeft");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ModifyDmgTypeFromWeaponGrabbed;
    /// <summary>
    /// Function: ModifyDmgTypeFromWeaponGrabbed
    /// </summary>
    public unsafe override void ModifyDmgTypeFromWeaponGrabbed(BmSDK.BmGame.RBMCombatThrownObject WeaponInHand, out BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyDmgTypeFromWeaponGrabbed, "BmGame.RCombatMove_BatmanStunStrike.ModifyDmgTypeFromWeaponGrabbed");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponInHand, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out dmgType);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        dmgType = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_CanReceiveAttackFromPawn;
    /// <summary>
    /// Function: CanReceiveAttackFromPawn
    /// </summary>
    public unsafe override bool CanReceiveAttackFromPawn(BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReceiveAttackFromPawn, "BmGame.RCombatMove_BatmanStunStrike.CanReceiveAttackFromPawn");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CanNewAttackBeStarted;
    /// <summary>
    /// Function: CanNewAttackBeStarted
    /// </summary>
    public unsafe override bool CanNewAttackBeStarted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanNewAttackBeStarted, "BmGame.RCombatMove_BatmanStunStrike.CanNewAttackBeStarted");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformFloorPickupThug;
    /// <summary>
    /// Function: CanPerformFloorPickupThug
    /// </summary>
    public unsafe override bool CanPerformFloorPickupThug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformFloorPickupThug, "BmGame.RCombatMove_BatmanStunStrike.CanPerformFloorPickupThug");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformSecondaryGroupCombatMove;
    /// <summary>
    /// Function: CanPerformSecondaryGroupCombatMove
    /// </summary>
    public unsafe virtual bool CanPerformSecondaryGroupCombatMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformSecondaryGroupCombatMove, "BmGame.RCombatMove_BatmanStunStrike.CanPerformSecondaryGroupCombatMove");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformPrimaryGroupMove, "BmGame.RCombatMove_BatmanStunStrike.CanPerformPrimaryGroupMove");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformTakedownWithStun, "BmGame.RCombatMove_BatmanStunStrike.CanPerformTakedownWithStun");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformTakedownWithCounter, "BmGame.RCombatMove_BatmanStunStrike.CanPerformTakedownWithCounter");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDamageDirection;
    /// <summary>
    /// Function: GetDamageDirection
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetDamageDirection(BmSDK.BmGame.RPawnCombat HitPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageDirection, "BmGame.RCombatMove_BatmanStunStrike.GetDamageDirection");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetDamageAmount;
    /// <summary>
    /// Function: GetDamageAmount
    /// </summary>
    public unsafe override float GetDamageAmount(BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageAmount, "BmGame.RCombatMove_BatmanStunStrike.GetDamageAmount");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UpdateStunning;
    /// <summary>
    /// Function: UpdateStunning
    /// </summary>
    public unsafe virtual void UpdateStunning(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateStunning, "BmGame.RCombatMove_BatmanStunStrike.UpdateStunning");
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

    private static BmSDK.Function __fn_IsValidTarget;
    /// <summary>
    /// Function: IsValidTarget
    /// </summary>
    public unsafe virtual bool IsValidTarget(BmSDK.BmGame.RPawnCombat Enemy)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidTarget, "BmGame.RCombatMove_BatmanStunStrike.IsValidTarget");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Enemy, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetRadiusForAngle;
    /// <summary>
    /// Function: GetRadiusForAngle
    /// </summary>
    public unsafe virtual float GetRadiusForAngle(float TestAngle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRadiusForAngle, "BmGame.RCombatMove_BatmanStunStrike.GetRadiusForAngle");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestAngle, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DrawArcSegment;
    /// <summary>
    /// Function: DrawArcSegment
    /// </summary>
    public unsafe virtual void DrawArcSegment(float MinAngle, float MaxAngle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawArcSegment, "BmGame.RCombatMove_BatmanStunStrike.DrawArcSegment");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinAngle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxAngle, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoHitPawn;
    /// <summary>
    /// Function: DoHitPawn
    /// </summary>
    public unsafe override void DoHitPawn(BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoHitPawn, "BmGame.RCombatMove_BatmanStunStrike.DoHitPawn");
        byte* paramsPtr = stackalloc byte[257];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StunEnemy;
    /// <summary>
    /// Function: StunEnemy
    /// </summary>
    public unsafe virtual void StunEnemy(BmSDK.BmGame.RPawnCombat Enemy)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StunEnemy, "BmGame.RCombatMove_BatmanStunStrike.StunEnemy");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Enemy, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayImpactSound;
    /// <summary>
    /// Function: PlayImpactSound
    /// </summary>
    public unsafe override void PlayImpactSound(BmSDK.BmGame.RPawnCombat DamageReceiver, BmSDK.BmGame.RPawnCombat.DamageResult DmgResult)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayImpactSound, "BmGame.RCombatMove_BatmanStunStrike.PlayImpactSound");
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgResult, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFirstHitSound;
    /// <summary>
    /// Function: PlayFirstHitSound
    /// </summary>
    public unsafe override void PlayFirstHitSound(BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFirstHitSound, "BmGame.RCombatMove_BatmanStunStrike.PlayFirstHitSound");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceHitTarget;
    /// <summary>
    /// Function: ForceHitTarget
    /// </summary>
    public unsafe override void ForceHitTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceHitTarget, "BmGame.RCombatMove_BatmanStunStrike.ForceHitTarget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OutOfTime;
    /// <summary>
    /// Function: OutOfTime
    /// </summary>
    public unsafe virtual void OutOfTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OutOfTime, "BmGame.RCombatMove_BatmanStunStrike.OutOfTime");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnLeashStun;
    /// <summary>
    /// Function: UnLeashStun
    /// </summary>
    public unsafe virtual void UnLeashStun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnLeashStun, "BmGame.RCombatMove_BatmanStunStrike.UnLeashStun");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartTrail;
    /// <summary>
    /// Function: StartTrail
    /// </summary>
    public unsafe override void StartTrail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartTrail, "BmGame.RCombatMove_BatmanStunStrike.StartTrail");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayChargeUp;
    /// <summary>
    /// Function: PlayChargeUp
    /// </summary>
    public unsafe virtual void PlayChargeUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayChargeUp, "BmGame.RCombatMove_BatmanStunStrike.PlayChargeUp");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StrikeContact;
    /// <summary>
    /// Function: StrikeContact
    /// </summary>
    public unsafe override void StrikeContact(bool bPreStrike)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StrikeContact, "BmGame.RCombatMove_BatmanStunStrike.StrikeContact");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPreStrike, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessDamageResult;
    /// <summary>
    /// Function: ProcessDamageResult
    /// </summary>
    public unsafe override void ProcessDamageResult(BmSDK.BmGame.RPawnCombat.DamageResult DmgResult, BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessDamageResult, "BmGame.RCombatMove_BatmanStunStrike.ProcessDamageResult");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgResult, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerEvade;
    /// <summary>
    /// Function: TriggerEvade
    /// </summary>
    public unsafe override bool TriggerEvade()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerEvade, "BmGame.RCombatMove_BatmanStunStrike.TriggerEvade");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerStrikeAttempted;
    /// <summary>
    /// Function: TriggerStrikeAttempted
    /// </summary>
    public unsafe override void TriggerStrikeAttempted(bool bStun = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerStrikeAttempted, "BmGame.RCombatMove_BatmanStunStrike.TriggerStrikeAttempted");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStun, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldSlowMo;
    /// <summary>
    /// Function: ShouldSlowMo
    /// </summary>
    public unsafe override bool ShouldSlowMo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSlowMo, "BmGame.RCombatMove_BatmanStunStrike.ShouldSlowMo");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GotoFirstState;
    /// <summary>
    /// Function: GotoFirstState
    /// </summary>
    public unsafe override void GotoFirstState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoFirstState, "BmGame.RCombatMove_BatmanStunStrike.GotoFirstState");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmGame.RCombatMove_BatmanStunStrike.Initialise");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStrikeDurationScale;
    /// <summary>
    /// Function: GetStrikeDurationScale
    /// </summary>
    public unsafe override float GetStrikeDurationScale()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeDurationScale, "BmGame.RCombatMove_BatmanStunStrike.GetStrikeDurationScale");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetChargedUp;
    /// <summary>
    /// Function: SetChargedUp
    /// </summary>
    public unsafe virtual void SetChargedUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetChargedUp, "BmGame.RCombatMove_BatmanStunStrike.SetChargedUp");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bIsStunning
    /// </summary>
    public unsafe bool bIsStunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bRegisteredAction
    /// </summary>
    public unsafe bool bRegisteredAction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bStunPropInLeftHand
    /// </summary>
    public unsafe bool bStunPropInLeftHand
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bForceSuperStun
    /// </summary>
    public unsafe bool bForceSuperStun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bCanDoSuperStun
    /// </summary>
    public unsafe bool bCanDoSuperStun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bOnlyHitTarget
    /// </summary>
    public unsafe bool bOnlyHitTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bChargedUp
    /// </summary>
    public unsafe bool bChargedUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// FloatProperty: CurrStunAngle
    /// </summary>
    public unsafe float CurrStunAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }

    /// <summary>
    /// FloatProperty: CurrStunTime
    /// </summary>
    public unsafe float CurrStunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// FloatProperty: TotalStunTime
    /// </summary>
    public unsafe float TotalStunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }

    /// <summary>
    /// IntProperty: StunAngleDir
    /// </summary>
    public unsafe int StunAngleDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// FloatProperty: MinStunRadius
    /// </summary>
    public unsafe float MinStunRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// FloatProperty: MaxStunRadius
    /// </summary>
    public unsafe float MaxStunRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// FloatProperty: MaxStunAngle
    /// </summary>
    public unsafe float MaxStunAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }

    /// <summary>
    /// ComponentProperty: StunPropComponent
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent StunPropComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// IntProperty: ConsecutiveStuns
    /// </summary>
    public unsafe int ConsecutiveStuns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }
}
