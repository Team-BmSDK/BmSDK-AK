#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_JokerRooftopController<br/>
/// (size = 652)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_JokerRooftopController : BmSDK.BmGame.RSeqAct_JokerRooftopControllerBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_JokerRooftopController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSeqAct_JokerRooftopController.
    /// </summary>
    public static RSeqAct_JokerRooftopController DefaultObject => (RSeqAct_JokerRooftopController)StaticClass().DefaultObject;

    internal RSeqAct_JokerRooftopController() { }

    /// <summary>
    /// Constructs a new RSeqAct_JokerRooftopController
    /// </summary>
    public RSeqAct_JokerRooftopController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_JokerRooftopController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_JokerRooftopController(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_JokerRooftopController>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_JokerRooftopController>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_JokerRooftopController>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_JokerRooftopController>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_JokerRooftopController>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_JokerRooftopController>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_JokerRooftopController>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_JokerRooftopController>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmScript.RSeqAct_JokerRooftopController.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FindSpawnPoint;
    /// <summary>
    /// Function: FindSpawnPoint
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RJokerRooftopPoint FindSpawnPoint(bool bHightLightSpheres = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindSpawnPoint, "BmScript.RSeqAct_JokerRooftopController.FindSpawnPoint");
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHightLightSpheres, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.RJokerRooftopPoint>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnRooftopJoker;
    /// <summary>
    /// Function: SpawnRooftopJoker
    /// </summary>
    public unsafe override void SpawnRooftopJoker()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnRooftopJoker, "BmScript.RSeqAct_JokerRooftopController.SpawnRooftopJoker");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSideStoryDialogue;
    /// <summary>
    /// Function: GetSideStoryDialogue
    /// </summary>
    public unsafe virtual bool GetSideStoryDialogue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSideStoryDialogue, "BmScript.RSeqAct_JokerRooftopController.GetSideStoryDialogue");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsMissionFinished;
    /// <summary>
    /// Function: IsMissionFinished
    /// </summary>
    public unsafe virtual bool IsMissionFinished(BmSDK.BmGame.RPersistentData pData, int missionIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMissionFinished, "BmScript.RSeqAct_JokerRooftopController.IsMissionFinished");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(missionIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetNumConvForSideStory;
    /// <summary>
    /// Function: GetNumConvForSideStory
    /// </summary>
    public unsafe virtual int GetNumConvForSideStory(int SideIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumConvForSideStory, "BmScript.RSeqAct_JokerRooftopController.GetNumConvForSideStory");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetSideStoryNameForIndex;
    /// <summary>
    /// Function: GetSideStoryNameForIndex
    /// </summary>
    public unsafe virtual BmSDK.FString GetSideStoryNameForIndex(int SideIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSideStoryNameForIndex, "BmScript.RSeqAct_JokerRooftopController.GetSideStoryNameForIndex");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTimeSinceUpdate;
    /// <summary>
    /// Function: GetTimeSinceUpdate
    /// </summary>
    public unsafe virtual float GetTimeSinceUpdate(BmSDK.BmGame.RPersistentData pData, int missionIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeSinceUpdate, "BmScript.RSeqAct_JokerRooftopController.GetTimeSinceUpdate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(missionIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsMissionEligibleForUpdateMovie;
    /// <summary>
    /// Function: IsMissionEligibleForUpdateMovie
    /// </summary>
    public unsafe virtual bool IsMissionEligibleForUpdateMovie(BmSDK.BmGame.RPersistentData pData, int missionIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMissionEligibleForUpdateMovie, "BmScript.RSeqAct_JokerRooftopController.IsMissionEligibleForUpdateMovie");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(missionIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetNumValidSideStoryLines;
    /// <summary>
    /// Function: GetNumValidSideStoryLines
    /// </summary>
    public unsafe virtual int GetNumValidSideStoryLines(float Perc, int StoryId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumValidSideStoryLines, "BmScript.RSeqAct_JokerRooftopController.GetNumValidSideStoryLines");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Perc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StoryId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetCh7Dialogue;
    /// <summary>
    /// Function: GetCh7Dialogue
    /// </summary>
    public unsafe virtual bool GetCh7Dialogue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCh7Dialogue, "BmScript.RSeqAct_JokerRooftopController.GetCh7Dialogue");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetChapterDialogue;
    /// <summary>
    /// Function: GetChapterDialogue
    /// </summary>
    public unsafe virtual bool GetChapterDialogue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChapterDialogue, "BmScript.RSeqAct_JokerRooftopController.GetChapterDialogue");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumConvForChapter;
    /// <summary>
    /// Function: GetNumConvForChapter
    /// </summary>
    public unsafe virtual int GetNumConvForChapter(int ChIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumConvForChapter, "BmScript.RSeqAct_JokerRooftopController.GetNumConvForChapter");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetAdjustedChapterNumber;
    /// <summary>
    /// Function: GetAdjustedChapterNumber
    /// </summary>
    public unsafe virtual int GetAdjustedChapterNumber()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAdjustedChapterNumber, "BmScript.RSeqAct_JokerRooftopController.GetAdjustedChapterNumber");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NextDialogueIsChapter;
    /// <summary>
    /// Function: NextDialogueIsChapter
    /// </summary>
    public unsafe virtual bool NextDialogueIsChapter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NextDialogueIsChapter, "BmScript.RSeqAct_JokerRooftopController.NextDialogueIsChapter");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayDialogue;
    /// <summary>
    /// Function: PlayDialogue
    /// </summary>
    public unsafe override void PlayDialogue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDialogue, "BmScript.RSeqAct_JokerRooftopController.PlayDialogue");
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartNextDialogue;
    /// <summary>
    /// Function: StartNextDialogue
    /// </summary>
    public unsafe override void StartNextDialogue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartNextDialogue, "BmScript.RSeqAct_JokerRooftopController.StartNextDialogue");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnAllJokers;
    /// <summary>
    /// Function: SpawnAllJokers
    /// </summary>
    public unsafe override void SpawnAllJokers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnAllJokers, "BmScript.RSeqAct_JokerRooftopController.SpawnAllJokers");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetJokerPointFromBehaviour;
    /// <summary>
    /// Function: GetJokerPointFromBehaviour
    /// </summary>
    public unsafe override BmSDK.BmGame.RJokerRooftopPointBase GetJokerPointFromBehaviour(BmSDK.BmGame.RBMBehaviour JokerBehav)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJokerPointFromBehaviour, "BmScript.RSeqAct_JokerRooftopController.GetJokerPointFromBehaviour");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JokerBehav, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RJokerRooftopPointBase>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DrawTestingSpheres;
    /// <summary>
    /// Function: DrawTestingSpheres
    /// </summary>
    public unsafe override void DrawTestingSpheres()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTestingSpheres, "BmScript.RSeqAct_JokerRooftopController.DrawTestingSpheres");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_JokerInView;
    /// <summary>
    /// Function: JokerInView
    /// </summary>
    public unsafe override bool JokerInView(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JokerInView, "BmScript.RSeqAct_JokerRooftopController.JokerInView");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// IntProperty: CurrentSideStorySelectedLine
    /// </summary>
    public unsafe int CurrentSideStorySelectedLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }
}
