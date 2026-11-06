#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AppNotificationsBase<br/>
/// (size = 192)
/// (flags = 134217882)
/// </summary>
public partial class AppNotificationsBase : BmSDK.Engine.PlatformInterfaceBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AppNotificationsBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as AppNotificationsBase.
    /// </summary>
    public static AppNotificationsBase DefaultObject => (AppNotificationsBase)StaticClass().DefaultObject;

    internal AppNotificationsBase() { }

    /// <summary>
    /// Constructs a new AppNotificationsBase
    /// </summary>
    public AppNotificationsBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AppNotificationsBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AppNotificationsBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AppNotificationsBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AppNotificationsBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AppNotificationsBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AppNotificationsBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AppNotificationsBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AppNotificationsBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AppNotificationsBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AppNotificationsBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DebugLogNotification;
    /// <summary>
    /// Function: DebugLogNotification
    /// </summary>
    public unsafe virtual void DebugLogNotification(out BmSDK.Engine.AppNotificationsBase.FNotificationInfo Notification)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugLogNotification, "Engine.AppNotificationsBase.DebugLogNotification");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Notification = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AppNotificationsBase.FNotificationInfo>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_OnReceivedRemoteNotification;
    /// <summary>
    /// Function: OnReceivedRemoteNotification
    /// </summary>
    public unsafe virtual void OnReceivedRemoteNotification(out BmSDK.Engine.AppNotificationsBase.FNotificationInfo Notification, bool bWasAppActive)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReceivedRemoteNotification, "Engine.AppNotificationsBase.OnReceivedRemoteNotification");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasAppActive, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Notification = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AppNotificationsBase.FNotificationInfo>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_OnReceivedLocalNotification;
    /// <summary>
    /// Function: OnReceivedLocalNotification
    /// </summary>
    public unsafe virtual void OnReceivedLocalNotification(out BmSDK.Engine.AppNotificationsBase.FNotificationInfo Notification, bool bWasAppActive)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReceivedLocalNotification, "Engine.AppNotificationsBase.OnReceivedLocalNotification");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasAppActive, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Notification = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AppNotificationsBase.FNotificationInfo>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_CancelAllScheduledLocalNotifications;
    /// <summary>
    /// Function: CancelAllScheduledLocalNotifications
    /// </summary>
    public unsafe virtual void CancelAllScheduledLocalNotifications()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelAllScheduledLocalNotifications, "Engine.AppNotificationsBase.CancelAllScheduledLocalNotifications");
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

    private static BmSDK.Function __fn_ScheduleLocalNotification;
    /// <summary>
    /// Function: ScheduleLocalNotification
    /// </summary>
    public unsafe virtual void ScheduleLocalNotification(out BmSDK.Engine.AppNotificationsBase.FNotificationInfo Notification, int StartOffsetSeconds)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScheduleLocalNotification, "Engine.AppNotificationsBase.ScheduleLocalNotification");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartOffsetSeconds, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Notification = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AppNotificationsBase.FNotificationInfo>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_WasLaunchedViaNotification;
    /// <summary>
    /// Function: WasLaunchedViaNotification
    /// </summary>
    public unsafe virtual bool WasLaunchedViaNotification()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WasLaunchedViaNotification, "Engine.AppNotificationsBase.WasLaunchedViaNotification");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "Engine.AppNotificationsBase.Init");
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
    /// StructProperty: AppLaunchNotification
    /// </summary>
    public unsafe ref BmSDK.Engine.AppNotificationsBase.FLaunchNotificationInfo AppLaunchNotification
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AppNotificationsBase.FLaunchNotificationInfo>(Ptr + 116);

    /// <summary>
    /// DelegateProperty: __OnReceivedLocalNotification__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReceivedLocalNotification__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// DelegateProperty: __OnReceivedRemoteNotification__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReceivedRemoteNotification__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// Struct: FLaunchNotificationInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FLaunchNotificationInfo
    {
        /// <summary>
        /// BoolProperty: bWasLaunchedViaNotification
        /// </summary>
        public unsafe bool bWasLaunchedViaNotification
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Notification
        /// </summary>
        public unsafe BmSDK.Engine.AppNotificationsBase.FNotificationInfo Notification
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AppNotificationsBase.FNotificationInfo>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FNotificationInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FNotificationInfo
    {
        /// <summary>
        /// BoolProperty: bIsLocal
        /// </summary>
        public unsafe bool bIsLocal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: MessageBody
        /// </summary>
        public unsafe BmSDK.FString MessageBody
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: BadgeNumber
        /// </summary>
        public unsafe int BadgeNumber
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ArrayProperty: MessageInfo
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.AppNotificationsBase.FNotificationMessageInfo> MessageInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AppNotificationsBase.FNotificationMessageInfo>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FNotificationMessageInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FNotificationMessageInfo
    {
        /// <summary>
        /// StrProperty: Key
        /// </summary>
        public unsafe BmSDK.FString Key
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Value
        /// </summary>
        public unsafe BmSDK.FString Value
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}
