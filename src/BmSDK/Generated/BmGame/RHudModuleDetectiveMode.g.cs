#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleDetectiveMode<br/>
/// (size = 445)
/// (flags = 18)
/// </summary>
public partial class RHudModuleDetectiveMode : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleDetectiveMode", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHudModuleDetectiveMode.
    /// </summary>
    public static RHudModuleDetectiveMode DefaultObject => (RHudModuleDetectiveMode)StaticClass().DefaultObject;

    internal RHudModuleDetectiveMode() { }

    /// <summary>
    /// Constructs a new RHudModuleDetectiveMode
    /// </summary>
    public RHudModuleDetectiveMode(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleDetectiveMode Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleDetectiveMode(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleDetectiveMode>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleDetectiveMode>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleDetectiveMode>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleDetectiveMode>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleDetectiveMode>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleDetectiveMode>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleDetectiveMode>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleDetectiveMode>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_HideScannerDetail;
    /// <summary>
    /// Function: HideScannerDetail
    /// </summary>
    public unsafe virtual void HideScannerDetail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideScannerDetail, "BmGame.RHudModuleDetectiveMode.HideScannerDetail");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScannerDetailPrivate;
    /// <summary>
    /// Function: SetScannerDetailPrivate
    /// </summary>
    public unsafe virtual void SetScannerDetailPrivate(BmSDK.FString swfmovie_name, bool bScanned)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScannerDetailPrivate, "BmGame.RHudModuleDetectiveMode.SetScannerDetailPrivate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(swfmovie_name, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bScanned, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScannerDetail;
    /// <summary>
    /// Function: SetScannerDetail
    /// </summary>
    public unsafe virtual void SetScannerDetail(float location_x, float location_y, float location_depth, BmSDK.BmGame.RPhysicalEvidenceBase CSE)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScannerDetail, "BmGame.RHudModuleDetectiveMode.SetScannerDetail");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_depth, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CSE, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideEvidenceDetail;
    /// <summary>
    /// Function: HideEvidenceDetail
    /// </summary>
    public unsafe virtual void HideEvidenceDetail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideEvidenceDetail, "BmGame.RHudModuleDetectiveMode.HideEvidenceDetail");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEvidenceDetailPrivate;
    /// <summary>
    /// Function: SetEvidenceDetailPrivate
    /// </summary>
    public unsafe virtual void SetEvidenceDetailPrivate(float location_x, float location_y, float location_depth, BmSDK.FString swfmovie_name, bool bScanned)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEvidenceDetailPrivate, "BmGame.RHudModuleDetectiveMode.SetEvidenceDetailPrivate");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_depth, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(swfmovie_name, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bScanned, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEvidenceDetail;
    /// <summary>
    /// Function: SetEvidenceDetail
    /// </summary>
    public unsafe virtual void SetEvidenceDetail(float location_x, float location_y, float location_depth, BmSDK.BmGame.RPhysicalEvidenceBase CSE)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEvidenceDetail, "BmGame.RHudModuleDetectiveMode.SetEvidenceDetail");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_depth, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CSE, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateCachedEvidence;
    /// <summary>
    /// Function: UpdateCachedEvidence
    /// </summary>
    public unsafe virtual void UpdateCachedEvidence(BmSDK.GFxUI.SwfMovie NewEvidence)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCachedEvidence, "BmGame.RHudModuleDetectiveMode.UpdateCachedEvidence");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewEvidence, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideInfoText;
    /// <summary>
    /// Function: HideInfoText
    /// </summary>
    public unsafe virtual void HideInfoText()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideInfoText, "BmGame.RHudModuleDetectiveMode.HideInfoText");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInfoText;
    /// <summary>
    /// Function: SetInfoText
    /// </summary>
    public unsafe virtual void SetInfoText(float location_x, float location_y, float location_depth, BmSDK.FString Heading, BmSDK.FString Description, bool Warning)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInfoText, "BmGame.RHudModuleDetectiveMode.SetInfoText");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_depth, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Heading, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Warning, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideNPCDetail;
    /// <summary>
    /// Function: HideNPCDetail
    /// </summary>
    public unsafe virtual void HideNPCDetail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideNPCDetail, "BmGame.RHudModuleDetectiveMode.HideNPCDetail");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNPCDetail;
    /// <summary>
    /// Function: SetNPCDetail
    /// </summary>
    public unsafe virtual void SetNPCDetail(float location_x, float location_y, float location_depth, int physical_state_enum, int weapon_enum, int extra_info_enum, bool is_armoured, BmSDK.FString optional_name)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNPCDetail, "BmGame.RHudModuleDetectiveMode.SetNPCDetail");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_depth, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(physical_state_enum, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(weapon_enum, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(extra_info_enum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_armoured, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(optional_name, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideSmokePercentage;
    /// <summary>
    /// Function: HideSmokePercentage
    /// </summary>
    public unsafe virtual void HideSmokePercentage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideSmokePercentage, "BmGame.RHudModuleDetectiveMode.HideSmokePercentage");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSmokePercentage;
    /// <summary>
    /// Function: SetSmokePercentage
    /// </summary>
    public unsafe virtual void SetSmokePercentage(int SmokePercentage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSmokePercentage, "BmGame.RHudModuleDetectiveMode.SetSmokePercentage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmokePercentage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNPCCountString;
    /// <summary>
    /// Function: SetNPCCountString
    /// </summary>
    public unsafe virtual void SetNPCCountString(int total, BmSDK.FString Str)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNPCCountString, "BmGame.RHudModuleDetectiveMode.SetNPCCountString");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(total, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Str, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateNPCCounts;
    /// <summary>
    /// Function: UpdateNPCCounts
    /// </summary>
    public unsafe virtual void UpdateNPCCounts(int Armed, int UnArmed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateNPCCounts, "BmGame.RHudModuleDetectiveMode.UpdateNPCCounts");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Armed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnArmed, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseCurrentDetail;
    /// <summary>
    /// Function: CloseCurrentDetail
    /// </summary>
    public unsafe virtual void CloseCurrentDetail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseCurrentDetail, "BmGame.RHudModuleDetectiveMode.CloseCurrentDetail");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearDetailIfMatches;
    /// <summary>
    /// Function: ClearDetailIfMatches
    /// </summary>
    public unsafe virtual void ClearDetailIfMatches(BmSDK.BmGame.RHudModuleDetectiveMode.DetailDisplayType _TestDetailType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearDetailIfMatches, "BmGame.RHudModuleDetectiveMode.ClearDetailIfMatches");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_TestDetailType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentDetail;
    /// <summary>
    /// Function: SetCurrentDetail
    /// </summary>
    public unsafe virtual void SetCurrentDetail(BmSDK.BmGame.RHudModuleDetectiveMode.DetailDisplayType _CurrentDetailType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentDetail, "BmGame.RHudModuleDetectiveMode.SetCurrentDetail");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_CurrentDetailType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Detective_InfoBoxOpenSound;
    /// <summary>
    /// Function: Detective_InfoBoxOpenSound
    /// </summary>
    public unsafe virtual void Detective_InfoBoxOpenSound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Detective_InfoBoxOpenSound, "BmGame.RHudModuleDetectiveMode.Detective_InfoBoxOpenSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVisible;
    /// <summary>
    /// Function: SetVisible
    /// </summary>
    public unsafe override void SetVisible(bool is_visible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVisible, "BmGame.RHudModuleDetectiveMode.SetVisible");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_visible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.RHudModuleDetectiveMode.Close");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseFlash, "BmGame.RHudModuleDetectiveMode.InitialiseFlash");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RHudModuleDetectiveMode.Init");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// Enum: ENpcExtraInfo
    /// </summary>
    public enum ENpcExtraInfo : byte
    {
        ENpcExtraInfo_None = 0,
        ENpcExtraInfo_Friendly = 1,
        ENpcExtraInfo_Undead = 2,
        ENpcExtraInfo_ThugJammer = 3,
        ENpcExtraInfo_ThugMines = 4,
        ENpcExtraInfo_ThugThermalVision = 5,
        ENpcExtraInfo_Robot = 6,
        ENpcExtraInfo_ThugJammerBroken = 7,
        ENpcExtraInfo_DroneController = 8,
        ENpcExtraInfo_DetectiveModeDetector = 9,
        ENpcExtraInfo_Medic3 = 10,
        ENpcExtraInfo_Medic2 = 11,
        ENpcExtraInfo_Medic1 = 12,
        ENpcExtraInfo_Medic0 = 13,
        ENpcExtraInfo_MAX = 14,
    }

    /// <summary>
    /// Enum: DetailDisplayType
    /// </summary>
    public enum DetailDisplayType : byte
    {
        DDT_None = 0,
        DDT_Smoke = 1,
        DDT_NPC = 2,
        DDT_Info = 3,
        DDT_Evidence = 4,
        DDT_Scanner = 5,
        DDT_MAX = 6,
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetNPCCountString
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetNPCCountString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetSmokeLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetSmokeLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_HideSmokeLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_HideSmokeLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetNPCDetail
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetNPCDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_HideNPCDetail
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_HideNPCDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetInfoText
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetInfoText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_HideInfoText
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_HideInfoText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetEvidenceDetail
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetEvidenceDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_HideEvidenceDetail
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_HideEvidenceDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetScannerDetail
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetScannerDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_HideScannerDetail
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_HideScannerDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// ObjectProperty: LastEvidenceSwf
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie LastEvidenceSwf
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// StrProperty: LastEvidenceString
    /// </summary>
    public unsafe BmSDK.FString LastEvidenceString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: NPCDetailActive
    /// </summary>
    public unsafe bool NPCDetailActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// BoolProperty: InfoTextActive
    /// </summary>
    public unsafe bool InfoTextActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// ByteProperty: CurrentDetailType
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleDetectiveMode.DetailDisplayType CurrentDetailType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleDetectiveMode.DetailDisplayType>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }
}
