#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: AkDialogue<br/>
/// (size = 148)
/// (flags = 134217875)
/// </summary>
public partial class AkDialogue : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkDialogue", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as AkDialogue.
    /// </summary>
    public static AkDialogue DefaultObject => (AkDialogue)StaticClass().DefaultObject;

    internal AkDialogue() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkDialogue(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkDialogue>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkDialogue>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkDialogue>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkDialogue>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkDialogue>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkDialogue>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkDialogue>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkDialogue>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetDialogueSubtitle;
    /// <summary>
    /// Function: GetDialogueSubtitle
    /// </summary>
    public unsafe static BmSDK.FString GetDialogueSubtitle(BmSDK.Engine.AkDialogueLine dlgLine, BmSDK.Engine.AkDialogueEvent dlgEvent, BmSDK.Engine.Actor dlgSpeaker, out float subDur)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDialogueSubtitle, "Engine.AkDialogue.GetDialogueSubtitle");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgEvent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeaker, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out subDur);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(subDur, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        subDur = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetGauntletMeter;
    /// <summary>
    /// Function: GetGauntletMeter
    /// </summary>
    public unsafe static float GetGauntletMeter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGauntletMeter, "Engine.AkDialogue.GetGauntletMeter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSurveillanceMeter;
    /// <summary>
    /// Function: GetSurveillanceMeter
    /// </summary>
    public unsafe static float GetSurveillanceMeter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSurveillanceMeter, "Engine.AkDialogue.GetSurveillanceMeter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDialogueMeter;
    /// <summary>
    /// Function: GetDialogueMeter
    /// </summary>
    public unsafe static float GetDialogueMeter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDialogueMeter, "Engine.AkDialogue.GetDialogueMeter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AllowAnimOnlyDialogue;
    /// <summary>
    /// Function: AllowAnimOnlyDialogue
    /// </summary>
    public unsafe static void AllowAnimOnlyDialogue(bool dlgAllowed, BmSDK.FString strDebug = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowAnimOnlyDialogue, "Engine.AkDialogue.AllowAnimOnlyDialogue");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgAllowed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(strDebug, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_IsAnimOnlyDialogueAllowed;
    /// <summary>
    /// Function: IsAnimOnlyDialogueAllowed
    /// </summary>
    public unsafe static bool IsAnimOnlyDialogueAllowed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAnimOnlyDialogueAllowed, "Engine.AkDialogue.IsAnimOnlyDialogueAllowed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSurveillanceFocus;
    /// <summary>
    /// Function: GetSurveillanceFocus
    /// </summary>
    public unsafe static BmSDK.Engine.Actor GetSurveillanceFocus()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSurveillanceFocus, "Engine.AkDialogue.GetSurveillanceFocus");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsSurveillanceUIVisible;
    /// <summary>
    /// Function: IsSurveillanceUIVisible
    /// </summary>
    public unsafe static bool IsSurveillanceUIVisible()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSurveillanceUIVisible, "Engine.AkDialogue.IsSurveillanceUIVisible");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsSurveillanceDialogueAllowed;
    /// <summary>
    /// Function: IsSurveillanceDialogueAllowed
    /// </summary>
    public unsafe static bool IsSurveillanceDialogueAllowed(bool broadcastIntercept = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSurveillanceDialogueAllowed, "Engine.AkDialogue.IsSurveillanceDialogueAllowed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(broadcastIntercept, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DisableSurveillanceDialogue;
    /// <summary>
    /// Function: DisableSurveillanceDialogue
    /// </summary>
    public unsafe static void DisableSurveillanceDialogue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableSurveillanceDialogue, "Engine.AkDialogue.DisableSurveillanceDialogue");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_EnableSurveillanceDialogue;
    /// <summary>
    /// Function: EnableSurveillanceDialogue
    /// </summary>
    public unsafe static void EnableSurveillanceDialogue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableSurveillanceDialogue, "Engine.AkDialogue.EnableSurveillanceDialogue");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_IsSurveillanceDialogueActive;
    /// <summary>
    /// Function: IsSurveillanceDialogueActive
    /// </summary>
    public unsafe static bool IsSurveillanceDialogueActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSurveillanceDialogueActive, "Engine.AkDialogue.IsSurveillanceDialogueActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetSurveillanceDialogue;
    /// <summary>
    /// Function: ResetSurveillanceDialogue
    /// </summary>
    public unsafe static void ResetSurveillanceDialogue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetSurveillanceDialogue, "Engine.AkDialogue.ResetSurveillanceDialogue");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_NotifySurveillanceDialogue;
    /// <summary>
    /// Function: NotifySurveillanceDialogue
    /// </summary>
    public unsafe static void NotifySurveillanceDialogue(BmSDK.Engine.Actor dlgSpeaker, int dlgSpeechId = default, float survMinRange = default, float survMidRange = default, float survMaxRange = default, float survDistortionRange = default, bool broadcastIntercept = default, BmSDK.FString broadcastStation = default, BmSDK.FString broadcastSpeaker = default, bool surveillanceOcclusion = default, bool interrupted = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifySurveillanceDialogue, "Engine.AkDialogue.NotifySurveillanceDialogue");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeechId, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(survMinRange, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(survMidRange, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(survMaxRange, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(survDistortionRange, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(broadcastIntercept, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(broadcastStation, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(broadcastSpeaker, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(surveillanceOcclusion, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(interrupted, paramsPtr + 68);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_NotifyFocusDialogue;
    /// <summary>
    /// Function: NotifyFocusDialogue
    /// </summary>
    public unsafe static void NotifyFocusDialogue(BmSDK.Engine.Actor dlgSpeaker, bool speakerHasFocus)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFocusDialogue, "Engine.AkDialogue.NotifyFocusDialogue");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speakerHasFocus, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_IsAudible;
    /// <summary>
    /// Function: IsAudible
    /// </summary>
    public unsafe static bool IsAudible(BmSDK.Engine.AkDialogueSpeech dlgSpeech, BmSDK.TArray<BmSDK.Engine.Actor> dlgSpeakers, bool checkLocks)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAudible, "Engine.AkDialogue.IsAudible");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeech, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeakers, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(checkLocks, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_FullReset;
    /// <summary>
    /// Function: FullReset
    /// </summary>
    public unsafe static void FullReset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FullReset, "Engine.AkDialogue.FullReset");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_IsForciblyDucked;
    /// <summary>
    /// Function: IsForciblyDucked
    /// </summary>
    public unsafe static bool IsForciblyDucked()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsForciblyDucked, "Engine.AkDialogue.IsForciblyDucked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DisableForceDucking;
    /// <summary>
    /// Function: DisableForceDucking
    /// </summary>
    public unsafe static void DisableForceDucking(bool fullyUnduck = default, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableForceDucking, "Engine.AkDialogue.DisableForceDucking");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fullyUnduck, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_EnableForceDucking;
    /// <summary>
    /// Function: EnableForceDucking
    /// </summary>
    public unsafe static void EnableForceDucking(bool fullyDuck = default, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableForceDucking, "Engine.AkDialogue.EnableForceDucking");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fullyDuck, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_ResetDuckingInfo;
    /// <summary>
    /// Function: ResetDuckingInfo
    /// </summary>
    public unsafe static void ResetDuckingInfo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetDuckingInfo, "Engine.AkDialogue.ResetDuckingInfo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_SetDuckingInfo;
    /// <summary>
    /// Function: SetDuckingInfo
    /// </summary>
    public unsafe static void SetDuckingInfo(BmSDK.Engine.AkDialogue.FAkDuckingInfo dckInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDuckingInfo, "Engine.AkDialogue.SetDuckingInfo");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dckInfo, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_GetDuckingInfo;
    /// <summary>
    /// Function: GetDuckingInfo
    /// </summary>
    public unsafe static BmSDK.Engine.AkDialogue.FAkDuckingInfo GetDuckingInfo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDuckingInfo, "Engine.AkDialogue.GetDuckingInfo");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogue.FAkDuckingInfo>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsSpeechPlaying_SuppressPrompts;
    /// <summary>
    /// Function: IsSpeechPlaying_SuppressPrompts
    /// </summary>
    public unsafe static bool IsSpeechPlaying_SuppressPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSpeechPlaying_SuppressPrompts, "Engine.AkDialogue.IsSpeechPlaying_SuppressPrompts");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsSpeechPlaying_Persistent;
    /// <summary>
    /// Function: IsSpeechPlaying_Persistent
    /// </summary>
    public unsafe static bool IsSpeechPlaying_Persistent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSpeechPlaying_Persistent, "Engine.AkDialogue.IsSpeechPlaying_Persistent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsSpeechPlaying_Instance;
    /// <summary>
    /// Function: IsSpeechPlaying_Instance
    /// </summary>
    public unsafe static bool IsSpeechPlaying_Instance(int dlgSpeechId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSpeechPlaying_Instance, "Engine.AkDialogue.IsSpeechPlaying_Instance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeechId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsSpeechPlaying_TypeId;
    /// <summary>
    /// Function: IsSpeechPlaying_TypeId
    /// </summary>
    public unsafe static bool IsSpeechPlaying_TypeId(BmSDK.Engine.AkDialogueType dlgType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSpeechPlaying_TypeId, "Engine.AkDialogue.IsSpeechPlaying_TypeId");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgType, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsSpeechPlaying_VoiceId;
    /// <summary>
    /// Function: IsSpeechPlaying_VoiceId
    /// </summary>
    public unsafe static bool IsSpeechPlaying_VoiceId(BmSDK.Engine.AkDialogueVoice dlgVoice)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSpeechPlaying_VoiceId, "Engine.AkDialogue.IsSpeechPlaying_VoiceId");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgVoice, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsSpeechPlaying;
    /// <summary>
    /// Function: IsSpeechPlaying
    /// </summary>
    public unsafe static bool IsSpeechPlaying()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSpeechPlaying, "Engine.AkDialogue.IsSpeechPlaying");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopSpeech_All;
    /// <summary>
    /// Function: StopSpeech_All
    /// </summary>
    public unsafe static void StopSpeech_All(BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSpeech_All, "Engine.AkDialogue.StopSpeech_All");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StopSpeech_SuppressPrompts;
    /// <summary>
    /// Function: StopSpeech_SuppressPrompts
    /// </summary>
    public unsafe static void StopSpeech_SuppressPrompts(BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSpeech_SuppressPrompts, "Engine.AkDialogue.StopSpeech_SuppressPrompts");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StopSpeech_Persistent;
    /// <summary>
    /// Function: StopSpeech_Persistent
    /// </summary>
    public unsafe static void StopSpeech_Persistent(BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSpeech_Persistent, "Engine.AkDialogue.StopSpeech_Persistent");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StopSpeech_Emotes;
    /// <summary>
    /// Function: StopSpeech_Emotes
    /// </summary>
    public unsafe static void StopSpeech_Emotes(BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSpeech_Emotes, "Engine.AkDialogue.StopSpeech_Emotes");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StopSpeech_TypeId;
    /// <summary>
    /// Function: StopSpeech_TypeId
    /// </summary>
    public unsafe static void StopSpeech_TypeId(BmSDK.Engine.AkDialogueType dlgType, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSpeech_TypeId, "Engine.AkDialogue.StopSpeech_TypeId");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StopSpeech_VoiceId;
    /// <summary>
    /// Function: StopSpeech_VoiceId
    /// </summary>
    public unsafe static void StopSpeech_VoiceId(BmSDK.Engine.AkDialogueVoice dlgVoice, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSpeech_VoiceId, "Engine.AkDialogue.StopSpeech_VoiceId");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgVoice, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StopSpeech_Speakers;
    /// <summary>
    /// Function: StopSpeech_Speakers
    /// </summary>
    public unsafe static void StopSpeech_Speakers(BmSDK.TArray<BmSDK.Engine.Actor> dlgSpeakers, bool exceptEmotes = default, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSpeech_Speakers, "Engine.AkDialogue.StopSpeech_Speakers");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeakers, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(exceptEmotes, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StopSpeech_Speech;
    /// <summary>
    /// Function: StopSpeech_Speech
    /// </summary>
    public unsafe static void StopSpeech_Speech(BmSDK.Engine.AkDialogueSpeech dlgSpeech, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSpeech_Speech, "Engine.AkDialogue.StopSpeech_Speech");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeech, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StopSpeech;
    /// <summary>
    /// Function: StopSpeech
    /// </summary>
    public unsafe static void StopSpeech(int speechId, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSpeech, "Engine.AkDialogue.StopSpeech");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StartSpeechGlobal;
    /// <summary>
    /// Function: StartSpeechGlobal
    /// </summary>
    public unsafe static int StartSpeechGlobal(BmSDK.Engine.AkDialogueSpeech dlgSpeech, out BmSDK.Engine.AkDialogue.FAkSpeechOptions dlgOpts, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSpeechGlobal, "Engine.AkDialogue.StartSpeechGlobal");
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeech, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 124);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        dlgOpts = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogue.FAkSpeechOptions>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_StartSpeech;
    /// <summary>
    /// Function: StartSpeech
    /// </summary>
    public unsafe static int StartSpeech(BmSDK.Engine.AkDialogueSpeech dlgSpeech, BmSDK.TArray<BmSDK.Engine.Actor> dlgSpeakers, out BmSDK.Engine.AkDialogue.FAkSpeechOptions dlgOpts, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSpeech, "Engine.AkDialogue.StartSpeech");
        byte* paramsPtr = stackalloc byte[176];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeech, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeakers, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 140);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        dlgOpts = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogue.FAkSpeechOptions>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 156);
    }

    private static BmSDK.Function __fn_IsVoiceLocked;
    /// <summary>
    /// Function: IsVoiceLocked
    /// </summary>
    public unsafe static bool IsVoiceLocked(BmSDK.Engine.AkDialogueVoice dlgVoice)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVoiceLocked, "Engine.AkDialogue.IsVoiceLocked");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgVoice, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsTypeLocked;
    /// <summary>
    /// Function: IsTypeLocked
    /// </summary>
    public unsafe static bool IsTypeLocked(BmSDK.Engine.AkDialogueType dlgType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTypeLocked, "Engine.AkDialogue.IsTypeLocked");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgType, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UnlockAllTypes;
    /// <summary>
    /// Function: UnlockAllTypes
    /// </summary>
    public unsafe static void UnlockAllTypes()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockAllTypes, "Engine.AkDialogue.UnlockAllTypes");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_UnlockType;
    /// <summary>
    /// Function: UnlockType
    /// </summary>
    public unsafe static void UnlockType(BmSDK.Engine.AkDialogueType dlgType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockType, "Engine.AkDialogue.UnlockType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgType, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_LockType;
    /// <summary>
    /// Function: LockType
    /// </summary>
    public unsafe static void LockType(BmSDK.Engine.AkDialogueType dlgType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LockType, "Engine.AkDialogue.LockType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgType, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_UnlockAllVoices;
    /// <summary>
    /// Function: UnlockAllVoices
    /// </summary>
    public unsafe static void UnlockAllVoices()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockAllVoices, "Engine.AkDialogue.UnlockAllVoices");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_UnlockVoice;
    /// <summary>
    /// Function: UnlockVoice
    /// </summary>
    public unsafe static void UnlockVoice(BmSDK.Engine.AkDialogueVoice dlgVoice, bool full = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockVoice, "Engine.AkDialogue.UnlockVoice");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgVoice, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(full, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_LockVoice;
    /// <summary>
    /// Function: LockVoice
    /// </summary>
    public unsafe static void LockVoice(BmSDK.Engine.AkDialogueVoice dlgVoice)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LockVoice, "Engine.AkDialogue.LockVoice");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgVoice, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_PlayerChanged;
    /// <summary>
    /// Function: PlayerChanged
    /// </summary>
    public unsafe static void PlayerChanged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerChanged, "Engine.AkDialogue.PlayerChanged");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_JumpToSpeechLine;
    /// <summary>
    /// Function: JumpToSpeechLine
    /// </summary>
    public unsafe static void JumpToSpeechLine(int speechId, int lineIdx, float fadeTime = default, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JumpToSpeechLine, "Engine.AkDialogue.JumpToSpeechLine");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(lineIdx, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fadeTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_SkipSpeechLine;
    /// <summary>
    /// Function: SkipSpeechLine
    /// </summary>
    public unsafe static void SkipSpeechLine(int speechId, float fadeTime = default, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SkipSpeechLine, "Engine.AkDialogue.SkipSpeechLine");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fadeTime, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_InterruptSpeech_Type;
    /// <summary>
    /// Function: InterruptSpeech_Type
    /// </summary>
    public unsafe static void InterruptSpeech_Type(BmSDK.Engine.AkDialogueType dlgType, float fadeTime = default, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterruptSpeech_Type, "Engine.AkDialogue.InterruptSpeech_Type");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fadeTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_InterruptSpeech_Speech;
    /// <summary>
    /// Function: InterruptSpeech_Speech
    /// </summary>
    public unsafe static void InterruptSpeech_Speech(BmSDK.Engine.AkDialogueSpeech dlgSpeech, float fadeTime = default, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterruptSpeech_Speech, "Engine.AkDialogue.InterruptSpeech_Speech");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeech, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fadeTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_InterruptSpeech_Id;
    /// <summary>
    /// Function: InterruptSpeech_Id
    /// </summary>
    public unsafe static void InterruptSpeech_Id(int speechId, float fadeTime = default, BmSDK.FString dlgTag = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterruptSpeech_Id, "Engine.AkDialogue.InterruptSpeech_Id");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fadeTime, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgTag, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_CancelSpeechCallbacks;
    /// <summary>
    /// Function: CancelSpeechCallbacks
    /// </summary>
    public unsafe static void CancelSpeechCallbacks(BmSDK.GameObject Obj)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelSpeechCallbacks, "Engine.AkDialogue.CancelSpeechCallbacks");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obj, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_ChangeSpeechOption_DisableSubtitles;
    /// <summary>
    /// Function: ChangeSpeechOption_DisableSubtitles
    /// </summary>
    public unsafe static void ChangeSpeechOption_DisableSubtitles(int speechId, bool Disable)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeSpeechOption_DisableSubtitles, "Engine.AkDialogue.ChangeSpeechOption_DisableSubtitles");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Disable, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_ChangeSpeechOption_WaitForNotifies;
    /// <summary>
    /// Function: ChangeSpeechOption_WaitForNotifies
    /// </summary>
    public unsafe static void ChangeSpeechOption_WaitForNotifies(int speechId, bool wait)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeSpeechOption_WaitForNotifies, "Engine.AkDialogue.ChangeSpeechOption_WaitForNotifies");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(wait, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_IsSpeechWaitingForNotifies;
    /// <summary>
    /// Function: IsSpeechWaitingForNotifies
    /// </summary>
    public unsafe static bool IsSpeechWaitingForNotifies(int speechId, bool waitingNow)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSpeechWaitingForNotifies, "Engine.AkDialogue.IsSpeechWaitingForNotifies");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(waitingNow, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CheckSpeechChapterFlags;
    /// <summary>
    /// Function: CheckSpeechChapterFlags
    /// </summary>
    public unsafe static bool CheckSpeechChapterFlags(BmSDK.Engine.AkDialogueSpeech dlgSpeech, bool checkAll = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckSpeechChapterFlags, "Engine.AkDialogue.CheckSpeechChapterFlags");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeech, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(checkAll, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetSpeechMinMaxDuration;
    /// <summary>
    /// Function: GetSpeechMinMaxDuration
    /// </summary>
    public unsafe static void GetSpeechMinMaxDuration(BmSDK.Engine.AkDialogueSpeech dlgSpeech, out float minDur, out float maxDur)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpeechMinMaxDuration, "Engine.AkDialogue.GetSpeechMinMaxDuration");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeech, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out minDur);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(minDur, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out maxDur);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(maxDur, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        minDur = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        maxDur = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetAverageNoSpeechInterval;
    /// <summary>
    /// Function: GetAverageNoSpeechInterval
    /// </summary>
    public unsafe static float GetAverageNoSpeechInterval()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAverageNoSpeechInterval, "Engine.AkDialogue.GetAverageNoSpeechInterval");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAverageSpeechInterval;
    /// <summary>
    /// Function: GetAverageSpeechInterval
    /// </summary>
    public unsafe static float GetAverageSpeechInterval()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAverageSpeechInterval, "Engine.AkDialogue.GetAverageSpeechInterval");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTimeSinceAnySpeech;
    /// <summary>
    /// Function: GetTimeSinceAnySpeech
    /// </summary>
    public unsafe static float GetTimeSinceAnySpeech()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeSinceAnySpeech, "Engine.AkDialogue.GetTimeSinceAnySpeech");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSpeechCurrentLineIndex;
    /// <summary>
    /// Function: GetSpeechCurrentLineIndex
    /// </summary>
    public unsafe static int GetSpeechCurrentLineIndex(int speechId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpeechCurrentLineIndex, "Engine.AkDialogue.GetSpeechCurrentLineIndex");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetSpeechElapsedTime;
    /// <summary>
    /// Function: GetSpeechElapsedTime
    /// </summary>
    public unsafe static float GetSpeechElapsedTime(int speechId, bool currentLineOnly = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpeechElapsedTime, "Engine.AkDialogue.GetSpeechElapsedTime");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(currentLineOnly, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetSpeechPriority;
    /// <summary>
    /// Function: GetSpeechPriority
    /// </summary>
    public unsafe static bool GetSpeechPriority(BmSDK.Engine.AkDialogueSpeech dlgSpeech, out BmSDK.Engine.AkDialogue.FAkSpeechOptions dlgOpts, bool dlgForPlayer, out int dlgPriority)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpeechPriority, "Engine.AkDialogue.GetSpeechPriority");
        byte* paramsPtr = stackalloc byte[152];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeech, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgForPlayer, paramsPtr + 124);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out dlgPriority);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgPriority, paramsPtr + 128);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        dlgOpts = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogue.FAkSpeechOptions>(paramsPtr + 8);
        dlgPriority = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 128);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 132);
    }

    private static BmSDK.Function __fn_GetHighestActiveSpeechPriority;
    /// <summary>
    /// Function: GetHighestActiveSpeechPriority
    /// </summary>
    public unsafe static int GetHighestActiveSpeechPriority(bool dlgExceptEmotes = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHighestActiveSpeechPriority, "Engine.AkDialogue.GetHighestActiveSpeechPriority");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgExceptEmotes, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCurrentSpeechInstances;
    /// <summary>
    /// Function: GetCurrentSpeechInstances
    /// </summary>
    public unsafe static int GetCurrentSpeechInstances()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentSpeechInstances, "Engine.AkDialogue.GetCurrentSpeechInstances");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMaxSpeechInstances;
    /// <summary>
    /// Function: GetMaxSpeechInstances
    /// </summary>
    public unsafe static int GetMaxSpeechInstances()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxSpeechInstances, "Engine.AkDialogue.GetMaxSpeechInstances");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetMaxSpeechInstances;
    /// <summary>
    /// Function: ResetMaxSpeechInstances
    /// </summary>
    public unsafe static void ResetMaxSpeechInstances()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetMaxSpeechInstances, "Engine.AkDialogue.ResetMaxSpeechInstances");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_SetMaxSpeechInstances;
    /// <summary>
    /// Function: SetMaxSpeechInstances
    /// </summary>
    public unsafe static void SetMaxSpeechInstances(int maxSpeechInstances)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMaxSpeechInstances, "Engine.AkDialogue.SetMaxSpeechInstances");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(maxSpeechInstances, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_AkDialogueCallback_OnStopDialogueLine;
    /// <summary>
    /// Function: AkDialogueCallback_OnStopDialogueLine
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkDialogue.AkDialogueCallbackResult AkDialogueCallback_OnStopDialogueLine(BmSDK.Engine.AkDialogueLine dlgLine, BmSDK.Engine.AkDialogueEvent dlgEvent, BmSDK.GameObject dlgSpeaker, bool interrupted)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AkDialogueCallback_OnStopDialogueLine, "Engine.AkDialogue.AkDialogueCallback_OnStopDialogueLine");
        byte* paramsPtr = stackalloc byte[45];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgEvent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeaker, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(interrupted, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogue.AkDialogueCallbackResult>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_AkDialogueCallback_OnStartDialogueLine;
    /// <summary>
    /// Function: AkDialogueCallback_OnStartDialogueLine
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkDialogue.AkDialogueCallbackResult AkDialogueCallback_OnStartDialogueLine(BmSDK.Engine.AkDialogueLine dlgLine, BmSDK.Engine.AkDialogueEvent dlgEvent, BmSDK.GameObject dlgSpeaker, bool isBarkSquelch)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AkDialogueCallback_OnStartDialogueLine, "Engine.AkDialogue.AkDialogueCallback_OnStartDialogueLine");
        byte* paramsPtr = stackalloc byte[45];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgEvent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeaker, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isBarkSquelch, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogue.AkDialogueCallbackResult>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_AkDialogueCallback_OnStopSpeech;
    /// <summary>
    /// Function: AkDialogueCallback_OnStopSpeech
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkDialogue.AkDialogueCallbackResult AkDialogueCallback_OnStopSpeech(int speechId, bool interrupted)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AkDialogueCallback_OnStopSpeech, "Engine.AkDialogue.AkDialogueCallback_OnStopSpeech");
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(interrupted, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogue.AkDialogueCallbackResult>(paramsPtr + 8);
    }

    /// <summary>
    /// DelegateProperty: __AkDialogueCallback_OnStartSpeech__Delegate
    /// </summary>
    public unsafe System.IntPtr __AkDialogueCallback_OnStartSpeech__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// DelegateProperty: __AkDialogueCallback_OnStopSpeech__Delegate
    /// </summary>
    public unsafe System.IntPtr __AkDialogueCallback_OnStopSpeech__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// DelegateProperty: __AkDialogueCallback_OnStartDialogueLine__Delegate
    /// </summary>
    public unsafe System.IntPtr __AkDialogueCallback_OnStartDialogueLine__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// DelegateProperty: __AkDialogueCallback_OnStopDialogueLine__Delegate
    /// </summary>
    public unsafe System.IntPtr __AkDialogueCallback_OnStopDialogueLine__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    private static BmSDK.Function __fn_AkDialogueCallback_OnStartSpeech;
    /// <summary>
    /// Function: AkDialogueCallback_OnStartSpeech
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkDialogue.AkDialogueCallbackResult AkDialogueCallback_OnStartSpeech(int speechId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AkDialogueCallback_OnStartSpeech, "Engine.AkDialogue.AkDialogueCallback_OnStartSpeech");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogue.AkDialogueCallbackResult>(paramsPtr + 4);
    }

    /// <summary>
    /// Struct: FAkDialogueCallbackInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FAkDialogueCallbackInfo
    {
        /// <summary>
        /// IntProperty: SpeechInstanceId
        /// </summary>
        public unsafe int SpeechInstanceId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: LineIndex
        /// </summary>
        public unsafe int LineIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FAkDuckingInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FAkDuckingInfo
    {
        /// <summary>
        /// IntProperty: DuckingLevels
        /// </summary>
        public unsafe int DuckingLevels
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: DuckAttackTime
        /// </summary>
        public unsafe float DuckAttackTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: DuckReleaseTime
        /// </summary>
        public unsafe float DuckReleaseTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: FullyDuckedValue
        /// </summary>
        public unsafe float FullyDuckedValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: FullyUnduckedValue
        /// </summary>
        public unsafe float FullyUnduckedValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: PhantomDucks
        /// </summary>
        public unsafe int PhantomDucks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FAkSpeechOptions
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 116)]
    public partial record struct FAkSpeechOptions
    {
        /// <summary>
        /// IntProperty: InstancePriorityBump
        /// </summary>
        public unsafe int InstancePriorityBump
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MinDistanceToPlayer
        /// </summary>
        public unsafe float MinDistanceToPlayer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: MaxDistanceFromPlayer
        /// </summary>
        public unsafe float MaxDistanceFromPlayer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bNoDistanceScoring
        /// </summary>
        public unsafe bool bNoDistanceScoring
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bRejectInstanceOnPriorityMatch
        /// </summary>
        public unsafe bool bRejectInstanceOnPriorityMatch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bRejectInstanceIfNotHighestPriority
        /// </summary>
        public unsafe bool bRejectInstanceIfNotHighestPriority
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bRejectInstanceIfPredBarkLockActive
        /// </summary>
        public unsafe bool bRejectInstanceIfPredBarkLockActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bRejectInstanceIfChatterDisabled
        /// </summary>
        public unsafe bool bRejectInstanceIfChatterDisabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bRejectIfInterruptsMatchingSpeech
        /// </summary>
        public unsafe bool bRejectIfInterruptsMatchingSpeech
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bRejectIfInterruptsAnySpeech
        /// </summary>
        public unsafe bool bRejectIfInterruptsAnySpeech
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bAllowIncapacitatedSpeakers
        /// </summary>
        public unsafe bool bAllowIncapacitatedSpeakers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bNoAbortIfActiveSpeakerInterrupted
        /// </summary>
        public unsafe bool bNoAbortIfActiveSpeakerInterrupted
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 256) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bNoAbortIfInactiveSpeakerInterrupted
        /// </summary>
        public unsafe bool bNoAbortIfInactiveSpeakerInterrupted
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 512) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bSubstituteGlobalSpeakers
        /// </summary>
        public unsafe bool bSubstituteGlobalSpeakers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1024) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bAllowMissingSpeakers
        /// </summary>
        public unsafe bool bAllowMissingSpeakers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 2048) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bAllowMissingVoiceForSingleLine
        /// </summary>
        public unsafe bool bAllowMissingVoiceForSingleLine
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 4096) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bAllowIncorrectVoiceForSingleLine
        /// </summary>
        public unsafe bool bAllowIncorrectVoiceForSingleLine
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 8192) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bDisableAnimation
        /// </summary>
        public unsafe bool bDisableAnimation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 16384) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bDisableAudio
        /// </summary>
        public unsafe bool bDisableAudio
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 32768) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bDisableSubtitles
        /// </summary>
        public unsafe bool bDisableSubtitles
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 65536) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bForceSubtitlesIfNewest
        /// </summary>
        public unsafe bool bForceSubtitlesIfNewest
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 131072) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bWaitForNotifies
        /// </summary>
        public unsafe bool bWaitForNotifies
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 262144) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bPreventAttachToWaitingSpeech
        /// </summary>
        public unsafe bool bPreventAttachToWaitingSpeech
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 524288) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bRequireAttachToWaitingSpeech
        /// </summary>
        public unsafe bool bRequireAttachToWaitingSpeech
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1048576) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bAllowDifferentSpeakerOnAttachToWaitingSpeech
        /// </summary>
        public unsafe bool bAllowDifferentSpeakerOnAttachToWaitingSpeech
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 2097152) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bOverrideVoiceLock
        /// </summary>
        public unsafe bool bOverrideVoiceLock
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 4194304) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bOverrideTypeLock
        /// </summary>
        public unsafe bool bOverrideTypeLock
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 8388608) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bRequireExplicitStop
        /// </summary>
        public unsafe bool bRequireExplicitStop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 16777216) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bRequirePreferredVoices
        /// </summary>
        public unsafe bool bRequirePreferredVoices
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 33554432) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bRejectIfRepetitionDisallowed
        /// </summary>
        public unsafe bool bRejectIfRepetitionDisallowed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 67108864) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bRejectIfInvalidChapterFlags
        /// </summary>
        public unsafe bool bRejectIfInvalidChapterFlags
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 134217728) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: PreferredVoices
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.AkDialogue.FAkPreferredVoice> PreferredVoices
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkDialogue.FAkPreferredVoice>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: CustomPauseFlags
        /// </summary>
        public unsafe int CustomPauseFlags
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bIgnoreEventOffset
        /// </summary>
        public unsafe bool bIgnoreEventOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// ByteProperty: StreamingPriorityOverride
        /// </summary>
        public unsafe BmSDK.Engine.AkWwise.EAkIOStreamPriorities StreamingPriorityOverride
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.EAkIOStreamPriorities>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: Callbacks
        /// </summary>
        public unsafe BmSDK.Engine.AkDialogue.FAkSpeechCallbacks Callbacks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogue.FAkSpeechCallbacks>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }

    /// <summary>
    /// Struct: FAkSpeechCallbacks
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial record struct FAkSpeechCallbacks
    {
        /// <summary>
        /// DelegateProperty: OnStartSpeech
        /// </summary>
        public unsafe System.IntPtr OnStartSpeech
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// DelegateProperty: OnStopSpeech
        /// </summary>
        public unsafe System.IntPtr OnStopSpeech
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// DelegateProperty: OnStartDialogueLine
        /// </summary>
        public unsafe System.IntPtr OnStartDialogueLine
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// DelegateProperty: OnStopDialogueLine
        /// </summary>
        public unsafe System.IntPtr OnStopDialogueLine
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StructProperty: CustomListener
        /// </summary>
        public unsafe System.IntPtr CustomListener
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Struct: FAkPreferredVoice
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FAkPreferredVoice
    {
        /// <summary>
        /// ObjectProperty: PreferredVoice
        /// </summary>
        public unsafe BmSDK.Engine.AkDialogueVoice PreferredVoice
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueVoice>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: SpeakerObject
        /// </summary>
        public unsafe BmSDK.GameObject SpeakerObject
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 8); }; }
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
    }

    /// <summary>
    /// Enum: AkDialogueVoiceEthnicity
    /// </summary>
    public enum AkDialogueVoiceEthnicity : byte
    {
        AK_VOICE_ETHNICITY_NONE = 0,
        AK_VOICE_ETHNICITY_MAX = 1,
    }

    /// <summary>
    /// Enum: AkDialogueVoiceGender
    /// </summary>
    public enum AkDialogueVoiceGender : byte
    {
        AK_VOICE_GENDER_NONE = 0,
        AK_VOICE_GENDER_MALE = 1,
        AK_VOICE_GENDER_FEMALE = 2,
        AK_VOICE_GENDER_MAX = 3,
    }

    /// <summary>
    /// Enum: AkDialogueCallbackResult
    /// </summary>
    public enum AkDialogueCallbackResult : byte
    {
        AK_SPEECH_OKAY = 0,
        AK_SPEECH_SKIP = 1,
        AK_SPEECH_DELAY = 2,
        AK_SPEECH_ABORT = 3,
        AK_SPEECH_MAX = 4,
    }
}
