#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHidePoint_LampPostTop<br/>
/// (size = 1356)
/// (flags = 2292187794)
/// </summary>
public partial class RHidePoint_LampPostTop : BmSDK.BmGame.RHidePoint_Walkable, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHidePoint_LampPostTop", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHidePoint_LampPostTop.
    /// </summary>
    public static RHidePoint_LampPostTop DefaultObject => (RHidePoint_LampPostTop)StaticClass().DefaultObject;

    internal RHidePoint_LampPostTop() { }

    /// <summary>
    /// Constructs a new RHidePoint_LampPostTop
    /// </summary>
    public RHidePoint_LampPostTop(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHidePoint_LampPostTop(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHidePoint_LampPostTop>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint_LampPostTop>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHidePoint_LampPostTop>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint_LampPostTop>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint_LampPostTop>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint_LampPostTop>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHidePoint_LampPostTop>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint_LampPostTop>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_InstantMovePawnTo;
    /// <summary>
    /// Function: InstantMovePawnTo
    /// </summary>
    public unsafe override void InstantMovePawnTo(BmSDK.BmGame.RPlayerController lPC, BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstantMovePawnTo, "BmGame.RHidePoint_LampPostTop.InstantMovePawnTo");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(lPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveMatinee;
    /// <summary>
    /// Function: MoveMatinee
    /// </summary>
    public unsafe virtual void MoveMatinee(float MoveAmount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveMatinee, "BmGame.RHidePoint_LampPostTop.MoveMatinee");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveHidePoint;
    /// <summary>
    /// Function: MoveHidePoint
    /// </summary>
    public unsafe override void MoveHidePoint(System.Numerics.Vector3 InputDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveHidePoint, "BmGame.RHidePoint_LampPostTop.MoveHidePoint");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InputDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearMatinee;
    /// <summary>
    /// Function: ClearMatinee
    /// </summary>
    public unsafe virtual void ClearMatinee()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearMatinee, "BmGame.RHidePoint_LampPostTop.ClearMatinee");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMatinee;
    /// <summary>
    /// Function: SetMatinee
    /// </summary>
    public unsafe virtual void SetMatinee(BmSDK.Engine.SeqAct_Interp M)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMatinee, "BmGame.RHidePoint_LampPostTop.SetMatinee");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(M, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WillSmashIfShot;
    /// <summary>
    /// Function: WillSmashIfShot
    /// </summary>
    public unsafe override bool WillSmashIfShot()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WillSmashIfShot, "BmGame.RHidePoint_LampPostTop.WillSmashIfShot");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnToggle;
    /// <summary>
    /// Function: OnToggle
    /// </summary>
    public unsafe override void OnToggle(BmSDK.Engine.SeqAct_Toggle Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggle, "BmGame.RHidePoint_LampPostTop.OnToggle");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestMineAttachPoint;
    /// <summary>
    /// Function: RequestMineAttachPoint
    /// </summary>
    public unsafe override bool RequestMineAttachPoint(System.Numerics.Vector3 TargetHintLoc, BmSDK.Rotator ThrowDir, out System.Numerics.Vector3 mineLoc, out BmSDK.Rotator MineRot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestMineAttachPoint, "BmGame.RHidePoint_LampPostTop.RequestMineAttachPoint");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetHintLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out mineLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mineLoc, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MineRot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MineRot, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        mineLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
        MineRot = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_GetCatwomanPerchPosition;
    /// <summary>
    /// Function: GetCatwomanPerchPosition
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetCatwomanPerchPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCatwomanPerchPosition, "BmGame.RHidePoint_LampPostTop.GetCatwomanPerchPosition");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatmanPerchPosition;
    /// <summary>
    /// Function: GetBatmanPerchPosition
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetBatmanPerchPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatmanPerchPosition, "BmGame.RHidePoint_LampPostTop.GetBatmanPerchPosition");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BMLeft;
    /// <summary>
    /// Function: BMLeft
    /// </summary>
    public unsafe override void BMLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BMLeft, "BmGame.RHidePoint_LampPostTop.BMLeft");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartJokerHallucination;
    /// <summary>
    /// Function: StartJokerHallucination
    /// </summary>
    public unsafe virtual void StartJokerHallucination(System.Numerics.Vector3 BatmanLoc, System.Numerics.Vector3 BatmanRot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartJokerHallucination, "BmGame.RHidePoint_LampPostTop.StartJokerHallucination");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanRot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoJokerOverlay;
    /// <summary>
    /// Function: DoJokerOverlay
    /// </summary>
    public unsafe virtual void DoJokerOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoJokerOverlay, "BmGame.RHidePoint_LampPostTop.DoJokerOverlay");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PickJokerMountAnims;
    /// <summary>
    /// Function: PickJokerMountAnims
    /// </summary>
    public unsafe virtual void PickJokerMountAnims(out BmSDK.FName TransIn, out BmSDK.FName Idle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickJokerMountAnims, "BmGame.RHidePoint_LampPostTop.PickJokerMountAnims");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TransIn);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransIn, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Idle);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Idle, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TransIn = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
        Idle = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_ThugsAroundInPred;
    /// <summary>
    /// Function: ThugsAroundInPred
    /// </summary>
    public unsafe virtual bool ThugsAroundInPred()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugsAroundInPred, "BmGame.RHidePoint_LampPostTop.ThugsAroundInPred");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DoJokerHallucination;
    /// <summary>
    /// Function: DoJokerHallucination
    /// </summary>
    public unsafe virtual bool DoJokerHallucination()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoJokerHallucination, "BmGame.RHidePoint_LampPostTop.DoJokerHallucination");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// ComponentProperty: CollisionShape
    /// </summary>
    public unsafe BmSDK.Engine.RAggGeomCollisionComponent CollisionShape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAggGeomCollisionComponent>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: ChanceOfJokerHallucination
    /// </summary>
    public unsafe float ChanceOfJokerHallucination
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenJokerHallucinationOverlays
    /// </summary>
    public unsafe float TimeBetweenJokerHallucinationOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// BoolProperty: bJokerInNervousPose
    /// </summary>
    public unsafe bool bJokerInNervousPose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1304); }
    }

    /// <summary>
    /// StructProperty: BeamEnd1
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BeamEnd1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1308);

    /// <summary>
    /// StructProperty: BeamEnd2
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BeamEnd2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1320);

    /// <summary>
    /// ObjectProperty: AxisMatinee
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_Interp AxisMatinee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_Interp>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// FloatProperty: CurrentSpeed
    /// </summary>
    public unsafe float CurrentSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// FloatProperty: DesiredAnimSpeed
    /// </summary>
    public unsafe float DesiredAnimSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// FloatProperty: XAxisSpeed
    /// </summary>
    public unsafe float XAxisSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// FloatProperty: AccelTime
    /// </summary>
    public unsafe float AccelTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }
}
