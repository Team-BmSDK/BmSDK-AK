#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleScanner<br/>
/// (size = 356)
/// (flags = 18)
/// </summary>
public partial class RHudModuleScanner : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleScanner", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHudModuleScanner.
    /// </summary>
    public static RHudModuleScanner DefaultObject => (RHudModuleScanner)StaticClass().DefaultObject;

    internal RHudModuleScanner() { }

    /// <summary>
    /// Constructs a new RHudModuleScanner
    /// </summary>
    public RHudModuleScanner(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleScanner Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleScanner(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleScanner>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleScanner>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleScanner>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleScanner>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleScanner>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleScanner>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleScanner>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleScanner>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_InitDeepScanParams;
    /// <summary>
    /// Function: InitDeepScanParams
    /// </summary>
    public unsafe virtual void InitDeepScanParams(int NumEvidenceFound, int NumPossibilities, BmSDK.FString PossibleMatchString, BmSDK.FString FoundString1, BmSDK.FString FoundString2, int FinalDisplayFrameIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitDeepScanParams, "BmGame.RHudModuleScanner.InitDeepScanParams");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumEvidenceFound, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumPossibilities, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PossibleMatchString, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FoundString1, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FoundString2, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinalDisplayFrameIndex, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindDeepScanEvidence;
    /// <summary>
    /// Function: FindDeepScanEvidence
    /// </summary>
    public unsafe virtual void FindDeepScanEvidence(BmSDK.FString FoundString, int NumPossibilitiesNow)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindDeepScanEvidence, "BmGame.RHudModuleScanner.FindDeepScanEvidence");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FoundString, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumPossibilitiesNow, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDeepScanLevel;
    /// <summary>
    /// Function: SetDeepScanLevel
    /// </summary>
    public unsafe virtual void SetDeepScanLevel(int scan_level)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDeepScanLevel, "BmGame.RHudModuleScanner.SetDeepScanLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(scan_level, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddTimelineFill;
    /// <summary>
    /// Function: AddTimelineFill
    /// </summary>
    public unsafe virtual void AddTimelineFill(float prop_start, float prop_finish)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddTimelineFill, "BmGame.RHudModuleScanner.AddTimelineFill");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(prop_start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(prop_finish, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTimelineHighlight;
    /// <summary>
    /// Function: SetTimelineHighlight
    /// </summary>
    public unsafe virtual void SetTimelineHighlight(BmSDK.FString Anim, float prop_start, float prop_finish)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTimelineHighlight, "BmGame.RHudModuleScanner.SetTimelineHighlight");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(prop_start, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(prop_finish, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTimelineCursor;
    /// <summary>
    /// Function: SetTimelineCursor
    /// </summary>
    public unsafe virtual void SetTimelineCursor(float cursor_prop)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTimelineCursor, "BmGame.RHudModuleScanner.SetTimelineCursor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cursor_prop, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideTimeline;
    /// <summary>
    /// Function: HideTimeline
    /// </summary>
    public unsafe virtual void HideTimeline()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideTimeline, "BmGame.RHudModuleScanner.HideTimeline");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowTimeline;
    /// <summary>
    /// Function: ShowTimeline
    /// </summary>
    public unsafe virtual void ShowTimeline()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowTimeline, "BmGame.RHudModuleScanner.ShowTimeline");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartScanning;
    /// <summary>
    /// Function: StartScanning
    /// </summary>
    public unsafe virtual void StartScanning(bool isCaseFile, int scanMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartScanning, "BmGame.RHudModuleScanner.StartScanning");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isCaseFile, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(scanMode, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeselectEvidenceSection;
    /// <summary>
    /// Function: DeselectEvidenceSection
    /// </summary>
    public unsafe virtual void DeselectEvidenceSection(int percentIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeselectEvidenceSection, "BmGame.RHudModuleScanner.DeselectEvidenceSection");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(percentIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SelectEvidenceSection;
    /// <summary>
    /// Function: SelectEvidenceSection
    /// </summary>
    public unsafe virtual void SelectEvidenceSection(int percentIndex, int ScanState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectEvidenceSection, "BmGame.RHudModuleScanner.SelectEvidenceSection");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(percentIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScanState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveEvidenceSection;
    /// <summary>
    /// Function: RemoveEvidenceSection
    /// </summary>
    public unsafe virtual void RemoveEvidenceSection(int percentIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveEvidenceSection, "BmGame.RHudModuleScanner.RemoveEvidenceSection");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(percentIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddEvidenceSection;
    /// <summary>
    /// Function: AddEvidenceSection
    /// </summary>
    public unsafe virtual void AddEvidenceSection(int StartIndex, int endIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddEvidenceSection, "BmGame.RHudModuleScanner.AddEvidenceSection");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(endIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddSimpleEvidenceSection;
    /// <summary>
    /// Function: AddSimpleEvidenceSection
    /// </summary>
    public unsafe virtual void AddSimpleEvidenceSection(int percentIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSimpleEvidenceSection, "BmGame.RHudModuleScanner.AddSimpleEvidenceSection");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(percentIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCameraMode;
    /// <summary>
    /// Function: SetCameraMode
    /// </summary>
    public unsafe virtual void SetCameraMode(int Mode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCameraMode, "BmGame.RHudModuleScanner.SetCameraMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCaseFileMode;
    /// <summary>
    /// Function: SetCaseFileMode
    /// </summary>
    public unsafe virtual void SetCaseFileMode(int ScanState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCaseFileMode, "BmGame.RHudModuleScanner.SetCaseFileMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScanState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMarkerPositionPercentage;
    /// <summary>
    /// Function: SetMarkerPositionPercentage
    /// </summary>
    public unsafe virtual void SetMarkerPositionPercentage(float Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMarkerPositionPercentage, "BmGame.RHudModuleScanner.SetMarkerPositionPercentage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScannerPercentageComplete;
    /// <summary>
    /// Function: SetScannerPercentageComplete
    /// </summary>
    public unsafe virtual void SetScannerPercentageComplete(float Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScannerPercentageComplete, "BmGame.RHudModuleScanner.SetScannerPercentageComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScannerPosition;
    /// <summary>
    /// Function: SetScannerPosition
    /// </summary>
    public unsafe virtual void SetScannerPosition(float X, float Y)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScannerPosition, "BmGame.RHudModuleScanner.SetScannerPosition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScanAnimProportion;
    /// <summary>
    /// Function: SetScanAnimProportion
    /// </summary>
    public unsafe virtual void SetScanAnimProportion(BmSDK.FString anim_name, float Proportion)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScanAnimProportion, "BmGame.RHudModuleScanner.SetScanAnimProportion");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(anim_name, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayScanAnim;
    /// <summary>
    /// Function: PlayScanAnim
    /// </summary>
    public unsafe virtual void PlayScanAnim(BmSDK.FString anim_name)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayScanAnim, "BmGame.RHudModuleScanner.PlayScanAnim");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(anim_name, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Scanner_ScanComplete;
    /// <summary>
    /// Function: XI_Scanner_ScanComplete
    /// </summary>
    public unsafe virtual void XI_Scanner_ScanComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Scanner_ScanComplete, "BmGame.RHudModuleScanner.XI_Scanner_ScanComplete");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Scanner_ScannerAnimComplete;
    /// <summary>
    /// Function: XI_Scanner_ScannerAnimComplete
    /// </summary>
    public unsafe virtual void XI_Scanner_ScannerAnimComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Scanner_ScannerAnimComplete, "BmGame.RHudModuleScanner.XI_Scanner_ScannerAnimComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AutoChooseDetectedFrame;
    /// <summary>
    /// Function: AutoChooseDetectedFrame
    /// </summary>
    public unsafe virtual void AutoChooseDetectedFrame()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutoChooseDetectedFrame, "BmGame.RHudModuleScanner.AutoChooseDetectedFrame");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Scanner_NotifyOutroComplete;
    /// <summary>
    /// Function: XI_Scanner_NotifyOutroComplete
    /// </summary>
    public unsafe virtual void XI_Scanner_NotifyOutroComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Scanner_NotifyOutroComplete, "BmGame.RHudModuleScanner.XI_Scanner_NotifyOutroComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Scanner_NotifyIntroComplete;
    /// <summary>
    /// Function: XI_Scanner_NotifyIntroComplete
    /// </summary>
    public unsafe virtual void XI_Scanner_NotifyIntroComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Scanner_NotifyIntroComplete, "BmGame.RHudModuleScanner.XI_Scanner_NotifyIntroComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitialiseFlash;
    /// <summary>
    /// Function: InitialiseFlash
    /// </summary>
    public unsafe override void InitialiseFlash()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseFlash, "BmGame.RHudModuleScanner.InitialiseFlash");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.RHudModuleScanner.Close");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RHudModuleScanner.Init");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// StrProperty: CachedFunction_PlayScanAnim
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_PlayScanAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetScannerPosition
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetScannerPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetScanAnimProportion
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetScanAnimProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetTimelineHighlight
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetTimelineHighlight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetTimelineCursor
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetTimelineCursor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_AddTimelineFill
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_AddTimelineFill
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// StrProperty: CachedScanAnim
    /// </summary>
    public unsafe BmSDK.FString CachedScanAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: TimelineVisible
    /// </summary>
    public unsafe bool TimelineVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }
}
