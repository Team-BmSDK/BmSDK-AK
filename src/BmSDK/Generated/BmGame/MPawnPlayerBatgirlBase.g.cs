#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: MPawnPlayerBatgirlBase<br/>
/// (size = 10308)
/// (flags = 144703671)
/// </summary>
public partial class MPawnPlayerBatgirlBase : BmSDK.BmGame.RPawnPlayerBmBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MPawnPlayerBatgirlBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnPlayerBatgirlBase.
    /// </summary>
    public static MPawnPlayerBatgirlBase DefaultObject => (MPawnPlayerBatgirlBase)StaticClass().DefaultObject;

    internal MPawnPlayerBatgirlBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnPlayerBatgirlBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.MPawnPlayerBatgirlBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FixIncorrectShimmyNotify;
    /// <summary>
    /// Function: FixIncorrectShimmyNotify
    /// </summary>
    public unsafe virtual void FixIncorrectShimmyNotify(BmSDK.Engine.AnimSet VantageAnimSet, BmSDK.FName AnimName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FixIncorrectShimmyNotify, "BmGame.MPawnPlayerBatgirlBase.FixIncorrectShimmyNotify");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VantageAnimSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateThugsDefeatedDuringScareHack;
    /// <summary>
    /// Function: UpdateThugsDefeatedDuringScareHack
    /// </summary>
    public unsafe virtual void UpdateThugsDefeatedDuringScareHack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateThugsDefeatedDuringScareHack, "BmGame.MPawnPlayerBatgirlBase.UpdateThugsDefeatedDuringScareHack");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateThugsDefeatedDuringHacking;
    /// <summary>
    /// Function: UpdateThugsDefeatedDuringHacking
    /// </summary>
    public unsafe virtual void UpdateThugsDefeatedDuringHacking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateThugsDefeatedDuringHacking, "BmGame.MPawnPlayerBatgirlBase.UpdateThugsDefeatedDuringHacking");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DelayedRestartLocalLight;
    /// <summary>
    /// Function: DelayedRestartLocalLight
    /// </summary>
    public unsafe virtual void DelayedRestartLocalLight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DelayedRestartLocalLight, "BmGame.MPawnPlayerBatgirlBase.DelayedRestartLocalLight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LocalLightReactivationDelay;
    /// <summary>
    /// Function: LocalLightReactivationDelay
    /// </summary>
    public unsafe virtual void LocalLightReactivationDelay(float TimerDelay)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LocalLightReactivationDelay, "BmGame.MPawnPlayerBatgirlBase.LocalLightReactivationDelay");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimerDelay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceLocalLightChange;
    /// <summary>
    /// Function: ForceLocalLightChange
    /// </summary>
    public unsafe virtual void ForceLocalLightChange(bool bOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceLocalLightChange, "BmGame.MPawnPlayerBatgirlBase.ForceLocalLightChange");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateCollectableProgression;
    /// <summary>
    /// Function: UpdateCollectableProgression
    /// </summary>
    public unsafe virtual void UpdateCollectableProgression()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCollectableProgression, "BmGame.MPawnPlayerBatgirlBase.UpdateCollectableProgression");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRemaningCollectables;
    /// <summary>
    /// Function: GetRemaningCollectables
    /// </summary>
    public unsafe virtual void GetRemaningCollectables(out int NbBalloon, out int NbTheeth, out int NbJITB)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRemaningCollectables, "BmGame.MPawnPlayerBatgirlBase.GetRemaningCollectables");
        byte* paramsPtr = stackalloc byte[12];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NbBalloon);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NbBalloon, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NbTheeth);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NbTheeth, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NbJITB);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NbJITB, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NbBalloon = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        NbTheeth = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        NbJITB = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_GetNumberCollectables;
    /// <summary>
    /// Function: GetNumberCollectables
    /// </summary>
    public unsafe virtual void GetNumberCollectables(out int NbBalloon, out int NbTheeth, out int NbJITB)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumberCollectables, "BmGame.MPawnPlayerBatgirlBase.GetNumberCollectables");
        byte* paramsPtr = stackalloc byte[36];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NbBalloon);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NbBalloon, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NbTheeth);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NbTheeth, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NbJITB);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NbJITB, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NbBalloon = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        NbTheeth = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        NbJITB = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_NotifyKilledForTannoy;
    /// <summary>
    /// Function: NotifyKilledForTannoy
    /// </summary>
    public unsafe virtual void NotifyKilledForTannoy(BmSDK.Engine.Pawn KilledPawn, BmSDK.BmGame.RBMRoomAIState RoomState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyKilledForTannoy, "BmGame.MPawnPlayerBatgirlBase.NotifyKilledForTannoy");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RoomState, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyAfterRescue;
    /// <summary>
    /// Function: NotifyAfterRescue
    /// </summary>
    public unsafe virtual void NotifyAfterRescue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyAfterRescue, "BmGame.MPawnPlayerBatgirlBase.NotifyAfterRescue");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHackInDangerAreaBarks;
    /// <summary>
    /// Function: PlayHackInDangerAreaBarks
    /// </summary>
    public unsafe virtual void PlayHackInDangerAreaBarks()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHackInDangerAreaBarks, "BmGame.MPawnPlayerBatgirlBase.PlayHackInDangerAreaBarks");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayBombHackBarks;
    /// <summary>
    /// Function: PlayBombHackBarks
    /// </summary>
    public unsafe virtual void PlayBombHackBarks(bool havePlayedIntro)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBombHackBarks, "BmGame.MPawnPlayerBatgirlBase.PlayBombHackBarks");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(havePlayedIntro, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsScareTakedown;
    /// <summary>
    /// Function: IsScareTakedown
    /// </summary>
    public unsafe virtual bool IsScareTakedown(BmSDK.BmGame.RGameInfo.EStealthTakeDownStages Type)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsScareTakedown, "BmGame.MPawnPlayerBatgirlBase.IsScareTakedown");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OverrideTakedownTarget;
    /// <summary>
    /// Function: OverrideTakedownTarget
    /// </summary>
    public unsafe virtual void OverrideTakedownTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideTakedownTarget, "BmGame.MPawnPlayerBatgirlBase.OverrideTakedownTarget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverrideTakedown;
    /// <summary>
    /// Function: OverrideTakedown
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.EStealthTakeDownStages OverrideTakedown(BmSDK.FName StateName, BmSDK.BmGame.RPawnPlayer.FPlayerTakedownInfo Info, BmSDK.BmGame.RPawnVillain Victim, BmSDK.BmGame.RPawnVillain Victim2)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideTakedown, "BmGame.MPawnPlayerBatgirlBase.OverrideTakedown");
        byte* paramsPtr = stackalloc byte[53];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim2, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStealthTakeDownStages>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_SetSwingChuteSpecialMove;
    /// <summary>
    /// Function: SetSwingChuteSpecialMove
    /// </summary>
    public unsafe virtual void SetSwingChuteSpecialMove(out BmSDK.BmGame.RSpecialMoveConfig SwingMove, out BmSDK.BmGame.RSpecialMoveConfig GlideMove, out BmSDK.BmGame.RSpecialMoveConfig CrouchInMove, out BmSDK.BmGame.RSpecialMoveConfig RollOutOfChute)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSwingChuteSpecialMove, "BmGame.MPawnPlayerBatgirlBase.SetSwingChuteSpecialMove");
        byte* paramsPtr = stackalloc byte[32];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SwingMove);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwingMove, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out GlideMove);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GlideMove, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CrouchInMove);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CrouchInMove, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RollOutOfChute);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RollOutOfChute, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SwingMove = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
        GlideMove = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 8);
        CrouchInMove = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 16);
        RollOutOfChute = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_SetLadderSpecialMove;
    /// <summary>
    /// Function: SetLadderSpecialMove
    /// </summary>
    public unsafe virtual void SetLadderSpecialMove(out BmSDK.BmGame.RSpecialMoveConfig BatmanClimbRunMove, out BmSDK.BmGame.RSpecialMoveConfig BatmanClimbStandMove, out BmSDK.BmGame.RSpecialMoveConfig BatmanGrateMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLadderSpecialMove, "BmGame.MPawnPlayerBatgirlBase.SetLadderSpecialMove");
        byte* paramsPtr = stackalloc byte[24];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BatmanClimbRunMove);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanClimbRunMove, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BatmanClimbStandMove);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanClimbStandMove, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BatmanGrateMove);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanGrateMove, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BatmanClimbRunMove = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
        BatmanClimbStandMove = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 8);
        BatmanGrateMove = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_HideStaff;
    /// <summary>
    /// Function: HideStaff
    /// </summary>
    public unsafe override void HideStaff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideStaff, "BmGame.MPawnPlayerBatgirlBase.HideStaff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SelectDeathTip_BG;
    /// <summary>
    /// Function: SelectDeathTip_BG
    /// </summary>
    public unsafe virtual BmSDK.FString SelectDeathTip_BG(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectDeathTip_BG, "BmGame.MPawnPlayerBatgirlBase.SelectDeathTip_BG");
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_SelectDeathMovie_BG;
    /// <summary>
    /// Function: SelectDeathMovie_BG
    /// </summary>
    public unsafe virtual BmSDK.FString SelectDeathMovie_BG(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectDeathMovie_BG, "BmGame.MPawnPlayerBatgirlBase.SelectDeathMovie_BG");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmGame.MPawnPlayerBatgirlBase.Died");
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// ObjectProperty: PlayerCounterAnimset_JokerKnife
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerCounterAnimset_JokerKnife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 10252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10252); }
    }

    /// <summary>
    /// ObjectProperty: VillainCounterAnimset_JokerKnife
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainCounterAnimset_JokerKnife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 10260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10260); }
    }

    /// <summary>
    /// ObjectProperty: BatgirlHackingGadget
    /// </summary>
    public unsafe BmSDK.BmGame.MHackingGadgetBase BatgirlHackingGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackingGadgetBase>(Ptr + 10268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10268); }
    }

    /// <summary>
    /// BoolProperty: bDebugBatgirlAttractHackVisibility
    /// </summary>
    public unsafe bool bDebugBatgirlAttractHackVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10276); }
    }

    /// <summary>
    /// BoolProperty: bScareModeOn
    /// </summary>
    public unsafe bool bScareModeOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10276); }
    }

    /// <summary>
    /// BoolProperty: bBlindModeOn
    /// </summary>
    public unsafe bool bBlindModeOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10276); }
    }

    /// <summary>
    /// IntProperty: MaxBalloon
    /// </summary>
    public unsafe int MaxBalloon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10280); }
    }

    /// <summary>
    /// IntProperty: MaxTheeth
    /// </summary>
    public unsafe int MaxTheeth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10284); }
    }

    /// <summary>
    /// IntProperty: MaxJITB
    /// </summary>
    public unsafe int MaxJITB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10288); }
    }

    /// <summary>
    /// IntProperty: Achievement_Scared_ThugDefeated_Amount_Needed
    /// </summary>
    public unsafe int Achievement_Scared_ThugDefeated_Amount_Needed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10292); }
    }

    /// <summary>
    /// IntProperty: Achievement_Scared_ThugsDefeated
    /// </summary>
    public unsafe int Achievement_Scared_ThugsDefeated
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10296); }
    }

    /// <summary>
    /// IntProperty: Achievement_ThugDefeated_DuringHack_Amount_Needed
    /// </summary>
    public unsafe int Achievement_ThugDefeated_DuringHack_Amount_Needed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10300); }
    }

    /// <summary>
    /// IntProperty: Achievement_ThugDefeated_DuringHack
    /// </summary>
    public unsafe int Achievement_ThugDefeated_DuringHack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10304); }
    }
}
