#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPawnVillainMultiStageBase<br/>
/// (size = 6800)
/// (flags = 144703671)
/// </summary>
public partial class RPawnVillainMultiStageBase : BmSDK.BmGame.RPawnVillain, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnVillainMultiStageBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillainMultiStageBase.
    /// </summary>
    public static RPawnVillainMultiStageBase DefaultObject => (RPawnVillainMultiStageBase)StaticClass().DefaultObject;

    internal RPawnVillainMultiStageBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainMultiStageBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStageBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStageBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStageBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStageBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStageBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStageBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStageBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStageBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetKnifeHitSound;
    /// <summary>
    /// Function: GetKnifeHitSound
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetKnifeHitSound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetKnifeHitSound, "BmGame.RPawnVillainMultiStageBase.GetKnifeHitSound");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFloorFreezeTime;
    /// <summary>
    /// Function: GetFloorFreezeTime
    /// </summary>
    public unsafe override float GetFloorFreezeTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFloorFreezeTime, "BmGame.RPawnVillainMultiStageBase.GetFloorFreezeTime");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFreezeTime;
    /// <summary>
    /// Function: GetFreezeTime
    /// </summary>
    public unsafe override float GetFreezeTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFreezeTime, "BmGame.RPawnVillainMultiStageBase.GetFreezeTime");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateWeapon;
    /// <summary>
    /// Function: CreateWeapon
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMWeapon CreateWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeapon, "BmGame.RPawnVillainMultiStageBase.CreateWeapon");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeapon>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFreezeBlastTorsoEffectScale;
    /// <summary>
    /// Function: GetFreezeBlastTorsoEffectScale
    /// </summary>
    public unsafe override float GetFreezeBlastTorsoEffectScale()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFreezeBlastTorsoEffectScale, "BmGame.RPawnVillainMultiStageBase.GetFreezeBlastTorsoEffectScale");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetWeaponFlag;
    /// <summary>
    /// Function: GetWeaponFlag
    /// </summary>
    public unsafe override BmSDK.FName GetWeaponFlag()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponFlag, "BmGame.RPawnVillainMultiStageBase.GetWeaponFlag");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHudWeaponType;
    /// <summary>
    /// Function: GetHudWeaponType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.EHudWeaponType GetHudWeaponType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHudWeaponType, "BmGame.RPawnVillainMultiStageBase.GetHudWeaponType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EHudWeaponType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TempDisableEFist;
    /// <summary>
    /// Function: TempDisableEFist
    /// </summary>
    public unsafe virtual void TempDisableEFist()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TempDisableEFist, "BmGame.RPawnVillainMultiStageBase.TempDisableEFist");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMultiWeaponXrays;
    /// <summary>
    /// Function: SetMultiWeaponXrays
    /// </summary>
    public unsafe virtual void SetMultiWeaponXrays()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMultiWeaponXrays, "BmGame.RPawnVillainMultiStageBase.SetMultiWeaponXrays");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsAwareOfPlayer;
    /// <summary>
    /// Function: IsAwareOfPlayer
    /// </summary>
    public unsafe override bool IsAwareOfPlayer(BmSDK.BmGame.RPawnPlayer PlayerPawn, BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAwareOfPlayer, "BmGame.RPawnVillainMultiStageBase.IsAwareOfPlayer");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetFallingTakedownAttackerAnimset;
    /// <summary>
    /// Function: GetFallingTakedownAttackerAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetFallingTakedownAttackerAnimset(BmSDK.BmGame.RPawnPlayer Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFallingTakedownAttackerAnimset, "BmGame.RPawnVillainMultiStageBase.GetFallingTakedownAttackerAnimset");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetFallingTakedownAnimset;
    /// <summary>
    /// Function: GetFallingTakedownAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetFallingTakedownAnimset(BmSDK.BmGame.RPawnPlayer Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFallingTakedownAnimset, "BmGame.RPawnVillainMultiStageBase.GetFallingTakedownAnimset");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetRightBladeFx;
    /// <summary>
    /// Function: SetRightBladeFx
    /// </summary>
    public unsafe virtual void SetRightBladeFx(bool bOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRightBladeFx, "BmGame.RPawnVillainMultiStageBase.SetRightBladeFx");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLeftBladeFx;
    /// <summary>
    /// Function: SetLeftBladeFx
    /// </summary>
    public unsafe virtual void SetLeftBladeFx(bool bOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLeftBladeFx, "BmGame.RPawnVillainMultiStageBase.SetLeftBladeFx");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFistFx;
    /// <summary>
    /// Function: SetFistFx
    /// </summary>
    public unsafe virtual void SetFistFx(bool bOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFistFx, "BmGame.RPawnVillainMultiStageBase.SetFistFx");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsDamageable;
    /// <summary>
    /// Function: IsDamageable
    /// </summary>
    public unsafe virtual bool IsDamageable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDamageable, "BmGame.RPawnVillainMultiStageBase.IsDamageable");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanShowStunStars;
    /// <summary>
    /// Function: CanShowStunStars
    /// </summary>
    public unsafe virtual bool CanShowStunStars()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanShowStunStars, "BmGame.RPawnVillainMultiStageBase.CanShowStunStars");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetHealth;
    /// <summary>
    /// Function: SetHealth
    /// </summary>
    public unsafe override void SetHealth()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealth, "BmGame.RPawnVillainMultiStageBase.SetHealth");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmGame.RPawnVillainMultiStageBase.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopBladeTrailR;
    /// <summary>
    /// Function: StopBladeTrailR
    /// </summary>
    public unsafe virtual void StopBladeTrailR()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopBladeTrailR, "BmGame.RPawnVillainMultiStageBase.StopBladeTrailR");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopBladeTrailL;
    /// <summary>
    /// Function: StopBladeTrailL
    /// </summary>
    public unsafe virtual void StopBladeTrailL()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopBladeTrailL, "BmGame.RPawnVillainMultiStageBase.StopBladeTrailL");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFistOn;
    /// <summary>
    /// Function: SetFistOn
    /// </summary>
    public unsafe virtual void SetFistOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFistOn, "BmGame.RPawnVillainMultiStageBase.SetFistOn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateXRayVisibility;
    /// <summary>
    /// Function: UpdateXRayVisibility
    /// </summary>
    public unsafe override void UpdateXRayVisibility(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateXRayVisibility, "BmGame.RPawnVillainMultiStageBase.UpdateXRayVisibility");
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

    private static BmSDK.Function __fn_GetThugStateScore;
    /// <summary>
    /// Function: GetThugStateScore
    /// </summary>
    public unsafe virtual int GetThugStateScore(int CheckState = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThugStateScore, "BmGame.RPawnVillainMultiStageBase.GetThugStateScore");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckState, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsPathClear;
    /// <summary>
    /// Function: IsPathClear
    /// </summary>
    public unsafe virtual bool IsPathClear(System.Numerics.Vector3 FromPoint, System.Numerics.Vector3 EndPoint, float Radius, out System.Numerics.Vector3 CollidePoint, out System.Numerics.Vector3 CollideNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPathClear, "BmGame.RPawnVillainMultiStageBase.IsPathClear");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPoint, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CollidePoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollidePoint, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CollideNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollideNormal, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CollidePoint = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 28);
        CollideNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_GetStateHitReactionAnimset;
    /// <summary>
    /// Function: GetStateHitReactionAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetStateHitReactionAnimset(BmSDK.BmGame.RPawnVillainMultiStageBase.EThugState NewThugState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStateHitReactionAnimset, "BmGame.RPawnVillainMultiStageBase.GetStateHitReactionAnimset");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewThugState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetAerialJumpOnTargetAnimName;
    /// <summary>
    /// Function: GetAerialJumpOnTargetAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetAerialJumpOnTargetAnimName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAerialJumpOnTargetAnimName, "BmGame.RPawnVillainMultiStageBase.GetAerialJumpOnTargetAnimName");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetThrowThugAttackClass;
    /// <summary>
    /// Function: GetThrowThugAttackClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetThrowThugAttackClass()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThrowThugAttackClass, "BmGame.RPawnVillainMultiStageBase.GetThrowThugAttackClass");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBlockAnimset;
    /// <summary>
    /// Function: GetBlockAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetBlockAnimset(BmSDK.BmGame.RPawnVillainMultiStageBase.EThugState BlockState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBlockAnimset, "BmGame.RPawnVillainMultiStageBase.GetBlockAnimset");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlockState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_EFistHitTarget;
    /// <summary>
    /// Function: EFistHitTarget
    /// </summary>
    public unsafe virtual void EFistHitTarget(BmSDK.FName DamageBone)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EFistHitTarget, "BmGame.RPawnVillainMultiStageBase.EFistHitTarget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageBone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPossibleMoves;
    /// <summary>
    /// Function: GetPossibleMoves
    /// </summary>
    public unsafe virtual void GetPossibleMoves(out BmSDK.TArray<BmSDK.Class> PossibleMoves, BmSDK.BmGame.RPawnVillainMultiStageBase.EThugState CurrThugState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPossibleMoves, "BmGame.RPawnVillainMultiStageBase.GetPossibleMoves");
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrThugState, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PossibleMoves = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetArmour;
    /// <summary>
    /// Function: SetArmour
    /// </summary>
    public unsafe virtual void SetArmour(bool bOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetArmour, "BmGame.RPawnVillainMultiStageBase.SetArmour");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: EThugState
    /// </summary>
    public enum EThugState : byte
    {
        ETS_EFist = 0,
        ETS_Shield = 1,
        ETS_Armoured = 2,
        ETS_Blade = 3,
        ETS_Max = 4,
    }

    /// <summary>
    /// ComponentProperty: FistFxCompLeft
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FistFxCompLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6664); }
    }

    /// <summary>
    /// ComponentProperty: FistFxCompRight
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FistFxCompRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6672); }
    }

    /// <summary>
    /// ObjectProperty: FistFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem FistFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 6680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6680); }
    }

    /// <summary>
    /// ObjectProperty: BladeFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem BladeFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 6688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6688); }
    }

    /// <summary>
    /// ObjectProperty: EFAudible
    /// </summary>
    public unsafe BmSDK.Engine.RAkAudible EFAudible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAkAudible>(Ptr + 6696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6696); }
    }

    /// <summary>
    /// ObjectProperty: EFistLoopingEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent EFistLoopingEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6704); }
    }

    /// <summary>
    /// ObjectProperty: LastFoundThugToThrow
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain LastFoundThugToThrow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 6712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6712); }
    }

    /// <summary>
    /// ObjectProperty: WeaponXrayMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant WeaponXrayMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6720); }
    }

    /// <summary>
    /// ComponentProperty: BladeFxCompRight
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BladeFxCompRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6728); }
    }

    /// <summary>
    /// ComponentProperty: BladeFxCompLeft
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BladeFxCompLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6736); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastWeaponChange
    /// </summary>
    public unsafe float TimeSinceLastWeaponChange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6744); }
    }

    /// <summary>
    /// BoolProperty: bFistFxOn
    /// </summary>
    public unsafe bool bFistFxOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6748); }
    }

    /// <summary>
    /// BoolProperty: bLeftBladeFxOn
    /// </summary>
    public unsafe bool bLeftBladeFxOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6748); }
    }

    /// <summary>
    /// BoolProperty: bRightBladeFxOn
    /// </summary>
    public unsafe bool bRightBladeFxOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6748); }
    }

    /// <summary>
    /// BoolProperty: bQueueChangeState
    /// </summary>
    public unsafe bool bQueueChangeState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6748); }
    }

    /// <summary>
    /// BoolProperty: bInvincible
    /// </summary>
    public unsafe bool bInvincible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6748); }
    }

    /// <summary>
    /// BoolProperty: bTutorial
    /// </summary>
    public unsafe bool bTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6748); }
    }

    /// <summary>
    /// IntProperty: NumTimesHit
    /// </summary>
    public unsafe int NumTimesHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6752); }
    }

    /// <summary>
    /// IntProperty: MaxHits
    /// </summary>
    public unsafe int MaxHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6756); }
    }

    /// <summary>
    /// ByteProperty: ThugState
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillainMultiStageBase.EThugState ThugState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillainMultiStageBase.EThugState>(Ptr + 6760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6760); }
    }

    /// <summary>
    /// ArrayProperty: AllowedStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillainMultiStageBase.EThugState> AllowedStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillainMultiStageBase.EThugState>>(Ptr + 6764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6764); }
    }

    /// <summary>
    /// ArrayProperty: TempThugStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillainMultiStageBase.EThugState> TempThugStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillainMultiStageBase.EThugState>>(Ptr + 6780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6780); }
    }

    /// <summary>
    /// IntProperty: NumStrikes
    /// </summary>
    public unsafe int NumStrikes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6796); }
    }
}
