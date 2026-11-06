#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIInteraction<br/>
/// (size = 464)
/// (flags = 134217886)
/// </summary>
public partial class UIInteraction : BmSDK.Engine.Interaction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIInteraction", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as UIInteraction.
    /// </summary>
    public static UIInteraction DefaultObject => (UIInteraction)StaticClass().DefaultObject;

    internal UIInteraction() { }

    /// <summary>
    /// Constructs a new UIInteraction
    /// </summary>
    public UIInteraction(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIInteraction Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIInteraction(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIInteraction>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIInteraction>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIInteraction>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIInteraction>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIInteraction>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIInteraction>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIInteraction>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIInteraction>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_NotifyGameSessionEnded;
    /// <summary>
    /// Function: NotifyGameSessionEnded
    /// </summary>
    public unsafe override void NotifyGameSessionEnded()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyGameSessionEnded, "Engine.UIInteraction.NotifyGameSessionEnded");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNATType;
    /// <summary>
    /// Function: GetNATType
    /// </summary>
    public unsafe static BmSDK.Engine.OnlineSubsystem.ENATType GetNATType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNATType, "Engine.UIInteraction.GetNATType");
        byte* paramsPtr = stackalloc byte[29];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.ENATType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetConnectedGamepadCount;
    /// <summary>
    /// Function: GetConnectedGamepadCount
    /// </summary>
    public unsafe static int GetConnectedGamepadCount(BmSDK.TArray<bool> ControllerConnectionStatusOverrides = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetConnectedGamepadCount, "Engine.UIInteraction.GetConnectedGamepadCount");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerConnectionStatusOverrides, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsGamepadConnected;
    /// <summary>
    /// Function: IsGamepadConnected
    /// </summary>
    public unsafe static bool IsGamepadConnected(int ControllerId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGamepadConnected, "Engine.UIInteraction.IsGamepadConnected");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNumGuestsLoggedIn;
    /// <summary>
    /// Function: GetNumGuestsLoggedIn
    /// </summary>
    public unsafe static int GetNumGuestsLoggedIn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumGuestsLoggedIn, "Engine.UIInteraction.GetNumGuestsLoggedIn");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLoggedInPlayerCount;
    /// <summary>
    /// Function: GetLoggedInPlayerCount
    /// </summary>
    public unsafe static int GetLoggedInPlayerCount(bool bRequireOnlineLogin = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLoggedInPlayerCount, "Engine.UIInteraction.GetLoggedInPlayerCount");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRequireOnlineLogin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsLoggedIn;
    /// <summary>
    /// Function: IsLoggedIn
    /// </summary>
    public unsafe static bool IsLoggedIn(int ControllerId, bool bRequireOnlineLogin = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLoggedIn, "Engine.UIInteraction.IsLoggedIn");
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRequireOnlineLogin, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_HasLinkConnection;
    /// <summary>
    /// Function: HasLinkConnection
    /// </summary>
    public unsafe static bool HasLinkConnection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasLinkConnection, "Engine.UIInteraction.HasLinkConnection");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLowestLoginStatusOfControllers;
    /// <summary>
    /// Function: GetLowestLoginStatusOfControllers
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.ELoginStatus GetLowestLoginStatusOfControllers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLowestLoginStatusOfControllers, "Engine.UIInteraction.GetLowestLoginStatusOfControllers");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.ELoginStatus>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLoginStatus;
    /// <summary>
    /// Function: GetLoginStatus
    /// </summary>
    public unsafe static BmSDK.Engine.OnlineSubsystem.ELoginStatus GetLoginStatus(int ControllerId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLoginStatus, "Engine.UIInteraction.GetLoginStatus");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.ELoginStatus>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_NotifyPlayerRemoved;
    /// <summary>
    /// Function: NotifyPlayerRemoved
    /// </summary>
    public unsafe override void NotifyPlayerRemoved(int PlayerIndex, BmSDK.Engine.LocalPlayer RemovedPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPlayerRemoved, "Engine.UIInteraction.NotifyPlayerRemoved");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemovedPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPlayerAdded;
    /// <summary>
    /// Function: NotifyPlayerAdded
    /// </summary>
    public unsafe override void NotifyPlayerAdded(int PlayerIndex, BmSDK.Engine.LocalPlayer AddedPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPlayerAdded, "Engine.UIInteraction.NotifyPlayerAdded");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AddedPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLocalPlayer;
    /// <summary>
    /// Function: GetLocalPlayer
    /// </summary>
    public unsafe static BmSDK.Engine.LocalPlayer GetLocalPlayer(int PlayerIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalPlayer, "Engine.UIInteraction.GetLocalPlayer");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LocalPlayer>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDataStoreClient;
    /// <summary>
    /// Function: GetDataStoreClient
    /// </summary>
    public unsafe static BmSDK.Engine.DataStoreClient GetDataStoreClient()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDataStoreClient, "Engine.UIInteraction.GetDataStoreClient");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DataStoreClient>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPlayerControllerId;
    /// <summary>
    /// Function: GetPlayerControllerId
    /// </summary>
    public unsafe static int GetPlayerControllerId(int PlayerIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerControllerId, "Engine.UIInteraction.GetPlayerControllerId");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPlayerIndex;
    /// <summary>
    /// Function: GetPlayerIndex
    /// </summary>
    public unsafe static int GetPlayerIndex(int ControllerId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerIndex, "Engine.UIInteraction.GetPlayerIndex");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPlayerCount;
    /// <summary>
    /// Function: GetPlayerCount
    /// </summary>
    public unsafe static int GetPlayerCount()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerCount, "Engine.UIInteraction.GetPlayerCount");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Struct: FUIAxisEmulationData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FUIAxisEmulationData
    {
        /// <summary>
        /// BoolProperty: bEnabled
        /// </summary>
        public unsafe bool bEnabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FUIKeyRepeatData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FUIKeyRepeatData
    {
        /// <summary>
        /// NameProperty: CurrentRepeatKey
        /// </summary>
        public unsafe BmSDK.FName CurrentRepeatKey
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: NextRepeatTime
        /// </summary>
        public unsafe double NextRepeatTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<double>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// StructProperty: VfTable_FExec
    /// </summary>
    public unsafe System.IntPtr VfTable_FExec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: VfTable_FGlobalDataStoreClientManager
    /// </summary>
    public unsafe System.IntPtr VfTable_FGlobalDataStoreClientManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// StructProperty: VfTable_FCallbackEventDevice
    /// </summary>
    public unsafe System.IntPtr VfTable_FCallbackEventDevice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ObjectProperty: UIManager
    /// </summary>
    public unsafe BmSDK.Engine.UIManager UIManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIManager>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ObjectProperty: SceneClient
    /// </summary>
    public unsafe BmSDK.Engine.GameUISceneClient SceneClient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameUISceneClient>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ObjectProperty: DataStoreManager
    /// </summary>
    public unsafe BmSDK.Engine.DataStoreClient DataStoreManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DataStoreClient>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ClassProperty: SceneClientClass
    /// </summary>
    public unsafe BmSDK.Class SceneClientClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ClassProperty: UIManagerClass
    /// </summary>
    public unsafe BmSDK.Class UIManagerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ArrayProperty: SupportedDoubleClickKeys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> SupportedDoubleClickKeys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// BoolProperty: bProcessInput
    /// </summary>
    public unsafe bool bProcessInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 252); }
    }

    /// <summary>
    /// FloatProperty: UIJoystickDeadZone
    /// </summary>
    public unsafe float UIJoystickDeadZone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// FloatProperty: UIAxisMultiplier
    /// </summary>
    public unsafe float UIAxisMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: AxisRepeatDelay
    /// </summary>
    public unsafe float AxisRepeatDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// FloatProperty: MouseButtonRepeatDelay
    /// </summary>
    public unsafe float MouseButtonRepeatDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// FloatProperty: DoubleClickTriggerSeconds
    /// </summary>
    public unsafe float DoubleClickTriggerSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// IntProperty: DoubleClickPixelTolerance
    /// </summary>
    public unsafe int DoubleClickPixelTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// StructProperty: MouseButtonRepeatInfo
    /// </summary>
    public unsafe ref BmSDK.Engine.UIInteraction.FUIKeyRepeatData MouseButtonRepeatInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.UIInteraction.FUIKeyRepeatData>(Ptr + 280);

    /// <summary>
    /// ArrayProperty: ConfiguredAxisEmulationDefinitions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.UIRoot.FUIAxisEmulationDefinition> ConfiguredAxisEmulationDefinitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.UIRoot.FUIAxisEmulationDefinition>>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// MapProperty: AxisEmulationDefinitions
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ AxisEmulationDefinitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: AxisInputEmulation
    /// </summary>
    public InlineArray<BmSDK.Engine.UIInteraction.FUIAxisEmulationData> AxisInputEmulation => new(4, Ptr + 384, 20, this);

    /// <summary>
    /// StructProperty: AxisInputEmulation
    /// </summary>
    public unsafe ref BmSDK.Engine.UIInteraction.FUIAxisEmulationData AxisInputEmulation_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.UIInteraction.FUIAxisEmulationData>(Ptr + 384);
    /// <summary>
    /// StructProperty: AxisInputEmulation
    /// </summary>
    public unsafe ref BmSDK.Engine.UIInteraction.FUIAxisEmulationData AxisInputEmulation_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.UIInteraction.FUIAxisEmulationData>(Ptr + 404);
    /// <summary>
    /// StructProperty: AxisInputEmulation
    /// </summary>
    public unsafe ref BmSDK.Engine.UIInteraction.FUIAxisEmulationData AxisInputEmulation_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.UIInteraction.FUIAxisEmulationData>(Ptr + 424);
    /// <summary>
    /// StructProperty: AxisInputEmulation
    /// </summary>
    public unsafe ref BmSDK.Engine.UIInteraction.FUIAxisEmulationData AxisInputEmulation_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.UIInteraction.FUIAxisEmulationData>(Ptr + 444);
}
