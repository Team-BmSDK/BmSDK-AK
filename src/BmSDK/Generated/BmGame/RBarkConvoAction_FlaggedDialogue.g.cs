#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkConvoAction_FlaggedDialogue<br/>
/// (size = 224)
/// (flags = 134217874)
/// </summary>
public partial class RBarkConvoAction_FlaggedDialogue : BmSDK.BmGame.RBarkConvoAction_SpeechBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkConvoAction_FlaggedDialogue", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBarkConvoAction_FlaggedDialogue.
    /// </summary>
    public static RBarkConvoAction_FlaggedDialogue DefaultObject => (RBarkConvoAction_FlaggedDialogue)StaticClass().DefaultObject;

    internal RBarkConvoAction_FlaggedDialogue() { }

    /// <summary>
    /// Constructs a new RBarkConvoAction_FlaggedDialogue
    /// </summary>
    public RBarkConvoAction_FlaggedDialogue(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkConvoAction_FlaggedDialogue Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkConvoAction_FlaggedDialogue(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction_FlaggedDialogue>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction_FlaggedDialogue>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction_FlaggedDialogue>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction_FlaggedDialogue>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction_FlaggedDialogue>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction_FlaggedDialogue>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction_FlaggedDialogue>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkConvoAction_FlaggedDialogue>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetCurrentDialogueType;
    /// <summary>
    /// Function: GetCurrentDialogueType
    /// </summary>
    public unsafe override BmSDK.Engine.AkDialogueType GetCurrentDialogueType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentDialogueType, "BmGame.RBarkConvoAction_FlaggedDialogue.GetCurrentDialogueType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogueType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBestDataAndIndex;
    /// <summary>
    /// Function: GetBestDataAndIndex
    /// </summary>
    public unsafe virtual void GetBestDataAndIndex(BmSDK.BmGame.RBarkFlagBase ContextFlags, out BmSDK.BmGame.RBarkConvoData_FlagNode OutData, out int BestIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestDataAndIndex, "BmGame.RBarkConvoAction_FlaggedDialogue.GetBestDataAndIndex");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutData);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutData, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestIndex, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBarkConvoData_FlagNode>(paramsPtr + 8);
        BestIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_AddIndividualFlagsFor;
    /// <summary>
    /// Function: AddIndividualFlagsFor
    /// </summary>
    public unsafe virtual void AddIndividualFlagsFor(BmSDK.Engine.Actor Speaker, out BmSDK.BmGame.RBarkFlagBase context)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddIndividualFlagsFor, "BmGame.RBarkConvoAction_FlaggedDialogue.AddIndividualFlagsFor");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out context);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(context, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        context = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBarkFlagBase>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_GBFSSearchHandlePawnRefList;
    /// <summary>
    /// Function: GBFSSearchHandlePawnRefList
    /// </summary>
    public unsafe override BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef> GBFSSearchHandlePawnRefList(BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef> InList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GBFSSearchHandlePawnRefList, "BmGame.RBarkConvoAction_FlaggedDialogue.GBFSSearchHandlePawnRefList");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnRefList, "BmGame.RBarkConvoAction_FlaggedDialogue.GetPawnRefList");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalPlayedScore, "BmGame.RBarkConvoAction_FlaggedDialogue.GetLocalPlayedScore");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsFinished;
    /// <summary>
    /// Function: IsFinished
    /// </summary>
    public unsafe override bool IsFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFinished, "BmGame.RBarkConvoAction_FlaggedDialogue.IsFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Stop;
    /// <summary>
    /// Function: Stop
    /// </summary>
    public unsafe override void Stop(bool bHardStop, bool bOrphan = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Stop, "BmGame.RBarkConvoAction_FlaggedDialogue.Stop");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmGame.RBarkConvoAction_FlaggedDialogue.OnActivate");
        byte* paramsPtr = stackalloc byte[196];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: ConvoFlagSource
    /// </summary>
    public enum ConvoFlagSource : byte
    {
        CFS_Base = 0,
        CFS_BaseAndSpeaker = 1,
        CFS_Speaker = 2,
        CFS_MAX = 3,
    }

    /// <summary>
    /// ArrayProperty: ConvoData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkConvoData_FlagNode> ConvoData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkConvoData_FlagNode>>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// ByteProperty: FlagSource
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkConvoAction_FlaggedDialogue.ConvoFlagSource FlagSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkConvoAction_FlaggedDialogue.ConvoFlagSource>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// IntProperty: HandleID
    /// </summary>
    public unsafe int HandleID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ObjectProperty: PawnRef
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkConvoPawnRef PawnRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkConvoPawnRef>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// ObjectProperty: triggeredSpeech
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech triggeredSpeech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
}
