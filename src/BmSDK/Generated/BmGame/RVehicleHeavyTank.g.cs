#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleHeavyTank<br/>
/// (size = 8728)
/// (flags = 144704182)
/// </summary>
public partial class RVehicleHeavyTank : BmSDK.BmGame.RVehicleTank, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleHeavyTank", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RVehicleHeavyTank.
    /// </summary>
    public static RVehicleHeavyTank DefaultObject => (RVehicleHeavyTank)StaticClass().DefaultObject;

    internal RVehicleHeavyTank() { }

    /// <summary>
    /// Constructs a new RVehicleHeavyTank
    /// </summary>
    public RVehicleHeavyTank(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleHeavyTank(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_NoReplanBackToIsland;
    /// <summary>
    /// Function: NoReplanBackToIsland
    /// </summary>
    public unsafe virtual void NoReplanBackToIsland()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NoReplanBackToIsland, "BmGame.RVehicleHeavyTank.NoReplanBackToIsland");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeathExplosionRumble;
    /// <summary>
    /// Function: DeathExplosionRumble
    /// </summary>
    public unsafe override void DeathExplosionRumble()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeathExplosionRumble, "BmGame.RVehicleHeavyTank.DeathExplosionRumble");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBasePawn, "BmGame.RVehicleHeavyTank.CanBasePawn");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UnBlind;
    /// <summary>
    /// Function: UnBlind
    /// </summary>
    public unsafe override void UnBlind()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnBlind, "BmGame.RVehicleHeavyTank.UnBlind");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Blind;
    /// <summary>
    /// Function: Blind
    /// </summary>
    public unsafe override void Blind(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Blind, "BmGame.RVehicleHeavyTank.Blind");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateAttackWarningModifier;
    /// <summary>
    /// Function: UpdateAttackWarningModifier
    /// </summary>
    public unsafe override void UpdateAttackWarningModifier()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAttackWarningModifier, "BmGame.RVehicleHeavyTank.UpdateAttackWarningModifier");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLockedOntoPlayer;
    /// <summary>
    /// Function: SetLockedOntoPlayer
    /// </summary>
    public unsafe virtual void SetLockedOntoPlayer(bool LockedOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLockedOntoPlayer, "BmGame.RVehicleHeavyTank.SetLockedOntoPlayer");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LockedOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugDestroyAllWeakPoints;
    /// <summary>
    /// Function: DebugDestroyAllWeakPoints
    /// </summary>
    public unsafe virtual void DebugDestroyAllWeakPoints()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugDestroyAllWeakPoints, "BmGame.RVehicleHeavyTank.DebugDestroyAllWeakPoints");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmobileLost;
    /// <summary>
    /// Function: BatmobileLost
    /// </summary>
    public unsafe virtual void BatmobileLost()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmobileLost, "BmGame.RVehicleHeavyTank.BatmobileLost");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmobileSpotted;
    /// <summary>
    /// Function: BatmobileSpotted
    /// </summary>
    public unsafe virtual void BatmobileSpotted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmobileSpotted, "BmGame.RVehicleHeavyTank.BatmobileSpotted");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayStagedBasedDialogue;
    /// <summary>
    /// Function: PlayStagedBasedDialogue
    /// </summary>
    public unsafe virtual void PlayStagedBasedDialogue(BmSDK.BmGame.RVehicleHeavyTank.ECommandTankStageBasedDialogue Dialogue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayStagedBasedDialogue, "BmGame.RVehicleHeavyTank.PlayStagedBasedDialogue");
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dialogue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDialogueStage;
    /// <summary>
    /// Function: GetDialogueStage
    /// </summary>
    public unsafe virtual int GetDialogueStage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDialogueStage, "BmGame.RVehicleHeavyTank.GetDialogueStage");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MakeCloudburstVulnerable;
    /// <summary>
    /// Function: MakeCloudburstVulnerable
    /// </summary>
    public unsafe virtual void MakeCloudburstVulnerable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeCloudburstVulnerable, "BmGame.RVehicleHeavyTank.MakeCloudburstVulnerable");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCloudburstState;
    /// <summary>
    /// Function: SetCloudburstState
    /// </summary>
    public unsafe virtual void SetCloudburstState(int WeakPointsRemaining)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCloudburstState, "BmGame.RVehicleHeavyTank.SetCloudburstState");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeakPointsRemaining, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowHeat;
    /// <summary>
    /// Function: ShowHeat
    /// </summary>
    public unsafe virtual void ShowHeat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowHeat, "BmGame.RVehicleHeavyTank.ShowHeat");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeakPointHit;
    /// <summary>
    /// Function: WeakPointHit
    /// </summary>
    public unsafe virtual void WeakPointHit(int EyeHit)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeakPointHit, "BmGame.RVehicleHeavyTank.WeakPointHit");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EyeHit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EyeShot;
    /// <summary>
    /// Function: EyeShot
    /// </summary>
    public unsafe override bool EyeShot(int EyeHit)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EyeShot, "BmGame.RVehicleHeavyTank.EyeShot");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EyeHit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TickWeakPoints;
    /// <summary>
    /// Function: TickWeakPoints
    /// </summary>
    public unsafe virtual void TickWeakPoints(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickWeakPoints, "BmGame.RVehicleHeavyTank.TickWeakPoints");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScanWeakPoints;
    /// <summary>
    /// Function: ScanWeakPoints
    /// </summary>
    public unsafe virtual void ScanWeakPoints(System.Numerics.Vector3 ScanOrigin)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScanWeakPoints, "BmGame.RVehicleHeavyTank.ScanWeakPoints");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScanOrigin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MakeWeakPointVisible;
    /// <summary>
    /// Function: MakeWeakPointVisible
    /// </summary>
    public unsafe virtual void MakeWeakPointVisible(int I)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeWeakPointVisible, "BmGame.RVehicleHeavyTank.MakeWeakPointVisible");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(I, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScanningFinished;
    /// <summary>
    /// Function: ScanningFinished
    /// </summary>
    public unsafe virtual void ScanningFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScanningFinished, "BmGame.RVehicleHeavyTank.ScanningFinished");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopForAttacking;
    /// <summary>
    /// Function: StopForAttacking
    /// </summary>
    public unsafe virtual bool StopForAttacking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopForAttacking, "BmGame.RVehicleHeavyTank.StopForAttacking");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumSimultaneousAttackSlots;
    /// <summary>
    /// Function: GetNumSimultaneousAttackSlots
    /// </summary>
    public unsafe override int GetNumSimultaneousAttackSlots(int WeaponIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumSimultaneousAttackSlots, "BmGame.RVehicleHeavyTank.GetNumSimultaneousAttackSlots");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetShootTarget;
    /// <summary>
    /// Function: GetShootTarget
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetShootTarget(BmSDK.Engine.Actor Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetShootTarget, "BmGame.RVehicleHeavyTank.GetShootTarget");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsAttacking;
    /// <summary>
    /// Function: IsAttacking
    /// </summary>
    public unsafe override bool IsAttacking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAttacking, "BmGame.RVehicleHeavyTank.IsAttacking");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartAttack;
    /// <summary>
    /// Function: StartAttack
    /// </summary>
    public unsafe override bool StartAttack(BmSDK.Engine.Actor Target, float WarningTime, System.Numerics.Vector3 AttackLoc = default, int WeaponIndex = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAttack, "BmGame.RVehicleHeavyTank.StartAttack");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WarningTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackLoc, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponIndex, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_SetCurrentBossStage;
    /// <summary>
    /// Function: SetCurrentBossStage
    /// </summary>
    public unsafe virtual void SetCurrentBossStage(int CurrentStage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentBossStage, "BmGame.RVehicleHeavyTank.SetCurrentBossStage");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentStage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireNow;
    /// <summary>
    /// Function: FireNow
    /// </summary>
    public unsafe override void FireNow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireNow, "BmGame.RVehicleHeavyTank.FireNow");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateDamageFromEMP;
    /// <summary>
    /// Function: UpdateDamageFromEMP
    /// </summary>
    public unsafe override void UpdateDamageFromEMP(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateDamageFromEMP, "BmGame.RVehicleHeavyTank.UpdateDamageFromEMP");
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

    private static BmSDK.Function __fn_TakeDamageFromEMP;
    /// <summary>
    /// Function: TakeDamageFromEMP
    /// </summary>
    public unsafe override void TakeDamageFromEMP(BmSDK.Engine.Controller DamageInstigator, float DamageDuration)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamageFromEMP, "BmGame.RVehicleHeavyTank.TakeDamageFromEMP");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageInstigator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageDuration, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverrideVehicleTakedown;
    /// <summary>
    /// Function: OverrideVehicleTakedown
    /// </summary>
    public unsafe override bool OverrideVehicleTakedown(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideVehicleTakedown, "BmGame.RVehicleHeavyTank.OverrideVehicleTakedown");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TickAimAndShootAtBatman;
    /// <summary>
    /// Function: TickAimAndShootAtBatman
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 TickAimAndShootAtBatman(float DeltaTime, float CombatRange, System.Numerics.Vector3 ScanDirIn, bool ScanTurnsTurret = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickAimAndShootAtBatman, "BmGame.RVehicleHeavyTank.TickAimAndShootAtBatman");
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatRange, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScanDirIn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScanTurnsTurret, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_DisableShield;
    /// <summary>
    /// Function: DisableShield
    /// </summary>
    public unsafe virtual void DisableShield()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableShield, "BmGame.RVehicleHeavyTank.DisableShield");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProjectBounds;
    /// <summary>
    /// Function: ProjectBounds
    /// </summary>
    public unsafe virtual void ProjectBounds(BmSDK.BmGame.RPlayerController RPC, System.Numerics.Vector3 TargetLoc, float TargetRadiusHorz, float TargetRadiusVert, out System.Numerics.Vector2 OutMin, out System.Numerics.Vector2 OutMax)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProjectBounds, "BmGame.RVehicleHeavyTank.ProjectBounds");
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLoc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetRadiusHorz, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetRadiusVert, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutMin = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(paramsPtr + 28);
        OutMax = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(paramsPtr + 36);
        return;
    }

    private static BmSDK.Function __fn_CheckVisibility;
    /// <summary>
    /// Function: CheckVisibility
    /// </summary>
    public unsafe virtual bool CheckVisibility(BmSDK.BmGame.RPlayerController RPC, out int FailReason)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckVisibility, "BmGame.RVehicleHeavyTank.CheckVisibility");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FailReason = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmGame.RVehicleHeavyTank.Died");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_CanAttackTarget;
    /// <summary>
    /// Function: CanAttackTarget
    /// </summary>
    public unsafe override BmSDK.BmGame.RVehicleNPC.ECanAttackTargetResult CanAttackTarget(BmSDK.Engine.Actor Target, int WeaponID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanAttackTarget, "BmGame.RVehicleHeavyTank.CanAttackTarget");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.ECanAttackTargetResult>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_UpdateLaserAudioSource;
    /// <summary>
    /// Function: UpdateLaserAudioSource
    /// </summary>
    public unsafe virtual void UpdateLaserAudioSource(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateLaserAudioSource, "BmGame.RVehicleHeavyTank.UpdateLaserAudioSource");
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

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RVehicleHeavyTank.Tick");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScanLaserActive;
    /// <summary>
    /// Function: SetScanLaserActive
    /// </summary>
    public unsafe virtual void SetScanLaserActive(bool OnOrOff)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScanLaserActive, "BmGame.RVehicleHeavyTank.SetScanLaserActive");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnOrOff, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScanLaserScale;
    /// <summary>
    /// Function: SetScanLaserScale
    /// </summary>
    public unsafe virtual void SetScanLaserScale(float Scale)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScanLaserScale, "BmGame.RVehicleHeavyTank.SetScanLaserScale");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RigidBodyCollision;
    /// <summary>
    /// Function: RigidBodyCollision
    /// </summary>
    public unsafe override void RigidBodyCollision(BmSDK.Engine.PrimitiveComponent HitComponent, BmSDK.Engine.PrimitiveComponent OtherComponent, out BmSDK.Engine.Actor.FCollisionImpactData RigidCollisionData, int ContactIndex, float Speed, int Index0, int Index1)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RigidBodyCollision, "BmGame.RVehicleHeavyTank.RigidBodyCollision");
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComponent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactIndex, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index0, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index1, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RigidCollisionData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.FCollisionImpactData>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_GetComboTimer;
    /// <summary>
    /// Function: GetComboTimer
    /// </summary>
    public unsafe override float GetComboTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboTimer, "BmGame.RVehicleHeavyTank.GetComboTimer");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMissileTargetLocation;
    /// <summary>
    /// Function: GetMissileTargetLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetMissileTargetLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMissileTargetLocation, "BmGame.RVehicleHeavyTank.GetMissileTargetLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetWeaponLockOnLocation;
    /// <summary>
    /// Function: GetWeaponLockOnLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetWeaponLockOnLocation(out int InSight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponLockOnLocation, "BmGame.RVehicleHeavyTank.GetWeaponLockOnLocation");
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        InSight = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DetachWeakPoint;
    /// <summary>
    /// Function: DetachWeakPoint
    /// </summary>
    public unsafe virtual void DetachWeakPoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachWeakPoint, "BmGame.RVehicleHeavyTank.DetachWeakPoint");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachWeakPoint;
    /// <summary>
    /// Function: AttachWeakPoint
    /// </summary>
    public unsafe virtual void AttachWeakPoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachWeakPoint, "BmGame.RVehicleHeavyTank.AttachWeakPoint");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopsProjectile;
    /// <summary>
    /// Function: StopsProjectile
    /// </summary>
    public unsafe override bool StopsProjectile(BmSDK.Engine.Projectile P, BmSDK.Engine.PrimitiveComponent HitComponent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopsProjectile, "BmGame.RVehicleHeavyTank.StopsProjectile");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ShieldCooldown;
    /// <summary>
    /// Function: ShieldCooldown
    /// </summary>
    public unsafe virtual void ShieldCooldown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShieldCooldown, "BmGame.RVehicleHeavyTank.ShieldCooldown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Touch;
    /// <summary>
    /// Function: Touch
    /// </summary>
    public unsafe override void Touch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Touch, "BmGame.RVehicleHeavyTank.Touch");
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeDamage;
    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamage, "BmGame.RVehicleHeavyTank.TakeDamage");
        byte* paramsPtr = stackalloc byte[120];
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

    private static BmSDK.Function __fn_TakeDamageFromWeapon;
    /// <summary>
    /// Function: TakeDamageFromWeapon
    /// </summary>
    public unsafe override BmSDK.Engine.Actor.EWeaponDamageResult TakeDamageFromWeapon(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default, bool bHeadShot = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamageFromWeapon, "BmGame.RVehicleHeavyTank.TakeDamageFromWeapon");
        byte* paramsPtr = stackalloc byte[109];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHeadShot, paramsPtr + 104);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.EWeaponDamageResult>(paramsPtr + 108);
    }

    private static BmSDK.Function __fn_SetLightState;
    /// <summary>
    /// Function: SetLightState
    /// </summary>
    public unsafe virtual void SetLightState(int LightState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLightState, "BmGame.RVehicleHeavyTank.SetLightState");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LightState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelAttack;
    /// <summary>
    /// Function: CancelAttack
    /// </summary>
    public unsafe override void CancelAttack(bool DueToBeingRammed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelAttack, "BmGame.RVehicleHeavyTank.CancelAttack");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DueToBeingRammed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PowerUp;
    /// <summary>
    /// Function: PowerUp
    /// </summary>
    public unsafe virtual void PowerUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PowerUp, "BmGame.RVehicleHeavyTank.PowerUp");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PoweredDownAnnounce;
    /// <summary>
    /// Function: PoweredDownAnnounce
    /// </summary>
    public unsafe virtual void PoweredDownAnnounce()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PoweredDownAnnounce, "BmGame.RVehicleHeavyTank.PoweredDownAnnounce");
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PowerDown;
    /// <summary>
    /// Function: PowerDown
    /// </summary>
    public unsafe virtual void PowerDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PowerDown, "BmGame.RVehicleHeavyTank.PowerDown");
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWeakPointRevealed;
    /// <summary>
    /// Function: SetWeakPointRevealed
    /// </summary>
    public unsafe virtual void SetWeakPointRevealed(bool Revealed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWeakPointRevealed, "BmGame.RVehicleHeavyTank.SetWeakPointRevealed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Revealed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RVehicleHeavyTank.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FCommandTankDialogueCont
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FCommandTankDialogueCont
    {
        /// <summary>
        /// ArrayProperty: Lines
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.AkDialogueSpeech> Lines
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkDialogueSpeech>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: ECommandTankStageBasedDialogue
    /// </summary>
    public enum ECommandTankStageBasedDialogue : byte
    {
        ESBD_WeakPointHit = 0,
        ESBD_BatmanSpotted = 1,
        ESBD_SearchOneShot = 2,
        ESBD_ChaseOneShot = 3,
        ESBD_ChaseBegins = 4,
        ESBD_ChaseEnds = 5,
        ESBD_MAX = 6,
    }

    /// <summary>
    /// Struct: FCommanderTankWeakPoint
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FCommanderTankWeakPoint
    {
        /// <summary>
        /// NameProperty: Socket
        /// </summary>
        public unsafe BmSDK.FName Socket
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: VisibleDuration
        /// </summary>
        public unsafe float VisibleDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bDestroyed
        /// </summary>
        public unsafe bool bDestroyed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// ComponentProperty: WeakPointPS
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent WeakPointPS
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FCommanderTankStage
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FCommanderTankStage
    {
        /// <summary>
        /// ArrayProperty: AvailableWeapons
        /// </summary>
        public unsafe BmSDK.TArray<int> AvailableWeapons
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MaxHealthPct
        /// </summary>
        public unsafe float MaxHealthPct
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: NextStageHealth
        /// </summary>
        public unsafe int NextStageHealth
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: Duration
        /// </summary>
        public unsafe float Duration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: NextStageTimeout
        /// </summary>
        public unsafe int NextStageTimeout
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: MinSimultaneousAttacks
        /// </summary>
        public unsafe int MinSimultaneousAttacks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: DifficultyMod
        /// </summary>
        public unsafe float DifficultyMod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: OverrideAttackInterval
        /// </summary>
        public unsafe float OverrideAttackInterval
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// ComponentProperty: WeakPoint
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent WeakPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 8112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8112); }
    }

    /// <summary>
    /// BoolProperty: HideWeakPointWhenPatrolling
    /// </summary>
    public unsafe bool HideWeakPointWhenPatrolling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: DisableLaserCollision
    /// </summary>
    public unsafe bool DisableLaserCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: Shielded
    /// </summary>
    public unsafe bool Shielded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bDrawScanLaserDebug
    /// </summary>
    public unsafe bool bDrawScanLaserDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: WeakPointRevealed
    /// </summary>
    public unsafe bool WeakPointRevealed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: DisallowEngageTarget
    /// </summary>
    public unsafe bool DisallowEngageTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bCloudburstVulnerable
    /// </summary>
    public unsafe bool bCloudburstVulnerable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bNoScanLasers
    /// </summary>
    public unsafe bool bNoScanLasers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bWeakPointsTargettable
    /// </summary>
    public unsafe bool bWeakPointsTargettable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bVulnderableOnStartup
    /// </summary>
    public unsafe bool bVulnderableOnStartup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bLockedOnToPlayer
    /// </summary>
    public unsafe bool bLockedOnToPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: PlayedLostDialogueThisStage
    /// </summary>
    public unsafe bool PlayedLostDialogueThisStage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// FloatProperty: ScanRange
    /// </summary>
    public unsafe float ScanRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8124); }
    }

    /// <summary>
    /// ComponentProperty: ScannerLightSource
    /// </summary>
    public unsafe BmSDK.Engine.SpotLightComponent ScannerLightSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpotLightComponent>(Ptr + 8128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8128); }
    }

    /// <summary>
    /// StructProperty: SearchLightColour
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor SearchLightColour
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 8136);

    /// <summary>
    /// StructProperty: Sweep360LightColour
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor Sweep360LightColour
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 8140);

    /// <summary>
    /// StructProperty: AttackLightColour
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor AttackLightColour
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 8144);

    /// <summary>
    /// ObjectProperty: ScanLaser
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleScanLaser ScanLaser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleScanLaser>(Ptr + 8148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8148); }
    }

    /// <summary>
    /// ObjectProperty: BattleViewMaterialInst
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BattleViewMaterialInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 8156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8156); }
    }

    /// <summary>
    /// ObjectProperty: LightMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant LightMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 8164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8164); }
    }

    /// <summary>
    /// ObjectProperty: LaserAudible
    /// </summary>
    public unsafe BmSDK.Engine.RAkAudible LaserAudible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAkAudible>(Ptr + 8172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8172); }
    }

    /// <summary>
    /// ObjectProperty: LaserEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LaserEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8180); }
    }

    /// <summary>
    /// ObjectProperty: DisableShieldMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DisableShieldMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8188); }
    }

    /// <summary>
    /// ObjectProperty: ShieldImpactMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant ShieldImpactMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 8196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8196); }
    }

    /// <summary>
    /// ObjectProperty: ShieldFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ShieldFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 8204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8204); }
    }

    /// <summary>
    /// ObjectProperty: MuzzleWarningFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem MuzzleWarningFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 8212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8212); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileContactParticles
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem BatmobileContactParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 8220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8220); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileContactSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BatmobileContactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8228); }
    }

    /// <summary>
    /// ObjectProperty: BossMovieInstance
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie BossMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 8236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8236); }
    }

    /// <summary>
    /// ObjectProperty: TurretDestroyedMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh TurretDestroyedMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 8244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8244); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstOverheatedLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CloudburstOverheatedLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 8252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8252); }
    }

    /// <summary>
    /// ObjectProperty: PostScanLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech PostScanLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 8260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8260); }
    }

    /// <summary>
    /// ObjectProperty: PostPowerDownLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech PostPowerDownLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 8268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8268); }
    }

    /// <summary>
    /// ObjectProperty: EMPIneffectiveLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech EMPIneffectiveLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 8276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8276); }
    }

    /// <summary>
    /// ObjectProperty: CachedShutDownBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour CachedShutDownBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour>(Ptr + 8284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8284); }
    }

    /// <summary>
    /// ObjectProperty: WeakPointTarget
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WeakPointTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 8292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8292); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstCriticalOn
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CloudburstCriticalOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8300); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstCriticalOff
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CloudburstCriticalOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8308); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstCriticalValue
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName CloudburstCriticalValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 8316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8316); }
    }

    /// <summary>
    /// ObjectProperty: MainWeaponChargeSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent MainWeaponChargeSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8324); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant CloudburstMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 8332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8332); }
    }

    /// <summary>
    /// ObjectProperty: DeathExplosionWaveform
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform DeathExplosionWaveform
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 8340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8340); }
    }

    /// <summary>
    /// ComponentProperty: CloudburstPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent CloudburstPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8348); }
    }

    /// <summary>
    /// ComponentProperty: TurretDestroyedPersistentPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent TurretDestroyedPersistentPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8356); }
    }

    /// <summary>
    /// ComponentProperty: TurretDestroyedPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent TurretDestroyedPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8364); }
    }

    /// <summary>
    /// ComponentProperty: TurretMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent TurretMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 8372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8372); }
    }

    /// <summary>
    /// ComponentProperty: Cloudburst
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent Cloudburst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 8380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8380); }
    }

    /// <summary>
    /// ComponentProperty: WeakPointMeshComp
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent WeakPointMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 8388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8388); }
    }

    /// <summary>
    /// ComponentProperty: ShieldImpactComp
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent ShieldImpactComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 8396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8396); }
    }

    /// <summary>
    /// ComponentProperty: ShieldMeshComp
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent ShieldMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 8404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8404); }
    }

    /// <summary>
    /// ComponentProperty: Shield
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent Shield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 8412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8412); }
    }

    /// <summary>
    /// NameProperty: ScannerSocker
    /// </summary>
    public unsafe BmSDK.FName ScannerSocker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8420); }
    }

    /// <summary>
    /// IntProperty: NumScanLasers
    /// </summary>
    public unsafe int NumScanLasers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8428); }
    }

    /// <summary>
    /// ArrayProperty: ActualLasers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleScanLaser> ActualLasers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleScanLaser>>(Ptr + 8432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8432); }
    }

    /// <summary>
    /// IntProperty: CurrentCollisionLaser
    /// </summary>
    public unsafe int CurrentCollisionLaser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8448); }
    }

    /// <summary>
    /// FloatProperty: WeakPointRadius
    /// </summary>
    public unsafe float WeakPointRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8452); }
    }

    /// <summary>
    /// FloatProperty: MaxLaserSoundVelocity
    /// </summary>
    public unsafe float MaxLaserSoundVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8456); }
    }

    /// <summary>
    /// ArrayProperty: LaserSoundPositions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkWwise.FAkSourceSpatial> LaserSoundPositions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkWwise.FAkSourceSpatial>>(Ptr + 8460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8460); }
    }

    /// <summary>
    /// FloatProperty: MuzzleWarningDuration
    /// </summary>
    public unsafe float MuzzleWarningDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8476); }
    }

    /// <summary>
    /// FloatProperty: BatmobileContactDamagePerSecond
    /// </summary>
    public unsafe float BatmobileContactDamagePerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8480); }
    }

    /// <summary>
    /// FloatProperty: BatmobileContactImpulse
    /// </summary>
    public unsafe float BatmobileContactImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8484); }
    }

    /// <summary>
    /// FloatProperty: ContactDamageDelay
    /// </summary>
    public unsafe float ContactDamageDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8488); }
    }

    /// <summary>
    /// FloatProperty: ScanForBatmanAngle
    /// </summary>
    public unsafe float ScanForBatmanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8492); }
    }

    /// <summary>
    /// FloatProperty: VisibilityTimeMod
    /// </summary>
    public unsafe float VisibilityTimeMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8496); }
    }

    /// <summary>
    /// IntProperty: NumNonTurretLightMaterialInst
    /// </summary>
    public unsafe int NumNonTurretLightMaterialInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8500); }
    }

    /// <summary>
    /// ArrayProperty: AllWeapons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.FWalkerWeaponContainer> AllWeapons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.FWalkerWeaponContainer>>(Ptr + 8504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8504); }
    }

    /// <summary>
    /// ArrayProperty: BossStages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.FCommanderTankStage> BossStages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.FCommanderTankStage>>(Ptr + 8520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8520); }
    }

    /// <summary>
    /// FloatProperty: CloudburstHeat
    /// </summary>
    public unsafe float CloudburstHeat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8536); }
    }

    /// <summary>
    /// IntProperty: CurrentBossStage
    /// </summary>
    public unsafe int CurrentBossStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8540); }
    }

    /// <summary>
    /// FloatProperty: StartingHealth
    /// </summary>
    public unsafe float StartingHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8544); }
    }

    /// <summary>
    /// FloatProperty: CurrentStageTimeout
    /// </summary>
    public unsafe float CurrentStageTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8548); }
    }

    /// <summary>
    /// ArrayProperty: WeakPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.FCommanderTankWeakPoint> WeakPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.FCommanderTankWeakPoint>>(Ptr + 8552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8552); }
    }

    /// <summary>
    /// ArrayProperty: WeakPointsDestroyedGotoStage
    /// </summary>
    public unsafe BmSDK.TArray<int> WeakPointsDestroyedGotoStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 8568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8568); }
    }

    /// <summary>
    /// FloatProperty: PostPowerDownLineDelay
    /// </summary>
    public unsafe float PostPowerDownLineDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8584); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: StageBasedDialogue
    /// </summary>
    public InlineArray<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont> StageBasedDialogue => new(6, Ptr + 8588, 16, this);

    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8588);
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8604);
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8620);
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8636);
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8652);
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe ref BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8668);

    /// <summary>
    /// ArrayProperty: CloudburstDamageTemplate
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ParticleSystem> CloudburstDamageTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ParticleSystem>>(Ptr + 8684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8684); }
    }

    /// <summary>
    /// ArrayProperty: MaterialHeatValues
    /// </summary>
    public unsafe BmSDK.TArray<float> MaterialHeatValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 8700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8700); }
    }

    /// <summary>
    /// FloatProperty: PowerDownPowerBackUpDelay
    /// </summary>
    public unsafe float PowerDownPowerBackUpDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8716); }
    }

    /// <summary>
    /// NameProperty: LastAimSocket
    /// </summary>
    public unsafe BmSDK.FName LastAimSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8720); }
    }
}
