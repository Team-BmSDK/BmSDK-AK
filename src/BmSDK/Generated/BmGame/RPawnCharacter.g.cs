#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPawnCharacter<br/>
/// (size = 2660)
/// (flags = 144703671)
/// </summary>
public partial class RPawnCharacter : BmSDK.BmGame.RPawn, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnCharacter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnCharacter.
    /// </summary>
    public static RPawnCharacter DefaultObject => (RPawnCharacter)StaticClass().DefaultObject;

    internal RPawnCharacter() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnCharacter(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ReAddShadowReflectionPlane;
    /// <summary>
    /// Function: ReAddShadowReflectionPlane
    /// </summary>
    public unsafe virtual void ReAddShadowReflectionPlane()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReAddShadowReflectionPlane, "BmGame.RPawnCharacter.ReAddShadowReflectionPlane");
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

    private static BmSDK.Function __fn_RemoveShadowReflectionPlane;
    /// <summary>
    /// Function: RemoveShadowReflectionPlane
    /// </summary>
    public unsafe virtual void RemoveShadowReflectionPlane()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveShadowReflectionPlane, "BmGame.RPawnCharacter.RemoveShadowReflectionPlane");
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

    private static BmSDK.Function __fn_SetHidden;
    /// <summary>
    /// Function: SetHidden
    /// </summary>
    public unsafe override void SetHidden(bool bNewHidden)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHidden, "BmGame.RPawnCharacter.SetHidden");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewHidden, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateWeaponRainMaterials;
    /// <summary>
    /// Function: UpdateWeaponRainMaterials
    /// </summary>
    public unsafe virtual void UpdateWeaponRainMaterials(BmSDK.FName nWeaponRainParameterName, BmSDK.GameObject.FLinearColor WeaponRainDirectionColour)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateWeaponRainMaterials, "BmGame.RPawnCharacter.UpdateWeaponRainMaterials");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nWeaponRainParameterName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponRainDirectionColour, paramsPtr + 8);
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

    private static BmSDK.Function __fn_UpdateRainMaterials;
    /// <summary>
    /// Function: UpdateRainMaterials
    /// </summary>
    public unsafe virtual void UpdateRainMaterials(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRainMaterials, "BmGame.RPawnCharacter.UpdateRainMaterials");
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

    private static BmSDK.Function __fn_PlayCharacterBark;
    /// <summary>
    /// Function: PlayCharacterBark
    /// </summary>
    public unsafe virtual void PlayCharacterBark(BmSDK.Engine.AkDialogueConversation aBark, bool bRejectIfInterruptsAnySpeech = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCharacterBark, "BmGame.RPawnCharacter.PlayCharacterBark");
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aBark, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRejectIfInterruptsAnySpeech, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnTeleport;
    /// <summary>
    /// Function: OnTeleport
    /// </summary>
    public unsafe override void OnTeleport(BmSDK.Engine.SeqAct_Teleport Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnTeleport, "BmGame.RPawnCharacter.OnTeleport");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeleteRiotObjects;
    /// <summary>
    /// Function: DeleteRiotObjects
    /// </summary>
    public unsafe virtual void DeleteRiotObjects()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeleteRiotObjects, "BmGame.RPawnCharacter.DeleteRiotObjects");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RiotPickupNotify;
    /// <summary>
    /// Function: RiotPickupNotify
    /// </summary>
    public unsafe virtual void RiotPickupNotify(BmSDK.BmGame.RAnimNotify_PickupProp PickupNotify)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RiotPickupNotify, "BmGame.RPawnCharacter.RiotPickupNotify");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PickupNotify, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropRiotObject;
    /// <summary>
    /// Function: DropRiotObject
    /// </summary>
    public unsafe virtual void DropRiotObject(out BmSDK.BmGame.RRiotObjectBase RiotObject, BmSDK.BmGame.RAnimNotify_PickupProp PickupNotify = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropRiotObject, "BmGame.RPawnCharacter.DropRiotObject");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PickupNotify, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RiotObject = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRiotObjectBase>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnObject;
    /// <summary>
    /// Function: SpawnObject
    /// </summary>
    public unsafe virtual void SpawnObject(out BmSDK.BmGame.RRiotObjectBase RiotObject)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnObject, "BmGame.RPawnCharacter.SpawnObject");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RiotObject = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRiotObjectBase>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessRiotPickupNotify;
    /// <summary>
    /// Function: ProcessRiotPickupNotify
    /// </summary>
    public unsafe virtual void ProcessRiotPickupNotify(BmSDK.BmGame.RAnimNotify_PickupProp PickupNotify)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessRiotPickupNotify, "BmGame.RPawnCharacter.ProcessRiotPickupNotify");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PickupNotify, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropProps;
    /// <summary>
    /// Function: DropProps
    /// </summary>
    public unsafe virtual void DropProps()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropProps, "BmGame.RPawnCharacter.DropProps");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachCombatAnimsToBase;
    /// <summary>
    /// Function: AttachCombatAnimsToBase
    /// </summary>
    public unsafe virtual bool AttachCombatAnimsToBase()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachCombatAnimsToBase, "BmGame.RPawnCharacter.AttachCombatAnimsToBase");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetActorSpacePosFromWorldSpace;
    /// <summary>
    /// Function: GetActorSpacePosFromWorldSpace
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetActorSpacePosFromWorldSpace(BmSDK.Engine.Actor RelativeActor, System.Numerics.Vector3 WorldSpacePos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActorSpacePosFromWorldSpace, "BmGame.RPawnCharacter.GetActorSpacePosFromWorldSpace");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelativeActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldSpacePos, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetWorldSpacePosFromActorSpace;
    /// <summary>
    /// Function: GetWorldSpacePosFromActorSpace
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetWorldSpacePosFromActorSpace(BmSDK.Engine.Actor RelativeActor, System.Numerics.Vector3 ActorSpacePos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWorldSpacePosFromActorSpace, "BmGame.RPawnCharacter.GetWorldSpacePosFromActorSpace");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelativeActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorSpacePos, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_SetCombatTransitionRelativeToBaseActor;
    /// <summary>
    /// Function: SetCombatTransitionRelativeToBaseActor
    /// </summary>
    public unsafe virtual void SetCombatTransitionRelativeToBaseActor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCombatTransitionRelativeToBaseActor, "BmGame.RPawnCharacter.SetCombatTransitionRelativeToBaseActor");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTransitionRelativeToBaseActor;
    /// <summary>
    /// Function: SetTransitionRelativeToBaseActor
    /// </summary>
    public unsafe virtual void SetTransitionRelativeToBaseActor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTransitionRelativeToBaseActor, "BmGame.RPawnCharacter.SetTransitionRelativeToBaseActor");
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

    private static BmSDK.Function __fn_SetRelativeTargetOnBase_PosAndYaw;
    /// <summary>
    /// Function: SetRelativeTargetOnBase_PosAndYaw
    /// </summary>
    public unsafe virtual void SetRelativeTargetOnBase_PosAndYaw(System.Numerics.Vector3 NewPosition = default, int NewYaw = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRelativeTargetOnBase_PosAndYaw, "BmGame.RPawnCharacter.SetRelativeTargetOnBase_PosAndYaw");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewYaw, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRelativeTargetOnBase_PosAndRot;
    /// <summary>
    /// Function: SetRelativeTargetOnBase_PosAndRot
    /// </summary>
    public unsafe virtual void SetRelativeTargetOnBase_PosAndRot(System.Numerics.Vector3 NewPosition = default, BmSDK.Rotator NewRotation = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRelativeTargetOnBase_PosAndRot, "BmGame.RPawnCharacter.SetRelativeTargetOnBase_PosAndRot");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsNavMeshClearOfObstacles;
    /// <summary>
    /// Function: IsNavMeshClearOfObstacles
    /// </summary>
    public unsafe virtual bool IsNavMeshClearOfObstacles(System.Numerics.Vector3 StartPoint, System.Numerics.Vector3 TestPoint, System.Numerics.Vector3 TestExtent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNavMeshClearOfObstacles, "BmGame.RPawnCharacter.IsNavMeshClearOfObstacles");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestExtent, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_NavMeshPointReachable;
    /// <summary>
    /// Function: NavMeshPointReachable
    /// </summary>
    public unsafe virtual bool NavMeshPointReachable(System.Numerics.Vector3 TestPoint, out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, bool bCheckForFloor = default, System.Numerics.Vector3 OverrideStartLocation = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavMeshPointReachable, "BmGame.RPawnCharacter.NavMeshPointReachable");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckForFloor, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideStartLocation, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_SetupRainMaterials;
    /// <summary>
    /// Function: SetupRainMaterials
    /// </summary>
    public unsafe virtual void SetupRainMaterials()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupRainMaterials, "BmGame.RPawnCharacter.SetupRainMaterials");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerPlayRelativeTransition;
    /// <summary>
    /// Function: ServerPlayRelativeTransition
    /// </summary>
    public unsafe virtual void ServerPlayRelativeTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerPlayRelativeTransition, "BmGame.RPawnCharacter.ServerPlayRelativeTransition");
        byte* paramsPtr = stackalloc byte[164];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 100);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 152);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 156);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 160);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayReplicatedRelativeTransitionEx;
    /// <summary>
    /// Function: PlayReplicatedRelativeTransitionEx
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayReplicatedRelativeTransitionEx(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default, bool bReplicateToServer = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayReplicatedRelativeTransitionEx, "BmGame.RPawnCharacter.PlayReplicatedRelativeTransitionEx");
        byte* paramsPtr = stackalloc byte[176];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 100);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 152);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 156);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 160);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReplicateToServer, paramsPtr + 164);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 168);
    }

    private static BmSDK.Function __fn_PlayReplicatedRelativeTransition;
    /// <summary>
    /// Function: PlayReplicatedRelativeTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayReplicatedRelativeTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default, bool bReplicateToServer = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayReplicatedRelativeTransition, "BmGame.RPawnCharacter.PlayReplicatedRelativeTransition");
        byte* paramsPtr = stackalloc byte[176];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 100);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 152);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 156);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 160);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReplicateToServer, paramsPtr + 164);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 168);
    }

    private static BmSDK.Function __fn_ServerPlayRelativeTransitionRotationOnly;
    /// <summary>
    /// Function: ServerPlayRelativeTransitionRotationOnly
    /// </summary>
    public unsafe virtual void ServerPlayRelativeTransitionRotationOnly(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerPlayRelativeTransitionRotationOnly, "BmGame.RPawnCharacter.ServerPlayRelativeTransitionRotationOnly");
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 140);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 144);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 148);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayReplicatedRelativeTransitionRotationOnly;
    /// <summary>
    /// Function: PlayReplicatedRelativeTransitionRotationOnly
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayReplicatedRelativeTransitionRotationOnly(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default, bool bReplicateToServer = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayReplicatedRelativeTransitionRotationOnly, "BmGame.RPawnCharacter.PlayReplicatedRelativeTransitionRotationOnly");
        byte* paramsPtr = stackalloc byte[164];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 140);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 144);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 148);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReplicateToServer, paramsPtr + 152);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 156);
    }

    private static BmSDK.Function __fn_FaceRotation;
    /// <summary>
    /// Function: FaceRotation
    /// </summary>
    public unsafe override void FaceRotation(BmSDK.Rotator NewRotation, float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FaceRotation, "BmGame.RPawnCharacter.FaceRotation");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRotation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 12);
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

    private static BmSDK.Function __fn_UnPossessed;
    /// <summary>
    /// Function: UnPossessed
    /// </summary>
    public unsafe override void UnPossessed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnPossessed, "BmGame.RPawnCharacter.UnPossessed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmGame.RPawnCharacter.Died");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_MatineeTeleport;
    /// <summary>
    /// Function: MatineeTeleport
    /// </summary>
    public unsafe override void MatineeTeleport(BmSDK.Engine.InterpGroupInst InterpGroupInst, BmSDK.FName DebugSource)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatineeTeleport, "BmGame.RPawnCharacter.MatineeTeleport");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpGroupInst, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DebugSource, paramsPtr + 8);
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

    private static BmSDK.Function __fn_UpdateMatineeMovementTarget;
    /// <summary>
    /// Function: UpdateMatineeMovementTarget
    /// </summary>
    public unsafe virtual void UpdateMatineeMovementTarget(BmSDK.Engine.InterpGroupInst InterpGroupInst, System.Numerics.Vector3 TargetLocation, BmSDK.Rotator TargetRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMatineeMovementTarget, "BmGame.RPawnCharacter.UpdateMatineeMovementTarget");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpGroupInst, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetRotation, paramsPtr + 20);
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

    private static BmSDK.Function __fn_SetAnimPosition;
    /// <summary>
    /// Function: SetAnimPosition
    /// </summary>
    public unsafe override void SetAnimPosition(BmSDK.Engine.InterpGroupInst InterpGroupInst, BmSDK.FName SlotName, int ChannelIndex, BmSDK.FName InAnimSeqName, float InPosition, bool bFireNotifies, bool bLooping, bool bEnableRootMotion)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAnimPosition, "BmGame.RPawnCharacter.SetAnimPosition");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpGroupInst, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChannelIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAnimSeqName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPosition, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFireNotifies, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLooping, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableRootMotion, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlendOutAnimControl;
    /// <summary>
    /// Function: BlendOutAnimControl
    /// </summary>
    public unsafe override void BlendOutAnimControl(BmSDK.Engine.InterpGroup InInterpGroup, BmSDK.Engine.InterpGroupInst InInterpGroupInst, float BlendOutDuration)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlendOutAnimControl, "BmGame.RPawnCharacter.BlendOutAnimControl");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroupInst, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendOutDuration, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishAnimControl;
    /// <summary>
    /// Function: FinishAnimControl
    /// </summary>
    public unsafe override void FinishAnimControl(BmSDK.Engine.InterpGroup InInterpGroup, BmSDK.Engine.InterpGroupInst InInterpGroupInst)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishAnimControl, "BmGame.RPawnCharacter.FinishAnimControl");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroupInst, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginAnimControl;
    /// <summary>
    /// Function: BeginAnimControl
    /// </summary>
    public unsafe override void BeginAnimControl(BmSDK.Engine.InterpGroup InInterpGroup, BmSDK.Engine.InterpGroupInst InInterpGroupInst)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginAnimControl, "BmGame.RPawnCharacter.BeginAnimControl");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroupInst, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHasConstrainingComponent;
    /// <summary>
    /// Function: SetHasConstrainingComponent
    /// </summary>
    public unsafe virtual void SetHasConstrainingComponent(bool bHasConstrainingComponent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHasConstrainingComponent, "BmGame.RPawnCharacter.SetHasConstrainingComponent");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHasConstrainingComponent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe virtual void PostInitCharacter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmGame.RPawnCharacter.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupCustomPhysics;
    /// <summary>
    /// Function: SetupCustomPhysics
    /// </summary>
    public unsafe virtual void SetupCustomPhysics()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupCustomPhysics, "BmGame.RPawnCharacter.SetupCustomPhysics");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RPawnCharacter.Destroyed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetYawRadians;
    /// <summary>
    /// Function: SetYawRadians
    /// </summary>
    public unsafe virtual void SetYawRadians(float R)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetYawRadians, "BmGame.RPawnCharacter.SetYawRadians");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 0);
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

    private static BmSDK.Function __fn_DoRBFallAlert;
    /// <summary>
    /// Function: DoRBFallAlert
    /// </summary>
    public unsafe virtual void DoRBFallAlert()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoRBFallAlert, "BmGame.RPawnCharacter.DoRBFallAlert");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RigidBodyCollision;
    /// <summary>
    /// Function: RigidBodyCollision
    /// </summary>
    public unsafe override void RigidBodyCollision(BmSDK.Engine.PrimitiveComponent HitComponent, BmSDK.Engine.PrimitiveComponent OtherComponent, out BmSDK.Engine.Actor.FCollisionImpactData RigidCollisionData, int ContactIndex, float Speed, int Index0, int Index1)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RigidBodyCollision, "BmGame.RPawnCharacter.RigidBodyCollision");
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComponent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactIndex, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index0, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index1, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RigidCollisionData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.FCollisionImpactData>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_FinishedGetUp;
    /// <summary>
    /// Function: FinishedGetUp
    /// </summary>
    public unsafe virtual void FinishedGetUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedGetUp, "BmGame.RPawnCharacter.FinishedGetUp");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetForceGetUpTime;
    /// <summary>
    /// Function: GetForceGetUpTime
    /// </summary>
    public unsafe virtual float GetForceGetUpTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetForceGetUpTime, "BmGame.RPawnCharacter.GetForceGetUpTime");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CancelGetUpFromRagdoll;
    /// <summary>
    /// Function: CancelGetUpFromRagdoll
    /// </summary>
    public unsafe virtual void CancelGetUpFromRagdoll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelGetUpFromRagdoll, "BmGame.RPawnCharacter.CancelGetUpFromRagdoll");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsGettingUpFromRagdoll;
    /// <summary>
    /// Function: IsGettingUpFromRagdoll
    /// </summary>
    public unsafe virtual bool IsGettingUpFromRagdoll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGettingUpFromRagdoll, "BmGame.RPawnCharacter.IsGettingUpFromRagdoll");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartImmediateGetUp;
    /// <summary>
    /// Function: StartImmediateGetUp
    /// </summary>
    public unsafe virtual void StartImmediateGetUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartImmediateGetUp, "BmGame.RPawnCharacter.StartImmediateGetUp");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartGetUp;
    /// <summary>
    /// Function: StartGetUp
    /// </summary>
    public unsafe virtual void StartGetUp(bool bImmediate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGetUp, "BmGame.RPawnCharacter.StartGetUp");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bImmediate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetUpFromRagdollSlaved;
    /// <summary>
    /// Function: GetUpFromRagdollSlaved
    /// </summary>
    public unsafe virtual void GetUpFromRagdollSlaved(BmSDK.FName TargetMovementStance, BmSDK.FName TargetWeaponStance, BmSDK.BmGame.RPawnCharacter NewGetUpMaster, BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId NewGetUpMasterAnimID, BmSDK.Engine.AnimSet NewGetUpAnimset, BmSDK.FName NewGetUpAnimName, bool bAnimImmediate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUpFromRagdollSlaved, "BmGame.RPawnCharacter.GetUpFromRagdollSlaved");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetMovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetWeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpMaster, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpMasterAnimID, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpAnimset, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpAnimName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAnimImmediate, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetUpFromRagdoll;
    /// <summary>
    /// Function: GetUpFromRagdoll
    /// </summary>
    public unsafe virtual void GetUpFromRagdoll(BmSDK.FName TargetMovementStance, BmSDK.FName TargetWeaponStance, bool ForceGetup = default, BmSDK.Engine.AnimSet NewGetUpAnimset = default, BmSDK.FName NewGetUpAnimName = default, bool bImmediate = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUpFromRagdoll, "BmGame.RPawnCharacter.GetUpFromRagdoll");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetMovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetWeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceGetup, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpAnimset, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpAnimName, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bImmediate, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldSpeedUpGetUp;
    /// <summary>
    /// Function: ShouldSpeedUpGetUp
    /// </summary>
    public unsafe virtual bool ShouldSpeedUpGetUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSpeedUpGetUp, "BmGame.RPawnCharacter.ShouldSpeedUpGetUp");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnPlayedQueuedTransition;
    /// <summary>
    /// Function: OnPlayedQueuedTransition
    /// </summary>
    public unsafe virtual void OnPlayedQueuedTransition(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id, float TimeLeftOver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPlayedQueuedTransition, "BmGame.RPawnCharacter.OnPlayedQueuedTransition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchWeaponBoneCallback;
    /// <summary>
    /// Function: SwitchWeaponBoneCallback
    /// </summary>
    public unsafe virtual void SwitchWeaponBoneCallback(BmSDK.BmGame.RAnimNotify_SwitchWeaponBone NewNotify, BmSDK.BmGame.RAnimNotify_SwitchWeaponBone PreviousNotify)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchWeaponBoneCallback, "BmGame.RPawnCharacter.SwitchWeaponBoneCallback");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewNotify, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousNotify, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponSwitchCallback;
    /// <summary>
    /// Function: WeaponSwitchCallback
    /// </summary>
    public unsafe virtual void WeaponSwitchCallback(BmSDK.Engine.Inventory NewWeapon, BmSDK.Engine.Inventory PreviousWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponSwitchCallback, "BmGame.RPawnCharacter.WeaponSwitchCallback");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousWeapon, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheatFly;
    /// <summary>
    /// Function: CheatFly
    /// </summary>
    public unsafe override bool CheatFly()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheatFly, "BmGame.RPawnCharacter.CheatFly");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheatGhost;
    /// <summary>
    /// Function: CheatGhost
    /// </summary>
    public unsafe override bool CheatGhost()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheatGhost, "BmGame.RPawnCharacter.CheatGhost");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheatWalk;
    /// <summary>
    /// Function: CheatWalk
    /// </summary>
    public unsafe override bool CheatWalk()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheatWalk, "BmGame.RPawnCharacter.CheatWalk");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DuplicateWeaponConfig;
    /// <summary>
    /// Function: DuplicateWeaponConfig
    /// </summary>
    public unsafe static BmSDK.BmGame.RWeaponConfig DuplicateWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DuplicateWeaponConfig, "BmGame.RPawnCharacter.DuplicateWeaponConfig");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ShallowDuplicateWeaponConfig;
    /// <summary>
    /// Function: ShallowDuplicateWeaponConfig
    /// </summary>
    public unsafe static BmSDK.BmGame.RWeaponConfig ShallowDuplicateWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShallowDuplicateWeaponConfig, "BmGame.RPawnCharacter.ShallowDuplicateWeaponConfig");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CombineWeaponConfigs;
    /// <summary>
    /// Function: CombineWeaponConfigs
    /// </summary>
    public unsafe static BmSDK.BmGame.RWeaponConfig CombineWeaponConfigs(BmSDK.GameObject NewOwner, BmSDK.FString DebugName, BmSDK.BmGame.RWeaponConfig Config1, BmSDK.BmGame.RWeaponConfig Config2, BmSDK.BmGame.RWeaponConfig Config3 = default, BmSDK.BmGame.RWeaponConfig Config4 = default, BmSDK.BmGame.RWeaponConfig Config5 = default, BmSDK.BmGame.RWeaponConfig Config6 = default, BmSDK.BmGame.RWeaponConfig Config7 = default, BmSDK.BmGame.RWeaponConfig Config8 = default, BmSDK.BmGame.RWeaponConfig Config9 = default, BmSDK.BmGame.RWeaponConfig Config10 = default, BmSDK.BmGame.RWeaponConfig Config11 = default, BmSDK.BmGame.RWeaponConfig Config12 = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombineWeaponConfigs, "BmGame.RPawnCharacter.CombineWeaponConfigs");
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DebugName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config1, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config2, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config3, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config4, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config5, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config6, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config7, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config8, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config9, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config10, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config11, paramsPtr + 104);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config12, paramsPtr + 112);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 120);
    }

    private static BmSDK.Function __fn_SetAnimTimeScale;
    /// <summary>
    /// Function: SetAnimTimeScale
    /// </summary>
    public unsafe virtual void SetAnimTimeScale(float Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAnimTimeScale, "BmGame.RPawnCharacter.SetAnimTimeScale");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_DisableAnimTick;
    /// <summary>
    /// Function: DisableAnimTick
    /// </summary>
    public unsafe virtual void DisableAnimTick(bool Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableAnimTick, "BmGame.RPawnCharacter.DisableAnimTick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsRagdoll;
    /// <summary>
    /// Function: IsRagdoll
    /// </summary>
    public unsafe virtual bool IsRagdoll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRagdoll, "BmGame.RPawnCharacter.IsRagdoll");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ChangeRagdollDamping;
    /// <summary>
    /// Function: ChangeRagdollDamping
    /// </summary>
    public unsafe virtual void ChangeRagdollDamping(float LinearDamping, float AngularDamping)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeRagdollDamping, "BmGame.RPawnCharacter.ChangeRagdollDamping");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinearDamping, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngularDamping, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ChangeRagdollMotorWeight;
    /// <summary>
    /// Function: ChangeRagdollMotorWeight
    /// </summary>
    public unsafe virtual void ChangeRagdollMotorWeight(BmSDK.FName Description, float NewWeight, float BlendDuration = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeRagdollMotorWeight, "BmGame.RPawnCharacter.ChangeRagdollMotorWeight");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeight, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendDuration, paramsPtr + 12);
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

    private static BmSDK.Function __fn_ResetRagdoll;
    /// <summary>
    /// Function: ResetRagdoll
    /// </summary>
    public unsafe virtual void ResetRagdoll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetRagdoll, "BmGame.RPawnCharacter.ResetRagdoll");
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

    private static BmSDK.Function __fn_PopRagdoll;
    /// <summary>
    /// Function: PopRagdoll
    /// </summary>
    public unsafe virtual void PopRagdoll(BmSDK.FName Description)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopRagdoll, "BmGame.RPawnCharacter.PopRagdoll");
        byte* paramsPtr = stackalloc byte[8];
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

    private static BmSDK.Function __fn_PushRagdollOff;
    /// <summary>
    /// Function: PushRagdollOff
    /// </summary>
    public unsafe virtual void PushRagdollOff(BmSDK.FName Description)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushRagdollOff, "BmGame.RPawnCharacter.PushRagdollOff");
        byte* paramsPtr = stackalloc byte[8];
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

    private static BmSDK.Function __fn_PushRagdollOn;
    /// <summary>
    /// Function: PushRagdollOn
    /// </summary>
    public unsafe virtual void PushRagdollOn(BmSDK.FName Description, float MotorWeight = default, float BlendInDuration = default, float BlendOutDuration = default, float LinerDamping = default, float AngularDamping = default, BmSDK.TArray<BmSDK.FName> FixedBodies = default, bool ActorRotationLocked = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushRagdollOn, "BmGame.RPawnCharacter.PushRagdollOn");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MotorWeight, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendInDuration, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendOutDuration, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinerDamping, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngularDamping, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FixedBodies, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorRotationLocked, paramsPtr + 44);
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

    private static BmSDK.Function __fn_GetFirstFootNotifyInAnim;
    /// <summary>
    /// Function: GetFirstFootNotifyInAnim
    /// </summary>
    public unsafe virtual bool GetFirstFootNotifyInAnim(BmSDK.Engine.AnimSequence inAnim, out BmSDK.Engine.RAutomaticTransitions.EFootSyncPoint FootSyncPoint, out float normalisedTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFirstFootNotifyInAnim, "BmGame.RPawnCharacter.GetFirstFootNotifyInAnim");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inAnim, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FootSyncPoint = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAutomaticTransitions.EFootSyncPoint>(paramsPtr + 8);
        normalisedTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetScriptNotifiesOfType;
    /// <summary>
    /// Function: GetScriptNotifiesOfType
    /// </summary>
    public unsafe virtual void GetScriptNotifiesOfType(BmSDK.FName scriptNotifyName, BmSDK.Engine.AnimSequence Sequence, out BmSDK.TArray<BmSDK.Engine.AnimSequence.FAnimNotifyEvent> Notifies)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScriptNotifiesOfType, "BmGame.RPawnCharacter.GetScriptNotifiesOfType");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(scriptNotifyName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Sequence, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Notifies = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSequence.FAnimNotifyEvent>>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_SnapFloorCorrection;
    /// <summary>
    /// Function: SnapFloorCorrection
    /// </summary>
    public unsafe virtual void SnapFloorCorrection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SnapFloorCorrection, "BmGame.RPawnCharacter.SnapFloorCorrection");
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

    private static BmSDK.Function __fn_GetMoveToPhaseTime;
    /// <summary>
    /// Function: GetMoveToPhaseTime
    /// </summary>
    public unsafe virtual float GetMoveToPhaseTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMoveToPhaseTime, "BmGame.RPawnCharacter.GetMoveToPhaseTime");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMoveToPhase;
    /// <summary>
    /// Function: GetMoveToPhase
    /// </summary>
    public unsafe virtual BmSDK.Engine.RAutomaticTransitions.EFootSyncPoint GetMoveToPhase()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMoveToPhase, "BmGame.RPawnCharacter.GetMoveToPhase");
        byte* paramsPtr = stackalloc byte[1];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAutomaticTransitions.EFootSyncPoint>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetIdleTimeScale;
    /// <summary>
    /// Function: SetIdleTimeScale
    /// </summary>
    public unsafe virtual void SetIdleTimeScale(float NewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIdleTimeScale, "BmGame.RPawnCharacter.SetIdleTimeScale");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsFallingOrLanding;
    /// <summary>
    /// Function: IsFallingOrLanding
    /// </summary>
    public unsafe virtual bool IsFallingOrLanding()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFallingOrLanding, "BmGame.RPawnCharacter.IsFallingOrLanding");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsFalling;
    /// <summary>
    /// Function: IsFalling
    /// </summary>
    public unsafe virtual bool IsFalling()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFalling, "BmGame.RPawnCharacter.IsFalling");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OverrideYawVelocity;
    /// <summary>
    /// Function: OverrideYawVelocity
    /// </summary>
    public unsafe virtual void OverrideYawVelocity(float YawVelocity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideYawVelocity, "BmGame.RPawnCharacter.OverrideYawVelocity");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YawVelocity, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OverrideTranslationVelocity;
    /// <summary>
    /// Function: OverrideTranslationVelocity
    /// </summary>
    public unsafe virtual void OverrideTranslationVelocity(System.Numerics.Vector3 TranslationVelocity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideTranslationVelocity, "BmGame.RPawnCharacter.OverrideTranslationVelocity");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TranslationVelocity, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddYaw;
    /// <summary>
    /// Function: AddYaw
    /// </summary>
    public unsafe virtual void AddYaw(float Yaw)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddYaw, "BmGame.RPawnCharacter.AddYaw");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Yaw, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddYawVelocity;
    /// <summary>
    /// Function: AddYawVelocity
    /// </summary>
    public unsafe virtual void AddYawVelocity(float YawVelocity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddYawVelocity, "BmGame.RPawnCharacter.AddYawVelocity");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YawVelocity, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddTranslation;
    /// <summary>
    /// Function: AddTranslation
    /// </summary>
    public unsafe virtual void AddTranslation(System.Numerics.Vector3 Translation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddTranslation, "BmGame.RPawnCharacter.AddTranslation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Translation, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddTranslationVelocity;
    /// <summary>
    /// Function: AddTranslationVelocity
    /// </summary>
    public unsafe virtual void AddTranslationVelocity(System.Numerics.Vector3 TranslationVelocity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddTranslationVelocity, "BmGame.RPawnCharacter.AddTranslationVelocity");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TranslationVelocity, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetLegDirection;
    /// <summary>
    /// Function: GetLegDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetLegDirection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLegDirection, "BmGame.RPawnCharacter.GetLegDirection");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFaceAtDirection;
    /// <summary>
    /// Function: GetFaceAtDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFaceAtDirection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFaceAtDirection, "BmGame.RPawnCharacter.GetFaceAtDirection");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopFaceAt;
    /// <summary>
    /// Function: StopFaceAt
    /// </summary>
    public unsafe virtual void StopFaceAt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFaceAt, "BmGame.RPawnCharacter.StopFaceAt");
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

    private static BmSDK.Function __fn_FaceAtActorWithKillTimer;
    /// <summary>
    /// Function: FaceAtActorWithKillTimer
    /// </summary>
    public unsafe virtual void FaceAtActorWithKillTimer(BmSDK.Engine.Actor Actor, float fDuration, BmSDK.FName ActorBoneName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FaceAtActorWithKillTimer, "BmGame.RPawnCharacter.FaceAtActorWithKillTimer");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDuration, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorBoneName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FaceAtActor;
    /// <summary>
    /// Function: FaceAtActor
    /// </summary>
    public unsafe virtual void FaceAtActor(BmSDK.Engine.Actor Actor, BmSDK.FName ActorBoneName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FaceAtActor, "BmGame.RPawnCharacter.FaceAtActor");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorBoneName, paramsPtr + 8);
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

    private static BmSDK.Function __fn_FaceInDirection;
    /// <summary>
    /// Function: FaceInDirection
    /// </summary>
    public unsafe virtual void FaceInDirection(System.Numerics.Vector3 Direction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FaceInDirection, "BmGame.RPawnCharacter.FaceInDirection");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
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

    private static BmSDK.Function __fn_FaceAt;
    /// <summary>
    /// Function: FaceAt
    /// </summary>
    public unsafe virtual void FaceAt(System.Numerics.Vector3 Position)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FaceAt, "BmGame.RPawnCharacter.FaceAt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
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

    private static BmSDK.Function __fn_StopLookAt;
    /// <summary>
    /// Function: StopLookAt
    /// </summary>
    public unsafe virtual void StopLookAt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopLookAt, "BmGame.RPawnCharacter.StopLookAt");
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

    private static BmSDK.Function __fn_LookAtActor;
    /// <summary>
    /// Function: LookAtActor
    /// </summary>
    public unsafe virtual void LookAtActor(BmSDK.Engine.Actor Actor, BmSDK.FName ActorBoneName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookAtActor, "BmGame.RPawnCharacter.LookAtActor");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorBoneName, paramsPtr + 8);
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

    private static BmSDK.Function __fn_LookInDirection;
    /// <summary>
    /// Function: LookInDirection
    /// </summary>
    public unsafe virtual void LookInDirection(System.Numerics.Vector3 Direction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookInDirection, "BmGame.RPawnCharacter.LookInDirection");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
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

    private static BmSDK.Function __fn_LookAt;
    /// <summary>
    /// Function: LookAt
    /// </summary>
    public unsafe virtual void LookAt(System.Numerics.Vector3 Position)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookAt, "BmGame.RPawnCharacter.LookAt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetHeadPositionWithoutAiming;
    /// <summary>
    /// Function: GetHeadPositionWithoutAiming
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetHeadPositionWithoutAiming()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeadPositionWithoutAiming, "BmGame.RPawnCharacter.GetHeadPositionWithoutAiming");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetActualAimAtDirection;
    /// <summary>
    /// Function: GetActualAimAtDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetActualAimAtDirection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActualAimAtDirection, "BmGame.RPawnCharacter.GetActualAimAtDirection");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTargetAimAtDirection;
    /// <summary>
    /// Function: GetTargetAimAtDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetTargetAimAtDirection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetAimAtDirection, "BmGame.RPawnCharacter.GetTargetAimAtDirection");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SnapAimAt;
    /// <summary>
    /// Function: SnapAimAt
    /// </summary>
    public unsafe virtual void SnapAimAt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SnapAimAt, "BmGame.RPawnCharacter.SnapAimAt");
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

    private static BmSDK.Function __fn_StopAimAt;
    /// <summary>
    /// Function: StopAimAt
    /// </summary>
    public unsafe virtual void StopAimAt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAimAt, "BmGame.RPawnCharacter.StopAimAt");
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

    private static BmSDK.Function __fn_AimAtActor;
    /// <summary>
    /// Function: AimAtActor
    /// </summary>
    public unsafe virtual void AimAtActor(BmSDK.Engine.Actor Actor, BmSDK.FName Description = default, BmSDK.FName ActorBoneName = default, BmSDK.BmGame.RAnimUtil_PosePlayer.EAllowTurningToAim AllowTurningToAim = default, float LimitScale = default, BmSDK.BmGame.RPoseConfig.FAimingTransitionTimingOverride TimingOverride = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimAtActor, "BmGame.RPawnCharacter.AimAtActor");
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

    private static BmSDK.Function __fn_AimInDirection;
    /// <summary>
    /// Function: AimInDirection
    /// </summary>
    public unsafe virtual void AimInDirection(System.Numerics.Vector3 Direction, BmSDK.FName Description = default, BmSDK.BmGame.RAnimUtil_PosePlayer.EAllowTurningToAim AllowTurningToAim = default, float LimitScale = default, BmSDK.BmGame.RPoseConfig.FAimingTransitionTimingOverride TimingOverride = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimInDirection, "BmGame.RPawnCharacter.AimInDirection");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowTurningToAim, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LimitScale, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimingOverride, paramsPtr + 28);
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

    private static BmSDK.Function __fn_AimAt;
    /// <summary>
    /// Function: AimAt
    /// </summary>
    public unsafe virtual void AimAt(System.Numerics.Vector3 Position, BmSDK.FName Description = default, BmSDK.BmGame.RAnimUtil_PosePlayer.EAllowTurningToAim AllowTurningToAim = default, float LimitScale = default, BmSDK.BmGame.RPoseConfig.FAimingTransitionTimingOverride TimingOverride = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimAt, "BmGame.RPawnCharacter.AimAt");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowTurningToAim, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LimitScale, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimingOverride, paramsPtr + 28);
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

    private static BmSDK.Function __fn_GetMoveToDirection;
    /// <summary>
    /// Function: GetMoveToDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetMoveToDirection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMoveToDirection, "BmGame.RPawnCharacter.GetMoveToDirection");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InstantStopMoveTo;
    /// <summary>
    /// Function: InstantStopMoveTo
    /// </summary>
    public unsafe virtual void InstantStopMoveTo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstantStopMoveTo, "BmGame.RPawnCharacter.InstantStopMoveTo");
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

    private static BmSDK.Function __fn_StopMoveTo;
    /// <summary>
    /// Function: StopMoveTo
    /// </summary>
    public unsafe virtual void StopMoveTo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopMoveTo, "BmGame.RPawnCharacter.StopMoveTo");
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

    private static BmSDK.Function __fn_MoveInDirection;
    /// <summary>
    /// Function: MoveInDirection
    /// </summary>
    public unsafe virtual void MoveInDirection(System.Numerics.Vector3 Direction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveInDirection, "BmGame.RPawnCharacter.MoveInDirection");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
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

    private static BmSDK.Function __fn_MoveTo;
    /// <summary>
    /// Function: MoveTo
    /// </summary>
    public unsafe virtual void MoveTo(System.Numerics.Vector3 Position)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveTo, "BmGame.RPawnCharacter.MoveTo");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsAnyOneShotMovementCycleActive;
    /// <summary>
    /// Function: IsAnyOneShotMovementCycleActive
    /// </summary>
    public unsafe virtual bool IsAnyOneShotMovementCycleActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAnyOneShotMovementCycleActive, "BmGame.RPawnCharacter.IsAnyOneShotMovementCycleActive");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetOneShotMovementCycleState;
    /// <summary>
    /// Function: GetOneShotMovementCycleState
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_MovementPlayer.EOneShotMovementCycleState GetOneShotMovementCycleState(BmSDK.FName Description)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOneShotMovementCycleState, "BmGame.RPawnCharacter.GetOneShotMovementCycleState");
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_MovementPlayer.EOneShotMovementCycleState>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PlayOneShotMovementCycle;
    /// <summary>
    /// Function: PlayOneShotMovementCycle
    /// </summary>
    public unsafe virtual void PlayOneShotMovementCycle(BmSDK.BmGame.RAnimConfig.FCustomAnimConfig AnimConfig, BmSDK.FName Description)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayOneShotMovementCycle, "BmGame.RPawnCharacter.PlayOneShotMovementCycle");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimConfig, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 52);
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

    private static BmSDK.Function __fn_SetMovementSpeed;
    /// <summary>
    /// Function: SetMovementSpeed
    /// </summary>
    public unsafe virtual void SetMovementSpeed(BmSDK.Engine.RAutomaticTransitions.EMovementSpeed NewSpeed, float NewSpeedScale = default, BmSDK.BmGame.RAnimUtil_PosePlayer.EMoveToRequestFacing Facing = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMovementSpeed, "BmGame.RPawnCharacter.SetMovementSpeed");
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSpeed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSpeedScale, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Facing, paramsPtr + 8);
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

    private static BmSDK.Function __fn_StopAllOverlaysInstantly;
    /// <summary>
    /// Function: StopAllOverlaysInstantly
    /// </summary>
    public unsafe virtual void StopAllOverlaysInstantly()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAllOverlaysInstantly, "BmGame.RPawnCharacter.StopAllOverlaysInstantly");
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

    private static BmSDK.Function __fn_StopAllOverlays;
    /// <summary>
    /// Function: StopAllOverlays
    /// </summary>
    public unsafe virtual void StopAllOverlays()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAllOverlays, "BmGame.RPawnCharacter.StopAllOverlays");
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

    private static BmSDK.Function __fn_StopGlobalAdditiveOverlay;
    /// <summary>
    /// Function: StopGlobalAdditiveOverlay
    /// </summary>
    public unsafe virtual void StopGlobalAdditiveOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopGlobalAdditiveOverlay, "BmGame.RPawnCharacter.StopGlobalAdditiveOverlay");
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

    private static BmSDK.Function __fn_StopAdditiveOverlay;
    /// <summary>
    /// Function: StopAdditiveOverlay
    /// </summary>
    public unsafe virtual void StopAdditiveOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAdditiveOverlay, "BmGame.RPawnCharacter.StopAdditiveOverlay");
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

    private static BmSDK.Function __fn_StopIdleOverlay;
    /// <summary>
    /// Function: StopIdleOverlay
    /// </summary>
    public unsafe virtual void StopIdleOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopIdleOverlay, "BmGame.RPawnCharacter.StopIdleOverlay");
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

    private static BmSDK.Function __fn_StopWeaponOverlay;
    /// <summary>
    /// Function: StopWeaponOverlay
    /// </summary>
    public unsafe virtual void StopWeaponOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopWeaponOverlay, "BmGame.RPawnCharacter.StopWeaponOverlay");
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

    private static BmSDK.Function __fn_IsPlayingAnyOverlay;
    /// <summary>
    /// Function: IsPlayingAnyOverlay
    /// </summary>
    public unsafe virtual bool IsPlayingAnyOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayingAnyOverlay, "BmGame.RPawnCharacter.IsPlayingAnyOverlay");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPlayingOverlay;
    /// <summary>
    /// Function: IsPlayingOverlay
    /// </summary>
    public unsafe virtual bool IsPlayingOverlay(BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayingOverlay, "BmGame.RPawnCharacter.IsPlayingOverlay");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PlayCustomGlobalAdditiveOverlay;
    /// <summary>
    /// Function: PlayCustomGlobalAdditiveOverlay
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlayCustomGlobalAdditiveOverlay(BmSDK.BmGame.RAnimConfig.FFullyCustomAdditiveAnimConfig CustomAnim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCustomGlobalAdditiveOverlay, "BmGame.RPawnCharacter.PlayCustomGlobalAdditiveOverlay");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomAnim, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_PlayCustomAdditiveOverlay;
    /// <summary>
    /// Function: PlayCustomAdditiveOverlay
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlayCustomAdditiveOverlay(BmSDK.BmGame.RAnimConfig.FCustomAdditiveAnimConfig CustomAnim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCustomAdditiveOverlay, "BmGame.RPawnCharacter.PlayCustomAdditiveOverlay");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomAnim, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_PlayCustomIdleOverlay;
    /// <summary>
    /// Function: PlayCustomIdleOverlay
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlayCustomIdleOverlay(BmSDK.BmGame.RAnimConfig.FCustomAnimConfig CustomAnim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCustomIdleOverlay, "BmGame.RPawnCharacter.PlayCustomIdleOverlay");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomAnim, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_PlayIdleOverlay;
    /// <summary>
    /// Function: PlayIdleOverlay
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlayIdleOverlay(BmSDK.FName OverlayName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayIdleOverlay, "BmGame.RPawnCharacter.PlayIdleOverlay");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverlayName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PlayCustomWeaponOverlay;
    /// <summary>
    /// Function: PlayCustomWeaponOverlay
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlayCustomWeaponOverlay(BmSDK.BmGame.RAnimConfig.FCustomAnimConfig CustomAnim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCustomWeaponOverlay, "BmGame.RPawnCharacter.PlayCustomWeaponOverlay");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomAnim, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_PlayWeaponOverlay;
    /// <summary>
    /// Function: PlayWeaponOverlay
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlayWeaponOverlay(BmSDK.FName OverlayName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayWeaponOverlay, "BmGame.RPawnCharacter.PlayWeaponOverlay");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverlayName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetTransitionAnimFromCurrent;
    /// <summary>
    /// Function: GetTransitionAnimFromCurrent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSequence GetTransitionAnimFromCurrent(BmSDK.FName ToMovementStance, BmSDK.FName ToWeaponStance, BmSDK.FName ToIdleStance, bool ToMirrored = default, BmSDK.FName TransitionName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionAnimFromCurrent, "BmGame.RPawnCharacter.GetTransitionAnimFromCurrent");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToMovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToWeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToIdleStance, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToMirrored, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetTransitionDominantAnim;
    /// <summary>
    /// Function: GetTransitionDominantAnim
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSequence GetTransitionDominantAnim(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionDominantAnim, "BmGame.RPawnCharacter.GetTransitionDominantAnim");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetTransitionDuration;
    /// <summary>
    /// Function: SetTransitionDuration
    /// </summary>
    public unsafe virtual void SetTransitionDuration(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id, float NewDuration)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTransitionDuration, "BmGame.RPawnCharacter.SetTransitionDuration");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDuration, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetTransitionDuration;
    /// <summary>
    /// Function: GetTransitionDuration
    /// </summary>
    public unsafe virtual float GetTransitionDuration(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionDuration, "BmGame.RPawnCharacter.GetTransitionDuration");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTransitionTimeInSeconds;
    /// <summary>
    /// Function: GetTransitionTimeInSeconds
    /// </summary>
    public unsafe virtual float GetTransitionTimeInSeconds(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionTimeInSeconds, "BmGame.RPawnCharacter.GetTransitionTimeInSeconds");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTransitionNormalizedTime;
    /// <summary>
    /// Function: GetTransitionNormalizedTime
    /// </summary>
    public unsafe virtual float GetTransitionNormalizedTime(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionNormalizedTime, "BmGame.RPawnCharacter.GetTransitionNormalizedTime");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetHeadTransition;
    /// <summary>
    /// Function: GetHeadTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId GetHeadTransition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeadTransition, "BmGame.RPawnCharacter.GetHeadTransition");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsHeadTransition;
    /// <summary>
    /// Function: IsHeadTransition
    /// </summary>
    public unsafe virtual bool IsHeadTransition(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHeadTransition, "BmGame.RPawnCharacter.IsHeadTransition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasTransition;
    /// <summary>
    /// Function: HasTransition
    /// </summary>
    public unsafe virtual bool HasTransition(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasTransition, "BmGame.RPawnCharacter.HasTransition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_WillBeInTransition;
    /// <summary>
    /// Function: WillBeInTransition
    /// </summary>
    public unsafe virtual bool WillBeInTransition(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id, float DeltaSeconds, BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WillBeInTransition, "BmGame.RPawnCharacter.WillBeInTransition");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaSeconds, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsInTransition;
    /// <summary>
    /// Function: IsInTransition
    /// </summary>
    public unsafe virtual bool IsInTransition(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id, BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInTransition, "BmGame.RPawnCharacter.IsInTransition");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsInAnyNonAutomaticTransition;
    /// <summary>
    /// Function: IsInAnyNonAutomaticTransition
    /// </summary>
    public unsafe virtual bool IsInAnyNonAutomaticTransition(BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInAnyNonAutomaticTransition, "BmGame.RPawnCharacter.IsInAnyNonAutomaticTransition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsInAnyAutomaticTransition;
    /// <summary>
    /// Function: IsInAnyAutomaticTransition
    /// </summary>
    public unsafe virtual bool IsInAnyAutomaticTransition(BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness, out BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Transition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInAnyAutomaticTransition, "BmGame.RPawnCharacter.IsInAnyAutomaticTransition");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Transition = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsInAnyTransition;
    /// <summary>
    /// Function: IsInAnyTransition
    /// </summary>
    public unsafe virtual bool IsInAnyTransition(BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInAnyTransition, "BmGame.RPawnCharacter.IsInAnyTransition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsInWeaponTransition;
    /// <summary>
    /// Function: IsInWeaponTransition
    /// </summary>
    public unsafe virtual bool IsInWeaponTransition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInWeaponTransition, "BmGame.RPawnCharacter.IsInWeaponTransition");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsTransitionMirrored;
    /// <summary>
    /// Function: IsTransitionMirrored
    /// </summary>
    public unsafe virtual bool IsTransitionMirrored()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTransitionMirrored, "BmGame.RPawnCharacter.IsTransitionMirrored");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPoseMirrored;
    /// <summary>
    /// Function: IsPoseMirrored
    /// </summary>
    public unsafe virtual bool IsPoseMirrored()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPoseMirrored, "BmGame.RPawnCharacter.IsPoseMirrored");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FakeTickTransitionTime;
    /// <summary>
    /// Function: FakeTickTransitionTime
    /// </summary>
    public unsafe virtual void FakeTickTransitionTime(float NormalizedTime, int DisableTimeAdvanceForNumFrames = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeTickTransitionTime, "BmGame.RPawnCharacter.FakeTickTransitionTime");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NormalizedTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisableTimeAdvanceForNumFrames, paramsPtr + 4);
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

    private static BmSDK.Function __fn_TeleportTransitionTime;
    /// <summary>
    /// Function: TeleportTransitionTime
    /// </summary>
    public unsafe virtual void TeleportTransitionTime(float NormalizedTime, int DisableTimeAdvanceForNumFrames = default, BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Transition = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TeleportTransitionTime, "BmGame.RPawnCharacter.TeleportTransitionTime");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NormalizedTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisableTimeAdvanceForNumFrames, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Transition, paramsPtr + 8);
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

    private static BmSDK.Function __fn_ChangePoseOverTime;
    /// <summary>
    /// Function: ChangePoseOverTime
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId ChangePoseOverTime(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, float Time, bool bMirrored = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangePoseOverTime, "BmGame.RPawnCharacter.ChangePoseOverTime");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ChangePoseWeaponSimple;
    /// <summary>
    /// Function: ChangePoseWeaponSimple
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId ChangePoseWeaponSimple(BmSDK.Engine.Inventory NewWeapon, BmSDK.Engine.Inventory NewTransitionWeapon, bool bForce = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangePoseWeaponSimple, "BmGame.RPawnCharacter.ChangePoseWeaponSimple");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTransitionWeapon, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ChangePoseNoDataWeightIfNotHead;
    /// <summary>
    /// Function: ChangePoseNoDataWeightIfNotHead
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId ChangePoseNoDataWeightIfNotHead(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, BmSDK.FName TransitionName = default, bool bMirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangePoseNoDataWeightIfNotHead, "BmGame.RPawnCharacter.ChangePoseNoDataWeightIfNotHead");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 136);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_ChangePoseWeapon;
    /// <summary>
    /// Function: ChangePoseWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId ChangePoseWeapon(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, BmSDK.Engine.Inventory NewWeapon, BmSDK.Engine.Inventory NewTransitionWeapon, BmSDK.FName TransitionName = default, bool bMirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangePoseWeapon, "BmGame.RPawnCharacter.ChangePoseWeapon");
        byte* paramsPtr = stackalloc byte[156];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTransitionWeapon, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 148);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 152);
    }

    private static BmSDK.Function __fn_ForceChangePose;
    /// <summary>
    /// Function: ForceChangePose
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId ForceChangePose(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, BmSDK.FName TransitionName = default, bool bMirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDuration = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceChangePose, "BmGame.RPawnCharacter.ForceChangePose");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDuration, paramsPtr + 136);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_ChangePose;
    /// <summary>
    /// Function: ChangePose
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId ChangePose(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, BmSDK.FName TransitionName = default, bool bMirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangePose, "BmGame.RPawnCharacter.ChangePose");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 136);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_StartSlavedTransition;
    /// <summary>
    /// Function: StartSlavedTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId StartSlavedTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, BmSDK.Engine.Actor SlavedToActor, BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId SlavedToTransition, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSlavedTransition, "BmGame.RPawnCharacter.StartSlavedTransition");
        byte* paramsPtr = stackalloc byte[160];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlavedToActor, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlavedToTransition, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 148);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 152);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 156);
    }

    private static BmSDK.Function __fn_StartRelativeTransitionRotationOnly;
    /// <summary>
    /// Function: StartRelativeTransitionRotationOnly
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId StartRelativeTransitionRotationOnly(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartRelativeTransitionRotationOnly, "BmGame.RPawnCharacter.StartRelativeTransitionRotationOnly");
        byte* paramsPtr = stackalloc byte[156];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 140);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 144);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 148);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 152);
    }

    private static BmSDK.Function __fn_StartRelativePairedTransition;
    /// <summary>
    /// Function: StartRelativePairedTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId StartRelativePairedTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default, BmSDK.Engine.Actor PairedIdleActor = default, BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PairedIdeActorTransitionId = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartRelativePairedTransition, "BmGame.RPawnCharacter.StartRelativePairedTransition");
        byte* paramsPtr = stackalloc byte[180];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 100);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 152);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 156);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 160);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PairedIdleActor, paramsPtr + 164);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PairedIdeActorTransitionId, paramsPtr + 172);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 176);
    }

    private static BmSDK.Function __fn_StartRelativeTransition;
    /// <summary>
    /// Function: StartRelativeTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId StartRelativeTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartRelativeTransition, "BmGame.RPawnCharacter.StartRelativeTransition");
        byte* paramsPtr = stackalloc byte[168];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 100);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 152);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 156);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 160);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 164);
    }

    private static BmSDK.Function __fn_StartAbsoluteTransitionRotationOnly;
    /// <summary>
    /// Function: StartAbsoluteTransitionRotationOnly
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId StartAbsoluteTransitionRotationOnly(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, int TransitionTargetYaw, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAbsoluteTransitionRotationOnly, "BmGame.RPawnCharacter.StartAbsoluteTransitionRotationOnly");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 136);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_StartAbsoluteTransition;
    /// <summary>
    /// Function: StartAbsoluteTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId StartAbsoluteTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAbsoluteTransition, "BmGame.RPawnCharacter.StartAbsoluteTransition");
        byte* paramsPtr = stackalloc byte[156];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 148);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 152);
    }

    private static BmSDK.Function __fn_SetAllowAutomaticTransitionOutOfMatinee;
    /// <summary>
    /// Function: SetAllowAutomaticTransitionOutOfMatinee
    /// </summary>
    public unsafe virtual void SetAllowAutomaticTransitionOutOfMatinee()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAllowAutomaticTransitionOutOfMatinee, "BmGame.RPawnCharacter.SetAllowAutomaticTransitionOutOfMatinee");
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

    private static BmSDK.Function __fn_IsAnimationControlledByParticularMatinee;
    /// <summary>
    /// Function: IsAnimationControlledByParticularMatinee
    /// </summary>
    public unsafe virtual bool IsAnimationControlledByParticularMatinee(BmSDK.Engine.InterpGroupInst InterpGroupInst)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAnimationControlledByParticularMatinee, "BmGame.RPawnCharacter.IsAnimationControlledByParticularMatinee");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpGroupInst, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsAnimationControlledByMatinee;
    /// <summary>
    /// Function: IsAnimationControlledByMatinee
    /// </summary>
    public unsafe virtual bool IsAnimationControlledByMatinee()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAnimationControlledByMatinee, "BmGame.RPawnCharacter.IsAnimationControlledByMatinee");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsControlledByParticularMatinee;
    /// <summary>
    /// Function: IsControlledByParticularMatinee
    /// </summary>
    public unsafe virtual bool IsControlledByParticularMatinee(BmSDK.Engine.InterpGroupInst InterpGroupInst)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsControlledByParticularMatinee, "BmGame.RPawnCharacter.IsControlledByParticularMatinee");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpGroupInst, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsControlledByMatinee;
    /// <summary>
    /// Function: IsControlledByMatinee
    /// </summary>
    public unsafe virtual bool IsControlledByMatinee()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsControlledByMatinee, "BmGame.RPawnCharacter.IsControlledByMatinee");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetIdleStance;
    /// <summary>
    /// Function: GetIdleStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetIdleStance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIdleStance, "BmGame.RPawnCharacter.GetIdleStance");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetWeaponStance;
    /// <summary>
    /// Function: GetWeaponStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetWeaponStance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponStance, "BmGame.RPawnCharacter.GetWeaponStance");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMovementStance;
    /// <summary>
    /// Function: GetMovementStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetMovementStance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMovementStance, "BmGame.RPawnCharacter.GetMovementStance");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInPose;
    /// <summary>
    /// Function: IsInPose
    /// </summary>
    public unsafe virtual bool IsInPose(BmSDK.FName MovementStance, BmSDK.FName WeaponStance)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInPose, "BmGame.RPawnCharacter.IsInPose");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
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

    private static BmSDK.Function __fn_IsInIdleStance;
    /// <summary>
    /// Function: IsInIdleStance
    /// </summary>
    public unsafe virtual bool IsInIdleStance(BmSDK.FName Stance, BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInIdleStance, "BmGame.RPawnCharacter.IsInIdleStance");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsInWeaponStance;
    /// <summary>
    /// Function: IsInWeaponStance
    /// </summary>
    public unsafe virtual bool IsInWeaponStance(BmSDK.FName Stance, BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInWeaponStance, "BmGame.RPawnCharacter.IsInWeaponStance");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsInMovementStance;
    /// <summary>
    /// Function: IsInMovementStance
    /// </summary>
    public unsafe virtual bool IsInMovementStance(BmSDK.FName Stance, BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInMovementStance, "BmGame.RPawnCharacter.IsInMovementStance");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ChangeIdleStanceWithoutTransition;
    /// <summary>
    /// Function: ChangeIdleStanceWithoutTransition
    /// </summary>
    public unsafe virtual void ChangeIdleStanceWithoutTransition(BmSDK.FName Stance)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeIdleStanceWithoutTransition, "BmGame.RPawnCharacter.ChangeIdleStanceWithoutTransition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ChangeIdleStance;
    /// <summary>
    /// Function: ChangeIdleStance
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId ChangeIdleStance(BmSDK.FName Stance)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeIdleStance, "BmGame.RPawnCharacter.ChangeIdleStance");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ChangeWeaponStance;
    /// <summary>
    /// Function: ChangeWeaponStance
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId ChangeWeaponStance(BmSDK.FName Stance)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeWeaponStance, "BmGame.RPawnCharacter.ChangeWeaponStance");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ChangeMovementStance;
    /// <summary>
    /// Function: ChangeMovementStance
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId ChangeMovementStance(BmSDK.FName Stance)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeMovementStance, "BmGame.RPawnCharacter.ChangeMovementStance");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IssueChangePose;
    /// <summary>
    /// Function: IssueChangePose
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId IssueChangePose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IssueChangePose, "BmGame.RPawnCharacter.IssueChangePose");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EndChangePose;
    /// <summary>
    /// Function: EndChangePose
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId EndChangePose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndChangePose, "BmGame.RPawnCharacter.EndChangePose");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BeginQueuedChangePose;
    /// <summary>
    /// Function: BeginQueuedChangePose
    /// </summary>
    public unsafe virtual void BeginQueuedChangePose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginQueuedChangePose, "BmGame.RPawnCharacter.BeginQueuedChangePose");
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

    private static BmSDK.Function __fn_BeginCleanChangePose;
    /// <summary>
    /// Function: BeginCleanChangePose
    /// </summary>
    public unsafe virtual void BeginCleanChangePose(BmSDK.FName PreviousMovementStance, BmSDK.FName PreviousWeaponStance, BmSDK.FName PreviousIdleStance, BmSDK.Engine.Inventory PreviousWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginCleanChangePose, "BmGame.RPawnCharacter.BeginCleanChangePose");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousMovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousWeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousIdleStance, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousWeapon, paramsPtr + 24);
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

    private static BmSDK.Function __fn_BeginChangePose;
    /// <summary>
    /// Function: BeginChangePose
    /// </summary>
    public unsafe virtual void BeginChangePose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginChangePose, "BmGame.RPawnCharacter.BeginChangePose");
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

    private static BmSDK.Function __fn_GetFullyCustomAdditiveAnim;
    /// <summary>
    /// Function: GetFullyCustomAdditiveAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FFullyCustomAdditiveAnimConfig GetFullyCustomAdditiveAnim(BmSDK.FName AddAnimName, BmSDK.FName SubtractAnimName = default, BmSDK.Engine.AnimSet Set = default, BmSDK.TArray<BmSDK.Engine.AnimSet> ExtraSets = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFullyCustomAdditiveAnim, "BmGame.RPawnCharacter.GetFullyCustomAdditiveAnim");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AddAnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubtractAnimName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraSets, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FFullyCustomAdditiveAnimConfig>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetAdditiveAnim;
    /// <summary>
    /// Function: GetAdditiveAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAdditiveAnimConfig GetAdditiveAnim(BmSDK.FName AddAnimName, BmSDK.FName SubtractAnimName = default, BmSDK.Engine.AnimSet Set = default, BmSDK.TArray<BmSDK.Engine.AnimSet> ExtraSets = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAdditiveAnim, "BmGame.RPawnCharacter.GetAdditiveAnim");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AddAnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubtractAnimName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraSets, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FCustomAdditiveAnimConfig>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetFullBodyIdle;
    /// <summary>
    /// Function: GetFullBodyIdle
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig GetFullBodyIdle(BmSDK.FName AnimName, BmSDK.Engine.AnimSet Set = default, BmSDK.TArray<BmSDK.Engine.AnimSet> ExtraSets = default, BmSDK.Engine.RAimingConfig AimingConfig = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFullBodyIdle, "BmGame.RPawnCharacter.GetFullBodyIdle");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraSets, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimingConfig, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetFullBodyTransition;
    /// <summary>
    /// Function: GetFullBodyTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig GetFullBodyTransition(BmSDK.FName AnimName, BmSDK.Engine.AnimSet Set = default, BmSDK.TArray<BmSDK.Engine.AnimSet> ExtraSets = default, BmSDK.Engine.RAimingConfig AimingConfig = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFullBodyTransition, "BmGame.RPawnCharacter.GetFullBodyTransition");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraSets, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimingConfig, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetFullBodyAnim;
    /// <summary>
    /// Function: GetFullBodyAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAnimConfig GetFullBodyAnim(BmSDK.FName AnimName, BmSDK.Engine.AnimSet Set = default, BmSDK.TArray<BmSDK.Engine.AnimSet> ExtraSets = default, BmSDK.Engine.RAimingConfig AimingConfig = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFullBodyAnim, "BmGame.RPawnCharacter.GetFullBodyAnim");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraSets, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimingConfig, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RPawnCharacter.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitAnimNode;
    /// <summary>
    /// Function: InitAnimNode
    /// </summary>
    public unsafe virtual void InitAnimNode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitAnimNode, "BmGame.RPawnCharacter.InitAnimNode");
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

    private static BmSDK.Function __fn_ClearOverridenWeaponConfig;
    /// <summary>
    /// Function: ClearOverridenWeaponConfig
    /// </summary>
    public unsafe virtual void ClearOverridenWeaponConfig()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearOverridenWeaponConfig, "BmGame.RPawnCharacter.ClearOverridenWeaponConfig");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddToUnarmedWeaponConfig;
    /// <summary>
    /// Function: AddToUnarmedWeaponConfig
    /// </summary>
    public unsafe virtual void AddToUnarmedWeaponConfig(BmSDK.BmGame.RWeaponConfig NewWeaponConfig)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddToUnarmedWeaponConfig, "BmGame.RPawnCharacter.AddToUnarmedWeaponConfig");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAttachToActor;
    /// <summary>
    /// Function: OnAttachToActor
    /// </summary>
    public unsafe override void OnAttachToActor(BmSDK.Engine.SeqAct_AttachToActor Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAttachToActor, "BmGame.RPawnCharacter.OnAttachToActor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PossessedBy;
    /// <summary>
    /// Function: PossessedBy
    /// </summary>
    public unsafe override void PossessedBy(BmSDK.Engine.Controller C, bool bVehicleTransition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PossessedBy, "BmGame.RPawnCharacter.PossessedBy");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVehicleTransition, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInLowPose;
    /// <summary>
    /// Function: IsInLowPose
    /// </summary>
    public unsafe virtual bool IsInLowPose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInLowPose, "BmGame.RPawnCharacter.IsInLowPose");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OverlayExists;
    /// <summary>
    /// Function: OverlayExists
    /// </summary>
    public unsafe virtual bool OverlayExists(BmSDK.FName OverlayName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverlayExists, "BmGame.RPawnCharacter.OverlayExists");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverlayName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetFOVCheckLocation;
    /// <summary>
    /// Function: GetFOVCheckLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetFOVCheckLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFOVCheckLocation, "BmGame.RPawnCharacter.GetFOVCheckLocation");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTargetLocation;
    /// <summary>
    /// Function: GetTargetLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetTargetLocation(BmSDK.Engine.Actor RequestedBy = default, bool bRequestAlternateLoc = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetLocation, "BmGame.RPawnCharacter.GetTargetLocation");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRequestAlternateLoc, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_AttemptTeleportToSafeLocation;
    /// <summary>
    /// Function: AttemptTeleportToSafeLocation
    /// </summary>
    public unsafe virtual void AttemptTeleportToSafeLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttemptTeleportToSafeLocation, "BmGame.RPawnCharacter.AttemptTeleportToSafeLocation");
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

    /// <summary>
    /// Struct: FTweakFaceFXRegister
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FTweakFaceFXRegister
    {
        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Value
        /// </summary>
        public unsafe float Value
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FRagdollNavMeshCollisionTrackingInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FRagdollNavMeshCollisionTrackingInfo
    {
        /// <summary>
        /// NameProperty: BoneName
        /// </summary>
        public unsafe BmSDK.FName BoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: PrevPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 PrevPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: ERagdollVsNavMesh
    /// </summary>
    public enum ERagdollVsNavMesh : byte
    {
        RAGvsNAV_Constrain = 0,
        RAGvsNAV_ConstrainWhenNotDead = 1,
        RAGvsNAV_DoNotConstrain = 2,
        RAGvsNAV_Auto = 3,
        RAGvsNAV_MAX = 4,
    }

    /// <summary>
    /// Struct: FSoundTracking
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSoundTracking
    {
        /// <summary>
        /// ObjectProperty: NameOfSound
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent NameOfSound
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: TimeStamp
        /// </summary>
        public unsafe float TimeStamp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: PeakStrength
        /// </summary>
        public unsafe float PeakStrength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FCustomIdleConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FCustomIdleConfig
    {
        /// <summary>
        /// StructProperty: Config
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimConfig.FCustomAnimConfig Config
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FCustomTransitionConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FCustomTransitionConfig
    {
        /// <summary>
        /// StructProperty: Config
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimConfig.FCustomAnimConfig Config
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: AIController
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController AIController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 1796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1796); }
    }

    /// <summary>
    /// ObjectProperty: PlayerController
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerControllerCombat PlayerController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerControllerCombat>(Ptr + 1804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1804); }
    }

    /// <summary>
    /// ObjectProperty: Anim
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNode_Pose Anim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNode_Pose>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// ObjectProperty: ActualWeapon
    /// </summary>
    public unsafe BmSDK.Engine.Inventory ActualWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Inventory>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// ObjectProperty: UnarmedWeaponConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponConfig UnarmedWeaponConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// ObjectProperty: OverrideUnarmedWeaponConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponConfig OverrideUnarmedWeaponConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }

    /// <summary>
    /// ObjectProperty: CarriedObject
    /// </summary>
    public unsafe BmSDK.BmGame.RCarriableObjectBase CarriedObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCarriableObjectBase>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// ObjectProperty: GetUpMaster
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCharacter GetUpMaster
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCharacter>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// ObjectProperty: GetUpAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet GetUpAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// ObjectProperty: SoundCharacterAudioFilter
    /// </summary>
    public unsafe BmSDK.Engine.AkCharacterFilter SoundCharacterAudioFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkCharacterFilter>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// ObjectProperty: IgnoreCollisionWithPawn
    /// </summary>
    public unsafe BmSDK.Engine.Actor IgnoreCollisionWithPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }

    /// <summary>
    /// ObjectProperty: Tweak_Anim_AnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet Tweak_Anim_AnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// ObjectProperty: CurrentRiotObjectLeftHand
    /// </summary>
    public unsafe BmSDK.BmGame.RRiotObjectBase CurrentRiotObjectLeftHand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRiotObjectBase>(Ptr + 1892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1892); }
    }

    /// <summary>
    /// ObjectProperty: CurrentRiotObjectRightHand
    /// </summary>
    public unsafe BmSDK.BmGame.RRiotObjectBase CurrentRiotObjectRightHand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRiotObjectBase>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// ComponentProperty: BodyConstrainingComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RConstrainingComponent BodyConstrainingComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RConstrainingComponent>(Ptr + 1908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1908); }
    }

    /// <summary>
    /// BoolProperty: AllowFlappyBits
    /// </summary>
    public unsafe bool AllowFlappyBits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: AlwaysUsePhysics
    /// </summary>
    public unsafe bool AlwaysUsePhysics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: DisableRagdollCalming
    /// </summary>
    public unsafe bool DisableRagdollCalming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: AllowProceduralBreathing
    /// </summary>
    public unsafe bool AllowProceduralBreathing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: AllowCustomPhysics
    /// </summary>
    public unsafe bool AllowCustomPhysics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: AllowCustomPhysicsUpdate
    /// </summary>
    public unsafe bool AllowCustomPhysicsUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: EnableFloorCorrection
    /// </summary>
    public unsafe bool EnableFloorCorrection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: AllowFloorCorrectionRaycast
    /// </summary>
    public unsafe bool AllowFloorCorrectionRaycast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: ReduceBlinksAndEyeMovements
    /// </summary>
    public unsafe bool ReduceBlinksAndEyeMovements
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: InsideChangePose
    /// </summary>
    public unsafe bool InsideChangePose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bPlayConfusedGetup
    /// </summary>
    public unsafe bool bPlayConfusedGetup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bDisableScrambleGetup
    /// </summary>
    public unsafe bool bDisableScrambleGetup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bBounceIntoCombat
    /// </summary>
    public unsafe bool bBounceIntoCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bForceScrambleIntoCombat
    /// </summary>
    public unsafe bool bForceScrambleIntoCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bConstrainingComponentNeedsUpdate
    /// </summary>
    public unsafe bool bConstrainingComponentNeedsUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bIsRobot
    /// </summary>
    public unsafe bool bIsRobot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: SilentRagdoll
    /// </summary>
    public unsafe bool SilentRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bNoBackscreenSupport
    /// </summary>
    public unsafe bool bNoBackscreenSupport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bForceGetupFacing
    /// </summary>
    public unsafe bool bForceGetupFacing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bConstrainRagdollToDynamicNavMesh
    /// </summary>
    public unsafe bool bConstrainRagdollToDynamicNavMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bDisableRagdollVsNavMeshConstraint
    /// </summary>
    public unsafe bool bDisableRagdollVsNavMeshConstraint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bTempDisableRagdollVsNavMeshConstraint
    /// </summary>
    public unsafe bool bTempDisableRagdollVsNavMeshConstraint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bTempForceRagdollVsNavMeshConstraint
    /// </summary>
    public unsafe bool bTempForceRagdollVsNavMeshConstraint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bLastFrameWasRagdoll
    /// </summary>
    public unsafe bool bLastFrameWasRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bAllowBaseRotationOnPawn
    /// </summary>
    public unsafe bool bAllowBaseRotationOnPawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: Tweak_FaceFXRegisters_Enabled
    /// </summary>
    public unsafe bool Tweak_FaceFXRegisters_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: Tweak_Anim_Enabled
    /// </summary>
    public unsafe bool Tweak_Anim_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bSpedUpGetUpAnim
    /// </summary>
    public unsafe bool bSpedUpGetUpAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// ArrayProperty: MatineeControlReferences
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.InterpGroupInst> MatineeControlReferences
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.InterpGroupInst>>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// ArrayProperty: Bodysounds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FSoundTracking> Bodysounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FSoundTracking>>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// StructProperty: PreviousPose
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimNode_Pose.FPreviousPoseDescription PreviousPose
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimNode_Pose.FPreviousPoseDescription>(Ptr + 1952);

    /// <summary>
    /// StructProperty: Pose
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimNode_Pose.FPoseDescription Pose
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimNode_Pose.FPoseDescription>(Ptr + 2056);

    /// <summary>
    /// NameProperty: GetUpTargetMovementStance
    /// </summary>
    public unsafe BmSDK.FName GetUpTargetMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// NameProperty: GetUpTargetWeaponStance
    /// </summary>
    public unsafe BmSDK.FName GetUpTargetWeaponStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// StructProperty: GetUpTransitionID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId GetUpTransitionID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 2432);

    /// <summary>
    /// StructProperty: GetUpMasterAnimID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId GetUpMasterAnimID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 2436);

    /// <summary>
    /// NameProperty: GetUpAnimName
    /// </summary>
    public unsafe BmSDK.FName GetUpAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }

    /// <summary>
    /// FloatProperty: GetupBlendOutDuration
    /// </summary>
    public unsafe float GetupBlendOutDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// FloatProperty: TimeOfLastBodyFallParticle
    /// </summary>
    public unsafe float TimeOfLastBodyFallParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2452); }
    }

    /// <summary>
    /// ByteProperty: RagdollVsNavMeshSolution
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCharacter.ERagdollVsNavMesh RagdollVsNavMeshSolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCharacter.ERagdollVsNavMesh>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// StructProperty: PrevSafePelvisLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PrevSafePelvisLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2460);

    /// <summary>
    /// StructProperty: LastSafeLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastSafeLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2472);

    /// <summary>
    /// IntProperty: NavMeshConstrainFrames
    /// </summary>
    public unsafe int NavMeshConstrainFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2484); }
    }

    /// <summary>
    /// IntProperty: NavMeshConstrainBuffer
    /// </summary>
    public unsafe int NavMeshConstrainBuffer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// ArrayProperty: RagdollCollisionBodies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FRagdollNavMeshCollisionTrackingInfo> RagdollCollisionBodies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FRagdollNavMeshCollisionTrackingInfo>>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// StructProperty: OldShadowReflectionPlane
    /// </summary>
    public unsafe ref BmSDK.GameObject.FPlane OldShadowReflectionPlane
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FPlane>(Ptr + 2512);

    /// <summary>
    /// FloatProperty: ShadowReflectionRagdollCache
    /// </summary>
    public unsafe float ShadowReflectionRagdollCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// StructProperty: Tweak_LocationNudge
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Tweak_LocationNudge
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2532);

    /// <summary>
    /// ArrayProperty: Tweak_FaceFXRegisters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FTweakFaceFXRegister> Tweak_FaceFXRegisters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FTweakFaceFXRegister>>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// NameProperty: Tweak_Anim_AnimName
    /// </summary>
    public unsafe BmSDK.FName Tweak_Anim_AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// FloatProperty: Tweak_Anim_Time
    /// </summary>
    public unsafe float Tweak_Anim_Time
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }

    /// <summary>
    /// FloatProperty: NavTestLength
    /// </summary>
    public unsafe float NavTestLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2572); }
    }

    /// <summary>
    /// FloatProperty: RagdollFacingThreshold
    /// </summary>
    public unsafe float RagdollFacingThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// ArrayProperty: RainMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> RainMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }

    /// <summary>
    /// FloatProperty: RainAccumulationAlpha
    /// </summary>
    public unsafe float RainAccumulationAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2596); }
    }

    /// <summary>
    /// FloatProperty: WetnessAccumulationAlpha
    /// </summary>
    public unsafe float WetnessAccumulationAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// NameProperty: RainParameterName
    /// </summary>
    public unsafe BmSDK.FName RainParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2604); }
    }

    /// <summary>
    /// StructProperty: PreviousRainDirectionColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor PreviousRainDirectionColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 2612);

    /// <summary>
    /// FloatProperty: LastRainMaterialUpdateTime
    /// </summary>
    public unsafe float LastRainMaterialUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }

    /// <summary>
    /// NameProperty: BeginGetUp_MovementStance
    /// </summary>
    public unsafe BmSDK.FName BeginGetUp_MovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }
    }

    /// <summary>
    /// StructProperty: BeginGetUp_TransitionId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId BeginGetUp_TransitionId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 2640);

    /// <summary>
    /// DelegateProperty: __OnPlayedQueuedTransition__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnPlayedQueuedTransition__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2644); }
    }
}
