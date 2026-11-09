#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// ABSTRACT Class: RBMBehaviour_GangMovementBase<br/>
/// (size = 924)
/// (flags = 8211)
/// </summary>
public partial class RBMBehaviour_GangMovementBase : BmSDK.BmGame.RBMBehaviour_GangMovementBaseBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_GangMovementBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMBehaviour_GangMovementBase.
    /// </summary>
    public static RBMBehaviour_GangMovementBase DefaultObject => (RBMBehaviour_GangMovementBase)StaticClass().DefaultObject;

    internal RBMBehaviour_GangMovementBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_GangMovementBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangMovementBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangMovementBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangMovementBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangMovementBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangMovementBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangMovementBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangMovementBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangMovementBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmScript.RBMBehaviour_GangMovementBase.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateRunVariantWeaponConfig;
    /// <summary>
    /// Function: CreateRunVariantWeaponConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateRunVariantWeaponConfig()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateRunVariantWeaponConfig, "BmScript.RBMBehaviour_GangMovementBase.CreateRunVariantWeaponConfig");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BeginHammer;
    /// <summary>
    /// Function: BeginHammer
    /// </summary>
    public unsafe virtual void BeginHammer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginHammer, "BmScript.RBMBehaviour_GangMovementBase.BeginHammer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndGrind;
    /// <summary>
    /// Function: EndGrind
    /// </summary>
    public unsafe virtual void EndGrind()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndGrind, "BmScript.RBMBehaviour_GangMovementBase.EndGrind");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginGrind;
    /// <summary>
    /// Function: BeginGrind
    /// </summary>
    public unsafe virtual void BeginGrind()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginGrind, "BmScript.RBMBehaviour_GangMovementBase.BeginGrind");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndWeld;
    /// <summary>
    /// Function: EndWeld
    /// </summary>
    public unsafe virtual void EndWeld()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndWeld, "BmScript.RBMBehaviour_GangMovementBase.EndWeld");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginWeld;
    /// <summary>
    /// Function: BeginWeld
    /// </summary>
    public unsafe virtual void BeginWeld()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginWeld, "BmScript.RBMBehaviour_GangMovementBase.BeginWeld");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGraffiti;
    /// <summary>
    /// Function: UpdateGraffiti
    /// </summary>
    public unsafe virtual void UpdateGraffiti(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGraffiti, "BmScript.RBMBehaviour_GangMovementBase.UpdateGraffiti");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GraffitiNotify;
    /// <summary>
    /// Function: GraffitiNotify
    /// </summary>
    public unsafe override void GraffitiNotify(BmSDK.BmGame.RAnimNotify_Graffiti _GraffitiNotify)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GraffitiNotify, "BmScript.RBMBehaviour_GangMovementBase.GraffitiNotify");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_GraffitiNotify, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IgniteFlare;
    /// <summary>
    /// Function: IgniteFlare
    /// </summary>
    public unsafe virtual void IgniteFlare()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IgniteFlare, "BmScript.RBMBehaviour_GangMovementBase.IgniteFlare");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExplodeMolotov;
    /// <summary>
    /// Function: ExplodeMolotov
    /// </summary>
    public unsafe virtual void ExplodeMolotov()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExplodeMolotov, "BmScript.RBMBehaviour_GangMovementBase.ExplodeMolotov");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IgniteMolotov;
    /// <summary>
    /// Function: IgniteMolotov
    /// </summary>
    public unsafe virtual void IgniteMolotov()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IgniteMolotov, "BmScript.RBMBehaviour_GangMovementBase.IgniteMolotov");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SmashWindow;
    /// <summary>
    /// Function: SmashWindow
    /// </summary>
    public unsafe virtual void SmashWindow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SmashWindow, "BmScript.RBMBehaviour_GangMovementBase.SmashWindow");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SmashObject;
    /// <summary>
    /// Function: SmashObject
    /// </summary>
    public unsafe virtual void SmashObject()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SmashObject, "BmScript.RBMBehaviour_GangMovementBase.SmashObject");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CrackOrSmashWindow;
    /// <summary>
    /// Function: CrackOrSmashWindow
    /// </summary>
    public unsafe virtual void CrackOrSmashWindow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CrackOrSmashWindow, "BmScript.RBMBehaviour_GangMovementBase.CrackOrSmashWindow");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CrackOrSmashObject;
    /// <summary>
    /// Function: CrackOrSmashObject
    /// </summary>
    public unsafe virtual void CrackOrSmashObject()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CrackOrSmashObject, "BmScript.RBMBehaviour_GangMovementBase.CrackOrSmashObject");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CrackWindow;
    /// <summary>
    /// Function: CrackWindow
    /// </summary>
    public unsafe virtual void CrackWindow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CrackWindow, "BmScript.RBMBehaviour_GangMovementBase.CrackWindow");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CrackObject;
    /// <summary>
    /// Function: CrackObject
    /// </summary>
    public unsafe virtual void CrackObject()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CrackObject, "BmScript.RBMBehaviour_GangMovementBase.CrackObject");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBreakVars;
    /// <summary>
    /// Function: GetBreakVars
    /// </summary>
    public unsafe virtual void GetBreakVars(out System.Numerics.Vector3 HitLoc, out System.Numerics.Vector3 HitNorm, out System.Numerics.Vector3 HitSpeed, out BmSDK.Engine.Actor ThrownActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBreakVars, "BmScript.RBMBehaviour_GangMovementBase.GetBreakVars");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNorm);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNorm, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitSpeed);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitSpeed, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThrownActor);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownActor, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        HitNorm = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        HitSpeed = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
        ThrownActor = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 36);
        return;
    }

    private static BmSDK.Function __fn_RiotPickupNotify;
    /// <summary>
    /// Function: RiotPickupNotify
    /// </summary>
    public unsafe override void RiotPickupNotify(BmSDK.BmGame.RAnimNotify_PickupProp PickupNotify)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RiotPickupNotify, "BmScript.RBMBehaviour_GangMovementBase.RiotPickupNotify");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PickupNotify, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnObject;
    /// <summary>
    /// Function: SpawnObject
    /// </summary>
    public unsafe virtual void SpawnObject(out BmSDK.BmGame.RRiotObjectBase RiotObject)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnObject, "BmScript.RBMBehaviour_GangMovementBase.SpawnObject");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RiotObject);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RiotObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RiotObject = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RRiotObjectBase>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_PickupStone;
    /// <summary>
    /// Function: PickupStone
    /// </summary>
    public unsafe virtual void PickupStone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickupStone, "BmScript.RBMBehaviour_GangMovementBase.PickupStone");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PickupBrick;
    /// <summary>
    /// Function: PickupBrick
    /// </summary>
    public unsafe virtual void PickupBrick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickupBrick, "BmScript.RBMBehaviour_GangMovementBase.PickupBrick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PickupSprayCan;
    /// <summary>
    /// Function: PickupSprayCan
    /// </summary>
    public unsafe virtual void PickupSprayCan()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickupSprayCan, "BmScript.RBMBehaviour_GangMovementBase.PickupSprayCan");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PickupPipe;
    /// <summary>
    /// Function: PickupPipe
    /// </summary>
    public unsafe virtual void PickupPipe()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickupPipe, "BmScript.RBMBehaviour_GangMovementBase.PickupPipe");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RiotExitBehaviour;
    /// <summary>
    /// Function: RiotExitBehaviour
    /// </summary>
    public unsafe virtual void RiotExitBehaviour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RiotExitBehaviour, "BmScript.RBMBehaviour_GangMovementBase.RiotExitBehaviour");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DettachFromCar;
    /// <summary>
    /// Function: DettachFromCar
    /// </summary>
    public unsafe virtual void DettachFromCar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DettachFromCar, "BmScript.RBMBehaviour_GangMovementBase.DettachFromCar");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachToCarSeat3;
    /// <summary>
    /// Function: AttachToCarSeat3
    /// </summary>
    public unsafe virtual void AttachToCarSeat3()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachToCarSeat3, "BmScript.RBMBehaviour_GangMovementBase.AttachToCarSeat3");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachToCarSeat2;
    /// <summary>
    /// Function: AttachToCarSeat2
    /// </summary>
    public unsafe virtual void AttachToCarSeat2()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachToCarSeat2, "BmScript.RBMBehaviour_GangMovementBase.AttachToCarSeat2");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachToCarSeat1;
    /// <summary>
    /// Function: AttachToCarSeat1
    /// </summary>
    public unsafe virtual void AttachToCarSeat1()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachToCarSeat1, "BmScript.RBMBehaviour_GangMovementBase.AttachToCarSeat1");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEvadeVehicleType;
    /// <summary>
    /// Function: GetEvadeVehicleType
    /// </summary>
    public unsafe override BmSDK.BmGame.RGameInfo.EEvadeVehicleType GetEvadeVehicleType(BmSDK.Engine.Actor V, float CarSpeed, bool bZap)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEvadeVehicleType, "BmScript.RBMBehaviour_GangMovementBase.GetEvadeVehicleType");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CarSpeed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bZap, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.EEvadeVehicleType>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_TriggerOutputEvent;
    /// <summary>
    /// Function: TriggerOutputEvent
    /// </summary>
    public unsafe virtual void TriggerOutputEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerOutputEvent, "BmScript.RBMBehaviour_GangMovementBase.TriggerOutputEvent");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InteractOutput;
    /// <summary>
    /// Function: InteractOutput
    /// </summary>
    public unsafe virtual void InteractOutput()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InteractOutput, "BmScript.RBMBehaviour_GangMovementBase.InteractOutput");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanLookAtPlayer;
    /// <summary>
    /// Function: CanLookAtPlayer
    /// </summary>
    public unsafe override bool CanLookAtPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanLookAtPlayer, "BmScript.RBMBehaviour_GangMovementBase.CanLookAtPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HandlePathNotFound;
    /// <summary>
    /// Function: HandlePathNotFound
    /// </summary>
    public unsafe virtual void HandlePathNotFound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandlePathNotFound, "BmScript.RBMBehaviour_GangMovementBase.HandlePathNotFound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRunVariants;
    /// <summary>
    /// Function: SetRunVariants
    /// </summary>
    public unsafe virtual void SetRunVariants(BmSDK.BmGame.RBMAIAction_RiotRunBase MoveAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRunVariants, "BmScript.RBMBehaviour_GangMovementBase.SetRunVariants");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeHitInCombat;
    /// <summary>
    /// Function: CanBeHitInCombat
    /// </summary>
    public unsafe override bool CanBeHitInCombat(BmSDK.BmGame.RDamageType DamageType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeHitInCombat, "BmScript.RBMBehaviour_GangMovementBase.CanBeHitInCombat");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CaptainDied;
    /// <summary>
    /// Function: CaptainDied
    /// </summary>
    public unsafe override void CaptainDied()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CaptainDied, "BmScript.RBMBehaviour_GangMovementBase.CaptainDied");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RiotHandleSpookedBy;
    /// <summary>
    /// Function: RiotHandleSpookedBy
    /// </summary>
    public unsafe override bool RiotHandleSpookedBy(BmSDK.Engine.Actor Threat, bool bAlertNeighours = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RiotHandleSpookedBy, "BmScript.RBMBehaviour_GangMovementBase.RiotHandleSpookedBy");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Threat, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAlertNeighours, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PlayFleeReaction;
    /// <summary>
    /// Function: PlayFleeReaction
    /// </summary>
    public unsafe virtual void PlayFleeReaction()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFleeReaction, "BmScript.RBMBehaviour_GangMovementBase.PlayFleeReaction");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickEndTransition;
    /// <summary>
    /// Function: QuickEndTransition
    /// </summary>
    public unsafe virtual void QuickEndTransition(bool bKeepRiotMovement, bool bGoingToCombat = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickEndTransition, "BmScript.RBMBehaviour_GangMovementBase.QuickEndTransition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKeepRiotMovement, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGoingToCombat, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSpecCanTakeOver;
    /// <summary>
    /// Function: SetSpecCanTakeOver
    /// </summary>
    public unsafe virtual void SetSpecCanTakeOver()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSpecCanTakeOver, "BmScript.RBMBehaviour_GangMovementBase.SetSpecCanTakeOver");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearCantFlee;
    /// <summary>
    /// Function: ClearCantFlee
    /// </summary>
    public unsafe virtual void ClearCantFlee()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCantFlee, "BmScript.RBMBehaviour_GangMovementBase.ClearCantFlee");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCantFlee;
    /// <summary>
    /// Function: SetCantFlee
    /// </summary>
    public unsafe virtual void SetCantFlee()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCantFlee, "BmScript.RBMBehaviour_GangMovementBase.SetCantFlee");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.RBMBehaviour_GangMovementBase.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerBumped;
    /// <summary>
    /// Function: PlayerBumped
    /// </summary>
    public unsafe override void PlayerBumped(bool bFriendly)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerBumped, "BmScript.RBMBehaviour_GangMovementBase.PlayerBumped");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFriendly, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleNoise;
    /// <summary>
    /// Function: HandleNoise
    /// </summary>
    public unsafe override void HandleNoise(BmSDK.BmGame.RPawnPlayer PlayerInstigator)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleNoise, "BmScript.RBMBehaviour_GangMovementBase.HandleNoise");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerInstigator, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Repath;
    /// <summary>
    /// Function: Repath
    /// </summary>
    public unsafe virtual void Repath()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Repath, "BmScript.RBMBehaviour_GangMovementBase.Repath");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartNavMeshSearch;
    /// <summary>
    /// Function: StartNavMeshSearch
    /// </summary>
    public unsafe virtual void StartNavMeshSearch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartNavMeshSearch, "BmScript.RBMBehaviour_GangMovementBase.StartNavMeshSearch");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VeryCloseToGoal;
    /// <summary>
    /// Function: VeryCloseToGoal
    /// </summary>
    public unsafe virtual bool VeryCloseToGoal(float CheckDist, float CheckDist2D)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VeryCloseToGoal, "BmScript.RBMBehaviour_GangMovementBase.VeryCloseToGoal");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDist, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDist2D, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PawnIsBeingPooled;
    /// <summary>
    /// Function: PawnIsBeingPooled
    /// </summary>
    public unsafe override void PawnIsBeingPooled(bool bBeingStreamedOut)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnIsBeingPooled, "BmScript.RBMBehaviour_GangMovementBase.PawnIsBeingPooled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBeingStreamedOut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnEndInterrupt;
    /// <summary>
    /// Function: OnEndInterrupt
    /// </summary>
    public unsafe override void OnEndInterrupt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEndInterrupt, "BmScript.RBMBehaviour_GangMovementBase.OnEndInterrupt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBeginInterrupt;
    /// <summary>
    /// Function: OnBeginInterrupt
    /// </summary>
    public unsafe override void OnBeginInterrupt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBeginInterrupt, "BmScript.RBMBehaviour_GangMovementBase.OnBeginInterrupt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDeactivate;
    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeactivate, "BmScript.RBMBehaviour_GangMovementBase.OnDeactivate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInitialState;
    /// <summary>
    /// Function: SetInitialState
    /// </summary>
    public unsafe override void SetInitialState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInitialState, "BmScript.RBMBehaviour_GangMovementBase.SetInitialState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LeaveDueToTimeout;
    /// <summary>
    /// Function: LeaveDueToTimeout
    /// </summary>
    public unsafe override void LeaveDueToTimeout()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LeaveDueToTimeout, "BmScript.RBMBehaviour_GangMovementBase.LeaveDueToTimeout");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GenerateMoveToPoint;
    /// <summary>
    /// Function: GenerateMoveToPoint
    /// </summary>
    public unsafe virtual void GenerateMoveToPoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GenerateMoveToPoint, "BmScript.RBMBehaviour_GangMovementBase.GenerateMoveToPoint");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnActivate;
    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmScript.RBMBehaviour_GangMovementBase.OnActivate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMoveLocation;
    /// <summary>
    /// Function: GetMoveLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetMoveLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMoveLocation, "BmScript.RBMBehaviour_GangMovementBase.GetMoveLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDestinationActor;
    /// <summary>
    /// Function: GetDestinationActor
    /// </summary>
    public unsafe override BmSDK.Engine.Actor GetDestinationActor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDestinationActor, "BmScript.RBMBehaviour_GangMovementBase.GetDestinationActor");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: DestinationActor
    /// </summary>
    public unsafe BmSDK.BmGame.RGangInteractPointBase DestinationActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGangInteractPointBase>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: NavHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle NavHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: SavedAction
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIAction_BaseMove SavedAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIAction_BaseMove>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: SavedSpecToPOI
    /// </summary>
    public unsafe BmSDK.BmGame.RGangInteractPointBase SavedSpecToPOI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGangInteractPointBase>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// NameProperty: SavedMovementStance
    /// </summary>
    public unsafe BmSDK.FName SavedMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// NameProperty: SavedWeaponStance
    /// </summary>
    public unsafe BmSDK.FName SavedWeaponStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// NameProperty: NewMovementStance
    /// </summary>
    public unsafe BmSDK.FName NewMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// NameProperty: NewWeaponStance
    /// </summary>
    public unsafe BmSDK.FName NewWeaponStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// StructProperty: SavedTransInPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SavedTransInPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 836);

    /// <summary>
    /// StructProperty: SavedTransInRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator SavedTransInRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 848);

    /// <summary>
    /// BoolProperty: bDetattchedFromCar
    /// </summary>
    public unsafe bool bDetattchedFromCar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: bCantFleeAtTheMoment
    /// </summary>
    public unsafe bool bCantFleeAtTheMoment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: bSecondTry
    /// </summary>
    public unsafe bool bSecondTry
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: bSprayingGraffiti
    /// </summary>
    public unsafe bool bSprayingGraffiti
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: bHasRegisteredPointWithBrain
    /// </summary>
    public unsafe bool bHasRegisteredPointWithBrain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: bHasDoneWaitState
    /// </summary>
    public unsafe bool bHasDoneWaitState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// FloatProperty: ChanceOfNewRunCycle
    /// </summary>
    public unsafe float ChanceOfNewRunCycle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// FloatProperty: StartleFriendDistance
    /// </summary>
    public unsafe float StartleFriendDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// StructProperty: FleeReactionID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId FleeReactionID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 872);

    /// <summary>
    /// ArrayProperty: FleeReactionFront
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> FleeReactionFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ArrayProperty: FleeReactionBack
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> FleeReactionBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// FloatProperty: CurrentSprayDuration
    /// </summary>
    public unsafe float CurrentSprayDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// FloatProperty: CurrentSprayTime
    /// </summary>
    public unsafe float CurrentSprayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// IntProperty: CurrentSprayIndex
    /// </summary>
    public unsafe int CurrentSprayIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// IntProperty: WaitStateFrameTimer
    /// </summary>
    public unsafe int WaitStateFrameTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }
}
