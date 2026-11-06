#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RBMPawnAI<br/>
/// (size = 4632)
/// (flags = 144703671)
/// </summary>
public partial class RBMPawnAI : BmSDK.BmGame.RBMPawnAIAnim, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMPawnAI", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMPawnAI.
    /// </summary>
    public static RBMPawnAI DefaultObject => (RBMPawnAI)StaticClass().DefaultObject;

    internal RBMPawnAI() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMPawnAI(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetLastStartledByPlayerTime;
    /// <summary>
    /// Function: SetLastStartledByPlayerTime
    /// </summary>
    public unsafe virtual void SetLastStartledByPlayerTime(float Time)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLastStartledByPlayerTime, "BmGame.RBMPawnAI.SetLastStartledByPlayerTime");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLastRevivingSomeoneElseTime;
    /// <summary>
    /// Function: SetLastRevivingSomeoneElseTime
    /// </summary>
    public unsafe virtual void SetLastRevivingSomeoneElseTime(float Time)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLastRevivingSomeoneElseTime, "BmGame.RBMPawnAI.SetLastRevivingSomeoneElseTime");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLastHitByFlashBangTime;
    /// <summary>
    /// Function: SetLastHitByFlashBangTime
    /// </summary>
    public unsafe virtual void SetLastHitByFlashBangTime(float Time)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLastHitByFlashBangTime, "BmGame.RBMPawnAI.SetLastHitByFlashBangTime");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetExtraVarsForDLCObject;
    /// <summary>
    /// Function: GetExtraVarsForDLCObject
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RExtraPawnVarsForDLC GetExtraVarsForDLCObject()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetExtraVarsForDLCObject, "BmGame.RBMPawnAI.GetExtraVarsForDLCObject");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RExtraPawnVarsForDLC>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasBatarangIncoming;
    /// <summary>
    /// Function: HasBatarangIncoming
    /// </summary>
    public unsafe virtual void HasBatarangIncoming()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasBatarangIncoming, "BmGame.RBMPawnAI.HasBatarangIncoming");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnTeleport;
    /// <summary>
    /// Function: OnTeleport
    /// </summary>
    public unsafe override void OnTeleport(BmSDK.Engine.SeqAct_Teleport Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnTeleport, "BmGame.RBMPawnAI.OnTeleport");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLevelDepthPriorityGroup;
    /// <summary>
    /// Function: SetLevelDepthPriorityGroup
    /// </summary>
    public unsafe virtual void SetLevelDepthPriorityGroup(int DepthGroup)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLevelDepthPriorityGroup, "BmGame.RBMPawnAI.SetLevelDepthPriorityGroup");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DepthGroup, paramsPtr + 0);
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

    private static BmSDK.Function __fn_FindContactName;
    /// <summary>
    /// Function: FindContactName
    /// </summary>
    public unsafe override BmSDK.Engine.AkEvent FindContactName(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindContactName, "BmGame.RBMPawnAI.FindContactName");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OnStopSpeech_AwaitingDestruction;
    /// <summary>
    /// Function: OnStopSpeech_AwaitingDestruction
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkDialogue.AkDialogueCallbackResult OnStopSpeech_AwaitingDestruction(int speechId, bool interrupted)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnStopSpeech_AwaitingDestruction, "BmGame.RBMPawnAI.OnStopSpeech_AwaitingDestruction");
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(interrupted, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogue.AkDialogueCallbackResult>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CantSpeakReason;
    /// <summary>
    /// Function: CantSpeakReason
    /// </summary>
    public unsafe override BmSDK.FString CantSpeakReason(BmSDK.Engine.AkDialogueSpeech Speech, BmSDK.Engine.AkDialogue.FAkSpeechOptions dlgOpts = default, bool dlgContinuation = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CantSpeakReason, "BmGame.RBMPawnAI.CantSpeakReason");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speech, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgOpts, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgContinuation, paramsPtr + 124);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 128);
    }

    private static BmSDK.Function __fn_CanSpeak;
    /// <summary>
    /// Function: CanSpeak
    /// </summary>
    public unsafe override bool CanSpeak(BmSDK.Engine.AkDialogueSpeech Speech, BmSDK.Engine.AkDialogue.FAkSpeechOptions dlgOpts = default, bool dlgContinuation = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSpeak, "BmGame.RBMPawnAI.CanSpeak");
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speech, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgOpts, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgContinuation, paramsPtr + 124);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 128);
    }

    private static BmSDK.Function __fn_ForcePairedAnimLoad;
    /// <summary>
    /// Function: ForcePairedAnimLoad
    /// </summary>
    public unsafe virtual void ForcePairedAnimLoad()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForcePairedAnimLoad, "BmGame.RBMPawnAI.ForcePairedAnimLoad");
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

    private static BmSDK.Function __fn_UpdateTimeSinceLastRender;
    /// <summary>
    /// Function: UpdateTimeSinceLastRender
    /// </summary>
    public unsafe virtual void UpdateTimeSinceLastRender()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTimeSinceLastRender, "BmGame.RBMPawnAI.UpdateTimeSinceLastRender");
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

    private static BmSDK.Function __fn_DestroyOrReturnToPool;
    /// <summary>
    /// Function: DestroyOrReturnToPool
    /// </summary>
    public unsafe override void DestroyOrReturnToPool(bool bForce = default, bool bStreamedOut = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyOrReturnToPool, "BmGame.RBMPawnAI.DestroyOrReturnToPool");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStreamedOut, paramsPtr + 4);
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

    private static BmSDK.Function __fn_FinishWakingFromPool;
    /// <summary>
    /// Function: FinishWakingFromPool
    /// </summary>
    public unsafe virtual bool FinishWakingFromPool(System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation, BmSDK.Class WeaponClass, bool bRequiresNavMesh = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishWakingFromPool, "BmGame.RBMPawnAI.FinishWakingFromPool");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponClass, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRequiresNavMesh, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_WakeFromPool;
    /// <summary>
    /// Function: WakeFromPool
    /// </summary>
    public unsafe virtual bool WakeFromPool(System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation, BmSDK.Class WeaponClass, bool bRequiresNavMesh = default, bool bSetLocation = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WakeFromPool, "BmGame.RBMPawnAI.WakeFromPool");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponClass, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRequiresNavMesh, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetLocation, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_SleepInPool;
    /// <summary>
    /// Function: SleepInPool
    /// </summary>
    public unsafe virtual bool SleepInPool(bool bForce = default, bool bStreamedOut = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SleepInPool, "BmGame.RBMPawnAI.SleepInPool");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStreamedOut, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetAllowedToChatter;
    /// <summary>
    /// Function: SetAllowedToChatter
    /// </summary>
    public unsafe virtual void SetAllowedToChatter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAllowedToChatter, "BmGame.RBMPawnAI.SetAllowedToChatter");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAllowedToChatterDirect;
    /// <summary>
    /// Function: SetAllowedToChatterDirect
    /// </summary>
    public unsafe virtual void SetAllowedToChatterDirect(bool bSet)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAllowedToChatterDirect, "BmGame.RBMPawnAI.SetAllowedToChatterDirect");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSet, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnChallengeModeImpact;
    /// <summary>
    /// Function: SpawnChallengeModeImpact
    /// </summary>
    public unsafe virtual void SpawnChallengeModeImpact(BmSDK.FName ImpactBone, float intensity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnChallengeModeImpact, "BmGame.RBMPawnAI.SpawnChallengeModeImpact");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactBone, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(intensity, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitMatineeBehaviour;
    /// <summary>
    /// Function: ExitMatineeBehaviour
    /// </summary>
    public unsafe virtual void ExitMatineeBehaviour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMatineeBehaviour, "BmGame.RBMPawnAI.ExitMatineeBehaviour");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishAnimControl;
    /// <summary>
    /// Function: FinishAnimControl
    /// </summary>
    public unsafe override void FinishAnimControl(BmSDK.Engine.InterpGroup InInterpGroup, BmSDK.Engine.InterpGroupInst InInterpGroupInst)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishAnimControl, "BmGame.RBMPawnAI.FinishAnimControl");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroupInst, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlendOutAnimControl;
    /// <summary>
    /// Function: BlendOutAnimControl
    /// </summary>
    public unsafe override void BlendOutAnimControl(BmSDK.Engine.InterpGroup InInterpGroup, BmSDK.Engine.InterpGroupInst InInterpGroupInst, float BlendOutDuration)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlendOutAnimControl, "BmGame.RBMPawnAI.BlendOutAnimControl");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroupInst, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendOutDuration, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginAnimControl;
    /// <summary>
    /// Function: BeginAnimControl
    /// </summary>
    public unsafe override void BeginAnimControl(BmSDK.Engine.InterpGroup InInterpGroup, BmSDK.Engine.InterpGroupInst InInterpGroupInst)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginAnimControl, "BmGame.RBMPawnAI.BeginAnimControl");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroupInst, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoKillAllEnemiesReplacement;
    /// <summary>
    /// Function: DoKillAllEnemiesReplacement
    /// </summary>
    public unsafe virtual bool DoKillAllEnemiesReplacement()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoKillAllEnemiesReplacement, "BmGame.RBMPawnAI.DoKillAllEnemiesReplacement");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetLocationCheap;
    /// <summary>
    /// Function: SetLocationCheap
    /// </summary>
    public unsafe virtual void SetLocationCheap(System.Numerics.Vector3 NewLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLocationCheap, "BmGame.RBMPawnAI.SetLocationCheap");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLocation, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetPawnToDestroyIfInStasisForTooLong;
    /// <summary>
    /// Function: SetPawnToDestroyIfInStasisForTooLong
    /// </summary>
    public unsafe virtual void SetPawnToDestroyIfInStasisForTooLong(bool bNewDestroyIfInStasis, float TimeUntilDestroy)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPawnToDestroyIfInStasisForTooLong, "BmGame.RBMPawnAI.SetPawnToDestroyIfInStasisForTooLong");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewDestroyIfInStasis, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeUntilDestroy, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TraversalEdgeRemoved;
    /// <summary>
    /// Function: TraversalEdgeRemoved
    /// </summary>
    public unsafe virtual void TraversalEdgeRemoved(BmSDK.Engine.Actor Prop)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraversalEdgeRemoved, "BmGame.RBMPawnAI.TraversalEdgeRemoved");
        byte* paramsPtr = stackalloc byte[256];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prop, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePawnFading;
    /// <summary>
    /// Function: UpdatePawnFading
    /// </summary>
    public unsafe virtual void UpdatePawnFading(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePawnFading, "BmGame.RBMPawnAI.UpdatePawnFading");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartFadeIn;
    /// <summary>
    /// Function: StartFadeIn
    /// </summary>
    public unsafe virtual void StartFadeIn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFadeIn, "BmGame.RBMPawnAI.StartFadeIn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeAndDestroyPawn;
    /// <summary>
    /// Function: FadeAndDestroyPawn
    /// </summary>
    public unsafe virtual void FadeAndDestroyPawn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeAndDestroyPawn, "BmGame.RBMPawnAI.FadeAndDestroyPawn");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHasHeadset;
    /// <summary>
    /// Function: SetHasHeadset
    /// </summary>
    public unsafe virtual void SetHasHeadset(bool HasHeadset)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHasHeadset, "BmGame.RBMPawnAI.SetHasHeadset");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HasHeadset, paramsPtr + 0);
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

    private static BmSDK.Function __fn_HitDestructibleProp;
    /// <summary>
    /// Function: HitDestructibleProp
    /// </summary>
    public unsafe override void HitDestructibleProp(BmSDK.BmGame.RDestructibleProp Prop)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitDestructibleProp, "BmGame.RBMPawnAI.HitDestructibleProp");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prop, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAttachToActor;
    /// <summary>
    /// Function: OnAttachToActor
    /// </summary>
    public unsafe override void OnAttachToActor(BmSDK.Engine.SeqAct_AttachToActor Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAttachToActor, "BmGame.RBMPawnAI.OnAttachToActor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchWeaponToDefaultBone;
    /// <summary>
    /// Function: SwitchWeaponToDefaultBone
    /// </summary>
    public unsafe virtual void SwitchWeaponToDefaultBone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchWeaponToDefaultBone, "BmGame.RBMPawnAI.SwitchWeaponToDefaultBone");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchWeaponToBone;
    /// <summary>
    /// Function: SwitchWeaponToBone
    /// </summary>
    public unsafe virtual void SwitchWeaponToBone(BmSDK.FName BoneOrSocketName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchWeaponToBone, "BmGame.RBMPawnAI.SwitchWeaponToBone");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneOrSocketName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchWeaponBoneCallback;
    /// <summary>
    /// Function: SwitchWeaponBoneCallback
    /// </summary>
    public unsafe override void SwitchWeaponBoneCallback(BmSDK.BmGame.RAnimNotify_SwitchWeaponBone NewNotify, BmSDK.BmGame.RAnimNotify_SwitchWeaponBone PreviousNotify)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchWeaponBoneCallback, "BmGame.RBMPawnAI.SwitchWeaponBoneCallback");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewNotify, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousNotify, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DiscoveredPathBlockedByBankDoor;
    /// <summary>
    /// Function: DiscoveredPathBlockedByBankDoor
    /// </summary>
    public unsafe virtual void DiscoveredPathBlockedByBankDoor(BmSDK.BmGame.RBankDoorBase BlockingDoor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DiscoveredPathBlockedByBankDoor, "BmGame.RBMPawnAI.DiscoveredPathBlockedByBankDoor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlockingDoor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TellControllerAboutCollisionWarning;
    /// <summary>
    /// Function: TellControllerAboutCollisionWarning
    /// </summary>
    public unsafe virtual void TellControllerAboutCollisionWarning(BmSDK.Engine.Actor V, float Speed, BmSDK.BmGame.RGameInfo.EEvadeVehicleType EvadeType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TellControllerAboutCollisionWarning, "BmGame.RBMPawnAI.TellControllerAboutCollisionWarning");
        byte* paramsPtr = stackalloc byte[13];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvadeType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PossibleCarCollisionWarning;
    /// <summary>
    /// Function: PossibleCarCollisionWarning
    /// </summary>
    public unsafe virtual void PossibleCarCollisionWarning(BmSDK.Engine.Actor V, float Speed, float DeltaTime, bool bForceDive = default, bool bZap = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PossibleCarCollisionWarning, "BmGame.RBMPawnAI.PossibleCarCollisionWarning");
        byte* paramsPtr = stackalloc byte[25];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDive, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bZap, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetUnarmedHitReactionAnimset;
    /// <summary>
    /// Function: GetUnarmedHitReactionAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetUnarmedHitReactionAnimset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnarmedHitReactionAnimset, "BmGame.RBMPawnAI.GetUnarmedHitReactionAnimset");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentGargoyle;
    /// <summary>
    /// Function: GetCurrentGargoyle
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHidePoint_Mesh GetCurrentGargoyle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentGargoyle, "BmGame.RBMPawnAI.GetCurrentGargoyle");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHidePoint_Mesh>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetGargoyle;
    /// <summary>
    /// Function: SetGargoyle
    /// </summary>
    public unsafe virtual void SetGargoyle(BmSDK.BmGame.RHidePoint_Mesh NewGarg)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGargoyle, "BmGame.RBMPawnAI.SetGargoyle");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGarg, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WakeFromDead;
    /// <summary>
    /// Function: WakeFromDead
    /// </summary>
    public unsafe virtual void WakeFromDead(BmSDK.BmGame.RPawnCharacter NewGetUpMaster = default, BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId NewGetUpMasterAnimID = default, BmSDK.Engine.AnimSet NewGetUpAnimset = default, BmSDK.FName NewGetUpAnimName = default, BmSDK.FName GetUpMovementStance = default, bool bDoAnim = default, bool bAnimImmediate = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WakeFromDead, "BmGame.RBMPawnAI.WakeFromDead");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpMaster, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpMasterAnimID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpAnimset, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpAnimName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetUpMovementStance, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoAnim, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAnimImmediate, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WakeFromDeadWithDefaults;
    /// <summary>
    /// Function: WakeFromDeadWithDefaults
    /// </summary>
    public unsafe virtual void WakeFromDeadWithDefaults()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WakeFromDeadWithDefaults, "BmGame.RBMPawnAI.WakeFromDeadWithDefaults");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GodModeWakeFromDead;
    /// <summary>
    /// Function: GodModeWakeFromDead
    /// </summary>
    public unsafe virtual void GodModeWakeFromDead()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GodModeWakeFromDead, "BmGame.RBMPawnAI.GodModeWakeFromDead");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFinishGettingUpFromRagdoll;
    /// <summary>
    /// Function: OnFinishGettingUpFromRagdoll
    /// </summary>
    public unsafe virtual void OnFinishGettingUpFromRagdoll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFinishGettingUpFromRagdoll, "BmGame.RBMPawnAI.OnFinishGettingUpFromRagdoll");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerSpotted;
    /// <summary>
    /// Function: PlayerSpotted
    /// </summary>
    public unsafe virtual void PlayerSpotted(BmSDK.BmGame.RPawnPlayer SpottedPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerSpotted, "BmGame.RBMPawnAI.PlayerSpotted");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpottedPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBlinded;
    /// <summary>
    /// Function: IsBlinded
    /// </summary>
    public unsafe virtual bool IsBlinded()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBlinded, "BmGame.RBMPawnAI.IsBlinded");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldTriggerPredAlerts;
    /// <summary>
    /// Function: ShouldTriggerPredAlerts
    /// </summary>
    public unsafe virtual bool ShouldTriggerPredAlerts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldTriggerPredAlerts, "BmGame.RBMPawnAI.ShouldTriggerPredAlerts");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HitWall;
    /// <summary>
    /// Function: HitWall
    /// </summary>
    public unsafe override void HitWall(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent WallComp)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitWall, "BmGame.RBMPawnAI.HitWall");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallComp, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCombatIdleStance;
    /// <summary>
    /// Function: SetCombatIdleStance
    /// </summary>
    public unsafe virtual void SetCombatIdleStance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCombatIdleStance, "BmGame.RBMPawnAI.SetCombatIdleStance");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCombatIdleStance;
    /// <summary>
    /// Function: GetCombatIdleStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetCombatIdleStance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatIdleStance, "BmGame.RBMPawnAI.GetCombatIdleStance");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNonFatalTakedownDamage;
    /// <summary>
    /// Function: GetNonFatalTakedownDamage
    /// </summary>
    public unsafe virtual float GetNonFatalTakedownDamage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNonFatalTakedownDamage, "BmGame.RBMPawnAI.GetNonFatalTakedownDamage");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AreTakedownsFatal;
    /// <summary>
    /// Function: AreTakedownsFatal
    /// </summary>
    public unsafe virtual bool AreTakedownsFatal()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreTakedownsFatal, "BmGame.RBMPawnAI.AreTakedownsFatal");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AttemptTeleportToSafeLocation;
    /// <summary>
    /// Function: AttemptTeleportToSafeLocation
    /// </summary>
    public unsafe override void AttemptTeleportToSafeLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttemptTeleportToSafeLocation, "BmGame.RBMPawnAI.AttemptTeleportToSafeLocation");
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

    private static BmSDK.Function __fn_InternalSetPhysWalkingType;
    /// <summary>
    /// Function: InternalSetPhysWalkingType
    /// </summary>
    public unsafe void InternalSetPhysWalkingType(BmSDK.BmGame.RGameRI.EPhysWalkingType NewType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InternalSetPhysWalkingType, "BmGame.RBMPawnAI.InternalSetPhysWalkingType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RevertTempPhysWalking;
    /// <summary>
    /// Function: RevertTempPhysWalking
    /// </summary>
    public unsafe virtual void RevertTempPhysWalking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RevertTempPhysWalking, "BmGame.RBMPawnAI.RevertTempPhysWalking");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTempPhysWalking;
    /// <summary>
    /// Function: SetTempPhysWalking
    /// </summary>
    public unsafe virtual void SetTempPhysWalking(BmSDK.BmGame.RGameRI.EPhysWalkingType NewPhysWalkType, bool bNewDisableRagdollVsNavMeshConstraint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTempPhysWalking, "BmGame.RBMPawnAI.SetTempPhysWalking");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPhysWalkType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewDisableRagdollVsNavMeshConstraint, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPhysWalkingTypeAndRagdoll;
    /// <summary>
    /// Function: SetPhysWalkingTypeAndRagdoll
    /// </summary>
    public unsafe virtual void SetPhysWalkingTypeAndRagdoll(BmSDK.BmGame.RGameRI.EPhysWalkingType NewPhysWalkType, bool bNewDisableRagdollVsNavMeshConstraint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPhysWalkingTypeAndRagdoll, "BmGame.RBMPawnAI.SetPhysWalkingTypeAndRagdoll");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPhysWalkType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewDisableRagdollVsNavMeshConstraint, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPhysWalkingType;
    /// <summary>
    /// Function: SetPhysWalkingType
    /// </summary>
    public unsafe virtual void SetPhysWalkingType(BmSDK.BmGame.RGameRI.EPhysWalkingType NewPhysWalkType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPhysWalkingType, "BmGame.RBMPawnAI.SetPhysWalkingType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPhysWalkType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnModifyHealth;
    /// <summary>
    /// Function: OnModifyHealth
    /// </summary>
    public unsafe override void OnModifyHealth(BmSDK.Engine.SeqAct_ModifyHealth Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnModifyHealth, "BmGame.RBMPawnAI.OnModifyHealth");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ConversationInterrupted;
    /// <summary>
    /// Function: ConversationInterrupted
    /// </summary>
    public unsafe virtual void ConversationInterrupted(BmSDK.BmGame.RBMPawnAI InterruptedSpeaker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConversationInterrupted, "BmGame.RBMPawnAI.ConversationInterrupted");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterruptedSpeaker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TauntNotify;
    /// <summary>
    /// Function: TauntNotify
    /// </summary>
    public unsafe virtual void TauntNotify(BmSDK.BmGame.RGameRI.ETauntNotifyType Type)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TauntNotify, "BmGame.RBMPawnAI.TauntNotify");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MulticastDamagedBy;
    /// <summary>
    /// Function: MulticastDamagedBy
    /// </summary>
    public unsafe virtual void MulticastDamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo Info)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MulticastDamagedBy, "BmGame.RBMPawnAI.MulticastDamagedBy");
        byte* paramsPtr = stackalloc byte[248];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EarlyWarningOfBatarang;
    /// <summary>
    /// Function: EarlyWarningOfBatarang
    /// </summary>
    public unsafe virtual void EarlyWarningOfBatarang()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EarlyWarningOfBatarang, "BmGame.RBMPawnAI.EarlyWarningOfBatarang");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeGlideKicked;
    /// <summary>
    /// Function: CanBeGlideKicked
    /// </summary>
    public unsafe virtual bool CanBeGlideKicked()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeGlideKicked, "BmGame.RBMPawnAI.CanBeGlideKicked");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGlideKickEffectLocation;
    /// <summary>
    /// Function: GetGlideKickEffectLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGlideKickEffectLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlideKickEffectLocation, "BmGame.RBMPawnAI.GetGlideKickEffectLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AdjustGlideKickZ;
    /// <summary>
    /// Function: AdjustGlideKickZ
    /// </summary>
    public unsafe virtual float AdjustGlideKickZ()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustGlideKickZ, "BmGame.RBMPawnAI.AdjustGlideKickZ");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopGlideKickFX;
    /// <summary>
    /// Function: StopGlideKickFX
    /// </summary>
    public unsafe virtual void StopGlideKickFX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopGlideKickFX, "BmGame.RBMPawnAI.StopGlideKickFX");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartGlideKickFX;
    /// <summary>
    /// Function: StartGlideKickFX
    /// </summary>
    public unsafe virtual void StartGlideKickFX(BmSDK.Engine.ParticleSystem OverrideFX, BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGlideKickFX, "BmGame.RBMPawnAI.StartGlideKickFX");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideFX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsDoingSomethingLatent;
    /// <summary>
    /// Function: IsDoingSomethingLatent
    /// </summary>
    public unsafe virtual bool IsDoingSomethingLatent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDoingSomethingLatent, "BmGame.RBMPawnAI.IsDoingSomethingLatent");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFirstNonGlanceAction;
    /// <summary>
    /// Function: GetFirstNonGlanceAction
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIAction GetFirstNonGlanceAction()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFirstNonGlanceAction, "BmGame.RBMPawnAI.GetFirstNonGlanceAction");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIAction>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EndCurrentAction;
    /// <summary>
    /// Function: EndCurrentAction
    /// </summary>
    public unsafe virtual void EndCurrentAction()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndCurrentAction, "BmGame.RBMPawnAI.EndCurrentAction");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddInterrupt;
    /// <summary>
    /// Function: AddInterrupt
    /// </summary>
    public unsafe virtual void AddInterrupt(BmSDK.BmGame.RBMAIAction NewAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddInterrupt, "BmGame.RBMPawnAI.AddInterrupt");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OutputActionQueue;
    /// <summary>
    /// Function: OutputActionQueue
    /// </summary>
    public unsafe virtual void OutputActionQueue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OutputActionQueue, "BmGame.RBMPawnAI.OutputActionQueue");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCurrentAction;
    /// <summary>
    /// Function: GetCurrentAction
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIAction GetCurrentAction()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentAction, "BmGame.RBMPawnAI.GetCurrentAction");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIAction>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ServerTickActionQueue;
    /// <summary>
    /// Function: ServerTickActionQueue
    /// </summary>
    public unsafe virtual void ServerTickActionQueue(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerTickActionQueue, "BmGame.RBMPawnAI.ServerTickActionQueue");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsActionTickAllowed;
    /// <summary>
    /// Function: IsActionTickAllowed
    /// </summary>
    public unsafe virtual bool IsActionTickAllowed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsActionTickAllowed, "BmGame.RBMPawnAI.IsActionTickAllowed");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_KillQueue;
    /// <summary>
    /// Function: KillQueue
    /// </summary>
    public unsafe virtual void KillQueue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillQueue, "BmGame.RBMPawnAI.KillQueue");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReactivateQueue;
    /// <summary>
    /// Function: ReactivateQueue
    /// </summary>
    public unsafe virtual void ReactivateQueue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReactivateQueue, "BmGame.RBMPawnAI.ReactivateQueue");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InterruptQueue;
    /// <summary>
    /// Function: InterruptQueue
    /// </summary>
    public unsafe virtual void InterruptQueue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterruptQueue, "BmGame.RBMPawnAI.InterruptQueue");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddToQueue;
    /// <summary>
    /// Function: AddToQueue
    /// </summary>
    public unsafe virtual void AddToQueue(BmSDK.BmGame.RBMAIAction NewAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddToQueue, "BmGame.RBMPawnAI.AddToQueue");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartNewQueue;
    /// <summary>
    /// Function: StartNewQueue
    /// </summary>
    public unsafe virtual void StartNewQueue(BmSDK.BmGame.RBMAIAction NewAction, BmSDK.BmGame.RBMAIAction.ActionExitLevel Urgency = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartNewQueue, "BmGame.RBMPawnAI.StartNewQueue");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Urgency, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefreshActionAnimInfo;
    /// <summary>
    /// Function: RefreshActionAnimInfo
    /// </summary>
    public unsafe virtual void RefreshActionAnimInfo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshActionAnimInfo, "BmGame.RBMPawnAI.RefreshActionAnimInfo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateAction;
    /// <summary>
    /// Function: ActivateAction
    /// </summary>
    public unsafe virtual void ActivateAction()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateAction, "BmGame.RBMPawnAI.ActivateAction");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldUseAimingStanceDuringChase;
    /// <summary>
    /// Function: ShouldUseAimingStanceDuringChase
    /// </summary>
    public unsafe virtual bool ShouldUseAimingStanceDuringChase()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldUseAimingStanceDuringChase, "BmGame.RBMPawnAI.ShouldUseAimingStanceDuringChase");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResolveMovementMetaPose;
    /// <summary>
    /// Function: ResolveMovementMetaPose
    /// </summary>
    public unsafe virtual BmSDK.FName ResolveMovementMetaPose(BmSDK.FName InPose)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResolveMovementMetaPose, "BmGame.RBMPawnAI.ResolveMovementMetaPose");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPose, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ResolveWeaponMetaPose;
    /// <summary>
    /// Function: ResolveWeaponMetaPose
    /// </summary>
    public unsafe virtual BmSDK.FName ResolveWeaponMetaPose(BmSDK.FName InPose)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResolveWeaponMetaPose, "BmGame.RBMPawnAI.ResolveWeaponMetaPose");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPose, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ActionStanceUpdated;
    /// <summary>
    /// Function: ActionStanceUpdated
    /// </summary>
    public unsafe virtual void ActionStanceUpdated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActionStanceUpdated, "BmGame.RBMPawnAI.ActionStanceUpdated");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFenceJumpAnim;
    /// <summary>
    /// Function: PlayFenceJumpAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayFenceJumpAnim(System.Numerics.Vector3 JumpLocation, float JumpYaw, BmSDK.FName JumpType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFenceJumpAnim, "BmGame.RBMPawnAI.PlayFenceJumpAnim");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpYaw, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetCombatWeaponStance;
    /// <summary>
    /// Function: GetCombatWeaponStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetCombatWeaponStance(bool bWeaponWillBeDropped)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatWeaponStance, "BmGame.RBMPawnAI.GetCombatWeaponStance");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWeaponWillBeDropped, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetStunnedWeaponStance;
    /// <summary>
    /// Function: GetStunnedWeaponStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetStunnedWeaponStance(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStunnedWeaponStance, "BmGame.RBMPawnAI.GetStunnedWeaponStance");
        byte* paramsPtr = stackalloc byte[256];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 248);
    }

    private static BmSDK.Function __fn_GetDisarmStance;
    /// <summary>
    /// Function: GetDisarmStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetDisarmStance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisarmStance, "BmGame.RBMPawnAI.GetDisarmStance");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCombatStance;
    /// <summary>
    /// Function: GetCombatStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetCombatStance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatStance, "BmGame.RBMPawnAI.GetCombatStance");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCameraLookAtPriority;
    /// <summary>
    /// Function: GetCameraLookAtPriority
    /// </summary>
    public unsafe override float GetCameraLookAtPriority()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraLookAtPriority, "BmGame.RBMPawnAI.GetCameraLookAtPriority");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PickupGun;
    /// <summary>
    /// Function: PickupGun
    /// </summary>
    public unsafe virtual void PickupGun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickupGun, "BmGame.RBMPawnAI.PickupGun");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropGun;
    /// <summary>
    /// Function: DropGun
    /// </summary>
    public unsafe virtual void DropGun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropGun, "BmGame.RBMPawnAI.DropGun");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSetGunFiring;
    /// <summary>
    /// Function: OnSetGunFiring
    /// </summary>
    public unsafe virtual void OnSetGunFiring(BmSDK.BmGame.RSeqAct_SetGunFiring GunFireAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSetGunFiring, "BmGame.RBMPawnAI.OnSetGunFiring");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GunFireAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponStopOnBurstEnd;
    /// <summary>
    /// Function: WeaponStopOnBurstEnd
    /// </summary>
    public unsafe virtual void WeaponStopOnBurstEnd()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponStopOnBurstEnd, "BmGame.RBMPawnAI.WeaponStopOnBurstEnd");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponStop;
    /// <summary>
    /// Function: WeaponStop
    /// </summary>
    public unsafe virtual void WeaponStop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponStop, "BmGame.RBMPawnAI.WeaponStop");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponFire;
    /// <summary>
    /// Function: WeaponFire
    /// </summary>
    public unsafe virtual void WeaponFire(bool bBurst = default, bool bFireOnce = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponFire, "BmGame.RBMPawnAI.WeaponFire");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBurst, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFireOnce, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Anim_WeaponFirePartyCar;
    /// <summary>
    /// Function: Anim_WeaponFirePartyCar
    /// </summary>
    public unsafe virtual void Anim_WeaponFirePartyCar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Anim_WeaponFirePartyCar, "BmGame.RBMPawnAI.Anim_WeaponFirePartyCar");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Anim_WeaponStop;
    /// <summary>
    /// Function: Anim_WeaponStop
    /// </summary>
    public unsafe virtual void Anim_WeaponStop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Anim_WeaponStop, "BmGame.RBMPawnAI.Anim_WeaponStop");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Anim_WeaponFireFullAuto;
    /// <summary>
    /// Function: Anim_WeaponFireFullAuto
    /// </summary>
    public unsafe virtual void Anim_WeaponFireFullAuto()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Anim_WeaponFireFullAuto, "BmGame.RBMPawnAI.Anim_WeaponFireFullAuto");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Anim_WeaponFireOneShot;
    /// <summary>
    /// Function: Anim_WeaponFireOneShot
    /// </summary>
    public unsafe virtual void Anim_WeaponFireOneShot()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Anim_WeaponFireOneShot, "BmGame.RBMPawnAI.Anim_WeaponFireOneShot");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Anim_WeaponFire;
    /// <summary>
    /// Function: Anim_WeaponFire
    /// </summary>
    public unsafe virtual void Anim_WeaponFire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Anim_WeaponFire, "BmGame.RBMPawnAI.Anim_WeaponFire");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopFire;
    /// <summary>
    /// Function: StopFire
    /// </summary>
    public unsafe override void StopFire(byte FireModeNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFire, "BmGame.RBMPawnAI.StopFire");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartFire;
    /// <summary>
    /// Function: StartFire
    /// </summary>
    public unsafe override void StartFire(byte FireModeNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFire, "BmGame.RBMPawnAI.StartFire");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoFiringRecoil;
    /// <summary>
    /// Function: DoFiringRecoil
    /// </summary>
    public unsafe virtual void DoFiringRecoil(BmSDK.FName RecoilAnimName, BmSDK.Engine.AnimSet Set)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoFiringRecoil, "BmGame.RBMPawnAI.DoFiringRecoil");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RecoilAnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReloadGun;
    /// <summary>
    /// Function: ReloadGun
    /// </summary>
    public unsafe virtual void ReloadGun(bool bMagicReload = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReloadGun, "BmGame.RBMPawnAI.ReloadGun");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMagicReload, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Anim_ReloadGun;
    /// <summary>
    /// Function: Anim_ReloadGun
    /// </summary>
    public unsafe virtual void Anim_ReloadGun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Anim_ReloadGun, "BmGame.RBMPawnAI.Anim_ReloadGun");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickGunFire;
    /// <summary>
    /// Function: TickGunFire
    /// </summary>
    public unsafe virtual void TickGunFire(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickGunFire, "BmGame.RBMPawnAI.TickGunFire");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldMiss;
    /// <summary>
    /// Function: ShouldMiss
    /// </summary>
    public unsafe virtual bool ShouldMiss(float TestDistSq, BmSDK.Engine.Actor TrackedTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldMiss, "BmGame.RBMPawnAI.ShouldMiss");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestDistSq, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TrackedTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetAIThoughts;
    /// <summary>
    /// Function: GetAIThoughts
    /// </summary>
    public unsafe override void GetAIThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAIThoughts, "BmGame.RBMPawnAI.GetAIThoughts");
        byte* paramsPtr = stackalloc byte[47];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_DumpCurrentThoughtsToLog;
    /// <summary>
    /// Function: DumpCurrentThoughtsToLog
    /// </summary>
    public unsafe virtual void DumpCurrentThoughtsToLog()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpCurrentThoughtsToLog, "BmGame.RBMPawnAI.DumpCurrentThoughtsToLog");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveRoadObstacle;
    /// <summary>
    /// Function: RemoveRoadObstacle
    /// </summary>
    public unsafe virtual void RemoveRoadObstacle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveRoadObstacle, "BmGame.RBMPawnAI.RemoveRoadObstacle");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateRoadObstacleBounds;
    /// <summary>
    /// Function: UpdateRoadObstacleBounds
    /// </summary>
    public unsafe virtual void UpdateRoadObstacleBounds()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRoadObstacleBounds, "BmGame.RBMPawnAI.UpdateRoadObstacleBounds");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateRoadObstacle;
    /// <summary>
    /// Function: CreateRoadObstacle
    /// </summary>
    public unsafe virtual void CreateRoadObstacle(BmSDK.BmGame.RRoadNetwork RoadNetwork, int FilterBits)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateRoadObstacle, "BmGame.RBMPawnAI.CreateRoadObstacle");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RoadNetwork, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FilterBits, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNavHandle_PathBetweenChasePoints;
    /// <summary>
    /// Function: GetNavHandle_PathBetweenChasePoints
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RNavigationHandle GetNavHandle_PathBetweenChasePoints(BmSDK.BmGame.RChasePoint StartPoint, BmSDK.BmGame.RChasePoint EndPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNavHandle_PathBetweenChasePoints, "BmGame.RBMPawnAI.GetNavHandle_PathBetweenChasePoints");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPoint, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RNavigationHandle>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_RemoveNavHandles;
    /// <summary>
    /// Function: RemoveNavHandles
    /// </summary>
    public unsafe virtual void RemoveNavHandles()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveNavHandles, "BmGame.RBMPawnAI.RemoveNavHandles");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopMoveToAtCurrentLocation;
    /// <summary>
    /// Function: StopMoveToAtCurrentLocation
    /// </summary>
    public unsafe virtual void StopMoveToAtCurrentLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopMoveToAtCurrentLocation, "BmGame.RBMPawnAI.StopMoveToAtCurrentLocation");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FollowNavHandle;
    /// <summary>
    /// Function: FollowNavHandle
    /// </summary>
    public unsafe virtual void FollowNavHandle(BmSDK.BmGame.RNavigationHandle NavHandle, bool bCanFallBackToMoveInDirection = default, bool bMoveInDirection = default, bool bStopMoveTo = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FollowNavHandle, "BmGame.RBMPawnAI.FollowNavHandle");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanFallBackToMoveInDirection, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMoveInDirection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStopMoveTo, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNavHandle_PathToActor;
    /// <summary>
    /// Function: GetNavHandle_PathToActor
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RNavigationHandle GetNavHandle_PathToActor(BmSDK.Engine.Actor destActor, BmSDK.FName ClaimName, int Priority = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNavHandle_PathToActor, "BmGame.RBMPawnAI.GetNavHandle_PathToActor");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(destActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClaimName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RNavigationHandle>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetNavHandle_PathToPoint;
    /// <summary>
    /// Function: GetNavHandle_PathToPoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RNavigationHandle GetNavHandle_PathToPoint(System.Numerics.Vector3 DestPos, BmSDK.FName ClaimName, int Priority = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNavHandle_PathToPoint, "BmGame.RBMPawnAI.GetNavHandle_PathToPoint");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClaimName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RNavigationHandle>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetNavHandle;
    /// <summary>
    /// Function: GetNavHandle
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RNavigationHandle GetNavHandle(BmSDK.FName ClaimName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNavHandle, "BmGame.RBMPawnAI.GetNavHandle");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClaimName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RNavigationHandle>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CreateStandPoseConfig;
    /// <summary>
    /// Function: CreateStandPoseConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPoseConfig CreateStandPoseConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet TurnAnimSet)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateStandPoseConfig, "BmGame.RBMPawnAI.CreateStandPoseConfig");
        byte* paramsPtr = stackalloc byte[452];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnAnimSet, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CreateBasicWeaponConfig;
    /// <summary>
    /// Function: CreateBasicWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateBasicWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets, BmSDK.Engine.AnimSet TurnAnimSet = default, bool bForWeap = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateBasicWeaponConfig, "BmGame.RBMPawnAI.CreateBasicWeaponConfig");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSets, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnAnimSet, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForWeap, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetEntryAnim;
    /// <summary>
    /// Function: GetEntryAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetEntryAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEntryAnim, "BmGame.RBMPawnAI.GetEntryAnim");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEntryAnimSet;
    /// <summary>
    /// Function: GetEntryAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetEntryAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEntryAnimSet, "BmGame.RBMPawnAI.GetEntryAnimSet");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemovePropSkeletal;
    /// <summary>
    /// Function: RemovePropSkeletal
    /// </summary>
    public unsafe override void RemovePropSkeletal(System.Numerics.Vector3 PropForce, bool PawnDied = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemovePropSkeletal, "BmGame.RBMPawnAI.RemovePropSkeletal");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropForce, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnDied, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanShovePawns;
    /// <summary>
    /// Function: CanShovePawns
    /// </summary>
    public unsafe virtual bool CanShovePawns()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanShovePawns, "BmGame.RBMPawnAI.CanShovePawns");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanHitLaserGrid;
    /// <summary>
    /// Function: CanHitLaserGrid
    /// </summary>
    public unsafe override bool CanHitLaserGrid()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanHitLaserGrid, "BmGame.RBMPawnAI.CanHitLaserGrid");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanRepel;
    /// <summary>
    /// Function: CanRepel
    /// </summary>
    public unsafe override bool CanRepel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanRepel, "BmGame.RBMPawnAI.CanRepel");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ModifyBatarangFlightPath;
    /// <summary>
    /// Function: ModifyBatarangFlightPath
    /// </summary>
    public unsafe virtual float ModifyBatarangFlightPath()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyBatarangFlightPath, "BmGame.RBMPawnAI.ModifyBatarangFlightPath");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlaySound_ImpactAI;
    /// <summary>
    /// Function: PlaySound_ImpactAI
    /// </summary>
    public unsafe override void PlaySound_ImpactAI(BmSDK.Engine.Actor playOn, bool bIsStrike, bool bFinishingBlow, bool bIsHeadImpact, bool bIsPunch, bool bIsStrong, bool bIsBlocked, bool bCanEmote = default, bool bIsQuick = default, bool bPlayerAttacked = default, bool bForceEmote = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound_ImpactAI, "BmGame.RBMPawnAI.PlaySound_ImpactAI");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(playOn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrike, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinishingBlow, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsHeadImpact, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPunch, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrong, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBlocked, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanEmote, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsQuick, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayerAttacked, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceEmote, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RigidBodyCollision;
    /// <summary>
    /// Function: RigidBodyCollision
    /// </summary>
    public unsafe override void RigidBodyCollision(BmSDK.Engine.PrimitiveComponent HitComponent, BmSDK.Engine.PrimitiveComponent OtherComponent, out BmSDK.Engine.Actor.FCollisionImpactData RigidCollisionData, int ContactIndex, float Speed, int Index0, int Index1)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RigidBodyCollision, "BmGame.RBMPawnAI.RigidBodyCollision");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComponent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactIndex, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index0, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index1, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RigidCollisionData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FCollisionImpactData>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_FadeOutAfterDeath;
    /// <summary>
    /// Function: FadeOutAfterDeath
    /// </summary>
    public unsafe virtual void FadeOutAfterDeath(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeOutAfterDeath, "BmGame.RBMPawnAI.FadeOutAfterDeath");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatMoveFinished;
    /// <summary>
    /// Function: CombatMoveFinished
    /// </summary>
    public unsafe override void CombatMoveFinished(BmSDK.BmGame.RCombatMove OldMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatMoveFinished, "BmGame.RBMPawnAI.CombatMoveFinished");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatMoveInitialised;
    /// <summary>
    /// Function: CombatMoveInitialised
    /// </summary>
    public unsafe override void CombatMoveInitialised(BmSDK.BmGame.RCombatMove NewMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatMoveInitialised, "BmGame.RBMPawnAI.CombatMoveInitialised");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetJammedAttackMoveClass;
    /// <summary>
    /// Function: GetJammedAttackMoveClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetJammedAttackMoveClass()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJammedAttackMoveClass, "BmGame.RBMPawnAI.GetJammedAttackMoveClass");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAttackMoveClass;
    /// <summary>
    /// Function: GetAttackMoveClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetAttackMoveClass()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAttackMoveClass, "BmGame.RBMPawnAI.GetAttackMoveClass");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CurrentBehaviourChanged;
    /// <summary>
    /// Function: CurrentBehaviourChanged
    /// </summary>
    public unsafe virtual void CurrentBehaviourChanged(BmSDK.BmGame.RBMBehaviour NewBehaviour)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CurrentBehaviourChanged, "BmGame.RBMPawnAI.CurrentBehaviourChanged");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBehaviour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishedGetUp;
    /// <summary>
    /// Function: FinishedGetUp
    /// </summary>
    public unsafe override void FinishedGetUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedGetUp, "BmGame.RBMPawnAI.FinishedGetUp");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowWeaponRight;
    /// <summary>
    /// Function: ShowWeaponRight
    /// </summary>
    public unsafe virtual void ShowWeaponRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowWeaponRight, "BmGame.RBMPawnAI.ShowWeaponRight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowWeaponLeft;
    /// <summary>
    /// Function: ShowWeaponLeft
    /// </summary>
    public unsafe virtual void ShowWeaponLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowWeaponLeft, "BmGame.RBMPawnAI.ShowWeaponLeft");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowWeapon;
    /// <summary>
    /// Function: ShowWeapon
    /// </summary>
    public unsafe virtual void ShowWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowWeapon, "BmGame.RBMPawnAI.ShowWeapon");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideWeapon;
    /// <summary>
    /// Function: HideWeapon
    /// </summary>
    public unsafe virtual void HideWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideWeapon, "BmGame.RBMPawnAI.HideWeapon");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Drop;
    /// <summary>
    /// Function: Drop
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject Drop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Drop, "BmGame.RBMPawnAI.Drop");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ThrowWeaponVelocity;
    /// <summary>
    /// Function: ThrowWeaponVelocity
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject ThrowWeaponVelocity(System.Numerics.Vector3 NewVel)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowWeaponVelocity, "BmGame.RBMPawnAI.ThrowWeaponVelocity");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ThrowWeapon;
    /// <summary>
    /// Function: ThrowWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject ThrowWeapon(System.Numerics.Vector3 TargetPos = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowWeapon, "BmGame.RBMPawnAI.ThrowWeapon");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ChangeXrayColour;
    /// <summary>
    /// Function: ChangeXrayColour
    /// </summary>
    public unsafe override void ChangeXrayColour(bool bBlue, bool bForced = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeXrayColour, "BmGame.RBMPawnAI.ChangeXrayColour");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBlue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForced, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleWeaponUnJammed;
    /// <summary>
    /// Function: HandleWeaponUnJammed
    /// </summary>
    public unsafe virtual void HandleWeaponUnJammed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleWeaponUnJammed, "BmGame.RBMPawnAI.HandleWeaponUnJammed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleWeaponJammed;
    /// <summary>
    /// Function: HandleWeaponJammed
    /// </summary>
    public unsafe virtual void HandleWeaponJammed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleWeaponJammed, "BmGame.RBMPawnAI.HandleWeaponJammed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandlePredThugDisarm;
    /// <summary>
    /// Function: HandlePredThugDisarm
    /// </summary>
    public unsafe virtual void HandlePredThugDisarm(bool bNoImmiediateReaction = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandlePredThugDisarm, "BmGame.RBMPawnAI.HandlePredThugDisarm");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoImmiediateReaction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleThugDisarmGunFX;
    /// <summary>
    /// Function: HandleThugDisarmGunFX
    /// </summary>
    public unsafe virtual void HandleThugDisarmGunFX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleThugDisarmGunFX, "BmGame.RBMPawnAI.HandleThugDisarmGunFX");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponSwitchCallback;
    /// <summary>
    /// Function: WeaponSwitchCallback
    /// </summary>
    public unsafe override void WeaponSwitchCallback(BmSDK.Engine.Inventory NewWeapon, BmSDK.Engine.Inventory PreviousWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponSwitchCallback, "BmGame.RBMPawnAI.WeaponSwitchCallback");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousWeapon, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NewWeaponAttached;
    /// <summary>
    /// Function: NewWeaponAttached
    /// </summary>
    public unsafe virtual void NewWeaponAttached(BmSDK.BmGame.RBMWeapon NewWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NewWeaponAttached, "BmGame.RBMPawnAI.NewWeaponAttached");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponChanged;
    /// <summary>
    /// Function: WeaponChanged
    /// </summary>
    public unsafe virtual void WeaponChanged(BmSDK.BmGame.RBMWeapon NewWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponChanged, "BmGame.RBMPawnAI.WeaponChanged");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DodgedMagneticBlastDisarm;
    /// <summary>
    /// Function: DodgedMagneticBlastDisarm
    /// </summary>
    public unsafe virtual void DodgedMagneticBlastDisarm()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DodgedMagneticBlastDisarm, "BmGame.RBMPawnAI.DodgedMagneticBlastDisarm");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryDisarmByMagneticBlast;
    /// <summary>
    /// Function: TryDisarmByMagneticBlast
    /// </summary>
    public unsafe virtual void TryDisarmByMagneticBlast(System.Numerics.Vector3 Impulse, BmSDK.BmGame.RPawnCombat Attacker, BmSDK.BmGame.RMagneticBlastReceiver Receiver, bool bSuccessfulDisarm)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryDisarmByMagneticBlast, "BmGame.RBMPawnAI.TryDisarmByMagneticBlast");
        byte* paramsPtr = stackalloc byte[284];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Impulse, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Receiver, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccessfulDisarm, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisappearDisarm;
    /// <summary>
    /// Function: DisappearDisarm
    /// </summary>
    public unsafe virtual void DisappearDisarm()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisappearDisarm, "BmGame.RBMPawnAI.DisappearDisarm");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceDisarm;
    /// <summary>
    /// Function: ForceDisarm
    /// </summary>
    public unsafe virtual void ForceDisarm()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceDisarm, "BmGame.RBMPawnAI.ForceDisarm");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropWeapon;
    /// <summary>
    /// Function: DropWeapon
    /// </summary>
    public unsafe virtual void DropWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropWeapon, "BmGame.RBMPawnAI.DropWeapon");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Disarm;
    /// <summary>
    /// Function: Disarm
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject Disarm(BmSDK.Class DisarmDamageType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Disarm, "BmGame.RBMPawnAI.Disarm");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisarmDamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SwitchWeapon;
    /// <summary>
    /// Function: SwitchWeapon
    /// </summary>
    public unsafe virtual void SwitchWeapon(BmSDK.Engine.Inventory NewWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchWeapon, "BmGame.RBMPawnAI.SwitchWeapon");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerBumped;
    /// <summary>
    /// Function: PlayerBumped
    /// </summary>
    public unsafe virtual void PlayerBumped(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerBumped, "BmGame.RBMPawnAI.PlayerBumped");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Bump;
    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe override void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Bump, "BmGame.RBMPawnAI.Bump");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckDodgeProjectile;
    /// <summary>
    /// Function: CheckDodgeProjectile
    /// </summary>
    public unsafe virtual bool CheckDodgeProjectile(BmSDK.BmGame.RPawn Thrower, BmSDK.FName TargetBone, System.Numerics.Vector3 ProjPos, int BatarangID, bool bForceDodge = default, bool bSteerableProj = default, bool bDodgeAwayFromPosition = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckDodgeProjectile, "BmGame.RBMPawnAI.CheckDodgeProjectile");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thrower, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBone, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjPos, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangID, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDodge, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSteerableProj, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDodgeAwayFromPosition, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_CollisionWith;
    /// <summary>
    /// Function: CollisionWith
    /// </summary>
    public unsafe override void CollisionWith(BmSDK.BmGame.RPawnCombat OtherPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CollisionWith, "BmGame.RBMPawnAI.CollisionWith");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IdleConfigNotify;
    /// <summary>
    /// Function: IdleConfigNotify
    /// </summary>
    public unsafe virtual void IdleConfigNotify(BmSDK.BmGame.RAnimNotify_IdleConfigOutput Notify)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IdleConfigNotify, "BmGame.RBMPawnAI.IdleConfigNotify");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Notify, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCombatBehaviourClass;
    /// <summary>
    /// Function: GetCombatBehaviourClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetCombatBehaviourClass()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatBehaviourClass, "BmGame.RBMPawnAI.GetCombatBehaviourClass");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveWeaponFromInventory;
    /// <summary>
    /// Function: RemoveWeaponFromInventory
    /// </summary>
    public unsafe virtual void RemoveWeaponFromInventory(BmSDK.BmGame.RBMWeapon WeaponToRemove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveWeaponFromInventory, "BmGame.RBMPawnAI.RemoveWeaponFromInventory");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponToRemove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasWeapon;
    /// <summary>
    /// Function: HasWeapon
    /// </summary>
    public unsafe virtual bool HasWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasWeapon, "BmGame.RBMPawnAI.HasWeapon");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnWeapon;
    /// <summary>
    /// Function: SpawnWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMWeapon SpawnWeapon(BmSDK.Class WeaponClass, bool bForce = default, bool bNoPoseChange = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnWeapon, "BmGame.RBMPawnAI.SpawnWeapon");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoPoseChange, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMWeapon>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CreateWeapon;
    /// <summary>
    /// Function: CreateWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMWeapon CreateWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeapon, "BmGame.RBMPawnAI.CreateWeapon");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMWeapon>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetupCustomPhysics;
    /// <summary>
    /// Function: SetupCustomPhysics
    /// </summary>
    public unsafe override void SetupCustomPhysics()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupCustomPhysics, "BmGame.RBMPawnAI.SetupCustomPhysics");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInRangeHighlightAlpha;
    /// <summary>
    /// Function: SetInRangeHighlightAlpha
    /// </summary>
    public unsafe virtual void SetInRangeHighlightAlpha(float Alpha)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInRangeHighlightAlpha, "BmGame.RBMPawnAI.SetInRangeHighlightAlpha");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateMultiplayerAura;
    /// <summary>
    /// Function: ActivateMultiplayerAura
    /// </summary>
    public unsafe override void ActivateMultiplayerAura(BmSDK.Engine.MaterialInterface AuraMat, BmSDK.Engine.Scene.ESceneDepthPriorityGroup DPG = default, BmSDK.Engine.MaterialInterface XrayAuraMat = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateMultiplayerAura, "BmGame.RBMPawnAI.ActivateMultiplayerAura");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuraMat, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DPG, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XrayAuraMat, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPropsInXray;
    /// <summary>
    /// Function: SetPropsInXray
    /// </summary>
    public unsafe override void SetPropsInXray(bool bActivate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPropsInXray, "BmGame.RBMPawnAI.SetPropsInXray");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPropsInThermal;
    /// <summary>
    /// Function: SetPropsInThermal
    /// </summary>
    public unsafe override void SetPropsInThermal(bool bActivate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPropsInThermal, "BmGame.RBMPawnAI.SetPropsInThermal");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIndividualStaticPropInVM;
    /// <summary>
    /// Function: SetIndividualStaticPropInVM
    /// </summary>
    public unsafe virtual void SetIndividualStaticPropInVM(bool bActivate, bool bThermal, int MeshToChangeIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIndividualStaticPropInVM, "BmGame.RBMPawnAI.SetIndividualStaticPropInVM");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThermal, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshToChangeIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIndividualSkeletalPropInVM;
    /// <summary>
    /// Function: SetIndividualSkeletalPropInVM
    /// </summary>
    public unsafe virtual void SetIndividualSkeletalPropInVM(bool bActivate, bool bThermal, int MeshToChangeIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIndividualSkeletalPropInVM, "BmGame.RBMPawnAI.SetIndividualSkeletalPropInVM");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThermal, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshToChangeIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanAttachPropWithFlag;
    /// <summary>
    /// Function: CanAttachPropWithFlag
    /// </summary>
    public unsafe virtual bool CanAttachPropWithFlag(BmSDK.FString FlagString)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanAttachPropWithFlag, "BmGame.RBMPawnAI.CanAttachPropWithFlag");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_AttachSkeletalProps;
    /// <summary>
    /// Function: AttachSkeletalProps
    /// </summary>
    public unsafe virtual void AttachSkeletalProps()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachSkeletalProps, "BmGame.RBMPawnAI.AttachSkeletalProps");
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

    private static BmSDK.Function __fn_UpgradeExtraMeshesWithRFlaps;
    /// <summary>
    /// Function: UpgradeExtraMeshesWithRFlaps
    /// </summary>
    public unsafe virtual void UpgradeExtraMeshesWithRFlaps(BmSDK.Engine.SkeletalMeshComponent MainMesh, BmSDK.Engine.SkeletalMeshComponent SubMesh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpgradeExtraMeshesWithRFlaps, "BmGame.RBMPawnAI.UpgradeExtraMeshesWithRFlaps");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MainMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubMesh, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetStaticPropIndexByMesh;
    /// <summary>
    /// Function: GetStaticPropIndexByMesh
    /// </summary>
    public unsafe virtual int GetStaticPropIndexByMesh(BmSDK.Engine.StaticMesh SM)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStaticPropIndexByMesh, "BmGame.RBMPawnAI.GetStaticPropIndexByMesh");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SM, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_OverrideStaticPropMaterial;
    /// <summary>
    /// Function: OverrideStaticPropMaterial
    /// </summary>
    public unsafe virtual void OverrideStaticPropMaterial(int Index, BmSDK.Engine.Material Mat)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideStaticPropMaterial, "BmGame.RBMPawnAI.OverrideStaticPropMaterial");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mat, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetStaticPropHidden;
    /// <summary>
    /// Function: SetStaticPropHidden
    /// </summary>
    public unsafe virtual void SetStaticPropHidden(int Index, bool bHide)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStaticPropHidden, "BmGame.RBMPawnAI.SetStaticPropHidden");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHide, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveStaticProp;
    /// <summary>
    /// Function: RemoveStaticProp
    /// </summary>
    public unsafe virtual void RemoveStaticProp(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveStaticProp, "BmGame.RBMPawnAI.RemoveStaticProp");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitPropStatic;
    /// <summary>
    /// Function: InitPropStatic
    /// </summary>
    public unsafe virtual void InitPropStatic(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitPropStatic, "BmGame.RBMPawnAI.InitPropStatic");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachStaticProps;
    /// <summary>
    /// Function: AttachStaticProps
    /// </summary>
    public unsafe virtual void AttachStaticProps()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachStaticProps, "BmGame.RBMPawnAI.AttachStaticProps");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachProps;
    /// <summary>
    /// Function: AttachProps
    /// </summary>
    public unsafe virtual void AttachProps()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachProps, "BmGame.RBMPawnAI.AttachProps");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPawnProps;
    /// <summary>
    /// Function: AddPawnProps
    /// </summary>
    public unsafe virtual void AddPawnProps()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPawnProps, "BmGame.RBMPawnAI.AddPawnProps");
        byte* paramsPtr = stackalloc byte[356];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShrinkAttachmentArrays;
    /// <summary>
    /// Function: ShrinkAttachmentArrays
    /// </summary>
    public unsafe virtual void ShrinkAttachmentArrays()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShrinkAttachmentArrays, "BmGame.RBMPawnAI.ShrinkAttachmentArrays");
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

    private static BmSDK.Function __fn_PostLoadXrayCheck;
    /// <summary>
    /// Function: PostLoadXrayCheck
    /// </summary>
    public unsafe override void PostLoadXrayCheck()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostLoadXrayCheck, "BmGame.RBMPawnAI.PostLoadXrayCheck");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleNetPosCorrectionClient;
    /// <summary>
    /// Function: HandleNetPosCorrectionClient
    /// </summary>
    public unsafe virtual bool HandleNetPosCorrectionClient(System.Numerics.Vector3 CorrectPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleNetPosCorrectionClient, "BmGame.RBMPawnAI.HandleNetPosCorrectionClient");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CorrectPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SupressNetPosValidationServer;
    /// <summary>
    /// Function: SupressNetPosValidationServer
    /// </summary>
    public unsafe virtual bool SupressNetPosValidationServer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SupressNetPosValidationServer, "BmGame.RBMPawnAI.SupressNetPosValidationServer");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ReplicatedEvent;
    /// <summary>
    /// Function: ReplicatedEvent
    /// </summary>
    public unsafe override void ReplicatedEvent(BmSDK.FName VarName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicatedEvent, "BmGame.RBMPawnAI.ReplicatedEvent");
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmGame.RBMPawnAI.Died");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RBMPawnAI.Destroyed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RBMPawnAI.PreStreamOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyPawn;
    /// <summary>
    /// Function: DestroyPawn
    /// </summary>
    public unsafe virtual void DestroyPawn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyPawn, "BmGame.RBMPawnAI.DestroyPawn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMainMeshesForegroundSettings;
    /// <summary>
    /// Function: SetMainMeshesForegroundSettings
    /// </summary>
    public unsafe override void SetMainMeshesForegroundSettings(bool bPutInForeground)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMainMeshesForegroundSettings, "BmGame.RBMPawnAI.SetMainMeshesForegroundSettings");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPutInForeground, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInXrayMode;
    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe override void SetInXrayMode(bool show, bool bForceOff)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInXrayMode, "BmGame.RBMPawnAI.SetInXrayMode");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFleeRunPose;
    /// <summary>
    /// Function: SetFleeRunPose
    /// </summary>
    public unsafe virtual void SetFleeRunPose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFleeRunPose, "BmGame.RBMPawnAI.SetFleeRunPose");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetExtendedSightRange;
    /// <summary>
    /// Function: SetExtendedSightRange
    /// </summary>
    public unsafe virtual void SetExtendedSightRange(float NewRange)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetExtendedSightRange, "BmGame.RBMPawnAI.SetExtendedSightRange");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRange, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFocusedVisionRadius;
    /// <summary>
    /// Function: SetFocusedVisionRadius
    /// </summary>
    public unsafe virtual void SetFocusedVisionRadius(float NewRadius)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFocusedVisionRadius, "BmGame.RBMPawnAI.SetFocusedVisionRadius");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRadius, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFocusedSightRange;
    /// <summary>
    /// Function: SetFocusedSightRange
    /// </summary>
    public unsafe virtual void SetFocusedSightRange(float NewRange)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFocusedSightRange, "BmGame.RBMPawnAI.SetFocusedSightRange");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRange, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPeripheralSightRange;
    /// <summary>
    /// Function: SetPeripheralSightRange
    /// </summary>
    public unsafe virtual void SetPeripheralSightRange(float NewRange)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPeripheralSightRange, "BmGame.RBMPawnAI.SetPeripheralSightRange");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRange, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCheckSightRange;
    /// <summary>
    /// Function: GetCheckSightRange
    /// </summary>
    public unsafe virtual float GetCheckSightRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCheckSightRange, "BmGame.RBMPawnAI.GetCheckSightRange");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanMoveToPoint;
    /// <summary>
    /// Function: CanMoveToPoint
    /// </summary>
    public unsafe virtual bool CanMoveToPoint(System.Numerics.Vector3 MoveToPoint, out float HitTime, out BmSDK.Engine.Actor HitActor, bool bSlopeCheck = default, System.Numerics.Vector3 TestLocation = default, bool bForceExtentCheck = default, bool bDoGroundCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanMoveToPoint, "BmGame.RBMPawnAI.CanMoveToPoint");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveToPoint, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitTime, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitActor);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitActor, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSlopeCheck, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceExtentCheck, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoGroundCheck, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        HitActor = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_CreateLadderWeaponConfig;
    /// <summary>
    /// Function: CreateLadderWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateLadderWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2 = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateLadderWeaponConfig, "BmGame.RBMPawnAI.CreateLadderWeaponConfig");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CreateWeaponConfigUnarmed;
    /// <summary>
    /// Function: CreateWeaponConfigUnarmed
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateWeaponConfigUnarmed(BmSDK.GameObject NewOwner)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeaponConfigUnarmed, "BmGame.RBMPawnAI.CreateWeaponConfigUnarmed");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AddOverrideAnimsetToWeaponConfig;
    /// <summary>
    /// Function: AddOverrideAnimsetToWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig AddOverrideAnimsetToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig, BmSDK.Engine.AnimSet NewAnimSet)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddOverrideAnimsetToWeaponConfig, "BmGame.RBMPawnAI.AddOverrideAnimsetToWeaponConfig");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAnimSet, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_DeregisterWeaponConfig;
    /// <summary>
    /// Function: DeregisterWeaponConfig
    /// </summary>
    public unsafe virtual void DeregisterWeaponConfig()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeregisterWeaponConfig, "BmGame.RBMPawnAI.DeregisterWeaponConfig");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateWeaponConfig;
    /// <summary>
    /// Function: CreateWeaponConfig
    /// </summary>
    public unsafe virtual void CreateWeaponConfig(BmSDK.Engine.AnimSet OverrideAnimset = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeaponConfig, "BmGame.RBMPawnAI.CreateWeaponConfig");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideAnimset, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOverrideAnimset;
    /// <summary>
    /// Function: SetOverrideAnimset
    /// </summary>
    public unsafe virtual void SetOverrideAnimset(BmSDK.BmGame.RBMCombatManager.EWeaponConfigType NewConfigType, BmSDK.Engine.AnimSet NewOverrideAnimset, bool bOverrideHitReactionAnimset)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOverrideAnimset, "BmGame.RBMPawnAI.SetOverrideAnimset");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewConfigType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOverrideAnimset, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideHitReactionAnimset, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDyeSprayLevel;
    /// <summary>
    /// Function: SetDyeSprayLevel
    /// </summary>
    public unsafe virtual void SetDyeSprayLevel(float dyeProportion)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDyeSprayLevel, "BmGame.RBMPawnAI.SetDyeSprayLevel");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dyeProportion, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncreaseBatarangDamage;
    /// <summary>
    /// Function: IncreaseBatarangDamage
    /// </summary>
    public unsafe virtual void IncreaseBatarangDamage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseBatarangDamage, "BmGame.RBMPawnAI.IncreaseBatarangDamage");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncreaseFacialDamage;
    /// <summary>
    /// Function: IncreaseFacialDamage
    /// </summary>
    public unsafe virtual void IncreaseFacialDamage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseFacialDamage, "BmGame.RBMPawnAI.IncreaseFacialDamage");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncreaseFacialDirtAmount;
    /// <summary>
    /// Function: IncreaseFacialDirtAmount
    /// </summary>
    public unsafe virtual void IncreaseFacialDirtAmount()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseFacialDirtAmount, "BmGame.RBMPawnAI.IncreaseFacialDirtAmount");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncreaseDirtAmount;
    /// <summary>
    /// Function: IncreaseDirtAmount
    /// </summary>
    public unsafe virtual void IncreaseDirtAmount(BmSDK.BmGame.RBMPawnAI.EDirtLocation DirtLocation, BmSDK.BmGame.RBMPawnAI.EDirtType DirtType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseDirtAmount, "BmGame.RBMPawnAI.IncreaseDirtAmount");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DirtLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DirtType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetExplosionVisualDamage;
    /// <summary>
    /// Function: SetExplosionVisualDamage
    /// </summary>
    public unsafe virtual void SetExplosionVisualDamage(float NewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetExplosionVisualDamage, "BmGame.RBMPawnAI.SetExplosionVisualDamage");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearMaterialParameters;
    /// <summary>
    /// Function: ClearMaterialParameters
    /// </summary>
    public unsafe virtual void ClearMaterialParameters()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearMaterialParameters, "BmGame.RBMPawnAI.ClearMaterialParameters");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMeshMaterialParameter;
    /// <summary>
    /// Function: SetMeshMaterialParameter
    /// </summary>
    public unsafe virtual void SetMeshMaterialParameter(BmSDK.FName ParameterName, float ParameterValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMeshMaterialParameter, "BmGame.RBMPawnAI.SetMeshMaterialParameter");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterValue, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRagdollVsNavMesh;
    /// <summary>
    /// Function: SetRagdollVsNavMesh
    /// </summary>
    public unsafe virtual void SetRagdollVsNavMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRagdollVsNavMesh, "BmGame.RBMPawnAI.SetRagdollVsNavMesh");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBossAutomaticTutorialText;
    /// <summary>
    /// Function: GetBossAutomaticTutorialText
    /// </summary>
    public unsafe virtual bool GetBossAutomaticTutorialText(BmSDK.BmGame.RPlayerController RPC, out BmSDK.BmGame.RPersistentData.ETutorialType BestTutorial, out BmSDK.FString BestTutorialPrompt, out BmSDK.BmGame.RHUDPrompt.EControlIcon BestControlIcon, out int bShowTutorial)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBossAutomaticTutorialText, "BmGame.RBMPawnAI.GetBossAutomaticTutorialText");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestTutorial);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestTutorial, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestControlIcon);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestControlIcon, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bShowTutorial);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowTutorial, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BestTutorial = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPersistentData.ETutorialType>(paramsPtr + 8);
        BestTutorialPrompt = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
        BestControlIcon = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 28);
        bShowTutorial = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmGame.RBMPawnAI.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckPostIvyToxinMaterialParameter;
    /// <summary>
    /// Function: CheckPostIvyToxinMaterialParameter
    /// </summary>
    public unsafe virtual void CheckPostIvyToxinMaterialParameter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckPostIvyToxinMaterialParameter, "BmGame.RBMPawnAI.CheckPostIvyToxinMaterialParameter");
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

    private static BmSDK.Function __fn_StorePlayerInteractions;
    /// <summary>
    /// Function: StorePlayerInteractions
    /// </summary>
    public unsafe virtual void StorePlayerInteractions(out BmSDK.Engine.RInteractionComponent OutInteractions)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StorePlayerInteractions, "BmGame.RBMPawnAI.StorePlayerInteractions");
        byte* paramsPtr = stackalloc byte[8];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutInteractions);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutInteractions, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutInteractions = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.RInteractionComponent>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_CheckPlayerInteractions;
    /// <summary>
    /// Function: CheckPlayerInteractions
    /// </summary>
    public unsafe virtual bool CheckPlayerInteractions(BmSDK.Engine.RInteractionComponent CheckInteractions)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckPlayerInteractions, "BmGame.RBMPawnAI.CheckPlayerInteractions");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckInteractions, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetPlayerInteractions;
    /// <summary>
    /// Function: SetPlayerInteractions
    /// </summary>
    public unsafe virtual void SetPlayerInteractions(BmSDK.Engine.RInteractionComponent NewInteractions)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerInteractions, "BmGame.RBMPawnAI.SetPlayerInteractions");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewInteractions, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPlayerInteractionClass;
    /// <summary>
    /// Function: AddPlayerInteractionClass
    /// </summary>
    public unsafe virtual void AddPlayerInteractionClass(BmSDK.FName NewInteraction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPlayerInteractionClass, "BmGame.RBMPawnAI.AddPlayerInteractionClass");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewInteraction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetPlayerInteractionOriginDist;
    /// <summary>
    /// Function: ResetPlayerInteractionOriginDist
    /// </summary>
    public unsafe virtual void ResetPlayerInteractionOriginDist()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPlayerInteractionOriginDist, "BmGame.RBMPawnAI.ResetPlayerInteractionOriginDist");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPlayerInteractionOriginDist;
    /// <summary>
    /// Function: SetPlayerInteractionOriginDist
    /// </summary>
    public unsafe virtual void SetPlayerInteractionOriginDist(float OverrideOriginDist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerInteractionOriginDist, "BmGame.RBMPawnAI.SetPlayerInteractionOriginDist");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideOriginDist, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetachPlayerInteractions;
    /// <summary>
    /// Function: DetachPlayerInteractions
    /// </summary>
    public unsafe virtual void DetachPlayerInteractions()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachPlayerInteractions, "BmGame.RBMPawnAI.DetachPlayerInteractions");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachPlayerInteractions;
    /// <summary>
    /// Function: AttachPlayerInteractions
    /// </summary>
    public unsafe virtual void AttachPlayerInteractions()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachPlayerInteractions, "BmGame.RBMPawnAI.AttachPlayerInteractions");
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

    private static BmSDK.Function __fn_UnsetFakeGrateVis;
    /// <summary>
    /// Function: UnsetFakeGrateVis
    /// </summary>
    public unsafe virtual void UnsetFakeGrateVis()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnsetFakeGrateVis, "BmGame.RBMPawnAI.UnsetFakeGrateVis");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFakeGrateVis;
    /// <summary>
    /// Function: SetFakeGrateVis
    /// </summary>
    public unsafe virtual void SetFakeGrateVis()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFakeGrateVis, "BmGame.RBMPawnAI.SetFakeGrateVis");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanDebugKill;
    /// <summary>
    /// Function: CanDebugKill
    /// </summary>
    public unsafe virtual bool CanDebugKill()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDebugKill, "BmGame.RBMPawnAI.CanDebugKill");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InitialiseLongRangeHighlight;
    /// <summary>
    /// Function: InitialiseLongRangeHighlight
    /// </summary>
    public unsafe virtual void InitialiseLongRangeHighlight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseLongRangeHighlight, "BmGame.RBMPawnAI.InitialiseLongRangeHighlight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldShowLongRangeHighlight;
    /// <summary>
    /// Function: ShouldShowLongRangeHighlight
    /// </summary>
    public unsafe virtual bool ShouldShowLongRangeHighlight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldShowLongRangeHighlight, "BmGame.RBMPawnAI.ShouldShowLongRangeHighlight");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_SetHelicopterPointOfInterestType;
    /// <summary>
    /// Function: SetHelicopterPointOfInterestType
    /// </summary>
    public unsafe virtual void SetHelicopterPointOfInterestType(BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes _HelicopterPointOfInterestType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHelicopterPointOfInterestType, "BmGame.RBMPawnAI.SetHelicopterPointOfInterestType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_HelicopterPointOfInterestType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSideStoryDetails;
    /// <summary>
    /// Function: SetSideStoryDetails
    /// </summary>
    public unsafe virtual void SetSideStoryDetails(BmSDK.FString SideStoryIconName, int _SideStoryDiscoveryHeight, bool _SideStoryIsMainActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSideStoryDetails, "BmGame.RBMPawnAI.SetSideStoryDetails");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStoryIconName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_SideStoryDiscoveryHeight, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_SideStoryIsMainActor, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RBMPawnAI.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentPylon;
    /// <summary>
    /// Function: SetCurrentPylon
    /// </summary>
    public unsafe virtual void SetCurrentPylon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentPylon, "BmGame.RBMPawnAI.SetCurrentPylon");
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

    private static BmSDK.Function __fn_GetLocalSpaceSocketDelta;
    /// <summary>
    /// Function: GetLocalSpaceSocketDelta
    /// </summary>
    public unsafe static bool GetLocalSpaceSocketDelta(BmSDK.Engine.SkeletalMeshComponent SkelComponent, BmSDK.FName FromSocketName, BmSDK.FName ToSocketName, out System.Numerics.Vector3 out_Location, out BmSDK.Rotator out_Rotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalSpaceSocketDelta, "BmGame.RBMPawnAI.GetLocalSpaceSocketDelta");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromSocketName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToSocketName, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Location);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Location, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Rotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Rotation, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Location = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
        out_Rotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_GatherForcesFromWalls;
    /// <summary>
    /// Function: GatherForcesFromWalls
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GatherForcesFromWalls(System.Numerics.Vector3 SourceLocation, float MaxForce, float MinRange, float MaxSideForceMultiplier = default, System.Numerics.Vector3 ForwardDir = default, bool bShowDebug = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GatherForcesFromWalls, "BmGame.RBMPawnAI.GatherForcesFromWalls");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxForce, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinRange, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxSideForceMultiplier, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForwardDir, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowDebug, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_IsInactiveInPool;
    /// <summary>
    /// Function: IsInactiveInPool
    /// </summary>
    public unsafe virtual bool IsInactiveInPool()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInactiveInPool, "BmGame.RBMPawnAI.IsInactiveInPool");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_HasGasMask;
    /// <summary>
    /// Function: HasGasMask
    /// </summary>
    public unsafe virtual bool HasGasMask(BmSDK.Engine.SkeletalMesh TestMesh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasGasMask, "BmGame.RBMPawnAI.HasGasMask");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestMesh, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetBodySize;
    /// <summary>
    /// Function: GetBodySize
    /// </summary>
    public unsafe virtual BmSDK.FString GetBodySize(BmSDK.Engine.SkeletalMesh TestMesh, bool bIsHead)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBodySize, "BmGame.RBMPawnAI.GetBodySize");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsHead, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CanBeSeenByBatsForXray;
    /// <summary>
    /// Function: CanBeSeenByBatsForXray
    /// </summary>
    public unsafe override bool CanBeSeenByBatsForXray()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeSeenByBatsForXray, "BmGame.RBMPawnAI.CanBeSeenByBatsForXray");
        byte* paramsPtr = stackalloc byte[4];
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

    private static BmSDK.Function __fn_ForceTickIndividualComponent;
    /// <summary>
    /// Function: ForceTickIndividualComponent
    /// </summary>
    public unsafe virtual void ForceTickIndividualComponent(BmSDK.Engine.ActorComponent CompToTick, float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceTickIndividualComponent, "BmGame.RBMPawnAI.ForceTickIndividualComponent");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CompToTick, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
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

    private static BmSDK.Function __fn_UpdatePropsVisibility;
    /// <summary>
    /// Function: UpdatePropsVisibility
    /// </summary>
    public unsafe override void UpdatePropsVisibility(float AlphaVal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePropsVisibility, "BmGame.RBMPawnAI.UpdatePropsVisibility");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlphaVal, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetTickIsDisabled;
    /// <summary>
    /// Function: SetTickIsDisabled
    /// </summary>
    public unsafe override void SetTickIsDisabled(bool bInDisabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTickIsDisabled, "BmGame.RBMPawnAI.SetTickIsDisabled");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInDisabled, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetLastValidNavMeshPoly;
    /// <summary>
    /// Function: SetLastValidNavMeshPoly
    /// </summary>
    public unsafe virtual void SetLastValidNavMeshPoly(BmSDK.Engine.Pylon ValidPylon, int ValidPolyID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLastValidNavMeshPoly, "BmGame.RBMPawnAI.SetLastValidNavMeshPoly");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValidPylon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValidPolyID, paramsPtr + 8);
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

    private static BmSDK.Function __fn_UpdateVertVisibility;
    /// <summary>
    /// Function: UpdateVertVisibility
    /// </summary>
    public unsafe virtual void UpdateVertVisibility()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateVertVisibility, "BmGame.RBMPawnAI.UpdateVertVisibility");
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

    private static BmSDK.Function __fn_GetMaxSightRange;
    /// <summary>
    /// Function: GetMaxSightRange
    /// </summary>
    public unsafe virtual float GetMaxSightRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxSightRange, "BmGame.RBMPawnAI.GetMaxSightRange");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanSeeActorFromPos;
    /// <summary>
    /// Function: CanSeeActorFromPos
    /// </summary>
    public unsafe virtual float CanSeeActorFromPos(BmSDK.Engine.Actor TestActor, System.Numerics.Vector3 TestPos, bool bEarlyOut = default, bool bIgnoreSmoke = default, bool bSkipTestedBones = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSeeActorFromPos, "BmGame.RBMPawnAI.CanSeeActorFromPos");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEarlyOut, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreSmoke, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipTestedBones, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_CanSeeActor;
    /// <summary>
    /// Function: CanSeeActor
    /// </summary>
    public unsafe virtual float CanSeeActor(BmSDK.Engine.Actor TestActor, bool bEarlyOut = default, bool bIgnoreSmoke = default, bool bSkipTestedBones = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSeeActor, "BmGame.RBMPawnAI.CanSeeActor");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEarlyOut, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreSmoke, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipTestedBones, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_CanSeePos;
    /// <summary>
    /// Function: CanSeePos
    /// </summary>
    public unsafe virtual bool CanSeePos(System.Numerics.Vector3 TestPos, bool bIgnoreSmoke = default, bool bStartWithPointCheck = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSeePos, "BmGame.RBMPawnAI.CanSeePos");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreSmoke, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStartWithPointCheck, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetPawnVisionCheckEyeLoc;
    /// <summary>
    /// Function: GetPawnVisionCheckEyeLoc
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPawnVisionCheckEyeLoc()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnVisionCheckEyeLoc, "BmGame.RBMPawnAI.GetPawnVisionCheckEyeLoc");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateActionOfClass;
    /// <summary>
    /// Function: CreateActionOfClass
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIAction CreateActionOfClass(BmSDK.Class NewClass, BmSDK.BmGame.RAlertEventCoordinatorSolo NewAEC, BmSDK.FString NewId = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateActionOfClass, "BmGame.RBMPawnAI.CreateActionOfClass");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAEC, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewId, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIAction>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_InitCharacter;
    /// <summary>
    /// Function: InitCharacter
    /// </summary>
    public unsafe virtual void InitCharacter(BmSDK.BmGame.RBMPawnAI.FInitCharacterDescription Description)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitCharacter, "BmGame.RBMPawnAI.InitCharacter");
        byte* paramsPtr = stackalloc byte[96];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 0);
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
    /// Struct: FgrateVisInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FgrateVisInfo
    {
        /// <summary>
        /// ObjectProperty: Grate
        /// </summary>
        public unsafe BmSDK.BmGame.RTunnelGrateBase Grate
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: timeVisible
        /// </summary>
        public unsafe float timeVisible
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FPathFailItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FPathFailItem
    {
        /// <summary>
        /// ByteProperty: PathError
        /// </summary>
        public unsafe BmSDK.Engine.EngineTypes.EPathFindingError PathError
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.EngineTypes.EPathFindingError>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: StartPos
        /// </summary>
        public unsafe System.Numerics.Vector3 StartPos
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: EndPos
        /// </summary>
        public unsafe System.Numerics.Vector3 EndPos
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FAlwaysOnParticles
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FAlwaysOnParticles
    {
        /// <summary>
        /// ComponentProperty: Part
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent Part
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: AttachBone
        /// </summary>
        public unsafe BmSDK.FName AttachBone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FValidNavMeshPoly
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FValidNavMeshPoly
    {
        /// <summary>
        /// StructProperty: Position
        /// </summary>
        public unsafe System.Numerics.Vector3 Position
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Pylon
        /// </summary>
        public unsafe BmSDK.Engine.Pylon Pylon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: PolyId
        /// </summary>
        public unsafe int PolyId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Enum: GunTargetBoneState
    /// </summary>
    public enum GunTargetBoneState : byte
    {
        GTBS_Untested = 0,
        GTBS_Obscured = 1,
        GTBS_Visible = 2,
        GTBS_MAX = 3,
    }

    /// <summary>
    /// Struct: FInitCharacterDescription
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public partial record struct FInitCharacterDescription
    {
        /// <summary>
        /// ClassProperty: Character
        /// </summary>
        public unsafe BmSDK.Class Character
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: CharacterDefine
        /// </summary>
        public unsafe BmSDK.BmGame.RCharacterDefine CharacterDefine
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterDefine>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// NameProperty: PawnReferenceName
        /// </summary>
        public unsafe BmSDK.FName PawnReferenceName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ClassProperty: WeaponType
        /// </summary>
        public unsafe BmSDK.Class WeaponType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ObjectProperty: AlternateAnimAndWeapon
        /// </summary>
        public unsafe BmSDK.BmGame.RAlternateAnimationAndWeaponConfig AlternateAnimAndWeapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlternateAnimationAndWeaponConfig>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// NameProperty: InitialMovementStance
        /// </summary>
        public unsafe BmSDK.FName InitialMovementStance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// NameProperty: InitialWeaponStance
        /// </summary>
        public unsafe BmSDK.FName InitialWeaponStance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// BoolProperty: bCastShadow
        /// </summary>
        public unsafe bool bCastShadow
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bForceFlappyBitsOff
        /// </summary>
        public unsafe bool bForceFlappyBitsOff
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bForceAlwaysUsePhysicsOn
        /// </summary>
        public unsafe bool bForceAlwaysUsePhysicsOn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bDisableRagdollCalming
        /// </summary>
        public unsafe bool bDisableRagdollCalming
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bCanBeXrayed
        /// </summary>
        public unsafe bool bCanBeXrayed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bTreatXrayAsOverworld
        /// </summary>
        public unsafe bool bTreatXrayAsOverworld
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bTreatAsOverworldForStasis
        /// </summary>
        public unsafe bool bTreatAsOverworldForStasis
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bForceLongRangeXrayFading
        /// </summary>
        public unsafe bool bForceLongRangeXrayFading
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bSilentRagdoll
        /// </summary>
        public unsafe bool bSilentRagdoll
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 256) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bUsedInCutsceneDialogue
        /// </summary>
        public unsafe bool bUsedInCutsceneDialogue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 512) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bSnappedToGround
        /// </summary>
        public unsafe bool bSnappedToGround
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1024) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: OverridePhysWalkingType
        /// </summary>
        public unsafe bool OverridePhysWalkingType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 2048) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// ByteProperty: PhysWalkingType
        /// </summary>
        public unsafe BmSDK.BmGame.RGameRI.EPhysWalkingType PhysWalkingType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EPhysWalkingType>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: bFallBackToNavMeshFloor
        /// </summary>
        public unsafe bool bFallBackToNavMeshFloor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// ByteProperty: RagdollVsNavMeshSolution
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnCharacter.ERagdollVsNavMesh RagdollVsNavMeshSolution
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCharacter.ERagdollVsNavMesh>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// BoolProperty: bReduceBlinksAndEyeMovements
        /// </summary>
        public unsafe bool bReduceBlinksAndEyeMovements
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bForceDisableFloorCorrection
        /// </summary>
        public unsafe bool bForceDisableFloorCorrection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bUseSkeletalMeshAggressiveLODScale
        /// </summary>
        public unsafe bool bUseSkeletalMeshAggressiveLODScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// FloatProperty: SkeletalMeshAggressiveLODMultiplier
        /// </summary>
        public unsafe float SkeletalMeshAggressiveLODMultiplier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// ArrayProperty: DefineIndexes
        /// </summary>
        public unsafe BmSDK.TArray<int> DefineIndexes
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }
    }

    /// <summary>
    /// Struct: FCharacterStaticProps
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 140)]
    public partial record struct FCharacterStaticProps
    {
        /// <summary>
        /// ObjectProperty: Prop
        /// </summary>
        public unsafe BmSDK.Engine.StaticMesh Prop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ComponentProperty: PropComp
        /// </summary>
        public unsafe BmSDK.Engine.StaticMeshComponent PropComp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// NameProperty: PropGlobalFlagCheck
        /// </summary>
        public unsafe BmSDK.FName PropGlobalFlagCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: MeshFlagMatch
        /// </summary>
        public unsafe BmSDK.FString MeshFlagMatch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// NameProperty: SocketToAttachPropTo
        /// </summary>
        public unsafe BmSDK.FName SocketToAttachPropTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// NameProperty: BoneToAttachPropTo
        /// </summary>
        public unsafe BmSDK.FName BoneToAttachPropTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// ArrayProperty: OverrideMaterials
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstance> OverrideMaterials
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstance>>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// ArrayProperty: OverrideMaterialsIC
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> OverrideMaterialsIC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// ObjectProperty: OverrideXrayMaterial
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstance OverrideXrayMaterial
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// ObjectProperty: OverrideXrayMaterialIC
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstanceConstant OverrideXrayMaterialIC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// ObjectProperty: OverrideThermalMaterial
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstance OverrideThermalMaterial
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }

        /// <summary>
        /// ObjectProperty: OverrideThermalMaterialIC
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstanceConstant OverrideThermalMaterialIC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }

        /// <summary>
        /// BoolProperty: bDisruptableEquipment
        /// </summary>
        public unsafe bool bDisruptableEquipment
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }; }
        }

        /// <summary>
        /// BoolProperty: bExplosiveWhenDisrupted
        /// </summary>
        public unsafe bool bExplosiveWhenDisrupted
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }; }
        }

        /// <summary>
        /// StrProperty: sDisruptorHUDDescription
        /// </summary>
        public unsafe BmSDK.FString sDisruptorHUDDescription
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 124); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }; }
        }
    }

    /// <summary>
    /// Struct: FCharacterSkeletalProps
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 184)]
    public partial record struct FCharacterSkeletalProps
    {
        /// <summary>
        /// ObjectProperty: Prop
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMesh Prop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ComponentProperty: PropComp
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMeshComponent PropComp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: OverrideMaterials
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstance> OverrideMaterials
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstance>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: OverrideXrayMaterial
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstance OverrideXrayMaterial
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ObjectProperty: OverrideXrayMaterialIC
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstanceConstant OverrideXrayMaterialIC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ObjectProperty: OverrideThermalMaterial
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstance OverrideThermalMaterial
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// ObjectProperty: OverrideThermalMaterialIC
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstanceConstant OverrideThermalMaterialIC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bDontAllowColorChange
        /// </summary>
        public unsafe bool bDontAllowColorChange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// ObjectProperty: PropPhys
        /// </summary>
        public unsafe BmSDK.Engine.PhysicsAsset PropPhys
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAsset>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// NameProperty: SocketToAttachPropTo
        /// </summary>
        public unsafe BmSDK.FName SocketToAttachPropTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// NameProperty: BoneToAttachPropTo
        /// </summary>
        public unsafe BmSDK.FName BoneToAttachPropTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// NameProperty: PropGlobalFlagCheck
        /// </summary>
        public unsafe BmSDK.FName PropGlobalFlagCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// StrProperty: MeshFlagMatch
        /// </summary>
        public unsafe BmSDK.FString MeshFlagMatch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }

        /// <summary>
        /// BoolProperty: bRemovePropOnStrike
        /// </summary>
        public unsafe bool bRemovePropOnStrike
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }; }
        }

        /// <summary>
        /// BoolProperty: bRemovePropOnDeath
        /// </summary>
        public unsafe bool bRemovePropOnDeath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }; }
        }

        /// <summary>
        /// BoolProperty: bRemovedProp
        /// </summary>
        public unsafe bool bRemovedProp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }; }
        }

        /// <summary>
        /// BoolProperty: bUsesParentAnim
        /// </summary>
        public unsafe bool bUsesParentAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }; }
        }

        /// <summary>
        /// ByteProperty: ParentAnimComponentMode
        /// </summary>
        public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.EParentAnimComponentMode ParentAnimComponentMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.EParentAnimComponentMode>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }

        /// <summary>
        /// ObjectProperty: AnimTree
        /// </summary>
        public unsafe BmSDK.Engine.AnimTree AnimTree
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimTree>(Ptr + 124); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }; }
        }

        /// <summary>
        /// ArrayProperty: AnimSets
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 132); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }; }
        }

        /// <summary>
        /// ClassProperty: RemovedPropClass
        /// </summary>
        public unsafe BmSDK.Class RemovedPropClass
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 148); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }; }
        }

        /// <summary>
        /// ObjectProperty: CustomDetatchedImpactEvent
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent CustomDetatchedImpactEvent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 156); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }; }
        }

        /// <summary>
        /// BoolProperty: bDisruptableEquipment
        /// </summary>
        public unsafe bool bDisruptableEquipment
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }; }
        }

        /// <summary>
        /// BoolProperty: bExplosiveWhenDisrupted
        /// </summary>
        public unsafe bool bExplosiveWhenDisrupted
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }; }
        }

        /// <summary>
        /// StrProperty: sDisruptorHUDDescription
        /// </summary>
        public unsafe BmSDK.FString sDisruptorHUDDescription
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }; }
        }
    }

    /// <summary>
    /// Struct: FSoftPawnInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSoftPawnInfo
    {
        /// <summary>
        /// ObjectProperty: Pawn
        /// </summary>
        public unsafe BmSDK.BmGame.RBMPawnAI Pawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: InfluenceTime
        /// </summary>
        public unsafe float InfluenceTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bInfluencedThisFrame
        /// </summary>
        public unsafe bool bInfluencedThisFrame
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FBodyDirtState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FBodyDirtState
    {
        /// <summary>
        /// StructProperty: Locations
        /// </summary>
        public unsafe BmSDK.BmGame.RBMPawnAI.FBodyLocationDirtState Locations_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI.FBodyLocationDirtState>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// StructProperty: Locations
        /// </summary>
        public unsafe BmSDK.BmGame.RBMPawnAI.FBodyLocationDirtState Locations_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI.FBodyLocationDirtState>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: MaxDirt
        /// </summary>
        public unsafe int MaxDirt
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FBodyLocationDirtState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FBodyLocationDirtState
    {
        /// <summary>
        /// IntProperty: Amount
        /// </summary>
        public unsafe int Amount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: Parameter
        /// </summary>
        public unsafe BmSDK.FName Parameter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EDirtType
    /// </summary>
    public enum EDirtType : byte
    {
        EDIRTTYPE_Wet = 0,
        EDIRTTYPE_Mud = 1,
        EDIRTTYPE_Dust = 2,
        EDIRTTYPE_Goo = 3,
        EDIRTTYPE_MAX = 4,
    }

    /// <summary>
    /// Enum: EDirtLocation
    /// </summary>
    public enum EDirtLocation : byte
    {
        EDIRTLOC_Front = 0,
        EDIRTLOC_Back = 1,
        EDIRTLOC_MAX = 2,
    }

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavigationHandle
    /// </summary>
    public unsafe System.IntPtr VfTable_IInterface_NavigationHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 3340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3340); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: BodyDirtStates
    /// </summary>
    public InlineArray<BmSDK.BmGame.RBMPawnAI.FBodyDirtState> BodyDirtStates => new(4, Ptr + 3348, 28, this);

    /// <summary>
    /// StructProperty: BodyDirtStates
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMPawnAI.FBodyDirtState BodyDirtStates_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMPawnAI.FBodyDirtState>(Ptr + 3348);
    /// <summary>
    /// StructProperty: BodyDirtStates
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMPawnAI.FBodyDirtState BodyDirtStates_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMPawnAI.FBodyDirtState>(Ptr + 3376);
    /// <summary>
    /// StructProperty: BodyDirtStates
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMPawnAI.FBodyDirtState BodyDirtStates_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMPawnAI.FBodyDirtState>(Ptr + 3404);
    /// <summary>
    /// StructProperty: BodyDirtStates
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMPawnAI.FBodyDirtState BodyDirtStates_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMPawnAI.FBodyDirtState>(Ptr + 3432);

    /// <summary>
    /// IntProperty: FacialDirtLevel
    /// </summary>
    public unsafe int FacialDirtLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3460); }
    }

    /// <summary>
    /// IntProperty: FacialDamageLevel
    /// </summary>
    public unsafe int FacialDamageLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3464); }
    }

    /// <summary>
    /// ArrayProperty: FacialDamageParameters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> FacialDamageParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 3468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3468); }
    }

    /// <summary>
    /// ArrayProperty: FacialDamageValues
    /// </summary>
    public unsafe BmSDK.TArray<float> FacialDamageValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 3484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3484); }
    }

    /// <summary>
    /// FloatProperty: ExplosionDamageLevel
    /// </summary>
    public unsafe float ExplosionDamageLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3500); }
    }

    /// <summary>
    /// IntProperty: BatarangDamageLevel
    /// </summary>
    public unsafe int BatarangDamageLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3504); }
    }

    /// <summary>
    /// IntProperty: DyeSprayLevel
    /// </summary>
    public unsafe int DyeSprayLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3508); }
    }

    /// <summary>
    /// StrProperty: BodySize
    /// </summary>
    public unsafe BmSDK.FString BodySize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3512); }
    }

    /// <summary>
    /// BoolProperty: bHasGasMask
    /// </summary>
    public unsafe bool bHasGasMask
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bFallBackToNavMeshFloor
    /// </summary>
    public unsafe bool bFallBackToNavMeshFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bDoPhysWalkingPointChecks
    /// </summary>
    public unsafe bool bDoPhysWalkingPointChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bBlockOtherPawns
    /// </summary>
    public unsafe bool bBlockOtherPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bDoPhysWalkingHeightSmoothing
    /// </summary>
    public unsafe bool bDoPhysWalkingHeightSmoothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bDontTurnOffGeoFloorChecksAtRange
    /// </summary>
    public unsafe bool bDontTurnOffGeoFloorChecksAtRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bPrevDoGeoFloorChecks
    /// </summary>
    public unsafe bool bPrevDoGeoFloorChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreRagdollPositionWhenSettingLocation
    /// </summary>
    public unsafe bool bIgnoreRagdollPositionWhenSettingLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bCanSeeThroughGlassCeilings
    /// </summary>
    public unsafe bool bCanSeeThroughGlassCeilings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bFriendly
    /// </summary>
    public unsafe bool bFriendly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bCrowd
    /// </summary>
    public unsafe bool bCrowd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bKeepWeapon
    /// </summary>
    public unsafe bool bKeepWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bSilentPredAI
    /// </summary>
    public unsafe bool bSilentPredAI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bIsLitePred
    /// </summary>
    public unsafe bool bIsLitePred
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bTriggerPredAlerts
    /// </summary>
    public unsafe bool bTriggerPredAlerts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bDoPredatorVision
    /// </summary>
    public unsafe bool bDoPredatorVision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bSniper
    /// </summary>
    public unsafe bool bSniper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bCanPickupSniperRifleSniper
    /// </summary>
    public unsafe bool bCanPickupSniperRifleSniper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bRocketLauncher
    /// </summary>
    public unsafe bool bRocketLauncher
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bCombatMirrored
    /// </summary>
    public unsafe bool bCombatMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bCanBeDisarmedByMagBlast
    /// </summary>
    public unsafe bool bCanBeDisarmedByMagBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bMagneticBlastClingToWeapon
    /// </summary>
    public unsafe bool bMagneticBlastClingToWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bDodgedMagneticBlastDisarm
    /// </summary>
    public unsafe bool bDodgedMagneticBlastDisarm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bInstantEnterCombatOnMagBlast
    /// </summary>
    public unsafe bool bInstantEnterCombatOnMagBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bForceNavMeshObstacleUpdate
    /// </summary>
    public unsafe bool bForceNavMeshObstacleUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bApplySoftPawnCollision
    /// </summary>
    public unsafe bool bApplySoftPawnCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bReceiveSoftPawnCollision
    /// </summary>
    public unsafe bool bReceiveSoftPawnCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bDoPlayerCollision
    /// </summary>
    public unsafe bool bDoPlayerCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bApplyRouterPawnAvoidance
    /// </summary>
    public unsafe bool bApplyRouterPawnAvoidance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bTickGunFire
    /// </summary>
    public unsafe bool bTickGunFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bFireOnceOnly
    /// </summary>
    public unsafe bool bFireOnceOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bForceBehaviourTickEveryFrame
    /// </summary>
    public unsafe bool bForceBehaviourTickEveryFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bWeaponCanBePickedUp
    /// </summary>
    public unsafe bool bWeaponCanBePickedUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bWeaponCanBePickedUpOnlyBySelf
    /// </summary>
    public unsafe bool bWeaponCanBePickedUpOnlyBySelf
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bWeaponWasJammed
    /// </summary>
    public unsafe bool bWeaponWasJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bDisableCornerSliding
    /// </summary>
    public unsafe bool bDisableCornerSliding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bAttackASAP
    /// </summary>
    public unsafe bool bAttackASAP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bForceConstantGroundChecks
    /// </summary>
    public unsafe bool bForceConstantGroundChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bWanderingAI
    /// </summary>
    public unsafe bool bWanderingAI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bCanCrossLevelVolumes
    /// </summary>
    public unsafe bool bCanCrossLevelVolumes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysShovePawns
    /// </summary>
    public unsafe bool bAlwaysShovePawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bDontShowPredatorEscapeInstructions
    /// </summary>
    public unsafe bool bDontShowPredatorEscapeInstructions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bAwardXPOnDeath
    /// </summary>
    public unsafe bool bAwardXPOnDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bSpawnedInRiot
    /// </summary>
    public unsafe bool bSpawnedInRiot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bTriggerBatarangCamera
    /// </summary>
    public unsafe bool bTriggerBatarangCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bFadeOutAfterDeath
    /// </summary>
    public unsafe bool bFadeOutAfterDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bStreamWeapon
    /// </summary>
    public unsafe bool bStreamWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bShouldPlayFleeReaction
    /// </summary>
    public unsafe bool bShouldPlayFleeReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bWaitForTransToEndBeforeFleeReaction
    /// </summary>
    public unsafe bool bWaitForTransToEndBeforeFleeReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bCanBeXrayed
    /// </summary>
    public unsafe bool bCanBeXrayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bTreatXrayAsOverworld
    /// </summary>
    public unsafe bool bTreatXrayAsOverworld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bTreatAsOverworldForStasis
    /// </summary>
    public unsafe bool bTreatAsOverworldForStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bBatarangCanKill
    /// </summary>
    public unsafe bool bBatarangCanKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bBatarangCantTarget
    /// </summary>
    public unsafe bool bBatarangCantTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bDontReactToBatarang
    /// </summary>
    public unsafe bool bDontReactToBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysDodgeBatarang
    /// </summary>
    public unsafe bool bAlwaysDodgeBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bForceBatarangMirror
    /// </summary>
    public unsafe bool bForceBatarangMirror
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bHarpoonCantTarget
    /// </summary>
    public unsafe bool bHarpoonCantTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bDontReactToHarpoon
    /// </summary>
    public unsafe bool bDontReactToHarpoon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bMagneticBlastCantHit
    /// </summary>
    public unsafe bool bMagneticBlastCantHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bUseRealNameForInvestigate
    /// </summary>
    public unsafe bool bUseRealNameForInvestigate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bFiring
    /// </summary>
    public unsafe bool bFiring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bFiringBurst
    /// </summary>
    public unsafe bool bFiringBurst
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bIsInBurst
    /// </summary>
    public unsafe bool bIsInBurst
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bStopAfterBurst
    /// </summary>
    public unsafe bool bStopAfterBurst
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bHasBuiltInGun
    /// </summary>
    public unsafe bool bHasBuiltInGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bIsInFrontOfCamera
    /// </summary>
    public unsafe bool bIsInFrontOfCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bInDialogue
    /// </summary>
    public unsafe bool bInDialogue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bICSuspendStasis
    /// </summary>
    public unsafe bool bICSuspendStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bICForceStasis
    /// </summary>
    public unsafe bool bICForceStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bDestroyPawnIfInStasisForTooLong
    /// </summary>
    public unsafe bool bDestroyPawnIfInStasisForTooLong
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bActionTickActive
    /// </summary>
    public unsafe bool bActionTickActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bActionCustomEyeLocation
    /// </summary>
    public unsafe bool bActionCustomEyeLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bIsRescueTarget
    /// </summary>
    public unsafe bool bIsRescueTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bShowRouterBlockedInfo
    /// </summary>
    public unsafe bool bShowRouterBlockedInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bCheckingInGrate
    /// </summary>
    public unsafe bool bCheckingInGrate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bFakeCheckingInGrate
    /// </summary>
    public unsafe bool bFakeCheckingInGrate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bTrackingSightingInGrate
    /// </summary>
    public unsafe bool bTrackingSightingInGrate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bAllowedToChatter
    /// </summary>
    public unsafe bool bAllowedToChatter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreForNavPathAvoidance
    /// </summary>
    public unsafe bool bIgnoreForNavPathAvoidance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bChallengeModePawn
    /// </summary>
    public unsafe bool bChallengeModePawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bAllowConversationsToContinueWhenTakenDown
    /// </summary>
    public unsafe bool bAllowConversationsToContinueWhenTakenDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bFadeIn
    /// </summary>
    public unsafe bool bFadeIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bFadeOut
    /// </summary>
    public unsafe bool bFadeOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bShouldTickFade
    /// </summary>
    public unsafe bool bShouldTickFade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bPlayerInteractionsManuallyAttached
    /// </summary>
    public unsafe bool bPlayerInteractionsManuallyAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bInMatineeBehaviour
    /// </summary>
    public unsafe bool bInMatineeBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bPooledPawn_Inactive
    /// </summary>
    public unsafe bool bPooledPawn_Inactive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bInThugPool
    /// </summary>
    public unsafe bool bInThugPool
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToFinishUnpooling
    /// </summary>
    public unsafe bool bWaitingToFinishUnpooling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bForceRunSleepInPoolCode
    /// </summary>
    public unsafe bool bForceRunSleepInPoolCode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bBeingStreamedOut
    /// </summary>
    public unsafe bool bBeingStreamedOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: grateVisDrawDebug
    /// </summary>
    public unsafe bool grateVisDrawDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: grateVisForceOn
    /// </summary>
    public unsafe bool grateVisForceOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: grateVisForceOff
    /// </summary>
    public unsafe bool grateVisForceOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bAwaitingDestruction
    /// </summary>
    public unsafe bool bAwaitingDestruction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bFinishedSpeakingWhileAwaitingDestruction
    /// </summary>
    public unsafe bool bFinishedSpeakingWhileAwaitingDestruction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3540) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3540); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3540); }
    }

    /// <summary>
    /// BoolProperty: bHasSideStoryIconName
    /// </summary>
    public unsafe bool bHasSideStoryIconName
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3540) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3540); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3540); }
    }

    /// <summary>
    /// BoolProperty: CachedInvestigateLocationValid
    /// </summary>
    public unsafe bool CachedInvestigateLocationValid
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3540) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3540); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3540); }
    }

    /// <summary>
    /// BoolProperty: bAllowBehaviourTickWhenPawnTickIsDisabled
    /// </summary>
    public unsafe bool bAllowBehaviourTickWhenPawnTickIsDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3540) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3540); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3540); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_Falling
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig PoseConfig_Falling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 3544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3544); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_Standing
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig PoseConfig_Standing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 3552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3552); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_Basic
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig PoseConfig_Basic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 3560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3560); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_Ladder
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig PoseConfig_Ladder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 3568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3568); }
    }

    /// <summary>
    /// ObjectProperty: AIManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIManager AIManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIManager>(Ptr + 3576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3576); }
    }

    /// <summary>
    /// ObjectProperty: CurrNavHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle CurrNavHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 3584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3584); }
    }

    /// <summary>
    /// ObjectProperty: Spawner
    /// </summary>
    public unsafe BmSDK.GameObject Spawner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 3592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3592); }
    }

    /// <summary>
    /// ObjectProperty: LastMagBlastReceiver
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlastReceiver LastMagBlastReceiver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlastReceiver>(Ptr + 3600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3600); }
    }

    /// <summary>
    /// ObjectProperty: AlternateAnimAndWeap
    /// </summary>
    public unsafe BmSDK.BmGame.RAlternateAnimationAndWeaponConfig AlternateAnimAndWeap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlternateAnimationAndWeaponConfig>(Ptr + 3608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3608); }
    }

    /// <summary>
    /// ObjectProperty: CurrWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RBMWeapon CurrWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeapon>(Ptr + 3616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3616); }
    }

    /// <summary>
    /// ObjectProperty: CurrDroppedWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatThrownObject CurrDroppedWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject>(Ptr + 3624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3624); }
    }

    /// <summary>
    /// ObjectProperty: CharacterDefine
    /// </summary>
    public unsafe BmSDK.BmGame.RCharacterDefine CharacterDefine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterDefine>(Ptr + 3632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3632); }
    }

    /// <summary>
    /// ObjectProperty: StreamedWeaponRefHolder
    /// </summary>
    public unsafe BmSDK.BmGame.RCharacterBioCue StreamedWeaponRefHolder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterBioCue>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }

    /// <summary>
    /// ObjectProperty: FoliageList
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass FoliageList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 3648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3648); }
    }

    /// <summary>
    /// ObjectProperty: CurrentFoliage
    /// </summary>
    public unsafe BmSDK.Engine.InteractiveFoliageActor CurrentFoliage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InteractiveFoliageActor>(Ptr + 3656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3656); }
    }

    /// <summary>
    /// ObjectProperty: EntryAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet EntryAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3664); }
    }

    /// <summary>
    /// ObjectProperty: LastFloorPanel
    /// </summary>
    public unsafe BmSDK.BmGame.RElectrifiedFloorPanel LastFloorPanel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RElectrifiedFloorPanel>(Ptr + 3672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3672); }
    }

    /// <summary>
    /// ObjectProperty: CurrentGun
    /// </summary>
    public unsafe BmSDK.BmGame.RBMWeaponRanged CurrentGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeaponRanged>(Ptr + 3680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3680); }
    }

    /// <summary>
    /// ObjectProperty: GlanceTarget
    /// </summary>
    public unsafe BmSDK.BmGame.AlertInstance GlanceTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.AlertInstance>(Ptr + 3688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3688); }
    }

    /// <summary>
    /// ObjectProperty: StasisLinkMasterPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI StasisLinkMasterPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 3696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3696); }
    }

    /// <summary>
    /// ObjectProperty: ArmouredThugMagnetisedAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ArmouredThugMagnetisedAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3704); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeDespawnParticleEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChallengeDespawnParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3712); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeImpactParticleEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChallengeImpactParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3720); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeDespawnAkEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChallengeDespawnAkEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3728); }
    }

    /// <summary>
    /// ObjectProperty: InVehicleWeaponArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPCWeapon InVehicleWeaponArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPCWeapon>(Ptr + 3736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3736); }
    }

    /// <summary>
    /// ObjectProperty: lastSearchedLedgeInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RLedgeLookDangerAreaInfo lastSearchedLedgeInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLedgeLookDangerAreaInfo>(Ptr + 3744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3744); }
    }

    /// <summary>
    /// ObjectProperty: MatineeBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour_Controlled MatineeBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_Controlled>(Ptr + 3752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3752); }
    }

    /// <summary>
    /// ObjectProperty: PawnPool
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPool PawnPool
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPool>(Ptr + 3760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3760); }
    }

    /// <summary>
    /// ObjectProperty: IncomingCombatMove
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatMove IncomingCombatMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatMove>(Ptr + 3768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3768); }
    }

    /// <summary>
    /// ObjectProperty: ReformLocationActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor ReformLocationActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3776); }
    }

    /// <summary>
    /// ObjectProperty: RoadObstacleRoads
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadNetwork RoadObstacleRoads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork>(Ptr + 3784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3784); }
    }

    /// <summary>
    /// ComponentProperty: LongRangeHighlightMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent LongRangeHighlightMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 3792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3792); }
    }

    /// <summary>
    /// ComponentProperty: PlayerInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent PlayerInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 3800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3800); }
    }

    /// <summary>
    /// ComponentProperty: FlashLightComponent
    /// </summary>
    public unsafe BmSDK.Engine.SpotLightComponent FlashLightComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpotLightComponent>(Ptr + 3808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3808); }
    }

    /// <summary>
    /// ClassProperty: CombatBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class CombatBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3816); }
    }

    /// <summary>
    /// ClassProperty: CharactersType
    /// </summary>
    public unsafe BmSDK.Class CharactersType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3824); }
    }

    /// <summary>
    /// ClassProperty: WeaponType
    /// </summary>
    public unsafe BmSDK.Class WeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3832); }
    }

    /// <summary>
    /// ByteProperty: PhysWalkingType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.EPhysWalkingType PhysWalkingType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EPhysWalkingType>(Ptr + 3840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3840); }
    }

    /// <summary>
    /// ByteProperty: TempPhysWalkingType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.EPhysWalkingType TempPhysWalkingType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EPhysWalkingType>(Ptr + 3841); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3841); }
    }

    /// <summary>
    /// ByteProperty: StasisMode
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.EStasisMode StasisMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EStasisMode>(Ptr + 3842); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3842); }
    }

    /// <summary>
    /// ByteProperty: KOGameAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction KOGameAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 3843); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3843); }
    }

    /// <summary>
    /// ByteProperty: SkinColourType
    /// </summary>
    public unsafe BmSDK.BmGame.RCharacterDefine.SkinTypeEnum SkinColourType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterDefine.SkinTypeEnum>(Ptr + 3844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3844); }
    }

    /// <summary>
    /// ByteProperty: WeaponConfigType
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.EWeaponConfigType WeaponConfigType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.EWeaponConfigType>(Ptr + 3845); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3845); }
    }

    /// <summary>
    /// ByteProperty: HelicopterPointOfInterestType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes HelicopterPointOfInterestType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes>(Ptr + 3846); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3846); }
    }

    /// <summary>
    /// IntProperty: HitCollisionWithFloorCheckCount
    /// </summary>
    public unsafe int HitCollisionWithFloorCheckCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3848); }
    }

    /// <summary>
    /// StructProperty: SearchExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SearchExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3852);

    /// <summary>
    /// StructProperty: TerrifiedSearchExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TerrifiedSearchExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3864);

    /// <summary>
    /// ArrayProperty: NavHandleList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle> NavHandleList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle>>(Ptr + 3876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3876); }
    }

    /// <summary>
    /// NameProperty: PawnReferenceName
    /// </summary>
    public unsafe BmSDK.FName PawnReferenceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3892); }
    }

    /// <summary>
    /// FloatProperty: SoftPawnCollisionRadiusMultiplier
    /// </summary>
    public unsafe float SoftPawnCollisionRadiusMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3900); }
    }

    /// <summary>
    /// StructProperty: SoftPawnCollisionVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SoftPawnCollisionVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3904);

    /// <summary>
    /// ArrayProperty: SoftPawnCollisionInfluencers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FSoftPawnInfo> SoftPawnCollisionInfluencers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FSoftPawnInfo>>(Ptr + 3916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3916); }
    }

    /// <summary>
    /// NameProperty: HolsterBoneName
    /// </summary>
    public unsafe BmSDK.FName HolsterBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3932); }
    }

    /// <summary>
    /// IntProperty: ForceGroundChecks
    /// </summary>
    public unsafe int ForceGroundChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3940); }
    }

    /// <summary>
    /// IntProperty: FramesSinceGroundCheck
    /// </summary>
    public unsafe int FramesSinceGroundCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3944); }
    }

    /// <summary>
    /// ArrayProperty: AllowBasingOnVehicleObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> AllowBasingOnVehicleObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 3948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3948); }
    }

    /// <summary>
    /// ArrayProperty: DisableVehicleDiveBehaviours
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMBehaviour> DisableVehicleDiveBehaviours
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMBehaviour>>(Ptr + 3964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3964); }
    }

    /// <summary>
    /// FloatProperty: InstantSightRange
    /// </summary>
    public unsafe float InstantSightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3980); }
    }

    /// <summary>
    /// FloatProperty: FocusedSightRange
    /// </summary>
    public unsafe float FocusedSightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3984); }
    }

    /// <summary>
    /// FloatProperty: FocusedVisionRadius
    /// </summary>
    public unsafe float FocusedVisionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3988); }
    }

    /// <summary>
    /// FloatProperty: PeripheralSightRange
    /// </summary>
    public unsafe float PeripheralSightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3992); }
    }

    /// <summary>
    /// FloatProperty: ExtendedSightRange
    /// </summary>
    public unsafe float ExtendedSightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3996); }
    }

    /// <summary>
    /// StructProperty: PrevFloorNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PrevFloorNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4000);

    /// <summary>
    /// StrProperty: ForceDeathTip
    /// </summary>
    public unsafe BmSDK.FString ForceDeathTip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4012); }
    }

    /// <summary>
    /// StructProperty: HitReactionWeaponSwitchThrowImpulse
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HitReactionWeaponSwitchThrowImpulse
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4028);

    /// <summary>
    /// StrProperty: RiotWeaponName
    /// </summary>
    public unsafe BmSDK.FString RiotWeaponName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4040); }
    }

    /// <summary>
    /// FloatProperty: DeathTimer
    /// </summary>
    public unsafe float DeathTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4056); }
    }

    /// <summary>
    /// ArrayProperty: DeathMat
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> DeathMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 4060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4060); }
    }

    /// <summary>
    /// FloatProperty: DeathFadePause
    /// </summary>
    public unsafe float DeathFadePause
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4076); }
    }

    /// <summary>
    /// FloatProperty: DeathFadeDuration
    /// </summary>
    public unsafe float DeathFadeDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4080); }
    }

    /// <summary>
    /// StructProperty: CachedCylinderExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CachedCylinderExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4084);

    /// <summary>
    /// FloatProperty: MaxBumpedTimer
    /// </summary>
    public unsafe float MaxBumpedTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4096); }
    }

    /// <summary>
    /// FloatProperty: CarCollisionTimer
    /// </summary>
    public unsafe float CarCollisionTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4100); }
    }

    /// <summary>
    /// FloatProperty: LastCarCollisionWarningTime
    /// </summary>
    public unsafe float LastCarCollisionWarningTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4104); }
    }

    /// <summary>
    /// IntProperty: UniquePawnIdentifier
    /// </summary>
    public unsafe int UniquePawnIdentifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4108); }
    }

    /// <summary>
    /// ArrayProperty: PropStatics
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FCharacterStaticProps> PropStatics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FCharacterStaticProps>>(Ptr + 4112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4112); }
    }

    /// <summary>
    /// ArrayProperty: PropSkeletals
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FCharacterSkeletalProps> PropSkeletals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FCharacterSkeletalProps>>(Ptr + 4128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4128); }
    }

    /// <summary>
    /// StructProperty: PropLightingChannels
    /// </summary>
    public unsafe ref BmSDK.Engine.LightComponent.FLightingChannelContainer PropLightingChannels
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.LightComponent.FLightingChannelContainer>(Ptr + 4144);

    /// <summary>
    /// IntProperty: OverrideKOXP
    /// </summary>
    public unsafe int OverrideKOXP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4148); }
    }

    /// <summary>
    /// ArrayProperty: BatarangTargetBodyParts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BatarangTargetBodyParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4152); }
    }

    /// <summary>
    /// ArrayProperty: WhipTargetBodyParts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> WhipTargetBodyParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4168); }
    }

    /// <summary>
    /// StrProperty: RealNameForInvestigate
    /// </summary>
    public unsafe BmSDK.FString RealNameForInvestigate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4184); }
    }

    /// <summary>
    /// NameProperty: SpineName
    /// </summary>
    public unsafe BmSDK.FName SpineName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4200); }
    }

    /// <summary>
    /// NameProperty: EntryAnim
    /// </summary>
    public unsafe BmSDK.FName EntryAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4208); }
    }

    /// <summary>
    /// FloatProperty: LastFireTime
    /// </summary>
    public unsafe float LastFireTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4216); }
    }

    /// <summary>
    /// FloatProperty: FireTimer
    /// </summary>
    public unsafe float FireTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4220); }
    }

    /// <summary>
    /// IntProperty: BurstCount
    /// </summary>
    public unsafe int BurstCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4224); }
    }

    /// <summary>
    /// IntProperty: ClipCount
    /// </summary>
    public unsafe int ClipCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4228); }
    }

    /// <summary>
    /// FloatProperty: GunMomentumTime
    /// </summary>
    public unsafe float GunMomentumTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4232); }
    }

    /// <summary>
    /// StructProperty: GunMomentumDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GunMomentumDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4236);

    /// <summary>
    /// ArrayProperty: GunTargetBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.GunTargetBoneState> GunTargetBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.GunTargetBoneState>>(Ptr + 4248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4248); }
    }

    /// <summary>
    /// FloatProperty: BeenStartledTimer
    /// </summary>
    public unsafe float BeenStartledTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4264); }
    }

    /// <summary>
    /// ArrayProperty: StasisLinkPawn
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> StasisLinkPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 4268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4268); }
    }

    /// <summary>
    /// FloatProperty: OverrideStasisDist
    /// </summary>
    public unsafe float OverrideStasisDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4284); }
    }

    /// <summary>
    /// FloatProperty: OverrideFrontStasisDist
    /// </summary>
    public unsafe float OverrideFrontStasisDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4288); }
    }

    /// <summary>
    /// FloatProperty: DestroyPawnIfInStasisTime
    /// </summary>
    public unsafe float DestroyPawnIfInStasisTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4292); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastRender
    /// </summary>
    public unsafe float TimeSinceLastRender
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4296); }
    }

    /// <summary>
    /// ArrayProperty: Queue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIAction> Queue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIAction>>(Ptr + 4300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4300); }
    }

    /// <summary>
    /// ArrayProperty: MoveToTargetList
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> MoveToTargetList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 4316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4316); }
    }

    /// <summary>
    /// StructProperty: MoveToTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MoveToTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4332);

    /// <summary>
    /// StructProperty: LastValidNavMeshPoly
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMPawnAI.FValidNavMeshPoly LastValidNavMeshPoly
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMPawnAI.FValidNavMeshPoly>(Ptr + 4344);

    /// <summary>
    /// StructProperty: RouterBlockedPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RouterBlockedPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4368);

    /// <summary>
    /// StructProperty: RouterBlockedNewPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RouterBlockedNewPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4380);

    /// <summary>
    /// StructProperty: RouterBlockedDestination
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RouterBlockedDestination
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4392);

    /// <summary>
    /// StructProperty: RouterBlockedSnappedDestination
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RouterBlockedSnappedDestination
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4404);

    /// <summary>
    /// StructProperty: RouterBlockedExtents
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RouterBlockedExtents
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4416);

    /// <summary>
    /// ArrayProperty: AlwaysOnPS
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FAlwaysOnParticles> AlwaysOnPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FAlwaysOnParticles>>(Ptr + 4428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4428); }
    }

    /// <summary>
    /// FloatProperty: CurrDestZ
    /// </summary>
    public unsafe float CurrDestZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4444); }
    }

    /// <summary>
    /// FloatProperty: ZBlendSpeed
    /// </summary>
    public unsafe float ZBlendSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4448); }
    }

    /// <summary>
    /// FloatProperty: PrevPathSlideDirection
    /// </summary>
    public unsafe float PrevPathSlideDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4452); }
    }

    /// <summary>
    /// ArrayProperty: CombatIdleStances
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CombatIdleStances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4456); }
    }

    /// <summary>
    /// IntProperty: CombatIdleStanceID
    /// </summary>
    public unsafe int CombatIdleStanceID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4472); }
    }

    /// <summary>
    /// FloatProperty: FadeTimer
    /// </summary>
    public unsafe float FadeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4476); }
    }

    /// <summary>
    /// ArrayProperty: PathFailHistory
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FPathFailItem> PathFailHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FPathFailItem>>(Ptr + 4480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4480); }
    }

    /// <summary>
    /// FloatProperty: CurrentAverageFaceFXValue
    /// </summary>
    public unsafe float CurrentAverageFaceFXValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4496); }
    }

    /// <summary>
    /// FloatProperty: lastLedgeSearchTime
    /// </summary>
    public unsafe float lastLedgeSearchTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4500); }
    }

    /// <summary>
    /// IntProperty: numPaintyFootPrintsRemaining
    /// </summary>
    public unsafe int numPaintyFootPrintsRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4504); }
    }

    /// <summary>
    /// IntProperty: PooledActivations
    /// </summary>
    public unsafe int PooledActivations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4508); }
    }

    /// <summary>
    /// FloatProperty: grateVisLength_Normal
    /// </summary>
    public unsafe float grateVisLength_Normal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4512); }
    }

    /// <summary>
    /// FloatProperty: grateVisLength_GrateSearch
    /// </summary>
    public unsafe float grateVisLength_GrateSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4516); }
    }

    /// <summary>
    /// FloatProperty: grateVisWidth_Normal
    /// </summary>
    public unsafe float grateVisWidth_Normal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4520); }
    }

    /// <summary>
    /// FloatProperty: grateVisWidth_GrateSearch
    /// </summary>
    public unsafe float grateVisWidth_GrateSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4524); }
    }

    /// <summary>
    /// FloatProperty: grateVisForwardBiasDist
    /// </summary>
    public unsafe float grateVisForwardBiasDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4528); }
    }

    /// <summary>
    /// FloatProperty: grateVisAlreadyVisibleBonusRange
    /// </summary>
    public unsafe float grateVisAlreadyVisibleBonusRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4532); }
    }

    /// <summary>
    /// FloatProperty: grateVisWarmupTime
    /// </summary>
    public unsafe float grateVisWarmupTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4536); }
    }

    /// <summary>
    /// ArrayProperty: gratesBMVisibleThrough
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FgrateVisInfo> gratesBMVisibleThrough
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FgrateVisInfo>>(Ptr + 4540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4540); }
    }

    /// <summary>
    /// FloatProperty: SpawnedTime
    /// </summary>
    public unsafe float SpawnedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4556); }
    }

    /// <summary>
    /// IntProperty: NumWallChecks
    /// </summary>
    public unsafe int NumWallChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4560); }
    }

    /// <summary>
    /// ArrayProperty: WallForces
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> WallForces
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 4564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4564); }
    }

    /// <summary>
    /// StructProperty: ForwardWallHitNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ForwardWallHitNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4580);

    /// <summary>
    /// IntProperty: CurrentWallCheck
    /// </summary>
    public unsafe int CurrentWallCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4592); }
    }

    /// <summary>
    /// FloatProperty: ForwardWallCheckYaw
    /// </summary>
    public unsafe float ForwardWallCheckYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4596); }
    }

    /// <summary>
    /// StrProperty: DeathMovieIfThisPawnKillsBatman
    /// </summary>
    public unsafe BmSDK.FString DeathMovieIfThisPawnKillsBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4600); }
    }

    /// <summary>
    /// StructProperty: CachedInvestigateLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CachedInvestigateLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4616);

    /// <summary>
    /// IntProperty: RoadObstacleIndex
    /// </summary>
    public unsafe int RoadObstacleIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4628); }
    }
}
