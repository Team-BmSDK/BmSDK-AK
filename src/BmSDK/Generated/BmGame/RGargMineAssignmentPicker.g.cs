#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGargMineAssignmentPicker<br/>
/// (size = 164)
/// (flags = 8388626)
/// </summary>
public partial class RGargMineAssignmentPicker : BmSDK.BmGame.RGroupAssignmentPicker, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGargMineAssignmentPicker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGargMineAssignmentPicker.
    /// </summary>
    public static RGargMineAssignmentPicker DefaultObject => (RGargMineAssignmentPicker)StaticClass().DefaultObject;

    internal RGargMineAssignmentPicker() { }

    /// <summary>
    /// Constructs a new RGargMineAssignmentPicker
    /// </summary>
    public RGargMineAssignmentPicker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGargMineAssignmentPicker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGargMineAssignmentPicker(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGargMineAssignmentPicker>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGargMineAssignmentPicker>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGargMineAssignmentPicker>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGargMineAssignmentPicker>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGargMineAssignmentPicker>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGargMineAssignmentPicker>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGargMineAssignmentPicker>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGargMineAssignmentPicker>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetBestDestroyVantagePointsFromAPS;
    /// <summary>
    /// Function: GetBestDestroyVantagePointsFromAPS
    /// </summary>
    public unsafe virtual void GetBestDestroyVantagePointsFromAPS(System.Numerics.Vector3 VantageRefPoint, BmSDK.BmGame.RAttackPointSearch APS, out BmSDK.TArray<System.Numerics.Vector3> BestPoints)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestDestroyVantagePointsFromAPS, "BmGame.RGargMineAssignmentPicker.GetBestDestroyVantagePointsFromAPS");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VantageRefPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(APS, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BestPoints = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_BuildGargSearch;
    /// <summary>
    /// Function: BuildGargSearch
    /// </summary>
    public unsafe virtual void BuildGargSearch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuildGargSearch, "BmGame.RGargMineAssignmentPicker.BuildGargSearch");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAPS;
    /// <summary>
    /// Function: StartAPS
    /// </summary>
    public unsafe virtual void StartAPS()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAPS, "BmGame.RGargMineAssignmentPicker.StartAPS");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Update;
    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe override bool Update()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Update, "BmGame.RGargMineAssignmentPicker.Update");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearAllSearch;
    /// <summary>
    /// Function: ClearAllSearch
    /// </summary>
    public unsafe virtual void ClearAllSearch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAllSearch, "BmGame.RGargMineAssignmentPicker.ClearAllSearch");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Abort;
    /// <summary>
    /// Function: Abort
    /// </summary>
    public unsafe virtual void Abort()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Abort, "BmGame.RGargMineAssignmentPicker.Abort");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init(BmSDK.BmGame.RBMRoomAIState NewRoomState, System.IntPtr NewMineAssignmentFound, System.IntPtr NewMineAssignmentFailed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGargMineAssignmentPicker.Init");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRoomState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMineAssignmentFound, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMineAssignmentFailed, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MineAssignmentFailed;
    /// <summary>
    /// Function: MineAssignmentFailed
    /// </summary>
    public unsafe virtual void MineAssignmentFailed(BmSDK.BmGame.RGargMineAssignmentPicker GMAP)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MineAssignmentFailed, "BmGame.RGargMineAssignmentPicker.MineAssignmentFailed");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GMAP, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MineAssignmentFound;
    /// <summary>
    /// Function: MineAssignmentFound
    /// </summary>
    public unsafe virtual void MineAssignmentFound(BmSDK.BmGame.RGargMineAssignmentPicker GMAP, BmSDK.TArray<BmSDK.BmGame.RBMRoomAIState.FGargToPoints> NewSmashList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MineAssignmentFound, "BmGame.RGargMineAssignmentPicker.MineAssignmentFound");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GMAP, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSmashList, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FGargLocSearchItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FGargLocSearchItem
    {
        /// <summary>
        /// ObjectProperty: APS
        /// </summary>
        public unsafe BmSDK.BmGame.RAttackPointSearch APS
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAttackPointSearch>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: RefPoint
        /// </summary>
        public unsafe System.Numerics.Vector3 RefPoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: Garg
        /// </summary>
        public unsafe BmSDK.BmGame.RHidePoint Garg
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: AssignID
        /// </summary>
        public unsafe int AssignID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// ComponentProperty: RoomState
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState RoomState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: GargLocSearch
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGargMineAssignmentPicker.FGargLocSearchItem> GargLocSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGargMineAssignmentPicker.FGargLocSearchItem>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: GargsAndDestsList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMRoomAIState.FGargToPoints> GargsAndDestsList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMRoomAIState.FGargToPoints>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// DelegateProperty: __MineAssignmentFound__Delegate
    /// </summary>
    public unsafe System.IntPtr __MineAssignmentFound__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// DelegateProperty: __MineAssignmentFailed__Delegate
    /// </summary>
    public unsafe System.IntPtr __MineAssignmentFailed__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
}
