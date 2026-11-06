#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RStealthTakeDownStage<br/>
/// (size = 1664)
/// (flags = 144703635)
/// </summary>
public partial class RStealthTakeDownStage : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RStealthTakeDownStage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RStealthTakeDownStage.
    /// </summary>
    public static RStealthTakeDownStage DefaultObject => (RStealthTakeDownStage)StaticClass().DefaultObject;

    internal RStealthTakeDownStage() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RStealthTakeDownStage(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_BlockPlayerFromForceCrouching;
    /// <summary>
    /// Function: BlockPlayerFromForceCrouching
    /// </summary>
    public unsafe virtual bool BlockPlayerFromForceCrouching()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlockPlayerFromForceCrouching, "BmGame.RStealthTakeDownStage.BlockPlayerFromForceCrouching");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetTunnelGrateNextStage;
    /// <summary>
    /// Function: SetTunnelGrateNextStage
    /// </summary>
    public unsafe virtual void SetTunnelGrateNextStage(BmSDK.BmGame.RStealthTakeDownStage NextStageObject)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTunnelGrateNextStage, "BmGame.RStealthTakeDownStage.SetTunnelGrateNextStage");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextStageObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerPredAIResponse;
    /// <summary>
    /// Function: TriggerPredAIResponse
    /// </summary>
    public unsafe virtual void TriggerPredAIResponse()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPredAIResponse, "BmGame.RStealthTakeDownStage.TriggerPredAIResponse");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChainTakedownCam;
    /// <summary>
    /// Function: ChainTakedownCam
    /// </summary>
    public unsafe virtual void ChainTakedownCam()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChainTakedownCam, "BmGame.RStealthTakeDownStage.ChainTakedownCam");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerChainTakedown;
    /// <summary>
    /// Function: TriggerChainTakedown
    /// </summary>
    public unsafe virtual void TriggerChainTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerChainTakedown, "BmGame.RStealthTakeDownStage.TriggerChainTakedown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerEscapeTakedown;
    /// <summary>
    /// Function: TriggerEscapeTakedown
    /// </summary>
    public unsafe virtual void TriggerEscapeTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerEscapeTakedown, "BmGame.RStealthTakeDownStage.TriggerEscapeTakedown");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClimbDown;
    /// <summary>
    /// Function: ClimbDown
    /// </summary>
    public unsafe virtual void ClimbDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClimbDown, "BmGame.RStealthTakeDownStage.ClimbDown");
        byte* paramsPtr = stackalloc byte[29];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GrabPressed;
    /// <summary>
    /// Function: GrabPressed
    /// </summary>
    public unsafe virtual bool GrabPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrabPressed, "BmGame.RStealthTakeDownStage.GrabPressed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GrapplePressed;
    /// <summary>
    /// Function: GrapplePressed
    /// </summary>
    public unsafe virtual void GrapplePressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrapplePressed, "BmGame.RStealthTakeDownStage.GrapplePressed");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropWeapon;
    /// <summary>
    /// Function: DropWeapon
    /// </summary>
    public unsafe virtual void DropWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropWeapon, "BmGame.RStealthTakeDownStage.DropWeapon");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropOrBreakThugWeapon;
    /// <summary>
    /// Function: DropOrBreakThugWeapon
    /// </summary>
    public unsafe virtual void DropOrBreakThugWeapon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropOrBreakThugWeapon, "BmGame.RStealthTakeDownStage.DropOrBreakThugWeapon");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchWeaponDestroyLeft;
    /// <summary>
    /// Function: SwitchWeaponDestroyLeft
    /// </summary>
    public unsafe virtual void SwitchWeaponDestroyLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchWeaponDestroyLeft, "BmGame.RStealthTakeDownStage.SwitchWeaponDestroyLeft");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchWeaponDestroy;
    /// <summary>
    /// Function: SwitchWeaponDestroy
    /// </summary>
    public unsafe virtual void SwitchWeaponDestroy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchWeaponDestroy, "BmGame.RStealthTakeDownStage.SwitchWeaponDestroy");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchWeaponLeft;
    /// <summary>
    /// Function: SwitchWeaponLeft
    /// </summary>
    public unsafe virtual void SwitchWeaponLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchWeaponLeft, "BmGame.RStealthTakeDownStage.SwitchWeaponLeft");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchWeaponRight;
    /// <summary>
    /// Function: SwitchWeaponRight
    /// </summary>
    public unsafe virtual void SwitchWeaponRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchWeaponRight, "BmGame.RStealthTakeDownStage.SwitchWeaponRight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GrabWeapon;
    /// <summary>
    /// Function: GrabWeapon
    /// </summary>
    public unsafe virtual void GrabWeapon(bool bLeft, bool bDestroy)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrabWeapon, "BmGame.RStealthTakeDownStage.GrabWeapon");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLeft, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDestroy, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetVictim2TransitionID;
    /// <summary>
    /// Function: GetVictim2TransitionID
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId GetVictim2TransitionID()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVictim2TransitionID, "BmGame.RStealthTakeDownStage.GetVictim2TransitionID");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetVictim1TransitionID;
    /// <summary>
    /// Function: GetVictim1TransitionID
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId GetVictim1TransitionID()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVictim1TransitionID, "BmGame.RStealthTakeDownStage.GetVictim1TransitionID");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetAnimationSpeed;
    /// <summary>
    /// Function: ResetAnimationSpeed
    /// </summary>
    public unsafe virtual void ResetAnimationSpeed(BmSDK.BmGame.RPawnCharacter ResetCharacter, BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId ResetTransitionID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetAnimationSpeed, "BmGame.RStealthTakeDownStage.ResetAnimationSpeed");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResetCharacter, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResetTransitionID, paramsPtr + 8);
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

    private static BmSDK.Function __fn_ResetAttackerAndVictimAnimationSpeeds;
    /// <summary>
    /// Function: ResetAttackerAndVictimAnimationSpeeds
    /// </summary>
    public unsafe virtual void ResetAttackerAndVictimAnimationSpeeds()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetAttackerAndVictimAnimationSpeeds, "BmGame.RStealthTakeDownStage.ResetAttackerAndVictimAnimationSpeeds");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckEnvironmentTakedownRestrictions;
    /// <summary>
    /// Function: CheckEnvironmentTakedownRestrictions
    /// </summary>
    public unsafe virtual bool CheckEnvironmentTakedownRestrictions(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc, System.Numerics.Vector3 CheckDirection, BmSDK.Engine.AnimSet AttackerAnimSet, BmSDK.FName AttackerAnim, BmSDK.Engine.AnimSet VictimAnimSet, BmSDK.FName VictimAnim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckEnvironmentTakedownRestrictions, "BmGame.RStealthTakeDownStage.CheckEnvironmentTakedownRestrictions");
        byte* paramsPtr = stackalloc byte[180];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDirection, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackerAnimSet, paramsPtr + 144);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackerAnim, paramsPtr + 152);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VictimAnimSet, paramsPtr + 160);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VictimAnim, paramsPtr + 168);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 176);
    }

    private static BmSDK.Function __fn_GetGrateFinishAnimName;
    /// <summary>
    /// Function: GetGrateFinishAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetGrateFinishAnimName(BmSDK.FName CurrentAnimName, BmSDK.Engine.AnimSet AttackerSet, BmSDK.Engine.AnimSet VictimSet)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGrateFinishAnimName, "BmGame.RStealthTakeDownStage.GetGrateFinishAnimName");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentAnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackerSet, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VictimSet, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_FindBestEnvironmentTakedownAnims;
    /// <summary>
    /// Function: FindBestEnvironmentTakedownAnims
    /// </summary>
    public unsafe virtual bool FindBestEnvironmentTakedownAnims(out BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc, System.Numerics.Vector3 CheckDirection, BmSDK.Engine.AnimSet AttackerSet, BmSDK.FString AnimNamePrefix, out BmSDK.TArray<BmSDK.FName> AttackerNames, BmSDK.Engine.AnimSet VictimSet, out BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FAnimList> VictimNames)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindBestEnvironmentTakedownAnims, "BmGame.RStealthTakeDownStage.FindBestEnvironmentTakedownAnims");
        byte* paramsPtr = stackalloc byte[212];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDirection, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackerSet, paramsPtr + 144);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimNamePrefix, paramsPtr + 152);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VictimSet, paramsPtr + 184);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Loc = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(paramsPtr + 0);
        AttackerNames = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 168);
        VictimNames = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FAnimList>>(paramsPtr + 192);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 208);
    }

    private static BmSDK.Function __fn_ParseAttackerNotifies;
    /// <summary>
    /// Function: ParseAttackerNotifies
    /// </summary>
    public unsafe virtual void ParseAttackerNotifies(BmSDK.FName Anim, BmSDK.Engine.AnimSet Set)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ParseAttackerNotifies, "BmGame.RStealthTakeDownStage.ParseAttackerNotifies");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 8);
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

    private static BmSDK.Function __fn_FindAnimNamesByPrefix;
    /// <summary>
    /// Function: FindAnimNamesByPrefix
    /// </summary>
    public unsafe virtual void FindAnimNamesByPrefix(out BmSDK.BmGame.RStealthTakeDownStage.FTakeDownStageAnimSet StageAnimInfo, BmSDK.Engine.AnimSet AttackerSet, BmSDK.Engine.AnimSet VictimSet, BmSDK.Engine.AnimSet CameraSet)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAnimNamesByPrefix, "BmGame.RStealthTakeDownStage.FindAnimNamesByPrefix");
        byte* paramsPtr = stackalloc byte[332];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackerSet, paramsPtr + 308);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VictimSet, paramsPtr + 316);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraSet, paramsPtr + 324);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        StageAnimInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage.FTakeDownStageAnimSet>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_FindVictimFreeRagdollZone;
    /// <summary>
    /// Function: FindVictimFreeRagdollZone
    /// </summary>
    public unsafe virtual void FindVictimFreeRagdollZone(out System.Numerics.Vector3 ReferencePosition, BmSDK.Rotator ReferenceRotation, float MaxOffset = default, bool bOnlyCheckAABB = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindVictimFreeRagdollZone, "BmGame.RStealthTakeDownStage.FindVictimFreeRagdollZone");
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReferenceRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxOffset, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyCheckAABB, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ReferencePosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyBump;
    /// <summary>
    /// Function: NotifyBump
    /// </summary>
    public unsafe virtual void NotifyBump(BmSDK.Engine.Actor Other, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyBump, "BmGame.RStealthTakeDownStage.NotifyBump");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GrappleFromTakedownMove;
    /// <summary>
    /// Function: GrappleFromTakedownMove
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSpecialMoveConfig GrappleFromTakedownMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrappleFromTakedownMove, "BmGame.RStealthTakeDownStage.GrappleFromTakedownMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopRelativeTransition;
    /// <summary>
    /// Function: StopRelativeTransition
    /// </summary>
    public unsafe virtual void StopRelativeTransition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopRelativeTransition, "BmGame.RStealthTakeDownStage.StopRelativeTransition");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IgnoreHitReaction;
    /// <summary>
    /// Function: IgnoreHitReaction
    /// </summary>
    public unsafe virtual bool IgnoreHitReaction()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IgnoreHitReaction, "BmGame.RStealthTakeDownStage.IgnoreHitReaction");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CancelTakeDown;
    /// <summary>
    /// Function: CancelTakeDown
    /// </summary>
    public unsafe virtual void CancelTakeDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelTakeDown, "BmGame.RStealthTakeDownStage.CancelTakeDown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetPressed;
    /// <summary>
    /// Function: GadgetPressed
    /// </summary>
    public unsafe virtual void GadgetPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetPressed, "BmGame.RStealthTakeDownStage.GadgetPressed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StrikePressed;
    /// <summary>
    /// Function: StrikePressed
    /// </summary>
    public unsafe virtual void StrikePressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StrikePressed, "BmGame.RStealthTakeDownStage.StrikePressed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GrabReleased;
    /// <summary>
    /// Function: GrabReleased
    /// </summary>
    public unsafe virtual void GrabReleased()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrabReleased, "BmGame.RStealthTakeDownStage.GrabReleased");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SlowMoForEscapeTakedown;
    /// <summary>
    /// Function: SlowMoForEscapeTakedown
    /// </summary>
    public unsafe virtual bool SlowMoForEscapeTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SlowMoForEscapeTakedown, "BmGame.RStealthTakeDownStage.SlowMoForEscapeTakedown");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.RStealthTakeDownStage.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanAimGrapple;
    /// <summary>
    /// Function: CanAimGrapple
    /// </summary>
    public unsafe virtual bool CanAimGrapple()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanAimGrapple, "BmGame.RStealthTakeDownStage.CanAimGrapple");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NoInterrupt;
    /// <summary>
    /// Function: NoInterrupt
    /// </summary>
    public unsafe virtual void NoInterrupt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NoInterrupt, "BmGame.RStealthTakeDownStage.NoInterrupt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttackerDamaged;
    /// <summary>
    /// Function: AttackerDamaged
    /// </summary>
    public unsafe virtual void AttackerDamaged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttackerDamaged, "BmGame.RStealthTakeDownStage.AttackerDamaged");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanTakedownBeCancelledByDamage;
    /// <summary>
    /// Function: CanTakedownBeCancelledByDamage
    /// </summary>
    public unsafe virtual bool CanTakedownBeCancelledByDamage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTakedownBeCancelledByDamage, "BmGame.RStealthTakeDownStage.CanTakedownBeCancelledByDamage");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearCinematicCameraCollisionTarget;
    /// <summary>
    /// Function: ClearCinematicCameraCollisionTarget
    /// </summary>
    public unsafe virtual void ClearCinematicCameraCollisionTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCinematicCameraCollisionTarget, "BmGame.RStealthTakeDownStage.ClearCinematicCameraCollisionTarget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySpecialCameraAnim;
    /// <summary>
    /// Function: PlaySpecialCameraAnim
    /// </summary>
    public unsafe virtual bool PlaySpecialCameraAnim(BmSDK.FName AnimName, bool bCamMirrored, bool CameraCollision = default, float FOV = default, BmSDK.Engine.AnimSet CustomAnimSet = default, float BlendTime = default, bool bBlendCameraBackToPlayerCameraWhenFinished = default, bool bUseBatmanAsCameraCollisionTargetInsteadOfVictim = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySpecialCameraAnim, "BmGame.RStealthTakeDownStage.PlaySpecialCameraAnim");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCamMirrored, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraCollision, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomAnimSet, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendTime, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBlendCameraBackToPlayerCameraWhenFinished, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseBatmanAsCameraCollisionTargetInsteadOfVictim, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_MakeGrabbedNoise;
    /// <summary>
    /// Function: MakeGrabbedNoise
    /// </summary>
    public unsafe virtual void MakeGrabbedNoise(BmSDK.BmGame.RPawnPlayer Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeGrabbedNoise, "BmGame.RStealthTakeDownStage.MakeGrabbedNoise");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetReferencePosition;
    /// <summary>
    /// Function: GetReferencePosition
    /// </summary>
    public unsafe virtual void GetReferencePosition(out System.Numerics.Vector3 ReferencePosition, out BmSDK.Rotator ReferenceRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetReferencePosition, "BmGame.RStealthTakeDownStage.GetReferencePosition");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ReferencePosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        ReferenceRotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_Cancel;
    /// <summary>
    /// Function: Cancel
    /// </summary>
    public unsafe virtual void Cancel(bool SetState = default, bool bAbandonVictims = default, bool bResetPlayerPose = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Cancel, "BmGame.RStealthTakeDownStage.Cancel");
        byte* paramsPtr = stackalloc byte[280];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SetState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAbandonVictims, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetPlayerPose, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ComboHit;
    /// <summary>
    /// Function: ComboHit
    /// </summary>
    public unsafe virtual void ComboHit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ComboHit, "BmGame.RStealthTakeDownStage.ComboHit");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverrideChosenAnim;
    /// <summary>
    /// Function: OverrideChosenAnim
    /// </summary>
    public unsafe virtual void OverrideChosenAnim(out int Anim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideChosenAnim, "BmGame.RStealthTakeDownStage.OverrideChosenAnim");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Anim = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetFinishState;
    /// <summary>
    /// Function: GetFinishState
    /// </summary>
    public unsafe virtual BmSDK.FName GetFinishState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFinishState, "BmGame.RStealthTakeDownStage.GetFinishState");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EarlyFinish;
    /// <summary>
    /// Function: EarlyFinish
    /// </summary>
    public unsafe virtual void EarlyFinish()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EarlyFinish, "BmGame.RStealthTakeDownStage.EarlyFinish");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishAttackAttacker;
    /// <summary>
    /// Function: FinishAttackAttacker
    /// </summary>
    public unsafe virtual void FinishAttackAttacker()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishAttackAttacker, "BmGame.RStealthTakeDownStage.FinishAttackAttacker");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinaleCamera;
    /// <summary>
    /// Function: FinaleCamera
    /// </summary>
    public unsafe virtual void FinaleCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinaleCamera, "BmGame.RStealthTakeDownStage.FinaleCamera");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldUseRagdollDamping;
    /// <summary>
    /// Function: ShouldUseRagdollDamping
    /// </summary>
    public unsafe virtual bool ShouldUseRagdollDamping(BmSDK.BmGame.RPawnVillain TheVictim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldUseRagdollDamping, "BmGame.RStealthTakeDownStage.ShouldUseRagdollDamping");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheVictim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetWritheAnim;
    /// <summary>
    /// Function: GetWritheAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetWritheAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWritheAnim, "BmGame.RStealthTakeDownStage.GetWritheAnim");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerKOEvents;
    /// <summary>
    /// Function: TriggerKOEvents
    /// </summary>
    public unsafe virtual void TriggerKOEvents(BmSDK.Class EventClass, int iVictimNumber)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerKOEvents, "BmGame.RStealthTakeDownStage.TriggerKOEvents");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iVictimNumber, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerIceSmashTakedownEvent;
    /// <summary>
    /// Function: TriggerIceSmashTakedownEvent
    /// </summary>
    public unsafe virtual void TriggerIceSmashTakedownEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerIceSmashTakedownEvent, "BmGame.RStealthTakeDownStage.TriggerIceSmashTakedownEvent");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerSnaredTakedownEvent;
    /// <summary>
    /// Function: TriggerSnaredTakedownEvent
    /// </summary>
    public unsafe virtual void TriggerSnaredTakedownEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSnaredTakedownEvent, "BmGame.RStealthTakeDownStage.TriggerSnaredTakedownEvent");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishAttackVictim;
    /// <summary>
    /// Function: FinishAttackVictim
    /// </summary>
    public unsafe virtual bool FinishAttackVictim(int iVictimNumber)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishAttackVictim, "BmGame.RStealthTakeDownStage.FinishAttackVictim");
        byte* paramsPtr = stackalloc byte[292];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iVictimNumber, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ResetCameraBehindBatman;
    /// <summary>
    /// Function: ResetCameraBehindBatman
    /// </summary>
    public unsafe virtual bool ResetCameraBehindBatman(out BmSDK.Rotator out_ResetRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetCameraBehindBatman, "BmGame.RStealthTakeDownStage.ResetCameraBehindBatman");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_ResetRotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_End;
    /// <summary>
    /// Function: End
    /// </summary>
    public unsafe virtual void End(bool bLastStage = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_End, "BmGame.RStealthTakeDownStage.End");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLastStage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoStage;
    /// <summary>
    /// Function: GotoStage
    /// </summary>
    public unsafe virtual void GotoStage(BmSDK.BmGame.RGameInfo.EStealthTakeDownStages NextStageClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoStage, "BmGame.RStealthTakeDownStage.GotoStage");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextStageClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoStageEx;
    /// <summary>
    /// Function: GotoStageEx
    /// </summary>
    public unsafe virtual void GotoStageEx(BmSDK.BmGame.RGameInfo.EStealthTakeDownStages NextStageClass, bool bClientRequest = default, BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator EscapeLoc = default, bool bEscapeTakedown = default, bool bNextStageIsFearTakedown = default, bool bNextStageIsKnockoutSmash = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoStageEx, "BmGame.RStealthTakeDownStage.GotoStageEx");
        byte* paramsPtr = stackalloc byte[172];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextStageClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bClientRequest, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EscapeLoc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEscapeTakedown, paramsPtr + 140);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNextStageIsFearTakedown, paramsPtr + 144);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNextStageIsKnockoutSmash, paramsPtr + 148);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNextStage;
    /// <summary>
    /// Function: GetNextStage
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.EStealthTakeDownStages GetNextStage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextStage, "BmGame.RStealthTakeDownStage.GetNextStage");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStealthTakeDownStages>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RStealthTakeDownStage.Tick");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerNextStage;
    /// <summary>
    /// Function: TriggerNextStage
    /// </summary>
    public unsafe virtual void TriggerNextStage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerNextStage, "BmGame.RStealthTakeDownStage.TriggerNextStage");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerVictimFrozen;
    /// <summary>
    /// Function: TriggerVictimFrozen
    /// </summary>
    public unsafe virtual void TriggerVictimFrozen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerVictimFrozen, "BmGame.RStealthTakeDownStage.TriggerVictimFrozen");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerVictimNotFrozen;
    /// <summary>
    /// Function: TriggerVictimNotFrozen
    /// </summary>
    public unsafe virtual void TriggerVictimNotFrozen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerVictimNotFrozen, "BmGame.RStealthTakeDownStage.TriggerVictimNotFrozen");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerVictim;
    /// <summary>
    /// Function: TriggerVictim
    /// </summary>
    public unsafe virtual void TriggerVictim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerVictim, "BmGame.RStealthTakeDownStage.TriggerVictim");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayVictimAnim;
    /// <summary>
    /// Function: PlayVictimAnim
    /// </summary>
    public unsafe virtual void PlayVictimAnim(int iVictimNumber, float OverrideStartTime = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayVictimAnim, "BmGame.RStealthTakeDownStage.PlayVictimAnim");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iVictimNumber, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideStartTime, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChooseVictimAnimSet;
    /// <summary>
    /// Function: ChooseVictimAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet ChooseVictimAnimSet(BmSDK.BmGame.RPawnPlayer Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChooseVictimAnimSet, "BmGame.RStealthTakeDownStage.ChooseVictimAnimSet");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPlayerAnimset;
    /// <summary>
    /// Function: GetPlayerAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetPlayerAnimset(BmSDK.BmGame.RPawnPlayer Attacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerAnimset, "BmGame.RStealthTakeDownStage.GetPlayerAnimset");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsValidAnimSet;
    /// <summary>
    /// Function: IsValidAnimSet
    /// </summary>
    public unsafe virtual bool IsValidAnimSet(BmSDK.FString AnimPrefix, BmSDK.FString AnimSuffix, BmSDK.TArray<BmSDK.FName> AnimNames, BmSDK.Engine.AnimSet TestAnimSet)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidAnimSet, "BmGame.RStealthTakeDownStage.IsValidAnimSet");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPrefix, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSuffix, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimNames, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestAnimSet, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 56);
    }

    private static BmSDK.Function __fn_GetAimingConfig;
    /// <summary>
    /// Function: GetAimingConfig
    /// </summary>
    public unsafe virtual BmSDK.Engine.RAimingConfig GetAimingConfig()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAimingConfig, "BmGame.RStealthTakeDownStage.GetAimingConfig");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAimingConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopPlayerFallingOffEdges;
    /// <summary>
    /// Function: StopPlayerFallingOffEdges
    /// </summary>
    public unsafe virtual void StopPlayerFallingOffEdges()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopPlayerFallingOffEdges, "BmGame.RStealthTakeDownStage.StopPlayerFallingOffEdges");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverrideDestPose;
    /// <summary>
    /// Function: OverrideDestPose
    /// </summary>
    public unsafe virtual void OverrideDestPose(out BmSDK.FName DestPoseOverride)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideDestPose, "BmGame.RStealthTakeDownStage.OverrideDestPose");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DestPoseOverride = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_Begin;
    /// <summary>
    /// Function: Begin
    /// </summary>
    public unsafe virtual void Begin()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Begin, "BmGame.RStealthTakeDownStage.Begin");
        byte* paramsPtr = stackalloc byte[180];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPC;
    /// <summary>
    /// Function: GetPC
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPlayerControllerCombat GetPC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPC, "BmGame.RStealthTakeDownStage.GetPC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerControllerCombat>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAttacker;
    /// <summary>
    /// Function: GetAttacker
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayer GetAttacker()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAttacker, "BmGame.RStealthTakeDownStage.GetAttacker");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FillInAnimNames;
    /// <summary>
    /// Function: FillInAnimNames
    /// </summary>
    public unsafe virtual void FillInAnimNames()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FillInAnimNames, "BmGame.RStealthTakeDownStage.FillInAnimNames");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPoseFinalMirrored;
    /// <summary>
    /// Function: GetPoseFinalMirrored
    /// </summary>
    public unsafe virtual bool GetPoseFinalMirrored()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPoseFinalMirrored, "BmGame.RStealthTakeDownStage.GetPoseFinalMirrored");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStageAnim;
    /// <summary>
    /// Function: GetStageAnim
    /// </summary>
    public unsafe virtual int GetStageAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStageAnim, "BmGame.RStealthTakeDownStage.GetStageAnim");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AddVictim;
    /// <summary>
    /// Function: AddVictim
    /// </summary>
    public unsafe virtual void AddVictim(BmSDK.BmGame.RPawnVillain Pawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddVictim, "BmGame.RStealthTakeDownStage.AddVictim");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowCombat;
    /// <summary>
    /// Function: AllowCombat
    /// </summary>
    public unsafe virtual void AllowCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowCombat, "BmGame.RStealthTakeDownStage.AllowCombat");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndJokerHallucination;
    /// <summary>
    /// Function: EndJokerHallucination
    /// </summary>
    public unsafe virtual void EndJokerHallucination()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndJokerHallucination, "BmGame.RStealthTakeDownStage.EndJokerHallucination");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoSlavedJokerHallucination;
    /// <summary>
    /// Function: DoSlavedJokerHallucination
    /// </summary>
    public unsafe virtual void DoSlavedJokerHallucination(bool bIgnoreCollisionCheck, BmSDK.BmGame.RPawnJokerHallucination.TypesOfHallucination HallucinationType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoSlavedJokerHallucination, "BmGame.RStealthTakeDownStage.DoSlavedJokerHallucination");
        byte* paramsPtr = stackalloc byte[49];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreCollisionCheck, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HallucinationType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlayerCharacterUseSlomo;
    /// <summary>
    /// Function: CanPlayerCharacterUseSlomo
    /// </summary>
    public unsafe virtual bool CanPlayerCharacterUseSlomo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayerCharacterUseSlomo, "BmGame.RStealthTakeDownStage.CanPlayerCharacterUseSlomo");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetJokerHallucinationType;
    /// <summary>
    /// Function: GetJokerHallucinationType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnJokerHallucination.TypesOfHallucination GetJokerHallucinationType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJokerHallucinationType, "BmGame.RStealthTakeDownStage.GetJokerHallucinationType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnJokerHallucination.TypesOfHallucination>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetJokerHallucinationFadeMultiplier;
    /// <summary>
    /// Function: GetJokerHallucinationFadeMultiplier
    /// </summary>
    public unsafe virtual int GetJokerHallucinationFadeMultiplier()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJokerHallucinationFadeMultiplier, "BmGame.RStealthTakeDownStage.GetJokerHallucinationFadeMultiplier");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ModifyReferencePositionForSlope;
    /// <summary>
    /// Function: ModifyReferencePositionForSlope
    /// </summary>
    public unsafe virtual void ModifyReferencePositionForSlope(out System.Numerics.Vector3 ReferencePosition, out BmSDK.Rotator ReferenceRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyReferencePositionForSlope, "BmGame.RStealthTakeDownStage.ModifyReferencePositionForSlope");
        byte* paramsPtr = stackalloc byte[24];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ReferencePosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        ReferenceRotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Enum: EEscapeTakedownType
    /// </summary>
    public enum EEscapeTakedownType : byte
    {
        EFT_KOSmash = 0,
        EFT_Grate = 1,
        EFT_Grapple = 2,
        EFT_Ledge = 3,
        EFT_MAX = 4,
    }

    /// <summary>
    /// Struct: FVictimStruct
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FVictimStruct
    {
        /// <summary>
        /// ObjectProperty: Victim
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnVillain Victim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: ControlledBehaviour
        /// </summary>
        public unsafe BmSDK.BmGame.RBMBehaviour ControlledBehaviour
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: VictimController
        /// </summary>
        public unsafe BmSDK.BmGame.RBMAIController VictimController
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bVictimFinished
        /// </summary>
        public unsafe bool bVictimFinished
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: Victim
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain Victim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: Victim2
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain Victim2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: ControlledBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour_BeingTakenDown ControlledBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_BeingTakenDown>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: CachedAttacker
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer CachedAttacker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: NotifyTakedownCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_TakedownCamera NotifyTakedownCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_TakedownCamera>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: Grate
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase Grate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ClassProperty: DamageType
    /// </summary>
    public unsafe BmSDK.Class DamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ArrayProperty: StageAnim
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FTakeDownStageAnimSet> StageAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FTakeDownStageAnimSet>>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ByteProperty: NextStage
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EStealthTakeDownStages NextStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStealthTakeDownStages>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ByteProperty: AISilentTakedownType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.AAITakedownType AISilentTakedownType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.AAITakedownType>(Ptr + 741); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 741); }
    }

    /// <summary>
    /// ByteProperty: BluntTraumaAchievementCategory
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.BluntTraumaTakedowns BluntTraumaAchievementCategory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.BluntTraumaTakedowns>(Ptr + 742); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 742); }
    }

    /// <summary>
    /// ByteProperty: EscapeTakedown
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage.EEscapeTakedownType EscapeTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage.EEscapeTakedownType>(Ptr + 743); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 743); }
    }

    /// <summary>
    /// BoolProperty: bAutomaticTransitionTypeChangeAfterMeetingPoint
    /// </summary>
    public unsafe bool bAutomaticTransitionTypeChangeAfterMeetingPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bDisableCollision
    /// </summary>
    public unsafe bool bDisableCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bVictimKnocksOverOtherThugs
    /// </summary>
    public unsafe bool bVictimKnocksOverOtherThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bCharactersStartSynced
    /// </summary>
    public unsafe bool bCharactersStartSynced
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bMirrored
    /// </summary>
    public unsafe bool bMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bPlayedCameraAnim
    /// </summary>
    public unsafe bool bPlayedCameraAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bSlaveCameraToAttackerMesh
    /// </summary>
    public unsafe bool bSlaveCameraToAttackerMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bUseDOFSettingsForSpecialCameraAnim
    /// </summary>
    public unsafe bool bUseDOFSettingsForSpecialCameraAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bIsNoisy
    /// </summary>
    public unsafe bool bIsNoisy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bUseDofChange
    /// </summary>
    public unsafe bool bUseDofChange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: HasDoneFinaleCamera
    /// </summary>
    public unsafe bool HasDoneFinaleCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bPlayedFinaleCamera
    /// </summary>
    public unsafe bool bPlayedFinaleCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: AlwaysDoAnimatedFinaleCam
    /// </summary>
    public unsafe bool AlwaysDoAnimatedFinaleCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bFatal
    /// </summary>
    public unsafe bool bFatal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bStartsRagdoll
    /// </summary>
    public unsafe bool bStartsRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bAllowEarlyFinish
    /// </summary>
    public unsafe bool bAllowEarlyFinish
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bVictimFinished
    /// </summary>
    public unsafe bool bVictimFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bNotFirstStage
    /// </summary>
    public unsafe bool bNotFirstStage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bUseLastTakedownId
    /// </summary>
    public unsafe bool bUseLastTakedownId
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bUseLastStageAnimId
    /// </summary>
    public unsafe bool bUseLastStageAnimId
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bSynchToAttackerTime
    /// </summary>
    public unsafe bool bSynchToAttackerTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bAllowAuthority
    /// </summary>
    public unsafe bool bAllowAuthority
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bDisarmVictimAtStart
    /// </summary>
    public unsafe bool bDisarmVictimAtStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bUseVictimReferenceLocation
    /// </summary>
    public unsafe bool bUseVictimReferenceLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bSynchVictimRefPoint
    /// </summary>
    public unsafe bool bSynchVictimRefPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: SupressFinaleCamera
    /// </summary>
    public unsafe bool SupressFinaleCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bCanBeAttacked
    /// </summary>
    public unsafe bool bCanBeAttacked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredFromCorner
    /// </summary>
    public unsafe bool bTriggeredFromCorner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bStartsCombo
    /// </summary>
    public unsafe bool bStartsCombo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bBreaksWindow
    /// </summary>
    public unsafe bool bBreaksWindow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bDoingIdle
    /// </summary>
    public unsafe bool bDoingIdle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bAllowCombat
    /// </summary>
    public unsafe bool bAllowCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bAllowFallOffEdges
    /// </summary>
    public unsafe bool bAllowFallOffEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bInSmoke
    /// </summary>
    public unsafe bool bInSmoke
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bVictimUseCleanPoseChange
    /// </summary>
    public unsafe bool bVictimUseCleanPoseChange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bDelayVictimReaction
    /// </summary>
    public unsafe bool bDelayVictimReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bUseFallbackAnimSet
    /// </summary>
    public unsafe bool bUseFallbackAnimSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bGrabbedWeapon
    /// </summary>
    public unsafe bool bGrabbedWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bCanGrabWeapon
    /// </summary>
    public unsafe bool bCanGrabWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bUseCapeAnimNotifies
    /// </summary>
    public unsafe bool bUseCapeAnimNotifies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bCanDoEscapeTakedown
    /// </summary>
    public unsafe bool bCanDoEscapeTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysAllowLedgeFinish
    /// </summary>
    public unsafe bool bAlwaysAllowLedgeFinish
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bFearTakedown
    /// </summary>
    public unsafe bool bFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bKnockoutSmash
    /// </summary>
    public unsafe bool bKnockoutSmash
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bPlayerPressedButtonToGoToNextFearTakedown
    /// </summary>
    public unsafe bool bPlayerPressedButtonToGoToNextFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bAcceptingButtonPressForFearTakedown
    /// </summary>
    public unsafe bool bAcceptingButtonPressForFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bRefundFearTakedownCost
    /// </summary>
    public unsafe bool bRefundFearTakedownCost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bChainingFromLedge
    /// </summary>
    public unsafe bool bChainingFromLedge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bChainingFromWeakWall
    /// </summary>
    public unsafe bool bChainingFromWeakWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bAttackerDamagedDuringTakedown
    /// </summary>
    public unsafe bool bAttackerDamagedDuringTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bDisableCameraCollisionDuringBlendBackToPlayer
    /// </summary>
    public unsafe bool bDisableCameraCollisionDuringBlendBackToPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bCanDoFinaleCameraInCombat
    /// </summary>
    public unsafe bool bCanDoFinaleCameraInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bUseCharacterBonesOnlyForRagdollZoneSearch
    /// </summary>
    public unsafe bool bUseCharacterBonesOnlyForRagdollZoneSearch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// NameProperty: CameraState
    /// </summary>
    public unsafe BmSDK.FName CameraState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// StructProperty: AttackLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AttackLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 760);

    /// <summary>
    /// StructProperty: ImpactScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 772);

    /// <summary>
    /// StructProperty: CameraDOFSettings
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGameInfo.FDofStruct CameraDOFSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameInfo.FDofStruct>(Ptr + 928);

    /// <summary>
    /// StructProperty: StageAnims
    /// </summary>
    public unsafe ref BmSDK.BmGame.RStealthTakeDownStage.FTakeDownStageAnimSet StageAnims
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RStealthTakeDownStage.FTakeDownStageAnimSet>(Ptr + 948);

    /// <summary>
    /// IntProperty: StageAnimId
    /// </summary>
    public unsafe int StageAnimId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// IntProperty: Damage
    /// </summary>
    public unsafe int Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// StructProperty: TakeDownTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId TakeDownTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 1264);

    /// <summary>
    /// ArrayProperty: VictimTransitions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId> VictimTransitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// StructProperty: CustomLocator
    /// </summary>
    public unsafe ref BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator CustomLocator
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(Ptr + 1284);

    /// <summary>
    /// IntProperty: MinVictims
    /// </summary>
    public unsafe int MinVictims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// IntProperty: MaxVictims
    /// </summary>
    public unsafe int MaxVictims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// StructProperty: LastReferencePosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastReferencePosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1424);

    /// <summary>
    /// StructProperty: LastReferenceRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator LastReferenceRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1436);

    /// <summary>
    /// StructProperty: VictimReferencePosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VictimReferencePosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1448);

    /// <summary>
    /// StructProperty: VictimReferenceRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator VictimReferenceRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1460);

    /// <summary>
    /// IntProperty: ChosenAnim
    /// </summary>
    public unsafe int ChosenAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// FloatProperty: RateScale
    /// </summary>
    public unsafe float RateScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// ArrayProperty: Victims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FVictimStruct> Victims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FVictimStruct>>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// ArrayProperty: GameActionsToTriggerOnFinish
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> GameActionsToTriggerOnFinish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// FloatProperty: NotifyTakedownCameraTime
    /// </summary>
    public unsafe float NotifyTakedownCameraTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// StructProperty: EscapeLocator
    /// </summary>
    public unsafe ref BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator EscapeLocator
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(Ptr + 1516);

    /// <summary>
    /// IntProperty: iFearTakedownEnergyCost
    /// </summary>
    public unsafe int iFearTakedownEnergyCost
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1648); }
    }

    /// <summary>
    /// FloatProperty: fTimeSpentDoingTakedown
    /// </summary>
    public unsafe float fTimeSpentDoingTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1652); }
    }

    /// <summary>
    /// FloatProperty: fVictimDropWeaponTime
    /// </summary>
    public unsafe float fVictimDropWeaponTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1656); }
    }

    /// <summary>
    /// FloatProperty: fStartingNoInterruptDuration
    /// </summary>
    public unsafe float fStartingNoInterruptDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }

    /// <summary>
    /// Enum: AttackApproachDirection
    /// </summary>
    public enum AttackApproachDirection : byte
    {
        AAP_Back = 0,
        AAP_Front = 1,
        AAP_Left = 2,
        AAP_Right = 3,
        AAP_Environment = 4,
        AAP_MAX = 5,
    }

    /// <summary>
    /// Struct: FTakeDownStageAnimSet
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 308)]
    public partial record struct FTakeDownStageAnimSet
    {
        /// <summary>
        /// ArrayProperty: AttackerAnimation
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> AttackerAnimation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: AttackerIdle
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> AttackerIdle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: AttackerAnimationPrefix
        /// </summary>
        public unsafe BmSDK.FString AttackerAnimationPrefix
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StrProperty: AttackerAnimationSuffix
        /// </summary>
        public unsafe BmSDK.FString AttackerAnimationSuffix
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// ObjectProperty: AttackerAnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet AttackerAnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// NameProperty: DefaultCapeStateName
        /// </summary>
        public unsafe BmSDK.FName DefaultCapeStateName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// ArrayProperty: CapeStateName
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> CapeStateName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// ArrayProperty: CapeAnimName
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> CapeAnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// NameProperty: CapeFinishStateName
        /// </summary>
        public unsafe BmSDK.FName CapeFinishStateName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }

        /// <summary>
        /// ArrayProperty: VictimAnimations
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FAnimList> VictimAnimations
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FAnimList>>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }

        /// <summary>
        /// ArrayProperty: VictimIdle
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> VictimIdle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }; }
        }

        /// <summary>
        /// StrProperty: VictimAnimationPrefix
        /// </summary>
        public unsafe BmSDK.FString VictimAnimationPrefix
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }; }
        }

        /// <summary>
        /// StrProperty: VictimAnimationSuffix
        /// </summary>
        public unsafe BmSDK.FString VictimAnimationSuffix
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }; }
        }

        /// <summary>
        /// ObjectProperty: VictimAnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet VictimAnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 184); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }; }
        }

        /// <summary>
        /// FloatProperty: MeetingTime
        /// </summary>
        public unsafe float MeetingTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }; }
        }

        /// <summary>
        /// FloatProperty: AnimatedCameraFOV
        /// </summary>
        public unsafe float AnimatedCameraFOV
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }; }
        }

        /// <summary>
        /// BoolProperty: bMirrored
        /// </summary>
        public unsafe bool bMirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 200); }; }
        }

        /// <summary>
        /// NameProperty: AttackerEndPose
        /// </summary>
        public unsafe BmSDK.FName AttackerEndPose
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 204); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }; }
        }

        /// <summary>
        /// NameProperty: VictimEndPose
        /// </summary>
        public unsafe BmSDK.FName VictimEndPose
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 212); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }; }
        }

        /// <summary>
        /// ObjectProperty: CameraAnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet CameraAnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 220); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }; }
        }

        /// <summary>
        /// NameProperty: CameraAnimation
        /// </summary>
        public unsafe BmSDK.FName CameraAnimation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 228); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }; }
        }

        /// <summary>
        /// ArrayProperty: CameraAnimations
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> CameraAnimations
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 236); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }; }
        }

        /// <summary>
        /// StrProperty: CameraAnimationPrefix
        /// </summary>
        public unsafe BmSDK.FString CameraAnimationPrefix
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 252); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }; }
        }

        /// <summary>
        /// StrProperty: CameraAnimationSuffix
        /// </summary>
        public unsafe BmSDK.FString CameraAnimationSuffix
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 268); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }; }
        }

        /// <summary>
        /// BoolProperty: OverlayAnim
        /// </summary>
        public unsafe bool OverlayAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }; }
        }

        /// <summary>
        /// BoolProperty: ForceCameraAnimation
        /// </summary>
        public unsafe bool ForceCameraAnimation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }; }
        }

        /// <summary>
        /// BoolProperty: bBlendBackToPlayerCameraWhenFinishedCameraAnimation
        /// </summary>
        public unsafe bool bBlendBackToPlayerCameraWhenFinishedCameraAnimation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }; }
        }

        /// <summary>
        /// BoolProperty: CameraCollision
        /// </summary>
        public unsafe bool CameraCollision
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }; }
        }

        /// <summary>
        /// BoolProperty: bUseBatmanAsCameraCollisionTargetInsteadOfVictim
        /// </summary>
        public unsafe bool bUseBatmanAsCameraCollisionTargetInsteadOfVictim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }; }
        }

        /// <summary>
        /// BoolProperty: bCameraHardCut
        /// </summary>
        public unsafe bool bCameraHardCut
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }; }
        }

        /// <summary>
        /// FloatProperty: fCameraBlendInTime
        /// </summary>
        public unsafe float fCameraBlendInTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 288); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }; }
        }

        /// <summary>
        /// ByteProperty: OnStairsAnimIndex
        /// </summary>
        public unsafe byte OnStairsAnimIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 292); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }; }
        }

        /// <summary>
        /// BoolProperty: bUseMovementAnimSet
        /// </summary>
        public unsafe bool bUseMovementAnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }; }
        }

        /// <summary>
        /// BoolProperty: bUsePredatorOverrideAnimSets
        /// </summary>
        public unsafe bool bUsePredatorOverrideAnimSets
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }; }
        }

        /// <summary>
        /// NameProperty: StrikeBone
        /// </summary>
        public unsafe BmSDK.FName StrikeBone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 300); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }; }
        }
    }

    /// <summary>
    /// Struct: FAnimList
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FAnimList
    {
        /// <summary>
        /// ArrayProperty: Anims
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> Anims
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }
}
