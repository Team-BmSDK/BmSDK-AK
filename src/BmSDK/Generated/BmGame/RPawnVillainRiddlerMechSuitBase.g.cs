#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPawnVillainRiddlerMechSuitBase<br/>
/// (size = 6724)
/// (flags = 144703671)
/// </summary>
public partial class RPawnVillainRiddlerMechSuitBase : BmSDK.BmGame.RPawnVillainThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnVillainRiddlerMechSuitBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillainRiddlerMechSuitBase.
    /// </summary>
    public static RPawnVillainRiddlerMechSuitBase DefaultObject => (RPawnVillainRiddlerMechSuitBase)StaticClass().DefaultObject;

    internal RPawnVillainRiddlerMechSuitBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainRiddlerMechSuitBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainRiddlerMechSuitBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainRiddlerMechSuitBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainRiddlerMechSuitBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainRiddlerMechSuitBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainRiddlerMechSuitBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainRiddlerMechSuitBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainRiddlerMechSuitBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainRiddlerMechSuitBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_InitHealthBar;
    /// <summary>
    /// Function: InitHealthBar
    /// </summary>
    public unsafe virtual void InitHealthBar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitHealthBar, "BmGame.RPawnVillainRiddlerMechSuitBase.InitHealthBar");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSmashRobots;
    /// <summary>
    /// Function: CanSmashRobots
    /// </summary>
    public unsafe virtual bool CanSmashRobots()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSmashRobots, "BmGame.RPawnVillainRiddlerMechSuitBase.CanSmashRobots");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopCombatCamLookAtMe;
    /// <summary>
    /// Function: StopCombatCamLookAtMe
    /// </summary>
    public unsafe virtual void StopCombatCamLookAtMe()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopCombatCamLookAtMe, "BmGame.RPawnVillainRiddlerMechSuitBase.StopCombatCamLookAtMe");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatCamLookAtMe;
    /// <summary>
    /// Function: CombatCamLookAtMe
    /// </summary>
    public unsafe virtual void CombatCamLookAtMe()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatCamLookAtMe, "BmGame.RPawnVillainRiddlerMechSuitBase.CombatCamLookAtMe");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsFirstMechFight;
    /// <summary>
    /// Function: IsFirstMechFight
    /// </summary>
    public unsafe virtual bool IsFirstMechFight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFirstMechFight, "BmGame.RPawnVillainRiddlerMechSuitBase.IsFirstMechFight");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLiftLocator;
    /// <summary>
    /// Function: GetLiftLocator
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetLiftLocator()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLiftLocator, "BmGame.RPawnVillainRiddlerMechSuitBase.GetLiftLocator");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnChangeRobotColourStart;
    /// <summary>
    /// Function: OnChangeRobotColourStart
    /// </summary>
    public unsafe virtual void OnChangeRobotColourStart()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnChangeRobotColourStart, "BmGame.RPawnVillainRiddlerMechSuitBase.OnChangeRobotColourStart");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnShieldOffCW;
    /// <summary>
    /// Function: OnShieldOffCW
    /// </summary>
    public unsafe virtual void OnShieldOffCW()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnShieldOffCW, "BmGame.RPawnVillainRiddlerMechSuitBase.OnShieldOffCW");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnShieldOffBM;
    /// <summary>
    /// Function: OnShieldOffBM
    /// </summary>
    public unsafe virtual void OnShieldOffBM()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnShieldOffBM, "BmGame.RPawnVillainRiddlerMechSuitBase.OnShieldOffBM");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnShieldOff;
    /// <summary>
    /// Function: OnShieldOff
    /// </summary>
    public unsafe virtual void OnShieldOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnShieldOff, "BmGame.RPawnVillainRiddlerMechSuitBase.OnShieldOff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPlayerHit;
    /// <summary>
    /// Function: OnPlayerHit
    /// </summary>
    public unsafe virtual void OnPlayerHit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPlayerHit, "BmGame.RPawnVillainRiddlerMechSuitBase.OnPlayerHit");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffElectFist;
    /// <summary>
    /// Function: TurnOffElectFist
    /// </summary>
    public unsafe virtual void TurnOffElectFist()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffElectFist, "BmGame.RPawnVillainRiddlerMechSuitBase.TurnOffElectFist");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnElectFist;
    /// <summary>
    /// Function: TurnOnElectFist
    /// </summary>
    public unsafe virtual void TurnOnElectFist()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnElectFist, "BmGame.RPawnVillainRiddlerMechSuitBase.TurnOnElectFist");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopChargeUpFx;
    /// <summary>
    /// Function: StopChargeUpFx
    /// </summary>
    public unsafe virtual void StopChargeUpFx()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopChargeUpFx, "BmGame.RPawnVillainRiddlerMechSuitBase.StopChargeUpFx");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateChargeUpFx;
    /// <summary>
    /// Function: ActivateChargeUpFx
    /// </summary>
    public unsafe virtual void ActivateChargeUpFx()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateChargeUpFx, "BmGame.RPawnVillainRiddlerMechSuitBase.ActivateChargeUpFx");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckTriggerAllChangeColour;
    /// <summary>
    /// Function: CheckTriggerAllChangeColour
    /// </summary>
    public unsafe virtual void CheckTriggerAllChangeColour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckTriggerAllChangeColour, "BmGame.RPawnVillainRiddlerMechSuitBase.CheckTriggerAllChangeColour");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateRevive;
    /// <summary>
    /// Function: ActivateRevive
    /// </summary>
    public unsafe virtual void ActivateRevive(bool bStart)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateRevive, "BmGame.RPawnVillainRiddlerMechSuitBase.ActivateRevive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStart, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateBeam;
    /// <summary>
    /// Function: ActivateBeam
    /// </summary>
    public unsafe virtual void ActivateBeam(bool bStart)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateBeam, "BmGame.RPawnVillainRiddlerMechSuitBase.ActivateBeam");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStart, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanDoFarAttack;
    /// <summary>
    /// Function: CanDoFarAttack
    /// </summary>
    public unsafe virtual bool CanDoFarAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoFarAttack, "BmGame.RPawnVillainRiddlerMechSuitBase.CanDoFarAttack");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanForceCharge;
    /// <summary>
    /// Function: CanForceCharge
    /// </summary>
    public unsafe virtual bool CanForceCharge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanForceCharge, "BmGame.RPawnVillainRiddlerMechSuitBase.CanForceCharge");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_VulnerableToCatWoman;
    /// <summary>
    /// Function: VulnerableToCatWoman
    /// </summary>
    public unsafe virtual void VulnerableToCatWoman()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VulnerableToCatWoman, "BmGame.RPawnVillainRiddlerMechSuitBase.VulnerableToCatWoman");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VulnerableToBatman;
    /// <summary>
    /// Function: VulnerableToBatman
    /// </summary>
    public unsafe virtual void VulnerableToBatman()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VulnerableToBatman, "BmGame.RPawnVillainRiddlerMechSuitBase.VulnerableToBatman");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VulnerableToEveryone;
    /// <summary>
    /// Function: VulnerableToEveryone
    /// </summary>
    public unsafe virtual void VulnerableToEveryone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VulnerableToEveryone, "BmGame.RPawnVillainRiddlerMechSuitBase.VulnerableToEveryone");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBeamContactPfx;
    /// <summary>
    /// Function: GetBeamContactPfx
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetBeamContactPfx()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBeamContactPfx, "BmGame.RPawnVillainRiddlerMechSuitBase.GetBeamContactPfx");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBeamPfx;
    /// <summary>
    /// Function: GetBeamPfx
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetBeamPfx()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBeamPfx, "BmGame.RPawnVillainRiddlerMechSuitBase.GetBeamPfx");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetChargeBeamPfx;
    /// <summary>
    /// Function: GetChargeBeamPfx
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetChargeBeamPfx()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChargeBeamPfx, "BmGame.RPawnVillainRiddlerMechSuitBase.GetChargeBeamPfx");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetElectFistPfx;
    /// <summary>
    /// Function: GetElectFistPfx
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetElectFistPfx()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetElectFistPfx, "BmGame.RPawnVillainRiddlerMechSuitBase.GetElectFistPfx");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPowerUpPfx;
    /// <summary>
    /// Function: GetPowerUpPfx
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetPowerUpPfx()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPowerUpPfx, "BmGame.RPawnVillainRiddlerMechSuitBase.GetPowerUpPfx");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetForceChargePfx;
    /// <summary>
    /// Function: GetForceChargePfx
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetForceChargePfx()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetForceChargePfx, "BmGame.RPawnVillainRiddlerMechSuitBase.GetForceChargePfx");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_LightsOff;
    /// <summary>
    /// Function: LightsOff
    /// </summary>
    public unsafe virtual void LightsOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LightsOff, "BmGame.RPawnVillainRiddlerMechSuitBase.LightsOff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LightsOn;
    /// <summary>
    /// Function: LightsOn
    /// </summary>
    public unsafe virtual void LightsOn(bool bBlue, BmSDK.TArray<BmSDK.BmGame.RPawnVillain> TogglePawnList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LightsOn, "BmGame.RPawnVillainRiddlerMechSuitBase.LightsOn");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBlue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TogglePawnList, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetShieldOff;
    /// <summary>
    /// Function: SetShieldOff
    /// </summary>
    public unsafe virtual void SetShieldOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetShieldOff, "BmGame.RPawnVillainRiddlerMechSuitBase.SetShieldOff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetShieldOn;
    /// <summary>
    /// Function: SetShieldOn
    /// </summary>
    public unsafe virtual void SetShieldOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetShieldOn, "BmGame.RPawnVillainRiddlerMechSuitBase.SetShieldOn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AimAtActor;
    /// <summary>
    /// Function: AimAtActor
    /// </summary>
    public unsafe override void AimAtActor(BmSDK.Engine.Actor Actor, BmSDK.FName Description = default, BmSDK.FName ActorBoneName = default, BmSDK.BmGame.RAnimUtil_PosePlayer.EAllowTurningToAim AllowTurningToAim = default, float LimitScale = default, BmSDK.BmGame.RPoseConfig.FAimingTransitionTimingOverride TimingOverride = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimAtActor, "BmGame.RPawnVillainRiddlerMechSuitBase.AimAtActor");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorBoneName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowTurningToAim, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LimitScale, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimingOverride, paramsPtr + 32);
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
    /// IntProperty: NumPilotPound
    /// </summary>
    public unsafe int NumPilotPound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6696); }
    }

    /// <summary>
    /// FloatProperty: LastChargeCommandTIme
    /// </summary>
    public unsafe float LastChargeCommandTIme
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6700); }
    }

    /// <summary>
    /// FloatProperty: LastFarAttackTIme
    /// </summary>
    public unsafe float LastFarAttackTIme
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6704); }
    }

    /// <summary>
    /// ObjectProperty: BossModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleBoss BossModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleBoss>(Ptr + 6708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6708); }
    }

    /// <summary>
    /// ObjectProperty: TheMovieInstance
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie TheMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 6716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6716); }
    }
}
