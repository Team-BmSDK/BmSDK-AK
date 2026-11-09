#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RSeqAct_ChatterBoxBase<br/>
/// (size = 628)
/// (flags = 201334935)
/// </summary>
public partial class RSeqAct_ChatterBoxBase : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ChatterBoxBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSeqAct_ChatterBoxBase.
    /// </summary>
    public static RSeqAct_ChatterBoxBase DefaultObject => (RSeqAct_ChatterBoxBase)StaticClass().DefaultObject;

    internal RSeqAct_ChatterBoxBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ChatterBoxBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_ChatterBoxBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_ChatterBoxBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_ChatterBoxBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_ChatterBoxBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_ChatterBoxBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_ChatterBoxBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_ChatterBoxBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_ChatterBoxBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_IsAVideoBillboardOnScreen;
    /// <summary>
    /// Function: IsAVideoBillboardOnScreen
    /// </summary>
    public unsafe virtual bool IsAVideoBillboardOnScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAVideoBillboardOnScreen, "BmGame.RSeqAct_ChatterBoxBase.IsAVideoBillboardOnScreen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEventBarkForActivityType;
    /// <summary>
    /// Function: GetEventBarkForActivityType
    /// </summary>
    public unsafe virtual BmSDK.FName GetEventBarkForActivityType(BmSDK.BmGame.RSeqAct_ChatterBoxBase.PawnChatterActivityType activity, bool bForceWanderersToPlayOneShots = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEventBarkForActivityType, "BmGame.RSeqAct_ChatterBoxBase.GetEventBarkForActivityType");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(activity, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceWanderersToPlayOneShots, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetScarecrowBillboardChatterSpeech;
    /// <summary>
    /// Function: GetScarecrowBillboardChatterSpeech
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkDialogueSpeech GetScarecrowBillboardChatterSpeech()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScarecrowBillboardChatterSpeech, "BmGame.RSeqAct_ChatterBoxBase.GetScarecrowBillboardChatterSpeech");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogueSpeech>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerHelicopterChatterBark;
    /// <summary>
    /// Function: TriggerHelicopterChatterBark
    /// </summary>
    public unsafe virtual bool TriggerHelicopterChatterBark(BmSDK.BmGame.RHelicopterBase heliSpeaker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerHelicopterChatterBark, "BmGame.RSeqAct_ChatterBoxBase.TriggerHelicopterChatterBark");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(heliSpeaker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AreOtherTanksInRange;
    /// <summary>
    /// Function: AreOtherTanksInRange
    /// </summary>
    public unsafe virtual bool AreOtherTanksInRange(BmSDK.BmGame.RVehicleTank inTank)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreOtherTanksInRange, "BmGame.RSeqAct_ChatterBoxBase.AreOtherTanksInRange");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTank, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ShuffleChosenPawns;
    /// <summary>
    /// Function: ShuffleChosenPawns
    /// </summary>
    public unsafe virtual void ShuffleChosenPawns()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShuffleChosenPawns, "BmGame.RSeqAct_ChatterBoxBase.ShuffleChosenPawns");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryTriggerThugChatter;
    /// <summary>
    /// Function: TryTriggerThugChatter
    /// </summary>
    public unsafe virtual bool TryTriggerThugChatter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryTriggerThugChatter, "BmGame.RSeqAct_ChatterBoxBase.TryTriggerThugChatter");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryTriggerChatter;
    /// <summary>
    /// Function: TryTriggerChatter
    /// </summary>
    public unsafe virtual bool TryTriggerChatter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryTriggerChatter, "BmGame.RSeqAct_ChatterBoxBase.TryTriggerChatter");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryTriggerChopperBMChatter;
    /// <summary>
    /// Function: TryTriggerChopperBMChatter
    /// </summary>
    public unsafe virtual bool TryTriggerChopperBMChatter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryTriggerChopperBMChatter, "BmGame.RSeqAct_ChatterBoxBase.TryTriggerChopperBMChatter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateCachedGameStateVars;
    /// <summary>
    /// Function: UpdateCachedGameStateVars
    /// </summary>
    public unsafe virtual void UpdateCachedGameStateVars()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCachedGameStateVars, "BmGame.RSeqAct_ChatterBoxBase.UpdateCachedGameStateVars");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetOuterMost;
    /// <summary>
    /// Function: GetOuterMost
    /// </summary>
    public unsafe virtual BmSDK.GameObject GetOuterMost(BmSDK.GameObject A)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOuterMost, "BmGame.RSeqAct_ChatterBoxBase.GetOuterMost");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TriggerThugChatterBark;
    /// <summary>
    /// Function: TriggerThugChatterBark
    /// </summary>
    public unsafe virtual bool TriggerThugChatterBark(bool bForceWanderersToPlayOneShots = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerThugChatterBark, "BmGame.RSeqAct_ChatterBoxBase.TriggerThugChatterBark");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceWanderersToPlayOneShots, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DrawDebug;
    /// <summary>
    /// Function: DrawDebug
    /// </summary>
    public unsafe virtual void DrawDebug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebug, "BmGame.RSeqAct_ChatterBoxBase.DrawDebug");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnKismetDialogueSuccess;
    /// <summary>
    /// Function: OnKismetDialogueSuccess
    /// </summary>
    public unsafe virtual void OnKismetDialogueSuccess()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnKismetDialogueSuccess, "BmGame.RSeqAct_ChatterBoxBase.OnKismetDialogueSuccess");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_OnKismetDialogueFail;
    /// <summary>
    /// Function: OnKismetDialogueFail
    /// </summary>
    public unsafe virtual void OnKismetDialogueFail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnKismetDialogueFail, "BmGame.RSeqAct_ChatterBoxBase.OnKismetDialogueFail");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_GetRiddlerChatterInterval;
    /// <summary>
    /// Function: GetRiddlerChatterInterval
    /// </summary>
    public unsafe virtual float GetRiddlerChatterInterval()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRiddlerChatterInterval, "BmGame.RSeqAct_ChatterBoxBase.GetRiddlerChatterInterval");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetScarecrowChatterInterval;
    /// <summary>
    /// Function: GetScarecrowChatterInterval
    /// </summary>
    public unsafe virtual float GetScarecrowChatterInterval()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScarecrowChatterInterval, "BmGame.RSeqAct_ChatterBoxBase.GetScarecrowChatterInterval");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsLowUrgencyObjectiveActive;
    /// <summary>
    /// Function: IsLowUrgencyObjectiveActive
    /// </summary>
    public unsafe virtual bool IsLowUrgencyObjectiveActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLowUrgencyObjectiveActive, "BmGame.RSeqAct_ChatterBoxBase.IsLowUrgencyObjectiveActive");
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

    private static BmSDK.Function __fn_LogNoChatterFound;
    /// <summary>
    /// Function: LogNoChatterFound
    /// </summary>
    public unsafe virtual void LogNoChatterFound(BmSDK.BmGame.RBarkFlagBase BarkFlags, BmSDK.Engine.Actor subjectActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogNoChatterFound, "BmGame.RSeqAct_ChatterBoxBase.LogNoChatterFound");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkFlags, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(subjectActor, paramsPtr + 8);
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

    private static BmSDK.Function __fn_TryTriggerHelicopterChatter;
    /// <summary>
    /// Function: TryTriggerHelicopterChatter
    /// </summary>
    public unsafe virtual bool TryTriggerHelicopterChatter(bool bBMChatterOnly)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryTriggerHelicopterChatter, "BmGame.RSeqAct_ChatterBoxBase.TryTriggerHelicopterChatter");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBMChatterOnly, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TryTriggerRiddlerBillboardChatter;
    /// <summary>
    /// Function: TryTriggerRiddlerBillboardChatter
    /// </summary>
    public unsafe virtual bool TryTriggerRiddlerBillboardChatter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryTriggerRiddlerBillboardChatter, "BmGame.RSeqAct_ChatterBoxBase.TryTriggerRiddlerBillboardChatter");
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

    private static BmSDK.Function __fn_TryTriggerScarecrowBillboardChatter;
    /// <summary>
    /// Function: TryTriggerScarecrowBillboardChatter
    /// </summary>
    public unsafe virtual bool TryTriggerScarecrowBillboardChatter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryTriggerScarecrowBillboardChatter, "BmGame.RSeqAct_ChatterBoxBase.TryTriggerScarecrowBillboardChatter");
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

    private static BmSDK.Function __fn_CanPawnChatter;
    /// <summary>
    /// Function: CanPawnChatter
    /// </summary>
    public unsafe virtual bool CanPawnChatter(BmSDK.BmGame.RBMPawnAI TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPawnChatter, "BmGame.RSeqAct_ChatterBoxBase.CanPawnChatter");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ArePawnsInSameGroup;
    /// <summary>
    /// Function: ArePawnsInSameGroup
    /// </summary>
    public unsafe virtual bool ArePawnsInSameGroup(BmSDK.BmGame.RSeqAct_ChatterBoxBase.FPawnChatterInfo PawnInfoA, BmSDK.BmGame.RSeqAct_ChatterBoxBase.FPawnChatterInfo PawnInfoB)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ArePawnsInSameGroup, "BmGame.RSeqAct_ChatterBoxBase.ArePawnsInSameGroup");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnInfoA, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnInfoB, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 64);
    }

    private static BmSDK.Function __fn_GroupPawns;
    /// <summary>
    /// Function: GroupPawns
    /// </summary>
    public unsafe virtual int GroupPawns()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GroupPawns, "BmGame.RSeqAct_ChatterBoxBase.GroupPawns");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GlobalCanChatterPlay_Internal;
    /// <summary>
    /// Function: GlobalCanChatterPlay_Internal
    /// </summary>
    public unsafe static BmSDK.BmGame.RSeqAct_ChatterBoxBase.GlobalChatterAvailability GlobalCanChatterPlay_Internal(bool bFirecrew)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GlobalCanChatterPlay_Internal, "BmGame.RSeqAct_ChatterBoxBase.GlobalCanChatterPlay_Internal");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFirecrew, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSeqAct_ChatterBoxBase.GlobalChatterAvailability>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GroupAndScorePawns;
    /// <summary>
    /// Function: GroupAndScorePawns
    /// </summary>
    public unsafe virtual bool GroupAndScorePawns()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GroupAndScorePawns, "BmGame.RSeqAct_ChatterBoxBase.GroupAndScorePawns");
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

    private static BmSDK.Function __fn_GetAllValidPawnsInRange;
    /// <summary>
    /// Function: GetAllValidPawnsInRange
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RSeqAct_ChatterBoxBase.FPawnChatterInfo> GetAllValidPawnsInRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAllValidPawnsInRange, "BmGame.RSeqAct_ChatterBoxBase.GetAllValidPawnsInRange");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RSeqAct_ChatterBoxBase.FPawnChatterInfo>>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateTimers;
    /// <summary>
    /// Function: UpdateTimers
    /// </summary>
    public unsafe virtual void UpdateTimers(float DeltaTime, bool bGlobalLock, bool bAnyoneSpeaking, bool bThugTimerPaused, bool bThugTimerPausedByManbatOnly, bool bInActivePredVol)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTimers, "BmGame.RSeqAct_ChatterBoxBase.UpdateTimers");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGlobalLock, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAnyoneSpeaking, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThugTimerPaused, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThugTimerPausedByManbatOnly, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInActivePredVol, paramsPtr + 20);
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

    private static BmSDK.Function __fn_Update_Native;
    /// <summary>
    /// Function: Update_Native
    /// </summary>
    public unsafe virtual bool Update_Native(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Update_Native, "BmGame.RSeqAct_ChatterBoxBase.Update_Native");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetHighestPlayingSpeechPriority_IgnoreManbat;
    /// <summary>
    /// Function: GetHighestPlayingSpeechPriority_IgnoreManbat
    /// </summary>
    public unsafe virtual int GetHighestPlayingSpeechPriority_IgnoreManbat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHighestPlayingSpeechPriority_IgnoreManbat, "BmGame.RSeqAct_ChatterBoxBase.GetHighestPlayingSpeechPriority_IgnoreManbat");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetThugChatterTimer;
    /// <summary>
    /// Function: ResetThugChatterTimer
    /// </summary>
    public unsafe virtual void ResetThugChatterTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetThugChatterTimer, "BmGame.RSeqAct_ChatterBoxBase.ResetThugChatterTimer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
    /// Enum: GlobalChatterAvailability
    /// </summary>
    public enum GlobalChatterAvailability : byte
    {
        eGCA_None = 0,
        eGCA_ChopperBMChatterOnly = 1,
        eGCA_Full = 2,
        eGCA_MAX = 3,
    }

    /// <summary>
    /// Struct: FPawnChatterGroup
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FPawnChatterGroup
    {
        /// <summary>
        /// ArrayProperty: pawnChatterInfos
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_ChatterBoxBase.FPawnChatterInfo> pawnChatterInfos
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_ChatterBoxBase.FPawnChatterInfo>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Score
        /// </summary>
        public unsafe float Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FPawnChatterInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FPawnChatterInfo
    {
        /// <summary>
        /// ObjectProperty: Pawn
        /// </summary>
        public unsafe BmSDK.Engine.Pawn Pawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: PlayerDistSq
        /// </summary>
        public unsafe float PlayerDistSq
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: activityType
        /// </summary>
        public unsafe BmSDK.BmGame.RSeqAct_ChatterBoxBase.PawnChatterActivityType activityType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_ChatterBoxBase.PawnChatterActivityType>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: Vehicle
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleNPC Vehicle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: wandererGroup
        /// </summary>
        public unsafe int wandererGroup
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: Group
        /// </summary>
        public unsafe int Group
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Enum: PawnChatterActivityType
    /// </summary>
    public enum PawnChatterActivityType : byte
    {
        ePCAT_None = 0,
        ePCAT_Riot = 1,
        ePCAT_Wander = 2,
        ePCAT_Car = 3,
        ePCAT_MAX = 4,
    }

    /// <summary>
    /// BoolProperty: bDrawDebug
    /// </summary>
    public unsafe bool bDrawDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bRunning
    /// </summary>
    public unsafe bool bRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bHUDActivated
    /// </summary>
    public unsafe bool bHUDActivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bAllowedIndoors
    /// </summary>
    public unsafe bool bAllowedIndoors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: onlyTriggerVideoChatterIfBillboardsVisible
    /// </summary>
    public unsafe bool onlyTriggerVideoChatterIfBillboardsVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bSpecialCaseReduceRiddlerTimer
    /// </summary>
    public unsafe bool bSpecialCaseReduceRiddlerTimer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bKismetDialoguePending
    /// </summary>
    public unsafe bool bKismetDialoguePending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bLowUrgencyObjectivePreviouslyActive
    /// </summary>
    public unsafe bool bLowUrgencyObjectivePreviouslyActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bLowUrgencyObjectiveActive
    /// </summary>
    public unsafe bool bLowUrgencyObjectiveActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bRiddlerSpokenSinceLowUrgency
    /// </summary>
    public unsafe bool bRiddlerSpokenSinceLowUrgency
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: lastSuccessfulTriggerWasConversation
    /// </summary>
    public unsafe bool lastSuccessfulTriggerWasConversation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bRiddlerRecentlyRejected
    /// </summary>
    public unsafe bool bRiddlerRecentlyRejected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bScarecrowRecentlyRejected
    /// </summary>
    public unsafe bool bScarecrowRecentlyRejected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: cachedSacrificeRoomRevealedState
    /// </summary>
    public unsafe bool cachedSacrificeRoomRevealedState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: cachedIsKnightfall
    /// </summary>
    public unsafe bool cachedIsKnightfall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// FloatProperty: MaxDistFromPlayer
    /// </summary>
    public unsafe float MaxDistFromPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// FloatProperty: MaxDistBetweenThugsInAGroup
    /// </summary>
    public unsafe float MaxDistBetweenThugsInAGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// FloatProperty: SuccessCheckTimeMin
    /// </summary>
    public unsafe float SuccessCheckTimeMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// FloatProperty: SuccessCheckTimeMax
    /// </summary>
    public unsafe float SuccessCheckTimeMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// FloatProperty: FailCheckTime
    /// </summary>
    public unsafe float FailCheckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// FloatProperty: TimeTillThugChatterAllowed
    /// </summary>
    public unsafe float TimeTillThugChatterAllowed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// FloatProperty: TimeTillScarecrowAllowed
    /// </summary>
    public unsafe float TimeTillScarecrowAllowed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// FloatProperty: TimeTillRiddlerAllowed
    /// </summary>
    public unsafe float TimeTillRiddlerAllowed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// FloatProperty: TimeTillHeliChatterAllowed
    /// </summary>
    public unsafe float TimeTillHeliChatterAllowed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// FloatProperty: videoChatterIntervalMin
    /// </summary>
    public unsafe float videoChatterIntervalMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// FloatProperty: videoChatterIntervalMax
    /// </summary>
    public unsafe float videoChatterIntervalMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// IntProperty: videoChatterIntervalStepsFromMinToMax
    /// </summary>
    public unsafe int videoChatterIntervalStepsFromMinToMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// FloatProperty: helicopterChatterInterval
    /// </summary>
    public unsafe float helicopterChatterInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// FloatProperty: helicopterBatmanChatterInterval
    /// </summary>
    public unsafe float helicopterBatmanChatterInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// FloatProperty: riddlerChatterInitialTimer
    /// </summary>
    public unsafe float riddlerChatterInitialTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// FloatProperty: riddlerChatterSubseqeuntTimer
    /// </summary>
    public unsafe float riddlerChatterSubseqeuntTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// FloatProperty: indoorBillboardChatterBumpTime
    /// </summary>
    public unsafe float indoorBillboardChatterBumpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// FloatProperty: lastHeliBMChatterTime
    /// </summary>
    public unsafe float lastHeliBMChatterTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// FloatProperty: specialCaseReducedRiddlerInterval
    /// </summary>
    public unsafe float specialCaseReducedRiddlerInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ObjectProperty: scarecrowBillboardConvo
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_PlayRadioOrThoughtDialogue scarecrowBillboardConvo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_PlayRadioOrThoughtDialogue>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ObjectProperty: ContextFlags
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkFlagBase ContextFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkFlagBase>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPawn
    /// </summary>
    public unsafe BmSDK.Engine.Pawn PlayerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ObjectProperty: BMCurrentPredVol
    /// </summary>
    public unsafe BmSDK.BmGame.RPredatorVolume BMCurrentPredVol
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPredatorVolume>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// FloatProperty: lastRiddlerRejectTime
    /// </summary>
    public unsafe float lastRiddlerRejectTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// FloatProperty: lastScarecrowRejectTime
    /// </summary>
    public unsafe float lastScarecrowRejectTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// StrProperty: lastTriggeredDialogue
    /// </summary>
    public unsafe BmSDK.FString lastTriggeredDialogue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// FloatProperty: lastDialogueTriggerTime
    /// </summary>
    public unsafe float lastDialogueTriggerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// ArrayProperty: lastThugDialogueFailDbgInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> lastThugDialogueFailDbgInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// FloatProperty: lastThugDialogueFailTime
    /// </summary>
    public unsafe float lastThugDialogueFailTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ArrayProperty: sortedGroupList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_ChatterBoxBase.FPawnChatterGroup> sortedGroupList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_ChatterBoxBase.FPawnChatterGroup>>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ArrayProperty: AllValidPawns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_ChatterBoxBase.FPawnChatterInfo> AllValidPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_ChatterBoxBase.FPawnChatterInfo>>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ArrayProperty: ChosenPawns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_ChatterBoxBase.FPawnChatterInfo> ChosenPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_ChatterBoxBase.FPawnChatterInfo>>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// FloatProperty: globalBlockLockoutDuration
    /// </summary>
    public unsafe float globalBlockLockoutDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// FloatProperty: manbatThugChatLockoutDuration
    /// </summary>
    public unsafe float manbatThugChatLockoutDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// IntProperty: OneShotChatterBasePriority
    /// </summary>
    public unsafe int OneShotChatterBasePriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// IntProperty: MultiLineChatterBasePriority
    /// </summary>
    public unsafe int MultiLineChatterBasePriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// StructProperty: BMLastLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BMLastLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 600);

    /// <summary>
    /// FloatProperty: stoodStillTimeExtra
    /// </summary>
    public unsafe float stoodStillTimeExtra
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// FloatProperty: maxTimerIncreaseFromStayingStill
    /// </summary>
    public unsafe float maxTimerIncreaseFromStayingStill
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// FloatProperty: cachedLastVideoScreenTakeoverTime
    /// </summary>
    public unsafe float cachedLastVideoScreenTakeoverTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// IntProperty: cachedChapterNumber
    /// </summary>
    public unsafe int cachedChapterNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }
}
