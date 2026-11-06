#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RSpecialMoveInstance<br/>
/// (size = 876)
/// (flags = 144703635)
/// </summary>
public partial class RSpecialMoveInstance : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveInstance", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMoveInstance.
    /// </summary>
    public static RSpecialMoveInstance DefaultObject => (RSpecialMoveInstance)StaticClass().DefaultObject;

    internal RSpecialMoveInstance() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CantSwitchPlayer;
    /// <summary>
    /// Function: CantSwitchPlayer
    /// </summary>
    public unsafe virtual bool CantSwitchPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CantSwitchPlayer, "BmGame.RSpecialMoveInstance.CantSwitchPlayer");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SmashWindows;
    /// <summary>
    /// Function: SmashWindows
    /// </summary>
    public unsafe virtual void SmashWindows()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SmashWindows, "BmGame.RSpecialMoveInstance.SmashWindows");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AutomaticTutorialTextAllowed;
    /// <summary>
    /// Function: AutomaticTutorialTextAllowed
    /// </summary>
    public unsafe virtual bool AutomaticTutorialTextAllowed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutomaticTutorialTextAllowed, "BmGame.RSpecialMoveInstance.AutomaticTutorialTextAllowed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnimEndLocation;
    /// <summary>
    /// Function: GetAnimEndLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAnimEndLocation(BmSDK.FName AnimName, BmSDK.Engine.AnimSet AnimSet, System.Numerics.Vector3 AnimLocation, BmSDK.Rotator AnimRotation, bool Mirrored, bool WhenCollisionTurnsOn = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimEndLocation, "BmGame.RSpecialMoveInstance.GetAnimEndLocation");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimRotation, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WhenCollisionTurnsOn, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_CheckSpaceAtEndOfAnim;
    /// <summary>
    /// Function: CheckSpaceAtEndOfAnim
    /// </summary>
    public unsafe virtual bool CheckSpaceAtEndOfAnim(BmSDK.FName AnimName, BmSDK.Engine.AnimSet AnimSet, System.Numerics.Vector3 AnimLocation, BmSDK.Rotator AnimRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckSpaceAtEndOfAnim, "BmGame.RSpecialMoveInstance.CheckSpaceAtEndOfAnim");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimRotation, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_CanDoRadioMode;
    /// <summary>
    /// Function: CanDoRadioMode
    /// </summary>
    public unsafe virtual void CanDoRadioMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoRadioMode, "BmGame.RSpecialMoveInstance.CanDoRadioMode");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateInteractableItem;
    /// <summary>
    /// Function: ActivateInteractableItem
    /// </summary>
    public unsafe virtual void ActivateInteractableItem()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateInteractableItem, "BmGame.RSpecialMoveInstance.ActivateInteractableItem");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CantDieDuringMove;
    /// <summary>
    /// Function: CantDieDuringMove
    /// </summary>
    public unsafe virtual bool CantDieDuringMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CantDieDuringMove, "BmGame.RSpecialMoveInstance.CantDieDuringMove");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PostFallingPhysicsCallback;
    /// <summary>
    /// Function: PostFallingPhysicsCallback
    /// </summary>
    public unsafe virtual void PostFallingPhysicsCallback()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostFallingPhysicsCallback, "BmGame.RSpecialMoveInstance.PostFallingPhysicsCallback");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoSlavedJokerHallucination;
    /// <summary>
    /// Function: DoSlavedJokerHallucination
    /// </summary>
    public unsafe virtual void DoSlavedJokerHallucination(bool bIgnoreCollisionCheck, BmSDK.BmGame.RPawnJokerHallucination.TypesOfHallucination HallucinationType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoSlavedJokerHallucination, "BmGame.RSpecialMoveInstance.DoSlavedJokerHallucination");
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreCollisionCheck, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HallucinationType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanAimGadget;
    /// <summary>
    /// Function: CanAimGadget
    /// </summary>
    public unsafe virtual bool CanAimGadget(BmSDK.BmGame.RInventoryGadget Gadget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanAimGadget, "BmGame.RSpecialMoveInstance.CanAimGadget");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AllowKismetHelpText;
    /// <summary>
    /// Function: AllowKismetHelpText
    /// </summary>
    public unsafe virtual bool AllowKismetHelpText(BmSDK.BmGame.RSeqAct_HelpText HelpAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowKismetHelpText, "BmGame.RSpecialMoveInstance.AllowKismetHelpText");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AllowNewAgilityMove;
    /// <summary>
    /// Function: AllowNewAgilityMove
    /// </summary>
    public unsafe virtual void AllowNewAgilityMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowNewAgilityMove, "BmGame.RSpecialMoveInstance.AllowNewAgilityMove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ControlsCameraWithLeftStick;
    /// <summary>
    /// Function: ControlsCameraWithLeftStick
    /// </summary>
    public unsafe virtual bool ControlsCameraWithLeftStick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ControlsCameraWithLeftStick, "BmGame.RSpecialMoveInstance.ControlsCameraWithLeftStick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FootStepNotify;
    /// <summary>
    /// Function: FootStepNotify
    /// </summary>
    public unsafe virtual void FootStepNotify()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FootStepNotify, "BmGame.RSpecialMoveInstance.FootStepNotify");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyHitWall;
    /// <summary>
    /// Function: NotifyHitWall
    /// </summary>
    public unsafe virtual void NotifyHitWall(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor Wall)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyHitWall, "BmGame.RSpecialMoveInstance.NotifyHitWall");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Wall, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowStealthAttack;
    /// <summary>
    /// Function: AllowStealthAttack
    /// </summary>
    public unsafe virtual bool AllowStealthAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowStealthAttack, "BmGame.RSpecialMoveInstance.AllowStealthAttack");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDoCombat;
    /// <summary>
    /// Function: CanDoCombat
    /// </summary>
    public unsafe virtual bool CanDoCombat(bool CheckForEvade = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoCombat, "BmGame.RSpecialMoveInstance.CanDoCombat");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckForEvade, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetAnimSet;
    /// <summary>
    /// Function: GetAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimSet, "BmGame.RSpecialMoveInstance.GetAnimSet");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DisallowPlayerMove;
    /// <summary>
    /// Function: DisallowPlayerMove
    /// </summary>
    public unsafe virtual bool DisallowPlayerMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisallowPlayerMove, "BmGame.RSpecialMoveInstance.DisallowPlayerMove");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OverrideGrappleFireMove;
    /// <summary>
    /// Function: OverrideGrappleFireMove
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSpecialMoveConfig OverrideGrappleFireMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideGrappleFireMove, "BmGame.RSpecialMoveInstance.OverrideGrappleFireMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AllowMoveTo;
    /// <summary>
    /// Function: AllowMoveTo
    /// </summary>
    public unsafe virtual bool AllowMoveTo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowMoveTo, "BmGame.RSpecialMoveInstance.AllowMoveTo");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PredictEndLocation;
    /// <summary>
    /// Function: PredictEndLocation
    /// </summary>
    public unsafe virtual bool PredictEndLocation(out System.Numerics.Vector3 EndLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PredictEndLocation, "BmGame.RSpecialMoveInstance.PredictEndLocation");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        EndLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CanSetRadioMode;
    /// <summary>
    /// Function: CanSetRadioMode
    /// </summary>
    public unsafe virtual bool CanSetRadioMode(BmSDK.BmGame.RSeqAct_PlayRadioOrThoughtDialogue act)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSetRadioMode, "BmGame.RSpecialMoveInstance.CanSetRadioMode");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(act, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SimulatedTick;
    /// <summary>
    /// Function: SimulatedTick
    /// </summary>
    public unsafe virtual void SimulatedTick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SimulatedTick, "BmGame.RSpecialMoveInstance.SimulatedTick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnLanded;
    /// <summary>
    /// Function: PawnLanded
    /// </summary>
    public unsafe virtual void PawnLanded()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnLanded, "BmGame.RSpecialMoveInstance.PawnLanded");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveInDirection;
    /// <summary>
    /// Function: MoveInDirection
    /// </summary>
    public unsafe virtual void MoveInDirection(float X, float Y)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveInDirection, "BmGame.RSpecialMoveInstance.MoveInDirection");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AboutToFallOffEdge;
    /// <summary>
    /// Function: AboutToFallOffEdge
    /// </summary>
    public unsafe virtual bool AboutToFallOffEdge(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AboutToFallOffEdge, "BmGame.RSpecialMoveInstance.AboutToFallOffEdge");
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 132);
    }

    private static BmSDK.Function __fn_TriggerUnreliableRemoteEvent;
    /// <summary>
    /// Function: TriggerUnreliableRemoteEvent
    /// </summary>
    public unsafe virtual void TriggerUnreliableRemoteEvent(BmSDK.FName RemoteSpecialMoveEvent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerUnreliableRemoteEvent, "BmGame.RSpecialMoveInstance.TriggerUnreliableRemoteEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemoteSpecialMoveEvent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerRemoteEvent;
    /// <summary>
    /// Function: TriggerRemoteEvent
    /// </summary>
    public unsafe virtual void TriggerRemoteEvent(BmSDK.FName RemoteSpecialMoveEvent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerRemoteEvent, "BmGame.RSpecialMoveInstance.TriggerRemoteEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemoteSpecialMoveEvent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CustomEvent;
    /// <summary>
    /// Function: CustomEvent
    /// </summary>
    public unsafe virtual void CustomEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CustomEvent, "BmGame.RSpecialMoveInstance.CustomEvent");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoteEvent;
    /// <summary>
    /// Function: RemoteEvent
    /// </summary>
    public unsafe virtual void RemoteEvent(BmSDK.FName RemoteSpecialMoveEvent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoteEvent, "BmGame.RSpecialMoveInstance.RemoteEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemoteSpecialMoveEvent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldCorrectForClientError;
    /// <summary>
    /// Function: ShouldCorrectForClientError
    /// </summary>
    public unsafe virtual bool ShouldCorrectForClientError()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldCorrectForClientError, "BmGame.RSpecialMoveInstance.ShouldCorrectForClientError");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RotationOnly;
    /// <summary>
    /// Function: RotationOnly
    /// </summary>
    public unsafe virtual void RotationOnly()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RotationOnly, "BmGame.RSpecialMoveInstance.RotationOnly");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopRelativeTransition;
    /// <summary>
    /// Function: StopRelativeTransition
    /// </summary>
    public unsafe virtual void StopRelativeTransition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopRelativeTransition, "BmGame.RSpecialMoveInstance.StopRelativeTransition");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyTouch;
    /// <summary>
    /// Function: NotifyTouch
    /// </summary>
    public unsafe virtual void NotifyTouch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyTouch, "BmGame.RSpecialMoveInstance.NotifyTouch");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyBump;
    /// <summary>
    /// Function: NotifyBump
    /// </summary>
    public unsafe virtual void NotifyBump(BmSDK.Engine.Actor Other, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyBump, "BmGame.RSpecialMoveInstance.NotifyBump");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyTakeDamage;
    /// <summary>
    /// Function: NotifyTakeDamage
    /// </summary>
    public unsafe virtual void NotifyTakeDamage(int Damage, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyTakeDamage, "BmGame.RSpecialMoveInstance.NotifyTakeDamage");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceShootStumble;
    /// <summary>
    /// Function: ForceShootStumble
    /// </summary>
    public unsafe virtual bool ForceShootStumble()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceShootStumble, "BmGame.RSpecialMoveInstance.ForceShootStumble");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInteruptable;
    /// <summary>
    /// Function: IsInteruptable
    /// </summary>
    public unsafe virtual bool IsInteruptable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInteruptable, "BmGame.RSpecialMoveInstance.IsInteruptable");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe virtual void GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.RSpecialMoveInstance.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreRender;
    /// <summary>
    /// Function: PreRender
    /// </summary>
    public unsafe virtual void PreRender()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreRender, "BmGame.RSpecialMoveInstance.PreRender");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe virtual void DrawHUD(BmSDK.Engine.HUD H)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmGame.RSpecialMoveInstance.DrawHUD");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleAction;
    /// <summary>
    /// Function: HandleAction
    /// </summary>
    public unsafe virtual void HandleAction(BmSDK.FName actionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleAction, "BmGame.RSpecialMoveInstance.HandleAction");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanStartCameraConversation;
    /// <summary>
    /// Function: CanStartCameraConversation
    /// </summary>
    public unsafe virtual bool CanStartCameraConversation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanStartCameraConversation, "BmGame.RSpecialMoveInstance.CanStartCameraConversation");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayCameraAnim;
    /// <summary>
    /// Function: PlayCameraAnim
    /// </summary>
    public unsafe virtual bool PlayCameraAnim(BmSDK.FName AnimName, bool bAnimMirrored = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCameraAnim, "BmGame.RSpecialMoveInstance.PlayCameraAnim");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAnimMirrored, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PlaySpecialCameraAnim;
    /// <summary>
    /// Function: PlaySpecialCameraAnim
    /// </summary>
    public unsafe virtual bool PlaySpecialCameraAnim(BmSDK.BmGame.RPlayerController InController, BmSDK.FName AnimName, bool bPlaying, bool bCamMirrored, float FOV = default, bool bLoop = default, float AnimStartTime = default, bool bProportionalMotion = default, float fBlendInTime = default, BmSDK.Engine.SkeletalMeshComponent SlavedToSkelComponent = default, BmSDK.Engine.AnimSequence SlavedToAnim = default, bool bIgnoreBlend = default, bool bBlendEvenIfInactive = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySpecialCameraAnim, "BmGame.RSpecialMoveInstance.PlaySpecialCameraAnim");
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InController, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlaying, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCamMirrored, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLoop, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimStartTime, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bProportionalMotion, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fBlendInTime, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlavedToSkelComponent, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlavedToAnim, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreBlend, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBlendEvenIfInactive, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 68);
    }

    private static BmSDK.Function __fn_CancelSpecialMove;
    /// <summary>
    /// Function: CancelSpecialMove
    /// </summary>
    public unsafe virtual void CancelSpecialMove(BmSDK.BmGame.RSpecialMoveConfig NextSpecialMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelSpecialMove, "BmGame.RSpecialMoveInstance.CancelSpecialMove");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextSpecialMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEndControllerState;
    /// <summary>
    /// Function: GetEndControllerState
    /// </summary>
    public unsafe virtual BmSDK.FName GetEndControllerState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEndControllerState, "BmGame.RSpecialMoveInstance.GetEndControllerState");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateSpecialMove;
    /// <summary>
    /// Function: UpdateSpecialMove
    /// </summary>
    public unsafe virtual bool UpdateSpecialMove(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSpecialMove, "BmGame.RSpecialMoveInstance.UpdateSpecialMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ForceNotDestroy;
    /// <summary>
    /// Function: ForceNotDestroy
    /// </summary>
    public unsafe virtual bool ForceNotDestroy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceNotDestroy, "BmGame.RSpecialMoveInstance.ForceNotDestroy");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FinishCameraAnim;
    /// <summary>
    /// Function: FinishCameraAnim
    /// </summary>
    public unsafe virtual void FinishCameraAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishCameraAnim, "BmGame.RSpecialMoveInstance.FinishCameraAnim");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishSpecialMove;
    /// <summary>
    /// Function: FinishSpecialMove
    /// </summary>
    public unsafe virtual void FinishSpecialMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishSpecialMove, "BmGame.RSpecialMoveInstance.FinishSpecialMove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowUseGrapple;
    /// <summary>
    /// Function: AllowUseGrapple
    /// </summary>
    public unsafe virtual void AllowUseGrapple()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowUseGrapple, "BmGame.RSpecialMoveInstance.AllowUseGrapple");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForAOverride;
    /// <summary>
    /// Function: CheckForAOverride
    /// </summary>
    public unsafe virtual bool CheckForAOverride(bool ForceOverride = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForAOverride, "BmGame.RSpecialMoveInstance.CheckForAOverride");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceOverride, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTransitionId;
    /// <summary>
    /// Function: GetTransitionId
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId GetTransitionId()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionId, "BmGame.RSpecialMoveInstance.GetTransitionId");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NotifyStartCamera;
    /// <summary>
    /// Function: NotifyStartCamera
    /// </summary>
    public unsafe virtual void NotifyStartCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyStartCamera, "BmGame.RSpecialMoveInstance.NotifyStartCamera");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCameraAnim;
    /// <summary>
    /// Function: GetCameraAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetCameraAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraAnim, "BmGame.RSpecialMoveInstance.GetCameraAnim");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCameraAlignRotation;
    /// <summary>
    /// Function: GetCameraAlignRotation
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetCameraAlignRotation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraAlignRotation, "BmGame.RSpecialMoveInstance.GetCameraAlignRotation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCameraState;
    /// <summary>
    /// Function: SetCameraState
    /// </summary>
    public unsafe virtual void SetCameraState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCameraState, "BmGame.RSpecialMoveInstance.SetCameraState");
        byte* paramsPtr = stackalloc byte[176];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowInvestigateText;
    /// <summary>
    /// Function: AllowInvestigateText
    /// </summary>
    public unsafe virtual bool AllowInvestigateText()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowInvestigateText, "BmGame.RSpecialMoveInstance.AllowInvestigateText");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerSpecialMove;
    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe virtual void TriggerSpecialMove(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSpecialMove, "BmGame.RSpecialMoveInstance.TriggerSpecialMove");
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetAudioState;
    /// <summary>
    /// Function: ResetAudioState
    /// </summary>
    public unsafe virtual void ResetAudioState(BmSDK.Engine.AkStateName StateName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetAudioState, "BmGame.RSpecialMoveInstance.ResetAudioState");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetAudioState;
    /// <summary>
    /// Function: SetAudioState
    /// </summary>
    public unsafe virtual void SetAudioState(BmSDK.Engine.AkStateName StateName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAudioState, "BmGame.RSpecialMoveInstance.SetAudioState");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 0);
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
    /// StructProperty: CurrentMoveLocator
    /// </summary>
    public unsafe ref BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator CurrentMoveLocator
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(Ptr + 668);

    /// <summary>
    /// BoolProperty: bPushedState
    /// </summary>
    public unsafe bool bPushedState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bUsesMoveTo
    /// </summary>
    public unsafe bool bUsesMoveTo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bAuthoritativeMovement
    /// </summary>
    public unsafe bool bAuthoritativeMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bIsVulnerableDuringCombat
    /// </summary>
    public unsafe bool bIsVulnerableDuringCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bCanBeAttacked
    /// </summary>
    public unsafe bool bCanBeAttacked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bHiddenMove
    /// </summary>
    public unsafe bool bHiddenMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bUseCameraAnim
    /// </summary>
    public unsafe bool bUseCameraAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bCameraAnimPlayed
    /// </summary>
    public unsafe bool bCameraAnimPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: DontChangeState
    /// </summary>
    public unsafe bool DontChangeState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bCanUseGrapple
    /// </summary>
    public unsafe bool bCanUseGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bCanAimGrapple
    /// </summary>
    public unsafe bool bCanAimGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bAllowNewAgilityMove
    /// </summary>
    public unsafe bool bAllowNewAgilityMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bDisallowRun
    /// </summary>
    public unsafe bool bDisallowRun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreInterpolationForCameraAnim
    /// </summary>
    public unsafe bool bIgnoreInterpolationForCameraAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bDontAllowBatmobilePickup
    /// </summary>
    public unsafe bool bDontAllowBatmobilePickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: mIsCaseFileMove
    /// </summary>
    public unsafe bool mIsCaseFileMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bInSlowMo
    /// </summary>
    public unsafe bool bInSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bCanSetRadioMode
    /// </summary>
    public unsafe bool bCanSetRadioMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bNotBlockedByThugs
    /// </summary>
    public unsafe bool bNotBlockedByThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bForceThugsToFlee
    /// </summary>
    public unsafe bool bForceThugsToFlee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bMirrorCameraAlignOffset
    /// </summary>
    public unsafe bool bMirrorCameraAlignOffset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bCanSmashWindows
    /// </summary>
    public unsafe bool bCanSmashWindows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bNotBlockedByWire
    /// </summary>
    public unsafe bool bNotBlockedByWire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// ObjectProperty: Config
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig Config
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: SequenceAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_TriggerSpecialMove SequenceAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_TriggerSpecialMove>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: Player
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat Player
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer PlayerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: PlayerController
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController PlayerController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: SpecialMoveCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RInGameCinematicCam SpecialMoveCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInGameCinematicCam>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ObjectProperty: OverrideCameraFallback
    /// </summary>
    public unsafe BmSDK.Engine.Actor OverrideCameraFallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ByteProperty: CommentType
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig.AISpecialMoveCommentType CommentType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig.AISpecialMoveCommentType>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// StructProperty: PlayerAlertLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PlayerAlertLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 864);
}
