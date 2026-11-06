#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRagdollProcessor<br/>
/// (size = 509)
/// (flags = 134217874)
/// </summary>
public partial class RRagdollProcessor : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRagdollProcessor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RRagdollProcessor.
    /// </summary>
    public static RRagdollProcessor DefaultObject => (RRagdollProcessor)StaticClass().DefaultObject;

    internal RRagdollProcessor() { }

    /// <summary>
    /// Constructs a new RRagdollProcessor
    /// </summary>
    public RRagdollProcessor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRagdollProcessor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRagdollProcessor(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRagdollProcessor>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRagdollProcessor>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRagdollProcessor>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRagdollProcessor>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRagdollProcessor>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRagdollProcessor>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRagdollProcessor>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRagdollProcessor>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_HitPawn;
    /// <summary>
    /// Function: HitPawn
    /// </summary>
    public unsafe virtual void HitPawn(BmSDK.BmGame.RPawnCombat OtherPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitPawn, "BmGame.RRagdollProcessor.HitPawn");
        byte* paramsPtr = stackalloc byte[328];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForWallBehindHitThug;
    /// <summary>
    /// Function: CheckForWallBehindHitThug
    /// </summary>
    public unsafe virtual bool CheckForWallBehindHitThug(BmSDK.BmGame.RPawnCombat HitThug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForWallBehindHitThug, "BmGame.RRagdollProcessor.CheckForWallBehindHitThug");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitThug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CombatCollision;
    /// <summary>
    /// Function: CombatCollision
    /// </summary>
    public unsafe virtual void CombatCollision(BmSDK.BmGame.RPawnCombat OtherPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatCollision, "BmGame.RRagdollProcessor.CombatCollision");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckHitPawns;
    /// <summary>
    /// Function: CheckHitPawns
    /// </summary>
    public unsafe virtual void CheckHitPawns()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckHitPawns, "BmGame.RRagdollProcessor.CheckHitPawns");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHostPawnPelvisPosition;
    /// <summary>
    /// Function: GetHostPawnPelvisPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetHostPawnPelvisPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHostPawnPelvisPosition, "BmGame.RRagdollProcessor.GetHostPawnPelvisPosition");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SwitchToHitWallWrithe;
    /// <summary>
    /// Function: SwitchToHitWallWrithe
    /// </summary>
    public unsafe virtual void SwitchToHitWallWrithe()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchToHitWallWrithe, "BmGame.RRagdollProcessor.SwitchToHitWallWrithe");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessHitWall;
    /// <summary>
    /// Function: ProcessHitWall
    /// </summary>
    public unsafe virtual void ProcessHitWall()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessHitWall, "BmGame.RRagdollProcessor.ProcessHitWall");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RigidBodyCollision;
    /// <summary>
    /// Function: RigidBodyCollision
    /// </summary>
    public unsafe virtual void RigidBodyCollision(BmSDK.Engine.PrimitiveComponent HitComponent, BmSDK.Engine.PrimitiveComponent OtherComponent, out BmSDK.Engine.Actor.FCollisionImpactData RigidCollisionData, int ContactIndex, float Speed, int Index0, int Index1)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RigidBodyCollision, "BmGame.RRagdollProcessor.RigidBodyCollision");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComponent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactIndex, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index0, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index1, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RigidCollisionData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FCollisionImpactData>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_BodyIsHorizontalNearLocation;
    /// <summary>
    /// Function: BodyIsHorizontalNearLocation
    /// </summary>
    public unsafe virtual bool BodyIsHorizontalNearLocation(System.Numerics.Vector3 ContactLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BodyIsHorizontalNearLocation, "BmGame.RRagdollProcessor.BodyIsHorizontalNearLocation");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ConstrainedToNavMesh;
    /// <summary>
    /// Function: ConstrainedToNavMesh
    /// </summary>
    public unsafe virtual void ConstrainedToNavMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConstrainedToNavMesh, "BmGame.RRagdollProcessor.ConstrainedToNavMesh");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimeUntilGetup;
    /// <summary>
    /// Function: TimeUntilGetup
    /// </summary>
    public unsafe virtual float TimeUntilGetup()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimeUntilGetup, "BmGame.RRagdollProcessor.TimeUntilGetup");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe virtual void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RRagdollProcessor.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPelvisSpeed;
    /// <summary>
    /// Function: GetPelvisSpeed
    /// </summary>
    public unsafe virtual float GetPelvisSpeed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPelvisSpeed, "BmGame.RRagdollProcessor.GetPelvisSpeed");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TrackRagdollFacing;
    /// <summary>
    /// Function: TrackRagdollFacing
    /// </summary>
    public unsafe virtual void TrackRagdollFacing(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrackRagdollFacing, "BmGame.RRagdollProcessor.TrackRagdollFacing");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffPawnCollision;
    /// <summary>
    /// Function: TurnOffPawnCollision
    /// </summary>
    public unsafe virtual void TurnOffPawnCollision()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffPawnCollision, "BmGame.RRagdollProcessor.TurnOffPawnCollision");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyARF;
    /// <summary>
    /// Function: ApplyARF
    /// </summary>
    public unsafe virtual void ApplyARF(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyARF, "BmGame.RRagdollProcessor.ApplyARF");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Deactivate;
    /// <summary>
    /// Function: Deactivate
    /// </summary>
    public unsafe virtual void Deactivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Deactivate, "BmGame.RRagdollProcessor.Deactivate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Reactivate;
    /// <summary>
    /// Function: Reactivate
    /// </summary>
    public unsafe virtual void Reactivate(BmSDK.FName RagdollName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reactivate, "BmGame.RRagdollProcessor.Reactivate");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RagdollName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TempDeactivate;
    /// <summary>
    /// Function: TempDeactivate
    /// </summary>
    public unsafe virtual void TempDeactivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TempDeactivate, "BmGame.RRagdollProcessor.TempDeactivate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsActive;
    /// <summary>
    /// Function: IsActive
    /// </summary>
    public unsafe virtual bool IsActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsActive, "BmGame.RRagdollProcessor.IsActive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsRagdollOn;
    /// <summary>
    /// Function: IsRagdollOn
    /// </summary>
    public unsafe virtual bool IsRagdollOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRagdollOn, "BmGame.RRagdollProcessor.IsRagdollOn");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EnterState;
    /// <summary>
    /// Function: EnterState
    /// </summary>
    public unsafe virtual void EnterState(BmSDK.BmGame.RRagdollProcessor.RagdollState NewState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterState, "BmGame.RRagdollProcessor.EnterState");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginWrithe;
    /// <summary>
    /// Function: BeginWrithe
    /// </summary>
    public unsafe virtual void BeginWrithe(BmSDK.FName NewRagdollName, BmSDK.BmGame.RPawnCombat.FDamageInfo NewDmgInfo, bool bKill, bool bNewFrozen)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginWrithe, "BmGame.RRagdollProcessor.BeginWrithe");
        byte* paramsPtr = stackalloc byte[328];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRagdollName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDmgInfo, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKill, paramsPtr + 256);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewFrozen, paramsPtr + 260);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExplodeLimbs;
    /// <summary>
    /// Function: ExplodeLimbs
    /// </summary>
    public unsafe virtual void ExplodeLimbs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExplodeLimbs, "BmGame.RRagdollProcessor.ExplodeLimbs");
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitialiseWritheAnim;
    /// <summary>
    /// Function: InitialiseWritheAnim
    /// </summary>
    public unsafe virtual void InitialiseWritheAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseWritheAnim, "BmGame.RRagdollProcessor.InitialiseWritheAnim");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitialiseRagdollFacing;
    /// <summary>
    /// Function: InitialiseRagdollFacing
    /// </summary>
    public unsafe virtual void InitialiseRagdollFacing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseRagdollFacing, "BmGame.RRagdollProcessor.InitialiseRagdollFacing");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitialiseWrithePhaseFromAnimName;
    /// <summary>
    /// Function: InitialiseWrithePhaseFromAnimName
    /// </summary>
    public unsafe virtual void InitialiseWrithePhaseFromAnimName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseWrithePhaseFromAnimName, "BmGame.RRagdollProcessor.InitialiseWrithePhaseFromAnimName");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitialiseWrithePhase;
    /// <summary>
    /// Function: InitialiseWrithePhase
    /// </summary>
    public unsafe virtual void InitialiseWrithePhase(BmSDK.BmGame.RPawnCombat.FWritheDescription WritheDesc, float ImpulseDotPawnDir, bool bUseHitWallPhase)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseWrithePhase, "BmGame.RRagdollProcessor.InitialiseWrithePhase");
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WritheDesc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpulseDotPawnDir, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseHitWallPhase, paramsPtr + 84);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Reset;
    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe virtual void Reset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reset, "BmGame.RRagdollProcessor.Reset");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe virtual void Initialise(BmSDK.BmGame.RPawnCombat NewPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmGame.RRagdollProcessor.Initialise");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: RagdollState
    /// </summary>
    public enum RagdollState : byte
    {
        RAG_Idle = 0,
        RAG_Ragdoll = 1,
        RAG_Paused = 2,
        RAG_WaitForDeactivate = 3,
        RAG_MAX = 4,
    }

    /// <summary>
    /// FloatProperty: StunTime
    /// </summary>
    public unsafe float StunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: TotalRagdollTime
    /// </summary>
    public unsafe float TotalRagdollTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// FloatProperty: TurnOffPawnCollisionTimer
    /// </summary>
    public unsafe float TurnOffPawnCollisionTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bGetUpWhenHitFloor
    /// </summary>
    public unsafe bool bGetUpWhenHitFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bPlayedEmote
    /// </summary>
    public unsafe bool bPlayedEmote
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bKillWhenFinished
    /// </summary>
    public unsafe bool bKillWhenFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bHitWall
    /// </summary>
    public unsafe bool bHitWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShouldPlayHitWallImpactSFX
    /// </summary>
    public unsafe bool bShouldPlayHitWallImpactSFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bDamagedTarget
    /// </summary>
    public unsafe bool bDamagedTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bTickMe
    /// </summary>
    public unsafe bool bTickMe
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bFrozen
    /// </summary>
    public unsafe bool bFrozen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bFullMotorWeightWhenHitWall
    /// </summary>
    public unsafe bool bFullMotorWeightWhenHitWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bForceHitWallNextImpact
    /// </summary>
    public unsafe bool bForceHitWallNextImpact
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bFacingUp
    /// </summary>
    public unsafe bool bFacingUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bRevertTempPhysicsWalkingOnExit
    /// </summary>
    public unsafe bool bRevertTempPhysicsWalkingOnExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bTempDeactivated
    /// </summary>
    public unsafe bool bTempDeactivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: WritheDmgInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnCombat.FDamageInfo WritheDmgInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnCombat.FDamageInfo>(Ptr + 100);

    /// <summary>
    /// NameProperty: Writhe_HitWorldAnimName
    /// </summary>
    public unsafe BmSDK.FName Writhe_HitWorldAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// FloatProperty: ARFMulti
    /// </summary>
    public unsafe float ARFMulti
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: RandomARFTime
    /// </summary>
    public unsafe float RandomARFTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// FloatProperty: RandomARFPower
    /// </summary>
    public unsafe float RandomARFPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// ArrayProperty: HitPawns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat> HitPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// FloatProperty: CancelKnockOverPawnsTimer
    /// </summary>
    public unsafe float CancelKnockOverPawnsTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// NameProperty: RagdollStackName
    /// </summary>
    public unsafe BmSDK.FName RagdollStackName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ObjectProperty: HostPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat HostPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// FloatProperty: FrozenTimer
    /// </summary>
    public unsafe float FrozenTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// FloatProperty: MotorWeight
    /// </summary>
    public unsafe float MotorWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// FloatProperty: MotorBlendInTime
    /// </summary>
    public unsafe float MotorBlendInTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// FloatProperty: StartMotorTimer
    /// </summary>
    public unsafe float StartMotorTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// FloatProperty: ForceHitWallNextImpactTimer
    /// </summary>
    public unsafe float ForceHitWallNextImpactTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// FloatProperty: ForceHitWallTimer
    /// </summary>
    public unsafe float ForceHitWallTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// ArrayProperty: DefaultWritheDescriptions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat.FWritheDescription> DefaultWritheDescriptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat.FWritheDescription>>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// StructProperty: CurrWrithePhase
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnCombat.FWrithePhaseDesc CurrWrithePhase
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnCombat.FWrithePhaseDesc>(Ptr + 444);

    /// <summary>
    /// StructProperty: HitWallWrithePhase
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnCombat.FWrithePhaseDesc HitWallWrithePhase
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnCombat.FWrithePhaseDesc>(Ptr + 472);

    /// <summary>
    /// FloatProperty: FacingOtherDirTimer
    /// </summary>
    public unsafe float FacingOtherDirTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// FloatProperty: UnFreezeTime
    /// </summary>
    public unsafe float UnFreezeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ByteProperty: CurrState
    /// </summary>
    public unsafe BmSDK.BmGame.RRagdollProcessor.RagdollState CurrState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRagdollProcessor.RagdollState>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }
}
