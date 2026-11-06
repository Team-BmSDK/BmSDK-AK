#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkConvoAction<br/>
/// (size = 180)
/// (flags = 134217874)
/// </summary>
public partial class RBarkConvoAction : BmSDK.BmGame.RBarkConvoNode, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkConvoAction", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBarkConvoAction.
    /// </summary>
    public static RBarkConvoAction DefaultObject => (RBarkConvoAction)StaticClass().DefaultObject;

    internal RBarkConvoAction() { }

    /// <summary>
    /// Constructs a new RBarkConvoAction
    /// </summary>
    public RBarkConvoAction(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkConvoAction Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkConvoAction(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CheckLineRepetitionOkay;
    /// <summary>
    /// Function: CheckLineRepetitionOkay
    /// </summary>
    public unsafe virtual bool CheckLineRepetitionOkay(int SearchID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckLineRepetitionOkay, "BmGame.RBarkConvoAction.CheckLineRepetitionOkay");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ContainsOnceEverDialogueEvent;
    /// <summary>
    /// Function: ContainsOnceEverDialogueEvent
    /// </summary>
    public unsafe virtual bool ContainsOnceEverDialogueEvent(int SearchID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ContainsOnceEverDialogueEvent, "BmGame.RBarkConvoAction.ContainsOnceEverDialogueEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ContainsOnceOnlyDialogueEvent;
    /// <summary>
    /// Function: ContainsOnceOnlyDialogueEvent
    /// </summary>
    public unsafe virtual bool ContainsOnceOnlyDialogueEvent(int SearchID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ContainsOnceOnlyDialogueEvent, "BmGame.RBarkConvoAction.ContainsOnceOnlyDialogueEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GBFSSearchHandlePawnRefList;
    /// <summary>
    /// Function: GBFSSearchHandlePawnRefList
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef> GBFSSearchHandlePawnRefList(BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef> InList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GBFSSearchHandlePawnRefList, "BmGame.RBarkConvoAction.GBFSSearchHandlePawnRefList");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InList, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef>>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_FindPawnRef;
    /// <summary>
    /// Function: FindPawnRef
    /// </summary>
    public unsafe virtual int FindPawnRef(BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef> InList, BmSDK.BmGame.RBarkConvoPawnRef TestPawnRef)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPawnRef, "BmGame.RBarkConvoAction.FindPawnRef");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawnRef, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetPawnRefList;
    /// <summary>
    /// Function: GetPawnRefList
    /// </summary>
    public unsafe virtual void GetPawnRefList(int SearchID, out BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef> PawnRefList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnRefList, "BmGame.RBarkConvoAction.GetPawnRefList");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PawnRefList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_HasTerminatingOutput;
    /// <summary>
    /// Function: HasTerminatingOutput
    /// </summary>
    public unsafe virtual bool HasTerminatingOutput()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasTerminatingOutput, "BmGame.RBarkConvoAction.HasTerminatingOutput");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLocalPlayedScore;
    /// <summary>
    /// Function: GetLocalPlayedScore
    /// </summary>
    public unsafe virtual float GetLocalPlayedScore()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalPlayedScore, "BmGame.RBarkConvoAction.GetLocalPlayedScore");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ThisPlayedScore;
    /// <summary>
    /// Function: ThisPlayedScore
    /// </summary>
    public unsafe virtual float ThisPlayedScore(BmSDK.BmGame.RBarkFlagBase TestContext)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThisPlayedScore, "BmGame.RBarkConvoAction.ThisPlayedScore");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestContext, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetOutputIndex;
    /// <summary>
    /// Function: GetOutputIndex
    /// </summary>
    public unsafe virtual int GetOutputIndex()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOutputIndex, "BmGame.RBarkConvoAction.GetOutputIndex");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsFinished;
    /// <summary>
    /// Function: IsFinished
    /// </summary>
    public unsafe virtual bool IsFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFinished, "BmGame.RBarkConvoAction.IsFinished");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Stop;
    /// <summary>
    /// Function: Stop
    /// </summary>
    public unsafe virtual void Stop(bool bHardStop, bool bOrphan = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Stop, "BmGame.RBarkConvoAction.Stop");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHardStop, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOrphan, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnActivate;
    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe virtual void OnActivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmGame.RBarkConvoAction.OnActivate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Activate;
    /// <summary>
    /// Function: Activate
    /// </summary>
    public unsafe virtual void Activate(BmSDK.BmGame.RBarkConvo NewConvoCoord)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Activate, "BmGame.RBarkConvoAction.Activate");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewConvoCoord, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: Out
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkConvoAction.FBCA_Output> Out
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkConvoAction.FBCA_Output>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: bInterrupted
    /// </summary>
    public unsafe bool bInterrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 132); }
    }

    /// <summary>
    /// BoolProperty: bRecursionLock
    /// </summary>
    public unsafe bool bRecursionLock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: ConvoCoord
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkConvo ConvoCoord
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkConvo>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// IntProperty: LastSearchID
    /// </summary>
    public unsafe int LastSearchID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ArrayProperty: DrawOutputX
    /// </summary>
    public unsafe BmSDK.TArray<int> DrawOutputX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ArrayProperty: DrawInputY
    /// </summary>
    public unsafe BmSDK.TArray<int> DrawInputY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// Struct: FBCA_Output
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FBCA_Output
    {
        /// <summary>
        /// ArrayProperty: Next
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkConvoAction> Next
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkConvoAction>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Label
        /// </summary>
        public unsafe BmSDK.FString Label
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}
