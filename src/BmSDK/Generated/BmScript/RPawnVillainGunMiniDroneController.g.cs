#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnVillainGunMiniDroneController<br/>
/// (size = 6896)
/// (flags = 10485814)
/// </summary>
public partial class RPawnVillainGunMiniDroneController : BmSDK.BmScript.RPawnVillainGunPredFull, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnVillainGunMiniDroneController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillainGunMiniDroneController.
    /// </summary>
    public static RPawnVillainGunMiniDroneController DefaultObject => (RPawnVillainGunMiniDroneController)StaticClass().DefaultObject;

    internal RPawnVillainGunMiniDroneController() { }

    /// <summary>
    /// Constructs a new RPawnVillainGunMiniDroneController
    /// </summary>
    public RPawnVillainGunMiniDroneController(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainGunMiniDroneController(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunMiniDroneController>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunMiniDroneController>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunMiniDroneController>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunMiniDroneController>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunMiniDroneController>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunMiniDroneController>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunMiniDroneController>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunMiniDroneController>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetEquipmentPropSkeletalsIndex;
    /// <summary>
    /// Function: GetEquipmentPropSkeletalsIndex
    /// </summary>
    public unsafe override int GetEquipmentPropSkeletalsIndex()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEquipmentPropSkeletalsIndex, "BmScript.RPawnVillainGunMiniDroneController.GetEquipmentPropSkeletalsIndex");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InformOfDroneExploding;
    /// <summary>
    /// Function: InformOfDroneExploding
    /// </summary>
    public unsafe virtual void InformOfDroneExploding()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InformOfDroneExploding, "BmScript.RPawnVillainGunMiniDroneController.InformOfDroneExploding");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CodesHaveFinishedDownloading;
    /// <summary>
    /// Function: CodesHaveFinishedDownloading
    /// </summary>
    public unsafe virtual void CodesHaveFinishedDownloading()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CodesHaveFinishedDownloading, "BmScript.RPawnVillainGunMiniDroneController.CodesHaveFinishedDownloading");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindMiniDrone;
    /// <summary>
    /// Function: FindMiniDrone
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHelicopterBase FindMiniDrone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindMiniDrone, "BmScript.RPawnVillainGunMiniDroneController.FindMiniDrone");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterBase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetControllerToMiniDroneLineStartLocation;
    /// <summary>
    /// Function: GetControllerToMiniDroneLineStartLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetControllerToMiniDroneLineStartLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetControllerToMiniDroneLineStartLocation, "BmScript.RPawnVillainGunMiniDroneController.GetControllerToMiniDroneLineStartLocation");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasDroneRemoteInHand;
    /// <summary>
    /// Function: HasDroneRemoteInHand
    /// </summary>
    public unsafe override bool HasDroneRemoteInHand()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasDroneRemoteInHand, "BmScript.RPawnVillainGunMiniDroneController.HasDroneRemoteInHand");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMyMiniDrone;
    /// <summary>
    /// Function: GetMyMiniDrone
    /// </summary>
    public unsafe override BmSDK.BmGame.RHelicopterBase GetMyMiniDrone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMyMiniDrone, "BmScript.RPawnVillainGunMiniDroneController.GetMyMiniDrone");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterBase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsMinidroneController;
    /// <summary>
    /// Function: IsMinidroneController
    /// </summary>
    public unsafe override bool IsMinidroneController()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMinidroneController, "BmScript.RPawnVillainGunMiniDroneController.IsMinidroneController");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ThrowRemoteAway;
    /// <summary>
    /// Function: ThrowRemoteAway
    /// </summary>
    public unsafe override void ThrowRemoteAway()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowRemoteAway, "BmScript.RPawnVillainGunMiniDroneController.ThrowRemoteAway");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasRemoteBeenThrownAway;
    /// <summary>
    /// Function: HasRemoteBeenThrownAway
    /// </summary>
    public unsafe override bool HasRemoteBeenThrownAway()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasRemoteBeenThrownAway, "BmScript.RPawnVillainGunMiniDroneController.HasRemoteBeenThrownAway");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsMiniDroneDisabledByREC;
    /// <summary>
    /// Function: IsMiniDroneDisabledByREC
    /// </summary>
    public unsafe override bool IsMiniDroneDisabledByREC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMiniDroneDisabledByREC, "BmScript.RPawnVillainGunMiniDroneController.IsMiniDroneDisabledByREC");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MiniDroneRecoveredFromDisruptor;
    /// <summary>
    /// Function: MiniDroneRecoveredFromDisruptor
    /// </summary>
    public unsafe virtual void MiniDroneRecoveredFromDisruptor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MiniDroneRecoveredFromDisruptor, "BmScript.RPawnVillainGunMiniDroneController.MiniDroneRecoveredFromDisruptor");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MiniDroneHitByDisruptor;
    /// <summary>
    /// Function: MiniDroneHitByDisruptor
    /// </summary>
    public unsafe virtual void MiniDroneHitByDisruptor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MiniDroneHitByDisruptor, "BmScript.RPawnVillainGunMiniDroneController.MiniDroneHitByDisruptor");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnJammedExplosion;
    /// <summary>
    /// Function: SpawnJammedExplosion
    /// </summary>
    public unsafe virtual void SpawnJammedExplosion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnJammedExplosion, "BmScript.RPawnVillainGunMiniDroneController.SpawnJammedExplosion");
        byte* paramsPtr = stackalloc byte[272];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MiniDroneAttackingTarget;
    /// <summary>
    /// Function: MiniDroneAttackingTarget
    /// </summary>
    public unsafe virtual void MiniDroneAttackingTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MiniDroneAttackingTarget, "BmScript.RPawnVillainGunMiniDroneController.MiniDroneAttackingTarget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MiniDroneFoundCasualty;
    /// <summary>
    /// Function: MiniDroneFoundCasualty
    /// </summary>
    public unsafe virtual void MiniDroneFoundCasualty(BmSDK.BmGame.RPawnVillain Casualty)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MiniDroneFoundCasualty, "BmScript.RPawnVillainGunMiniDroneController.MiniDroneFoundCasualty");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Casualty, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDisruptedEquipmentLocationAndRotation;
    /// <summary>
    /// Function: GetDisruptedEquipmentLocationAndRotation
    /// </summary>
    public unsafe override void GetDisruptedEquipmentLocationAndRotation(out System.Numerics.Vector3 vLocation, out BmSDK.Rotator rRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisruptedEquipmentLocationAndRotation, "BmScript.RPawnVillainGunMiniDroneController.GetDisruptedEquipmentLocationAndRotation");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        vLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        rRotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_DisruptorDisableEquipment;
    /// <summary>
    /// Function: DisruptorDisableEquipment
    /// </summary>
    public unsafe override void DisruptorDisableEquipment()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisruptorDisableEquipment, "BmScript.RPawnVillainGunMiniDroneController.DisruptorDisableEquipment");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnequipMiniDroneController;
    /// <summary>
    /// Function: UnequipMiniDroneController
    /// </summary>
    public unsafe override void UnequipMiniDroneController()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnequipMiniDroneController, "BmScript.RPawnVillainGunMiniDroneController.UnequipMiniDroneController");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EquipMiniDroneController;
    /// <summary>
    /// Function: EquipMiniDroneController
    /// </summary>
    public unsafe override void EquipMiniDroneController()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EquipMiniDroneController, "BmScript.RPawnVillainGunMiniDroneController.EquipMiniDroneController");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RestoreDisruptorDisabledEquipment;
    /// <summary>
    /// Function: RestoreDisruptorDisabledEquipment
    /// </summary>
    public unsafe override void RestoreDisruptorDisabledEquipment()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreDisruptorDisabledEquipment, "BmScript.RPawnVillainGunMiniDroneController.RestoreDisruptorDisabledEquipment");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDroneControllerAnimset;
    /// <summary>
    /// Function: GetDroneControllerAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetDroneControllerAnimset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDroneControllerAnimset, "BmScript.RPawnVillainGunMiniDroneController.GetDroneControllerAnimset");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AddPawnProps;
    /// <summary>
    /// Function: AddPawnProps
    /// </summary>
    public unsafe override void AddPawnProps()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPawnProps, "BmScript.RPawnVillainGunMiniDroneController.AddPawnProps");
        byte* paramsPtr = stackalloc byte[184];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachProps;
    /// <summary>
    /// Function: AttachProps
    /// </summary>
    public unsafe override void AttachProps()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachProps, "BmScript.RPawnVillainGunMiniDroneController.AttachProps");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.RPawnVillainGunMiniDroneController.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// NameProperty: nHandBoneToAttachControllerTo
    /// </summary>
    public unsafe BmSDK.FName nHandBoneToAttachControllerTo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6808); }
    }

    /// <summary>
    /// NameProperty: nBeltSocketToAttachControllerTo
    /// </summary>
    public unsafe BmSDK.FName nBeltSocketToAttachControllerTo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6816); }
    }

    /// <summary>
    /// ObjectProperty: ControllerSkeletalMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh ControllerSkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 6824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6824); }
    }

    /// <summary>
    /// ObjectProperty: ControllerPhysicsAsset
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsAsset ControllerPhysicsAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAsset>(Ptr + 6832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6832); }
    }

    /// <summary>
    /// ObjectProperty: ControllerXrayMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant ControllerXrayMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6840); }
    }

    /// <summary>
    /// ObjectProperty: ControllerDisruptedXrayMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant ControllerDisruptedXrayMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6848); }
    }

    /// <summary>
    /// ObjectProperty: JammedExplosionVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem JammedExplosionVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 6856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6856); }
    }

    /// <summary>
    /// ObjectProperty: JammedExplodeEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent JammedExplodeEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6864); }
    }

    /// <summary>
    /// ObjectProperty: LightArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RDeferred_SpotLight_Shadowed_Spawnable LightArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeferred_SpotLight_Shadowed_Spawnable>(Ptr + 6872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6872); }
    }

    /// <summary>
    /// ObjectProperty: lightInstance
    /// </summary>
    public unsafe BmSDK.BmGame.RDeferred_SpotLight_Shadowed_Spawnable lightInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeferred_SpotLight_Shadowed_Spawnable>(Ptr + 6880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6880); }
    }

    /// <summary>
    /// IntProperty: iMiniDroneControllerIndex
    /// </summary>
    public unsafe int iMiniDroneControllerIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6888); }
    }

    /// <summary>
    /// BoolProperty: bMyMiniDroneHasExploded
    /// </summary>
    public unsafe bool bMyMiniDroneHasExploded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6892) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6892); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6892); }
    }
}
