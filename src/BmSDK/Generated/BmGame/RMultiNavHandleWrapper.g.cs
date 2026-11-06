#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RMultiNavHandleWrapper<br/>
/// (size = 132)
/// (flags = 18)
/// </summary>
public partial class RMultiNavHandleWrapper : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RMultiNavHandleWrapper", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RMultiNavHandleWrapper.
    /// </summary>
    public static RMultiNavHandleWrapper DefaultObject => (RMultiNavHandleWrapper)StaticClass().DefaultObject;

    internal RMultiNavHandleWrapper() { }

    /// <summary>
    /// Constructs a new RMultiNavHandleWrapper
    /// </summary>
    public RMultiNavHandleWrapper(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RMultiNavHandleWrapper Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMultiNavHandleWrapper(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMultiNavHandleWrapper>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMultiNavHandleWrapper>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMultiNavHandleWrapper>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMultiNavHandleWrapper>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMultiNavHandleWrapper>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMultiNavHandleWrapper>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMultiNavHandleWrapper>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMultiNavHandleWrapper>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_IsEmpty;
    /// <summary>
    /// Function: IsEmpty
    /// </summary>
    public unsafe virtual bool IsEmpty()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsEmpty, "BmGame.RMultiNavHandleWrapper.IsEmpty");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsSearching;
    /// <summary>
    /// Function: IsSearching
    /// </summary>
    public unsafe virtual bool IsSearching()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSearching, "BmGame.RMultiNavHandleWrapper.IsSearching");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FreeAllHandles;
    /// <summary>
    /// Function: FreeAllHandles
    /// </summary>
    public unsafe virtual void FreeAllHandles()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FreeAllHandles, "BmGame.RMultiNavHandleWrapper.FreeAllHandles");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemovePathByIndex;
    /// <summary>
    /// Function: RemovePathByIndex
    /// </summary>
    public unsafe virtual void RemovePathByIndex(int RemIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemovePathByIndex, "BmGame.RMultiNavHandleWrapper.RemovePathByIndex");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDestForIndex;
    /// <summary>
    /// Function: GetDestForIndex
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDestForIndex(int TestIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDestForIndex, "BmGame.RMultiNavHandleWrapper.GetDestForIndex");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDistForPathToIndex;
    /// <summary>
    /// Function: GetDistForPathToIndex
    /// </summary>
    public unsafe virtual float GetDistForPathToIndex(int TestIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDistForPathToIndex, "BmGame.RMultiNavHandleWrapper.GetDistForPathToIndex");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDestIndexClosestTo;
    /// <summary>
    /// Function: GetDestIndexClosestTo
    /// </summary>
    public unsafe virtual int GetDestIndexClosestTo(System.Numerics.Vector3 TestPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDestIndexClosestTo, "BmGame.RMultiNavHandleWrapper.GetDestIndexClosestTo");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetNumPaths;
    /// <summary>
    /// Function: GetNumPaths
    /// </summary>
    public unsafe virtual int GetNumPaths()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumPaths, "BmGame.RMultiNavHandleWrapper.GetNumPaths");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetShortestPath;
    /// <summary>
    /// Function: GetShortestPath
    /// </summary>
    public unsafe virtual bool GetShortestPath(out float bestDist, out int BestPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetShortestPath, "BmGame.RMultiNavHandleWrapper.GetShortestPath");
        byte* paramsPtr = stackalloc byte[20];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bestDist);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bestDist, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestPath);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestPath, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        bestDist = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
        BestPath = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AddDestination;
    /// <summary>
    /// Function: AddDestination
    /// </summary>
    public unsafe virtual void AddDestination(System.Numerics.Vector3 NewLoc, int NewIndex = default, float NewExtraCost = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDestination, "BmGame.RMultiNavHandleWrapper.AddDestination");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewExtraCost, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplaySearches;
    /// <summary>
    /// Function: DisplaySearches
    /// </summary>
    public unsafe virtual void DisplaySearches()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplaySearches, "BmGame.RMultiNavHandleWrapper.DisplaySearches");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAvoidPlayers;
    /// <summary>
    /// Function: SetAvoidPlayers
    /// </summary>
    public unsafe virtual void SetAvoidPlayers(bool bNewVal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAvoidPlayers, "BmGame.RMultiNavHandleWrapper.SetAvoidPlayers");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewVal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetThug;
    /// <summary>
    /// Function: GetThug
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMPawnAI GetThug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThug, "BmGame.RMultiNavHandleWrapper.GetThug");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetThug;
    /// <summary>
    /// Function: SetThug
    /// </summary>
    public unsafe virtual void SetThug(BmSDK.BmGame.RBMPawnAI NewThug, BmSDK.FName NewClaimName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetThug, "BmGame.RMultiNavHandleWrapper.SetThug");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewThug, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewClaimName, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FIndexedNavHandle
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FIndexedNavHandle
    {
        /// <summary>
        /// ObjectProperty: NavHandle
        /// </summary>
        public unsafe BmSDK.BmGame.RNavigationHandle NavHandle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Index
        /// </summary>
        public unsafe int Index
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: ExtraCost
        /// </summary>
        public unsafe float ExtraCost
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// StructProperty: OverrideStartLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 OverrideStartLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 84);

    /// <summary>
    /// ObjectProperty: Thug
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI Thug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ArrayProperty: Path
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper.FIndexedNavHandle> Path
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper.FIndexedNavHandle>>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bAvoidPlayers
    /// </summary>
    public unsafe bool bAvoidPlayers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreGuardVolumeConstraints
    /// </summary>
    public unsafe bool bIgnoreGuardVolumeConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// NameProperty: ClaimName
    /// </summary>
    public unsafe BmSDK.FName ClaimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
}
