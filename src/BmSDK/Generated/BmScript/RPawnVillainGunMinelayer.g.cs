#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnVillainGunMinelayer<br/>
/// (size = 6880)
/// (flags = 10485814)
/// </summary>
public partial class RPawnVillainGunMinelayer : BmSDK.BmScript.RPawnVillainGunPredFull, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnVillainGunMinelayer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillainGunMinelayer.
    /// </summary>
    public static RPawnVillainGunMinelayer DefaultObject => (RPawnVillainGunMinelayer)StaticClass().DefaultObject;

    internal RPawnVillainGunMinelayer() { }

    /// <summary>
    /// Constructs a new RPawnVillainGunMinelayer
    /// </summary>
    public RPawnVillainGunMinelayer(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainGunMinelayer(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunMinelayer>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunMinelayer>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunMinelayer>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunMinelayer>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunMinelayer>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunMinelayer>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunMinelayer>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunMinelayer>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_WakeFromDead;
    /// <summary>
    /// Function: WakeFromDead
    /// </summary>
    public unsafe override void WakeFromDead(BmSDK.BmGame.RPawnCharacter NewGetUpMaster = default, BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId NewGetUpMasterAnimID = default, BmSDK.Engine.AnimSet NewGetUpAnimset = default, BmSDK.FName NewGetUpAnimName = default, BmSDK.FName GetUpMovementStance = default, bool bDoAnim = default, bool bAnimImmediate = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WakeFromDead, "BmScript.RPawnVillainGunMinelayer.WakeFromDead");
        byte* paramsPtr = stackalloc byte[44];
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

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmScript.RPawnVillainGunMinelayer.Died");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_SwitchEquipmentXrayMaterial;
    /// <summary>
    /// Function: SwitchEquipmentXrayMaterial
    /// </summary>
    public unsafe override void SwitchEquipmentXrayMaterial(BmSDK.Engine.MaterialInterface NewMIC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchEquipmentXrayMaterial, "BmScript.RPawnVillainGunMinelayer.SwitchEquipmentXrayMaterial");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMIC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDisruptedEquipmentLocationAndRotation;
    /// <summary>
    /// Function: GetDisruptedEquipmentLocationAndRotation
    /// </summary>
    public unsafe override void GetDisruptedEquipmentLocationAndRotation(out System.Numerics.Vector3 vLocation, out BmSDK.Rotator rRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisruptedEquipmentLocationAndRotation, "BmScript.RPawnVillainGunMinelayer.GetDisruptedEquipmentLocationAndRotation");
        byte* paramsPtr = stackalloc byte[24];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out vLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out rRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        vLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        rRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_DisruptorDisableEquipment;
    /// <summary>
    /// Function: DisruptorDisableEquipment
    /// </summary>
    public unsafe override void DisruptorDisableEquipment()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisruptorDisableEquipment, "BmScript.RPawnVillainGunMinelayer.DisruptorDisableEquipment");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RestoreDisruptorDisabledEquipment;
    /// <summary>
    /// Function: RestoreDisruptorDisabledEquipment
    /// </summary>
    public unsafe override void RestoreDisruptorDisabledEquipment()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreDisruptorDisabledEquipment, "BmScript.RPawnVillainGunMinelayer.RestoreDisruptorDisabledEquipment");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMineInVentTFRConfig;
    /// <summary>
    /// Function: GetMineInVentTFRConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RTransitionFromRunConfig GetMineInVentTFRConfig()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMineInVentTFRConfig, "BmScript.RPawnVillainGunMinelayer.GetMineInVentTFRConfig");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RTransitionFromRunConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMinelayerAnimset;
    /// <summary>
    /// Function: GetMinelayerAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetMinelayerAnimset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMinelayerAnimset, "BmScript.RPawnVillainGunMinelayer.GetMinelayerAnimset");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetGrabMineHidden;
    /// <summary>
    /// Function: SetGrabMineHidden
    /// </summary>
    public unsafe override void SetGrabMineHidden(bool bNewVal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGrabMineHidden, "BmScript.RPawnVillainGunMinelayer.SetGrabMineHidden");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewVal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMineMeshComps;
    /// <summary>
    /// Function: GetMineMeshComps
    /// </summary>
    public unsafe virtual void GetMineMeshComps()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMineMeshComps, "BmScript.RPawnVillainGunMinelayer.GetMineMeshComps");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachProps;
    /// <summary>
    /// Function: AttachProps
    /// </summary>
    public unsafe override void AttachProps()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachProps, "BmScript.RPawnVillainGunMinelayer.AttachProps");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPawnProps;
    /// <summary>
    /// Function: AddPawnProps
    /// </summary>
    public unsafe override void AddPawnProps()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPawnProps, "BmScript.RPawnVillainGunMinelayer.AddPawnProps");
        byte* paramsPtr = stackalloc byte[552];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmScript.RPawnVillainGunMinelayer.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnMine;
    /// <summary>
    /// Function: SpawnMine
    /// </summary>
    public unsafe override bool SpawnMine(BmSDK.BmGame.RThugMineablePointBase TargetMinePoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnMine, "BmScript.RPawnVillainGunMinelayer.SpawnMine");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetMinePoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// ComponentProperty: GrabMineMeshStandard
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent GrabMineMeshStandard
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6808); }
    }

    /// <summary>
    /// ObjectProperty: MineInVentTFRConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RTransitionFromRunConfig MineInVentTFRConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTransitionFromRunConfig>(Ptr + 6816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6816); }
    }

    /// <summary>
    /// ObjectProperty: MineMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh MineMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 6824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6824); }
    }

    /// <summary>
    /// ObjectProperty: MinePhysics
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsAsset MinePhysics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAsset>(Ptr + 6832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6832); }
    }

    /// <summary>
    /// ObjectProperty: DisruptedMineXrayMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant DisruptedMineXrayMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6840); }
    }

    /// <summary>
    /// ObjectProperty: NormalMineXrayMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant NormalMineXrayMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6848); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: MineMeshComps
    /// </summary>
    public InlineArray<BmSDK.Engine.SkeletalMeshComponent> MineMeshComps => new(3, Ptr + 6856, 8, this);

    /// <summary>
    /// ComponentProperty: MineMeshComps
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent MineMeshComps_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6856); }
    }
    /// <summary>
    /// ComponentProperty: MineMeshComps
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent MineMeshComps_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6864); }
    }
    /// <summary>
    /// ComponentProperty: MineMeshComps
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent MineMeshComps_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6872); }
    }
}
