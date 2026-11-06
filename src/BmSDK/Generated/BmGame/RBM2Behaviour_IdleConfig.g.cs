#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBM2Behaviour_IdleConfig<br/>
/// (size = 1032)
/// (flags = 134217874)
/// </summary>
public partial class RBM2Behaviour_IdleConfig : BmSDK.BmGame.RBMBehaviour_MoveToBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBM2Behaviour_IdleConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBM2Behaviour_IdleConfig.
    /// </summary>
    public static RBM2Behaviour_IdleConfig DefaultObject => (RBM2Behaviour_IdleConfig)StaticClass().DefaultObject;

    internal RBM2Behaviour_IdleConfig() { }

    /// <summary>
    /// Constructs a new RBM2Behaviour_IdleConfig
    /// </summary>
    public RBM2Behaviour_IdleConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBM2Behaviour_IdleConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBM2Behaviour_IdleConfig(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBM2Behaviour_IdleConfig>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBM2Behaviour_IdleConfig>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBM2Behaviour_IdleConfig>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBM2Behaviour_IdleConfig>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBM2Behaviour_IdleConfig>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBM2Behaviour_IdleConfig>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBM2Behaviour_IdleConfig>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBM2Behaviour_IdleConfig>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CanRepel;
    /// <summary>
    /// Function: CanRepel
    /// </summary>
    public unsafe override bool CanRepel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanRepel, "BmGame.RBM2Behaviour_IdleConfig.CanRepel");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBlock;
    /// <summary>
    /// Function: CanBlock
    /// </summary>
    public unsafe override bool CanBlock()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBlock, "BmGame.RBM2Behaviour_IdleConfig.CanBlock");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RandomBarkFudgeFactor;
    /// <summary>
    /// Function: RandomBarkFudgeFactor
    /// </summary>
    public unsafe override float RandomBarkFudgeFactor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RandomBarkFudgeFactor, "BmGame.RBM2Behaviour_IdleConfig.RandomBarkFudgeFactor");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayRandomBark;
    /// <summary>
    /// Function: PlayRandomBark
    /// </summary>
    public unsafe override bool PlayRandomBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayRandomBark, "BmGame.RBM2Behaviour_IdleConfig.PlayRandomBark");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GadgetNoise;
    /// <summary>
    /// Function: GadgetNoise
    /// </summary>
    public unsafe override void GadgetNoise(System.Numerics.Vector3 SafeNoiseLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetNoise, "BmGame.RBM2Behaviour_IdleConfig.GadgetNoise");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SafeNoiseLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NeedsToYieldToPredAI;
    /// <summary>
    /// Function: NeedsToYieldToPredAI
    /// </summary>
    public unsafe virtual bool NeedsToYieldToPredAI()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NeedsToYieldToPredAI, "BmGame.RBM2Behaviour_IdleConfig.NeedsToYieldToPredAI");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetThoughts;
    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe override void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmGame.RBM2Behaviour_IdleConfig.GetThoughts");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_EnterNPCDialogue;
    /// <summary>
    /// Function: EnterNPCDialogue
    /// </summary>
    public unsafe virtual void EnterNPCDialogue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterNPCDialogue, "BmGame.RBM2Behaviour_IdleConfig.EnterNPCDialogue");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitNPCDialogue;
    /// <summary>
    /// Function: ExitNPCDialogue
    /// </summary>
    public unsafe virtual void ExitNPCDialogue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitNPCDialogue, "BmGame.RBM2Behaviour_IdleConfig.ExitNPCDialogue");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDialogueLookFinalPosAndRot;
    /// <summary>
    /// Function: GetDialogueLookFinalPosAndRot
    /// </summary>
    public unsafe virtual void GetDialogueLookFinalPosAndRot(out System.Numerics.Vector3 outLoc, out BmSDK.Rotator OutRot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDialogueLookFinalPosAndRot, "BmGame.RBM2Behaviour_IdleConfig.GetDialogueLookFinalPosAndRot");
        byte* paramsPtr = stackalloc byte[44];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outLoc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutRot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutRot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        OutRot = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_PerformDialogueLook;
    /// <summary>
    /// Function: PerformDialogueLook
    /// </summary>
    public unsafe virtual void PerformDialogueLook()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PerformDialogueLook, "BmGame.RBM2Behaviour_IdleConfig.PerformDialogueLook");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SnapForDialogue;
    /// <summary>
    /// Function: SnapForDialogue
    /// </summary>
    public unsafe virtual void SnapForDialogue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SnapForDialogue, "BmGame.RBM2Behaviour_IdleConfig.SnapForDialogue");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReturnFromDialogueLook;
    /// <summary>
    /// Function: ReturnFromDialogueLook
    /// </summary>
    public unsafe virtual void ReturnFromDialogueLook()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReturnFromDialogueLook, "BmGame.RBM2Behaviour_IdleConfig.ReturnFromDialogueLook");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetIdleTime;
    /// <summary>
    /// Function: ResetIdleTime
    /// </summary>
    public unsafe virtual void ResetIdleTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetIdleTime, "BmGame.RBM2Behaviour_IdleConfig.ResetIdleTime");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayDialogueRandomAnimation;
    /// <summary>
    /// Function: PlayDialogueRandomAnimation
    /// </summary>
    public unsafe virtual void PlayDialogueRandomAnimation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDialogueRandomAnimation, "BmGame.RBM2Behaviour_IdleConfig.PlayDialogueRandomAnimation");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayRandomAnimation;
    /// <summary>
    /// Function: PlayRandomAnimation
    /// </summary>
    public unsafe virtual void PlayRandomAnimation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayRandomAnimation, "BmGame.RBM2Behaviour_IdleConfig.PlayRandomAnimation");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayStartedAnimation;
    /// <summary>
    /// Function: PlayStartedAnimation
    /// </summary>
    public unsafe override void PlayStartedAnimation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayStartedAnimation, "BmGame.RBM2Behaviour_IdleConfig.PlayStartedAnimation");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNewTimeForDialogueRandomAnimation;
    /// <summary>
    /// Function: GetNewTimeForDialogueRandomAnimation
    /// </summary>
    public unsafe virtual float GetNewTimeForDialogueRandomAnimation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNewTimeForDialogueRandomAnimation, "BmGame.RBM2Behaviour_IdleConfig.GetNewTimeForDialogueRandomAnimation");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNewTimeForRandomAnimation;
    /// <summary>
    /// Function: GetNewTimeForRandomAnimation
    /// </summary>
    public unsafe virtual float GetNewTimeForRandomAnimation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNewTimeForRandomAnimation, "BmGame.RBM2Behaviour_IdleConfig.GetNewTimeForRandomAnimation");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayEventAnimation;
    /// <summary>
    /// Function: PlayEventAnimation
    /// </summary>
    public unsafe virtual void PlayEventAnimation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayEventAnimation, "BmGame.RBM2Behaviour_IdleConfig.PlayEventAnimation");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginExit;
    /// <summary>
    /// Function: BeginExit
    /// </summary>
    public unsafe virtual void BeginExit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginExit, "BmGame.RBM2Behaviour_IdleConfig.BeginExit");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NextBehaviourIsAChainedIdle;
    /// <summary>
    /// Function: NextBehaviourIsAChainedIdle
    /// </summary>
    public unsafe virtual bool NextBehaviourIsAChainedIdle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NextBehaviourIsAChainedIdle, "BmGame.RBM2Behaviour_IdleConfig.NextBehaviourIsAChainedIdle");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayNonAlignedIdle;
    /// <summary>
    /// Function: PlayNonAlignedIdle
    /// </summary>
    public unsafe virtual void PlayNonAlignedIdle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayNonAlignedIdle, "BmGame.RBM2Behaviour_IdleConfig.PlayNonAlignedIdle");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayAlignedIdle;
    /// <summary>
    /// Function: PlayAlignedIdle
    /// </summary>
    public unsafe virtual void PlayAlignedIdle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAlignedIdle, "BmGame.RBM2Behaviour_IdleConfig.PlayAlignedIdle");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayNonAlignedTransitionIn;
    /// <summary>
    /// Function: PlayNonAlignedTransitionIn
    /// </summary>
    public unsafe virtual void PlayNonAlignedTransitionIn(BmSDK.FName TransInAnim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayNonAlignedTransitionIn, "BmGame.RBM2Behaviour_IdleConfig.PlayNonAlignedTransitionIn");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransInAnim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayLinkedTransition;
    /// <summary>
    /// Function: PlayLinkedTransition
    /// </summary>
    public unsafe virtual void PlayLinkedTransition(BmSDK.BmGame.RPawnCharacter MasterActor, BmSDK.FName TransitionIn, BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId transID, bool bAllowAimAt, bool bFakeTransOut = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayLinkedTransition, "BmGame.RBM2Behaviour_IdleConfig.PlayLinkedTransition");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MasterActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionIn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(transID, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowAimAt, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFakeTransOut, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlayLinkedTransition;
    /// <summary>
    /// Function: CanPlayLinkedTransition
    /// </summary>
    public unsafe virtual bool CanPlayLinkedTransition(BmSDK.FName TransitionAnim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayLinkedTransition, "BmGame.RBM2Behaviour_IdleConfig.CanPlayLinkedTransition");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionAnim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PlayAlignedTransitionIn;
    /// <summary>
    /// Function: PlayAlignedTransitionIn
    /// </summary>
    public unsafe virtual void PlayAlignedTransitionIn(BmSDK.FName TransitionIn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAlignedTransitionIn, "BmGame.RBM2Behaviour_IdleConfig.PlayAlignedTransitionIn");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionIn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAnimStartDirection;
    /// <summary>
    /// Function: GetAnimStartDirection
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetAnimStartDirection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimStartDirection, "BmGame.RBM2Behaviour_IdleConfig.GetAnimStartDirection");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPropLocation;
    /// <summary>
    /// Function: GetPropLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPropLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPropLocation, "BmGame.RBM2Behaviour_IdleConfig.GetPropLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GenerateMoveToTarget;
    /// <summary>
    /// Function: GenerateMoveToTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GenerateMoveToTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GenerateMoveToTarget, "BmGame.RBM2Behaviour_IdleConfig.GenerateMoveToTarget");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnimStartDirectionVehicle;
    /// <summary>
    /// Function: GetAnimStartDirectionVehicle
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetAnimStartDirectionVehicle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimStartDirectionVehicle, "BmGame.RBM2Behaviour_IdleConfig.GetAnimStartDirectionVehicle");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPropLocationVehicle;
    /// <summary>
    /// Function: GetPropLocationVehicle
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPropLocationVehicle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPropLocationVehicle, "BmGame.RBM2Behaviour_IdleConfig.GetPropLocationVehicle");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GenerateMoveToTargetVehicle;
    /// <summary>
    /// Function: GenerateMoveToTargetVehicle
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GenerateMoveToTargetVehicle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GenerateMoveToTargetVehicle, "BmGame.RBM2Behaviour_IdleConfig.GenerateMoveToTargetVehicle");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnimStartDirectionLedge;
    /// <summary>
    /// Function: GetAnimStartDirectionLedge
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetAnimStartDirectionLedge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimStartDirectionLedge, "BmGame.RBM2Behaviour_IdleConfig.GetAnimStartDirectionLedge");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPropLocationLedge;
    /// <summary>
    /// Function: GetPropLocationLedge
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPropLocationLedge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPropLocationLedge, "BmGame.RBM2Behaviour_IdleConfig.GetPropLocationLedge");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GenerateMoveToTargetLedge;
    /// <summary>
    /// Function: GenerateMoveToTargetLedge
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GenerateMoveToTargetLedge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GenerateMoveToTargetLedge, "BmGame.RBM2Behaviour_IdleConfig.GenerateMoveToTargetLedge");
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnimStartDirectionPlannar;
    /// <summary>
    /// Function: GetAnimStartDirectionPlannar
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetAnimStartDirectionPlannar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimStartDirectionPlannar, "BmGame.RBM2Behaviour_IdleConfig.GetAnimStartDirectionPlannar");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPropLocationPlannar;
    /// <summary>
    /// Function: GetPropLocationPlannar
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPropLocationPlannar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPropLocationPlannar, "BmGame.RBM2Behaviour_IdleConfig.GetPropLocationPlannar");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GenerateMoveToTargetPlannar;
    /// <summary>
    /// Function: GenerateMoveToTargetPlannar
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GenerateMoveToTargetPlannar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GenerateMoveToTargetPlannar, "BmGame.RBM2Behaviour_IdleConfig.GenerateMoveToTargetPlannar");
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnimStartDirectionPlain;
    /// <summary>
    /// Function: GetAnimStartDirectionPlain
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetAnimStartDirectionPlain()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimStartDirectionPlain, "BmGame.RBM2Behaviour_IdleConfig.GetAnimStartDirectionPlain");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPropLocationPlain;
    /// <summary>
    /// Function: GetPropLocationPlain
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPropLocationPlain()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPropLocationPlain, "BmGame.RBM2Behaviour_IdleConfig.GetPropLocationPlain");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPropLocationPawnWithRot;
    /// <summary>
    /// Function: GetPropLocationPawnWithRot
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPropLocationPawnWithRot()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPropLocationPawnWithRot, "BmGame.RBM2Behaviour_IdleConfig.GetPropLocationPawnWithRot");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GenerateMoveToTargetPlain;
    /// <summary>
    /// Function: GenerateMoveToTargetPlain
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GenerateMoveToTargetPlain()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GenerateMoveToTargetPlain, "BmGame.RBM2Behaviour_IdleConfig.GenerateMoveToTargetPlain");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnimStartDirectionProp;
    /// <summary>
    /// Function: GetAnimStartDirectionProp
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetAnimStartDirectionProp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimStartDirectionProp, "BmGame.RBM2Behaviour_IdleConfig.GetAnimStartDirectionProp");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPropLocationProp;
    /// <summary>
    /// Function: GetPropLocationProp
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPropLocationProp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPropLocationProp, "BmGame.RBM2Behaviour_IdleConfig.GetPropLocationProp");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GenerateMoveToTargetProp;
    /// <summary>
    /// Function: GenerateMoveToTargetProp
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GenerateMoveToTargetProp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GenerateMoveToTargetProp, "BmGame.RBM2Behaviour_IdleConfig.GenerateMoveToTargetProp");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UseTransitionIn;
    /// <summary>
    /// Function: UseTransitionIn
    /// </summary>
    public unsafe virtual bool UseTransitionIn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UseTransitionIn, "BmGame.RBM2Behaviour_IdleConfig.UseTransitionIn");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsUseIdleAsInVer;
    /// <summary>
    /// Function: IsUseIdleAsInVer
    /// </summary>
    public unsafe virtual bool IsUseIdleAsInVer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsUseIdleAsInVer, "BmGame.RBM2Behaviour_IdleConfig.IsUseIdleAsInVer");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AwareOfPlayer;
    /// <summary>
    /// Function: AwareOfPlayer
    /// </summary>
    public unsafe override bool AwareOfPlayer(BmSDK.Engine.Actor Player, BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwareOfPlayer, "BmGame.RBM2Behaviour_IdleConfig.AwareOfPlayer");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_UnAwareOfPlayer;
    /// <summary>
    /// Function: UnAwareOfPlayer
    /// </summary>
    public unsafe override bool UnAwareOfPlayer(BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnAwareOfPlayer, "BmGame.RBM2Behaviour_IdleConfig.UnAwareOfPlayer");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmGame.RBM2Behaviour_IdleConfig.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldReactBeforeJoiningCombat;
    /// <summary>
    /// Function: ShouldReactBeforeJoiningCombat
    /// </summary>
    public unsafe override bool ShouldReactBeforeJoiningCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldReactBeforeJoiningCombat, "BmGame.RBM2Behaviour_IdleConfig.ShouldReactBeforeJoiningCombat");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EnableRestartIdleOnMatineeEnd;
    /// <summary>
    /// Function: EnableRestartIdleOnMatineeEnd
    /// </summary>
    public unsafe virtual void EnableRestartIdleOnMatineeEnd()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableRestartIdleOnMatineeEnd, "BmGame.RBM2Behaviour_IdleConfig.EnableRestartIdleOnMatineeEnd");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableRestartIdleOnMatineeEnd;
    /// <summary>
    /// Function: DisableRestartIdleOnMatineeEnd
    /// </summary>
    public unsafe virtual void DisableRestartIdleOnMatineeEnd()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableRestartIdleOnMatineeEnd, "BmGame.RBM2Behaviour_IdleConfig.DisableRestartIdleOnMatineeEnd");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnEndInterrupt;
    /// <summary>
    /// Function: OnEndInterrupt
    /// </summary>
    public unsafe override void OnEndInterrupt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEndInterrupt, "BmGame.RBM2Behaviour_IdleConfig.OnEndInterrupt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBeginInterrupt;
    /// <summary>
    /// Function: OnBeginInterrupt
    /// </summary>
    public unsafe override void OnBeginInterrupt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBeginInterrupt, "BmGame.RBM2Behaviour_IdleConfig.OnBeginInterrupt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowCombatHit;
    /// <summary>
    /// Function: AllowCombatHit
    /// </summary>
    public unsafe virtual void AllowCombatHit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowCombatHit, "BmGame.RBM2Behaviour_IdleConfig.AllowCombatHit");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeHitInCombat;
    /// <summary>
    /// Function: CanBeHitInCombat
    /// </summary>
    public unsafe override bool CanBeHitInCombat(BmSDK.BmGame.RDamageType DamageType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeHitInCombat, "BmGame.RBM2Behaviour_IdleConfig.CanBeHitInCombat");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanLookAtPlayer;
    /// <summary>
    /// Function: CanLookAtPlayer
    /// </summary>
    public unsafe override bool CanLookAtPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanLookAtPlayer, "BmGame.RBM2Behaviour_IdleConfig.CanLookAtPlayer");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnDeactivate;
    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeactivate, "BmGame.RBM2Behaviour_IdleConfig.OnDeactivate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReverseFovCheck;
    /// <summary>
    /// Function: ReverseFovCheck
    /// </summary>
    public unsafe virtual bool ReverseFovCheck()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReverseFovCheck, "BmGame.RBM2Behaviour_IdleConfig.ReverseFovCheck");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TalkingToBats;
    /// <summary>
    /// Function: TalkingToBats
    /// </summary>
    public unsafe virtual void TalkingToBats()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TalkingToBats, "BmGame.RBM2Behaviour_IdleConfig.TalkingToBats");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForCloseProximity;
    /// <summary>
    /// Function: CheckForCloseProximity
    /// </summary>
    public unsafe override bool CheckForCloseProximity(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForCloseProximity, "BmGame.RBM2Behaviour_IdleConfig.CheckForCloseProximity");
        byte* paramsPtr = stackalloc byte[8];
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

    private static BmSDK.Function __fn_Check2DProximity;
    /// <summary>
    /// Function: Check2DProximity
    /// </summary>
    public unsafe virtual void Check2DProximity()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Check2DProximity, "BmGame.RBM2Behaviour_IdleConfig.Check2DProximity");
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

    private static BmSDK.Function __fn_UpdateLookAt;
    /// <summary>
    /// Function: UpdateLookAt
    /// </summary>
    public unsafe virtual void UpdateLookAt(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateLookAt, "BmGame.RBM2Behaviour_IdleConfig.UpdateLookAt");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForBatmanInteruption;
    /// <summary>
    /// Function: CheckForBatmanInteruption
    /// </summary>
    public unsafe virtual void CheckForBatmanInteruption()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForBatmanInteruption, "BmGame.RBM2Behaviour_IdleConfig.CheckForBatmanInteruption");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableBMMove;
    /// <summary>
    /// Function: EnableBMMove
    /// </summary>
    public unsafe virtual void EnableBMMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableBMMove, "BmGame.RBM2Behaviour_IdleConfig.EnableBMMove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableBMMove;
    /// <summary>
    /// Function: DisableBMMove
    /// </summary>
    public unsafe virtual void DisableBMMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableBMMove, "BmGame.RBM2Behaviour_IdleConfig.DisableBMMove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ICMoveRequest;
    /// <summary>
    /// Function: ICMoveRequest
    /// </summary>
    public unsafe virtual void ICMoveRequest()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ICMoveRequest, "BmGame.RBM2Behaviour_IdleConfig.ICMoveRequest");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnExitConditionTriggered;
    /// <summary>
    /// Function: OnExitConditionTriggered
    /// </summary>
    public unsafe override void OnExitConditionTriggered()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnExitConditionTriggered, "BmGame.RBM2Behaviour_IdleConfig.OnExitConditionTriggered");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowAiming;
    /// <summary>
    /// Function: AllowAiming
    /// </summary>
    public unsafe virtual void AllowAiming()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowAiming, "BmGame.RBM2Behaviour_IdleConfig.AllowAiming");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisallowAiming;
    /// <summary>
    /// Function: DisallowAiming
    /// </summary>
    public unsafe virtual void DisallowAiming()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisallowAiming, "BmGame.RBM2Behaviour_IdleConfig.DisallowAiming");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EarlyExit;
    /// <summary>
    /// Function: EarlyExit
    /// </summary>
    public unsafe virtual void EarlyExit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EarlyExit, "BmGame.RBM2Behaviour_IdleConfig.EarlyExit");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AnimNotify;
    /// <summary>
    /// Function: AnimNotify
    /// </summary>
    public unsafe virtual void AnimNotify(BmSDK.GameObject.FGuid Gid)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnimNotify, "BmGame.RBM2Behaviour_IdleConfig.AnimNotify");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gid, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetOutputLink;
    /// <summary>
    /// Function: GetOutputLink
    /// </summary>
    public unsafe virtual int GetOutputLink(BmSDK.TArray<BmSDK.BmGame.RBM2Behaviour_IdleConfig.FNotifyIdentifier> NotifyLinks, BmSDK.GameObject.FGuid Gid)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOutputLink, "BmGame.RBM2Behaviour_IdleConfig.GetOutputLink");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyLinks, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gid, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_WaitForLinkActor;
    /// <summary>
    /// Function: WaitForLinkActor
    /// </summary>
    public unsafe virtual bool WaitForLinkActor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WaitForLinkActor, "BmGame.RBM2Behaviour_IdleConfig.WaitForLinkActor");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PickNextWalkVariantTime;
    /// <summary>
    /// Function: PickNextWalkVariantTime
    /// </summary>
    public unsafe virtual void PickNextWalkVariantTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickNextWalkVariantTime, "BmGame.RBM2Behaviour_IdleConfig.PickNextWalkVariantTime");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PriorityBehaviourWaiting;
    /// <summary>
    /// Function: PriorityBehaviourWaiting
    /// </summary>
    public unsafe override void PriorityBehaviourWaiting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PriorityBehaviourWaiting, "BmGame.RBM2Behaviour_IdleConfig.PriorityBehaviourWaiting");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCombat;
    /// <summary>
    /// Function: TriggerCombat
    /// </summary>
    public unsafe virtual void TriggerCombat(BmSDK.Engine.Actor CombatTarget, bool bForceIntoCombat = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCombat, "BmGame.RBM2Behaviour_IdleConfig.TriggerCombat");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceIntoCombat, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMoveToSpeedIC;
    /// <summary>
    /// Function: SetMoveToSpeedIC
    /// </summary>
    public unsafe virtual void SetMoveToSpeedIC(BmSDK.BmGame.RBMBehaviour_MoveToBase.MoveToSpeed movSpeed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMoveToSpeedIC, "BmGame.RBM2Behaviour_IdleConfig.SetMoveToSpeedIC");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(movSpeed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnActivate;
    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmGame.RBM2Behaviour_IdleConfig.OnActivate");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PickClosestProp;
    /// <summary>
    /// Function: PickClosestProp
    /// </summary>
    public unsafe virtual void PickClosestProp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickClosestProp, "BmGame.RBM2Behaviour_IdleConfig.PickClosestProp");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRoutedPropDistance;
    /// <summary>
    /// Function: GetRoutedPropDistance
    /// </summary>
    public unsafe virtual float GetRoutedPropDistance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRoutedPropDistance, "BmGame.RBM2Behaviour_IdleConfig.GetRoutedPropDistance");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SearchAnimSetForAnim;
    /// <summary>
    /// Function: SearchAnimSetForAnim
    /// </summary>
    public unsafe virtual bool SearchAnimSetForAnim(BmSDK.Engine.AnimSet searchSet, BmSDK.FString SearchName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SearchAnimSetForAnim, "BmGame.RBM2Behaviour_IdleConfig.SearchAnimSetForAnim");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(searchSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchName, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_InitialiseLookAt;
    /// <summary>
    /// Function: InitialiseLookAt
    /// </summary>
    public unsafe virtual void InitialiseLookAt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseLookAt, "BmGame.RBM2Behaviour_IdleConfig.InitialiseLookAt");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TellControllerToEnterCombat;
    /// <summary>
    /// Function: TellControllerToEnterCombat
    /// </summary>
    public unsafe virtual void TellControllerToEnterCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TellControllerToEnterCombat, "BmGame.RBM2Behaviour_IdleConfig.TellControllerToEnterCombat");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandlesGlance;
    /// <summary>
    /// Function: HandlesGlance
    /// </summary>
    public unsafe override bool HandlesGlance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandlesGlance, "BmGame.RBM2Behaviour_IdleConfig.HandlesGlance");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_WantsToEnterCombat;
    /// <summary>
    /// Function: WantsToEnterCombat
    /// </summary>
    public unsafe override void WantsToEnterCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WantsToEnterCombat, "BmGame.RBM2Behaviour_IdleConfig.WantsToEnterCombat");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeactivateInputLinks;
    /// <summary>
    /// Function: DeactivateInputLinks
    /// </summary>
    public unsafe virtual void DeactivateInputLinks()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivateInputLinks, "BmGame.RBM2Behaviour_IdleConfig.DeactivateInputLinks");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateInputLinks;
    /// <summary>
    /// Function: ActivateInputLinks
    /// </summary>
    public unsafe virtual void ActivateInputLinks()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateInputLinks, "BmGame.RBM2Behaviour_IdleConfig.ActivateInputLinks");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoBasicVaildTests;
    /// <summary>
    /// Function: DoBasicVaildTests
    /// </summary>
    public unsafe virtual bool DoBasicVaildTests()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoBasicVaildTests, "BmGame.RBM2Behaviour_IdleConfig.DoBasicVaildTests");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DeactivateSPStuff;
    /// <summary>
    /// Function: DeactivateSPStuff
    /// </summary>
    public unsafe virtual void DeactivateSPStuff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivateSPStuff, "BmGame.RBM2Behaviour_IdleConfig.DeactivateSPStuff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitialiseSPStuff;
    /// <summary>
    /// Function: InitialiseSPStuff
    /// </summary>
    public unsafe virtual void InitialiseSPStuff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseSPStuff, "BmGame.RBM2Behaviour_IdleConfig.InitialiseSPStuff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitialiseWorkingVariables;
    /// <summary>
    /// Function: InitialiseWorkingVariables
    /// </summary>
    public unsafe virtual void InitialiseWorkingVariables()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseWorkingVariables, "BmGame.RBM2Behaviour_IdleConfig.InitialiseWorkingVariables");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNoCombat;
    /// <summary>
    /// Function: SetNoCombat
    /// </summary>
    public unsafe virtual void SetNoCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNoCombat, "BmGame.RBM2Behaviour_IdleConfig.SetNoCombat");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFullCombat;
    /// <summary>
    /// Function: SetFullCombat
    /// </summary>
    public unsafe virtual void SetFullCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFullCombat, "BmGame.RBM2Behaviour_IdleConfig.SetFullCombat");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCombatLos;
    /// <summary>
    /// Function: SetCombatLos
    /// </summary>
    public unsafe virtual void SetCombatLos()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCombatLos, "BmGame.RBM2Behaviour_IdleConfig.SetCombatLos");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayEvent;
    /// <summary>
    /// Function: PlayEvent
    /// </summary>
    public unsafe virtual void PlayEvent(int EventIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayEvent, "BmGame.RBM2Behaviour_IdleConfig.PlayEvent");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBatmanGrab;
    /// <summary>
    /// Function: CanBatmanGrab
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMAIController.BatmanGrabType CanBatmanGrab()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBatmanGrab, "BmGame.RBM2Behaviour_IdleConfig.CanBatmanGrab");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIController.BatmanGrabType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayerBumped;
    /// <summary>
    /// Function: PlayerBumped
    /// </summary>
    public unsafe override void PlayerBumped(bool bFriendly)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerBumped, "BmGame.RBM2Behaviour_IdleConfig.PlayerBumped");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFriendly, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleNoise;
    /// <summary>
    /// Function: HandleNoise
    /// </summary>
    public unsafe override void HandleNoise(BmSDK.BmGame.RPawnPlayer PlayerInstigator)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleNoise, "BmGame.RBM2Behaviour_IdleConfig.HandleNoise");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerInstigator, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishedStalling;
    /// <summary>
    /// Function: FinishedStalling
    /// </summary>
    public unsafe virtual void FinishedStalling()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedStalling, "BmGame.RBM2Behaviour_IdleConfig.FinishedStalling");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScriptExitBehaviour;
    /// <summary>
    /// Function: ScriptExitBehaviour
    /// </summary>
    public unsafe virtual void ScriptExitBehaviour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScriptExitBehaviour, "BmGame.RBM2Behaviour_IdleConfig.ScriptExitBehaviour");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetEventAndOverlayVars;
    /// <summary>
    /// Function: ResetEventAndOverlayVars
    /// </summary>
    public unsafe virtual void ResetEventAndOverlayVars(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetEventAndOverlayVars, "BmGame.RBM2Behaviour_IdleConfig.ResetEventAndOverlayVars");
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

    private static BmSDK.Function __fn_LogGuids;
    /// <summary>
    /// Function: LogGuids
    /// </summary>
    public unsafe virtual void LogGuids(BmSDK.GameObject.FGuid Gid)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogGuids, "BmGame.RBM2Behaviour_IdleConfig.LogGuids");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gid, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsReadyToPlayDialogueRandomAnimation;
    /// <summary>
    /// Function: IsReadyToPlayDialogueRandomAnimation
    /// </summary>
    public unsafe virtual bool IsReadyToPlayDialogueRandomAnimation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsReadyToPlayDialogueRandomAnimation, "BmGame.RBM2Behaviour_IdleConfig.IsReadyToPlayDialogueRandomAnimation");
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

    private static BmSDK.Function __fn_IsReadyToPlayRandomAnimation;
    /// <summary>
    /// Function: IsReadyToPlayRandomAnimation
    /// </summary>
    public unsafe virtual bool IsReadyToPlayRandomAnimation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsReadyToPlayRandomAnimation, "BmGame.RBM2Behaviour_IdleConfig.IsReadyToPlayRandomAnimation");
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

    private static BmSDK.Function __fn_IsReadyToPlayEvent;
    /// <summary>
    /// Function: IsReadyToPlayEvent
    /// </summary>
    public unsafe virtual bool IsReadyToPlayEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsReadyToPlayEvent, "BmGame.RBM2Behaviour_IdleConfig.IsReadyToPlayEvent");
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

    private static BmSDK.Function __fn_IsReadyToPlayStartledAnimation;
    /// <summary>
    /// Function: IsReadyToPlayStartledAnimation
    /// </summary>
    public unsafe override bool IsReadyToPlayStartledAnimation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsReadyToPlayStartledAnimation, "BmGame.RBM2Behaviour_IdleConfig.IsReadyToPlayStartledAnimation");
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

    private static BmSDK.Function __fn_IsNotPlayingTransition;
    /// <summary>
    /// Function: IsNotPlayingTransition
    /// </summary>
    public unsafe virtual bool IsNotPlayingTransition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNotPlayingTransition, "BmGame.RBM2Behaviour_IdleConfig.IsNotPlayingTransition");
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

    private static BmSDK.Function __fn_IsTransitionInOver;
    /// <summary>
    /// Function: IsTransitionInOver
    /// </summary>
    public unsafe virtual bool IsTransitionInOver()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTransitionInOver, "BmGame.RBM2Behaviour_IdleConfig.IsTransitionInOver");
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

    private static BmSDK.Function __fn_IsInTransitionIn;
    /// <summary>
    /// Function: IsInTransitionIn
    /// </summary>
    public unsafe virtual bool IsInTransitionIn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInTransitionIn, "BmGame.RBM2Behaviour_IdleConfig.IsInTransitionIn");
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

    private static BmSDK.Function __fn_IsExitAnimationOver;
    /// <summary>
    /// Function: IsExitAnimationOver
    /// </summary>
    public unsafe virtual bool IsExitAnimationOver()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsExitAnimationOver, "BmGame.RBM2Behaviour_IdleConfig.IsExitAnimationOver");
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

    private static BmSDK.Function __fn_IsNotPlayingOverlay;
    /// <summary>
    /// Function: IsNotPlayingOverlay
    /// </summary>
    public unsafe virtual bool IsNotPlayingOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNotPlayingOverlay, "BmGame.RBM2Behaviour_IdleConfig.IsNotPlayingOverlay");
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

    private static BmSDK.Function __fn_ExitCalled;
    /// <summary>
    /// Function: ExitCalled
    /// </summary>
    public unsafe virtual bool ExitCalled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitCalled, "BmGame.RBM2Behaviour_IdleConfig.ExitCalled");
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

    private static BmSDK.Function __fn_CheckAbsoluteTeleport;
    /// <summary>
    /// Function: CheckAbsoluteTeleport
    /// </summary>
    public unsafe virtual void CheckAbsoluteTeleport()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAbsoluteTeleport, "BmGame.RBM2Behaviour_IdleConfig.CheckAbsoluteTeleport");
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

    private static BmSDK.Function __fn_NativeIdleTick;
    /// <summary>
    /// Function: NativeIdleTick
    /// </summary>
    public unsafe virtual void NativeIdleTick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NativeIdleTick, "BmGame.RBM2Behaviour_IdleConfig.NativeIdleTick");
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

    private static BmSDK.Function __fn_GetNotifies;
    /// <summary>
    /// Function: GetNotifies
    /// </summary>
    public unsafe virtual bool GetNotifies(out int RunningCounter, out BmSDK.TArray<BmSDK.BmGame.RBM2Behaviour_IdleConfig.FNotifyIdentifier> ListToBuild, BmSDK.FName AnimationName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNotifies, "BmGame.RBM2Behaviour_IdleConfig.GetNotifies");
        byte* paramsPtr = stackalloc byte[32];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RunningCounter);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RunningCounter, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimationName, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        RunningCounter = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        ListToBuild = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RBM2Behaviour_IdleConfig.FNotifyIdentifier>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Struct: FNotifyIdentifier
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FNotifyIdentifier
    {
        /// <summary>
        /// NameProperty: NotifyName
        /// </summary>
        public unsafe BmSDK.FName NotifyName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: OutputLink
        /// </summary>
        public unsafe int OutputLink
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: Gid
        /// </summary>
        public unsafe BmSDK.GameObject.FGuid Gid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FGuid>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: IsUsed
        /// </summary>
        public unsafe int IsUsed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Struct: FProximityAndSight
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FProximityAndSight
    {
        /// <summary>
        /// FloatProperty: BatmanProximityDistance
        /// </summary>
        public unsafe float BatmanProximityDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: BatmanProximity2DDistance
        /// </summary>
        public unsafe float BatmanProximity2DDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: NPCSeenDistance
        /// </summary>
        public unsafe float NPCSeenDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: BatmanSeenDistance
        /// </summary>
        public unsafe float BatmanSeenDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: TimeBetweenNotSeenAndSeenForOutput
        /// </summary>
        public unsafe float TimeBetweenNotSeenAndSeenForOutput
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: TimeSinceLastNPCSeen
        /// </summary>
        public unsafe float TimeSinceLastNPCSeen
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: TimeSinceBMClose
        /// </summary>
        public unsafe float TimeSinceBMClose
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: TimeSinceBMClose2D
        /// </summary>
        public unsafe float TimeSinceBMClose2D
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: TimeSinceBMSeen
        /// </summary>
        public unsafe float TimeSinceBMSeen
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: CheckTimer
        /// </summary>
        public unsafe float CheckTimer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: ProximityPawnTimesliceIndex
        /// </summary>
        public unsafe int ProximityPawnTimesliceIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: bSeenBatmanBothWayCheck
        /// </summary>
        public unsafe bool bSeenBatmanBothWayCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: bDontCheckNPCs
        /// </summary>
        public unsafe bool bDontCheckNPCs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: StartleDist
        /// </summary>
        public unsafe float StartleDist
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
    }

    /// <summary>
    /// Struct: FCombatAndSpOptions
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FCombatAndSpOptions
    {
        /// <summary>
        /// FloatProperty: OffsetFromOriginDistance
        /// </summary>
        public unsafe float OffsetFromOriginDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bCanBeGrabbed
        /// </summary>
        public unsafe bool bCanBeGrabbed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bAllowInstantExitViaExitCon
        /// </summary>
        public unsafe bool bAllowInstantExitViaExitCon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bCanBeHitInCombat
        /// </summary>
        public unsafe bool bCanBeHitInCombat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bCanBeHitInCombatLocal
        /// </summary>
        public unsafe bool bCanBeHitInCombatLocal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bPlayReactionBeforeJoiningCombat
        /// </summary>
        public unsafe bool bPlayReactionBeforeJoiningCombat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bCombatTriggered
        /// </summary>
        public unsafe bool bCombatTriggered
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bStallBeforeSilentPredator
        /// </summary>
        public unsafe bool bStallBeforeSilentPredator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bStallBeforePredRegistersAEC
        /// </summary>
        public unsafe bool bStallBeforePredRegistersAEC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bStartCombatOnLOS
        /// </summary>
        public unsafe bool bStartCombatOnLOS
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 256) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bPlayingSpStartle
        /// </summary>
        public unsafe bool bPlayingSpStartle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 512) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bCantRespondToAECAlerts
        /// </summary>
        public unsafe bool bCantRespondToAECAlerts
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1024) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bPlayExitBeforeJoiningCombat
        /// </summary>
        public unsafe bool bPlayExitBeforeJoiningCombat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 2048) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bEnterCombatIfFiringJammedGun
        /// </summary>
        public unsafe bool bEnterCombatIfFiringJammedGun
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 4096) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FMoveToData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial record struct FMoveToData
    {
        /// <summary>
        /// StructProperty: MoveToPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 MoveToPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: FaceDir
        /// </summary>
        public unsafe System.Numerics.Vector3 FaceDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: TooLongForTurn
        /// </summary>
        public unsafe float TooLongForTurn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: NonAlignedStartLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 NonAlignedStartLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: NonAlignedStartRotation
        /// </summary>
        public unsafe BmSDK.Rotator NonAlignedStartRotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ObjectProperty: NavHandle
        /// </summary>
        public unsafe BmSDK.BmGame.RNavigationHandle NavHandle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// ByteProperty: Speed
        /// </summary>
        public unsafe BmSDK.BmGame.RBMBehaviour_MoveToBase.MoveToSpeed Speed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_MoveToBase.MoveToSpeed>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// ByteProperty: TransInInteruptSetting
        /// </summary>
        public unsafe BmSDK.BmGame.RBM2Behaviour_IdleConfig.TransitionInInteruptSetting TransInInteruptSetting
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBM2Behaviour_IdleConfig.TransitionInInteruptSetting>(Ptr + 61); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 61); }; }
        }

        /// <summary>
        /// BoolProperty: bDisableBMMove
        /// </summary>
        public unsafe bool bDisableBMMove
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: bHasSlowedDown
        /// </summary>
        public unsafe bool bHasSlowedDown
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: bHasTurned
        /// </summary>
        public unsafe bool bHasTurned
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: bUseMoveTo
        /// </summary>
        public unsafe bool bUseMoveTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: NonAlignedStartLocationSet
        /// </summary>
        public unsafe bool NonAlignedStartLocationSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: bFinishMoveToBeforeIdle
        /// </summary>
        public unsafe bool bFinishMoveToBeforeIdle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: bTransInWasInterupted
        /// </summary>
        public unsafe bool bTransInWasInterupted
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: bInteruptedCollisionNeedsReset
        /// </summary>
        public unsafe bool bInteruptedCollisionNeedsReset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: bTrackAlignmentPosition
        /// </summary>
        public unsafe bool bTrackAlignmentPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 256) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: bRestartIdleOnMatineeEnd
        /// </summary>
        public unsafe bool bRestartIdleOnMatineeEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 512) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: bUseAccurateDecelerationCalculation
        /// </summary>
        public unsafe bool bUseAccurateDecelerationCalculation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1024) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Enum: TransitionInInteruptSetting
    /// </summary>
    public enum TransitionInInteruptSetting : byte
    {
        TRANSININTSET_None = 0,
        TRANSININTSET_Replay = 1,
        TRANSININTSET_StraightToIdle = 2,
        TRANSININTSET_BatmanMove = 3,
        TRANSININTSET_MAX = 4,
    }

    /// <summary>
    /// Enum: EStasisType
    /// </summary>
    public enum EStasisType : byte
    {
        STASIS_AllowStasisWhenNotTransitioning = 0,
        STASIS_AlwaysAllowStasis = 1,
        STASIS_NeverAllowStasis = 2,
        STASIS_MAX = 3,
    }

    /// <summary>
    /// ObjectProperty: IdleConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RBM2IdleConfig IdleConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBM2IdleConfig>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ObjectProperty: Prop
    /// </summary>
    public unsafe BmSDK.Engine.Actor Prop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ObjectProperty: PropSearch
    /// </summary>
    public unsafe BmSDK.BmGame.RMultiNavHandleWrapper PropSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMultiNavHandleWrapper>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ObjectProperty: CurrentLookAtTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentLookAtTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ObjectProperty: AEC_Dummy
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_IdleConfigSolo AEC_Dummy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_IdleConfigSolo>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// ObjectProperty: LinkActor
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI LinkActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ObjectProperty: InterrogationLocator
    /// </summary>
    public unsafe BmSDK.Engine.Actor InterrogationLocator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ArrayProperty: Props
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> Props
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bSearchingForClosestProp
    /// </summary>
    public unsafe bool bSearchingForClosestProp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bMirrorEverything
    /// </summary>
    public unsafe bool bMirrorEverything
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreOverlaysWhenExiting
    /// </summary>
    public unsafe bool bIgnoreOverlaysWhenExiting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bCanExitDuringTransIn
    /// </summary>
    public unsafe bool bCanExitDuringTransIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bDontInitialiseIdleTime
    /// </summary>
    public unsafe bool bDontInitialiseIdleTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bExtendStasisRangeForDialogue
    /// </summary>
    public unsafe bool bExtendStasisRangeForDialogue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bAllowedToLookAtThings
    /// </summary>
    public unsafe bool bAllowedToLookAtThings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bEnableProximityChecks
    /// </summary>
    public unsafe bool bEnableProximityChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bAllowTurningForAims
    /// </summary>
    public unsafe bool bAllowTurningForAims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bNoLookAtsConnected
    /// </summary>
    public unsafe bool bNoLookAtsConnected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bExposeTransitionOptions
    /// </summary>
    public unsafe bool bExposeTransitionOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bExposedTransitionOptions
    /// </summary>
    public unsafe bool bExposedTransitionOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreTransitionIn
    /// </summary>
    public unsafe bool bIgnoreTransitionIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreTransitionOut
    /// </summary>
    public unsafe bool bIgnoreTransitionOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bExposeRandomAnimationToggle
    /// </summary>
    public unsafe bool bExposeRandomAnimationToggle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bExposedRandomAnimationToggle
    /// </summary>
    public unsafe bool bExposedRandomAnimationToggle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bDisallowRandomAnimations
    /// </summary>
    public unsafe bool bDisallowRandomAnimations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bExposeLinkActor
    /// </summary>
    public unsafe bool bExposeLinkActor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bExposedLinkActor
    /// </summary>
    public unsafe bool bExposedLinkActor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bLinkedSlave
    /// </summary>
    public unsafe bool bLinkedSlave
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bHasFiredWalkOutput
    /// </summary>
    public unsafe bool bHasFiredWalkOutput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bEventRequested
    /// </summary>
    public unsafe bool bEventRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bAllowStartlesDuringEvent
    /// </summary>
    public unsafe bool bAllowStartlesDuringEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bPlayingEvent
    /// </summary>
    public unsafe bool bPlayingEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bPlayingRandomAnimation
    /// </summary>
    public unsafe bool bPlayingRandomAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bPlayingStartledAnimation
    /// </summary>
    public unsafe bool bPlayingStartledAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bPlayingDialogueRandomAnimation
    /// </summary>
    public unsafe bool bPlayingDialogueRandomAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bHasRandomsWithNoMovement
    /// </summary>
    public unsafe bool bHasRandomsWithNoMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bHasDialogueRandomsWithNoMovement
    /// </summary>
    public unsafe bool bHasDialogueRandomsWithNoMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bInDialogueLook
    /// </summary>
    public unsafe bool bInDialogueLook
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bInNPCDialogueLook
    /// </summary>
    public unsafe bool bInNPCDialogueLook
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bInNPCDialogueLookIdle
    /// </summary>
    public unsafe bool bInNPCDialogueLookIdle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bInTransitionIn
    /// </summary>
    public unsafe bool bInTransitionIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 724); }
    }

    /// <summary>
    /// BoolProperty: bInTransitionOut
    /// </summary>
    public unsafe bool bInTransitionOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 724); }
    }

    /// <summary>
    /// BoolProperty: bStoredIsInAnyTransition
    /// </summary>
    public unsafe bool bStoredIsInAnyTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 724); }
    }

    /// <summary>
    /// BoolProperty: bStoredIsPlayingOverlay
    /// </summary>
    public unsafe bool bStoredIsPlayingOverlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 724); }
    }

    /// <summary>
    /// BoolProperty: bOnExitEnterCombat
    /// </summary>
    public unsafe bool bOnExitEnterCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 724); }
    }

    /// <summary>
    /// BoolProperty: bIsHostageThatShouldBlockNavHere
    /// </summary>
    public unsafe bool bIsHostageThatShouldBlockNavHere
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 724); }
    }

    /// <summary>
    /// BoolProperty: bAllowRandomTransitionsIfBatmanClose
    /// </summary>
    public unsafe bool bAllowRandomTransitionsIfBatmanClose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 724); }
    }

    /// <summary>
    /// BoolProperty: bForceIdleAsInAllowed
    /// </summary>
    public unsafe bool bForceIdleAsInAllowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 724); }
    }

    /// <summary>
    /// ByteProperty: StasisType
    /// </summary>
    public unsafe BmSDK.BmGame.RBM2Behaviour_IdleConfig.EStasisType StasisType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBM2Behaviour_IdleConfig.EStasisType>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// FloatProperty: CurrentLookAtTargetPriority
    /// </summary>
    public unsafe float CurrentLookAtTargetPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// NameProperty: CurrentLookAtBone
    /// </summary>
    public unsafe BmSDK.FName CurrentLookAtBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: CurrentLookTimer
    /// </summary>
    public unsafe float CurrentLookTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: TimeTillNextLookCheck
    /// </summary>
    public unsafe float TimeTillNextLookCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// StructProperty: MoveOptions
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBM2Behaviour_IdleConfig.FMoveToData MoveOptions
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBM2Behaviour_IdleConfig.FMoveToData>(Ptr + 752);

    /// <summary>
    /// StructProperty: CSOptions
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBM2Behaviour_IdleConfig.FCombatAndSpOptions CSOptions
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBM2Behaviour_IdleConfig.FCombatAndSpOptions>(Ptr + 820);

    /// <summary>
    /// FloatProperty: PredBarkFudgeFactor
    /// </summary>
    public unsafe float PredBarkFudgeFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// StructProperty: ProximityAndSightOptions
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBM2Behaviour_IdleConfig.FProximityAndSight ProximityAndSightOptions
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBM2Behaviour_IdleConfig.FProximityAndSight>(Ptr + 832);

    /// <summary>
    /// NameProperty: ConfigName
    /// </summary>
    public unsafe BmSDK.FName ConfigName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// IntProperty: ReservedInputLinks
    /// </summary>
    public unsafe int ReservedInputLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// IntProperty: ReservedOutputLinks
    /// </summary>
    public unsafe int ReservedOutputLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// StructProperty: TransInId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId TransInId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 900);

    /// <summary>
    /// ArrayProperty: EventNotifyLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBM2Behaviour_IdleConfig.FNotifyIdentifier> EventNotifyLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBM2Behaviour_IdleConfig.FNotifyIdentifier>>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ArrayProperty: IdleNotifyLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBM2Behaviour_IdleConfig.FNotifyIdentifier> IdleNotifyLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBM2Behaviour_IdleConfig.FNotifyIdentifier>>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// ArrayProperty: RandomNotifyLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBM2Behaviour_IdleConfig.FNotifyIdentifier> RandomNotifyLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBM2Behaviour_IdleConfig.FNotifyIdentifier>>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// StructProperty: PlayingOverlay
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlayingOverlay
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 952);

    /// <summary>
    /// IntProperty: LastRandomIndex
    /// </summary>
    public unsafe int LastRandomIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// IntProperty: LastDialogueRandomIndex
    /// </summary>
    public unsafe int LastDialogueRandomIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// FloatProperty: RandomAnimationTimer
    /// </summary>
    public unsafe float RandomAnimationTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// FloatProperty: NPCDialogueRandomAnimationTimer
    /// </summary>
    public unsafe float NPCDialogueRandomAnimationTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// IntProperty: EventRequested
    /// </summary>
    public unsafe int EventRequested
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// StructProperty: DialogueLookStartPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DialogueLookStartPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 980);

    /// <summary>
    /// FloatProperty: DialogueLookStartYaw
    /// </summary>
    public unsafe float DialogueLookStartYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// StructProperty: TraceLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TraceLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 996);

    /// <summary>
    /// StructProperty: TraceNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TraceNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1008);

    /// <summary>
    /// IntProperty: SpawnFix
    /// </summary>
    public unsafe int SpawnFix
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// IntProperty: QueueAbsoluteTeleport
    /// </summary>
    public unsafe int QueueAbsoluteTeleport
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: nextPossibleWalkVariantTriggerTime
    /// </summary>
    public unsafe float nextPossibleWalkVariantTriggerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }
}
