#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkConvoAction_AKMulti<br/>
/// (size = 212)
/// (flags = 134217874)
/// </summary>
public partial class RBarkConvoAction_AKMulti : BmSDK.BmGame.RBarkConvoAction_SpeechBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkConvoAction_AKMulti", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBarkConvoAction_AKMulti.
    /// </summary>
    public static RBarkConvoAction_AKMulti DefaultObject => (RBarkConvoAction_AKMulti)StaticClass().DefaultObject;

    internal RBarkConvoAction_AKMulti() { }

    /// <summary>
    /// Constructs a new RBarkConvoAction_AKMulti
    /// </summary>
    public RBarkConvoAction_AKMulti(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkConvoAction_AKMulti Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkConvoAction_AKMulti(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction_AKMulti>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction_AKMulti>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction_AKMulti>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction_AKMulti>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction_AKMulti>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction_AKMulti>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction_AKMulti>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction_AKMulti>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetCurrentDialogueType;
    /// <summary>
    /// Function: GetCurrentDialogueType
    /// </summary>
    public unsafe override BmSDK.Engine.AkDialogueType GetCurrentDialogueType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentDialogueType, "BmGame.RBarkConvoAction_AKMulti.GetCurrentDialogueType");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogueType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckLineRepetitionOkay;
    /// <summary>
    /// Function: CheckLineRepetitionOkay
    /// </summary>
    public unsafe override bool CheckLineRepetitionOkay(int SearchID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckLineRepetitionOkay, "BmGame.RBarkConvoAction_AKMulti.CheckLineRepetitionOkay");
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
    public unsafe override bool ContainsOnceEverDialogueEvent(int SearchID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ContainsOnceEverDialogueEvent, "BmGame.RBarkConvoAction_AKMulti.ContainsOnceEverDialogueEvent");
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
    public unsafe override bool ContainsOnceOnlyDialogueEvent(int SearchID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ContainsOnceOnlyDialogueEvent, "BmGame.RBarkConvoAction_AKMulti.ContainsOnceOnlyDialogueEvent");
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
    public unsafe override BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef> GBFSSearchHandlePawnRefList(BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef> InList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GBFSSearchHandlePawnRefList, "BmGame.RBarkConvoAction_AKMulti.GBFSSearchHandlePawnRefList");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InList, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef>>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetPawnRefList;
    /// <summary>
    /// Function: GetPawnRefList
    /// </summary>
    public unsafe override void GetPawnRefList(int SearchID, out BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef> PawnRefList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnRefList, "BmGame.RBarkConvoAction_AKMulti.GetPawnRefList");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PawnRefList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_GetLocalPlayedScore;
    /// <summary>
    /// Function: GetLocalPlayedScore
    /// </summary>
    public unsafe override float GetLocalPlayedScore()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalPlayedScore, "BmGame.RBarkConvoAction_AKMulti.GetLocalPlayedScore");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsFinished;
    /// <summary>
    /// Function: IsFinished
    /// </summary>
    public unsafe override bool IsFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFinished, "BmGame.RBarkConvoAction_AKMulti.IsFinished");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Stop;
    /// <summary>
    /// Function: Stop
    /// </summary>
    public unsafe override void Stop(bool bHardStop, bool bOrphan = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Stop, "BmGame.RBarkConvoAction_AKMulti.Stop");
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
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmGame.RBarkConvoAction_AKMulti.OnActivate");
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Line
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLineDynamic Line
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLineDynamic>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// ObjectProperty: Speaker
    /// </summary>
    public unsafe BmSDK.Engine.Actor Speaker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// ObjectProperty: PawnRef
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkConvoPawnRef PawnRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkConvoPawnRef>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// IntProperty: HandleID
    /// </summary>
    public unsafe int HandleID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }
}
