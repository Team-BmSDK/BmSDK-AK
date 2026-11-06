#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMCombatPoint_EnvironmentAttackObjectBase<br/>
/// (size = 924)
/// (flags = 144704146)
/// </summary>
public partial class RBMCombatPoint_EnvironmentAttackObjectBase : BmSDK.BmGame.RBMCombatPoint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMCombatPoint_EnvironmentAttackObjectBase.
    /// </summary>
    public static RBMCombatPoint_EnvironmentAttackObjectBase DefaultObject => (RBMCombatPoint_EnvironmentAttackObjectBase)StaticClass().DefaultObject;

    internal RBMCombatPoint_EnvironmentAttackObjectBase() { }

    /// <summary>
    /// Constructs a new RBMCombatPoint_EnvironmentAttackObjectBase
    /// </summary>
    public RBMCombatPoint_EnvironmentAttackObjectBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMCombatPoint_EnvironmentAttackObjectBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_EnvironmentAttackObjectBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_EnvironmentAttackObjectBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_EnvironmentAttackObjectBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_EnvironmentAttackObjectBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_EnvironmentAttackObjectBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_EnvironmentAttackObjectBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_EnvironmentAttackObjectBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_EnvironmentAttackObjectBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_FireDestroyedEvent;
    /// <summary>
    /// Function: FireDestroyedEvent
    /// </summary>
    public unsafe virtual void FireDestroyedEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireDestroyedEvent, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.FireDestroyedEvent");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.Tick");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHighlightMeshesHidden;
    /// <summary>
    /// Function: SetHighlightMeshesHidden
    /// </summary>
    public unsafe virtual void SetHighlightMeshesHidden(bool bHide)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHighlightMeshesHidden, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.SetHighlightMeshesHidden");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHide, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHighlightPlayerInRange;
    /// <summary>
    /// Function: SetHighlightPlayerInRange
    /// </summary>
    public unsafe virtual void SetHighlightPlayerInRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHighlightPlayerInRange, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.SetHighlightPlayerInRange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHighlightBothInRange;
    /// <summary>
    /// Function: SetHighlightBothInRange
    /// </summary>
    public unsafe virtual void SetHighlightBothInRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHighlightBothInRange, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.SetHighlightBothInRange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsValidPlayer;
    /// <summary>
    /// Function: IsValidPlayer
    /// </summary>
    public unsafe virtual bool IsValidPlayer(BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidPlayer, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.IsValidPlayer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPlayerInRange;
    /// <summary>
    /// Function: GetPlayerInRange
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayerCombat GetPlayerInRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerInRange, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.GetPlayerInRange");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayerCombat>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsValidLoc;
    /// <summary>
    /// Function: IsValidLoc
    /// </summary>
    public unsafe virtual bool IsValidLoc(BmSDK.BmGame.RPawnPlayerCombat TestPlayer, BmSDK.BmGame.RPawnVillain TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidLoc, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.IsValidLoc");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetPriority;
    /// <summary>
    /// Function: GetPriority
    /// </summary>
    public unsafe virtual float GetPriority(BmSDK.BmGame.RPawnVillain TestVillain, float DistToPlayerSq, float MaxDistToPlayerSq)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPriority, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.GetPriority");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestVillain, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistToPlayerSq, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDistToPlayerSq, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetTargetEndStance;
    /// <summary>
    /// Function: GetTargetEndStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetTargetEndStance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetEndStance, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.GetTargetEndStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldKill;
    /// <summary>
    /// Function: ShouldKill
    /// </summary>
    public unsafe virtual bool ShouldKill()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldKill, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.ShouldKill");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCurrentVillainHighlight;
    /// <summary>
    /// Function: SetCurrentVillainHighlight
    /// </summary>
    public unsafe virtual void SetCurrentVillainHighlight(bool bOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentVillainHighlight, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.SetCurrentVillainHighlight");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UsedByPawn;
    /// <summary>
    /// Function: UsedByPawn
    /// </summary>
    public unsafe override void UsedByPawn(BmSDK.BmGame.RPawnCombat NewUser, BmSDK.Engine.Actor NewTarget = default, bool bUsedDuringTaunt = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UsedByPawn, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.UsedByPawn");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUser, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUsedDuringTaunt, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeUsedByPlayer;
    /// <summary>
    /// Function: CanBeUsedByPlayer
    /// </summary>
    public unsafe override bool CanBeUsedByPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeUsedByPlayer, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.CanBeUsedByPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeUsedByPawn;
    /// <summary>
    /// Function: CanBeUsedByPawn
    /// </summary>
    public unsafe override bool CanBeUsedByPawn(BmSDK.BmGame.RPawnCombat NewUser, BmSDK.Engine.Actor TargetActor, bool bTaunting)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeUsedByPawn, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.CanBeUsedByPawn");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUser, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetActor, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTaunting, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_SetupHighlightMaterial;
    /// <summary>
    /// Function: SetupHighlightMaterial
    /// </summary>
    public unsafe virtual void SetupHighlightMaterial()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupHighlightMaterial, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.SetupHighlightMaterial");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLights;
    /// <summary>
    /// Function: ClearLights
    /// </summary>
    public unsafe virtual void ClearLights()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLights, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.ClearLights");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugReset;
    /// <summary>
    /// Function: DebugReset
    /// </summary>
    public unsafe virtual void DebugReset(BmSDK.BmGame.RBMCombatManager CM)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugReset, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.DebugReset");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CM, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMeshYawOffset;
    /// <summary>
    /// Function: GetMeshYawOffset
    /// </summary>
    public unsafe virtual float GetMeshYawOffset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMeshYawOffset, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.GetMeshYawOffset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetObjectLocation_UC;
    /// <summary>
    /// Function: GetObjectLocation_UC
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetObjectLocation_UC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjectLocation_UC, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.GetObjectLocation_UC");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetObjectLocation;
    /// <summary>
    /// Function: GetObjectLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetObjectLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjectLocation, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.GetObjectLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnimYaw_UC;
    /// <summary>
    /// Function: GetAnimYaw_UC
    /// </summary>
    public unsafe virtual int GetAnimYaw_UC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimYaw_UC, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.GetAnimYaw_UC");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnimYaw;
    /// <summary>
    /// Function: GetAnimYaw
    /// </summary>
    public unsafe virtual float GetAnimYaw()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimYaw, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.GetAnimYaw");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetMyPylon;
    /// <summary>
    /// Function: SetMyPylon
    /// </summary>
    public unsafe virtual void SetMyPylon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMyPylon, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.SetMyPylon");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterStasisCheckMesh;
    /// <summary>
    /// Function: RegisterStasisCheckMesh
    /// </summary>
    public unsafe virtual void RegisterStasisCheckMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterStasisCheckMesh, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.RegisterStasisCheckMesh");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayDestroyAnim;
    /// <summary>
    /// Function: PlayDestroyAnim
    /// </summary>
    public unsafe virtual bool PlayDestroyAnim(BmSDK.FName AnimName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDestroyAnim, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.PlayDestroyAnim");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetupHighlightMesh;
    /// <summary>
    /// Function: SetupHighlightMesh
    /// </summary>
    public unsafe virtual void SetupHighlightMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupHighlightMesh, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.SetupHighlightMesh");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAnimName;
    /// <summary>
    /// Function: GetAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetAnimName(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimName, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.GetAnimName");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_OnSwapMesh;
    /// <summary>
    /// Function: OnSwapMesh
    /// </summary>
    public unsafe virtual void OnSwapMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSwapMesh, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.OnSwapMesh");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFxEvent;
    /// <summary>
    /// Function: OnFxEvent
    /// </summary>
    public unsafe virtual void OnFxEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFxEvent, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.OnFxEvent");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDroppedObject;
    /// <summary>
    /// Function: OnDroppedObject
    /// </summary>
    public unsafe virtual void OnDroppedObject(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDroppedObject, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.OnDroppedObject");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnGrabbedObject;
    /// <summary>
    /// Function: OnGrabbedObject
    /// </summary>
    public unsafe virtual void OnGrabbedObject(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnGrabbedObject, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.OnGrabbedObject");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearHighlight;
    /// <summary>
    /// Function: ClearHighlight
    /// </summary>
    public unsafe virtual void ClearHighlight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearHighlight, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.ClearHighlight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHighlight;
    /// <summary>
    /// Function: UpdateHighlight
    /// </summary>
    public unsafe virtual void UpdateHighlight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHighlight, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.UpdateHighlight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoRangeCheck;
    /// <summary>
    /// Function: DoRangeCheck
    /// </summary>
    public unsafe virtual void DoRangeCheck()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoRangeCheck, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.DoRangeCheck");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsValidInCombat;
    /// <summary>
    /// Function: IsValidInCombat
    /// </summary>
    public unsafe virtual bool IsValidInCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidInCombat, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.IsValidInCombat");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsValidVillain;
    /// <summary>
    /// Function: IsValidVillain
    /// </summary>
    public unsafe virtual bool IsValidVillain(BmSDK.BmGame.RPawnVillain TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidVillain, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.IsValidVillain");
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

    private static BmSDK.Function __fn_GetRotatedVectorOnAxis;
    /// <summary>
    /// Function: GetRotatedVectorOnAxis
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRotatedVectorOnAxis(System.Numerics.Vector3 vec, int Angle, System.Numerics.Vector3 Axis)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRotatedVectorOnAxis, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.GetRotatedVectorOnAxis");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vec, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Angle, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Axis, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_SetLight;
    /// <summary>
    /// Function: SetLight
    /// </summary>
    public unsafe virtual void SetLight(BmSDK.Engine.PointLightComponent LightComp, BmSDK.FName LightSocket, bool Enable)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLight, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.SetLight");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LightComp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LightSocket, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Enable, paramsPtr + 16);
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

    private static BmSDK.Function __fn_SetupLights;
    /// <summary>
    /// Function: SetupLights
    /// </summary>
    public unsafe virtual void SetupLights()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupLights, "BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.SetupLights");
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
    /// Enum: EObjectUsageType
    /// </summary>
    public enum EObjectUsageType : byte
    {
        OUT_IntoObject = 0,
        OUT_IntoTarget = 1,
        OUT_JokerCell = 2,
        OUT_MAX = 3,
    }

    /// <summary>
    /// ObjectProperty: CurrentPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat CurrentPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: MyPylon
    /// </summary>
    public unsafe BmSDK.Engine.Pylon MyPylon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: InRangeHighlight
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstance InRangeHighlight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: InRangeHighlightMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant InRangeHighlightMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ObjectProperty: FadedHighlight
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstance FadedHighlight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ObjectProperty: FadedHighlightMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant FadedHighlightMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// ComponentProperty: FadeMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent FadeMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// ComponentProperty: AttachLightMeshComp
    /// </summary>
    public unsafe BmSDK.Engine.MeshComponent AttachLightMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MeshComponent>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// ComponentProperty: LightComp3
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent LightComp3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ComponentProperty: LightComp2
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent LightComp2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ComponentProperty: LightComp1
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent LightComp1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// FloatProperty: TriggerRange
    /// </summary>
    public unsafe float TriggerRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// FloatProperty: BatclawTriggerRange
    /// </summary>
    public unsafe float BatclawTriggerRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: PlayerToVillainRange
    /// </summary>
    public unsafe float PlayerToVillainRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// FloatProperty: HighlightAlpha
    /// </summary>
    public unsafe float HighlightAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// BoolProperty: bUsed
    /// </summary>
    public unsafe bool bUsed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bCurrentObject
    /// </summary>
    public unsafe bool bCurrentObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bPlayerInRangeHighlight
    /// </summary>
    public unsafe bool bPlayerInRangeHighlight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bIsVillainHighlighted
    /// </summary>
    public unsafe bool bIsVillainHighlighted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bAnyVillainInSamePylon
    /// </summary>
    public unsafe bool bAnyVillainInSamePylon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bVillianInRange
    /// </summary>
    public unsafe bool bVillianInRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bSpawnCustomCombatMove
    /// </summary>
    public unsafe bool bSpawnCustomCombatMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bBothInRangeHighlight
    /// </summary>
    public unsafe bool bBothInRangeHighlight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bDontPutInStasis
    /// </summary>
    public unsafe bool bDontPutInStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bLightSet
    /// </summary>
    public unsafe bool bLightSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bFadedState
    /// </summary>
    public unsafe bool bFadedState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bFadeWhenBetweenCameraAndPlayer
    /// </summary>
    public unsafe bool bFadeWhenBetweenCameraAndPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bForceHUDPrompt
    /// </summary>
    public unsafe bool bForceHUDPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// FloatProperty: HaveTargetAlpha
    /// </summary>
    public unsafe float HaveTargetAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: NoTargetAlpha
    /// </summary>
    public unsafe float NoTargetAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// FloatProperty: FadedMeshAlpha
    /// </summary>
    public unsafe float FadedMeshAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// FloatProperty: HighlightChangeSpeed
    /// </summary>
    public unsafe float HighlightChangeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ArrayProperty: HighlightMeshes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.PrimitiveComponent> HighlightMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PrimitiveComponent>>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// NameProperty: LightSocket1
    /// </summary>
    public unsafe BmSDK.FName LightSocket1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// NameProperty: LightSocket2
    /// </summary>
    public unsafe BmSDK.FName LightSocket2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// NameProperty: LightSocket3
    /// </summary>
    public unsafe BmSDK.FName LightSocket3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ArrayProperty: StasisCheckMeshList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MeshComponent> StasisCheckMeshList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MeshComponent>>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ByteProperty: UsageType
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.EObjectUsageType UsageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatPoint_EnvironmentAttackObjectBase.EObjectUsageType>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// StrProperty: HUDPromptString
    /// </summary>
    public unsafe BmSDK.FString HUDPromptString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// StructProperty: NonPathBuildPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 NonPathBuildPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 904);

    /// <summary>
    /// FloatProperty: PathBuildZOffset
    /// </summary>
    public unsafe float PathBuildZOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// FloatProperty: PylonRange
    /// </summary>
    public unsafe float PylonRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }
}
