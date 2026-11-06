#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RThugEatingPlantBase<br/>
/// (size = 820)
/// (flags = 144703635)
/// </summary>
public partial class RThugEatingPlantBase : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RThugEatingPlantBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RThugEatingPlantBase.
    /// </summary>
    public static RThugEatingPlantBase DefaultObject => (RThugEatingPlantBase)StaticClass().DefaultObject;

    internal RThugEatingPlantBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RThugEatingPlantBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RThugEatingPlantBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RThugEatingPlantBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RThugEatingPlantBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RThugEatingPlantBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RThugEatingPlantBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RThugEatingPlantBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RThugEatingPlantBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RThugEatingPlantBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObstacleActor;
    /// <summary>
    /// Function: GetObstacleActor
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetObstacleActor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObstacleActor, "BmGame.RThugEatingPlantBase.GetObstacleActor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Detonate;
    /// <summary>
    /// Function: Detonate
    /// </summary>
    public unsafe virtual void Detonate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Detonate, "BmGame.RThugEatingPlantBase.Detonate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDetonatePrompt;
    /// <summary>
    /// Function: GetDetonatePrompt
    /// </summary>
    public unsafe virtual BmSDK.FString GetDetonatePrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDetonatePrompt, "BmGame.RThugEatingPlantBase.GetDetonatePrompt");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayDetonateAnim;
    /// <summary>
    /// Function: PlayDetonateAnim
    /// </summary>
    public unsafe virtual bool PlayDetonateAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDetonateAnim, "BmGame.RThugEatingPlantBase.PlayDetonateAnim");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ReadyToDetonate;
    /// <summary>
    /// Function: ReadyToDetonate
    /// </summary>
    public unsafe virtual bool ReadyToDetonate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadyToDetonate, "BmGame.RThugEatingPlantBase.ReadyToDetonate");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EatCancelled;
    /// <summary>
    /// Function: EatCancelled
    /// </summary>
    public unsafe virtual void EatCancelled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EatCancelled, "BmGame.RThugEatingPlantBase.EatCancelled");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GrabThug;
    /// <summary>
    /// Function: GrabThug
    /// </summary>
    public unsafe virtual void GrabThug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrabThug, "BmGame.RThugEatingPlantBase.GrabThug");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetThugPosFromAnim;
    /// <summary>
    /// Function: GetThugPosFromAnim
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetThugPosFromAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThugPosFromAnim, "BmGame.RThugEatingPlantBase.GetThugPosFromAnim");
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBestAttackAnim;
    /// <summary>
    /// Function: GetBestAttackAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetBestAttackAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestAttackAnim, "BmGame.RThugEatingPlantBase.GetBestAttackAnim");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsThugSafeForCollision;
    /// <summary>
    /// Function: IsThugSafeForCollision
    /// </summary>
    public unsafe virtual bool IsThugSafeForCollision(float TestDist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsThugSafeForCollision, "BmGame.RThugEatingPlantBase.IsThugSafeForCollision");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestDist, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTraceStartLoc;
    /// <summary>
    /// Function: GetTraceStartLoc
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetTraceStartLoc()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTraceStartLoc, "BmGame.RThugEatingPlantBase.GetTraceStartLoc");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PickAnimForRangeSq;
    /// <summary>
    /// Function: PickAnimForRangeSq
    /// </summary>
    public unsafe virtual BmSDK.FName PickAnimForRangeSq(float RangeSq, BmSDK.FName AnimList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickAnimForRangeSq, "BmGame.RThugEatingPlantBase.PickAnimForRangeSq");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RangeSq, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimList, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_TurnTowardsTarget;
    /// <summary>
    /// Function: TurnTowardsTarget
    /// </summary>
    public unsafe virtual bool TurnTowardsTarget(float DeltaTime, float UnRotUnitsPerSec)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnTowardsTarget, "BmGame.RThugEatingPlantBase.TurnTowardsTarget");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnRotUnitsPerSec, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_StopPlantEatingFX;
    /// <summary>
    /// Function: StopPlantEatingFX
    /// </summary>
    public unsafe virtual void StopPlantEatingFX(BmSDK.BmGame.RPawnVillain VillainTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopPlantEatingFX, "BmGame.RThugEatingPlantBase.StopPlantEatingFX");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartPlantEatingFX;
    /// <summary>
    /// Function: StartPlantEatingFX
    /// </summary>
    public unsafe virtual void StartPlantEatingFX(BmSDK.BmGame.RPawnVillain NewTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartPlantEatingFX, "BmGame.RThugEatingPlantBase.StartPlantEatingFX");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTargetHighlight;
    /// <summary>
    /// Function: SetTargetHighlight
    /// </summary>
    public unsafe virtual void SetTargetHighlight(bool bIsHighlightOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTargetHighlight, "BmGame.RThugEatingPlantBase.SetTargetHighlight");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsHighlightOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RThugEatingPlantBase.Tick");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugFinished;
    /// <summary>
    /// Function: ThugFinished
    /// </summary>
    public unsafe virtual void ThugFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugFinished, "BmGame.RThugEatingPlantBase.ThugFinished");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireThugEatenKismetEvent;
    /// <summary>
    /// Function: FireThugEatenKismetEvent
    /// </summary>
    public unsafe virtual void FireThugEatenKismetEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireThugEatenKismetEvent, "BmGame.RThugEatingPlantBase.FireThugEatenKismetEvent");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetThugAnimSet;
    /// <summary>
    /// Function: GetThugAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetThugAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThugAnimSet, "BmGame.RThugEatingPlantBase.GetThugAnimSet");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartEatAnim;
    /// <summary>
    /// Function: StartEatAnim
    /// </summary>
    public unsafe virtual void StartEatAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartEatAnim, "BmGame.RThugEatingPlantBase.StartEatAnim");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayAwareIdle;
    /// <summary>
    /// Function: PlayAwareIdle
    /// </summary>
    public unsafe virtual void PlayAwareIdle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAwareIdle, "BmGame.RThugEatingPlantBase.PlayAwareIdle");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCalmIdle;
    /// <summary>
    /// Function: PlayCalmIdle
    /// </summary>
    public unsafe virtual void PlayCalmIdle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCalmIdle, "BmGame.RThugEatingPlantBase.PlayCalmIdle");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetVoiceSynthMovePosition;
    /// <summary>
    /// Function: GetVoiceSynthMovePosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetVoiceSynthMovePosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVoiceSynthMovePosition, "BmGame.RThugEatingPlantBase.GetVoiceSynthMovePosition");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RThugEatingPlantBase.Destroyed");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RThugEatingPlantBase.PreStreamOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInXrayMode;
    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe virtual void SetInXrayMode(bool show, bool bForceOff)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInXrayMode, "BmGame.RThugEatingPlantBase.SetInXrayMode");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGlow;
    /// <summary>
    /// Function: UpdateGlow
    /// </summary>
    public unsafe virtual void UpdateGlow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGlow, "BmGame.RThugEatingPlantBase.UpdateGlow");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreatePlantGlow;
    /// <summary>
    /// Function: CreatePlantGlow
    /// </summary>
    public unsafe virtual void CreatePlantGlow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreatePlantGlow, "BmGame.RThugEatingPlantBase.CreatePlantGlow");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateGlowMesh;
    /// <summary>
    /// Function: CreateGlowMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkeletalMeshComponent CreateGlowMesh(BmSDK.Engine.SkeletalMeshComponent Template, BmSDK.Engine.MaterialInterface OverrideMaterial)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateGlowMesh, "BmGame.RThugEatingPlantBase.CreateGlowMesh");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Template, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaterial, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RThugEatingPlantBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnRegisterObstacle;
    /// <summary>
    /// Function: UnRegisterObstacle
    /// </summary>
    public unsafe virtual void UnRegisterObstacle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnRegisterObstacle, "BmGame.RThugEatingPlantBase.UnRegisterObstacle");
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

    private static BmSDK.Function __fn_RegisterObstacle;
    /// <summary>
    /// Function: RegisterObstacle
    /// </summary>
    public unsafe virtual void RegisterObstacle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterObstacle, "BmGame.RThugEatingPlantBase.RegisterObstacle");
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
    /// StructProperty: VfTable_IInterface_NavMeshPathObstacle
    /// </summary>
    public unsafe System.IntPtr VfTable_IInterface_NavMeshPathObstacle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ComponentProperty: PlantMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent PlantMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ComponentProperty: PlayerInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent PlayerInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: CurrentTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillainGunPredBase CurrentTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillainGunPredBase>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: GlowMaterialMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant GlowMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: GlowMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface GlowMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: TargetThugOverridePS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem TargetThugOverridePS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: explosionVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem explosionVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: TargetCanBeTargetedBy
    /// </summary>
    public unsafe BmSDK.Engine.PlayerController TargetCanBeTargetedBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: CurrentPlantBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour_BeingEatenByPlant CurrentPlantBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_BeingEatenByPlant>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ComponentProperty: GlowMaskMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent GlowMaskMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ComponentProperty: Cylinder_MaxRange
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent Cylinder_MaxRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ComponentProperty: Cylinder_ShortRange
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent Cylinder_ShortRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bHasThugInside
    /// </summary>
    public unsafe bool bHasThugInside
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 772); }
    }

    /// <summary>
    /// BoolProperty: bDoneGrab
    /// </summary>
    public unsafe bool bDoneGrab
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 772); }
    }

    /// <summary>
    /// BoolProperty: bHighlighTarget
    /// </summary>
    public unsafe bool bHighlighTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 772); }
    }

    /// <summary>
    /// NameProperty: BestAttackAnim
    /// </summary>
    public unsafe BmSDK.FName BestAttackAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: AttackAnimList
    /// </summary>
    public InlineArray<BmSDK.FName> AttackAnimList => new(4, Ptr + 784, 8, this);

    /// <summary>
    /// NameProperty: AttackAnimList
    /// </summary>
    public unsafe BmSDK.FName AttackAnimList_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }
    /// <summary>
    /// NameProperty: AttackAnimList
    /// </summary>
    public unsafe BmSDK.FName AttackAnimList_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }
    /// <summary>
    /// NameProperty: AttackAnimList
    /// </summary>
    public unsafe BmSDK.FName AttackAnimList_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }
    /// <summary>
    /// NameProperty: AttackAnimList
    /// </summary>
    public unsafe BmSDK.FName AttackAnimList_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// StructProperty: ThrowTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId ThrowTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 816);
}
