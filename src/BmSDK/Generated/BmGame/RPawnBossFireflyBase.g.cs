#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPawnBossFireflyBase<br/>
/// (size = 7076)
/// (flags = 144703671)
/// </summary>
public partial class RPawnBossFireflyBase : BmSDK.BmGame.RPawnVillain, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnBossFireflyBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnBossFireflyBase.
    /// </summary>
    public static RPawnBossFireflyBase DefaultObject => (RPawnBossFireflyBase)StaticClass().DefaultObject;

    internal RPawnBossFireflyBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnBossFireflyBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossFireflyBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossFireflyBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossFireflyBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossFireflyBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossFireflyBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossFireflyBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossFireflyBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossFireflyBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_TriggerFFBark;
    /// <summary>
    /// Function: TriggerFFBark
    /// </summary>
    public unsafe virtual bool TriggerFFBark(BmSDK.FName eventFlagName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerFFBark, "BmGame.RPawnBossFireflyBase.TriggerFFBark");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eventFlagName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TriggerSecondChaseOutroGauntlet;
    /// <summary>
    /// Function: TriggerSecondChaseOutroGauntlet
    /// </summary>
    public unsafe virtual bool TriggerSecondChaseOutroGauntlet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSecondChaseOutroGauntlet, "BmGame.RPawnBossFireflyBase.TriggerSecondChaseOutroGauntlet");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerFirstChaseOutroGauntlet;
    /// <summary>
    /// Function: TriggerFirstChaseOutroGauntlet
    /// </summary>
    public unsafe virtual bool TriggerFirstChaseOutroGauntlet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerFirstChaseOutroGauntlet, "BmGame.RPawnBossFireflyBase.TriggerFirstChaseOutroGauntlet");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NotifyBeatdownFailed;
    /// <summary>
    /// Function: NotifyBeatdownFailed
    /// </summary>
    public unsafe virtual void NotifyBeatdownFailed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyBeatdownFailed, "BmGame.RPawnBossFireflyBase.NotifyBeatdownFailed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyBeatdownComplete;
    /// <summary>
    /// Function: NotifyBeatdownComplete
    /// </summary>
    public unsafe virtual void NotifyBeatdownComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyBeatdownComplete, "BmGame.RPawnBossFireflyBase.NotifyBeatdownComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CleanUpGrenades;
    /// <summary>
    /// Function: CleanUpGrenades
    /// </summary>
    public unsafe virtual void CleanUpGrenades()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanUpGrenades, "BmGame.RPawnBossFireflyBase.CleanUpGrenades");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyGrenadeDidDamage;
    /// <summary>
    /// Function: NotifyGrenadeDidDamage
    /// </summary>
    public unsafe virtual void NotifyGrenadeDidDamage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyGrenadeDidDamage, "BmGame.RPawnBossFireflyBase.NotifyGrenadeDidDamage");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveGrenadeFromList;
    /// <summary>
    /// Function: RemoveGrenadeFromList
    /// </summary>
    public unsafe virtual void RemoveGrenadeFromList(BmSDK.BmGame.RProjectile_GrenadeBase gren)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveGrenadeFromList, "BmGame.RPawnBossFireflyBase.RemoveGrenadeFromList");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(gren, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitiateTakedownMove;
    /// <summary>
    /// Function: InitiateTakedownMove
    /// </summary>
    public unsafe virtual void InitiateTakedownMove(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitiateTakedownMove, "BmGame.RPawnBossFireflyBase.InitiateTakedownMove");
        byte* paramsPtr = stackalloc byte[168];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NeedsFallbackTakedownInstructions;
    /// <summary>
    /// Function: NeedsFallbackTakedownInstructions
    /// </summary>
    public unsafe virtual bool NeedsFallbackTakedownInstructions()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NeedsFallbackTakedownInstructions, "BmGame.RPawnBossFireflyBase.NeedsFallbackTakedownInstructions");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InRangeForActualTakedown;
    /// <summary>
    /// Function: InRangeForActualTakedown
    /// </summary>
    public unsafe virtual bool InRangeForActualTakedown(System.Numerics.Vector3 Loc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InRangeForActualTakedown, "BmGame.RPawnBossFireflyBase.InRangeForActualTakedown");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_InRangeForTakedownPrompt;
    /// <summary>
    /// Function: InRangeForTakedownPrompt
    /// </summary>
    public unsafe virtual bool InRangeForTakedownPrompt(System.Numerics.Vector3 Loc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InRangeForTakedownPrompt, "BmGame.RPawnBossFireflyBase.InRangeForTakedownPrompt");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_DropBomb_TimedRecursive;
    /// <summary>
    /// Function: DropBomb_TimedRecursive
    /// </summary>
    public unsafe virtual void DropBomb_TimedRecursive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropBomb_TimedRecursive, "BmGame.RPawnBossFireflyBase.DropBomb_TimedRecursive");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateTargetVFX;
    /// <summary>
    /// Function: UpdateTargetVFX
    /// </summary>
    public unsafe virtual void UpdateTargetVFX(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTargetVFX, "BmGame.RPawnBossFireflyBase.UpdateTargetVFX");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryDeactivateTargetVFX;
    /// <summary>
    /// Function: TryDeactivateTargetVFX
    /// </summary>
    public unsafe virtual void TryDeactivateTargetVFX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryDeactivateTargetVFX, "BmGame.RPawnBossFireflyBase.TryDeactivateTargetVFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryActivateTargetVFX;
    /// <summary>
    /// Function: TryActivateTargetVFX
    /// </summary>
    public unsafe virtual void TryActivateTargetVFX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryActivateTargetVFX, "BmGame.RPawnBossFireflyBase.TryActivateTargetVFX");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableBoostFX;
    /// <summary>
    /// Function: DisableBoostFX
    /// </summary>
    public unsafe virtual void DisableBoostFX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableBoostFX, "BmGame.RPawnBossFireflyBase.DisableBoostFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableBoostFX;
    /// <summary>
    /// Function: EnableBoostFX
    /// </summary>
    public unsafe virtual void EnableBoostFX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableBoostFX, "BmGame.RPawnBossFireflyBase.EnableBoostFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableSmokeTrail;
    /// <summary>
    /// Function: DisableSmokeTrail
    /// </summary>
    public unsafe virtual void DisableSmokeTrail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableSmokeTrail, "BmGame.RPawnBossFireflyBase.DisableSmokeTrail");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableSmokeTrail;
    /// <summary>
    /// Function: EnableSmokeTrail
    /// </summary>
    public unsafe virtual void EnableSmokeTrail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableSmokeTrail, "BmGame.RPawnBossFireflyBase.EnableSmokeTrail");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyFFFliesAwayAfterBeatdown;
    /// <summary>
    /// Function: NotifyFFFliesAwayAfterBeatdown
    /// </summary>
    public unsafe virtual void NotifyFFFliesAwayAfterBeatdown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFFFliesAwayAfterBeatdown, "BmGame.RPawnBossFireflyBase.NotifyFFFliesAwayAfterBeatdown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OutroGauntletFinished;
    /// <summary>
    /// Function: OutroGauntletFinished
    /// </summary>
    public unsafe virtual void OutroGauntletFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OutroGauntletFinished, "BmGame.RPawnBossFireflyBase.OutroGauntletFinished");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NoMorePunches;
    /// <summary>
    /// Function: NoMorePunches
    /// </summary>
    public unsafe virtual void NoMorePunches()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NoMorePunches, "BmGame.RPawnBossFireflyBase.NoMorePunches");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PunchConnected;
    /// <summary>
    /// Function: PunchConnected
    /// </summary>
    public unsafe virtual void PunchConnected()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PunchConnected, "BmGame.RPawnBossFireflyBase.PunchConnected");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayPunchedEmote;
    /// <summary>
    /// Function: PlayPunchedEmote
    /// </summary>
    public unsafe virtual void PlayPunchedEmote()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayPunchedEmote, "BmGame.RPawnBossFireflyBase.PlayPunchedEmote");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CityOutOfView;
    /// <summary>
    /// Function: CityOutOfView
    /// </summary>
    public unsafe virtual void CityOutOfView()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CityOutOfView, "BmGame.RPawnBossFireflyBase.CityOutOfView");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CamPointingUpDuringTakedown;
    /// <summary>
    /// Function: CamPointingUpDuringTakedown
    /// </summary>
    public unsafe virtual void CamPointingUpDuringTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CamPointingUpDuringTakedown, "BmGame.RPawnBossFireflyBase.CamPointingUpDuringTakedown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RPawnBossFireflyBase.Destroyed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireflyPawnNoLongerRequired;
    /// <summary>
    /// Function: FireflyPawnNoLongerRequired
    /// </summary>
    public unsafe virtual void FireflyPawnNoLongerRequired()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireflyPawnNoLongerRequired, "BmGame.RPawnBossFireflyBase.FireflyPawnNoLongerRequired");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RPawnBossFireflyBase.Tick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RPawnBossFireflyBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamagedBy;
    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedBy, "BmGame.RPawnBossFireflyBase.DamagedBy");
        byte* paramsPtr = stackalloc byte[265];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 248);
    }

    private static BmSDK.Function __fn_WarnAboutRiotSurpressorShot;
    /// <summary>
    /// Function: WarnAboutRiotSurpressorShot
    /// </summary>
    public unsafe override void WarnAboutRiotSurpressorShot()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WarnAboutRiotSurpressorShot, "BmGame.RPawnBossFireflyBase.WarnAboutRiotSurpressorShot");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EncroachedBy;
    /// <summary>
    /// Function: EncroachedBy
    /// </summary>
    public unsafe override void EncroachedBy(BmSDK.Engine.Actor Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EncroachedBy, "BmGame.RPawnBossFireflyBase.EncroachedBy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopGPS;
    /// <summary>
    /// Function: StopGPS
    /// </summary>
    public unsafe virtual bool StopGPS()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopGPS, "BmGame.RPawnBossFireflyBase.StopGPS");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Disarm;
    /// <summary>
    /// Function: Disarm
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMCombatThrownObject Disarm(BmSDK.Class DisarmDamageType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Disarm, "BmGame.RPawnBossFireflyBase.Disarm");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisarmDamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AreTakedownsFatal;
    /// <summary>
    /// Function: AreTakedownsFatal
    /// </summary>
    public unsafe override bool AreTakedownsFatal()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreTakedownsFatal, "BmGame.RPawnBossFireflyBase.AreTakedownsFatal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldForceBeatDown;
    /// <summary>
    /// Function: ShouldForceBeatDown
    /// </summary>
    public unsafe override bool ShouldForceBeatDown(BmSDK.BmGame.RPawnPlayerCombat TestPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceBeatDown, "BmGame.RPawnBossFireflyBase.ShouldForceBeatDown");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanRedirect;
    /// <summary>
    /// Function: CanRedirect
    /// </summary>
    public unsafe override bool CanRedirect()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanRedirect, "BmGame.RPawnBossFireflyBase.CanRedirect");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAwareOfPlayer;
    /// <summary>
    /// Function: IsAwareOfPlayer
    /// </summary>
    public unsafe override bool IsAwareOfPlayer(BmSDK.BmGame.RPawnPlayer PlayerPawn, BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAwareOfPlayer, "BmGame.RPawnBossFireflyBase.IsAwareOfPlayer");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CheckForOverridenTakedown;
    /// <summary>
    /// Function: CheckForOverridenTakedown
    /// </summary>
    public unsafe override bool CheckForOverridenTakedown(BmSDK.BmGame.RGameInfo.EStealthTakeDownStages takedown_stage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForOverridenTakedown, "BmGame.RPawnBossFireflyBase.CheckForOverridenTakedown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown_stage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsVulnerableToTakedown;
    /// <summary>
    /// Function: IsVulnerableToTakedown
    /// </summary>
    public unsafe override bool IsVulnerableToTakedown(BmSDK.FString takedown)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVulnerableToTakedown, "BmGame.RPawnBossFireflyBase.IsVulnerableToTakedown");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsBoss;
    /// <summary>
    /// Function: IsBoss
    /// </summary>
    public unsafe override bool IsBoss()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBoss, "BmGame.RPawnBossFireflyBase.IsBoss");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HitByFracturePart;
    /// <summary>
    /// Function: HitByFracturePart
    /// </summary>
    public unsafe virtual void HitByFracturePart()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByFracturePart, "BmGame.RPawnBossFireflyBase.HitByFracturePart");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PossibleCarCollisionWarning;
    /// <summary>
    /// Function: PossibleCarCollisionWarning
    /// </summary>
    public unsafe override void PossibleCarCollisionWarning(BmSDK.Engine.Actor V, float Speed, float DeltaTime, bool bForceDive = default, bool bZap = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PossibleCarCollisionWarning, "BmGame.RPawnBossFireflyBase.PossibleCarCollisionWarning");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDive, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bZap, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProjectPointOntoPlane;
    /// <summary>
    /// Function: ProjectPointOntoPlane
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 ProjectPointOntoPlane(out System.Numerics.Vector3 rPlaneNormal, out System.Numerics.Vector3 rPointOnPlane, out System.Numerics.Vector3 rPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProjectPointOntoPlane, "BmGame.RPawnBossFireflyBase.ProjectPointOntoPlane");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out rPlaneNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rPlaneNormal, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out rPointOnPlane);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rPointOnPlane, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out rPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rPoint, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        rPlaneNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        rPointOnPlane = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        rPoint = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_MoveNoCollision;
    /// <summary>
    /// Function: MoveNoCollision
    /// </summary>
    public unsafe virtual bool MoveNoCollision(System.Numerics.Vector3 Delta)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveNoCollision, "BmGame.RPawnBossFireflyBase.MoveNoCollision");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_UpdateRotation;
    /// <summary>
    /// Function: UpdateRotation
    /// </summary>
    public unsafe virtual void UpdateRotation(float DeltaTime, System.Numerics.Vector3 Destination, float currMaxSpeed, float cruisingMaxSpeed, float evasionMaxSpeed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRotation, "BmGame.RPawnBossFireflyBase.UpdateRotation");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Destination, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(currMaxSpeed, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cruisingMaxSpeed, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(evasionMaxSpeed, paramsPtr + 24);
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

    private static BmSDK.Function __fn_AccelerateTowards;
    /// <summary>
    /// Function: AccelerateTowards
    /// </summary>
    public unsafe virtual void AccelerateTowards(float DeltaTime, System.Numerics.Vector3 Destination, float currMaxSpeed, float cruisingMaxSpeed, float evasionMaxSpeed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AccelerateTowards, "BmGame.RPawnBossFireflyBase.AccelerateTowards");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Destination, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(currMaxSpeed, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cruisingMaxSpeed, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(evasionMaxSpeed, paramsPtr + 24);
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
    /// ObjectProperty: BMAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BMAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 6664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6664); }
    }

    /// <summary>
    /// ObjectProperty: FFAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet FFAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 6672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6672); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CameraAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 6680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6680); }
    }

    /// <summary>
    /// ObjectProperty: BatmanPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer BatmanPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 6688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6688); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 6696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6696); }
    }

    /// <summary>
    /// ObjectProperty: BeatDownMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BeatDownMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6704); }
    }

    /// <summary>
    /// ObjectProperty: JetpackSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent JetpackSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6712); }
    }

    /// <summary>
    /// ObjectProperty: BossModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleBoss BossModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleBoss>(Ptr + 6720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6720); }
    }

    /// <summary>
    /// ObjectProperty: PunchEmoteContainer
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech PunchEmoteContainer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 6728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6728); }
    }

    /// <summary>
    /// ComponentProperty: FlameThrower
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent FlameThrower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6736); }
    }

    /// <summary>
    /// ClassProperty: GrenadeClass
    /// </summary>
    public unsafe BmSDK.Class GrenadeClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6744); }
    }

    /// <summary>
    /// ComponentProperty: targetVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent targetVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6752); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: smokePFX
    /// </summary>
    public InlineArray<BmSDK.Engine.ParticleSystemComponent> smokePFX => new(2, Ptr + 6760, 8, this);

    /// <summary>
    /// ComponentProperty: smokePFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent smokePFX_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6760); }
    }
    /// <summary>
    /// ComponentProperty: smokePFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent smokePFX_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6768); }
    }

    /// <summary>
    /// BoolProperty: bDrawDebug
    /// </summary>
    public unsafe bool bDrawDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6776); }
    }

    /// <summary>
    /// BoolProperty: bTargetVFXShouldBeActive
    /// </summary>
    public unsafe bool bTargetVFXShouldBeActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6776); }
    }

    /// <summary>
    /// BoolProperty: bNoMovement
    /// </summary>
    public unsafe bool bNoMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6776); }
    }

    /// <summary>
    /// BoolProperty: targetVFXOn
    /// </summary>
    public unsafe bool targetVFXOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6776); }
    }

    /// <summary>
    /// BoolProperty: bDrawDistanceDebug
    /// </summary>
    public unsafe bool bDrawDistanceDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6776); }
    }

    /// <summary>
    /// BoolProperty: bSmokeTrailRunning
    /// </summary>
    public unsafe bool bSmokeTrailRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6776); }
    }

    /// <summary>
    /// BoolProperty: bBoostEffectRunning
    /// </summary>
    public unsafe bool bBoostEffectRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6776); }
    }

    /// <summary>
    /// BoolProperty: bOutOfFuel
    /// </summary>
    public unsafe bool bOutOfFuel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6776); }
    }

    /// <summary>
    /// InlineArray{StrProperty}: encounterCompleteFlagNames
    /// </summary>
    public InlineArray<BmSDK.FString> encounterCompleteFlagNames => new(3, Ptr + 6780, 16, this);

    /// <summary>
    /// StrProperty: encounterCompleteFlagNames
    /// </summary>
    public unsafe BmSDK.FString encounterCompleteFlagNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6780); }
    }
    /// <summary>
    /// StrProperty: encounterCompleteFlagNames
    /// </summary>
    public unsafe BmSDK.FString encounterCompleteFlagNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6796); }
    }
    /// <summary>
    /// StrProperty: encounterCompleteFlagNames
    /// </summary>
    public unsafe BmSDK.FString encounterCompleteFlagNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6812); }
    }

    /// <summary>
    /// IntProperty: numEncountersComplete
    /// </summary>
    public unsafe int numEncountersComplete
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6828); }
    }

    /// <summary>
    /// FloatProperty: healthProportion
    /// </summary>
    public unsafe float healthProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6832); }
    }

    /// <summary>
    /// FloatProperty: targetVFXZOffset
    /// </summary>
    public unsafe float targetVFXZOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6836); }
    }

    /// <summary>
    /// FloatProperty: targetLinePulseProportion
    /// </summary>
    public unsafe float targetLinePulseProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6840); }
    }

    /// <summary>
    /// FloatProperty: targetLinePulseStartDist
    /// </summary>
    public unsafe float targetLinePulseStartDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6844); }
    }

    /// <summary>
    /// FloatProperty: targetLinePulsePeriod_Max
    /// </summary>
    public unsafe float targetLinePulsePeriod_Max
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6848); }
    }

    /// <summary>
    /// FloatProperty: targetLinePulsePeriod_Min
    /// </summary>
    public unsafe float targetLinePulsePeriod_Min
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6852); }
    }

    /// <summary>
    /// StructProperty: DirectionalAnimNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DirectionalAnimNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6856);

    /// <summary>
    /// StructProperty: TiltVector
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TiltVector
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6868);

    /// <summary>
    /// FloatProperty: HorizontalRubberbandingPeriod
    /// </summary>
    public unsafe float HorizontalRubberbandingPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6880); }
    }

    /// <summary>
    /// FloatProperty: MaxHorizontalAcceleration
    /// </summary>
    public unsafe float MaxHorizontalAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6884); }
    }

    /// <summary>
    /// FloatProperty: VerticalRubberbandingPeriod
    /// </summary>
    public unsafe float VerticalRubberbandingPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6888); }
    }

    /// <summary>
    /// FloatProperty: MaxVerticalAcceleration
    /// </summary>
    public unsafe float MaxVerticalAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6892); }
    }

    /// <summary>
    /// StructProperty: currentAcceleration
    /// </summary>
    public unsafe ref System.Numerics.Vector3 currentAcceleration
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6896);

    /// <summary>
    /// StructProperty: currentFlightVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 currentFlightVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6908);

    /// <summary>
    /// FloatProperty: timeWhenEnergyRanOut
    /// </summary>
    public unsafe float timeWhenEnergyRanOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6920); }
    }

    /// <summary>
    /// FloatProperty: rollRateCurrent
    /// </summary>
    public unsafe float rollRateCurrent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6924); }
    }

    /// <summary>
    /// FloatProperty: rollRateMax
    /// </summary>
    public unsafe float rollRateMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6928); }
    }

    /// <summary>
    /// FloatProperty: rollRateTimeTillMax
    /// </summary>
    public unsafe float rollRateTimeTillMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6932); }
    }

    /// <summary>
    /// FloatProperty: turnAnimRateOfChange
    /// </summary>
    public unsafe float turnAnimRateOfChange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6936); }
    }

    /// <summary>
    /// FloatProperty: rollAnimMultiplier
    /// </summary>
    public unsafe float rollAnimMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6940); }
    }

    /// <summary>
    /// FloatProperty: codeRollMaxDeg
    /// </summary>
    public unsafe float codeRollMaxDeg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6944); }
    }

    /// <summary>
    /// FloatProperty: yawChangeRate
    /// </summary>
    public unsafe float yawChangeRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6948); }
    }

    /// <summary>
    /// FloatProperty: animForwardMin
    /// </summary>
    public unsafe float animForwardMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6952); }
    }

    /// <summary>
    /// FloatProperty: animForwardMax
    /// </summary>
    public unsafe float animForwardMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6956); }
    }

    /// <summary>
    /// ArrayProperty: activeGrenades
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RProjectile_GrenadeBase> activeGrenades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RProjectile_GrenadeBase>>(Ptr + 6960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6960); }
    }

    /// <summary>
    /// FloatProperty: rotV2_DYawDegreesRequiredForMaxRoll
    /// </summary>
    public unsafe float rotV2_DYawDegreesRequiredForMaxRoll
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6976); }
    }

    /// <summary>
    /// FloatProperty: rotV2_RollAccelTime
    /// </summary>
    public unsafe float rotV2_RollAccelTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6980); }
    }

    /// <summary>
    /// FloatProperty: rotV2_RollDrivingYawRate
    /// </summary>
    public unsafe float rotV2_RollDrivingYawRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6984); }
    }

    /// <summary>
    /// FloatProperty: rotV2_CurrentRollProportion
    /// </summary>
    public unsafe float rotV2_CurrentRollProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6988); }
    }

    /// <summary>
    /// FloatProperty: rotV2_TargetRollProportion
    /// </summary>
    public unsafe float rotV2_TargetRollProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6992); }
    }

    /// <summary>
    /// FloatProperty: rotV2_CurrentRollRate
    /// </summary>
    public unsafe float rotV2_CurrentRollRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6996); }
    }

    /// <summary>
    /// StructProperty: prevLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 prevLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7000);

    /// <summary>
    /// FloatProperty: minSmokeSpawnRate
    /// </summary>
    public unsafe float minSmokeSpawnRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7012); }
    }

    /// <summary>
    /// FloatProperty: maxSmokeRateVelocity
    /// </summary>
    public unsafe float maxSmokeRateVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7016); }
    }

    /// <summary>
    /// FloatProperty: prevFrameVelocity
    /// </summary>
    public unsafe float prevFrameVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7020); }
    }

    /// <summary>
    /// FloatProperty: currentSmokeSpawnRate
    /// </summary>
    public unsafe float currentSmokeSpawnRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7024); }
    }

    /// <summary>
    /// FloatProperty: lastBoostEffectTriggerTime
    /// </summary>
    public unsafe float lastBoostEffectTriggerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7028); }
    }

    /// <summary>
    /// FloatProperty: boostProportion
    /// </summary>
    public unsafe float boostProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7032); }
    }

    /// <summary>
    /// FloatProperty: prevBoostProportion
    /// </summary>
    public unsafe float prevBoostProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7036); }
    }

    /// <summary>
    /// FloatProperty: boostParamVal
    /// </summary>
    public unsafe float boostParamVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7040); }
    }

    /// <summary>
    /// FloatProperty: boostParamMax
    /// </summary>
    public unsafe float boostParamMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7044); }
    }

    /// <summary>
    /// FloatProperty: boostParamScale
    /// </summary>
    public unsafe float boostParamScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7048); }
    }

    /// <summary>
    /// FloatProperty: boostEffectThreshold
    /// </summary>
    public unsafe float boostEffectThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7052); }
    }

    /// <summary>
    /// FloatProperty: boostEffectDuration
    /// </summary>
    public unsafe float boostEffectDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7056); }
    }

    /// <summary>
    /// FloatProperty: minTimeBetweenBoostEffects
    /// </summary>
    public unsafe float minTimeBetweenBoostEffects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7060); }
    }

    /// <summary>
    /// FloatProperty: energyShrinkPeriod
    /// </summary>
    public unsafe float energyShrinkPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7064); }
    }

    /// <summary>
    /// FloatProperty: energyProportion
    /// </summary>
    public unsafe float energyProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7068); }
    }

    /// <summary>
    /// FloatProperty: smokeFuelLevel
    /// </summary>
    public unsafe float smokeFuelLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7072); }
    }
}
