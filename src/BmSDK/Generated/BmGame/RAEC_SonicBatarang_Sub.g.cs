#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_SonicBatarang_Sub<br/>
/// (size = 740)
/// (flags = 10485778)
/// </summary>
public partial class RAEC_SonicBatarang_Sub : BmSDK.BmGame.RAlertEventCoordinatorSolo, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_SonicBatarang_Sub", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_SonicBatarang_Sub.
    /// </summary>
    public static RAEC_SonicBatarang_Sub DefaultObject => (RAEC_SonicBatarang_Sub)StaticClass().DefaultObject;

    internal RAEC_SonicBatarang_Sub() { }

    /// <summary>
    /// Constructs a new RAEC_SonicBatarang_Sub
    /// </summary>
    public RAEC_SonicBatarang_Sub(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_SonicBatarang_Sub(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_SonicBatarang_Sub>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_SonicBatarang_Sub>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_SonicBatarang_Sub>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_SonicBatarang_Sub>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_SonicBatarang_Sub>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_SonicBatarang_Sub>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_SonicBatarang_Sub>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_SonicBatarang_Sub>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_StartInvestigate;
    /// <summary>
    /// Function: StartInvestigate
    /// </summary>
    public unsafe virtual void StartInvestigate(System.Numerics.Vector3 NewDirectMoveTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartInvestigate, "BmGame.RAEC_SonicBatarang_Sub.StartInvestigate");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDirectMoveTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGoalDistForTargetType;
    /// <summary>
    /// Function: GetGoalDistForTargetType
    /// </summary>
    public unsafe virtual float GetGoalDistForTargetType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGoalDistForTargetType, "BmGame.RAEC_SonicBatarang_Sub.GetGoalDistForTargetType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DisableGrateVis;
    /// <summary>
    /// Function: DisableGrateVis
    /// </summary>
    public unsafe virtual void DisableGrateVis()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableGrateVis, "BmGame.RAEC_SonicBatarang_Sub.DisableGrateVis");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableGrateVis;
    /// <summary>
    /// Function: EnableGrateVis
    /// </summary>
    public unsafe virtual void EnableGrateVis()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableGrateVis, "BmGame.RAEC_SonicBatarang_Sub.EnableGrateVis");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFinishedBark;
    /// <summary>
    /// Function: PlayFinishedBark
    /// </summary>
    public unsafe virtual void PlayFinishedBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFinishedBark, "BmGame.RAEC_SonicBatarang_Sub.PlayFinishedBark");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayLookAtBark;
    /// <summary>
    /// Function: PlayLookAtBark
    /// </summary>
    public unsafe virtual void PlayLookAtBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayLookAtBark, "BmGame.RAEC_SonicBatarang_Sub.PlayLookAtBark");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSentryKitAnimOffset;
    /// <summary>
    /// Function: GetSentryKitAnimOffset
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetSentryKitAnimOffset(BmSDK.BmGame.RLootSourceBase TestKit, out float MeetingPointTravelDist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSentryKitAnimOffset, "BmGame.RAEC_SonicBatarang_Sub.GetSentryKitAnimOffset");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestKit, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MeetingPointTravelDist);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeetingPointTravelDist, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MeetingPointTravelDist = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetWallAnimOffset;
    /// <summary>
    /// Function: GetWallAnimOffset
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetWallAnimOffset(BmSDK.BmGame.RDestructibleProp_FractureWall TestWall, bool bCocky, System.Numerics.Vector3 SideHintPos, out float MeetingPointTravelDist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWallAnimOffset, "BmGame.RAEC_SonicBatarang_Sub.GetWallAnimOffset");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestWall, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCocky, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideHintPos, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MeetingPointTravelDist);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeetingPointTravelDist, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MeetingPointTravelDist = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetStartlePointAnimOffset;
    /// <summary>
    /// Function: GetStartlePointAnimOffset
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetStartlePointAnimOffset(System.Numerics.Vector3 AnimPos, int AnimYaw, out float MeetingPointTravelDist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStartlePointAnimOffset, "BmGame.RAEC_SonicBatarang_Sub.GetStartlePointAnimOffset");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimYaw, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MeetingPointTravelDist);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeetingPointTravelDist, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MeetingPointTravelDist = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetLockerAnimOffset;
    /// <summary>
    /// Function: GetLockerAnimOffset
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetLockerAnimOffset(BmSDK.BmGame.RPredatorGunLockerBase TestLocker, bool bCocky, out float MeetingPointTravelDist)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLockerAnimOffset, "BmGame.RAEC_SonicBatarang_Sub.GetLockerAnimOffset");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCocky, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MeetingPointTravelDist);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeetingPointTravelDist, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MeetingPointTravelDist = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_NotifyEvent;
    /// <summary>
    /// Function: NotifyEvent
    /// </summary>
    public unsafe override void NotifyEvent(BmSDK.BmGame.RBMAIAction EventAction, BmSDK.FString EventType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyEvent, "BmGame.RAEC_SonicBatarang_Sub.NotifyEvent");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventAction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyFinished;
    /// <summary>
    /// Function: NotifyFinished
    /// </summary>
    public unsafe override void NotifyFinished(BmSDK.BmGame.RBMAIAction FinishedAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFinished, "BmGame.RAEC_SonicBatarang_Sub.NotifyFinished");
        byte* paramsPtr = stackalloc byte[252];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGrateLookRefPoint;
    /// <summary>
    /// Function: GetGrateLookRefPoint
    /// </summary>
    public unsafe virtual bool GetGrateLookRefPoint(BmSDK.BmGame.RTunnelGrateBase Grate, BmSDK.BmGame.RAEC_Search_Sub_Grate.eLookInGrateType lookType, out System.Numerics.Vector3 outRefLoc, out BmSDK.Rotator outRefRot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGrateLookRefPoint, "BmGame.RAEC_SonicBatarang_Sub.GetGrateLookRefPoint");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Grate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(lookType, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outRefLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outRefLoc, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outRefRot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outRefRot, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outRefLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        outRefRot = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RAEC_SonicBatarang_Sub.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBeginShutdown;
    /// <summary>
    /// Function: OnBeginShutdown
    /// </summary>
    public unsafe override void OnBeginShutdown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBeginShutdown, "BmGame.RAEC_SonicBatarang_Sub.OnBeginShutdown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnVillainStolen;
    /// <summary>
    /// Function: OnVillainStolen
    /// </summary>
    public unsafe override void OnVillainStolen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnVillainStolen, "BmGame.RAEC_SonicBatarang_Sub.OnVillainStolen");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: SBrang
    /// </summary>
    public unsafe BmSDK.BmGame.RBatDistractProjectile SBrang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatDistractProjectile>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ObjectProperty: SpecialTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor SpecialTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: VoiceSynthesiser
    /// </summary>
    public unsafe BmSDK.BmGame.RVoiceSynthesiser VoiceSynthesiser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVoiceSynthesiser>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// FloatProperty: AlertVisibleTime
    /// </summary>
    public unsafe float AlertVisibleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// StructProperty: DirectMoveTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DirectMoveTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 724);

    /// <summary>
    /// BoolProperty: bPlayedOrderAck
    /// </summary>
    public unsafe bool bPlayedOrderAck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }
}
