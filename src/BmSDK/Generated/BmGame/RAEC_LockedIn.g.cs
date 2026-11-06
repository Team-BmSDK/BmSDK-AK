#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_LockedIn<br/>
/// (size = 752)
/// (flags = 10485778)
/// </summary>
public partial class RAEC_LockedIn : BmSDK.BmGame.RAlertEventCoordinatorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_LockedIn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_LockedIn.
    /// </summary>
    public static RAEC_LockedIn DefaultObject => (RAEC_LockedIn)StaticClass().DefaultObject;

    internal RAEC_LockedIn() { }

    /// <summary>
    /// Constructs a new RAEC_LockedIn
    /// </summary>
    public RAEC_LockedIn(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_LockedIn(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_LockedIn>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_LockedIn>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_LockedIn>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_LockedIn>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_LockedIn>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_LockedIn>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_LockedIn>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_LockedIn>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_IsInUse;
    /// <summary>
    /// Function: IsInUse
    /// </summary>
    public unsafe virtual bool IsInUse(BmSDK.BmGame.RLockedInReactionPoint TestPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInUse, "BmGame.RAEC_LockedIn.IsInUse");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetBestThugAndReactPoint;
    /// <summary>
    /// Function: GetBestThugAndReactPoint
    /// </summary>
    public unsafe virtual void GetBestThugAndReactPoint(BmSDK.TArray<BmSDK.BmGame.RAEC_LockedIn.FThugPointDist> ThugPointDistList, out int ThugIndex, out BmSDK.BmGame.RLockedInReactionPoint UsablePoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestThugAndReactPoint, "BmGame.RAEC_LockedIn.GetBestThugAndReactPoint");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugPointDistList, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThugIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugIndex, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out UsablePoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UsablePoint, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThugIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        UsablePoint = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RLockedInReactionPoint>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_BuildThugPointDistList;
    /// <summary>
    /// Function: BuildThugPointDistList
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RAEC_LockedIn.FThugPointDist> BuildThugPointDistList(BmSDK.TArray<BmSDK.BmGame.RBMAIController> ConList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuildThugPointDistList, "BmGame.RAEC_LockedIn.BuildThugPointDistList");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConList, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RAEC_LockedIn.FThugPointDist>>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ReleaseAllThugs;
    /// <summary>
    /// Function: ReleaseAllThugs
    /// </summary>
    public unsafe virtual void ReleaseAllThugs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseAllThugs, "BmGame.RAEC_LockedIn.ReleaseAllThugs");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryReactBarkFor;
    /// <summary>
    /// Function: TryReactBarkFor
    /// </summary>
    public unsafe virtual void TryReactBarkFor(BmSDK.BmGame.RPawnVillain ReactBarkPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryReactBarkFor, "BmGame.RAEC_LockedIn.TryReactBarkFor");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReactBarkPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleLockedInThugs;
    /// <summary>
    /// Function: HandleLockedInThugs
    /// </summary>
    public unsafe virtual void HandleLockedInThugs(BmSDK.TArray<BmSDK.BmGame.RBMAIController> LockinConList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleLockedInThugs, "BmGame.RAEC_LockedIn.HandleLockedInThugs");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LockinConList, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrepReactPoint;
    /// <summary>
    /// Function: PrepReactPoint
    /// </summary>
    public unsafe virtual void PrepReactPoint(BmSDK.BmGame.RLockedInReactionPoint NewLockinReactpoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepReactPoint, "BmGame.RAEC_LockedIn.PrepReactPoint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLockinReactpoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RAEC_LockedIn.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FThugPointDist
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FThugPointDist
    {
        /// <summary>
        /// ObjectProperty: TestThugCon
        /// </summary>
        public unsafe BmSDK.BmGame.RBMAIController TestThugCon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: PointDistList
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_LockedIn.FPointDist> PointDistList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_LockedIn.FPointDist>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FPointDist
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FPointDist
    {
        /// <summary>
        /// IntProperty: ReactPointIndex
        /// </summary>
        public unsafe int ReactPointIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: DistSq
        /// </summary>
        public unsafe float DistSq
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// ArrayProperty: ReactPointList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLockedInReactionPoint> ReactPointList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLockedInReactionPoint>>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: FallbackAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_LockedIn_Fallback FallbackAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_LockedIn_Fallback>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bReactBarkPlayed
    /// </summary>
    public unsafe bool bReactBarkPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: LockTime
    /// </summary>
    public unsafe float LockTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }
}
