#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RHelicopterBase<br/>
/// (size = 2348)
/// (flags = 144704183)
/// </summary>
public partial class RHelicopterBase : BmSDK.Engine.Pawn, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHelicopterBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHelicopterBase.
    /// </summary>
    public static RHelicopterBase DefaultObject => (RHelicopterBase)StaticClass().DefaultObject;

    internal RHelicopterBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHelicopterBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PlayDeathBarks;
    /// <summary>
    /// Function: PlayDeathBarks
    /// </summary>
    public unsafe virtual void PlayDeathBarks()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDeathBarks, "BmGame.RHelicopterBase.PlayDeathBarks");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverrideFireImpulse;
    /// <summary>
    /// Function: OverrideFireImpulse
    /// </summary>
    public unsafe virtual void OverrideFireImpulse(System.Numerics.Vector3 Position, BmSDK.Engine.RB_RadialImpulseComponent RadialImpulseComponent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideFireImpulse, "BmGame.RHelicopterBase.OverrideFireImpulse");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RadialImpulseComponent, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlyingVehicleSuspendOnManyTanks;
    /// <summary>
    /// Function: FlyingVehicleSuspendOnManyTanks
    /// </summary>
    public unsafe virtual bool FlyingVehicleSuspendOnManyTanks()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlyingVehicleSuspendOnManyTanks, "BmGame.RHelicopterBase.FlyingVehicleSuspendOnManyTanks");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FlyingVehicleAudioResume;
    /// <summary>
    /// Function: FlyingVehicleAudioResume
    /// </summary>
    public unsafe virtual void FlyingVehicleAudioResume()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlyingVehicleAudioResume, "BmGame.RHelicopterBase.FlyingVehicleAudioResume");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlyingVehicleAudioSuspend;
    /// <summary>
    /// Function: FlyingVehicleAudioSuspend
    /// </summary>
    public unsafe virtual void FlyingVehicleAudioSuspend()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlyingVehicleAudioSuspend, "BmGame.RHelicopterBase.FlyingVehicleAudioSuspend");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanChatter;
    /// <summary>
    /// Function: CanChatter
    /// </summary>
    public unsafe virtual bool CanChatter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanChatter, "BmGame.RHelicopterBase.CanChatter");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRemoveMaterialsFromDisruptorMeshList;
    /// <summary>
    /// Function: GetRemoveMaterialsFromDisruptorMeshList
    /// </summary>
    public unsafe virtual void GetRemoveMaterialsFromDisruptorMeshList(out BmSDK.TArray<int> OutRemoveMaterialsList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRemoveMaterialsFromDisruptorMeshList, "BmGame.RHelicopterBase.GetRemoveMaterialsFromDisruptorMeshList");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutRemoveMaterialsList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyHelicopter;
    /// <summary>
    /// Function: DestroyHelicopter
    /// </summary>
    public unsafe virtual void DestroyHelicopter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyHelicopter, "BmGame.RHelicopterBase.DestroyHelicopter");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateAbseiling;
    /// <summary>
    /// Function: UpdateAbseiling
    /// </summary>
    public unsafe virtual void UpdateAbseiling(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAbseiling, "BmGame.RHelicopterBase.UpdateAbseiling");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAbseilAnimName;
    /// <summary>
    /// Function: GetAbseilAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetAbseilAnimName(int SlotID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAbseilAnimName, "BmGame.RHelicopterBase.GetAbseilAnimName");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UnlockAbseilSlot;
    /// <summary>
    /// Function: UnlockAbseilSlot
    /// </summary>
    public unsafe virtual void UnlockAbseilSlot(BmSDK.BmGame.RBMPawnAI AbseilPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockAbseilSlot, "BmGame.RHelicopterBase.UnlockAbseilSlot");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbseilPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LockAbseilSlot;
    /// <summary>
    /// Function: LockAbseilSlot
    /// </summary>
    public unsafe virtual bool LockAbseilSlot(BmSDK.BmGame.RBMPawnAI AbseilPawn, int SlotID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LockAbseilSlot, "BmGame.RHelicopterBase.LockAbseilSlot");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbseilPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetAbseilSlot;
    /// <summary>
    /// Function: GetAbseilSlot
    /// </summary>
    public unsafe virtual int GetAbseilSlot(BmSDK.BmGame.RBMPawnAI AbseilPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAbseilSlot, "BmGame.RHelicopterBase.GetAbseilSlot");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbseilPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsAbseilSlotPositionUseable;
    /// <summary>
    /// Function: IsAbseilSlotPositionUseable
    /// </summary>
    public unsafe virtual bool IsAbseilSlotPositionUseable(BmSDK.BmGame.RBMPawnAI TestPawn, int SlotID, bool bAbseilDebug = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAbseilSlotPositionUseable, "BmGame.RHelicopterBase.IsAbseilSlotPositionUseable");
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAbseilDebug, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_NotifyHomingMissileStrike;
    /// <summary>
    /// Function: NotifyHomingMissileStrike
    /// </summary>
    public unsafe virtual void NotifyHomingMissileStrike(float units_above_target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyHomingMissileStrike, "BmGame.RHelicopterBase.NotifyHomingMissileStrike");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(units_above_target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsAbseilingActive;
    /// <summary>
    /// Function: IsAbseilingActive
    /// </summary>
    public unsafe virtual bool IsAbseilingActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAbseilingActive, "BmGame.RHelicopterBase.IsAbseilingActive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartAbseil;
    /// <summary>
    /// Function: StartAbseil
    /// </summary>
    public unsafe virtual void StartAbseil()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAbseil, "BmGame.RHelicopterBase.StartAbseil");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugAbseilSlots;
    /// <summary>
    /// Function: DebugAbseilSlots
    /// </summary>
    public unsafe virtual void DebugAbseilSlots()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugAbseilSlots, "BmGame.RHelicopterBase.DebugAbseilSlots");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GlideLandOnHelicopter;
    /// <summary>
    /// Function: GlideLandOnHelicopter
    /// </summary>
    public unsafe virtual void GlideLandOnHelicopter(BmSDK.BmGame.RPawnPlayer LandingPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GlideLandOnHelicopter, "BmGame.RHelicopterBase.GlideLandOnHelicopter");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LandingPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LockRocketPassengerID;
    /// <summary>
    /// Function: LockRocketPassengerID
    /// </summary>
    public unsafe virtual void LockRocketPassengerID(BmSDK.BmGame.RBMPawnAI Pawn, int PassengerID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LockRocketPassengerID, "BmGame.RHelicopterBase.LockRocketPassengerID");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PassengerID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRocketPassengerID;
    /// <summary>
    /// Function: GetRocketPassengerID
    /// </summary>
    public unsafe virtual int GetRocketPassengerID(BmSDK.BmGame.RBMPawnAI Pawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRocketPassengerID, "BmGame.RHelicopterBase.GetRocketPassengerID");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UnlockPassengerID;
    /// <summary>
    /// Function: UnlockPassengerID
    /// </summary>
    public unsafe virtual void UnlockPassengerID(BmSDK.BmGame.RBMPawnAI Pawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockPassengerID, "BmGame.RHelicopterBase.UnlockPassengerID");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LockPassengerID;
    /// <summary>
    /// Function: LockPassengerID
    /// </summary>
    public unsafe virtual void LockPassengerID(BmSDK.BmGame.RBMPawnAI Pawn, int PassengerID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LockPassengerID, "BmGame.RHelicopterBase.LockPassengerID");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PassengerID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPassengerID;
    /// <summary>
    /// Function: GetPassengerID
    /// </summary>
    public unsafe virtual int GetPassengerID(BmSDK.BmGame.RBMPawnAI Pawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPassengerID, "BmGame.RHelicopterBase.GetPassengerID");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_HasAbseilers;
    /// <summary>
    /// Function: HasAbseilers
    /// </summary>
    public unsafe virtual bool HasAbseilers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasAbseilers, "BmGame.RHelicopterBase.HasAbseilers");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasPassengers;
    /// <summary>
    /// Function: HasPassengers
    /// </summary>
    public unsafe virtual bool HasPassengers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasPassengers, "BmGame.RHelicopterBase.HasPassengers");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsControlledByHuman;
    /// <summary>
    /// Function: IsControlledByHuman
    /// </summary>
    public unsafe virtual bool IsControlledByHuman()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsControlledByHuman, "BmGame.RHelicopterBase.IsControlledByHuman");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AbandonedByController;
    /// <summary>
    /// Function: AbandonedByController
    /// </summary>
    public unsafe virtual void AbandonedByController()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AbandonedByController, "BmGame.RHelicopterBase.AbandonedByController");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTargets;
    /// <summary>
    /// Function: GetTargets
    /// </summary>
    public unsafe virtual void GetTargets(out BmSDK.TArray<BmSDK.Engine.Actor> Targets)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargets, "BmGame.RHelicopterBase.GetTargets");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Targets = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_IsSpecialTutorialMinidrone;
    /// <summary>
    /// Function: IsSpecialTutorialMinidrone
    /// </summary>
    public unsafe virtual bool IsSpecialTutorialMinidrone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSpecialTutorialMinidrone, "BmGame.RHelicopterBase.IsSpecialTutorialMinidrone");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumberOfMinidroneSearchLightTargets;
    /// <summary>
    /// Function: GetNumberOfMinidroneSearchLightTargets
    /// </summary>
    public unsafe virtual int GetNumberOfMinidroneSearchLightTargets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumberOfMinidroneSearchLightTargets, "BmGame.RHelicopterBase.GetNumberOfMinidroneSearchLightTargets");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMaximumMiniDroneControllerInteractionDistance;
    /// <summary>
    /// Function: GetMaximumMiniDroneControllerInteractionDistance
    /// </summary>
    public unsafe virtual float GetMaximumMiniDroneControllerInteractionDistance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaximumMiniDroneControllerInteractionDistance, "BmGame.RHelicopterBase.GetMaximumMiniDroneControllerInteractionDistance");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCodesHaventBeenDownloadedYetBatmanThought;
    /// <summary>
    /// Function: GetCodesHaventBeenDownloadedYetBatmanThought
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkDialogueSpeech GetCodesHaventBeenDownloadedYetBatmanThought()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCodesHaventBeenDownloadedYetBatmanThought, "BmGame.RHelicopterBase.GetCodesHaventBeenDownloadedYetBatmanThought");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HaveCodesFinishedDownloading;
    /// <summary>
    /// Function: HaveCodesFinishedDownloading
    /// </summary>
    public unsafe virtual bool HaveCodesFinishedDownloading()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HaveCodesFinishedDownloading, "BmGame.RHelicopterBase.HaveCodesFinishedDownloading");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DownloadCodes;
    /// <summary>
    /// Function: DownloadCodes
    /// </summary>
    public unsafe virtual float DownloadCodes(float DeltaT)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DownloadCodes, "BmGame.RHelicopterBase.DownloadCodes");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaT, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_MinidroneIsBeingTargetedByRHD;
    /// <summary>
    /// Function: MinidroneIsBeingTargetedByRHD
    /// </summary>
    public unsafe virtual void MinidroneIsBeingTargetedByRHD()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MinidroneIsBeingTargetedByRHD, "BmGame.RHelicopterBase.MinidroneIsBeingTargetedByRHD");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SelfDestruct;
    /// <summary>
    /// Function: SelfDestruct
    /// </summary>
    public unsafe virtual void SelfDestruct()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelfDestruct, "BmGame.RHelicopterBase.SelfDestruct");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetArmour;
    /// <summary>
    /// Function: GetArmour
    /// </summary>
    public unsafe virtual float GetArmour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetArmour, "BmGame.RHelicopterBase.GetArmour");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DrawDebugGraphics;
    /// <summary>
    /// Function: DrawDebugGraphics
    /// </summary>
    public unsafe virtual void DrawDebugGraphics()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugGraphics, "BmGame.RHelicopterBase.DrawDebugGraphics");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceLowQualityLight;
    /// <summary>
    /// Function: ForceLowQualityLight
    /// </summary>
    public unsafe virtual void ForceLowQualityLight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceLowQualityLight, "BmGame.RHelicopterBase.ForceLowQualityLight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceHighQualityLight;
    /// <summary>
    /// Function: ForceHighQualityLight
    /// </summary>
    public unsafe virtual void ForceHighQualityLight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceHighQualityLight, "BmGame.RHelicopterBase.ForceHighQualityLight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsTargetatble;
    /// <summary>
    /// Function: IsTargetatble
    /// </summary>
    public unsafe virtual bool IsTargetatble()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTargetatble, "BmGame.RHelicopterBase.IsTargetatble");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetGrapplePointEnabled;
    /// <summary>
    /// Function: SetGrapplePointEnabled
    /// </summary>
    public unsafe virtual void SetGrapplePointEnabled(bool make_enabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGrapplePointEnabled, "BmGame.RHelicopterBase.SetGrapplePointEnabled");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(make_enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOverrideSpeed;
    /// <summary>
    /// Function: SetOverrideSpeed
    /// </summary>
    public unsafe virtual void SetOverrideSpeed(float _override_speed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOverrideSpeed, "BmGame.RHelicopterBase.SetOverrideSpeed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_override_speed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TouchedRiotZone;
    /// <summary>
    /// Function: TouchedRiotZone
    /// </summary>
    public unsafe virtual void TouchedRiotZone(BmSDK.BmGame.ROverworldPopulationVolume RiotVolume, bool bEntering)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TouchedRiotZone, "BmGame.RHelicopterBase.TouchedRiotZone");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RiotVolume, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEntering, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHelicopterControlVolume;
    /// <summary>
    /// Function: SetHelicopterControlVolume
    /// </summary>
    public unsafe virtual void SetHelicopterControlVolume(BmSDK.BmGame.RHelicopterControlVolume ControlVolume, bool bEntering)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHelicopterControlVolume, "BmGame.RHelicopterBase.SetHelicopterControlVolume");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControlVolume, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEntering, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StrafePathGunsOff;
    /// <summary>
    /// Function: StrafePathGunsOff
    /// </summary>
    public unsafe virtual void StrafePathGunsOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StrafePathGunsOff, "BmGame.RHelicopterBase.StrafePathGunsOff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StrafePathGunsOn;
    /// <summary>
    /// Function: StrafePathGunsOn
    /// </summary>
    public unsafe virtual void StrafePathGunsOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StrafePathGunsOn, "BmGame.RHelicopterBase.StrafePathGunsOn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StrafePathEnd;
    /// <summary>
    /// Function: StrafePathEnd
    /// </summary>
    public unsafe virtual void StrafePathEnd()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StrafePathEnd, "BmGame.RHelicopterBase.StrafePathEnd");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StrafePathBegin;
    /// <summary>
    /// Function: StrafePathBegin
    /// </summary>
    public unsafe virtual void StrafePathBegin(float fStrafeAngleInDegrees)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StrafePathBegin, "BmGame.RHelicopterBase.StrafePathBegin");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fStrafeAngleInDegrees, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginPursueActor;
    /// <summary>
    /// Function: BeginPursueActor
    /// </summary>
    public unsafe virtual void BeginPursueActor(BmSDK.Engine.Actor the_actor, float pursuit_altitude, float pursuit_distance, bool GoReallyFast)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginPursueActor, "BmGame.RHelicopterBase.BeginPursueActor");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pursuit_altitude, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pursuit_distance, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoReallyFast, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WatchPlayer;
    /// <summary>
    /// Function: WatchPlayer
    /// </summary>
    public unsafe virtual void WatchPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WatchPlayer, "BmGame.RHelicopterBase.WatchPlayer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RecoveredFromREC;
    /// <summary>
    /// Function: RecoveredFromREC
    /// </summary>
    public unsafe virtual void RecoveredFromREC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecoveredFromREC, "BmGame.RHelicopterBase.RecoveredFromREC");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitByREC;
    /// <summary>
    /// Function: HitByREC
    /// </summary>
    public unsafe virtual void HitByREC(System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 AttackerLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByREC, "BmGame.RHelicopterBase.HitByREC");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackerLocation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangePath;
    /// <summary>
    /// Function: ChangePath
    /// </summary>
    public unsafe virtual void ChangePath(BmSDK.BmGame.RPatrolPoint NewStartPoint, bool bTeleport)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangePath, "BmGame.RHelicopterBase.ChangePath");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTeleport, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RHelicopterBase.Destroyed");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RHelicopterBase.PreStreamOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RHelicopterBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAggressionLevels;
    /// <summary>
    /// Function: SetAggressionLevels
    /// </summary>
    public unsafe virtual void SetAggressionLevels(bool ChaingunEnabled, bool MissilesEnabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAggressionLevels, "BmGame.RHelicopterBase.SetAggressionLevels");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChaingunEnabled, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MissilesEnabled, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HelicopterDismounted;
    /// <summary>
    /// Function: HelicopterDismounted
    /// </summary>
    public unsafe virtual void HelicopterDismounted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HelicopterDismounted, "BmGame.RHelicopterBase.HelicopterDismounted");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsAttackEnabled;
    /// <summary>
    /// Function: IsAttackEnabled
    /// </summary>
    public unsafe virtual bool IsAttackEnabled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAttackEnabled, "BmGame.RHelicopterBase.IsAttackEnabled");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HelicopterBoarded;
    /// <summary>
    /// Function: HelicopterBoarded
    /// </summary>
    public unsafe virtual void HelicopterBoarded()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HelicopterBoarded, "BmGame.RHelicopterBase.HelicopterBoarded");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDifficultyParameters;
    /// <summary>
    /// Function: GetDifficultyParameters
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHelicopterBase.FHelicopterDifficultyParameters GetDifficultyParameters(int DifficultyLevel)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDifficultyParameters, "BmGame.RHelicopterBase.GetDifficultyParameters");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DifficultyLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterBase.FHelicopterDifficultyParameters>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsPlayerInvisible;
    /// <summary>
    /// Function: IsPlayerInvisible
    /// </summary>
    public unsafe virtual bool IsPlayerInvisible()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayerInvisible, "BmGame.RHelicopterBase.IsPlayerInvisible");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetFlightControlEnabled;
    /// <summary>
    /// Function: SetFlightControlEnabled
    /// </summary>
    public unsafe virtual void SetFlightControlEnabled(bool is_enabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFlightControlEnabled, "BmGame.RHelicopterBase.SetFlightControlEnabled");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CrashingHelicopterAtRest;
    /// <summary>
    /// Function: CrashingHelicopterAtRest
    /// </summary>
    public unsafe virtual void CrashingHelicopterAtRest()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CrashingHelicopterAtRest, "BmGame.RHelicopterBase.CrashingHelicopterAtRest");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CrashingHelicopterHitsGround;
    /// <summary>
    /// Function: CrashingHelicopterHitsGround
    /// </summary>
    public unsafe virtual void CrashingHelicopterHitsGround()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CrashingHelicopterHitsGround, "BmGame.RHelicopterBase.CrashingHelicopterHitsGround");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetControlActor;
    /// <summary>
    /// Function: GetControlActor
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetControlActor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetControlActor, "BmGame.RHelicopterBase.GetControlActor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Trigger;
    /// <summary>
    /// Function: Trigger
    /// </summary>
    public unsafe virtual bool Trigger(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Trigger, "BmGame.RHelicopterBase.Trigger");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetBlindedTimeRemaining;
    /// <summary>
    /// Function: GetBlindedTimeRemaining
    /// </summary>
    public unsafe virtual float GetBlindedTimeRemaining()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBlindedTimeRemaining, "BmGame.RHelicopterBase.GetBlindedTimeRemaining");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UnBlind;
    /// <summary>
    /// Function: UnBlind
    /// </summary>
    public unsafe virtual void UnBlind()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnBlind, "BmGame.RHelicopterBase.UnBlind");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBlinded;
    /// <summary>
    /// Function: IsBlinded
    /// </summary>
    public unsafe virtual bool IsBlinded()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBlinded, "BmGame.RHelicopterBase.IsBlinded");
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

    private static BmSDK.Function __fn_GetDisplayTargetLocation;
    /// <summary>
    /// Function: GetDisplayTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDisplayTargetLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayTargetLocation, "BmGame.RHelicopterBase.GetDisplayTargetLocation");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RequiresBlindDroneUpgrade;
    /// <summary>
    /// Function: RequiresBlindDroneUpgrade
    /// </summary>
    public unsafe virtual bool RequiresBlindDroneUpgrade()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequiresBlindDroneUpgrade, "BmGame.RHelicopterBase.RequiresBlindDroneUpgrade");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanTrigger;
    /// <summary>
    /// Function: CanTrigger
    /// </summary>
    public unsafe virtual bool CanTrigger(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTrigger, "BmGame.RHelicopterBase.CanTrigger");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanBeTargettedByRHD;
    /// <summary>
    /// Function: CanBeTargettedByRHD
    /// </summary>
    public unsafe virtual bool CanBeTargettedByRHD(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeTargettedByRHD, "BmGame.RHelicopterBase.CanBeTargettedByRHD");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetDisplayLockOnState;
    /// <summary>
    /// Function: GetDisplayLockOnState
    /// </summary>
    public unsafe virtual BmSDK.FString GetDisplayLockOnState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayLockOnState, "BmGame.RHelicopterBase.GetDisplayLockOnState");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayTitle;
    /// <summary>
    /// Function: GetDisplayTitle
    /// </summary>
    public unsafe virtual BmSDK.FString GetDisplayTitle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayTitle, "BmGame.RHelicopterBase.GetDisplayTitle");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayDescription;
    /// <summary>
    /// Function: GetDisplayDescription
    /// </summary>
    public unsafe virtual BmSDK.FString GetDisplayDescription()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayDescription, "BmGame.RHelicopterBase.GetDisplayDescription");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayIconName;
    /// <summary>
    /// Function: GetDisplayIconName
    /// </summary>
    public unsafe virtual BmSDK.FString GetDisplayIconName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayIconName, "BmGame.RHelicopterBase.GetDisplayIconName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NeedDisplayRefresh;
    /// <summary>
    /// Function: NeedDisplayRefresh
    /// </summary>
    public unsafe virtual bool NeedDisplayRefresh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NeedDisplayRefresh, "BmGame.RHelicopterBase.NeedDisplayRefresh");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInteractionPrompt;
    /// <summary>
    /// Function: GetInteractionPrompt
    /// </summary>
    public unsafe virtual BmSDK.FString GetInteractionPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInteractionPrompt, "BmGame.RHelicopterBase.GetInteractionPrompt");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldInteractionPromptBeDisplayedInCentreOfScreen;
    /// <summary>
    /// Function: ShouldInteractionPromptBeDisplayedInCentreOfScreen
    /// </summary>
    public unsafe virtual bool ShouldInteractionPromptBeDisplayedInCentreOfScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldInteractionPromptBeDisplayedInCentreOfScreen, "BmGame.RHelicopterBase.ShouldInteractionPromptBeDisplayedInCentreOfScreen");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInteractionPromptSecondary;
    /// <summary>
    /// Function: GetInteractionPromptSecondary
    /// </summary>
    public unsafe virtual BmSDK.FString GetInteractionPromptSecondary()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInteractionPromptSecondary, "BmGame.RHelicopterBase.GetInteractionPromptSecondary");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInteractionType;
    /// <summary>
    /// Function: GetInteractionType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RRemoteControlLowSecurityInterface.EOmnitronInteractionType GetInteractionType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInteractionType, "BmGame.RHelicopterBase.GetInteractionType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRemoteControlLowSecurityInterface.EOmnitronInteractionType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerSecondary;
    /// <summary>
    /// Function: TriggerSecondary
    /// </summary>
    public unsafe virtual bool TriggerSecondary(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSecondary, "BmGame.RHelicopterBase.TriggerSecondary");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanTargetTroughWalls;
    /// <summary>
    /// Function: CanTargetTroughWalls
    /// </summary>
    public unsafe virtual bool CanTargetTroughWalls()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTargetTroughWalls, "BmGame.RHelicopterBase.CanTargetTroughWalls");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMiniGameHelpPrompt;
    /// <summary>
    /// Function: GetMiniGameHelpPrompt
    /// </summary>
    public unsafe virtual void GetMiniGameHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMiniGameHelpPrompt, "BmGame.RHelicopterBase.GetMiniGameHelpPrompt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerLeft;
    /// <summary>
    /// Function: TriggerLeft
    /// </summary>
    public unsafe virtual void TriggerLeft(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerLeft, "BmGame.RHelicopterBase.TriggerLeft");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerRight;
    /// <summary>
    /// Function: TriggerRight
    /// </summary>
    public unsafe virtual void TriggerRight(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerRight, "BmGame.RHelicopterBase.TriggerRight");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetXrayMeshLevel;
    /// <summary>
    /// Function: SetXrayMeshLevel
    /// </summary>
    public unsafe virtual void SetXrayMeshLevel(bool bForce = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetXrayMeshLevel, "BmGame.RHelicopterBase.SetXrayMeshLevel");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RecoveredFromBeingBlinded;
    /// <summary>
    /// Function: RecoveredFromBeingBlinded
    /// </summary>
    public unsafe virtual void RecoveredFromBeingBlinded()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecoveredFromBeingBlinded, "BmGame.RHelicopterBase.RecoveredFromBeingBlinded");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeactivateDroneDisruptorEffect;
    /// <summary>
    /// Function: DeactivateDroneDisruptorEffect
    /// </summary>
    public unsafe virtual void DeactivateDroneDisruptorEffect()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivateDroneDisruptorEffect, "BmGame.RHelicopterBase.DeactivateDroneDisruptorEffect");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitByDisruptor;
    /// <summary>
    /// Function: HitByDisruptor
    /// </summary>
    public unsafe virtual void HitByDisruptor(System.Numerics.Vector3 ShotDirection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByDisruptor, "BmGame.RHelicopterBase.HitByDisruptor");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShotDirection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsDisrupted;
    /// <summary>
    /// Function: IsDisrupted
    /// </summary>
    public unsafe virtual bool IsDisrupted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDisrupted, "BmGame.RHelicopterBase.IsDisrupted");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HitByDisruptorGadgetSecondary;
    /// <summary>
    /// Function: HitByDisruptorGadgetSecondary
    /// </summary>
    public unsafe virtual bool HitByDisruptorGadgetSecondary()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByDisruptorGadgetSecondary, "BmGame.RHelicopterBase.HitByDisruptorGadgetSecondary");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeDisruptedSecondary;
    /// <summary>
    /// Function: CanBeDisruptedSecondary
    /// </summary>
    public unsafe virtual bool CanBeDisruptedSecondary()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeDisruptedSecondary, "BmGame.RHelicopterBase.CanBeDisruptedSecondary");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisruptorOverridePriority;
    /// <summary>
    /// Function: GetDisruptorOverridePriority
    /// </summary>
    public unsafe virtual float GetDisruptorOverridePriority()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisruptorOverridePriority, "BmGame.RHelicopterBase.GetDisruptorOverridePriority");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeDisrupted;
    /// <summary>
    /// Function: CanBeDisrupted
    /// </summary>
    public unsafe virtual bool CanBeDisrupted(BmSDK.BmGame.RJammerGadget JammerGadget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeDisrupted, "BmGame.RHelicopterBase.CanBeDisrupted");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JammerGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_HitByDisruptorGadgetCharge;
    /// <summary>
    /// Function: HitByDisruptorGadgetCharge
    /// </summary>
    public unsafe virtual bool HitByDisruptorGadgetCharge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByDisruptorGadgetCharge, "BmGame.RHelicopterBase.HitByDisruptorGadgetCharge");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisruptorTargetPosition;
    /// <summary>
    /// Function: GetDisruptorTargetPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDisruptorTargetPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisruptorTargetPosition, "BmGame.RHelicopterBase.GetDisruptorTargetPosition");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DoTimeSliceFeature;
    /// <summary>
    /// Function: DoTimeSliceFeature
    /// </summary>
    public unsafe virtual void DoTimeSliceFeature(int feature_index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoTimeSliceFeature, "BmGame.RHelicopterBase.DoTimeSliceFeature");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(feature_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimeSliceFrame;
    /// <summary>
    /// Function: TimeSliceFrame
    /// </summary>
    public unsafe virtual void TimeSliceFrame(int num_frames_since_last)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimeSliceFrame, "BmGame.RHelicopterBase.TimeSliceFrame");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(num_frames_since_last, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckOptimisedStasis;
    /// <summary>
    /// Function: CheckOptimisedStasis
    /// </summary>
    public unsafe virtual bool CheckOptimisedStasis()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckOptimisedStasis, "BmGame.RHelicopterBase.CheckOptimisedStasis");
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

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RHelicopterBase.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestCustomLight;
    /// <summary>
    /// Function: TestCustomLight
    /// </summary>
    public unsafe virtual bool TestCustomLight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestCustomLight, "BmGame.RHelicopterBase.TestCustomLight");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetPointOfInterestBatman;
    /// <summary>
    /// Function: SetPointOfInterestBatman
    /// </summary>
    public unsafe virtual void SetPointOfInterestBatman(bool TrueFalse)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPointOfInterestBatman, "BmGame.RHelicopterBase.SetPointOfInterestBatman");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TrueFalse, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPointOfInterest;
    /// <summary>
    /// Function: SetPointOfInterest
    /// </summary>
    public unsafe virtual void SetPointOfInterest(BmSDK.Engine.Actor TheActor, BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes PoiType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPointOfInterest, "BmGame.RHelicopterBase.SetPointOfInterest");
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoiType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsValidPointOfInterest;
    /// <summary>
    /// Function: IsValidPointOfInterest
    /// </summary>
    public unsafe virtual bool IsValidPointOfInterest(BmSDK.Engine.Actor TheActor, BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes PoiType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidPointOfInterest, "BmGame.RHelicopterBase.IsValidPointOfInterest");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoiType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RegisterBatmanPointOfInterest;
    /// <summary>
    /// Function: RegisterBatmanPointOfInterest
    /// </summary>
    public unsafe virtual void RegisterBatmanPointOfInterest(BmSDK.FName inBarkFlag, bool bPriority = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterBatmanPointOfInterest, "BmGame.RHelicopterBase.RegisterBatmanPointOfInterest");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inBarkFlag, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPriority, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForPointOfInterest;
    /// <summary>
    /// Function: CheckForPointOfInterest
    /// </summary>
    public unsafe virtual void CheckForPointOfInterest()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForPointOfInterest, "BmGame.RHelicopterBase.CheckForPointOfInterest");
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

    private static BmSDK.Function __fn_GetBoundingCylinder;
    /// <summary>
    /// Function: GetBoundingCylinder
    /// </summary>
    public unsafe override void GetBoundingCylinder(out float CollisionRadius, out float CollisionHeight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBoundingCylinder, "BmGame.RHelicopterBase.GetBoundingCylinder");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CollisionRadius = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
        CollisionHeight = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_IsBatmanInSpotlight;
    /// <summary>
    /// Function: IsBatmanInSpotlight
    /// </summary>
    public unsafe virtual bool IsBatmanInSpotlight(System.Numerics.Vector3 spot_origin, System.Numerics.Vector3 spot_angle, float spot_range, float spot_radius)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatmanInSpotlight, "BmGame.RHelicopterBase.IsBatmanInSpotlight");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(spot_origin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(spot_angle, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(spot_range, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(spot_radius, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_TickWindGust;
    /// <summary>
    /// Function: TickWindGust
    /// </summary>
    public unsafe virtual void TickWindGust(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickWindGust, "BmGame.RHelicopterBase.TickWindGust");
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

    private static BmSDK.Function __fn_RandomWindGust;
    /// <summary>
    /// Function: RandomWindGust
    /// </summary>
    public unsafe virtual void RandomWindGust()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RandomWindGust, "BmGame.RHelicopterBase.RandomWindGust");
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

    private static BmSDK.Function __fn_FlightControlAdjustVirtualLocation;
    /// <summary>
    /// Function: FlightControlAdjustVirtualLocation
    /// </summary>
    public unsafe virtual void FlightControlAdjustVirtualLocation(float TargetZ, float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlightControlAdjustVirtualLocation, "BmGame.RHelicopterBase.FlightControlAdjustVirtualLocation");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetZ, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 4);
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

    private static BmSDK.Function __fn_AdvanceTowardsVirtualLocation;
    /// <summary>
    /// Function: AdvanceTowardsVirtualLocation
    /// </summary>
    public unsafe virtual void AdvanceTowardsVirtualLocation(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdvanceTowardsVirtualLocation, "BmGame.RHelicopterBase.AdvanceTowardsVirtualLocation");
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

    private static BmSDK.Function __fn_SetVirtualLocationWithConstraints;
    /// <summary>
    /// Function: SetVirtualLocationWithConstraints
    /// </summary>
    public unsafe virtual bool SetVirtualLocationWithConstraints(System.Numerics.Vector3 NewVirtualLocation, float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVirtualLocationWithConstraints, "BmGame.RHelicopterBase.SetVirtualLocationWithConstraints");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVirtualLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 12);
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

    private static BmSDK.Function __fn_SetVirtualLocation;
    /// <summary>
    /// Function: SetVirtualLocation
    /// </summary>
    public unsafe virtual void SetVirtualLocation(System.Numerics.Vector3 NewVirtualLocation, float DeltaTime = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVirtualLocation, "BmGame.RHelicopterBase.SetVirtualLocation");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVirtualLocation, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SpawnDeadVehicle;
    /// <summary>
    /// Function: SpawnDeadVehicle
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RDeadVehicle SpawnDeadVehicle(BmSDK.BmGame.RDeadVehicle Archetype)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDeadVehicle, "BmGame.RHelicopterBase.SpawnDeadVehicle");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Archetype, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeadVehicle>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CrashMovement;
    /// <summary>
    /// Function: CrashMovement
    /// </summary>
    public unsafe virtual bool CrashMovement(float DeltaTime, float Gravity, float crash_altitude, float braking_once_crashed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CrashMovement, "BmGame.RHelicopterBase.CrashMovement");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gravity, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(crash_altitude, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(braking_once_crashed, paramsPtr + 12);
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

    private static BmSDK.Function __fn_UpdateRotation;
    /// <summary>
    /// Function: UpdateRotation
    /// </summary>
    public unsafe virtual void UpdateRotation(System.Numerics.Vector3 TargetLocation, float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRotation, "BmGame.RHelicopterBase.UpdateRotation");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 0);
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

    private static BmSDK.Function __fn_MoveTowardPath;
    /// <summary>
    /// Function: MoveTowardPath
    /// </summary>
    public unsafe virtual bool MoveTowardPath(System.Numerics.Vector3 TargetLocation, System.Numerics.Vector3 NextTargetLocation, float DeltaTime, float MaxVelocity = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveTowardPath, "BmGame.RHelicopterBase.MoveTowardPath");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextTargetLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxVelocity, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_MoveToward;
    /// <summary>
    /// Function: MoveToward
    /// </summary>
    public unsafe virtual bool MoveToward(System.Numerics.Vector3 TargetLocation, float DeltaTime, float MaxVelocity = default, bool SlowdownOnApproach = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveToward, "BmGame.RHelicopterBase.MoveToward");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxVelocity, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlowdownOnApproach, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_FindPathToLocation;
    /// <summary>
    /// Function: FindPathToLocation
    /// </summary>
    public unsafe virtual bool FindPathToLocation(System.Numerics.Vector3 StartingLocation, System.Numerics.Vector3 TargetLocation, bool FindPointAbove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPathToLocation, "BmGame.RHelicopterBase.FindPathToLocation");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartingLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FindPointAbove, paramsPtr + 24);
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

    private static BmSDK.Function __fn_MoveNoCollision;
    /// <summary>
    /// Function: MoveNoCollision
    /// </summary>
    public unsafe virtual bool MoveNoCollision(System.Numerics.Vector3 Delta)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveNoCollision, "BmGame.RHelicopterBase.MoveNoCollision");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 0);
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

    private static BmSDK.Function __fn_TestLineOfSight;
    /// <summary>
    /// Function: TestLineOfSight
    /// </summary>
    public unsafe virtual bool TestLineOfSight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestLineOfSight, "BmGame.RHelicopterBase.TestLineOfSight");
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

    private static BmSDK.Function __fn_TestSearchLight;
    /// <summary>
    /// Function: TestSearchLight
    /// </summary>
    public unsafe virtual bool TestSearchLight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestSearchLight, "BmGame.RHelicopterBase.TestSearchLight");
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

    private static BmSDK.Function __fn_UpdateVisibility;
    /// <summary>
    /// Function: UpdateVisibility
    /// </summary>
    public unsafe virtual void UpdateVisibility(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateVisibility, "BmGame.RHelicopterBase.UpdateVisibility");
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

    private static BmSDK.Function __fn_TickNative;
    /// <summary>
    /// Function: TickNative
    /// </summary>
    public unsafe virtual void TickNative(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickNative, "BmGame.RHelicopterBase.TickNative");
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

    private static BmSDK.Function __fn_IsValidTakedownTarget;
    /// <summary>
    /// Function: IsValidTakedownTarget
    /// </summary>
    public unsafe virtual bool IsValidTakedownTarget(bool StandingOnVehicle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidTakedownTarget, "BmGame.RHelicopterBase.IsValidTakedownTarget");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StandingOnVehicle, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PlayerExited;
    /// <summary>
    /// Function: PlayerExited
    /// </summary>
    public unsafe virtual void PlayerExited()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerExited, "BmGame.RHelicopterBase.PlayerExited");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerEntered;
    /// <summary>
    /// Function: PlayerEntered
    /// </summary>
    public unsafe virtual void PlayerEntered()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerEntered, "BmGame.RHelicopterBase.PlayerEntered");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBackDoorLocked;
    /// <summary>
    /// Function: SetBackDoorLocked
    /// </summary>
    public unsafe virtual void SetBackDoorLocked(bool bLocked, bool bFromKismet = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBackDoorLocked, "BmGame.RHelicopterBase.SetBackDoorLocked");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLocked, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFromKismet, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsChinook;
    /// <summary>
    /// Function: IsChinook
    /// </summary>
    public unsafe virtual bool IsChinook()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsChinook, "BmGame.RHelicopterBase.IsChinook");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Struct: FHelicopterAbseilSlotInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FHelicopterAbseilSlotInfo
    {
        /// <summary>
        /// NameProperty: AnimName
        /// </summary>
        public unsafe BmSDK.FName AnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Pawn
        /// </summary>
        public unsafe BmSDK.BmGame.RBMPawnAI Pawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FHelicopterPassengerInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FHelicopterPassengerInfo
    {
        /// <summary>
        /// NameProperty: BaseSocket
        /// </summary>
        public unsafe BmSDK.FName BaseSocket
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: Socket
        /// </summary>
        public unsafe BmSDK.FName Socket
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// NameProperty: IdleAnim
        /// </summary>
        public unsafe BmSDK.FName IdleAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// NameProperty: IntoTauntAnim
        /// </summary>
        public unsafe BmSDK.FName IntoTauntAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ObjectProperty: Pawn
        /// </summary>
        public unsafe BmSDK.BmGame.RBMPawnAI Pawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: TauntPoseID
        /// </summary>
        public unsafe int TauntPoseID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Enum: HeliTimeSliceFeature
    /// </summary>
    public enum HeliTimeSliceFeature : byte
    {
        HTS_DustFX = 0,
        HTS_SearchLight = 1,
        HTS_CrowScare = 2,
        HTS_WindGust = 3,
        HTS_MAX = 4,
    }

    /// <summary>
    /// Struct: FHelicopterDifficultyParameters
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FHelicopterDifficultyParameters
    {
        /// <summary>
        /// FloatProperty: ChainGunDamage
        /// </summary>
        public unsafe float ChainGunDamage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: RocketDamage
        /// </summary>
        public unsafe float RocketDamage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// ArrayProperty: RouteCache
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.NavigationPoint> RouteCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.NavigationPoint>>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// FloatProperty: RouteLifeTime
    /// </summary>
    public unsafe float RouteLifeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// FloatProperty: LinearAcceleration
    /// </summary>
    public unsafe float LinearAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// FloatProperty: TurningSpeed
    /// </summary>
    public unsafe float TurningSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// FloatProperty: maxPatrolVelocity
    /// </summary>
    public unsafe float maxPatrolVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// FloatProperty: maxChaseVelocity
    /// </summary>
    public unsafe float maxChaseVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// FloatProperty: maxStrafeVelocity
    /// </summary>
    public unsafe float maxStrafeVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// FloatProperty: LinearVelocity
    /// </summary>
    public unsafe float LinearVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// FloatProperty: SlowDownDistance
    /// </summary>
    public unsafe float SlowDownDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1524); }
    }

    /// <summary>
    /// FloatProperty: TurningDistance
    /// </summary>
    public unsafe float TurningDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }

    /// <summary>
    /// FloatProperty: TurningDistanceRemaining
    /// </summary>
    public unsafe float TurningDistanceRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// BoolProperty: bHasBegunTurning
    /// </summary>
    public unsafe bool bHasBegunTurning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bForcePursuitSpeed
    /// </summary>
    public unsafe bool bForcePursuitSpeed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bHoldPositionUntilBoarded
    /// </summary>
    public unsafe bool bHoldPositionUntilBoarded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: CanSeeThroughSmoke
    /// </summary>
    public unsafe bool CanSeeThroughSmoke
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: DisableSweep
    /// </summary>
    public unsafe bool DisableSweep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: LimitlessVisionRange
    /// </summary>
    public unsafe bool LimitlessVisionRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bInLowDetail
    /// </summary>
    public unsafe bool bInLowDetail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bHasVisualContact
    /// </summary>
    public unsafe bool bHasVisualContact
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bLineOfSightToBatman
    /// </summary>
    public unsafe bool bLineOfSightToBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bBatmanInSearchLight
    /// </summary>
    public unsafe bool bBatmanInSearchLight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bOnScreenLastFrame
    /// </summary>
    public unsafe bool bOnScreenLastFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bActivelyAvoidBatman
    /// </summary>
    public unsafe bool bActivelyAvoidBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bAvoidGettingTooCloseToBatman
    /// </summary>
    public unsafe bool bAvoidGettingTooCloseToBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bBatmanOnBoard
    /// </summary>
    public unsafe bool bBatmanOnBoard
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bSubjectToFlightControl
    /// </summary>
    public unsafe bool bSubjectToFlightControl
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bHasRotors
    /// </summary>
    public unsafe bool bHasRotors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bAllowedToChatter
    /// </summary>
    public unsafe bool bAllowedToChatter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: IsFriendly
    /// </summary>
    public unsafe bool IsFriendly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bHeliTimeSliceVisionCheckAllowed
    /// </summary>
    public unsafe bool bHeliTimeSliceVisionCheckAllowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: playerCanBeSeenByHelicopter
    /// </summary>
    public unsafe bool playerCanBeSeenByHelicopter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bAlertedToBatmansPosition
    /// </summary>
    public unsafe bool bAlertedToBatmansPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: HasLostSightOfBatman
    /// </summary>
    public unsafe bool HasLostSightOfBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bIsAggro
    /// </summary>
    public unsafe bool bIsAggro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: new_lineofsight
    /// </summary>
    public unsafe bool new_lineofsight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bBlocksRECHits
    /// </summary>
    public unsafe bool bBlocksRECHits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bHasCustomLightCode
    /// </summary>
    public unsafe bool bHasCustomLightCode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bAbseiling
    /// </summary>
    public unsafe bool bAbseiling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bAbseilingHasBegun
    /// </summary>
    public unsafe bool bAbseilingHasBegun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: AudioSuspended
    /// </summary>
    public unsafe bool AudioSuspended
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bFixedCombatCameraWhenPlayerIsBasedOn
    /// </summary>
    public unsafe bool bFixedCombatCameraWhenPlayerIsBasedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bDisrupted
    /// </summary>
    public unsafe bool bDisrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bDeleteWhenOffscreen
    /// </summary>
    public unsafe bool bDeleteWhenOffscreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bFriendly
    /// </summary>
    public unsafe bool bFriendly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1540); }
    }

    /// <summary>
    /// BoolProperty: bIsGunship
    /// </summary>
    public unsafe bool bIsGunship
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1540); }
    }

    /// <summary>
    /// BoolProperty: bCanDoHeliChatter
    /// </summary>
    public unsafe bool bCanDoHeliChatter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1540); }
    }

    /// <summary>
    /// BoolProperty: bLastBMPOIWasPriority
    /// </summary>
    public unsafe bool bLastBMPOIWasPriority
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1540); }
    }

    /// <summary>
    /// BoolProperty: DrivingAndOutOfRangeStasisActive
    /// </summary>
    public unsafe bool DrivingAndOutOfRangeStasisActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1540); }
    }

    /// <summary>
    /// BoolProperty: bApplyWindToCape
    /// </summary>
    public unsafe bool bApplyWindToCape
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1540); }
    }

    /// <summary>
    /// BoolProperty: PPEnabled
    /// </summary>
    public unsafe bool PPEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1540); }
    }

    /// <summary>
    /// StructProperty: PrevPointLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PrevPointLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1544);

    /// <summary>
    /// StructProperty: ActualVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ActualVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1556);

    /// <summary>
    /// StructProperty: ActualAcceleration
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ActualAcceleration
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1568);

    /// <summary>
    /// FloatProperty: ActualRotationalVelocity
    /// </summary>
    public unsafe float ActualRotationalVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// StructProperty: VirtualLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VirtualLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1584);

    /// <summary>
    /// StructProperty: VirtualRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator VirtualRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1596);

    /// <summary>
    /// FloatProperty: PitchAndRollMultiplier
    /// </summary>
    public unsafe float PitchAndRollMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// ObjectProperty: LookAtTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor LookAtTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// ObjectProperty: HelicopterPassengerAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet HelicopterPassengerAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1628); }
    }

    /// <summary>
    /// ObjectProperty: FixedCamOverlayAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet FixedCamOverlayAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// ObjectProperty: chinookSeqAct
    /// </summary>
    public unsafe BmSDK.Engine.SequenceAction chinookSeqAct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SequenceAction>(Ptr + 1644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1644); }
    }

    /// <summary>
    /// ObjectProperty: PointOfInterestActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor PointOfInterestActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1652); }
    }

    /// <summary>
    /// ObjectProperty: PreviousPointOfInterestActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor PreviousPointOfInterestActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }

    /// <summary>
    /// ObjectProperty: BarkData
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkCharacterDef BarkData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkCharacterDef>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// ObjectProperty: BarkDataInstance
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkCharacterDefInstance BarkDataInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkCharacterDefInstance>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// ComponentProperty: WindComponent
    /// </summary>
    public unsafe BmSDK.Engine.WindPointSourceComponent WindComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WindPointSourceComponent>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// ComponentProperty: PlayerBlocker
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent PlayerBlocker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// ComponentProperty: DisruptedVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent DisruptedVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// ComponentProperty: LensFlareFX
    /// </summary>
    public unsafe BmSDK.Engine.LensFlareComponent LensFlareFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LensFlareComponent>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// ComponentProperty: SearchLightMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent SearchLightMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// ComponentProperty: TheSpotLightComponent
    /// </summary>
    public unsafe BmSDK.Engine.SpotLightComponent TheSpotLightComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpotLightComponent>(Ptr + 1724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1724); }
    }

    /// <summary>
    /// FloatProperty: RubberBandingPeriod
    /// </summary>
    public unsafe float RubberBandingPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// FloatProperty: RubberBandingMaxAcceleration
    /// </summary>
    public unsafe float RubberBandingMaxAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }

    /// <summary>
    /// FloatProperty: RubberBandingJerkPeriod
    /// </summary>
    public unsafe float RubberBandingJerkPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1740); }
    }

    /// <summary>
    /// FloatProperty: CurrentMaxSpeed
    /// </summary>
    public unsafe float CurrentMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }

    /// <summary>
    /// FloatProperty: MaximumPitchForwardDegrees
    /// </summary>
    public unsafe float MaximumPitchForwardDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// FloatProperty: MaximumBankSidewaysDegrees
    /// </summary>
    public unsafe float MaximumBankSidewaysDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }
    }

    /// <summary>
    /// FloatProperty: MaximumBankFromTurnDegrees
    /// </summary>
    public unsafe float MaximumBankFromTurnDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1756); }
    }

    /// <summary>
    /// FloatProperty: RotationalVelocityMaxDegrees
    /// </summary>
    public unsafe float RotationalVelocityMaxDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// FloatProperty: RotationalAccelerationDegrees
    /// </summary>
    public unsafe float RotationalAccelerationDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// ArrayProperty: WhooshBys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkWwise.FSimpleWhooshBy> WhooshBys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkWwise.FSimpleWhooshBy>>(Ptr + 1768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }
    }

    /// <summary>
    /// FloatProperty: DistanceToCutAudio
    /// </summary>
    public unsafe float DistanceToCutAudio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1784); }
    }

    /// <summary>
    /// StructProperty: GustNormalStart
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GustNormalStart
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1788);

    /// <summary>
    /// StructProperty: GustNormalFinish
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GustNormalFinish
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1800);

    /// <summary>
    /// FloatProperty: GustMagnitude
    /// </summary>
    public unsafe float GustMagnitude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// FloatProperty: GustTimer
    /// </summary>
    public unsafe float GustTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// FloatProperty: GustDuration
    /// </summary>
    public unsafe float GustDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// FloatProperty: GustCalmPeriodDuration
    /// </summary>
    public unsafe float GustCalmPeriodDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }
    }

    /// <summary>
    /// StructProperty: CurrentGustVector
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentGustVector
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1828);

    /// <summary>
    /// FloatProperty: RotationBankingMagnitude
    /// </summary>
    public unsafe float RotationBankingMagnitude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }

    /// <summary>
    /// FloatProperty: WobbleTime
    /// </summary>
    public unsafe float WobbleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// FloatProperty: RecImpactTimestamp
    /// </summary>
    public unsafe float RecImpactTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// FloatProperty: RecImpactImmunityPeriod
    /// </summary>
    public unsafe float RecImpactImmunityPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// FloatProperty: RecImpactDisorientPeriod
    /// </summary>
    public unsafe float RecImpactDisorientPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }
    }

    /// <summary>
    /// StructProperty: WobbleVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WobbleVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1860);

    /// <summary>
    /// FloatProperty: GustStrengthBase
    /// </summary>
    public unsafe float GustStrengthBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1872); }
    }

    /// <summary>
    /// FloatProperty: GustStrengthRange
    /// </summary>
    public unsafe float GustStrengthRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }

    /// <summary>
    /// FloatProperty: GustDurationMin
    /// </summary>
    public unsafe float GustDurationMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// FloatProperty: GustDurationRange
    /// </summary>
    public unsafe float GustDurationRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// FloatProperty: GustCalmPeriod
    /// </summary>
    public unsafe float GustCalmPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }
    }

    /// <summary>
    /// FloatProperty: BobUpAndDownVelocity
    /// </summary>
    public unsafe float BobUpAndDownVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1892); }
    }

    /// <summary>
    /// FloatProperty: BobStartTime
    /// </summary>
    public unsafe float BobStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1896); }
    }

    /// <summary>
    /// FloatProperty: searchLightDetectionRadius
    /// </summary>
    public unsafe float searchLightDetectionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// FloatProperty: searchLightRadius
    /// </summary>
    public unsafe float searchLightRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }
    }

    /// <summary>
    /// FloatProperty: trackingLightRadius
    /// </summary>
    public unsafe float trackingLightRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1908); }
    }

    /// <summary>
    /// FloatProperty: searchLightRangeCM
    /// </summary>
    public unsafe float searchLightRangeCM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// FloatProperty: searchSweepPeriod
    /// </summary>
    public unsafe float searchSweepPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// FloatProperty: searchSweepDegrees
    /// </summary>
    public unsafe float searchSweepDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// FloatProperty: VisionRangeExtended
    /// </summary>
    public unsafe float VisionRangeExtended
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1924); }
    }

    /// <summary>
    /// FloatProperty: searchLightTrackingRate_Idle
    /// </summary>
    public unsafe float searchLightTrackingRate_Idle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// FloatProperty: searchLightTrackingRate_Alert
    /// </summary>
    public unsafe float searchLightTrackingRate_Alert
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// FloatProperty: searchLightGiveUpTime
    /// </summary>
    public unsafe float searchLightGiveUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// StructProperty: lightTargetOrientation
    /// </summary>
    public unsafe ref BmSDK.Rotator lightTargetOrientation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1940);

    /// <summary>
    /// FloatProperty: fOverrideSpeed
    /// </summary>
    public unsafe float fOverrideSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// StructProperty: LightFloorPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LightFloorPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1956);

    /// <summary>
    /// StructProperty: lightPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 lightPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1968);

    /// <summary>
    /// FloatProperty: HoldPositionDistance
    /// </summary>
    public unsafe float HoldPositionDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// FloatProperty: HoldPositionDistanceBeginElevation
    /// </summary>
    public unsafe float HoldPositionDistanceBeginElevation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1984); }
    }

    /// <summary>
    /// FloatProperty: HoldPositionElevation
    /// </summary>
    public unsafe float HoldPositionElevation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// StructProperty: lightOrientation
    /// </summary>
    public unsafe ref BmSDK.Rotator lightOrientation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1992);

    /// <summary>
    /// ArrayProperty: RemoveMaterialsFromDisruptorMeshList
    /// </summary>
    public unsafe BmSDK.TArray<int> RemoveMaterialsFromDisruptorMeshList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2004); }
    }

    /// <summary>
    /// FloatProperty: fDisruptorAimMaximumHeight
    /// </summary>
    public unsafe float fDisruptorAimMaximumHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2020); }
    }

    /// <summary>
    /// FloatProperty: fDisruptorAimMaximumRearDistance
    /// </summary>
    public unsafe float fDisruptorAimMaximumRearDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// StrProperty: sRHDScreenTitle
    /// </summary>
    public unsafe BmSDK.FString sRHDScreenTitle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// ArrayProperty: HelicopterDifficultyLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHelicopterBase.FHelicopterDifficultyParameters> HelicopterDifficultyLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHelicopterBase.FHelicopterDifficultyParameters>>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceVisualContactLost
    /// </summary>
    public unsafe float TimeSinceVisualContactLost
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// NameProperty: DroneCombatEvTag
    /// </summary>
    public unsafe BmSDK.FName DroneCombatEvTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// ArrayProperty: HeliTimeSliceFrameCounts
    /// </summary>
    public unsafe BmSDK.TArray<int> HeliTimeSliceFrameCounts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// ArrayProperty: HeliTimeSliceFeatureQueued
    /// </summary>
    public unsafe BmSDK.TArray<bool> HeliTimeSliceFeatureQueued
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// IntProperty: framesBetweenDustFXUpdates_Active
    /// </summary>
    public unsafe int framesBetweenDustFXUpdates_Active
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// IntProperty: framesBetweenDustFXUpdates_Inactive
    /// </summary>
    public unsafe int framesBetweenDustFXUpdates_Inactive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// IntProperty: framesBetweenSearchLightTraces
    /// </summary>
    public unsafe int framesBetweenSearchLightTraces
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// IntProperty: framesBetweenCrowScares
    /// </summary>
    public unsafe int framesBetweenCrowScares
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// IntProperty: framesBetweenWindGustUpdates
    /// </summary>
    public unsafe int framesBetweenWindGustUpdates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// FloatProperty: windGustDeltaTime
    /// </summary>
    public unsafe float windGustDeltaTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// StructProperty: BMLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BMLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2128);

    /// <summary>
    /// FloatProperty: LastSpottedTime
    /// </summary>
    public unsafe float LastSpottedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// ArrayProperty: HelicopterPassengerList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHelicopterBase.FHelicopterPassengerInfo> HelicopterPassengerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHelicopterBase.FHelicopterPassengerInfo>>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// ArrayProperty: HelicopterRocketPassengerList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHelicopterBase.FHelicopterPassengerInfo> HelicopterRocketPassengerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHelicopterBase.FHelicopterPassengerInfo>>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// ArrayProperty: HelicopterAbseilSlots
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHelicopterBase.FHelicopterAbseilSlotInfo> HelicopterAbseilSlots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHelicopterBase.FHelicopterAbseilSlotInfo>>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// FloatProperty: MaxAbseilHeight
    /// </summary>
    public unsafe float MaxAbseilHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// StructProperty: FixedCamLocationOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FixedCamLocationOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2196);

    /// <summary>
    /// StructProperty: FixedCamLocationRange
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FixedCamLocationRange
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2208);

    /// <summary>
    /// StructProperty: FixedCamRotationOffset
    /// </summary>
    public unsafe ref BmSDK.Rotator FixedCamRotationOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2220);

    /// <summary>
    /// StructProperty: FixedCamRotationRange
    /// </summary>
    public unsafe ref BmSDK.Rotator FixedCamRotationRange
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2232);

    /// <summary>
    /// FloatProperty: FixedCamFOV
    /// </summary>
    public unsafe float FixedCamFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// FloatProperty: FixedCamFOVRange
    /// </summary>
    public unsafe float FixedCamFOVRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }

    /// <summary>
    /// FloatProperty: FixedCamMinDist
    /// </summary>
    public unsafe float FixedCamMinDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// FloatProperty: FixedCamMaxDist
    /// </summary>
    public unsafe float FixedCamMaxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// FloatProperty: FixedCamYawFollowPercent
    /// </summary>
    public unsafe float FixedCamYawFollowPercent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// NameProperty: FixedCamOverlayName
    /// </summary>
    public unsafe BmSDK.FName FixedCamOverlayName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }

    /// <summary>
    /// FloatProperty: BoundsRadius
    /// </summary>
    public unsafe float BoundsRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }
    }

    /// <summary>
    /// FloatProperty: BoundsHeight
    /// </summary>
    public unsafe float BoundsHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// StrProperty: sDisruptorHUDDescription
    /// </summary>
    public unsafe BmSDK.FString sDisruptorHUDDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// FloatProperty: BlindedDuration
    /// </summary>
    public unsafe float BlindedDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }
    }

    /// <summary>
    /// ByteProperty: PointOfInterestType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes PointOfInterestType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// FloatProperty: lastBMPOITime
    /// </summary>
    public unsafe float lastBMPOITime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// FloatProperty: PointOfInterestIgnoreTimer
    /// </summary>
    public unsafe float PointOfInterestIgnoreTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }

    /// <summary>
    /// NameProperty: lastBMPOIBarkFlag
    /// </summary>
    public unsafe BmSDK.FName lastBMPOIBarkFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }
    }

    /// <summary>
    /// FloatProperty: PointOfInterestTryTimer
    /// </summary>
    public unsafe float PointOfInterestTryTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// IntProperty: PointOfInterestTimeSliceInt
    /// </summary>
    public unsafe int PointOfInterestTimeSliceInt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2324); }
    }

    /// <summary>
    /// StructProperty: QueuedFinalRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator QueuedFinalRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2328);

    /// <summary>
    /// FloatProperty: PPSpeed
    /// </summary>
    public unsafe float PPSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2340); }
    }

    /// <summary>
    /// FloatProperty: PPMax
    /// </summary>
    public unsafe float PPMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2344); }
    }
}
