#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCombatMove_VillainSimultaneousAttack<br/>
/// (size = 1296)
/// (flags = 144703634)
/// </summary>
public partial class RCombatMove_VillainSimultaneousAttack : BmSDK.BmGame.RCombatMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatMove_VillainSimultaneousAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCombatMove_VillainSimultaneousAttack.
    /// </summary>
    public static RCombatMove_VillainSimultaneousAttack DefaultObject => (RCombatMove_VillainSimultaneousAttack)StaticClass().DefaultObject;

    internal RCombatMove_VillainSimultaneousAttack() { }

    /// <summary>
    /// Constructs a new RCombatMove_VillainSimultaneousAttack
    /// </summary>
    public RCombatMove_VillainSimultaneousAttack(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_VillainSimultaneousAttack(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainSimultaneousAttack>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainSimultaneousAttack>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainSimultaneousAttack>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainSimultaneousAttack>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainSimultaneousAttack>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainSimultaneousAttack>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainSimultaneousAttack>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainSimultaneousAttack>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CanShovePawns;
    /// <summary>
    /// Function: CanShovePawns
    /// </summary>
    public unsafe override bool CanShovePawns(BmSDK.BmGame.RBMPawnAI TestThug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanShovePawns, "BmGame.RCombatMove_VillainSimultaneousAttack.CanShovePawns");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestThug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetFirstTransitionLocation;
    /// <summary>
    /// Function: GetFirstTransitionLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFirstTransitionLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFirstTransitionLocation, "BmGame.RCombatMove_VillainSimultaneousAttack.GetFirstTransitionLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetFirstTransitionLocation;
    /// <summary>
    /// Function: SetFirstTransitionLocation
    /// </summary>
    public unsafe virtual void SetFirstTransitionLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFirstTransitionLocation, "BmGame.RCombatMove_VillainSimultaneousAttack.SetFirstTransitionLocation");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCounterLocation;
    /// <summary>
    /// Function: GetCounterLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetCounterLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterLocation, "BmGame.RCombatMove_VillainSimultaneousAttack.GetCounterLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCounterLocation;
    /// <summary>
    /// Function: SetCounterLocation
    /// </summary>
    public unsafe virtual void SetCounterLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCounterLocation, "BmGame.RCombatMove_VillainSimultaneousAttack.SetCounterLocation");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldCombatMoveForceCombatCamera;
    /// <summary>
    /// Function: ShouldCombatMoveForceCombatCamera
    /// </summary>
    public unsafe override bool ShouldCombatMoveForceCombatCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldCombatMoveForceCombatCamera, "BmGame.RCombatMove_VillainSimultaneousAttack.ShouldCombatMoveForceCombatCamera");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanSpawnSuperStrike;
    /// <summary>
    /// Function: CanSpawnSuperStrike
    /// </summary>
    public unsafe override bool CanSpawnSuperStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSpawnSuperStrike, "BmGame.RCombatMove_VillainSimultaneousAttack.CanSpawnSuperStrike");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerStrikeAttempted, "BmGame.RCombatMove_VillainSimultaneousAttack.TriggerStrikeAttempted");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStun, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowCriticalStatus;
    /// <summary>
    /// Function: ShowCriticalStatus
    /// </summary>
    public unsafe virtual void ShowCriticalStatus()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCriticalStatus, "BmGame.RCombatMove_VillainSimultaneousAttack.ShowCriticalStatus");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitMove;
    /// <summary>
    /// Function: ExitMove
    /// </summary>
    public unsafe override void ExitMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMove, "BmGame.RCombatMove_VillainSimultaneousAttack.ExitMove");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateFormation;
    /// <summary>
    /// Function: UpdateFormation
    /// </summary>
    public unsafe virtual bool UpdateFormation(bool bTrackUsage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFormation, "BmGame.RCombatMove_VillainSimultaneousAttack.UpdateFormation");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTrackUsage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateJokerHallucination;
    /// <summary>
    /// Function: UpdateJokerHallucination
    /// </summary>
    public unsafe virtual bool UpdateJokerHallucination(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateJokerHallucination, "BmGame.RCombatMove_VillainSimultaneousAttack.UpdateJokerHallucination");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetFOVModifier;
    /// <summary>
    /// Function: GetFOVModifier
    /// </summary>
    public unsafe override float GetFOVModifier()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFOVModifier, "BmGame.RCombatMove_VillainSimultaneousAttack.GetFOVModifier");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateSlowMo;
    /// <summary>
    /// Function: UpdateSlowMo
    /// </summary>
    public unsafe virtual bool UpdateSlowMo(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSlowMo, "BmGame.RCombatMove_VillainSimultaneousAttack.UpdateSlowMo");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShouldSlowMo;
    /// <summary>
    /// Function: ShouldSlowMo
    /// </summary>
    public unsafe virtual bool ShouldSlowMo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSlowMo, "BmGame.RCombatMove_VillainSimultaneousAttack.ShouldSlowMo");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBoneName;
    /// <summary>
    /// Function: GetBoneName
    /// </summary>
    public unsafe virtual BmSDK.FName GetBoneName(BmSDK.BmGame.RGameInfo.BoneNameList BoneID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBoneName, "BmGame.RCombatMove_VillainSimultaneousAttack.GetBoneName");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTransitionDurationScale;
    /// <summary>
    /// Function: GetTransitionDurationScale
    /// </summary>
    public unsafe virtual float GetTransitionDurationScale(BmSDK.BmGame.RPawnVillain Villain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionDurationScale, "BmGame.RCombatMove_VillainSimultaneousAttack.GetTransitionDurationScale");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ExitMoveForPawn;
    /// <summary>
    /// Function: ExitMoveForPawn
    /// </summary>
    public unsafe override void ExitMoveForPawn(BmSDK.BmGame.RPawnCombat PawnToExit)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMoveForPawn, "BmGame.RCombatMove_VillainSimultaneousAttack.ExitMoveForPawn");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnToExit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveOverridenForPawn;
    /// <summary>
    /// Function: MoveOverridenForPawn
    /// </summary>
    public unsafe override void MoveOverridenForPawn(BmSDK.BmGame.RPawnCombat OverridenPawn, BmSDK.BmGame.RCombatMove NewMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveOverridenForPawn, "BmGame.RCombatMove_VillainSimultaneousAttack.MoveOverridenForPawn");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridenPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InterruptsBeatdown;
    /// <summary>
    /// Function: InterruptsBeatdown
    /// </summary>
    public unsafe override bool InterruptsBeatdown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterruptsBeatdown, "BmGame.RCombatMove_VillainSimultaneousAttack.InterruptsBeatdown");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFormationTargetLocation;
    /// <summary>
    /// Function: GetFormationTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFormationTargetLocation(int Idx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFormationTargetLocation, "BmGame.RCombatMove_VillainSimultaneousAttack.GetFormationTargetLocation");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Idx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCounterLimb;
    /// <summary>
    /// Function: GetCounterLimb
    /// </summary>
    public unsafe override BmSDK.BmGame.RGameInfo.CounterLimb GetCounterLimb(BmSDK.BmGame.RPawnCombat TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterLimb, "BmGame.RCombatMove_VillainSimultaneousAttack.GetCounterLimb");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CounterLimb>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsValidGroupFloorTakedownTarget;
    /// <summary>
    /// Function: IsValidGroupFloorTakedownTarget
    /// </summary>
    public unsafe virtual bool IsValidGroupFloorTakedownTarget(BmSDK.BmGame.RPawnCombat IsStunnedPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidGroupFloorTakedownTarget, "BmGame.RCombatMove_VillainSimultaneousAttack.IsValidGroupFloorTakedownTarget");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsStunnedPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanPerformNextComboMove;
    /// <summary>
    /// Function: CanPerformNextComboMove
    /// </summary>
    public unsafe override bool CanPerformNextComboMove(bool bSpecialMove = default, bool bStrike = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformNextComboMove, "BmGame.RCombatMove_VillainSimultaneousAttack.CanPerformNextComboMove");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStrike, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_OverridenBySpecialMove;
    /// <summary>
    /// Function: OverridenBySpecialMove
    /// </summary>
    public unsafe virtual void OverridenBySpecialMove(BmSDK.BmGame.RPawnVillain SpecialMoveTarget = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverridenBySpecialMove, "BmGame.RCombatMove_VillainSimultaneousAttack.OverridenBySpecialMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialMoveTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPerformWeaponDestroy;
    /// <summary>
    /// Function: CanPerformWeaponDestroy
    /// </summary>
    public unsafe virtual bool CanPerformWeaponDestroy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformWeaponDestroy, "BmGame.RCombatMove_VillainSimultaneousAttack.CanPerformWeaponDestroy");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformTakedownWithStun;
    /// <summary>
    /// Function: CanPerformTakedownWithStun
    /// </summary>
    public unsafe virtual bool CanPerformTakedownWithStun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformTakedownWithStun, "BmGame.RCombatMove_VillainSimultaneousAttack.CanPerformTakedownWithStun");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DamageCollisionBetween;
    /// <summary>
    /// Function: DamageCollisionBetween
    /// </summary>
    public unsafe override void DamageCollisionBetween(BmSDK.BmGame.RPawnCombat Pawn1, BmSDK.BmGame.RPawnCombat Pawn2, System.Numerics.Vector3 DamageDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageCollisionBetween, "BmGame.RCombatMove_VillainSimultaneousAttack.DamageCollisionBetween");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn2, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageDir, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayThugCounter;
    /// <summary>
    /// Function: PlayThugCounter
    /// </summary>
    public unsafe virtual void PlayThugCounter(int Idx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayThugCounter, "BmGame.RCombatMove_VillainSimultaneousAttack.PlayThugCounter");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Idx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySettle;
    /// <summary>
    /// Function: PlaySettle
    /// </summary>
    public unsafe virtual void PlaySettle(BmSDK.BmGame.RPawnVillain Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySettle, "BmGame.RCombatMove_VillainSimultaneousAttack.PlaySettle");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBmAnimName;
    /// <summary>
    /// Function: GetBmAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetBmAnimName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBmAnimName, "BmGame.RCombatMove_VillainSimultaneousAttack.GetBmAnimName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetVillainAnimName;
    /// <summary>
    /// Function: GetVillainAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetVillainAnimName(int V)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVillainAnimName, "BmGame.RCombatMove_VillainSimultaneousAttack.GetVillainAnimName");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AllowAnotherAttacker;
    /// <summary>
    /// Function: AllowAnotherAttacker
    /// </summary>
    public unsafe override bool AllowAnotherAttacker()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowAnotherAttacker, "BmGame.RCombatMove_VillainSimultaneousAttack.AllowAnotherAttacker");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayHitFX;
    /// <summary>
    /// Function: PlayHitFX
    /// </summary>
    public unsafe virtual void PlayHitFX(BmSDK.BmGame.RPawnCombat Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHitFX, "BmGame.RCombatMove_VillainSimultaneousAttack.PlayHitFX");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamageCurrentPlayer;
    /// <summary>
    /// Function: DamageCurrentPlayer
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.DamageResult DamageCurrentPlayer(BmSDK.BmGame.RPawnCombat Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageCurrentPlayer, "BmGame.RCombatMove_VillainSimultaneousAttack.DamageCurrentPlayer");
        byte* paramsPtr = stackalloc byte[260];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_WeaponGrabbedByTarget;
    /// <summary>
    /// Function: WeaponGrabbedByTarget
    /// </summary>
    public unsafe virtual void WeaponGrabbedByTarget(BmSDK.BmGame.RBMWeapon WeaponToGrab, bool bLeftHand)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponGrabbedByTarget, "BmGame.RCombatMove_VillainSimultaneousAttack.WeaponGrabbedByTarget");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponToGrab, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLeftHand, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGrabbed;
    /// <summary>
    /// Function: SetGrabbed
    /// </summary>
    public unsafe virtual void SetGrabbed(BmSDK.BmGame.RPawnVillain GrabbedVillain, bool bPawnGrabbed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGrabbed, "BmGame.RCombatMove_VillainSimultaneousAttack.SetGrabbed");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrabbedVillain, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPawnGrabbed, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowMovementExit;
    /// <summary>
    /// Function: AllowMovementExit
    /// </summary>
    public unsafe virtual void AllowMovementExit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowMovementExit, "BmGame.RCombatMove_VillainSimultaneousAttack.AllowMovementExit");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BotTryNextStrike, "BmGame.RCombatMove_VillainSimultaneousAttack.BotTryNextStrike");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowNextStrike;
    /// <summary>
    /// Function: AllowNextStrike
    /// </summary>
    public unsafe virtual void AllowNextStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowNextStrike, "BmGame.RCombatMove_VillainSimultaneousAttack.AllowNextStrike");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerDualTakedownAttempted;
    /// <summary>
    /// Function: TriggerDualTakedownAttempted
    /// </summary>
    public unsafe override void TriggerDualTakedownAttempted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerDualTakedownAttempted, "BmGame.RCombatMove_VillainSimultaneousAttack.TriggerDualTakedownAttempted");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveSuccessfullyFinished;
    /// <summary>
    /// Function: MoveSuccessfullyFinished
    /// </summary>
    public unsafe virtual void MoveSuccessfullyFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveSuccessfullyFinished, "BmGame.RCombatMove_VillainSimultaneousAttack.MoveSuccessfullyFinished");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VillainGoRagdoll;
    /// <summary>
    /// Function: VillainGoRagdoll
    /// </summary>
    public unsafe virtual void VillainGoRagdoll(BmSDK.BmGame.RPawnVillain RagdollVillain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VillainGoRagdoll, "BmGame.RCombatMove_VillainSimultaneousAttack.VillainGoRagdoll");
        byte* paramsPtr = stackalloc byte[260];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RagdollVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRagdollNotify;
    /// <summary>
    /// Function: OnRagdollNotify
    /// </summary>
    public unsafe virtual void OnRagdollNotify(BmSDK.BmGame.RPawnVillain RagdollVillain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRagdollNotify, "BmGame.RCombatMove_VillainSimultaneousAttack.OnRagdollNotify");
        byte* paramsPtr = stackalloc byte[260];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RagdollVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDamageAmount;
    /// <summary>
    /// Function: GetDamageAmount
    /// </summary>
    public unsafe virtual float GetDamageAmount()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageAmount, "BmGame.RCombatMove_VillainSimultaneousAttack.GetDamageAmount");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DamageCollisionDeactivated;
    /// <summary>
    /// Function: DamageCollisionDeactivated
    /// </summary>
    public unsafe virtual void DamageCollisionDeactivated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageCollisionDeactivated, "BmGame.RCombatMove_VillainSimultaneousAttack.DamageCollisionDeactivated");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AnimHit;
    /// <summary>
    /// Function: AnimHit
    /// </summary>
    public unsafe virtual void AnimHit(BmSDK.BmGame.RPawnVillain VillainPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnimHit, "BmGame.RCombatMove_VillainSimultaneousAttack.AnimHit");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VillainPreAttackNotifyTriggered;
    /// <summary>
    /// Function: VillainPreAttackNotifyTriggered
    /// </summary>
    public unsafe virtual void VillainPreAttackNotifyTriggered(BmSDK.BmGame.RPawnVillain VillainPawn, BmSDK.BmGame.RGameInfo.FVillainAttackInfo AttackInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VillainPreAttackNotifyTriggered, "BmGame.RCombatMove_VillainSimultaneousAttack.VillainPreAttackNotifyTriggered");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackInfo, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VillainAttackNotifyTriggered;
    /// <summary>
    /// Function: VillainAttackNotifyTriggered
    /// </summary>
    public unsafe virtual void VillainAttackNotifyTriggered(BmSDK.BmGame.RPawnVillain VillainPawn, BmSDK.BmGame.RGameInfo.FVillainAttackInfo AttackInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VillainAttackNotifyTriggered, "BmGame.RCombatMove_VillainSimultaneousAttack.VillainAttackNotifyTriggered");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackInfo, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanCounterStop;
    /// <summary>
    /// Function: CanCounterStop
    /// </summary>
    public unsafe virtual void CanCounterStop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCounterStop, "BmGame.RCombatMove_VillainSimultaneousAttack.CanCounterStop");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanCounterStart;
    /// <summary>
    /// Function: CanCounterStart
    /// </summary>
    public unsafe virtual void CanCounterStart()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCounterStart, "BmGame.RCombatMove_VillainSimultaneousAttack.CanCounterStart");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeTargettedByPlayer;
    /// <summary>
    /// Function: CanBeTargettedByPlayer
    /// </summary>
    public unsafe override bool CanBeTargettedByPlayer(BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.Class DamageType, BmSDK.BmGame.RPawnPlayerCombat NewPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeTargettedByPlayer, "BmGame.RCombatMove_VillainSimultaneousAttack.CanBeTargettedByPlayer");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_SetCounterable;
    /// <summary>
    /// Function: SetCounterable
    /// </summary>
    public unsafe virtual void SetCounterable(BmSDK.BmGame.RPawnVillain VillainPawn, bool bCounterable, bool bSuccess)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCounterable, "BmGame.RCombatMove_VillainSimultaneousAttack.SetCounterable");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCounterable, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccess, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSimultaneousCounterStop;
    /// <summary>
    /// Function: CanSimultaneousCounterStop
    /// </summary>
    public unsafe virtual void CanSimultaneousCounterStop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSimultaneousCounterStop, "BmGame.RCombatMove_VillainSimultaneousAttack.CanSimultaneousCounterStop");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSimultaneousCounterStart;
    /// <summary>
    /// Function: CanSimultaneousCounterStart
    /// </summary>
    public unsafe virtual void CanSimultaneousCounterStart()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSimultaneousCounterStart, "BmGame.RCombatMove_VillainSimultaneousAttack.CanSimultaneousCounterStart");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SimultaneousCriticalStart;
    /// <summary>
    /// Function: SimultaneousCriticalStart
    /// </summary>
    public unsafe virtual void SimultaneousCriticalStart(BmSDK.BmGame.RPawnVillain VillainPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SimultaneousCriticalStart, "BmGame.RCombatMove_VillainSimultaneousAttack.SimultaneousCriticalStart");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CounterFXPunchFinal;
    /// <summary>
    /// Function: CounterFXPunchFinal
    /// </summary>
    public unsafe virtual void CounterFXPunchFinal()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterFXPunchFinal, "BmGame.RCombatMove_VillainSimultaneousAttack.CounterFXPunchFinal");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CounterFxHitFinal;
    /// <summary>
    /// Function: CounterFxHitFinal
    /// </summary>
    public unsafe virtual void CounterFxHitFinal()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterFxHitFinal, "BmGame.RCombatMove_VillainSimultaneousAttack.CounterFxHitFinal");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CounterFXPunch;
    /// <summary>
    /// Function: CounterFXPunch
    /// </summary>
    public unsafe virtual void CounterFXPunch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterFXPunch, "BmGame.RCombatMove_VillainSimultaneousAttack.CounterFXPunch");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CounterFXHit;
    /// <summary>
    /// Function: CounterFXHit
    /// </summary>
    public unsafe virtual void CounterFXHit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterFXHit, "BmGame.RCombatMove_VillainSimultaneousAttack.CounterFXHit");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CounterFXBlock;
    /// <summary>
    /// Function: CounterFXBlock
    /// </summary>
    public unsafe virtual void CounterFXBlock()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterFXBlock, "BmGame.RCombatMove_VillainSimultaneousAttack.CounterFXBlock");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopTargetting;
    /// <summary>
    /// Function: StopTargetting
    /// </summary>
    public unsafe virtual void StopTargetting(BmSDK.BmGame.RPawnVillain VillainPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopTargetting, "BmGame.RCombatMove_VillainSimultaneousAttack.StopTargetting");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllStopTargetting;
    /// <summary>
    /// Function: AllStopTargetting
    /// </summary>
    public unsafe virtual void AllStopTargetting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllStopTargetting, "BmGame.RCombatMove_VillainSimultaneousAttack.AllStopTargetting");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllStartTargetting;
    /// <summary>
    /// Function: AllStartTargetting
    /// </summary>
    public unsafe virtual void AllStartTargetting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllStartTargetting, "BmGame.RCombatMove_VillainSimultaneousAttack.AllStartTargetting");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetVillainWithCounterOrder;
    /// <summary>
    /// Function: GetVillainWithCounterOrder
    /// </summary>
    public unsafe virtual int GetVillainWithCounterOrder(int OrderIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVillainWithCounterOrder, "BmGame.RCombatMove_VillainSimultaneousAttack.GetVillainWithCounterOrder");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OrderIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ReSortCounterOrder;
    /// <summary>
    /// Function: ReSortCounterOrder
    /// </summary>
    public unsafe virtual void ReSortCounterOrder(int VillainListIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReSortCounterOrder, "BmGame.RCombatMove_VillainSimultaneousAttack.ReSortCounterOrder");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainListIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CounterPressedSimulated;
    /// <summary>
    /// Function: CounterPressedSimulated
    /// </summary>
    public unsafe virtual void CounterPressedSimulated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterPressedSimulated, "BmGame.RCombatMove_VillainSimultaneousAttack.CounterPressedSimulated");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CounterPressed;
    /// <summary>
    /// Function: CounterPressed
    /// </summary>
    public unsafe virtual void CounterPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterPressed, "BmGame.RCombatMove_VillainSimultaneousAttack.CounterPressed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RevertToNormalCounter;
    /// <summary>
    /// Function: RevertToNormalCounter
    /// </summary>
    public unsafe virtual void RevertToNormalCounter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RevertToNormalCounter, "BmGame.RCombatMove_VillainSimultaneousAttack.RevertToNormalCounter");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayBatmanCounter;
    /// <summary>
    /// Function: PlayBatmanCounter
    /// </summary>
    public unsafe virtual void PlayBatmanCounter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBatmanCounter, "BmGame.RCombatMove_VillainSimultaneousAttack.PlayBatmanCounter");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoThrowCounterDir;
    /// <summary>
    /// Function: DoThrowCounterDir
    /// </summary>
    public unsafe virtual int DoThrowCounterDir(System.Numerics.Vector3 TestDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoThrowCounterDir, "BmGame.RCombatMove_VillainSimultaneousAttack.DoThrowCounterDir");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_StartFinalBlowCam;
    /// <summary>
    /// Function: StartFinalBlowCam
    /// </summary>
    public unsafe virtual void StartFinalBlowCam()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFinalBlowCam, "BmGame.RCombatMove_VillainSimultaneousAttack.StartFinalBlowCam");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncCountered;
    /// <summary>
    /// Function: IncCountered
    /// </summary>
    public unsafe virtual void IncCountered()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncCountered, "BmGame.RCombatMove_VillainSimultaneousAttack.IncCountered");
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartCounter;
    /// <summary>
    /// Function: StartCounter
    /// </summary>
    public unsafe virtual void StartCounter(float TimeInitiatedByPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartCounter, "BmGame.RCombatMove_VillainSimultaneousAttack.StartCounter");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanCounter;
    /// <summary>
    /// Function: CanCounter
    /// </summary>
    public unsafe virtual bool CanCounter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCounter, "BmGame.RCombatMove_VillainSimultaneousAttack.CanCounter");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OverrideDamagedBy;
    /// <summary>
    /// Function: OverrideDamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult OverrideDamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideDamagedBy, "BmGame.RCombatMove_VillainSimultaneousAttack.OverrideDamagedBy");
        byte* paramsPtr = stackalloc byte[249];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 248);
    }

    private static BmSDK.Function __fn_CanReceiveAttackFromPawn;
    /// <summary>
    /// Function: CanReceiveAttackFromPawn
    /// </summary>
    public unsafe override bool CanReceiveAttackFromPawn(BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReceiveAttackFromPawn, "BmGame.RCombatMove_VillainSimultaneousAttack.CanReceiveAttackFromPawn");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanNewAttackBeStarted, "BmGame.RCombatMove_VillainSimultaneousAttack.CanNewAttackBeStarted");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAttacking;
    /// <summary>
    /// Function: IsAttacking
    /// </summary>
    public unsafe override bool IsAttacking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAttacking, "BmGame.RCombatMove_VillainSimultaneousAttack.IsAttacking");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TurnOffRelativeTransition;
    /// <summary>
    /// Function: TurnOffRelativeTransition
    /// </summary>
    public unsafe override void TurnOffRelativeTransition(BmSDK.BmGame.RPawnCombat TransitionPawn, BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId TestID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffRelativeTransition, "BmGame.RCombatMove_VillainSimultaneousAttack.TurnOffRelativeTransition");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanFinalBlowOnPawnType;
    /// <summary>
    /// Function: CanFinalBlowOnPawnType
    /// </summary>
    public unsafe virtual bool CanFinalBlowOnPawnType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanFinalBlowOnPawnType, "BmGame.RCombatMove_VillainSimultaneousAttack.CanFinalBlowOnPawnType");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdatePotentialFinalBlow;
    /// <summary>
    /// Function: UpdatePotentialFinalBlow
    /// </summary>
    public unsafe virtual void UpdatePotentialFinalBlow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePotentialFinalBlow, "BmGame.RCombatMove_VillainSimultaneousAttack.UpdatePotentialFinalBlow");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddVillain;
    /// <summary>
    /// Function: AddVillain
    /// </summary>
    public unsafe virtual void AddVillain(BmSDK.BmGame.RPawnVillain Villain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddVillain, "BmGame.RCombatMove_VillainSimultaneousAttack.AddVillain");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawVecs;
    /// <summary>
    /// Function: DrawVecs
    /// </summary>
    public unsafe virtual void DrawVecs(bool bPersistent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawVecs, "BmGame.RCombatMove_VillainSimultaneousAttack.DrawVecs");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmGame.RCombatMove_VillainSimultaneousAttack.Initialise");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMirrored;
    /// <summary>
    /// Function: GetMirrored
    /// </summary>
    public unsafe override bool GetMirrored()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMirrored, "BmGame.RCombatMove_VillainSimultaneousAttack.GetMirrored");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCombatMoveVictim;
    /// <summary>
    /// Function: GetCombatMoveVictim
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawn GetCombatMoveVictim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatMoveVictim, "BmGame.RCombatMove_VillainSimultaneousAttack.GetCombatMoveVictim");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NotifyCombatMoveOfJokerSpawn;
    /// <summary>
    /// Function: NotifyCombatMoveOfJokerSpawn
    /// </summary>
    public unsafe virtual void NotifyCombatMoveOfJokerSpawn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyCombatMoveOfJokerSpawn, "BmGame.RCombatMove_VillainSimultaneousAttack.NotifyCombatMoveOfJokerSpawn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateFormationRotation;
    /// <summary>
    /// Function: UpdateFormationRotation
    /// </summary>
    public unsafe virtual void UpdateFormationRotation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFormationRotation, "BmGame.RCombatMove_VillainSimultaneousAttack.UpdateFormationRotation");
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

    private static BmSDK.Function __fn_UpdateVecSpots;
    /// <summary>
    /// Function: UpdateVecSpots
    /// </summary>
    public unsafe virtual void UpdateVecSpots()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateVecSpots, "BmGame.RCombatMove_VillainSimultaneousAttack.UpdateVecSpots");
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

    private static BmSDK.Function __fn_SetCounterInfo;
    /// <summary>
    /// Function: SetCounterInfo
    /// </summary>
    public unsafe virtual void SetCounterInfo(int CounterInfoIndex, bool bTrackUsage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCounterInfo, "BmGame.RCombatMove_VillainSimultaneousAttack.SetCounterInfo");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterInfoIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTrackUsage, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetSimultaneousCounterInfoScore;
    /// <summary>
    /// Function: GetSimultaneousCounterInfoScore
    /// </summary>
    public unsafe virtual int GetSimultaneousCounterInfoScore(BmSDK.BmGame.RPawnPlayerCombat.FSimultaneousCounterInfo TestCounter, bool bHasWeaponIH)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSimultaneousCounterInfoScore, "BmGame.RCombatMove_VillainSimultaneousAttack.GetSimultaneousCounterInfoScore");
        byte* paramsPtr = stackalloc byte[176];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestCounter, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHasWeaponIH, paramsPtr + 168);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 172);
    }

    private static BmSDK.Function __fn_GetCounterInfo;
    /// <summary>
    /// Function: GetCounterInfo
    /// </summary>
    public unsafe virtual int GetCounterInfo(BmSDK.BmGame.RPawnCombat.SimultaneousCounterAnimType FormationType, BmSDK.BmGame.RPawnCombat.SimultaneousCounterBehaviourType BehaviourType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterInfo, "BmGame.RCombatMove_VillainSimultaneousAttack.GetCounterInfo");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FormationType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourType, paramsPtr + 1);
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

    /// <summary>
    /// Struct: FIndexDistArray
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FIndexDistArray
    {
        /// <summary>
        /// ArrayProperty: IndexArray
        /// </summary>
        public unsafe BmSDK.TArray<int> IndexArray
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: DistArray
        /// </summary>
        public unsafe BmSDK.TArray<float> DistArray
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FVillainInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial record struct FVillainInfo
    {
        /// <summary>
        /// ObjectProperty: Pawn
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnVillain Pawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bTrackTarget
        /// </summary>
        public unsafe bool bTrackTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bCanCounter
        /// </summary>
        public unsafe bool bCanCounter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bCountered
        /// </summary>
        public unsafe bool bCountered
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bGrabbed
        /// </summary>
        public unsafe bool bGrabbed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: AnimId
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId AnimId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: InitStrikeDir
        /// </summary>
        public unsafe System.Numerics.Vector3 InitStrikeDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: LastTransitionRotation
        /// </summary>
        public unsafe float LastTransitionRotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bRagdolled
        /// </summary>
        public unsafe bool bRagdolled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: VecSpot
        /// </summary>
        public unsafe int VecSpot
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: AttackDelay
        /// </summary>
        public unsafe float AttackDelay
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: bAttackStarted
        /// </summary>
        public unsafe bool bAttackStarted
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// NameProperty: ImpactBone
        /// </summary>
        public unsafe BmSDK.FName ImpactBone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: GetInPositionTime
        /// </summary>
        public unsafe float GetInPositionTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bInPosition
        /// </summary>
        public unsafe bool bInPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: bCriticaled
        /// </summary>
        public unsafe bool bCriticaled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: bCriticalAttack
        /// </summary>
        public unsafe bool bCriticalAttack
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: Target
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat Target
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ObjectProperty: RelativeCounterPosActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor RelativeCounterPosActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ObjectProperty: RelativeFirstTransitionActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor RelativeFirstTransitionActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// StructProperty: BatmanAnimID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId BatmanAnimID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 800);

    /// <summary>
    /// IntProperty: NumCountered
    /// </summary>
    public unsafe int NumCountered
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// StructProperty: RelativeCounterLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RelativeCounterLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 808);

    /// <summary>
    /// StructProperty: CounterRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator CounterRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 820);

    /// <summary>
    /// FloatProperty: DamageAmount
    /// </summary>
    public unsafe float DamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// FloatProperty: DmgImpulseVal
    /// </summary>
    public unsafe float DmgImpulseVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// StructProperty: SCInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayerCombat.FSimultaneousCounterInfo SCInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayerCombat.FSimultaneousCounterInfo>(Ptr + 840);

    /// <summary>
    /// NameProperty: VillainStrikeBone
    /// </summary>
    public unsafe BmSDK.FName VillainStrikeBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ArrayProperty: VillainsWhoHitBatman
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat> VillainsWhoHitBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ArrayProperty: FormationVecList
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> FormationVecList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// StructProperty: RelativeFirstTransitionLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RelativeFirstTransitionLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1048);

    /// <summary>
    /// BoolProperty: bAllowNextStrike
    /// </summary>
    public unsafe bool bAllowNextStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bAllowMovementExit
    /// </summary>
    public unsafe bool bAllowMovementExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bCounterPromptOn
    /// </summary>
    public unsafe bool bCounterPromptOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bHitPlayer
    /// </summary>
    public unsafe bool bHitPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bHitPerfectStrike
    /// </summary>
    public unsafe bool bHitPerfectStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bSlowMo
    /// </summary>
    public unsafe bool bSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bOverridenBySpecialMove
    /// </summary>
    public unsafe bool bOverridenBySpecialMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bThrow
    /// </summary>
    public unsafe bool bThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bShouldKill
    /// </summary>
    public unsafe bool bShouldKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bCameraPlayed
    /// </summary>
    public unsafe bool bCameraPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bWasWeaponIH
    /// </summary>
    public unsafe bool bWasWeaponIH
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bPotentialFinalBlow
    /// </summary>
    public unsafe bool bPotentialFinalBlow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bUsingJokerHallucination
    /// </summary>
    public unsafe bool bUsingJokerHallucination
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// FloatProperty: AttackTime
    /// </summary>
    public unsafe float AttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// FloatProperty: TransitionDurationScale
    /// </summary>
    public unsafe float TransitionDurationScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// IntProperty: NumInPosition
    /// </summary>
    public unsafe int NumInPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// FloatProperty: BatmanMoveTimer
    /// </summary>
    public unsafe float BatmanMoveTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// ArrayProperty: SlowMoHitTimes
    /// </summary>
    public unsafe BmSDK.TArray<float> SlowMoHitTimes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// FloatProperty: CounterTime
    /// </summary>
    public unsafe float CounterTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// IntProperty: NumCounterHits
    /// </summary>
    public unsafe int NumCounterHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// IntProperty: CurrCounterHit
    /// </summary>
    public unsafe int CurrCounterHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// FloatProperty: TimeDualPlayQueued
    /// </summary>
    public unsafe float TimeDualPlayQueued
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// StructProperty: ImpactScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 1112);

    /// <summary>
    /// ByteProperty: Formation
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat.SimultaneousCounterAnimType Formation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.SimultaneousCounterAnimType>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// ByteProperty: PawnBehaviourType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat.SimultaneousCounterBehaviourType PawnBehaviourType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.SimultaneousCounterBehaviourType>(Ptr + 1269); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1269); }
    }

    /// <summary>
    /// ArrayProperty: VillainList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCombatMove_VillainSimultaneousAttack.FVillainInfo> VillainList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCombatMove_VillainSimultaneousAttack.FVillainInfo>>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// FloatProperty: TrackingRangeSq
    /// </summary>
    public unsafe float TrackingRangeSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: JokerHallucinationFovModifier
    /// </summary>
    public unsafe float JokerHallucinationFovModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }
}
