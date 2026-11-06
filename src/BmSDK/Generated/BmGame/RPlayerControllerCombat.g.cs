#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPlayerControllerCombat<br/>
/// (size = 9000)
/// (flags = 144703638)
/// </summary>
public partial class RPlayerControllerCombat : BmSDK.BmGame.RPlayerController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPlayerControllerCombat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPlayerControllerCombat.
    /// </summary>
    public static RPlayerControllerCombat DefaultObject => (RPlayerControllerCombat)StaticClass().DefaultObject;

    internal RPlayerControllerCombat() { }

    /// <summary>
    /// Constructs a new RPlayerControllerCombat
    /// </summary>
    public RPlayerControllerCombat(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPlayerControllerCombat(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PreRestart;
    /// <summary>
    /// Function: PreRestart
    /// </summary>
    public unsafe override void PreRestart()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreRestart, "BmGame.RPlayerControllerCombat.PreRestart");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CantSwitchPlayer;
    /// <summary>
    /// Function: CantSwitchPlayer
    /// </summary>
    public unsafe override bool CantSwitchPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CantSwitchPlayer, "BmGame.RPlayerControllerCombat.CantSwitchPlayer");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BeatdownFromFloorPickup;
    /// <summary>
    /// Function: BeatdownFromFloorPickup
    /// </summary>
    public unsafe virtual void BeatdownFromFloorPickup()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeatdownFromFloorPickup, "BmGame.RPlayerControllerCombat.BeatdownFromFloorPickup");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpgradeQuickGadgetToSuperGadget;
    /// <summary>
    /// Function: UpgradeQuickGadgetToSuperGadget
    /// </summary>
    public unsafe override void UpgradeQuickGadgetToSuperGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpgradeQuickGadgetToSuperGadget, "BmGame.RPlayerControllerCombat.UpgradeQuickGadgetToSuperGadget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DontQuickThrowBatarang;
    /// <summary>
    /// Function: DontQuickThrowBatarang
    /// </summary>
    public unsafe override void DontQuickThrowBatarang()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DontQuickThrowBatarang, "BmGame.RPlayerControllerCombat.DontQuickThrowBatarang");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReEnableCombat;
    /// <summary>
    /// Function: ReEnableCombat
    /// </summary>
    public unsafe virtual void ReEnableCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReEnableCombat, "BmGame.RPlayerControllerCombat.ReEnableCombat");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableCombat;
    /// <summary>
    /// Function: DisableCombat
    /// </summary>
    public unsafe override void DisableCombat(float Duration = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableCombat, "BmGame.RPlayerControllerCombat.DisableCombat");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceDodgeProjectile;
    /// <summary>
    /// Function: ForceDodgeProjectile
    /// </summary>
    public unsafe virtual bool ForceDodgeProjectile()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceDodgeProjectile, "BmGame.RPlayerControllerCombat.ForceDodgeProjectile");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SuperGadgetTimer;
    /// <summary>
    /// Function: SuperGadgetTimer
    /// </summary>
    public unsafe override void SuperGadgetTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuperGadgetTimer, "BmGame.RPlayerControllerCombat.SuperGadgetTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KeyboardSpecialGadgetComboTimer;
    /// <summary>
    /// Function: KeyboardSpecialGadgetComboTimer
    /// </summary>
    public unsafe override void KeyboardSpecialGadgetComboTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KeyboardSpecialGadgetComboTimer, "BmGame.RPlayerControllerCombat.KeyboardSpecialGadgetComboTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseQuickGadgetY;
    /// <summary>
    /// Function: ReleaseQuickGadgetY
    /// </summary>
    public unsafe override void ReleaseQuickGadgetY()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseQuickGadgetY, "BmGame.RPlayerControllerCombat.ReleaseQuickGadgetY");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseQuickGadgetX;
    /// <summary>
    /// Function: ReleaseQuickGadgetX
    /// </summary>
    public unsafe override void ReleaseQuickGadgetX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseQuickGadgetX, "BmGame.RPlayerControllerCombat.ReleaseQuickGadgetX");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseQuickGadgetB;
    /// <summary>
    /// Function: ReleaseQuickGadgetB
    /// </summary>
    public unsafe override void ReleaseQuickGadgetB()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseQuickGadgetB, "BmGame.RPlayerControllerCombat.ReleaseQuickGadgetB");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseQuickGadgetA;
    /// <summary>
    /// Function: ReleaseQuickGadgetA
    /// </summary>
    public unsafe override void ReleaseQuickGadgetA()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseQuickGadgetA, "BmGame.RPlayerControllerCombat.ReleaseQuickGadgetA");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickGadgetB;
    /// <summary>
    /// Function: QuickGadgetB
    /// </summary>
    public unsafe override void QuickGadgetB()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickGadgetB, "BmGame.RPlayerControllerCombat.QuickGadgetB");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickGadgetX;
    /// <summary>
    /// Function: QuickGadgetX
    /// </summary>
    public unsafe override void QuickGadgetX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickGadgetX, "BmGame.RPlayerControllerCombat.QuickGadgetX");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickGadgetY;
    /// <summary>
    /// Function: QuickGadgetY
    /// </summary>
    public unsafe override void QuickGadgetY()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickGadgetY, "BmGame.RPlayerControllerCombat.QuickGadgetY");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickGadgetA;
    /// <summary>
    /// Function: QuickGadgetA
    /// </summary>
    public unsafe override void QuickGadgetA()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickGadgetA, "BmGame.RPlayerControllerCombat.QuickGadgetA");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerDamagePawn;
    /// <summary>
    /// Function: ServerDamagePawn
    /// </summary>
    public unsafe virtual void ServerDamagePawn(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerDamagePawn, "BmGame.RPlayerControllerCombat.ServerDamagePawn");
        byte* paramsPtr = stackalloc byte[256];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerDoHitPawn;
    /// <summary>
    /// Function: ServerDoHitPawn
    /// </summary>
    public unsafe virtual void ServerDoHitPawn(BmSDK.BmGame.RPawnCombat DamageReceiver, float DmgAmount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerDoHitPawn, "BmGame.RPlayerControllerCombat.ServerDoHitPawn");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnRegisterComboValueReachedAction;
    /// <summary>
    /// Function: UnRegisterComboValueReachedAction
    /// </summary>
    public unsafe virtual void UnRegisterComboValueReachedAction(BmSDK.BmGame.RSeqAct_ComboValueReached OldAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnRegisterComboValueReachedAction, "BmGame.RPlayerControllerCombat.UnRegisterComboValueReachedAction");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterComboValueReachedAction;
    /// <summary>
    /// Function: RegisterComboValueReachedAction
    /// </summary>
    public unsafe virtual void RegisterComboValueReachedAction(BmSDK.BmGame.RSeqAct_ComboValueReached NewAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterComboValueReachedAction, "BmGame.RPlayerControllerCombat.RegisterComboValueReachedAction");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableCapeStun;
    /// <summary>
    /// Function: EnableCapeStun
    /// </summary>
    public unsafe virtual void EnableCapeStun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableCapeStun, "BmGame.RPlayerControllerCombat.EnableCapeStun");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableCapeStun;
    /// <summary>
    /// Function: DisableCapeStun
    /// </summary>
    public unsafe override void DisableCapeStun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableCapeStun, "BmGame.RPlayerControllerCombat.DisableCapeStun");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanStagger;
    /// <summary>
    /// Function: CanStagger
    /// </summary>
    public unsafe override bool CanStagger()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanStagger, "BmGame.RPlayerControllerCombat.CanStagger");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MakeBatmanLookAtEnemy;
    /// <summary>
    /// Function: MakeBatmanLookAtEnemy
    /// </summary>
    public unsafe override bool MakeBatmanLookAtEnemy(bool bReset = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeBatmanLookAtEnemy, "BmGame.RPlayerControllerCombat.MakeBatmanLookAtEnemy");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReset, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ReadyGadgetOrCounterReleased;
    /// <summary>
    /// Function: ReadyGadgetOrCounterReleased
    /// </summary>
    public unsafe virtual void ReadyGadgetOrCounterReleased()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadyGadgetOrCounterReleased, "BmGame.RPlayerControllerCombat.ReadyGadgetOrCounterReleased");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MouseReadyGadget;
    /// <summary>
    /// Function: MouseReadyGadget
    /// </summary>
    public unsafe virtual void MouseReadyGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MouseReadyGadget, "BmGame.RPlayerControllerCombat.MouseReadyGadget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadyGadgetOrCounterPressed;
    /// <summary>
    /// Function: ReadyGadgetOrCounterPressed
    /// </summary>
    public unsafe override void ReadyGadgetOrCounterPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadyGadgetOrCounterPressed, "BmGame.RPlayerControllerCombat.ReadyGadgetOrCounterPressed");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetOrQuickStrikePressed;
    /// <summary>
    /// Function: GadgetOrQuickStrikePressed
    /// </summary>
    public unsafe virtual void GadgetOrQuickStrikePressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetOrQuickStrikePressed, "BmGame.RPlayerControllerCombat.GadgetOrQuickStrikePressed");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GrappleOrStrikeGadgetPressed;
    /// <summary>
    /// Function: GrappleOrStrikeGadgetPressed
    /// </summary>
    public unsafe virtual void GrappleOrStrikeGadgetPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrappleOrStrikeGadgetPressed, "BmGame.RPlayerControllerCombat.GrappleOrStrikeGadgetPressed");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerFlashBangMultiHitEvents;
    /// <summary>
    /// Function: TriggerFlashBangMultiHitEvents
    /// </summary>
    public unsafe virtual void TriggerFlashBangMultiHitEvents()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerFlashBangMultiHitEvents, "BmGame.RPlayerControllerCombat.TriggerFlashBangMultiHitEvents");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterGameAction;
    /// <summary>
    /// Function: RegisterGameAction
    /// </summary>
    public unsafe override void RegisterGameAction(BmSDK.BmGame.RGameInfo.EGameAction Action, BmSDK.Engine.Actor XPTarget = default, int XPAmount = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterGameAction, "BmGame.RPlayerControllerCombat.RegisterGameAction");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPAmount, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RPlayerControllerCombat.Destroyed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayImpactRumble;
    /// <summary>
    /// Function: PlayImpactRumble
    /// </summary>
    public unsafe virtual void PlayImpactRumble(float LeftAmp = default, float RightAmp = default, float Duration = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayImpactRumble, "BmGame.RPlayerControllerCombat.PlayImpactRumble");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeftAmp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RightAmp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NavManWTF;
    /// <summary>
    /// Function: NavManWTF
    /// </summary>
    public unsafe virtual void NavManWTF()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavManWTF, "BmGame.RPlayerControllerCombat.NavManWTF");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AIWTF;
    /// <summary>
    /// Function: AIWTF
    /// </summary>
    public unsafe virtual void AIWTF()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AIWTF, "BmGame.RPlayerControllerCombat.AIWTF");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TutorialWTF;
    /// <summary>
    /// Function: TutorialWTF
    /// </summary>
    public unsafe virtual void TutorialWTF()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TutorialWTF, "BmGame.RPlayerControllerCombat.TutorialWTF");
        byte* paramsPtr = stackalloc byte[13];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PairedAnimWTF;
    /// <summary>
    /// Function: PairedAnimWTF
    /// </summary>
    public unsafe virtual void PairedAnimWTF()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PairedAnimWTF, "BmGame.RPlayerControllerCombat.PairedAnimWTF");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StrikeWTF;
    /// <summary>
    /// Function: StrikeWTF
    /// </summary>
    public unsafe virtual void StrikeWTF()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StrikeWTF, "BmGame.RPlayerControllerCombat.StrikeWTF");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatWTF;
    /// <summary>
    /// Function: CombatWTF
    /// </summary>
    public unsafe virtual void CombatWTF()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatWTF, "BmGame.RPlayerControllerCombat.CombatWTF");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuppressVenomCamera;
    /// <summary>
    /// Function: SuppressVenomCamera
    /// </summary>
    public unsafe override bool SuppressVenomCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuppressVenomCamera, "BmGame.RPlayerControllerCombat.SuppressVenomCamera");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SuppressCombatCamera;
    /// <summary>
    /// Function: SuppressCombatCamera
    /// </summary>
    public unsafe override bool SuppressCombatCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuppressCombatCamera, "BmGame.RPlayerControllerCombat.SuppressCombatCamera");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldGoSlowMoOnNextHit;
    /// <summary>
    /// Function: ShouldGoSlowMoOnNextHit
    /// </summary>
    public unsafe virtual bool ShouldGoSlowMoOnNextHit(int ComboInc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldGoSlowMoOnNextHit, "BmGame.RPlayerControllerCombat.ShouldGoSlowMoOnNextHit");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboInc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateCombatCameraSuppression;
    /// <summary>
    /// Function: UpdateCombatCameraSuppression
    /// </summary>
    public unsafe virtual void UpdateCombatCameraSuppression()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCombatCameraSuppression, "BmGame.RPlayerControllerCombat.UpdateCombatCameraSuppression");
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

    private static BmSDK.Function __fn_CombatTick;
    /// <summary>
    /// Function: CombatTick
    /// </summary>
    public unsafe override void CombatTick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatTick, "BmGame.RPlayerControllerCombat.CombatTick");
        byte* paramsPtr = stackalloc byte[192];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateCombatHUD;
    /// <summary>
    /// Function: UpdateCombatHUD
    /// </summary>
    public unsafe override void UpdateCombatHUD()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCombatHUD, "BmGame.RPlayerControllerCombat.UpdateCombatHUD");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyFixedCombatCam;
    /// <summary>
    /// Function: DestroyFixedCombatCam
    /// </summary>
    public unsafe virtual void DestroyFixedCombatCam()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyFixedCombatCam, "BmGame.RPlayerControllerCombat.DestroyFixedCombatCam");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateFixedCamera;
    /// <summary>
    /// Function: UpdateFixedCamera
    /// </summary>
    public unsafe virtual void UpdateFixedCamera(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFixedCamera, "BmGame.RPlayerControllerCombat.UpdateFixedCamera");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveFixedCamRotationTowardsPlayer;
    /// <summary>
    /// Function: MoveFixedCamRotationTowardsPlayer
    /// </summary>
    public unsafe virtual void MoveFixedCamRotationTowardsPlayer(float YawFollowPercent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveFixedCamRotationTowardsPlayer, "BmGame.RPlayerControllerCombat.MoveFixedCamRotationTowardsPlayer");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YawFollowPercent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFixedCamRotation;
    /// <summary>
    /// Function: GetFixedCamRotation
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetFixedCamRotation(BmSDK.Rotator baseRot, BmSDK.Rotator RotRange, float MinDist, float MaxDist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFixedCamRotation, "BmGame.RPlayerControllerCombat.GetFixedCamRotation");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(baseRot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RotRange, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinDist, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDist, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetFixedCamLocation;
    /// <summary>
    /// Function: GetFixedCamLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFixedCamLocation(System.Numerics.Vector3 BaseLoc, System.Numerics.Vector3 LocRange, float MinDist, float MaxDist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFixedCamLocation, "BmGame.RPlayerControllerCombat.GetFixedCamLocation");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocRange, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinDist, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDist, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetFixedCamFOV;
    /// <summary>
    /// Function: GetFixedCamFOV
    /// </summary>
    public unsafe virtual float GetFixedCamFOV(float BaseFOV, float FovRange, float MinDist, float MaxDist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFixedCamFOV, "BmGame.RPlayerControllerCombat.GetFixedCamFOV");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseFOV, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FovRange, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinDist, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDist, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SpawnFinishedCombatMove;
    /// <summary>
    /// Function: SpawnFinishedCombatMove
    /// </summary>
    public unsafe override void SpawnFinishedCombatMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFinishedCombatMove, "BmGame.RPlayerControllerCombat.SpawnFinishedCombatMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueFinishedCombatMove;
    /// <summary>
    /// Function: QueueFinishedCombatMove
    /// </summary>
    public unsafe virtual void QueueFinishedCombatMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueFinishedCombatMove, "BmGame.RPlayerControllerCombat.QueueFinishedCombatMove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetComboOnHUD;
    /// <summary>
    /// Function: SetComboOnHUD
    /// </summary>
    public unsafe virtual void SetComboOnHUD()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetComboOnHUD, "BmGame.RPlayerControllerCombat.SetComboOnHUD");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateComboOnHUD;
    /// <summary>
    /// Function: UpdateComboOnHUD
    /// </summary>
    public unsafe virtual void UpdateComboOnHUD()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateComboOnHUD, "BmGame.RPlayerControllerCombat.UpdateComboOnHUD");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActualClearLastStrikeDir;
    /// <summary>
    /// Function: ActualClearLastStrikeDir
    /// </summary>
    public unsafe virtual void ActualClearLastStrikeDir()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActualClearLastStrikeDir, "BmGame.RPlayerControllerCombat.ActualClearLastStrikeDir");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLastStrikeDir;
    /// <summary>
    /// Function: ClearLastStrikeDir
    /// </summary>
    public unsafe virtual void ClearLastStrikeDir()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLastStrikeDir, "BmGame.RPlayerControllerCombat.ClearLastStrikeDir");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLastStrikeDir;
    /// <summary>
    /// Function: SetLastStrikeDir
    /// </summary>
    public unsafe virtual void SetLastStrikeDir(System.Numerics.Vector3 StrikeDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLastStrikeDir, "BmGame.RPlayerControllerCombat.SetLastStrikeDir");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsTargetted;
    /// <summary>
    /// Function: IsTargetted
    /// </summary>
    public unsafe virtual bool IsTargetted(BmSDK.BmGame.RPawnCombat IgnoreTargetter = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTargetted, "BmGame.RPlayerControllerCombat.IsTargetted");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreTargetter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_Untargetted;
    /// <summary>
    /// Function: Untargetted
    /// </summary>
    public unsafe virtual void Untargetted(BmSDK.BmGame.RPawnCombat Targetter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Untargetted, "BmGame.RPlayerControllerCombat.Untargetted");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Targetter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Targetted;
    /// <summary>
    /// Function: Targetted
    /// </summary>
    public unsafe virtual void Targetted(BmSDK.BmGame.RPawnCombat Targetter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Targetted, "BmGame.RPlayerControllerCombat.Targetted");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Targetter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Lasered;
    /// <summary>
    /// Function: Lasered
    /// </summary>
    public unsafe virtual void Lasered()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Lasered, "BmGame.RPlayerControllerCombat.Lasered");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Zapped;
    /// <summary>
    /// Function: Zapped
    /// </summary>
    public unsafe virtual void Zapped()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Zapped, "BmGame.RPlayerControllerCombat.Zapped");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Stunned;
    /// <summary>
    /// Function: Stunned
    /// </summary>
    public unsafe virtual void Stunned(bool bDontPlaySfx = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Stunned, "BmGame.RPlayerControllerCombat.Stunned");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDontPlaySfx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckDodge;
    /// <summary>
    /// Function: CheckDodge
    /// </summary>
    public unsafe virtual void CheckDodge(BmSDK.BmGame.RPawnCombat Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckDodge, "BmGame.RPlayerControllerCombat.CheckDodge");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnRunningStun;
    /// <summary>
    /// Function: SpawnRunningStun
    /// </summary>
    public unsafe virtual void SpawnRunningStun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnRunningStun, "BmGame.RPlayerControllerCombat.SpawnRunningStun");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnRunningStrike;
    /// <summary>
    /// Function: SpawnRunningStrike
    /// </summary>
    public unsafe virtual void SpawnRunningStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnRunningStrike, "BmGame.RPlayerControllerCombat.SpawnRunningStrike");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBatmobileTakedownReady;
    /// <summary>
    /// Function: IsBatmobileTakedownReady
    /// </summary>
    public unsafe virtual bool IsBatmobileTakedownReady()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatmobileTakedownReady, "BmGame.RPlayerControllerCombat.IsBatmobileTakedownReady");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBatmobileTakedownAllowed;
    /// <summary>
    /// Function: IsBatmobileTakedownAllowed
    /// </summary>
    public unsafe virtual bool IsBatmobileTakedownAllowed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatmobileTakedownAllowed, "BmGame.RPlayerControllerCombat.IsBatmobileTakedownAllowed");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldShowSpecialPrompt;
    /// <summary>
    /// Function: ShouldShowSpecialPrompt
    /// </summary>
    public unsafe virtual bool ShouldShowSpecialPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldShowSpecialPrompt, "BmGame.RPlayerControllerCombat.ShouldShowSpecialPrompt");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpecialUnlocked;
    /// <summary>
    /// Function: SpecialUnlocked
    /// </summary>
    public unsafe virtual bool SpecialUnlocked()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialUnlocked, "BmGame.RPlayerControllerCombat.SpecialUnlocked");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDoDualPlayTakedown;
    /// <summary>
    /// Function: CanDoDualPlayTakedown
    /// </summary>
    public unsafe virtual bool CanDoDualPlayTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoDualPlayTakedown, "BmGame.RPlayerControllerCombat.CanDoDualPlayTakedown");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDoSecondaryGroupCombatMove;
    /// <summary>
    /// Function: CanDoSecondaryGroupCombatMove
    /// </summary>
    public unsafe virtual bool CanDoSecondaryGroupCombatMove(bool bDoComboCountCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoSecondaryGroupCombatMove, "BmGame.RPlayerControllerCombat.CanDoSecondaryGroupCombatMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanDoPrimaryGroupCombatMove;
    /// <summary>
    /// Function: CanDoPrimaryGroupCombatMove
    /// </summary>
    public unsafe virtual bool CanDoPrimaryGroupCombatMove(bool bDoComboCountCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoPrimaryGroupCombatMove, "BmGame.RPlayerControllerCombat.CanDoPrimaryGroupCombatMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanDoWeaponSnatch;
    /// <summary>
    /// Function: CanDoWeaponSnatch
    /// </summary>
    public unsafe virtual bool CanDoWeaponSnatch(bool bDoComboCountCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoWeaponSnatch, "BmGame.RPlayerControllerCombat.CanDoWeaponSnatch");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanDoWeaponDestroy;
    /// <summary>
    /// Function: CanDoWeaponDestroy
    /// </summary>
    public unsafe virtual bool CanDoWeaponDestroy(bool bDoComboCountCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoWeaponDestroy, "BmGame.RPlayerControllerCombat.CanDoWeaponDestroy");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanDoCombatTakedown;
    /// <summary>
    /// Function: CanDoCombatTakedown
    /// </summary>
    public unsafe virtual bool CanDoCombatTakedown(bool bDoComboCountCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoCombatTakedown, "BmGame.RPlayerControllerCombat.CanDoCombatTakedown");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanDoThrow;
    /// <summary>
    /// Function: CanDoThrow
    /// </summary>
    public unsafe virtual bool CanDoThrow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoThrow, "BmGame.RPlayerControllerCombat.CanDoThrow");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ServerSpawnFailMove;
    /// <summary>
    /// Function: ServerSpawnFailMove
    /// </summary>
    public unsafe virtual void ServerSpawnFailMove(BmSDK.FName FailAnim, bool bCanBecomeThrow, bool bCanBecomeTakedown, bool bCanBecomeFloorTakedown, BmSDK.FName FailCapeState, System.Numerics.Vector3 MoveDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSpawnFailMove, "BmGame.RPlayerControllerCombat.ServerSpawnFailMove");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailAnim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeThrow, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeTakedown, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeFloorTakedown, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailCapeState, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerRequestComboTakedown;
    /// <summary>
    /// Function: ServerRequestComboTakedown
    /// </summary>
    public unsafe virtual void ServerRequestComboTakedown(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.BmGame.RPawnPlayerCombat.FTakedownInfo Info, float CollisionDist, System.Numerics.Vector3 Dir, float Dist, BmSDK.BmGame.RPawnPlayerCombat.ETakedownType takedownType, float HitTimeForward, float HitTimeBackward, bool FoundInValidDirection, bool InstantStart, System.Numerics.Vector3 AnimPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRequestComboTakedown, "BmGame.RPlayerControllerCombat.ServerRequestComboTakedown");
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionDist, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dist, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedownType, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitTimeForward, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitTimeBackward, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FoundInValidDirection, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstantStart, paramsPtr + 92);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnInterrogation;
    /// <summary>
    /// Function: SpawnInterrogation
    /// </summary>
    public unsafe virtual bool SpawnInterrogation(BmSDK.BmGame.RPawnVillain NewTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnInterrogation, "BmGame.RPlayerControllerCombat.SpawnInterrogation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TrySpawnDualComboTakedown;
    /// <summary>
    /// Function: TrySpawnDualComboTakedown
    /// </summary>
    public unsafe virtual bool TrySpawnDualComboTakedown(bool bOverrideCurrentMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrySpawnDualComboTakedown, "BmGame.RPlayerControllerCombat.TrySpawnDualComboTakedown");
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TrySpawnDualPlayClash;
    /// <summary>
    /// Function: TrySpawnDualPlayClash
    /// </summary>
    public unsafe virtual bool TrySpawnDualPlayClash(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrySpawnDualPlayClash, "BmGame.RPlayerControllerCombat.TrySpawnDualPlayClash");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FindDualPlayClashTarget;
    /// <summary>
    /// Function: FindDualPlayClashTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain FindDualPlayClashTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindDualPlayClashTarget, "BmGame.RPlayerControllerCombat.FindDualPlayClashTarget");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnTakedown;
    /// <summary>
    /// Function: SpawnTakedown
    /// </summary>
    public unsafe virtual bool SpawnTakedown(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnTakedown, "BmGame.RPlayerControllerCombat.SpawnTakedown");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FindTakedownTarget;
    /// <summary>
    /// Function: FindTakedownTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain FindTakedownTarget(BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindTakedownTarget, "BmGame.RPlayerControllerCombat.FindTakedownTarget");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TryTakedown;
    /// <summary>
    /// Function: TryTakedown
    /// </summary>
    public unsafe virtual bool TryTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryTakedown, "BmGame.RPlayerControllerCombat.TryTakedown");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsValidThrowTarget;
    /// <summary>
    /// Function: IsValidThrowTarget
    /// </summary>
    public unsafe virtual bool IsValidThrowTarget(BmSDK.BmGame.RPawnVillain Target, System.Numerics.Vector3 MoveDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidThrowTarget, "BmGame.RPlayerControllerCombat.IsValidThrowTarget");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_TrySpawnWeaponSnatch;
    /// <summary>
    /// Function: TrySpawnWeaponSnatch
    /// </summary>
    public unsafe virtual bool TrySpawnWeaponSnatch(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrySpawnWeaponSnatch, "BmGame.RPlayerControllerCombat.TrySpawnWeaponSnatch");
        byte* paramsPtr = stackalloc byte[124];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnWeaponDestroy;
    /// <summary>
    /// Function: SpawnWeaponDestroy
    /// </summary>
    public unsafe virtual bool SpawnWeaponDestroy(bool bOverrideCurrentMove = default, BmSDK.BmGame.RPawnVillain NewTarget = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnWeaponDestroy, "BmGame.RPlayerControllerCombat.SpawnWeaponDestroy");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ServerRequestThrow;
    /// <summary>
    /// Function: ServerRequestThrow
    /// </summary>
    public unsafe virtual void ServerRequestThrow(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnPlayerCombat.FThrowInfo ThrowInfo, System.Numerics.Vector3 AnimPos, BmSDK.Rotator ThrowDir, bool bSetCapeState, bool bDirectThrow)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRequestThrow, "BmGame.RPlayerControllerCombat.ServerRequestThrow");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowInfo, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetCapeState, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDirectThrow, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerRequestIntoThrow;
    /// <summary>
    /// Function: ServerRequestIntoThrow
    /// </summary>
    public unsafe virtual void ServerRequestIntoThrow(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnCombat.TargetStrikeResponse TargetResponse, BmSDK.Rotator MoveDir, float TargetDist, System.Numerics.Vector3 AnimPos, float AnimRot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRequestIntoThrow, "BmGame.RPlayerControllerCombat.ServerRequestIntoThrow");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetResponse, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetDist, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimRot, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnThrow;
    /// <summary>
    /// Function: SpawnThrow
    /// </summary>
    public unsafe virtual bool SpawnThrow(bool bOverrideCurrentMove = default, BmSDK.BmGame.RPawnVillain NewTarget = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnThrow, "BmGame.RPlayerControllerCombat.SpawnThrow");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_TryThrow;
    /// <summary>
    /// Function: TryThrow
    /// </summary>
    public unsafe virtual bool TryThrow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryThrow, "BmGame.RPlayerControllerCombat.TryThrow");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ServerRequestFloorTakedownSimulated;
    /// <summary>
    /// Function: ServerRequestFloorTakedownSimulated
    /// </summary>
    public unsafe virtual void ServerRequestFloorTakedownSimulated(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.BmGame.RGameInfo.EGameAction ChallengeActionToTriggerIfSuccessful, float TargetDist, System.Numerics.Vector3 AnimPos, System.Numerics.Vector3 FacingDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRequestFloorTakedownSimulated, "BmGame.RPlayerControllerCombat.ServerRequestFloorTakedownSimulated");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeActionToTriggerIfSuccessful, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetDist, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryFloorTakedown;
    /// <summary>
    /// Function: TryFloorTakedown
    /// </summary>
    public unsafe virtual bool TryFloorTakedown(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryFloorTakedown, "BmGame.RPlayerControllerCombat.TryFloorTakedown");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TryFloorStrike;
    /// <summary>
    /// Function: TryFloorStrike
    /// </summary>
    public unsafe virtual bool TryFloorStrike(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryFloorStrike, "BmGame.RPlayerControllerCombat.TryFloorStrike");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TryFloorPickupThug;
    /// <summary>
    /// Function: TryFloorPickupThug
    /// </summary>
    public unsafe override bool TryFloorPickupThug(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryFloorPickupThug, "BmGame.RPlayerControllerCombat.TryFloorPickupThug");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetLastAttackTarget;
    /// <summary>
    /// Function: SetLastAttackTarget
    /// </summary>
    public unsafe virtual void SetLastAttackTarget(BmSDK.BmGame.RPawnVillain Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLastAttackTarget, "BmGame.RPlayerControllerCombat.SetLastAttackTarget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerRequestProjectileCounter;
    /// <summary>
    /// Function: ServerRequestProjectileCounter
    /// </summary>
    public unsafe virtual void ServerRequestProjectileCounter(BmSDK.BmGame.RBMCombatThrownObject ThrownObject)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRequestProjectileCounter, "BmGame.RPlayerControllerCombat.ServerRequestProjectileCounter");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerRequestCounter;
    /// <summary>
    /// Function: ServerRequestCounter
    /// </summary>
    public unsafe virtual void ServerRequestCounter(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.Class CounterDmgType, int CounterInfoIndex, float CounterRot, System.Numerics.Vector3 AnimPos, bool bFinalBlow)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRequestCounter, "BmGame.RPlayerControllerCombat.ServerRequestCounter");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterDmgType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterInfoIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterRot, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinalBlow, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryBossCounter;
    /// <summary>
    /// Function: TryBossCounter
    /// </summary>
    public unsafe virtual bool TryBossCounter(BmSDK.BmGame.RPawnVillain targ)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryBossCounter, "BmGame.RPlayerControllerCombat.TryBossCounter");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(targ, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TryProjectileCounter;
    /// <summary>
    /// Function: TryProjectileCounter
    /// </summary>
    public unsafe virtual bool TryProjectileCounter(bool bCanCheckLongRange)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryProjectileCounter, "BmGame.RPlayerControllerCombat.TryProjectileCounter");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanCheckLongRange, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TryCounter;
    /// <summary>
    /// Function: TryCounter
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayerCombat.ETryCounterResult TryCounter(bool bCanFail, float TimeInitiatedByPlayer = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryCounter, "BmGame.RPlayerControllerCombat.TryCounter");
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanFail, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.ETryCounterResult>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TrySimultaneousCounter;
    /// <summary>
    /// Function: TrySimultaneousCounter
    /// </summary>
    public unsafe virtual bool TrySimultaneousCounter(bool bCanStartMove, float TimeInitiatedByPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrySimultaneousCounter, "BmGame.RPlayerControllerCombat.TrySimultaneousCounter");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanStartMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TryStun;
    /// <summary>
    /// Function: TryStun
    /// </summary>
    public unsafe virtual bool TryStun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryStun, "BmGame.RPlayerControllerCombat.TryStun");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStunMove;
    /// <summary>
    /// Function: GetStunMove
    /// </summary>
    public unsafe virtual BmSDK.Class GetStunMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStunMove, "BmGame.RPlayerControllerCombat.GetStunMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ServerSpawnSpecialMove;
    /// <summary>
    /// Function: ServerSpawnSpecialMove
    /// </summary>
    public unsafe virtual void ServerSpawnSpecialMove(BmSDK.Class MoveClass, System.Numerics.Vector3 AnimPos, BmSDK.Rotator AnimRot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSpawnSpecialMove, "BmGame.RPlayerControllerCombat.ServerSpawnSpecialMove");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimRot, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerRequestStrike;
    /// <summary>
    /// Function: ServerRequestStrike
    /// </summary>
    public unsafe virtual void ServerRequestStrike(BmSDK.Class StrikeClass, BmSDK.BmGame.RPawnVillain Target, BmSDK.Class dmgType, int StrikeInfoIndex, bool bOverrideTargetStrike, float Dir, int Combo, BmSDK.BmGame.RPawnCombat.TargetStrikeResponse TargetResponse)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRequestStrike, "BmGame.RPlayerControllerCombat.ServerRequestStrike");
        byte* paramsPtr = stackalloc byte[41];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeInfoIndex, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideTargetStrike, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Combo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetResponse, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryAirStrike;
    /// <summary>
    /// Function: TryAirStrike
    /// </summary>
    public unsafe virtual bool TryAirStrike(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryAirStrike, "BmGame.RPlayerControllerCombat.TryAirStrike");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TryStrike;
    /// <summary>
    /// Function: TryStrike
    /// </summary>
    public unsafe virtual bool TryStrike(float TimeInitiatedByPlayer = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryStrike, "BmGame.RPlayerControllerCombat.TryStrike");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBatclawStunTarget;
    /// <summary>
    /// Function: GetBatclawStunTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain GetBatclawStunTarget(BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatclawStunTarget, "BmGame.RPlayerControllerCombat.GetBatclawStunTarget");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetBatclawSlamTarget;
    /// <summary>
    /// Function: GetBatclawSlamTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain GetBatclawSlamTarget(BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatclawSlamTarget, "BmGame.RPlayerControllerCombat.GetBatclawSlamTarget");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetQuickStrikeDamageType;
    /// <summary>
    /// Function: GetQuickStrikeDamageType
    /// </summary>
    public unsafe virtual BmSDK.Class GetQuickStrikeDamageType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetQuickStrikeDamageType, "BmGame.RPlayerControllerCombat.GetQuickStrikeDamageType");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetQuickStrikeType;
    /// <summary>
    /// Function: GetQuickStrikeType
    /// </summary>
    public unsafe virtual BmSDK.Class GetQuickStrikeType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetQuickStrikeType, "BmGame.RPlayerControllerCombat.GetQuickStrikeType");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHeavyStrikeType;
    /// <summary>
    /// Function: GetHeavyStrikeType
    /// </summary>
    public unsafe virtual BmSDK.Class GetHeavyStrikeType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeavyStrikeType, "BmGame.RPlayerControllerCombat.GetHeavyStrikeType");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHeavyStrikeDamageType;
    /// <summary>
    /// Function: GetHeavyStrikeDamageType
    /// </summary>
    public unsafe virtual BmSDK.Class GetHeavyStrikeDamageType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeavyStrikeDamageType, "BmGame.RPlayerControllerCombat.GetHeavyStrikeDamageType");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCriticalStrikeDamageType;
    /// <summary>
    /// Function: GetCriticalStrikeDamageType
    /// </summary>
    public unsafe virtual BmSDK.Class GetCriticalStrikeDamageType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCriticalStrikeDamageType, "BmGame.RPlayerControllerCombat.GetCriticalStrikeDamageType");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryBarge;
    /// <summary>
    /// Function: TryBarge
    /// </summary>
    public unsafe virtual bool TryBarge(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryBarge, "BmGame.RPlayerControllerCombat.TryBarge");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StartRun;
    /// <summary>
    /// Function: StartRun
    /// </summary>
    public unsafe override void StartRun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartRun, "BmGame.RPlayerControllerCombat.StartRun");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerGroundTakedown;
    /// <summary>
    /// Function: TriggerGroundTakedown
    /// </summary>
    public unsafe override bool TriggerGroundTakedown(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerGroundTakedown, "BmGame.RPlayerControllerCombat.TriggerGroundTakedown");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TriggerCounter;
    /// <summary>
    /// Function: TriggerCounter
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnPlayerCombat.ETryCounterResult TriggerCounter(bool bCanFail)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCounter, "BmGame.RPlayerControllerCombat.TriggerCounter");
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanFail, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.ETryCounterResult>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TryToStartCombatInterrogation;
    /// <summary>
    /// Function: TryToStartCombatInterrogation
    /// </summary>
    public unsafe virtual bool TryToStartCombatInterrogation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToStartCombatInterrogation, "BmGame.RPlayerControllerCombat.TryToStartCombatInterrogation");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryToStartCombatTakeDown;
    /// <summary>
    /// Function: TryToStartCombatTakeDown
    /// </summary>
    public unsafe override bool TryToStartCombatTakeDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToStartCombatTakeDown, "BmGame.RPlayerControllerCombat.TryToStartCombatTakeDown");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BankPoints;
    /// <summary>
    /// Function: BankPoints
    /// </summary>
    public unsafe virtual void BankPoints()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BankPoints, "BmGame.RPlayerControllerCombat.BankPoints");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BankPointsInternal;
    /// <summary>
    /// Function: BankPointsInternal
    /// </summary>
    public unsafe virtual void BankPointsInternal()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BankPointsInternal, "BmGame.RPlayerControllerCombat.BankPointsInternal");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GrabReleased;
    /// <summary>
    /// Function: GrabReleased
    /// </summary>
    public unsafe override void GrabReleased()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrabReleased, "BmGame.RPlayerControllerCombat.GrabReleased");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TrySecondaryGroupCombatMove;
    /// <summary>
    /// Function: TrySecondaryGroupCombatMove
    /// </summary>
    public unsafe virtual bool TrySecondaryGroupCombatMove(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrySecondaryGroupCombatMove, "BmGame.RPlayerControllerCombat.TrySecondaryGroupCombatMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TryPrimaryGroupCombatMove;
    /// <summary>
    /// Function: TryPrimaryGroupCombatMove
    /// </summary>
    public unsafe virtual bool TryPrimaryGroupCombatMove(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryPrimaryGroupCombatMove, "BmGame.RPlayerControllerCombat.TryPrimaryGroupCombatMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GrabPressed;
    /// <summary>
    /// Function: GrabPressed
    /// </summary>
    public unsafe override void GrabPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrabPressed, "BmGame.RPlayerControllerCombat.GrabPressed");
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FloorTakedownModifierReleased;
    /// <summary>
    /// Function: FloorTakedownModifierReleased
    /// </summary>
    public unsafe virtual void FloorTakedownModifierReleased()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FloorTakedownModifierReleased, "BmGame.RPlayerControllerCombat.FloorTakedownModifierReleased");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FloorTakedownModifierPressed;
    /// <summary>
    /// Function: FloorTakedownModifierPressed
    /// </summary>
    public unsafe virtual void FloorTakedownModifierPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FloorTakedownModifierPressed, "BmGame.RPlayerControllerCombat.FloorTakedownModifierPressed");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlockBreakerReleased;
    /// <summary>
    /// Function: BlockBreakerReleased
    /// </summary>
    public unsafe virtual void BlockBreakerReleased()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlockBreakerReleased, "BmGame.RPlayerControllerCombat.BlockBreakerReleased");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoCapeStun;
    /// <summary>
    /// Function: DoCapeStun
    /// </summary>
    public unsafe virtual void DoCapeStun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoCapeStun, "BmGame.RPlayerControllerCombat.DoCapeStun");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CapeStunTimer;
    /// <summary>
    /// Function: CapeStunTimer
    /// </summary>
    public unsafe virtual void CapeStunTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CapeStunTimer, "BmGame.RPlayerControllerCombat.CapeStunTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerBlockBreaker;
    /// <summary>
    /// Function: TriggerBlockBreaker
    /// </summary>
    public unsafe override void TriggerBlockBreaker()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerBlockBreaker, "BmGame.RPlayerControllerCombat.TriggerBlockBreaker");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerSecondaryGroupCombatMove;
    /// <summary>
    /// Function: TriggerSecondaryGroupCombatMove
    /// </summary>
    public unsafe virtual void TriggerSecondaryGroupCombatMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSecondaryGroupCombatMove, "BmGame.RPlayerControllerCombat.TriggerSecondaryGroupCombatMove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerPrimaryGroupCombatMove;
    /// <summary>
    /// Function: TriggerPrimaryGroupCombatMove
    /// </summary>
    public unsafe virtual void TriggerPrimaryGroupCombatMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPrimaryGroupCombatMove, "BmGame.RPlayerControllerCombat.TriggerPrimaryGroupCombatMove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCombatTakedown;
    /// <summary>
    /// Function: TriggerCombatTakedown
    /// </summary>
    public unsafe virtual void TriggerCombatTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCombatTakedown, "BmGame.RPlayerControllerCombat.TriggerCombatTakedown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerWeaponDestroy;
    /// <summary>
    /// Function: TriggerWeaponDestroy
    /// </summary>
    public unsafe virtual void TriggerWeaponDestroy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerWeaponDestroy, "BmGame.RPlayerControllerCombat.TriggerWeaponDestroy");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerThrow;
    /// <summary>
    /// Function: TriggerThrow
    /// </summary>
    public unsafe virtual void TriggerThrow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerThrow, "BmGame.RPlayerControllerCombat.TriggerThrow");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerQuickStrike;
    /// <summary>
    /// Function: TriggerQuickStrike
    /// </summary>
    public unsafe override void TriggerQuickStrike()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerQuickStrike, "BmGame.RPlayerControllerCombat.TriggerQuickStrike");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NewComboMoveStarted;
    /// <summary>
    /// Function: NewComboMoveStarted
    /// </summary>
    public unsafe virtual void NewComboMoveStarted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NewComboMoveStarted, "BmGame.RPlayerControllerCombat.NewComboMoveStarted");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateRunningTimers;
    /// <summary>
    /// Function: UpdateRunningTimers
    /// </summary>
    public unsafe virtual void UpdateRunningTimers(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRunningTimers, "BmGame.RPlayerControllerCombat.UpdateRunningTimers");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRoomChange;
    /// <summary>
    /// Function: OnRoomChange
    /// </summary>
    public unsafe override void OnRoomChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRoomChange, "BmGame.RPlayerControllerCombat.OnRoomChange");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyTakeDamage;
    /// <summary>
    /// Function: NotifyTakeDamage
    /// </summary>
    public unsafe override void NotifyTakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyTakeDamage, "BmGame.RPlayerControllerCombat.NotifyTakeDamage");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 84);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateCombatHitVars;
    /// <summary>
    /// Function: UpdateCombatHitVars
    /// </summary>
    public unsafe virtual void UpdateCombatHitVars(BmSDK.Engine.Controller InstigatedBy, int Damage, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCombatHitVars, "BmGame.RPlayerControllerCombat.UpdateCombatHitVars");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddScore;
    /// <summary>
    /// Function: AddScore
    /// </summary>
    public unsafe virtual void AddScore(int Amount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddScore, "BmGame.RPlayerControllerCombat.AddScore");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddScoreForMove;
    /// <summary>
    /// Function: AddScoreForMove
    /// </summary>
    public unsafe virtual void AddScoreForMove(BmSDK.BmGame.RGameInfo.EComboMoveType MoveType, int ComboMultiplier, BmSDK.BmGame.RPawnCombat Target, int NumTargets)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddScoreForMove, "BmGame.RPlayerControllerCombat.AddScoreForMove");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboMultiplier, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumTargets, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffCounterPrompt;
    /// <summary>
    /// Function: TurnOffCounterPrompt
    /// </summary>
    public unsafe virtual void TurnOffCounterPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffCounterPrompt, "BmGame.RPlayerControllerCombat.TurnOffCounterPrompt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnCounterPrompt;
    /// <summary>
    /// Function: TurnOnCounterPrompt
    /// </summary>
    public unsafe virtual void TurnOnCounterPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnCounterPrompt, "BmGame.RPlayerControllerCombat.TurnOnCounterPrompt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetComboLevel;
    /// <summary>
    /// Function: GetComboLevel
    /// </summary>
    public unsafe virtual int GetComboLevel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboLevel, "BmGame.RPlayerControllerCombat.GetComboLevel");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDoSpecialMove;
    /// <summary>
    /// Function: CanDoSpecialMove
    /// </summary>
    public unsafe virtual bool CanDoSpecialMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoSpecialMove, "BmGame.RPlayerControllerCombat.CanDoSpecialMove");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpecialMoveTargetInRange;
    /// <summary>
    /// Function: SpecialMoveTargetInRange
    /// </summary>
    public unsafe virtual bool SpecialMoveTargetInRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialMoveTargetInRange, "BmGame.RPlayerControllerCombat.SpecialMoveTargetInRange");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateComboStatus;
    /// <summary>
    /// Function: UpdateComboStatus
    /// </summary>
    public unsafe override void UpdateComboStatus(BmSDK.BmGame.RPawnPlayerCombat CurrentPawn, BmSDK.BmGame.RPawnPlayerCombat NewPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateComboStatus, "BmGame.RPlayerControllerCombat.UpdateComboStatus");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetComboLength;
    /// <summary>
    /// Function: GetComboLength
    /// </summary>
    public unsafe virtual int GetComboLength()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboLength, "BmGame.RPlayerControllerCombat.GetComboLength");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumAwayFromCombo;
    /// <summary>
    /// Function: GetNumAwayFromCombo
    /// </summary>
    public unsafe virtual int GetNumAwayFromCombo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumAwayFromCombo, "BmGame.RPlayerControllerCombat.GetNumAwayFromCombo");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInComboForSuper;
    /// <summary>
    /// Function: IsInComboForSuper
    /// </summary>
    public unsafe virtual bool IsInComboForSuper()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInComboForSuper, "BmGame.RPlayerControllerCombat.IsInComboForSuper");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInCombo;
    /// <summary>
    /// Function: IsInCombo
    /// </summary>
    public unsafe virtual bool IsInCombo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInCombo, "BmGame.RPlayerControllerCombat.IsInCombo");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetComboMinLength;
    /// <summary>
    /// Function: GetComboMinLength
    /// </summary>
    public unsafe virtual int GetComboMinLength()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboMinLength, "BmGame.RPlayerControllerCombat.GetComboMinLength");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanContinueCombo;
    /// <summary>
    /// Function: CanContinueCombo
    /// </summary>
    public unsafe virtual bool CanContinueCombo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanContinueCombo, "BmGame.RPlayerControllerCombat.CanContinueCombo");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DisableCombo;
    /// <summary>
    /// Function: DisableCombo
    /// </summary>
    public unsafe virtual void DisableCombo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableCombo, "BmGame.RPlayerControllerCombat.DisableCombo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ContinueComboTimerComplete;
    /// <summary>
    /// Function: ContinueComboTimerComplete
    /// </summary>
    public unsafe virtual void ContinueComboTimerComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ContinueComboTimerComplete, "BmGame.RPlayerControllerCombat.ContinueComboTimerComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetComboTimerIfComboTimerRunning;
    /// <summary>
    /// Function: SetComboTimerIfComboTimerRunning
    /// </summary>
    public unsafe override void SetComboTimerIfComboTimerRunning(float TimeToSet)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetComboTimerIfComboTimerRunning, "BmGame.RPlayerControllerCombat.SetComboTimerIfComboTimerRunning");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeToSet, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetContinueComboTimer;
    /// <summary>
    /// Function: SetContinueComboTimer
    /// </summary>
    public unsafe virtual void SetContinueComboTimer(float ComboWindow = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetContinueComboTimer, "BmGame.RPlayerControllerCombat.SetContinueComboTimer");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboWindow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CriticalComboMoveFailed;
    /// <summary>
    /// Function: CriticalComboMoveFailed
    /// </summary>
    public unsafe virtual void CriticalComboMoveFailed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CriticalComboMoveFailed, "BmGame.RPlayerControllerCombat.CriticalComboMoveFailed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CriticalBeatdownPerformed;
    /// <summary>
    /// Function: CriticalBeatdownPerformed
    /// </summary>
    public unsafe virtual void CriticalBeatdownPerformed(int NumPerformed = default, bool bShowOnHud = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CriticalBeatdownPerformed, "BmGame.RPlayerControllerCombat.CriticalBeatdownPerformed");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumPerformed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowOnHud, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CriticalComboMovePerformed;
    /// <summary>
    /// Function: CriticalComboMovePerformed
    /// </summary>
    public unsafe virtual void CriticalComboMovePerformed(int NumPerformed = default, bool bShowOnHud = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CriticalComboMovePerformed, "BmGame.RPlayerControllerCombat.CriticalComboMovePerformed");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumPerformed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowOnHud, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnDropWeaponMove;
    /// <summary>
    /// Function: SpawnDropWeaponMove
    /// </summary>
    public unsafe virtual void SpawnDropWeaponMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDropWeaponMove, "BmGame.RPlayerControllerCombat.SpawnDropWeaponMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearCombo;
    /// <summary>
    /// Function: ClearCombo
    /// </summary>
    public unsafe override void ClearCombo(BmSDK.FString Reason, bool bForceDropWeapon = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCombo, "BmGame.RPlayerControllerCombat.ClearCombo");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDropWeapon, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCombatMoveDurationMulti;
    /// <summary>
    /// Function: GetCombatMoveDurationMulti
    /// </summary>
    public unsafe virtual float GetCombatMoveDurationMulti()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatMoveDurationMulti, "BmGame.RPlayerControllerCombat.GetCombatMoveDurationMulti");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TurnOffFinalBlowPP;
    /// <summary>
    /// Function: TurnOffFinalBlowPP
    /// </summary>
    public unsafe virtual void TurnOffFinalBlowPP()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffFinalBlowPP, "BmGame.RPlayerControllerCombat.TurnOffFinalBlowPP");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnFinalBlowPP;
    /// <summary>
    /// Function: TurnOnFinalBlowPP
    /// </summary>
    public unsafe virtual void TurnOnFinalBlowPP(float Amount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnFinalBlowPP, "BmGame.RPlayerControllerCombat.TurnOnFinalBlowPP");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInFreeflowFocus;
    /// <summary>
    /// Function: IsInFreeflowFocus
    /// </summary>
    public unsafe virtual bool IsInFreeflowFocus()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInFreeflowFocus, "BmGame.RPlayerControllerCombat.IsInFreeflowFocus");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDoGadgetSpecial;
    /// <summary>
    /// Function: CanDoGadgetSpecial
    /// </summary>
    public unsafe virtual bool CanDoGadgetSpecial()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoGadgetSpecial, "BmGame.RPlayerControllerCombat.CanDoGadgetSpecial");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCombatFOVModifier;
    /// <summary>
    /// Function: GetCombatFOVModifier
    /// </summary>
    public unsafe virtual int GetCombatFOVModifier()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatFOVModifier, "BmGame.RPlayerControllerCombat.GetCombatFOVModifier");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatmobileTakedownAdrenalineSpecialLimit;
    /// <summary>
    /// Function: GetBatmobileTakedownAdrenalineSpecialLimit
    /// </summary>
    public unsafe virtual float GetBatmobileTakedownAdrenalineSpecialLimit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatmobileTakedownAdrenalineSpecialLimit, "BmGame.RPlayerControllerCombat.GetBatmobileTakedownAdrenalineSpecialLimit");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShowBatmobileTakedownAdrenaline;
    /// <summary>
    /// Function: ShowBatmobileTakedownAdrenaline
    /// </summary>
    public unsafe override void ShowBatmobileTakedownAdrenaline()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowBatmobileTakedownAdrenaline, "BmGame.RPlayerControllerCombat.ShowBatmobileTakedownAdrenaline");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearBatmobileTakedownAdrenalineAtEndOfCombat;
    /// <summary>
    /// Function: ClearBatmobileTakedownAdrenalineAtEndOfCombat
    /// </summary>
    public unsafe virtual void ClearBatmobileTakedownAdrenalineAtEndOfCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearBatmobileTakedownAdrenalineAtEndOfCombat, "BmGame.RPlayerControllerCombat.ClearBatmobileTakedownAdrenalineAtEndOfCombat");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpendBatmobileTakedownAdrenaline;
    /// <summary>
    /// Function: SpendBatmobileTakedownAdrenaline
    /// </summary>
    public unsafe virtual void SpendBatmobileTakedownAdrenaline()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpendBatmobileTakedownAdrenaline, "BmGame.RPlayerControllerCombat.SpendBatmobileTakedownAdrenaline");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncBatmobileTakedownAdrenaline;
    /// <summary>
    /// Function: IncBatmobileTakedownAdrenaline
    /// </summary>
    public unsafe virtual void IncBatmobileTakedownAdrenaline(float IncAmount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncBatmobileTakedownAdrenaline, "BmGame.RPlayerControllerCombat.IncBatmobileTakedownAdrenaline");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TrySpawnDualPlayMove;
    /// <summary>
    /// Function: TrySpawnDualPlayMove
    /// </summary>
    public unsafe virtual bool TrySpawnDualPlayMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrySpawnDualPlayMove, "BmGame.RPlayerControllerCombat.TrySpawnDualPlayMove");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsRiddlerMechFight;
    /// <summary>
    /// Function: IsRiddlerMechFight
    /// </summary>
    public unsafe virtual bool IsRiddlerMechFight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRiddlerMechFight, "BmGame.RPlayerControllerCombat.IsRiddlerMechFight");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasDualPlayTargets;
    /// <summary>
    /// Function: HasDualPlayTargets
    /// </summary>
    public unsafe virtual bool HasDualPlayTargets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasDualPlayTargets, "BmGame.RPlayerControllerCombat.HasDualPlayTargets");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DualPlayReleased;
    /// <summary>
    /// Function: DualPlayReleased
    /// </summary>
    public unsafe override void DualPlayReleased()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DualPlayReleased, "BmGame.RPlayerControllerCombat.DualPlayReleased");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DualPlayPressed;
    /// <summary>
    /// Function: DualPlayPressed
    /// </summary>
    public unsafe override void DualPlayPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DualPlayPressed, "BmGame.RPlayerControllerCombat.DualPlayPressed");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanDualPlay;
    /// <summary>
    /// Function: CanDualPlay
    /// </summary>
    public unsafe virtual bool CanDualPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDualPlay, "BmGame.RPlayerControllerCombat.CanDualPlay");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearDualPlayAdrenalineAtEndOfCombat;
    /// <summary>
    /// Function: ClearDualPlayAdrenalineAtEndOfCombat
    /// </summary>
    public unsafe virtual void ClearDualPlayAdrenalineAtEndOfCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearDualPlayAdrenalineAtEndOfCombat, "BmGame.RPlayerControllerCombat.ClearDualPlayAdrenalineAtEndOfCombat");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoDualplayAdrenalineSpent;
    /// <summary>
    /// Function: DoDualplayAdrenalineSpent
    /// </summary>
    public unsafe virtual void DoDualplayAdrenalineSpent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoDualplayAdrenalineSpent, "BmGame.RPlayerControllerCombat.DoDualplayAdrenalineSpent");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoTakedownStateChangeEvent;
    /// <summary>
    /// Function: DoTakedownStateChangeEvent
    /// </summary>
    public unsafe virtual void DoTakedownStateChangeEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoTakedownStateChangeEvent, "BmGame.RPlayerControllerCombat.DoTakedownStateChangeEvent");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpendDualPlayAdrenaline;
    /// <summary>
    /// Function: SpendDualPlayAdrenaline
    /// </summary>
    public unsafe virtual void SpendDualPlayAdrenaline()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpendDualPlayAdrenaline, "BmGame.RPlayerControllerCombat.SpendDualPlayAdrenaline");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateDualPlayHud;
    /// <summary>
    /// Function: UpdateDualPlayHud
    /// </summary>
    public unsafe virtual void UpdateDualPlayHud()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateDualPlayHud, "BmGame.RPlayerControllerCombat.UpdateDualPlayHud");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncDualPlayAdrenaline;
    /// <summary>
    /// Function: IncDualPlayAdrenaline
    /// </summary>
    public unsafe virtual void IncDualPlayAdrenaline(float IncAmount, bool bUpdateAdrenalineOnly = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncDualPlayAdrenaline, "BmGame.RPlayerControllerCombat.IncDualPlayAdrenaline");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUpdateAdrenalineOnly, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSniperPP;
    /// <summary>
    /// Function: SetSniperPP
    /// </summary>
    public unsafe virtual void SetSniperPP(float Opacity, bool bAuto = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSniperPP, "BmGame.RPlayerControllerCombat.SetSniperPP");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Opacity, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAuto, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffSniperPP;
    /// <summary>
    /// Function: TurnOffSniperPP
    /// </summary>
    public unsafe virtual void TurnOffSniperPP()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffSniperPP, "BmGame.RPlayerControllerCombat.TurnOffSniperPP");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnSniperPP;
    /// <summary>
    /// Function: TurnOnSniperPP
    /// </summary>
    public unsafe virtual void TurnOnSniperPP()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnSniperPP, "BmGame.RPlayerControllerCombat.TurnOnSniperPP");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateFreeflowFocusFX;
    /// <summary>
    /// Function: UpdateFreeflowFocusFX
    /// </summary>
    public unsafe virtual void UpdateFreeflowFocusFX(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFreeflowFocusFX, "BmGame.RPlayerControllerCombat.UpdateFreeflowFocusFX");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearAdrenalineAtEndOfCombat;
    /// <summary>
    /// Function: ClearAdrenalineAtEndOfCombat
    /// </summary>
    public unsafe override void ClearAdrenalineAtEndOfCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAdrenalineAtEndOfCombat, "BmGame.RPlayerControllerCombat.ClearAdrenalineAtEndOfCombat");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearAdrenalineWhenComboLost;
    /// <summary>
    /// Function: ClearAdrenalineWhenComboLost
    /// </summary>
    public unsafe virtual void ClearAdrenalineWhenComboLost()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAdrenalineWhenComboLost, "BmGame.RPlayerControllerCombat.ClearAdrenalineWhenComboLost");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearAdrenaline;
    /// <summary>
    /// Function: ClearAdrenaline
    /// </summary>
    public unsafe virtual void ClearAdrenaline()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAdrenaline, "BmGame.RPlayerControllerCombat.ClearAdrenaline");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpendAdrenaline;
    /// <summary>
    /// Function: SpendAdrenaline
    /// </summary>
    public unsafe virtual void SpendAdrenaline()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpendAdrenaline, "BmGame.RPlayerControllerCombat.SpendAdrenaline");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAdrenalineOnHud;
    /// <summary>
    /// Function: SetAdrenalineOnHud
    /// </summary>
    public unsafe virtual void SetAdrenalineOnHud(bool reduced_by_injury = default, bool bSpecialMoveTriggered = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAdrenalineOnHud, "BmGame.RPlayerControllerCombat.SetAdrenalineOnHud");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(reduced_by_injury, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialMoveTriggered, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAdrenalineSuperSpecialLimit;
    /// <summary>
    /// Function: GetAdrenalineSuperSpecialLimit
    /// </summary>
    public unsafe virtual float GetAdrenalineSuperSpecialLimit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAdrenalineSuperSpecialLimit, "BmGame.RPlayerControllerCombat.GetAdrenalineSuperSpecialLimit");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAdrenalineSpecialLimit;
    /// <summary>
    /// Function: GetAdrenalineSpecialLimit
    /// </summary>
    public unsafe virtual float GetAdrenalineSpecialLimit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAdrenalineSpecialLimit, "BmGame.RPlayerControllerCombat.GetAdrenalineSpecialLimit");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DecAdrenaline;
    /// <summary>
    /// Function: DecAdrenaline
    /// </summary>
    public unsafe virtual void DecAdrenaline(float DecAmount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DecAdrenaline, "BmGame.RPlayerControllerCombat.DecAdrenaline");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncAdrenaline;
    /// <summary>
    /// Function: IncAdrenaline
    /// </summary>
    public unsafe virtual void IncAdrenaline(float IncAmount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncAdrenaline, "BmGame.RPlayerControllerCombat.IncAdrenaline");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DecCombo;
    /// <summary>
    /// Function: DecCombo
    /// </summary>
    public unsafe virtual void DecCombo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DecCombo, "BmGame.RPlayerControllerCombat.DecCombo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncCombo;
    /// <summary>
    /// Function: IncCombo
    /// </summary>
    public unsafe virtual void IncCombo(BmSDK.BmGame.RPawnCombat PawnAttacked = default, int IncAmount = default, int IncSpecialMoveCount = default, bool bDoNotIncBatmobileTakedown = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncCombo, "BmGame.RPlayerControllerCombat.IncCombo");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnAttacked, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncAmount, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncSpecialMoveCount, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoNotIncBatmobileTakedown, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetQuickStrikeAudioParam;
    /// <summary>
    /// Function: SetQuickStrikeAudioParam
    /// </summary>
    public unsafe virtual void SetQuickStrikeAudioParam(float Scale)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetQuickStrikeAudioParam, "BmGame.RPlayerControllerCombat.SetQuickStrikeAudioParam");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetComboIncCue;
    /// <summary>
    /// Function: SetComboIncCue
    /// </summary>
    public unsafe virtual void SetComboIncCue(BmSDK.Engine.SoundCue NewCue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetComboIncCue, "BmGame.RPlayerControllerCombat.SetComboIncCue");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BankXPForSave;
    /// <summary>
    /// Function: BankXPForSave
    /// </summary>
    public unsafe override void BankXPForSave()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BankXPForSave, "BmGame.RPlayerControllerCombat.BankXPForSave");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowCombatBonusPoints;
    /// <summary>
    /// Function: ShowCombatBonusPoints
    /// </summary>
    public unsafe virtual float ShowCombatBonusPoints()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCombatBonusPoints, "BmGame.RPlayerControllerCombat.ShowCombatBonusPoints");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AwardCombatBonusPoints;
    /// <summary>
    /// Function: AwardCombatBonusPoints
    /// </summary>
    public unsafe virtual int AwardCombatBonusPoints()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardCombatBonusPoints, "BmGame.RPlayerControllerCombat.AwardCombatBonusPoints");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AwardPredatorSkillPoints;
    /// <summary>
    /// Function: AwardPredatorSkillPoints
    /// </summary>
    public unsafe virtual void AwardPredatorSkillPoints()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardPredatorSkillPoints, "BmGame.RPlayerControllerCombat.AwardPredatorSkillPoints");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AwardCombatSkillPoints;
    /// <summary>
    /// Function: AwardCombatSkillPoints
    /// </summary>
    public unsafe virtual void AwardCombatSkillPoints()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardCombatSkillPoints, "BmGame.RPlayerControllerCombat.AwardCombatSkillPoints");
        byte* paramsPtr = stackalloc byte[100];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpottedDuringPredator;
    /// <summary>
    /// Function: SpottedDuringPredator
    /// </summary>
    public unsafe override void SpottedDuringPredator(BmSDK.BmGame.RPawnVillain Spotter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpottedDuringPredator, "BmGame.RPlayerControllerCombat.SpottedDuringPredator");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spotter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerSpotted;
    /// <summary>
    /// Function: PlayerSpotted
    /// </summary>
    public unsafe override void PlayerSpotted(BmSDK.BmGame.RPawnVillain Spotee)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerSpotted, "BmGame.RPlayerControllerCombat.PlayerSpotted");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spotee, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPredatorXPBonus;
    /// <summary>
    /// Function: AddPredatorXPBonus
    /// </summary>
    public unsafe virtual void AddPredatorXPBonus()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPredatorXPBonus, "BmGame.RPlayerControllerCombat.AddPredatorXPBonus");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCombatXPBonus;
    /// <summary>
    /// Function: AddCombatXPBonus
    /// </summary>
    public unsafe virtual void AddCombatXPBonus()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCombatXPBonus, "BmGame.RPlayerControllerCombat.AddCombatXPBonus");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateStoredCombatXPInfo;
    /// <summary>
    /// Function: UpdateStoredCombatXPInfo
    /// </summary>
    public unsafe virtual void UpdateStoredCombatXPInfo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateStoredCombatXPInfo, "BmGame.RPlayerControllerCombat.UpdateStoredCombatXPInfo");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearXPAfterSuppression;
    /// <summary>
    /// Function: ClearXPAfterSuppression
    /// </summary>
    public unsafe virtual void ClearXPAfterSuppression()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearXPAfterSuppression, "BmGame.RPlayerControllerCombat.ClearXPAfterSuppression");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AwardXPAfterSuppression;
    /// <summary>
    /// Function: AwardXPAfterSuppression
    /// </summary>
    public unsafe virtual void AwardXPAfterSuppression()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardXPAfterSuppression, "BmGame.RPlayerControllerCombat.AwardXPAfterSuppression");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyCombatStarted;
    /// <summary>
    /// Function: NotifyCombatStarted
    /// </summary>
    public unsafe override void NotifyCombatStarted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyCombatStarted, "BmGame.RPlayerControllerCombat.NotifyCombatStarted");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetPerFightStats;
    /// <summary>
    /// Function: ResetPerFightStats
    /// </summary>
    public unsafe virtual void ResetPerFightStats(bool bForce = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPerFightStats, "BmGame.RPlayerControllerCombat.ResetPerFightStats");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetMaxCombatants;
    /// <summary>
    /// Function: ResetMaxCombatants
    /// </summary>
    public unsafe virtual void ResetMaxCombatants()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetMaxCombatants, "BmGame.RPlayerControllerCombat.ResetMaxCombatants");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetMaxComboSize;
    /// <summary>
    /// Function: ResetMaxComboSize
    /// </summary>
    public unsafe virtual void ResetMaxComboSize()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetMaxComboSize, "BmGame.RPlayerControllerCombat.ResetMaxComboSize");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMaxComboSize;
    /// <summary>
    /// Function: GetMaxComboSize
    /// </summary>
    public unsafe virtual int GetMaxComboSize()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxComboSize, "BmGame.RPlayerControllerCombat.GetMaxComboSize");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IncCombosStarted;
    /// <summary>
    /// Function: IncCombosStarted
    /// </summary>
    public unsafe virtual void IncCombosStarted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncCombosStarted, "BmGame.RPlayerControllerCombat.IncCombosStarted");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAverageCombo;
    /// <summary>
    /// Function: GetAverageCombo
    /// </summary>
    public unsafe virtual int GetAverageCombo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAverageCombo, "BmGame.RPlayerControllerCombat.GetAverageCombo");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumCombosStarted;
    /// <summary>
    /// Function: GetNumCombosStarted
    /// </summary>
    public unsafe virtual int GetNumCombosStarted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumCombosStarted, "BmGame.RPlayerControllerCombat.GetNumCombosStarted");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetCombosStarted;
    /// <summary>
    /// Function: ResetCombosStarted
    /// </summary>
    public unsafe virtual void ResetCombosStarted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetCombosStarted, "BmGame.RPlayerControllerCombat.ResetCombosStarted");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterComboFlow;
    /// <summary>
    /// Function: EnterComboFlow
    /// </summary>
    public unsafe virtual void EnterComboFlow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterComboFlow, "BmGame.RPlayerControllerCombat.EnterComboFlow");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OutputComboMoves;
    /// <summary>
    /// Function: OutputComboMoves
    /// </summary>
    public unsafe virtual void OutputComboMoves()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OutputComboMoves, "BmGame.RPlayerControllerCombat.OutputComboMoves");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearComboMoves;
    /// <summary>
    /// Function: ClearComboMoves
    /// </summary>
    public unsafe virtual void ClearComboMoves()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearComboMoves, "BmGame.RPlayerControllerCombat.ClearComboMoves");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMaxVariation;
    /// <summary>
    /// Function: SetMaxVariation
    /// </summary>
    public unsafe virtual void SetMaxVariation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMaxVariation, "BmGame.RPlayerControllerCombat.SetMaxVariation");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMaxComboVariation;
    /// <summary>
    /// Function: GetMaxComboVariation
    /// </summary>
    public unsafe virtual int GetMaxComboVariation(bool bIncludeGadgets = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxComboVariation, "BmGame.RPlayerControllerCombat.GetMaxComboVariation");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludeGadgets, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ResetComboMoveTypes;
    /// <summary>
    /// Function: ResetComboMoveTypes
    /// </summary>
    public unsafe virtual void ResetComboMoveTypes()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetComboMoveTypes, "BmGame.RPlayerControllerCombat.ResetComboMoveTypes");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetMaxComboVariation;
    /// <summary>
    /// Function: ResetMaxComboVariation
    /// </summary>
    public unsafe virtual void ResetMaxComboVariation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetMaxComboVariation, "BmGame.RPlayerControllerCombat.ResetMaxComboVariation");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetGadgetVariation;
    /// <summary>
    /// Function: ResetGadgetVariation
    /// </summary>
    public unsafe virtual void ResetGadgetVariation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetGadgetVariation, "BmGame.RPlayerControllerCombat.ResetGadgetVariation");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetComboGadgetVariationScore;
    /// <summary>
    /// Function: GetComboGadgetVariationScore
    /// </summary>
    public unsafe virtual int GetComboGadgetVariationScore()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboGadgetVariationScore, "BmGame.RPlayerControllerCombat.GetComboGadgetVariationScore");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetComboVariationScore;
    /// <summary>
    /// Function: GetComboVariationScore
    /// </summary>
    public unsafe virtual int GetComboVariationScore(bool bIncludeGadgets = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboVariationScore, "BmGame.RPlayerControllerCombat.GetComboVariationScore");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludeGadgets, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_MovePerformed;
    /// <summary>
    /// Function: MovePerformed
    /// </summary>
    public unsafe virtual void MovePerformed(BmSDK.BmGame.RGameInfo.EComboMoveType MoveType, BmSDK.BmGame.RPawnCombat Target, bool bAddScore = default, int ComboForScore = default, int NumOfTargets = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MovePerformed, "BmGame.RPlayerControllerCombat.MovePerformed");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddScore, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboForScore, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumOfTargets, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncTutorialProgressForMove;
    /// <summary>
    /// Function: IncTutorialProgressForMove
    /// </summary>
    public unsafe virtual void IncTutorialProgressForMove(BmSDK.BmGame.RGameInfo.EComboMoveType MoveType, BmSDK.BmGame.RPawnCombat Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncTutorialProgressForMove, "BmGame.RPlayerControllerCombat.IncTutorialProgressForMove");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RepelledByBrute;
    /// <summary>
    /// Function: RepelledByBrute
    /// </summary>
    public unsafe virtual void RepelledByBrute()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RepelledByBrute, "BmGame.RPlayerControllerCombat.RepelledByBrute");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlockedBy;
    /// <summary>
    /// Function: BlockedBy
    /// </summary>
    public unsafe virtual void BlockedBy(BmSDK.BmGame.RPawnVillain Villain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlockedBy, "BmGame.RPlayerControllerCombat.BlockedBy");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldShowAutoCombatHints;
    /// <summary>
    /// Function: ShouldShowAutoCombatHints
    /// </summary>
    public unsafe virtual bool ShouldShowAutoCombatHints()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldShowAutoCombatHints, "BmGame.RPlayerControllerCombat.ShouldShowAutoCombatHints");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearChargesSinceBatarang;
    /// <summary>
    /// Function: ClearChargesSinceBatarang
    /// </summary>
    public unsafe virtual void ClearChargesSinceBatarang()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearChargesSinceBatarang, "BmGame.RPlayerControllerCombat.ClearChargesSinceBatarang");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncChargesSinceBatarang;
    /// <summary>
    /// Function: IncChargesSinceBatarang
    /// </summary>
    public unsafe virtual void IncChargesSinceBatarang()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncChargesSinceBatarang, "BmGame.RPlayerControllerCombat.IncChargesSinceBatarang");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearHitsSinceCounter;
    /// <summary>
    /// Function: ClearHitsSinceCounter
    /// </summary>
    public unsafe virtual void ClearHitsSinceCounter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearHitsSinceCounter, "BmGame.RPlayerControllerCombat.ClearHitsSinceCounter");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncHitsSinceCounter;
    /// <summary>
    /// Function: IncHitsSinceCounter
    /// </summary>
    public unsafe virtual void IncHitsSinceCounter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncHitsSinceCounter, "BmGame.RPlayerControllerCombat.IncHitsSinceCounter");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanDoComboProjectileGadget;
    /// <summary>
    /// Function: CanDoComboProjectileGadget
    /// </summary>
    public unsafe virtual bool CanDoComboProjectileGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoComboProjectileGadget, "BmGame.RPlayerControllerCombat.CanDoComboProjectileGadget");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDoComboWhip;
    /// <summary>
    /// Function: CanDoComboWhip
    /// </summary>
    public unsafe virtual bool CanDoComboWhip()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoComboWhip, "BmGame.RPlayerControllerCombat.CanDoComboWhip");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDoComboBatarang;
    /// <summary>
    /// Function: CanDoComboBatarang
    /// </summary>
    public unsafe virtual bool CanDoComboBatarang()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoComboBatarang, "BmGame.RPlayerControllerCombat.CanDoComboBatarang");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ServerRequestRedirect;
    /// <summary>
    /// Function: ServerRequestRedirect
    /// </summary>
    public unsafe virtual void ServerRequestRedirect(BmSDK.BmGame.RPawnVillain TargetPawn, System.Numerics.Vector3 RedirectDir, System.Numerics.Vector3 AnimPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRequestRedirect, "BmGame.RPlayerControllerCombat.ServerRequestRedirect");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RedirectDir, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryRedirect;
    /// <summary>
    /// Function: TryRedirect
    /// </summary>
    public unsafe virtual bool TryRedirect(BmSDK.BmGame.RPawnVillain TargetPawn = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryRedirect, "BmGame.RPlayerControllerCombat.TryRedirect");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ServerLockProjectileThrowTarget;
    /// <summary>
    /// Function: ServerLockProjectileThrowTarget
    /// </summary>
    public unsafe virtual void ServerLockProjectileThrowTarget(BmSDK.BmGame.RPawnVillain ThrowTarget, BmSDK.Rotator ThrowDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerLockProjectileThrowTarget, "BmGame.RPlayerControllerCombat.ServerLockProjectileThrowTarget");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerRequestEvade;
    /// <summary>
    /// Function: ServerRequestEvade
    /// </summary>
    public unsafe virtual void ServerRequestEvade(System.Numerics.Vector3 EvadeDir, BmSDK.FName EvadeName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRequestEvade, "BmGame.RPlayerControllerCombat.ServerRequestEvade");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvadeDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvadeName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnEvade;
    /// <summary>
    /// Function: SpawnEvade
    /// </summary>
    public unsafe override void SpawnEvade(bool bCanQueue = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnEvade, "BmGame.RPlayerControllerCombat.SpawnEvade");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanQueue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToQueueEvade;
    /// <summary>
    /// Function: TryToQueueEvade
    /// </summary>
    public unsafe virtual void TryToQueueEvade()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToQueueEvade, "BmGame.RPlayerControllerCombat.TryToQueueEvade");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWallEvadeInfo;
    /// <summary>
    /// Function: GetWallEvadeInfo
    /// </summary>
    public unsafe virtual bool GetWallEvadeInfo(System.Numerics.Vector3 Dir, out System.Numerics.Vector3 WallLocation, out System.Numerics.Vector3 WallNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWallEvadeInfo, "BmGame.RPlayerControllerCombat.GetWallEvadeInfo");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out WallLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out WallNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        WallLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        WallNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_DialogueModeTimeout;
    /// <summary>
    /// Function: DialogueModeTimeout
    /// </summary>
    public unsafe virtual void DialogueModeTimeout()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DialogueModeTimeout, "BmGame.RPlayerControllerCombat.DialogueModeTimeout");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryingToSetDialogueMode;
    /// <summary>
    /// Function: TryingToSetDialogueMode
    /// </summary>
    public unsafe virtual void TryingToSetDialogueMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryingToSetDialogueMode, "BmGame.RPlayerControllerCombat.TryingToSetDialogueMode");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoubleTapRun;
    /// <summary>
    /// Function: DoubleTapRun
    /// </summary>
    public unsafe override void DoubleTapRun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoubleTapRun, "BmGame.RPlayerControllerCombat.DoubleTapRun");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLastTarget;
    /// <summary>
    /// Function: ClearLastTarget
    /// </summary>
    public unsafe virtual void ClearLastTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLastTarget, "BmGame.RPlayerControllerCombat.ClearLastTarget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatMoveFinished;
    /// <summary>
    /// Function: CombatMoveFinished
    /// </summary>
    public unsafe virtual void CombatMoveFinished(BmSDK.BmGame.RCombatMove FinishedMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatMoveFinished, "BmGame.RPlayerControllerCombat.CombatMoveFinished");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatMoveInitialised;
    /// <summary>
    /// Function: CombatMoveInitialised
    /// </summary>
    public unsafe virtual void CombatMoveInitialised()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatMoveInitialised, "BmGame.RPlayerControllerCombat.CombatMoveInitialised");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override void GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.RPlayerControllerCombat.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowTutorial;
    /// <summary>
    /// Function: ShowTutorial
    /// </summary>
    public unsafe virtual void ShowTutorial(BmSDK.BmGame.RHUDPrompt HelpPrompt, BmSDK.BmGame.RPersistentData.ETutorialType TutorialToShow)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowTutorial, "BmGame.RPlayerControllerCombat.ShowTutorial");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TutorialToShow, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowMultiStageTutorial;
    /// <summary>
    /// Function: ShowMultiStageTutorial
    /// </summary>
    public unsafe virtual void ShowMultiStageTutorial(BmSDK.BmGame.RHUDPrompt HelpPrompt)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowMultiStageTutorial, "BmGame.RPlayerControllerCombat.ShowMultiStageTutorial");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAerialBeatdownIcon;
    /// <summary>
    /// Function: GetAerialBeatdownIcon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHUDPrompt.EControlIcon GetAerialBeatdownIcon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAerialBeatdownIcon, "BmGame.RPlayerControllerCombat.GetAerialBeatdownIcon");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBeatdownIcon;
    /// <summary>
    /// Function: GetBeatdownIcon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHUDPrompt.EControlIcon GetBeatdownIcon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBeatdownIcon, "BmGame.RPlayerControllerCombat.GetBeatdownIcon");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHighestPriorityBatmobileTutorial;
    /// <summary>
    /// Function: GetHighestPriorityBatmobileTutorial
    /// </summary>
    public unsafe virtual void GetHighestPriorityBatmobileTutorial(out BmSDK.BmGame.RPersistentData.ETutorialType BestTutorial, out BmSDK.FString BestTutorialPrompt, out BmSDK.BmGame.RHUDPrompt.EControlIcon BestControlIcon, out int bShowTutorial)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHighestPriorityBatmobileTutorial, "BmGame.RPlayerControllerCombat.GetHighestPriorityBatmobileTutorial");
        byte* paramsPtr = stackalloc byte[49];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestTutorial);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestTutorial, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestControlIcon);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestControlIcon, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bShowTutorial);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowTutorial, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BestTutorial = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.ETutorialType>(paramsPtr + 0);
        BestTutorialPrompt = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
        BestControlIcon = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 20);
        bShowTutorial = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_GetHighestPriorityTutorial;
    /// <summary>
    /// Function: GetHighestPriorityTutorial
    /// </summary>
    public unsafe virtual void GetHighestPriorityTutorial(out BmSDK.BmGame.RPersistentData.ETutorialType BestTutorial, out BmSDK.FString BestTutorialPrompt, out BmSDK.BmGame.RHUDPrompt.EControlIcon BestControlIcon, out int bShowTutorial)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHighestPriorityTutorial, "BmGame.RPlayerControllerCombat.GetHighestPriorityTutorial");
        byte* paramsPtr = stackalloc byte[68];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestTutorial);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestTutorial, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestControlIcon);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestControlIcon, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bShowTutorial);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowTutorial, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BestTutorial = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.ETutorialType>(paramsPtr + 0);
        BestTutorialPrompt = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
        BestControlIcon = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 20);
        bShowTutorial = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_GrabbableWeaponInRange;
    /// <summary>
    /// Function: GrabbableWeaponInRange
    /// </summary>
    public unsafe virtual bool GrabbableWeaponInRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrabbableWeaponInRange, "BmGame.RPlayerControllerCombat.GrabbableWeaponInRange");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckTutorial;
    /// <summary>
    /// Function: CheckTutorial
    /// </summary>
    public unsafe virtual bool CheckTutorial(BmSDK.BmGame.RPersistentData.ETutorialType CheckTutorialType, out int BestPriority, out BmSDK.BmGame.RPersistentData.ETutorialType BestTutorial, out BmSDK.FString BestPrompt, out int bShowTutorial)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckTutorial, "BmGame.RPlayerControllerCombat.CheckTutorial");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckTutorialType, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestPriority);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestPriority, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestTutorial);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestTutorial, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bShowTutorial);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowTutorial, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BestPriority = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        BestTutorial = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.ETutorialType>(paramsPtr + 8);
        BestPrompt = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 12);
        bShowTutorial = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_CanTriggerCombatInterrogation;
    /// <summary>
    /// Function: CanTriggerCombatInterrogation
    /// </summary>
    public unsafe virtual bool CanTriggerCombatInterrogation(bool bCheckValidContext = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTriggerCombatInterrogation, "BmGame.RPlayerControllerCombat.CanTriggerCombatInterrogation");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckValidContext, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsInCombat;
    /// <summary>
    /// Function: IsInCombat
    /// </summary>
    public unsafe override bool IsInCombat(bool bForceCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInCombat, "BmGame.RPlayerControllerCombat.IsInCombat");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCM;
    /// <summary>
    /// Function: GetCM
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMCombatManager GetCM()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCM, "BmGame.RPlayerControllerCombat.GetCM");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FindFloorTakedownTarget;
    /// <summary>
    /// Function: FindFloorTakedownTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain FindFloorTakedownTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindFloorTakedownTarget, "BmGame.RPlayerControllerCombat.FindFloorTakedownTarget");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FindRedirectTarget;
    /// <summary>
    /// Function: FindRedirectTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat FindRedirectTarget(float MaxDist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindRedirectTarget, "BmGame.RPlayerControllerCombat.FindRedirectTarget");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDist, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_InputHeading;
    /// <summary>
    /// Function: InputHeading
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 InputHeading(bool bCanBeZero = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InputHeading, "BmGame.RPlayerControllerCombat.InputHeading");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBeZero, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasMovementInput;
    /// <summary>
    /// Function: HasMovementInput
    /// </summary>
    public unsafe virtual bool HasMovementInput()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasMovementInput, "BmGame.RPlayerControllerCombat.HasMovementInput");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBatarangPrimed;
    /// <summary>
    /// Function: IsBatarangPrimed
    /// </summary>
    public unsafe virtual bool IsBatarangPrimed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatarangPrimed, "BmGame.RPlayerControllerCombat.IsBatarangPrimed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckThrowSmokeBomb;
    /// <summary>
    /// Function: CheckThrowSmokeBomb
    /// </summary>
    public unsafe override bool CheckThrowSmokeBomb()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckThrowSmokeBomb, "BmGame.RPlayerControllerCombat.CheckThrowSmokeBomb");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDoCombat;
    /// <summary>
    /// Function: CanDoCombat
    /// </summary>
    public unsafe override bool CanDoCombat(bool CheckForEvade = default, bool bDebugOutput = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoCombat, "BmGame.RPlayerControllerCombat.CanDoCombat");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckForEvade, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugOutput, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanBeAttacked;
    /// <summary>
    /// Function: CanBeAttacked
    /// </summary>
    public unsafe virtual bool CanBeAttacked()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeAttacked, "BmGame.RPlayerControllerCombat.CanBeAttacked");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetLasered;
    /// <summary>
    /// Function: SetLasered
    /// </summary>
    public unsafe virtual void SetLasered(bool bNewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLasered, "BmGame.RPlayerControllerCombat.SetLasered");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetZapped;
    /// <summary>
    /// Function: SetZapped
    /// </summary>
    public unsafe virtual void SetZapped(bool bNewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetZapped, "BmGame.RPlayerControllerCombat.SetZapped");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsLasered;
    /// <summary>
    /// Function: IsLasered
    /// </summary>
    public unsafe virtual bool IsLasered()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLasered, "BmGame.RPlayerControllerCombat.IsLasered");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsZapped;
    /// <summary>
    /// Function: IsZapped
    /// </summary>
    public unsafe virtual bool IsZapped()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsZapped, "BmGame.RPlayerControllerCombat.IsZapped");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsStunned;
    /// <summary>
    /// Function: IsStunned
    /// </summary>
    public unsafe virtual bool IsStunned()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStunned, "BmGame.RPlayerControllerCombat.IsStunned");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasBeenHit;
    /// <summary>
    /// Function: HasBeenHit
    /// </summary>
    public unsafe virtual bool HasBeenHit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasBeenHit, "BmGame.RPlayerControllerCombat.HasBeenHit");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartBeenHitCheck;
    /// <summary>
    /// Function: StartBeenHitCheck
    /// </summary>
    public unsafe virtual void StartBeenHitCheck()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartBeenHitCheck, "BmGame.RPlayerControllerCombat.StartBeenHitCheck");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasEverBeenHit;
    /// <summary>
    /// Function: HasEverBeenHit
    /// </summary>
    public unsafe virtual bool HasEverBeenHit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasEverBeenHit, "BmGame.RPlayerControllerCombat.HasEverBeenHit");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartEverBeenHitCheck;
    /// <summary>
    /// Function: StartEverBeenHitCheck
    /// </summary>
    public unsafe virtual void StartEverBeenHitCheck()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartEverBeenHitCheck, "BmGame.RPlayerControllerCombat.StartEverBeenHitCheck");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanShowFloorPickupPrompt;
    /// <summary>
    /// Function: CanShowFloorPickupPrompt
    /// </summary>
    public unsafe override bool CanShowFloorPickupPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanShowFloorPickupPrompt, "BmGame.RPlayerControllerCombat.CanShowFloorPickupPrompt");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsValidStrikeTarget;
    /// <summary>
    /// Function: IsValidStrikeTarget
    /// </summary>
    public unsafe virtual bool IsValidStrikeTarget(System.Numerics.Vector3 FacingDir, BmSDK.Class dmgType, BmSDK.BmGame.RPawnVillain TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidStrikeTarget, "BmGame.RPlayerControllerCombat.IsValidStrikeTarget");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_FindWeaponToPickupCacheUI;
    /// <summary>
    /// Function: FindWeaponToPickupCacheUI
    /// </summary>
    public unsafe virtual bool FindWeaponToPickupCacheUI(System.Numerics.Vector3 CheckDir, float CheckDist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindWeaponToPickupCacheUI, "BmGame.RPlayerControllerCombat.FindWeaponToPickupCacheUI");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDist, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_FindWeaponToPickup;
    /// <summary>
    /// Function: FindWeaponToPickup
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject FindWeaponToPickup(System.Numerics.Vector3 CheckDir, float CheckDist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindWeaponToPickup, "BmGame.RPlayerControllerCombat.FindWeaponToPickup");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDist, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_FindDeadTarget;
    /// <summary>
    /// Function: FindDeadTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain FindDeadTarget(System.Numerics.Vector3 FacingDir, BmSDK.Class dmgType = default, float CloseRangeDist = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindDeadTarget, "BmGame.RPlayerControllerCombat.FindDeadTarget");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CloseRangeDist, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_FindStrikeTarget;
    /// <summary>
    /// Function: FindStrikeTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain FindStrikeTarget(System.Numerics.Vector3 FacingDir, BmSDK.Class dmgType = default, float CloseRangeDist = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindStrikeTarget, "BmGame.RPlayerControllerCombat.FindStrikeTarget");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CloseRangeDist, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetLookAtEnemy;
    /// <summary>
    /// Function: GetLookAtEnemy
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat GetLookAtEnemy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLookAtEnemy, "BmGame.RPlayerControllerCombat.GetLookAtEnemy");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(paramsPtr + 0);
    }

    /// <summary>
    /// Struct: FComboMoveInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FComboMoveInfo
    {
        /// <summary>
        /// ByteProperty: MoveType
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EComboMoveType MoveType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EComboMoveType>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: MoveNum
        /// </summary>
        public unsafe int MoveNum
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FStruckInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FStruckInfo
    {
        /// <summary>
        /// ObjectProperty: PawnAttacked
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnCombat PawnAttacked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ConsecutiveHits
        /// </summary>
        public unsafe int ConsecutiveHits
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: CombatManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager CombatManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager>(Ptr + 7440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7440); }
    }

    /// <summary>
    /// ObjectProperty: ImpactRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ImpactRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 7448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7448); }
    }

    /// <summary>
    /// ObjectProperty: LastAttackTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain LastAttackTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 7456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7456); }
    }

    /// <summary>
    /// ObjectProperty: DifficultyOverrideVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RDifficultyOverrideVolume DifficultyOverrideVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDifficultyOverrideVolume>(Ptr + 7464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7464); }
    }

    /// <summary>
    /// ObjectProperty: CurrentLookAtTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat CurrentLookAtTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 7472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7472); }
    }

    /// <summary>
    /// ObjectProperty: SniperPP
    /// </summary>
    public unsafe BmSDK.BmGame.RViewPostProcess SniperPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RViewPostProcess>(Ptr + 7480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7480); }
    }

    /// <summary>
    /// ObjectProperty: FinalBlowPP
    /// </summary>
    public unsafe BmSDK.BmGame.RViewPostProcess FinalBlowPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RViewPostProcess>(Ptr + 7488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7488); }
    }

    /// <summary>
    /// ObjectProperty: FixedCombatCam
    /// </summary>
    public unsafe BmSDK.BmGame.RCameraActor FixedCombatCam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCameraActor>(Ptr + 7496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7496); }
    }

    /// <summary>
    /// ObjectProperty: FixedCombatCam_HeliBase
    /// </summary>
    public unsafe BmSDK.BmGame.RHelicopterBase FixedCombatCam_HeliBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterBase>(Ptr + 7504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7504); }
    }

    /// <summary>
    /// ComponentProperty: ComboIncAC
    /// </summary>
    public unsafe BmSDK.Engine.AudioComponent ComboIncAC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AudioComponent>(Ptr + 7512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7512); }
    }

    /// <summary>
    /// ComponentProperty: XPBonusRoom
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState XPBonusRoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 7520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7520); }
    }

    /// <summary>
    /// IntProperty: ComboSize
    /// </summary>
    public unsafe int ComboSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7528); }
    }

    /// <summary>
    /// IntProperty: CurrMaxComboSize
    /// </summary>
    public unsafe int CurrMaxComboSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7532); }
    }

    /// <summary>
    /// IntProperty: TotalMaxComboSize
    /// </summary>
    public unsafe int TotalMaxComboSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7536); }
    }

    /// <summary>
    /// IntProperty: NumTimesHit
    /// </summary>
    public unsafe int NumTimesHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7540); }
    }

    /// <summary>
    /// FloatProperty: AdrenalineValue
    /// </summary>
    public unsafe float AdrenalineValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7544); }
    }

    /// <summary>
    /// FloatProperty: AdrenalineSpecialLimit
    /// </summary>
    public unsafe float AdrenalineSpecialLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7548); }
    }

    /// <summary>
    /// FloatProperty: AdrenalineSuperSpecialLimit
    /// </summary>
    public unsafe float AdrenalineSuperSpecialLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7552); }
    }

    /// <summary>
    /// BoolProperty: bFirstSpecialMoveUsed
    /// </summary>
    public unsafe bool bFirstSpecialMoveUsed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: AdrenalineBarActive
    /// </summary>
    public unsafe bool AdrenalineBarActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bSuppressCombatCameraInCorridor
    /// </summary>
    public unsafe bool bSuppressCombatCameraInCorridor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bPlayFinishedCombatMoveWhenAble
    /// </summary>
    public unsafe bool bPlayFinishedCombatMoveWhenAble
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bForceSpecialCombo
    /// </summary>
    public unsafe bool bForceSpecialCombo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHit
    /// </summary>
    public unsafe bool bBeenHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bEverBeenHit
    /// </summary>
    public unsafe bool bEverBeenHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bShownDesignTutorial
    /// </summary>
    public unsafe bool bShownDesignTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByStunStick
    /// </summary>
    public unsafe bool bBeenHitByStunStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByKnife
    /// </summary>
    public unsafe bool bBeenHitByKnife
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitBySword
    /// </summary>
    public unsafe bool bBeenHitBySword
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByCombatGun
    /// </summary>
    public unsafe bool bBeenHitByCombatGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByChargedUpThug
    /// </summary>
    public unsafe bool bBeenHitByChargedUpThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByMultiWeaponFist
    /// </summary>
    public unsafe bool bBeenHitByMultiWeaponFist
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByMultiWeaponShield
    /// </summary>
    public unsafe bool bBeenHitByMultiWeaponShield
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitBySimultaneousAttack
    /// </summary>
    public unsafe bool bBeenHitBySimultaneousAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByArmouredThug
    /// </summary>
    public unsafe bool bBeenHitByArmouredThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByShieldThug
    /// </summary>
    public unsafe bool bBeenHitByShieldThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByLieutenant
    /// </summary>
    public unsafe bool bBeenHitByLieutenant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByTitanHenchman
    /// </summary>
    public unsafe bool bBeenHitByTitanHenchman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByProjectile
    /// </summary>
    public unsafe bool bBeenHitByProjectile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitBySniper
    /// </summary>
    public unsafe bool bBeenHitBySniper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByMine
    /// </summary>
    public unsafe bool bBeenHitByMine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bSpottedByThermal
    /// </summary>
    public unsafe bool bSpottedByThermal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bVantageMineWasUsedInPredatorSection
    /// </summary>
    public unsafe bool bVantageMineWasUsedInPredatorSection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bTryingToSetDialogueMode
    /// </summary>
    public unsafe bool bTryingToSetDialogueMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bShowEvadePrompt
    /// </summary>
    public unsafe bool bShowEvadePrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bShowQuickBatarangPrompt
    /// </summary>
    public unsafe bool bShowQuickBatarangPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bCanDoComboBatarang
    /// </summary>
    public unsafe bool bCanDoComboBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bMirroredFailAnim
    /// </summary>
    public unsafe bool bMirroredFailAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bStoredNoHitBonus
    /// </summary>
    public unsafe bool bStoredNoHitBonus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bStoredPerfectFreeflow
    /// </summary>
    public unsafe bool bStoredPerfectFreeflow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: StoredPredatorSeen
    /// </summary>
    public unsafe bool StoredPredatorSeen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bUseComboIncCue
    /// </summary>
    public unsafe bool bUseComboIncCue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bLieutenantStrikeHelp
    /// </summary>
    public unsafe bool bLieutenantStrikeHelp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bDisallowCombat
    /// </summary>
    public unsafe bool bDisallowCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bAllowCombatWithNoMovement
    /// </summary>
    public unsafe bool bAllowCombatWithNoMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bCapeStunDisabled
    /// </summary>
    public unsafe bool bCapeStunDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bInFreeflowFocus
    /// </summary>
    public unsafe bool bInFreeflowFocus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bSniperPPActive
    /// </summary>
    public unsafe bool bSniperPPActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bAllowInteractionMidCombat
    /// </summary>
    public unsafe bool bAllowInteractionMidCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bCouldDoCombatWhenCounterPressed
    /// </summary>
    public unsafe bool bCouldDoCombatWhenCounterPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bUnderAttackFromGunshipHomingMissiles
    /// </summary>
    public unsafe bool bUnderAttackFromGunshipHomingMissiles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bPrevCanDoDualPlayTakedown
    /// </summary>
    public unsafe bool bPrevCanDoDualPlayTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bCanDoReadyGadgetOrCounter
    /// </summary>
    public unsafe bool bCanDoReadyGadgetOrCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bNoGroundTakedown
    /// </summary>
    public unsafe bool bNoGroundTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bGroundTakedownDone
    /// </summary>
    public unsafe bool bGroundTakedownDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// FloatProperty: DualPlayAdrenalineValue
    /// </summary>
    public unsafe float DualPlayAdrenalineValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7564); }
    }

    /// <summary>
    /// FloatProperty: DualPlayAdrenalineSpecialLimit
    /// </summary>
    public unsafe float DualPlayAdrenalineSpecialLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7568); }
    }

    /// <summary>
    /// FloatProperty: BatmobileTakedownAdrenalineValue
    /// </summary>
    public unsafe float BatmobileTakedownAdrenalineValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7572); }
    }

    /// <summary>
    /// FloatProperty: BatmobileTakedownAdrenalineSpecialLimit
    /// </summary>
    public unsafe float BatmobileTakedownAdrenalineSpecialLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7576); }
    }

    /// <summary>
    /// IntProperty: CombatScore
    /// </summary>
    public unsafe int CombatScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7580); }
    }

    /// <summary>
    /// ArrayProperty: TargettedBy
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat> TargettedBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(Ptr + 7584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7584); }
    }

    /// <summary>
    /// FloatProperty: LastAttackTargetTime
    /// </summary>
    public unsafe float LastAttackTargetTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7600); }
    }

    /// <summary>
    /// StructProperty: LastStrikeDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastStrikeDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7604);

    /// <summary>
    /// FloatProperty: FinishedCombatSpecialMoveTimeout
    /// </summary>
    public unsafe float FinishedCombatSpecialMoveTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7616); }
    }

    /// <summary>
    /// IntProperty: MovesSinceSpecial
    /// </summary>
    public unsafe int MovesSinceSpecial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7620); }
    }

    /// <summary>
    /// IntProperty: CombosStarted
    /// </summary>
    public unsafe int CombosStarted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7624); }
    }

    /// <summary>
    /// IntProperty: CombosAchieved
    /// </summary>
    public unsafe int CombosAchieved
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7628); }
    }

    /// <summary>
    /// IntProperty: CummulativeComboAchieved
    /// </summary>
    public unsafe int CummulativeComboAchieved
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7632); }
    }

    /// <summary>
    /// IntProperty: CounterPrompt
    /// </summary>
    public unsafe int CounterPrompt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7636); }
    }

    /// <summary>
    /// FloatProperty: CounterPromptTimer
    /// </summary>
    public unsafe float CounterPromptTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7640); }
    }

    /// <summary>
    /// FloatProperty: LastFailTime
    /// </summary>
    public unsafe float LastFailTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7644); }
    }

    /// <summary>
    /// NameProperty: LastFailAnimName
    /// </summary>
    public unsafe BmSDK.FName LastFailAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7648); }
    }

    /// <summary>
    /// IntProperty: MaxComboSize
    /// </summary>
    public unsafe int MaxComboSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7656); }
    }

    /// <summary>
    /// IntProperty: MaxCombatants
    /// </summary>
    public unsafe int MaxCombatants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7660); }
    }

    /// <summary>
    /// IntProperty: MaxComboVariation
    /// </summary>
    public unsafe int MaxComboVariation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7664); }
    }

    /// <summary>
    /// IntProperty: MaxComboVariationNoGadgets
    /// </summary>
    public unsafe int MaxComboVariationNoGadgets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7668); }
    }

    /// <summary>
    /// IntProperty: TimesHitInThisFight
    /// </summary>
    public unsafe int TimesHitInThisFight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7672); }
    }

    /// <summary>
    /// StructProperty: StoredCombatXPInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGameInfo.FCombatXPInfo StoredCombatXPInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameInfo.FCombatXPInfo>(Ptr + 7676);

    /// <summary>
    /// IntProperty: StoredComboBonus
    /// </summary>
    public unsafe int StoredComboBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7776); }
    }

    /// <summary>
    /// IntProperty: StoredMaxCombatants
    /// </summary>
    public unsafe int StoredMaxCombatants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7780); }
    }

    /// <summary>
    /// IntProperty: StoredVariationBonus
    /// </summary>
    public unsafe int StoredVariationBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7784); }
    }

    /// <summary>
    /// IntProperty: StoredGadgetVariationBonus
    /// </summary>
    public unsafe int StoredGadgetVariationBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7788); }
    }

    /// <summary>
    /// IntProperty: StoredNumberOfCombos
    /// </summary>
    public unsafe int StoredNumberOfCombos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7792); }
    }

    /// <summary>
    /// IntProperty: StoredNumCombatants
    /// </summary>
    public unsafe int StoredNumCombatants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7796); }
    }

    /// <summary>
    /// IntProperty: StoredNumThugs
    /// </summary>
    public unsafe int StoredNumThugs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7800); }
    }

    /// <summary>
    /// IntProperty: StoredNumCombatExperts
    /// </summary>
    public unsafe int StoredNumCombatExperts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7804); }
    }

    /// <summary>
    /// IntProperty: StoredNumBrutes
    /// </summary>
    public unsafe int StoredNumBrutes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7808); }
    }

    /// <summary>
    /// IntProperty: StoredNumMedics
    /// </summary>
    public unsafe int StoredNumMedics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7812); }
    }

    /// <summary>
    /// IntProperty: StoredNumRobots
    /// </summary>
    public unsafe int StoredNumRobots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7816); }
    }

    /// <summary>
    /// IntProperty: StoredNumDollotrons
    /// </summary>
    public unsafe int StoredNumDollotrons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7820); }
    }

    /// <summary>
    /// IntProperty: StoredNumJokerBoxer
    /// </summary>
    public unsafe int StoredNumJokerBoxer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7824); }
    }

    /// <summary>
    /// IntProperty: StoredNumRiddlerMech
    /// </summary>
    public unsafe int StoredNumRiddlerMech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7828); }
    }

    /// <summary>
    /// IntProperty: StoredNumPyg
    /// </summary>
    public unsafe int StoredNumPyg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7832); }
    }

    /// <summary>
    /// IntProperty: StoredNumBlackfire
    /// </summary>
    public unsafe int StoredNumBlackfire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7836); }
    }

    /// <summary>
    /// IntProperty: StoredNumBats
    /// </summary>
    public unsafe int StoredNumBats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7840); }
    }

    /// <summary>
    /// IntProperty: StoredNumKnives
    /// </summary>
    public unsafe int StoredNumKnives
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7844); }
    }

    /// <summary>
    /// IntProperty: StoredNumShields
    /// </summary>
    public unsafe int StoredNumShields
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7848); }
    }

    /// <summary>
    /// IntProperty: StoredNumStunSticks
    /// </summary>
    public unsafe int StoredNumStunSticks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7852); }
    }

    /// <summary>
    /// IntProperty: StoredNumGuns
    /// </summary>
    public unsafe int StoredNumGuns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7856); }
    }

    /// <summary>
    /// IntProperty: StoredNumCrates
    /// </summary>
    public unsafe int StoredNumCrates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7860); }
    }

    /// <summary>
    /// StructProperty: StoredPredatorXPInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGameInfo.FPredatorXPInfo StoredPredatorXPInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameInfo.FPredatorXPInfo>(Ptr + 7864);

    /// <summary>
    /// IntProperty: HitsSinceCounter
    /// </summary>
    public unsafe int HitsSinceCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7936); }
    }

    /// <summary>
    /// IntProperty: ChargesSinceBatarang
    /// </summary>
    public unsafe int ChargesSinceBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7940); }
    }

    /// <summary>
    /// IntProperty: SetComboFrames
    /// </summary>
    public unsafe int SetComboFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7944); }
    }

    /// <summary>
    /// IntProperty: ShowCriticalFrames
    /// </summary>
    public unsafe int ShowCriticalFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7948); }
    }

    /// <summary>
    /// IntProperty: CriticalComboChain
    /// </summary>
    public unsafe int CriticalComboChain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7952); }
    }

    /// <summary>
    /// FloatProperty: NotInCombatTimer
    /// </summary>
    public unsafe float NotInCombatTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7956); }
    }

    /// <summary>
    /// IntProperty: BlockedByArmouredSinceBeatdown
    /// </summary>
    public unsafe int BlockedByArmouredSinceBeatdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7960); }
    }

    /// <summary>
    /// IntProperty: BlockedByMultiStageSinceBeatdown
    /// </summary>
    public unsafe int BlockedByMultiStageSinceBeatdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7964); }
    }

    /// <summary>
    /// IntProperty: RepelledByMultiStageSinceBeatdown
    /// </summary>
    public unsafe int RepelledByMultiStageSinceBeatdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7968); }
    }

    /// <summary>
    /// IntProperty: BlockedByShieldSinceAerial
    /// </summary>
    public unsafe int BlockedByShieldSinceAerial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7972); }
    }

    /// <summary>
    /// IntProperty: BlockedByTitanSinceSuperStun
    /// </summary>
    public unsafe int BlockedByTitanSinceSuperStun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7976); }
    }

    /// <summary>
    /// IntProperty: StunStickHits
    /// </summary>
    public unsafe int StunStickHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7980); }
    }

    /// <summary>
    /// IntProperty: BladeHits
    /// </summary>
    public unsafe int BladeHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7984); }
    }

    /// <summary>
    /// ArrayProperty: ComboValueReachedActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_ComboValueReached> ComboValueReachedActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_ComboValueReached>>(Ptr + 7988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7988); }
    }

    /// <summary>
    /// IntProperty: ConsecutiveBatarangsOrRedirects
    /// </summary>
    public unsafe int ConsecutiveBatarangsOrRedirects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8004); }
    }

    /// <summary>
    /// StrProperty: CombatBonusSummaryString
    /// </summary>
    public unsafe BmSDK.FString CombatBonusSummaryString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8008); }
    }

    /// <summary>
    /// FloatProperty: CombatBonusDelayTime
    /// </summary>
    public unsafe float CombatBonusDelayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8024); }
    }

    /// <summary>
    /// StructProperty: LastAttacked
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPlayerControllerCombat.FStruckInfo LastAttacked
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPlayerControllerCombat.FStruckInfo>(Ptr + 8028);

    /// <summary>
    /// ArrayProperty: ComboMoves
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerControllerCombat.FComboMoveInfo> ComboMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerControllerCombat.FComboMoveInfo>>(Ptr + 8040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8040); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: MoveTypeCount
    /// </summary>
    public InlineArray<int> MoveTypeCount => new(71, Ptr + 8056, 4, this);

    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8056); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8060); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8064); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8068); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8072); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8076); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8080); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8084); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8088); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8092); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8096); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8100); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8104); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8108); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8112); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8116); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8120); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8124); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8128); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8132); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8136); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8140); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8144); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8148); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8152); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8156); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8160); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8164); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8168); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8172); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8176); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8180); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8184); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8188); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8192); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8196); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8200); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8204); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8208); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8212); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8216); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8220); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8224); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8228); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8232); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8236); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8240); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8244); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8248); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8252); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8256); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8260); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8264); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8268); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8272); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8276); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8280); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8284); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8288); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8292); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8296); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8300); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8304); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8308); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8312); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8316); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8320); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8324); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_68
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8328); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_69
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8332); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_70
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8336); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: ComboMoveType
    /// </summary>
    public InlineArray<int> ComboMoveType => new(71, Ptr + 8340, 4, this);

    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8340); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8344); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8348); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8352); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8356); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8360); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8364); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8368); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8372); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8376); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8380); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8384); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8388); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8392); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8396); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8400); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8404); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8408); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8412); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8416); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8420); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8424); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8428); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8432); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8436); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8440); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8444); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8448); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8452); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8456); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8460); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8464); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8468); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8472); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8476); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8480); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8484); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8488); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8492); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8496); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8500); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8504); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8508); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8512); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8516); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8520); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8524); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8528); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8532); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8536); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8540); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8544); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8548); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8552); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8556); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8560); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8564); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8568); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8572); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8576); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8580); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8584); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8588); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8592); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8596); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8600); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8604); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8608); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_68
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8612); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_69
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8616); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_70
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8620); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: GadgetMoveType
    /// </summary>
    public InlineArray<int> GadgetMoveType => new(71, Ptr + 8624, 4, this);

    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8624); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8628); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8632); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8636); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8640); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8644); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8648); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8652); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8656); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8660); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8664); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8668); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8672); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8676); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8680); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8684); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8688); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8692); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8696); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8700); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8704); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8708); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8712); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8716); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8720); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8724); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8728); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8732); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8736); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8740); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8744); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8748); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8752); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8756); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8760); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8764); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8768); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8772); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8776); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8780); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8784); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8788); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8792); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8796); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8800); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8804); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8808); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8812); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8816); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8820); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8824); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8828); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8832); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8836); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8840); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8844); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8848); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8852); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8856); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8860); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8864); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8868); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8872); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8876); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8880); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8884); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8888); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8892); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_68
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8896); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_69
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8900); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_70
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8904); }
    }

    /// <summary>
    /// FloatProperty: CurrentLookAtTargetTime
    /// </summary>
    public unsafe float CurrentLookAtTargetTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8908); }
    }

    /// <summary>
    /// IntProperty: FrontCounters
    /// </summary>
    public unsafe int FrontCounters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8912); }
    }

    /// <summary>
    /// IntProperty: BackCounters
    /// </summary>
    public unsafe int BackCounters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8916); }
    }

    /// <summary>
    /// FloatProperty: CurrCombatCamDistModifier
    /// </summary>
    public unsafe float CurrCombatCamDistModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8920); }
    }

    /// <summary>
    /// FloatProperty: CurrSuperComboPPAmount
    /// </summary>
    public unsafe float CurrSuperComboPPAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8924); }
    }

    /// <summary>
    /// FloatProperty: SniperPPVal
    /// </summary>
    public unsafe float SniperPPVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8928); }
    }

    /// <summary>
    /// FloatProperty: lastSniperPPUpdateTime
    /// </summary>
    public unsafe float lastSniperPPUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8932); }
    }

    /// <summary>
    /// FloatProperty: MaxVariationSpeedMulti
    /// </summary>
    public unsafe float MaxVariationSpeedMulti
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8936); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastStrikeRequest
    /// </summary>
    public unsafe float TimeSinceLastStrikeRequest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8940); }
    }

    /// <summary>
    /// FloatProperty: FixedCombatCam_NoBaseTimer
    /// </summary>
    public unsafe float FixedCombatCam_NoBaseTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8944); }
    }

    /// <summary>
    /// StrProperty: OverridenDeathTip
    /// </summary>
    public unsafe BmSDK.FString OverridenDeathTip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8948); }
    }

    /// <summary>
    /// ArrayProperty: ClearComboReasons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ClearComboReasons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 8964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8964); }
    }

    /// <summary>
    /// StrProperty: LastClearComboReason
    /// </summary>
    public unsafe BmSDK.FString LastClearComboReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8980); }
    }

    /// <summary>
    /// FloatProperty: lastFlashBangHitTime
    /// </summary>
    public unsafe float lastFlashBangHitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8996); }
    }
}
