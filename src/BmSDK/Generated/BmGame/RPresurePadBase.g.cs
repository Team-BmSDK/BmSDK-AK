#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPresurePadBase<br/>
/// (size = 736)
/// (flags = 144703635)
/// </summary>
public partial class RPresurePadBase : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPresurePadBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPresurePadBase.
    /// </summary>
    public static RPresurePadBase DefaultObject => (RPresurePadBase)StaticClass().DefaultObject;

    internal RPresurePadBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPresurePadBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPresurePadBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPresurePadBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPresurePadBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPresurePadBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPresurePadBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPresurePadBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPresurePadBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPresurePadBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_IsStaticForFloorCorrection;
    /// <summary>
    /// Function: IsStaticForFloorCorrection
    /// </summary>
    public unsafe override bool IsStaticForFloorCorrection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStaticForFloorCorrection, "BmGame.RPresurePadBase.IsStaticForFloorCorrection");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetOverworldHintRange;
    /// <summary>
    /// Function: GetOverworldHintRange
    /// </summary>
    public unsafe virtual int GetOverworldHintRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverworldHintRange, "BmGame.RPresurePadBase.GetOverworldHintRange");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSatnavToRoadAtSameHeight;
    /// <summary>
    /// Function: GetSatnavToRoadAtSameHeight
    /// </summary>
    public unsafe virtual bool GetSatnavToRoadAtSameHeight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSatnavToRoadAtSameHeight, "BmGame.RPresurePadBase.GetSatnavToRoadAtSameHeight");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSatnavToRoadBelow;
    /// <summary>
    /// Function: GetSatnavToRoadBelow
    /// </summary>
    public unsafe virtual bool GetSatnavToRoadBelow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSatnavToRoadBelow, "BmGame.RPresurePadBase.GetSatnavToRoadBelow");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCustomFlag;
    /// <summary>
    /// Function: GetCustomFlag
    /// </summary>
    public unsafe virtual BmSDK.FString GetCustomFlag()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomFlag, "BmGame.RPresurePadBase.GetCustomFlag");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetUnlockedChapter;
    /// <summary>
    /// Function: GetUnlockedChapter
    /// </summary>
    public unsafe virtual int GetUnlockedChapter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnlockedChapter, "BmGame.RPresurePadBase.GetUnlockedChapter");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMapIconFloatUpAdjustment;
    /// <summary>
    /// Function: GetMapIconFloatUpAdjustment
    /// </summary>
    public unsafe virtual int GetMapIconFloatUpAdjustment()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMapIconFloatUpAdjustment, "BmGame.RPresurePadBase.GetMapIconFloatUpAdjustment");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UseSecretLocation;
    /// <summary>
    /// Function: UseSecretLocation
    /// </summary>
    public unsafe virtual bool UseSecretLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UseSecretLocation, "BmGame.RPresurePadBase.UseSecretLocation");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretLocationZ;
    /// <summary>
    /// Function: GetSecretLocationZ
    /// </summary>
    public unsafe virtual int GetSecretLocationZ()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretLocationZ, "BmGame.RPresurePadBase.GetSecretLocationZ");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretLocationY;
    /// <summary>
    /// Function: GetSecretLocationY
    /// </summary>
    public unsafe virtual int GetSecretLocationY()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretLocationY, "BmGame.RPresurePadBase.GetSecretLocationY");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretLocationX;
    /// <summary>
    /// Function: GetSecretLocationX
    /// </summary>
    public unsafe virtual int GetSecretLocationX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretLocationX, "BmGame.RPresurePadBase.GetSecretLocationX");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretZone;
    /// <summary>
    /// Function: GetSecretZone
    /// </summary>
    public unsafe virtual byte GetSecretZone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretZone, "BmGame.RPresurePadBase.GetSecretZone");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretPickupIndex;
    /// <summary>
    /// Function: GetSecretPickupIndex
    /// </summary>
    public unsafe virtual int GetSecretPickupIndex()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretPickupIndex, "BmGame.RPresurePadBase.GetSecretPickupIndex");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretSubType;
    /// <summary>
    /// Function: GetSecretSubType
    /// </summary>
    public unsafe virtual BmSDK.FString GetSecretSubType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretSubType, "BmGame.RPresurePadBase.GetSecretSubType");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretName;
    /// <summary>
    /// Function: GetSecretName
    /// </summary>
    public unsafe virtual BmSDK.FString GetSecretName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretName, "BmGame.RPresurePadBase.GetSecretName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsValidSecret;
    /// <summary>
    /// Function: IsValidSecret
    /// </summary>
    public unsafe virtual bool IsValidSecret()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidSecret, "BmGame.RPresurePadBase.IsValidSecret");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: EPressurePadType
    /// </summary>
    public enum EPressurePadType : byte
    {
        PPT_BatmanAndCatwoman = 0,
        PPT_CatwomanOnly = 1,
        PPT_AvoidPad = 2,
        PPT_NoReaction = 3,
        PPT_BatmanOnly = 4,
        PPT_BatmobileOnly = 5,
        PPT_BatmobileWithBatman = 6,
        PPT_BatmanOrBatmobile = 7,
        PPT_BatmanAndCatwomanAndRobot = 8,
        PPT_PressurePadType_MAX = 9,
        PPT_MAX = 10,
    }

    /// <summary>
    /// StructProperty: VfTable_IRSecretInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRSecretInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ByteProperty: CurrentPadType
    /// </summary>
    public unsafe BmSDK.BmGame.RPresurePadBase.EPressurePadType CurrentPadType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPresurePadBase.EPressurePadType>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ByteProperty: Zone
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.ERiddlerLocationName Zone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ERiddlerLocationName>(Ptr + 677); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 677); }
    }

    /// <summary>
    /// ByteProperty: ChapterPresentIn
    /// </summary>
    public unsafe BmSDK.BmGame.RPickupBase.EChapterNo ChapterPresentIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPickupBase.EChapterNo>(Ptr + 678); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 678); }
    }

    /// <summary>
    /// BoolProperty: bIsSecret
    /// </summary>
    public unsafe bool bIsSecret
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// BoolProperty: bUseSecretLocation
    /// </summary>
    public unsafe bool bUseSecretLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// IntProperty: SecretIndex
    /// </summary>
    public unsafe int SecretIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// IntProperty: SecretX
    /// </summary>
    public unsafe int SecretX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// IntProperty: SecretY
    /// </summary>
    public unsafe int SecretY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// IntProperty: SecretZ
    /// </summary>
    public unsafe int SecretZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// IntProperty: FloatUpAdjust
    /// </summary>
    public unsafe int FloatUpAdjust
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// StrProperty: SecretType
    /// </summary>
    public unsafe BmSDK.FString SecretType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// StrProperty: MapRevealPreventionFlag
    /// </summary>
    public unsafe BmSDK.FString MapRevealPreventionFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }
}
