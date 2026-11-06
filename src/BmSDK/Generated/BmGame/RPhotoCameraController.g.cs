#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPhotoCameraController<br/>
/// (size = 2672)
/// (flags = 144703638)
/// </summary>
public partial class RPhotoCameraController : BmSDK.Engine.DebugCameraController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPhotoCameraController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPhotoCameraController.
    /// </summary>
    public static RPhotoCameraController DefaultObject => (RPhotoCameraController)StaticClass().DefaultObject;

    internal RPhotoCameraController() { }

    /// <summary>
    /// Constructs a new RPhotoCameraController
    /// </summary>
    public RPhotoCameraController(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPhotoCameraController(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPhotoCameraController>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhotoCameraController>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPhotoCameraController>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhotoCameraController>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhotoCameraController>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhotoCameraController>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPhotoCameraController>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhotoCameraController>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_InitInputSystem;
    /// <summary>
    /// Function: InitInputSystem
    /// </summary>
    public unsafe override void InitInputSystem()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitInputSystem, "BmGame.RPhotoCameraController.InitInputSystem");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Teleport;
    /// <summary>
    /// Function: Teleport
    /// </summary>
    public unsafe virtual void Teleport()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Teleport, "BmGame.RPhotoCameraController.Teleport");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StoreSettings;
    /// <summary>
    /// Function: StoreSettings
    /// </summary>
    public unsafe virtual void StoreSettings()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StoreSettings, "BmGame.RPhotoCameraController.StoreSettings");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FetchSettings;
    /// <summary>
    /// Function: FetchSettings
    /// </summary>
    public unsafe virtual void FetchSettings()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FetchSettings, "BmGame.RPhotoCameraController.FetchSettings");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpSettings;
    /// <summary>
    /// Function: DumpSettings
    /// </summary>
    public unsafe virtual void DumpSettings()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpSettings, "BmGame.RPhotoCameraController.DumpSettings");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDefaultSettings;
    /// <summary>
    /// Function: SetDefaultSettings
    /// </summary>
    public unsafe virtual void SetDefaultSettings()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDefaultSettings, "BmGame.RPhotoCameraController.SetDefaultSettings");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PutSettings;
    /// <summary>
    /// Function: PutSettings
    /// </summary>
    public unsafe virtual void PutSettings(BmSDK.TArray<float> Settings)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PutSettings, "BmGame.RPhotoCameraController.PutSettings");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Settings, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_GetSettings;
    /// <summary>
    /// Function: GetSettings
    /// </summary>
    public unsafe virtual void GetSettings(out BmSDK.TArray<float> Settings)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSettings, "BmGame.RPhotoCameraController.GetSettings");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Settings = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<float>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_Set;
    /// <summary>
    /// Function: Set
    /// </summary>
    public unsafe virtual void Set(BmSDK.FString ItemName, float Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Set, "BmGame.RPhotoCameraController.Set");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Get;
    /// <summary>
    /// Function: Get
    /// </summary>
    public unsafe virtual float Get(BmSDK.FString ItemName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Get, "BmGame.RPhotoCameraController.Get");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_AdjustItem;
    /// <summary>
    /// Function: AdjustItem
    /// </summary>
    public unsafe virtual void AdjustItem(BmSDK.FString ItemName, float Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustItem, "BmGame.RPhotoCameraController.AdjustItem");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExposureFromUI;
    /// <summary>
    /// Function: ExposureFromUI
    /// </summary>
    public unsafe virtual float ExposureFromUI(float InValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExposureFromUI, "BmGame.RPhotoCameraController.ExposureFromUI");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ExposureToUI;
    /// <summary>
    /// Function: ExposureToUI
    /// </summary>
    public unsafe virtual float ExposureToUI(float InValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExposureToUI, "BmGame.RPhotoCameraController.ExposureToUI");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DofApertureFromUI;
    /// <summary>
    /// Function: DofApertureFromUI
    /// </summary>
    public unsafe virtual float DofApertureFromUI(float InValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DofApertureFromUI, "BmGame.RPhotoCameraController.DofApertureFromUI");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DofApertureToUI;
    /// <summary>
    /// Function: DofApertureToUI
    /// </summary>
    public unsafe virtual float DofApertureToUI(float InValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DofApertureToUI, "BmGame.RPhotoCameraController.DofApertureToUI");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ModifyMoveDeltaForOcean;
    /// <summary>
    /// Function: ModifyMoveDeltaForOcean
    /// </summary>
    public unsafe virtual void ModifyMoveDeltaForOcean(System.Numerics.Vector3 InitialLocation, out System.Numerics.Vector3 Delta)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyMoveDeltaForOcean, "BmGame.RPhotoCameraController.ModifyMoveDeltaForOcean");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Delta);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Delta = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_InitPlayerReplicationInfo;
    /// <summary>
    /// Function: InitPlayerReplicationInfo
    /// </summary>
    public unsafe override void InitPlayerReplicationInfo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitPlayerReplicationInfo, "BmGame.RPhotoCameraController.InitPlayerReplicationInfo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerTick;
    /// <summary>
    /// Function: PlayerTick
    /// </summary>
    public unsafe override void PlayerTick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerTick, "BmGame.RPhotoCameraController.PlayerTick");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Pause;
    /// <summary>
    /// Function: Pause
    /// </summary>
    public unsafe override void Pause()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Pause, "BmGame.RPhotoCameraController.Pause");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPlayersOnly;
    /// <summary>
    /// Function: SetPlayersOnly
    /// </summary>
    public unsafe virtual void SetPlayersOnly(bool bPlayersOnly)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayersOnly, "BmGame.RPhotoCameraController.SetPlayersOnly");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayersOnly, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDeactivate;
    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeactivate, "BmGame.RPhotoCameraController.OnDeactivate");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnActivate;
    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmGame.RPhotoCameraController.OnActivate");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RPhotoCameraController.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugUpdateCinematicCapes;
    /// <summary>
    /// Function: DebugUpdateCinematicCapes
    /// </summary>
    public unsafe virtual void DebugUpdateCinematicCapes()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugUpdateCinematicCapes, "BmGame.RPhotoCameraController.DebugUpdateCinematicCapes");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateBatmansCapeInternal;
    /// <summary>
    /// Function: UpdateBatmansCapeInternal
    /// </summary>
    public unsafe void UpdateBatmansCapeInternal(BmSDK.BmGame.RCapeComponent CapeComponent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateBatmansCapeInternal, "BmGame.RPhotoCameraController.UpdateBatmansCapeInternal");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CapeComponent, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_RegisterOnlineDelegates;
    /// <summary>
    /// Function: RegisterOnlineDelegates
    /// </summary>
    public unsafe override void RegisterOnlineDelegates()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterOnlineDelegates, "BmGame.RPhotoCameraController.RegisterOnlineDelegates");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InheritCurrentPPSettings;
    /// <summary>
    /// Function: InheritCurrentPPSettings
    /// </summary>
    public unsafe virtual void InheritCurrentPPSettings()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InheritCurrentPPSettings, "BmGame.RPhotoCameraController.InheritCurrentPPSettings");
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Enum: EPhotoMenuSettings
    /// </summary>
    public enum EPhotoMenuSettings : byte
    {
        PMS_CameraZoom = 0,
        PMS_CameraDistance = 1,
        PMS_CameraTilt = 2,
        PMS_DOFValue = 3,
        PMS_DOFDistance = 4,
        PMS_ImageExposure = 5,
        PMS_ImageBrightness = 6,
        PMS_FilterType = 7,
        PMS_FilterIntensity = 8,
        PMS_VignetteType = 9,
        PMS_VignetteIntensity = 10,
        PMS_FrameType = 11,
        PMS_FrameIntensity = 12,
        PMS_LogoPosition = 13,
        PMS_LogoScale = 14,
        PMS_MAX = 15,
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// ObjectProperty: TrackingActor
    /// </summary>
    public unsafe BmSDK.Engine.Pawn TrackingActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// ObjectProperty: OriginalColourLUT
    /// </summary>
    public unsafe BmSDK.Engine.Texture OriginalColourLUT
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// ObjectProperty: TargetFilter
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D TargetFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: Filter
    /// </summary>
    public InlineArray<BmSDK.Engine.Texture2D> Filter => new(11, Ptr + 1944, 8, this);

    /// <summary>
    /// ObjectProperty: Filter
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D Filter_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }
    /// <summary>
    /// ObjectProperty: Filter
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D Filter_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }
    /// <summary>
    /// ObjectProperty: Filter
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D Filter_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 1960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }
    }
    /// <summary>
    /// ObjectProperty: Filter
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D Filter_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 1968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }
    }
    /// <summary>
    /// ObjectProperty: Filter
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D Filter_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }
    /// <summary>
    /// ObjectProperty: Filter
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D Filter_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 1984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1984); }
    }
    /// <summary>
    /// ObjectProperty: Filter
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D Filter_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 1992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }
    }
    /// <summary>
    /// ObjectProperty: Filter
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D Filter_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }
    /// <summary>
    /// ObjectProperty: Filter
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D Filter_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 2008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2008); }
    }
    /// <summary>
    /// ObjectProperty: Filter
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D Filter_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 2016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2016); }
    }
    /// <summary>
    /// ObjectProperty: Filter
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D Filter_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// StructProperty: DOFSettings
    /// </summary>
    public unsafe ref BmSDK.Engine.PostProcessVolume.FPostProcessSettings DOFSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.PostProcessVolume.FPostProcessSettings>(Ptr + 2032);

    /// <summary>
    /// StructProperty: OrbitOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 OrbitOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2556);

    /// <summary>
    /// StructProperty: OrbitRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator OrbitRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2568);

    /// <summary>
    /// StructProperty: OrbitRotationOffset
    /// </summary>
    public unsafe ref BmSDK.Rotator OrbitRotationOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2580);

    /// <summary>
    /// FloatProperty: DesiredZoomSpeed
    /// </summary>
    public unsafe float DesiredZoomSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// FloatProperty: CurrentZoomSpeed
    /// </summary>
    public unsafe float CurrentZoomSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2596); }
    }

    /// <summary>
    /// FloatProperty: CameraDistance
    /// </summary>
    public unsafe float CameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// FloatProperty: DesiredRollAngle
    /// </summary>
    public unsafe float DesiredRollAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2604); }
    }

    /// <summary>
    /// FloatProperty: DesiredFOVAngle
    /// </summary>
    public unsafe float DesiredFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// FloatProperty: TargetCameraDistance
    /// </summary>
    public unsafe float TargetCameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// FloatProperty: TargetRollAngle
    /// </summary>
    public unsafe float TargetRollAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// FloatProperty: TargetDOFApertureStop
    /// </summary>
    public unsafe float TargetDOFApertureStop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2620); }
    }

    /// <summary>
    /// FloatProperty: TargetDOFFocusDistance
    /// </summary>
    public unsafe float TargetDOFFocusDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// FloatProperty: TargetDOFExposureBaseOffset
    /// </summary>
    public unsafe float TargetDOFExposureBaseOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }

    /// <summary>
    /// FloatProperty: InitialGamma
    /// </summary>
    public unsafe float InitialGamma
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }
    }

    /// <summary>
    /// FloatProperty: TargetFOVAngle
    /// </summary>
    public unsafe float TargetFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// BoolProperty: bOverrideDOF
    /// </summary>
    public unsafe bool bOverrideDOF
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2640) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2640); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2640); }
    }

    /// <summary>
    /// BoolProperty: bMovementDisabled
    /// </summary>
    public unsafe bool bMovementDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2640) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2640); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2640); }
    }

    /// <summary>
    /// BoolProperty: bZoomDisabled
    /// </summary>
    public unsafe bool bZoomDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2640) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2640); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2640); }
    }

    /// <summary>
    /// BoolProperty: bLeftMouseButtonPressed
    /// </summary>
    public unsafe bool bLeftMouseButtonPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2640) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2640); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2640); }
    }

    /// <summary>
    /// BoolProperty: bRightMouseButtonPressed
    /// </summary>
    public unsafe bool bRightMouseButtonPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2640) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2640); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2640); }
    }

    /// <summary>
    /// ArrayProperty: StoredSettings
    /// </summary>
    public unsafe BmSDK.TArray<float> StoredSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 2644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2644); }
    }

    /// <summary>
    /// StructProperty: TrackingOffset
    /// </summary>
    public unsafe ref BmSDK.Rotator TrackingOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2660);
}
