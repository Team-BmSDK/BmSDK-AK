#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RJokerHallucinationFrequencyController<br/>
/// (size = 164)
/// (flags = 134217874)
/// </summary>
public partial class RJokerHallucinationFrequencyController : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RJokerHallucinationFrequencyController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RJokerHallucinationFrequencyController.
    /// </summary>
    public static RJokerHallucinationFrequencyController DefaultObject => (RJokerHallucinationFrequencyController)StaticClass().DefaultObject;

    internal RJokerHallucinationFrequencyController() { }

    /// <summary>
    /// Constructs a new RJokerHallucinationFrequencyController
    /// </summary>
    public RJokerHallucinationFrequencyController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RJokerHallucinationFrequencyController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RJokerHallucinationFrequencyController(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJokerHallucinationFrequencyController>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerHallucinationFrequencyController>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJokerHallucinationFrequencyController>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerHallucinationFrequencyController>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerHallucinationFrequencyController>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerHallucinationFrequencyController>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJokerHallucinationFrequencyController>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerHallucinationFrequencyController>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ShouldJokerHelpUpThug;
    /// <summary>
    /// Function: ShouldJokerHelpUpThug
    /// </summary>
    public unsafe virtual bool ShouldJokerHelpUpThug(BmSDK.BmGame.RPawnVillain Thug, BmSDK.FName TargetStance)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldJokerHelpUpThug, "BmGame.RJokerHallucinationFrequencyController.ShouldJokerHelpUpThug");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thug, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetStance, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_HelpUpThug;
    /// <summary>
    /// Function: HelpUpThug
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId HelpUpThug(BmSDK.BmGame.RPawnVillain Thug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HelpUpThug, "BmGame.RJokerHallucinationFrequencyController.HelpUpThug");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DoGenericSlavedJokerHallucination;
    /// <summary>
    /// Function: DoGenericSlavedJokerHallucination
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnJokerHallucination DoGenericSlavedJokerHallucination(BmSDK.BmGame.RPawnCharacter HostPawn, bool bIgnoreCollisionCheck, BmSDK.Rotator AngleOffset, System.Numerics.Vector3 refLoc, BmSDK.FName TransAnimName, BmSDK.FName idleAnimName, BmSDK.BmGame.RPawnJokerHallucination.TypesOfHallucination HallucinationType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoGenericSlavedJokerHallucination, "BmGame.RJokerHallucinationFrequencyController.DoGenericSlavedJokerHallucination");
        byte* paramsPtr = stackalloc byte[200];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HostPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreCollisionCheck, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngleOffset, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(refLoc, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransAnimName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(idleAnimName, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HallucinationType, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnJokerHallucination>(paramsPtr + 56);
    }

    private static BmSDK.Function __fn_SpawnJokerHallucination;
    /// <summary>
    /// Function: SpawnJokerHallucination
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnJokerHallucination SpawnJokerHallucination(BmSDK.BmGame.RCharacterDefine CustomDefine = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnJokerHallucination, "BmGame.RJokerHallucinationFrequencyController.SpawnJokerHallucination");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomDefine, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnJokerHallucination>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsSpaceForJokerAnimationCheckWholeAnim;
    /// <summary>
    /// Function: IsSpaceForJokerAnimationCheckWholeAnim
    /// </summary>
    public unsafe virtual bool IsSpaceForJokerAnimationCheckWholeAnim(BmSDK.BmGame.RAnimConfig.FCustomAnimConfig AnimConf, BmSDK.BmGame.RPawnCharacter TestPawn, float CheckDistance, System.Numerics.Vector3 refLoc, BmSDK.Rotator RefRot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSpaceForJokerAnimationCheckWholeAnim, "BmGame.RJokerHallucinationFrequencyController.IsSpaceForJokerAnimationCheckWholeAnim");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimConf, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDistance, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(refLoc, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RefRot, paramsPtr + 76);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 88);
    }

    private static BmSDK.Function __fn_IsSpaceForJokerAnimation;
    /// <summary>
    /// Function: IsSpaceForJokerAnimation
    /// </summary>
    public unsafe virtual bool IsSpaceForJokerAnimation(BmSDK.FName AnimName, BmSDK.Engine.Actor TestActor, float CheckDistance, System.Numerics.Vector3 TestLoc = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSpaceForJokerAnimation, "BmGame.RJokerHallucinationFrequencyController.IsSpaceForJokerAnimation");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDistance, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLoc, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetJokerHallucinationAnimSet;
    /// <summary>
    /// Function: GetJokerHallucinationAnimSet
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.Engine.AnimSet> GetJokerHallucinationAnimSet()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJokerHallucinationAnimSet, "BmGame.RJokerHallucinationFrequencyController.GetJokerHallucinationAnimSet");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.AnimSet>>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsJokerAnimationLoaded;
    /// <summary>
    /// Function: IsJokerAnimationLoaded
    /// </summary>
    public unsafe virtual bool IsJokerAnimationLoaded(BmSDK.FName AnimName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsJokerAnimationLoaded, "BmGame.RJokerHallucinationFrequencyController.IsJokerAnimationLoaded");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_JokerHallucinationsAllowed;
    /// <summary>
    /// Function: JokerHallucinationsAllowed
    /// </summary>
    public unsafe virtual bool JokerHallucinationsAllowed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JokerHallucinationsAllowed, "BmGame.RJokerHallucinationFrequencyController.JokerHallucinationsAllowed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetWorldInfo;
    /// <summary>
    /// Function: GetWorldInfo
    /// </summary>
    public unsafe virtual BmSDK.Engine.WorldInfo GetWorldInfo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWorldInfo, "BmGame.RJokerHallucinationFrequencyController.GetWorldInfo");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.WorldInfo>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasAnimBeenUsedRecently;
    /// <summary>
    /// Function: HasAnimBeenUsedRecently
    /// </summary>
    public unsafe virtual bool HasAnimBeenUsedRecently(BmSDK.BmGame.RPawnJokerHallucination.TypesOfHallucination AppearanceType, BmSDK.FName AnimationName, int NumHistoryToCheck)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasAnimBeenUsedRecently, "BmGame.RJokerHallucinationFrequencyController.HasAnimBeenUsedRecently");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AppearanceType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimationName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumHistoryToCheck, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_RegisterJokerAppearance;
    /// <summary>
    /// Function: RegisterJokerAppearance
    /// </summary>
    public unsafe virtual void RegisterJokerAppearance(BmSDK.BmGame.RPawnJokerHallucination.TypesOfHallucination AppearanceType, BmSDK.FName AnimationName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterJokerAppearance, "BmGame.RJokerHallucinationFrequencyController.RegisterJokerAppearance");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AppearanceType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimationName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIntialValues;
    /// <summary>
    /// Function: SetIntialValues
    /// </summary>
    public unsafe virtual void SetIntialValues()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIntialValues, "BmGame.RJokerHallucinationFrequencyController.SetIntialValues");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldSpawnJokerThisTime;
    /// <summary>
    /// Function: ShouldSpawnJokerThisTime
    /// </summary>
    public unsafe virtual bool ShouldSpawnJokerThisTime(BmSDK.BmGame.RPawnJokerHallucination.TypesOfHallucination AppearanceType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSpawnJokerThisTime, "BmGame.RJokerHallucinationFrequencyController.ShouldSpawnJokerThisTime");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AppearanceType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// ArrayProperty: ChanceOfJokerHallucinationByType
    /// </summary>
    public unsafe BmSDK.TArray<float> ChanceOfJokerHallucinationByType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: NumRequestsUntilActiveByType
    /// </summary>
    public unsafe BmSDK.TArray<int> NumRequestsUntilActiveByType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: AppearanceHistory
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RJokerHallucinationFrequencyController.FHallucinationAppearanceHistory> AppearanceHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RJokerHallucinationFrequencyController.FHallucinationAppearanceHistory>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// IntProperty: MaxHistory
    /// </summary>
    public unsafe int MaxHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: JokerHallucinationAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> JokerHallucinationAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ObjectProperty: JokerHallucinationCameras
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet JokerHallucinationCameras
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: bAllowMultipleJokers
    /// </summary>
    public unsafe bool bAllowMultipleJokers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bJokerCurrentlyActive
    /// </summary>
    public unsafe bool bJokerCurrentlyActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bHasSetInitialChance
    /// </summary>
    public unsafe bool bHasSetInitialChance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// Struct: FHallucinationAppearanceHistory
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FHallucinationAppearanceHistory
    {
        /// <summary>
        /// IntProperty: TimesAppeard
        /// </summary>
        public unsafe int TimesAppeard
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: AnimNames
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> AnimNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: TimeOfLastAppearance
        /// </summary>
        public unsafe float TimeOfLastAppearance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: MinTimeBetweenAppearances
        /// </summary>
        public unsafe float MinTimeBetweenAppearances
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }
}
