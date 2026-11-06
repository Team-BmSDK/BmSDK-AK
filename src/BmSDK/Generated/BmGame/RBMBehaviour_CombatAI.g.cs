#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_CombatAI<br/>
/// (size = 1020)
/// (flags = 134226066)
/// </summary>
public partial class RBMBehaviour_CombatAI : BmSDK.BmGame.RBMBehaviour_Combat, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_CombatAI", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMBehaviour_CombatAI.
    /// </summary>
    public static RBMBehaviour_CombatAI DefaultObject => (RBMBehaviour_CombatAI)StaticClass().DefaultObject;

    internal RBMBehaviour_CombatAI() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_CombatAI
    /// </summary>
    public RBMBehaviour_CombatAI(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_CombatAI Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_CombatAI(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_CombatAI>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_CombatAI>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_CombatAI>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_CombatAI>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_CombatAI>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_CombatAI>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_CombatAI>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_CombatAI>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_RepelledAttacker;
    /// <summary>
    /// Function: RepelledAttacker
    /// </summary>
    public unsafe override void RepelledAttacker(BmSDK.BmGame.RPawnCombat Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RepelledAttacker, "BmGame.RBMBehaviour_CombatAI.RepelledAttacker");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanRepel;
    /// <summary>
    /// Function: CanRepel
    /// </summary>
    public unsafe override bool CanRepel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanRepel, "BmGame.RBMBehaviour_CombatAI.CanRepel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSimultaneousAttackAnimName;
    /// <summary>
    /// Function: GetSimultaneousAttackAnimName
    /// </summary>
    public unsafe override BmSDK.FName GetSimultaneousAttackAnimName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSimultaneousAttackAnimName, "BmGame.RBMBehaviour_CombatAI.GetSimultaneousAttackAnimName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TargetActorChanged;
    /// <summary>
    /// Function: TargetActorChanged
    /// </summary>
    public unsafe override void TargetActorChanged(BmSDK.Engine.Actor NewTargetActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargetActorChanged, "BmGame.RBMBehaviour_CombatAI.TargetActorChanged");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTargetActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSpawnMove;
    /// <summary>
    /// Function: OnSpawnMove
    /// </summary>
    public unsafe override void OnSpawnMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSpawnMove, "BmGame.RBMBehaviour_CombatAI.OnSpawnMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPossibleMoves;
    /// <summary>
    /// Function: GetPossibleMoves
    /// </summary>
    public unsafe override void GetPossibleMoves(out BmSDK.TArray<BmSDK.Class> PossibleMoves)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPossibleMoves, "BmGame.RBMBehaviour_CombatAI.GetPossibleMoves");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PossibleMoves = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Class>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetClashPriority;
    /// <summary>
    /// Function: GetClashPriority
    /// </summary>
    public unsafe virtual int GetClashPriority()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClashPriority, "BmGame.RBMBehaviour_CombatAI.GetClashPriority");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAttackPriority;
    /// <summary>
    /// Function: GetAttackPriority
    /// </summary>
    public unsafe override int GetAttackPriority(bool bForceAttack)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAttackPriority, "BmGame.RBMBehaviour_CombatAI.GetAttackPriority");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceAttack, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_BetweenCameraAndPlayer;
    /// <summary>
    /// Function: BetweenCameraAndPlayer
    /// </summary>
    public unsafe virtual bool BetweenCameraAndPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BetweenCameraAndPlayer, "BmGame.RBMBehaviour_CombatAI.BetweenCameraAndPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_GetBestPickup;
    /// <summary>
    /// Function: GetBestPickup
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject GetBestPickup(BmSDK.FName PickupMoveStance, float CheckDist, bool bTaunting)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestPickup, "BmGame.RBMBehaviour_CombatAI.GetBestPickup");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PickupMoveStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDist, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTaunting, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetBestCombatPoint;
    /// <summary>
    /// Function: GetBestCombatPoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatPoint GetBestCombatPoint(bool bTaunting)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestCombatPoint, "BmGame.RBMBehaviour_CombatAI.GetBestCombatPoint");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTaunting, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatPoint>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UseBestCombatPointOrPickup;
    /// <summary>
    /// Function: UseBestCombatPointOrPickup
    /// </summary>
    public unsafe virtual bool UseBestCombatPointOrPickup(BmSDK.FName PickupMoveStance, bool bTaunting)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UseBestCombatPointOrPickup, "BmGame.RBMBehaviour_CombatAI.UseBestCombatPointOrPickup");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PickupMoveStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTaunting, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SpawnPickupWeaponMove;
    /// <summary>
    /// Function: SpawnPickupWeaponMove
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RCombatMove_VillainPickupWeapon SpawnPickupWeaponMove(BmSDK.BmGame.RBMCombatThrownObject WeaponToPickup)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnPickupWeaponMove, "BmGame.RBMBehaviour_CombatAI.SpawnPickupWeaponMove");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponToPickup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCombatMove_VillainPickupWeapon>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SpawnChargeUpMove;
    /// <summary>
    /// Function: SpawnChargeUpMove
    /// </summary>
    public unsafe virtual void SpawnChargeUpMove(BmSDK.BmGame.RPawnVillain ChargeUpVillain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnChargeUpMove, "BmGame.RBMBehaviour_CombatAI.SpawnChargeUpMove");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChargeUpVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToFindThugToChargeUp;
    /// <summary>
    /// Function: TryToFindThugToChargeUp
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain TryToFindThugToChargeUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToFindThugToChargeUp, "BmGame.RBMBehaviour_CombatAI.TryToFindThugToChargeUp");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnReviveMove;
    /// <summary>
    /// Function: SpawnReviveMove
    /// </summary>
    public unsafe virtual void SpawnReviveMove(BmSDK.BmGame.RPawnVillain BestCasualty)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnReviveMove, "BmGame.RBMBehaviour_CombatAI.SpawnReviveMove");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestCasualty, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToFindCasualtyToRevive;
    /// <summary>
    /// Function: TryToFindCasualtyToRevive
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain TryToFindCasualtyToRevive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToFindCasualtyToRevive, "BmGame.RBMBehaviour_CombatAI.TryToFindCasualtyToRevive");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetTickIsDisabled;
    /// <summary>
    /// Function: SetTickIsDisabled
    /// </summary>
    public unsafe override void SetTickIsDisabled(bool bInDisabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTickIsDisabled, "BmGame.RBMBehaviour_CombatAI.SetTickIsDisabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInDisabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateVisionCheck;
    /// <summary>
    /// Function: UpdateVisionCheck
    /// </summary>
    public unsafe virtual bool UpdateVisionCheck(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateVisionCheck, "BmGame.RBMBehaviour_CombatAI.UpdateVisionCheck");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StartPathFindToSafety;
    /// <summary>
    /// Function: StartPathFindToSafety
    /// </summary>
    public unsafe virtual void StartPathFindToSafety()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartPathFindToSafety, "BmGame.RBMBehaviour_CombatAI.StartPathFindToSafety");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FastChangeToTauntPose;
    /// <summary>
    /// Function: FastChangeToTauntPose
    /// </summary>
    public unsafe virtual void FastChangeToTauntPose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FastChangeToTauntPose, "BmGame.RBMBehaviour_CombatAI.FastChangeToTauntPose");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsActorSafe;
    /// <summary>
    /// Function: IsActorSafe
    /// </summary>
    public unsafe virtual bool IsActorSafe(BmSDK.Engine.Actor A)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsActorSafe, "BmGame.RBMBehaviour_CombatAI.IsActorSafe");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_StartMoveToGuardEmptyBatmobilePathSearch;
    /// <summary>
    /// Function: StartMoveToGuardEmptyBatmobilePathSearch
    /// </summary>
    public unsafe virtual bool StartMoveToGuardEmptyBatmobilePathSearch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartMoveToGuardEmptyBatmobilePathSearch, "BmGame.RBMBehaviour_CombatAI.StartMoveToGuardEmptyBatmobilePathSearch");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGuardEmptyBatmobilePoint;
    /// <summary>
    /// Function: GetGuardEmptyBatmobilePoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGuardEmptyBatmobilePoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGuardEmptyBatmobilePoint, "BmGame.RBMBehaviour_CombatAI.GetGuardEmptyBatmobilePoint");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBackPedalPoint;
    /// <summary>
    /// Function: GetBackPedalPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetBackPedalPoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBackPedalPoint, "BmGame.RBMBehaviour_CombatAI.GetBackPedalPoint");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetupBackpedal;
    /// <summary>
    /// Function: SetupBackpedal
    /// </summary>
    public unsafe virtual void SetupBackpedal()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupBackpedal, "BmGame.RBMBehaviour_CombatAI.SetupBackpedal");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldGuardEmptyBatmobile;
    /// <summary>
    /// Function: ShouldGuardEmptyBatmobile
    /// </summary>
    public unsafe override bool ShouldGuardEmptyBatmobile()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldGuardEmptyBatmobile, "BmGame.RBMBehaviour_CombatAI.ShouldGuardEmptyBatmobile");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldThrowGrenadesAtBatmobile;
    /// <summary>
    /// Function: ShouldThrowGrenadesAtBatmobile
    /// </summary>
    public unsafe virtual bool ShouldThrowGrenadesAtBatmobile()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldThrowGrenadesAtBatmobile, "BmGame.RBMBehaviour_CombatAI.ShouldThrowGrenadesAtBatmobile");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldRetreatFromBatmobile;
    /// <summary>
    /// Function: ShouldRetreatFromBatmobile
    /// </summary>
    public unsafe virtual bool ShouldRetreatFromBatmobile()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldRetreatFromBatmobile, "BmGame.RBMBehaviour_CombatAI.ShouldRetreatFromBatmobile");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldReactToCombatEvent;
    /// <summary>
    /// Function: ShouldReactToCombatEvent
    /// </summary>
    public unsafe virtual bool ShouldReactToCombatEvent(System.Numerics.Vector3 ReactLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldReactToCombatEvent, "BmGame.RBMBehaviour_CombatAI.ShouldReactToCombatEvent");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReactLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ShouldTryAndPathToCombat;
    /// <summary>
    /// Function: ShouldTryAndPathToCombat
    /// </summary>
    public unsafe virtual bool ShouldTryAndPathToCombat(BmSDK.Engine.Actor CombatTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldTryAndPathToCombat, "BmGame.RBMBehaviour_CombatAI.ShouldTryAndPathToCombat");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AwareOfPlayer;
    /// <summary>
    /// Function: AwareOfPlayer
    /// </summary>
    public unsafe override bool AwareOfPlayer(BmSDK.Engine.Actor Player, BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwareOfPlayer, "BmGame.RBMBehaviour_CombatAI.AwareOfPlayer");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_MoveInForceDir;
    /// <summary>
    /// Function: MoveInForceDir
    /// </summary>
    public unsafe virtual void MoveInForceDir(System.Numerics.Vector3 MoveVector)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveInForceDir, "BmGame.RBMBehaviour_CombatAI.MoveInForceDir");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveVector, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsCurrentCombatantWhileTaunting;
    /// <summary>
    /// Function: IsCurrentCombatantWhileTaunting
    /// </summary>
    public unsafe virtual bool IsCurrentCombatantWhileTaunting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCurrentCombatantWhileTaunting, "BmGame.RBMBehaviour_CombatAI.IsCurrentCombatantWhileTaunting");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TargetMustBeReachable;
    /// <summary>
    /// Function: TargetMustBeReachable
    /// </summary>
    public unsafe virtual bool TargetMustBeReachable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargetMustBeReachable, "BmGame.RBMBehaviour_CombatAI.TargetMustBeReachable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckRunToCombatLocationIsSafe;
    /// <summary>
    /// Function: CheckRunToCombatLocationIsSafe
    /// </summary>
    public unsafe virtual bool CheckRunToCombatLocationIsSafe(bool bCheckForReachability, out System.Numerics.Vector3 LastSafeTargetLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckRunToCombatLocationIsSafe, "BmGame.RBMBehaviour_CombatAI.CheckRunToCombatLocationIsSafe");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckForReachability, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out LastSafeTargetLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LastSafeTargetLocation, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        LastSafeTargetLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetRunToCombatLocation;
    /// <summary>
    /// Function: GetRunToCombatLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRunToCombatLocation(bool bCheap = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRunToCombatLocation, "BmGame.RBMBehaviour_CombatAI.GetRunToCombatLocation");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetRunToCombatOffset;
    /// <summary>
    /// Function: SetRunToCombatOffset
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 SetRunToCombatOffset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRunToCombatOffset, "BmGame.RBMBehaviour_CombatAI.SetRunToCombatOffset");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldMirrorTauntStates;
    /// <summary>
    /// Function: ShouldMirrorTauntStates
    /// </summary>
    public unsafe virtual bool ShouldMirrorTauntStates()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldMirrorTauntStates, "BmGame.RBMBehaviour_CombatAI.ShouldMirrorTauntStates");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MoveInDirection;
    /// <summary>
    /// Function: MoveInDirection
    /// </summary>
    public unsafe virtual void MoveInDirection(System.Numerics.Vector3 MoveDirection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveInDirection, "BmGame.RBMBehaviour_CombatAI.MoveInDirection");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDirection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PathToCombatNotFound;
    /// <summary>
    /// Function: PathToCombatNotFound
    /// </summary>
    public unsafe virtual void PathToCombatNotFound(BmSDK.BmGame.RNavigationHandle Nav)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathToCombatNotFound, "BmGame.RBMBehaviour_CombatAI.PathToCombatNotFound");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Nav, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveToCombatRepath;
    /// <summary>
    /// Function: MoveToCombatRepath
    /// </summary>
    public unsafe virtual void MoveToCombatRepath()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveToCombatRepath, "BmGame.RBMBehaviour_CombatAI.MoveToCombatRepath");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartMoveToCombatPathSearch;
    /// <summary>
    /// Function: StartMoveToCombatPathSearch
    /// </summary>
    public unsafe virtual void StartMoveToCombatPathSearch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartMoveToCombatPathSearch, "BmGame.RBMBehaviour_CombatAI.StartMoveToCombatPathSearch");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanClimbWhileRouting;
    /// <summary>
    /// Function: CanClimbWhileRouting
    /// </summary>
    public unsafe virtual bool CanClimbWhileRouting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanClimbWhileRouting, "BmGame.RBMBehaviour_CombatAI.CanClimbWhileRouting");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GotoCombatState;
    /// <summary>
    /// Function: GotoCombatState
    /// </summary>
    public unsafe virtual void GotoCombatState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoCombatState, "BmGame.RBMBehaviour_CombatAI.GotoCombatState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoMoveToCombatState;
    /// <summary>
    /// Function: GotoMoveToCombatState
    /// </summary>
    public unsafe virtual void GotoMoveToCombatState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoMoveToCombatState, "BmGame.RBMBehaviour_CombatAI.GotoMoveToCombatState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessTargetPawnInDanger;
    /// <summary>
    /// Function: ProcessTargetPawnInDanger
    /// </summary>
    public unsafe virtual void ProcessTargetPawnInDanger()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessTargetPawnInDanger, "BmGame.RBMBehaviour_CombatAI.ProcessTargetPawnInDanger");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlayBark;
    /// <summary>
    /// Function: CanPlayBark
    /// </summary>
    public unsafe override bool CanPlayBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayBark, "BmGame.RBMBehaviour_CombatAI.CanPlayBark");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ProcessTauntAnims;
    /// <summary>
    /// Function: ProcessTauntAnims
    /// </summary>
    public unsafe virtual void ProcessTauntAnims(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessTauntAnims, "BmGame.RBMBehaviour_CombatAI.ProcessTauntAnims");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanThrowProjectileAtTarget;
    /// <summary>
    /// Function: CanThrowProjectileAtTarget
    /// </summary>
    public unsafe virtual bool CanThrowProjectileAtTarget(BmSDK.Engine.Actor CombatTargetActor, bool bGrenade, bool bHalveTimeCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanThrowProjectileAtTarget, "BmGame.RBMBehaviour_CombatAI.CanThrowProjectileAtTarget");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatTargetActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGrenade, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHalveTimeCheck, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_TargetIsInterrogating;
    /// <summary>
    /// Function: TargetIsInterrogating
    /// </summary>
    public unsafe override bool TargetIsInterrogating()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargetIsInterrogating, "BmGame.RBMBehaviour_CombatAI.TargetIsInterrogating");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnStampOnFingersMove;
    /// <summary>
    /// Function: SpawnStampOnFingersMove
    /// </summary>
    public unsafe virtual void SpawnStampOnFingersMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnStampOnFingersMove, "BmGame.RBMBehaviour_CombatAI.SpawnStampOnFingersMove");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanStampOnFingers;
    /// <summary>
    /// Function: CanStampOnFingers
    /// </summary>
    public unsafe virtual bool CanStampOnFingers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanStampOnFingers, "BmGame.RBMBehaviour_CombatAI.CanStampOnFingers");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnThrowGrenadeAtBatmobileMove;
    /// <summary>
    /// Function: SpawnThrowGrenadeAtBatmobileMove
    /// </summary>
    public unsafe virtual void SpawnThrowGrenadeAtBatmobileMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnThrowGrenadeAtBatmobileMove, "BmGame.RBMBehaviour_CombatAI.SpawnThrowGrenadeAtBatmobileMove");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnThrowBrickMove;
    /// <summary>
    /// Function: SpawnThrowBrickMove
    /// </summary>
    public unsafe virtual void SpawnThrowBrickMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnThrowBrickMove, "BmGame.RBMBehaviour_CombatAI.SpawnThrowBrickMove");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWaitForCombatMovementForce;
    /// <summary>
    /// Function: GetWaitForCombatMovementForce
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetWaitForCombatMovementForce()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWaitForCombatMovementForce, "BmGame.RBMBehaviour_CombatAI.GetWaitForCombatMovementForce");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMovementSpeed;
    /// <summary>
    /// Function: GetMovementSpeed
    /// </summary>
    public unsafe virtual BmSDK.Engine.RAutomaticTransitions.EMovementSpeed GetMovementSpeed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMovementSpeed, "BmGame.RBMBehaviour_CombatAI.GetMovementSpeed");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.RAutomaticTransitions.EMovementSpeed>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetThoughts;
    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe override void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmGame.RBMBehaviour_CombatAI.GetThoughts");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_EnterCombatMoveState;
    /// <summary>
    /// Function: EnterCombatMoveState
    /// </summary>
    public unsafe virtual void EnterCombatMoveState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterCombatMoveState, "BmGame.RBMBehaviour_CombatAI.EnterCombatMoveState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanChangeTarget;
    /// <summary>
    /// Function: CanChangeTarget
    /// </summary>
    public unsafe virtual bool CanChangeTarget(BmSDK.BmGame.RPawnPlayerCombat TestTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanChangeTarget, "BmGame.RBMBehaviour_CombatAI.CanChangeTarget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanShovePawns;
    /// <summary>
    /// Function: CanShovePawns
    /// </summary>
    public unsafe override bool CanShovePawns()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanShovePawns, "BmGame.RBMBehaviour_CombatAI.CanShovePawns");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnThugShovedMove;
    /// <summary>
    /// Function: SpawnThugShovedMove
    /// </summary>
    public unsafe virtual bool SpawnThugShovedMove(System.Numerics.Vector3 ShovedVelocity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnThugShovedMove, "BmGame.RBMBehaviour_CombatAI.SpawnThugShovedMove");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShovedVelocity, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SpawnThugPushedIntoThugMove;
    /// <summary>
    /// Function: SpawnThugPushedIntoThugMove
    /// </summary>
    public unsafe virtual bool SpawnThugPushedIntoThugMove(BmSDK.BmGame.RPawnVillain TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnThugPushedIntoThugMove, "BmGame.RBMBehaviour_CombatAI.SpawnThugPushedIntoThugMove");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UpdateThugPushedIntoThug;
    /// <summary>
    /// Function: UpdateThugPushedIntoThug
    /// </summary>
    public unsafe virtual bool UpdateThugPushedIntoThug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateThugPushedIntoThug, "BmGame.RBMBehaviour_CombatAI.UpdateThugPushedIntoThug");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdatePushThug;
    /// <summary>
    /// Function: UpdatePushThug
    /// </summary>
    public unsafe virtual bool UpdatePushThug(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePushThug, "BmGame.RBMBehaviour_CombatAI.UpdatePushThug");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DoVisionChecks;
    /// <summary>
    /// Function: DoVisionChecks
    /// </summary>
    public unsafe virtual bool DoVisionChecks()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoVisionChecks, "BmGame.RBMBehaviour_CombatAI.DoVisionChecks");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetRotationAndVelocity;
    /// <summary>
    /// Function: SetRotationAndVelocity
    /// </summary>
    public unsafe virtual void SetRotationAndVelocity(float DeltaTime, System.Numerics.Vector3 DestVelocity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRotationAndVelocity, "BmGame.RBMBehaviour_CombatAI.SetRotationAndVelocity");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestVelocity, paramsPtr + 4);
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

    private static BmSDK.Function __fn_CanPlayIdleOverlay;
    /// <summary>
    /// Function: CanPlayIdleOverlay
    /// </summary>
    public unsafe virtual bool CanPlayIdleOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayIdleOverlay, "BmGame.RBMBehaviour_CombatAI.CanPlayIdleOverlay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayTurnStep;
    /// <summary>
    /// Function: PlayTurnStep
    /// </summary>
    public unsafe virtual void PlayTurnStep(System.Numerics.Vector3 TargetHeading, bool bForce = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayTurnStep, "BmGame.RBMBehaviour_CombatAI.PlayTurnStep");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetHeading, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayStepInDirection;
    /// <summary>
    /// Function: PlayStepInDirection
    /// </summary>
    public unsafe virtual void PlayStepInDirection(System.Numerics.Vector3 MoveDir, System.Numerics.Vector3 FrontDir, float MoveSize, float ForceSize, float MoveAmnt)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayStepInDirection, "BmGame.RBMBehaviour_CombatAI.PlayStepInDirection");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FrontDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveSize, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceSize, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveAmnt, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBestStepAnim;
    /// <summary>
    /// Function: GetBestStepAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetBestStepAnim(System.Numerics.Vector3 MoveDir, System.Numerics.Vector3 FrontDir, float ForceSize, float MoveSize, bool bForceLongSteps = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestStepAnim, "BmGame.RBMBehaviour_CombatAI.GetBestStepAnim");
        byte* paramsPtr = stackalloc byte[212];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FrontDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceSize, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveSize, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceLongSteps, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_UpdateRailing;
    /// <summary>
    /// Function: UpdateRailing
    /// </summary>
    public unsafe virtual void UpdateRailing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRailing, "BmGame.RBMBehaviour_CombatAI.UpdateRailing");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEvadeVehicleType;
    /// <summary>
    /// Function: GetEvadeVehicleType
    /// </summary>
    public unsafe override BmSDK.BmGame.RGameInfo.EEvadeVehicleType GetEvadeVehicleType(BmSDK.Engine.Actor V, float CarSpeed, bool bZap)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEvadeVehicleType, "BmGame.RBMBehaviour_CombatAI.GetEvadeVehicleType");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CarSpeed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bZap, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.EEvadeVehicleType>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CanStartAttacking;
    /// <summary>
    /// Function: CanStartAttacking
    /// </summary>
    public unsafe override bool CanStartAttacking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanStartAttacking, "BmGame.RBMBehaviour_CombatAI.CanStartAttacking");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldUseEnvironment;
    /// <summary>
    /// Function: ShouldUseEnvironment
    /// </summary>
    public unsafe virtual bool ShouldUseEnvironment(float DeltaTime, bool bForceCheck)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldUseEnvironment, "BmGame.RBMBehaviour_CombatAI.ShouldUseEnvironment");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceCheck, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanDodgeProjectile;
    /// <summary>
    /// Function: CanDodgeProjectile
    /// </summary>
    public unsafe override bool CanDodgeProjectile(System.Numerics.Vector3 ThrownFromPos, int CheckBatarangID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDodgeProjectile, "BmGame.RBMBehaviour_CombatAI.CanDodgeProjectile");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckBatarangID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CanDodgeLineLaunchKick;
    /// <summary>
    /// Function: CanDodgeLineLaunchKick
    /// </summary>
    public unsafe override bool CanDodgeLineLaunchKick(BmSDK.BmGame.RPawnPlayer Attacker, System.Numerics.Vector3 KickDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDodgeLineLaunchKick, "BmGame.RBMBehaviour_CombatAI.CanDodgeLineLaunchKick");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KickDir, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ReEnterIdleAfterCombatMove;
    /// <summary>
    /// Function: ReEnterIdleAfterCombatMove
    /// </summary>
    public unsafe virtual bool ReEnterIdleAfterCombatMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReEnterIdleAfterCombatMove, "BmGame.RBMBehaviour_CombatAI.ReEnterIdleAfterCombatMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsCurrentCombatant;
    /// <summary>
    /// Function: IsCurrentCombatant
    /// </summary>
    public unsafe override bool IsCurrentCombatant()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCurrentCombatant, "BmGame.RBMBehaviour_CombatAI.IsCurrentCombatant");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnBeginInterrupt;
    /// <summary>
    /// Function: OnBeginInterrupt
    /// </summary>
    public unsafe override void OnBeginInterrupt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBeginInterrupt, "BmGame.RBMBehaviour_CombatAI.OnBeginInterrupt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UndeadCheck;
    /// <summary>
    /// Function: UndeadCheck
    /// </summary>
    public unsafe virtual void UndeadCheck()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UndeadCheck, "BmGame.RBMBehaviour_CombatAI.UndeadCheck");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDeactivate;
    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeactivate, "BmGame.RBMBehaviour_CombatAI.OnDeactivate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldStopDialogue;
    /// <summary>
    /// Function: ShouldStopDialogue
    /// </summary>
    public unsafe override bool ShouldStopDialogue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldStopDialogue, "BmGame.RBMBehaviour_CombatAI.ShouldStopDialogue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnActivate;
    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmGame.RBMBehaviour_CombatAI.OnActivate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: NoMoveReason
    /// </summary>
    public enum NoMoveReason : byte
    {
        NMR_None = 0,
        NMR_NoFloor = 1,
        NMR_Wall = 2,
        NMR_WaitForCollCheck = 3,
        NMR_MAX = 4,
    }

    /// <summary>
    /// FloatProperty: CombatPointCheckTime
    /// </summary>
    public unsafe float CombatPointCheckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// FloatProperty: CheckForCombatPointTimer
    /// </summary>
    public unsafe float CheckForCombatPointTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// FloatProperty: UseCombatPointChance
    /// </summary>
    public unsafe float UseCombatPointChance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bForceEnvCheck
    /// </summary>
    public unsafe bool bForceEnvCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bCanAttack
    /// </summary>
    public unsafe bool bCanAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bTauntAimAt
    /// </summary>
    public unsafe bool bTauntAimAt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bMovingWhileWaiting
    /// </summary>
    public unsafe bool bMovingWhileWaiting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bHasTurnSteps
    /// </summary>
    public unsafe bool bHasTurnSteps
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bHasSmallTurnSteps
    /// </summary>
    public unsafe bool bHasSmallTurnSteps
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bHasFrontStep
    /// </summary>
    public unsafe bool bHasFrontStep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bInitialisedMovement
    /// </summary>
    public unsafe bool bInitialisedMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bTriedDirectMoveTo
    /// </summary>
    public unsafe bool bTriedDirectMoveTo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bJustBeenInCombat
    /// </summary>
    public unsafe bool bJustBeenInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bReEnterIdleAfterCombatMove
    /// </summary>
    public unsafe bool bReEnterIdleAfterCombatMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bOnRailing
    /// </summary>
    public unsafe bool bOnRailing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bFailedToFindRocketLauncher
    /// </summary>
    public unsafe bool bFailedToFindRocketLauncher
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bChosenFirstState
    /// </summary>
    public unsafe bool bChosenFirstState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bForceCombatStanceWhileMovingToCombat
    /// </summary>
    public unsafe bool bForceCombatStanceWhileMovingToCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bCachedIsCurrentCombatant
    /// </summary>
    public unsafe bool bCachedIsCurrentCombatant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// FloatProperty: RetryTimer
    /// </summary>
    public unsafe float RetryTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// FloatProperty: VisionCheckTimer
    /// </summary>
    public unsafe float VisionCheckTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: LOSToTargetTime
    /// </summary>
    public unsafe float LOSToTargetTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceTauntStarted
    /// </summary>
    public unsafe float TimeSinceTauntStarted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// FloatProperty: NotInDangerTime
    /// </summary>
    public unsafe float NotInDangerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// StrProperty: NAR
    /// </summary>
    public unsafe BmSDK.FString NAR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// StructProperty: TauntID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId TauntID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 740);

    /// <summary>
    /// StructProperty: LastValidTauntAimAt
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastValidTauntAimAt
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 744);

    /// <summary>
    /// FloatProperty: TimeUntilTaunt
    /// </summary>
    public unsafe float TimeUntilTaunt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// StructProperty: StepTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId StepTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 760);

    /// <summary>
    /// FloatProperty: TimeUntilIdleOverlay
    /// </summary>
    public unsafe float TimeUntilIdleOverlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// StructProperty: LastMoveToDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastMoveToDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 768);

    /// <summary>
    /// ObjectProperty: GuardPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatArea_GuardPoint GuardPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatArea_GuardPoint>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: RoamPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor RoamPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: NavHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle NavHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: GameRepInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI GameRepInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: RetreatActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor RetreatActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: NMRHitActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor NMRHitActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: WeaponPickupSearch
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponPickupSearch WeaponPickupSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponPickupSearch>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// StructProperty: MoveWhileWaitingLargeForceDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MoveWhileWaitingLargeForceDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 836);

    /// <summary>
    /// StructProperty: RoamAnimID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId RoamAnimID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 848);

    /// <summary>
    /// FloatProperty: RoamTimer
    /// </summary>
    public unsafe float RoamTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// FloatProperty: RoamRadius
    /// </summary>
    public unsafe float RoamRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// FloatProperty: RoamTimeAfterSighting
    /// </summary>
    public unsafe float RoamTimeAfterSighting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// StructProperty: RailingMoveDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RailingMoveDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 864);

    /// <summary>
    /// FloatProperty: NotInBatmobileTime
    /// </summary>
    public unsafe float NotInBatmobileTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ArrayProperty: FailedRetreatPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> FailedRetreatPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// FloatProperty: PlayHideBarkTimer
    /// </summary>
    public unsafe float PlayHideBarkTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// FloatProperty: MinMoveAmount
    /// </summary>
    public unsafe float MinMoveAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// FloatProperty: MinMoveSpeedForce
    /// </summary>
    public unsafe float MinMoveSpeedForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// FloatProperty: MaxMoveSpeedForce
    /// </summary>
    public unsafe float MaxMoveSpeedForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ByteProperty: NMR
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour_CombatAI.NoMoveReason NMR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_CombatAI.NoMoveReason>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// StructProperty: NMRPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 NMRPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 916);

    /// <summary>
    /// FloatProperty: NMRHitTime
    /// </summary>
    public unsafe float NMRHitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// StructProperty: NMRPrevDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 NMRPrevDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 932);

    /// <summary>
    /// NameProperty: PostStasisState
    /// </summary>
    public unsafe BmSDK.FName PostStasisState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// StructProperty: RunToCombatOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RunToCombatOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 952);

    /// <summary>
    /// StructProperty: LastPlayerMoveToLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastPlayerMoveToLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 964);

    /// <summary>
    /// FloatProperty: LastLockDoorStateTime
    /// </summary>
    public unsafe float LastLockDoorStateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastPushCheck
    /// </summary>
    public unsafe float TimeSinceLastPushCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// FloatProperty: TurnThresholdCos
    /// </summary>
    public unsafe float TurnThresholdCos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// FloatProperty: NotUsingMoveToTime
    /// </summary>
    public unsafe float NotUsingMoveToTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: InitialIdleTime
    /// </summary>
    public unsafe float InitialIdleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// IntProperty: UseCachedIsCurrentCombatantFrames
    /// </summary>
    public unsafe int UseCachedIsCurrentCombatantFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// FloatProperty: LastBackpedalTime
    /// </summary>
    public unsafe float LastBackpedalTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// FloatProperty: NoGrenadeTime
    /// </summary>
    public unsafe float NoGrenadeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// StructProperty: GuardBatmobilePoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GuardBatmobilePoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1008);
}
