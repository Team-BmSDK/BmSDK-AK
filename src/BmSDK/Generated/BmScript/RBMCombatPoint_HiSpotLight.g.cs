#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMCombatPoint_HiSpotLight<br/>
/// (size = 1008)
/// (flags = 10486290)
/// </summary>
public partial class RBMCombatPoint_HiSpotLight : BmSDK.BmGame.RBMCombatPoint_EnvironmentAttackObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMCombatPoint_HiSpotLight", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMCombatPoint_HiSpotLight.
    /// </summary>
    public static RBMCombatPoint_HiSpotLight DefaultObject => (RBMCombatPoint_HiSpotLight)StaticClass().DefaultObject;

    internal RBMCombatPoint_HiSpotLight() { }

    /// <summary>
    /// Constructs a new RBMCombatPoint_HiSpotLight
    /// </summary>
    public RBMCombatPoint_HiSpotLight(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMCombatPoint_HiSpotLight(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_HiSpotLight>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_HiSpotLight>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_HiSpotLight>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_HiSpotLight>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_HiSpotLight>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_HiSpotLight>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_HiSpotLight>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_HiSpotLight>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_IsValidLoc;
    /// <summary>
    /// Function: IsValidLoc
    /// </summary>
    public unsafe override bool IsValidLoc(BmSDK.BmGame.RPawnPlayerCombat TestPlayer, BmSDK.BmGame.RPawnVillain TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidLoc, "BmScript.RBMCombatPoint_HiSpotLight.IsValidLoc");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetAnimYaw;
    /// <summary>
    /// Function: GetAnimYaw
    /// </summary>
    public unsafe override float GetAnimYaw()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimYaw, "BmScript.RBMCombatPoint_HiSpotLight.GetAnimYaw");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMeshYawOffset;
    /// <summary>
    /// Function: GetMeshYawOffset
    /// </summary>
    public unsafe override float GetMeshYawOffset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMeshYawOffset, "BmScript.RBMCombatPoint_HiSpotLight.GetMeshYawOffset");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayDestroyAnim;
    /// <summary>
    /// Function: PlayDestroyAnim
    /// </summary>
    public unsafe override bool PlayDestroyAnim(BmSDK.FName AnimName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDestroyAnim, "BmScript.RBMCombatPoint_HiSpotLight.PlayDestroyAnim");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetAnimName;
    /// <summary>
    /// Function: GetAnimName
    /// </summary>
    public unsafe override BmSDK.FName GetAnimName(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimName, "BmScript.RBMCombatPoint_HiSpotLight.GetAnimName");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_UsedByPawn;
    /// <summary>
    /// Function: UsedByPawn
    /// </summary>
    public unsafe override void UsedByPawn(BmSDK.BmGame.RPawnCombat NewUser, BmSDK.Engine.Actor NewTarget = default, bool bUsedDuringTaunt = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UsedByPawn, "BmScript.RBMCombatPoint_HiSpotLight.UsedByPawn");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUser, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUsedDuringTaunt, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDroppedObject;
    /// <summary>
    /// Function: OnDroppedObject
    /// </summary>
    public unsafe override void OnDroppedObject(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDroppedObject, "BmScript.RBMCombatPoint_HiSpotLight.OnDroppedObject");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnGrabbedObject;
    /// <summary>
    /// Function: OnGrabbedObject
    /// </summary>
    public unsafe override void OnGrabbedObject(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnGrabbedObject, "BmScript.RBMCombatPoint_HiSpotLight.OnGrabbedObject");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadedStateChanged;
    /// <summary>
    /// Function: FadedStateChanged
    /// </summary>
    public unsafe override void FadedStateChanged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadedStateChanged, "BmScript.RBMCombatPoint_HiSpotLight.FadedStateChanged");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupHighlightMesh;
    /// <summary>
    /// Function: SetupHighlightMesh
    /// </summary>
    public unsafe override void SetupHighlightMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupHighlightMesh, "BmScript.RBMCombatPoint_HiSpotLight.SetupHighlightMesh");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugReset;
    /// <summary>
    /// Function: DebugReset
    /// </summary>
    public unsafe override void DebugReset(BmSDK.BmGame.RBMCombatManager CM)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugReset, "BmScript.RBMCombatPoint_HiSpotLight.DebugReset");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CM, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSwapMesh;
    /// <summary>
    /// Function: OnSwapMesh
    /// </summary>
    public unsafe override void OnSwapMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSwapMesh, "BmScript.RBMCombatPoint_HiSpotLight.OnSwapMesh");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.RBMCombatPoint_HiSpotLight.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ComponentProperty: SpotLightChain
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent SpotLightChain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ObjectProperty: SpotLight
    /// </summary>
    public unsafe BmSDK.BmScript.RBMCombatThrownObject_HiSpotLightSmashable SpotLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RBMCombatThrownObject_HiSpotLightSmashable>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ComponentProperty: LightComponent
    /// </summary>
    public unsafe BmSDK.Engine.SpotLightComponent LightComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpotLightComponent>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// ComponentProperty: SpotLightInRangeHighlightMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent SpotLightInRangeHighlightMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// ComponentProperty: InRangeHighlightMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent InRangeHighlightMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// NameProperty: SocketName
    /// </summary>
    public unsafe BmSDK.FName SocketName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// FloatProperty: AnimYaw
    /// </summary>
    public unsafe float AnimYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }
}
